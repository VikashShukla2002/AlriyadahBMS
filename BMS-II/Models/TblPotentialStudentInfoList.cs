namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblPotentialStudentInfoList
    /// </summary>
    public static TblPotentialStudentInfoList tblPotentialStudentInfoList
    {
        get => HttpData.Get<TblPotentialStudentInfoList>("tblPotentialStudentInfoList")!;
        set => HttpData["tblPotentialStudentInfoList"] = value;
    }

    /// <summary>
    /// Page class for tblPotentialStudentInfo
    /// </summary>
    public class TblPotentialStudentInfoList : TblPotentialStudentInfoListBase
    {
        // Constructor
        public TblPotentialStudentInfoList(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblPotentialStudentInfoList() : base()
        {
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
    public class TblPotentialStudentInfoListBase : TblPotentialStudentInfo
    {
        // Page ID
        public string PageID = "list";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblPotentialStudentInfo";

        // Page object name
        public string PageObjName = "tblPotentialStudentInfoList";

        // Title
        public string? Title = null; // Title for <title> tag

        // Grid form hidden field names
        public string FormName = "ftblPotentialStudentInfolist";

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
        public TblPotentialStudentInfoListBase()
        {
            // CSS class name as context
            TableVar = "tblPotentialStudentInfo";
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

            // Table object (tblPotentialStudentInfo)
            if (tblPotentialStudentInfo == null || tblPotentialStudentInfo is TblPotentialStudentInfo)
                tblPotentialStudentInfo = this;

            // Initialize URLs
            AddUrl = "TblPotentialStudentInfoAdd?" + Config.TableShowDetail + "=";
            InlineAddUrl = PageUrl + "action=add";
            GridAddUrl = PageUrl + "action=gridadd";
            GridEditUrl = PageUrl + "action=gridedit";
            MultiEditUrl = PageUrl + "action=multiedit";
            MultiDeleteUrl = "TblPotentialStudentInfoDelete";
            MultiUpdateUrl = "TblPotentialStudentInfoUpdate";

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
        public string PageName => "TblPotentialStudentInfoList";

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
            int_Potential_Student_ID.Visible = false;
            int_Student_Id.Visible = false;
            str_NationalID_Iqama.Visible = false;
            NationalID.SetVisibility();
            str_First_Name.SetVisibility();
            str_Middle_Name.Visible = false;
            str_Last_Name.SetVisibility();
            str_Address1.Visible = false;
            str_Address2.Visible = false;
            int_State.Visible = false;
            str_City.Visible = false;
            str_Zip.Visible = false;
            int_Instructor.Visible = false;
            int_Driver.Visible = false;
            str_Home_Phone.Visible = false;
            str_Cell_Phone.SetVisibility();
            str_Parent_Phone.Visible = false;
            str_Other_Phone.Visible = false;
            str_Email.Visible = false;
            str_ParentName.Visible = false;
            str_ParentEmail1.Visible = false;
            str_ParentEmail2.Visible = false;
            str_Username.Visible = false;
            str_Password.Visible = false;
            str_DOB.Visible = false;
            int_DOB_Day.Visible = false;
            int_DOB_Month.Visible = false;
            int_DOB_Year.Visible = false;
            int_Age.Visible = false;
            int_Type.Visible = false;
            int_Wear_Glasses.Visible = false;
            int_Sex.Visible = false;
            str_DLPermit.Visible = false;
            dt_Date_PermitIssue.Visible = false;
            dt_Date_ExpirePermit.Visible = false;
            int_Hs_ID.Visible = false;
            str_Emergency_Contact_Name.Visible = false;
            str_Emergency_Contact_Phone.Visible = false;
            str_Emergency_Contact_Relation.Visible = false;
            str_Student_Notes.Visible = false;
            str_Driving_Notes.Visible = false;
            int_Location_Id.Visible = false;
            int_Permit_Number.Visible = false;
            Permit_Issue_Date.Visible = false;
            Permit_Expiry_Date.Visible = false;
            int_Status.Visible = false;
            int_Lead_Id.Visible = false;
            int_Activated_By.Visible = false;
            date_Activated.Visible = false;
            date_Created.Visible = false;
            date_Modified.Visible = false;
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
            strSMSNotification.Visible = false;
            strVoiceNotification.Visible = false;
            str_Weight.Visible = false;
            str_SpecialNeeds.Visible = false;
            str_MedicalConditions.Visible = false;
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
            int_Nationality.Visible = false;
            str_National_ID_en.Visible = false;
            str_National_ID_arabic.Visible = false;
            Quallification_Id.Visible = false;
            Job_Id.Visible = false;
            str_DOB_arabic.Visible = false;
            int_Language.Visible = false;
            strRefId.Visible = false;
            int_Program_Id.Visible = false;
            IsDrivingexperience.Visible = false;
            IsScheduleassessment.Visible = false;
            IsEnrollbyyourself.Visible = false;
            AssessmentTime.Visible = false;
            AssessmentDate.Visible = false;
            isAssessmentDone.Visible = false;
            AssessmentScore.Visible = false;
            dt_WrittenTestPassed.Visible = false;
            dt_RoadTestPassed.Visible = false;
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
            Absher_Appointment_number.Visible = false;
            DataImportId.Visible = false;
            date_Birth_Hijri.Visible = false;
            UserlevelID.Visible = false;
            Activated.Visible = false;
            Absherphoto.Visible = false;
            Fingerprint.Visible = false;
            Required_Program.SetVisibility();
            Price.SetVisibility();
            Hijri_Day.Visible = false;
            Hijri_Month.Visible = false;
            Hijri_Year.Visible = false;
            Course_Price.Visible = false;
            Vat_Tax_15.Visible = false;
            dec_Balance.Visible = false;
            Total_Price.Visible = false;
            Payment_Online.SetVisibility();
            Institution.Visible = false;
            WaitingList.Visible = false;
            Assessment_ID.Visible = false;
        }

        // Constructor
        public TblPotentialStudentInfoListBase(Controller? controller = null): this() { // DN
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

            // Setup other options
            SetupOtherOptions();

            // Set up custom action (compatible with old version)
            ListActions.Add(CustomActions);

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

            // Update form name to avoid conflict
            if (IsModal)
                FormName = "ftblPotentialStudentInfogrid";

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
            AddFilter(ref filter, DbDetailFilter);
            AddFilter(ref filter, SearchWhere);

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
                tblPotentialStudentInfoList?.PageRender();
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
                savedFilterList = await Profile.GetSearchFilters(CurrentUserName(), "ftblPotentialStudentInfosrch");

            // Initialize
            var filters = new JObject(); // DN
            filters.Merge(JObject.Parse(int_Potential_Student_ID.AdvancedSearch.ToJson())); // Field int_Potential_Student_ID
            filters.Merge(JObject.Parse(int_Student_Id.AdvancedSearch.ToJson())); // Field int_Student_Id
            filters.Merge(JObject.Parse(str_NationalID_Iqama.AdvancedSearch.ToJson())); // Field str_NationalID_Iqama
            filters.Merge(JObject.Parse(NationalID.AdvancedSearch.ToJson())); // Field NationalID
            filters.Merge(JObject.Parse(str_First_Name.AdvancedSearch.ToJson())); // Field str_First_Name
            filters.Merge(JObject.Parse(str_Middle_Name.AdvancedSearch.ToJson())); // Field str_Middle_Name
            filters.Merge(JObject.Parse(str_Last_Name.AdvancedSearch.ToJson())); // Field str_Last_Name
            filters.Merge(JObject.Parse(str_Address1.AdvancedSearch.ToJson())); // Field str_Address1
            filters.Merge(JObject.Parse(str_Address2.AdvancedSearch.ToJson())); // Field str_Address2
            filters.Merge(JObject.Parse(int_State.AdvancedSearch.ToJson())); // Field int_State
            filters.Merge(JObject.Parse(str_City.AdvancedSearch.ToJson())); // Field str_City
            filters.Merge(JObject.Parse(str_Zip.AdvancedSearch.ToJson())); // Field str_Zip
            filters.Merge(JObject.Parse(int_Instructor.AdvancedSearch.ToJson())); // Field int_Instructor
            filters.Merge(JObject.Parse(int_Driver.AdvancedSearch.ToJson())); // Field int_Driver
            filters.Merge(JObject.Parse(str_Home_Phone.AdvancedSearch.ToJson())); // Field str_Home_Phone
            filters.Merge(JObject.Parse(str_Cell_Phone.AdvancedSearch.ToJson())); // Field str_Cell_Phone
            filters.Merge(JObject.Parse(str_Parent_Phone.AdvancedSearch.ToJson())); // Field str_Parent_Phone
            filters.Merge(JObject.Parse(str_Other_Phone.AdvancedSearch.ToJson())); // Field str_Other_Phone
            filters.Merge(JObject.Parse(str_Email.AdvancedSearch.ToJson())); // Field str_Email
            filters.Merge(JObject.Parse(str_ParentName.AdvancedSearch.ToJson())); // Field str_ParentName
            filters.Merge(JObject.Parse(str_ParentEmail1.AdvancedSearch.ToJson())); // Field str_ParentEmail1
            filters.Merge(JObject.Parse(str_ParentEmail2.AdvancedSearch.ToJson())); // Field str_ParentEmail2
            filters.Merge(JObject.Parse(str_Username.AdvancedSearch.ToJson())); // Field str_Username
            filters.Merge(JObject.Parse(str_Password.AdvancedSearch.ToJson())); // Field str_Password
            filters.Merge(JObject.Parse(str_DOB.AdvancedSearch.ToJson())); // Field str_DOB
            filters.Merge(JObject.Parse(int_DOB_Day.AdvancedSearch.ToJson())); // Field int_DOB_Day
            filters.Merge(JObject.Parse(int_DOB_Month.AdvancedSearch.ToJson())); // Field int_DOB_Month
            filters.Merge(JObject.Parse(int_DOB_Year.AdvancedSearch.ToJson())); // Field int_DOB_Year
            filters.Merge(JObject.Parse(int_Age.AdvancedSearch.ToJson())); // Field int_Age
            filters.Merge(JObject.Parse(int_Type.AdvancedSearch.ToJson())); // Field int_Type
            filters.Merge(JObject.Parse(int_Wear_Glasses.AdvancedSearch.ToJson())); // Field int_Wear_Glasses
            filters.Merge(JObject.Parse(int_Sex.AdvancedSearch.ToJson())); // Field int_Sex
            filters.Merge(JObject.Parse(str_DLPermit.AdvancedSearch.ToJson())); // Field str_DLPermit
            filters.Merge(JObject.Parse(dt_Date_PermitIssue.AdvancedSearch.ToJson())); // Field dt_Date_PermitIssue
            filters.Merge(JObject.Parse(dt_Date_ExpirePermit.AdvancedSearch.ToJson())); // Field dt_Date_ExpirePermit
            filters.Merge(JObject.Parse(int_Hs_ID.AdvancedSearch.ToJson())); // Field int_Hs_ID
            filters.Merge(JObject.Parse(str_Emergency_Contact_Name.AdvancedSearch.ToJson())); // Field str_Emergency_Contact_Name
            filters.Merge(JObject.Parse(str_Emergency_Contact_Phone.AdvancedSearch.ToJson())); // Field str_Emergency_Contact_Phone
            filters.Merge(JObject.Parse(str_Emergency_Contact_Relation.AdvancedSearch.ToJson())); // Field str_Emergency_Contact_Relation
            filters.Merge(JObject.Parse(str_Student_Notes.AdvancedSearch.ToJson())); // Field str_Student_Notes
            filters.Merge(JObject.Parse(str_Driving_Notes.AdvancedSearch.ToJson())); // Field str_Driving_Notes
            filters.Merge(JObject.Parse(int_Location_Id.AdvancedSearch.ToJson())); // Field int_Location_Id
            filters.Merge(JObject.Parse(int_Permit_Number.AdvancedSearch.ToJson())); // Field int_Permit_Number
            filters.Merge(JObject.Parse(Permit_Issue_Date.AdvancedSearch.ToJson())); // Field Permit_Issue_Date
            filters.Merge(JObject.Parse(Permit_Expiry_Date.AdvancedSearch.ToJson())); // Field Permit_Expiry_Date
            filters.Merge(JObject.Parse(int_Status.AdvancedSearch.ToJson())); // Field int_Status
            filters.Merge(JObject.Parse(int_Lead_Id.AdvancedSearch.ToJson())); // Field int_Lead_Id
            filters.Merge(JObject.Parse(int_Activated_By.AdvancedSearch.ToJson())); // Field int_Activated_By
            filters.Merge(JObject.Parse(date_Activated.AdvancedSearch.ToJson())); // Field date_Activated
            filters.Merge(JObject.Parse(date_Created.AdvancedSearch.ToJson())); // Field date_Created
            filters.Merge(JObject.Parse(date_Modified.AdvancedSearch.ToJson())); // Field date_Modified
            filters.Merge(JObject.Parse(date_Complete.AdvancedSearch.ToJson())); // Field date_Complete
            filters.Merge(JObject.Parse(int_Created_By.AdvancedSearch.ToJson())); // Field int_Created_By
            filters.Merge(JObject.Parse(int_Modified_By.AdvancedSearch.ToJson())); // Field int_Modified_By
            filters.Merge(JObject.Parse(bit_IsDeleted.AdvancedSearch.ToJson())); // Field bit_IsDeleted
            filters.Merge(JObject.Parse(str_CardHolderName.AdvancedSearch.ToJson())); // Field str_CardHolderName
            filters.Merge(JObject.Parse(str_CardHolderAddress.AdvancedSearch.ToJson())); // Field str_CardHolderAddress
            filters.Merge(JObject.Parse(str_CardHolderCity.AdvancedSearch.ToJson())); // Field str_CardHolderCity
            filters.Merge(JObject.Parse(str_CardHolderZip.AdvancedSearch.ToJson())); // Field str_CardHolderZip
            filters.Merge(JObject.Parse(str_CardType.AdvancedSearch.ToJson())); // Field str_CardType
            filters.Merge(JObject.Parse(str_CardExpMonth.AdvancedSearch.ToJson())); // Field str_CardExpMonth
            filters.Merge(JObject.Parse(str_CardExpYear.AdvancedSearch.ToJson())); // Field str_CardExpYear
            filters.Merge(JObject.Parse(str_CardNo.AdvancedSearch.ToJson())); // Field str_CardNo
            filters.Merge(JObject.Parse(str_Certificate_No.AdvancedSearch.ToJson())); // Field str_Certificate_No
            filters.Merge(JObject.Parse(str_AmountPaid.AdvancedSearch.ToJson())); // Field str_AmountPaid
            filters.Merge(JObject.Parse(str_PermitValidated.AdvancedSearch.ToJson())); // Field str_PermitValidated
            filters.Merge(JObject.Parse(strSMSNotification.AdvancedSearch.ToJson())); // Field strSMSNotification
            filters.Merge(JObject.Parse(strVoiceNotification.AdvancedSearch.ToJson())); // Field strVoiceNotification
            filters.Merge(JObject.Parse(str_Weight.AdvancedSearch.ToJson())); // Field str_Weight
            filters.Merge(JObject.Parse(str_SpecialNeeds.AdvancedSearch.ToJson())); // Field str_SpecialNeeds
            filters.Merge(JObject.Parse(str_MedicalConditions.AdvancedSearch.ToJson())); // Field str_MedicalConditions
            filters.Merge(JObject.Parse(bit_Verified_PIC_InSAW.AdvancedSearch.ToJson())); // Field bit_Verified_PIC_InSAW
            filters.Merge(JObject.Parse(bit_Permit_Waiver_Entered.AdvancedSearch.ToJson())); // Field bit_Permit_Waiver_Entered
            filters.Merge(JObject.Parse(bit_TermsConditions.AdvancedSearch.ToJson())); // Field bit_TermsConditions
            filters.Merge(JObject.Parse(bit_Disable_Self_Scheduling.AdvancedSearch.ToJson())); // Field bit_Disable_Self_Scheduling
            filters.Merge(JObject.Parse(int_EyeColor.AdvancedSearch.ToJson())); // Field int_EyeColor
            filters.Merge(JObject.Parse(int_HairColor.AdvancedSearch.ToJson())); // Field int_HairColor
            filters.Merge(JObject.Parse(int_ColorBlind.AdvancedSearch.ToJson())); // Field int_ColorBlind
            filters.Merge(JObject.Parse(int_HeightFeet.AdvancedSearch.ToJson())); // Field int_HeightFeet
            filters.Merge(JObject.Parse(int_HeightInches.AdvancedSearch.ToJson())); // Field int_HeightInches
            filters.Merge(JObject.Parse(str_reference_code.AdvancedSearch.ToJson())); // Field str_reference_code
            filters.Merge(JObject.Parse(dt_ParentClassAttendedDt.AdvancedSearch.ToJson())); // Field dt_ParentClassAttendedDt
            filters.Merge(JObject.Parse(str_ParentClassAttendedLoc.AdvancedSearch.ToJson())); // Field str_ParentClassAttendedLoc
            filters.Merge(JObject.Parse(dt_SiblingClassAttendedDt.AdvancedSearch.ToJson())); // Field dt_SiblingClassAttendedDt
            filters.Merge(JObject.Parse(str_SiblingClassAttendedLoc.AdvancedSearch.ToJson())); // Field str_SiblingClassAttendedLoc
            filters.Merge(JObject.Parse(bit_PoliciesAndProcedures.AdvancedSearch.ToJson())); // Field bit_PoliciesAndProcedures
            filters.Merge(JObject.Parse(dt_CourseCompletionDt.AdvancedSearch.ToJson())); // Field dt_CourseCompletionDt
            filters.Merge(JObject.Parse(dt_ExtensionDt.AdvancedSearch.ToJson())); // Field dt_ExtensionDt
            filters.Merge(JObject.Parse(str_MedicalCondition.AdvancedSearch.ToJson())); // Field str_MedicalCondition
            filters.Merge(JObject.Parse(str_MajorCrossStreets.AdvancedSearch.ToJson())); // Field str_MajorCrossStreets
            filters.Merge(JObject.Parse(str_DriverEdCertNo.AdvancedSearch.ToJson())); // Field str_DriverEdCertNo
            filters.Merge(JObject.Parse(dt_DriverEdCertIssuedDt.AdvancedSearch.ToJson())); // Field dt_DriverEdCertIssuedDt
            filters.Merge(JObject.Parse(str_BTWDriversEdCertNo.AdvancedSearch.ToJson())); // Field str_BTWDriversEdCertNo
            filters.Merge(JObject.Parse(dt_BTWCertIssuedDt.AdvancedSearch.ToJson())); // Field dt_BTWCertIssuedDt
            filters.Merge(JObject.Parse(str_OLDriversEdCertNo.AdvancedSearch.ToJson())); // Field str_OLDriversEdCertNo
            filters.Merge(JObject.Parse(dt_OLCertIssuedDt.AdvancedSearch.ToJson())); // Field dt_OLCertIssuedDt
            filters.Merge(JObject.Parse(str_height.AdvancedSearch.ToJson())); // Field str_height
            filters.Merge(JObject.Parse(dt_BTWCompletionDt.AdvancedSearch.ToJson())); // Field dt_BTWCompletionDt
            filters.Merge(JObject.Parse(dt_CRCompletionDt.AdvancedSearch.ToJson())); // Field dt_CRCompletionDt
            filters.Merge(JObject.Parse(strTextBox5.AdvancedSearch.ToJson())); // Field strTextBox5
            filters.Merge(JObject.Parse(strTextBox6.AdvancedSearch.ToJson())); // Field strTextBox6
            filters.Merge(JObject.Parse(str_ApartmentNo.AdvancedSearch.ToJson())); // Field str_ApartmentNo
            filters.Merge(JObject.Parse(dt_PermitTestDate.AdvancedSearch.ToJson())); // Field dt_PermitTestDate
            filters.Merge(JObject.Parse(str_OnlineDriverEdLogin.AdvancedSearch.ToJson())); // Field str_OnlineDriverEdLogin
            filters.Merge(JObject.Parse(str_OnlineDriverEdPassword.AdvancedSearch.ToJson())); // Field str_OnlineDriverEdPassword
            filters.Merge(JObject.Parse(bit_IsSMSEnabled.AdvancedSearch.ToJson())); // Field bit_IsSMSEnabled
            filters.Merge(JObject.Parse(dt_SMSModified.AdvancedSearch.ToJson())); // Field dt_SMSModified
            filters.Merge(JObject.Parse(str_confirmPassword.AdvancedSearch.ToJson())); // Field str_confirmPassword
            filters.Merge(JObject.Parse(DE_Certificate.AdvancedSearch.ToJson())); // Field DE_Certificate
            filters.Merge(JObject.Parse(Discuss.AdvancedSearch.ToJson())); // Field Discuss
            filters.Merge(JObject.Parse(int_UnlicensedSibling.AdvancedSearch.ToJson())); // Field int_UnlicensedSibling
            filters.Merge(JObject.Parse(int_YearSiblingIsEligible.AdvancedSearch.ToJson())); // Field int_YearSiblingIsEligible
            filters.Merge(JObject.Parse(BTW_Certificate.AdvancedSearch.ToJson())); // Field BTW_Certificate
            filters.Merge(JObject.Parse(dt_DECertIssueDate.AdvancedSearch.ToJson())); // Field dt_DECertIssueDate
            filters.Merge(JObject.Parse(str_StudentSignature.AdvancedSearch.ToJson())); // Field str_StudentSignature
            filters.Merge(JObject.Parse(str_ParentSignature.AdvancedSearch.ToJson())); // Field str_ParentSignature
            filters.Merge(JObject.Parse(str_Last6DigitsOfParentDriversLicense.AdvancedSearch.ToJson())); // Field str_Last6DigitsOfParentDriversLicense
            filters.Merge(JObject.Parse(str_FACControl.AdvancedSearch.ToJson())); // Field str_FACControl
            filters.Merge(JObject.Parse(Classroom_Status_Code.AdvancedSearch.ToJson())); // Field Classroom_Status_Code
            filters.Merge(JObject.Parse(Laboratory_Status_Code.AdvancedSearch.ToJson())); // Field Laboratory_Status_Code
            filters.Merge(JObject.Parse(bit_EnrollmentForm.AdvancedSearch.ToJson())); // Field bit_EnrollmentForm
            filters.Merge(JObject.Parse(bit_ParentStudentContract.AdvancedSearch.ToJson())); // Field bit_ParentStudentContract
            filters.Merge(JObject.Parse(bit_ParentalAgreement.AdvancedSearch.ToJson())); // Field bit_ParentalAgreement
            filters.Merge(JObject.Parse(int_SF_GR_WA_HS.AdvancedSearch.ToJson())); // Field int_SF_GR_WA_HS
            filters.Merge(JObject.Parse(bit_DisableOnRMV.AdvancedSearch.ToJson())); // Field bit_DisableOnRMV
            filters.Merge(JObject.Parse(bit_UploadedToRMV.AdvancedSearch.ToJson())); // Field bit_UploadedToRMV
            filters.Merge(JObject.Parse(str_Mother_Name.AdvancedSearch.ToJson())); // Field str_Mother_Name
            filters.Merge(JObject.Parse(str_Guardians_Name.AdvancedSearch.ToJson())); // Field str_Guardians_Name
            filters.Merge(JObject.Parse(str_Mother_Phone.AdvancedSearch.ToJson())); // Field str_Mother_Phone
            filters.Merge(JObject.Parse(bit_terms.AdvancedSearch.ToJson())); // Field bit_terms
            filters.Merge(JObject.Parse(int_Nationality.AdvancedSearch.ToJson())); // Field int_Nationality
            filters.Merge(JObject.Parse(str_National_ID_en.AdvancedSearch.ToJson())); // Field str_National_ID_en
            filters.Merge(JObject.Parse(str_National_ID_arabic.AdvancedSearch.ToJson())); // Field str_National_ID_arabic
            filters.Merge(JObject.Parse(Quallification_Id.AdvancedSearch.ToJson())); // Field Quallification_Id
            filters.Merge(JObject.Parse(Job_Id.AdvancedSearch.ToJson())); // Field Job_Id
            filters.Merge(JObject.Parse(str_DOB_arabic.AdvancedSearch.ToJson())); // Field str_DOB_arabic
            filters.Merge(JObject.Parse(int_Language.AdvancedSearch.ToJson())); // Field int_Language
            filters.Merge(JObject.Parse(strRefId.AdvancedSearch.ToJson())); // Field strRefId
            filters.Merge(JObject.Parse(int_Program_Id.AdvancedSearch.ToJson())); // Field int_Program_Id
            filters.Merge(JObject.Parse(IsDrivingexperience.AdvancedSearch.ToJson())); // Field IsDrivingexperience
            filters.Merge(JObject.Parse(IsScheduleassessment.AdvancedSearch.ToJson())); // Field IsScheduleassessment
            filters.Merge(JObject.Parse(IsEnrollbyyourself.AdvancedSearch.ToJson())); // Field IsEnrollbyyourself
            filters.Merge(JObject.Parse(AssessmentTime.AdvancedSearch.ToJson())); // Field AssessmentTime
            filters.Merge(JObject.Parse(AssessmentDate.AdvancedSearch.ToJson())); // Field AssessmentDate
            filters.Merge(JObject.Parse(isAssessmentDone.AdvancedSearch.ToJson())); // Field isAssessmentDone
            filters.Merge(JObject.Parse(AssessmentScore.AdvancedSearch.ToJson())); // Field AssessmentScore
            filters.Merge(JObject.Parse(dt_WrittenTestPassed.AdvancedSearch.ToJson())); // Field dt_WrittenTestPassed
            filters.Merge(JObject.Parse(dt_RoadTestPassed.AdvancedSearch.ToJson())); // Field dt_RoadTestPassed
            filters.Merge(JObject.Parse(bit_Archive.AdvancedSearch.ToJson())); // Field bit_Archive
            filters.Merge(JObject.Parse(ArchiveNotes.AdvancedSearch.ToJson())); // Field ArchiveNotes
            filters.Merge(JObject.Parse(dtArchived.AdvancedSearch.ToJson())); // Field dtArchived
            filters.Merge(JObject.Parse(SrNo9Dec21.AdvancedSearch.ToJson())); // Field SrNo9Dec21
            filters.Merge(JObject.Parse(REGNNUMB.AdvancedSearch.ToJson())); // Field REGNNUMB
            filters.Merge(JObject.Parse(REGNLOCN.AdvancedSearch.ToJson())); // Field REGNLOCN
            filters.Merge(JObject.Parse(SrNo11DecF1S1.AdvancedSearch.ToJson())); // Field SrNo11DecF1S1
            filters.Merge(JObject.Parse(IsInterestedInTraining.AdvancedSearch.ToJson())); // Field IsInterestedInTraining
            filters.Merge(JObject.Parse(StudentEncryptID.AdvancedSearch.ToJson())); // Field StudentEncryptID
            filters.Merge(JObject.Parse(StudentConfirURL.AdvancedSearch.ToJson())); // Field StudentConfirURL
            filters.Merge(JObject.Parse(SrNo15DecF1S2.AdvancedSearch.ToJson())); // Field SrNo15DecF1S2
            filters.Merge(JObject.Parse(SrNo15DecF1S3.AdvancedSearch.ToJson())); // Field SrNo15DecF1S3
            filters.Merge(JObject.Parse(SrNo16DecF2S2.AdvancedSearch.ToJson())); // Field SrNo16DecF2S2
            filters.Merge(JObject.Parse(SrNo16DecF2S3.AdvancedSearch.ToJson())); // Field SrNo16DecF2S3
            filters.Merge(JObject.Parse(SrNo16DecF3S1.AdvancedSearch.ToJson())); // Field SrNo16DecF3S1
            filters.Merge(JObject.Parse(SrNo16DecF3S2.AdvancedSearch.ToJson())); // Field SrNo16DecF3S2
            filters.Merge(JObject.Parse(SrNo16DecF4S1.AdvancedSearch.ToJson())); // Field SrNo16DecF4S1
            filters.Merge(JObject.Parse(SrNo16DecF4S2.AdvancedSearch.ToJson())); // Field SrNo16DecF4S2
            filters.Merge(JObject.Parse(SrNo16DecF4S3.AdvancedSearch.ToJson())); // Field SrNo16DecF4S3
            filters.Merge(JObject.Parse(StudentAssementBookingURL.AdvancedSearch.ToJson())); // Field StudentAssementBookingURL
            filters.Merge(JObject.Parse(intDrivinglicenseType.AdvancedSearch.ToJson())); // Field intDrivinglicenseType
            filters.Merge(JObject.Parse(Isdrivinglicense.AdvancedSearch.ToJson())); // Field Isdrivinglicense
            filters.Merge(JObject.Parse(drivinglicensenumber.AdvancedSearch.ToJson())); // Field drivinglicensenumber
            filters.Merge(JObject.Parse(Absher_Appointment_number.AdvancedSearch.ToJson())); // Field Absher_Appointment_number
            filters.Merge(JObject.Parse(DataImportId.AdvancedSearch.ToJson())); // Field DataImportId
            filters.Merge(JObject.Parse(date_Birth_Hijri.AdvancedSearch.ToJson())); // Field date_Birth_Hijri
            filters.Merge(JObject.Parse(UserlevelID.AdvancedSearch.ToJson())); // Field UserlevelID
            filters.Merge(JObject.Parse(Activated.AdvancedSearch.ToJson())); // Field Activated
            filters.Merge(JObject.Parse(Absherphoto.AdvancedSearch.ToJson())); // Field Absherphoto
            filters.Merge(JObject.Parse(Fingerprint.AdvancedSearch.ToJson())); // Field Fingerprint
            filters.Merge(JObject.Parse(Required_Program.AdvancedSearch.ToJson())); // Field Required_Program
            filters.Merge(JObject.Parse(Price.AdvancedSearch.ToJson())); // Field Price
            filters.Merge(JObject.Parse(Hijri_Day.AdvancedSearch.ToJson())); // Field Hijri_Day
            filters.Merge(JObject.Parse(Hijri_Month.AdvancedSearch.ToJson())); // Field Hijri_Month
            filters.Merge(JObject.Parse(Hijri_Year.AdvancedSearch.ToJson())); // Field Hijri_Year
            filters.Merge(JObject.Parse(Course_Price.AdvancedSearch.ToJson())); // Field Course_Price
            filters.Merge(JObject.Parse(Vat_Tax_15.AdvancedSearch.ToJson())); // Field Vat_Tax_15
            filters.Merge(JObject.Parse(dec_Balance.AdvancedSearch.ToJson())); // Field dec_Balance
            filters.Merge(JObject.Parse(Total_Price.AdvancedSearch.ToJson())); // Field Total_Price
            filters.Merge(JObject.Parse(Payment_Online.AdvancedSearch.ToJson())); // Field Payment_Online
            filters.Merge(JObject.Parse(Institution.AdvancedSearch.ToJson())); // Field Institution
            filters.Merge(JObject.Parse(WaitingList.AdvancedSearch.ToJson())); // Field WaitingList
            filters.Merge(JObject.Parse(Assessment_ID.AdvancedSearch.ToJson())); // Field Assessment_ID
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
                await Profile.SetSearchFilters(CurrentUserName(), "ftblPotentialStudentInfosrch", filters);
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

            // Field int_Potential_Student_ID
            if (filter?.TryGetValue("x_int_Potential_Student_ID", out sv) ?? false) {
                int_Potential_Student_ID.AdvancedSearch.SearchValue = sv;
                int_Potential_Student_ID.AdvancedSearch.SearchOperator = filter["z_int_Potential_Student_ID"];
                int_Potential_Student_ID.AdvancedSearch.SearchCondition = filter["v_int_Potential_Student_ID"];
                int_Potential_Student_ID.AdvancedSearch.SearchValue2 = filter["y_int_Potential_Student_ID"];
                int_Potential_Student_ID.AdvancedSearch.SearchOperator2 = filter["w_int_Potential_Student_ID"];
                int_Potential_Student_ID.AdvancedSearch.Save();
            }

            // Field int_Student_Id
            if (filter?.TryGetValue("x_int_Student_Id", out sv) ?? false) {
                int_Student_Id.AdvancedSearch.SearchValue = sv;
                int_Student_Id.AdvancedSearch.SearchOperator = filter["z_int_Student_Id"];
                int_Student_Id.AdvancedSearch.SearchCondition = filter["v_int_Student_Id"];
                int_Student_Id.AdvancedSearch.SearchValue2 = filter["y_int_Student_Id"];
                int_Student_Id.AdvancedSearch.SearchOperator2 = filter["w_int_Student_Id"];
                int_Student_Id.AdvancedSearch.Save();
            }

            // Field str_NationalID_Iqama
            if (filter?.TryGetValue("x_str_NationalID_Iqama", out sv) ?? false) {
                str_NationalID_Iqama.AdvancedSearch.SearchValue = sv;
                str_NationalID_Iqama.AdvancedSearch.SearchOperator = filter["z_str_NationalID_Iqama"];
                str_NationalID_Iqama.AdvancedSearch.SearchCondition = filter["v_str_NationalID_Iqama"];
                str_NationalID_Iqama.AdvancedSearch.SearchValue2 = filter["y_str_NationalID_Iqama"];
                str_NationalID_Iqama.AdvancedSearch.SearchOperator2 = filter["w_str_NationalID_Iqama"];
                str_NationalID_Iqama.AdvancedSearch.Save();
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

            // Field str_First_Name
            if (filter?.TryGetValue("x_str_First_Name", out sv) ?? false) {
                str_First_Name.AdvancedSearch.SearchValue = sv;
                str_First_Name.AdvancedSearch.SearchOperator = filter["z_str_First_Name"];
                str_First_Name.AdvancedSearch.SearchCondition = filter["v_str_First_Name"];
                str_First_Name.AdvancedSearch.SearchValue2 = filter["y_str_First_Name"];
                str_First_Name.AdvancedSearch.SearchOperator2 = filter["w_str_First_Name"];
                str_First_Name.AdvancedSearch.Save();
            }

            // Field str_Middle_Name
            if (filter?.TryGetValue("x_str_Middle_Name", out sv) ?? false) {
                str_Middle_Name.AdvancedSearch.SearchValue = sv;
                str_Middle_Name.AdvancedSearch.SearchOperator = filter["z_str_Middle_Name"];
                str_Middle_Name.AdvancedSearch.SearchCondition = filter["v_str_Middle_Name"];
                str_Middle_Name.AdvancedSearch.SearchValue2 = filter["y_str_Middle_Name"];
                str_Middle_Name.AdvancedSearch.SearchOperator2 = filter["w_str_Middle_Name"];
                str_Middle_Name.AdvancedSearch.Save();
            }

            // Field str_Last_Name
            if (filter?.TryGetValue("x_str_Last_Name", out sv) ?? false) {
                str_Last_Name.AdvancedSearch.SearchValue = sv;
                str_Last_Name.AdvancedSearch.SearchOperator = filter["z_str_Last_Name"];
                str_Last_Name.AdvancedSearch.SearchCondition = filter["v_str_Last_Name"];
                str_Last_Name.AdvancedSearch.SearchValue2 = filter["y_str_Last_Name"];
                str_Last_Name.AdvancedSearch.SearchOperator2 = filter["w_str_Last_Name"];
                str_Last_Name.AdvancedSearch.Save();
            }

            // Field str_Address1
            if (filter?.TryGetValue("x_str_Address1", out sv) ?? false) {
                str_Address1.AdvancedSearch.SearchValue = sv;
                str_Address1.AdvancedSearch.SearchOperator = filter["z_str_Address1"];
                str_Address1.AdvancedSearch.SearchCondition = filter["v_str_Address1"];
                str_Address1.AdvancedSearch.SearchValue2 = filter["y_str_Address1"];
                str_Address1.AdvancedSearch.SearchOperator2 = filter["w_str_Address1"];
                str_Address1.AdvancedSearch.Save();
            }

            // Field str_Address2
            if (filter?.TryGetValue("x_str_Address2", out sv) ?? false) {
                str_Address2.AdvancedSearch.SearchValue = sv;
                str_Address2.AdvancedSearch.SearchOperator = filter["z_str_Address2"];
                str_Address2.AdvancedSearch.SearchCondition = filter["v_str_Address2"];
                str_Address2.AdvancedSearch.SearchValue2 = filter["y_str_Address2"];
                str_Address2.AdvancedSearch.SearchOperator2 = filter["w_str_Address2"];
                str_Address2.AdvancedSearch.Save();
            }

            // Field int_State
            if (filter?.TryGetValue("x_int_State", out sv) ?? false) {
                int_State.AdvancedSearch.SearchValue = sv;
                int_State.AdvancedSearch.SearchOperator = filter["z_int_State"];
                int_State.AdvancedSearch.SearchCondition = filter["v_int_State"];
                int_State.AdvancedSearch.SearchValue2 = filter["y_int_State"];
                int_State.AdvancedSearch.SearchOperator2 = filter["w_int_State"];
                int_State.AdvancedSearch.Save();
            }

            // Field str_City
            if (filter?.TryGetValue("x_str_City", out sv) ?? false) {
                str_City.AdvancedSearch.SearchValue = sv;
                str_City.AdvancedSearch.SearchOperator = filter["z_str_City"];
                str_City.AdvancedSearch.SearchCondition = filter["v_str_City"];
                str_City.AdvancedSearch.SearchValue2 = filter["y_str_City"];
                str_City.AdvancedSearch.SearchOperator2 = filter["w_str_City"];
                str_City.AdvancedSearch.Save();
            }

            // Field str_Zip
            if (filter?.TryGetValue("x_str_Zip", out sv) ?? false) {
                str_Zip.AdvancedSearch.SearchValue = sv;
                str_Zip.AdvancedSearch.SearchOperator = filter["z_str_Zip"];
                str_Zip.AdvancedSearch.SearchCondition = filter["v_str_Zip"];
                str_Zip.AdvancedSearch.SearchValue2 = filter["y_str_Zip"];
                str_Zip.AdvancedSearch.SearchOperator2 = filter["w_str_Zip"];
                str_Zip.AdvancedSearch.Save();
            }

            // Field int_Instructor
            if (filter?.TryGetValue("x_int_Instructor", out sv) ?? false) {
                int_Instructor.AdvancedSearch.SearchValue = sv;
                int_Instructor.AdvancedSearch.SearchOperator = filter["z_int_Instructor"];
                int_Instructor.AdvancedSearch.SearchCondition = filter["v_int_Instructor"];
                int_Instructor.AdvancedSearch.SearchValue2 = filter["y_int_Instructor"];
                int_Instructor.AdvancedSearch.SearchOperator2 = filter["w_int_Instructor"];
                int_Instructor.AdvancedSearch.Save();
            }

            // Field int_Driver
            if (filter?.TryGetValue("x_int_Driver", out sv) ?? false) {
                int_Driver.AdvancedSearch.SearchValue = sv;
                int_Driver.AdvancedSearch.SearchOperator = filter["z_int_Driver"];
                int_Driver.AdvancedSearch.SearchCondition = filter["v_int_Driver"];
                int_Driver.AdvancedSearch.SearchValue2 = filter["y_int_Driver"];
                int_Driver.AdvancedSearch.SearchOperator2 = filter["w_int_Driver"];
                int_Driver.AdvancedSearch.Save();
            }

            // Field str_Home_Phone
            if (filter?.TryGetValue("x_str_Home_Phone", out sv) ?? false) {
                str_Home_Phone.AdvancedSearch.SearchValue = sv;
                str_Home_Phone.AdvancedSearch.SearchOperator = filter["z_str_Home_Phone"];
                str_Home_Phone.AdvancedSearch.SearchCondition = filter["v_str_Home_Phone"];
                str_Home_Phone.AdvancedSearch.SearchValue2 = filter["y_str_Home_Phone"];
                str_Home_Phone.AdvancedSearch.SearchOperator2 = filter["w_str_Home_Phone"];
                str_Home_Phone.AdvancedSearch.Save();
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

            // Field str_Parent_Phone
            if (filter?.TryGetValue("x_str_Parent_Phone", out sv) ?? false) {
                str_Parent_Phone.AdvancedSearch.SearchValue = sv;
                str_Parent_Phone.AdvancedSearch.SearchOperator = filter["z_str_Parent_Phone"];
                str_Parent_Phone.AdvancedSearch.SearchCondition = filter["v_str_Parent_Phone"];
                str_Parent_Phone.AdvancedSearch.SearchValue2 = filter["y_str_Parent_Phone"];
                str_Parent_Phone.AdvancedSearch.SearchOperator2 = filter["w_str_Parent_Phone"];
                str_Parent_Phone.AdvancedSearch.Save();
            }

            // Field str_Other_Phone
            if (filter?.TryGetValue("x_str_Other_Phone", out sv) ?? false) {
                str_Other_Phone.AdvancedSearch.SearchValue = sv;
                str_Other_Phone.AdvancedSearch.SearchOperator = filter["z_str_Other_Phone"];
                str_Other_Phone.AdvancedSearch.SearchCondition = filter["v_str_Other_Phone"];
                str_Other_Phone.AdvancedSearch.SearchValue2 = filter["y_str_Other_Phone"];
                str_Other_Phone.AdvancedSearch.SearchOperator2 = filter["w_str_Other_Phone"];
                str_Other_Phone.AdvancedSearch.Save();
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

            // Field str_ParentName
            if (filter?.TryGetValue("x_str_ParentName", out sv) ?? false) {
                str_ParentName.AdvancedSearch.SearchValue = sv;
                str_ParentName.AdvancedSearch.SearchOperator = filter["z_str_ParentName"];
                str_ParentName.AdvancedSearch.SearchCondition = filter["v_str_ParentName"];
                str_ParentName.AdvancedSearch.SearchValue2 = filter["y_str_ParentName"];
                str_ParentName.AdvancedSearch.SearchOperator2 = filter["w_str_ParentName"];
                str_ParentName.AdvancedSearch.Save();
            }

            // Field str_ParentEmail1
            if (filter?.TryGetValue("x_str_ParentEmail1", out sv) ?? false) {
                str_ParentEmail1.AdvancedSearch.SearchValue = sv;
                str_ParentEmail1.AdvancedSearch.SearchOperator = filter["z_str_ParentEmail1"];
                str_ParentEmail1.AdvancedSearch.SearchCondition = filter["v_str_ParentEmail1"];
                str_ParentEmail1.AdvancedSearch.SearchValue2 = filter["y_str_ParentEmail1"];
                str_ParentEmail1.AdvancedSearch.SearchOperator2 = filter["w_str_ParentEmail1"];
                str_ParentEmail1.AdvancedSearch.Save();
            }

            // Field str_ParentEmail2
            if (filter?.TryGetValue("x_str_ParentEmail2", out sv) ?? false) {
                str_ParentEmail2.AdvancedSearch.SearchValue = sv;
                str_ParentEmail2.AdvancedSearch.SearchOperator = filter["z_str_ParentEmail2"];
                str_ParentEmail2.AdvancedSearch.SearchCondition = filter["v_str_ParentEmail2"];
                str_ParentEmail2.AdvancedSearch.SearchValue2 = filter["y_str_ParentEmail2"];
                str_ParentEmail2.AdvancedSearch.SearchOperator2 = filter["w_str_ParentEmail2"];
                str_ParentEmail2.AdvancedSearch.Save();
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

            // Field str_Password
            if (filter?.TryGetValue("x_str_Password", out sv) ?? false) {
                str_Password.AdvancedSearch.SearchValue = sv;
                str_Password.AdvancedSearch.SearchOperator = filter["z_str_Password"];
                str_Password.AdvancedSearch.SearchCondition = filter["v_str_Password"];
                str_Password.AdvancedSearch.SearchValue2 = filter["y_str_Password"];
                str_Password.AdvancedSearch.SearchOperator2 = filter["w_str_Password"];
                str_Password.AdvancedSearch.Save();
            }

            // Field str_DOB
            if (filter?.TryGetValue("x_str_DOB", out sv) ?? false) {
                str_DOB.AdvancedSearch.SearchValue = sv;
                str_DOB.AdvancedSearch.SearchOperator = filter["z_str_DOB"];
                str_DOB.AdvancedSearch.SearchCondition = filter["v_str_DOB"];
                str_DOB.AdvancedSearch.SearchValue2 = filter["y_str_DOB"];
                str_DOB.AdvancedSearch.SearchOperator2 = filter["w_str_DOB"];
                str_DOB.AdvancedSearch.Save();
            }

            // Field int_DOB_Day
            if (filter?.TryGetValue("x_int_DOB_Day", out sv) ?? false) {
                int_DOB_Day.AdvancedSearch.SearchValue = sv;
                int_DOB_Day.AdvancedSearch.SearchOperator = filter["z_int_DOB_Day"];
                int_DOB_Day.AdvancedSearch.SearchCondition = filter["v_int_DOB_Day"];
                int_DOB_Day.AdvancedSearch.SearchValue2 = filter["y_int_DOB_Day"];
                int_DOB_Day.AdvancedSearch.SearchOperator2 = filter["w_int_DOB_Day"];
                int_DOB_Day.AdvancedSearch.Save();
            }

            // Field int_DOB_Month
            if (filter?.TryGetValue("x_int_DOB_Month", out sv) ?? false) {
                int_DOB_Month.AdvancedSearch.SearchValue = sv;
                int_DOB_Month.AdvancedSearch.SearchOperator = filter["z_int_DOB_Month"];
                int_DOB_Month.AdvancedSearch.SearchCondition = filter["v_int_DOB_Month"];
                int_DOB_Month.AdvancedSearch.SearchValue2 = filter["y_int_DOB_Month"];
                int_DOB_Month.AdvancedSearch.SearchOperator2 = filter["w_int_DOB_Month"];
                int_DOB_Month.AdvancedSearch.Save();
            }

            // Field int_DOB_Year
            if (filter?.TryGetValue("x_int_DOB_Year", out sv) ?? false) {
                int_DOB_Year.AdvancedSearch.SearchValue = sv;
                int_DOB_Year.AdvancedSearch.SearchOperator = filter["z_int_DOB_Year"];
                int_DOB_Year.AdvancedSearch.SearchCondition = filter["v_int_DOB_Year"];
                int_DOB_Year.AdvancedSearch.SearchValue2 = filter["y_int_DOB_Year"];
                int_DOB_Year.AdvancedSearch.SearchOperator2 = filter["w_int_DOB_Year"];
                int_DOB_Year.AdvancedSearch.Save();
            }

            // Field int_Age
            if (filter?.TryGetValue("x_int_Age", out sv) ?? false) {
                int_Age.AdvancedSearch.SearchValue = sv;
                int_Age.AdvancedSearch.SearchOperator = filter["z_int_Age"];
                int_Age.AdvancedSearch.SearchCondition = filter["v_int_Age"];
                int_Age.AdvancedSearch.SearchValue2 = filter["y_int_Age"];
                int_Age.AdvancedSearch.SearchOperator2 = filter["w_int_Age"];
                int_Age.AdvancedSearch.Save();
            }

            // Field int_Type
            if (filter?.TryGetValue("x_int_Type", out sv) ?? false) {
                int_Type.AdvancedSearch.SearchValue = sv;
                int_Type.AdvancedSearch.SearchOperator = filter["z_int_Type"];
                int_Type.AdvancedSearch.SearchCondition = filter["v_int_Type"];
                int_Type.AdvancedSearch.SearchValue2 = filter["y_int_Type"];
                int_Type.AdvancedSearch.SearchOperator2 = filter["w_int_Type"];
                int_Type.AdvancedSearch.Save();
            }

            // Field int_Wear_Glasses
            if (filter?.TryGetValue("x_int_Wear_Glasses", out sv) ?? false) {
                int_Wear_Glasses.AdvancedSearch.SearchValue = sv;
                int_Wear_Glasses.AdvancedSearch.SearchOperator = filter["z_int_Wear_Glasses"];
                int_Wear_Glasses.AdvancedSearch.SearchCondition = filter["v_int_Wear_Glasses"];
                int_Wear_Glasses.AdvancedSearch.SearchValue2 = filter["y_int_Wear_Glasses"];
                int_Wear_Glasses.AdvancedSearch.SearchOperator2 = filter["w_int_Wear_Glasses"];
                int_Wear_Glasses.AdvancedSearch.Save();
            }

            // Field int_Sex
            if (filter?.TryGetValue("x_int_Sex", out sv) ?? false) {
                int_Sex.AdvancedSearch.SearchValue = sv;
                int_Sex.AdvancedSearch.SearchOperator = filter["z_int_Sex"];
                int_Sex.AdvancedSearch.SearchCondition = filter["v_int_Sex"];
                int_Sex.AdvancedSearch.SearchValue2 = filter["y_int_Sex"];
                int_Sex.AdvancedSearch.SearchOperator2 = filter["w_int_Sex"];
                int_Sex.AdvancedSearch.Save();
            }

            // Field str_DLPermit
            if (filter?.TryGetValue("x_str_DLPermit", out sv) ?? false) {
                str_DLPermit.AdvancedSearch.SearchValue = sv;
                str_DLPermit.AdvancedSearch.SearchOperator = filter["z_str_DLPermit"];
                str_DLPermit.AdvancedSearch.SearchCondition = filter["v_str_DLPermit"];
                str_DLPermit.AdvancedSearch.SearchValue2 = filter["y_str_DLPermit"];
                str_DLPermit.AdvancedSearch.SearchOperator2 = filter["w_str_DLPermit"];
                str_DLPermit.AdvancedSearch.Save();
            }

            // Field dt_Date_PermitIssue
            if (filter?.TryGetValue("x_dt_Date_PermitIssue", out sv) ?? false) {
                dt_Date_PermitIssue.AdvancedSearch.SearchValue = sv;
                dt_Date_PermitIssue.AdvancedSearch.SearchOperator = filter["z_dt_Date_PermitIssue"];
                dt_Date_PermitIssue.AdvancedSearch.SearchCondition = filter["v_dt_Date_PermitIssue"];
                dt_Date_PermitIssue.AdvancedSearch.SearchValue2 = filter["y_dt_Date_PermitIssue"];
                dt_Date_PermitIssue.AdvancedSearch.SearchOperator2 = filter["w_dt_Date_PermitIssue"];
                dt_Date_PermitIssue.AdvancedSearch.Save();
            }

            // Field dt_Date_ExpirePermit
            if (filter?.TryGetValue("x_dt_Date_ExpirePermit", out sv) ?? false) {
                dt_Date_ExpirePermit.AdvancedSearch.SearchValue = sv;
                dt_Date_ExpirePermit.AdvancedSearch.SearchOperator = filter["z_dt_Date_ExpirePermit"];
                dt_Date_ExpirePermit.AdvancedSearch.SearchCondition = filter["v_dt_Date_ExpirePermit"];
                dt_Date_ExpirePermit.AdvancedSearch.SearchValue2 = filter["y_dt_Date_ExpirePermit"];
                dt_Date_ExpirePermit.AdvancedSearch.SearchOperator2 = filter["w_dt_Date_ExpirePermit"];
                dt_Date_ExpirePermit.AdvancedSearch.Save();
            }

            // Field int_Hs_ID
            if (filter?.TryGetValue("x_int_Hs_ID", out sv) ?? false) {
                int_Hs_ID.AdvancedSearch.SearchValue = sv;
                int_Hs_ID.AdvancedSearch.SearchOperator = filter["z_int_Hs_ID"];
                int_Hs_ID.AdvancedSearch.SearchCondition = filter["v_int_Hs_ID"];
                int_Hs_ID.AdvancedSearch.SearchValue2 = filter["y_int_Hs_ID"];
                int_Hs_ID.AdvancedSearch.SearchOperator2 = filter["w_int_Hs_ID"];
                int_Hs_ID.AdvancedSearch.Save();
            }

            // Field str_Emergency_Contact_Name
            if (filter?.TryGetValue("x_str_Emergency_Contact_Name", out sv) ?? false) {
                str_Emergency_Contact_Name.AdvancedSearch.SearchValue = sv;
                str_Emergency_Contact_Name.AdvancedSearch.SearchOperator = filter["z_str_Emergency_Contact_Name"];
                str_Emergency_Contact_Name.AdvancedSearch.SearchCondition = filter["v_str_Emergency_Contact_Name"];
                str_Emergency_Contact_Name.AdvancedSearch.SearchValue2 = filter["y_str_Emergency_Contact_Name"];
                str_Emergency_Contact_Name.AdvancedSearch.SearchOperator2 = filter["w_str_Emergency_Contact_Name"];
                str_Emergency_Contact_Name.AdvancedSearch.Save();
            }

            // Field str_Emergency_Contact_Phone
            if (filter?.TryGetValue("x_str_Emergency_Contact_Phone", out sv) ?? false) {
                str_Emergency_Contact_Phone.AdvancedSearch.SearchValue = sv;
                str_Emergency_Contact_Phone.AdvancedSearch.SearchOperator = filter["z_str_Emergency_Contact_Phone"];
                str_Emergency_Contact_Phone.AdvancedSearch.SearchCondition = filter["v_str_Emergency_Contact_Phone"];
                str_Emergency_Contact_Phone.AdvancedSearch.SearchValue2 = filter["y_str_Emergency_Contact_Phone"];
                str_Emergency_Contact_Phone.AdvancedSearch.SearchOperator2 = filter["w_str_Emergency_Contact_Phone"];
                str_Emergency_Contact_Phone.AdvancedSearch.Save();
            }

            // Field str_Emergency_Contact_Relation
            if (filter?.TryGetValue("x_str_Emergency_Contact_Relation", out sv) ?? false) {
                str_Emergency_Contact_Relation.AdvancedSearch.SearchValue = sv;
                str_Emergency_Contact_Relation.AdvancedSearch.SearchOperator = filter["z_str_Emergency_Contact_Relation"];
                str_Emergency_Contact_Relation.AdvancedSearch.SearchCondition = filter["v_str_Emergency_Contact_Relation"];
                str_Emergency_Contact_Relation.AdvancedSearch.SearchValue2 = filter["y_str_Emergency_Contact_Relation"];
                str_Emergency_Contact_Relation.AdvancedSearch.SearchOperator2 = filter["w_str_Emergency_Contact_Relation"];
                str_Emergency_Contact_Relation.AdvancedSearch.Save();
            }

            // Field str_Student_Notes
            if (filter?.TryGetValue("x_str_Student_Notes", out sv) ?? false) {
                str_Student_Notes.AdvancedSearch.SearchValue = sv;
                str_Student_Notes.AdvancedSearch.SearchOperator = filter["z_str_Student_Notes"];
                str_Student_Notes.AdvancedSearch.SearchCondition = filter["v_str_Student_Notes"];
                str_Student_Notes.AdvancedSearch.SearchValue2 = filter["y_str_Student_Notes"];
                str_Student_Notes.AdvancedSearch.SearchOperator2 = filter["w_str_Student_Notes"];
                str_Student_Notes.AdvancedSearch.Save();
            }

            // Field str_Driving_Notes
            if (filter?.TryGetValue("x_str_Driving_Notes", out sv) ?? false) {
                str_Driving_Notes.AdvancedSearch.SearchValue = sv;
                str_Driving_Notes.AdvancedSearch.SearchOperator = filter["z_str_Driving_Notes"];
                str_Driving_Notes.AdvancedSearch.SearchCondition = filter["v_str_Driving_Notes"];
                str_Driving_Notes.AdvancedSearch.SearchValue2 = filter["y_str_Driving_Notes"];
                str_Driving_Notes.AdvancedSearch.SearchOperator2 = filter["w_str_Driving_Notes"];
                str_Driving_Notes.AdvancedSearch.Save();
            }

            // Field int_Location_Id
            if (filter?.TryGetValue("x_int_Location_Id", out sv) ?? false) {
                int_Location_Id.AdvancedSearch.SearchValue = sv;
                int_Location_Id.AdvancedSearch.SearchOperator = filter["z_int_Location_Id"];
                int_Location_Id.AdvancedSearch.SearchCondition = filter["v_int_Location_Id"];
                int_Location_Id.AdvancedSearch.SearchValue2 = filter["y_int_Location_Id"];
                int_Location_Id.AdvancedSearch.SearchOperator2 = filter["w_int_Location_Id"];
                int_Location_Id.AdvancedSearch.Save();
            }

            // Field int_Permit_Number
            if (filter?.TryGetValue("x_int_Permit_Number", out sv) ?? false) {
                int_Permit_Number.AdvancedSearch.SearchValue = sv;
                int_Permit_Number.AdvancedSearch.SearchOperator = filter["z_int_Permit_Number"];
                int_Permit_Number.AdvancedSearch.SearchCondition = filter["v_int_Permit_Number"];
                int_Permit_Number.AdvancedSearch.SearchValue2 = filter["y_int_Permit_Number"];
                int_Permit_Number.AdvancedSearch.SearchOperator2 = filter["w_int_Permit_Number"];
                int_Permit_Number.AdvancedSearch.Save();
            }

            // Field Permit_Issue_Date
            if (filter?.TryGetValue("x_Permit_Issue_Date", out sv) ?? false) {
                Permit_Issue_Date.AdvancedSearch.SearchValue = sv;
                Permit_Issue_Date.AdvancedSearch.SearchOperator = filter["z_Permit_Issue_Date"];
                Permit_Issue_Date.AdvancedSearch.SearchCondition = filter["v_Permit_Issue_Date"];
                Permit_Issue_Date.AdvancedSearch.SearchValue2 = filter["y_Permit_Issue_Date"];
                Permit_Issue_Date.AdvancedSearch.SearchOperator2 = filter["w_Permit_Issue_Date"];
                Permit_Issue_Date.AdvancedSearch.Save();
            }

            // Field Permit_Expiry_Date
            if (filter?.TryGetValue("x_Permit_Expiry_Date", out sv) ?? false) {
                Permit_Expiry_Date.AdvancedSearch.SearchValue = sv;
                Permit_Expiry_Date.AdvancedSearch.SearchOperator = filter["z_Permit_Expiry_Date"];
                Permit_Expiry_Date.AdvancedSearch.SearchCondition = filter["v_Permit_Expiry_Date"];
                Permit_Expiry_Date.AdvancedSearch.SearchValue2 = filter["y_Permit_Expiry_Date"];
                Permit_Expiry_Date.AdvancedSearch.SearchOperator2 = filter["w_Permit_Expiry_Date"];
                Permit_Expiry_Date.AdvancedSearch.Save();
            }

            // Field int_Status
            if (filter?.TryGetValue("x_int_Status", out sv) ?? false) {
                int_Status.AdvancedSearch.SearchValue = sv;
                int_Status.AdvancedSearch.SearchOperator = filter["z_int_Status"];
                int_Status.AdvancedSearch.SearchCondition = filter["v_int_Status"];
                int_Status.AdvancedSearch.SearchValue2 = filter["y_int_Status"];
                int_Status.AdvancedSearch.SearchOperator2 = filter["w_int_Status"];
                int_Status.AdvancedSearch.Save();
            }

            // Field int_Lead_Id
            if (filter?.TryGetValue("x_int_Lead_Id", out sv) ?? false) {
                int_Lead_Id.AdvancedSearch.SearchValue = sv;
                int_Lead_Id.AdvancedSearch.SearchOperator = filter["z_int_Lead_Id"];
                int_Lead_Id.AdvancedSearch.SearchCondition = filter["v_int_Lead_Id"];
                int_Lead_Id.AdvancedSearch.SearchValue2 = filter["y_int_Lead_Id"];
                int_Lead_Id.AdvancedSearch.SearchOperator2 = filter["w_int_Lead_Id"];
                int_Lead_Id.AdvancedSearch.Save();
            }

            // Field int_Activated_By
            if (filter?.TryGetValue("x_int_Activated_By", out sv) ?? false) {
                int_Activated_By.AdvancedSearch.SearchValue = sv;
                int_Activated_By.AdvancedSearch.SearchOperator = filter["z_int_Activated_By"];
                int_Activated_By.AdvancedSearch.SearchCondition = filter["v_int_Activated_By"];
                int_Activated_By.AdvancedSearch.SearchValue2 = filter["y_int_Activated_By"];
                int_Activated_By.AdvancedSearch.SearchOperator2 = filter["w_int_Activated_By"];
                int_Activated_By.AdvancedSearch.Save();
            }

            // Field date_Activated
            if (filter?.TryGetValue("x_date_Activated", out sv) ?? false) {
                date_Activated.AdvancedSearch.SearchValue = sv;
                date_Activated.AdvancedSearch.SearchOperator = filter["z_date_Activated"];
                date_Activated.AdvancedSearch.SearchCondition = filter["v_date_Activated"];
                date_Activated.AdvancedSearch.SearchValue2 = filter["y_date_Activated"];
                date_Activated.AdvancedSearch.SearchOperator2 = filter["w_date_Activated"];
                date_Activated.AdvancedSearch.Save();
            }

            // Field date_Created
            if (filter?.TryGetValue("x_date_Created", out sv) ?? false) {
                date_Created.AdvancedSearch.SearchValue = sv;
                date_Created.AdvancedSearch.SearchOperator = filter["z_date_Created"];
                date_Created.AdvancedSearch.SearchCondition = filter["v_date_Created"];
                date_Created.AdvancedSearch.SearchValue2 = filter["y_date_Created"];
                date_Created.AdvancedSearch.SearchOperator2 = filter["w_date_Created"];
                date_Created.AdvancedSearch.Save();
            }

            // Field date_Modified
            if (filter?.TryGetValue("x_date_Modified", out sv) ?? false) {
                date_Modified.AdvancedSearch.SearchValue = sv;
                date_Modified.AdvancedSearch.SearchOperator = filter["z_date_Modified"];
                date_Modified.AdvancedSearch.SearchCondition = filter["v_date_Modified"];
                date_Modified.AdvancedSearch.SearchValue2 = filter["y_date_Modified"];
                date_Modified.AdvancedSearch.SearchOperator2 = filter["w_date_Modified"];
                date_Modified.AdvancedSearch.Save();
            }

            // Field date_Complete
            if (filter?.TryGetValue("x_date_Complete", out sv) ?? false) {
                date_Complete.AdvancedSearch.SearchValue = sv;
                date_Complete.AdvancedSearch.SearchOperator = filter["z_date_Complete"];
                date_Complete.AdvancedSearch.SearchCondition = filter["v_date_Complete"];
                date_Complete.AdvancedSearch.SearchValue2 = filter["y_date_Complete"];
                date_Complete.AdvancedSearch.SearchOperator2 = filter["w_date_Complete"];
                date_Complete.AdvancedSearch.Save();
            }

            // Field int_Created_By
            if (filter?.TryGetValue("x_int_Created_By", out sv) ?? false) {
                int_Created_By.AdvancedSearch.SearchValue = sv;
                int_Created_By.AdvancedSearch.SearchOperator = filter["z_int_Created_By"];
                int_Created_By.AdvancedSearch.SearchCondition = filter["v_int_Created_By"];
                int_Created_By.AdvancedSearch.SearchValue2 = filter["y_int_Created_By"];
                int_Created_By.AdvancedSearch.SearchOperator2 = filter["w_int_Created_By"];
                int_Created_By.AdvancedSearch.Save();
            }

            // Field int_Modified_By
            if (filter?.TryGetValue("x_int_Modified_By", out sv) ?? false) {
                int_Modified_By.AdvancedSearch.SearchValue = sv;
                int_Modified_By.AdvancedSearch.SearchOperator = filter["z_int_Modified_By"];
                int_Modified_By.AdvancedSearch.SearchCondition = filter["v_int_Modified_By"];
                int_Modified_By.AdvancedSearch.SearchValue2 = filter["y_int_Modified_By"];
                int_Modified_By.AdvancedSearch.SearchOperator2 = filter["w_int_Modified_By"];
                int_Modified_By.AdvancedSearch.Save();
            }

            // Field bit_IsDeleted
            if (filter?.TryGetValue("x_bit_IsDeleted", out sv) ?? false) {
                bit_IsDeleted.AdvancedSearch.SearchValue = sv;
                bit_IsDeleted.AdvancedSearch.SearchOperator = filter["z_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.SearchCondition = filter["v_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.SearchValue2 = filter["y_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.SearchOperator2 = filter["w_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.Save();
            }

            // Field str_CardHolderName
            if (filter?.TryGetValue("x_str_CardHolderName", out sv) ?? false) {
                str_CardHolderName.AdvancedSearch.SearchValue = sv;
                str_CardHolderName.AdvancedSearch.SearchOperator = filter["z_str_CardHolderName"];
                str_CardHolderName.AdvancedSearch.SearchCondition = filter["v_str_CardHolderName"];
                str_CardHolderName.AdvancedSearch.SearchValue2 = filter["y_str_CardHolderName"];
                str_CardHolderName.AdvancedSearch.SearchOperator2 = filter["w_str_CardHolderName"];
                str_CardHolderName.AdvancedSearch.Save();
            }

            // Field str_CardHolderAddress
            if (filter?.TryGetValue("x_str_CardHolderAddress", out sv) ?? false) {
                str_CardHolderAddress.AdvancedSearch.SearchValue = sv;
                str_CardHolderAddress.AdvancedSearch.SearchOperator = filter["z_str_CardHolderAddress"];
                str_CardHolderAddress.AdvancedSearch.SearchCondition = filter["v_str_CardHolderAddress"];
                str_CardHolderAddress.AdvancedSearch.SearchValue2 = filter["y_str_CardHolderAddress"];
                str_CardHolderAddress.AdvancedSearch.SearchOperator2 = filter["w_str_CardHolderAddress"];
                str_CardHolderAddress.AdvancedSearch.Save();
            }

            // Field str_CardHolderCity
            if (filter?.TryGetValue("x_str_CardHolderCity", out sv) ?? false) {
                str_CardHolderCity.AdvancedSearch.SearchValue = sv;
                str_CardHolderCity.AdvancedSearch.SearchOperator = filter["z_str_CardHolderCity"];
                str_CardHolderCity.AdvancedSearch.SearchCondition = filter["v_str_CardHolderCity"];
                str_CardHolderCity.AdvancedSearch.SearchValue2 = filter["y_str_CardHolderCity"];
                str_CardHolderCity.AdvancedSearch.SearchOperator2 = filter["w_str_CardHolderCity"];
                str_CardHolderCity.AdvancedSearch.Save();
            }

            // Field str_CardHolderZip
            if (filter?.TryGetValue("x_str_CardHolderZip", out sv) ?? false) {
                str_CardHolderZip.AdvancedSearch.SearchValue = sv;
                str_CardHolderZip.AdvancedSearch.SearchOperator = filter["z_str_CardHolderZip"];
                str_CardHolderZip.AdvancedSearch.SearchCondition = filter["v_str_CardHolderZip"];
                str_CardHolderZip.AdvancedSearch.SearchValue2 = filter["y_str_CardHolderZip"];
                str_CardHolderZip.AdvancedSearch.SearchOperator2 = filter["w_str_CardHolderZip"];
                str_CardHolderZip.AdvancedSearch.Save();
            }

            // Field str_CardType
            if (filter?.TryGetValue("x_str_CardType", out sv) ?? false) {
                str_CardType.AdvancedSearch.SearchValue = sv;
                str_CardType.AdvancedSearch.SearchOperator = filter["z_str_CardType"];
                str_CardType.AdvancedSearch.SearchCondition = filter["v_str_CardType"];
                str_CardType.AdvancedSearch.SearchValue2 = filter["y_str_CardType"];
                str_CardType.AdvancedSearch.SearchOperator2 = filter["w_str_CardType"];
                str_CardType.AdvancedSearch.Save();
            }

            // Field str_CardExpMonth
            if (filter?.TryGetValue("x_str_CardExpMonth", out sv) ?? false) {
                str_CardExpMonth.AdvancedSearch.SearchValue = sv;
                str_CardExpMonth.AdvancedSearch.SearchOperator = filter["z_str_CardExpMonth"];
                str_CardExpMonth.AdvancedSearch.SearchCondition = filter["v_str_CardExpMonth"];
                str_CardExpMonth.AdvancedSearch.SearchValue2 = filter["y_str_CardExpMonth"];
                str_CardExpMonth.AdvancedSearch.SearchOperator2 = filter["w_str_CardExpMonth"];
                str_CardExpMonth.AdvancedSearch.Save();
            }

            // Field str_CardExpYear
            if (filter?.TryGetValue("x_str_CardExpYear", out sv) ?? false) {
                str_CardExpYear.AdvancedSearch.SearchValue = sv;
                str_CardExpYear.AdvancedSearch.SearchOperator = filter["z_str_CardExpYear"];
                str_CardExpYear.AdvancedSearch.SearchCondition = filter["v_str_CardExpYear"];
                str_CardExpYear.AdvancedSearch.SearchValue2 = filter["y_str_CardExpYear"];
                str_CardExpYear.AdvancedSearch.SearchOperator2 = filter["w_str_CardExpYear"];
                str_CardExpYear.AdvancedSearch.Save();
            }

            // Field str_CardNo
            if (filter?.TryGetValue("x_str_CardNo", out sv) ?? false) {
                str_CardNo.AdvancedSearch.SearchValue = sv;
                str_CardNo.AdvancedSearch.SearchOperator = filter["z_str_CardNo"];
                str_CardNo.AdvancedSearch.SearchCondition = filter["v_str_CardNo"];
                str_CardNo.AdvancedSearch.SearchValue2 = filter["y_str_CardNo"];
                str_CardNo.AdvancedSearch.SearchOperator2 = filter["w_str_CardNo"];
                str_CardNo.AdvancedSearch.Save();
            }

            // Field str_Certificate_No
            if (filter?.TryGetValue("x_str_Certificate_No", out sv) ?? false) {
                str_Certificate_No.AdvancedSearch.SearchValue = sv;
                str_Certificate_No.AdvancedSearch.SearchOperator = filter["z_str_Certificate_No"];
                str_Certificate_No.AdvancedSearch.SearchCondition = filter["v_str_Certificate_No"];
                str_Certificate_No.AdvancedSearch.SearchValue2 = filter["y_str_Certificate_No"];
                str_Certificate_No.AdvancedSearch.SearchOperator2 = filter["w_str_Certificate_No"];
                str_Certificate_No.AdvancedSearch.Save();
            }

            // Field str_AmountPaid
            if (filter?.TryGetValue("x_str_AmountPaid", out sv) ?? false) {
                str_AmountPaid.AdvancedSearch.SearchValue = sv;
                str_AmountPaid.AdvancedSearch.SearchOperator = filter["z_str_AmountPaid"];
                str_AmountPaid.AdvancedSearch.SearchCondition = filter["v_str_AmountPaid"];
                str_AmountPaid.AdvancedSearch.SearchValue2 = filter["y_str_AmountPaid"];
                str_AmountPaid.AdvancedSearch.SearchOperator2 = filter["w_str_AmountPaid"];
                str_AmountPaid.AdvancedSearch.Save();
            }

            // Field str_PermitValidated
            if (filter?.TryGetValue("x_str_PermitValidated", out sv) ?? false) {
                str_PermitValidated.AdvancedSearch.SearchValue = sv;
                str_PermitValidated.AdvancedSearch.SearchOperator = filter["z_str_PermitValidated"];
                str_PermitValidated.AdvancedSearch.SearchCondition = filter["v_str_PermitValidated"];
                str_PermitValidated.AdvancedSearch.SearchValue2 = filter["y_str_PermitValidated"];
                str_PermitValidated.AdvancedSearch.SearchOperator2 = filter["w_str_PermitValidated"];
                str_PermitValidated.AdvancedSearch.Save();
            }

            // Field strSMSNotification
            if (filter?.TryGetValue("x_strSMSNotification", out sv) ?? false) {
                strSMSNotification.AdvancedSearch.SearchValue = sv;
                strSMSNotification.AdvancedSearch.SearchOperator = filter["z_strSMSNotification"];
                strSMSNotification.AdvancedSearch.SearchCondition = filter["v_strSMSNotification"];
                strSMSNotification.AdvancedSearch.SearchValue2 = filter["y_strSMSNotification"];
                strSMSNotification.AdvancedSearch.SearchOperator2 = filter["w_strSMSNotification"];
                strSMSNotification.AdvancedSearch.Save();
            }

            // Field strVoiceNotification
            if (filter?.TryGetValue("x_strVoiceNotification", out sv) ?? false) {
                strVoiceNotification.AdvancedSearch.SearchValue = sv;
                strVoiceNotification.AdvancedSearch.SearchOperator = filter["z_strVoiceNotification"];
                strVoiceNotification.AdvancedSearch.SearchCondition = filter["v_strVoiceNotification"];
                strVoiceNotification.AdvancedSearch.SearchValue2 = filter["y_strVoiceNotification"];
                strVoiceNotification.AdvancedSearch.SearchOperator2 = filter["w_strVoiceNotification"];
                strVoiceNotification.AdvancedSearch.Save();
            }

            // Field str_Weight
            if (filter?.TryGetValue("x_str_Weight", out sv) ?? false) {
                str_Weight.AdvancedSearch.SearchValue = sv;
                str_Weight.AdvancedSearch.SearchOperator = filter["z_str_Weight"];
                str_Weight.AdvancedSearch.SearchCondition = filter["v_str_Weight"];
                str_Weight.AdvancedSearch.SearchValue2 = filter["y_str_Weight"];
                str_Weight.AdvancedSearch.SearchOperator2 = filter["w_str_Weight"];
                str_Weight.AdvancedSearch.Save();
            }

            // Field str_SpecialNeeds
            if (filter?.TryGetValue("x_str_SpecialNeeds", out sv) ?? false) {
                str_SpecialNeeds.AdvancedSearch.SearchValue = sv;
                str_SpecialNeeds.AdvancedSearch.SearchOperator = filter["z_str_SpecialNeeds"];
                str_SpecialNeeds.AdvancedSearch.SearchCondition = filter["v_str_SpecialNeeds"];
                str_SpecialNeeds.AdvancedSearch.SearchValue2 = filter["y_str_SpecialNeeds"];
                str_SpecialNeeds.AdvancedSearch.SearchOperator2 = filter["w_str_SpecialNeeds"];
                str_SpecialNeeds.AdvancedSearch.Save();
            }

            // Field str_MedicalConditions
            if (filter?.TryGetValue("x_str_MedicalConditions", out sv) ?? false) {
                str_MedicalConditions.AdvancedSearch.SearchValue = sv;
                str_MedicalConditions.AdvancedSearch.SearchOperator = filter["z_str_MedicalConditions"];
                str_MedicalConditions.AdvancedSearch.SearchCondition = filter["v_str_MedicalConditions"];
                str_MedicalConditions.AdvancedSearch.SearchValue2 = filter["y_str_MedicalConditions"];
                str_MedicalConditions.AdvancedSearch.SearchOperator2 = filter["w_str_MedicalConditions"];
                str_MedicalConditions.AdvancedSearch.Save();
            }

            // Field bit_Verified_PIC_InSAW
            if (filter?.TryGetValue("x_bit_Verified_PIC_InSAW", out sv) ?? false) {
                bit_Verified_PIC_InSAW.AdvancedSearch.SearchValue = sv;
                bit_Verified_PIC_InSAW.AdvancedSearch.SearchOperator = filter["z_bit_Verified_PIC_InSAW"];
                bit_Verified_PIC_InSAW.AdvancedSearch.SearchCondition = filter["v_bit_Verified_PIC_InSAW"];
                bit_Verified_PIC_InSAW.AdvancedSearch.SearchValue2 = filter["y_bit_Verified_PIC_InSAW"];
                bit_Verified_PIC_InSAW.AdvancedSearch.SearchOperator2 = filter["w_bit_Verified_PIC_InSAW"];
                bit_Verified_PIC_InSAW.AdvancedSearch.Save();
            }

            // Field bit_Permit_Waiver_Entered
            if (filter?.TryGetValue("x_bit_Permit_Waiver_Entered", out sv) ?? false) {
                bit_Permit_Waiver_Entered.AdvancedSearch.SearchValue = sv;
                bit_Permit_Waiver_Entered.AdvancedSearch.SearchOperator = filter["z_bit_Permit_Waiver_Entered"];
                bit_Permit_Waiver_Entered.AdvancedSearch.SearchCondition = filter["v_bit_Permit_Waiver_Entered"];
                bit_Permit_Waiver_Entered.AdvancedSearch.SearchValue2 = filter["y_bit_Permit_Waiver_Entered"];
                bit_Permit_Waiver_Entered.AdvancedSearch.SearchOperator2 = filter["w_bit_Permit_Waiver_Entered"];
                bit_Permit_Waiver_Entered.AdvancedSearch.Save();
            }

            // Field bit_TermsConditions
            if (filter?.TryGetValue("x_bit_TermsConditions", out sv) ?? false) {
                bit_TermsConditions.AdvancedSearch.SearchValue = sv;
                bit_TermsConditions.AdvancedSearch.SearchOperator = filter["z_bit_TermsConditions"];
                bit_TermsConditions.AdvancedSearch.SearchCondition = filter["v_bit_TermsConditions"];
                bit_TermsConditions.AdvancedSearch.SearchValue2 = filter["y_bit_TermsConditions"];
                bit_TermsConditions.AdvancedSearch.SearchOperator2 = filter["w_bit_TermsConditions"];
                bit_TermsConditions.AdvancedSearch.Save();
            }

            // Field bit_Disable_Self_Scheduling
            if (filter?.TryGetValue("x_bit_Disable_Self_Scheduling", out sv) ?? false) {
                bit_Disable_Self_Scheduling.AdvancedSearch.SearchValue = sv;
                bit_Disable_Self_Scheduling.AdvancedSearch.SearchOperator = filter["z_bit_Disable_Self_Scheduling"];
                bit_Disable_Self_Scheduling.AdvancedSearch.SearchCondition = filter["v_bit_Disable_Self_Scheduling"];
                bit_Disable_Self_Scheduling.AdvancedSearch.SearchValue2 = filter["y_bit_Disable_Self_Scheduling"];
                bit_Disable_Self_Scheduling.AdvancedSearch.SearchOperator2 = filter["w_bit_Disable_Self_Scheduling"];
                bit_Disable_Self_Scheduling.AdvancedSearch.Save();
            }

            // Field int_EyeColor
            if (filter?.TryGetValue("x_int_EyeColor", out sv) ?? false) {
                int_EyeColor.AdvancedSearch.SearchValue = sv;
                int_EyeColor.AdvancedSearch.SearchOperator = filter["z_int_EyeColor"];
                int_EyeColor.AdvancedSearch.SearchCondition = filter["v_int_EyeColor"];
                int_EyeColor.AdvancedSearch.SearchValue2 = filter["y_int_EyeColor"];
                int_EyeColor.AdvancedSearch.SearchOperator2 = filter["w_int_EyeColor"];
                int_EyeColor.AdvancedSearch.Save();
            }

            // Field int_HairColor
            if (filter?.TryGetValue("x_int_HairColor", out sv) ?? false) {
                int_HairColor.AdvancedSearch.SearchValue = sv;
                int_HairColor.AdvancedSearch.SearchOperator = filter["z_int_HairColor"];
                int_HairColor.AdvancedSearch.SearchCondition = filter["v_int_HairColor"];
                int_HairColor.AdvancedSearch.SearchValue2 = filter["y_int_HairColor"];
                int_HairColor.AdvancedSearch.SearchOperator2 = filter["w_int_HairColor"];
                int_HairColor.AdvancedSearch.Save();
            }

            // Field int_ColorBlind
            if (filter?.TryGetValue("x_int_ColorBlind", out sv) ?? false) {
                int_ColorBlind.AdvancedSearch.SearchValue = sv;
                int_ColorBlind.AdvancedSearch.SearchOperator = filter["z_int_ColorBlind"];
                int_ColorBlind.AdvancedSearch.SearchCondition = filter["v_int_ColorBlind"];
                int_ColorBlind.AdvancedSearch.SearchValue2 = filter["y_int_ColorBlind"];
                int_ColorBlind.AdvancedSearch.SearchOperator2 = filter["w_int_ColorBlind"];
                int_ColorBlind.AdvancedSearch.Save();
            }

            // Field int_HeightFeet
            if (filter?.TryGetValue("x_int_HeightFeet", out sv) ?? false) {
                int_HeightFeet.AdvancedSearch.SearchValue = sv;
                int_HeightFeet.AdvancedSearch.SearchOperator = filter["z_int_HeightFeet"];
                int_HeightFeet.AdvancedSearch.SearchCondition = filter["v_int_HeightFeet"];
                int_HeightFeet.AdvancedSearch.SearchValue2 = filter["y_int_HeightFeet"];
                int_HeightFeet.AdvancedSearch.SearchOperator2 = filter["w_int_HeightFeet"];
                int_HeightFeet.AdvancedSearch.Save();
            }

            // Field int_HeightInches
            if (filter?.TryGetValue("x_int_HeightInches", out sv) ?? false) {
                int_HeightInches.AdvancedSearch.SearchValue = sv;
                int_HeightInches.AdvancedSearch.SearchOperator = filter["z_int_HeightInches"];
                int_HeightInches.AdvancedSearch.SearchCondition = filter["v_int_HeightInches"];
                int_HeightInches.AdvancedSearch.SearchValue2 = filter["y_int_HeightInches"];
                int_HeightInches.AdvancedSearch.SearchOperator2 = filter["w_int_HeightInches"];
                int_HeightInches.AdvancedSearch.Save();
            }

            // Field str_reference_code
            if (filter?.TryGetValue("x_str_reference_code", out sv) ?? false) {
                str_reference_code.AdvancedSearch.SearchValue = sv;
                str_reference_code.AdvancedSearch.SearchOperator = filter["z_str_reference_code"];
                str_reference_code.AdvancedSearch.SearchCondition = filter["v_str_reference_code"];
                str_reference_code.AdvancedSearch.SearchValue2 = filter["y_str_reference_code"];
                str_reference_code.AdvancedSearch.SearchOperator2 = filter["w_str_reference_code"];
                str_reference_code.AdvancedSearch.Save();
            }

            // Field dt_ParentClassAttendedDt
            if (filter?.TryGetValue("x_dt_ParentClassAttendedDt", out sv) ?? false) {
                dt_ParentClassAttendedDt.AdvancedSearch.SearchValue = sv;
                dt_ParentClassAttendedDt.AdvancedSearch.SearchOperator = filter["z_dt_ParentClassAttendedDt"];
                dt_ParentClassAttendedDt.AdvancedSearch.SearchCondition = filter["v_dt_ParentClassAttendedDt"];
                dt_ParentClassAttendedDt.AdvancedSearch.SearchValue2 = filter["y_dt_ParentClassAttendedDt"];
                dt_ParentClassAttendedDt.AdvancedSearch.SearchOperator2 = filter["w_dt_ParentClassAttendedDt"];
                dt_ParentClassAttendedDt.AdvancedSearch.Save();
            }

            // Field str_ParentClassAttendedLoc
            if (filter?.TryGetValue("x_str_ParentClassAttendedLoc", out sv) ?? false) {
                str_ParentClassAttendedLoc.AdvancedSearch.SearchValue = sv;
                str_ParentClassAttendedLoc.AdvancedSearch.SearchOperator = filter["z_str_ParentClassAttendedLoc"];
                str_ParentClassAttendedLoc.AdvancedSearch.SearchCondition = filter["v_str_ParentClassAttendedLoc"];
                str_ParentClassAttendedLoc.AdvancedSearch.SearchValue2 = filter["y_str_ParentClassAttendedLoc"];
                str_ParentClassAttendedLoc.AdvancedSearch.SearchOperator2 = filter["w_str_ParentClassAttendedLoc"];
                str_ParentClassAttendedLoc.AdvancedSearch.Save();
            }

            // Field dt_SiblingClassAttendedDt
            if (filter?.TryGetValue("x_dt_SiblingClassAttendedDt", out sv) ?? false) {
                dt_SiblingClassAttendedDt.AdvancedSearch.SearchValue = sv;
                dt_SiblingClassAttendedDt.AdvancedSearch.SearchOperator = filter["z_dt_SiblingClassAttendedDt"];
                dt_SiblingClassAttendedDt.AdvancedSearch.SearchCondition = filter["v_dt_SiblingClassAttendedDt"];
                dt_SiblingClassAttendedDt.AdvancedSearch.SearchValue2 = filter["y_dt_SiblingClassAttendedDt"];
                dt_SiblingClassAttendedDt.AdvancedSearch.SearchOperator2 = filter["w_dt_SiblingClassAttendedDt"];
                dt_SiblingClassAttendedDt.AdvancedSearch.Save();
            }

            // Field str_SiblingClassAttendedLoc
            if (filter?.TryGetValue("x_str_SiblingClassAttendedLoc", out sv) ?? false) {
                str_SiblingClassAttendedLoc.AdvancedSearch.SearchValue = sv;
                str_SiblingClassAttendedLoc.AdvancedSearch.SearchOperator = filter["z_str_SiblingClassAttendedLoc"];
                str_SiblingClassAttendedLoc.AdvancedSearch.SearchCondition = filter["v_str_SiblingClassAttendedLoc"];
                str_SiblingClassAttendedLoc.AdvancedSearch.SearchValue2 = filter["y_str_SiblingClassAttendedLoc"];
                str_SiblingClassAttendedLoc.AdvancedSearch.SearchOperator2 = filter["w_str_SiblingClassAttendedLoc"];
                str_SiblingClassAttendedLoc.AdvancedSearch.Save();
            }

            // Field bit_PoliciesAndProcedures
            if (filter?.TryGetValue("x_bit_PoliciesAndProcedures", out sv) ?? false) {
                bit_PoliciesAndProcedures.AdvancedSearch.SearchValue = sv;
                bit_PoliciesAndProcedures.AdvancedSearch.SearchOperator = filter["z_bit_PoliciesAndProcedures"];
                bit_PoliciesAndProcedures.AdvancedSearch.SearchCondition = filter["v_bit_PoliciesAndProcedures"];
                bit_PoliciesAndProcedures.AdvancedSearch.SearchValue2 = filter["y_bit_PoliciesAndProcedures"];
                bit_PoliciesAndProcedures.AdvancedSearch.SearchOperator2 = filter["w_bit_PoliciesAndProcedures"];
                bit_PoliciesAndProcedures.AdvancedSearch.Save();
            }

            // Field dt_CourseCompletionDt
            if (filter?.TryGetValue("x_dt_CourseCompletionDt", out sv) ?? false) {
                dt_CourseCompletionDt.AdvancedSearch.SearchValue = sv;
                dt_CourseCompletionDt.AdvancedSearch.SearchOperator = filter["z_dt_CourseCompletionDt"];
                dt_CourseCompletionDt.AdvancedSearch.SearchCondition = filter["v_dt_CourseCompletionDt"];
                dt_CourseCompletionDt.AdvancedSearch.SearchValue2 = filter["y_dt_CourseCompletionDt"];
                dt_CourseCompletionDt.AdvancedSearch.SearchOperator2 = filter["w_dt_CourseCompletionDt"];
                dt_CourseCompletionDt.AdvancedSearch.Save();
            }

            // Field dt_ExtensionDt
            if (filter?.TryGetValue("x_dt_ExtensionDt", out sv) ?? false) {
                dt_ExtensionDt.AdvancedSearch.SearchValue = sv;
                dt_ExtensionDt.AdvancedSearch.SearchOperator = filter["z_dt_ExtensionDt"];
                dt_ExtensionDt.AdvancedSearch.SearchCondition = filter["v_dt_ExtensionDt"];
                dt_ExtensionDt.AdvancedSearch.SearchValue2 = filter["y_dt_ExtensionDt"];
                dt_ExtensionDt.AdvancedSearch.SearchOperator2 = filter["w_dt_ExtensionDt"];
                dt_ExtensionDt.AdvancedSearch.Save();
            }

            // Field str_MedicalCondition
            if (filter?.TryGetValue("x_str_MedicalCondition", out sv) ?? false) {
                str_MedicalCondition.AdvancedSearch.SearchValue = sv;
                str_MedicalCondition.AdvancedSearch.SearchOperator = filter["z_str_MedicalCondition"];
                str_MedicalCondition.AdvancedSearch.SearchCondition = filter["v_str_MedicalCondition"];
                str_MedicalCondition.AdvancedSearch.SearchValue2 = filter["y_str_MedicalCondition"];
                str_MedicalCondition.AdvancedSearch.SearchOperator2 = filter["w_str_MedicalCondition"];
                str_MedicalCondition.AdvancedSearch.Save();
            }

            // Field str_MajorCrossStreets
            if (filter?.TryGetValue("x_str_MajorCrossStreets", out sv) ?? false) {
                str_MajorCrossStreets.AdvancedSearch.SearchValue = sv;
                str_MajorCrossStreets.AdvancedSearch.SearchOperator = filter["z_str_MajorCrossStreets"];
                str_MajorCrossStreets.AdvancedSearch.SearchCondition = filter["v_str_MajorCrossStreets"];
                str_MajorCrossStreets.AdvancedSearch.SearchValue2 = filter["y_str_MajorCrossStreets"];
                str_MajorCrossStreets.AdvancedSearch.SearchOperator2 = filter["w_str_MajorCrossStreets"];
                str_MajorCrossStreets.AdvancedSearch.Save();
            }

            // Field str_DriverEdCertNo
            if (filter?.TryGetValue("x_str_DriverEdCertNo", out sv) ?? false) {
                str_DriverEdCertNo.AdvancedSearch.SearchValue = sv;
                str_DriverEdCertNo.AdvancedSearch.SearchOperator = filter["z_str_DriverEdCertNo"];
                str_DriverEdCertNo.AdvancedSearch.SearchCondition = filter["v_str_DriverEdCertNo"];
                str_DriverEdCertNo.AdvancedSearch.SearchValue2 = filter["y_str_DriverEdCertNo"];
                str_DriverEdCertNo.AdvancedSearch.SearchOperator2 = filter["w_str_DriverEdCertNo"];
                str_DriverEdCertNo.AdvancedSearch.Save();
            }

            // Field dt_DriverEdCertIssuedDt
            if (filter?.TryGetValue("x_dt_DriverEdCertIssuedDt", out sv) ?? false) {
                dt_DriverEdCertIssuedDt.AdvancedSearch.SearchValue = sv;
                dt_DriverEdCertIssuedDt.AdvancedSearch.SearchOperator = filter["z_dt_DriverEdCertIssuedDt"];
                dt_DriverEdCertIssuedDt.AdvancedSearch.SearchCondition = filter["v_dt_DriverEdCertIssuedDt"];
                dt_DriverEdCertIssuedDt.AdvancedSearch.SearchValue2 = filter["y_dt_DriverEdCertIssuedDt"];
                dt_DriverEdCertIssuedDt.AdvancedSearch.SearchOperator2 = filter["w_dt_DriverEdCertIssuedDt"];
                dt_DriverEdCertIssuedDt.AdvancedSearch.Save();
            }

            // Field str_BTWDriversEdCertNo
            if (filter?.TryGetValue("x_str_BTWDriversEdCertNo", out sv) ?? false) {
                str_BTWDriversEdCertNo.AdvancedSearch.SearchValue = sv;
                str_BTWDriversEdCertNo.AdvancedSearch.SearchOperator = filter["z_str_BTWDriversEdCertNo"];
                str_BTWDriversEdCertNo.AdvancedSearch.SearchCondition = filter["v_str_BTWDriversEdCertNo"];
                str_BTWDriversEdCertNo.AdvancedSearch.SearchValue2 = filter["y_str_BTWDriversEdCertNo"];
                str_BTWDriversEdCertNo.AdvancedSearch.SearchOperator2 = filter["w_str_BTWDriversEdCertNo"];
                str_BTWDriversEdCertNo.AdvancedSearch.Save();
            }

            // Field dt_BTWCertIssuedDt
            if (filter?.TryGetValue("x_dt_BTWCertIssuedDt", out sv) ?? false) {
                dt_BTWCertIssuedDt.AdvancedSearch.SearchValue = sv;
                dt_BTWCertIssuedDt.AdvancedSearch.SearchOperator = filter["z_dt_BTWCertIssuedDt"];
                dt_BTWCertIssuedDt.AdvancedSearch.SearchCondition = filter["v_dt_BTWCertIssuedDt"];
                dt_BTWCertIssuedDt.AdvancedSearch.SearchValue2 = filter["y_dt_BTWCertIssuedDt"];
                dt_BTWCertIssuedDt.AdvancedSearch.SearchOperator2 = filter["w_dt_BTWCertIssuedDt"];
                dt_BTWCertIssuedDt.AdvancedSearch.Save();
            }

            // Field str_OLDriversEdCertNo
            if (filter?.TryGetValue("x_str_OLDriversEdCertNo", out sv) ?? false) {
                str_OLDriversEdCertNo.AdvancedSearch.SearchValue = sv;
                str_OLDriversEdCertNo.AdvancedSearch.SearchOperator = filter["z_str_OLDriversEdCertNo"];
                str_OLDriversEdCertNo.AdvancedSearch.SearchCondition = filter["v_str_OLDriversEdCertNo"];
                str_OLDriversEdCertNo.AdvancedSearch.SearchValue2 = filter["y_str_OLDriversEdCertNo"];
                str_OLDriversEdCertNo.AdvancedSearch.SearchOperator2 = filter["w_str_OLDriversEdCertNo"];
                str_OLDriversEdCertNo.AdvancedSearch.Save();
            }

            // Field dt_OLCertIssuedDt
            if (filter?.TryGetValue("x_dt_OLCertIssuedDt", out sv) ?? false) {
                dt_OLCertIssuedDt.AdvancedSearch.SearchValue = sv;
                dt_OLCertIssuedDt.AdvancedSearch.SearchOperator = filter["z_dt_OLCertIssuedDt"];
                dt_OLCertIssuedDt.AdvancedSearch.SearchCondition = filter["v_dt_OLCertIssuedDt"];
                dt_OLCertIssuedDt.AdvancedSearch.SearchValue2 = filter["y_dt_OLCertIssuedDt"];
                dt_OLCertIssuedDt.AdvancedSearch.SearchOperator2 = filter["w_dt_OLCertIssuedDt"];
                dt_OLCertIssuedDt.AdvancedSearch.Save();
            }

            // Field str_height
            if (filter?.TryGetValue("x_str_height", out sv) ?? false) {
                str_height.AdvancedSearch.SearchValue = sv;
                str_height.AdvancedSearch.SearchOperator = filter["z_str_height"];
                str_height.AdvancedSearch.SearchCondition = filter["v_str_height"];
                str_height.AdvancedSearch.SearchValue2 = filter["y_str_height"];
                str_height.AdvancedSearch.SearchOperator2 = filter["w_str_height"];
                str_height.AdvancedSearch.Save();
            }

            // Field dt_BTWCompletionDt
            if (filter?.TryGetValue("x_dt_BTWCompletionDt", out sv) ?? false) {
                dt_BTWCompletionDt.AdvancedSearch.SearchValue = sv;
                dt_BTWCompletionDt.AdvancedSearch.SearchOperator = filter["z_dt_BTWCompletionDt"];
                dt_BTWCompletionDt.AdvancedSearch.SearchCondition = filter["v_dt_BTWCompletionDt"];
                dt_BTWCompletionDt.AdvancedSearch.SearchValue2 = filter["y_dt_BTWCompletionDt"];
                dt_BTWCompletionDt.AdvancedSearch.SearchOperator2 = filter["w_dt_BTWCompletionDt"];
                dt_BTWCompletionDt.AdvancedSearch.Save();
            }

            // Field dt_CRCompletionDt
            if (filter?.TryGetValue("x_dt_CRCompletionDt", out sv) ?? false) {
                dt_CRCompletionDt.AdvancedSearch.SearchValue = sv;
                dt_CRCompletionDt.AdvancedSearch.SearchOperator = filter["z_dt_CRCompletionDt"];
                dt_CRCompletionDt.AdvancedSearch.SearchCondition = filter["v_dt_CRCompletionDt"];
                dt_CRCompletionDt.AdvancedSearch.SearchValue2 = filter["y_dt_CRCompletionDt"];
                dt_CRCompletionDt.AdvancedSearch.SearchOperator2 = filter["w_dt_CRCompletionDt"];
                dt_CRCompletionDt.AdvancedSearch.Save();
            }

            // Field strTextBox5
            if (filter?.TryGetValue("x_strTextBox5", out sv) ?? false) {
                strTextBox5.AdvancedSearch.SearchValue = sv;
                strTextBox5.AdvancedSearch.SearchOperator = filter["z_strTextBox5"];
                strTextBox5.AdvancedSearch.SearchCondition = filter["v_strTextBox5"];
                strTextBox5.AdvancedSearch.SearchValue2 = filter["y_strTextBox5"];
                strTextBox5.AdvancedSearch.SearchOperator2 = filter["w_strTextBox5"];
                strTextBox5.AdvancedSearch.Save();
            }

            // Field strTextBox6
            if (filter?.TryGetValue("x_strTextBox6", out sv) ?? false) {
                strTextBox6.AdvancedSearch.SearchValue = sv;
                strTextBox6.AdvancedSearch.SearchOperator = filter["z_strTextBox6"];
                strTextBox6.AdvancedSearch.SearchCondition = filter["v_strTextBox6"];
                strTextBox6.AdvancedSearch.SearchValue2 = filter["y_strTextBox6"];
                strTextBox6.AdvancedSearch.SearchOperator2 = filter["w_strTextBox6"];
                strTextBox6.AdvancedSearch.Save();
            }

            // Field str_ApartmentNo
            if (filter?.TryGetValue("x_str_ApartmentNo", out sv) ?? false) {
                str_ApartmentNo.AdvancedSearch.SearchValue = sv;
                str_ApartmentNo.AdvancedSearch.SearchOperator = filter["z_str_ApartmentNo"];
                str_ApartmentNo.AdvancedSearch.SearchCondition = filter["v_str_ApartmentNo"];
                str_ApartmentNo.AdvancedSearch.SearchValue2 = filter["y_str_ApartmentNo"];
                str_ApartmentNo.AdvancedSearch.SearchOperator2 = filter["w_str_ApartmentNo"];
                str_ApartmentNo.AdvancedSearch.Save();
            }

            // Field dt_PermitTestDate
            if (filter?.TryGetValue("x_dt_PermitTestDate", out sv) ?? false) {
                dt_PermitTestDate.AdvancedSearch.SearchValue = sv;
                dt_PermitTestDate.AdvancedSearch.SearchOperator = filter["z_dt_PermitTestDate"];
                dt_PermitTestDate.AdvancedSearch.SearchCondition = filter["v_dt_PermitTestDate"];
                dt_PermitTestDate.AdvancedSearch.SearchValue2 = filter["y_dt_PermitTestDate"];
                dt_PermitTestDate.AdvancedSearch.SearchOperator2 = filter["w_dt_PermitTestDate"];
                dt_PermitTestDate.AdvancedSearch.Save();
            }

            // Field str_OnlineDriverEdLogin
            if (filter?.TryGetValue("x_str_OnlineDriverEdLogin", out sv) ?? false) {
                str_OnlineDriverEdLogin.AdvancedSearch.SearchValue = sv;
                str_OnlineDriverEdLogin.AdvancedSearch.SearchOperator = filter["z_str_OnlineDriverEdLogin"];
                str_OnlineDriverEdLogin.AdvancedSearch.SearchCondition = filter["v_str_OnlineDriverEdLogin"];
                str_OnlineDriverEdLogin.AdvancedSearch.SearchValue2 = filter["y_str_OnlineDriverEdLogin"];
                str_OnlineDriverEdLogin.AdvancedSearch.SearchOperator2 = filter["w_str_OnlineDriverEdLogin"];
                str_OnlineDriverEdLogin.AdvancedSearch.Save();
            }

            // Field str_OnlineDriverEdPassword
            if (filter?.TryGetValue("x_str_OnlineDriverEdPassword", out sv) ?? false) {
                str_OnlineDriverEdPassword.AdvancedSearch.SearchValue = sv;
                str_OnlineDriverEdPassword.AdvancedSearch.SearchOperator = filter["z_str_OnlineDriverEdPassword"];
                str_OnlineDriverEdPassword.AdvancedSearch.SearchCondition = filter["v_str_OnlineDriverEdPassword"];
                str_OnlineDriverEdPassword.AdvancedSearch.SearchValue2 = filter["y_str_OnlineDriverEdPassword"];
                str_OnlineDriverEdPassword.AdvancedSearch.SearchOperator2 = filter["w_str_OnlineDriverEdPassword"];
                str_OnlineDriverEdPassword.AdvancedSearch.Save();
            }

            // Field bit_IsSMSEnabled
            if (filter?.TryGetValue("x_bit_IsSMSEnabled", out sv) ?? false) {
                bit_IsSMSEnabled.AdvancedSearch.SearchValue = sv;
                bit_IsSMSEnabled.AdvancedSearch.SearchOperator = filter["z_bit_IsSMSEnabled"];
                bit_IsSMSEnabled.AdvancedSearch.SearchCondition = filter["v_bit_IsSMSEnabled"];
                bit_IsSMSEnabled.AdvancedSearch.SearchValue2 = filter["y_bit_IsSMSEnabled"];
                bit_IsSMSEnabled.AdvancedSearch.SearchOperator2 = filter["w_bit_IsSMSEnabled"];
                bit_IsSMSEnabled.AdvancedSearch.Save();
            }

            // Field dt_SMSModified
            if (filter?.TryGetValue("x_dt_SMSModified", out sv) ?? false) {
                dt_SMSModified.AdvancedSearch.SearchValue = sv;
                dt_SMSModified.AdvancedSearch.SearchOperator = filter["z_dt_SMSModified"];
                dt_SMSModified.AdvancedSearch.SearchCondition = filter["v_dt_SMSModified"];
                dt_SMSModified.AdvancedSearch.SearchValue2 = filter["y_dt_SMSModified"];
                dt_SMSModified.AdvancedSearch.SearchOperator2 = filter["w_dt_SMSModified"];
                dt_SMSModified.AdvancedSearch.Save();
            }

            // Field str_confirmPassword
            if (filter?.TryGetValue("x_str_confirmPassword", out sv) ?? false) {
                str_confirmPassword.AdvancedSearch.SearchValue = sv;
                str_confirmPassword.AdvancedSearch.SearchOperator = filter["z_str_confirmPassword"];
                str_confirmPassword.AdvancedSearch.SearchCondition = filter["v_str_confirmPassword"];
                str_confirmPassword.AdvancedSearch.SearchValue2 = filter["y_str_confirmPassword"];
                str_confirmPassword.AdvancedSearch.SearchOperator2 = filter["w_str_confirmPassword"];
                str_confirmPassword.AdvancedSearch.Save();
            }

            // Field DE_Certificate
            if (filter?.TryGetValue("x_DE_Certificate", out sv) ?? false) {
                DE_Certificate.AdvancedSearch.SearchValue = sv;
                DE_Certificate.AdvancedSearch.SearchOperator = filter["z_DE_Certificate"];
                DE_Certificate.AdvancedSearch.SearchCondition = filter["v_DE_Certificate"];
                DE_Certificate.AdvancedSearch.SearchValue2 = filter["y_DE_Certificate"];
                DE_Certificate.AdvancedSearch.SearchOperator2 = filter["w_DE_Certificate"];
                DE_Certificate.AdvancedSearch.Save();
            }

            // Field Discuss
            if (filter?.TryGetValue("x_Discuss", out sv) ?? false) {
                Discuss.AdvancedSearch.SearchValue = sv;
                Discuss.AdvancedSearch.SearchOperator = filter["z_Discuss"];
                Discuss.AdvancedSearch.SearchCondition = filter["v_Discuss"];
                Discuss.AdvancedSearch.SearchValue2 = filter["y_Discuss"];
                Discuss.AdvancedSearch.SearchOperator2 = filter["w_Discuss"];
                Discuss.AdvancedSearch.Save();
            }

            // Field int_UnlicensedSibling
            if (filter?.TryGetValue("x_int_UnlicensedSibling", out sv) ?? false) {
                int_UnlicensedSibling.AdvancedSearch.SearchValue = sv;
                int_UnlicensedSibling.AdvancedSearch.SearchOperator = filter["z_int_UnlicensedSibling"];
                int_UnlicensedSibling.AdvancedSearch.SearchCondition = filter["v_int_UnlicensedSibling"];
                int_UnlicensedSibling.AdvancedSearch.SearchValue2 = filter["y_int_UnlicensedSibling"];
                int_UnlicensedSibling.AdvancedSearch.SearchOperator2 = filter["w_int_UnlicensedSibling"];
                int_UnlicensedSibling.AdvancedSearch.Save();
            }

            // Field int_YearSiblingIsEligible
            if (filter?.TryGetValue("x_int_YearSiblingIsEligible", out sv) ?? false) {
                int_YearSiblingIsEligible.AdvancedSearch.SearchValue = sv;
                int_YearSiblingIsEligible.AdvancedSearch.SearchOperator = filter["z_int_YearSiblingIsEligible"];
                int_YearSiblingIsEligible.AdvancedSearch.SearchCondition = filter["v_int_YearSiblingIsEligible"];
                int_YearSiblingIsEligible.AdvancedSearch.SearchValue2 = filter["y_int_YearSiblingIsEligible"];
                int_YearSiblingIsEligible.AdvancedSearch.SearchOperator2 = filter["w_int_YearSiblingIsEligible"];
                int_YearSiblingIsEligible.AdvancedSearch.Save();
            }

            // Field BTW_Certificate
            if (filter?.TryGetValue("x_BTW_Certificate", out sv) ?? false) {
                BTW_Certificate.AdvancedSearch.SearchValue = sv;
                BTW_Certificate.AdvancedSearch.SearchOperator = filter["z_BTW_Certificate"];
                BTW_Certificate.AdvancedSearch.SearchCondition = filter["v_BTW_Certificate"];
                BTW_Certificate.AdvancedSearch.SearchValue2 = filter["y_BTW_Certificate"];
                BTW_Certificate.AdvancedSearch.SearchOperator2 = filter["w_BTW_Certificate"];
                BTW_Certificate.AdvancedSearch.Save();
            }

            // Field dt_DECertIssueDate
            if (filter?.TryGetValue("x_dt_DECertIssueDate", out sv) ?? false) {
                dt_DECertIssueDate.AdvancedSearch.SearchValue = sv;
                dt_DECertIssueDate.AdvancedSearch.SearchOperator = filter["z_dt_DECertIssueDate"];
                dt_DECertIssueDate.AdvancedSearch.SearchCondition = filter["v_dt_DECertIssueDate"];
                dt_DECertIssueDate.AdvancedSearch.SearchValue2 = filter["y_dt_DECertIssueDate"];
                dt_DECertIssueDate.AdvancedSearch.SearchOperator2 = filter["w_dt_DECertIssueDate"];
                dt_DECertIssueDate.AdvancedSearch.Save();
            }

            // Field str_StudentSignature
            if (filter?.TryGetValue("x_str_StudentSignature", out sv) ?? false) {
                str_StudentSignature.AdvancedSearch.SearchValue = sv;
                str_StudentSignature.AdvancedSearch.SearchOperator = filter["z_str_StudentSignature"];
                str_StudentSignature.AdvancedSearch.SearchCondition = filter["v_str_StudentSignature"];
                str_StudentSignature.AdvancedSearch.SearchValue2 = filter["y_str_StudentSignature"];
                str_StudentSignature.AdvancedSearch.SearchOperator2 = filter["w_str_StudentSignature"];
                str_StudentSignature.AdvancedSearch.Save();
            }

            // Field str_ParentSignature
            if (filter?.TryGetValue("x_str_ParentSignature", out sv) ?? false) {
                str_ParentSignature.AdvancedSearch.SearchValue = sv;
                str_ParentSignature.AdvancedSearch.SearchOperator = filter["z_str_ParentSignature"];
                str_ParentSignature.AdvancedSearch.SearchCondition = filter["v_str_ParentSignature"];
                str_ParentSignature.AdvancedSearch.SearchValue2 = filter["y_str_ParentSignature"];
                str_ParentSignature.AdvancedSearch.SearchOperator2 = filter["w_str_ParentSignature"];
                str_ParentSignature.AdvancedSearch.Save();
            }

            // Field str_Last6DigitsOfParentDriversLicense
            if (filter?.TryGetValue("x_str_Last6DigitsOfParentDriversLicense", out sv) ?? false) {
                str_Last6DigitsOfParentDriversLicense.AdvancedSearch.SearchValue = sv;
                str_Last6DigitsOfParentDriversLicense.AdvancedSearch.SearchOperator = filter["z_str_Last6DigitsOfParentDriversLicense"];
                str_Last6DigitsOfParentDriversLicense.AdvancedSearch.SearchCondition = filter["v_str_Last6DigitsOfParentDriversLicense"];
                str_Last6DigitsOfParentDriversLicense.AdvancedSearch.SearchValue2 = filter["y_str_Last6DigitsOfParentDriversLicense"];
                str_Last6DigitsOfParentDriversLicense.AdvancedSearch.SearchOperator2 = filter["w_str_Last6DigitsOfParentDriversLicense"];
                str_Last6DigitsOfParentDriversLicense.AdvancedSearch.Save();
            }

            // Field str_FACControl
            if (filter?.TryGetValue("x_str_FACControl", out sv) ?? false) {
                str_FACControl.AdvancedSearch.SearchValue = sv;
                str_FACControl.AdvancedSearch.SearchOperator = filter["z_str_FACControl"];
                str_FACControl.AdvancedSearch.SearchCondition = filter["v_str_FACControl"];
                str_FACControl.AdvancedSearch.SearchValue2 = filter["y_str_FACControl"];
                str_FACControl.AdvancedSearch.SearchOperator2 = filter["w_str_FACControl"];
                str_FACControl.AdvancedSearch.Save();
            }

            // Field Classroom_Status_Code
            if (filter?.TryGetValue("x_Classroom_Status_Code", out sv) ?? false) {
                Classroom_Status_Code.AdvancedSearch.SearchValue = sv;
                Classroom_Status_Code.AdvancedSearch.SearchOperator = filter["z_Classroom_Status_Code"];
                Classroom_Status_Code.AdvancedSearch.SearchCondition = filter["v_Classroom_Status_Code"];
                Classroom_Status_Code.AdvancedSearch.SearchValue2 = filter["y_Classroom_Status_Code"];
                Classroom_Status_Code.AdvancedSearch.SearchOperator2 = filter["w_Classroom_Status_Code"];
                Classroom_Status_Code.AdvancedSearch.Save();
            }

            // Field Laboratory_Status_Code
            if (filter?.TryGetValue("x_Laboratory_Status_Code", out sv) ?? false) {
                Laboratory_Status_Code.AdvancedSearch.SearchValue = sv;
                Laboratory_Status_Code.AdvancedSearch.SearchOperator = filter["z_Laboratory_Status_Code"];
                Laboratory_Status_Code.AdvancedSearch.SearchCondition = filter["v_Laboratory_Status_Code"];
                Laboratory_Status_Code.AdvancedSearch.SearchValue2 = filter["y_Laboratory_Status_Code"];
                Laboratory_Status_Code.AdvancedSearch.SearchOperator2 = filter["w_Laboratory_Status_Code"];
                Laboratory_Status_Code.AdvancedSearch.Save();
            }

            // Field bit_EnrollmentForm
            if (filter?.TryGetValue("x_bit_EnrollmentForm", out sv) ?? false) {
                bit_EnrollmentForm.AdvancedSearch.SearchValue = sv;
                bit_EnrollmentForm.AdvancedSearch.SearchOperator = filter["z_bit_EnrollmentForm"];
                bit_EnrollmentForm.AdvancedSearch.SearchCondition = filter["v_bit_EnrollmentForm"];
                bit_EnrollmentForm.AdvancedSearch.SearchValue2 = filter["y_bit_EnrollmentForm"];
                bit_EnrollmentForm.AdvancedSearch.SearchOperator2 = filter["w_bit_EnrollmentForm"];
                bit_EnrollmentForm.AdvancedSearch.Save();
            }

            // Field bit_ParentStudentContract
            if (filter?.TryGetValue("x_bit_ParentStudentContract", out sv) ?? false) {
                bit_ParentStudentContract.AdvancedSearch.SearchValue = sv;
                bit_ParentStudentContract.AdvancedSearch.SearchOperator = filter["z_bit_ParentStudentContract"];
                bit_ParentStudentContract.AdvancedSearch.SearchCondition = filter["v_bit_ParentStudentContract"];
                bit_ParentStudentContract.AdvancedSearch.SearchValue2 = filter["y_bit_ParentStudentContract"];
                bit_ParentStudentContract.AdvancedSearch.SearchOperator2 = filter["w_bit_ParentStudentContract"];
                bit_ParentStudentContract.AdvancedSearch.Save();
            }

            // Field bit_ParentalAgreement
            if (filter?.TryGetValue("x_bit_ParentalAgreement", out sv) ?? false) {
                bit_ParentalAgreement.AdvancedSearch.SearchValue = sv;
                bit_ParentalAgreement.AdvancedSearch.SearchOperator = filter["z_bit_ParentalAgreement"];
                bit_ParentalAgreement.AdvancedSearch.SearchCondition = filter["v_bit_ParentalAgreement"];
                bit_ParentalAgreement.AdvancedSearch.SearchValue2 = filter["y_bit_ParentalAgreement"];
                bit_ParentalAgreement.AdvancedSearch.SearchOperator2 = filter["w_bit_ParentalAgreement"];
                bit_ParentalAgreement.AdvancedSearch.Save();
            }

            // Field int_SF_GR_WA_HS
            if (filter?.TryGetValue("x_int_SF_GR_WA_HS", out sv) ?? false) {
                int_SF_GR_WA_HS.AdvancedSearch.SearchValue = sv;
                int_SF_GR_WA_HS.AdvancedSearch.SearchOperator = filter["z_int_SF_GR_WA_HS"];
                int_SF_GR_WA_HS.AdvancedSearch.SearchCondition = filter["v_int_SF_GR_WA_HS"];
                int_SF_GR_WA_HS.AdvancedSearch.SearchValue2 = filter["y_int_SF_GR_WA_HS"];
                int_SF_GR_WA_HS.AdvancedSearch.SearchOperator2 = filter["w_int_SF_GR_WA_HS"];
                int_SF_GR_WA_HS.AdvancedSearch.Save();
            }

            // Field bit_DisableOnRMV
            if (filter?.TryGetValue("x_bit_DisableOnRMV", out sv) ?? false) {
                bit_DisableOnRMV.AdvancedSearch.SearchValue = sv;
                bit_DisableOnRMV.AdvancedSearch.SearchOperator = filter["z_bit_DisableOnRMV"];
                bit_DisableOnRMV.AdvancedSearch.SearchCondition = filter["v_bit_DisableOnRMV"];
                bit_DisableOnRMV.AdvancedSearch.SearchValue2 = filter["y_bit_DisableOnRMV"];
                bit_DisableOnRMV.AdvancedSearch.SearchOperator2 = filter["w_bit_DisableOnRMV"];
                bit_DisableOnRMV.AdvancedSearch.Save();
            }

            // Field bit_UploadedToRMV
            if (filter?.TryGetValue("x_bit_UploadedToRMV", out sv) ?? false) {
                bit_UploadedToRMV.AdvancedSearch.SearchValue = sv;
                bit_UploadedToRMV.AdvancedSearch.SearchOperator = filter["z_bit_UploadedToRMV"];
                bit_UploadedToRMV.AdvancedSearch.SearchCondition = filter["v_bit_UploadedToRMV"];
                bit_UploadedToRMV.AdvancedSearch.SearchValue2 = filter["y_bit_UploadedToRMV"];
                bit_UploadedToRMV.AdvancedSearch.SearchOperator2 = filter["w_bit_UploadedToRMV"];
                bit_UploadedToRMV.AdvancedSearch.Save();
            }

            // Field str_Mother_Name
            if (filter?.TryGetValue("x_str_Mother_Name", out sv) ?? false) {
                str_Mother_Name.AdvancedSearch.SearchValue = sv;
                str_Mother_Name.AdvancedSearch.SearchOperator = filter["z_str_Mother_Name"];
                str_Mother_Name.AdvancedSearch.SearchCondition = filter["v_str_Mother_Name"];
                str_Mother_Name.AdvancedSearch.SearchValue2 = filter["y_str_Mother_Name"];
                str_Mother_Name.AdvancedSearch.SearchOperator2 = filter["w_str_Mother_Name"];
                str_Mother_Name.AdvancedSearch.Save();
            }

            // Field str_Guardians_Name
            if (filter?.TryGetValue("x_str_Guardians_Name", out sv) ?? false) {
                str_Guardians_Name.AdvancedSearch.SearchValue = sv;
                str_Guardians_Name.AdvancedSearch.SearchOperator = filter["z_str_Guardians_Name"];
                str_Guardians_Name.AdvancedSearch.SearchCondition = filter["v_str_Guardians_Name"];
                str_Guardians_Name.AdvancedSearch.SearchValue2 = filter["y_str_Guardians_Name"];
                str_Guardians_Name.AdvancedSearch.SearchOperator2 = filter["w_str_Guardians_Name"];
                str_Guardians_Name.AdvancedSearch.Save();
            }

            // Field str_Mother_Phone
            if (filter?.TryGetValue("x_str_Mother_Phone", out sv) ?? false) {
                str_Mother_Phone.AdvancedSearch.SearchValue = sv;
                str_Mother_Phone.AdvancedSearch.SearchOperator = filter["z_str_Mother_Phone"];
                str_Mother_Phone.AdvancedSearch.SearchCondition = filter["v_str_Mother_Phone"];
                str_Mother_Phone.AdvancedSearch.SearchValue2 = filter["y_str_Mother_Phone"];
                str_Mother_Phone.AdvancedSearch.SearchOperator2 = filter["w_str_Mother_Phone"];
                str_Mother_Phone.AdvancedSearch.Save();
            }

            // Field bit_terms
            if (filter?.TryGetValue("x_bit_terms", out sv) ?? false) {
                bit_terms.AdvancedSearch.SearchValue = sv;
                bit_terms.AdvancedSearch.SearchOperator = filter["z_bit_terms"];
                bit_terms.AdvancedSearch.SearchCondition = filter["v_bit_terms"];
                bit_terms.AdvancedSearch.SearchValue2 = filter["y_bit_terms"];
                bit_terms.AdvancedSearch.SearchOperator2 = filter["w_bit_terms"];
                bit_terms.AdvancedSearch.Save();
            }

            // Field int_Nationality
            if (filter?.TryGetValue("x_int_Nationality", out sv) ?? false) {
                int_Nationality.AdvancedSearch.SearchValue = sv;
                int_Nationality.AdvancedSearch.SearchOperator = filter["z_int_Nationality"];
                int_Nationality.AdvancedSearch.SearchCondition = filter["v_int_Nationality"];
                int_Nationality.AdvancedSearch.SearchValue2 = filter["y_int_Nationality"];
                int_Nationality.AdvancedSearch.SearchOperator2 = filter["w_int_Nationality"];
                int_Nationality.AdvancedSearch.Save();
            }

            // Field str_National_ID_en
            if (filter?.TryGetValue("x_str_National_ID_en", out sv) ?? false) {
                str_National_ID_en.AdvancedSearch.SearchValue = sv;
                str_National_ID_en.AdvancedSearch.SearchOperator = filter["z_str_National_ID_en"];
                str_National_ID_en.AdvancedSearch.SearchCondition = filter["v_str_National_ID_en"];
                str_National_ID_en.AdvancedSearch.SearchValue2 = filter["y_str_National_ID_en"];
                str_National_ID_en.AdvancedSearch.SearchOperator2 = filter["w_str_National_ID_en"];
                str_National_ID_en.AdvancedSearch.Save();
            }

            // Field str_National_ID_arabic
            if (filter?.TryGetValue("x_str_National_ID_arabic", out sv) ?? false) {
                str_National_ID_arabic.AdvancedSearch.SearchValue = sv;
                str_National_ID_arabic.AdvancedSearch.SearchOperator = filter["z_str_National_ID_arabic"];
                str_National_ID_arabic.AdvancedSearch.SearchCondition = filter["v_str_National_ID_arabic"];
                str_National_ID_arabic.AdvancedSearch.SearchValue2 = filter["y_str_National_ID_arabic"];
                str_National_ID_arabic.AdvancedSearch.SearchOperator2 = filter["w_str_National_ID_arabic"];
                str_National_ID_arabic.AdvancedSearch.Save();
            }

            // Field Quallification_Id
            if (filter?.TryGetValue("x_Quallification_Id", out sv) ?? false) {
                Quallification_Id.AdvancedSearch.SearchValue = sv;
                Quallification_Id.AdvancedSearch.SearchOperator = filter["z_Quallification_Id"];
                Quallification_Id.AdvancedSearch.SearchCondition = filter["v_Quallification_Id"];
                Quallification_Id.AdvancedSearch.SearchValue2 = filter["y_Quallification_Id"];
                Quallification_Id.AdvancedSearch.SearchOperator2 = filter["w_Quallification_Id"];
                Quallification_Id.AdvancedSearch.Save();
            }

            // Field Job_Id
            if (filter?.TryGetValue("x_Job_Id", out sv) ?? false) {
                Job_Id.AdvancedSearch.SearchValue = sv;
                Job_Id.AdvancedSearch.SearchOperator = filter["z_Job_Id"];
                Job_Id.AdvancedSearch.SearchCondition = filter["v_Job_Id"];
                Job_Id.AdvancedSearch.SearchValue2 = filter["y_Job_Id"];
                Job_Id.AdvancedSearch.SearchOperator2 = filter["w_Job_Id"];
                Job_Id.AdvancedSearch.Save();
            }

            // Field str_DOB_arabic
            if (filter?.TryGetValue("x_str_DOB_arabic", out sv) ?? false) {
                str_DOB_arabic.AdvancedSearch.SearchValue = sv;
                str_DOB_arabic.AdvancedSearch.SearchOperator = filter["z_str_DOB_arabic"];
                str_DOB_arabic.AdvancedSearch.SearchCondition = filter["v_str_DOB_arabic"];
                str_DOB_arabic.AdvancedSearch.SearchValue2 = filter["y_str_DOB_arabic"];
                str_DOB_arabic.AdvancedSearch.SearchOperator2 = filter["w_str_DOB_arabic"];
                str_DOB_arabic.AdvancedSearch.Save();
            }

            // Field int_Language
            if (filter?.TryGetValue("x_int_Language", out sv) ?? false) {
                int_Language.AdvancedSearch.SearchValue = sv;
                int_Language.AdvancedSearch.SearchOperator = filter["z_int_Language"];
                int_Language.AdvancedSearch.SearchCondition = filter["v_int_Language"];
                int_Language.AdvancedSearch.SearchValue2 = filter["y_int_Language"];
                int_Language.AdvancedSearch.SearchOperator2 = filter["w_int_Language"];
                int_Language.AdvancedSearch.Save();
            }

            // Field strRefId
            if (filter?.TryGetValue("x_strRefId", out sv) ?? false) {
                strRefId.AdvancedSearch.SearchValue = sv;
                strRefId.AdvancedSearch.SearchOperator = filter["z_strRefId"];
                strRefId.AdvancedSearch.SearchCondition = filter["v_strRefId"];
                strRefId.AdvancedSearch.SearchValue2 = filter["y_strRefId"];
                strRefId.AdvancedSearch.SearchOperator2 = filter["w_strRefId"];
                strRefId.AdvancedSearch.Save();
            }

            // Field int_Program_Id
            if (filter?.TryGetValue("x_int_Program_Id", out sv) ?? false) {
                int_Program_Id.AdvancedSearch.SearchValue = sv;
                int_Program_Id.AdvancedSearch.SearchOperator = filter["z_int_Program_Id"];
                int_Program_Id.AdvancedSearch.SearchCondition = filter["v_int_Program_Id"];
                int_Program_Id.AdvancedSearch.SearchValue2 = filter["y_int_Program_Id"];
                int_Program_Id.AdvancedSearch.SearchOperator2 = filter["w_int_Program_Id"];
                int_Program_Id.AdvancedSearch.Save();
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

            // Field IsScheduleassessment
            if (filter?.TryGetValue("x_IsScheduleassessment", out sv) ?? false) {
                IsScheduleassessment.AdvancedSearch.SearchValue = sv;
                IsScheduleassessment.AdvancedSearch.SearchOperator = filter["z_IsScheduleassessment"];
                IsScheduleassessment.AdvancedSearch.SearchCondition = filter["v_IsScheduleassessment"];
                IsScheduleassessment.AdvancedSearch.SearchValue2 = filter["y_IsScheduleassessment"];
                IsScheduleassessment.AdvancedSearch.SearchOperator2 = filter["w_IsScheduleassessment"];
                IsScheduleassessment.AdvancedSearch.Save();
            }

            // Field IsEnrollbyyourself
            if (filter?.TryGetValue("x_IsEnrollbyyourself", out sv) ?? false) {
                IsEnrollbyyourself.AdvancedSearch.SearchValue = sv;
                IsEnrollbyyourself.AdvancedSearch.SearchOperator = filter["z_IsEnrollbyyourself"];
                IsEnrollbyyourself.AdvancedSearch.SearchCondition = filter["v_IsEnrollbyyourself"];
                IsEnrollbyyourself.AdvancedSearch.SearchValue2 = filter["y_IsEnrollbyyourself"];
                IsEnrollbyyourself.AdvancedSearch.SearchOperator2 = filter["w_IsEnrollbyyourself"];
                IsEnrollbyyourself.AdvancedSearch.Save();
            }

            // Field AssessmentTime
            if (filter?.TryGetValue("x_AssessmentTime", out sv) ?? false) {
                AssessmentTime.AdvancedSearch.SearchValue = sv;
                AssessmentTime.AdvancedSearch.SearchOperator = filter["z_AssessmentTime"];
                AssessmentTime.AdvancedSearch.SearchCondition = filter["v_AssessmentTime"];
                AssessmentTime.AdvancedSearch.SearchValue2 = filter["y_AssessmentTime"];
                AssessmentTime.AdvancedSearch.SearchOperator2 = filter["w_AssessmentTime"];
                AssessmentTime.AdvancedSearch.Save();
            }

            // Field AssessmentDate
            if (filter?.TryGetValue("x_AssessmentDate", out sv) ?? false) {
                AssessmentDate.AdvancedSearch.SearchValue = sv;
                AssessmentDate.AdvancedSearch.SearchOperator = filter["z_AssessmentDate"];
                AssessmentDate.AdvancedSearch.SearchCondition = filter["v_AssessmentDate"];
                AssessmentDate.AdvancedSearch.SearchValue2 = filter["y_AssessmentDate"];
                AssessmentDate.AdvancedSearch.SearchOperator2 = filter["w_AssessmentDate"];
                AssessmentDate.AdvancedSearch.Save();
            }

            // Field isAssessmentDone
            if (filter?.TryGetValue("x_isAssessmentDone", out sv) ?? false) {
                isAssessmentDone.AdvancedSearch.SearchValue = sv;
                isAssessmentDone.AdvancedSearch.SearchOperator = filter["z_isAssessmentDone"];
                isAssessmentDone.AdvancedSearch.SearchCondition = filter["v_isAssessmentDone"];
                isAssessmentDone.AdvancedSearch.SearchValue2 = filter["y_isAssessmentDone"];
                isAssessmentDone.AdvancedSearch.SearchOperator2 = filter["w_isAssessmentDone"];
                isAssessmentDone.AdvancedSearch.Save();
            }

            // Field AssessmentScore
            if (filter?.TryGetValue("x_AssessmentScore", out sv) ?? false) {
                AssessmentScore.AdvancedSearch.SearchValue = sv;
                AssessmentScore.AdvancedSearch.SearchOperator = filter["z_AssessmentScore"];
                AssessmentScore.AdvancedSearch.SearchCondition = filter["v_AssessmentScore"];
                AssessmentScore.AdvancedSearch.SearchValue2 = filter["y_AssessmentScore"];
                AssessmentScore.AdvancedSearch.SearchOperator2 = filter["w_AssessmentScore"];
                AssessmentScore.AdvancedSearch.Save();
            }

            // Field dt_WrittenTestPassed
            if (filter?.TryGetValue("x_dt_WrittenTestPassed", out sv) ?? false) {
                dt_WrittenTestPassed.AdvancedSearch.SearchValue = sv;
                dt_WrittenTestPassed.AdvancedSearch.SearchOperator = filter["z_dt_WrittenTestPassed"];
                dt_WrittenTestPassed.AdvancedSearch.SearchCondition = filter["v_dt_WrittenTestPassed"];
                dt_WrittenTestPassed.AdvancedSearch.SearchValue2 = filter["y_dt_WrittenTestPassed"];
                dt_WrittenTestPassed.AdvancedSearch.SearchOperator2 = filter["w_dt_WrittenTestPassed"];
                dt_WrittenTestPassed.AdvancedSearch.Save();
            }

            // Field dt_RoadTestPassed
            if (filter?.TryGetValue("x_dt_RoadTestPassed", out sv) ?? false) {
                dt_RoadTestPassed.AdvancedSearch.SearchValue = sv;
                dt_RoadTestPassed.AdvancedSearch.SearchOperator = filter["z_dt_RoadTestPassed"];
                dt_RoadTestPassed.AdvancedSearch.SearchCondition = filter["v_dt_RoadTestPassed"];
                dt_RoadTestPassed.AdvancedSearch.SearchValue2 = filter["y_dt_RoadTestPassed"];
                dt_RoadTestPassed.AdvancedSearch.SearchOperator2 = filter["w_dt_RoadTestPassed"];
                dt_RoadTestPassed.AdvancedSearch.Save();
            }

            // Field bit_Archive
            if (filter?.TryGetValue("x_bit_Archive", out sv) ?? false) {
                bit_Archive.AdvancedSearch.SearchValue = sv;
                bit_Archive.AdvancedSearch.SearchOperator = filter["z_bit_Archive"];
                bit_Archive.AdvancedSearch.SearchCondition = filter["v_bit_Archive"];
                bit_Archive.AdvancedSearch.SearchValue2 = filter["y_bit_Archive"];
                bit_Archive.AdvancedSearch.SearchOperator2 = filter["w_bit_Archive"];
                bit_Archive.AdvancedSearch.Save();
            }

            // Field ArchiveNotes
            if (filter?.TryGetValue("x_ArchiveNotes", out sv) ?? false) {
                ArchiveNotes.AdvancedSearch.SearchValue = sv;
                ArchiveNotes.AdvancedSearch.SearchOperator = filter["z_ArchiveNotes"];
                ArchiveNotes.AdvancedSearch.SearchCondition = filter["v_ArchiveNotes"];
                ArchiveNotes.AdvancedSearch.SearchValue2 = filter["y_ArchiveNotes"];
                ArchiveNotes.AdvancedSearch.SearchOperator2 = filter["w_ArchiveNotes"];
                ArchiveNotes.AdvancedSearch.Save();
            }

            // Field dtArchived
            if (filter?.TryGetValue("x_dtArchived", out sv) ?? false) {
                dtArchived.AdvancedSearch.SearchValue = sv;
                dtArchived.AdvancedSearch.SearchOperator = filter["z_dtArchived"];
                dtArchived.AdvancedSearch.SearchCondition = filter["v_dtArchived"];
                dtArchived.AdvancedSearch.SearchValue2 = filter["y_dtArchived"];
                dtArchived.AdvancedSearch.SearchOperator2 = filter["w_dtArchived"];
                dtArchived.AdvancedSearch.Save();
            }

            // Field SrNo9Dec21
            if (filter?.TryGetValue("x_SrNo9Dec21", out sv) ?? false) {
                SrNo9Dec21.AdvancedSearch.SearchValue = sv;
                SrNo9Dec21.AdvancedSearch.SearchOperator = filter["z_SrNo9Dec21"];
                SrNo9Dec21.AdvancedSearch.SearchCondition = filter["v_SrNo9Dec21"];
                SrNo9Dec21.AdvancedSearch.SearchValue2 = filter["y_SrNo9Dec21"];
                SrNo9Dec21.AdvancedSearch.SearchOperator2 = filter["w_SrNo9Dec21"];
                SrNo9Dec21.AdvancedSearch.Save();
            }

            // Field REGNNUMB
            if (filter?.TryGetValue("x_REGNNUMB", out sv) ?? false) {
                REGNNUMB.AdvancedSearch.SearchValue = sv;
                REGNNUMB.AdvancedSearch.SearchOperator = filter["z_REGNNUMB"];
                REGNNUMB.AdvancedSearch.SearchCondition = filter["v_REGNNUMB"];
                REGNNUMB.AdvancedSearch.SearchValue2 = filter["y_REGNNUMB"];
                REGNNUMB.AdvancedSearch.SearchOperator2 = filter["w_REGNNUMB"];
                REGNNUMB.AdvancedSearch.Save();
            }

            // Field REGNLOCN
            if (filter?.TryGetValue("x_REGNLOCN", out sv) ?? false) {
                REGNLOCN.AdvancedSearch.SearchValue = sv;
                REGNLOCN.AdvancedSearch.SearchOperator = filter["z_REGNLOCN"];
                REGNLOCN.AdvancedSearch.SearchCondition = filter["v_REGNLOCN"];
                REGNLOCN.AdvancedSearch.SearchValue2 = filter["y_REGNLOCN"];
                REGNLOCN.AdvancedSearch.SearchOperator2 = filter["w_REGNLOCN"];
                REGNLOCN.AdvancedSearch.Save();
            }

            // Field SrNo11DecF1S1
            if (filter?.TryGetValue("x_SrNo11DecF1S1", out sv) ?? false) {
                SrNo11DecF1S1.AdvancedSearch.SearchValue = sv;
                SrNo11DecF1S1.AdvancedSearch.SearchOperator = filter["z_SrNo11DecF1S1"];
                SrNo11DecF1S1.AdvancedSearch.SearchCondition = filter["v_SrNo11DecF1S1"];
                SrNo11DecF1S1.AdvancedSearch.SearchValue2 = filter["y_SrNo11DecF1S1"];
                SrNo11DecF1S1.AdvancedSearch.SearchOperator2 = filter["w_SrNo11DecF1S1"];
                SrNo11DecF1S1.AdvancedSearch.Save();
            }

            // Field IsInterestedInTraining
            if (filter?.TryGetValue("x_IsInterestedInTraining", out sv) ?? false) {
                IsInterestedInTraining.AdvancedSearch.SearchValue = sv;
                IsInterestedInTraining.AdvancedSearch.SearchOperator = filter["z_IsInterestedInTraining"];
                IsInterestedInTraining.AdvancedSearch.SearchCondition = filter["v_IsInterestedInTraining"];
                IsInterestedInTraining.AdvancedSearch.SearchValue2 = filter["y_IsInterestedInTraining"];
                IsInterestedInTraining.AdvancedSearch.SearchOperator2 = filter["w_IsInterestedInTraining"];
                IsInterestedInTraining.AdvancedSearch.Save();
            }

            // Field StudentEncryptID
            if (filter?.TryGetValue("x_StudentEncryptID", out sv) ?? false) {
                StudentEncryptID.AdvancedSearch.SearchValue = sv;
                StudentEncryptID.AdvancedSearch.SearchOperator = filter["z_StudentEncryptID"];
                StudentEncryptID.AdvancedSearch.SearchCondition = filter["v_StudentEncryptID"];
                StudentEncryptID.AdvancedSearch.SearchValue2 = filter["y_StudentEncryptID"];
                StudentEncryptID.AdvancedSearch.SearchOperator2 = filter["w_StudentEncryptID"];
                StudentEncryptID.AdvancedSearch.Save();
            }

            // Field StudentConfirURL
            if (filter?.TryGetValue("x_StudentConfirURL", out sv) ?? false) {
                StudentConfirURL.AdvancedSearch.SearchValue = sv;
                StudentConfirURL.AdvancedSearch.SearchOperator = filter["z_StudentConfirURL"];
                StudentConfirURL.AdvancedSearch.SearchCondition = filter["v_StudentConfirURL"];
                StudentConfirURL.AdvancedSearch.SearchValue2 = filter["y_StudentConfirURL"];
                StudentConfirURL.AdvancedSearch.SearchOperator2 = filter["w_StudentConfirURL"];
                StudentConfirURL.AdvancedSearch.Save();
            }

            // Field SrNo15DecF1S2
            if (filter?.TryGetValue("x_SrNo15DecF1S2", out sv) ?? false) {
                SrNo15DecF1S2.AdvancedSearch.SearchValue = sv;
                SrNo15DecF1S2.AdvancedSearch.SearchOperator = filter["z_SrNo15DecF1S2"];
                SrNo15DecF1S2.AdvancedSearch.SearchCondition = filter["v_SrNo15DecF1S2"];
                SrNo15DecF1S2.AdvancedSearch.SearchValue2 = filter["y_SrNo15DecF1S2"];
                SrNo15DecF1S2.AdvancedSearch.SearchOperator2 = filter["w_SrNo15DecF1S2"];
                SrNo15DecF1S2.AdvancedSearch.Save();
            }

            // Field SrNo15DecF1S3
            if (filter?.TryGetValue("x_SrNo15DecF1S3", out sv) ?? false) {
                SrNo15DecF1S3.AdvancedSearch.SearchValue = sv;
                SrNo15DecF1S3.AdvancedSearch.SearchOperator = filter["z_SrNo15DecF1S3"];
                SrNo15DecF1S3.AdvancedSearch.SearchCondition = filter["v_SrNo15DecF1S3"];
                SrNo15DecF1S3.AdvancedSearch.SearchValue2 = filter["y_SrNo15DecF1S3"];
                SrNo15DecF1S3.AdvancedSearch.SearchOperator2 = filter["w_SrNo15DecF1S3"];
                SrNo15DecF1S3.AdvancedSearch.Save();
            }

            // Field SrNo16DecF2S2
            if (filter?.TryGetValue("x_SrNo16DecF2S2", out sv) ?? false) {
                SrNo16DecF2S2.AdvancedSearch.SearchValue = sv;
                SrNo16DecF2S2.AdvancedSearch.SearchOperator = filter["z_SrNo16DecF2S2"];
                SrNo16DecF2S2.AdvancedSearch.SearchCondition = filter["v_SrNo16DecF2S2"];
                SrNo16DecF2S2.AdvancedSearch.SearchValue2 = filter["y_SrNo16DecF2S2"];
                SrNo16DecF2S2.AdvancedSearch.SearchOperator2 = filter["w_SrNo16DecF2S2"];
                SrNo16DecF2S2.AdvancedSearch.Save();
            }

            // Field SrNo16DecF2S3
            if (filter?.TryGetValue("x_SrNo16DecF2S3", out sv) ?? false) {
                SrNo16DecF2S3.AdvancedSearch.SearchValue = sv;
                SrNo16DecF2S3.AdvancedSearch.SearchOperator = filter["z_SrNo16DecF2S3"];
                SrNo16DecF2S3.AdvancedSearch.SearchCondition = filter["v_SrNo16DecF2S3"];
                SrNo16DecF2S3.AdvancedSearch.SearchValue2 = filter["y_SrNo16DecF2S3"];
                SrNo16DecF2S3.AdvancedSearch.SearchOperator2 = filter["w_SrNo16DecF2S3"];
                SrNo16DecF2S3.AdvancedSearch.Save();
            }

            // Field SrNo16DecF3S1
            if (filter?.TryGetValue("x_SrNo16DecF3S1", out sv) ?? false) {
                SrNo16DecF3S1.AdvancedSearch.SearchValue = sv;
                SrNo16DecF3S1.AdvancedSearch.SearchOperator = filter["z_SrNo16DecF3S1"];
                SrNo16DecF3S1.AdvancedSearch.SearchCondition = filter["v_SrNo16DecF3S1"];
                SrNo16DecF3S1.AdvancedSearch.SearchValue2 = filter["y_SrNo16DecF3S1"];
                SrNo16DecF3S1.AdvancedSearch.SearchOperator2 = filter["w_SrNo16DecF3S1"];
                SrNo16DecF3S1.AdvancedSearch.Save();
            }

            // Field SrNo16DecF3S2
            if (filter?.TryGetValue("x_SrNo16DecF3S2", out sv) ?? false) {
                SrNo16DecF3S2.AdvancedSearch.SearchValue = sv;
                SrNo16DecF3S2.AdvancedSearch.SearchOperator = filter["z_SrNo16DecF3S2"];
                SrNo16DecF3S2.AdvancedSearch.SearchCondition = filter["v_SrNo16DecF3S2"];
                SrNo16DecF3S2.AdvancedSearch.SearchValue2 = filter["y_SrNo16DecF3S2"];
                SrNo16DecF3S2.AdvancedSearch.SearchOperator2 = filter["w_SrNo16DecF3S2"];
                SrNo16DecF3S2.AdvancedSearch.Save();
            }

            // Field SrNo16DecF4S1
            if (filter?.TryGetValue("x_SrNo16DecF4S1", out sv) ?? false) {
                SrNo16DecF4S1.AdvancedSearch.SearchValue = sv;
                SrNo16DecF4S1.AdvancedSearch.SearchOperator = filter["z_SrNo16DecF4S1"];
                SrNo16DecF4S1.AdvancedSearch.SearchCondition = filter["v_SrNo16DecF4S1"];
                SrNo16DecF4S1.AdvancedSearch.SearchValue2 = filter["y_SrNo16DecF4S1"];
                SrNo16DecF4S1.AdvancedSearch.SearchOperator2 = filter["w_SrNo16DecF4S1"];
                SrNo16DecF4S1.AdvancedSearch.Save();
            }

            // Field SrNo16DecF4S2
            if (filter?.TryGetValue("x_SrNo16DecF4S2", out sv) ?? false) {
                SrNo16DecF4S2.AdvancedSearch.SearchValue = sv;
                SrNo16DecF4S2.AdvancedSearch.SearchOperator = filter["z_SrNo16DecF4S2"];
                SrNo16DecF4S2.AdvancedSearch.SearchCondition = filter["v_SrNo16DecF4S2"];
                SrNo16DecF4S2.AdvancedSearch.SearchValue2 = filter["y_SrNo16DecF4S2"];
                SrNo16DecF4S2.AdvancedSearch.SearchOperator2 = filter["w_SrNo16DecF4S2"];
                SrNo16DecF4S2.AdvancedSearch.Save();
            }

            // Field SrNo16DecF4S3
            if (filter?.TryGetValue("x_SrNo16DecF4S3", out sv) ?? false) {
                SrNo16DecF4S3.AdvancedSearch.SearchValue = sv;
                SrNo16DecF4S3.AdvancedSearch.SearchOperator = filter["z_SrNo16DecF4S3"];
                SrNo16DecF4S3.AdvancedSearch.SearchCondition = filter["v_SrNo16DecF4S3"];
                SrNo16DecF4S3.AdvancedSearch.SearchValue2 = filter["y_SrNo16DecF4S3"];
                SrNo16DecF4S3.AdvancedSearch.SearchOperator2 = filter["w_SrNo16DecF4S3"];
                SrNo16DecF4S3.AdvancedSearch.Save();
            }

            // Field StudentAssementBookingURL
            if (filter?.TryGetValue("x_StudentAssementBookingURL", out sv) ?? false) {
                StudentAssementBookingURL.AdvancedSearch.SearchValue = sv;
                StudentAssementBookingURL.AdvancedSearch.SearchOperator = filter["z_StudentAssementBookingURL"];
                StudentAssementBookingURL.AdvancedSearch.SearchCondition = filter["v_StudentAssementBookingURL"];
                StudentAssementBookingURL.AdvancedSearch.SearchValue2 = filter["y_StudentAssementBookingURL"];
                StudentAssementBookingURL.AdvancedSearch.SearchOperator2 = filter["w_StudentAssementBookingURL"];
                StudentAssementBookingURL.AdvancedSearch.Save();
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

            // Field Isdrivinglicense
            if (filter?.TryGetValue("x_Isdrivinglicense", out sv) ?? false) {
                Isdrivinglicense.AdvancedSearch.SearchValue = sv;
                Isdrivinglicense.AdvancedSearch.SearchOperator = filter["z_Isdrivinglicense"];
                Isdrivinglicense.AdvancedSearch.SearchCondition = filter["v_Isdrivinglicense"];
                Isdrivinglicense.AdvancedSearch.SearchValue2 = filter["y_Isdrivinglicense"];
                Isdrivinglicense.AdvancedSearch.SearchOperator2 = filter["w_Isdrivinglicense"];
                Isdrivinglicense.AdvancedSearch.Save();
            }

            // Field drivinglicensenumber
            if (filter?.TryGetValue("x_drivinglicensenumber", out sv) ?? false) {
                drivinglicensenumber.AdvancedSearch.SearchValue = sv;
                drivinglicensenumber.AdvancedSearch.SearchOperator = filter["z_drivinglicensenumber"];
                drivinglicensenumber.AdvancedSearch.SearchCondition = filter["v_drivinglicensenumber"];
                drivinglicensenumber.AdvancedSearch.SearchValue2 = filter["y_drivinglicensenumber"];
                drivinglicensenumber.AdvancedSearch.SearchOperator2 = filter["w_drivinglicensenumber"];
                drivinglicensenumber.AdvancedSearch.Save();
            }

            // Field Absher_Appointment_number
            if (filter?.TryGetValue("x_Absher_Appointment_number", out sv) ?? false) {
                Absher_Appointment_number.AdvancedSearch.SearchValue = sv;
                Absher_Appointment_number.AdvancedSearch.SearchOperator = filter["z_Absher_Appointment_number"];
                Absher_Appointment_number.AdvancedSearch.SearchCondition = filter["v_Absher_Appointment_number"];
                Absher_Appointment_number.AdvancedSearch.SearchValue2 = filter["y_Absher_Appointment_number"];
                Absher_Appointment_number.AdvancedSearch.SearchOperator2 = filter["w_Absher_Appointment_number"];
                Absher_Appointment_number.AdvancedSearch.Save();
            }

            // Field DataImportId
            if (filter?.TryGetValue("x_DataImportId", out sv) ?? false) {
                DataImportId.AdvancedSearch.SearchValue = sv;
                DataImportId.AdvancedSearch.SearchOperator = filter["z_DataImportId"];
                DataImportId.AdvancedSearch.SearchCondition = filter["v_DataImportId"];
                DataImportId.AdvancedSearch.SearchValue2 = filter["y_DataImportId"];
                DataImportId.AdvancedSearch.SearchOperator2 = filter["w_DataImportId"];
                DataImportId.AdvancedSearch.Save();
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

            // Field UserlevelID
            if (filter?.TryGetValue("x_UserlevelID", out sv) ?? false) {
                UserlevelID.AdvancedSearch.SearchValue = sv;
                UserlevelID.AdvancedSearch.SearchOperator = filter["z_UserlevelID"];
                UserlevelID.AdvancedSearch.SearchCondition = filter["v_UserlevelID"];
                UserlevelID.AdvancedSearch.SearchValue2 = filter["y_UserlevelID"];
                UserlevelID.AdvancedSearch.SearchOperator2 = filter["w_UserlevelID"];
                UserlevelID.AdvancedSearch.Save();
            }

            // Field Activated
            if (filter?.TryGetValue("x_Activated", out sv) ?? false) {
                Activated.AdvancedSearch.SearchValue = sv;
                Activated.AdvancedSearch.SearchOperator = filter["z_Activated"];
                Activated.AdvancedSearch.SearchCondition = filter["v_Activated"];
                Activated.AdvancedSearch.SearchValue2 = filter["y_Activated"];
                Activated.AdvancedSearch.SearchOperator2 = filter["w_Activated"];
                Activated.AdvancedSearch.Save();
            }

            // Field Absherphoto
            if (filter?.TryGetValue("x_Absherphoto", out sv) ?? false) {
                Absherphoto.AdvancedSearch.SearchValue = sv;
                Absherphoto.AdvancedSearch.SearchOperator = filter["z_Absherphoto"];
                Absherphoto.AdvancedSearch.SearchCondition = filter["v_Absherphoto"];
                Absherphoto.AdvancedSearch.SearchValue2 = filter["y_Absherphoto"];
                Absherphoto.AdvancedSearch.SearchOperator2 = filter["w_Absherphoto"];
                Absherphoto.AdvancedSearch.Save();
            }

            // Field Fingerprint
            if (filter?.TryGetValue("x_Fingerprint", out sv) ?? false) {
                Fingerprint.AdvancedSearch.SearchValue = sv;
                Fingerprint.AdvancedSearch.SearchOperator = filter["z_Fingerprint"];
                Fingerprint.AdvancedSearch.SearchCondition = filter["v_Fingerprint"];
                Fingerprint.AdvancedSearch.SearchValue2 = filter["y_Fingerprint"];
                Fingerprint.AdvancedSearch.SearchOperator2 = filter["w_Fingerprint"];
                Fingerprint.AdvancedSearch.Save();
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

            // Field Hijri_Day
            if (filter?.TryGetValue("x_Hijri_Day", out sv) ?? false) {
                Hijri_Day.AdvancedSearch.SearchValue = sv;
                Hijri_Day.AdvancedSearch.SearchOperator = filter["z_Hijri_Day"];
                Hijri_Day.AdvancedSearch.SearchCondition = filter["v_Hijri_Day"];
                Hijri_Day.AdvancedSearch.SearchValue2 = filter["y_Hijri_Day"];
                Hijri_Day.AdvancedSearch.SearchOperator2 = filter["w_Hijri_Day"];
                Hijri_Day.AdvancedSearch.Save();
            }

            // Field Hijri_Month
            if (filter?.TryGetValue("x_Hijri_Month", out sv) ?? false) {
                Hijri_Month.AdvancedSearch.SearchValue = sv;
                Hijri_Month.AdvancedSearch.SearchOperator = filter["z_Hijri_Month"];
                Hijri_Month.AdvancedSearch.SearchCondition = filter["v_Hijri_Month"];
                Hijri_Month.AdvancedSearch.SearchValue2 = filter["y_Hijri_Month"];
                Hijri_Month.AdvancedSearch.SearchOperator2 = filter["w_Hijri_Month"];
                Hijri_Month.AdvancedSearch.Save();
            }

            // Field Hijri_Year
            if (filter?.TryGetValue("x_Hijri_Year", out sv) ?? false) {
                Hijri_Year.AdvancedSearch.SearchValue = sv;
                Hijri_Year.AdvancedSearch.SearchOperator = filter["z_Hijri_Year"];
                Hijri_Year.AdvancedSearch.SearchCondition = filter["v_Hijri_Year"];
                Hijri_Year.AdvancedSearch.SearchValue2 = filter["y_Hijri_Year"];
                Hijri_Year.AdvancedSearch.SearchOperator2 = filter["w_Hijri_Year"];
                Hijri_Year.AdvancedSearch.Save();
            }

            // Field Course_Price
            if (filter?.TryGetValue("x_Course_Price", out sv) ?? false) {
                Course_Price.AdvancedSearch.SearchValue = sv;
                Course_Price.AdvancedSearch.SearchOperator = filter["z_Course_Price"];
                Course_Price.AdvancedSearch.SearchCondition = filter["v_Course_Price"];
                Course_Price.AdvancedSearch.SearchValue2 = filter["y_Course_Price"];
                Course_Price.AdvancedSearch.SearchOperator2 = filter["w_Course_Price"];
                Course_Price.AdvancedSearch.Save();
            }

            // Field Vat_Tax_15
            if (filter?.TryGetValue("x_Vat_Tax_15", out sv) ?? false) {
                Vat_Tax_15.AdvancedSearch.SearchValue = sv;
                Vat_Tax_15.AdvancedSearch.SearchOperator = filter["z_Vat_Tax_15"];
                Vat_Tax_15.AdvancedSearch.SearchCondition = filter["v_Vat_Tax_15"];
                Vat_Tax_15.AdvancedSearch.SearchValue2 = filter["y_Vat_Tax_15"];
                Vat_Tax_15.AdvancedSearch.SearchOperator2 = filter["w_Vat_Tax_15"];
                Vat_Tax_15.AdvancedSearch.Save();
            }

            // Field dec_Balance
            if (filter?.TryGetValue("x_dec_Balance", out sv) ?? false) {
                dec_Balance.AdvancedSearch.SearchValue = sv;
                dec_Balance.AdvancedSearch.SearchOperator = filter["z_dec_Balance"];
                dec_Balance.AdvancedSearch.SearchCondition = filter["v_dec_Balance"];
                dec_Balance.AdvancedSearch.SearchValue2 = filter["y_dec_Balance"];
                dec_Balance.AdvancedSearch.SearchOperator2 = filter["w_dec_Balance"];
                dec_Balance.AdvancedSearch.Save();
            }

            // Field Total_Price
            if (filter?.TryGetValue("x_Total_Price", out sv) ?? false) {
                Total_Price.AdvancedSearch.SearchValue = sv;
                Total_Price.AdvancedSearch.SearchOperator = filter["z_Total_Price"];
                Total_Price.AdvancedSearch.SearchCondition = filter["v_Total_Price"];
                Total_Price.AdvancedSearch.SearchValue2 = filter["y_Total_Price"];
                Total_Price.AdvancedSearch.SearchOperator2 = filter["w_Total_Price"];
                Total_Price.AdvancedSearch.Save();
            }

            // Field Payment_Online
            if (filter?.TryGetValue("x_Payment_Online", out sv) ?? false) {
                Payment_Online.AdvancedSearch.SearchValue = sv;
                Payment_Online.AdvancedSearch.SearchOperator = filter["z_Payment_Online"];
                Payment_Online.AdvancedSearch.SearchCondition = filter["v_Payment_Online"];
                Payment_Online.AdvancedSearch.SearchValue2 = filter["y_Payment_Online"];
                Payment_Online.AdvancedSearch.SearchOperator2 = filter["w_Payment_Online"];
                Payment_Online.AdvancedSearch.Save();
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

            // Field WaitingList
            if (filter?.TryGetValue("x_WaitingList", out sv) ?? false) {
                WaitingList.AdvancedSearch.SearchValue = sv;
                WaitingList.AdvancedSearch.SearchOperator = filter["z_WaitingList"];
                WaitingList.AdvancedSearch.SearchCondition = filter["v_WaitingList"];
                WaitingList.AdvancedSearch.SearchValue2 = filter["y_WaitingList"];
                WaitingList.AdvancedSearch.SearchOperator2 = filter["w_WaitingList"];
                WaitingList.AdvancedSearch.Save();
            }

            // Field Assessment_ID
            if (filter?.TryGetValue("x_Assessment_ID", out sv) ?? false) {
                Assessment_ID.AdvancedSearch.SearchValue = sv;
                Assessment_ID.AdvancedSearch.SearchOperator = filter["z_Assessment_ID"];
                Assessment_ID.AdvancedSearch.SearchCondition = filter["v_Assessment_ID"];
                Assessment_ID.AdvancedSearch.SearchValue2 = filter["y_Assessment_ID"];
                Assessment_ID.AdvancedSearch.SearchOperator2 = filter["w_Assessment_ID"];
                Assessment_ID.AdvancedSearch.Save();
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
            BuildSearchSql(ref where, int_Potential_Student_ID, def, false); // int_Potential_Student_ID
            BuildSearchSql(ref where, int_Student_Id, def, false); // int_Student_Id
            BuildSearchSql(ref where, str_NationalID_Iqama, def, false); // str_NationalID_Iqama
            BuildSearchSql(ref where, NationalID, def, false); // NationalID
            BuildSearchSql(ref where, str_First_Name, def, false); // str_First_Name
            BuildSearchSql(ref where, str_Middle_Name, def, false); // str_Middle_Name
            BuildSearchSql(ref where, str_Last_Name, def, false); // str_Last_Name
            BuildSearchSql(ref where, str_Address1, def, false); // str_Address1
            BuildSearchSql(ref where, str_Address2, def, false); // str_Address2
            BuildSearchSql(ref where, int_State, def, false); // int_State
            BuildSearchSql(ref where, str_City, def, false); // str_City
            BuildSearchSql(ref where, str_Zip, def, false); // str_Zip
            BuildSearchSql(ref where, int_Instructor, def, false); // int_Instructor
            BuildSearchSql(ref where, int_Driver, def, false); // int_Driver
            BuildSearchSql(ref where, str_Home_Phone, def, false); // str_Home_Phone
            BuildSearchSql(ref where, str_Cell_Phone, def, false); // str_Cell_Phone
            BuildSearchSql(ref where, str_Parent_Phone, def, false); // str_Parent_Phone
            BuildSearchSql(ref where, str_Other_Phone, def, false); // str_Other_Phone
            BuildSearchSql(ref where, str_Email, def, false); // str_Email
            BuildSearchSql(ref where, str_ParentName, def, false); // str_ParentName
            BuildSearchSql(ref where, str_ParentEmail1, def, false); // str_ParentEmail1
            BuildSearchSql(ref where, str_ParentEmail2, def, false); // str_ParentEmail2
            BuildSearchSql(ref where, str_Username, def, false); // str_Username
            BuildSearchSql(ref where, str_Password, def, false); // str_Password
            BuildSearchSql(ref where, str_DOB, def, false); // str_DOB
            BuildSearchSql(ref where, int_DOB_Day, def, false); // int_DOB_Day
            BuildSearchSql(ref where, int_DOB_Month, def, false); // int_DOB_Month
            BuildSearchSql(ref where, int_DOB_Year, def, false); // int_DOB_Year
            BuildSearchSql(ref where, int_Age, def, false); // int_Age
            BuildSearchSql(ref where, int_Type, def, false); // int_Type
            BuildSearchSql(ref where, int_Wear_Glasses, def, false); // int_Wear_Glasses
            BuildSearchSql(ref where, int_Sex, def, false); // int_Sex
            BuildSearchSql(ref where, str_DLPermit, def, false); // str_DLPermit
            BuildSearchSql(ref where, dt_Date_PermitIssue, def, false); // dt_Date_PermitIssue
            BuildSearchSql(ref where, dt_Date_ExpirePermit, def, false); // dt_Date_ExpirePermit
            BuildSearchSql(ref where, int_Hs_ID, def, false); // int_Hs_ID
            BuildSearchSql(ref where, str_Emergency_Contact_Name, def, false); // str_Emergency_Contact_Name
            BuildSearchSql(ref where, str_Emergency_Contact_Phone, def, false); // str_Emergency_Contact_Phone
            BuildSearchSql(ref where, str_Emergency_Contact_Relation, def, false); // str_Emergency_Contact_Relation
            BuildSearchSql(ref where, str_Student_Notes, def, false); // str_Student_Notes
            BuildSearchSql(ref where, str_Driving_Notes, def, false); // str_Driving_Notes
            BuildSearchSql(ref where, int_Location_Id, def, false); // int_Location_Id
            BuildSearchSql(ref where, int_Permit_Number, def, false); // int_Permit_Number
            BuildSearchSql(ref where, Permit_Issue_Date, def, false); // Permit_Issue_Date
            BuildSearchSql(ref where, Permit_Expiry_Date, def, false); // Permit_Expiry_Date
            BuildSearchSql(ref where, int_Status, def, false); // int_Status
            BuildSearchSql(ref where, int_Lead_Id, def, false); // int_Lead_Id
            BuildSearchSql(ref where, int_Activated_By, def, false); // int_Activated_By
            BuildSearchSql(ref where, date_Activated, def, false); // date_Activated
            BuildSearchSql(ref where, date_Created, def, false); // date_Created
            BuildSearchSql(ref where, date_Modified, def, false); // date_Modified
            BuildSearchSql(ref where, date_Complete, def, false); // date_Complete
            BuildSearchSql(ref where, int_Created_By, def, false); // int_Created_By
            BuildSearchSql(ref where, int_Modified_By, def, false); // int_Modified_By
            BuildSearchSql(ref where, bit_IsDeleted, def, false); // bit_IsDeleted
            BuildSearchSql(ref where, str_CardHolderName, def, false); // str_CardHolderName
            BuildSearchSql(ref where, str_CardHolderAddress, def, false); // str_CardHolderAddress
            BuildSearchSql(ref where, str_CardHolderCity, def, false); // str_CardHolderCity
            BuildSearchSql(ref where, str_CardHolderZip, def, false); // str_CardHolderZip
            BuildSearchSql(ref where, str_CardType, def, false); // str_CardType
            BuildSearchSql(ref where, str_CardExpMonth, def, false); // str_CardExpMonth
            BuildSearchSql(ref where, str_CardExpYear, def, false); // str_CardExpYear
            BuildSearchSql(ref where, str_CardNo, def, false); // str_CardNo
            BuildSearchSql(ref where, str_Certificate_No, def, false); // str_Certificate_No
            BuildSearchSql(ref where, str_AmountPaid, def, false); // str_AmountPaid
            BuildSearchSql(ref where, str_PermitValidated, def, false); // str_PermitValidated
            BuildSearchSql(ref where, strSMSNotification, def, false); // strSMSNotification
            BuildSearchSql(ref where, strVoiceNotification, def, false); // strVoiceNotification
            BuildSearchSql(ref where, str_Weight, def, false); // str_Weight
            BuildSearchSql(ref where, str_SpecialNeeds, def, false); // str_SpecialNeeds
            BuildSearchSql(ref where, str_MedicalConditions, def, false); // str_MedicalConditions
            BuildSearchSql(ref where, bit_Verified_PIC_InSAW, def, false); // bit_Verified_PIC_InSAW
            BuildSearchSql(ref where, bit_Permit_Waiver_Entered, def, false); // bit_Permit_Waiver_Entered
            BuildSearchSql(ref where, bit_TermsConditions, def, false); // bit_TermsConditions
            BuildSearchSql(ref where, bit_Disable_Self_Scheduling, def, false); // bit_Disable_Self_Scheduling
            BuildSearchSql(ref where, int_EyeColor, def, false); // int_EyeColor
            BuildSearchSql(ref where, int_HairColor, def, false); // int_HairColor
            BuildSearchSql(ref where, int_ColorBlind, def, false); // int_ColorBlind
            BuildSearchSql(ref where, int_HeightFeet, def, false); // int_HeightFeet
            BuildSearchSql(ref where, int_HeightInches, def, false); // int_HeightInches
            BuildSearchSql(ref where, str_reference_code, def, false); // str_reference_code
            BuildSearchSql(ref where, dt_ParentClassAttendedDt, def, false); // dt_ParentClassAttendedDt
            BuildSearchSql(ref where, str_ParentClassAttendedLoc, def, false); // str_ParentClassAttendedLoc
            BuildSearchSql(ref where, dt_SiblingClassAttendedDt, def, false); // dt_SiblingClassAttendedDt
            BuildSearchSql(ref where, str_SiblingClassAttendedLoc, def, false); // str_SiblingClassAttendedLoc
            BuildSearchSql(ref where, bit_PoliciesAndProcedures, def, false); // bit_PoliciesAndProcedures
            BuildSearchSql(ref where, dt_CourseCompletionDt, def, false); // dt_CourseCompletionDt
            BuildSearchSql(ref where, dt_ExtensionDt, def, false); // dt_ExtensionDt
            BuildSearchSql(ref where, str_MedicalCondition, def, false); // str_MedicalCondition
            BuildSearchSql(ref where, str_MajorCrossStreets, def, false); // str_MajorCrossStreets
            BuildSearchSql(ref where, str_DriverEdCertNo, def, false); // str_DriverEdCertNo
            BuildSearchSql(ref where, dt_DriverEdCertIssuedDt, def, false); // dt_DriverEdCertIssuedDt
            BuildSearchSql(ref where, str_BTWDriversEdCertNo, def, false); // str_BTWDriversEdCertNo
            BuildSearchSql(ref where, dt_BTWCertIssuedDt, def, false); // dt_BTWCertIssuedDt
            BuildSearchSql(ref where, str_OLDriversEdCertNo, def, false); // str_OLDriversEdCertNo
            BuildSearchSql(ref where, dt_OLCertIssuedDt, def, false); // dt_OLCertIssuedDt
            BuildSearchSql(ref where, str_height, def, false); // str_height
            BuildSearchSql(ref where, dt_BTWCompletionDt, def, false); // dt_BTWCompletionDt
            BuildSearchSql(ref where, dt_CRCompletionDt, def, false); // dt_CRCompletionDt
            BuildSearchSql(ref where, strTextBox5, def, false); // strTextBox5
            BuildSearchSql(ref where, strTextBox6, def, false); // strTextBox6
            BuildSearchSql(ref where, str_ApartmentNo, def, false); // str_ApartmentNo
            BuildSearchSql(ref where, dt_PermitTestDate, def, false); // dt_PermitTestDate
            BuildSearchSql(ref where, str_OnlineDriverEdLogin, def, false); // str_OnlineDriverEdLogin
            BuildSearchSql(ref where, str_OnlineDriverEdPassword, def, false); // str_OnlineDriverEdPassword
            BuildSearchSql(ref where, bit_IsSMSEnabled, def, false); // bit_IsSMSEnabled
            BuildSearchSql(ref where, dt_SMSModified, def, false); // dt_SMSModified
            BuildSearchSql(ref where, str_confirmPassword, def, false); // str_confirmPassword
            BuildSearchSql(ref where, DE_Certificate, def, false); // DE_Certificate
            BuildSearchSql(ref where, Discuss, def, false); // Discuss
            BuildSearchSql(ref where, int_UnlicensedSibling, def, false); // int_UnlicensedSibling
            BuildSearchSql(ref where, int_YearSiblingIsEligible, def, false); // int_YearSiblingIsEligible
            BuildSearchSql(ref where, BTW_Certificate, def, false); // BTW_Certificate
            BuildSearchSql(ref where, dt_DECertIssueDate, def, false); // dt_DECertIssueDate
            BuildSearchSql(ref where, str_StudentSignature, def, false); // str_StudentSignature
            BuildSearchSql(ref where, str_ParentSignature, def, false); // str_ParentSignature
            BuildSearchSql(ref where, str_Last6DigitsOfParentDriversLicense, def, false); // str_Last6DigitsOfParentDriversLicense
            BuildSearchSql(ref where, str_FACControl, def, false); // str_FACControl
            BuildSearchSql(ref where, Classroom_Status_Code, def, false); // Classroom_Status_Code
            BuildSearchSql(ref where, Laboratory_Status_Code, def, false); // Laboratory_Status_Code
            BuildSearchSql(ref where, bit_EnrollmentForm, def, false); // bit_EnrollmentForm
            BuildSearchSql(ref where, bit_ParentStudentContract, def, false); // bit_ParentStudentContract
            BuildSearchSql(ref where, bit_ParentalAgreement, def, false); // bit_ParentalAgreement
            BuildSearchSql(ref where, int_SF_GR_WA_HS, def, false); // int_SF_GR_WA_HS
            BuildSearchSql(ref where, bit_DisableOnRMV, def, false); // bit_DisableOnRMV
            BuildSearchSql(ref where, bit_UploadedToRMV, def, false); // bit_UploadedToRMV
            BuildSearchSql(ref where, str_Mother_Name, def, false); // str_Mother_Name
            BuildSearchSql(ref where, str_Guardians_Name, def, false); // str_Guardians_Name
            BuildSearchSql(ref where, str_Mother_Phone, def, false); // str_Mother_Phone
            BuildSearchSql(ref where, bit_terms, def, false); // bit_terms
            BuildSearchSql(ref where, int_Nationality, def, false); // int_Nationality
            BuildSearchSql(ref where, str_National_ID_en, def, false); // str_National_ID_en
            BuildSearchSql(ref where, str_National_ID_arabic, def, false); // str_National_ID_arabic
            BuildSearchSql(ref where, Quallification_Id, def, false); // Quallification_Id
            BuildSearchSql(ref where, Job_Id, def, false); // Job_Id
            BuildSearchSql(ref where, str_DOB_arabic, def, true); // str_DOB_arabic
            BuildSearchSql(ref where, int_Language, def, false); // int_Language
            BuildSearchSql(ref where, strRefId, def, false); // strRefId
            BuildSearchSql(ref where, int_Program_Id, def, false); // int_Program_Id
            BuildSearchSql(ref where, IsDrivingexperience, def, false); // IsDrivingexperience
            BuildSearchSql(ref where, IsScheduleassessment, def, false); // IsScheduleassessment
            BuildSearchSql(ref where, IsEnrollbyyourself, def, false); // IsEnrollbyyourself
            BuildSearchSql(ref where, AssessmentTime, def, false); // AssessmentTime
            BuildSearchSql(ref where, AssessmentDate, def, false); // AssessmentDate
            BuildSearchSql(ref where, isAssessmentDone, def, false); // isAssessmentDone
            BuildSearchSql(ref where, AssessmentScore, def, false); // AssessmentScore
            BuildSearchSql(ref where, dt_WrittenTestPassed, def, false); // dt_WrittenTestPassed
            BuildSearchSql(ref where, dt_RoadTestPassed, def, false); // dt_RoadTestPassed
            BuildSearchSql(ref where, bit_Archive, def, false); // bit_Archive
            BuildSearchSql(ref where, ArchiveNotes, def, false); // ArchiveNotes
            BuildSearchSql(ref where, dtArchived, def, false); // dtArchived
            BuildSearchSql(ref where, SrNo9Dec21, def, false); // SrNo9Dec21
            BuildSearchSql(ref where, REGNNUMB, def, false); // REGNNUMB
            BuildSearchSql(ref where, REGNLOCN, def, false); // REGNLOCN
            BuildSearchSql(ref where, SrNo11DecF1S1, def, false); // SrNo11DecF1S1
            BuildSearchSql(ref where, IsInterestedInTraining, def, false); // IsInterestedInTraining
            BuildSearchSql(ref where, StudentEncryptID, def, false); // StudentEncryptID
            BuildSearchSql(ref where, StudentConfirURL, def, false); // StudentConfirURL
            BuildSearchSql(ref where, SrNo15DecF1S2, def, false); // SrNo15DecF1S2
            BuildSearchSql(ref where, SrNo15DecF1S3, def, false); // SrNo15DecF1S3
            BuildSearchSql(ref where, SrNo16DecF2S2, def, false); // SrNo16DecF2S2
            BuildSearchSql(ref where, SrNo16DecF2S3, def, false); // SrNo16DecF2S3
            BuildSearchSql(ref where, SrNo16DecF3S1, def, false); // SrNo16DecF3S1
            BuildSearchSql(ref where, SrNo16DecF3S2, def, false); // SrNo16DecF3S2
            BuildSearchSql(ref where, SrNo16DecF4S1, def, false); // SrNo16DecF4S1
            BuildSearchSql(ref where, SrNo16DecF4S2, def, false); // SrNo16DecF4S2
            BuildSearchSql(ref where, SrNo16DecF4S3, def, false); // SrNo16DecF4S3
            BuildSearchSql(ref where, StudentAssementBookingURL, def, false); // StudentAssementBookingURL
            BuildSearchSql(ref where, intDrivinglicenseType, def, false); // intDrivinglicenseType
            BuildSearchSql(ref where, Isdrivinglicense, def, false); // Isdrivinglicense
            BuildSearchSql(ref where, drivinglicensenumber, def, false); // drivinglicensenumber
            BuildSearchSql(ref where, Absher_Appointment_number, def, false); // Absher_Appointment_number
            BuildSearchSql(ref where, DataImportId, def, false); // DataImportId
            BuildSearchSql(ref where, date_Birth_Hijri, def, false); // date_Birth_Hijri
            BuildSearchSql(ref where, UserlevelID, def, false); // UserlevelID
            BuildSearchSql(ref where, Activated, def, false); // Activated
            BuildSearchSql(ref where, Absherphoto, def, false); // Absherphoto
            BuildSearchSql(ref where, Fingerprint, def, false); // Fingerprint
            BuildSearchSql(ref where, Required_Program, def, false); // Required_Program
            BuildSearchSql(ref where, Price, def, false); // Price
            BuildSearchSql(ref where, Hijri_Day, def, false); // Hijri_Day
            BuildSearchSql(ref where, Hijri_Month, def, false); // Hijri_Month
            BuildSearchSql(ref where, Hijri_Year, def, false); // Hijri_Year
            BuildSearchSql(ref where, Course_Price, def, false); // Course_Price
            BuildSearchSql(ref where, Vat_Tax_15, def, false); // Vat_Tax_15
            BuildSearchSql(ref where, dec_Balance, def, false); // dec_Balance
            BuildSearchSql(ref where, Total_Price, def, false); // Total_Price
            BuildSearchSql(ref where, Payment_Online, def, false); // Payment_Online
            BuildSearchSql(ref where, Institution, def, false); // Institution
            BuildSearchSql(ref where, WaitingList, def, false); // WaitingList
            BuildSearchSql(ref where, Assessment_ID, def, false); // Assessment_ID

            // Set up search command
            if (!def && !Empty(where) && (new[] { "", "reset", "resetall" }).Contains(Command))
                Command = "search";
            if (!def && Command == "search") {
                int_Potential_Student_ID.AdvancedSearch.Save(); // int_Potential_Student_ID
                int_Student_Id.AdvancedSearch.Save(); // int_Student_Id
                str_NationalID_Iqama.AdvancedSearch.Save(); // str_NationalID_Iqama
                NationalID.AdvancedSearch.Save(); // NationalID
                str_First_Name.AdvancedSearch.Save(); // str_First_Name
                str_Middle_Name.AdvancedSearch.Save(); // str_Middle_Name
                str_Last_Name.AdvancedSearch.Save(); // str_Last_Name
                str_Address1.AdvancedSearch.Save(); // str_Address1
                str_Address2.AdvancedSearch.Save(); // str_Address2
                int_State.AdvancedSearch.Save(); // int_State
                str_City.AdvancedSearch.Save(); // str_City
                str_Zip.AdvancedSearch.Save(); // str_Zip
                int_Instructor.AdvancedSearch.Save(); // int_Instructor
                int_Driver.AdvancedSearch.Save(); // int_Driver
                str_Home_Phone.AdvancedSearch.Save(); // str_Home_Phone
                str_Cell_Phone.AdvancedSearch.Save(); // str_Cell_Phone
                str_Parent_Phone.AdvancedSearch.Save(); // str_Parent_Phone
                str_Other_Phone.AdvancedSearch.Save(); // str_Other_Phone
                str_Email.AdvancedSearch.Save(); // str_Email
                str_ParentName.AdvancedSearch.Save(); // str_ParentName
                str_ParentEmail1.AdvancedSearch.Save(); // str_ParentEmail1
                str_ParentEmail2.AdvancedSearch.Save(); // str_ParentEmail2
                str_Username.AdvancedSearch.Save(); // str_Username
                str_Password.AdvancedSearch.Save(); // str_Password
                str_DOB.AdvancedSearch.Save(); // str_DOB
                int_DOB_Day.AdvancedSearch.Save(); // int_DOB_Day
                int_DOB_Month.AdvancedSearch.Save(); // int_DOB_Month
                int_DOB_Year.AdvancedSearch.Save(); // int_DOB_Year
                int_Age.AdvancedSearch.Save(); // int_Age
                int_Type.AdvancedSearch.Save(); // int_Type
                int_Wear_Glasses.AdvancedSearch.Save(); // int_Wear_Glasses
                int_Sex.AdvancedSearch.Save(); // int_Sex
                str_DLPermit.AdvancedSearch.Save(); // str_DLPermit
                dt_Date_PermitIssue.AdvancedSearch.Save(); // dt_Date_PermitIssue
                dt_Date_ExpirePermit.AdvancedSearch.Save(); // dt_Date_ExpirePermit
                int_Hs_ID.AdvancedSearch.Save(); // int_Hs_ID
                str_Emergency_Contact_Name.AdvancedSearch.Save(); // str_Emergency_Contact_Name
                str_Emergency_Contact_Phone.AdvancedSearch.Save(); // str_Emergency_Contact_Phone
                str_Emergency_Contact_Relation.AdvancedSearch.Save(); // str_Emergency_Contact_Relation
                str_Student_Notes.AdvancedSearch.Save(); // str_Student_Notes
                str_Driving_Notes.AdvancedSearch.Save(); // str_Driving_Notes
                int_Location_Id.AdvancedSearch.Save(); // int_Location_Id
                int_Permit_Number.AdvancedSearch.Save(); // int_Permit_Number
                Permit_Issue_Date.AdvancedSearch.Save(); // Permit_Issue_Date
                Permit_Expiry_Date.AdvancedSearch.Save(); // Permit_Expiry_Date
                int_Status.AdvancedSearch.Save(); // int_Status
                int_Lead_Id.AdvancedSearch.Save(); // int_Lead_Id
                int_Activated_By.AdvancedSearch.Save(); // int_Activated_By
                date_Activated.AdvancedSearch.Save(); // date_Activated
                date_Created.AdvancedSearch.Save(); // date_Created
                date_Modified.AdvancedSearch.Save(); // date_Modified
                date_Complete.AdvancedSearch.Save(); // date_Complete
                int_Created_By.AdvancedSearch.Save(); // int_Created_By
                int_Modified_By.AdvancedSearch.Save(); // int_Modified_By
                bit_IsDeleted.AdvancedSearch.Save(); // bit_IsDeleted
                str_CardHolderName.AdvancedSearch.Save(); // str_CardHolderName
                str_CardHolderAddress.AdvancedSearch.Save(); // str_CardHolderAddress
                str_CardHolderCity.AdvancedSearch.Save(); // str_CardHolderCity
                str_CardHolderZip.AdvancedSearch.Save(); // str_CardHolderZip
                str_CardType.AdvancedSearch.Save(); // str_CardType
                str_CardExpMonth.AdvancedSearch.Save(); // str_CardExpMonth
                str_CardExpYear.AdvancedSearch.Save(); // str_CardExpYear
                str_CardNo.AdvancedSearch.Save(); // str_CardNo
                str_Certificate_No.AdvancedSearch.Save(); // str_Certificate_No
                str_AmountPaid.AdvancedSearch.Save(); // str_AmountPaid
                str_PermitValidated.AdvancedSearch.Save(); // str_PermitValidated
                strSMSNotification.AdvancedSearch.Save(); // strSMSNotification
                strVoiceNotification.AdvancedSearch.Save(); // strVoiceNotification
                str_Weight.AdvancedSearch.Save(); // str_Weight
                str_SpecialNeeds.AdvancedSearch.Save(); // str_SpecialNeeds
                str_MedicalConditions.AdvancedSearch.Save(); // str_MedicalConditions
                bit_Verified_PIC_InSAW.AdvancedSearch.Save(); // bit_Verified_PIC_InSAW
                bit_Permit_Waiver_Entered.AdvancedSearch.Save(); // bit_Permit_Waiver_Entered
                bit_TermsConditions.AdvancedSearch.Save(); // bit_TermsConditions
                bit_Disable_Self_Scheduling.AdvancedSearch.Save(); // bit_Disable_Self_Scheduling
                int_EyeColor.AdvancedSearch.Save(); // int_EyeColor
                int_HairColor.AdvancedSearch.Save(); // int_HairColor
                int_ColorBlind.AdvancedSearch.Save(); // int_ColorBlind
                int_HeightFeet.AdvancedSearch.Save(); // int_HeightFeet
                int_HeightInches.AdvancedSearch.Save(); // int_HeightInches
                str_reference_code.AdvancedSearch.Save(); // str_reference_code
                dt_ParentClassAttendedDt.AdvancedSearch.Save(); // dt_ParentClassAttendedDt
                str_ParentClassAttendedLoc.AdvancedSearch.Save(); // str_ParentClassAttendedLoc
                dt_SiblingClassAttendedDt.AdvancedSearch.Save(); // dt_SiblingClassAttendedDt
                str_SiblingClassAttendedLoc.AdvancedSearch.Save(); // str_SiblingClassAttendedLoc
                bit_PoliciesAndProcedures.AdvancedSearch.Save(); // bit_PoliciesAndProcedures
                dt_CourseCompletionDt.AdvancedSearch.Save(); // dt_CourseCompletionDt
                dt_ExtensionDt.AdvancedSearch.Save(); // dt_ExtensionDt
                str_MedicalCondition.AdvancedSearch.Save(); // str_MedicalCondition
                str_MajorCrossStreets.AdvancedSearch.Save(); // str_MajorCrossStreets
                str_DriverEdCertNo.AdvancedSearch.Save(); // str_DriverEdCertNo
                dt_DriverEdCertIssuedDt.AdvancedSearch.Save(); // dt_DriverEdCertIssuedDt
                str_BTWDriversEdCertNo.AdvancedSearch.Save(); // str_BTWDriversEdCertNo
                dt_BTWCertIssuedDt.AdvancedSearch.Save(); // dt_BTWCertIssuedDt
                str_OLDriversEdCertNo.AdvancedSearch.Save(); // str_OLDriversEdCertNo
                dt_OLCertIssuedDt.AdvancedSearch.Save(); // dt_OLCertIssuedDt
                str_height.AdvancedSearch.Save(); // str_height
                dt_BTWCompletionDt.AdvancedSearch.Save(); // dt_BTWCompletionDt
                dt_CRCompletionDt.AdvancedSearch.Save(); // dt_CRCompletionDt
                strTextBox5.AdvancedSearch.Save(); // strTextBox5
                strTextBox6.AdvancedSearch.Save(); // strTextBox6
                str_ApartmentNo.AdvancedSearch.Save(); // str_ApartmentNo
                dt_PermitTestDate.AdvancedSearch.Save(); // dt_PermitTestDate
                str_OnlineDriverEdLogin.AdvancedSearch.Save(); // str_OnlineDriverEdLogin
                str_OnlineDriverEdPassword.AdvancedSearch.Save(); // str_OnlineDriverEdPassword
                bit_IsSMSEnabled.AdvancedSearch.Save(); // bit_IsSMSEnabled
                dt_SMSModified.AdvancedSearch.Save(); // dt_SMSModified
                str_confirmPassword.AdvancedSearch.Save(); // str_confirmPassword
                DE_Certificate.AdvancedSearch.Save(); // DE_Certificate
                Discuss.AdvancedSearch.Save(); // Discuss
                int_UnlicensedSibling.AdvancedSearch.Save(); // int_UnlicensedSibling
                int_YearSiblingIsEligible.AdvancedSearch.Save(); // int_YearSiblingIsEligible
                BTW_Certificate.AdvancedSearch.Save(); // BTW_Certificate
                dt_DECertIssueDate.AdvancedSearch.Save(); // dt_DECertIssueDate
                str_StudentSignature.AdvancedSearch.Save(); // str_StudentSignature
                str_ParentSignature.AdvancedSearch.Save(); // str_ParentSignature
                str_Last6DigitsOfParentDriversLicense.AdvancedSearch.Save(); // str_Last6DigitsOfParentDriversLicense
                str_FACControl.AdvancedSearch.Save(); // str_FACControl
                Classroom_Status_Code.AdvancedSearch.Save(); // Classroom_Status_Code
                Laboratory_Status_Code.AdvancedSearch.Save(); // Laboratory_Status_Code
                bit_EnrollmentForm.AdvancedSearch.Save(); // bit_EnrollmentForm
                bit_ParentStudentContract.AdvancedSearch.Save(); // bit_ParentStudentContract
                bit_ParentalAgreement.AdvancedSearch.Save(); // bit_ParentalAgreement
                int_SF_GR_WA_HS.AdvancedSearch.Save(); // int_SF_GR_WA_HS
                bit_DisableOnRMV.AdvancedSearch.Save(); // bit_DisableOnRMV
                bit_UploadedToRMV.AdvancedSearch.Save(); // bit_UploadedToRMV
                str_Mother_Name.AdvancedSearch.Save(); // str_Mother_Name
                str_Guardians_Name.AdvancedSearch.Save(); // str_Guardians_Name
                str_Mother_Phone.AdvancedSearch.Save(); // str_Mother_Phone
                bit_terms.AdvancedSearch.Save(); // bit_terms
                int_Nationality.AdvancedSearch.Save(); // int_Nationality
                str_National_ID_en.AdvancedSearch.Save(); // str_National_ID_en
                str_National_ID_arabic.AdvancedSearch.Save(); // str_National_ID_arabic
                Quallification_Id.AdvancedSearch.Save(); // Quallification_Id
                Job_Id.AdvancedSearch.Save(); // Job_Id
                str_DOB_arabic.AdvancedSearch.Save(); // str_DOB_arabic
                int_Language.AdvancedSearch.Save(); // int_Language
                strRefId.AdvancedSearch.Save(); // strRefId
                int_Program_Id.AdvancedSearch.Save(); // int_Program_Id
                IsDrivingexperience.AdvancedSearch.Save(); // IsDrivingexperience
                IsScheduleassessment.AdvancedSearch.Save(); // IsScheduleassessment
                IsEnrollbyyourself.AdvancedSearch.Save(); // IsEnrollbyyourself
                AssessmentTime.AdvancedSearch.Save(); // AssessmentTime
                AssessmentDate.AdvancedSearch.Save(); // AssessmentDate
                isAssessmentDone.AdvancedSearch.Save(); // isAssessmentDone
                AssessmentScore.AdvancedSearch.Save(); // AssessmentScore
                dt_WrittenTestPassed.AdvancedSearch.Save(); // dt_WrittenTestPassed
                dt_RoadTestPassed.AdvancedSearch.Save(); // dt_RoadTestPassed
                bit_Archive.AdvancedSearch.Save(); // bit_Archive
                ArchiveNotes.AdvancedSearch.Save(); // ArchiveNotes
                dtArchived.AdvancedSearch.Save(); // dtArchived
                SrNo9Dec21.AdvancedSearch.Save(); // SrNo9Dec21
                REGNNUMB.AdvancedSearch.Save(); // REGNNUMB
                REGNLOCN.AdvancedSearch.Save(); // REGNLOCN
                SrNo11DecF1S1.AdvancedSearch.Save(); // SrNo11DecF1S1
                IsInterestedInTraining.AdvancedSearch.Save(); // IsInterestedInTraining
                StudentEncryptID.AdvancedSearch.Save(); // StudentEncryptID
                StudentConfirURL.AdvancedSearch.Save(); // StudentConfirURL
                SrNo15DecF1S2.AdvancedSearch.Save(); // SrNo15DecF1S2
                SrNo15DecF1S3.AdvancedSearch.Save(); // SrNo15DecF1S3
                SrNo16DecF2S2.AdvancedSearch.Save(); // SrNo16DecF2S2
                SrNo16DecF2S3.AdvancedSearch.Save(); // SrNo16DecF2S3
                SrNo16DecF3S1.AdvancedSearch.Save(); // SrNo16DecF3S1
                SrNo16DecF3S2.AdvancedSearch.Save(); // SrNo16DecF3S2
                SrNo16DecF4S1.AdvancedSearch.Save(); // SrNo16DecF4S1
                SrNo16DecF4S2.AdvancedSearch.Save(); // SrNo16DecF4S2
                SrNo16DecF4S3.AdvancedSearch.Save(); // SrNo16DecF4S3
                StudentAssementBookingURL.AdvancedSearch.Save(); // StudentAssementBookingURL
                intDrivinglicenseType.AdvancedSearch.Save(); // intDrivinglicenseType
                Isdrivinglicense.AdvancedSearch.Save(); // Isdrivinglicense
                drivinglicensenumber.AdvancedSearch.Save(); // drivinglicensenumber
                Absher_Appointment_number.AdvancedSearch.Save(); // Absher_Appointment_number
                DataImportId.AdvancedSearch.Save(); // DataImportId
                date_Birth_Hijri.AdvancedSearch.Save(); // date_Birth_Hijri
                UserlevelID.AdvancedSearch.Save(); // UserlevelID
                Activated.AdvancedSearch.Save(); // Activated
                Absherphoto.AdvancedSearch.Save(); // Absherphoto
                Fingerprint.AdvancedSearch.Save(); // Fingerprint
                Required_Program.AdvancedSearch.Save(); // Required_Program
                Price.AdvancedSearch.Save(); // Price
                Hijri_Day.AdvancedSearch.Save(); // Hijri_Day
                Hijri_Month.AdvancedSearch.Save(); // Hijri_Month
                Hijri_Year.AdvancedSearch.Save(); // Hijri_Year
                Course_Price.AdvancedSearch.Save(); // Course_Price
                Vat_Tax_15.AdvancedSearch.Save(); // Vat_Tax_15
                dec_Balance.AdvancedSearch.Save(); // dec_Balance
                Total_Price.AdvancedSearch.Save(); // Total_Price
                Payment_Online.AdvancedSearch.Save(); // Payment_Online
                Institution.AdvancedSearch.Save(); // Institution
                WaitingList.AdvancedSearch.Save(); // WaitingList
                Assessment_ID.AdvancedSearch.Save(); // Assessment_ID

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

            // Field NationalID
            filter = QueryBuilderWhere("NationalID");
            if (Empty(filter))
                BuildSearchSql(ref filter, NationalID, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + NationalID.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_First_Name
            filter = QueryBuilderWhere("str_First_Name");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_First_Name, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_First_Name.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_Last_Name
            filter = QueryBuilderWhere("str_Last_Name");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_Last_Name, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_Last_Name.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_Cell_Phone
            filter = QueryBuilderWhere("str_Cell_Phone");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_Cell_Phone, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_Cell_Phone.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field Required_Program
            filter = QueryBuilderWhere("Required_Program");
            if (Empty(filter))
                BuildSearchSql(ref filter, Required_Program, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + Required_Program.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field Price
            filter = QueryBuilderWhere("Price");
            if (Empty(filter))
                BuildSearchSql(ref filter, Price, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + Price.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field Payment_Online
            filter = QueryBuilderWhere("Payment_Online");
            if (Empty(filter))
                BuildSearchSql(ref filter, Payment_Online, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + Payment_Online.Caption + "</span>" + captionSuffix + filter + "</div>";
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
            searchFlds.Add(str_NationalID_Iqama);
            searchFlds.Add(NationalID);
            searchFlds.Add(str_First_Name);
            searchFlds.Add(str_Middle_Name);
            searchFlds.Add(str_Last_Name);
            searchFlds.Add(str_Zip);
            searchFlds.Add(str_Home_Phone);
            searchFlds.Add(str_Cell_Phone);
            searchFlds.Add(str_Parent_Phone);
            searchFlds.Add(str_Other_Phone);
            searchFlds.Add(str_Email);
            searchFlds.Add(str_ParentName);
            searchFlds.Add(str_ParentEmail2);
            searchFlds.Add(str_Username);
            searchFlds.Add(str_Password);
            searchFlds.Add(str_DLPermit);
            searchFlds.Add(str_Emergency_Contact_Name);
            searchFlds.Add(str_Emergency_Contact_Phone);
            searchFlds.Add(str_Emergency_Contact_Relation);
            searchFlds.Add(str_Student_Notes);
            searchFlds.Add(str_Driving_Notes);
            searchFlds.Add(int_Permit_Number);
            searchFlds.Add(Permit_Issue_Date);
            searchFlds.Add(str_CardHolderName);
            searchFlds.Add(str_CardHolderAddress);
            searchFlds.Add(str_CardHolderCity);
            searchFlds.Add(str_CardHolderZip);
            searchFlds.Add(str_CardType);
            searchFlds.Add(str_CardExpMonth);
            searchFlds.Add(str_CardExpYear);
            searchFlds.Add(str_CardNo);
            searchFlds.Add(str_Certificate_No);
            searchFlds.Add(str_PermitValidated);
            searchFlds.Add(strSMSNotification);
            searchFlds.Add(strVoiceNotification);
            searchFlds.Add(str_Weight);
            searchFlds.Add(str_SpecialNeeds);
            searchFlds.Add(str_MedicalConditions);
            searchFlds.Add(str_reference_code);
            searchFlds.Add(str_ParentClassAttendedLoc);
            searchFlds.Add(str_SiblingClassAttendedLoc);
            searchFlds.Add(str_MedicalCondition);
            searchFlds.Add(str_MajorCrossStreets);
            searchFlds.Add(str_DriverEdCertNo);
            searchFlds.Add(str_BTWDriversEdCertNo);
            searchFlds.Add(str_OLDriversEdCertNo);
            searchFlds.Add(str_height);
            searchFlds.Add(strTextBox5);
            searchFlds.Add(strTextBox6);
            searchFlds.Add(str_ApartmentNo);
            searchFlds.Add(str_OnlineDriverEdLogin);
            searchFlds.Add(str_OnlineDriverEdPassword);
            searchFlds.Add(str_confirmPassword);
            searchFlds.Add(DE_Certificate);
            searchFlds.Add(Discuss);
            searchFlds.Add(BTW_Certificate);
            searchFlds.Add(dt_DECertIssueDate);
            searchFlds.Add(str_StudentSignature);
            searchFlds.Add(str_ParentSignature);
            searchFlds.Add(str_Last6DigitsOfParentDriversLicense);
            searchFlds.Add(str_FACControl);
            searchFlds.Add(Classroom_Status_Code);
            searchFlds.Add(Laboratory_Status_Code);
            searchFlds.Add(str_Mother_Name);
            searchFlds.Add(str_Guardians_Name);
            searchFlds.Add(str_Mother_Phone);
            searchFlds.Add(str_National_ID_en);
            searchFlds.Add(str_National_ID_arabic);
            searchFlds.Add(str_DOB_arabic);
            searchFlds.Add(strRefId);
            searchFlds.Add(AssessmentTime);
            searchFlds.Add(ArchiveNotes);
            searchFlds.Add(REGNNUMB);
            searchFlds.Add(REGNLOCN);
            searchFlds.Add(StudentEncryptID);
            searchFlds.Add(StudentConfirURL);
            searchFlds.Add(StudentAssementBookingURL);
            searchFlds.Add(drivinglicensenumber);
            searchFlds.Add(Absher_Appointment_number);
            searchFlds.Add(date_Birth_Hijri);
            searchFlds.Add(Absherphoto);
            searchFlds.Add(Fingerprint);
            searchFlds.Add(Required_Program);
            searchFlds.Add(Payment_Online);
            searchFlds.Add(Institution);
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
            if (int_Potential_Student_ID.AdvancedSearch.IssetSession)
                return true;
            if (int_Student_Id.AdvancedSearch.IssetSession)
                return true;
            if (str_NationalID_Iqama.AdvancedSearch.IssetSession)
                return true;
            if (NationalID.AdvancedSearch.IssetSession)
                return true;
            if (str_First_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_Middle_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_Last_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_Address1.AdvancedSearch.IssetSession)
                return true;
            if (str_Address2.AdvancedSearch.IssetSession)
                return true;
            if (int_State.AdvancedSearch.IssetSession)
                return true;
            if (str_City.AdvancedSearch.IssetSession)
                return true;
            if (str_Zip.AdvancedSearch.IssetSession)
                return true;
            if (int_Instructor.AdvancedSearch.IssetSession)
                return true;
            if (int_Driver.AdvancedSearch.IssetSession)
                return true;
            if (str_Home_Phone.AdvancedSearch.IssetSession)
                return true;
            if (str_Cell_Phone.AdvancedSearch.IssetSession)
                return true;
            if (str_Parent_Phone.AdvancedSearch.IssetSession)
                return true;
            if (str_Other_Phone.AdvancedSearch.IssetSession)
                return true;
            if (str_Email.AdvancedSearch.IssetSession)
                return true;
            if (str_ParentName.AdvancedSearch.IssetSession)
                return true;
            if (str_ParentEmail1.AdvancedSearch.IssetSession)
                return true;
            if (str_ParentEmail2.AdvancedSearch.IssetSession)
                return true;
            if (str_Username.AdvancedSearch.IssetSession)
                return true;
            if (str_Password.AdvancedSearch.IssetSession)
                return true;
            if (str_DOB.AdvancedSearch.IssetSession)
                return true;
            if (int_DOB_Day.AdvancedSearch.IssetSession)
                return true;
            if (int_DOB_Month.AdvancedSearch.IssetSession)
                return true;
            if (int_DOB_Year.AdvancedSearch.IssetSession)
                return true;
            if (int_Age.AdvancedSearch.IssetSession)
                return true;
            if (int_Type.AdvancedSearch.IssetSession)
                return true;
            if (int_Wear_Glasses.AdvancedSearch.IssetSession)
                return true;
            if (int_Sex.AdvancedSearch.IssetSession)
                return true;
            if (str_DLPermit.AdvancedSearch.IssetSession)
                return true;
            if (dt_Date_PermitIssue.AdvancedSearch.IssetSession)
                return true;
            if (dt_Date_ExpirePermit.AdvancedSearch.IssetSession)
                return true;
            if (int_Hs_ID.AdvancedSearch.IssetSession)
                return true;
            if (str_Emergency_Contact_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_Emergency_Contact_Phone.AdvancedSearch.IssetSession)
                return true;
            if (str_Emergency_Contact_Relation.AdvancedSearch.IssetSession)
                return true;
            if (str_Student_Notes.AdvancedSearch.IssetSession)
                return true;
            if (str_Driving_Notes.AdvancedSearch.IssetSession)
                return true;
            if (int_Location_Id.AdvancedSearch.IssetSession)
                return true;
            if (int_Permit_Number.AdvancedSearch.IssetSession)
                return true;
            if (Permit_Issue_Date.AdvancedSearch.IssetSession)
                return true;
            if (Permit_Expiry_Date.AdvancedSearch.IssetSession)
                return true;
            if (int_Status.AdvancedSearch.IssetSession)
                return true;
            if (int_Lead_Id.AdvancedSearch.IssetSession)
                return true;
            if (int_Activated_By.AdvancedSearch.IssetSession)
                return true;
            if (date_Activated.AdvancedSearch.IssetSession)
                return true;
            if (date_Created.AdvancedSearch.IssetSession)
                return true;
            if (date_Modified.AdvancedSearch.IssetSession)
                return true;
            if (date_Complete.AdvancedSearch.IssetSession)
                return true;
            if (int_Created_By.AdvancedSearch.IssetSession)
                return true;
            if (int_Modified_By.AdvancedSearch.IssetSession)
                return true;
            if (bit_IsDeleted.AdvancedSearch.IssetSession)
                return true;
            if (str_CardHolderName.AdvancedSearch.IssetSession)
                return true;
            if (str_CardHolderAddress.AdvancedSearch.IssetSession)
                return true;
            if (str_CardHolderCity.AdvancedSearch.IssetSession)
                return true;
            if (str_CardHolderZip.AdvancedSearch.IssetSession)
                return true;
            if (str_CardType.AdvancedSearch.IssetSession)
                return true;
            if (str_CardExpMonth.AdvancedSearch.IssetSession)
                return true;
            if (str_CardExpYear.AdvancedSearch.IssetSession)
                return true;
            if (str_CardNo.AdvancedSearch.IssetSession)
                return true;
            if (str_Certificate_No.AdvancedSearch.IssetSession)
                return true;
            if (str_AmountPaid.AdvancedSearch.IssetSession)
                return true;
            if (str_PermitValidated.AdvancedSearch.IssetSession)
                return true;
            if (strSMSNotification.AdvancedSearch.IssetSession)
                return true;
            if (strVoiceNotification.AdvancedSearch.IssetSession)
                return true;
            if (str_Weight.AdvancedSearch.IssetSession)
                return true;
            if (str_SpecialNeeds.AdvancedSearch.IssetSession)
                return true;
            if (str_MedicalConditions.AdvancedSearch.IssetSession)
                return true;
            if (bit_Verified_PIC_InSAW.AdvancedSearch.IssetSession)
                return true;
            if (bit_Permit_Waiver_Entered.AdvancedSearch.IssetSession)
                return true;
            if (bit_TermsConditions.AdvancedSearch.IssetSession)
                return true;
            if (bit_Disable_Self_Scheduling.AdvancedSearch.IssetSession)
                return true;
            if (int_EyeColor.AdvancedSearch.IssetSession)
                return true;
            if (int_HairColor.AdvancedSearch.IssetSession)
                return true;
            if (int_ColorBlind.AdvancedSearch.IssetSession)
                return true;
            if (int_HeightFeet.AdvancedSearch.IssetSession)
                return true;
            if (int_HeightInches.AdvancedSearch.IssetSession)
                return true;
            if (str_reference_code.AdvancedSearch.IssetSession)
                return true;
            if (dt_ParentClassAttendedDt.AdvancedSearch.IssetSession)
                return true;
            if (str_ParentClassAttendedLoc.AdvancedSearch.IssetSession)
                return true;
            if (dt_SiblingClassAttendedDt.AdvancedSearch.IssetSession)
                return true;
            if (str_SiblingClassAttendedLoc.AdvancedSearch.IssetSession)
                return true;
            if (bit_PoliciesAndProcedures.AdvancedSearch.IssetSession)
                return true;
            if (dt_CourseCompletionDt.AdvancedSearch.IssetSession)
                return true;
            if (dt_ExtensionDt.AdvancedSearch.IssetSession)
                return true;
            if (str_MedicalCondition.AdvancedSearch.IssetSession)
                return true;
            if (str_MajorCrossStreets.AdvancedSearch.IssetSession)
                return true;
            if (str_DriverEdCertNo.AdvancedSearch.IssetSession)
                return true;
            if (dt_DriverEdCertIssuedDt.AdvancedSearch.IssetSession)
                return true;
            if (str_BTWDriversEdCertNo.AdvancedSearch.IssetSession)
                return true;
            if (dt_BTWCertIssuedDt.AdvancedSearch.IssetSession)
                return true;
            if (str_OLDriversEdCertNo.AdvancedSearch.IssetSession)
                return true;
            if (dt_OLCertIssuedDt.AdvancedSearch.IssetSession)
                return true;
            if (str_height.AdvancedSearch.IssetSession)
                return true;
            if (dt_BTWCompletionDt.AdvancedSearch.IssetSession)
                return true;
            if (dt_CRCompletionDt.AdvancedSearch.IssetSession)
                return true;
            if (strTextBox5.AdvancedSearch.IssetSession)
                return true;
            if (strTextBox6.AdvancedSearch.IssetSession)
                return true;
            if (str_ApartmentNo.AdvancedSearch.IssetSession)
                return true;
            if (dt_PermitTestDate.AdvancedSearch.IssetSession)
                return true;
            if (str_OnlineDriverEdLogin.AdvancedSearch.IssetSession)
                return true;
            if (str_OnlineDriverEdPassword.AdvancedSearch.IssetSession)
                return true;
            if (bit_IsSMSEnabled.AdvancedSearch.IssetSession)
                return true;
            if (dt_SMSModified.AdvancedSearch.IssetSession)
                return true;
            if (str_confirmPassword.AdvancedSearch.IssetSession)
                return true;
            if (DE_Certificate.AdvancedSearch.IssetSession)
                return true;
            if (Discuss.AdvancedSearch.IssetSession)
                return true;
            if (int_UnlicensedSibling.AdvancedSearch.IssetSession)
                return true;
            if (int_YearSiblingIsEligible.AdvancedSearch.IssetSession)
                return true;
            if (BTW_Certificate.AdvancedSearch.IssetSession)
                return true;
            if (dt_DECertIssueDate.AdvancedSearch.IssetSession)
                return true;
            if (str_StudentSignature.AdvancedSearch.IssetSession)
                return true;
            if (str_ParentSignature.AdvancedSearch.IssetSession)
                return true;
            if (str_Last6DigitsOfParentDriversLicense.AdvancedSearch.IssetSession)
                return true;
            if (str_FACControl.AdvancedSearch.IssetSession)
                return true;
            if (Classroom_Status_Code.AdvancedSearch.IssetSession)
                return true;
            if (Laboratory_Status_Code.AdvancedSearch.IssetSession)
                return true;
            if (bit_EnrollmentForm.AdvancedSearch.IssetSession)
                return true;
            if (bit_ParentStudentContract.AdvancedSearch.IssetSession)
                return true;
            if (bit_ParentalAgreement.AdvancedSearch.IssetSession)
                return true;
            if (int_SF_GR_WA_HS.AdvancedSearch.IssetSession)
                return true;
            if (bit_DisableOnRMV.AdvancedSearch.IssetSession)
                return true;
            if (bit_UploadedToRMV.AdvancedSearch.IssetSession)
                return true;
            if (str_Mother_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_Guardians_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_Mother_Phone.AdvancedSearch.IssetSession)
                return true;
            if (bit_terms.AdvancedSearch.IssetSession)
                return true;
            if (int_Nationality.AdvancedSearch.IssetSession)
                return true;
            if (str_National_ID_en.AdvancedSearch.IssetSession)
                return true;
            if (str_National_ID_arabic.AdvancedSearch.IssetSession)
                return true;
            if (Quallification_Id.AdvancedSearch.IssetSession)
                return true;
            if (Job_Id.AdvancedSearch.IssetSession)
                return true;
            if (str_DOB_arabic.AdvancedSearch.IssetSession)
                return true;
            if (int_Language.AdvancedSearch.IssetSession)
                return true;
            if (strRefId.AdvancedSearch.IssetSession)
                return true;
            if (int_Program_Id.AdvancedSearch.IssetSession)
                return true;
            if (IsDrivingexperience.AdvancedSearch.IssetSession)
                return true;
            if (IsScheduleassessment.AdvancedSearch.IssetSession)
                return true;
            if (IsEnrollbyyourself.AdvancedSearch.IssetSession)
                return true;
            if (AssessmentTime.AdvancedSearch.IssetSession)
                return true;
            if (AssessmentDate.AdvancedSearch.IssetSession)
                return true;
            if (isAssessmentDone.AdvancedSearch.IssetSession)
                return true;
            if (AssessmentScore.AdvancedSearch.IssetSession)
                return true;
            if (dt_WrittenTestPassed.AdvancedSearch.IssetSession)
                return true;
            if (dt_RoadTestPassed.AdvancedSearch.IssetSession)
                return true;
            if (bit_Archive.AdvancedSearch.IssetSession)
                return true;
            if (ArchiveNotes.AdvancedSearch.IssetSession)
                return true;
            if (dtArchived.AdvancedSearch.IssetSession)
                return true;
            if (SrNo9Dec21.AdvancedSearch.IssetSession)
                return true;
            if (REGNNUMB.AdvancedSearch.IssetSession)
                return true;
            if (REGNLOCN.AdvancedSearch.IssetSession)
                return true;
            if (SrNo11DecF1S1.AdvancedSearch.IssetSession)
                return true;
            if (IsInterestedInTraining.AdvancedSearch.IssetSession)
                return true;
            if (StudentEncryptID.AdvancedSearch.IssetSession)
                return true;
            if (StudentConfirURL.AdvancedSearch.IssetSession)
                return true;
            if (SrNo15DecF1S2.AdvancedSearch.IssetSession)
                return true;
            if (SrNo15DecF1S3.AdvancedSearch.IssetSession)
                return true;
            if (SrNo16DecF2S2.AdvancedSearch.IssetSession)
                return true;
            if (SrNo16DecF2S3.AdvancedSearch.IssetSession)
                return true;
            if (SrNo16DecF3S1.AdvancedSearch.IssetSession)
                return true;
            if (SrNo16DecF3S2.AdvancedSearch.IssetSession)
                return true;
            if (SrNo16DecF4S1.AdvancedSearch.IssetSession)
                return true;
            if (SrNo16DecF4S2.AdvancedSearch.IssetSession)
                return true;
            if (SrNo16DecF4S3.AdvancedSearch.IssetSession)
                return true;
            if (StudentAssementBookingURL.AdvancedSearch.IssetSession)
                return true;
            if (intDrivinglicenseType.AdvancedSearch.IssetSession)
                return true;
            if (Isdrivinglicense.AdvancedSearch.IssetSession)
                return true;
            if (drivinglicensenumber.AdvancedSearch.IssetSession)
                return true;
            if (Absher_Appointment_number.AdvancedSearch.IssetSession)
                return true;
            if (DataImportId.AdvancedSearch.IssetSession)
                return true;
            if (date_Birth_Hijri.AdvancedSearch.IssetSession)
                return true;
            if (UserlevelID.AdvancedSearch.IssetSession)
                return true;
            if (Activated.AdvancedSearch.IssetSession)
                return true;
            if (Absherphoto.AdvancedSearch.IssetSession)
                return true;
            if (Fingerprint.AdvancedSearch.IssetSession)
                return true;
            if (Required_Program.AdvancedSearch.IssetSession)
                return true;
            if (Price.AdvancedSearch.IssetSession)
                return true;
            if (Hijri_Day.AdvancedSearch.IssetSession)
                return true;
            if (Hijri_Month.AdvancedSearch.IssetSession)
                return true;
            if (Hijri_Year.AdvancedSearch.IssetSession)
                return true;
            if (Course_Price.AdvancedSearch.IssetSession)
                return true;
            if (Vat_Tax_15.AdvancedSearch.IssetSession)
                return true;
            if (dec_Balance.AdvancedSearch.IssetSession)
                return true;
            if (Total_Price.AdvancedSearch.IssetSession)
                return true;
            if (Payment_Online.AdvancedSearch.IssetSession)
                return true;
            if (Institution.AdvancedSearch.IssetSession)
                return true;
            if (WaitingList.AdvancedSearch.IssetSession)
                return true;
            if (Assessment_ID.AdvancedSearch.IssetSession)
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
            int_Potential_Student_ID.AdvancedSearch.UnsetSession();
            int_Student_Id.AdvancedSearch.UnsetSession();
            str_NationalID_Iqama.AdvancedSearch.UnsetSession();
            NationalID.AdvancedSearch.UnsetSession();
            str_First_Name.AdvancedSearch.UnsetSession();
            str_Middle_Name.AdvancedSearch.UnsetSession();
            str_Last_Name.AdvancedSearch.UnsetSession();
            str_Address1.AdvancedSearch.UnsetSession();
            str_Address2.AdvancedSearch.UnsetSession();
            int_State.AdvancedSearch.UnsetSession();
            str_City.AdvancedSearch.UnsetSession();
            str_Zip.AdvancedSearch.UnsetSession();
            int_Instructor.AdvancedSearch.UnsetSession();
            int_Driver.AdvancedSearch.UnsetSession();
            str_Home_Phone.AdvancedSearch.UnsetSession();
            str_Cell_Phone.AdvancedSearch.UnsetSession();
            str_Parent_Phone.AdvancedSearch.UnsetSession();
            str_Other_Phone.AdvancedSearch.UnsetSession();
            str_Email.AdvancedSearch.UnsetSession();
            str_ParentName.AdvancedSearch.UnsetSession();
            str_ParentEmail1.AdvancedSearch.UnsetSession();
            str_ParentEmail2.AdvancedSearch.UnsetSession();
            str_Username.AdvancedSearch.UnsetSession();
            str_Password.AdvancedSearch.UnsetSession();
            str_DOB.AdvancedSearch.UnsetSession();
            int_DOB_Day.AdvancedSearch.UnsetSession();
            int_DOB_Month.AdvancedSearch.UnsetSession();
            int_DOB_Year.AdvancedSearch.UnsetSession();
            int_Age.AdvancedSearch.UnsetSession();
            int_Type.AdvancedSearch.UnsetSession();
            int_Wear_Glasses.AdvancedSearch.UnsetSession();
            int_Sex.AdvancedSearch.UnsetSession();
            str_DLPermit.AdvancedSearch.UnsetSession();
            dt_Date_PermitIssue.AdvancedSearch.UnsetSession();
            dt_Date_ExpirePermit.AdvancedSearch.UnsetSession();
            int_Hs_ID.AdvancedSearch.UnsetSession();
            str_Emergency_Contact_Name.AdvancedSearch.UnsetSession();
            str_Emergency_Contact_Phone.AdvancedSearch.UnsetSession();
            str_Emergency_Contact_Relation.AdvancedSearch.UnsetSession();
            str_Student_Notes.AdvancedSearch.UnsetSession();
            str_Driving_Notes.AdvancedSearch.UnsetSession();
            int_Location_Id.AdvancedSearch.UnsetSession();
            int_Permit_Number.AdvancedSearch.UnsetSession();
            Permit_Issue_Date.AdvancedSearch.UnsetSession();
            Permit_Expiry_Date.AdvancedSearch.UnsetSession();
            int_Status.AdvancedSearch.UnsetSession();
            int_Lead_Id.AdvancedSearch.UnsetSession();
            int_Activated_By.AdvancedSearch.UnsetSession();
            date_Activated.AdvancedSearch.UnsetSession();
            date_Created.AdvancedSearch.UnsetSession();
            date_Modified.AdvancedSearch.UnsetSession();
            date_Complete.AdvancedSearch.UnsetSession();
            int_Created_By.AdvancedSearch.UnsetSession();
            int_Modified_By.AdvancedSearch.UnsetSession();
            bit_IsDeleted.AdvancedSearch.UnsetSession();
            str_CardHolderName.AdvancedSearch.UnsetSession();
            str_CardHolderAddress.AdvancedSearch.UnsetSession();
            str_CardHolderCity.AdvancedSearch.UnsetSession();
            str_CardHolderZip.AdvancedSearch.UnsetSession();
            str_CardType.AdvancedSearch.UnsetSession();
            str_CardExpMonth.AdvancedSearch.UnsetSession();
            str_CardExpYear.AdvancedSearch.UnsetSession();
            str_CardNo.AdvancedSearch.UnsetSession();
            str_Certificate_No.AdvancedSearch.UnsetSession();
            str_AmountPaid.AdvancedSearch.UnsetSession();
            str_PermitValidated.AdvancedSearch.UnsetSession();
            strSMSNotification.AdvancedSearch.UnsetSession();
            strVoiceNotification.AdvancedSearch.UnsetSession();
            str_Weight.AdvancedSearch.UnsetSession();
            str_SpecialNeeds.AdvancedSearch.UnsetSession();
            str_MedicalConditions.AdvancedSearch.UnsetSession();
            bit_Verified_PIC_InSAW.AdvancedSearch.UnsetSession();
            bit_Permit_Waiver_Entered.AdvancedSearch.UnsetSession();
            bit_TermsConditions.AdvancedSearch.UnsetSession();
            bit_Disable_Self_Scheduling.AdvancedSearch.UnsetSession();
            int_EyeColor.AdvancedSearch.UnsetSession();
            int_HairColor.AdvancedSearch.UnsetSession();
            int_ColorBlind.AdvancedSearch.UnsetSession();
            int_HeightFeet.AdvancedSearch.UnsetSession();
            int_HeightInches.AdvancedSearch.UnsetSession();
            str_reference_code.AdvancedSearch.UnsetSession();
            dt_ParentClassAttendedDt.AdvancedSearch.UnsetSession();
            str_ParentClassAttendedLoc.AdvancedSearch.UnsetSession();
            dt_SiblingClassAttendedDt.AdvancedSearch.UnsetSession();
            str_SiblingClassAttendedLoc.AdvancedSearch.UnsetSession();
            bit_PoliciesAndProcedures.AdvancedSearch.UnsetSession();
            dt_CourseCompletionDt.AdvancedSearch.UnsetSession();
            dt_ExtensionDt.AdvancedSearch.UnsetSession();
            str_MedicalCondition.AdvancedSearch.UnsetSession();
            str_MajorCrossStreets.AdvancedSearch.UnsetSession();
            str_DriverEdCertNo.AdvancedSearch.UnsetSession();
            dt_DriverEdCertIssuedDt.AdvancedSearch.UnsetSession();
            str_BTWDriversEdCertNo.AdvancedSearch.UnsetSession();
            dt_BTWCertIssuedDt.AdvancedSearch.UnsetSession();
            str_OLDriversEdCertNo.AdvancedSearch.UnsetSession();
            dt_OLCertIssuedDt.AdvancedSearch.UnsetSession();
            str_height.AdvancedSearch.UnsetSession();
            dt_BTWCompletionDt.AdvancedSearch.UnsetSession();
            dt_CRCompletionDt.AdvancedSearch.UnsetSession();
            strTextBox5.AdvancedSearch.UnsetSession();
            strTextBox6.AdvancedSearch.UnsetSession();
            str_ApartmentNo.AdvancedSearch.UnsetSession();
            dt_PermitTestDate.AdvancedSearch.UnsetSession();
            str_OnlineDriverEdLogin.AdvancedSearch.UnsetSession();
            str_OnlineDriverEdPassword.AdvancedSearch.UnsetSession();
            bit_IsSMSEnabled.AdvancedSearch.UnsetSession();
            dt_SMSModified.AdvancedSearch.UnsetSession();
            str_confirmPassword.AdvancedSearch.UnsetSession();
            DE_Certificate.AdvancedSearch.UnsetSession();
            Discuss.AdvancedSearch.UnsetSession();
            int_UnlicensedSibling.AdvancedSearch.UnsetSession();
            int_YearSiblingIsEligible.AdvancedSearch.UnsetSession();
            BTW_Certificate.AdvancedSearch.UnsetSession();
            dt_DECertIssueDate.AdvancedSearch.UnsetSession();
            str_StudentSignature.AdvancedSearch.UnsetSession();
            str_ParentSignature.AdvancedSearch.UnsetSession();
            str_Last6DigitsOfParentDriversLicense.AdvancedSearch.UnsetSession();
            str_FACControl.AdvancedSearch.UnsetSession();
            Classroom_Status_Code.AdvancedSearch.UnsetSession();
            Laboratory_Status_Code.AdvancedSearch.UnsetSession();
            bit_EnrollmentForm.AdvancedSearch.UnsetSession();
            bit_ParentStudentContract.AdvancedSearch.UnsetSession();
            bit_ParentalAgreement.AdvancedSearch.UnsetSession();
            int_SF_GR_WA_HS.AdvancedSearch.UnsetSession();
            bit_DisableOnRMV.AdvancedSearch.UnsetSession();
            bit_UploadedToRMV.AdvancedSearch.UnsetSession();
            str_Mother_Name.AdvancedSearch.UnsetSession();
            str_Guardians_Name.AdvancedSearch.UnsetSession();
            str_Mother_Phone.AdvancedSearch.UnsetSession();
            bit_terms.AdvancedSearch.UnsetSession();
            int_Nationality.AdvancedSearch.UnsetSession();
            str_National_ID_en.AdvancedSearch.UnsetSession();
            str_National_ID_arabic.AdvancedSearch.UnsetSession();
            Quallification_Id.AdvancedSearch.UnsetSession();
            Job_Id.AdvancedSearch.UnsetSession();
            str_DOB_arabic.AdvancedSearch.UnsetSession();
            int_Language.AdvancedSearch.UnsetSession();
            strRefId.AdvancedSearch.UnsetSession();
            int_Program_Id.AdvancedSearch.UnsetSession();
            IsDrivingexperience.AdvancedSearch.UnsetSession();
            IsScheduleassessment.AdvancedSearch.UnsetSession();
            IsEnrollbyyourself.AdvancedSearch.UnsetSession();
            AssessmentTime.AdvancedSearch.UnsetSession();
            AssessmentDate.AdvancedSearch.UnsetSession();
            isAssessmentDone.AdvancedSearch.UnsetSession();
            AssessmentScore.AdvancedSearch.UnsetSession();
            dt_WrittenTestPassed.AdvancedSearch.UnsetSession();
            dt_RoadTestPassed.AdvancedSearch.UnsetSession();
            bit_Archive.AdvancedSearch.UnsetSession();
            ArchiveNotes.AdvancedSearch.UnsetSession();
            dtArchived.AdvancedSearch.UnsetSession();
            SrNo9Dec21.AdvancedSearch.UnsetSession();
            REGNNUMB.AdvancedSearch.UnsetSession();
            REGNLOCN.AdvancedSearch.UnsetSession();
            SrNo11DecF1S1.AdvancedSearch.UnsetSession();
            IsInterestedInTraining.AdvancedSearch.UnsetSession();
            StudentEncryptID.AdvancedSearch.UnsetSession();
            StudentConfirURL.AdvancedSearch.UnsetSession();
            SrNo15DecF1S2.AdvancedSearch.UnsetSession();
            SrNo15DecF1S3.AdvancedSearch.UnsetSession();
            SrNo16DecF2S2.AdvancedSearch.UnsetSession();
            SrNo16DecF2S3.AdvancedSearch.UnsetSession();
            SrNo16DecF3S1.AdvancedSearch.UnsetSession();
            SrNo16DecF3S2.AdvancedSearch.UnsetSession();
            SrNo16DecF4S1.AdvancedSearch.UnsetSession();
            SrNo16DecF4S2.AdvancedSearch.UnsetSession();
            SrNo16DecF4S3.AdvancedSearch.UnsetSession();
            StudentAssementBookingURL.AdvancedSearch.UnsetSession();
            intDrivinglicenseType.AdvancedSearch.UnsetSession();
            Isdrivinglicense.AdvancedSearch.UnsetSession();
            drivinglicensenumber.AdvancedSearch.UnsetSession();
            Absher_Appointment_number.AdvancedSearch.UnsetSession();
            DataImportId.AdvancedSearch.UnsetSession();
            date_Birth_Hijri.AdvancedSearch.UnsetSession();
            UserlevelID.AdvancedSearch.UnsetSession();
            Activated.AdvancedSearch.UnsetSession();
            Absherphoto.AdvancedSearch.UnsetSession();
            Fingerprint.AdvancedSearch.UnsetSession();
            Required_Program.AdvancedSearch.UnsetSession();
            Price.AdvancedSearch.UnsetSession();
            Hijri_Day.AdvancedSearch.UnsetSession();
            Hijri_Month.AdvancedSearch.UnsetSession();
            Hijri_Year.AdvancedSearch.UnsetSession();
            Course_Price.AdvancedSearch.UnsetSession();
            Vat_Tax_15.AdvancedSearch.UnsetSession();
            dec_Balance.AdvancedSearch.UnsetSession();
            Total_Price.AdvancedSearch.UnsetSession();
            Payment_Online.AdvancedSearch.UnsetSession();
            Institution.AdvancedSearch.UnsetSession();
            WaitingList.AdvancedSearch.UnsetSession();
            Assessment_ID.AdvancedSearch.UnsetSession();
        }

        // Restore all search parameters
        protected void RestoreSearchParms() {
            RestoreSearch = true;

            // Restore basic search values
            BasicSearch.Load();

            // Restore advanced search values
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
                UpdateSort(NationalID, ctrl); // NationalID
                UpdateSort(str_First_Name, ctrl); // str_First_Name
                UpdateSort(str_Last_Name, ctrl); // str_Last_Name
                UpdateSort(str_Cell_Phone, ctrl); // str_Cell_Phone
                UpdateSort(Required_Program, ctrl); // Required_Program
                UpdateSort(Price, ctrl); // Price
                UpdateSort(Payment_Online, ctrl); // Payment_Online
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

                // Reset (clear) sorting order
                if (SameText(Command, "resetsort")) {
                    string orderBy = "";
                    SessionOrderBy = orderBy;
                    int_Potential_Student_ID.Sort = "";
                    int_Student_Id.Sort = "";
                    str_NationalID_Iqama.Sort = "";
                    NationalID.Sort = "";
                    str_First_Name.Sort = "";
                    str_Middle_Name.Sort = "";
                    str_Last_Name.Sort = "";
                    str_Address1.Sort = "";
                    str_Address2.Sort = "";
                    int_State.Sort = "";
                    str_City.Sort = "";
                    str_Zip.Sort = "";
                    int_Instructor.Sort = "";
                    int_Driver.Sort = "";
                    str_Home_Phone.Sort = "";
                    str_Cell_Phone.Sort = "";
                    str_Parent_Phone.Sort = "";
                    str_Other_Phone.Sort = "";
                    str_Email.Sort = "";
                    str_ParentName.Sort = "";
                    str_ParentEmail1.Sort = "";
                    str_ParentEmail2.Sort = "";
                    str_Username.Sort = "";
                    str_Password.Sort = "";
                    str_DOB.Sort = "";
                    int_DOB_Day.Sort = "";
                    int_DOB_Month.Sort = "";
                    int_DOB_Year.Sort = "";
                    int_Age.Sort = "";
                    int_Type.Sort = "";
                    int_Wear_Glasses.Sort = "";
                    int_Sex.Sort = "";
                    str_DLPermit.Sort = "";
                    dt_Date_PermitIssue.Sort = "";
                    dt_Date_ExpirePermit.Sort = "";
                    int_Hs_ID.Sort = "";
                    str_Emergency_Contact_Name.Sort = "";
                    str_Emergency_Contact_Phone.Sort = "";
                    str_Emergency_Contact_Relation.Sort = "";
                    str_Student_Notes.Sort = "";
                    str_Driving_Notes.Sort = "";
                    int_Location_Id.Sort = "";
                    int_Permit_Number.Sort = "";
                    Permit_Issue_Date.Sort = "";
                    Permit_Expiry_Date.Sort = "";
                    int_Status.Sort = "";
                    int_Lead_Id.Sort = "";
                    int_Activated_By.Sort = "";
                    date_Activated.Sort = "";
                    date_Created.Sort = "";
                    date_Modified.Sort = "";
                    date_Complete.Sort = "";
                    int_Created_By.Sort = "";
                    int_Modified_By.Sort = "";
                    bit_IsDeleted.Sort = "";
                    str_CardHolderName.Sort = "";
                    str_CardHolderAddress.Sort = "";
                    str_CardHolderCity.Sort = "";
                    str_CardHolderZip.Sort = "";
                    str_CardType.Sort = "";
                    str_CardExpMonth.Sort = "";
                    str_CardExpYear.Sort = "";
                    str_CardNo.Sort = "";
                    str_Certificate_No.Sort = "";
                    str_AmountPaid.Sort = "";
                    str_PermitValidated.Sort = "";
                    strSMSNotification.Sort = "";
                    strVoiceNotification.Sort = "";
                    str_Weight.Sort = "";
                    str_SpecialNeeds.Sort = "";
                    str_MedicalConditions.Sort = "";
                    bit_Verified_PIC_InSAW.Sort = "";
                    bit_Permit_Waiver_Entered.Sort = "";
                    bit_TermsConditions.Sort = "";
                    bit_Disable_Self_Scheduling.Sort = "";
                    int_EyeColor.Sort = "";
                    int_HairColor.Sort = "";
                    int_ColorBlind.Sort = "";
                    int_HeightFeet.Sort = "";
                    int_HeightInches.Sort = "";
                    str_reference_code.Sort = "";
                    dt_ParentClassAttendedDt.Sort = "";
                    str_ParentClassAttendedLoc.Sort = "";
                    dt_SiblingClassAttendedDt.Sort = "";
                    str_SiblingClassAttendedLoc.Sort = "";
                    bit_PoliciesAndProcedures.Sort = "";
                    dt_CourseCompletionDt.Sort = "";
                    dt_ExtensionDt.Sort = "";
                    str_MedicalCondition.Sort = "";
                    str_MajorCrossStreets.Sort = "";
                    str_DriverEdCertNo.Sort = "";
                    dt_DriverEdCertIssuedDt.Sort = "";
                    str_BTWDriversEdCertNo.Sort = "";
                    dt_BTWCertIssuedDt.Sort = "";
                    str_OLDriversEdCertNo.Sort = "";
                    dt_OLCertIssuedDt.Sort = "";
                    str_height.Sort = "";
                    dt_BTWCompletionDt.Sort = "";
                    dt_CRCompletionDt.Sort = "";
                    strTextBox5.Sort = "";
                    strTextBox6.Sort = "";
                    str_ApartmentNo.Sort = "";
                    dt_PermitTestDate.Sort = "";
                    str_OnlineDriverEdLogin.Sort = "";
                    str_OnlineDriverEdPassword.Sort = "";
                    bit_IsSMSEnabled.Sort = "";
                    dt_SMSModified.Sort = "";
                    str_confirmPassword.Sort = "";
                    DE_Certificate.Sort = "";
                    Discuss.Sort = "";
                    int_UnlicensedSibling.Sort = "";
                    int_YearSiblingIsEligible.Sort = "";
                    BTW_Certificate.Sort = "";
                    dt_DECertIssueDate.Sort = "";
                    str_StudentSignature.Sort = "";
                    str_ParentSignature.Sort = "";
                    str_Last6DigitsOfParentDriversLicense.Sort = "";
                    str_FACControl.Sort = "";
                    Classroom_Status_Code.Sort = "";
                    Laboratory_Status_Code.Sort = "";
                    bit_EnrollmentForm.Sort = "";
                    bit_ParentStudentContract.Sort = "";
                    bit_ParentalAgreement.Sort = "";
                    int_SF_GR_WA_HS.Sort = "";
                    bit_DisableOnRMV.Sort = "";
                    bit_UploadedToRMV.Sort = "";
                    str_Mother_Name.Sort = "";
                    str_Guardians_Name.Sort = "";
                    str_Mother_Phone.Sort = "";
                    bit_terms.Sort = "";
                    int_Nationality.Sort = "";
                    str_National_ID_en.Sort = "";
                    str_National_ID_arabic.Sort = "";
                    Quallification_Id.Sort = "";
                    Job_Id.Sort = "";
                    str_DOB_arabic.Sort = "";
                    int_Language.Sort = "";
                    strRefId.Sort = "";
                    int_Program_Id.Sort = "";
                    IsDrivingexperience.Sort = "";
                    IsScheduleassessment.Sort = "";
                    IsEnrollbyyourself.Sort = "";
                    AssessmentTime.Sort = "";
                    AssessmentDate.Sort = "";
                    isAssessmentDone.Sort = "";
                    AssessmentScore.Sort = "";
                    dt_WrittenTestPassed.Sort = "";
                    dt_RoadTestPassed.Sort = "";
                    bit_Archive.Sort = "";
                    ArchiveNotes.Sort = "";
                    dtArchived.Sort = "";
                    SrNo9Dec21.Sort = "";
                    REGNNUMB.Sort = "";
                    REGNLOCN.Sort = "";
                    SrNo11DecF1S1.Sort = "";
                    IsInterestedInTraining.Sort = "";
                    StudentEncryptID.Sort = "";
                    StudentConfirURL.Sort = "";
                    SrNo15DecF1S2.Sort = "";
                    SrNo15DecF1S3.Sort = "";
                    SrNo16DecF2S2.Sort = "";
                    SrNo16DecF2S3.Sort = "";
                    SrNo16DecF3S1.Sort = "";
                    SrNo16DecF3S2.Sort = "";
                    SrNo16DecF4S1.Sort = "";
                    SrNo16DecF4S2.Sort = "";
                    SrNo16DecF4S3.Sort = "";
                    StudentAssementBookingURL.Sort = "";
                    intDrivinglicenseType.Sort = "";
                    Isdrivinglicense.Sort = "";
                    drivinglicensenumber.Sort = "";
                    Absher_Appointment_number.Sort = "";
                    DataImportId.Sort = "";
                    date_Birth_Hijri.Sort = "";
                    UserlevelID.Sort = "";
                    Activated.Sort = "";
                    Absherphoto.Sort = "";
                    Fingerprint.Sort = "";
                    Required_Program.Sort = "";
                    Price.Sort = "";
                    Hijri_Day.Sort = "";
                    Hijri_Month.Sort = "";
                    Hijri_Year.Sort = "";
                    Course_Price.Sort = "";
                    Vat_Tax_15.Sort = "";
                    dec_Balance.Sort = "";
                    Total_Price.Sort = "";
                    Payment_Online.Sort = "";
                    Institution.Sort = "";
                    WaitingList.Sort = "";
                    Assessment_ID.Sort = "";
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

            // "edit"
            item = ListOptions.Add("edit");
            item.CssClass = "text-nowrap";
            item.Visible = Security.CanEdit;
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;

            // "detail_tblBillingInfo"
            item = ListOptions.Add("detail_tblBillingInfo");
            item.CssClass = "text-nowrap";
            item.Visible = Security.AllowList(CurrentProjectID + "tblBillingInfo");
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;
            item.ShowInButtonGroup = false;
            tblBillingInfoGrid = Resolve("TblBillingInfoGrid")!;

            // Multiple details
            if (ShowMultipleDetails) {
                item = ListOptions.Add("details");
                item.CssClass = "text-nowrap";
                item.Visible = ShowMultipleDetails && ListOptions.DetailVisible();
                item.OnLeft = MultiColumnLayout == "cards" ? false : true;
                item.ShowInButtonGroup = false;
            }

            // Set up detail pages
            var _pages = new SubPages();
            _pages.Add("tblBillingInfo");
            DetailPages = _pages;

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

            // "edit"
            listOption = ListOptions["edit"];
            string editcaption = Language.Phrase("EditLink", true);
            isVisible = Security.CanEdit && ShowOptionLink("edit");
            if (isVisible) {
                if (ModalEdit && !IsMobile())
                    listOption?.SetBody($@"<a class=""ew-row-link ew-edit"" title=""{editcaption}"" data-table=""tblPotentialStudentInfo"" data-caption=""{editcaption}"" data-ew-action=""modal"" data-action=""edit"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(EditUrl)) + "\" data-btn=\"SaveBtn\">" + Language.Phrase("EditLink") + "</a>");
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
                        string link = "<li><button type=\"button\" class=\"dropdown-item ew-action ew-list-action\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblPotentialStudentInfolist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + " " + caption + "</button></li>";
                        if (!Empty(link)) {
                            links.Add(link);
                            if (Empty(body)) // Setup first button
                                body = "<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlTitle(caption) + "\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblPotentialStudentInfolist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + caption + "</button>";
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
            var detailViewTblVar = "";
            var detailCopyTblVar = "";
            var detailEditTblVar = "";
            dynamic? detailPage = null;
            string detailFilter = "";

            // "detail_tblBillingInfo"
            listOption = ListOptions["detail_tblBillingInfo"];
            isVisible = Security.AllowList(CurrentProjectID + "tblBillingInfo") && ShowOptionLink();
            if (isVisible) {
                string caption, title, url;
                var body = Language.Phrase("DetailLink") + Language.TablePhrase("tblBillingInfo", "TblCaption");
                body = "<a class=\"btn btn-default ew-row-link ew-detail" + (ListOptions.UseDropDownButton ? " dropdown-toggle" : "") + "\" data-action=\"list\" href=\"" + HtmlEncode(AppPath("TblBillingInfoList?" + Config.TableShowMaster + "=tblPotentialStudentInfo&" + ForeignKeyUrl("fk_NationalID", NationalID.CurrentValue) + "")) + "\">" + body + "</a>";
                string links = "";
                detailPage = Resolve("TblBillingInfoGrid")!;
                if (detailPage?.DetailEdit && Security.CanEdit && ShowOptionLink("edit") && Security.AllowEdit(CurrentProjectID + "tblPotentialStudentInfo") ?? false) {
                    caption = Language.Phrase("MasterDetailEditLink", null);
                    title = Language.Phrase("MasterDetailEditLink", true);
                    url = GetEditUrl(Config.TableShowDetail + "=tblBillingInfo");
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-edit\" data-action=\"edit\" data-caption=\"" + title + "\" href=\"" + HtmlEncode(AppPath(url)) + "\">" + caption + "</a></li>";
                    if (!Empty(detailEditTblVar))
                        detailEditTblVar += ",";
                    detailEditTblVar += "tblBillingInfo";
                }
                if (!Empty(links)) {
                    body += "<button type=\"button\" class=\"dropdown-toggle btn btn-default ew-detail\" data-bs-toggle=\"dropdown\"></button>";
                    body += "<ul class=\"dropdown-menu\">" + links + "</ul>";
                } else {
                    body = Regex.Replace(body, @"\b\s+dropdown-toggle\b", "");
                }
                body = "<div class=\"btn-group btn-group-sm ew-btn-group\">" + body + "</div>";
                listOption?.SetBody(body);
                if (ShowMultipleDetails)
                    listOption?.SetVisible(false);
            }
            if (ShowMultipleDetails) {
                var body = Language.Phrase("MultipleMasterDetails");
                body = "<div class=\"btn-group btn-group-sm ew-btn-group\">";
                string links = "";
                if (!Empty(detailViewTblVar)) {
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-view\" data-action=\"view\" data-caption=\"" + HtmlEncode(Language.Phrase("MasterDetailViewLink", true)) + "\" href=\"" + HtmlEncode(AppPath(GetViewUrl(Config.TableShowDetail + "=" + detailViewTblVar))) + "\">" + Language.Phrase("MasterDetailViewLink", null) + "</a></li>";
                }
                if (!Empty(detailEditTblVar)) {
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-edit\" data-action=\"edit\" data-caption=\"" + HtmlEncode(Language.Phrase("MasterDetailEditLink", true)) + "\" href=\"" + HtmlEncode(AppPath(GetEditUrl(Config.TableShowDetail + "=" + detailEditTblVar))) + "\">" + Language.Phrase("MasterDetailEditLink", null) + "</a></li>";
                }
                if (!Empty(detailCopyTblVar)) {
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-copy\" data-action=\"add\" data-caption=\"" + HtmlEncode(Language.Phrase("MasterDetailCopyLink", true)) + "\" href=\"" + HtmlEncode(AppPath(GetCopyUrl(Config.TableShowDetail + "=" + detailCopyTblVar))) + "\">" + Language.Phrase("MasterDetailCopyLink", null) + "</a></li>";
                }
                if (!Empty(links)) {
                    body += "<button type=\"button\" class=\"dropdown-toggle btn btn-default ew-master-detail\" title=\"" + HtmlEncode(Language.Phrase("MultipleMasterDetails", true)) + "\" data-bs-toggle=\"dropdown\">" + Language.Phrase("MultipleMasterDetails") + "</button>";
                    body += "<ul class=\"dropdown-menu ew-dropdown-menu\">" + links + "</ul>";
                }
                body += "</div>";
                // Multiple details
                listOption = ListOptions["details"];
                listOption?.SetBody(body);
            }

            // "checkbox"
            listOption = ListOptions["checkbox"];
            listOption?.SetBody("<div class=\"form-check\"><input type=\"checkbox\" id=\"key_m_" + RowCount + "\" name=\"key_m[]\" class=\"form-check-input ew-multi-select\" value=\"" + HtmlEncode(int_Potential_Student_ID.CurrentValue) + "\"></div>");
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
            sqlwrk = KeyFilter(Resolve("tblBillingInfo")!.NationalID, NationalID.CurrentValue, NationalID.DataType, DbId);
            masterKeys.Add(ConvertToString(NationalID.CurrentValue));

            // Column "detail_tblBillingInfo"
            if ((DetailPages?["tblBillingInfo"]?.Visible ?? false) && Security.AllowList(CurrentProjectID + "tblBillingInfo")) {
                link = "";
                option = ListOptions["detail_tblBillingInfo"];
                url = "TblBillingInfoPreview?t=tblPotentialStudentInfo&f=" + Encrypt(sqlwrk + "|" + String.Join("|", masterKeys));
                btngrp = "<div data-table=\"tblBillingInfo\" data-url=\"" + AppPath(url) + "\" class=\"ew-detail-btn-group d-none\">";
                if (Security.AllowList(CurrentProjectID + "tblPotentialStudentInfo")) {
                    string label = Language.TablePhrase("tblBillingInfo", "TblCaption");
                    link = "<button class=\"nav-link\" data-bs-toggle=\"tab\" data-table=\"tblBillingInfo\" data-url=\"" + AppPath(url) + "\" type=\"button\" role=\"tab\" aria-selected=\"false\">" + label + "</button>";
                    detaillnk = AppPath("TblBillingInfoList?" + Config.TableShowMaster + "=tblPotentialStudentInfo&" + ForeignKeyUrl("fk_NationalID", NationalID.CurrentValue) + "");
                    title = Language.TablePhrase("tblBillingInfo", "TblCaption");
                    caption = Language.Phrase("MasterDetailListLink");
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(detaillnk) + "\">" + caption + "</a>";
                }
                detailPage = Resolve("TblBillingInfoGrid")!;
                if (detailPage?.DetailView && Security.CanView && ShowOptionLink("view") && Security.AllowView(CurrentProjectID + "tblPotentialStudentInfo") ?? false) {
                    caption = Language.Phrase("MasterDetailViewLink");
                    title = Language.Phrase("MasterDetailViewLink", true);
                    url = AppPath(GetViewUrl(Config.TableShowDetail + "=tblBillingInfo"));
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(url) + "\">" + caption + "</a>";
                }
                if (detailPage?.DetailEdit && Security.CanEdit && ShowOptionLink("edit") && Security.AllowEdit(CurrentProjectID + "tblPotentialStudentInfo") ?? false) {
                    caption = Language.Phrase("MasterDetailEditLink");
                    title = Language.Phrase("MasterDetailEditLink", true);
                    url = AppPath(GetEditUrl(Config.TableShowDetail + "=tblBillingInfo"));
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
                option.OnLeft = MultiColumnLayout == "cards" ? false : true;
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
            item.Body = "<div class=\"btn-group\"><div class=\"form-check\"><input type=\"checkbox\" name=\"key\" id=\"key\" class=\"form-check-input\" data-ew-action=\"select-all-keys\" form=\"ftblPotentialStudentInfolist\"><label class=\"form-check-label\" for=\"key\">" + Language.Phrase("SelectAll") + "</label></div></div>";
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
            item.Body = "<a class=\"ew-save-filter\" data-form=\"ftblPotentialStudentInfosrch\" data-ew-action=\"none\">" + Language.Phrase("SaveCurrentFilter") + "</a>";
            item.Visible = true;
            item = FilterOptions.Add("deletefilter");
            item.Body = "<a class=\"ew-delete-filter\" data-form=\"ftblPotentialStudentInfosrch\" data-ew-action=\"none\">" + Language.Phrase("DeleteFilter") + "</a>";
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
                    item.Body = "<<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlEncode(caption) + "\" data-caption=\"" + HtmlEncode(caption) + "\" data-ew-action=\"submit\" form=\"ftblPotentialStudentInfolist\"" + act.ToDataAttrs() + ">" + icon + "</button>";
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
                    RowAttrs.Add("id", "r0_tblPotentialStudentInfo");
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
            RowAttrs.Add("data-rowindex", ConvertToString(tblPotentialStudentInfoList.RowCount));
            RowAttrs.Add("data-key", GetKey(true));
            RowAttrs.Add("id", "r" + ConvertToString(tblPotentialStudentInfoList.RowCount) + "_tblPotentialStudentInfo");
            RowAttrs.Add("data-rowtype", ConvertToString((int)RowType));
            RowAttrs.AppendClass(tblPotentialStudentInfoList.RowCount % 2 != 1 ? "ew-table-alt-row" : "");
            if (IsAdd && tblPotentialStudentInfoList.RowType == RowType.Add || IsEdit && tblPotentialStudentInfoList.RowType == RowType.Edit) // Inline-Add/Edit row
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

            // int_Potential_Student_ID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Potential_Student_ID"))
                    int_Potential_Student_ID.AdvancedSearch.SearchValue = Get("x_int_Potential_Student_ID");
                else
                    int_Potential_Student_ID.AdvancedSearch.SearchValue = Get("int_Potential_Student_ID"); // Default Value // DN
            if (!Empty(int_Potential_Student_ID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Potential_Student_ID"))
                int_Potential_Student_ID.AdvancedSearch.SearchOperator = Get("z_int_Potential_Student_ID");

            // int_Student_Id
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Student_Id"))
                    int_Student_Id.AdvancedSearch.SearchValue = Get("x_int_Student_Id");
                else
                    int_Student_Id.AdvancedSearch.SearchValue = Get("int_Student_Id"); // Default Value // DN
            if (!Empty(int_Student_Id.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Student_Id"))
                int_Student_Id.AdvancedSearch.SearchOperator = Get("z_int_Student_Id");

            // str_NationalID_Iqama
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_NationalID_Iqama"))
                    str_NationalID_Iqama.AdvancedSearch.SearchValue = Get("x_str_NationalID_Iqama");
                else
                    str_NationalID_Iqama.AdvancedSearch.SearchValue = Get("str_NationalID_Iqama"); // Default Value // DN
            if (!Empty(str_NationalID_Iqama.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_NationalID_Iqama"))
                str_NationalID_Iqama.AdvancedSearch.SearchOperator = Get("z_str_NationalID_Iqama");

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

            // str_First_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_First_Name"))
                    str_First_Name.AdvancedSearch.SearchValue = Get("x_str_First_Name");
                else
                    str_First_Name.AdvancedSearch.SearchValue = Get("str_First_Name"); // Default Value // DN
            if (!Empty(str_First_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_First_Name"))
                str_First_Name.AdvancedSearch.SearchOperator = Get("z_str_First_Name");

            // str_Middle_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Middle_Name"))
                    str_Middle_Name.AdvancedSearch.SearchValue = Get("x_str_Middle_Name");
                else
                    str_Middle_Name.AdvancedSearch.SearchValue = Get("str_Middle_Name"); // Default Value // DN
            if (!Empty(str_Middle_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Middle_Name"))
                str_Middle_Name.AdvancedSearch.SearchOperator = Get("z_str_Middle_Name");

            // str_Last_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Last_Name"))
                    str_Last_Name.AdvancedSearch.SearchValue = Get("x_str_Last_Name");
                else
                    str_Last_Name.AdvancedSearch.SearchValue = Get("str_Last_Name"); // Default Value // DN
            if (!Empty(str_Last_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Last_Name"))
                str_Last_Name.AdvancedSearch.SearchOperator = Get("z_str_Last_Name");

            // str_Address1
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Address1"))
                    str_Address1.AdvancedSearch.SearchValue = Get("x_str_Address1");
                else
                    str_Address1.AdvancedSearch.SearchValue = Get("str_Address1"); // Default Value // DN
            if (!Empty(str_Address1.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Address1"))
                str_Address1.AdvancedSearch.SearchOperator = Get("z_str_Address1");

            // str_Address2
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Address2"))
                    str_Address2.AdvancedSearch.SearchValue = Get("x_str_Address2");
                else
                    str_Address2.AdvancedSearch.SearchValue = Get("str_Address2"); // Default Value // DN
            if (!Empty(str_Address2.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Address2"))
                str_Address2.AdvancedSearch.SearchOperator = Get("z_str_Address2");

            // int_State
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_State"))
                    int_State.AdvancedSearch.SearchValue = Get("x_int_State");
                else
                    int_State.AdvancedSearch.SearchValue = Get("int_State"); // Default Value // DN
            if (!Empty(int_State.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_State"))
                int_State.AdvancedSearch.SearchOperator = Get("z_int_State");

            // str_City
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_City"))
                    str_City.AdvancedSearch.SearchValue = Get("x_str_City");
                else
                    str_City.AdvancedSearch.SearchValue = Get("str_City"); // Default Value // DN
            if (!Empty(str_City.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_City"))
                str_City.AdvancedSearch.SearchOperator = Get("z_str_City");

            // str_Zip
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Zip"))
                    str_Zip.AdvancedSearch.SearchValue = Get("x_str_Zip");
                else
                    str_Zip.AdvancedSearch.SearchValue = Get("str_Zip"); // Default Value // DN
            if (!Empty(str_Zip.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Zip"))
                str_Zip.AdvancedSearch.SearchOperator = Get("z_str_Zip");

            // int_Instructor
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Instructor"))
                    int_Instructor.AdvancedSearch.SearchValue = Get("x_int_Instructor");
                else
                    int_Instructor.AdvancedSearch.SearchValue = Get("int_Instructor"); // Default Value // DN
            if (!Empty(int_Instructor.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Instructor"))
                int_Instructor.AdvancedSearch.SearchOperator = Get("z_int_Instructor");

            // int_Driver
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Driver"))
                    int_Driver.AdvancedSearch.SearchValue = Get("x_int_Driver");
                else
                    int_Driver.AdvancedSearch.SearchValue = Get("int_Driver"); // Default Value // DN
            if (!Empty(int_Driver.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Driver"))
                int_Driver.AdvancedSearch.SearchOperator = Get("z_int_Driver");

            // str_Home_Phone
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Home_Phone"))
                    str_Home_Phone.AdvancedSearch.SearchValue = Get("x_str_Home_Phone");
                else
                    str_Home_Phone.AdvancedSearch.SearchValue = Get("str_Home_Phone"); // Default Value // DN
            if (!Empty(str_Home_Phone.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Home_Phone"))
                str_Home_Phone.AdvancedSearch.SearchOperator = Get("z_str_Home_Phone");

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

            // str_Parent_Phone
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Parent_Phone"))
                    str_Parent_Phone.AdvancedSearch.SearchValue = Get("x_str_Parent_Phone");
                else
                    str_Parent_Phone.AdvancedSearch.SearchValue = Get("str_Parent_Phone"); // Default Value // DN
            if (!Empty(str_Parent_Phone.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Parent_Phone"))
                str_Parent_Phone.AdvancedSearch.SearchOperator = Get("z_str_Parent_Phone");

            // str_Other_Phone
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Other_Phone"))
                    str_Other_Phone.AdvancedSearch.SearchValue = Get("x_str_Other_Phone");
                else
                    str_Other_Phone.AdvancedSearch.SearchValue = Get("str_Other_Phone"); // Default Value // DN
            if (!Empty(str_Other_Phone.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Other_Phone"))
                str_Other_Phone.AdvancedSearch.SearchOperator = Get("z_str_Other_Phone");

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

            // str_ParentName
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_ParentName"))
                    str_ParentName.AdvancedSearch.SearchValue = Get("x_str_ParentName");
                else
                    str_ParentName.AdvancedSearch.SearchValue = Get("str_ParentName"); // Default Value // DN
            if (!Empty(str_ParentName.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_ParentName"))
                str_ParentName.AdvancedSearch.SearchOperator = Get("z_str_ParentName");

            // str_ParentEmail1
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_ParentEmail1"))
                    str_ParentEmail1.AdvancedSearch.SearchValue = Get("x_str_ParentEmail1");
                else
                    str_ParentEmail1.AdvancedSearch.SearchValue = Get("str_ParentEmail1"); // Default Value // DN
            if (!Empty(str_ParentEmail1.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_ParentEmail1"))
                str_ParentEmail1.AdvancedSearch.SearchOperator = Get("z_str_ParentEmail1");

            // str_ParentEmail2
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_ParentEmail2"))
                    str_ParentEmail2.AdvancedSearch.SearchValue = Get("x_str_ParentEmail2");
                else
                    str_ParentEmail2.AdvancedSearch.SearchValue = Get("str_ParentEmail2"); // Default Value // DN
            if (!Empty(str_ParentEmail2.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_ParentEmail2"))
                str_ParentEmail2.AdvancedSearch.SearchOperator = Get("z_str_ParentEmail2");

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

            // str_Password
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Password"))
                    str_Password.AdvancedSearch.SearchValue = Get("x_str_Password");
                else
                    str_Password.AdvancedSearch.SearchValue = Get("str_Password"); // Default Value // DN
            if (!Empty(str_Password.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Password"))
                str_Password.AdvancedSearch.SearchOperator = Get("z_str_Password");

            // str_DOB
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_DOB"))
                    str_DOB.AdvancedSearch.SearchValue = Get("x_str_DOB");
                else
                    str_DOB.AdvancedSearch.SearchValue = Get("str_DOB"); // Default Value // DN
            if (!Empty(str_DOB.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_DOB"))
                str_DOB.AdvancedSearch.SearchOperator = Get("z_str_DOB");

            // int_DOB_Day
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_DOB_Day"))
                    int_DOB_Day.AdvancedSearch.SearchValue = Get("x_int_DOB_Day");
                else
                    int_DOB_Day.AdvancedSearch.SearchValue = Get("int_DOB_Day"); // Default Value // DN
            if (!Empty(int_DOB_Day.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_DOB_Day"))
                int_DOB_Day.AdvancedSearch.SearchOperator = Get("z_int_DOB_Day");

            // int_DOB_Month
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_DOB_Month"))
                    int_DOB_Month.AdvancedSearch.SearchValue = Get("x_int_DOB_Month");
                else
                    int_DOB_Month.AdvancedSearch.SearchValue = Get("int_DOB_Month"); // Default Value // DN
            if (!Empty(int_DOB_Month.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_DOB_Month"))
                int_DOB_Month.AdvancedSearch.SearchOperator = Get("z_int_DOB_Month");

            // int_DOB_Year
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_DOB_Year"))
                    int_DOB_Year.AdvancedSearch.SearchValue = Get("x_int_DOB_Year");
                else
                    int_DOB_Year.AdvancedSearch.SearchValue = Get("int_DOB_Year"); // Default Value // DN
            if (!Empty(int_DOB_Year.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_DOB_Year"))
                int_DOB_Year.AdvancedSearch.SearchOperator = Get("z_int_DOB_Year");

            // int_Age
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Age"))
                    int_Age.AdvancedSearch.SearchValue = Get("x_int_Age");
                else
                    int_Age.AdvancedSearch.SearchValue = Get("int_Age"); // Default Value // DN
            if (!Empty(int_Age.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Age"))
                int_Age.AdvancedSearch.SearchOperator = Get("z_int_Age");

            // int_Type
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Type"))
                    int_Type.AdvancedSearch.SearchValue = Get("x_int_Type");
                else
                    int_Type.AdvancedSearch.SearchValue = Get("int_Type"); // Default Value // DN
            if (!Empty(int_Type.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Type"))
                int_Type.AdvancedSearch.SearchOperator = Get("z_int_Type");

            // int_Wear_Glasses
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Wear_Glasses"))
                    int_Wear_Glasses.AdvancedSearch.SearchValue = Get("x_int_Wear_Glasses");
                else
                    int_Wear_Glasses.AdvancedSearch.SearchValue = Get("int_Wear_Glasses"); // Default Value // DN
            if (!Empty(int_Wear_Glasses.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Wear_Glasses"))
                int_Wear_Glasses.AdvancedSearch.SearchOperator = Get("z_int_Wear_Glasses");

            // int_Sex
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Sex"))
                    int_Sex.AdvancedSearch.SearchValue = Get("x_int_Sex");
                else
                    int_Sex.AdvancedSearch.SearchValue = Get("int_Sex"); // Default Value // DN
            if (!Empty(int_Sex.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Sex"))
                int_Sex.AdvancedSearch.SearchOperator = Get("z_int_Sex");

            // str_DLPermit
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_DLPermit"))
                    str_DLPermit.AdvancedSearch.SearchValue = Get("x_str_DLPermit");
                else
                    str_DLPermit.AdvancedSearch.SearchValue = Get("str_DLPermit"); // Default Value // DN
            if (!Empty(str_DLPermit.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_DLPermit"))
                str_DLPermit.AdvancedSearch.SearchOperator = Get("z_str_DLPermit");

            // dt_Date_PermitIssue
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_Date_PermitIssue"))
                    dt_Date_PermitIssue.AdvancedSearch.SearchValue = Get("x_dt_Date_PermitIssue");
                else
                    dt_Date_PermitIssue.AdvancedSearch.SearchValue = Get("dt_Date_PermitIssue"); // Default Value // DN
            if (!Empty(dt_Date_PermitIssue.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_Date_PermitIssue"))
                dt_Date_PermitIssue.AdvancedSearch.SearchOperator = Get("z_dt_Date_PermitIssue");

            // dt_Date_ExpirePermit
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_Date_ExpirePermit"))
                    dt_Date_ExpirePermit.AdvancedSearch.SearchValue = Get("x_dt_Date_ExpirePermit");
                else
                    dt_Date_ExpirePermit.AdvancedSearch.SearchValue = Get("dt_Date_ExpirePermit"); // Default Value // DN
            if (!Empty(dt_Date_ExpirePermit.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_Date_ExpirePermit"))
                dt_Date_ExpirePermit.AdvancedSearch.SearchOperator = Get("z_dt_Date_ExpirePermit");

            // int_Hs_ID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Hs_ID"))
                    int_Hs_ID.AdvancedSearch.SearchValue = Get("x_int_Hs_ID");
                else
                    int_Hs_ID.AdvancedSearch.SearchValue = Get("int_Hs_ID"); // Default Value // DN
            if (!Empty(int_Hs_ID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Hs_ID"))
                int_Hs_ID.AdvancedSearch.SearchOperator = Get("z_int_Hs_ID");

            // str_Emergency_Contact_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Emergency_Contact_Name"))
                    str_Emergency_Contact_Name.AdvancedSearch.SearchValue = Get("x_str_Emergency_Contact_Name");
                else
                    str_Emergency_Contact_Name.AdvancedSearch.SearchValue = Get("str_Emergency_Contact_Name"); // Default Value // DN
            if (!Empty(str_Emergency_Contact_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Emergency_Contact_Name"))
                str_Emergency_Contact_Name.AdvancedSearch.SearchOperator = Get("z_str_Emergency_Contact_Name");

            // str_Emergency_Contact_Phone
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Emergency_Contact_Phone"))
                    str_Emergency_Contact_Phone.AdvancedSearch.SearchValue = Get("x_str_Emergency_Contact_Phone");
                else
                    str_Emergency_Contact_Phone.AdvancedSearch.SearchValue = Get("str_Emergency_Contact_Phone"); // Default Value // DN
            if (!Empty(str_Emergency_Contact_Phone.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Emergency_Contact_Phone"))
                str_Emergency_Contact_Phone.AdvancedSearch.SearchOperator = Get("z_str_Emergency_Contact_Phone");

            // str_Emergency_Contact_Relation
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Emergency_Contact_Relation"))
                    str_Emergency_Contact_Relation.AdvancedSearch.SearchValue = Get("x_str_Emergency_Contact_Relation");
                else
                    str_Emergency_Contact_Relation.AdvancedSearch.SearchValue = Get("str_Emergency_Contact_Relation"); // Default Value // DN
            if (!Empty(str_Emergency_Contact_Relation.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Emergency_Contact_Relation"))
                str_Emergency_Contact_Relation.AdvancedSearch.SearchOperator = Get("z_str_Emergency_Contact_Relation");

            // str_Student_Notes
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Student_Notes"))
                    str_Student_Notes.AdvancedSearch.SearchValue = Get("x_str_Student_Notes");
                else
                    str_Student_Notes.AdvancedSearch.SearchValue = Get("str_Student_Notes"); // Default Value // DN
            if (!Empty(str_Student_Notes.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Student_Notes"))
                str_Student_Notes.AdvancedSearch.SearchOperator = Get("z_str_Student_Notes");

            // str_Driving_Notes
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Driving_Notes"))
                    str_Driving_Notes.AdvancedSearch.SearchValue = Get("x_str_Driving_Notes");
                else
                    str_Driving_Notes.AdvancedSearch.SearchValue = Get("str_Driving_Notes"); // Default Value // DN
            if (!Empty(str_Driving_Notes.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Driving_Notes"))
                str_Driving_Notes.AdvancedSearch.SearchOperator = Get("z_str_Driving_Notes");

            // int_Location_Id
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Location_Id"))
                    int_Location_Id.AdvancedSearch.SearchValue = Get("x_int_Location_Id");
                else
                    int_Location_Id.AdvancedSearch.SearchValue = Get("int_Location_Id"); // Default Value // DN
            if (!Empty(int_Location_Id.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Location_Id"))
                int_Location_Id.AdvancedSearch.SearchOperator = Get("z_int_Location_Id");

            // int_Permit_Number
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Permit_Number"))
                    int_Permit_Number.AdvancedSearch.SearchValue = Get("x_int_Permit_Number");
                else
                    int_Permit_Number.AdvancedSearch.SearchValue = Get("int_Permit_Number"); // Default Value // DN
            if (!Empty(int_Permit_Number.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Permit_Number"))
                int_Permit_Number.AdvancedSearch.SearchOperator = Get("z_int_Permit_Number");

            // Permit_Issue_Date
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Permit_Issue_Date"))
                    Permit_Issue_Date.AdvancedSearch.SearchValue = Get("x_Permit_Issue_Date");
                else
                    Permit_Issue_Date.AdvancedSearch.SearchValue = Get("Permit_Issue_Date"); // Default Value // DN
            if (!Empty(Permit_Issue_Date.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Permit_Issue_Date"))
                Permit_Issue_Date.AdvancedSearch.SearchOperator = Get("z_Permit_Issue_Date");

            // Permit_Expiry_Date
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Permit_Expiry_Date"))
                    Permit_Expiry_Date.AdvancedSearch.SearchValue = Get("x_Permit_Expiry_Date");
                else
                    Permit_Expiry_Date.AdvancedSearch.SearchValue = Get("Permit_Expiry_Date"); // Default Value // DN
            if (!Empty(Permit_Expiry_Date.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Permit_Expiry_Date"))
                Permit_Expiry_Date.AdvancedSearch.SearchOperator = Get("z_Permit_Expiry_Date");

            // int_Status
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Status"))
                    int_Status.AdvancedSearch.SearchValue = Get("x_int_Status");
                else
                    int_Status.AdvancedSearch.SearchValue = Get("int_Status"); // Default Value // DN
            if (!Empty(int_Status.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Status"))
                int_Status.AdvancedSearch.SearchOperator = Get("z_int_Status");

            // int_Lead_Id
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Lead_Id"))
                    int_Lead_Id.AdvancedSearch.SearchValue = Get("x_int_Lead_Id");
                else
                    int_Lead_Id.AdvancedSearch.SearchValue = Get("int_Lead_Id"); // Default Value // DN
            if (!Empty(int_Lead_Id.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Lead_Id"))
                int_Lead_Id.AdvancedSearch.SearchOperator = Get("z_int_Lead_Id");

            // int_Activated_By
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Activated_By"))
                    int_Activated_By.AdvancedSearch.SearchValue = Get("x_int_Activated_By");
                else
                    int_Activated_By.AdvancedSearch.SearchValue = Get("int_Activated_By"); // Default Value // DN
            if (!Empty(int_Activated_By.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Activated_By"))
                int_Activated_By.AdvancedSearch.SearchOperator = Get("z_int_Activated_By");

            // date_Activated
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_Activated"))
                    date_Activated.AdvancedSearch.SearchValue = Get("x_date_Activated");
                else
                    date_Activated.AdvancedSearch.SearchValue = Get("date_Activated"); // Default Value // DN
            if (!Empty(date_Activated.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_Activated"))
                date_Activated.AdvancedSearch.SearchOperator = Get("z_date_Activated");

            // date_Created
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_Created"))
                    date_Created.AdvancedSearch.SearchValue = Get("x_date_Created");
                else
                    date_Created.AdvancedSearch.SearchValue = Get("date_Created"); // Default Value // DN
            if (!Empty(date_Created.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_Created"))
                date_Created.AdvancedSearch.SearchOperator = Get("z_date_Created");

            // date_Modified
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_Modified"))
                    date_Modified.AdvancedSearch.SearchValue = Get("x_date_Modified");
                else
                    date_Modified.AdvancedSearch.SearchValue = Get("date_Modified"); // Default Value // DN
            if (!Empty(date_Modified.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_Modified"))
                date_Modified.AdvancedSearch.SearchOperator = Get("z_date_Modified");

            // date_Complete
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_Complete"))
                    date_Complete.AdvancedSearch.SearchValue = Get("x_date_Complete");
                else
                    date_Complete.AdvancedSearch.SearchValue = Get("date_Complete"); // Default Value // DN
            if (!Empty(date_Complete.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_Complete"))
                date_Complete.AdvancedSearch.SearchOperator = Get("z_date_Complete");

            // int_Created_By
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Created_By"))
                    int_Created_By.AdvancedSearch.SearchValue = Get("x_int_Created_By");
                else
                    int_Created_By.AdvancedSearch.SearchValue = Get("int_Created_By"); // Default Value // DN
            if (!Empty(int_Created_By.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Created_By"))
                int_Created_By.AdvancedSearch.SearchOperator = Get("z_int_Created_By");

            // int_Modified_By
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Modified_By"))
                    int_Modified_By.AdvancedSearch.SearchValue = Get("x_int_Modified_By");
                else
                    int_Modified_By.AdvancedSearch.SearchValue = Get("int_Modified_By"); // Default Value // DN
            if (!Empty(int_Modified_By.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Modified_By"))
                int_Modified_By.AdvancedSearch.SearchOperator = Get("z_int_Modified_By");

            // bit_IsDeleted
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_IsDeleted"))
                    bit_IsDeleted.AdvancedSearch.SearchValue = Get("x_bit_IsDeleted");
                else
                    bit_IsDeleted.AdvancedSearch.SearchValue = Get("bit_IsDeleted"); // Default Value // DN
            if (!Empty(bit_IsDeleted.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_IsDeleted"))
                bit_IsDeleted.AdvancedSearch.SearchOperator = Get("z_bit_IsDeleted");

            // str_CardHolderName
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_CardHolderName"))
                    str_CardHolderName.AdvancedSearch.SearchValue = Get("x_str_CardHolderName");
                else
                    str_CardHolderName.AdvancedSearch.SearchValue = Get("str_CardHolderName"); // Default Value // DN
            if (!Empty(str_CardHolderName.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_CardHolderName"))
                str_CardHolderName.AdvancedSearch.SearchOperator = Get("z_str_CardHolderName");

            // str_CardHolderAddress
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_CardHolderAddress"))
                    str_CardHolderAddress.AdvancedSearch.SearchValue = Get("x_str_CardHolderAddress");
                else
                    str_CardHolderAddress.AdvancedSearch.SearchValue = Get("str_CardHolderAddress"); // Default Value // DN
            if (!Empty(str_CardHolderAddress.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_CardHolderAddress"))
                str_CardHolderAddress.AdvancedSearch.SearchOperator = Get("z_str_CardHolderAddress");

            // str_CardHolderCity
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_CardHolderCity"))
                    str_CardHolderCity.AdvancedSearch.SearchValue = Get("x_str_CardHolderCity");
                else
                    str_CardHolderCity.AdvancedSearch.SearchValue = Get("str_CardHolderCity"); // Default Value // DN
            if (!Empty(str_CardHolderCity.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_CardHolderCity"))
                str_CardHolderCity.AdvancedSearch.SearchOperator = Get("z_str_CardHolderCity");

            // str_CardHolderZip
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_CardHolderZip"))
                    str_CardHolderZip.AdvancedSearch.SearchValue = Get("x_str_CardHolderZip");
                else
                    str_CardHolderZip.AdvancedSearch.SearchValue = Get("str_CardHolderZip"); // Default Value // DN
            if (!Empty(str_CardHolderZip.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_CardHolderZip"))
                str_CardHolderZip.AdvancedSearch.SearchOperator = Get("z_str_CardHolderZip");

            // str_CardType
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_CardType"))
                    str_CardType.AdvancedSearch.SearchValue = Get("x_str_CardType");
                else
                    str_CardType.AdvancedSearch.SearchValue = Get("str_CardType"); // Default Value // DN
            if (!Empty(str_CardType.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_CardType"))
                str_CardType.AdvancedSearch.SearchOperator = Get("z_str_CardType");

            // str_CardExpMonth
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_CardExpMonth"))
                    str_CardExpMonth.AdvancedSearch.SearchValue = Get("x_str_CardExpMonth");
                else
                    str_CardExpMonth.AdvancedSearch.SearchValue = Get("str_CardExpMonth"); // Default Value // DN
            if (!Empty(str_CardExpMonth.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_CardExpMonth"))
                str_CardExpMonth.AdvancedSearch.SearchOperator = Get("z_str_CardExpMonth");

            // str_CardExpYear
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_CardExpYear"))
                    str_CardExpYear.AdvancedSearch.SearchValue = Get("x_str_CardExpYear");
                else
                    str_CardExpYear.AdvancedSearch.SearchValue = Get("str_CardExpYear"); // Default Value // DN
            if (!Empty(str_CardExpYear.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_CardExpYear"))
                str_CardExpYear.AdvancedSearch.SearchOperator = Get("z_str_CardExpYear");

            // str_CardNo
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_CardNo"))
                    str_CardNo.AdvancedSearch.SearchValue = Get("x_str_CardNo");
                else
                    str_CardNo.AdvancedSearch.SearchValue = Get("str_CardNo"); // Default Value // DN
            if (!Empty(str_CardNo.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_CardNo"))
                str_CardNo.AdvancedSearch.SearchOperator = Get("z_str_CardNo");

            // str_Certificate_No
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Certificate_No"))
                    str_Certificate_No.AdvancedSearch.SearchValue = Get("x_str_Certificate_No");
                else
                    str_Certificate_No.AdvancedSearch.SearchValue = Get("str_Certificate_No"); // Default Value // DN
            if (!Empty(str_Certificate_No.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Certificate_No"))
                str_Certificate_No.AdvancedSearch.SearchOperator = Get("z_str_Certificate_No");

            // str_AmountPaid
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_AmountPaid"))
                    str_AmountPaid.AdvancedSearch.SearchValue = Get("x_str_AmountPaid");
                else
                    str_AmountPaid.AdvancedSearch.SearchValue = Get("str_AmountPaid"); // Default Value // DN
            if (!Empty(str_AmountPaid.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_AmountPaid"))
                str_AmountPaid.AdvancedSearch.SearchOperator = Get("z_str_AmountPaid");

            // str_PermitValidated
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_PermitValidated"))
                    str_PermitValidated.AdvancedSearch.SearchValue = Get("x_str_PermitValidated");
                else
                    str_PermitValidated.AdvancedSearch.SearchValue = Get("str_PermitValidated"); // Default Value // DN
            if (!Empty(str_PermitValidated.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_PermitValidated"))
                str_PermitValidated.AdvancedSearch.SearchOperator = Get("z_str_PermitValidated");

            // strSMSNotification
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_strSMSNotification"))
                    strSMSNotification.AdvancedSearch.SearchValue = Get("x_strSMSNotification");
                else
                    strSMSNotification.AdvancedSearch.SearchValue = Get("strSMSNotification"); // Default Value // DN
            if (!Empty(strSMSNotification.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_strSMSNotification"))
                strSMSNotification.AdvancedSearch.SearchOperator = Get("z_strSMSNotification");

            // strVoiceNotification
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_strVoiceNotification"))
                    strVoiceNotification.AdvancedSearch.SearchValue = Get("x_strVoiceNotification");
                else
                    strVoiceNotification.AdvancedSearch.SearchValue = Get("strVoiceNotification"); // Default Value // DN
            if (!Empty(strVoiceNotification.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_strVoiceNotification"))
                strVoiceNotification.AdvancedSearch.SearchOperator = Get("z_strVoiceNotification");

            // str_Weight
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Weight"))
                    str_Weight.AdvancedSearch.SearchValue = Get("x_str_Weight");
                else
                    str_Weight.AdvancedSearch.SearchValue = Get("str_Weight"); // Default Value // DN
            if (!Empty(str_Weight.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Weight"))
                str_Weight.AdvancedSearch.SearchOperator = Get("z_str_Weight");

            // str_SpecialNeeds
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_SpecialNeeds"))
                    str_SpecialNeeds.AdvancedSearch.SearchValue = Get("x_str_SpecialNeeds");
                else
                    str_SpecialNeeds.AdvancedSearch.SearchValue = Get("str_SpecialNeeds"); // Default Value // DN
            if (!Empty(str_SpecialNeeds.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_SpecialNeeds"))
                str_SpecialNeeds.AdvancedSearch.SearchOperator = Get("z_str_SpecialNeeds");

            // str_MedicalConditions
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_MedicalConditions"))
                    str_MedicalConditions.AdvancedSearch.SearchValue = Get("x_str_MedicalConditions");
                else
                    str_MedicalConditions.AdvancedSearch.SearchValue = Get("str_MedicalConditions"); // Default Value // DN
            if (!Empty(str_MedicalConditions.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_MedicalConditions"))
                str_MedicalConditions.AdvancedSearch.SearchOperator = Get("z_str_MedicalConditions");

            // bit_Verified_PIC_InSAW
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_Verified_PIC_InSAW"))
                    bit_Verified_PIC_InSAW.AdvancedSearch.SearchValue = Get("x_bit_Verified_PIC_InSAW");
                else
                    bit_Verified_PIC_InSAW.AdvancedSearch.SearchValue = Get("bit_Verified_PIC_InSAW"); // Default Value // DN
            if (!Empty(bit_Verified_PIC_InSAW.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_Verified_PIC_InSAW"))
                bit_Verified_PIC_InSAW.AdvancedSearch.SearchOperator = Get("z_bit_Verified_PIC_InSAW");

            // bit_Permit_Waiver_Entered
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_Permit_Waiver_Entered"))
                    bit_Permit_Waiver_Entered.AdvancedSearch.SearchValue = Get("x_bit_Permit_Waiver_Entered");
                else
                    bit_Permit_Waiver_Entered.AdvancedSearch.SearchValue = Get("bit_Permit_Waiver_Entered"); // Default Value // DN
            if (!Empty(bit_Permit_Waiver_Entered.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_Permit_Waiver_Entered"))
                bit_Permit_Waiver_Entered.AdvancedSearch.SearchOperator = Get("z_bit_Permit_Waiver_Entered");

            // bit_TermsConditions
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_TermsConditions"))
                    bit_TermsConditions.AdvancedSearch.SearchValue = Get("x_bit_TermsConditions");
                else
                    bit_TermsConditions.AdvancedSearch.SearchValue = Get("bit_TermsConditions"); // Default Value // DN
            if (!Empty(bit_TermsConditions.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_TermsConditions"))
                bit_TermsConditions.AdvancedSearch.SearchOperator = Get("z_bit_TermsConditions");

            // bit_Disable_Self_Scheduling
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_Disable_Self_Scheduling"))
                    bit_Disable_Self_Scheduling.AdvancedSearch.SearchValue = Get("x_bit_Disable_Self_Scheduling");
                else
                    bit_Disable_Self_Scheduling.AdvancedSearch.SearchValue = Get("bit_Disable_Self_Scheduling"); // Default Value // DN
            if (!Empty(bit_Disable_Self_Scheduling.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_Disable_Self_Scheduling"))
                bit_Disable_Self_Scheduling.AdvancedSearch.SearchOperator = Get("z_bit_Disable_Self_Scheduling");

            // int_EyeColor
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_EyeColor"))
                    int_EyeColor.AdvancedSearch.SearchValue = Get("x_int_EyeColor");
                else
                    int_EyeColor.AdvancedSearch.SearchValue = Get("int_EyeColor"); // Default Value // DN
            if (!Empty(int_EyeColor.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_EyeColor"))
                int_EyeColor.AdvancedSearch.SearchOperator = Get("z_int_EyeColor");

            // int_HairColor
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_HairColor"))
                    int_HairColor.AdvancedSearch.SearchValue = Get("x_int_HairColor");
                else
                    int_HairColor.AdvancedSearch.SearchValue = Get("int_HairColor"); // Default Value // DN
            if (!Empty(int_HairColor.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_HairColor"))
                int_HairColor.AdvancedSearch.SearchOperator = Get("z_int_HairColor");

            // int_ColorBlind
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_ColorBlind"))
                    int_ColorBlind.AdvancedSearch.SearchValue = Get("x_int_ColorBlind");
                else
                    int_ColorBlind.AdvancedSearch.SearchValue = Get("int_ColorBlind"); // Default Value // DN
            if (!Empty(int_ColorBlind.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_ColorBlind"))
                int_ColorBlind.AdvancedSearch.SearchOperator = Get("z_int_ColorBlind");

            // int_HeightFeet
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_HeightFeet"))
                    int_HeightFeet.AdvancedSearch.SearchValue = Get("x_int_HeightFeet");
                else
                    int_HeightFeet.AdvancedSearch.SearchValue = Get("int_HeightFeet"); // Default Value // DN
            if (!Empty(int_HeightFeet.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_HeightFeet"))
                int_HeightFeet.AdvancedSearch.SearchOperator = Get("z_int_HeightFeet");

            // int_HeightInches
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_HeightInches"))
                    int_HeightInches.AdvancedSearch.SearchValue = Get("x_int_HeightInches");
                else
                    int_HeightInches.AdvancedSearch.SearchValue = Get("int_HeightInches"); // Default Value // DN
            if (!Empty(int_HeightInches.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_HeightInches"))
                int_HeightInches.AdvancedSearch.SearchOperator = Get("z_int_HeightInches");

            // str_reference_code
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_reference_code"))
                    str_reference_code.AdvancedSearch.SearchValue = Get("x_str_reference_code");
                else
                    str_reference_code.AdvancedSearch.SearchValue = Get("str_reference_code"); // Default Value // DN
            if (!Empty(str_reference_code.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_reference_code"))
                str_reference_code.AdvancedSearch.SearchOperator = Get("z_str_reference_code");

            // dt_ParentClassAttendedDt
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_ParentClassAttendedDt"))
                    dt_ParentClassAttendedDt.AdvancedSearch.SearchValue = Get("x_dt_ParentClassAttendedDt");
                else
                    dt_ParentClassAttendedDt.AdvancedSearch.SearchValue = Get("dt_ParentClassAttendedDt"); // Default Value // DN
            if (!Empty(dt_ParentClassAttendedDt.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_ParentClassAttendedDt"))
                dt_ParentClassAttendedDt.AdvancedSearch.SearchOperator = Get("z_dt_ParentClassAttendedDt");

            // str_ParentClassAttendedLoc
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_ParentClassAttendedLoc"))
                    str_ParentClassAttendedLoc.AdvancedSearch.SearchValue = Get("x_str_ParentClassAttendedLoc");
                else
                    str_ParentClassAttendedLoc.AdvancedSearch.SearchValue = Get("str_ParentClassAttendedLoc"); // Default Value // DN
            if (!Empty(str_ParentClassAttendedLoc.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_ParentClassAttendedLoc"))
                str_ParentClassAttendedLoc.AdvancedSearch.SearchOperator = Get("z_str_ParentClassAttendedLoc");

            // dt_SiblingClassAttendedDt
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_SiblingClassAttendedDt"))
                    dt_SiblingClassAttendedDt.AdvancedSearch.SearchValue = Get("x_dt_SiblingClassAttendedDt");
                else
                    dt_SiblingClassAttendedDt.AdvancedSearch.SearchValue = Get("dt_SiblingClassAttendedDt"); // Default Value // DN
            if (!Empty(dt_SiblingClassAttendedDt.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_SiblingClassAttendedDt"))
                dt_SiblingClassAttendedDt.AdvancedSearch.SearchOperator = Get("z_dt_SiblingClassAttendedDt");

            // str_SiblingClassAttendedLoc
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_SiblingClassAttendedLoc"))
                    str_SiblingClassAttendedLoc.AdvancedSearch.SearchValue = Get("x_str_SiblingClassAttendedLoc");
                else
                    str_SiblingClassAttendedLoc.AdvancedSearch.SearchValue = Get("str_SiblingClassAttendedLoc"); // Default Value // DN
            if (!Empty(str_SiblingClassAttendedLoc.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_SiblingClassAttendedLoc"))
                str_SiblingClassAttendedLoc.AdvancedSearch.SearchOperator = Get("z_str_SiblingClassAttendedLoc");

            // bit_PoliciesAndProcedures
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_PoliciesAndProcedures"))
                    bit_PoliciesAndProcedures.AdvancedSearch.SearchValue = Get("x_bit_PoliciesAndProcedures");
                else
                    bit_PoliciesAndProcedures.AdvancedSearch.SearchValue = Get("bit_PoliciesAndProcedures"); // Default Value // DN
            if (!Empty(bit_PoliciesAndProcedures.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_PoliciesAndProcedures"))
                bit_PoliciesAndProcedures.AdvancedSearch.SearchOperator = Get("z_bit_PoliciesAndProcedures");

            // dt_CourseCompletionDt
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_CourseCompletionDt"))
                    dt_CourseCompletionDt.AdvancedSearch.SearchValue = Get("x_dt_CourseCompletionDt");
                else
                    dt_CourseCompletionDt.AdvancedSearch.SearchValue = Get("dt_CourseCompletionDt"); // Default Value // DN
            if (!Empty(dt_CourseCompletionDt.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_CourseCompletionDt"))
                dt_CourseCompletionDt.AdvancedSearch.SearchOperator = Get("z_dt_CourseCompletionDt");

            // dt_ExtensionDt
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_ExtensionDt"))
                    dt_ExtensionDt.AdvancedSearch.SearchValue = Get("x_dt_ExtensionDt");
                else
                    dt_ExtensionDt.AdvancedSearch.SearchValue = Get("dt_ExtensionDt"); // Default Value // DN
            if (!Empty(dt_ExtensionDt.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_ExtensionDt"))
                dt_ExtensionDt.AdvancedSearch.SearchOperator = Get("z_dt_ExtensionDt");

            // str_MedicalCondition
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_MedicalCondition"))
                    str_MedicalCondition.AdvancedSearch.SearchValue = Get("x_str_MedicalCondition");
                else
                    str_MedicalCondition.AdvancedSearch.SearchValue = Get("str_MedicalCondition"); // Default Value // DN
            if (!Empty(str_MedicalCondition.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_MedicalCondition"))
                str_MedicalCondition.AdvancedSearch.SearchOperator = Get("z_str_MedicalCondition");

            // str_MajorCrossStreets
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_MajorCrossStreets"))
                    str_MajorCrossStreets.AdvancedSearch.SearchValue = Get("x_str_MajorCrossStreets");
                else
                    str_MajorCrossStreets.AdvancedSearch.SearchValue = Get("str_MajorCrossStreets"); // Default Value // DN
            if (!Empty(str_MajorCrossStreets.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_MajorCrossStreets"))
                str_MajorCrossStreets.AdvancedSearch.SearchOperator = Get("z_str_MajorCrossStreets");

            // str_DriverEdCertNo
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_DriverEdCertNo"))
                    str_DriverEdCertNo.AdvancedSearch.SearchValue = Get("x_str_DriverEdCertNo");
                else
                    str_DriverEdCertNo.AdvancedSearch.SearchValue = Get("str_DriverEdCertNo"); // Default Value // DN
            if (!Empty(str_DriverEdCertNo.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_DriverEdCertNo"))
                str_DriverEdCertNo.AdvancedSearch.SearchOperator = Get("z_str_DriverEdCertNo");

            // dt_DriverEdCertIssuedDt
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_DriverEdCertIssuedDt"))
                    dt_DriverEdCertIssuedDt.AdvancedSearch.SearchValue = Get("x_dt_DriverEdCertIssuedDt");
                else
                    dt_DriverEdCertIssuedDt.AdvancedSearch.SearchValue = Get("dt_DriverEdCertIssuedDt"); // Default Value // DN
            if (!Empty(dt_DriverEdCertIssuedDt.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_DriverEdCertIssuedDt"))
                dt_DriverEdCertIssuedDt.AdvancedSearch.SearchOperator = Get("z_dt_DriverEdCertIssuedDt");

            // str_BTWDriversEdCertNo
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_BTWDriversEdCertNo"))
                    str_BTWDriversEdCertNo.AdvancedSearch.SearchValue = Get("x_str_BTWDriversEdCertNo");
                else
                    str_BTWDriversEdCertNo.AdvancedSearch.SearchValue = Get("str_BTWDriversEdCertNo"); // Default Value // DN
            if (!Empty(str_BTWDriversEdCertNo.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_BTWDriversEdCertNo"))
                str_BTWDriversEdCertNo.AdvancedSearch.SearchOperator = Get("z_str_BTWDriversEdCertNo");

            // dt_BTWCertIssuedDt
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_BTWCertIssuedDt"))
                    dt_BTWCertIssuedDt.AdvancedSearch.SearchValue = Get("x_dt_BTWCertIssuedDt");
                else
                    dt_BTWCertIssuedDt.AdvancedSearch.SearchValue = Get("dt_BTWCertIssuedDt"); // Default Value // DN
            if (!Empty(dt_BTWCertIssuedDt.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_BTWCertIssuedDt"))
                dt_BTWCertIssuedDt.AdvancedSearch.SearchOperator = Get("z_dt_BTWCertIssuedDt");

            // str_OLDriversEdCertNo
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_OLDriversEdCertNo"))
                    str_OLDriversEdCertNo.AdvancedSearch.SearchValue = Get("x_str_OLDriversEdCertNo");
                else
                    str_OLDriversEdCertNo.AdvancedSearch.SearchValue = Get("str_OLDriversEdCertNo"); // Default Value // DN
            if (!Empty(str_OLDriversEdCertNo.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_OLDriversEdCertNo"))
                str_OLDriversEdCertNo.AdvancedSearch.SearchOperator = Get("z_str_OLDriversEdCertNo");

            // dt_OLCertIssuedDt
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_OLCertIssuedDt"))
                    dt_OLCertIssuedDt.AdvancedSearch.SearchValue = Get("x_dt_OLCertIssuedDt");
                else
                    dt_OLCertIssuedDt.AdvancedSearch.SearchValue = Get("dt_OLCertIssuedDt"); // Default Value // DN
            if (!Empty(dt_OLCertIssuedDt.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_OLCertIssuedDt"))
                dt_OLCertIssuedDt.AdvancedSearch.SearchOperator = Get("z_dt_OLCertIssuedDt");

            // str_height
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_height"))
                    str_height.AdvancedSearch.SearchValue = Get("x_str_height");
                else
                    str_height.AdvancedSearch.SearchValue = Get("str_height"); // Default Value // DN
            if (!Empty(str_height.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_height"))
                str_height.AdvancedSearch.SearchOperator = Get("z_str_height");

            // dt_BTWCompletionDt
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_BTWCompletionDt"))
                    dt_BTWCompletionDt.AdvancedSearch.SearchValue = Get("x_dt_BTWCompletionDt");
                else
                    dt_BTWCompletionDt.AdvancedSearch.SearchValue = Get("dt_BTWCompletionDt"); // Default Value // DN
            if (!Empty(dt_BTWCompletionDt.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_BTWCompletionDt"))
                dt_BTWCompletionDt.AdvancedSearch.SearchOperator = Get("z_dt_BTWCompletionDt");

            // dt_CRCompletionDt
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_CRCompletionDt"))
                    dt_CRCompletionDt.AdvancedSearch.SearchValue = Get("x_dt_CRCompletionDt");
                else
                    dt_CRCompletionDt.AdvancedSearch.SearchValue = Get("dt_CRCompletionDt"); // Default Value // DN
            if (!Empty(dt_CRCompletionDt.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_CRCompletionDt"))
                dt_CRCompletionDt.AdvancedSearch.SearchOperator = Get("z_dt_CRCompletionDt");

            // strTextBox5
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_strTextBox5"))
                    strTextBox5.AdvancedSearch.SearchValue = Get("x_strTextBox5");
                else
                    strTextBox5.AdvancedSearch.SearchValue = Get("strTextBox5"); // Default Value // DN
            if (!Empty(strTextBox5.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_strTextBox5"))
                strTextBox5.AdvancedSearch.SearchOperator = Get("z_strTextBox5");

            // strTextBox6
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_strTextBox6"))
                    strTextBox6.AdvancedSearch.SearchValue = Get("x_strTextBox6");
                else
                    strTextBox6.AdvancedSearch.SearchValue = Get("strTextBox6"); // Default Value // DN
            if (!Empty(strTextBox6.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_strTextBox6"))
                strTextBox6.AdvancedSearch.SearchOperator = Get("z_strTextBox6");

            // str_ApartmentNo
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_ApartmentNo"))
                    str_ApartmentNo.AdvancedSearch.SearchValue = Get("x_str_ApartmentNo");
                else
                    str_ApartmentNo.AdvancedSearch.SearchValue = Get("str_ApartmentNo"); // Default Value // DN
            if (!Empty(str_ApartmentNo.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_ApartmentNo"))
                str_ApartmentNo.AdvancedSearch.SearchOperator = Get("z_str_ApartmentNo");

            // dt_PermitTestDate
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_PermitTestDate"))
                    dt_PermitTestDate.AdvancedSearch.SearchValue = Get("x_dt_PermitTestDate");
                else
                    dt_PermitTestDate.AdvancedSearch.SearchValue = Get("dt_PermitTestDate"); // Default Value // DN
            if (!Empty(dt_PermitTestDate.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_PermitTestDate"))
                dt_PermitTestDate.AdvancedSearch.SearchOperator = Get("z_dt_PermitTestDate");

            // str_OnlineDriverEdLogin
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_OnlineDriverEdLogin"))
                    str_OnlineDriverEdLogin.AdvancedSearch.SearchValue = Get("x_str_OnlineDriverEdLogin");
                else
                    str_OnlineDriverEdLogin.AdvancedSearch.SearchValue = Get("str_OnlineDriverEdLogin"); // Default Value // DN
            if (!Empty(str_OnlineDriverEdLogin.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_OnlineDriverEdLogin"))
                str_OnlineDriverEdLogin.AdvancedSearch.SearchOperator = Get("z_str_OnlineDriverEdLogin");

            // str_OnlineDriverEdPassword
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_OnlineDriverEdPassword"))
                    str_OnlineDriverEdPassword.AdvancedSearch.SearchValue = Get("x_str_OnlineDriverEdPassword");
                else
                    str_OnlineDriverEdPassword.AdvancedSearch.SearchValue = Get("str_OnlineDriverEdPassword"); // Default Value // DN
            if (!Empty(str_OnlineDriverEdPassword.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_OnlineDriverEdPassword"))
                str_OnlineDriverEdPassword.AdvancedSearch.SearchOperator = Get("z_str_OnlineDriverEdPassword");

            // bit_IsSMSEnabled
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_IsSMSEnabled"))
                    bit_IsSMSEnabled.AdvancedSearch.SearchValue = Get("x_bit_IsSMSEnabled");
                else
                    bit_IsSMSEnabled.AdvancedSearch.SearchValue = Get("bit_IsSMSEnabled"); // Default Value // DN
            if (!Empty(bit_IsSMSEnabled.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_IsSMSEnabled"))
                bit_IsSMSEnabled.AdvancedSearch.SearchOperator = Get("z_bit_IsSMSEnabled");

            // dt_SMSModified
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_SMSModified"))
                    dt_SMSModified.AdvancedSearch.SearchValue = Get("x_dt_SMSModified");
                else
                    dt_SMSModified.AdvancedSearch.SearchValue = Get("dt_SMSModified"); // Default Value // DN
            if (!Empty(dt_SMSModified.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_SMSModified"))
                dt_SMSModified.AdvancedSearch.SearchOperator = Get("z_dt_SMSModified");

            // str_confirmPassword
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_confirmPassword"))
                    str_confirmPassword.AdvancedSearch.SearchValue = Get("x_str_confirmPassword");
                else
                    str_confirmPassword.AdvancedSearch.SearchValue = Get("str_confirmPassword"); // Default Value // DN
            if (!Empty(str_confirmPassword.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_confirmPassword"))
                str_confirmPassword.AdvancedSearch.SearchOperator = Get("z_str_confirmPassword");

            // DE_Certificate
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_DE_Certificate"))
                    DE_Certificate.AdvancedSearch.SearchValue = Get("x_DE_Certificate");
                else
                    DE_Certificate.AdvancedSearch.SearchValue = Get("DE_Certificate"); // Default Value // DN
            if (!Empty(DE_Certificate.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_DE_Certificate"))
                DE_Certificate.AdvancedSearch.SearchOperator = Get("z_DE_Certificate");

            // Discuss
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Discuss"))
                    Discuss.AdvancedSearch.SearchValue = Get("x_Discuss");
                else
                    Discuss.AdvancedSearch.SearchValue = Get("Discuss"); // Default Value // DN
            if (!Empty(Discuss.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Discuss"))
                Discuss.AdvancedSearch.SearchOperator = Get("z_Discuss");

            // int_UnlicensedSibling
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_UnlicensedSibling"))
                    int_UnlicensedSibling.AdvancedSearch.SearchValue = Get("x_int_UnlicensedSibling");
                else
                    int_UnlicensedSibling.AdvancedSearch.SearchValue = Get("int_UnlicensedSibling"); // Default Value // DN
            if (!Empty(int_UnlicensedSibling.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_UnlicensedSibling"))
                int_UnlicensedSibling.AdvancedSearch.SearchOperator = Get("z_int_UnlicensedSibling");

            // int_YearSiblingIsEligible
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_YearSiblingIsEligible"))
                    int_YearSiblingIsEligible.AdvancedSearch.SearchValue = Get("x_int_YearSiblingIsEligible");
                else
                    int_YearSiblingIsEligible.AdvancedSearch.SearchValue = Get("int_YearSiblingIsEligible"); // Default Value // DN
            if (!Empty(int_YearSiblingIsEligible.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_YearSiblingIsEligible"))
                int_YearSiblingIsEligible.AdvancedSearch.SearchOperator = Get("z_int_YearSiblingIsEligible");

            // BTW_Certificate
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_BTW_Certificate"))
                    BTW_Certificate.AdvancedSearch.SearchValue = Get("x_BTW_Certificate");
                else
                    BTW_Certificate.AdvancedSearch.SearchValue = Get("BTW_Certificate"); // Default Value // DN
            if (!Empty(BTW_Certificate.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_BTW_Certificate"))
                BTW_Certificate.AdvancedSearch.SearchOperator = Get("z_BTW_Certificate");

            // dt_DECertIssueDate
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_DECertIssueDate"))
                    dt_DECertIssueDate.AdvancedSearch.SearchValue = Get("x_dt_DECertIssueDate");
                else
                    dt_DECertIssueDate.AdvancedSearch.SearchValue = Get("dt_DECertIssueDate"); // Default Value // DN
            if (!Empty(dt_DECertIssueDate.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_DECertIssueDate"))
                dt_DECertIssueDate.AdvancedSearch.SearchOperator = Get("z_dt_DECertIssueDate");

            // str_StudentSignature
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_StudentSignature"))
                    str_StudentSignature.AdvancedSearch.SearchValue = Get("x_str_StudentSignature");
                else
                    str_StudentSignature.AdvancedSearch.SearchValue = Get("str_StudentSignature"); // Default Value // DN
            if (!Empty(str_StudentSignature.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_StudentSignature"))
                str_StudentSignature.AdvancedSearch.SearchOperator = Get("z_str_StudentSignature");

            // str_ParentSignature
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_ParentSignature"))
                    str_ParentSignature.AdvancedSearch.SearchValue = Get("x_str_ParentSignature");
                else
                    str_ParentSignature.AdvancedSearch.SearchValue = Get("str_ParentSignature"); // Default Value // DN
            if (!Empty(str_ParentSignature.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_ParentSignature"))
                str_ParentSignature.AdvancedSearch.SearchOperator = Get("z_str_ParentSignature");

            // str_Last6DigitsOfParentDriversLicense
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Last6DigitsOfParentDriversLicense"))
                    str_Last6DigitsOfParentDriversLicense.AdvancedSearch.SearchValue = Get("x_str_Last6DigitsOfParentDriversLicense");
                else
                    str_Last6DigitsOfParentDriversLicense.AdvancedSearch.SearchValue = Get("str_Last6DigitsOfParentDriversLicense"); // Default Value // DN
            if (!Empty(str_Last6DigitsOfParentDriversLicense.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Last6DigitsOfParentDriversLicense"))
                str_Last6DigitsOfParentDriversLicense.AdvancedSearch.SearchOperator = Get("z_str_Last6DigitsOfParentDriversLicense");

            // str_FACControl
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_FACControl"))
                    str_FACControl.AdvancedSearch.SearchValue = Get("x_str_FACControl");
                else
                    str_FACControl.AdvancedSearch.SearchValue = Get("str_FACControl"); // Default Value // DN
            if (!Empty(str_FACControl.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_FACControl"))
                str_FACControl.AdvancedSearch.SearchOperator = Get("z_str_FACControl");

            // Classroom_Status_Code
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Classroom_Status_Code"))
                    Classroom_Status_Code.AdvancedSearch.SearchValue = Get("x_Classroom_Status_Code");
                else
                    Classroom_Status_Code.AdvancedSearch.SearchValue = Get("Classroom_Status_Code"); // Default Value // DN
            if (!Empty(Classroom_Status_Code.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Classroom_Status_Code"))
                Classroom_Status_Code.AdvancedSearch.SearchOperator = Get("z_Classroom_Status_Code");

            // Laboratory_Status_Code
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Laboratory_Status_Code"))
                    Laboratory_Status_Code.AdvancedSearch.SearchValue = Get("x_Laboratory_Status_Code");
                else
                    Laboratory_Status_Code.AdvancedSearch.SearchValue = Get("Laboratory_Status_Code"); // Default Value // DN
            if (!Empty(Laboratory_Status_Code.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Laboratory_Status_Code"))
                Laboratory_Status_Code.AdvancedSearch.SearchOperator = Get("z_Laboratory_Status_Code");

            // bit_EnrollmentForm
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_EnrollmentForm"))
                    bit_EnrollmentForm.AdvancedSearch.SearchValue = Get("x_bit_EnrollmentForm");
                else
                    bit_EnrollmentForm.AdvancedSearch.SearchValue = Get("bit_EnrollmentForm"); // Default Value // DN
            if (!Empty(bit_EnrollmentForm.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_EnrollmentForm"))
                bit_EnrollmentForm.AdvancedSearch.SearchOperator = Get("z_bit_EnrollmentForm");

            // bit_ParentStudentContract
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_ParentStudentContract"))
                    bit_ParentStudentContract.AdvancedSearch.SearchValue = Get("x_bit_ParentStudentContract");
                else
                    bit_ParentStudentContract.AdvancedSearch.SearchValue = Get("bit_ParentStudentContract"); // Default Value // DN
            if (!Empty(bit_ParentStudentContract.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_ParentStudentContract"))
                bit_ParentStudentContract.AdvancedSearch.SearchOperator = Get("z_bit_ParentStudentContract");

            // bit_ParentalAgreement
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_ParentalAgreement"))
                    bit_ParentalAgreement.AdvancedSearch.SearchValue = Get("x_bit_ParentalAgreement");
                else
                    bit_ParentalAgreement.AdvancedSearch.SearchValue = Get("bit_ParentalAgreement"); // Default Value // DN
            if (!Empty(bit_ParentalAgreement.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_ParentalAgreement"))
                bit_ParentalAgreement.AdvancedSearch.SearchOperator = Get("z_bit_ParentalAgreement");

            // int_SF_GR_WA_HS
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_SF_GR_WA_HS"))
                    int_SF_GR_WA_HS.AdvancedSearch.SearchValue = Get("x_int_SF_GR_WA_HS");
                else
                    int_SF_GR_WA_HS.AdvancedSearch.SearchValue = Get("int_SF_GR_WA_HS"); // Default Value // DN
            if (!Empty(int_SF_GR_WA_HS.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_SF_GR_WA_HS"))
                int_SF_GR_WA_HS.AdvancedSearch.SearchOperator = Get("z_int_SF_GR_WA_HS");

            // bit_DisableOnRMV
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_DisableOnRMV"))
                    bit_DisableOnRMV.AdvancedSearch.SearchValue = Get("x_bit_DisableOnRMV");
                else
                    bit_DisableOnRMV.AdvancedSearch.SearchValue = Get("bit_DisableOnRMV"); // Default Value // DN
            if (!Empty(bit_DisableOnRMV.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_DisableOnRMV"))
                bit_DisableOnRMV.AdvancedSearch.SearchOperator = Get("z_bit_DisableOnRMV");

            // bit_UploadedToRMV
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_UploadedToRMV"))
                    bit_UploadedToRMV.AdvancedSearch.SearchValue = Get("x_bit_UploadedToRMV");
                else
                    bit_UploadedToRMV.AdvancedSearch.SearchValue = Get("bit_UploadedToRMV"); // Default Value // DN
            if (!Empty(bit_UploadedToRMV.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_UploadedToRMV"))
                bit_UploadedToRMV.AdvancedSearch.SearchOperator = Get("z_bit_UploadedToRMV");

            // str_Mother_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Mother_Name"))
                    str_Mother_Name.AdvancedSearch.SearchValue = Get("x_str_Mother_Name");
                else
                    str_Mother_Name.AdvancedSearch.SearchValue = Get("str_Mother_Name"); // Default Value // DN
            if (!Empty(str_Mother_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Mother_Name"))
                str_Mother_Name.AdvancedSearch.SearchOperator = Get("z_str_Mother_Name");

            // str_Guardians_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Guardians_Name"))
                    str_Guardians_Name.AdvancedSearch.SearchValue = Get("x_str_Guardians_Name");
                else
                    str_Guardians_Name.AdvancedSearch.SearchValue = Get("str_Guardians_Name"); // Default Value // DN
            if (!Empty(str_Guardians_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Guardians_Name"))
                str_Guardians_Name.AdvancedSearch.SearchOperator = Get("z_str_Guardians_Name");

            // str_Mother_Phone
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Mother_Phone"))
                    str_Mother_Phone.AdvancedSearch.SearchValue = Get("x_str_Mother_Phone");
                else
                    str_Mother_Phone.AdvancedSearch.SearchValue = Get("str_Mother_Phone"); // Default Value // DN
            if (!Empty(str_Mother_Phone.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Mother_Phone"))
                str_Mother_Phone.AdvancedSearch.SearchOperator = Get("z_str_Mother_Phone");

            // bit_terms
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_terms"))
                    bit_terms.AdvancedSearch.SearchValue = Get("x_bit_terms");
                else
                    bit_terms.AdvancedSearch.SearchValue = Get("bit_terms"); // Default Value // DN
            if (!Empty(bit_terms.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_terms"))
                bit_terms.AdvancedSearch.SearchOperator = Get("z_bit_terms");

            // int_Nationality
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Nationality"))
                    int_Nationality.AdvancedSearch.SearchValue = Get("x_int_Nationality");
                else
                    int_Nationality.AdvancedSearch.SearchValue = Get("int_Nationality"); // Default Value // DN
            if (!Empty(int_Nationality.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Nationality"))
                int_Nationality.AdvancedSearch.SearchOperator = Get("z_int_Nationality");

            // str_National_ID_en
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_National_ID_en"))
                    str_National_ID_en.AdvancedSearch.SearchValue = Get("x_str_National_ID_en");
                else
                    str_National_ID_en.AdvancedSearch.SearchValue = Get("str_National_ID_en"); // Default Value // DN
            if (!Empty(str_National_ID_en.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_National_ID_en"))
                str_National_ID_en.AdvancedSearch.SearchOperator = Get("z_str_National_ID_en");

            // str_National_ID_arabic
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_National_ID_arabic"))
                    str_National_ID_arabic.AdvancedSearch.SearchValue = Get("x_str_National_ID_arabic");
                else
                    str_National_ID_arabic.AdvancedSearch.SearchValue = Get("str_National_ID_arabic"); // Default Value // DN
            if (!Empty(str_National_ID_arabic.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_National_ID_arabic"))
                str_National_ID_arabic.AdvancedSearch.SearchOperator = Get("z_str_National_ID_arabic");

            // Quallification_Id
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Quallification_Id"))
                    Quallification_Id.AdvancedSearch.SearchValue = Get("x_Quallification_Id");
                else
                    Quallification_Id.AdvancedSearch.SearchValue = Get("Quallification_Id"); // Default Value // DN
            if (!Empty(Quallification_Id.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Quallification_Id"))
                Quallification_Id.AdvancedSearch.SearchOperator = Get("z_Quallification_Id");

            // Job_Id
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Job_Id"))
                    Job_Id.AdvancedSearch.SearchValue = Get("x_Job_Id");
                else
                    Job_Id.AdvancedSearch.SearchValue = Get("Job_Id"); // Default Value // DN
            if (!Empty(Job_Id.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Job_Id"))
                Job_Id.AdvancedSearch.SearchOperator = Get("z_Job_Id");

            // str_DOB_arabic
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_DOB_arabic[]"))
                    str_DOB_arabic.AdvancedSearch.SearchValue = Get("x_str_DOB_arabic[]");
                else
                    str_DOB_arabic.AdvancedSearch.SearchValue = Get("str_DOB_arabic"); // Default Value // DN
            if (!Empty(str_DOB_arabic.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_DOB_arabic"))
                str_DOB_arabic.AdvancedSearch.SearchOperator = Get("z_str_DOB_arabic");

            // int_Language
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Language"))
                    int_Language.AdvancedSearch.SearchValue = Get("x_int_Language");
                else
                    int_Language.AdvancedSearch.SearchValue = Get("int_Language"); // Default Value // DN
            if (!Empty(int_Language.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Language"))
                int_Language.AdvancedSearch.SearchOperator = Get("z_int_Language");

            // strRefId
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_strRefId"))
                    strRefId.AdvancedSearch.SearchValue = Get("x_strRefId");
                else
                    strRefId.AdvancedSearch.SearchValue = Get("strRefId"); // Default Value // DN
            if (!Empty(strRefId.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_strRefId"))
                strRefId.AdvancedSearch.SearchOperator = Get("z_strRefId");

            // int_Program_Id
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Program_Id"))
                    int_Program_Id.AdvancedSearch.SearchValue = Get("x_int_Program_Id");
                else
                    int_Program_Id.AdvancedSearch.SearchValue = Get("int_Program_Id"); // Default Value // DN
            if (!Empty(int_Program_Id.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Program_Id"))
                int_Program_Id.AdvancedSearch.SearchOperator = Get("z_int_Program_Id");

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

            // IsScheduleassessment
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_IsScheduleassessment"))
                    IsScheduleassessment.AdvancedSearch.SearchValue = Get("x_IsScheduleassessment");
                else
                    IsScheduleassessment.AdvancedSearch.SearchValue = Get("IsScheduleassessment"); // Default Value // DN
            if (!Empty(IsScheduleassessment.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_IsScheduleassessment"))
                IsScheduleassessment.AdvancedSearch.SearchOperator = Get("z_IsScheduleassessment");

            // IsEnrollbyyourself
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_IsEnrollbyyourself"))
                    IsEnrollbyyourself.AdvancedSearch.SearchValue = Get("x_IsEnrollbyyourself");
                else
                    IsEnrollbyyourself.AdvancedSearch.SearchValue = Get("IsEnrollbyyourself"); // Default Value // DN
            if (!Empty(IsEnrollbyyourself.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_IsEnrollbyyourself"))
                IsEnrollbyyourself.AdvancedSearch.SearchOperator = Get("z_IsEnrollbyyourself");

            // AssessmentTime
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_AssessmentTime"))
                    AssessmentTime.AdvancedSearch.SearchValue = Get("x_AssessmentTime");
                else
                    AssessmentTime.AdvancedSearch.SearchValue = Get("AssessmentTime"); // Default Value // DN
            if (!Empty(AssessmentTime.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_AssessmentTime"))
                AssessmentTime.AdvancedSearch.SearchOperator = Get("z_AssessmentTime");

            // AssessmentDate
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_AssessmentDate"))
                    AssessmentDate.AdvancedSearch.SearchValue = Get("x_AssessmentDate");
                else
                    AssessmentDate.AdvancedSearch.SearchValue = Get("AssessmentDate"); // Default Value // DN
            if (!Empty(AssessmentDate.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_AssessmentDate"))
                AssessmentDate.AdvancedSearch.SearchOperator = Get("z_AssessmentDate");

            // isAssessmentDone
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_isAssessmentDone"))
                    isAssessmentDone.AdvancedSearch.SearchValue = Get("x_isAssessmentDone");
                else
                    isAssessmentDone.AdvancedSearch.SearchValue = Get("isAssessmentDone"); // Default Value // DN
            if (!Empty(isAssessmentDone.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_isAssessmentDone"))
                isAssessmentDone.AdvancedSearch.SearchOperator = Get("z_isAssessmentDone");

            // AssessmentScore
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_AssessmentScore"))
                    AssessmentScore.AdvancedSearch.SearchValue = Get("x_AssessmentScore");
                else
                    AssessmentScore.AdvancedSearch.SearchValue = Get("AssessmentScore"); // Default Value // DN
            if (!Empty(AssessmentScore.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_AssessmentScore"))
                AssessmentScore.AdvancedSearch.SearchOperator = Get("z_AssessmentScore");

            // dt_WrittenTestPassed
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_WrittenTestPassed[]"))
                    dt_WrittenTestPassed.AdvancedSearch.SearchValue = Get("x_dt_WrittenTestPassed[]");
                else
                    dt_WrittenTestPassed.AdvancedSearch.SearchValue = Get("dt_WrittenTestPassed"); // Default Value // DN
            if (!Empty(dt_WrittenTestPassed.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_WrittenTestPassed"))
                dt_WrittenTestPassed.AdvancedSearch.SearchOperator = Get("z_dt_WrittenTestPassed");

            // dt_RoadTestPassed
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_RoadTestPassed[]"))
                    dt_RoadTestPassed.AdvancedSearch.SearchValue = Get("x_dt_RoadTestPassed[]");
                else
                    dt_RoadTestPassed.AdvancedSearch.SearchValue = Get("dt_RoadTestPassed"); // Default Value // DN
            if (!Empty(dt_RoadTestPassed.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_RoadTestPassed"))
                dt_RoadTestPassed.AdvancedSearch.SearchOperator = Get("z_dt_RoadTestPassed");

            // bit_Archive
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_Archive"))
                    bit_Archive.AdvancedSearch.SearchValue = Get("x_bit_Archive");
                else
                    bit_Archive.AdvancedSearch.SearchValue = Get("bit_Archive"); // Default Value // DN
            if (!Empty(bit_Archive.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_Archive"))
                bit_Archive.AdvancedSearch.SearchOperator = Get("z_bit_Archive");

            // ArchiveNotes
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_ArchiveNotes"))
                    ArchiveNotes.AdvancedSearch.SearchValue = Get("x_ArchiveNotes");
                else
                    ArchiveNotes.AdvancedSearch.SearchValue = Get("ArchiveNotes"); // Default Value // DN
            if (!Empty(ArchiveNotes.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_ArchiveNotes"))
                ArchiveNotes.AdvancedSearch.SearchOperator = Get("z_ArchiveNotes");

            // dtArchived
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dtArchived"))
                    dtArchived.AdvancedSearch.SearchValue = Get("x_dtArchived");
                else
                    dtArchived.AdvancedSearch.SearchValue = Get("dtArchived"); // Default Value // DN
            if (!Empty(dtArchived.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dtArchived"))
                dtArchived.AdvancedSearch.SearchOperator = Get("z_dtArchived");

            // SrNo9Dec21
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_SrNo9Dec21"))
                    SrNo9Dec21.AdvancedSearch.SearchValue = Get("x_SrNo9Dec21");
                else
                    SrNo9Dec21.AdvancedSearch.SearchValue = Get("SrNo9Dec21"); // Default Value // DN
            if (!Empty(SrNo9Dec21.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_SrNo9Dec21"))
                SrNo9Dec21.AdvancedSearch.SearchOperator = Get("z_SrNo9Dec21");

            // REGNNUMB
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_REGNNUMB"))
                    REGNNUMB.AdvancedSearch.SearchValue = Get("x_REGNNUMB");
                else
                    REGNNUMB.AdvancedSearch.SearchValue = Get("REGNNUMB"); // Default Value // DN
            if (!Empty(REGNNUMB.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_REGNNUMB"))
                REGNNUMB.AdvancedSearch.SearchOperator = Get("z_REGNNUMB");

            // REGNLOCN
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_REGNLOCN"))
                    REGNLOCN.AdvancedSearch.SearchValue = Get("x_REGNLOCN");
                else
                    REGNLOCN.AdvancedSearch.SearchValue = Get("REGNLOCN"); // Default Value // DN
            if (!Empty(REGNLOCN.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_REGNLOCN"))
                REGNLOCN.AdvancedSearch.SearchOperator = Get("z_REGNLOCN");

            // SrNo11DecF1S1
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_SrNo11DecF1S1"))
                    SrNo11DecF1S1.AdvancedSearch.SearchValue = Get("x_SrNo11DecF1S1");
                else
                    SrNo11DecF1S1.AdvancedSearch.SearchValue = Get("SrNo11DecF1S1"); // Default Value // DN
            if (!Empty(SrNo11DecF1S1.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_SrNo11DecF1S1"))
                SrNo11DecF1S1.AdvancedSearch.SearchOperator = Get("z_SrNo11DecF1S1");

            // IsInterestedInTraining
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_IsInterestedInTraining"))
                    IsInterestedInTraining.AdvancedSearch.SearchValue = Get("x_IsInterestedInTraining");
                else
                    IsInterestedInTraining.AdvancedSearch.SearchValue = Get("IsInterestedInTraining"); // Default Value // DN
            if (!Empty(IsInterestedInTraining.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_IsInterestedInTraining"))
                IsInterestedInTraining.AdvancedSearch.SearchOperator = Get("z_IsInterestedInTraining");

            // StudentEncryptID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_StudentEncryptID"))
                    StudentEncryptID.AdvancedSearch.SearchValue = Get("x_StudentEncryptID");
                else
                    StudentEncryptID.AdvancedSearch.SearchValue = Get("StudentEncryptID"); // Default Value // DN
            if (!Empty(StudentEncryptID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_StudentEncryptID"))
                StudentEncryptID.AdvancedSearch.SearchOperator = Get("z_StudentEncryptID");

            // StudentConfirURL
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_StudentConfirURL"))
                    StudentConfirURL.AdvancedSearch.SearchValue = Get("x_StudentConfirURL");
                else
                    StudentConfirURL.AdvancedSearch.SearchValue = Get("StudentConfirURL"); // Default Value // DN
            if (!Empty(StudentConfirURL.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_StudentConfirURL"))
                StudentConfirURL.AdvancedSearch.SearchOperator = Get("z_StudentConfirURL");

            // SrNo15DecF1S2
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_SrNo15DecF1S2"))
                    SrNo15DecF1S2.AdvancedSearch.SearchValue = Get("x_SrNo15DecF1S2");
                else
                    SrNo15DecF1S2.AdvancedSearch.SearchValue = Get("SrNo15DecF1S2"); // Default Value // DN
            if (!Empty(SrNo15DecF1S2.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_SrNo15DecF1S2"))
                SrNo15DecF1S2.AdvancedSearch.SearchOperator = Get("z_SrNo15DecF1S2");

            // SrNo15DecF1S3
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_SrNo15DecF1S3"))
                    SrNo15DecF1S3.AdvancedSearch.SearchValue = Get("x_SrNo15DecF1S3");
                else
                    SrNo15DecF1S3.AdvancedSearch.SearchValue = Get("SrNo15DecF1S3"); // Default Value // DN
            if (!Empty(SrNo15DecF1S3.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_SrNo15DecF1S3"))
                SrNo15DecF1S3.AdvancedSearch.SearchOperator = Get("z_SrNo15DecF1S3");

            // SrNo16DecF2S2
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_SrNo16DecF2S2"))
                    SrNo16DecF2S2.AdvancedSearch.SearchValue = Get("x_SrNo16DecF2S2");
                else
                    SrNo16DecF2S2.AdvancedSearch.SearchValue = Get("SrNo16DecF2S2"); // Default Value // DN
            if (!Empty(SrNo16DecF2S2.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_SrNo16DecF2S2"))
                SrNo16DecF2S2.AdvancedSearch.SearchOperator = Get("z_SrNo16DecF2S2");

            // SrNo16DecF2S3
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_SrNo16DecF2S3"))
                    SrNo16DecF2S3.AdvancedSearch.SearchValue = Get("x_SrNo16DecF2S3");
                else
                    SrNo16DecF2S3.AdvancedSearch.SearchValue = Get("SrNo16DecF2S3"); // Default Value // DN
            if (!Empty(SrNo16DecF2S3.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_SrNo16DecF2S3"))
                SrNo16DecF2S3.AdvancedSearch.SearchOperator = Get("z_SrNo16DecF2S3");

            // SrNo16DecF3S1
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_SrNo16DecF3S1"))
                    SrNo16DecF3S1.AdvancedSearch.SearchValue = Get("x_SrNo16DecF3S1");
                else
                    SrNo16DecF3S1.AdvancedSearch.SearchValue = Get("SrNo16DecF3S1"); // Default Value // DN
            if (!Empty(SrNo16DecF3S1.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_SrNo16DecF3S1"))
                SrNo16DecF3S1.AdvancedSearch.SearchOperator = Get("z_SrNo16DecF3S1");

            // SrNo16DecF3S2
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_SrNo16DecF3S2"))
                    SrNo16DecF3S2.AdvancedSearch.SearchValue = Get("x_SrNo16DecF3S2");
                else
                    SrNo16DecF3S2.AdvancedSearch.SearchValue = Get("SrNo16DecF3S2"); // Default Value // DN
            if (!Empty(SrNo16DecF3S2.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_SrNo16DecF3S2"))
                SrNo16DecF3S2.AdvancedSearch.SearchOperator = Get("z_SrNo16DecF3S2");

            // SrNo16DecF4S1
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_SrNo16DecF4S1"))
                    SrNo16DecF4S1.AdvancedSearch.SearchValue = Get("x_SrNo16DecF4S1");
                else
                    SrNo16DecF4S1.AdvancedSearch.SearchValue = Get("SrNo16DecF4S1"); // Default Value // DN
            if (!Empty(SrNo16DecF4S1.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_SrNo16DecF4S1"))
                SrNo16DecF4S1.AdvancedSearch.SearchOperator = Get("z_SrNo16DecF4S1");

            // SrNo16DecF4S2
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_SrNo16DecF4S2"))
                    SrNo16DecF4S2.AdvancedSearch.SearchValue = Get("x_SrNo16DecF4S2");
                else
                    SrNo16DecF4S2.AdvancedSearch.SearchValue = Get("SrNo16DecF4S2"); // Default Value // DN
            if (!Empty(SrNo16DecF4S2.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_SrNo16DecF4S2"))
                SrNo16DecF4S2.AdvancedSearch.SearchOperator = Get("z_SrNo16DecF4S2");

            // SrNo16DecF4S3
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_SrNo16DecF4S3"))
                    SrNo16DecF4S3.AdvancedSearch.SearchValue = Get("x_SrNo16DecF4S3");
                else
                    SrNo16DecF4S3.AdvancedSearch.SearchValue = Get("SrNo16DecF4S3"); // Default Value // DN
            if (!Empty(SrNo16DecF4S3.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_SrNo16DecF4S3"))
                SrNo16DecF4S3.AdvancedSearch.SearchOperator = Get("z_SrNo16DecF4S3");

            // StudentAssementBookingURL
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_StudentAssementBookingURL"))
                    StudentAssementBookingURL.AdvancedSearch.SearchValue = Get("x_StudentAssementBookingURL");
                else
                    StudentAssementBookingURL.AdvancedSearch.SearchValue = Get("StudentAssementBookingURL"); // Default Value // DN
            if (!Empty(StudentAssementBookingURL.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_StudentAssementBookingURL"))
                StudentAssementBookingURL.AdvancedSearch.SearchOperator = Get("z_StudentAssementBookingURL");

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

            // Isdrivinglicense
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Isdrivinglicense"))
                    Isdrivinglicense.AdvancedSearch.SearchValue = Get("x_Isdrivinglicense");
                else
                    Isdrivinglicense.AdvancedSearch.SearchValue = Get("Isdrivinglicense"); // Default Value // DN
            if (!Empty(Isdrivinglicense.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Isdrivinglicense"))
                Isdrivinglicense.AdvancedSearch.SearchOperator = Get("z_Isdrivinglicense");

            // drivinglicensenumber
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_drivinglicensenumber"))
                    drivinglicensenumber.AdvancedSearch.SearchValue = Get("x_drivinglicensenumber");
                else
                    drivinglicensenumber.AdvancedSearch.SearchValue = Get("drivinglicensenumber"); // Default Value // DN
            if (!Empty(drivinglicensenumber.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_drivinglicensenumber"))
                drivinglicensenumber.AdvancedSearch.SearchOperator = Get("z_drivinglicensenumber");

            // Absher_Appointment_number
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Absher_Appointment_number"))
                    Absher_Appointment_number.AdvancedSearch.SearchValue = Get("x_Absher_Appointment_number");
                else
                    Absher_Appointment_number.AdvancedSearch.SearchValue = Get("Absher_Appointment_number"); // Default Value // DN
            if (!Empty(Absher_Appointment_number.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Absher_Appointment_number"))
                Absher_Appointment_number.AdvancedSearch.SearchOperator = Get("z_Absher_Appointment_number");

            // DataImportId
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_DataImportId"))
                    DataImportId.AdvancedSearch.SearchValue = Get("x_DataImportId");
                else
                    DataImportId.AdvancedSearch.SearchValue = Get("DataImportId"); // Default Value // DN
            if (!Empty(DataImportId.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_DataImportId"))
                DataImportId.AdvancedSearch.SearchOperator = Get("z_DataImportId");

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

            // Activated
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Activated"))
                    Activated.AdvancedSearch.SearchValue = Get("x_Activated");
                else
                    Activated.AdvancedSearch.SearchValue = Get("Activated"); // Default Value // DN
            if (!Empty(Activated.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Activated"))
                Activated.AdvancedSearch.SearchOperator = Get("z_Activated");

            // Absherphoto
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Absherphoto"))
                    Absherphoto.AdvancedSearch.SearchValue = Get("x_Absherphoto");
                else
                    Absherphoto.AdvancedSearch.SearchValue = Get("Absherphoto"); // Default Value // DN
            if (!Empty(Absherphoto.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Absherphoto"))
                Absherphoto.AdvancedSearch.SearchOperator = Get("z_Absherphoto");

            // Fingerprint
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Fingerprint"))
                    Fingerprint.AdvancedSearch.SearchValue = Get("x_Fingerprint");
                else
                    Fingerprint.AdvancedSearch.SearchValue = Get("Fingerprint"); // Default Value // DN
            if (!Empty(Fingerprint.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Fingerprint"))
                Fingerprint.AdvancedSearch.SearchOperator = Get("z_Fingerprint");

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

            // Hijri_Day
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Hijri_Day"))
                    Hijri_Day.AdvancedSearch.SearchValue = Get("x_Hijri_Day");
                else
                    Hijri_Day.AdvancedSearch.SearchValue = Get("Hijri_Day"); // Default Value // DN
            if (!Empty(Hijri_Day.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Hijri_Day"))
                Hijri_Day.AdvancedSearch.SearchOperator = Get("z_Hijri_Day");

            // Hijri_Month
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Hijri_Month"))
                    Hijri_Month.AdvancedSearch.SearchValue = Get("x_Hijri_Month");
                else
                    Hijri_Month.AdvancedSearch.SearchValue = Get("Hijri_Month"); // Default Value // DN
            if (!Empty(Hijri_Month.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Hijri_Month"))
                Hijri_Month.AdvancedSearch.SearchOperator = Get("z_Hijri_Month");

            // Hijri_Year
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Hijri_Year"))
                    Hijri_Year.AdvancedSearch.SearchValue = Get("x_Hijri_Year");
                else
                    Hijri_Year.AdvancedSearch.SearchValue = Get("Hijri_Year"); // Default Value // DN
            if (!Empty(Hijri_Year.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Hijri_Year"))
                Hijri_Year.AdvancedSearch.SearchOperator = Get("z_Hijri_Year");

            // Course_Price
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Course_Price"))
                    Course_Price.AdvancedSearch.SearchValue = Get("x_Course_Price");
                else
                    Course_Price.AdvancedSearch.SearchValue = Get("Course_Price"); // Default Value // DN
            if (!Empty(Course_Price.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Course_Price"))
                Course_Price.AdvancedSearch.SearchOperator = Get("z_Course_Price");

            // Vat_Tax_15
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Vat_Tax_15"))
                    Vat_Tax_15.AdvancedSearch.SearchValue = Get("x_Vat_Tax_15");
                else
                    Vat_Tax_15.AdvancedSearch.SearchValue = Get("Vat_Tax_15"); // Default Value // DN
            if (!Empty(Vat_Tax_15.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Vat_Tax_15"))
                Vat_Tax_15.AdvancedSearch.SearchOperator = Get("z_Vat_Tax_15");

            // dec_Balance
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dec_Balance"))
                    dec_Balance.AdvancedSearch.SearchValue = Get("x_dec_Balance");
                else
                    dec_Balance.AdvancedSearch.SearchValue = Get("dec_Balance"); // Default Value // DN
            if (!Empty(dec_Balance.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dec_Balance"))
                dec_Balance.AdvancedSearch.SearchOperator = Get("z_dec_Balance");

            // Total_Price
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Total_Price"))
                    Total_Price.AdvancedSearch.SearchValue = Get("x_Total_Price");
                else
                    Total_Price.AdvancedSearch.SearchValue = Get("Total_Price"); // Default Value // DN
            if (!Empty(Total_Price.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Total_Price"))
                Total_Price.AdvancedSearch.SearchOperator = Get("z_Total_Price");

            // Payment_Online
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Payment_Online"))
                    Payment_Online.AdvancedSearch.SearchValue = Get("x_Payment_Online");
                else
                    Payment_Online.AdvancedSearch.SearchValue = Get("Payment_Online"); // Default Value // DN
            if (!Empty(Payment_Online.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Payment_Online"))
                Payment_Online.AdvancedSearch.SearchOperator = Get("z_Payment_Online");

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

            // WaitingList
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_WaitingList"))
                    WaitingList.AdvancedSearch.SearchValue = Get("x_WaitingList");
                else
                    WaitingList.AdvancedSearch.SearchValue = Get("WaitingList"); // Default Value // DN
            if (!Empty(WaitingList.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_WaitingList"))
                WaitingList.AdvancedSearch.SearchOperator = Get("z_WaitingList");

            // Assessment_ID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Assessment_ID"))
                    Assessment_ID.AdvancedSearch.SearchValue = Get("x_Assessment_ID");
                else
                    Assessment_ID.AdvancedSearch.SearchValue = Get("Assessment_ID"); // Default Value // DN
            if (!Empty(Assessment_ID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Assessment_ID"))
                Assessment_ID.AdvancedSearch.SearchOperator = Get("z_Assessment_ID");
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
            int_Potential_Student_ID.CellCssStyle = "white-space: nowrap;";

            // int_Student_Id
            int_Student_Id.CellCssStyle = "white-space: nowrap;";

            // str_NationalID_Iqama

            // NationalID

            // str_First_Name

            // str_Middle_Name

            // str_Last_Name

            // str_Address1

            // str_Address2

            // int_State

            // str_City

            // str_Zip

            // int_Instructor

            // int_Driver

            // str_Home_Phone

            // str_Cell_Phone

            // str_Parent_Phone

            // str_Other_Phone

            // str_Email

            // str_ParentName

            // str_ParentEmail1
            str_ParentEmail1.CellCssStyle = "white-space: nowrap;";

            // str_ParentEmail2

            // str_Username

            // str_Password

            // str_DOB

            // int_DOB_Day

            // int_DOB_Month

            // int_DOB_Year

            // int_Age

            // int_Type

            // int_Wear_Glasses

            // int_Sex

            // str_DLPermit

            // dt_Date_PermitIssue

            // dt_Date_ExpirePermit

            // int_Hs_ID

            // str_Emergency_Contact_Name

            // str_Emergency_Contact_Phone

            // str_Emergency_Contact_Relation

            // str_Student_Notes

            // str_Driving_Notes

            // int_Location_Id

            // int_Permit_Number

            // Permit_Issue_Date

            // Permit_Expiry_Date

            // int_Status

            // int_Lead_Id

            // int_Activated_By

            // date_Activated

            // date_Created

            // date_Modified

            // date_Complete

            // int_Created_By

            // int_Modified_By

            // bit_IsDeleted

            // str_CardHolderName

            // str_CardHolderAddress

            // str_CardHolderCity

            // str_CardHolderZip

            // str_CardType

            // str_CardExpMonth

            // str_CardExpYear

            // str_CardNo

            // str_Certificate_No

            // str_AmountPaid

            // str_PermitValidated

            // strSMSNotification

            // strVoiceNotification

            // str_Weight

            // str_SpecialNeeds

            // str_MedicalConditions

            // bit_Verified_PIC_InSAW

            // bit_Permit_Waiver_Entered

            // bit_TermsConditions

            // bit_Disable_Self_Scheduling

            // int_EyeColor

            // int_HairColor

            // int_ColorBlind

            // int_HeightFeet

            // int_HeightInches

            // str_reference_code

            // dt_ParentClassAttendedDt

            // str_ParentClassAttendedLoc

            // dt_SiblingClassAttendedDt

            // str_SiblingClassAttendedLoc

            // bit_PoliciesAndProcedures

            // dt_CourseCompletionDt

            // dt_ExtensionDt

            // str_MedicalCondition

            // str_MajorCrossStreets

            // str_DriverEdCertNo

            // dt_DriverEdCertIssuedDt

            // str_BTWDriversEdCertNo

            // dt_BTWCertIssuedDt

            // str_OLDriversEdCertNo

            // dt_OLCertIssuedDt

            // str_height

            // dt_BTWCompletionDt

            // dt_CRCompletionDt

            // strTextBox5

            // strTextBox6

            // str_ApartmentNo

            // dt_PermitTestDate

            // str_OnlineDriverEdLogin

            // str_OnlineDriverEdPassword

            // bit_IsSMSEnabled

            // dt_SMSModified

            // str_confirmPassword

            // DE_Certificate

            // Discuss

            // int_UnlicensedSibling

            // int_YearSiblingIsEligible

            // BTW_Certificate

            // dt_DECertIssueDate

            // str_StudentSignature

            // str_ParentSignature

            // str_Last6DigitsOfParentDriversLicense

            // str_FACControl

            // Classroom_Status_Code

            // Laboratory_Status_Code

            // bit_EnrollmentForm

            // bit_ParentStudentContract

            // bit_ParentalAgreement

            // int_SF_GR_WA_HS

            // bit_DisableOnRMV

            // bit_UploadedToRMV

            // str_Mother_Name

            // str_Guardians_Name

            // str_Mother_Phone

            // bit_terms

            // int_Nationality

            // str_National_ID_en

            // str_National_ID_arabic

            // Quallification_Id

            // Job_Id

            // str_DOB_arabic

            // int_Language

            // strRefId

            // int_Program_Id

            // IsDrivingexperience

            // IsScheduleassessment

            // IsEnrollbyyourself

            // AssessmentTime

            // AssessmentDate

            // isAssessmentDone

            // AssessmentScore

            // dt_WrittenTestPassed

            // dt_RoadTestPassed

            // bit_Archive

            // ArchiveNotes

            // dtArchived

            // SrNo9Dec21

            // REGNNUMB

            // REGNLOCN

            // SrNo11DecF1S1

            // IsInterestedInTraining

            // StudentEncryptID

            // StudentConfirURL

            // SrNo15DecF1S2

            // SrNo15DecF1S3

            // SrNo16DecF2S2

            // SrNo16DecF2S3

            // SrNo16DecF3S1

            // SrNo16DecF3S2

            // SrNo16DecF4S1

            // SrNo16DecF4S2

            // SrNo16DecF4S3

            // StudentAssementBookingURL

            // intDrivinglicenseType

            // Isdrivinglicense

            // drivinglicensenumber

            // Absher_Appointment_number

            // DataImportId

            // date_Birth_Hijri

            // UserlevelID

            // Activated

            // Absherphoto

            // Fingerprint

            // Required_Program

            // Price

            // Hijri_Day

            // Hijri_Month

            // Hijri_Year

            // Course_Price

            // Vat_Tax_15

            // dec_Balance

            // Total_Price

            // Payment_Online
            Payment_Online.CellCssStyle = "white-space: nowrap;";

            // Institution

            // WaitingList

            // Assessment_ID

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

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";

                // str_First_Name
                str_First_Name.HrefValue = "";
                str_First_Name.TooltipValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";
                str_Last_Name.TooltipValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";
                str_Cell_Phone.TooltipValue = "";

                // Required_Program
                Required_Program.HrefValue = "";
                Required_Program.TooltipValue = "";

                // Price
                Price.HrefValue = "";
                Price.TooltipValue = "";

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
            } else if (RowType == RowType.Search) {
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

                // str_Last_Name
                str_Last_Name.SetupEditAttributes();
                if (!str_Last_Name.Raw)
                    str_Last_Name.AdvancedSearch.SearchValue = HtmlDecode(str_Last_Name.AdvancedSearch.SearchValue);
                str_Last_Name.EditValue = HtmlEncode(str_Last_Name.AdvancedSearch.SearchValue);
                str_Last_Name.PlaceHolder = RemoveHtml(str_Last_Name.Caption);

                // str_Cell_Phone
                str_Cell_Phone.SetupEditAttributes();
                if (!str_Cell_Phone.Raw)
                    str_Cell_Phone.AdvancedSearch.SearchValue = HtmlDecode(str_Cell_Phone.AdvancedSearch.SearchValue);
                str_Cell_Phone.EditValue = HtmlEncode(str_Cell_Phone.AdvancedSearch.SearchValue);
                str_Cell_Phone.PlaceHolder = RemoveHtml(str_Cell_Phone.Caption);

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

                // Payment_Online
                Payment_Online.SetupEditAttributes();
                if (!Payment_Online.Raw)
                    Payment_Online.AdvancedSearch.SearchValue = HtmlDecode(Payment_Online.AdvancedSearch.SearchValue);
                Payment_Online.EditValue = HtmlEncode(Payment_Online.AdvancedSearch.SearchValue);
                Payment_Online.PlaceHolder = RemoveHtml(Payment_Online.Caption);
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
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblPotentialStudentInfolist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblPotentialStudentInfolist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblPotentialStudentInfolist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
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
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblPotentialStudentInfolist\" data-ew-action=\"email\" data-custom=\"false\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
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
            item.Body = "<a class=\"btn btn-default ew-search-toggle" + searchToggleClass + "\" role=\"button\" title=\"" + Language.Phrase("SearchPanel") + "\" data-caption=\"" + Language.Phrase("SearchPanel") + "\" data-ew-action=\"search-toggle\" data-form=\"ftblPotentialStudentInfosrch\" aria-pressed=\"" + (searchToggleClass == " active" ? "true" : "false") + "\">" + Language.Phrase("SearchLink") + "</a>";
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
                item.Body = "<a class=\"btn btn-default ew-advanced-search\" title=\"" + Language.Phrase("AdvancedSearch", true) + "\" data-table=\"tblPotentialStudentInfo\" data-caption=\"" + Language.Phrase("AdvancedSearch", true) + "\" data-ew-action=\"modal\" data-url=\"" + AppPath("TblPotentialStudentInfoSearch") + "\" data-btn=\"SearchBtn\">" + Language.Phrase("AdvancedSearch", false) + "</a>";
            else
                item.Body = "<a class=\"btn btn-default ew-advanced-search\" title=\"" + Language.Phrase("AdvancedSearch", true) + "\" data-caption=\"" + Language.Phrase("AdvancedSearch", true) + "\" href=\"" + AppPath("TblPotentialStudentInfoSearch") + "\">" + Language.Phrase("AdvancedSearch", false) + "</a>";
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
