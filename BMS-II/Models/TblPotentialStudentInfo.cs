namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26
{
    /// <summary>
    /// tblPotentialStudentInfo
    /// </summary>
    [MaybeNull]
    public static TblPotentialStudentInfo tblPotentialStudentInfo
    {
        get => HttpData.Resolve<TblPotentialStudentInfo>("tblPotentialStudentInfo");
        set => HttpData["tblPotentialStudentInfo"] = value;
    }

    /// <summary>
    /// Table class for tblPotentialStudentInfo
    /// </summary>
    public class TblPotentialStudentInfo : DbTable, IQueryFactory
    {
        public int RowCount = 0; // DN

        public bool UseSessionForListSql = true;

        // Column CSS classes
        public string LeftColumnClass = "col-sm-2 col-form-label ew-label";

        public string RightColumnClass = "col-sm-10";

        public string OffsetColumnClass = "col-sm-10 offset-sm-2";

        public string TableLeftColumnClass = "w-col-2";

        // Ajax / Modal
        public bool UseAjaxActions = false;

        public bool ModalSearch = false;

        public bool ModalView = false;

        public bool ModalAdd = false;

        public bool ModalEdit = false;

        public bool ModalUpdate = false;

        public bool InlineDelete = false;

        public bool ModalGridAdd = false;

        public bool ModalGridEdit = false;

        public bool ModalMultiEdit = false;

        public readonly DbField<SqlDbType> int_Potential_Student_ID;

        public readonly DbField<SqlDbType> int_Student_Id;

        public readonly DbField<SqlDbType> str_NationalID_Iqama;

        public readonly DbField<SqlDbType> NationalID;

        public readonly DbField<SqlDbType> str_First_Name;

        public readonly DbField<SqlDbType> str_Middle_Name;

        public readonly DbField<SqlDbType> str_Last_Name;

        public readonly DbField<SqlDbType> str_Address1;

        public readonly DbField<SqlDbType> str_Address2;

        public readonly DbField<SqlDbType> int_State;

        public readonly DbField<SqlDbType> str_City;

        public readonly DbField<SqlDbType> str_Zip;

        public readonly DbField<SqlDbType> int_Instructor;

        public readonly DbField<SqlDbType> int_Driver;

        public readonly DbField<SqlDbType> str_Home_Phone;

        public readonly DbField<SqlDbType> str_Cell_Phone;

        public readonly DbField<SqlDbType> str_Parent_Phone;

        public readonly DbField<SqlDbType> str_Other_Phone;

        public readonly DbField<SqlDbType> str_Email;

        public readonly DbField<SqlDbType> str_ParentName;

        public readonly DbField<SqlDbType> str_ParentEmail1;

        public readonly DbField<SqlDbType> str_ParentEmail2;

        public readonly DbField<SqlDbType> str_Username;

        public readonly DbField<SqlDbType> str_Password;

        public readonly DbField<SqlDbType> str_DOB;

        public readonly DbField<SqlDbType> int_DOB_Day;

        public readonly DbField<SqlDbType> int_DOB_Month;

        public readonly DbField<SqlDbType> int_DOB_Year;

        public readonly DbField<SqlDbType> int_Age;

        public readonly DbField<SqlDbType> int_Type;

        public readonly DbField<SqlDbType> int_Wear_Glasses;

        public readonly DbField<SqlDbType> int_Sex;

        public readonly DbField<SqlDbType> str_DLPermit;

        public readonly DbField<SqlDbType> dt_Date_PermitIssue;

        public readonly DbField<SqlDbType> dt_Date_ExpirePermit;

        public readonly DbField<SqlDbType> int_Hs_ID;

        public readonly DbField<SqlDbType> str_Emergency_Contact_Name;

        public readonly DbField<SqlDbType> str_Emergency_Contact_Phone;

        public readonly DbField<SqlDbType> str_Emergency_Contact_Relation;

        public readonly DbField<SqlDbType> str_Student_Notes;

        public readonly DbField<SqlDbType> str_Driving_Notes;

        public readonly DbField<SqlDbType> int_Location_Id;

        public readonly DbField<SqlDbType> int_Permit_Number;

        public readonly DbField<SqlDbType> Permit_Issue_Date;

        public readonly DbField<SqlDbType> Permit_Expiry_Date;

        public readonly DbField<SqlDbType> int_Status;

        public readonly DbField<SqlDbType> int_Lead_Id;

        public readonly DbField<SqlDbType> int_Activated_By;

        public readonly DbField<SqlDbType> date_Activated;

        public readonly DbField<SqlDbType> date_Created;

        public readonly DbField<SqlDbType> date_Modified;

        public readonly DbField<SqlDbType> date_Complete;

        public readonly DbField<SqlDbType> int_Created_By;

        public readonly DbField<SqlDbType> int_Modified_By;

        public readonly DbField<SqlDbType> bit_IsDeleted;

        public readonly DbField<SqlDbType> str_CardHolderName;

        public readonly DbField<SqlDbType> str_CardHolderAddress;

        public readonly DbField<SqlDbType> str_CardHolderCity;

        public readonly DbField<SqlDbType> str_CardHolderZip;

        public readonly DbField<SqlDbType> str_CardType;

        public readonly DbField<SqlDbType> str_CardExpMonth;

        public readonly DbField<SqlDbType> str_CardExpYear;

        public readonly DbField<SqlDbType> str_CardNo;

        public readonly DbField<SqlDbType> str_Certificate_No;

        public readonly DbField<SqlDbType> str_AmountPaid;

        public readonly DbField<SqlDbType> str_PermitValidated;

        public readonly DbField<SqlDbType> strSMSNotification;

        public readonly DbField<SqlDbType> strVoiceNotification;

        public readonly DbField<SqlDbType> str_Weight;

        public readonly DbField<SqlDbType> str_SpecialNeeds;

        public readonly DbField<SqlDbType> str_MedicalConditions;

        public readonly DbField<SqlDbType> bit_Verified_PIC_InSAW;

        public readonly DbField<SqlDbType> bit_Permit_Waiver_Entered;

        public readonly DbField<SqlDbType> bit_TermsConditions;

        public readonly DbField<SqlDbType> bit_Disable_Self_Scheduling;

        public readonly DbField<SqlDbType> int_EyeColor;

        public readonly DbField<SqlDbType> int_HairColor;

        public readonly DbField<SqlDbType> int_ColorBlind;

        public readonly DbField<SqlDbType> int_HeightFeet;

        public readonly DbField<SqlDbType> int_HeightInches;

        public readonly DbField<SqlDbType> str_reference_code;

        public readonly DbField<SqlDbType> dt_ParentClassAttendedDt;

        public readonly DbField<SqlDbType> str_ParentClassAttendedLoc;

        public readonly DbField<SqlDbType> dt_SiblingClassAttendedDt;

        public readonly DbField<SqlDbType> str_SiblingClassAttendedLoc;

        public readonly DbField<SqlDbType> bit_PoliciesAndProcedures;

        public readonly DbField<SqlDbType> dt_CourseCompletionDt;

        public readonly DbField<SqlDbType> dt_ExtensionDt;

        public readonly DbField<SqlDbType> str_MedicalCondition;

        public readonly DbField<SqlDbType> str_MajorCrossStreets;

        public readonly DbField<SqlDbType> str_DriverEdCertNo;

        public readonly DbField<SqlDbType> dt_DriverEdCertIssuedDt;

        public readonly DbField<SqlDbType> str_BTWDriversEdCertNo;

        public readonly DbField<SqlDbType> dt_BTWCertIssuedDt;

        public readonly DbField<SqlDbType> str_OLDriversEdCertNo;

        public readonly DbField<SqlDbType> dt_OLCertIssuedDt;

        public readonly DbField<SqlDbType> str_height;

        public readonly DbField<SqlDbType> dt_BTWCompletionDt;

        public readonly DbField<SqlDbType> dt_CRCompletionDt;

        public readonly DbField<SqlDbType> strTextBox5;

        public readonly DbField<SqlDbType> strTextBox6;

        public readonly DbField<SqlDbType> str_ApartmentNo;

        public readonly DbField<SqlDbType> dt_PermitTestDate;

        public readonly DbField<SqlDbType> str_OnlineDriverEdLogin;

        public readonly DbField<SqlDbType> str_OnlineDriverEdPassword;

        public readonly DbField<SqlDbType> bit_IsSMSEnabled;

        public readonly DbField<SqlDbType> dt_SMSModified;

        public readonly DbField<SqlDbType> str_confirmPassword;

        public readonly DbField<SqlDbType> DE_Certificate;

        public readonly DbField<SqlDbType> Discuss;

        public readonly DbField<SqlDbType> int_UnlicensedSibling;

        public readonly DbField<SqlDbType> int_YearSiblingIsEligible;

        public readonly DbField<SqlDbType> BTW_Certificate;

        public readonly DbField<SqlDbType> dt_DECertIssueDate;

        public readonly DbField<SqlDbType> str_StudentSignature;

        public readonly DbField<SqlDbType> str_ParentSignature;

        public readonly DbField<SqlDbType> str_Last6DigitsOfParentDriversLicense;

        public readonly DbField<SqlDbType> str_FACControl;

        public readonly DbField<SqlDbType> Classroom_Status_Code;

        public readonly DbField<SqlDbType> Laboratory_Status_Code;

        public readonly DbField<SqlDbType> bit_EnrollmentForm;

        public readonly DbField<SqlDbType> bit_ParentStudentContract;

        public readonly DbField<SqlDbType> bit_ParentalAgreement;

        public readonly DbField<SqlDbType> int_SF_GR_WA_HS;

        public readonly DbField<SqlDbType> bit_DisableOnRMV;

        public readonly DbField<SqlDbType> bit_UploadedToRMV;

        public readonly DbField<SqlDbType> str_Mother_Name;

        public readonly DbField<SqlDbType> str_Guardians_Name;

        public readonly DbField<SqlDbType> str_Mother_Phone;

        public readonly DbField<SqlDbType> bit_terms;

        public readonly DbField<SqlDbType> int_Nationality;

        public readonly DbField<SqlDbType> str_National_ID_en;

        public readonly DbField<SqlDbType> str_National_ID_arabic;

        public readonly DbField<SqlDbType> Quallification_Id;

        public readonly DbField<SqlDbType> Job_Id;

        public readonly DbField<SqlDbType> str_DOB_arabic;

        public readonly DbField<SqlDbType> int_Language;

        public readonly DbField<SqlDbType> strRefId;

        public readonly DbField<SqlDbType> int_Program_Id;

        public readonly DbField<SqlDbType> IsDrivingexperience;

        public readonly DbField<SqlDbType> IsScheduleassessment;

        public readonly DbField<SqlDbType> IsEnrollbyyourself;

        public readonly DbField<SqlDbType> AssessmentTime;

        public readonly DbField<SqlDbType> AssessmentDate;

        public readonly DbField<SqlDbType> isAssessmentDone;

        public readonly DbField<SqlDbType> AssessmentScore;

        public readonly DbField<SqlDbType> dt_WrittenTestPassed;

        public readonly DbField<SqlDbType> dt_RoadTestPassed;

        public readonly DbField<SqlDbType> bit_Archive;

        public readonly DbField<SqlDbType> ArchiveNotes;

        public readonly DbField<SqlDbType> dtArchived;

        public readonly DbField<SqlDbType> SrNo9Dec21;

        public readonly DbField<SqlDbType> REGNNUMB;

        public readonly DbField<SqlDbType> REGNLOCN;

        public readonly DbField<SqlDbType> SrNo11DecF1S1;

        public readonly DbField<SqlDbType> IsInterestedInTraining;

        public readonly DbField<SqlDbType> StudentEncryptID;

        public readonly DbField<SqlDbType> StudentConfirURL;

        public readonly DbField<SqlDbType> SrNo15DecF1S2;

        public readonly DbField<SqlDbType> SrNo15DecF1S3;

        public readonly DbField<SqlDbType> SrNo16DecF2S2;

        public readonly DbField<SqlDbType> SrNo16DecF2S3;

        public readonly DbField<SqlDbType> SrNo16DecF3S1;

        public readonly DbField<SqlDbType> SrNo16DecF3S2;

        public readonly DbField<SqlDbType> SrNo16DecF4S1;

        public readonly DbField<SqlDbType> SrNo16DecF4S2;

        public readonly DbField<SqlDbType> SrNo16DecF4S3;

        public readonly DbField<SqlDbType> StudentAssementBookingURL;

        public readonly DbField<SqlDbType> intDrivinglicenseType;

        public readonly DbField<SqlDbType> Isdrivinglicense;

        public readonly DbField<SqlDbType> drivinglicensenumber;

        public readonly DbField<SqlDbType> Absher_Appointment_number;

        public readonly DbField<SqlDbType> DataImportId;

        public readonly DbField<SqlDbType> date_Birth_Hijri;

        public readonly DbField<SqlDbType> UserlevelID;

        public readonly DbField<SqlDbType> Activated;

        public readonly DbField<SqlDbType> Absherphoto;

        public readonly DbField<SqlDbType> Fingerprint;

        public readonly DbField<SqlDbType> Required_Program;

        public readonly DbField<SqlDbType> Price;

        public readonly DbField<SqlDbType> Hijri_Day;

        public readonly DbField<SqlDbType> Hijri_Month;

        public readonly DbField<SqlDbType> Hijri_Year;

        public readonly DbField<SqlDbType> Course_Price;

        public readonly DbField<SqlDbType> Vat_Tax_15;

        public readonly DbField<SqlDbType> dec_Balance;

        public readonly DbField<SqlDbType> Total_Price;

        public readonly DbField<SqlDbType> Payment_Online;

        public readonly DbField<SqlDbType> Institution;

        public readonly DbField<SqlDbType> WaitingList;

        public readonly DbField<SqlDbType> Assessment_ID;

        // Constructor
        public TblPotentialStudentInfo()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "tblPotentialStudentInfo";
            Name = "tblPotentialStudentInfo";
            Type = "TABLE";
            UpdateTable = "dbo.tblPotentialStudentInfo"; // Update Table
            DbId = "DB"; // DN
            ExportAll = true;
            ExportPageBreakCount = 0; // Page break per every n record (PDF only)
            ExportPageOrientation = "portrait"; // Page orientation (PDF only)
            ExportPageSize = "a4"; // Page size (PDF only)
            ExportColumnWidths = new float[] { }; // Column widths (PDF only) // DN
            ExportExcelPageOrientation = "Portrait"; // Page orientation (EPPlus only)
            ExportExcelPageSize = "A4"; // Page size (EPPlus only)
            ExportWordPageOrientation = "Portrait"; // Page orientation (Word only)
            DetailAdd = false; // Allow detail add
            DetailEdit = false; // Allow detail edit
            DetailView = false; // Allow detail view
            ShowMultipleDetails = false; // Show multiple details
            GridAddRowCount = 5;
            AllowAddDeleteRow = true; // Allow add/delete row
            UseAjaxActions = UseAjaxActions || Config.UseAjaxActions;

            // int_Potential_Student_ID
            int_Potential_Student_ID = new(this, "x_int_Potential_Student_ID", 3, SqlDbType.Int)
            {
                Name = "int_Potential_Student_ID",
                Expression = "[int_Potential_Student_ID]",
                BasicSearchExpression = "CAST([int_Potential_Student_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Potential_Student_ID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "NO",
                InputTextType = "text",
                IsAutoIncrement = true, // Autoincrement field
                IsPrimaryKey = true, // Primary key field
                Nullable = false, // NOT NULL field
                Sortable = false, // Allow sort
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Potential_Student_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Potential_Student_ID", int_Potential_Student_ID);

            // int_Student_Id
            int_Student_Id = new(this, "x_int_Student_Id", 3, SqlDbType.Int)
            {
                Name = "int_Student_Id",
                Expression = "[int_Student_Id]",
                BasicSearchExpression = "CAST([int_Student_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Student_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                Sortable = false, // Allow sort
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Student_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Student_Id", int_Student_Id);

            // str_NationalID_Iqama
            str_NationalID_Iqama = new(this, "x_str_NationalID_Iqama", 202, SqlDbType.NVarChar)
            {
                Name = "str_NationalID_Iqama",
                Expression = "[str_NationalID_Iqama]",
                BasicSearchExpression = "[str_NationalID_Iqama]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_NationalID_Iqama]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_NationalID_Iqama", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_NationalID_Iqama", str_NationalID_Iqama);

            // NationalID
            NationalID = new(this, "x_NationalID", 20, SqlDbType.BigInt)
            {
                Name = "NationalID",
                Expression = "[NationalID]",
                UseBasicSearch = true,
                BasicSearchExpression = "CAST([NationalID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[NationalID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                IsForeignKey = true, // Foreign key field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "NationalID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("NationalID", NationalID);

            // str_First_Name
            str_First_Name = new(this, "x_str_First_Name", 202, SqlDbType.NVarChar)
            {
                Name = "str_First_Name",
                Expression = "[str_First_Name]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_First_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_First_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_First_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_First_Name", str_First_Name);

            // str_Middle_Name
            str_Middle_Name = new(this, "x_str_Middle_Name", 202, SqlDbType.NVarChar)
            {
                Name = "str_Middle_Name",
                Expression = "[str_Middle_Name]",
                BasicSearchExpression = "[str_Middle_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Middle_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Middle_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Middle_Name", str_Middle_Name);

            // str_Last_Name
            str_Last_Name = new(this, "x_str_Last_Name", 202, SqlDbType.NVarChar)
            {
                Name = "str_Last_Name",
                Expression = "[str_Last_Name]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Last_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Last_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Last_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Last_Name", str_Last_Name);

            // str_Address1
            str_Address1 = new(this, "x_str_Address1", 202, SqlDbType.NVarChar)
            {
                Name = "str_Address1",
                Expression = "[str_Address1]",
                BasicSearchExpression = "[str_Address1]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Address1]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Address1", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Address1", str_Address1);

            // str_Address2
            str_Address2 = new(this, "x_str_Address2", 202, SqlDbType.NVarChar)
            {
                Name = "str_Address2",
                Expression = "[str_Address2]",
                BasicSearchExpression = "[str_Address2]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Address2]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Address2", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Address2", str_Address2);

            // int_State
            int_State = new(this, "x_int_State", 3, SqlDbType.Int)
            {
                Name = "int_State",
                Expression = "[int_State]",
                BasicSearchExpression = "CAST([int_State] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_State]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "SELECT",
                InputTextType = "text",
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_State", "CustomMsg"),
                IsUpload = false
            };
            int_State.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(int_State, "Cities", false, "Province_ID", new List<string> { "Province", "", "", "" }, "", "", new List<string> { }, new List<string> { "x_str_City" }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "[Province]"),
                "en-US" => new Lookup<DbField>(int_State, "Cities", false, "Province_ID", new List<string> { "Province", "", "", "" }, "", "", new List<string> { }, new List<string> { "x_str_City" }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "[Province]"),
                _ => new Lookup<DbField>(int_State, "Cities", false, "Province_ID", new List<string> { "Province", "", "", "" }, "", "", new List<string> { }, new List<string> { "x_str_City" }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "[Province]")
            };
            Fields.Add("int_State", int_State);

            // str_City
            str_City = new(this, "x_str_City", 202, SqlDbType.NVarChar)
            {
                Name = "str_City",
                Expression = "[str_City]",
                BasicSearchExpression = "[str_City]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_City]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "SELECT",
                InputTextType = "text",
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_City", "CustomMsg"),
                IsUpload = false
            };
            str_City.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(str_City, "Cities", false, "City", new List<string> { "City", "", "", "" }, "", "", new List<string> { "x_int_State" }, new List<string> { }, new List<string> { "Province_ID" }, new List<string> { "x_Province_ID" }, new List<string> { }, new List<string> { }, "", "", "[City]"),
                "en-US" => new Lookup<DbField>(str_City, "Cities", false, "City", new List<string> { "City", "", "", "" }, "", "", new List<string> { "x_int_State" }, new List<string> { }, new List<string> { "Province_ID" }, new List<string> { "x_Province_ID" }, new List<string> { }, new List<string> { }, "", "", "[City]"),
                _ => new Lookup<DbField>(str_City, "Cities", false, "City", new List<string> { "City", "", "", "" }, "", "", new List<string> { "x_int_State" }, new List<string> { }, new List<string> { "Province_ID" }, new List<string> { "x_Province_ID" }, new List<string> { }, new List<string> { }, "", "", "[City]")
            };
            Fields.Add("str_City", str_City);

            // str_Zip
            str_Zip = new(this, "x_str_Zip", 202, SqlDbType.NVarChar)
            {
                Name = "str_Zip",
                Expression = "[str_Zip]",
                BasicSearchExpression = "[str_Zip]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Zip]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Zip", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Zip", str_Zip);

            // int_Instructor
            int_Instructor = new(this, "x_int_Instructor", 131, SqlDbType.Decimal)
            {
                Name = "int_Instructor",
                Expression = "[int_Instructor]",
                BasicSearchExpression = "CAST([int_Instructor] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Instructor]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "SELECT",
                InputTextType = "text",
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new() { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Instructor", "CustomMsg"),
                IsUpload = false
            };
            int_Instructor.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(int_Instructor, "tblStaff", false, "int_Staff_Id", new List<string> { "str_Full_Name", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "[str_Full_Name]"),
                "en-US" => new Lookup<DbField>(int_Instructor, "tblStaff", false, "int_Staff_Id", new List<string> { "str_Full_Name", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "[str_Full_Name]"),
                _ => new Lookup<DbField>(int_Instructor, "tblStaff", false, "int_Staff_Id", new List<string> { "str_Full_Name", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "[str_Full_Name]")
            };
            Fields.Add("int_Instructor", int_Instructor);

            // int_Driver
            int_Driver = new(this, "x_int_Driver", 131, SqlDbType.Decimal)
            {
                Name = "int_Driver",
                Expression = "[int_Driver]",
                BasicSearchExpression = "CAST([int_Driver] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Driver]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Driver", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Driver", int_Driver);

            // str_Home_Phone
            str_Home_Phone = new(this, "x_str_Home_Phone", 200, SqlDbType.VarChar)
            {
                Name = "str_Home_Phone",
                Expression = "[str_Home_Phone]",
                BasicSearchExpression = "[str_Home_Phone]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Home_Phone]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Home_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Home_Phone", str_Home_Phone);

            // str_Cell_Phone
            str_Cell_Phone = new(this, "x_str_Cell_Phone", 200, SqlDbType.VarChar)
            {
                Name = "str_Cell_Phone",
                Expression = "[str_Cell_Phone]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Cell_Phone]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Cell_Phone]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Required = true, // Required field
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Cell_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Cell_Phone", str_Cell_Phone);

            // str_Parent_Phone
            str_Parent_Phone = new(this, "x_str_Parent_Phone", 200, SqlDbType.VarChar)
            {
                Name = "str_Parent_Phone",
                Expression = "[str_Parent_Phone]",
                BasicSearchExpression = "[str_Parent_Phone]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Parent_Phone]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Parent_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Parent_Phone", str_Parent_Phone);

            // str_Other_Phone
            str_Other_Phone = new(this, "x_str_Other_Phone", 200, SqlDbType.VarChar)
            {
                Name = "str_Other_Phone",
                Expression = "[str_Other_Phone]",
                BasicSearchExpression = "[str_Other_Phone]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Other_Phone]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Other_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Other_Phone", str_Other_Phone);

            // str_Email
            str_Email = new(this, "x_str_Email", 202, SqlDbType.NVarChar)
            {
                Name = "str_Email",
                Expression = "[str_Email]",
                BasicSearchExpression = "[str_Email]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Email]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Email", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Email", str_Email);

            // str_ParentName
            str_ParentName = new(this, "x_str_ParentName", 202, SqlDbType.NVarChar)
            {
                Name = "str_ParentName",
                Expression = "[str_ParentName]",
                BasicSearchExpression = "[str_ParentName]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_ParentName]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_ParentName", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_ParentName", str_ParentName);

            // str_ParentEmail1
            str_ParentEmail1 = new(this, "x_str_ParentEmail1", 202, SqlDbType.NVarChar)
            {
                Name = "str_ParentEmail1",
                Expression = "[str_ParentEmail1]",
                BasicSearchExpression = "[str_ParentEmail1]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_ParentEmail1]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_ParentEmail1", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_ParentEmail1", str_ParentEmail1);

            // str_ParentEmail2
            str_ParentEmail2 = new(this, "x_str_ParentEmail2", 202, SqlDbType.NVarChar)
            {
                Name = "str_ParentEmail2",
                Expression = "[str_ParentEmail2]",
                BasicSearchExpression = "[str_ParentEmail2]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_ParentEmail2]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_ParentEmail2", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_ParentEmail2", str_ParentEmail2);

            // str_Username
            str_Username = new(this, "x_str_Username", 202, SqlDbType.NVarChar)
            {
                Name = "str_Username",
                Expression = "[str_Username]",
                BasicSearchExpression = "[str_Username]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Username]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Username", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Username", str_Username);

            // str_Password
            str_Password = new(this, "x_str_Password", 202, SqlDbType.NVarChar)
            {
                Name = "str_Password",
                Expression = "[str_Password]",
                BasicSearchExpression = "[str_Password]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Password]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Password", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Password", str_Password);

            // str_DOB
            str_DOB = new(this, "x_str_DOB", 135, SqlDbType.DateTime)
            {
                Name = "str_DOB",
                Expression = "[str_DOB]",
                BasicSearchExpression = CastDateFieldForLike("[str_DOB]", 2, "DB"),
                DateTimeFormat = 2,
                VirtualExpression = "[str_DOB]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", DateFormat(2)),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_DOB", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_DOB", str_DOB);

            // int_DOB_Day
            int_DOB_Day = new(this, "x_int_DOB_Day", 3, SqlDbType.Int)
            {
                Name = "int_DOB_Day",
                Expression = "[int_DOB_Day]",
                BasicSearchExpression = "CAST([int_DOB_Day] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_DOB_Day]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_DOB_Day", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_DOB_Day", int_DOB_Day);

            // int_DOB_Month
            int_DOB_Month = new(this, "x_int_DOB_Month", 3, SqlDbType.Int)
            {
                Name = "int_DOB_Month",
                Expression = "[int_DOB_Month]",
                BasicSearchExpression = "CAST([int_DOB_Month] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_DOB_Month]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_DOB_Month", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_DOB_Month", int_DOB_Month);

            // int_DOB_Year
            int_DOB_Year = new(this, "x_int_DOB_Year", 3, SqlDbType.Int)
            {
                Name = "int_DOB_Year",
                Expression = "[int_DOB_Year]",
                BasicSearchExpression = "CAST([int_DOB_Year] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_DOB_Year]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_DOB_Year", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_DOB_Year", int_DOB_Year);

            // int_Age
            int_Age = new(this, "x_int_Age", 3, SqlDbType.Int)
            {
                Name = "int_Age",
                Expression = "[int_Age]",
                BasicSearchExpression = "CAST([int_Age] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Age]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Age", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Age", int_Age);

            // int_Type
            int_Type = new(this, "x_int_Type", 3, SqlDbType.Int)
            {
                Name = "int_Type",
                Expression = "[int_Type]",
                BasicSearchExpression = "CAST([int_Type] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Type]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Type", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Type", int_Type);

            // int_Wear_Glasses
            int_Wear_Glasses = new(this, "x_int_Wear_Glasses", 3, SqlDbType.Int)
            {
                Name = "int_Wear_Glasses",
                Expression = "[int_Wear_Glasses]",
                BasicSearchExpression = "CAST([int_Wear_Glasses] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Wear_Glasses]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Wear_Glasses", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Wear_Glasses", int_Wear_Glasses);

            // int_Sex
            int_Sex = new(this, "x_int_Sex", 3, SqlDbType.Int)
            {
                Name = "int_Sex",
                Expression = "[int_Sex]",
                BasicSearchExpression = "CAST([int_Sex] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Sex]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "SELECT",
                InputTextType = "text",
                Required = true, // Required field
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                OptionCount = 2,
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Sex", "CustomMsg"),
                IsUpload = false
            };
            int_Sex.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(int_Sex, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(int_Sex, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(int_Sex, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("int_Sex", int_Sex);

            // str_DLPermit
            str_DLPermit = new(this, "x_str_DLPermit", 202, SqlDbType.NVarChar)
            {
                Name = "str_DLPermit",
                Expression = "[str_DLPermit]",
                BasicSearchExpression = "[str_DLPermit]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_DLPermit]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_DLPermit", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_DLPermit", str_DLPermit);

            // dt_Date_PermitIssue
            dt_Date_PermitIssue = new(this, "x_dt_Date_PermitIssue", 135, SqlDbType.DateTime)
            {
                Name = "dt_Date_PermitIssue",
                Expression = "[dt_Date_PermitIssue]",
                BasicSearchExpression = CastDateFieldForLike("[dt_Date_PermitIssue]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_Date_PermitIssue]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dt_Date_PermitIssue", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_Date_PermitIssue", dt_Date_PermitIssue);

            // dt_Date_ExpirePermit
            dt_Date_ExpirePermit = new(this, "x_dt_Date_ExpirePermit", 135, SqlDbType.DateTime)
            {
                Name = "dt_Date_ExpirePermit",
                Expression = "[dt_Date_ExpirePermit]",
                BasicSearchExpression = CastDateFieldForLike("[dt_Date_ExpirePermit]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_Date_ExpirePermit]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dt_Date_ExpirePermit", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_Date_ExpirePermit", dt_Date_ExpirePermit);

            // int_Hs_ID
            int_Hs_ID = new(this, "x_int_Hs_ID", 3, SqlDbType.Int)
            {
                Name = "int_Hs_ID",
                Expression = "[int_Hs_ID]",
                BasicSearchExpression = "CAST([int_Hs_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Hs_ID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Hs_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Hs_ID", int_Hs_ID);

            // str_Emergency_Contact_Name
            str_Emergency_Contact_Name = new(this, "x_str_Emergency_Contact_Name", 202, SqlDbType.NVarChar)
            {
                Name = "str_Emergency_Contact_Name",
                Expression = "[str_Emergency_Contact_Name]",
                BasicSearchExpression = "[str_Emergency_Contact_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Emergency_Contact_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Emergency_Contact_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Emergency_Contact_Name", str_Emergency_Contact_Name);

            // str_Emergency_Contact_Phone
            str_Emergency_Contact_Phone = new(this, "x_str_Emergency_Contact_Phone", 200, SqlDbType.VarChar)
            {
                Name = "str_Emergency_Contact_Phone",
                Expression = "[str_Emergency_Contact_Phone]",
                BasicSearchExpression = "[str_Emergency_Contact_Phone]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Emergency_Contact_Phone]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Emergency_Contact_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Emergency_Contact_Phone", str_Emergency_Contact_Phone);

            // str_Emergency_Contact_Relation
            str_Emergency_Contact_Relation = new(this, "x_str_Emergency_Contact_Relation", 202, SqlDbType.NVarChar)
            {
                Name = "str_Emergency_Contact_Relation",
                Expression = "[str_Emergency_Contact_Relation]",
                BasicSearchExpression = "[str_Emergency_Contact_Relation]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Emergency_Contact_Relation]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Emergency_Contact_Relation", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Emergency_Contact_Relation", str_Emergency_Contact_Relation);

            // str_Student_Notes
            str_Student_Notes = new(this, "x_str_Student_Notes", 203, SqlDbType.NText)
            {
                Name = "str_Student_Notes",
                Expression = "[str_Student_Notes]",
                BasicSearchExpression = "[str_Student_Notes]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Student_Notes]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Student_Notes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Student_Notes", str_Student_Notes);

            // str_Driving_Notes
            str_Driving_Notes = new(this, "x_str_Driving_Notes", 202, SqlDbType.NVarChar)
            {
                Name = "str_Driving_Notes",
                Expression = "[str_Driving_Notes]",
                BasicSearchExpression = "[str_Driving_Notes]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Driving_Notes]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Driving_Notes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Driving_Notes", str_Driving_Notes);

            // int_Location_Id
            int_Location_Id = new(this, "x_int_Location_Id", 3, SqlDbType.Int)
            {
                Name = "int_Location_Id",
                Expression = "[int_Location_Id]",
                BasicSearchExpression = "CAST([int_Location_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Location_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "SELECT",
                InputTextType = "text",
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Location_Id", "CustomMsg"),
                IsUpload = false
            };
            int_Location_Id.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(int_Location_Id, "tblLocation", false, "int_Location_Id", new List<string> { "str_Name", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "[str_Name]"),
                "en-US" => new Lookup<DbField>(int_Location_Id, "tblLocation", false, "int_Location_Id", new List<string> { "str_Name", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "[str_Name]"),
                _ => new Lookup<DbField>(int_Location_Id, "tblLocation", false, "int_Location_Id", new List<string> { "str_Name", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "[str_Name]")
            };
            Fields.Add("int_Location_Id", int_Location_Id);

            // int_Permit_Number
            int_Permit_Number = new(this, "x_int_Permit_Number", 202, SqlDbType.NVarChar)
            {
                Name = "int_Permit_Number",
                Expression = "[int_Permit_Number]",
                BasicSearchExpression = "[int_Permit_Number]",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Permit_Number]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Permit_Number", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Permit_Number", int_Permit_Number);

            // Permit_Issue_Date
            Permit_Issue_Date = new(this, "x_Permit_Issue_Date", 200, SqlDbType.VarChar)
            {
                Name = "Permit_Issue_Date",
                Expression = "[Permit_Issue_Date]",
                BasicSearchExpression = "[Permit_Issue_Date]",
                DateTimeFormat = -1,
                VirtualExpression = "[Permit_Issue_Date]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Permit_Issue_Date", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Permit_Issue_Date", Permit_Issue_Date);

            // Permit_Expiry_Date
            Permit_Expiry_Date = new(this, "x_Permit_Expiry_Date", 135, SqlDbType.DateTime)
            {
                Name = "Permit_Expiry_Date",
                Expression = "[Permit_Expiry_Date]",
                BasicSearchExpression = CastDateFieldForLike("[Permit_Expiry_Date]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[Permit_Expiry_Date]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Permit_Expiry_Date", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Permit_Expiry_Date", Permit_Expiry_Date);

            // int_Status
            int_Status = new(this, "x_int_Status", 3, SqlDbType.Int)
            {
                Name = "int_Status",
                Expression = "[int_Status]",
                BasicSearchExpression = "CAST([int_Status] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Status]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Status", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Status", int_Status);

            // int_Lead_Id
            int_Lead_Id = new(this, "x_int_Lead_Id", 131, SqlDbType.Decimal)
            {
                Name = "int_Lead_Id",
                Expression = "[int_Lead_Id]",
                BasicSearchExpression = "CAST([int_Lead_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Lead_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Lead_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Lead_Id", int_Lead_Id);

            // int_Activated_By
            int_Activated_By = new(this, "x_int_Activated_By", 131, SqlDbType.Decimal)
            {
                Name = "int_Activated_By",
                Expression = "[int_Activated_By]",
                BasicSearchExpression = "CAST([int_Activated_By] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Activated_By]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Activated_By", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Activated_By", int_Activated_By);

            // date_Activated
            date_Activated = new(this, "x_date_Activated", 135, SqlDbType.DateTime)
            {
                Name = "date_Activated",
                Expression = "[date_Activated]",
                BasicSearchExpression = CastDateFieldForLike("[date_Activated]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[date_Activated]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "date_Activated", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Activated", date_Activated);

            // date_Created
            date_Created = new(this, "x_date_Created", 135, SqlDbType.DateTime)
            {
                Name = "date_Created",
                Expression = "[date_Created]",
                BasicSearchExpression = CastDateFieldForLike("[date_Created]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[date_Created]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "date_Created", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Created", date_Created);

            // date_Modified
            date_Modified = new(this, "x_date_Modified", 135, SqlDbType.DateTime)
            {
                Name = "date_Modified",
                Expression = "[date_Modified]",
                BasicSearchExpression = CastDateFieldForLike("[date_Modified]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[date_Modified]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "date_Modified", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Modified", date_Modified);

            // date_Complete
            date_Complete = new(this, "x_date_Complete", 135, SqlDbType.DateTime)
            {
                Name = "date_Complete",
                Expression = "[date_Complete]",
                BasicSearchExpression = CastDateFieldForLike("[date_Complete]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[date_Complete]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "date_Complete", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Complete", date_Complete);

            // int_Created_By
            int_Created_By = new(this, "x_int_Created_By", 3, SqlDbType.Int)
            {
                Name = "int_Created_By",
                Expression = "[int_Created_By]",
                BasicSearchExpression = "CAST([int_Created_By] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Created_By]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Created_By", "CustomMsg"),
                IsUpload = false
            };
            int_Created_By.GetDefault = () => 1;
            Fields.Add("int_Created_By", int_Created_By);

            // int_Modified_By
            int_Modified_By = new(this, "x_int_Modified_By", 3, SqlDbType.Int)
            {
                Name = "int_Modified_By",
                Expression = "[int_Modified_By]",
                BasicSearchExpression = "CAST([int_Modified_By] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Modified_By]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Modified_By", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Modified_By", int_Modified_By);

            // bit_IsDeleted
            bit_IsDeleted = new(this, "x_bit_IsDeleted", 11, SqlDbType.Bit)
            {
                Name = "bit_IsDeleted",
                Expression = "[bit_IsDeleted]",
                BasicSearchExpression = "[bit_IsDeleted]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_IsDeleted]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "bit_IsDeleted", "CustomMsg"),
                IsUpload = false
            };
            bit_IsDeleted.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(bit_IsDeleted, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsDeleted, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(bit_IsDeleted, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            bit_IsDeleted.GetDefault = () => 0;
            Fields.Add("bit_IsDeleted", bit_IsDeleted);

            // str_CardHolderName
            str_CardHolderName = new(this, "x_str_CardHolderName", 202, SqlDbType.NVarChar)
            {
                Name = "str_CardHolderName",
                Expression = "[str_CardHolderName]",
                BasicSearchExpression = "[str_CardHolderName]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CardHolderName]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_CardHolderName", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CardHolderName", str_CardHolderName);

            // str_CardHolderAddress
            str_CardHolderAddress = new(this, "x_str_CardHolderAddress", 202, SqlDbType.NVarChar)
            {
                Name = "str_CardHolderAddress",
                Expression = "[str_CardHolderAddress]",
                BasicSearchExpression = "[str_CardHolderAddress]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CardHolderAddress]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_CardHolderAddress", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CardHolderAddress", str_CardHolderAddress);

            // str_CardHolderCity
            str_CardHolderCity = new(this, "x_str_CardHolderCity", 202, SqlDbType.NVarChar)
            {
                Name = "str_CardHolderCity",
                Expression = "[str_CardHolderCity]",
                BasicSearchExpression = "[str_CardHolderCity]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CardHolderCity]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_CardHolderCity", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CardHolderCity", str_CardHolderCity);

            // str_CardHolderZip
            str_CardHolderZip = new(this, "x_str_CardHolderZip", 202, SqlDbType.NVarChar)
            {
                Name = "str_CardHolderZip",
                Expression = "[str_CardHolderZip]",
                BasicSearchExpression = "[str_CardHolderZip]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CardHolderZip]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_CardHolderZip", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CardHolderZip", str_CardHolderZip);

            // str_CardType
            str_CardType = new(this, "x_str_CardType", 200, SqlDbType.VarChar)
            {
                Name = "str_CardType",
                Expression = "[str_CardType]",
                BasicSearchExpression = "[str_CardType]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CardType]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_CardType", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CardType", str_CardType);

            // str_CardExpMonth
            str_CardExpMonth = new(this, "x_str_CardExpMonth", 200, SqlDbType.VarChar)
            {
                Name = "str_CardExpMonth",
                Expression = "[str_CardExpMonth]",
                BasicSearchExpression = "[str_CardExpMonth]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CardExpMonth]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_CardExpMonth", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CardExpMonth", str_CardExpMonth);

            // str_CardExpYear
            str_CardExpYear = new(this, "x_str_CardExpYear", 200, SqlDbType.VarChar)
            {
                Name = "str_CardExpYear",
                Expression = "[str_CardExpYear]",
                BasicSearchExpression = "[str_CardExpYear]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CardExpYear]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_CardExpYear", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CardExpYear", str_CardExpYear);

            // str_CardNo
            str_CardNo = new(this, "x_str_CardNo", 200, SqlDbType.VarChar)
            {
                Name = "str_CardNo",
                Expression = "[str_CardNo]",
                BasicSearchExpression = "[str_CardNo]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CardNo]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_CardNo", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CardNo", str_CardNo);

            // str_Certificate_No
            str_Certificate_No = new(this, "x_str_Certificate_No", 200, SqlDbType.VarChar)
            {
                Name = "str_Certificate_No",
                Expression = "[str_Certificate_No]",
                BasicSearchExpression = "[str_Certificate_No]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Certificate_No]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Certificate_No", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Certificate_No", str_Certificate_No);

            // str_AmountPaid
            str_AmountPaid = new(this, "x_str_AmountPaid", 131, SqlDbType.Decimal)
            {
                Name = "str_AmountPaid",
                Expression = "[str_AmountPaid]",
                BasicSearchExpression = "CAST([str_AmountPaid] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[str_AmountPaid]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_AmountPaid", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_AmountPaid", str_AmountPaid);

            // str_PermitValidated
            str_PermitValidated = new(this, "x_str_PermitValidated", 200, SqlDbType.VarChar)
            {
                Name = "str_PermitValidated",
                Expression = "[str_PermitValidated]",
                BasicSearchExpression = "[str_PermitValidated]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_PermitValidated]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_PermitValidated", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_PermitValidated", str_PermitValidated);

            // strSMSNotification
            strSMSNotification = new(this, "x_strSMSNotification", 200, SqlDbType.VarChar)
            {
                Name = "strSMSNotification",
                Expression = "[strSMSNotification]",
                BasicSearchExpression = "[strSMSNotification]",
                DateTimeFormat = -1,
                VirtualExpression = "[strSMSNotification]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "SELECT",
                InputTextType = "text",
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "strSMSNotification", "CustomMsg"),
                IsUpload = false
            };
            strSMSNotification.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(strSMSNotification, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(strSMSNotification, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(strSMSNotification, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            strSMSNotification.GetDefault = () => "No";
            Fields.Add("strSMSNotification", strSMSNotification);

            // strVoiceNotification
            strVoiceNotification = new(this, "x_strVoiceNotification", 200, SqlDbType.VarChar)
            {
                Name = "strVoiceNotification",
                Expression = "[strVoiceNotification]",
                BasicSearchExpression = "[strVoiceNotification]",
                DateTimeFormat = -1,
                VirtualExpression = "[strVoiceNotification]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "strVoiceNotification", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("strVoiceNotification", strVoiceNotification);

            // str_Weight
            str_Weight = new(this, "x_str_Weight", 202, SqlDbType.NVarChar)
            {
                Name = "str_Weight",
                Expression = "[str_Weight]",
                BasicSearchExpression = "[str_Weight]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Weight]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Weight", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Weight", str_Weight);

            // str_SpecialNeeds
            str_SpecialNeeds = new(this, "x_str_SpecialNeeds", 201, SqlDbType.Text)
            {
                Name = "str_SpecialNeeds",
                Expression = "[str_SpecialNeeds]",
                BasicSearchExpression = "[str_SpecialNeeds]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_SpecialNeeds]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "SELECT",
                InputTextType = "text",
                Sortable = false, // Allow sort
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_SpecialNeeds", "CustomMsg"),
                IsUpload = false
            };
            str_SpecialNeeds.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(str_SpecialNeeds, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(str_SpecialNeeds, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(str_SpecialNeeds, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            str_SpecialNeeds.GetDefault = () => "No";
            Fields.Add("str_SpecialNeeds", str_SpecialNeeds);

            // str_MedicalConditions
            str_MedicalConditions = new(this, "x_str_MedicalConditions", 201, SqlDbType.Text)
            {
                Name = "str_MedicalConditions",
                Expression = "[str_MedicalConditions]",
                BasicSearchExpression = "[str_MedicalConditions]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_MedicalConditions]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_MedicalConditions", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_MedicalConditions", str_MedicalConditions);

            // bit_Verified_PIC_InSAW
            bit_Verified_PIC_InSAW = new(this, "x_bit_Verified_PIC_InSAW", 3, SqlDbType.Int)
            {
                Name = "bit_Verified_PIC_InSAW",
                Expression = "[bit_Verified_PIC_InSAW]",
                BasicSearchExpression = "CAST([bit_Verified_PIC_InSAW] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_Verified_PIC_InSAW]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "bit_Verified_PIC_InSAW", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("bit_Verified_PIC_InSAW", bit_Verified_PIC_InSAW);

            // bit_Permit_Waiver_Entered
            bit_Permit_Waiver_Entered = new(this, "x_bit_Permit_Waiver_Entered", 3, SqlDbType.Int)
            {
                Name = "bit_Permit_Waiver_Entered",
                Expression = "[bit_Permit_Waiver_Entered]",
                BasicSearchExpression = "CAST([bit_Permit_Waiver_Entered] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_Permit_Waiver_Entered]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "bit_Permit_Waiver_Entered", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("bit_Permit_Waiver_Entered", bit_Permit_Waiver_Entered);

            // bit_TermsConditions
            bit_TermsConditions = new(this, "x_bit_TermsConditions", 3, SqlDbType.Int)
            {
                Name = "bit_TermsConditions",
                Expression = "[bit_TermsConditions]",
                BasicSearchExpression = "CAST([bit_TermsConditions] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_TermsConditions]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "bit_TermsConditions", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("bit_TermsConditions", bit_TermsConditions);

            // bit_Disable_Self_Scheduling
            bit_Disable_Self_Scheduling = new(this, "x_bit_Disable_Self_Scheduling", 3, SqlDbType.Int)
            {
                Name = "bit_Disable_Self_Scheduling",
                Expression = "[bit_Disable_Self_Scheduling]",
                BasicSearchExpression = "CAST([bit_Disable_Self_Scheduling] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_Disable_Self_Scheduling]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "bit_Disable_Self_Scheduling", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("bit_Disable_Self_Scheduling", bit_Disable_Self_Scheduling);

            // int_EyeColor
            int_EyeColor = new(this, "x_int_EyeColor", 3, SqlDbType.Int)
            {
                Name = "int_EyeColor",
                Expression = "[int_EyeColor]",
                BasicSearchExpression = "CAST([int_EyeColor] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_EyeColor]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_EyeColor", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_EyeColor", int_EyeColor);

            // int_HairColor
            int_HairColor = new(this, "x_int_HairColor", 3, SqlDbType.Int)
            {
                Name = "int_HairColor",
                Expression = "[int_HairColor]",
                BasicSearchExpression = "CAST([int_HairColor] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_HairColor]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_HairColor", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_HairColor", int_HairColor);

            // int_ColorBlind
            int_ColorBlind = new(this, "x_int_ColorBlind", 3, SqlDbType.Int)
            {
                Name = "int_ColorBlind",
                Expression = "[int_ColorBlind]",
                BasicSearchExpression = "CAST([int_ColorBlind] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_ColorBlind]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_ColorBlind", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_ColorBlind", int_ColorBlind);

            // int_HeightFeet
            int_HeightFeet = new(this, "x_int_HeightFeet", 3, SqlDbType.Int)
            {
                Name = "int_HeightFeet",
                Expression = "[int_HeightFeet]",
                BasicSearchExpression = "CAST([int_HeightFeet] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_HeightFeet]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_HeightFeet", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_HeightFeet", int_HeightFeet);

            // int_HeightInches
            int_HeightInches = new(this, "x_int_HeightInches", 3, SqlDbType.Int)
            {
                Name = "int_HeightInches",
                Expression = "[int_HeightInches]",
                BasicSearchExpression = "CAST([int_HeightInches] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_HeightInches]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_HeightInches", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_HeightInches", int_HeightInches);

            // str_reference_code
            str_reference_code = new(this, "x_str_reference_code", 202, SqlDbType.NVarChar)
            {
                Name = "str_reference_code",
                Expression = "[str_reference_code]",
                BasicSearchExpression = "[str_reference_code]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_reference_code]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_reference_code", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_reference_code", str_reference_code);

            // dt_ParentClassAttendedDt
            dt_ParentClassAttendedDt = new(this, "x_dt_ParentClassAttendedDt", 135, SqlDbType.DateTime)
            {
                Name = "dt_ParentClassAttendedDt",
                Expression = "[dt_ParentClassAttendedDt]",
                BasicSearchExpression = CastDateFieldForLike("[dt_ParentClassAttendedDt]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_ParentClassAttendedDt]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dt_ParentClassAttendedDt", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_ParentClassAttendedDt", dt_ParentClassAttendedDt);

            // str_ParentClassAttendedLoc
            str_ParentClassAttendedLoc = new(this, "x_str_ParentClassAttendedLoc", 202, SqlDbType.NVarChar)
            {
                Name = "str_ParentClassAttendedLoc",
                Expression = "[str_ParentClassAttendedLoc]",
                BasicSearchExpression = "[str_ParentClassAttendedLoc]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_ParentClassAttendedLoc]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_ParentClassAttendedLoc", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_ParentClassAttendedLoc", str_ParentClassAttendedLoc);

            // dt_SiblingClassAttendedDt
            dt_SiblingClassAttendedDt = new(this, "x_dt_SiblingClassAttendedDt", 135, SqlDbType.DateTime)
            {
                Name = "dt_SiblingClassAttendedDt",
                Expression = "[dt_SiblingClassAttendedDt]",
                BasicSearchExpression = CastDateFieldForLike("[dt_SiblingClassAttendedDt]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_SiblingClassAttendedDt]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dt_SiblingClassAttendedDt", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_SiblingClassAttendedDt", dt_SiblingClassAttendedDt);

            // str_SiblingClassAttendedLoc
            str_SiblingClassAttendedLoc = new(this, "x_str_SiblingClassAttendedLoc", 202, SqlDbType.NVarChar)
            {
                Name = "str_SiblingClassAttendedLoc",
                Expression = "[str_SiblingClassAttendedLoc]",
                BasicSearchExpression = "[str_SiblingClassAttendedLoc]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_SiblingClassAttendedLoc]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_SiblingClassAttendedLoc", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_SiblingClassAttendedLoc", str_SiblingClassAttendedLoc);

            // bit_PoliciesAndProcedures
            bit_PoliciesAndProcedures = new(this, "x_bit_PoliciesAndProcedures", 11, SqlDbType.Bit)
            {
                Name = "bit_PoliciesAndProcedures",
                Expression = "[bit_PoliciesAndProcedures]",
                BasicSearchExpression = "[bit_PoliciesAndProcedures]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_PoliciesAndProcedures]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "bit_PoliciesAndProcedures", "CustomMsg"),
                IsUpload = false
            };
            bit_PoliciesAndProcedures.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(bit_PoliciesAndProcedures, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_PoliciesAndProcedures, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(bit_PoliciesAndProcedures, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("bit_PoliciesAndProcedures", bit_PoliciesAndProcedures);

            // dt_CourseCompletionDt
            dt_CourseCompletionDt = new(this, "x_dt_CourseCompletionDt", 135, SqlDbType.DateTime)
            {
                Name = "dt_CourseCompletionDt",
                Expression = "[dt_CourseCompletionDt]",
                BasicSearchExpression = CastDateFieldForLike("[dt_CourseCompletionDt]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_CourseCompletionDt]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dt_CourseCompletionDt", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_CourseCompletionDt", dt_CourseCompletionDt);

            // dt_ExtensionDt
            dt_ExtensionDt = new(this, "x_dt_ExtensionDt", 135, SqlDbType.DateTime)
            {
                Name = "dt_ExtensionDt",
                Expression = "[dt_ExtensionDt]",
                BasicSearchExpression = CastDateFieldForLike("[dt_ExtensionDt]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_ExtensionDt]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dt_ExtensionDt", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_ExtensionDt", dt_ExtensionDt);

            // str_MedicalCondition
            str_MedicalCondition = new(this, "x_str_MedicalCondition", 202, SqlDbType.NVarChar)
            {
                Name = "str_MedicalCondition",
                Expression = "[str_MedicalCondition]",
                BasicSearchExpression = "[str_MedicalCondition]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_MedicalCondition]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_MedicalCondition", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_MedicalCondition", str_MedicalCondition);

            // str_MajorCrossStreets
            str_MajorCrossStreets = new(this, "x_str_MajorCrossStreets", 202, SqlDbType.NVarChar)
            {
                Name = "str_MajorCrossStreets",
                Expression = "[str_MajorCrossStreets]",
                BasicSearchExpression = "[str_MajorCrossStreets]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_MajorCrossStreets]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_MajorCrossStreets", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_MajorCrossStreets", str_MajorCrossStreets);

            // str_DriverEdCertNo
            str_DriverEdCertNo = new(this, "x_str_DriverEdCertNo", 202, SqlDbType.NVarChar)
            {
                Name = "str_DriverEdCertNo",
                Expression = "[str_DriverEdCertNo]",
                BasicSearchExpression = "[str_DriverEdCertNo]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_DriverEdCertNo]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_DriverEdCertNo", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_DriverEdCertNo", str_DriverEdCertNo);

            // dt_DriverEdCertIssuedDt
            dt_DriverEdCertIssuedDt = new(this, "x_dt_DriverEdCertIssuedDt", 135, SqlDbType.DateTime)
            {
                Name = "dt_DriverEdCertIssuedDt",
                Expression = "[dt_DriverEdCertIssuedDt]",
                BasicSearchExpression = CastDateFieldForLike("[dt_DriverEdCertIssuedDt]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_DriverEdCertIssuedDt]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dt_DriverEdCertIssuedDt", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_DriverEdCertIssuedDt", dt_DriverEdCertIssuedDt);

            // str_BTWDriversEdCertNo
            str_BTWDriversEdCertNo = new(this, "x_str_BTWDriversEdCertNo", 200, SqlDbType.VarChar)
            {
                Name = "str_BTWDriversEdCertNo",
                Expression = "[str_BTWDriversEdCertNo]",
                BasicSearchExpression = "[str_BTWDriversEdCertNo]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_BTWDriversEdCertNo]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_BTWDriversEdCertNo", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_BTWDriversEdCertNo", str_BTWDriversEdCertNo);

            // dt_BTWCertIssuedDt
            dt_BTWCertIssuedDt = new(this, "x_dt_BTWCertIssuedDt", 135, SqlDbType.DateTime)
            {
                Name = "dt_BTWCertIssuedDt",
                Expression = "[dt_BTWCertIssuedDt]",
                BasicSearchExpression = CastDateFieldForLike("[dt_BTWCertIssuedDt]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_BTWCertIssuedDt]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dt_BTWCertIssuedDt", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_BTWCertIssuedDt", dt_BTWCertIssuedDt);

            // str_OLDriversEdCertNo
            str_OLDriversEdCertNo = new(this, "x_str_OLDriversEdCertNo", 200, SqlDbType.VarChar)
            {
                Name = "str_OLDriversEdCertNo",
                Expression = "[str_OLDriversEdCertNo]",
                BasicSearchExpression = "[str_OLDriversEdCertNo]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_OLDriversEdCertNo]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_OLDriversEdCertNo", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_OLDriversEdCertNo", str_OLDriversEdCertNo);

            // dt_OLCertIssuedDt
            dt_OLCertIssuedDt = new(this, "x_dt_OLCertIssuedDt", 135, SqlDbType.DateTime)
            {
                Name = "dt_OLCertIssuedDt",
                Expression = "[dt_OLCertIssuedDt]",
                BasicSearchExpression = CastDateFieldForLike("[dt_OLCertIssuedDt]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_OLCertIssuedDt]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dt_OLCertIssuedDt", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_OLCertIssuedDt", dt_OLCertIssuedDt);

            // str_height
            str_height = new(this, "x_str_height", 200, SqlDbType.VarChar)
            {
                Name = "str_height",
                Expression = "[str_height]",
                BasicSearchExpression = "[str_height]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_height]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_height", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_height", str_height);

            // dt_BTWCompletionDt
            dt_BTWCompletionDt = new(this, "x_dt_BTWCompletionDt", 135, SqlDbType.DateTime)
            {
                Name = "dt_BTWCompletionDt",
                Expression = "[dt_BTWCompletionDt]",
                BasicSearchExpression = CastDateFieldForLike("[dt_BTWCompletionDt]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_BTWCompletionDt]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dt_BTWCompletionDt", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_BTWCompletionDt", dt_BTWCompletionDt);

            // dt_CRCompletionDt
            dt_CRCompletionDt = new(this, "x_dt_CRCompletionDt", 135, SqlDbType.DateTime)
            {
                Name = "dt_CRCompletionDt",
                Expression = "[dt_CRCompletionDt]",
                BasicSearchExpression = CastDateFieldForLike("[dt_CRCompletionDt]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_CRCompletionDt]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dt_CRCompletionDt", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_CRCompletionDt", dt_CRCompletionDt);

            // strTextBox5
            strTextBox5 = new(this, "x_strTextBox5", 202, SqlDbType.NVarChar)
            {
                Name = "strTextBox5",
                Expression = "[strTextBox5]",
                BasicSearchExpression = "[strTextBox5]",
                DateTimeFormat = -1,
                VirtualExpression = "[strTextBox5]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "strTextBox5", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("strTextBox5", strTextBox5);

            // strTextBox6
            strTextBox6 = new(this, "x_strTextBox6", 202, SqlDbType.NVarChar)
            {
                Name = "strTextBox6",
                Expression = "[strTextBox6]",
                BasicSearchExpression = "[strTextBox6]",
                DateTimeFormat = -1,
                VirtualExpression = "[strTextBox6]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "strTextBox6", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("strTextBox6", strTextBox6);

            // str_ApartmentNo
            str_ApartmentNo = new(this, "x_str_ApartmentNo", 202, SqlDbType.NVarChar)
            {
                Name = "str_ApartmentNo",
                Expression = "[str_ApartmentNo]",
                BasicSearchExpression = "[str_ApartmentNo]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_ApartmentNo]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_ApartmentNo", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_ApartmentNo", str_ApartmentNo);

            // dt_PermitTestDate
            dt_PermitTestDate = new(this, "x_dt_PermitTestDate", 135, SqlDbType.DateTime)
            {
                Name = "dt_PermitTestDate",
                Expression = "[dt_PermitTestDate]",
                BasicSearchExpression = CastDateFieldForLike("[dt_PermitTestDate]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_PermitTestDate]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dt_PermitTestDate", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_PermitTestDate", dt_PermitTestDate);

            // str_OnlineDriverEdLogin
            str_OnlineDriverEdLogin = new(this, "x_str_OnlineDriverEdLogin", 200, SqlDbType.VarChar)
            {
                Name = "str_OnlineDriverEdLogin",
                Expression = "[str_OnlineDriverEdLogin]",
                BasicSearchExpression = "[str_OnlineDriverEdLogin]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_OnlineDriverEdLogin]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_OnlineDriverEdLogin", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_OnlineDriverEdLogin", str_OnlineDriverEdLogin);

            // str_OnlineDriverEdPassword
            str_OnlineDriverEdPassword = new(this, "x_str_OnlineDriverEdPassword", 200, SqlDbType.VarChar)
            {
                Name = "str_OnlineDriverEdPassword",
                Expression = "[str_OnlineDriverEdPassword]",
                BasicSearchExpression = "[str_OnlineDriverEdPassword]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_OnlineDriverEdPassword]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_OnlineDriverEdPassword", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_OnlineDriverEdPassword", str_OnlineDriverEdPassword);

            // bit_IsSMSEnabled
            bit_IsSMSEnabled = new(this, "x_bit_IsSMSEnabled", 11, SqlDbType.Bit)
            {
                Name = "bit_IsSMSEnabled",
                Expression = "[bit_IsSMSEnabled]",
                BasicSearchExpression = "[bit_IsSMSEnabled]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_IsSMSEnabled]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "bit_IsSMSEnabled", "CustomMsg"),
                IsUpload = false
            };
            bit_IsSMSEnabled.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(bit_IsSMSEnabled, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsSMSEnabled, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(bit_IsSMSEnabled, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("bit_IsSMSEnabled", bit_IsSMSEnabled);

            // dt_SMSModified
            dt_SMSModified = new(this, "x_dt_SMSModified", 135, SqlDbType.DateTime)
            {
                Name = "dt_SMSModified",
                Expression = "[dt_SMSModified]",
                BasicSearchExpression = CastDateFieldForLike("[dt_SMSModified]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_SMSModified]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dt_SMSModified", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_SMSModified", dt_SMSModified);

            // str_confirmPassword
            str_confirmPassword = new(this, "x_str_confirmPassword", 200, SqlDbType.VarChar)
            {
                Name = "str_confirmPassword",
                Expression = "[str_confirmPassword]",
                BasicSearchExpression = "[str_confirmPassword]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_confirmPassword]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_confirmPassword", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_confirmPassword", str_confirmPassword);

            // DE_Certificate
            DE_Certificate = new(this, "x_DE_Certificate", 200, SqlDbType.VarChar)
            {
                Name = "DE_Certificate",
                Expression = "[DE_Certificate]",
                BasicSearchExpression = "[DE_Certificate]",
                DateTimeFormat = -1,
                VirtualExpression = "[DE_Certificate]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "DE_Certificate", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("DE_Certificate", DE_Certificate);

            // Discuss
            Discuss = new(this, "x_Discuss", 202, SqlDbType.NVarChar)
            {
                Name = "Discuss",
                Expression = "[Discuss]",
                BasicSearchExpression = "[Discuss]",
                DateTimeFormat = -1,
                VirtualExpression = "[Discuss]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Discuss", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Discuss", Discuss);

            // int_UnlicensedSibling
            int_UnlicensedSibling = new(this, "x_int_UnlicensedSibling", 3, SqlDbType.Int)
            {
                Name = "int_UnlicensedSibling",
                Expression = "[int_UnlicensedSibling]",
                BasicSearchExpression = "CAST([int_UnlicensedSibling] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_UnlicensedSibling]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_UnlicensedSibling", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_UnlicensedSibling", int_UnlicensedSibling);

            // int_YearSiblingIsEligible
            int_YearSiblingIsEligible = new(this, "x_int_YearSiblingIsEligible", 3, SqlDbType.Int)
            {
                Name = "int_YearSiblingIsEligible",
                Expression = "[int_YearSiblingIsEligible]",
                BasicSearchExpression = "CAST([int_YearSiblingIsEligible] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_YearSiblingIsEligible]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_YearSiblingIsEligible", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_YearSiblingIsEligible", int_YearSiblingIsEligible);

            // BTW_Certificate
            BTW_Certificate = new(this, "x_BTW_Certificate", 200, SqlDbType.VarChar)
            {
                Name = "BTW_Certificate",
                Expression = "[BTW_Certificate]",
                BasicSearchExpression = "[BTW_Certificate]",
                DateTimeFormat = -1,
                VirtualExpression = "[BTW_Certificate]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "BTW_Certificate", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("BTW_Certificate", BTW_Certificate);

            // dt_DECertIssueDate
            dt_DECertIssueDate = new(this, "x_dt_DECertIssueDate", 200, SqlDbType.VarChar)
            {
                Name = "dt_DECertIssueDate",
                Expression = "[dt_DECertIssueDate]",
                BasicSearchExpression = "[dt_DECertIssueDate]",
                DateTimeFormat = -1,
                VirtualExpression = "[dt_DECertIssueDate]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dt_DECertIssueDate", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_DECertIssueDate", dt_DECertIssueDate);

            // str_StudentSignature
            str_StudentSignature = new(this, "x_str_StudentSignature", 202, SqlDbType.NVarChar)
            {
                Name = "str_StudentSignature",
                Expression = "[str_StudentSignature]",
                BasicSearchExpression = "[str_StudentSignature]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_StudentSignature]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_StudentSignature", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_StudentSignature", str_StudentSignature);

            // str_ParentSignature
            str_ParentSignature = new(this, "x_str_ParentSignature", 202, SqlDbType.NVarChar)
            {
                Name = "str_ParentSignature",
                Expression = "[str_ParentSignature]",
                BasicSearchExpression = "[str_ParentSignature]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_ParentSignature]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_ParentSignature", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_ParentSignature", str_ParentSignature);

            // str_Last6DigitsOfParentDriversLicense
            str_Last6DigitsOfParentDriversLicense = new(this, "x_str_Last6DigitsOfParentDriversLicense", 202, SqlDbType.NVarChar)
            {
                Name = "str_Last6DigitsOfParentDriversLicense",
                Expression = "[str_Last6DigitsOfParentDriversLicense]",
                BasicSearchExpression = "[str_Last6DigitsOfParentDriversLicense]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Last6DigitsOfParentDriversLicense]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Last6DigitsOfParentDriversLicense", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Last6DigitsOfParentDriversLicense", str_Last6DigitsOfParentDriversLicense);

            // str_FACControl
            str_FACControl = new(this, "x_str_FACControl", 200, SqlDbType.VarChar)
            {
                Name = "str_FACControl",
                Expression = "[str_FACControl]",
                BasicSearchExpression = "[str_FACControl]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_FACControl]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_FACControl", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_FACControl", str_FACControl);

            // Classroom_Status_Code
            Classroom_Status_Code = new(this, "x_Classroom_Status_Code", 200, SqlDbType.VarChar)
            {
                Name = "Classroom_Status_Code",
                Expression = "[Classroom_Status_Code]",
                BasicSearchExpression = "[Classroom_Status_Code]",
                DateTimeFormat = -1,
                VirtualExpression = "[Classroom_Status_Code]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Classroom_Status_Code", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Classroom_Status_Code", Classroom_Status_Code);

            // Laboratory_Status_Code
            Laboratory_Status_Code = new(this, "x_Laboratory_Status_Code", 200, SqlDbType.VarChar)
            {
                Name = "Laboratory_Status_Code",
                Expression = "[Laboratory_Status_Code]",
                BasicSearchExpression = "[Laboratory_Status_Code]",
                DateTimeFormat = -1,
                VirtualExpression = "[Laboratory_Status_Code]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Laboratory_Status_Code", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Laboratory_Status_Code", Laboratory_Status_Code);

            // bit_EnrollmentForm
            bit_EnrollmentForm = new(this, "x_bit_EnrollmentForm", 11, SqlDbType.Bit)
            {
                Name = "bit_EnrollmentForm",
                Expression = "[bit_EnrollmentForm]",
                BasicSearchExpression = "[bit_EnrollmentForm]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_EnrollmentForm]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "bit_EnrollmentForm", "CustomMsg"),
                IsUpload = false
            };
            bit_EnrollmentForm.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(bit_EnrollmentForm, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_EnrollmentForm, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(bit_EnrollmentForm, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("bit_EnrollmentForm", bit_EnrollmentForm);

            // bit_ParentStudentContract
            bit_ParentStudentContract = new(this, "x_bit_ParentStudentContract", 11, SqlDbType.Bit)
            {
                Name = "bit_ParentStudentContract",
                Expression = "[bit_ParentStudentContract]",
                BasicSearchExpression = "[bit_ParentStudentContract]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_ParentStudentContract]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "bit_ParentStudentContract", "CustomMsg"),
                IsUpload = false
            };
            bit_ParentStudentContract.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(bit_ParentStudentContract, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_ParentStudentContract, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(bit_ParentStudentContract, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("bit_ParentStudentContract", bit_ParentStudentContract);

            // bit_ParentalAgreement
            bit_ParentalAgreement = new(this, "x_bit_ParentalAgreement", 11, SqlDbType.Bit)
            {
                Name = "bit_ParentalAgreement",
                Expression = "[bit_ParentalAgreement]",
                BasicSearchExpression = "[bit_ParentalAgreement]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_ParentalAgreement]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "bit_ParentalAgreement", "CustomMsg"),
                IsUpload = false
            };
            bit_ParentalAgreement.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(bit_ParentalAgreement, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_ParentalAgreement, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(bit_ParentalAgreement, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("bit_ParentalAgreement", bit_ParentalAgreement);

            // int_SF_GR_WA_HS
            int_SF_GR_WA_HS = new(this, "x_int_SF_GR_WA_HS", 3, SqlDbType.Int)
            {
                Name = "int_SF_GR_WA_HS",
                Expression = "[int_SF_GR_WA_HS]",
                BasicSearchExpression = "CAST([int_SF_GR_WA_HS] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_SF_GR_WA_HS]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_SF_GR_WA_HS", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_SF_GR_WA_HS", int_SF_GR_WA_HS);

            // bit_DisableOnRMV
            bit_DisableOnRMV = new(this, "x_bit_DisableOnRMV", 11, SqlDbType.Bit)
            {
                Name = "bit_DisableOnRMV",
                Expression = "[bit_DisableOnRMV]",
                BasicSearchExpression = "[bit_DisableOnRMV]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_DisableOnRMV]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "bit_DisableOnRMV", "CustomMsg"),
                IsUpload = false
            };
            bit_DisableOnRMV.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(bit_DisableOnRMV, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_DisableOnRMV, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(bit_DisableOnRMV, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("bit_DisableOnRMV", bit_DisableOnRMV);

            // bit_UploadedToRMV
            bit_UploadedToRMV = new(this, "x_bit_UploadedToRMV", 11, SqlDbType.Bit)
            {
                Name = "bit_UploadedToRMV",
                Expression = "[bit_UploadedToRMV]",
                BasicSearchExpression = "[bit_UploadedToRMV]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_UploadedToRMV]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "bit_UploadedToRMV", "CustomMsg"),
                IsUpload = false
            };
            bit_UploadedToRMV.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(bit_UploadedToRMV, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_UploadedToRMV, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(bit_UploadedToRMV, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            bit_UploadedToRMV.GetDefault = () => 0;
            Fields.Add("bit_UploadedToRMV", bit_UploadedToRMV);

            // str_Mother_Name
            str_Mother_Name = new(this, "x_str_Mother_Name", 202, SqlDbType.NVarChar)
            {
                Name = "str_Mother_Name",
                Expression = "[str_Mother_Name]",
                BasicSearchExpression = "[str_Mother_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Mother_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Mother_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Mother_Name", str_Mother_Name);

            // str_Guardians_Name
            str_Guardians_Name = new(this, "x_str_Guardians_Name", 202, SqlDbType.NVarChar)
            {
                Name = "str_Guardians_Name",
                Expression = "[str_Guardians_Name]",
                BasicSearchExpression = "[str_Guardians_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Guardians_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Guardians_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Guardians_Name", str_Guardians_Name);

            // str_Mother_Phone
            str_Mother_Phone = new(this, "x_str_Mother_Phone", 202, SqlDbType.NVarChar)
            {
                Name = "str_Mother_Phone",
                Expression = "[str_Mother_Phone]",
                BasicSearchExpression = "[str_Mother_Phone]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Mother_Phone]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_Mother_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Mother_Phone", str_Mother_Phone);

            // bit_terms
            bit_terms = new(this, "x_bit_terms", 11, SqlDbType.Bit)
            {
                Name = "bit_terms",
                Expression = "[bit_terms]",
                BasicSearchExpression = "[bit_terms]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_terms]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "bit_terms", "CustomMsg"),
                IsUpload = false
            };
            bit_terms.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(bit_terms, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_terms, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(bit_terms, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("bit_terms", bit_terms);

            // int_Nationality
            int_Nationality = new(this, "x_int_Nationality", 3, SqlDbType.Int)
            {
                Name = "int_Nationality",
                Expression = "[int_Nationality]",
                BasicSearchExpression = "CAST([int_Nationality] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Nationality]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Nationality", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Nationality", int_Nationality);

            // str_National_ID_en
            str_National_ID_en = new(this, "x_str_National_ID_en", 202, SqlDbType.NVarChar)
            {
                Name = "str_National_ID_en",
                Expression = "[str_National_ID_en]",
                BasicSearchExpression = "[str_National_ID_en]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_National_ID_en]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_National_ID_en", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_National_ID_en", str_National_ID_en);

            // str_National_ID_arabic
            str_National_ID_arabic = new(this, "x_str_National_ID_arabic", 202, SqlDbType.NVarChar)
            {
                Name = "str_National_ID_arabic",
                Expression = "[str_National_ID_arabic]",
                BasicSearchExpression = "[str_National_ID_arabic]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_National_ID_arabic]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_National_ID_arabic", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_National_ID_arabic", str_National_ID_arabic);

            // Quallification_Id
            Quallification_Id = new(this, "x_Quallification_Id", 3, SqlDbType.Int)
            {
                Name = "Quallification_Id",
                Expression = "[Quallification_Id]",
                BasicSearchExpression = "CAST([Quallification_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Quallification_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Quallification_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Quallification_Id", Quallification_Id);

            // Job_Id
            Job_Id = new(this, "x_Job_Id", 3, SqlDbType.Int)
            {
                Name = "Job_Id",
                Expression = "[Job_Id]",
                BasicSearchExpression = "CAST([Job_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Job_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Job_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Job_Id", Job_Id);

            // str_DOB_arabic
            str_DOB_arabic = new(this, "x_str_DOB_arabic", 202, SqlDbType.NVarChar)
            {
                Name = "str_DOB_arabic",
                Expression = "[str_DOB_arabic]",
                BasicSearchExpression = "[str_DOB_arabic]",
                DateTimeFormat = 13,
                VirtualExpression = "[str_DOB_arabic]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "str_DOB_arabic", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_DOB_arabic", str_DOB_arabic);

            // int_Language
            int_Language = new(this, "x_int_Language", 3, SqlDbType.Int)
            {
                Name = "int_Language",
                Expression = "[int_Language]",
                BasicSearchExpression = "CAST([int_Language] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Language]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Language", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Language", int_Language);

            // strRefId
            strRefId = new(this, "x_strRefId", 200, SqlDbType.VarChar)
            {
                Name = "strRefId",
                Expression = "[strRefId]",
                BasicSearchExpression = "[strRefId]",
                DateTimeFormat = -1,
                VirtualExpression = "[strRefId]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "strRefId", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("strRefId", strRefId);

            // int_Program_Id
            int_Program_Id = new(this, "x_int_Program_Id", 3, SqlDbType.Int)
            {
                Name = "int_Program_Id",
                Expression = "[int_Program_Id]",
                BasicSearchExpression = "CAST([int_Program_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Program_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "SELECT",
                InputTextType = "text",
                Required = true, // Required field
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                OptionCount = 3,
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "int_Program_Id", "CustomMsg"),
                IsUpload = false
            };
            int_Program_Id.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(int_Program_Id, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(int_Program_Id, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(int_Program_Id, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("int_Program_Id", int_Program_Id);

            // IsDrivingexperience
            IsDrivingexperience = new(this, "x_IsDrivingexperience", 11, SqlDbType.Bit)
            {
                Name = "IsDrivingexperience",
                Expression = "[IsDrivingexperience]",
                BasicSearchExpression = "[IsDrivingexperience]",
                DateTimeFormat = -1,
                VirtualExpression = "[IsDrivingexperience]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "IsDrivingexperience", "CustomMsg"),
                IsUpload = false
            };
            IsDrivingexperience.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(IsDrivingexperience, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(IsDrivingexperience, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(IsDrivingexperience, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("IsDrivingexperience", IsDrivingexperience);

            // IsScheduleassessment
            IsScheduleassessment = new(this, "x_IsScheduleassessment", 11, SqlDbType.Bit)
            {
                Name = "IsScheduleassessment",
                Expression = "[IsScheduleassessment]",
                BasicSearchExpression = "[IsScheduleassessment]",
                DateTimeFormat = -1,
                VirtualExpression = "[IsScheduleassessment]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "IsScheduleassessment", "CustomMsg"),
                IsUpload = false
            };
            IsScheduleassessment.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(IsScheduleassessment, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(IsScheduleassessment, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(IsScheduleassessment, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("IsScheduleassessment", IsScheduleassessment);

            // IsEnrollbyyourself
            IsEnrollbyyourself = new(this, "x_IsEnrollbyyourself", 11, SqlDbType.Bit)
            {
                Name = "IsEnrollbyyourself",
                Expression = "[IsEnrollbyyourself]",
                BasicSearchExpression = "[IsEnrollbyyourself]",
                DateTimeFormat = -1,
                VirtualExpression = "[IsEnrollbyyourself]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "IsEnrollbyyourself", "CustomMsg"),
                IsUpload = false
            };
            IsEnrollbyyourself.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(IsEnrollbyyourself, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(IsEnrollbyyourself, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(IsEnrollbyyourself, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("IsEnrollbyyourself", IsEnrollbyyourself);

            // AssessmentTime
            AssessmentTime = new(this, "x_AssessmentTime", 200, SqlDbType.VarChar)
            {
                Name = "AssessmentTime",
                Expression = "[AssessmentTime]",
                BasicSearchExpression = "[AssessmentTime]",
                DateTimeFormat = -1,
                VirtualExpression = "[AssessmentTime]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "AssessmentTime", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("AssessmentTime", AssessmentTime);

            // AssessmentDate
            AssessmentDate = new(this, "x_AssessmentDate", 135, SqlDbType.DateTime)
            {
                Name = "AssessmentDate",
                Expression = "[AssessmentDate]",
                BasicSearchExpression = CastDateFieldForLike("[AssessmentDate]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[AssessmentDate]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "AssessmentDate", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("AssessmentDate", AssessmentDate);

            // isAssessmentDone
            isAssessmentDone = new(this, "x_isAssessmentDone", 11, SqlDbType.Bit)
            {
                Name = "isAssessmentDone",
                Expression = "[isAssessmentDone]",
                BasicSearchExpression = "[isAssessmentDone]",
                DateTimeFormat = -1,
                VirtualExpression = "[isAssessmentDone]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "isAssessmentDone", "CustomMsg"),
                IsUpload = false
            };
            isAssessmentDone.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(isAssessmentDone, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(isAssessmentDone, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(isAssessmentDone, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("isAssessmentDone", isAssessmentDone);

            // AssessmentScore
            AssessmentScore = new(this, "x_AssessmentScore", 3, SqlDbType.Int)
            {
                Name = "AssessmentScore",
                Expression = "[AssessmentScore]",
                BasicSearchExpression = "CAST([AssessmentScore] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[AssessmentScore]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                OptionCount = 2,
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "AssessmentScore", "CustomMsg"),
                IsUpload = false
            };
            AssessmentScore.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(AssessmentScore, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(AssessmentScore, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(AssessmentScore, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("AssessmentScore", AssessmentScore);

            // dt_WrittenTestPassed
            dt_WrittenTestPassed = new(this, "x_dt_WrittenTestPassed", 135, SqlDbType.DateTime)
            {
                Name = "dt_WrittenTestPassed",
                Expression = "[dt_WrittenTestPassed]",
                BasicSearchExpression = CastDateFieldForLike("[dt_WrittenTestPassed]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_WrittenTestPassed]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                OptionCount = 2,
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dt_WrittenTestPassed", "CustomMsg"),
                IsUpload = false
            };
            dt_WrittenTestPassed.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(dt_WrittenTestPassed, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(dt_WrittenTestPassed, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(dt_WrittenTestPassed, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("dt_WrittenTestPassed", dt_WrittenTestPassed);

            // dt_RoadTestPassed
            dt_RoadTestPassed = new(this, "x_dt_RoadTestPassed", 135, SqlDbType.DateTime)
            {
                Name = "dt_RoadTestPassed",
                Expression = "[dt_RoadTestPassed]",
                BasicSearchExpression = CastDateFieldForLike("[dt_RoadTestPassed]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_RoadTestPassed]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                OptionCount = 2,
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dt_RoadTestPassed", "CustomMsg"),
                IsUpload = false
            };
            dt_RoadTestPassed.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(dt_RoadTestPassed, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(dt_RoadTestPassed, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(dt_RoadTestPassed, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("dt_RoadTestPassed", dt_RoadTestPassed);

            // bit_Archive
            bit_Archive = new(this, "x_bit_Archive", 11, SqlDbType.Bit)
            {
                Name = "bit_Archive",
                Expression = "[bit_Archive]",
                BasicSearchExpression = "[bit_Archive]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_Archive]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "bit_Archive", "CustomMsg"),
                IsUpload = false
            };
            bit_Archive.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(bit_Archive, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_Archive, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(bit_Archive, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("bit_Archive", bit_Archive);

            // ArchiveNotes
            ArchiveNotes = new(this, "x_ArchiveNotes", 202, SqlDbType.NVarChar)
            {
                Name = "ArchiveNotes",
                Expression = "[ArchiveNotes]",
                BasicSearchExpression = "[ArchiveNotes]",
                DateTimeFormat = -1,
                VirtualExpression = "[ArchiveNotes]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "ArchiveNotes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("ArchiveNotes", ArchiveNotes);

            // dtArchived
            dtArchived = new(this, "x_dtArchived", 135, SqlDbType.DateTime)
            {
                Name = "dtArchived",
                Expression = "[dtArchived]",
                BasicSearchExpression = CastDateFieldForLike("[dtArchived]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dtArchived]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dtArchived", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dtArchived", dtArchived);

            // SrNo9Dec21
            SrNo9Dec21 = new(this, "x_SrNo9Dec21", 3, SqlDbType.Int)
            {
                Name = "SrNo9Dec21",
                Expression = "[SrNo9Dec21]",
                BasicSearchExpression = "CAST([SrNo9Dec21] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[SrNo9Dec21]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "SrNo9Dec21", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("SrNo9Dec21", SrNo9Dec21);

            // REGNNUMB
            REGNNUMB = new(this, "x_REGNNUMB", 202, SqlDbType.NVarChar)
            {
                Name = "REGNNUMB",
                Expression = "[REGNNUMB]",
                BasicSearchExpression = "[REGNNUMB]",
                DateTimeFormat = -1,
                VirtualExpression = "[REGNNUMB]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "REGNNUMB", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("REGNNUMB", REGNNUMB);

            // REGNLOCN
            REGNLOCN = new(this, "x_REGNLOCN", 202, SqlDbType.NVarChar)
            {
                Name = "REGNLOCN",
                Expression = "[REGNLOCN]",
                BasicSearchExpression = "[REGNLOCN]",
                DateTimeFormat = -1,
                VirtualExpression = "[REGNLOCN]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "REGNLOCN", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("REGNLOCN", REGNLOCN);

            // SrNo11DecF1S1
            SrNo11DecF1S1 = new(this, "x_SrNo11DecF1S1", 3, SqlDbType.Int)
            {
                Name = "SrNo11DecF1S1",
                Expression = "[SrNo11DecF1S1]",
                BasicSearchExpression = "CAST([SrNo11DecF1S1] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[SrNo11DecF1S1]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "SrNo11DecF1S1", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("SrNo11DecF1S1", SrNo11DecF1S1);

            // IsInterestedInTraining
            IsInterestedInTraining = new(this, "x_IsInterestedInTraining", 3, SqlDbType.Int)
            {
                Name = "IsInterestedInTraining",
                Expression = "[IsInterestedInTraining]",
                BasicSearchExpression = "CAST([IsInterestedInTraining] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[IsInterestedInTraining]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "IsInterestedInTraining", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("IsInterestedInTraining", IsInterestedInTraining);

            // StudentEncryptID
            StudentEncryptID = new(this, "x_StudentEncryptID", 202, SqlDbType.NVarChar)
            {
                Name = "StudentEncryptID",
                Expression = "[StudentEncryptID]",
                BasicSearchExpression = "[StudentEncryptID]",
                DateTimeFormat = -1,
                VirtualExpression = "[StudentEncryptID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "StudentEncryptID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("StudentEncryptID", StudentEncryptID);

            // StudentConfirURL
            StudentConfirURL = new(this, "x_StudentConfirURL", 202, SqlDbType.NVarChar)
            {
                Name = "StudentConfirURL",
                Expression = "[StudentConfirURL]",
                BasicSearchExpression = "[StudentConfirURL]",
                DateTimeFormat = -1,
                VirtualExpression = "[StudentConfirURL]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "StudentConfirURL", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("StudentConfirURL", StudentConfirURL);

            // SrNo15DecF1S2
            SrNo15DecF1S2 = new(this, "x_SrNo15DecF1S2", 3, SqlDbType.Int)
            {
                Name = "SrNo15DecF1S2",
                Expression = "[SrNo15DecF1S2]",
                BasicSearchExpression = "CAST([SrNo15DecF1S2] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[SrNo15DecF1S2]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "SrNo15DecF1S2", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("SrNo15DecF1S2", SrNo15DecF1S2);

            // SrNo15DecF1S3
            SrNo15DecF1S3 = new(this, "x_SrNo15DecF1S3", 3, SqlDbType.Int)
            {
                Name = "SrNo15DecF1S3",
                Expression = "[SrNo15DecF1S3]",
                BasicSearchExpression = "CAST([SrNo15DecF1S3] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[SrNo15DecF1S3]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "SrNo15DecF1S3", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("SrNo15DecF1S3", SrNo15DecF1S3);

            // SrNo16DecF2S2
            SrNo16DecF2S2 = new(this, "x_SrNo16DecF2S2", 3, SqlDbType.Int)
            {
                Name = "SrNo16DecF2S2",
                Expression = "[SrNo16DecF2S2]",
                BasicSearchExpression = "CAST([SrNo16DecF2S2] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[SrNo16DecF2S2]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "SrNo16DecF2S2", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("SrNo16DecF2S2", SrNo16DecF2S2);

            // SrNo16DecF2S3
            SrNo16DecF2S3 = new(this, "x_SrNo16DecF2S3", 3, SqlDbType.Int)
            {
                Name = "SrNo16DecF2S3",
                Expression = "[SrNo16DecF2S3]",
                BasicSearchExpression = "CAST([SrNo16DecF2S3] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[SrNo16DecF2S3]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "SrNo16DecF2S3", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("SrNo16DecF2S3", SrNo16DecF2S3);

            // SrNo16DecF3S1
            SrNo16DecF3S1 = new(this, "x_SrNo16DecF3S1", 3, SqlDbType.Int)
            {
                Name = "SrNo16DecF3S1",
                Expression = "[SrNo16DecF3S1]",
                BasicSearchExpression = "CAST([SrNo16DecF3S1] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[SrNo16DecF3S1]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "SrNo16DecF3S1", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("SrNo16DecF3S1", SrNo16DecF3S1);

            // SrNo16DecF3S2
            SrNo16DecF3S2 = new(this, "x_SrNo16DecF3S2", 3, SqlDbType.Int)
            {
                Name = "SrNo16DecF3S2",
                Expression = "[SrNo16DecF3S2]",
                BasicSearchExpression = "CAST([SrNo16DecF3S2] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[SrNo16DecF3S2]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "SrNo16DecF3S2", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("SrNo16DecF3S2", SrNo16DecF3S2);

            // SrNo16DecF4S1
            SrNo16DecF4S1 = new(this, "x_SrNo16DecF4S1", 3, SqlDbType.Int)
            {
                Name = "SrNo16DecF4S1",
                Expression = "[SrNo16DecF4S1]",
                BasicSearchExpression = "CAST([SrNo16DecF4S1] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[SrNo16DecF4S1]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "SrNo16DecF4S1", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("SrNo16DecF4S1", SrNo16DecF4S1);

            // SrNo16DecF4S2
            SrNo16DecF4S2 = new(this, "x_SrNo16DecF4S2", 3, SqlDbType.Int)
            {
                Name = "SrNo16DecF4S2",
                Expression = "[SrNo16DecF4S2]",
                BasicSearchExpression = "CAST([SrNo16DecF4S2] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[SrNo16DecF4S2]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "SrNo16DecF4S2", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("SrNo16DecF4S2", SrNo16DecF4S2);

            // SrNo16DecF4S3
            SrNo16DecF4S3 = new(this, "x_SrNo16DecF4S3", 3, SqlDbType.Int)
            {
                Name = "SrNo16DecF4S3",
                Expression = "[SrNo16DecF4S3]",
                BasicSearchExpression = "CAST([SrNo16DecF4S3] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[SrNo16DecF4S3]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "SrNo16DecF4S3", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("SrNo16DecF4S3", SrNo16DecF4S3);

            // StudentAssementBookingURL
            StudentAssementBookingURL = new(this, "x_StudentAssementBookingURL", 202, SqlDbType.NVarChar)
            {
                Name = "StudentAssementBookingURL",
                Expression = "[StudentAssementBookingURL]",
                BasicSearchExpression = "[StudentAssementBookingURL]",
                DateTimeFormat = -1,
                VirtualExpression = "[StudentAssementBookingURL]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "StudentAssementBookingURL", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("StudentAssementBookingURL", StudentAssementBookingURL);

            // intDrivinglicenseType
            intDrivinglicenseType = new(this, "x_intDrivinglicenseType", 3, SqlDbType.Int)
            {
                Name = "intDrivinglicenseType",
                Expression = "[intDrivinglicenseType]",
                BasicSearchExpression = "CAST([intDrivinglicenseType] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[intDrivinglicenseType]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                OptionCount = 1,
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "intDrivinglicenseType", "CustomMsg"),
                IsUpload = false
            };
            intDrivinglicenseType.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(intDrivinglicenseType, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(intDrivinglicenseType, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(intDrivinglicenseType, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("intDrivinglicenseType", intDrivinglicenseType);

            // Isdrivinglicense
            Isdrivinglicense = new(this, "x_Isdrivinglicense", 11, SqlDbType.Bit)
            {
                Name = "Isdrivinglicense",
                Expression = "[Isdrivinglicense]",
                BasicSearchExpression = "[Isdrivinglicense]",
                DateTimeFormat = -1,
                VirtualExpression = "[Isdrivinglicense]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Isdrivinglicense", "CustomMsg"),
                IsUpload = false
            };
            Isdrivinglicense.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(Isdrivinglicense, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(Isdrivinglicense, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(Isdrivinglicense, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("Isdrivinglicense", Isdrivinglicense);

            // drivinglicensenumber
            drivinglicensenumber = new(this, "x_drivinglicensenumber", 202, SqlDbType.NVarChar)
            {
                Name = "drivinglicensenumber",
                Expression = "[drivinglicensenumber]",
                BasicSearchExpression = "[drivinglicensenumber]",
                DateTimeFormat = -1,
                VirtualExpression = "[drivinglicensenumber]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "drivinglicensenumber", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("drivinglicensenumber", drivinglicensenumber);

            // Absher_Appointment_number
            Absher_Appointment_number = new(this, "x_Absher_Appointment_number", 202, SqlDbType.NVarChar)
            {
                Name = "Absher_Appointment_number",
                Expression = "[Absher_Appointment_number]",
                BasicSearchExpression = "[Absher_Appointment_number]",
                DateTimeFormat = -1,
                VirtualExpression = "[Absher_Appointment_number]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Absher_Appointment_number", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Absher_Appointment_number", Absher_Appointment_number);

            // DataImportId
            DataImportId = new(this, "x_DataImportId", 20, SqlDbType.BigInt)
            {
                Name = "DataImportId",
                Expression = "[DataImportId]",
                BasicSearchExpression = "CAST([DataImportId] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[DataImportId]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "DataImportId", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("DataImportId", DataImportId);

            // date_Birth_Hijri
            date_Birth_Hijri = new(this, "x_date_Birth_Hijri", 202, SqlDbType.NVarChar)
            {
                Name = "date_Birth_Hijri",
                Expression = "[date_Birth_Hijri]",
                BasicSearchExpression = "[date_Birth_Hijri]",
                DateTimeFormat = -1,
                VirtualExpression = "[date_Birth_Hijri]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "date_Birth_Hijri", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Birth_Hijri", date_Birth_Hijri);

            // UserlevelID
            UserlevelID = new(this, "x_UserlevelID", 3, SqlDbType.Int)
            {
                Name = "UserlevelID",
                Expression = "[UserlevelID]",
                BasicSearchExpression = "CAST([UserlevelID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[UserlevelID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "UserlevelID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("UserlevelID", UserlevelID);

            // Activated
            Activated = new(this, "x_Activated", 11, SqlDbType.Bit)
            {
                Name = "Activated",
                Expression = "[Activated]",
                BasicSearchExpression = "[Activated]",
                DateTimeFormat = -1,
                VirtualExpression = "[Activated]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Activated", "CustomMsg"),
                IsUpload = false
            };
            Activated.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(Activated, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(Activated, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(Activated, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("Activated", Activated);

            // Absherphoto
            Absherphoto = new(this, "x_Absherphoto", 202, SqlDbType.NVarChar)
            {
                Name = "Absherphoto",
                Expression = "[Absherphoto]",
                BasicSearchExpression = "[Absherphoto]",
                DateTimeFormat = -1,
                VirtualExpression = "[Absherphoto]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Absherphoto", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Absherphoto", Absherphoto);

            // Fingerprint
            Fingerprint = new(this, "x_Fingerprint", 202, SqlDbType.NVarChar)
            {
                Name = "Fingerprint",
                Expression = "[Fingerprint]",
                BasicSearchExpression = "[Fingerprint]",
                DateTimeFormat = -1,
                VirtualExpression = "[Fingerprint]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Fingerprint", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Fingerprint", Fingerprint);

            // Required_Program
            Required_Program = new(this, "x_Required_Program", 202, SqlDbType.NVarChar)
            {
                Name = "Required_Program",
                Expression = "[Required_Program]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Required_Program]",
                DateTimeFormat = -1,
                VirtualExpression = "[Required_Program]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Required_Program", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Required_Program", Required_Program);

            // Price
            Price = new(this, "x_Price", 6, SqlDbType.Money)
            {
                Name = "Price",
                Expression = "[Price]",
                BasicSearchExpression = "CAST([Price] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Price]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Price", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Price", Price);

            // Hijri_Day
            Hijri_Day = new(this, "x_Hijri_Day", 3, SqlDbType.Int)
            {
                Name = "Hijri_Day",
                Expression = "[Hijri_Day]",
                BasicSearchExpression = "CAST([Hijri_Day] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Hijri_Day]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Hijri_Day", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Hijri_Day", Hijri_Day);

            // Hijri_Month
            Hijri_Month = new(this, "x_Hijri_Month", 3, SqlDbType.Int)
            {
                Name = "Hijri_Month",
                Expression = "[Hijri_Month]",
                BasicSearchExpression = "CAST([Hijri_Month] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Hijri_Month]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Hijri_Month", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Hijri_Month", Hijri_Month);

            // Hijri_Year
            Hijri_Year = new(this, "x_Hijri_Year", 3, SqlDbType.Int)
            {
                Name = "Hijri_Year",
                Expression = "[Hijri_Year]",
                BasicSearchExpression = "CAST([Hijri_Year] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Hijri_Year]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Hijri_Year", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Hijri_Year", Hijri_Year);

            // Course_Price
            Course_Price = new(this, "x_Course_Price", 131, SqlDbType.Decimal)
            {
                Name = "Course_Price",
                Expression = "[Course_Price]",
                BasicSearchExpression = "CAST([Course_Price] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Course_Price]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Course_Price", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Course_Price", Course_Price);

            // Vat_Tax_15
            Vat_Tax_15 = new(this, "x_Vat_Tax_15", 131, SqlDbType.Decimal)
            {
                Name = "Vat_Tax_15",
                Expression = "[Vat_Tax_15]",
                BasicSearchExpression = "CAST([Vat_Tax_15] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Vat_Tax_15]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Vat_Tax_15", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Vat_Tax_15", Vat_Tax_15);

            // dec_Balance
            dec_Balance = new(this, "x_dec_Balance", 131, SqlDbType.Decimal)
            {
                Name = "dec_Balance",
                Expression = "[dec_Balance]",
                BasicSearchExpression = "CAST([dec_Balance] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[dec_Balance]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "dec_Balance", "CustomMsg"),
                IsUpload = false
            };
            dec_Balance.GetDefault = () => 0;
            Fields.Add("dec_Balance", dec_Balance);

            // Total_Price
            Total_Price = new(this, "x_Total_Price", 131, SqlDbType.Decimal)
            {
                Name = "Total_Price",
                Expression = "[Total_Price]",
                BasicSearchExpression = "CAST([Total_Price] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Total_Price]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Total_Price", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Total_Price", Total_Price);

            // Payment_Online
            Payment_Online = new(this, "x_Payment_Online", 202, SqlDbType.NVarChar)
            {
                Name = "Payment_Online",
                Expression = "[Payment_Online]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Payment_Online]",
                DateTimeFormat = -1,
                VirtualExpression = "[Payment_Online]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Payment_Online", "CustomMsg"),
                IsUpload = false
            };
            Payment_Online.GetDefault = () => "www.myeform4.net/KSAADSBukayriyah/student/arabic/StudentOEArabic.aspx?Param=u2ThqlZz+WU";
            Payment_Online.GetLinkPrefix = () => "https://";
            Fields.Add("Payment_Online", Payment_Online);

            // Institution
            Institution = new(this, "x_Institution", 200, SqlDbType.VarChar)
            {
                Name = "Institution",
                Expression = "[Institution]",
                BasicSearchExpression = "[Institution]",
                DateTimeFormat = -1,
                VirtualExpression = "[Institution]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Institution", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Institution", Institution);

            // WaitingList
            WaitingList = new(this, "x_WaitingList", 11, SqlDbType.Bit)
            {
                Name = "WaitingList",
                Expression = "[WaitingList]",
                BasicSearchExpression = "[WaitingList]",
                DateTimeFormat = -1,
                VirtualExpression = "[WaitingList]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "WaitingList", "CustomMsg"),
                IsUpload = false
            };
            WaitingList.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(WaitingList, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(WaitingList, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(WaitingList, "tblPotentialStudentInfo", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("WaitingList", WaitingList);

            // Assessment_ID
            Assessment_ID = new(this, "x_Assessment_ID", 3, SqlDbType.Int)
            {
                Name = "Assessment_ID",
                Expression = "[Assessment_ID]",
                BasicSearchExpression = "CAST([Assessment_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Assessment_ID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPotentialStudentInfo", "Assessment_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Assessment_ID", Assessment_ID);

            // Call Table Load event
            TableLoad();
        }

        // Set Field Visibility
        public override bool GetFieldVisibility(string fldname)
        {
            var fld = FieldByName(fldname);
            return fld?.Visible ?? false; // Returns original value
        }

        // Invoke method // DN
        public object? Invoke(string name, object?[]? parameters = null)
        {
            var mi = this.GetType().GetMethod(name);
            if (mi != null)
                return IsAsyncMethod(mi)
                    ? InvokeAsync(mi, parameters).GetAwaiter().GetResult()
                    : mi.Invoke(this, parameters);
            return null;
        }

        // Invoke async method // DN
        public async Task<object?> InvokeAsync(MethodInfo? mi, object?[]? parameters = null)
        {
            if (mi != null)
            {
                dynamic? awaitable = mi.Invoke(this, parameters);
                if (awaitable != null)
                {
                    await awaitable;
                    return awaitable.GetAwaiter().GetResult();
                }
            }
            return null;
        }

#pragma warning disable 1998
        // Invoke async method // DN
        public async Task<object> InvokeAsync(string name, object[]? parameters = null) => InvokeAsync(this.GetType().GetMethod(name), parameters);
#pragma warning restore 1998

        // Check if Invoke async method // DN
        public bool IsAsyncMethod(MethodInfo? mi)
        {
            if (mi != null)
            {
                Type attType = typeof(AsyncStateMachineAttribute);
                return mi.GetCustomAttribute(attType) is AsyncStateMachineAttribute;
            }
            return false;
        }

        // Check if Invoke async method // DN
        public bool IsAsyncMethod(string name) => IsAsyncMethod(this.GetType().GetMethod(name));

#pragma warning disable 618
        // Connection
        public virtual DatabaseConnectionBase<SqlConnection, SqlCommand, SqlDataReader, SqlDbType> Connection => GetConnection(DbId);
#pragma warning restore 618

        // Get query factory
        public QueryFactory GetQueryFactory(bool main) => Connection.GetQueryFactory(main);

        // Get query builder
        public QueryBuilder GetQueryBuilder(bool main, string output = "")
        {
            var qf = GetQueryFactory(main);
            var qb = (XQuery)qf.Query(UpdateTable);
            if (output != "")
                qb.Compiler = Connection.GetCompiler(output); // Replace the compiler
            return qb;
        }

        // Get query builder with output Id (use secondary connection)
        public QueryBuilder GetQueryBuilder(string output) => GetQueryBuilder(false, output);

        // Get query builder without output Id (use secondary connection)
        public QueryBuilder GetQueryBuilder() => GetQueryBuilder(false);

        // Set left column class (must be predefined col-*-* classes of Bootstrap grid system)
        public void SetLeftColumnClass(string columnClass)
        {
            Match m = Regex.Match(columnClass, @"^col\-(\w+)\-(\d+)$");
            if (m.Success)
            {
                LeftColumnClass = columnClass + " col-form-label ew-label";
                RightColumnClass = "col-" + m.Groups[1].Value + "-" + ConvertToString(12 - ConvertToInt(m.Groups[2].Value));
                OffsetColumnClass = RightColumnClass + " " + columnClass.Replace("col-", "offset-");
                TableLeftColumnClass = Regex.Replace(columnClass, @"/^col-\w+-(\d+)$/", "w-col-$1"); // Change to w-col-*
            }
        }

        // Multiple column sort
        public void UpdateSort(DbField fld, bool ctrl)
        {
            string sortField, lastSort, curSort, orderBy, lastOrderBy, curOrderBy;
            if (CurrentOrder == fld.Name)
            {
                sortField = fld.Expression;
                lastSort = fld.Sort;
                if ((new[] { "ASC", "DESC", "NO" }).Contains(CurrentOrderType))
                {
                    curSort = CurrentOrderType;
                }
                else
                {
                    curSort = lastSort;
                }
                lastOrderBy = (new[] { "ASC", "DESC" }).Contains(lastSort) ? sortField + " " + lastSort : "";
                curOrderBy = (new[] { "ASC", "DESC" }).Contains(curSort) ? sortField + " " + curSort : "";
                if (ctrl)
                {
                    orderBy = SessionOrderBy;
                    List<string> listOrderBy = !Empty(orderBy) ? orderBy.Split(new string[] { ", " }, StringSplitOptions.None).ToList() : new();
                    if (!Empty(lastOrderBy) && listOrderBy.Contains(lastOrderBy))
                    {
                        if (Empty(curOrderBy))
                        {
                            listOrderBy.Remove(lastOrderBy);
                        }
                        else
                        {
                            var index = listOrderBy.IndexOf(lastOrderBy);
                            listOrderBy[index] = curOrderBy;
                        }
                    }
                    else if (!Empty(curOrderBy))
                    {
                        listOrderBy.Add(curOrderBy);
                    }
                    orderBy = String.Join(", ", listOrderBy);
                    SessionOrderBy = orderBy; // Save to Session
                }
                else
                {
                    SessionOrderBy = curOrderBy; // Save to Session
                }
            }
        }

        // Update field sort
        public void UpdateFieldSort()
        {
            string orderBy = SessionOrderBy; // Get ORDER BY from Session
            var flds = GetSortFields(orderBy);
            foreach (var (key, field) in Fields)
            {
                string fldSort = "";
                foreach (var fld in flds)
                {
                    if (fld[0] == field.Expression || fld[0] == field.VirtualExpression)
                        fldSort = fld[1];
                }
                field.Sort = fldSort;
            }
        }

        // Current detail table name
        public string CurrentDetailTable
        {
            get => Session.GetString(Config.ProjectName + "_" + TableVar + "_" + Config.TableDetailTable);
            set => Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableDetailTable] = value;
        }

        // List of current detail table names
        public List<string> CurrentDetailTables => CurrentDetailTable.Split(',').ToList();

        // Get detail URL
        public string DetailUrl
        {
            get
            {
                string detailUrl = "";
                if (CurrentDetailTable == "tblBillingInfo" && tblBillingInfo != null)
                {
                    detailUrl = tblBillingInfo.ListUrl + "?" + Config.TableShowMaster + "=" + TableVar;
                    detailUrl += "&" + ForeignKeyUrl("fk_NationalID", NationalID.CurrentValue);
                }
                if (Empty(detailUrl))
                    detailUrl = "TblPotentialStudentInfoList";
                return detailUrl;
            }
        }

#pragma warning disable 1998
        // Render X Axis for chart
        public async Task<Dictionary<string, object>> RenderChartXAxis(string chartVar, Dictionary<string, object> chartRow)
        {
            return chartRow;
        }
#pragma warning restore 1998

        // Table level SQL
        // FROM
        private string? _sqlFrom = null;

        public string SqlFrom
        {
            get => _sqlFrom ?? "dbo.tblPotentialStudentInfo";
            set => _sqlFrom = value;
        }

        // SELECT
        private string? _sqlSelect = null;

        public string SqlSelect
        { // Select
            get => _sqlSelect ?? "SELECT * FROM " + SqlFrom;
            set => _sqlSelect = value;
        }

        // WHERE // DN
        private string? _sqlWhere = null;

        public string SqlWhere
        {
            get
            {
                string where = "";
                AddFilter(ref where, ConvertToString(TableFilter));
                return _sqlWhere ?? where;
            }
            set
            {
                _sqlWhere = value;
            }
        }

        // Group By
        private string? _sqlGroupBy = null;

        public string SqlGroupBy
        {
            get => _sqlGroupBy ?? "";
            set => _sqlGroupBy = value;
        }

        // Having
        private string? _sqlHaving = null;

        public string SqlHaving
        {
            get => _sqlHaving ?? "";
            set => _sqlHaving = value;
        }

        // Order By
        private string? _sqlOrderBy = null;

        public string SqlOrderBy
        {
            get => _sqlOrderBy ?? "";
            set => _sqlOrderBy = value;
        }

        // Apply User ID filters
        public string ApplyUserIDFilters(string filter, string id = "")
        {
            if (!Empty(Security.CurrentUserID) && !Security.IsAdmin)
            { // Non system admin
                filter = AddUserIDFilter(filter, id);
            }
            return filter;
        }

        // Check if User ID security allows view all
        public bool UserIDAllow(string id = "")
        {
            int allow = UserIdAllowSecurity;
            return id switch
            {
                "add" => ((allow & 1) == 1),
                "copy" => ((allow & 1) == 1),
                "gridadd" => ((allow & 1) == 1),
                "register" => ((allow & 1) == 1),
                "addopt" => ((allow & 1) == 1),
                "edit" => ((allow & 4) == 4),
                "gridedit" => ((allow & 4) == 4),
                "update" => ((allow & 4) == 4),
                "changepassword" => ((allow & 4) == 4),
                "resetpassword" => ((allow & 4) == 4),
                "delete" => ((allow & 2) == 2),
                "view" => ((allow & 32) == 32),
                "search" => ((allow & 64) == 64),
                "lookup" => ((allow & 256) == 256),
                _ => ((allow & 8) == 8)
            };
        }

        /// <summary>
        /// Get record count by reading data reader (Async) // DN
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <param name="c">Connection</param>
        /// <returns>Record count</returns>
        public async Task<int> GetRecordCountAsync(string sql, dynamic? c = null)
        {
            try
            {
                var cnt = 0;
                var conn = c ?? Connection;
                using var dr = await conn.OpenDataReaderAsync(sql);
                if (dr != null)
                {
                    while (await dr.ReadAsync())
                        cnt++;
                }
                return cnt;
            }
            catch
            {
                if (Config.Debug)
                    throw;
                return -1;
            }
        }

        /// <summary>
        /// Get record count by reading data reader // DN
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <param name="c">Connection</param>
        /// <returns>Record count</returns>
        public int GetRecordCount(string sql, dynamic? c = null) => GetRecordCountAsync(sql, c).GetAwaiter().GetResult();

        /// <summary>
        /// Try to get record count by SELECT COUNT(*) (Async) // DN
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <param name="c">Connection</param>
        /// <returns>Record count</returns>
        public async Task<int> TryGetRecordCountAsync(string sql, dynamic? c = null)
        {
            string orderBy = OrderBy;
            var conn = c ?? Connection;
            sql = Regex.Replace(sql, @"/\*BeginOrderBy\*/[\s\S]+/\*EndOrderBy\*/", "", RegexOptions.IgnoreCase).Trim(); // Remove ORDER BY clause (MSSQL)
            if (!Empty(orderBy) && sql.EndsWith(orderBy))
                sql = sql.Substring(0, sql.Length - orderBy.Length); // Remove ORDER BY clause
            try
            {
                string sqlcnt;
                if ((new[] { "TABLE", "VIEW", "LINKTABLE" }).Contains(Type) && sql.StartsWith(SqlSelect))
                { // Handle Custom Field
                    sqlcnt = "SELECT COUNT(*) FROM " + SqlFrom + sql.Substring(SqlSelect.Length);
                }
                else
                {
                    sqlcnt = "SELECT COUNT(*) FROM (" + sql + ") EW_COUNT_TABLE";
                }
                return Convert.ToInt32(await conn?.ExecuteScalarAsync(sqlcnt));
            }
            catch
            {
                return await GetRecordCountAsync(sql, conn);
            }
        }

        /// <summary>
        /// Try to get record count by SELECT COUNT(*) // DN
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <param name="c">Connection</param>
        /// <returns>Record count</returns>
        public int TryGetRecordCount(string sql, dynamic? c = null) => TryGetRecordCountAsync(sql, c).GetAwaiter().GetResult();

        // Get SQL
        public string GetSql(string where, string orderBy = "") => BuildSelectSql(SqlSelect, SqlWhere, SqlGroupBy, SqlHaving, SqlOrderBy, where, orderBy);

        // Table SQL
        public string CurrentSql
        {
            get
            {
                string filter = CurrentFilter;
                filter = ApplyUserIDFilters(filter); // Add User ID filter
                string sort = SessionOrderBy;
                return GetSql(filter, sort);
            }
        }

        // Table SQL with List page filter
        public string ListSql
        {
            get
            {
                string sort = "";
                string select = "";
                string filter = UseSessionForListSql ? SessionWhere : "";
                AddFilter(ref filter, CurrentFilter);
                RecordsetSelecting(ref filter);
                filter = ApplyUserIDFilters(filter); // Add User ID filter
                select = SqlSelect;
                sort = UseSessionForListSql ? SessionOrderBy : "";
                return BuildSelectSql(select, SqlWhere, SqlGroupBy, SqlHaving, SqlOrderBy, filter, sort);
            }
        }

        // Get ORDER BY clause
        public string OrderBy
        {
            get
            {
                string sort = SessionOrderBy;
                return BuildSelectSql("", "", "", "", SqlOrderBy, "", sort);
            }
        }

        /// <summary>
        /// Get record count based on filter (for detail record count in master table pages) (Async) // DN
        /// </summary>
        /// <param name="filter">Filter</param>
        /// <returns>Record count</returns>
        public async Task<int> LoadRecordCountAsync(string filter) => await TryGetRecordCountAsync(GetSql(filter));

        /// <summary>
        /// Get record count based on filter (for detail record count in master table pages) // DN
        /// </summary>
        /// <param name="filter">Filter</param>
        /// <returns>Record count</returns>
        public int LoadRecordCount(string filter) => TryGetRecordCount(GetSql(filter));

        /// <summary>
        /// Get record count (for current List page) (Async) // DN
        /// </summary>
        /// <returns>Record count</returns>
        public async Task<int> ListRecordCountAsync() => await TryGetRecordCountAsync(ListSql);

        /// <summary>
        /// Get record count (for current List page) // DN
        /// </summary>
        /// <returns>Record count</returns>
        public int ListRecordCount() => TryGetRecordCount(ListSql);

        /// <summary>
        /// Insert (Async)
        /// </summary>
        /// <param name="data">Data to be inserted (IDictionary|Anonymous)</param>
        /// <returns>Row affected</returns>
        public async Task<int> InsertAsync(object data)
        {
            int result = 0;
            IDictionary<string, object> row;
            if (data is IDictionary<string, object> d)
                row = d;
            else if (IsAnonymousType(data))
                row = ConvertToDictionary<object>(data);
            else
                throw new ArgumentException("Data must be of anonymous type or Dictionary<string, object> type", "data");
            row = row.Where(kvp =>
            {
                var fld = FieldByName(kvp.Key);
                return fld != null && !fld.IsCustom;
            }).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            if (row.Count == 0)
                return -1;
            var queryBuilder = GetQueryBuilder();
            try
            {
                var lastInsertedId = await queryBuilder.InsertGetIdAsync<int>(row);
                int_Potential_Student_ID.SetDbValue(lastInsertedId);
                result = 1;
            }
            catch (Exception e)
            {
                CurrentPage?.SetFailureMessage(e.Message);
                if (Config.Debug)
                    throw;
            }
            return result;
        }

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="data">Data to be inserted (IDictionary|Anonymous)</param>
        /// <returns>Row affected</returns>
        public int Insert(object data) => InsertAsync(data).GetAwaiter().GetResult();

        /// <summary>
        /// Update (Async)
        /// </summary>
        /// <param name="data">Data to be updated (IDictionary|Anonymous)</param>
        /// <returns>Row affected</returns>
        public async Task<int> UpdateAsync(object data)
        {
            IDictionary<string, object> row;
            if (data is IDictionary<string, object> d)
                row = d;
            else if (IsAnonymousType(data))
                row = ConvertToDictionary<object>(data);
            else
                throw new ArgumentException("Data must be of anonymous type or Dictionary<string, object> type", "data");
            var where = GetRowFilterAsDictionary(row);
            return where != null ? await UpdateAsync(row, where) : -1; // Prevent update all record
        }

        /// <summary>
        /// Update (Async)
        /// </summary>
        /// <param name="data">Data to be updated (IDictionary|Anonymous)</param>
        /// <param name="where">Where (IDictionary|Anonymous|string)</param>
        /// <returns>Row affected</returns>
        public async Task<int> UpdateAsync(object data, object? where) => await UpdateAsync(data, where, null);

#pragma warning disable 168, 219
        /// <summary>
        /// Update (Async)
        /// </summary>
        /// <param name="data">Data to be updated (IDictionary|Anonymous)</param>
        /// <param name="where">Where (IDictionary|Anonymous)</param>
        /// <param name="rsold">Old record</param>
        /// <returns>Row affected</returns>
        public async Task<int> UpdateAsync(object data, object? where, Dictionary<string, object>? rsold)
        {
            int result = -1;
            IDictionary<string, object> row;
            if (data is IDictionary<string, object> d)
                row = d;
            else if (IsAnonymousType(data))
                row = ConvertToDictionary<object>(data);
            else
                throw new ArgumentException("Data must be of anonymous type or Dictionary<string, object> type", "data");
            bool cascadeUpdate = false;
            DbDataReader? drwrk;
            int updateResult;
            Dictionary<string, object> rscascade = new();
            if (rsold != null)
            {
            }
            row = row.Where(kvp => FieldByName(kvp.Key) is DbField fld && !fld.IsCustom).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            if (row.Count == 0)
                return -1;
            var queryBuilder = GetQueryBuilder();
            string filter = CurrentFilter;
            if (!Empty(filter))
                queryBuilder.WhereRaw(filter);
            if (IsAnonymousType(where))
                queryBuilder.Where(where);
            else if (where is IDictionary<string, object> dict)
                queryBuilder.Where(dict);
            else if (where is string)
                queryBuilder.WhereRaw((string)where);
            if (rsold != null && GetRowFilterAsDictionary(rsold) is IDictionary<string, object> rsoldFilter) // Add filter from old record
                queryBuilder.Where(rsoldFilter);
            if (queryBuilder.HasComponent("where")) // Prevent update all records
                result = await queryBuilder.UpdateAsync(row);
            return result;
        }
#pragma warning restore 168, 219

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="data">Data to be updated (IDictionary|Anonymous)</param>
        /// <returns>Row affected</returns>
        public int Update(object data) => UpdateAsync(data).GetAwaiter().GetResult();

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="data">Data to be updated (IDictionary|Anonymous)</param>
        /// <param name="where">Where (IDictionary|Anonymous|string)</param>
        /// <returns>Row affected</returns>
        public int Update(object data, object where) => UpdateAsync(data, where).GetAwaiter().GetResult();

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="data">Data to be updated (IDictionary|Anonymous)</param>
        /// <param name="where">Where (IDictionary|Anonymous|string)</param>
        /// <param name="rsold">Old record</param>
        /// <returns>Row affected</returns>
        public int Update(object data, object where, Dictionary<string, object> rsold) => UpdateAsync(data, where, rsold).GetAwaiter().GetResult();

#pragma warning disable 168, 1998
        /// <summary>
        /// Delete (Async)
        /// </summary>
        /// <param name="data">Data to be removed (IDictionary|Anonymous)</param>
        /// <param name="where">Where (IDictionary|Anonymous|string)</param>
        /// <returns>Row affected</returns>
        public async Task<int> DeleteAsync(object? data, object? where = null)
        {
            bool delete = true;
            IDictionary<string, object>? row = null;
            if (data is IDictionary<string, object> d)
                row = d;
            else if (IsAnonymousType(data))
                row = ConvertToDictionary<object>(data);
            List<Dictionary<string, object>>? dtlrows;
            if (row != null)
            {
            }
            var queryBuilder = GetQueryBuilder(true); // Use main connection
            if (GetRowFilterAsDictionary(row) is IDictionary<string, object> rowFilter)
                queryBuilder.Where(rowFilter);
            if (IsAnonymousType(where))
                queryBuilder.Where(where);
            else if (where is IDictionary<string, object> dict)
                queryBuilder.Where(dict);
            else if (where is string)
                queryBuilder.WhereRaw((string)where);
            int result = delete && queryBuilder.HasComponent("where") // Avoid delete if no WHERE clause
                ? await queryBuilder.DeleteAsync(Connection.Transaction)
                : -1;
            return result;
        }
#pragma warning restore 168, 1998

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="data">Data to be removed (IDictionary|Anonymous)</param>
        /// <param name="where">Where (IDictionary|Anonymous|string)</param>
        /// <returns>Row affected</returns>
        public int Delete(object data, object? where = null) => DeleteAsync(data, where).GetAwaiter().GetResult();

        // Load DbValue from recordset
        public void LoadDbValues(Dictionary<string, object>? row)
        {
            if (row == null)
                return;
            try
            {
                int_Potential_Student_ID.DbValue = row["int_Potential_Student_ID"]; // Set DB value only
                int_Student_Id.DbValue = row["int_Student_Id"]; // Set DB value only
                str_NationalID_Iqama.DbValue = row["str_NationalID_Iqama"]; // Set DB value only
                NationalID.DbValue = row["NationalID"]; // Set DB value only
                str_First_Name.DbValue = row["str_First_Name"]; // Set DB value only
                str_Middle_Name.DbValue = row["str_Middle_Name"]; // Set DB value only
                str_Last_Name.DbValue = row["str_Last_Name"]; // Set DB value only
                str_Address1.DbValue = row["str_Address1"]; // Set DB value only
                str_Address2.DbValue = row["str_Address2"]; // Set DB value only
                int_State.DbValue = row["int_State"]; // Set DB value only
                str_City.DbValue = row["str_City"]; // Set DB value only
                str_Zip.DbValue = row["str_Zip"]; // Set DB value only
                int_Instructor.DbValue = row["int_Instructor"]; // Set DB value only
                int_Driver.DbValue = row["int_Driver"]; // Set DB value only
                str_Home_Phone.DbValue = row["str_Home_Phone"]; // Set DB value only
                str_Cell_Phone.DbValue = row["str_Cell_Phone"]; // Set DB value only
                str_Parent_Phone.DbValue = row["str_Parent_Phone"]; // Set DB value only
                str_Other_Phone.DbValue = row["str_Other_Phone"]; // Set DB value only
                str_Email.DbValue = row["str_Email"]; // Set DB value only
                str_ParentName.DbValue = row["str_ParentName"]; // Set DB value only
                str_ParentEmail1.DbValue = row["str_ParentEmail1"]; // Set DB value only
                str_ParentEmail2.DbValue = row["str_ParentEmail2"]; // Set DB value only
                str_Username.DbValue = row["str_Username"]; // Set DB value only
                str_Password.DbValue = row["str_Password"]; // Set DB value only
                str_DOB.DbValue = row["str_DOB"]; // Set DB value only
                int_DOB_Day.DbValue = row["int_DOB_Day"]; // Set DB value only
                int_DOB_Month.DbValue = row["int_DOB_Month"]; // Set DB value only
                int_DOB_Year.DbValue = row["int_DOB_Year"]; // Set DB value only
                int_Age.DbValue = row["int_Age"]; // Set DB value only
                int_Type.DbValue = row["int_Type"]; // Set DB value only
                int_Wear_Glasses.DbValue = row["int_Wear_Glasses"]; // Set DB value only
                int_Sex.DbValue = row["int_Sex"]; // Set DB value only
                str_DLPermit.DbValue = row["str_DLPermit"]; // Set DB value only
                dt_Date_PermitIssue.DbValue = row["dt_Date_PermitIssue"]; // Set DB value only
                dt_Date_ExpirePermit.DbValue = row["dt_Date_ExpirePermit"]; // Set DB value only
                int_Hs_ID.DbValue = row["int_Hs_ID"]; // Set DB value only
                str_Emergency_Contact_Name.DbValue = row["str_Emergency_Contact_Name"]; // Set DB value only
                str_Emergency_Contact_Phone.DbValue = row["str_Emergency_Contact_Phone"]; // Set DB value only
                str_Emergency_Contact_Relation.DbValue = row["str_Emergency_Contact_Relation"]; // Set DB value only
                str_Student_Notes.DbValue = row["str_Student_Notes"]; // Set DB value only
                str_Driving_Notes.DbValue = row["str_Driving_Notes"]; // Set DB value only
                int_Location_Id.DbValue = row["int_Location_Id"]; // Set DB value only
                int_Permit_Number.DbValue = row["int_Permit_Number"]; // Set DB value only
                Permit_Issue_Date.DbValue = row["Permit_Issue_Date"]; // Set DB value only
                Permit_Expiry_Date.DbValue = row["Permit_Expiry_Date"]; // Set DB value only
                int_Status.DbValue = row["int_Status"]; // Set DB value only
                int_Lead_Id.DbValue = row["int_Lead_Id"]; // Set DB value only
                int_Activated_By.DbValue = row["int_Activated_By"]; // Set DB value only
                date_Activated.DbValue = row["date_Activated"]; // Set DB value only
                date_Created.DbValue = row["date_Created"]; // Set DB value only
                date_Modified.DbValue = row["date_Modified"]; // Set DB value only
                date_Complete.DbValue = row["date_Complete"]; // Set DB value only
                int_Created_By.DbValue = row["int_Created_By"]; // Set DB value only
                int_Modified_By.DbValue = row["int_Modified_By"]; // Set DB value only
                bit_IsDeleted.DbValue = (ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"); // Set DB value only
                str_CardHolderName.DbValue = row["str_CardHolderName"]; // Set DB value only
                str_CardHolderAddress.DbValue = row["str_CardHolderAddress"]; // Set DB value only
                str_CardHolderCity.DbValue = row["str_CardHolderCity"]; // Set DB value only
                str_CardHolderZip.DbValue = row["str_CardHolderZip"]; // Set DB value only
                str_CardType.DbValue = row["str_CardType"]; // Set DB value only
                str_CardExpMonth.DbValue = row["str_CardExpMonth"]; // Set DB value only
                str_CardExpYear.DbValue = row["str_CardExpYear"]; // Set DB value only
                str_CardNo.DbValue = row["str_CardNo"]; // Set DB value only
                str_Certificate_No.DbValue = row["str_Certificate_No"]; // Set DB value only
                str_AmountPaid.DbValue = row["str_AmountPaid"]; // Set DB value only
                str_PermitValidated.DbValue = row["str_PermitValidated"]; // Set DB value only
                strSMSNotification.DbValue = row["strSMSNotification"]; // Set DB value only
                strVoiceNotification.DbValue = row["strVoiceNotification"]; // Set DB value only
                str_Weight.DbValue = row["str_Weight"]; // Set DB value only
                str_SpecialNeeds.DbValue = row["str_SpecialNeeds"]; // Set DB value only
                str_MedicalConditions.DbValue = row["str_MedicalConditions"]; // Set DB value only
                bit_Verified_PIC_InSAW.DbValue = row["bit_Verified_PIC_InSAW"]; // Set DB value only
                bit_Permit_Waiver_Entered.DbValue = row["bit_Permit_Waiver_Entered"]; // Set DB value only
                bit_TermsConditions.DbValue = row["bit_TermsConditions"]; // Set DB value only
                bit_Disable_Self_Scheduling.DbValue = row["bit_Disable_Self_Scheduling"]; // Set DB value only
                int_EyeColor.DbValue = row["int_EyeColor"]; // Set DB value only
                int_HairColor.DbValue = row["int_HairColor"]; // Set DB value only
                int_ColorBlind.DbValue = row["int_ColorBlind"]; // Set DB value only
                int_HeightFeet.DbValue = row["int_HeightFeet"]; // Set DB value only
                int_HeightInches.DbValue = row["int_HeightInches"]; // Set DB value only
                str_reference_code.DbValue = row["str_reference_code"]; // Set DB value only
                dt_ParentClassAttendedDt.DbValue = row["dt_ParentClassAttendedDt"]; // Set DB value only
                str_ParentClassAttendedLoc.DbValue = row["str_ParentClassAttendedLoc"]; // Set DB value only
                dt_SiblingClassAttendedDt.DbValue = row["dt_SiblingClassAttendedDt"]; // Set DB value only
                str_SiblingClassAttendedLoc.DbValue = row["str_SiblingClassAttendedLoc"]; // Set DB value only
                bit_PoliciesAndProcedures.DbValue = (ConvertToBool(row["bit_PoliciesAndProcedures"]) ? "1" : "0"); // Set DB value only
                dt_CourseCompletionDt.DbValue = row["dt_CourseCompletionDt"]; // Set DB value only
                dt_ExtensionDt.DbValue = row["dt_ExtensionDt"]; // Set DB value only
                str_MedicalCondition.DbValue = row["str_MedicalCondition"]; // Set DB value only
                str_MajorCrossStreets.DbValue = row["str_MajorCrossStreets"]; // Set DB value only
                str_DriverEdCertNo.DbValue = row["str_DriverEdCertNo"]; // Set DB value only
                dt_DriverEdCertIssuedDt.DbValue = row["dt_DriverEdCertIssuedDt"]; // Set DB value only
                str_BTWDriversEdCertNo.DbValue = row["str_BTWDriversEdCertNo"]; // Set DB value only
                dt_BTWCertIssuedDt.DbValue = row["dt_BTWCertIssuedDt"]; // Set DB value only
                str_OLDriversEdCertNo.DbValue = row["str_OLDriversEdCertNo"]; // Set DB value only
                dt_OLCertIssuedDt.DbValue = row["dt_OLCertIssuedDt"]; // Set DB value only
                str_height.DbValue = row["str_height"]; // Set DB value only
                dt_BTWCompletionDt.DbValue = row["dt_BTWCompletionDt"]; // Set DB value only
                dt_CRCompletionDt.DbValue = row["dt_CRCompletionDt"]; // Set DB value only
                strTextBox5.DbValue = row["strTextBox5"]; // Set DB value only
                strTextBox6.DbValue = row["strTextBox6"]; // Set DB value only
                str_ApartmentNo.DbValue = row["str_ApartmentNo"]; // Set DB value only
                dt_PermitTestDate.DbValue = row["dt_PermitTestDate"]; // Set DB value only
                str_OnlineDriverEdLogin.DbValue = row["str_OnlineDriverEdLogin"]; // Set DB value only
                str_OnlineDriverEdPassword.DbValue = row["str_OnlineDriverEdPassword"]; // Set DB value only
                bit_IsSMSEnabled.DbValue = (ConvertToBool(row["bit_IsSMSEnabled"]) ? "1" : "0"); // Set DB value only
                dt_SMSModified.DbValue = row["dt_SMSModified"]; // Set DB value only
                str_confirmPassword.DbValue = row["str_confirmPassword"]; // Set DB value only
                DE_Certificate.DbValue = row["DE_Certificate"]; // Set DB value only
                Discuss.DbValue = row["Discuss"]; // Set DB value only
                int_UnlicensedSibling.DbValue = row["int_UnlicensedSibling"]; // Set DB value only
                int_YearSiblingIsEligible.DbValue = row["int_YearSiblingIsEligible"]; // Set DB value only
                BTW_Certificate.DbValue = row["BTW_Certificate"]; // Set DB value only
                dt_DECertIssueDate.DbValue = row["dt_DECertIssueDate"]; // Set DB value only
                str_StudentSignature.DbValue = row["str_StudentSignature"]; // Set DB value only
                str_ParentSignature.DbValue = row["str_ParentSignature"]; // Set DB value only
                str_Last6DigitsOfParentDriversLicense.DbValue = row["str_Last6DigitsOfParentDriversLicense"]; // Set DB value only
                str_FACControl.DbValue = row["str_FACControl"]; // Set DB value only
                Classroom_Status_Code.DbValue = row["Classroom_Status_Code"]; // Set DB value only
                Laboratory_Status_Code.DbValue = row["Laboratory_Status_Code"]; // Set DB value only
                bit_EnrollmentForm.DbValue = (ConvertToBool(row["bit_EnrollmentForm"]) ? "1" : "0"); // Set DB value only
                bit_ParentStudentContract.DbValue = (ConvertToBool(row["bit_ParentStudentContract"]) ? "1" : "0"); // Set DB value only
                bit_ParentalAgreement.DbValue = (ConvertToBool(row["bit_ParentalAgreement"]) ? "1" : "0"); // Set DB value only
                int_SF_GR_WA_HS.DbValue = row["int_SF_GR_WA_HS"]; // Set DB value only
                bit_DisableOnRMV.DbValue = (ConvertToBool(row["bit_DisableOnRMV"]) ? "1" : "0"); // Set DB value only
                bit_UploadedToRMV.DbValue = (ConvertToBool(row["bit_UploadedToRMV"]) ? "1" : "0"); // Set DB value only
                str_Mother_Name.DbValue = row["str_Mother_Name"]; // Set DB value only
                str_Guardians_Name.DbValue = row["str_Guardians_Name"]; // Set DB value only
                str_Mother_Phone.DbValue = row["str_Mother_Phone"]; // Set DB value only
                bit_terms.DbValue = (ConvertToBool(row["bit_terms"]) ? "1" : "0"); // Set DB value only
                int_Nationality.DbValue = row["int_Nationality"]; // Set DB value only
                str_National_ID_en.DbValue = row["str_National_ID_en"]; // Set DB value only
                str_National_ID_arabic.DbValue = row["str_National_ID_arabic"]; // Set DB value only
                Quallification_Id.DbValue = row["Quallification_Id"]; // Set DB value only
                Job_Id.DbValue = row["Job_Id"]; // Set DB value only
                str_DOB_arabic.DbValue = row["str_DOB_arabic"]; // Set DB value only
                int_Language.DbValue = row["int_Language"]; // Set DB value only
                strRefId.DbValue = row["strRefId"]; // Set DB value only
                int_Program_Id.DbValue = row["int_Program_Id"]; // Set DB value only
                IsDrivingexperience.DbValue = (ConvertToBool(row["IsDrivingexperience"]) ? "1" : "0"); // Set DB value only
                IsScheduleassessment.DbValue = (ConvertToBool(row["IsScheduleassessment"]) ? "1" : "0"); // Set DB value only
                IsEnrollbyyourself.DbValue = (ConvertToBool(row["IsEnrollbyyourself"]) ? "1" : "0"); // Set DB value only
                AssessmentTime.DbValue = row["AssessmentTime"]; // Set DB value only
                AssessmentDate.DbValue = row["AssessmentDate"]; // Set DB value only
                isAssessmentDone.DbValue = (ConvertToBool(row["isAssessmentDone"]) ? "1" : "0"); // Set DB value only
                AssessmentScore.DbValue = row["AssessmentScore"]; // Set DB value only
                dt_WrittenTestPassed.DbValue = row["dt_WrittenTestPassed"]; // Set DB value only
                dt_RoadTestPassed.DbValue = row["dt_RoadTestPassed"]; // Set DB value only
                bit_Archive.DbValue = (ConvertToBool(row["bit_Archive"]) ? "1" : "0"); // Set DB value only
                ArchiveNotes.DbValue = row["ArchiveNotes"]; // Set DB value only
                dtArchived.DbValue = row["dtArchived"]; // Set DB value only
                SrNo9Dec21.DbValue = row["SrNo9Dec21"]; // Set DB value only
                REGNNUMB.DbValue = row["REGNNUMB"]; // Set DB value only
                REGNLOCN.DbValue = row["REGNLOCN"]; // Set DB value only
                SrNo11DecF1S1.DbValue = row["SrNo11DecF1S1"]; // Set DB value only
                IsInterestedInTraining.DbValue = row["IsInterestedInTraining"]; // Set DB value only
                StudentEncryptID.DbValue = row["StudentEncryptID"]; // Set DB value only
                StudentConfirURL.DbValue = row["StudentConfirURL"]; // Set DB value only
                SrNo15DecF1S2.DbValue = row["SrNo15DecF1S2"]; // Set DB value only
                SrNo15DecF1S3.DbValue = row["SrNo15DecF1S3"]; // Set DB value only
                SrNo16DecF2S2.DbValue = row["SrNo16DecF2S2"]; // Set DB value only
                SrNo16DecF2S3.DbValue = row["SrNo16DecF2S3"]; // Set DB value only
                SrNo16DecF3S1.DbValue = row["SrNo16DecF3S1"]; // Set DB value only
                SrNo16DecF3S2.DbValue = row["SrNo16DecF3S2"]; // Set DB value only
                SrNo16DecF4S1.DbValue = row["SrNo16DecF4S1"]; // Set DB value only
                SrNo16DecF4S2.DbValue = row["SrNo16DecF4S2"]; // Set DB value only
                SrNo16DecF4S3.DbValue = row["SrNo16DecF4S3"]; // Set DB value only
                StudentAssementBookingURL.DbValue = row["StudentAssementBookingURL"]; // Set DB value only
                intDrivinglicenseType.DbValue = row["intDrivinglicenseType"]; // Set DB value only
                Isdrivinglicense.DbValue = (ConvertToBool(row["Isdrivinglicense"]) ? "1" : "0"); // Set DB value only
                drivinglicensenumber.DbValue = row["drivinglicensenumber"]; // Set DB value only
                Absher_Appointment_number.DbValue = row["Absher_Appointment_number"]; // Set DB value only
                DataImportId.DbValue = row["DataImportId"]; // Set DB value only
                date_Birth_Hijri.DbValue = row["date_Birth_Hijri"]; // Set DB value only
                UserlevelID.DbValue = row["UserlevelID"]; // Set DB value only
                Activated.DbValue = (ConvertToBool(row["Activated"]) ? "1" : "0"); // Set DB value only
                Absherphoto.DbValue = row["Absherphoto"]; // Set DB value only
                Fingerprint.DbValue = row["Fingerprint"]; // Set DB value only
                Required_Program.DbValue = row["Required_Program"]; // Set DB value only
                Price.DbValue = row["Price"]; // Set DB value only
                Hijri_Day.DbValue = row["Hijri_Day"]; // Set DB value only
                Hijri_Month.DbValue = row["Hijri_Month"]; // Set DB value only
                Hijri_Year.DbValue = row["Hijri_Year"]; // Set DB value only
                Course_Price.DbValue = row["Course_Price"]; // Set DB value only
                Vat_Tax_15.DbValue = row["Vat_Tax_15"]; // Set DB value only
                dec_Balance.DbValue = row["dec_Balance"]; // Set DB value only
                Total_Price.DbValue = row["Total_Price"]; // Set DB value only
                Payment_Online.DbValue = row["Payment_Online"]; // Set DB value only
                Institution.DbValue = row["Institution"]; // Set DB value only
                WaitingList.DbValue = (ConvertToBool(row["WaitingList"]) ? "1" : "0"); // Set DB value only
                Assessment_ID.DbValue = row["Assessment_ID"]; // Set DB value only
            }
            catch { }
        }

        public void DeleteUploadedFiles(Dictionary<string, object> row)
        {
            LoadDbValues(row);
        }

        // Record filter WHERE clause
        private string _sqlKeyFilter => "[int_Potential_Student_ID] = @int_Potential_Student_ID@";

#pragma warning disable 168, 219
        // Get record filter as string
        public string GetRecordFilter(Dictionary<string, object>? row = null, bool current = false)
        {
            string keyFilter = _sqlKeyFilter;
            object? val = null, result = "";
            val = row?.TryGetValue("int_Potential_Student_ID", out result) ?? false
                ? result
                : !Empty(int_Potential_Student_ID.OldValue) && !current ? int_Potential_Student_ID.OldValue : int_Potential_Student_ID.CurrentValue;
            if (!IsNumeric(val))
                return "0=1"; // Invalid key
            if (val == null)
                return "0=1"; // Invalid key
            keyFilter = keyFilter.Replace("@int_Potential_Student_ID@", AdjustSql(val, DbId)); // Replace key value
            return keyFilter;
        }

        // Get record filter as Dictionary // DN
        public Dictionary<string, object>? GetRowFilterAsDictionary(IDictionary<string, object>? row = null)
        {
            Dictionary<string, object>? keyFilter = new();
            object? val = null, result;
            val = row?.TryGetValue("int_Potential_Student_ID", out result) ?? false
                ? result
                : !Empty(int_Potential_Student_ID.OldValue) ? int_Potential_Student_ID.OldValue : int_Potential_Student_ID.CurrentValue;
            if (!IsNumeric(val))
                return null; // Invalid key
            if (Empty(val))
                return null; // Invalid key
            keyFilter.Add("int_Potential_Student_ID", val); // Add key value
            return keyFilter.Count > 0 ? keyFilter : null;
        }
#pragma warning restore 168, 219

        // Return URL
        public string ReturnUrl
        {
            get
            {
                string name = Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl;
                // Get referer URL automatically
                if (!Empty(ReferUrl()) && !SameText(ReferPage(), CurrentPageName()) &&
                    !SameText(ReferPage(), "login"))
                {// Referer not same page or login page
                    Session[name] = ReferUrl(); // Save to Session
                }
                if (!Empty(Session[name]))
                {
                    return Session.GetString(name);
                }
                else
                {
                    return "TblPotentialStudentInfoList";
                }
            }
            set
            {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "TblPotentialStudentInfoView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "TblPotentialStudentInfoEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "TblPotentialStudentInfoAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get
            {
                return "TblPotentialStudentInfoList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch
            {
                Config.ApiViewAction => "TblPotentialStudentInfoView",
                Config.ApiAddAction => "TblPotentialStudentInfoAdd",
                Config.ApiEditAction => "TblPotentialStudentInfoEdit",
                Config.ApiDeleteAction => "TblPotentialStudentInfoDelete",
                Config.ApiListAction => "TblPotentialStudentInfoList",
                _ => String.Empty
            };
        }

        // Current URL
        public string GetCurrentUrl(string parm = "")
        {
            string url = CurrentPageName();
            if (!Empty(parm))
                url = KeyUrl(url, parm);
            else
                url = KeyUrl(url, Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // List URL
        public string ListUrl => "TblPotentialStudentInfoList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblPotentialStudentInfoView", parm);
            else
                url = KeyUrl("TblPotentialStudentInfoView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "TblPotentialStudentInfoAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "TblPotentialStudentInfoAdd?" + parm;
            else
                url = "TblPotentialStudentInfoAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblPotentialStudentInfoEdit", parm);
            else
                url = KeyUrl("TblPotentialStudentInfoEdit", Config.TableShowDetail + "=");
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblPotentialStudentInfoList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblPotentialStudentInfoAdd", parm);
            else
                url = KeyUrl("TblPotentialStudentInfoAdd", Config.TableShowDetail + "=");
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblPotentialStudentInfoList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("TblPotentialStudentInfoDelete")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
            return url;
        }

        // Get primary key as JSON
        public string KeyToJson(bool htmlEncode = false)
        {
            string json = "";
            json += "\"int_Potential_Student_ID\":" + ConvertToJson(int_Potential_Student_ID.CurrentValue, "number", true);
            json = "{" + json + "}";
            if (htmlEncode)
                json = HtmlEncode(json);
            return json;
        }

        // Add key value to URL
        public string KeyUrl(string url, string parm = "")
        { // DN
            if (!IsNull(int_Potential_Student_ID.CurrentValue))
            {
                url += "/" + int_Potential_Student_ID.CurrentValue;
            }
            else
            {
                return "javascript:ew.alert(ew.language.phrase('InvalidRecord'));";
            }
            if (Empty(parm))
                return url;
            else
                return url + "?" + parm;
        }

        // Render sort
        public string RenderFieldHeader(DbField fld)
        {
            string sortUrl = "";
            string attrs = "";
            if (fld.Sortable)
            {
                sortUrl = SortUrl(fld);
                attrs = " role=\"button\" data-ew-action=\"sort\" data-ajax=\"" + (UseAjaxActions ? "true" : "false") + "\" data-sort-url=\"" + sortUrl + "\" data-sort-type=\"2\"";
                if (!Empty(ContextClass)) // Add context
                    attrs += " data-context=\"" + HtmlEncode(ContextClass) + "\"";
            }
            string html = "<div class=\"ew-table-header-caption\"" + attrs + ">" + fld.Caption + "</div>";
            if (!Empty(sortUrl))
            {
                html += "<div class=\"ew-table-header-sort\">" + fld.SortIcon + "</div>";
            }
            if (fld.UseFilter && Security.CanSearch)
            {
                html += "<div class=\"ew-filter-dropdown-btn\" data-ew-action=\"filter\" data-table=\"" + fld.TableVar + "\" data-field=\"" + fld.FieldVar +
                    "\"><div class=\"ew-table-header-filter\" role=\"button\" aria-haspopup=\"true\">" + Language.Phrase("Filter") + "</div></div>";
            }
            html = "<div class=\"ew-table-header-btn\">" + html + "</div>";
            if (UseCustomTemplate)
            {
                string scriptId = ("tpc_{id}").Replace("{id}", fld.TableVar + "_" + fld.Param);
                html = "<template id=\"" + scriptId + "\">" + html + "</template>";
            }
            return html;
        }

        // Sort URL (already URL-encoded)
        public string SortUrl(DbField fld)
        {
            if (!Empty(CurrentAction) || !Empty(Export) ||
                (new[] { 141, 201, 203, 128, 204, 205 }).Contains(fld.Type))
            { // Unsortable data type
                return "";
            }
            else if (fld.Sortable)
            {
                string urlParm = "order=" + UrlEncode(fld.Name) + "&amp;ordertype=" + fld.NextSort;
                if (DashboardReport)
                    urlParm += "&amp;" + Config.PageDashboard + "=true";
                return AddMasterUrl(CurrentDashboardPageUrl() + "?" + urlParm);
            }
            return "";
        }

#pragma warning disable 168, 219
        // Get key as string
        public string GetKey(bool current = false)
        {
            List<string> keys = new();
            string val;
            val = current ? ConvertToString(int_Potential_Student_ID.CurrentValue) ?? "" : ConvertToString(int_Potential_Student_ID.OldValue) ?? "";
            if (Empty(val))
                return String.Empty;
            keys.Add(val);
            return String.Join(Config.CompositeKeySeparator, keys);
        }

        // Get record filter as string // DN
        public string GetKey(IDictionary<string, object> row)
        {
            List<string> keys = new();
            object? val = null, result;
            val = row?.TryGetValue("int_Potential_Student_ID", out result) ?? false ? ConvertToString(result) : null;
            if (Empty(val))
                return String.Empty; // Invalid key
            keys.Add(ConvertToString(val)); // Add key value
            return String.Join(Config.CompositeKeySeparator, keys);
        }
#pragma warning restore 168, 219

        // Set key
        public void SetKey(string key, bool current = false)
        {
            OldKey = key;
            string[] keys = OldKey.Split(Convert.ToChar(Config.CompositeKeySeparator));
            if (keys.Length == 1)
            {
                if (current)
                {
                    int_Potential_Student_ID.CurrentValue = keys[0];
                }
                else
                {
                    int_Potential_Student_ID.OldValue = keys[0];
                }
            }
        }

#pragma warning disable 168
        // Get record keys
        public List<string> GetRecordKeys()
        {
            List<string> result = new();
            StringValues sv;
            List<string> keysList = new();
            if (Post("key_m[]", out sv) || Get("key_m[]", out sv))
            { // DN
                keysList = ((StringValues)sv).Select(k => ConvertToString(k)).ToList();
            }
            else if (RouteValues.Count > 0 || Query.Count > 0 || Form.Count > 0)
            { // DN
                string key = "";
                string[] keyValues = { };
                if (IsApi() && RouteValues.TryGetValue("key", out object? k))
                {
                    string str = ConvertToString(k);
                    keyValues = str.Split('/');
                }
                if (RouteValues.TryGetValue("int_Potential_Student_ID", out object? v0))
                { // int_Potential_Student_ID // DN
                    key = UrlDecode(v0); // DN
                }
                else if (IsApi() && !Empty(keyValues))
                {
                    key = keyValues[0];
                }
                else
                {
                    key = Param("int_Potential_Student_ID");
                }
                keysList.Add(key);
            }
            // Check keys
            foreach (var keys in keysList)
            {
                if (!IsNumeric(keys)) // int_Potential_Student_ID
                    continue;
                result.Add(keys);
            }
            return result;
        }
#pragma warning restore 168

        // Get filter from records
        public string GetFilterFromRecords(IEnumerable<Dictionary<string, object>> rows) =>
            String.Join(" OR ", rows.Select(row => "(" + GetRecordFilter(row) + ")"));

        // Get filter from record keys
        public string GetFilterFromRecordKeys(bool setCurrent = true)
        {
            List<string> recordKeys = GetRecordKeys();
            string keyFilter = "";
            foreach (var keys in recordKeys)
            {
                if (!Empty(keyFilter))
                    keyFilter += " OR ";
                if (setCurrent)
                    int_Potential_Student_ID.CurrentValue = keys;
                else
                    int_Potential_Student_ID.OldValue = keys;
                keyFilter += "(" + GetRecordFilter() + ")";
            }
            return keyFilter;
        }

#pragma warning disable 618
        // Load rows based on filter // DN
        public async Task<DbDataReader?> LoadReader(string filter, string sort = "", DatabaseConnectionBase<SqlConnection, SqlCommand, SqlDataReader, SqlDbType>? conn = null)
        {
            // Set up filter (SQL WHERE clause) and get return SQL
            string sql = GetSql(filter, sort);
            try
            {
                var dr = await (conn ?? Connection).OpenDataReaderAsync(sql);
                if (dr?.HasRows ?? false)
                    return dr;
                else
                    dr?.Close(); // Close unused data reader // DN
            }
            catch { }
            return null;
        }
#pragma warning restore 618

        // Load row values from recordset
        public void LoadListRowValues(DbDataReader? dr)
        {
            if (dr == null)
                return;
            int_Potential_Student_ID.SetDbValue(dr["int_Potential_Student_ID"]);
            int_Student_Id.SetDbValue(dr["int_Student_Id"]);
            str_NationalID_Iqama.SetDbValue(dr["str_NationalID_Iqama"]);
            NationalID.SetDbValue(dr["NationalID"]);
            str_First_Name.SetDbValue(dr["str_First_Name"]);
            str_Middle_Name.SetDbValue(dr["str_Middle_Name"]);
            str_Last_Name.SetDbValue(dr["str_Last_Name"]);
            str_Address1.SetDbValue(dr["str_Address1"]);
            str_Address2.SetDbValue(dr["str_Address2"]);
            int_State.SetDbValue(dr["int_State"]);
            str_City.SetDbValue(dr["str_City"]);
            str_Zip.SetDbValue(dr["str_Zip"]);
            int_Instructor.SetDbValue(dr["int_Instructor"]);
            int_Driver.SetDbValue(dr["int_Driver"]);
            str_Home_Phone.SetDbValue(dr["str_Home_Phone"]);
            str_Cell_Phone.SetDbValue(dr["str_Cell_Phone"]);
            str_Parent_Phone.SetDbValue(dr["str_Parent_Phone"]);
            str_Other_Phone.SetDbValue(dr["str_Other_Phone"]);
            str_Email.SetDbValue(dr["str_Email"]);
            str_ParentName.SetDbValue(dr["str_ParentName"]);
            str_ParentEmail1.SetDbValue(dr["str_ParentEmail1"]);
            str_ParentEmail2.SetDbValue(dr["str_ParentEmail2"]);
            str_Username.SetDbValue(dr["str_Username"]);
            str_Password.SetDbValue(dr["str_Password"]);
            str_DOB.SetDbValue(dr["str_DOB"]);
            int_DOB_Day.SetDbValue(dr["int_DOB_Day"]);
            int_DOB_Month.SetDbValue(dr["int_DOB_Month"]);
            int_DOB_Year.SetDbValue(dr["int_DOB_Year"]);
            int_Age.SetDbValue(dr["int_Age"]);
            int_Type.SetDbValue(dr["int_Type"]);
            int_Wear_Glasses.SetDbValue(dr["int_Wear_Glasses"]);
            int_Sex.SetDbValue(dr["int_Sex"]);
            str_DLPermit.SetDbValue(dr["str_DLPermit"]);
            dt_Date_PermitIssue.SetDbValue(dr["dt_Date_PermitIssue"]);
            dt_Date_ExpirePermit.SetDbValue(dr["dt_Date_ExpirePermit"]);
            int_Hs_ID.SetDbValue(dr["int_Hs_ID"]);
            str_Emergency_Contact_Name.SetDbValue(dr["str_Emergency_Contact_Name"]);
            str_Emergency_Contact_Phone.SetDbValue(dr["str_Emergency_Contact_Phone"]);
            str_Emergency_Contact_Relation.SetDbValue(dr["str_Emergency_Contact_Relation"]);
            str_Student_Notes.SetDbValue(dr["str_Student_Notes"]);
            str_Driving_Notes.SetDbValue(dr["str_Driving_Notes"]);
            int_Location_Id.SetDbValue(dr["int_Location_Id"]);
            int_Permit_Number.SetDbValue(dr["int_Permit_Number"]);
            Permit_Issue_Date.SetDbValue(dr["Permit_Issue_Date"]);
            Permit_Expiry_Date.SetDbValue(dr["Permit_Expiry_Date"]);
            int_Status.SetDbValue(dr["int_Status"]);
            int_Lead_Id.SetDbValue(dr["int_Lead_Id"]);
            int_Activated_By.SetDbValue(dr["int_Activated_By"]);
            date_Activated.SetDbValue(dr["date_Activated"]);
            date_Created.SetDbValue(dr["date_Created"]);
            date_Modified.SetDbValue(dr["date_Modified"]);
            date_Complete.SetDbValue(dr["date_Complete"]);
            int_Created_By.SetDbValue(dr["int_Created_By"]);
            int_Modified_By.SetDbValue(dr["int_Modified_By"]);
            bit_IsDeleted.SetDbValue(ConvertToBool(dr["bit_IsDeleted"]) ? "1" : "0");
            str_CardHolderName.SetDbValue(dr["str_CardHolderName"]);
            str_CardHolderAddress.SetDbValue(dr["str_CardHolderAddress"]);
            str_CardHolderCity.SetDbValue(dr["str_CardHolderCity"]);
            str_CardHolderZip.SetDbValue(dr["str_CardHolderZip"]);
            str_CardType.SetDbValue(dr["str_CardType"]);
            str_CardExpMonth.SetDbValue(dr["str_CardExpMonth"]);
            str_CardExpYear.SetDbValue(dr["str_CardExpYear"]);
            str_CardNo.SetDbValue(dr["str_CardNo"]);
            str_Certificate_No.SetDbValue(dr["str_Certificate_No"]);
            str_AmountPaid.SetDbValue(dr["str_AmountPaid"]);
            str_PermitValidated.SetDbValue(dr["str_PermitValidated"]);
            strSMSNotification.SetDbValue(dr["strSMSNotification"]);
            strVoiceNotification.SetDbValue(dr["strVoiceNotification"]);
            str_Weight.SetDbValue(dr["str_Weight"]);
            str_SpecialNeeds.SetDbValue(dr["str_SpecialNeeds"]);
            str_MedicalConditions.SetDbValue(dr["str_MedicalConditions"]);
            bit_Verified_PIC_InSAW.SetDbValue(dr["bit_Verified_PIC_InSAW"]);
            bit_Permit_Waiver_Entered.SetDbValue(dr["bit_Permit_Waiver_Entered"]);
            bit_TermsConditions.SetDbValue(dr["bit_TermsConditions"]);
            bit_Disable_Self_Scheduling.SetDbValue(dr["bit_Disable_Self_Scheduling"]);
            int_EyeColor.SetDbValue(dr["int_EyeColor"]);
            int_HairColor.SetDbValue(dr["int_HairColor"]);
            int_ColorBlind.SetDbValue(dr["int_ColorBlind"]);
            int_HeightFeet.SetDbValue(dr["int_HeightFeet"]);
            int_HeightInches.SetDbValue(dr["int_HeightInches"]);
            str_reference_code.SetDbValue(dr["str_reference_code"]);
            dt_ParentClassAttendedDt.SetDbValue(dr["dt_ParentClassAttendedDt"]);
            str_ParentClassAttendedLoc.SetDbValue(dr["str_ParentClassAttendedLoc"]);
            dt_SiblingClassAttendedDt.SetDbValue(dr["dt_SiblingClassAttendedDt"]);
            str_SiblingClassAttendedLoc.SetDbValue(dr["str_SiblingClassAttendedLoc"]);
            bit_PoliciesAndProcedures.SetDbValue(ConvertToBool(dr["bit_PoliciesAndProcedures"]) ? "1" : "0");
            dt_CourseCompletionDt.SetDbValue(dr["dt_CourseCompletionDt"]);
            dt_ExtensionDt.SetDbValue(dr["dt_ExtensionDt"]);
            str_MedicalCondition.SetDbValue(dr["str_MedicalCondition"]);
            str_MajorCrossStreets.SetDbValue(dr["str_MajorCrossStreets"]);
            str_DriverEdCertNo.SetDbValue(dr["str_DriverEdCertNo"]);
            dt_DriverEdCertIssuedDt.SetDbValue(dr["dt_DriverEdCertIssuedDt"]);
            str_BTWDriversEdCertNo.SetDbValue(dr["str_BTWDriversEdCertNo"]);
            dt_BTWCertIssuedDt.SetDbValue(dr["dt_BTWCertIssuedDt"]);
            str_OLDriversEdCertNo.SetDbValue(dr["str_OLDriversEdCertNo"]);
            dt_OLCertIssuedDt.SetDbValue(dr["dt_OLCertIssuedDt"]);
            str_height.SetDbValue(dr["str_height"]);
            dt_BTWCompletionDt.SetDbValue(dr["dt_BTWCompletionDt"]);
            dt_CRCompletionDt.SetDbValue(dr["dt_CRCompletionDt"]);
            strTextBox5.SetDbValue(dr["strTextBox5"]);
            strTextBox6.SetDbValue(dr["strTextBox6"]);
            str_ApartmentNo.SetDbValue(dr["str_ApartmentNo"]);
            dt_PermitTestDate.SetDbValue(dr["dt_PermitTestDate"]);
            str_OnlineDriverEdLogin.SetDbValue(dr["str_OnlineDriverEdLogin"]);
            str_OnlineDriverEdPassword.SetDbValue(dr["str_OnlineDriverEdPassword"]);
            bit_IsSMSEnabled.SetDbValue(ConvertToBool(dr["bit_IsSMSEnabled"]) ? "1" : "0");
            dt_SMSModified.SetDbValue(dr["dt_SMSModified"]);
            str_confirmPassword.SetDbValue(dr["str_confirmPassword"]);
            DE_Certificate.SetDbValue(dr["DE_Certificate"]);
            Discuss.SetDbValue(dr["Discuss"]);
            int_UnlicensedSibling.SetDbValue(dr["int_UnlicensedSibling"]);
            int_YearSiblingIsEligible.SetDbValue(dr["int_YearSiblingIsEligible"]);
            BTW_Certificate.SetDbValue(dr["BTW_Certificate"]);
            dt_DECertIssueDate.SetDbValue(dr["dt_DECertIssueDate"]);
            str_StudentSignature.SetDbValue(dr["str_StudentSignature"]);
            str_ParentSignature.SetDbValue(dr["str_ParentSignature"]);
            str_Last6DigitsOfParentDriversLicense.SetDbValue(dr["str_Last6DigitsOfParentDriversLicense"]);
            str_FACControl.SetDbValue(dr["str_FACControl"]);
            Classroom_Status_Code.SetDbValue(dr["Classroom_Status_Code"]);
            Laboratory_Status_Code.SetDbValue(dr["Laboratory_Status_Code"]);
            bit_EnrollmentForm.SetDbValue(ConvertToBool(dr["bit_EnrollmentForm"]) ? "1" : "0");
            bit_ParentStudentContract.SetDbValue(ConvertToBool(dr["bit_ParentStudentContract"]) ? "1" : "0");
            bit_ParentalAgreement.SetDbValue(ConvertToBool(dr["bit_ParentalAgreement"]) ? "1" : "0");
            int_SF_GR_WA_HS.SetDbValue(dr["int_SF_GR_WA_HS"]);
            bit_DisableOnRMV.SetDbValue(ConvertToBool(dr["bit_DisableOnRMV"]) ? "1" : "0");
            bit_UploadedToRMV.SetDbValue(ConvertToBool(dr["bit_UploadedToRMV"]) ? "1" : "0");
            str_Mother_Name.SetDbValue(dr["str_Mother_Name"]);
            str_Guardians_Name.SetDbValue(dr["str_Guardians_Name"]);
            str_Mother_Phone.SetDbValue(dr["str_Mother_Phone"]);
            bit_terms.SetDbValue(ConvertToBool(dr["bit_terms"]) ? "1" : "0");
            int_Nationality.SetDbValue(dr["int_Nationality"]);
            str_National_ID_en.SetDbValue(dr["str_National_ID_en"]);
            str_National_ID_arabic.SetDbValue(dr["str_National_ID_arabic"]);
            Quallification_Id.SetDbValue(dr["Quallification_Id"]);
            Job_Id.SetDbValue(dr["Job_Id"]);
            str_DOB_arabic.SetDbValue(dr["str_DOB_arabic"]);
            int_Language.SetDbValue(dr["int_Language"]);
            strRefId.SetDbValue(dr["strRefId"]);
            int_Program_Id.SetDbValue(dr["int_Program_Id"]);
            IsDrivingexperience.SetDbValue(ConvertToBool(dr["IsDrivingexperience"]) ? "1" : "0");
            IsScheduleassessment.SetDbValue(ConvertToBool(dr["IsScheduleassessment"]) ? "1" : "0");
            IsEnrollbyyourself.SetDbValue(ConvertToBool(dr["IsEnrollbyyourself"]) ? "1" : "0");
            AssessmentTime.SetDbValue(dr["AssessmentTime"]);
            AssessmentDate.SetDbValue(dr["AssessmentDate"]);
            isAssessmentDone.SetDbValue(ConvertToBool(dr["isAssessmentDone"]) ? "1" : "0");
            AssessmentScore.SetDbValue(dr["AssessmentScore"]);
            dt_WrittenTestPassed.SetDbValue(dr["dt_WrittenTestPassed"]);
            dt_RoadTestPassed.SetDbValue(dr["dt_RoadTestPassed"]);
            bit_Archive.SetDbValue(ConvertToBool(dr["bit_Archive"]) ? "1" : "0");
            ArchiveNotes.SetDbValue(dr["ArchiveNotes"]);
            dtArchived.SetDbValue(dr["dtArchived"]);
            SrNo9Dec21.SetDbValue(dr["SrNo9Dec21"]);
            REGNNUMB.SetDbValue(dr["REGNNUMB"]);
            REGNLOCN.SetDbValue(dr["REGNLOCN"]);
            SrNo11DecF1S1.SetDbValue(dr["SrNo11DecF1S1"]);
            IsInterestedInTraining.SetDbValue(dr["IsInterestedInTraining"]);
            StudentEncryptID.SetDbValue(dr["StudentEncryptID"]);
            StudentConfirURL.SetDbValue(dr["StudentConfirURL"]);
            SrNo15DecF1S2.SetDbValue(dr["SrNo15DecF1S2"]);
            SrNo15DecF1S3.SetDbValue(dr["SrNo15DecF1S3"]);
            SrNo16DecF2S2.SetDbValue(dr["SrNo16DecF2S2"]);
            SrNo16DecF2S3.SetDbValue(dr["SrNo16DecF2S3"]);
            SrNo16DecF3S1.SetDbValue(dr["SrNo16DecF3S1"]);
            SrNo16DecF3S2.SetDbValue(dr["SrNo16DecF3S2"]);
            SrNo16DecF4S1.SetDbValue(dr["SrNo16DecF4S1"]);
            SrNo16DecF4S2.SetDbValue(dr["SrNo16DecF4S2"]);
            SrNo16DecF4S3.SetDbValue(dr["SrNo16DecF4S3"]);
            StudentAssementBookingURL.SetDbValue(dr["StudentAssementBookingURL"]);
            intDrivinglicenseType.SetDbValue(dr["intDrivinglicenseType"]);
            Isdrivinglicense.SetDbValue(ConvertToBool(dr["Isdrivinglicense"]) ? "1" : "0");
            drivinglicensenumber.SetDbValue(dr["drivinglicensenumber"]);
            Absher_Appointment_number.SetDbValue(dr["Absher_Appointment_number"]);
            DataImportId.SetDbValue(dr["DataImportId"]);
            date_Birth_Hijri.SetDbValue(dr["date_Birth_Hijri"]);
            UserlevelID.SetDbValue(dr["UserlevelID"]);
            Activated.SetDbValue(ConvertToBool(dr["Activated"]) ? "1" : "0");
            Absherphoto.SetDbValue(dr["Absherphoto"]);
            Fingerprint.SetDbValue(dr["Fingerprint"]);
            Required_Program.SetDbValue(dr["Required_Program"]);
            Price.SetDbValue(dr["Price"]);
            Hijri_Day.SetDbValue(dr["Hijri_Day"]);
            Hijri_Month.SetDbValue(dr["Hijri_Month"]);
            Hijri_Year.SetDbValue(dr["Hijri_Year"]);
            Course_Price.SetDbValue(dr["Course_Price"]);
            Vat_Tax_15.SetDbValue(dr["Vat_Tax_15"]);
            dec_Balance.SetDbValue(dr["dec_Balance"]);
            Total_Price.SetDbValue(dr["Total_Price"]);
            Payment_Online.SetDbValue(dr["Payment_Online"]);
            Institution.SetDbValue(dr["Institution"]);
            WaitingList.SetDbValue(ConvertToBool(dr["WaitingList"]) ? "1" : "0");
            Assessment_ID.SetDbValue(dr["Assessment_ID"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "TblPotentialStudentInfoList";
            dynamic? page = CreateInstance(pageName, new object[] { Controller }); // DN
            if (page != null)
            {
                page.UseLayout = false; // DN
                await page.LoadRecordsetFromFilter(filter);
                string html = await GetViewOutput(pageName, page, false);
                page.Terminate(); // Terminate page and clean up
                return html;
            }
            return "";
        }

#pragma warning disable 1998
        // Render list row values
        public async Task RenderListRow()
        {
            // Call Row Rendering event
            RowRendering();

            // Common render codes

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
            if (!Empty(curVal))
            {
                if (int_State.Lookup != null && IsDictionary(int_State.Lookup?.Options) && int_State.Lookup?.Options.Values.Count > 0)
                { // Load from cache // DN
                    int_State.ViewValue = int_State.LookupCacheOption(curVal);
                }
                else
                { // Lookup from database // DN
                    filterWrk = SearchFilter("[Province_ID]", "=", int_State.CurrentValue, DataType.Number, "");
                    sqlWrk = int_State.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && int_State.Lookup != null)
                    { // Lookup values found
                        var listwrk = int_State.Lookup?.RenderViewRow(rswrk[0]);
                        int_State.ViewValue = int_State.HighlightLookup(ConvertToString(rswrk[0]), int_State.DisplayValue(listwrk));
                    }
                    else
                    {
                        int_State.ViewValue = FormatNumber(int_State.CurrentValue, int_State.FormatPattern);
                    }
                }
            }
            else
            {
                int_State.ViewValue = DbNullValue;
            }
            int_State.ViewCustomAttributes = "";

            // str_City
            curVal = ConvertToString(str_City.CurrentValue);
            if (!Empty(curVal))
            {
                if (str_City.Lookup != null && IsDictionary(str_City.Lookup?.Options) && str_City.Lookup?.Options.Values.Count > 0)
                { // Load from cache // DN
                    str_City.ViewValue = str_City.LookupCacheOption(curVal);
                }
                else
                { // Lookup from database // DN
                    filterWrk = SearchFilter("[City]", "=", str_City.CurrentValue, DataType.String, "");
                    sqlWrk = str_City.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && str_City.Lookup != null)
                    { // Lookup values found
                        var listwrk = str_City.Lookup?.RenderViewRow(rswrk[0]);
                        str_City.ViewValue = str_City.HighlightLookup(ConvertToString(rswrk[0]), str_City.DisplayValue(listwrk));
                    }
                    else
                    {
                        str_City.ViewValue = str_City.CurrentValue;
                    }
                }
            }
            else
            {
                str_City.ViewValue = DbNullValue;
            }
            str_City.ViewCustomAttributes = "";

            // str_Zip
            str_Zip.ViewValue = ConvertToString(str_Zip.CurrentValue); // DN
            str_Zip.ViewCustomAttributes = "";

            // int_Instructor
            curVal = ConvertToString(int_Instructor.CurrentValue);
            if (!Empty(curVal))
            {
                if (int_Instructor.Lookup != null && IsDictionary(int_Instructor.Lookup?.Options) && int_Instructor.Lookup?.Options.Values.Count > 0)
                { // Load from cache // DN
                    int_Instructor.ViewValue = int_Instructor.LookupCacheOption(curVal);
                }
                else
                { // Lookup from database // DN
                    filterWrk = SearchFilter("[int_Staff_Id]", "=", int_Instructor.CurrentValue, DataType.Number, "");
                    sqlWrk = int_Instructor.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && int_Instructor.Lookup != null)
                    { // Lookup values found
                        var listwrk = int_Instructor.Lookup?.RenderViewRow(rswrk[0]);
                        int_Instructor.ViewValue = int_Instructor.HighlightLookup(ConvertToString(rswrk[0]), int_Instructor.DisplayValue(listwrk));
                    }
                    else
                    {
                        int_Instructor.ViewValue = FormatNumber(int_Instructor.CurrentValue, int_Instructor.FormatPattern);
                    }
                }
            }
            else
            {
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
            if (!Empty(int_Sex.CurrentValue))
            {
                int_Sex.ViewValue = int_Sex.HighlightLookup(ConvertToString(int_Sex.CurrentValue), int_Sex.OptionCaption(ConvertToString(int_Sex.CurrentValue)));
            }
            else
            {
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
            if (!Empty(curVal))
            {
                if (int_Location_Id.Lookup != null && IsDictionary(int_Location_Id.Lookup?.Options) && int_Location_Id.Lookup?.Options.Values.Count > 0)
                { // Load from cache // DN
                    int_Location_Id.ViewValue = int_Location_Id.LookupCacheOption(curVal);
                }
                else
                { // Lookup from database // DN
                    filterWrk = SearchFilter("[int_Location_Id]", "=", int_Location_Id.CurrentValue, DataType.Number, "");
                    sqlWrk = int_Location_Id.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && int_Location_Id.Lookup != null)
                    { // Lookup values found
                        var listwrk = int_Location_Id.Lookup?.RenderViewRow(rswrk[0]);
                        int_Location_Id.ViewValue = int_Location_Id.HighlightLookup(ConvertToString(rswrk[0]), int_Location_Id.DisplayValue(listwrk));
                    }
                    else
                    {
                        int_Location_Id.ViewValue = FormatNumber(int_Location_Id.CurrentValue, int_Location_Id.FormatPattern);
                    }
                }
            }
            else
            {
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
            if (ConvertToBool(bit_IsDeleted.CurrentValue))
            {
                bit_IsDeleted.ViewValue = bit_IsDeleted.TagCaption(1) != "" ? bit_IsDeleted.TagCaption(1) : "Yes";
            }
            else
            {
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
            if (!Empty(strSMSNotification.CurrentValue))
            {
                strSMSNotification.ViewValue = strSMSNotification.HighlightLookup(ConvertToString(strSMSNotification.CurrentValue), strSMSNotification.OptionCaption(ConvertToString(strSMSNotification.CurrentValue)));
            }
            else
            {
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
            if (!Empty(str_SpecialNeeds.CurrentValue))
            {
                str_SpecialNeeds.ViewValue = str_SpecialNeeds.HighlightLookup(ConvertToString(str_SpecialNeeds.CurrentValue), str_SpecialNeeds.OptionCaption(ConvertToString(str_SpecialNeeds.CurrentValue)));
            }
            else
            {
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
            if (ConvertToBool(bit_PoliciesAndProcedures.CurrentValue))
            {
                bit_PoliciesAndProcedures.ViewValue = bit_PoliciesAndProcedures.TagCaption(1) != "" ? bit_PoliciesAndProcedures.TagCaption(1) : "Yes";
            }
            else
            {
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
            if (ConvertToBool(bit_IsSMSEnabled.CurrentValue))
            {
                bit_IsSMSEnabled.ViewValue = bit_IsSMSEnabled.TagCaption(1) != "" ? bit_IsSMSEnabled.TagCaption(1) : "Yes";
            }
            else
            {
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
            if (ConvertToBool(bit_EnrollmentForm.CurrentValue))
            {
                bit_EnrollmentForm.ViewValue = bit_EnrollmentForm.TagCaption(1) != "" ? bit_EnrollmentForm.TagCaption(1) : "Yes";
            }
            else
            {
                bit_EnrollmentForm.ViewValue = bit_EnrollmentForm.TagCaption(2) != "" ? bit_EnrollmentForm.TagCaption(2) : "No";
            }
            bit_EnrollmentForm.ViewCustomAttributes = "";

            // bit_ParentStudentContract
            if (ConvertToBool(bit_ParentStudentContract.CurrentValue))
            {
                bit_ParentStudentContract.ViewValue = bit_ParentStudentContract.TagCaption(1) != "" ? bit_ParentStudentContract.TagCaption(1) : "Yes";
            }
            else
            {
                bit_ParentStudentContract.ViewValue = bit_ParentStudentContract.TagCaption(2) != "" ? bit_ParentStudentContract.TagCaption(2) : "No";
            }
            bit_ParentStudentContract.ViewCustomAttributes = "";

            // bit_ParentalAgreement
            if (ConvertToBool(bit_ParentalAgreement.CurrentValue))
            {
                bit_ParentalAgreement.ViewValue = bit_ParentalAgreement.TagCaption(1) != "" ? bit_ParentalAgreement.TagCaption(1) : "Yes";
            }
            else
            {
                bit_ParentalAgreement.ViewValue = bit_ParentalAgreement.TagCaption(2) != "" ? bit_ParentalAgreement.TagCaption(2) : "No";
            }
            bit_ParentalAgreement.ViewCustomAttributes = "";

            // int_SF_GR_WA_HS
            int_SF_GR_WA_HS.ViewValue = int_SF_GR_WA_HS.CurrentValue;
            int_SF_GR_WA_HS.ViewValue = FormatNumber(int_SF_GR_WA_HS.ViewValue, int_SF_GR_WA_HS.FormatPattern);
            int_SF_GR_WA_HS.ViewCustomAttributes = "";

            // bit_DisableOnRMV
            if (ConvertToBool(bit_DisableOnRMV.CurrentValue))
            {
                bit_DisableOnRMV.ViewValue = bit_DisableOnRMV.TagCaption(1) != "" ? bit_DisableOnRMV.TagCaption(1) : "Yes";
            }
            else
            {
                bit_DisableOnRMV.ViewValue = bit_DisableOnRMV.TagCaption(2) != "" ? bit_DisableOnRMV.TagCaption(2) : "No";
            }
            bit_DisableOnRMV.ViewCustomAttributes = "";

            // bit_UploadedToRMV
            if (ConvertToBool(bit_UploadedToRMV.CurrentValue))
            {
                bit_UploadedToRMV.ViewValue = bit_UploadedToRMV.TagCaption(1) != "" ? bit_UploadedToRMV.TagCaption(1) : "Yes";
            }
            else
            {
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
            if (ConvertToBool(bit_terms.CurrentValue))
            {
                bit_terms.ViewValue = bit_terms.TagCaption(1) != "" ? bit_terms.TagCaption(1) : "Yes";
            }
            else
            {
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
            if (!Empty(int_Program_Id.CurrentValue))
            {
                int_Program_Id.ViewValue = int_Program_Id.HighlightLookup(ConvertToString(int_Program_Id.CurrentValue), int_Program_Id.OptionCaption(ConvertToString(int_Program_Id.CurrentValue)));
            }
            else
            {
                int_Program_Id.ViewValue = DbNullValue;
            }
            int_Program_Id.ViewCustomAttributes = "";

            // IsDrivingexperience
            if (ConvertToBool(IsDrivingexperience.CurrentValue))
            {
                IsDrivingexperience.ViewValue = IsDrivingexperience.TagCaption(1) != "" ? IsDrivingexperience.TagCaption(1) : "Yes";
            }
            else
            {
                IsDrivingexperience.ViewValue = IsDrivingexperience.TagCaption(2) != "" ? IsDrivingexperience.TagCaption(2) : "No";
            }
            IsDrivingexperience.ViewCustomAttributes = "";

            // IsScheduleassessment
            if (ConvertToBool(IsScheduleassessment.CurrentValue))
            {
                IsScheduleassessment.ViewValue = IsScheduleassessment.TagCaption(1) != "" ? IsScheduleassessment.TagCaption(1) : "Yes";
            }
            else
            {
                IsScheduleassessment.ViewValue = IsScheduleassessment.TagCaption(2) != "" ? IsScheduleassessment.TagCaption(2) : "No";
            }
            IsScheduleassessment.ViewCustomAttributes = "";

            // IsEnrollbyyourself
            if (ConvertToBool(IsEnrollbyyourself.CurrentValue))
            {
                IsEnrollbyyourself.ViewValue = IsEnrollbyyourself.TagCaption(1) != "" ? IsEnrollbyyourself.TagCaption(1) : "Yes";
            }
            else
            {
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
            if (ConvertToBool(isAssessmentDone.CurrentValue))
            {
                isAssessmentDone.ViewValue = isAssessmentDone.TagCaption(1) != "" ? isAssessmentDone.TagCaption(1) : "Yes";
            }
            else
            {
                isAssessmentDone.ViewValue = isAssessmentDone.TagCaption(2) != "" ? isAssessmentDone.TagCaption(2) : "No";
            }
            isAssessmentDone.ViewCustomAttributes = "";

            // AssessmentScore
            AssessmentScore.ViewValue = AssessmentScore.CurrentValue;
            AssessmentScore.ViewCustomAttributes = "";

            // dt_WrittenTestPassed
            if (!Empty(dt_WrittenTestPassed.CurrentValue))
            {
                var optionsWrk = new OptionValues();
                arWrk = ConvertToString(dt_WrittenTestPassed.CurrentValue).Split(Config.MultipleOptionSeparator);
                for (int i = 0; i < arWrk.Length; i++)
                {
                    optionsWrk.Add(dt_WrittenTestPassed.HighlightLookup(arWrk[i].Trim(), dt_WrittenTestPassed.OptionCaption(arWrk[i].Trim())));
                }
                dt_WrittenTestPassed.ViewValue = optionsWrk.ToString(); // DN
            }
            else
            {
                dt_WrittenTestPassed.ViewValue = DbNullValue;
            }
            dt_WrittenTestPassed.ViewCustomAttributes = "";

            // dt_RoadTestPassed
            if (!Empty(dt_RoadTestPassed.CurrentValue))
            {
                var optionsWrk = new OptionValues();
                arWrk = ConvertToString(dt_RoadTestPassed.CurrentValue).Split(Config.MultipleOptionSeparator);
                for (int i = 0; i < arWrk.Length; i++)
                {
                    optionsWrk.Add(dt_RoadTestPassed.HighlightLookup(arWrk[i].Trim(), dt_RoadTestPassed.OptionCaption(arWrk[i].Trim())));
                }
                dt_RoadTestPassed.ViewValue = optionsWrk.ToString(); // DN
            }
            else
            {
                dt_RoadTestPassed.ViewValue = DbNullValue;
            }
            dt_RoadTestPassed.ViewCustomAttributes = "";

            // bit_Archive
            if (ConvertToBool(bit_Archive.CurrentValue))
            {
                bit_Archive.ViewValue = bit_Archive.TagCaption(1) != "" ? bit_Archive.TagCaption(1) : "Yes";
            }
            else
            {
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
            if (ConvertToBool(Isdrivinglicense.CurrentValue))
            {
                Isdrivinglicense.ViewValue = Isdrivinglicense.TagCaption(1) != "" ? Isdrivinglicense.TagCaption(1) : "Yes";
            }
            else
            {
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
            if (ConvertToBool(Activated.CurrentValue))
            {
                Activated.ViewValue = Activated.TagCaption(1) != "" ? Activated.TagCaption(1) : "Yes";
            }
            else
            {
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
            if (ConvertToBool(WaitingList.CurrentValue))
            {
                WaitingList.ViewValue = WaitingList.TagCaption(1) != "" ? WaitingList.TagCaption(1) : "Yes";
            }
            else
            {
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
            if (!IsNull(Payment_Online.CurrentValue))
            {
                Payment_Online.HrefValue = Payment_Online.GetLinkPrefix() + ConvertToString(Payment_Online.CurrentValue); // Add prefix/suffix
                Payment_Online.LinkAttrs["target"] = "_blank"; // Add target
                if (IsExport())
                    Payment_Online.HrefValue = FullUrl(ConvertToString(Payment_Online.HrefValue), "href");
            }
            else
            {
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

            // Call Row Rendered event
            RowRendered();

            // Save data for Custom Template
            Rows.Add(CustomTemplateFieldValues());
        }
#pragma warning restore 1998

#pragma warning disable 1998
        // Render edit row values
        public async Task RenderEditRow()
        {
            // Call Row Rendering event
            RowRendering();

            // int_Potential_Student_ID
            int_Potential_Student_ID.SetupEditAttributes();
            int_Potential_Student_ID.EditValue = int_Potential_Student_ID.CurrentValue;
            int_Potential_Student_ID.ViewCustomAttributes = "";

            // int_Student_Id
            int_Student_Id.SetupEditAttributes();
            int_Student_Id.EditValue = int_Student_Id.CurrentValue; // DN
            int_Student_Id.PlaceHolder = RemoveHtml(int_Student_Id.Caption);
            if (!Empty(int_Student_Id.EditValue) && IsNumeric(int_Student_Id.EditValue))
                int_Student_Id.EditValue = FormatNumber(int_Student_Id.EditValue, null);

            // str_NationalID_Iqama
            str_NationalID_Iqama.SetupEditAttributes();
            str_NationalID_Iqama.EditValue = ConvertToString(str_NationalID_Iqama.CurrentValue); // DN
            str_NationalID_Iqama.ViewCustomAttributes = "";

            // NationalID
            NationalID.SetupEditAttributes();
            NationalID.EditValue = NationalID.CurrentValue; // DN
            NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);

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
            int_State.PlaceHolder = RemoveHtml(int_State.Caption);
            if (!Empty(int_State.EditValue) && IsNumeric(int_State.EditValue))
                int_State.EditValue = FormatNumber(int_State.EditValue, null);

            // str_City
            str_City.SetupEditAttributes();
            str_City.PlaceHolder = RemoveHtml(str_City.Caption);

            // str_Zip
            str_Zip.SetupEditAttributes();
            if (!str_Zip.Raw)
                str_Zip.CurrentValue = HtmlDecode(str_Zip.CurrentValue);
            str_Zip.EditValue = HtmlEncode(str_Zip.CurrentValue);
            str_Zip.PlaceHolder = RemoveHtml(str_Zip.Caption);

            // int_Instructor
            int_Instructor.SetupEditAttributes();
            int_Instructor.PlaceHolder = RemoveHtml(int_Instructor.Caption);
            if (!Empty(int_Instructor.EditValue) && IsNumeric(int_Instructor.EditValue))
                int_Instructor.EditValue = FormatNumber(int_Instructor.EditValue, null);

            // int_Driver
            int_Driver.SetupEditAttributes();
            int_Driver.EditValue = int_Driver.CurrentValue; // DN
            int_Driver.PlaceHolder = RemoveHtml(int_Driver.Caption);
            if (!Empty(int_Driver.EditValue) && IsNumeric(int_Driver.EditValue))
                int_Driver.EditValue = FormatNumber(int_Driver.EditValue, null);

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

            // str_Other_Phone
            str_Other_Phone.SetupEditAttributes();
            if (!str_Other_Phone.Raw)
                str_Other_Phone.CurrentValue = HtmlDecode(str_Other_Phone.CurrentValue);
            str_Other_Phone.EditValue = HtmlEncode(str_Other_Phone.CurrentValue);
            str_Other_Phone.PlaceHolder = RemoveHtml(str_Other_Phone.Caption);

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

            // str_ParentEmail1
            str_ParentEmail1.SetupEditAttributes();
            if (!str_ParentEmail1.Raw)
                str_ParentEmail1.CurrentValue = HtmlDecode(str_ParentEmail1.CurrentValue);
            str_ParentEmail1.EditValue = HtmlEncode(str_ParentEmail1.CurrentValue);
            str_ParentEmail1.PlaceHolder = RemoveHtml(str_ParentEmail1.Caption);

            // str_ParentEmail2
            str_ParentEmail2.SetupEditAttributes();
            if (!str_ParentEmail2.Raw)
                str_ParentEmail2.CurrentValue = HtmlDecode(str_ParentEmail2.CurrentValue);
            str_ParentEmail2.EditValue = HtmlEncode(str_ParentEmail2.CurrentValue);
            str_ParentEmail2.PlaceHolder = RemoveHtml(str_ParentEmail2.Caption);

            // str_Username
            str_Username.SetupEditAttributes();
            if (!Security.IsAdmin && Security.IsLoggedIn && !UserIDAllow("info"))
            { // Non system admin
                str_Username.CurrentValue = Empty(str_Username.CurrentValue) ? CurrentUserID() : str_Username.CurrentValue;
            }
            else
            {
                if (!str_Username.Raw)
                    str_Username.CurrentValue = HtmlDecode(str_Username.CurrentValue);
                str_Username.EditValue = HtmlEncode(str_Username.CurrentValue);
                str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);
            }

            // str_Password
            str_Password.SetupEditAttributes();
            if (!str_Password.Raw)
                str_Password.CurrentValue = HtmlDecode(str_Password.CurrentValue);
            str_Password.EditValue = HtmlEncode(str_Password.CurrentValue);
            str_Password.PlaceHolder = RemoveHtml(str_Password.Caption);

            // str_DOB
            str_DOB.SetupEditAttributes();
            str_DOB.EditValue = str_DOB.CurrentValue;
            str_DOB.EditValue = FormatDateTime(str_DOB.EditValue, str_DOB.FormatPattern);
            str_DOB.ViewCustomAttributes = "";

            // int_DOB_Day
            int_DOB_Day.SetupEditAttributes();
            int_DOB_Day.EditValue = int_DOB_Day.CurrentValue; // DN
            int_DOB_Day.PlaceHolder = RemoveHtml(int_DOB_Day.Caption);
            if (!Empty(int_DOB_Day.EditValue) && IsNumeric(int_DOB_Day.EditValue))
                int_DOB_Day.EditValue = FormatNumber(int_DOB_Day.EditValue, null);

            // int_DOB_Month
            int_DOB_Month.SetupEditAttributes();
            int_DOB_Month.EditValue = int_DOB_Month.CurrentValue; // DN
            int_DOB_Month.PlaceHolder = RemoveHtml(int_DOB_Month.Caption);
            if (!Empty(int_DOB_Month.EditValue) && IsNumeric(int_DOB_Month.EditValue))
                int_DOB_Month.EditValue = FormatNumber(int_DOB_Month.EditValue, null);

            // int_DOB_Year
            int_DOB_Year.SetupEditAttributes();
            int_DOB_Year.EditValue = int_DOB_Year.CurrentValue; // DN
            int_DOB_Year.PlaceHolder = RemoveHtml(int_DOB_Year.Caption);

            // int_Age
            int_Age.SetupEditAttributes();
            int_Age.EditValue = int_Age.CurrentValue;
            int_Age.ViewCustomAttributes = "";

            // int_Type
            int_Type.SetupEditAttributes();
            int_Type.EditValue = int_Type.CurrentValue; // DN
            int_Type.PlaceHolder = RemoveHtml(int_Type.Caption);
            if (!Empty(int_Type.EditValue) && IsNumeric(int_Type.EditValue))
                int_Type.EditValue = FormatNumber(int_Type.EditValue, null);

            // int_Wear_Glasses
            int_Wear_Glasses.SetupEditAttributes();
            int_Wear_Glasses.EditValue = int_Wear_Glasses.CurrentValue; // DN
            int_Wear_Glasses.PlaceHolder = RemoveHtml(int_Wear_Glasses.Caption);
            if (!Empty(int_Wear_Glasses.EditValue) && IsNumeric(int_Wear_Glasses.EditValue))
                int_Wear_Glasses.EditValue = FormatNumber(int_Wear_Glasses.EditValue, null);

            // int_Sex
            int_Sex.SetupEditAttributes();
            int_Sex.EditValue = int_Sex.Options(true);
            int_Sex.PlaceHolder = RemoveHtml(int_Sex.Caption);
            if (!Empty(int_Sex.EditValue) && IsNumeric(int_Sex.EditValue))
                int_Sex.EditValue = FormatNumber(int_Sex.EditValue, null);

            // str_DLPermit
            str_DLPermit.SetupEditAttributes();
            if (!str_DLPermit.Raw)
                str_DLPermit.CurrentValue = HtmlDecode(str_DLPermit.CurrentValue);
            str_DLPermit.EditValue = HtmlEncode(str_DLPermit.CurrentValue);
            str_DLPermit.PlaceHolder = RemoveHtml(str_DLPermit.Caption);

            // dt_Date_PermitIssue
            dt_Date_PermitIssue.SetupEditAttributes();
            dt_Date_PermitIssue.EditValue = FormatDateTime(dt_Date_PermitIssue.CurrentValue, dt_Date_PermitIssue.FormatPattern); // DN
            dt_Date_PermitIssue.PlaceHolder = RemoveHtml(dt_Date_PermitIssue.Caption);

            // dt_Date_ExpirePermit
            dt_Date_ExpirePermit.SetupEditAttributes();
            dt_Date_ExpirePermit.EditValue = FormatDateTime(dt_Date_ExpirePermit.CurrentValue, dt_Date_ExpirePermit.FormatPattern); // DN
            dt_Date_ExpirePermit.PlaceHolder = RemoveHtml(dt_Date_ExpirePermit.Caption);

            // int_Hs_ID
            int_Hs_ID.SetupEditAttributes();
            int_Hs_ID.EditValue = int_Hs_ID.CurrentValue; // DN
            int_Hs_ID.PlaceHolder = RemoveHtml(int_Hs_ID.Caption);
            if (!Empty(int_Hs_ID.EditValue) && IsNumeric(int_Hs_ID.EditValue))
                int_Hs_ID.EditValue = FormatNumber(int_Hs_ID.EditValue, null);

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

            // str_Driving_Notes
            str_Driving_Notes.SetupEditAttributes();
            str_Driving_Notes.EditValue = str_Driving_Notes.CurrentValue; // DN
            str_Driving_Notes.PlaceHolder = RemoveHtml(str_Driving_Notes.Caption);

            // int_Location_Id
            int_Location_Id.SetupEditAttributes();
            curVal = ConvertToString(int_Location_Id.CurrentValue);
            if (!Empty(curVal))
            {
                if (int_Location_Id.Lookup != null && IsDictionary(int_Location_Id.Lookup?.Options) && int_Location_Id.Lookup?.Options.Values.Count > 0)
                { // Load from cache // DN
                    int_Location_Id.EditValue = int_Location_Id.LookupCacheOption(curVal);
                }
                else
                { // Lookup from database // DN
                    filterWrk = SearchFilter("[int_Location_Id]", "=", int_Location_Id.CurrentValue, DataType.Number, "");
                    sqlWrk = int_Location_Id.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && int_Location_Id.Lookup != null)
                    { // Lookup values found
                        var listwrk = int_Location_Id.Lookup?.RenderViewRow(rswrk[0]);
                        int_Location_Id.EditValue = int_Location_Id.HighlightLookup(ConvertToString(rswrk[0]), int_Location_Id.DisplayValue(listwrk));
                    }
                    else
                    {
                        int_Location_Id.EditValue = FormatNumber(int_Location_Id.CurrentValue, int_Location_Id.FormatPattern);
                    }
                }
            }
            else
            {
                int_Location_Id.EditValue = DbNullValue;
            }
            int_Location_Id.ViewCustomAttributes = "";

            // int_Permit_Number
            int_Permit_Number.SetupEditAttributes();
            if (!int_Permit_Number.Raw)
                int_Permit_Number.CurrentValue = HtmlDecode(int_Permit_Number.CurrentValue);
            int_Permit_Number.EditValue = HtmlEncode(int_Permit_Number.CurrentValue);
            int_Permit_Number.PlaceHolder = RemoveHtml(int_Permit_Number.Caption);

            // Permit_Issue_Date
            Permit_Issue_Date.SetupEditAttributes();
            if (!Permit_Issue_Date.Raw)
                Permit_Issue_Date.CurrentValue = HtmlDecode(Permit_Issue_Date.CurrentValue);
            Permit_Issue_Date.EditValue = HtmlEncode(Permit_Issue_Date.CurrentValue);
            Permit_Issue_Date.PlaceHolder = RemoveHtml(Permit_Issue_Date.Caption);

            // Permit_Expiry_Date
            Permit_Expiry_Date.SetupEditAttributes();
            Permit_Expiry_Date.EditValue = FormatDateTime(Permit_Expiry_Date.CurrentValue, Permit_Expiry_Date.FormatPattern); // DN
            Permit_Expiry_Date.PlaceHolder = RemoveHtml(Permit_Expiry_Date.Caption);

            // int_Status
            int_Status.SetupEditAttributes();
            int_Status.EditValue = int_Status.CurrentValue; // DN
            int_Status.PlaceHolder = RemoveHtml(int_Status.Caption);
            if (!Empty(int_Status.EditValue) && IsNumeric(int_Status.EditValue))
                int_Status.EditValue = FormatNumber(int_Status.EditValue, null);

            // int_Lead_Id
            int_Lead_Id.SetupEditAttributes();
            int_Lead_Id.EditValue = int_Lead_Id.CurrentValue; // DN
            int_Lead_Id.PlaceHolder = RemoveHtml(int_Lead_Id.Caption);
            if (!Empty(int_Lead_Id.EditValue) && IsNumeric(int_Lead_Id.EditValue))
                int_Lead_Id.EditValue = FormatNumber(int_Lead_Id.EditValue, null);

            // int_Activated_By
            int_Activated_By.SetupEditAttributes();
            int_Activated_By.EditValue = int_Activated_By.CurrentValue; // DN
            int_Activated_By.PlaceHolder = RemoveHtml(int_Activated_By.Caption);
            if (!Empty(int_Activated_By.EditValue) && IsNumeric(int_Activated_By.EditValue))
                int_Activated_By.EditValue = FormatNumber(int_Activated_By.EditValue, null);

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

            // date_Complete
            date_Complete.SetupEditAttributes();
            date_Complete.EditValue = FormatDateTime(date_Complete.CurrentValue, date_Complete.FormatPattern); // DN
            date_Complete.PlaceHolder = RemoveHtml(date_Complete.Caption);

            // int_Created_By
            int_Created_By.SetupEditAttributes();
            int_Created_By.EditValue = int_Created_By.CurrentValue; // DN
            int_Created_By.PlaceHolder = RemoveHtml(int_Created_By.Caption);
            if (!Empty(int_Created_By.EditValue) && IsNumeric(int_Created_By.EditValue))
                int_Created_By.EditValue = FormatNumber(int_Created_By.EditValue, null);

            // int_Modified_By
            int_Modified_By.SetupEditAttributes();
            int_Modified_By.EditValue = int_Modified_By.CurrentValue; // DN
            int_Modified_By.PlaceHolder = RemoveHtml(int_Modified_By.Caption);
            if (!Empty(int_Modified_By.EditValue) && IsNumeric(int_Modified_By.EditValue))
                int_Modified_By.EditValue = FormatNumber(int_Modified_By.EditValue, null);

            // bit_IsDeleted
            bit_IsDeleted.EditValue = bit_IsDeleted.Options(false);
            bit_IsDeleted.PlaceHolder = RemoveHtml(bit_IsDeleted.Caption);

            // str_CardHolderName
            str_CardHolderName.SetupEditAttributes();
            if (!str_CardHolderName.Raw)
                str_CardHolderName.CurrentValue = HtmlDecode(str_CardHolderName.CurrentValue);
            str_CardHolderName.EditValue = HtmlEncode(str_CardHolderName.CurrentValue);
            str_CardHolderName.PlaceHolder = RemoveHtml(str_CardHolderName.Caption);

            // str_CardHolderAddress
            str_CardHolderAddress.SetupEditAttributes();
            if (!str_CardHolderAddress.Raw)
                str_CardHolderAddress.CurrentValue = HtmlDecode(str_CardHolderAddress.CurrentValue);
            str_CardHolderAddress.EditValue = HtmlEncode(str_CardHolderAddress.CurrentValue);
            str_CardHolderAddress.PlaceHolder = RemoveHtml(str_CardHolderAddress.Caption);

            // str_CardHolderCity
            str_CardHolderCity.SetupEditAttributes();
            if (!str_CardHolderCity.Raw)
                str_CardHolderCity.CurrentValue = HtmlDecode(str_CardHolderCity.CurrentValue);
            str_CardHolderCity.EditValue = HtmlEncode(str_CardHolderCity.CurrentValue);
            str_CardHolderCity.PlaceHolder = RemoveHtml(str_CardHolderCity.Caption);

            // str_CardHolderZip
            str_CardHolderZip.SetupEditAttributes();
            if (!str_CardHolderZip.Raw)
                str_CardHolderZip.CurrentValue = HtmlDecode(str_CardHolderZip.CurrentValue);
            str_CardHolderZip.EditValue = HtmlEncode(str_CardHolderZip.CurrentValue);
            str_CardHolderZip.PlaceHolder = RemoveHtml(str_CardHolderZip.Caption);

            // str_CardType
            str_CardType.SetupEditAttributes();
            if (!str_CardType.Raw)
                str_CardType.CurrentValue = HtmlDecode(str_CardType.CurrentValue);
            str_CardType.EditValue = HtmlEncode(str_CardType.CurrentValue);
            str_CardType.PlaceHolder = RemoveHtml(str_CardType.Caption);

            // str_CardExpMonth
            str_CardExpMonth.SetupEditAttributes();
            if (!str_CardExpMonth.Raw)
                str_CardExpMonth.CurrentValue = HtmlDecode(str_CardExpMonth.CurrentValue);
            str_CardExpMonth.EditValue = HtmlEncode(str_CardExpMonth.CurrentValue);
            str_CardExpMonth.PlaceHolder = RemoveHtml(str_CardExpMonth.Caption);

            // str_CardExpYear
            str_CardExpYear.SetupEditAttributes();
            if (!str_CardExpYear.Raw)
                str_CardExpYear.CurrentValue = HtmlDecode(str_CardExpYear.CurrentValue);
            str_CardExpYear.EditValue = HtmlEncode(str_CardExpYear.CurrentValue);
            str_CardExpYear.PlaceHolder = RemoveHtml(str_CardExpYear.Caption);

            // str_CardNo
            str_CardNo.SetupEditAttributes();
            if (!str_CardNo.Raw)
                str_CardNo.CurrentValue = HtmlDecode(str_CardNo.CurrentValue);
            str_CardNo.EditValue = HtmlEncode(str_CardNo.CurrentValue);
            str_CardNo.PlaceHolder = RemoveHtml(str_CardNo.Caption);

            // str_Certificate_No
            str_Certificate_No.SetupEditAttributes();
            if (!str_Certificate_No.Raw)
                str_Certificate_No.CurrentValue = HtmlDecode(str_Certificate_No.CurrentValue);
            str_Certificate_No.EditValue = HtmlEncode(str_Certificate_No.CurrentValue);
            str_Certificate_No.PlaceHolder = RemoveHtml(str_Certificate_No.Caption);

            // str_AmountPaid
            str_AmountPaid.SetupEditAttributes();
            str_AmountPaid.EditValue = str_AmountPaid.CurrentValue; // DN
            str_AmountPaid.PlaceHolder = RemoveHtml(str_AmountPaid.Caption);
            if (!Empty(str_AmountPaid.EditValue) && IsNumeric(str_AmountPaid.EditValue))
                str_AmountPaid.EditValue = FormatNumber(str_AmountPaid.EditValue, null);

            // str_PermitValidated
            str_PermitValidated.SetupEditAttributes();
            if (!str_PermitValidated.Raw)
                str_PermitValidated.CurrentValue = HtmlDecode(str_PermitValidated.CurrentValue);
            str_PermitValidated.EditValue = HtmlEncode(str_PermitValidated.CurrentValue);
            str_PermitValidated.PlaceHolder = RemoveHtml(str_PermitValidated.Caption);

            // strSMSNotification
            strSMSNotification.SetupEditAttributes();
            if (!Empty(strSMSNotification.CurrentValue))
            {
                strSMSNotification.EditValue = strSMSNotification.HighlightLookup(ConvertToString(strSMSNotification.CurrentValue), strSMSNotification.OptionCaption(ConvertToString(strSMSNotification.CurrentValue)));
            }
            else
            {
                strSMSNotification.EditValue = DbNullValue;
            }
            strSMSNotification.ViewCustomAttributes = "";

            // strVoiceNotification
            strVoiceNotification.SetupEditAttributes();
            if (!strVoiceNotification.Raw)
                strVoiceNotification.CurrentValue = HtmlDecode(strVoiceNotification.CurrentValue);
            strVoiceNotification.EditValue = HtmlEncode(strVoiceNotification.CurrentValue);
            strVoiceNotification.PlaceHolder = RemoveHtml(strVoiceNotification.Caption);

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

            // bit_Verified_PIC_InSAW
            bit_Verified_PIC_InSAW.SetupEditAttributes();
            bit_Verified_PIC_InSAW.EditValue = bit_Verified_PIC_InSAW.CurrentValue; // DN
            bit_Verified_PIC_InSAW.PlaceHolder = RemoveHtml(bit_Verified_PIC_InSAW.Caption);
            if (!Empty(bit_Verified_PIC_InSAW.EditValue) && IsNumeric(bit_Verified_PIC_InSAW.EditValue))
                bit_Verified_PIC_InSAW.EditValue = FormatNumber(bit_Verified_PIC_InSAW.EditValue, null);

            // bit_Permit_Waiver_Entered
            bit_Permit_Waiver_Entered.SetupEditAttributes();
            bit_Permit_Waiver_Entered.EditValue = bit_Permit_Waiver_Entered.CurrentValue; // DN
            bit_Permit_Waiver_Entered.PlaceHolder = RemoveHtml(bit_Permit_Waiver_Entered.Caption);
            if (!Empty(bit_Permit_Waiver_Entered.EditValue) && IsNumeric(bit_Permit_Waiver_Entered.EditValue))
                bit_Permit_Waiver_Entered.EditValue = FormatNumber(bit_Permit_Waiver_Entered.EditValue, null);

            // bit_TermsConditions
            bit_TermsConditions.SetupEditAttributes();
            bit_TermsConditions.EditValue = bit_TermsConditions.CurrentValue; // DN
            bit_TermsConditions.PlaceHolder = RemoveHtml(bit_TermsConditions.Caption);
            if (!Empty(bit_TermsConditions.EditValue) && IsNumeric(bit_TermsConditions.EditValue))
                bit_TermsConditions.EditValue = FormatNumber(bit_TermsConditions.EditValue, null);

            // bit_Disable_Self_Scheduling
            bit_Disable_Self_Scheduling.SetupEditAttributes();
            bit_Disable_Self_Scheduling.EditValue = bit_Disable_Self_Scheduling.CurrentValue; // DN
            bit_Disable_Self_Scheduling.PlaceHolder = RemoveHtml(bit_Disable_Self_Scheduling.Caption);
            if (!Empty(bit_Disable_Self_Scheduling.EditValue) && IsNumeric(bit_Disable_Self_Scheduling.EditValue))
                bit_Disable_Self_Scheduling.EditValue = FormatNumber(bit_Disable_Self_Scheduling.EditValue, null);

            // int_EyeColor
            int_EyeColor.SetupEditAttributes();
            int_EyeColor.EditValue = int_EyeColor.CurrentValue; // DN
            int_EyeColor.PlaceHolder = RemoveHtml(int_EyeColor.Caption);
            if (!Empty(int_EyeColor.EditValue) && IsNumeric(int_EyeColor.EditValue))
                int_EyeColor.EditValue = FormatNumber(int_EyeColor.EditValue, null);

            // int_HairColor
            int_HairColor.SetupEditAttributes();
            int_HairColor.EditValue = int_HairColor.CurrentValue; // DN
            int_HairColor.PlaceHolder = RemoveHtml(int_HairColor.Caption);
            if (!Empty(int_HairColor.EditValue) && IsNumeric(int_HairColor.EditValue))
                int_HairColor.EditValue = FormatNumber(int_HairColor.EditValue, null);

            // int_ColorBlind
            int_ColorBlind.SetupEditAttributes();
            int_ColorBlind.EditValue = int_ColorBlind.CurrentValue; // DN
            int_ColorBlind.PlaceHolder = RemoveHtml(int_ColorBlind.Caption);
            if (!Empty(int_ColorBlind.EditValue) && IsNumeric(int_ColorBlind.EditValue))
                int_ColorBlind.EditValue = FormatNumber(int_ColorBlind.EditValue, null);

            // int_HeightFeet
            int_HeightFeet.SetupEditAttributes();
            int_HeightFeet.EditValue = int_HeightFeet.CurrentValue; // DN
            int_HeightFeet.PlaceHolder = RemoveHtml(int_HeightFeet.Caption);
            if (!Empty(int_HeightFeet.EditValue) && IsNumeric(int_HeightFeet.EditValue))
                int_HeightFeet.EditValue = FormatNumber(int_HeightFeet.EditValue, null);

            // int_HeightInches
            int_HeightInches.SetupEditAttributes();
            int_HeightInches.EditValue = int_HeightInches.CurrentValue; // DN
            int_HeightInches.PlaceHolder = RemoveHtml(int_HeightInches.Caption);
            if (!Empty(int_HeightInches.EditValue) && IsNumeric(int_HeightInches.EditValue))
                int_HeightInches.EditValue = FormatNumber(int_HeightInches.EditValue, null);

            // str_reference_code
            str_reference_code.SetupEditAttributes();
            if (!str_reference_code.Raw)
                str_reference_code.CurrentValue = HtmlDecode(str_reference_code.CurrentValue);
            str_reference_code.EditValue = HtmlEncode(str_reference_code.CurrentValue);
            str_reference_code.PlaceHolder = RemoveHtml(str_reference_code.Caption);

            // dt_ParentClassAttendedDt
            dt_ParentClassAttendedDt.SetupEditAttributes();
            dt_ParentClassAttendedDt.EditValue = FormatDateTime(dt_ParentClassAttendedDt.CurrentValue, dt_ParentClassAttendedDt.FormatPattern); // DN
            dt_ParentClassAttendedDt.PlaceHolder = RemoveHtml(dt_ParentClassAttendedDt.Caption);

            // str_ParentClassAttendedLoc
            str_ParentClassAttendedLoc.SetupEditAttributes();
            if (!str_ParentClassAttendedLoc.Raw)
                str_ParentClassAttendedLoc.CurrentValue = HtmlDecode(str_ParentClassAttendedLoc.CurrentValue);
            str_ParentClassAttendedLoc.EditValue = HtmlEncode(str_ParentClassAttendedLoc.CurrentValue);
            str_ParentClassAttendedLoc.PlaceHolder = RemoveHtml(str_ParentClassAttendedLoc.Caption);

            // dt_SiblingClassAttendedDt
            dt_SiblingClassAttendedDt.SetupEditAttributes();
            dt_SiblingClassAttendedDt.EditValue = FormatDateTime(dt_SiblingClassAttendedDt.CurrentValue, dt_SiblingClassAttendedDt.FormatPattern); // DN
            dt_SiblingClassAttendedDt.PlaceHolder = RemoveHtml(dt_SiblingClassAttendedDt.Caption);

            // str_SiblingClassAttendedLoc
            str_SiblingClassAttendedLoc.SetupEditAttributes();
            if (!str_SiblingClassAttendedLoc.Raw)
                str_SiblingClassAttendedLoc.CurrentValue = HtmlDecode(str_SiblingClassAttendedLoc.CurrentValue);
            str_SiblingClassAttendedLoc.EditValue = HtmlEncode(str_SiblingClassAttendedLoc.CurrentValue);
            str_SiblingClassAttendedLoc.PlaceHolder = RemoveHtml(str_SiblingClassAttendedLoc.Caption);

            // bit_PoliciesAndProcedures
            bit_PoliciesAndProcedures.EditValue = bit_PoliciesAndProcedures.Options(false);
            bit_PoliciesAndProcedures.PlaceHolder = RemoveHtml(bit_PoliciesAndProcedures.Caption);

            // dt_CourseCompletionDt
            dt_CourseCompletionDt.SetupEditAttributes();
            dt_CourseCompletionDt.EditValue = FormatDateTime(dt_CourseCompletionDt.CurrentValue, dt_CourseCompletionDt.FormatPattern); // DN
            dt_CourseCompletionDt.PlaceHolder = RemoveHtml(dt_CourseCompletionDt.Caption);

            // dt_ExtensionDt
            dt_ExtensionDt.SetupEditAttributes();
            dt_ExtensionDt.EditValue = FormatDateTime(dt_ExtensionDt.CurrentValue, dt_ExtensionDt.FormatPattern); // DN
            dt_ExtensionDt.PlaceHolder = RemoveHtml(dt_ExtensionDt.Caption);

            // str_MedicalCondition
            str_MedicalCondition.SetupEditAttributes();
            if (!str_MedicalCondition.Raw)
                str_MedicalCondition.CurrentValue = HtmlDecode(str_MedicalCondition.CurrentValue);
            str_MedicalCondition.EditValue = HtmlEncode(str_MedicalCondition.CurrentValue);
            str_MedicalCondition.PlaceHolder = RemoveHtml(str_MedicalCondition.Caption);

            // str_MajorCrossStreets
            str_MajorCrossStreets.SetupEditAttributes();
            if (!str_MajorCrossStreets.Raw)
                str_MajorCrossStreets.CurrentValue = HtmlDecode(str_MajorCrossStreets.CurrentValue);
            str_MajorCrossStreets.EditValue = HtmlEncode(str_MajorCrossStreets.CurrentValue);
            str_MajorCrossStreets.PlaceHolder = RemoveHtml(str_MajorCrossStreets.Caption);

            // str_DriverEdCertNo
            str_DriverEdCertNo.SetupEditAttributes();
            if (!str_DriverEdCertNo.Raw)
                str_DriverEdCertNo.CurrentValue = HtmlDecode(str_DriverEdCertNo.CurrentValue);
            str_DriverEdCertNo.EditValue = HtmlEncode(str_DriverEdCertNo.CurrentValue);
            str_DriverEdCertNo.PlaceHolder = RemoveHtml(str_DriverEdCertNo.Caption);

            // dt_DriverEdCertIssuedDt
            dt_DriverEdCertIssuedDt.SetupEditAttributes();
            dt_DriverEdCertIssuedDt.EditValue = FormatDateTime(dt_DriverEdCertIssuedDt.CurrentValue, dt_DriverEdCertIssuedDt.FormatPattern); // DN
            dt_DriverEdCertIssuedDt.PlaceHolder = RemoveHtml(dt_DriverEdCertIssuedDt.Caption);

            // str_BTWDriversEdCertNo
            str_BTWDriversEdCertNo.SetupEditAttributes();
            if (!str_BTWDriversEdCertNo.Raw)
                str_BTWDriversEdCertNo.CurrentValue = HtmlDecode(str_BTWDriversEdCertNo.CurrentValue);
            str_BTWDriversEdCertNo.EditValue = HtmlEncode(str_BTWDriversEdCertNo.CurrentValue);
            str_BTWDriversEdCertNo.PlaceHolder = RemoveHtml(str_BTWDriversEdCertNo.Caption);

            // dt_BTWCertIssuedDt
            dt_BTWCertIssuedDt.SetupEditAttributes();
            dt_BTWCertIssuedDt.EditValue = FormatDateTime(dt_BTWCertIssuedDt.CurrentValue, dt_BTWCertIssuedDt.FormatPattern); // DN
            dt_BTWCertIssuedDt.PlaceHolder = RemoveHtml(dt_BTWCertIssuedDt.Caption);

            // str_OLDriversEdCertNo
            str_OLDriversEdCertNo.SetupEditAttributes();
            if (!str_OLDriversEdCertNo.Raw)
                str_OLDriversEdCertNo.CurrentValue = HtmlDecode(str_OLDriversEdCertNo.CurrentValue);
            str_OLDriversEdCertNo.EditValue = HtmlEncode(str_OLDriversEdCertNo.CurrentValue);
            str_OLDriversEdCertNo.PlaceHolder = RemoveHtml(str_OLDriversEdCertNo.Caption);

            // dt_OLCertIssuedDt
            dt_OLCertIssuedDt.SetupEditAttributes();
            dt_OLCertIssuedDt.EditValue = FormatDateTime(dt_OLCertIssuedDt.CurrentValue, dt_OLCertIssuedDt.FormatPattern); // DN
            dt_OLCertIssuedDt.PlaceHolder = RemoveHtml(dt_OLCertIssuedDt.Caption);

            // str_height
            str_height.SetupEditAttributes();
            if (!str_height.Raw)
                str_height.CurrentValue = HtmlDecode(str_height.CurrentValue);
            str_height.EditValue = HtmlEncode(str_height.CurrentValue);
            str_height.PlaceHolder = RemoveHtml(str_height.Caption);

            // dt_BTWCompletionDt
            dt_BTWCompletionDt.SetupEditAttributes();
            dt_BTWCompletionDt.EditValue = FormatDateTime(dt_BTWCompletionDt.CurrentValue, dt_BTWCompletionDt.FormatPattern); // DN
            dt_BTWCompletionDt.PlaceHolder = RemoveHtml(dt_BTWCompletionDt.Caption);

            // dt_CRCompletionDt
            dt_CRCompletionDt.SetupEditAttributes();
            dt_CRCompletionDt.EditValue = FormatDateTime(dt_CRCompletionDt.CurrentValue, dt_CRCompletionDt.FormatPattern); // DN
            dt_CRCompletionDt.PlaceHolder = RemoveHtml(dt_CRCompletionDt.Caption);

            // strTextBox5
            strTextBox5.SetupEditAttributes();
            if (!strTextBox5.Raw)
                strTextBox5.CurrentValue = HtmlDecode(strTextBox5.CurrentValue);
            strTextBox5.EditValue = HtmlEncode(strTextBox5.CurrentValue);
            strTextBox5.PlaceHolder = RemoveHtml(strTextBox5.Caption);

            // strTextBox6
            strTextBox6.SetupEditAttributes();
            if (!strTextBox6.Raw)
                strTextBox6.CurrentValue = HtmlDecode(strTextBox6.CurrentValue);
            strTextBox6.EditValue = HtmlEncode(strTextBox6.CurrentValue);
            strTextBox6.PlaceHolder = RemoveHtml(strTextBox6.Caption);

            // str_ApartmentNo
            str_ApartmentNo.SetupEditAttributes();
            if (!str_ApartmentNo.Raw)
                str_ApartmentNo.CurrentValue = HtmlDecode(str_ApartmentNo.CurrentValue);
            str_ApartmentNo.EditValue = HtmlEncode(str_ApartmentNo.CurrentValue);
            str_ApartmentNo.PlaceHolder = RemoveHtml(str_ApartmentNo.Caption);

            // dt_PermitTestDate
            dt_PermitTestDate.SetupEditAttributes();
            dt_PermitTestDate.EditValue = FormatDateTime(dt_PermitTestDate.CurrentValue, dt_PermitTestDate.FormatPattern); // DN
            dt_PermitTestDate.PlaceHolder = RemoveHtml(dt_PermitTestDate.Caption);

            // str_OnlineDriverEdLogin
            str_OnlineDriverEdLogin.SetupEditAttributes();
            if (!str_OnlineDriverEdLogin.Raw)
                str_OnlineDriverEdLogin.CurrentValue = HtmlDecode(str_OnlineDriverEdLogin.CurrentValue);
            str_OnlineDriverEdLogin.EditValue = HtmlEncode(str_OnlineDriverEdLogin.CurrentValue);
            str_OnlineDriverEdLogin.PlaceHolder = RemoveHtml(str_OnlineDriverEdLogin.Caption);

            // str_OnlineDriverEdPassword
            str_OnlineDriverEdPassword.SetupEditAttributes();
            if (!str_OnlineDriverEdPassword.Raw)
                str_OnlineDriverEdPassword.CurrentValue = HtmlDecode(str_OnlineDriverEdPassword.CurrentValue);
            str_OnlineDriverEdPassword.EditValue = HtmlEncode(str_OnlineDriverEdPassword.CurrentValue);
            str_OnlineDriverEdPassword.PlaceHolder = RemoveHtml(str_OnlineDriverEdPassword.Caption);

            // bit_IsSMSEnabled
            bit_IsSMSEnabled.EditValue = bit_IsSMSEnabled.Options(false);
            bit_IsSMSEnabled.PlaceHolder = RemoveHtml(bit_IsSMSEnabled.Caption);

            // dt_SMSModified
            dt_SMSModified.SetupEditAttributes();
            dt_SMSModified.EditValue = FormatDateTime(dt_SMSModified.CurrentValue, dt_SMSModified.FormatPattern); // DN
            dt_SMSModified.PlaceHolder = RemoveHtml(dt_SMSModified.Caption);

            // str_confirmPassword
            str_confirmPassword.SetupEditAttributes();
            if (!str_confirmPassword.Raw)
                str_confirmPassword.CurrentValue = HtmlDecode(str_confirmPassword.CurrentValue);
            str_confirmPassword.EditValue = HtmlEncode(str_confirmPassword.CurrentValue);
            str_confirmPassword.PlaceHolder = RemoveHtml(str_confirmPassword.Caption);

            // DE_Certificate
            DE_Certificate.SetupEditAttributes();
            if (!DE_Certificate.Raw)
                DE_Certificate.CurrentValue = HtmlDecode(DE_Certificate.CurrentValue);
            DE_Certificate.EditValue = HtmlEncode(DE_Certificate.CurrentValue);
            DE_Certificate.PlaceHolder = RemoveHtml(DE_Certificate.Caption);

            // Discuss
            Discuss.SetupEditAttributes();
            if (!Discuss.Raw)
                Discuss.CurrentValue = HtmlDecode(Discuss.CurrentValue);
            Discuss.EditValue = HtmlEncode(Discuss.CurrentValue);
            Discuss.PlaceHolder = RemoveHtml(Discuss.Caption);

            // int_UnlicensedSibling
            int_UnlicensedSibling.SetupEditAttributes();
            int_UnlicensedSibling.EditValue = int_UnlicensedSibling.CurrentValue; // DN
            int_UnlicensedSibling.PlaceHolder = RemoveHtml(int_UnlicensedSibling.Caption);
            if (!Empty(int_UnlicensedSibling.EditValue) && IsNumeric(int_UnlicensedSibling.EditValue))
                int_UnlicensedSibling.EditValue = FormatNumber(int_UnlicensedSibling.EditValue, null);

            // int_YearSiblingIsEligible
            int_YearSiblingIsEligible.SetupEditAttributes();
            int_YearSiblingIsEligible.EditValue = int_YearSiblingIsEligible.CurrentValue; // DN
            int_YearSiblingIsEligible.PlaceHolder = RemoveHtml(int_YearSiblingIsEligible.Caption);
            if (!Empty(int_YearSiblingIsEligible.EditValue) && IsNumeric(int_YearSiblingIsEligible.EditValue))
                int_YearSiblingIsEligible.EditValue = FormatNumber(int_YearSiblingIsEligible.EditValue, null);

            // BTW_Certificate
            BTW_Certificate.SetupEditAttributes();
            if (!BTW_Certificate.Raw)
                BTW_Certificate.CurrentValue = HtmlDecode(BTW_Certificate.CurrentValue);
            BTW_Certificate.EditValue = HtmlEncode(BTW_Certificate.CurrentValue);
            BTW_Certificate.PlaceHolder = RemoveHtml(BTW_Certificate.Caption);

            // dt_DECertIssueDate
            dt_DECertIssueDate.SetupEditAttributes();
            if (!dt_DECertIssueDate.Raw)
                dt_DECertIssueDate.CurrentValue = HtmlDecode(dt_DECertIssueDate.CurrentValue);
            dt_DECertIssueDate.EditValue = HtmlEncode(dt_DECertIssueDate.CurrentValue);
            dt_DECertIssueDate.PlaceHolder = RemoveHtml(dt_DECertIssueDate.Caption);

            // str_StudentSignature
            str_StudentSignature.SetupEditAttributes();
            if (!str_StudentSignature.Raw)
                str_StudentSignature.CurrentValue = HtmlDecode(str_StudentSignature.CurrentValue);
            str_StudentSignature.EditValue = HtmlEncode(str_StudentSignature.CurrentValue);
            str_StudentSignature.PlaceHolder = RemoveHtml(str_StudentSignature.Caption);

            // str_ParentSignature
            str_ParentSignature.SetupEditAttributes();
            if (!str_ParentSignature.Raw)
                str_ParentSignature.CurrentValue = HtmlDecode(str_ParentSignature.CurrentValue);
            str_ParentSignature.EditValue = HtmlEncode(str_ParentSignature.CurrentValue);
            str_ParentSignature.PlaceHolder = RemoveHtml(str_ParentSignature.Caption);

            // str_Last6DigitsOfParentDriversLicense
            str_Last6DigitsOfParentDriversLicense.SetupEditAttributes();
            if (!str_Last6DigitsOfParentDriversLicense.Raw)
                str_Last6DigitsOfParentDriversLicense.CurrentValue = HtmlDecode(str_Last6DigitsOfParentDriversLicense.CurrentValue);
            str_Last6DigitsOfParentDriversLicense.EditValue = HtmlEncode(str_Last6DigitsOfParentDriversLicense.CurrentValue);
            str_Last6DigitsOfParentDriversLicense.PlaceHolder = RemoveHtml(str_Last6DigitsOfParentDriversLicense.Caption);

            // str_FACControl
            str_FACControl.SetupEditAttributes();
            if (!str_FACControl.Raw)
                str_FACControl.CurrentValue = HtmlDecode(str_FACControl.CurrentValue);
            str_FACControl.EditValue = HtmlEncode(str_FACControl.CurrentValue);
            str_FACControl.PlaceHolder = RemoveHtml(str_FACControl.Caption);

            // Classroom_Status_Code
            Classroom_Status_Code.SetupEditAttributes();
            if (!Classroom_Status_Code.Raw)
                Classroom_Status_Code.CurrentValue = HtmlDecode(Classroom_Status_Code.CurrentValue);
            Classroom_Status_Code.EditValue = HtmlEncode(Classroom_Status_Code.CurrentValue);
            Classroom_Status_Code.PlaceHolder = RemoveHtml(Classroom_Status_Code.Caption);

            // Laboratory_Status_Code
            Laboratory_Status_Code.SetupEditAttributes();
            if (!Laboratory_Status_Code.Raw)
                Laboratory_Status_Code.CurrentValue = HtmlDecode(Laboratory_Status_Code.CurrentValue);
            Laboratory_Status_Code.EditValue = HtmlEncode(Laboratory_Status_Code.CurrentValue);
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
            int_SF_GR_WA_HS.EditValue = int_SF_GR_WA_HS.CurrentValue; // DN
            int_SF_GR_WA_HS.PlaceHolder = RemoveHtml(int_SF_GR_WA_HS.Caption);
            if (!Empty(int_SF_GR_WA_HS.EditValue) && IsNumeric(int_SF_GR_WA_HS.EditValue))
                int_SF_GR_WA_HS.EditValue = FormatNumber(int_SF_GR_WA_HS.EditValue, null);

            // bit_DisableOnRMV
            bit_DisableOnRMV.EditValue = bit_DisableOnRMV.Options(false);
            bit_DisableOnRMV.PlaceHolder = RemoveHtml(bit_DisableOnRMV.Caption);

            // bit_UploadedToRMV
            bit_UploadedToRMV.EditValue = bit_UploadedToRMV.Options(false);
            bit_UploadedToRMV.PlaceHolder = RemoveHtml(bit_UploadedToRMV.Caption);

            // str_Mother_Name
            str_Mother_Name.SetupEditAttributes();
            if (!str_Mother_Name.Raw)
                str_Mother_Name.CurrentValue = HtmlDecode(str_Mother_Name.CurrentValue);
            str_Mother_Name.EditValue = HtmlEncode(str_Mother_Name.CurrentValue);
            str_Mother_Name.PlaceHolder = RemoveHtml(str_Mother_Name.Caption);

            // str_Guardians_Name
            str_Guardians_Name.SetupEditAttributes();
            if (!str_Guardians_Name.Raw)
                str_Guardians_Name.CurrentValue = HtmlDecode(str_Guardians_Name.CurrentValue);
            str_Guardians_Name.EditValue = HtmlEncode(str_Guardians_Name.CurrentValue);
            str_Guardians_Name.PlaceHolder = RemoveHtml(str_Guardians_Name.Caption);

            // str_Mother_Phone
            str_Mother_Phone.SetupEditAttributes();
            if (!str_Mother_Phone.Raw)
                str_Mother_Phone.CurrentValue = HtmlDecode(str_Mother_Phone.CurrentValue);
            str_Mother_Phone.EditValue = HtmlEncode(str_Mother_Phone.CurrentValue);
            str_Mother_Phone.PlaceHolder = RemoveHtml(str_Mother_Phone.Caption);

            // bit_terms
            bit_terms.EditValue = bit_terms.Options(false);
            bit_terms.PlaceHolder = RemoveHtml(bit_terms.Caption);

            // int_Nationality
            int_Nationality.SetupEditAttributes();
            int_Nationality.EditValue = int_Nationality.CurrentValue;
            int_Nationality.EditValue = FormatNumber(int_Nationality.EditValue, int_Nationality.FormatPattern);
            int_Nationality.ViewCustomAttributes = "";

            // str_National_ID_en
            str_National_ID_en.SetupEditAttributes();
            if (!str_National_ID_en.Raw)
                str_National_ID_en.CurrentValue = HtmlDecode(str_National_ID_en.CurrentValue);
            str_National_ID_en.EditValue = HtmlEncode(str_National_ID_en.CurrentValue);
            str_National_ID_en.PlaceHolder = RemoveHtml(str_National_ID_en.Caption);

            // str_National_ID_arabic
            str_National_ID_arabic.SetupEditAttributes();
            if (!str_National_ID_arabic.Raw)
                str_National_ID_arabic.CurrentValue = HtmlDecode(str_National_ID_arabic.CurrentValue);
            str_National_ID_arabic.EditValue = HtmlEncode(str_National_ID_arabic.CurrentValue);
            str_National_ID_arabic.PlaceHolder = RemoveHtml(str_National_ID_arabic.Caption);

            // Quallification_Id
            Quallification_Id.SetupEditAttributes();
            Quallification_Id.EditValue = Quallification_Id.CurrentValue; // DN
            Quallification_Id.PlaceHolder = RemoveHtml(Quallification_Id.Caption);
            if (!Empty(Quallification_Id.EditValue) && IsNumeric(Quallification_Id.EditValue))
                Quallification_Id.EditValue = FormatNumber(Quallification_Id.EditValue, null);

            // Job_Id
            Job_Id.SetupEditAttributes();
            Job_Id.EditValue = Job_Id.CurrentValue; // DN
            Job_Id.PlaceHolder = RemoveHtml(Job_Id.Caption);
            if (!Empty(Job_Id.EditValue) && IsNumeric(Job_Id.EditValue))
                Job_Id.EditValue = FormatNumber(Job_Id.EditValue, null);

            // str_DOB_arabic
            str_DOB_arabic.PlaceHolder = RemoveHtml(str_DOB_arabic.Caption);

            // int_Language
            int_Language.SetupEditAttributes();
            int_Language.EditValue = int_Language.CurrentValue; // DN
            int_Language.PlaceHolder = RemoveHtml(int_Language.Caption);
            if (!Empty(int_Language.EditValue) && IsNumeric(int_Language.EditValue))
                int_Language.EditValue = FormatNumber(int_Language.EditValue, null);

            // strRefId
            strRefId.SetupEditAttributes();
            if (!strRefId.Raw)
                strRefId.CurrentValue = HtmlDecode(strRefId.CurrentValue);
            strRefId.EditValue = HtmlEncode(strRefId.CurrentValue);
            strRefId.PlaceHolder = RemoveHtml(strRefId.Caption);

            // int_Program_Id
            int_Program_Id.SetupEditAttributes();
            int_Program_Id.EditValue = int_Program_Id.Options(true);
            int_Program_Id.PlaceHolder = RemoveHtml(int_Program_Id.Caption);
            if (!Empty(int_Program_Id.EditValue) && IsNumeric(int_Program_Id.EditValue))
                int_Program_Id.EditValue = FormatNumber(int_Program_Id.EditValue, null);

            // IsDrivingexperience
            IsDrivingexperience.SetupEditAttributes();
            if (ConvertToBool(IsDrivingexperience.CurrentValue))
            {
                IsDrivingexperience.EditValue = IsDrivingexperience.TagCaption(1) != "" ? IsDrivingexperience.TagCaption(1) : "Yes";
            }
            else
            {
                IsDrivingexperience.EditValue = IsDrivingexperience.TagCaption(2) != "" ? IsDrivingexperience.TagCaption(2) : "No";
            }
            IsDrivingexperience.ViewCustomAttributes = "";

            // IsScheduleassessment
            IsScheduleassessment.SetupEditAttributes();
            if (ConvertToBool(IsScheduleassessment.CurrentValue))
            {
                IsScheduleassessment.EditValue = IsScheduleassessment.TagCaption(1) != "" ? IsScheduleassessment.TagCaption(1) : "Yes";
            }
            else
            {
                IsScheduleassessment.EditValue = IsScheduleassessment.TagCaption(2) != "" ? IsScheduleassessment.TagCaption(2) : "No";
            }
            IsScheduleassessment.ViewCustomAttributes = "";

            // IsEnrollbyyourself
            IsEnrollbyyourself.EditValue = IsEnrollbyyourself.Options(false);
            IsEnrollbyyourself.PlaceHolder = RemoveHtml(IsEnrollbyyourself.Caption);

            // AssessmentTime
            AssessmentTime.SetupEditAttributes();
            if (!AssessmentTime.Raw)
                AssessmentTime.CurrentValue = HtmlDecode(AssessmentTime.CurrentValue);
            AssessmentTime.EditValue = HtmlEncode(AssessmentTime.CurrentValue);
            AssessmentTime.PlaceHolder = RemoveHtml(AssessmentTime.Caption);

            // AssessmentDate
            AssessmentDate.SetupEditAttributes();
            AssessmentDate.EditValue = AssessmentDate.CurrentValue;
            AssessmentDate.EditValue = FormatDateTime(AssessmentDate.EditValue, AssessmentDate.FormatPattern);
            AssessmentDate.ViewCustomAttributes = "";

            // isAssessmentDone
            isAssessmentDone.SetupEditAttributes();
            if (ConvertToBool(isAssessmentDone.CurrentValue))
            {
                isAssessmentDone.EditValue = isAssessmentDone.TagCaption(1) != "" ? isAssessmentDone.TagCaption(1) : "Yes";
            }
            else
            {
                isAssessmentDone.EditValue = isAssessmentDone.TagCaption(2) != "" ? isAssessmentDone.TagCaption(2) : "No";
            }
            isAssessmentDone.ViewCustomAttributes = "";

            // AssessmentScore
            AssessmentScore.SetupEditAttributes();
            AssessmentScore.EditValue = AssessmentScore.CurrentValue;
            AssessmentScore.ViewCustomAttributes = "";

            // dt_WrittenTestPassed
            dt_WrittenTestPassed.SetupEditAttributes();
            if (!Empty(dt_WrittenTestPassed.CurrentValue))
            {
                var optionsWrk = new OptionValues();
                arWrk = ConvertToString(dt_WrittenTestPassed.CurrentValue).Split(Config.MultipleOptionSeparator);
                for (int i = 0; i < arWrk.Length; i++)
                {
                    optionsWrk.Add(dt_WrittenTestPassed.HighlightLookup(arWrk[i].Trim(), dt_WrittenTestPassed.OptionCaption(arWrk[i].Trim())));
                }
                dt_WrittenTestPassed.EditValue = optionsWrk.ToString(); // DN
            }
            else
            {
                dt_WrittenTestPassed.EditValue = DbNullValue;
            }
            dt_WrittenTestPassed.ViewCustomAttributes = "";

            // dt_RoadTestPassed
            dt_RoadTestPassed.SetupEditAttributes();
            if (!Empty(dt_RoadTestPassed.CurrentValue))
            {
                var optionsWrk = new OptionValues();
                arWrk = ConvertToString(dt_RoadTestPassed.CurrentValue).Split(Config.MultipleOptionSeparator);
                for (int i = 0; i < arWrk.Length; i++)
                {
                    optionsWrk.Add(dt_RoadTestPassed.HighlightLookup(arWrk[i].Trim(), dt_RoadTestPassed.OptionCaption(arWrk[i].Trim())));
                }
                dt_RoadTestPassed.EditValue = optionsWrk.ToString(); // DN
            }
            else
            {
                dt_RoadTestPassed.EditValue = DbNullValue;
            }
            dt_RoadTestPassed.ViewCustomAttributes = "";

            // bit_Archive
            bit_Archive.EditValue = bit_Archive.Options(false);
            bit_Archive.PlaceHolder = RemoveHtml(bit_Archive.Caption);

            // ArchiveNotes
            ArchiveNotes.SetupEditAttributes();
            if (!ArchiveNotes.Raw)
                ArchiveNotes.CurrentValue = HtmlDecode(ArchiveNotes.CurrentValue);
            ArchiveNotes.EditValue = HtmlEncode(ArchiveNotes.CurrentValue);
            ArchiveNotes.PlaceHolder = RemoveHtml(ArchiveNotes.Caption);

            // dtArchived
            dtArchived.SetupEditAttributes();
            dtArchived.EditValue = FormatDateTime(dtArchived.CurrentValue, dtArchived.FormatPattern); // DN
            dtArchived.PlaceHolder = RemoveHtml(dtArchived.Caption);

            // SrNo9Dec21
            SrNo9Dec21.SetupEditAttributes();
            SrNo9Dec21.EditValue = SrNo9Dec21.CurrentValue; // DN
            SrNo9Dec21.PlaceHolder = RemoveHtml(SrNo9Dec21.Caption);
            if (!Empty(SrNo9Dec21.EditValue) && IsNumeric(SrNo9Dec21.EditValue))
                SrNo9Dec21.EditValue = FormatNumber(SrNo9Dec21.EditValue, null);

            // REGNNUMB
            REGNNUMB.SetupEditAttributes();
            if (!REGNNUMB.Raw)
                REGNNUMB.CurrentValue = HtmlDecode(REGNNUMB.CurrentValue);
            REGNNUMB.EditValue = HtmlEncode(REGNNUMB.CurrentValue);
            REGNNUMB.PlaceHolder = RemoveHtml(REGNNUMB.Caption);

            // REGNLOCN
            REGNLOCN.SetupEditAttributes();
            if (!REGNLOCN.Raw)
                REGNLOCN.CurrentValue = HtmlDecode(REGNLOCN.CurrentValue);
            REGNLOCN.EditValue = HtmlEncode(REGNLOCN.CurrentValue);
            REGNLOCN.PlaceHolder = RemoveHtml(REGNLOCN.Caption);

            // SrNo11DecF1S1
            SrNo11DecF1S1.SetupEditAttributes();
            SrNo11DecF1S1.EditValue = SrNo11DecF1S1.CurrentValue; // DN
            SrNo11DecF1S1.PlaceHolder = RemoveHtml(SrNo11DecF1S1.Caption);
            if (!Empty(SrNo11DecF1S1.EditValue) && IsNumeric(SrNo11DecF1S1.EditValue))
                SrNo11DecF1S1.EditValue = FormatNumber(SrNo11DecF1S1.EditValue, null);

            // IsInterestedInTraining
            IsInterestedInTraining.SetupEditAttributes();
            IsInterestedInTraining.EditValue = IsInterestedInTraining.CurrentValue; // DN
            IsInterestedInTraining.PlaceHolder = RemoveHtml(IsInterestedInTraining.Caption);
            if (!Empty(IsInterestedInTraining.EditValue) && IsNumeric(IsInterestedInTraining.EditValue))
                IsInterestedInTraining.EditValue = FormatNumber(IsInterestedInTraining.EditValue, null);

            // StudentEncryptID
            StudentEncryptID.SetupEditAttributes();
            if (!StudentEncryptID.Raw)
                StudentEncryptID.CurrentValue = HtmlDecode(StudentEncryptID.CurrentValue);
            StudentEncryptID.EditValue = HtmlEncode(StudentEncryptID.CurrentValue);
            StudentEncryptID.PlaceHolder = RemoveHtml(StudentEncryptID.Caption);

            // StudentConfirURL
            StudentConfirURL.SetupEditAttributes();
            if (!StudentConfirURL.Raw)
                StudentConfirURL.CurrentValue = HtmlDecode(StudentConfirURL.CurrentValue);
            StudentConfirURL.EditValue = HtmlEncode(StudentConfirURL.CurrentValue);
            StudentConfirURL.PlaceHolder = RemoveHtml(StudentConfirURL.Caption);

            // SrNo15DecF1S2
            SrNo15DecF1S2.SetupEditAttributes();
            SrNo15DecF1S2.EditValue = SrNo15DecF1S2.CurrentValue; // DN
            SrNo15DecF1S2.PlaceHolder = RemoveHtml(SrNo15DecF1S2.Caption);
            if (!Empty(SrNo15DecF1S2.EditValue) && IsNumeric(SrNo15DecF1S2.EditValue))
                SrNo15DecF1S2.EditValue = FormatNumber(SrNo15DecF1S2.EditValue, null);

            // SrNo15DecF1S3
            SrNo15DecF1S3.SetupEditAttributes();
            SrNo15DecF1S3.EditValue = SrNo15DecF1S3.CurrentValue; // DN
            SrNo15DecF1S3.PlaceHolder = RemoveHtml(SrNo15DecF1S3.Caption);
            if (!Empty(SrNo15DecF1S3.EditValue) && IsNumeric(SrNo15DecF1S3.EditValue))
                SrNo15DecF1S3.EditValue = FormatNumber(SrNo15DecF1S3.EditValue, null);

            // SrNo16DecF2S2
            SrNo16DecF2S2.SetupEditAttributes();
            SrNo16DecF2S2.EditValue = SrNo16DecF2S2.CurrentValue; // DN
            SrNo16DecF2S2.PlaceHolder = RemoveHtml(SrNo16DecF2S2.Caption);
            if (!Empty(SrNo16DecF2S2.EditValue) && IsNumeric(SrNo16DecF2S2.EditValue))
                SrNo16DecF2S2.EditValue = FormatNumber(SrNo16DecF2S2.EditValue, null);

            // SrNo16DecF2S3
            SrNo16DecF2S3.SetupEditAttributes();
            SrNo16DecF2S3.EditValue = SrNo16DecF2S3.CurrentValue; // DN
            SrNo16DecF2S3.PlaceHolder = RemoveHtml(SrNo16DecF2S3.Caption);
            if (!Empty(SrNo16DecF2S3.EditValue) && IsNumeric(SrNo16DecF2S3.EditValue))
                SrNo16DecF2S3.EditValue = FormatNumber(SrNo16DecF2S3.EditValue, null);

            // SrNo16DecF3S1
            SrNo16DecF3S1.SetupEditAttributes();
            SrNo16DecF3S1.EditValue = SrNo16DecF3S1.CurrentValue; // DN
            SrNo16DecF3S1.PlaceHolder = RemoveHtml(SrNo16DecF3S1.Caption);
            if (!Empty(SrNo16DecF3S1.EditValue) && IsNumeric(SrNo16DecF3S1.EditValue))
                SrNo16DecF3S1.EditValue = FormatNumber(SrNo16DecF3S1.EditValue, null);

            // SrNo16DecF3S2
            SrNo16DecF3S2.SetupEditAttributes();
            SrNo16DecF3S2.EditValue = SrNo16DecF3S2.CurrentValue; // DN
            SrNo16DecF3S2.PlaceHolder = RemoveHtml(SrNo16DecF3S2.Caption);
            if (!Empty(SrNo16DecF3S2.EditValue) && IsNumeric(SrNo16DecF3S2.EditValue))
                SrNo16DecF3S2.EditValue = FormatNumber(SrNo16DecF3S2.EditValue, null);

            // SrNo16DecF4S1
            SrNo16DecF4S1.SetupEditAttributes();
            SrNo16DecF4S1.EditValue = SrNo16DecF4S1.CurrentValue; // DN
            SrNo16DecF4S1.PlaceHolder = RemoveHtml(SrNo16DecF4S1.Caption);
            if (!Empty(SrNo16DecF4S1.EditValue) && IsNumeric(SrNo16DecF4S1.EditValue))
                SrNo16DecF4S1.EditValue = FormatNumber(SrNo16DecF4S1.EditValue, null);

            // SrNo16DecF4S2
            SrNo16DecF4S2.SetupEditAttributes();
            SrNo16DecF4S2.EditValue = SrNo16DecF4S2.CurrentValue; // DN
            SrNo16DecF4S2.PlaceHolder = RemoveHtml(SrNo16DecF4S2.Caption);
            if (!Empty(SrNo16DecF4S2.EditValue) && IsNumeric(SrNo16DecF4S2.EditValue))
                SrNo16DecF4S2.EditValue = FormatNumber(SrNo16DecF4S2.EditValue, null);

            // SrNo16DecF4S3
            SrNo16DecF4S3.SetupEditAttributes();
            SrNo16DecF4S3.EditValue = SrNo16DecF4S3.CurrentValue; // DN
            SrNo16DecF4S3.PlaceHolder = RemoveHtml(SrNo16DecF4S3.Caption);
            if (!Empty(SrNo16DecF4S3.EditValue) && IsNumeric(SrNo16DecF4S3.EditValue))
                SrNo16DecF4S3.EditValue = FormatNumber(SrNo16DecF4S3.EditValue, null);

            // StudentAssementBookingURL
            StudentAssementBookingURL.SetupEditAttributes();
            if (!StudentAssementBookingURL.Raw)
                StudentAssementBookingURL.CurrentValue = HtmlDecode(StudentAssementBookingURL.CurrentValue);
            StudentAssementBookingURL.EditValue = HtmlEncode(StudentAssementBookingURL.CurrentValue);
            StudentAssementBookingURL.PlaceHolder = RemoveHtml(StudentAssementBookingURL.Caption);

            // intDrivinglicenseType
            intDrivinglicenseType.SetupEditAttributes();
            intDrivinglicenseType.EditValue = intDrivinglicenseType.CurrentValue; // DN
            intDrivinglicenseType.PlaceHolder = RemoveHtml(intDrivinglicenseType.Caption);
            if (!Empty(intDrivinglicenseType.EditValue) && IsNumeric(intDrivinglicenseType.EditValue))
                intDrivinglicenseType.EditValue = FormatNumber(intDrivinglicenseType.EditValue, null);

            // Isdrivinglicense
            Isdrivinglicense.EditValue = Isdrivinglicense.Options(false);
            Isdrivinglicense.PlaceHolder = RemoveHtml(Isdrivinglicense.Caption);

            // drivinglicensenumber
            drivinglicensenumber.SetupEditAttributes();
            if (!drivinglicensenumber.Raw)
                drivinglicensenumber.CurrentValue = HtmlDecode(drivinglicensenumber.CurrentValue);
            drivinglicensenumber.EditValue = HtmlEncode(drivinglicensenumber.CurrentValue);
            drivinglicensenumber.PlaceHolder = RemoveHtml(drivinglicensenumber.Caption);

            // Absher_Appointment_number
            Absher_Appointment_number.SetupEditAttributes();
            Absher_Appointment_number.EditValue = ConvertToString(Absher_Appointment_number.CurrentValue); // DN
            Absher_Appointment_number.ViewCustomAttributes = "";

            // DataImportId
            DataImportId.SetupEditAttributes();
            DataImportId.EditValue = DataImportId.CurrentValue; // DN
            DataImportId.PlaceHolder = RemoveHtml(DataImportId.Caption);
            if (!Empty(DataImportId.EditValue) && IsNumeric(DataImportId.EditValue))
                DataImportId.EditValue = FormatNumber(DataImportId.EditValue, null);

            // date_Birth_Hijri
            date_Birth_Hijri.SetupEditAttributes();
            date_Birth_Hijri.EditValue = ConvertToString(date_Birth_Hijri.CurrentValue); // DN
            date_Birth_Hijri.ViewCustomAttributes = "";

            // UserlevelID
            UserlevelID.SetupEditAttributes();
            UserlevelID.EditValue = UserlevelID.CurrentValue; // DN
            UserlevelID.PlaceHolder = RemoveHtml(UserlevelID.Caption);
            if (!Empty(UserlevelID.EditValue) && IsNumeric(UserlevelID.EditValue))
                UserlevelID.EditValue = FormatNumber(UserlevelID.EditValue, null);

            // Activated
            Activated.SetupEditAttributes();
            if (ConvertToBool(Activated.CurrentValue))
            {
                Activated.EditValue = Activated.TagCaption(1) != "" ? Activated.TagCaption(1) : "Yes";
            }
            else
            {
                Activated.EditValue = Activated.TagCaption(2) != "" ? Activated.TagCaption(2) : "No";
            }
            Activated.ViewCustomAttributes = "";

            // Absherphoto
            Absherphoto.SetupEditAttributes();
            Absherphoto.EditValue = ConvertToString(Absherphoto.CurrentValue); // DN
            Absherphoto.ViewCustomAttributes = "";

            // Fingerprint
            Fingerprint.SetupEditAttributes();
            if (!Fingerprint.Raw)
                Fingerprint.CurrentValue = HtmlDecode(Fingerprint.CurrentValue);
            Fingerprint.EditValue = HtmlEncode(Fingerprint.CurrentValue);
            Fingerprint.PlaceHolder = RemoveHtml(Fingerprint.Caption);

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

            // Course_Price
            Course_Price.SetupEditAttributes();
            Course_Price.EditValue = Course_Price.CurrentValue; // DN
            Course_Price.PlaceHolder = RemoveHtml(Course_Price.Caption);
            if (!Empty(Course_Price.EditValue) && IsNumeric(Course_Price.EditValue))
                Course_Price.EditValue = FormatNumber(Course_Price.EditValue, null);

            // Vat_Tax_15
            Vat_Tax_15.SetupEditAttributes();
            Vat_Tax_15.EditValue = Vat_Tax_15.CurrentValue; // DN
            Vat_Tax_15.PlaceHolder = RemoveHtml(Vat_Tax_15.Caption);
            if (!Empty(Vat_Tax_15.EditValue) && IsNumeric(Vat_Tax_15.EditValue))
                Vat_Tax_15.EditValue = FormatNumber(Vat_Tax_15.EditValue, null);

            // dec_Balance
            dec_Balance.SetupEditAttributes();
            dec_Balance.EditValue = dec_Balance.CurrentValue;
            dec_Balance.EditValue = FormatCurrency(dec_Balance.EditValue, dec_Balance.FormatPattern);
            dec_Balance.ViewCustomAttributes = "";

            // Total_Price
            Total_Price.SetupEditAttributes();
            Total_Price.EditValue = Total_Price.CurrentValue; // DN
            Total_Price.PlaceHolder = RemoveHtml(Total_Price.Caption);
            if (!Empty(Total_Price.EditValue) && IsNumeric(Total_Price.EditValue))
                Total_Price.EditValue = FormatNumber(Total_Price.EditValue, null);

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

            // Assessment_ID
            Assessment_ID.SetupEditAttributes();
            Assessment_ID.EditValue = Assessment_ID.CurrentValue; // DN
            Assessment_ID.PlaceHolder = RemoveHtml(Assessment_ID.Caption);
            if (!Empty(Assessment_ID.EditValue) && IsNumeric(Assessment_ID.EditValue))
                Assessment_ID.EditValue = FormatNumber(Assessment_ID.EditValue, null);

            // Call Row Rendered event
            RowRendered();
        }
#pragma warning restore 1998

        // Aggregate list row values
        public void AggregateListRowValues()
        {
        }

#pragma warning disable 1998
        // Aggregate list row (for rendering)
        public async Task AggregateListRow()
        {
            // Call Row Rendered event
            RowRendered();
        }
#pragma warning restore 1998

        // Export data in HTML/CSV/Word/Excel/Email/PDF format
        public async Task ExportDocument(dynamic doc, DbDataReader dataReader, int startRec, int stopRec, string exportType = "")
        {
            if (doc == null)
                return;
            if (dataReader == null)
                return;
            if (!doc.ExportCustom)
            {
                // Write header
                doc.ExportTableHeader();
                if (doc.Horizontal)
                { // Horizontal format, write header
                    doc.BeginExportRow();
                    if (exportType == "view")
                    {
                        doc.ExportCaption(str_NationalID_Iqama);
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(str_First_Name);
                        doc.ExportCaption(str_Middle_Name);
                        doc.ExportCaption(str_Last_Name);
                        doc.ExportCaption(str_Address1);
                        doc.ExportCaption(str_Address2);
                        doc.ExportCaption(int_State);
                        doc.ExportCaption(str_City);
                        doc.ExportCaption(str_Zip);
                        doc.ExportCaption(int_Instructor);
                        doc.ExportCaption(str_Home_Phone);
                        doc.ExportCaption(str_Cell_Phone);
                        doc.ExportCaption(str_Parent_Phone);
                        doc.ExportCaption(str_Email);
                        doc.ExportCaption(str_ParentName);
                        doc.ExportCaption(str_ParentEmail2);
                        doc.ExportCaption(str_DOB);
                        doc.ExportCaption(int_Age);
                        doc.ExportCaption(int_Sex);
                        doc.ExportCaption(str_Emergency_Contact_Name);
                        doc.ExportCaption(str_Emergency_Contact_Phone);
                        doc.ExportCaption(str_Emergency_Contact_Relation);
                        doc.ExportCaption(str_Student_Notes);
                        doc.ExportCaption(int_Location_Id);
                        doc.ExportCaption(date_Activated);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(str_AmountPaid);
                        doc.ExportCaption(strSMSNotification);
                        doc.ExportCaption(str_Weight);
                        doc.ExportCaption(str_SpecialNeeds);
                        doc.ExportCaption(str_MedicalConditions);
                        doc.ExportCaption(int_Nationality);
                        doc.ExportCaption(IsDrivingexperience);
                        doc.ExportCaption(Absher_Appointment_number);
                        doc.ExportCaption(date_Birth_Hijri);
                        doc.ExportCaption(Activated);
                        doc.ExportCaption(Absherphoto);
                        doc.ExportCaption(Required_Program);
                        doc.ExportCaption(Price);
                        doc.ExportCaption(Hijri_Day);
                        doc.ExportCaption(Hijri_Month);
                        doc.ExportCaption(Hijri_Year);
                        doc.ExportCaption(dec_Balance);
                        doc.ExportCaption(Payment_Online);
                        doc.ExportCaption(Institution);
                        doc.ExportCaption(WaitingList);
                        doc.ExportCaption(Assessment_ID);
                    }
                    else
                    {
                        doc.ExportCaption(str_NationalID_Iqama);
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(str_First_Name);
                        doc.ExportCaption(str_Middle_Name);
                        doc.ExportCaption(str_Last_Name);
                        doc.ExportCaption(str_Address1);
                        doc.ExportCaption(str_Address2);
                        doc.ExportCaption(int_State);
                        doc.ExportCaption(str_City);
                        doc.ExportCaption(str_Zip);
                        doc.ExportCaption(int_Instructor);
                        doc.ExportCaption(int_Driver);
                        doc.ExportCaption(str_Home_Phone);
                        doc.ExportCaption(str_Cell_Phone);
                        doc.ExportCaption(str_Parent_Phone);
                        doc.ExportCaption(str_Other_Phone);
                        doc.ExportCaption(str_Email);
                        doc.ExportCaption(str_ParentName);
                        doc.ExportCaption(str_ParentEmail1);
                        doc.ExportCaption(str_ParentEmail2);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(str_Password);
                        doc.ExportCaption(str_DOB);
                        doc.ExportCaption(int_DOB_Day);
                        doc.ExportCaption(int_DOB_Month);
                        doc.ExportCaption(int_DOB_Year);
                        doc.ExportCaption(int_Age);
                        doc.ExportCaption(int_Type);
                        doc.ExportCaption(int_Wear_Glasses);
                        doc.ExportCaption(int_Sex);
                        doc.ExportCaption(str_DLPermit);
                        doc.ExportCaption(dt_Date_PermitIssue);
                        doc.ExportCaption(dt_Date_ExpirePermit);
                        doc.ExportCaption(int_Hs_ID);
                        doc.ExportCaption(str_Emergency_Contact_Name);
                        doc.ExportCaption(str_Emergency_Contact_Phone);
                        doc.ExportCaption(str_Emergency_Contact_Relation);
                        doc.ExportCaption(str_Driving_Notes);
                        doc.ExportCaption(int_Location_Id);
                        doc.ExportCaption(int_Permit_Number);
                        doc.ExportCaption(Permit_Issue_Date);
                        doc.ExportCaption(Permit_Expiry_Date);
                        doc.ExportCaption(int_Status);
                        doc.ExportCaption(int_Lead_Id);
                        doc.ExportCaption(int_Activated_By);
                        doc.ExportCaption(date_Activated);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(date_Complete);
                        doc.ExportCaption(int_Created_By);
                        doc.ExportCaption(int_Modified_By);
                        doc.ExportCaption(bit_IsDeleted);
                        doc.ExportCaption(str_CardHolderName);
                        doc.ExportCaption(str_CardHolderAddress);
                        doc.ExportCaption(str_CardHolderCity);
                        doc.ExportCaption(str_CardHolderZip);
                        doc.ExportCaption(str_CardType);
                        doc.ExportCaption(str_CardExpMonth);
                        doc.ExportCaption(str_CardExpYear);
                        doc.ExportCaption(str_CardNo);
                        doc.ExportCaption(str_Certificate_No);
                        doc.ExportCaption(str_AmountPaid);
                        doc.ExportCaption(str_PermitValidated);
                        doc.ExportCaption(strSMSNotification);
                        doc.ExportCaption(strVoiceNotification);
                        doc.ExportCaption(str_Weight);
                        doc.ExportCaption(bit_Verified_PIC_InSAW);
                        doc.ExportCaption(bit_Permit_Waiver_Entered);
                        doc.ExportCaption(bit_TermsConditions);
                        doc.ExportCaption(bit_Disable_Self_Scheduling);
                        doc.ExportCaption(int_EyeColor);
                        doc.ExportCaption(int_HairColor);
                        doc.ExportCaption(int_ColorBlind);
                        doc.ExportCaption(int_HeightFeet);
                        doc.ExportCaption(int_HeightInches);
                        doc.ExportCaption(str_reference_code);
                        doc.ExportCaption(dt_ParentClassAttendedDt);
                        doc.ExportCaption(str_ParentClassAttendedLoc);
                        doc.ExportCaption(dt_SiblingClassAttendedDt);
                        doc.ExportCaption(str_SiblingClassAttendedLoc);
                        doc.ExportCaption(bit_PoliciesAndProcedures);
                        doc.ExportCaption(dt_CourseCompletionDt);
                        doc.ExportCaption(dt_ExtensionDt);
                        doc.ExportCaption(str_MedicalCondition);
                        doc.ExportCaption(str_MajorCrossStreets);
                        doc.ExportCaption(str_DriverEdCertNo);
                        doc.ExportCaption(dt_DriverEdCertIssuedDt);
                        doc.ExportCaption(str_BTWDriversEdCertNo);
                        doc.ExportCaption(dt_BTWCertIssuedDt);
                        doc.ExportCaption(str_OLDriversEdCertNo);
                        doc.ExportCaption(dt_OLCertIssuedDt);
                        doc.ExportCaption(str_height);
                        doc.ExportCaption(dt_BTWCompletionDt);
                        doc.ExportCaption(dt_CRCompletionDt);
                        doc.ExportCaption(strTextBox5);
                        doc.ExportCaption(strTextBox6);
                        doc.ExportCaption(str_ApartmentNo);
                        doc.ExportCaption(dt_PermitTestDate);
                        doc.ExportCaption(str_OnlineDriverEdLogin);
                        doc.ExportCaption(str_OnlineDriverEdPassword);
                        doc.ExportCaption(bit_IsSMSEnabled);
                        doc.ExportCaption(dt_SMSModified);
                        doc.ExportCaption(str_confirmPassword);
                        doc.ExportCaption(DE_Certificate);
                        doc.ExportCaption(Discuss);
                        doc.ExportCaption(int_UnlicensedSibling);
                        doc.ExportCaption(int_YearSiblingIsEligible);
                        doc.ExportCaption(BTW_Certificate);
                        doc.ExportCaption(dt_DECertIssueDate);
                        doc.ExportCaption(str_StudentSignature);
                        doc.ExportCaption(str_ParentSignature);
                        doc.ExportCaption(str_Last6DigitsOfParentDriversLicense);
                        doc.ExportCaption(str_FACControl);
                        doc.ExportCaption(Classroom_Status_Code);
                        doc.ExportCaption(Laboratory_Status_Code);
                        doc.ExportCaption(bit_EnrollmentForm);
                        doc.ExportCaption(bit_ParentStudentContract);
                        doc.ExportCaption(bit_ParentalAgreement);
                        doc.ExportCaption(int_SF_GR_WA_HS);
                        doc.ExportCaption(bit_DisableOnRMV);
                        doc.ExportCaption(bit_UploadedToRMV);
                        doc.ExportCaption(str_Mother_Name);
                        doc.ExportCaption(str_Guardians_Name);
                        doc.ExportCaption(str_Mother_Phone);
                        doc.ExportCaption(bit_terms);
                        doc.ExportCaption(int_Nationality);
                        doc.ExportCaption(str_National_ID_en);
                        doc.ExportCaption(str_National_ID_arabic);
                        doc.ExportCaption(Quallification_Id);
                        doc.ExportCaption(Job_Id);
                        doc.ExportCaption(str_DOB_arabic);
                        doc.ExportCaption(int_Language);
                        doc.ExportCaption(strRefId);
                        doc.ExportCaption(int_Program_Id);
                        doc.ExportCaption(IsDrivingexperience);
                        doc.ExportCaption(IsScheduleassessment);
                        doc.ExportCaption(IsEnrollbyyourself);
                        doc.ExportCaption(AssessmentTime);
                        doc.ExportCaption(AssessmentDate);
                        doc.ExportCaption(isAssessmentDone);
                        doc.ExportCaption(AssessmentScore);
                        doc.ExportCaption(dt_WrittenTestPassed);
                        doc.ExportCaption(dt_RoadTestPassed);
                        doc.ExportCaption(bit_Archive);
                        doc.ExportCaption(ArchiveNotes);
                        doc.ExportCaption(dtArchived);
                        doc.ExportCaption(SrNo9Dec21);
                        doc.ExportCaption(REGNNUMB);
                        doc.ExportCaption(REGNLOCN);
                        doc.ExportCaption(SrNo11DecF1S1);
                        doc.ExportCaption(IsInterestedInTraining);
                        doc.ExportCaption(StudentEncryptID);
                        doc.ExportCaption(StudentConfirURL);
                        doc.ExportCaption(SrNo15DecF1S2);
                        doc.ExportCaption(SrNo15DecF1S3);
                        doc.ExportCaption(SrNo16DecF2S2);
                        doc.ExportCaption(SrNo16DecF2S3);
                        doc.ExportCaption(SrNo16DecF3S1);
                        doc.ExportCaption(SrNo16DecF3S2);
                        doc.ExportCaption(SrNo16DecF4S1);
                        doc.ExportCaption(SrNo16DecF4S2);
                        doc.ExportCaption(SrNo16DecF4S3);
                        doc.ExportCaption(StudentAssementBookingURL);
                        doc.ExportCaption(intDrivinglicenseType);
                        doc.ExportCaption(Isdrivinglicense);
                        doc.ExportCaption(drivinglicensenumber);
                        doc.ExportCaption(Absher_Appointment_number);
                        doc.ExportCaption(DataImportId);
                        doc.ExportCaption(date_Birth_Hijri);
                        doc.ExportCaption(UserlevelID);
                        doc.ExportCaption(Activated);
                        doc.ExportCaption(Absherphoto);
                        doc.ExportCaption(Fingerprint);
                        doc.ExportCaption(Required_Program);
                        doc.ExportCaption(Price);
                        doc.ExportCaption(Hijri_Day);
                        doc.ExportCaption(Hijri_Month);
                        doc.ExportCaption(Hijri_Year);
                        doc.ExportCaption(Course_Price);
                        doc.ExportCaption(Vat_Tax_15);
                        doc.ExportCaption(dec_Balance);
                        doc.ExportCaption(Total_Price);
                        doc.ExportCaption(Payment_Online);
                        doc.ExportCaption(Institution);
                        doc.ExportCaption(WaitingList);
                        doc.ExportCaption(Assessment_ID);
                    }
                    doc.EndExportRow();
                }
            }
            int recCnt = startRec - 1;
            // Read first record for View Page // DN
            if (exportType == "view")
            {
                await dataReader.ReadAsync();
                // Move to and read first record for list page // DN
            }
            else
            {
                if (Connection.SelectOffset)
                {
                    await dataReader.ReadAsync();
                }
                else
                {
                    for (int i = 0; i < startRec; i++) // Move to the start record and use do-while loop
                        await dataReader.ReadAsync();
                }
            }
            int rowcnt = 0; // DN
            do
            { // DN
                recCnt++;
                if (recCnt >= startRec)
                {
                    rowcnt = recCnt - startRec + 1;

                    // Page break
                    if (ExportPageBreakCount > 0)
                    {
                        if (rowcnt > 1 && (rowcnt - 1) % ExportPageBreakCount == 0)
                            doc.ExportPageBreak();
                    }
                    LoadListRowValues(dataReader);

                    // Render row
                    RowType = RowType.View; // Render view
                    ResetAttributes();
                    await RenderListRow();
                    if (!doc.ExportCustom)
                    {
                        doc.BeginExportRow(rowcnt); // Allow CSS styles if enabled
                        if (exportType == "view")
                        {
                            await doc.ExportField(str_NationalID_Iqama);
                            await doc.ExportField(NationalID);
                            await doc.ExportField(str_First_Name);
                            await doc.ExportField(str_Middle_Name);
                            await doc.ExportField(str_Last_Name);
                            await doc.ExportField(str_Address1);
                            await doc.ExportField(str_Address2);
                            await doc.ExportField(int_State);
                            await doc.ExportField(str_City);
                            await doc.ExportField(str_Zip);
                            await doc.ExportField(int_Instructor);
                            await doc.ExportField(str_Home_Phone);
                            await doc.ExportField(str_Cell_Phone);
                            await doc.ExportField(str_Parent_Phone);
                            await doc.ExportField(str_Email);
                            await doc.ExportField(str_ParentName);
                            await doc.ExportField(str_ParentEmail2);
                            await doc.ExportField(str_DOB);
                            await doc.ExportField(int_Age);
                            await doc.ExportField(int_Sex);
                            await doc.ExportField(str_Emergency_Contact_Name);
                            await doc.ExportField(str_Emergency_Contact_Phone);
                            await doc.ExportField(str_Emergency_Contact_Relation);
                            await doc.ExportField(str_Student_Notes);
                            await doc.ExportField(int_Location_Id);
                            await doc.ExportField(date_Activated);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(str_AmountPaid);
                            await doc.ExportField(strSMSNotification);
                            await doc.ExportField(str_Weight);
                            await doc.ExportField(str_SpecialNeeds);
                            await doc.ExportField(str_MedicalConditions);
                            await doc.ExportField(int_Nationality);
                            await doc.ExportField(IsDrivingexperience);
                            await doc.ExportField(Absher_Appointment_number);
                            await doc.ExportField(date_Birth_Hijri);
                            await doc.ExportField(Activated);
                            await doc.ExportField(Absherphoto);
                            await doc.ExportField(Required_Program);
                            await doc.ExportField(Price);
                            await doc.ExportField(Hijri_Day);
                            await doc.ExportField(Hijri_Month);
                            await doc.ExportField(Hijri_Year);
                            await doc.ExportField(dec_Balance);
                            await doc.ExportField(Payment_Online);
                            await doc.ExportField(Institution);
                            await doc.ExportField(WaitingList);
                            await doc.ExportField(Assessment_ID);
                        }
                        else
                        {
                            await doc.ExportField(str_NationalID_Iqama);
                            await doc.ExportField(NationalID);
                            await doc.ExportField(str_First_Name);
                            await doc.ExportField(str_Middle_Name);
                            await doc.ExportField(str_Last_Name);
                            await doc.ExportField(str_Address1);
                            await doc.ExportField(str_Address2);
                            await doc.ExportField(int_State);
                            await doc.ExportField(str_City);
                            await doc.ExportField(str_Zip);
                            await doc.ExportField(int_Instructor);
                            await doc.ExportField(int_Driver);
                            await doc.ExportField(str_Home_Phone);
                            await doc.ExportField(str_Cell_Phone);
                            await doc.ExportField(str_Parent_Phone);
                            await doc.ExportField(str_Other_Phone);
                            await doc.ExportField(str_Email);
                            await doc.ExportField(str_ParentName);
                            await doc.ExportField(str_ParentEmail1);
                            await doc.ExportField(str_ParentEmail2);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(str_Password);
                            await doc.ExportField(str_DOB);
                            await doc.ExportField(int_DOB_Day);
                            await doc.ExportField(int_DOB_Month);
                            await doc.ExportField(int_DOB_Year);
                            await doc.ExportField(int_Age);
                            await doc.ExportField(int_Type);
                            await doc.ExportField(int_Wear_Glasses);
                            await doc.ExportField(int_Sex);
                            await doc.ExportField(str_DLPermit);
                            await doc.ExportField(dt_Date_PermitIssue);
                            await doc.ExportField(dt_Date_ExpirePermit);
                            await doc.ExportField(int_Hs_ID);
                            await doc.ExportField(str_Emergency_Contact_Name);
                            await doc.ExportField(str_Emergency_Contact_Phone);
                            await doc.ExportField(str_Emergency_Contact_Relation);
                            await doc.ExportField(str_Driving_Notes);
                            await doc.ExportField(int_Location_Id);
                            await doc.ExportField(int_Permit_Number);
                            await doc.ExportField(Permit_Issue_Date);
                            await doc.ExportField(Permit_Expiry_Date);
                            await doc.ExportField(int_Status);
                            await doc.ExportField(int_Lead_Id);
                            await doc.ExportField(int_Activated_By);
                            await doc.ExportField(date_Activated);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(date_Complete);
                            await doc.ExportField(int_Created_By);
                            await doc.ExportField(int_Modified_By);
                            await doc.ExportField(bit_IsDeleted);
                            await doc.ExportField(str_CardHolderName);
                            await doc.ExportField(str_CardHolderAddress);
                            await doc.ExportField(str_CardHolderCity);
                            await doc.ExportField(str_CardHolderZip);
                            await doc.ExportField(str_CardType);
                            await doc.ExportField(str_CardExpMonth);
                            await doc.ExportField(str_CardExpYear);
                            await doc.ExportField(str_CardNo);
                            await doc.ExportField(str_Certificate_No);
                            await doc.ExportField(str_AmountPaid);
                            await doc.ExportField(str_PermitValidated);
                            await doc.ExportField(strSMSNotification);
                            await doc.ExportField(strVoiceNotification);
                            await doc.ExportField(str_Weight);
                            await doc.ExportField(bit_Verified_PIC_InSAW);
                            await doc.ExportField(bit_Permit_Waiver_Entered);
                            await doc.ExportField(bit_TermsConditions);
                            await doc.ExportField(bit_Disable_Self_Scheduling);
                            await doc.ExportField(int_EyeColor);
                            await doc.ExportField(int_HairColor);
                            await doc.ExportField(int_ColorBlind);
                            await doc.ExportField(int_HeightFeet);
                            await doc.ExportField(int_HeightInches);
                            await doc.ExportField(str_reference_code);
                            await doc.ExportField(dt_ParentClassAttendedDt);
                            await doc.ExportField(str_ParentClassAttendedLoc);
                            await doc.ExportField(dt_SiblingClassAttendedDt);
                            await doc.ExportField(str_SiblingClassAttendedLoc);
                            await doc.ExportField(bit_PoliciesAndProcedures);
                            await doc.ExportField(dt_CourseCompletionDt);
                            await doc.ExportField(dt_ExtensionDt);
                            await doc.ExportField(str_MedicalCondition);
                            await doc.ExportField(str_MajorCrossStreets);
                            await doc.ExportField(str_DriverEdCertNo);
                            await doc.ExportField(dt_DriverEdCertIssuedDt);
                            await doc.ExportField(str_BTWDriversEdCertNo);
                            await doc.ExportField(dt_BTWCertIssuedDt);
                            await doc.ExportField(str_OLDriversEdCertNo);
                            await doc.ExportField(dt_OLCertIssuedDt);
                            await doc.ExportField(str_height);
                            await doc.ExportField(dt_BTWCompletionDt);
                            await doc.ExportField(dt_CRCompletionDt);
                            await doc.ExportField(strTextBox5);
                            await doc.ExportField(strTextBox6);
                            await doc.ExportField(str_ApartmentNo);
                            await doc.ExportField(dt_PermitTestDate);
                            await doc.ExportField(str_OnlineDriverEdLogin);
                            await doc.ExportField(str_OnlineDriverEdPassword);
                            await doc.ExportField(bit_IsSMSEnabled);
                            await doc.ExportField(dt_SMSModified);
                            await doc.ExportField(str_confirmPassword);
                            await doc.ExportField(DE_Certificate);
                            await doc.ExportField(Discuss);
                            await doc.ExportField(int_UnlicensedSibling);
                            await doc.ExportField(int_YearSiblingIsEligible);
                            await doc.ExportField(BTW_Certificate);
                            await doc.ExportField(dt_DECertIssueDate);
                            await doc.ExportField(str_StudentSignature);
                            await doc.ExportField(str_ParentSignature);
                            await doc.ExportField(str_Last6DigitsOfParentDriversLicense);
                            await doc.ExportField(str_FACControl);
                            await doc.ExportField(Classroom_Status_Code);
                            await doc.ExportField(Laboratory_Status_Code);
                            await doc.ExportField(bit_EnrollmentForm);
                            await doc.ExportField(bit_ParentStudentContract);
                            await doc.ExportField(bit_ParentalAgreement);
                            await doc.ExportField(int_SF_GR_WA_HS);
                            await doc.ExportField(bit_DisableOnRMV);
                            await doc.ExportField(bit_UploadedToRMV);
                            await doc.ExportField(str_Mother_Name);
                            await doc.ExportField(str_Guardians_Name);
                            await doc.ExportField(str_Mother_Phone);
                            await doc.ExportField(bit_terms);
                            await doc.ExportField(int_Nationality);
                            await doc.ExportField(str_National_ID_en);
                            await doc.ExportField(str_National_ID_arabic);
                            await doc.ExportField(Quallification_Id);
                            await doc.ExportField(Job_Id);
                            await doc.ExportField(str_DOB_arabic);
                            await doc.ExportField(int_Language);
                            await doc.ExportField(strRefId);
                            await doc.ExportField(int_Program_Id);
                            await doc.ExportField(IsDrivingexperience);
                            await doc.ExportField(IsScheduleassessment);
                            await doc.ExportField(IsEnrollbyyourself);
                            await doc.ExportField(AssessmentTime);
                            await doc.ExportField(AssessmentDate);
                            await doc.ExportField(isAssessmentDone);
                            await doc.ExportField(AssessmentScore);
                            await doc.ExportField(dt_WrittenTestPassed);
                            await doc.ExportField(dt_RoadTestPassed);
                            await doc.ExportField(bit_Archive);
                            await doc.ExportField(ArchiveNotes);
                            await doc.ExportField(dtArchived);
                            await doc.ExportField(SrNo9Dec21);
                            await doc.ExportField(REGNNUMB);
                            await doc.ExportField(REGNLOCN);
                            await doc.ExportField(SrNo11DecF1S1);
                            await doc.ExportField(IsInterestedInTraining);
                            await doc.ExportField(StudentEncryptID);
                            await doc.ExportField(StudentConfirURL);
                            await doc.ExportField(SrNo15DecF1S2);
                            await doc.ExportField(SrNo15DecF1S3);
                            await doc.ExportField(SrNo16DecF2S2);
                            await doc.ExportField(SrNo16DecF2S3);
                            await doc.ExportField(SrNo16DecF3S1);
                            await doc.ExportField(SrNo16DecF3S2);
                            await doc.ExportField(SrNo16DecF4S1);
                            await doc.ExportField(SrNo16DecF4S2);
                            await doc.ExportField(SrNo16DecF4S3);
                            await doc.ExportField(StudentAssementBookingURL);
                            await doc.ExportField(intDrivinglicenseType);
                            await doc.ExportField(Isdrivinglicense);
                            await doc.ExportField(drivinglicensenumber);
                            await doc.ExportField(Absher_Appointment_number);
                            await doc.ExportField(DataImportId);
                            await doc.ExportField(date_Birth_Hijri);
                            await doc.ExportField(UserlevelID);
                            await doc.ExportField(Activated);
                            await doc.ExportField(Absherphoto);
                            await doc.ExportField(Fingerprint);
                            await doc.ExportField(Required_Program);
                            await doc.ExportField(Price);
                            await doc.ExportField(Hijri_Day);
                            await doc.ExportField(Hijri_Month);
                            await doc.ExportField(Hijri_Year);
                            await doc.ExportField(Course_Price);
                            await doc.ExportField(Vat_Tax_15);
                            await doc.ExportField(dec_Balance);
                            await doc.ExportField(Total_Price);
                            await doc.ExportField(Payment_Online);
                            await doc.ExportField(Institution);
                            await doc.ExportField(WaitingList);
                            await doc.ExportField(Assessment_ID);
                        }
                        doc.EndExportRow(rowcnt);
                    }
                }

                // Call Row Export server event
                if (doc.ExportCustom)
                    RowExport(doc, dataReader);
            } while (recCnt < stopRec && await dataReader.ReadAsync()); // DN
            if (!doc.ExportCustom)
                doc.ExportTableFooter();
        }

        // Add User ID filter
        public string AddUserIDFilter(string filter = "", string id = "")
        {
            string filterWrk = "";
            if (id == "")
                id = (CurrentPageID() == "list") ? CurrentAction : CurrentPageID();
            if (!UserIDAllow(id) && !Security.IsAdmin)
            {
                filterWrk = Security.UserIDList();
                if (!Empty(filterWrk))
                    filterWrk = "[str_Username] IN (" + filterWrk + ")";
            }

            // Call User ID Filtering event
            UserIdFiltering(ref filterWrk);
            AddFilter(ref filter, filterWrk);
            return filter;
        }

        // User ID subquery
        public string GetUserIDSubquery(DbField fld, DbField masterfld)
        {
            string wrk = "";
            string sql = "SELECT " + masterfld.Expression + " FROM dbo.tblPotentialStudentInfo";
            string filter = AddUserIDFilter();
            if (!Empty(filter))
                sql += " WHERE " + filter;
            var list = Connection.GetRows(sql);
            wrk = String.Join(",", list.Select(d => QuotedValue(d.Values.First(), masterfld.DataType, Config.UserTableDbId))); // List all values
            if (!Empty(wrk))
                wrk = fld.Expression + " IN (" + wrk + ")";
            else
                wrk = "0=1"; // No User ID value found
            return wrk;
        }

        // Table filter
        private string? _tableFilter = null;

        public string TableFilter
        {
            get => _tableFilter ?? "[NationalID] is not null";
            set => _tableFilter = value;
        }

        // TblBasicSearchDefault
        private string? _tableBasicSearchDefault = null;

        public string TableBasicSearchDefault
        {
            get => _tableBasicSearchDefault ?? "";
            set => _tableBasicSearchDefault = value;
        }

#pragma warning disable 1998
        // Get file data
        public async Task<IActionResult> GetFileData(string fldparm, string[] keys, bool resize, int width = -1, int height = -1)
        {
            if (width < 0)
                width = Config.ThumbnailDefaultWidth;
            if (height < 0)
                height = Config.ThumbnailDefaultHeight;

            // No binary fields
            return JsonBoolResult.FalseResult; // Incorrect key
        }
#pragma warning restore 1998

        // Table level events

        // Table Load event
        public void TableLoad()
        {
            // Enter your code here
        }

        // Recordset Selecting event
        public void RecordsetSelecting(ref string filter)
        {
            // Enter your code here
        }

        // Recordset Selected event
        public void RecordsetSelected(DbDataReader rs)
        {
            // Enter your code here
        }

        // Recordset Searching event
        public void RecordsetSearching(ref string filter)
        {
            // Enter your code here
        }

        // Recordset Search Validated event
        public void RecordsetSearchValidated()
        {
            // Enter your code here
        }

        // Row_Selecting event
        public void RowSelecting(ref string filter)
        {
            // Enter your code here
        }

        // Row Selected event
        public void RowSelected(Dictionary<string, object> row)
        {
            //Log("Row Selected");
        }

        // Row Inserting event
        public bool RowInserting(Dictionary<string, object>? rsold, Dictionary<string, object> rsnew)
        {
            // Enter your code here
            // To cancel, set return value to False and error message to CancelMessage
            return true;
        }

        // Row Inserted event
        public void RowInserted(Dictionary<string, object>? rsold, Dictionary<string, object> rsnew)
        {
            //Log("Row Inserted");
        }

        // Row Updating event
        public bool RowUpdating(Dictionary<string, object> rsold, Dictionary<string, object> rsnew)
        {
            // Enter your code here
            // To cancel, set return value to False and error message to CancelMessage
            return true;
        }

        // Row Updated event
        public async void RowUpdated(Dictionary<string, object> rsold, Dictionary<string, object> rsnew)
        {
            //Log("Row Updated");
            var activated = Convert.ToBoolean(rsnew.GetValueOrDefault("Activated")?.ToString() ?? "0");
            if (activated)
            {
                var username = rsnew.GetValueOrDefault("str_Username")?.ToString();
                var password = rsnew.GetValueOrDefault("str_Password")?.ToString();
                var phoneNo = rsnew.GetValueOrDefault("str_Cell_Phone")?.ToString();
                var int_Student_Id = rsnew.GetValueOrDefault("int_Student_Id")?.ToString();
                var rowStudent = ExecuteRow($"SELECT * FROM tblStudents WHERE int_Student_ID = '{int_Student_Id}'");
                var fullName = rowStudent.GetValueOrDefault("str_Full_Name")?.ToString();
                var smsMessage = SmsMessageFor.ActivateAccountAfterPayment(fullName, username, password);
                await JawalbSms.SendSmsAsync(smsMessage, phoneNo!);
            }
        }

        // Row Update Conflict event
        public bool RowUpdateConflict(Dictionary<string, object> rsold, Dictionary<string, object> rsnew)
        {
            // Enter your code here
            // To ignore conflict, set return value to false
            return true;
        }

        // Recordset Deleting event
        public bool RowDeleting(Dictionary<string, object> rs)
        {
            // Enter your code here
            // To cancel, set return value to False and error message to CancelMessage
            return true;
        }

        // Row Deleted event
        public void RowDeleted(Dictionary<string, object> rs)
        {
            //Log("Row Deleted");
        }

        // Row Export event
        // doc = export document object
        public virtual void RowExport(dynamic doc, DbDataReader rs)
        {
            //doc.Text.Append("<div>" + MyField.ViewValue +"</div>"); // Build HTML with field value: rs["MyField"] or MyField.ViewValue
        }

        // Email Sending event
        public virtual bool EmailSending(Email email, dynamic? args)
        {
            //Log(email);
            return true;
        }

        // Lookup Selecting event
        public void LookupSelecting(DbField fld, ref string filter)
        {
            // Enter your code here
        }

        // Row Rendering event
        public void RowRendering()
        {
            // Enter your code here
        }

        // Row Rendered event
        public void RowRendered()
        {
            //VarDump(<FieldName>); // View field properties
        }

        // User ID Filtering event
        public void UserIdFiltering(ref string filter)
        {
            // Enter your code here
        }
    }
} // End Partial class
