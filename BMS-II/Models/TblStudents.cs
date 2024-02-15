namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblStudents
    /// </summary>
    [MaybeNull]
    public static TblStudents tblStudents
    {
        get => HttpData.Resolve<TblStudents>("tblStudents");
        set => HttpData["tblStudents"] = value;
    }

    /// <summary>
    /// Table class for tblStudents
    /// </summary>
    public class TblStudents : DbTable, IQueryFactory
    {
        public int RowCount = 0; // DN

        public bool UseSessionForListSql = true;

        // Column CSS classes
        public string LeftColumnClass = "col-sm-2 col-form-label ew-label";

        public string RightColumnClass = "col-sm-10";

        public string OffsetColumnClass = "col-sm-10 offset-sm-2";

        public string TableLeftColumnClass = "w-col-2";

        // Audit trail
        public bool AuditTrailOnAdd = true;

        public bool AuditTrailOnEdit = true;

        public bool AuditTrailOnDelete = true;

        public bool AuditTrailOnView = false;

        public bool AuditTrailOnViewData = false;

        public bool AuditTrailOnSearch = false;

        // Ajax / Modal
        public bool UseAjaxActions = false;

        public bool ModalSearch = false;

        public bool ModalView = true;

        public bool ModalAdd = false;

        public bool ModalEdit = false;

        public bool ModalUpdate = false;

        public bool InlineDelete = false;

        public bool ModalGridAdd = false;

        public bool ModalGridEdit = false;

        public bool ModalMultiEdit = false;

        public readonly DbField<SqlDbType> int_Student_ID;

        public readonly DbField<SqlDbType> str_First_Name;

        public readonly DbField<SqlDbType> str_Middle_Name;

        public readonly DbField<SqlDbType> str_Last_Name;

        public readonly DbField<SqlDbType> str_Full_Name;

        public readonly DbField<SqlDbType> str_Address;

        public readonly DbField<SqlDbType> str_City;

        public readonly DbField<SqlDbType> int_State;

        public readonly DbField<SqlDbType> str_Zip;

        public readonly DbField<SqlDbType> date_Hired;

        public readonly DbField<SqlDbType> date_Left;

        public readonly DbField<SqlDbType> str_CertNumber;

        public readonly DbField<SqlDbType> date_CertExp;

        public readonly DbField<SqlDbType> str_Cell_Phone;

        public readonly DbField<SqlDbType> str_Home_Phone;

        public readonly DbField<SqlDbType> str_Other_Phone;

        public readonly DbField<SqlDbType> str_Email;

        public readonly DbField<SqlDbType> str_Code;

        public readonly DbField<SqlDbType> str_Username;

        public readonly DbField<SqlDbType> str_Password;

        public readonly DbField<SqlDbType> date_Birth_Hijri;

        public readonly DbField<SqlDbType> date_Birth;

        public readonly DbField<SqlDbType> Hijri_Year;

        public readonly DbField<SqlDbType> Hijri_Month;

        public readonly DbField<SqlDbType> Hijri_Day;

        public readonly DbField<SqlDbType> date_Started;

        public readonly DbField<SqlDbType> str_DateHired;

        public readonly DbField<SqlDbType> str_DateLeft;

        public readonly DbField<SqlDbType> str_Emergency_Contact_Name;

        public readonly DbField<SqlDbType> str_Emergency_Contact_Phone;

        public readonly DbField<SqlDbType> str_Emergency_Contact_Relation;

        public readonly DbField<SqlDbType> str_Notes;

        public readonly DbField<SqlDbType> int_ClassType;

        public readonly DbField<SqlDbType> str_ZipCodes;

        public readonly DbField<SqlDbType> int_VehicleAssigned;

        public readonly DbField<SqlDbType> int_Status;

        public readonly DbField<SqlDbType> int_Type;

        public readonly DbField<SqlDbType> int_Location;

        public readonly DbField<SqlDbType> date_Created;

        public readonly DbField<SqlDbType> date_Modified;

        public readonly DbField<SqlDbType> int_Created_By;

        public readonly DbField<SqlDbType> int_Modified_By;

        public readonly DbField<SqlDbType> bit_IsDeleted;

        public readonly DbField<SqlDbType> str_InstPermitNo;

        public readonly DbField<SqlDbType> date_PermitExpiration;

        public readonly DbField<SqlDbType> date_InCarPermitIssue;

        public readonly DbField<SqlDbType> str_InClassPermitNo;

        public readonly DbField<SqlDbType> date_InClassPermitIssue;

        public readonly DbField<SqlDbType> instructor_caption;

        public readonly DbField<SqlDbType> str_LicType;

        public readonly DbField<SqlDbType> int_Order;

        public readonly DbField<SqlDbType> str_InstLicenceDate;

        public readonly DbField<SqlDbType> str_DLNum;

        public readonly DbField<SqlDbType> str_DLExp;

        public readonly DbField<SqlDbType> bit_appointmentColor;

        public readonly DbField<SqlDbType> str_appointmentColorCode;

        public readonly DbField<SqlDbType> bit_IsSuperAdmin;

        public readonly DbField<SqlDbType> IsDistanceBasedScheduling;

        public readonly DbField<SqlDbType> str_Package_Code;

        public readonly DbField<SqlDbType> str_NationalID_Iqama;

        public readonly DbField<SqlDbType> NationalID;

        public readonly DbField<SqlDbType> int_RoadDistanceCoverage;

        public readonly DbField<SqlDbType> str_Badge;

        public readonly DbField<SqlDbType> strZoomHostUrl;

        public readonly DbField<SqlDbType> strZoomUserUrl;

        public readonly DbField<SqlDbType> Signature;

        public readonly DbField<SqlDbType> str_VehicleType;

        public readonly DbField<SqlDbType> ProfilePicturePath;

        public readonly DbField<SqlDbType> Institution;

        public readonly DbField<SqlDbType> IsDrivingexperience;

        public readonly DbField<SqlDbType> intDrivinglicenseType;

        public readonly DbField<SqlDbType> AbsherApptNbr;

        public readonly DbField<SqlDbType> Absherphoto;

        public readonly DbField<SqlDbType> Fingerprint;

        public readonly DbField<SqlDbType> ProfileField;

        public readonly DbField<SqlDbType> UserlevelID;

        public readonly DbField<SqlDbType> Parent_Username;

        public readonly DbField<SqlDbType> Activated;

        public readonly DbField<SqlDbType> int_Nationality;

        public readonly DbField<SqlDbType> User_Role;

        public readonly DbField<SqlDbType> int_Staff_Id;

        // Constructor
        public TblStudents()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "tblStudents";
            Name = "tblStudents";
            Type = "TABLE";
            UpdateTable = "dbo.tblStudents"; // Update Table
            DbId = "DB"; // DN
            ExportAll = true;
            ExportPageBreakCount = 0; // Page break per every n record (PDF only)
            ExportPageOrientation = "portrait"; // Page orientation (PDF only)
            ExportPageSize = "a4"; // Page size (PDF only)
            ExportColumnWidths = new float[] {  }; // Column widths (PDF only) // DN
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
            UseColumnVisibility = true;

            // int_Student_ID
            int_Student_ID = new (this, "x_int_Student_ID", 3, SqlDbType.Int) {
                Name = "int_Student_ID",
                Expression = "[int_Student_ID]",
                BasicSearchExpression = "CAST([int_Student_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Student_ID]",
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
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblStudents", "int_Student_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Student_ID", int_Student_ID);

            // str_First_Name
            str_First_Name = new (this, "x_str_First_Name", 202, SqlDbType.NVarChar) {
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
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_First_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_First_Name", str_First_Name);

            // str_Middle_Name
            str_Middle_Name = new (this, "x_str_Middle_Name", 202, SqlDbType.NVarChar) {
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
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Middle_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Middle_Name", str_Middle_Name);

            // str_Last_Name
            str_Last_Name = new (this, "x_str_Last_Name", 202, SqlDbType.NVarChar) {
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
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Last_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Last_Name", str_Last_Name);

            // str_Full_Name
            str_Full_Name = new (this, "x_str_Full_Name", 202, SqlDbType.NVarChar) {
                Name = "str_Full_Name",
                Expression = "[str_Full_Name]",
                BasicSearchExpression = "[str_Full_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Full_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Full_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Full_Name", str_Full_Name);

            // str_Address
            str_Address = new (this, "x_str_Address", 202, SqlDbType.NVarChar) {
                Name = "str_Address",
                Expression = "[str_Address]",
                BasicSearchExpression = "[str_Address]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Address]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Address", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Address", str_Address);

            // str_City
            str_City = new (this, "x_str_City", 202, SqlDbType.NVarChar) {
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
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_City", "CustomMsg"),
                IsUpload = false
            };
            str_City.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(str_City, "Cities", false, "City", new List<string> {"City", "", "", ""}, "", "", new List<string> {}, new List<string> {"x_int_State"}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[City]"),
                "en-US" => new Lookup<DbField>(str_City, "Cities", false, "City", new List<string> {"City", "", "", ""}, "", "", new List<string> {}, new List<string> {"x_int_State"}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[City]"),
                _ => new Lookup<DbField>(str_City, "Cities", false, "City", new List<string> {"City", "", "", ""}, "", "", new List<string> {}, new List<string> {"x_int_State"}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[City]")
            };
            Fields.Add("str_City", str_City);

            // int_State
            int_State = new (this, "x_int_State", 3, SqlDbType.Int) {
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
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "int_State", "CustomMsg"),
                IsUpload = false
            };
            int_State.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(int_State, "Cities", false, "Province_ID", new List<string> {"Province", "", "", ""}, "", "", new List<string> {"x_str_City"}, new List<string> {}, new List<string> {"City"}, new List<string> {"x_City"}, new List<string> {}, new List<string> {}, "", "", "[Province]"),
                "en-US" => new Lookup<DbField>(int_State, "Cities", false, "Province_ID", new List<string> {"Province", "", "", ""}, "", "", new List<string> {"x_str_City"}, new List<string> {}, new List<string> {"City"}, new List<string> {"x_City"}, new List<string> {}, new List<string> {}, "", "", "[Province]"),
                _ => new Lookup<DbField>(int_State, "Cities", false, "Province_ID", new List<string> {"Province", "", "", ""}, "", "", new List<string> {"x_str_City"}, new List<string> {}, new List<string> {"City"}, new List<string> {"x_City"}, new List<string> {}, new List<string> {}, "", "", "[Province]")
            };
            Fields.Add("int_State", int_State);

            // str_Zip
            str_Zip = new (this, "x_str_Zip", 202, SqlDbType.NVarChar) {
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
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Zip", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Zip", str_Zip);

            // date_Hired
            date_Hired = new (this, "x_date_Hired", 135, SqlDbType.DateTime) {
                Name = "date_Hired",
                Expression = "[date_Hired]",
                BasicSearchExpression = CastDateFieldForLike("[date_Hired]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[date_Hired]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "date_Hired", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Hired", date_Hired);

            // date_Left
            date_Left = new (this, "x_date_Left", 135, SqlDbType.DateTime) {
                Name = "date_Left",
                Expression = "[date_Left]",
                BasicSearchExpression = CastDateFieldForLike("[date_Left]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[date_Left]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "date_Left", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Left", date_Left);

            // str_CertNumber
            str_CertNumber = new (this, "x_str_CertNumber", 202, SqlDbType.NVarChar) {
                Name = "str_CertNumber",
                Expression = "[str_CertNumber]",
                BasicSearchExpression = "[str_CertNumber]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CertNumber]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_CertNumber", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CertNumber", str_CertNumber);

            // date_CertExp
            date_CertExp = new (this, "x_date_CertExp", 200, SqlDbType.VarChar) {
                Name = "date_CertExp",
                Expression = "[date_CertExp]",
                BasicSearchExpression = "[date_CertExp]",
                DateTimeFormat = -1,
                VirtualExpression = "[date_CertExp]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "date_CertExp", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_CertExp", date_CertExp);

            // str_Cell_Phone
            str_Cell_Phone = new (this, "x_str_Cell_Phone", 200, SqlDbType.VarChar) {
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Cell_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Cell_Phone", str_Cell_Phone);

            // str_Home_Phone
            str_Home_Phone = new (this, "x_str_Home_Phone", 200, SqlDbType.VarChar) {
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Home_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Home_Phone", str_Home_Phone);

            // str_Other_Phone
            str_Other_Phone = new (this, "x_str_Other_Phone", 200, SqlDbType.VarChar) {
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Other_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Other_Phone", str_Other_Phone);

            // str_Email
            str_Email = new (this, "x_str_Email", 202, SqlDbType.NVarChar) {
                Name = "str_Email",
                Expression = "[str_Email]",
                UseBasicSearch = true,
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
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectEmail"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Email", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Email", str_Email);

            // str_Code
            str_Code = new (this, "x_str_Code", 202, SqlDbType.NVarChar) {
                Name = "str_Code",
                Expression = "[str_Code]",
                BasicSearchExpression = "[str_Code]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Code]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Code", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Code", str_Code);

            // str_Username
            str_Username = new (this, "x_str_Username", 202, SqlDbType.NVarChar) {
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
                IsForeignKey = true, // Foreign key field
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Username", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Username", str_Username);

            // str_Password
            str_Password = new (this, "x_str_Password", 202, SqlDbType.NVarChar) {
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
                HtmlTag = "PASSWORD",
                InputTextType = "text",
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Password", "CustomMsg"),
                IsUpload = false
            };
            if (Config.EncryptedPassword)
                str_Password.Raw = true;
            Fields.Add("str_Password", str_Password);

            // date_Birth_Hijri
            date_Birth_Hijri = new (this, "x_date_Birth_Hijri", 202, SqlDbType.NVarChar) {
                Name = "date_Birth_Hijri",
                Expression = "[date_Birth_Hijri]",
                BasicSearchExpression = "[date_Birth_Hijri]",
                DateTimeFormat = 0,
                VirtualExpression = "[date_Birth_Hijri]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Required = true, // Required field
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "date_Birth_Hijri", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Birth_Hijri", date_Birth_Hijri);

            // date_Birth
            date_Birth = new (this, "x_date_Birth", 135, SqlDbType.DateTime) {
                Name = "date_Birth",
                Expression = "[date_Birth]",
                BasicSearchExpression = CastDateFieldForLike("[date_Birth]", 16, "DB"),
                DateTimeFormat = 16,
                VirtualExpression = "[date_Birth]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Required = true, // Required field
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", DateFormat(16)),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "date_Birth", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Birth", date_Birth);

            // Hijri_Year
            Hijri_Year = new (this, "x_Hijri_Year", 3, SqlDbType.Int) {
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
                HtmlTag = "SELECT",
                InputTextType = "text",
                Required = true, // Required field
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                OptionCount = 77,
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "Hijri_Year", "CustomMsg"),
                IsUpload = false
            };
            Hijri_Year.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Hijri_Year, "Hijri_Table", false, "Hijri_Year", new List<string> {"Hijri_Year", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CAST([Hijri_Year] AS NVARCHAR)"),
                "en-US" => new Lookup<DbField>(Hijri_Year, "Hijri_Table", false, "Hijri_Year", new List<string> {"Hijri_Year", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CAST([Hijri_Year] AS NVARCHAR)"),
                _ => new Lookup<DbField>(Hijri_Year, "Hijri_Table", false, "Hijri_Year", new List<string> {"Hijri_Year", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CAST([Hijri_Year] AS NVARCHAR)")
            };
            Fields.Add("Hijri_Year", Hijri_Year);

            // Hijri_Month
            Hijri_Month = new (this, "x_Hijri_Month", 3, SqlDbType.Int) {
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
                HtmlTag = "SELECT",
                InputTextType = "text",
                Required = true, // Required field
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                OptionCount = 12,
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "Hijri_Month", "CustomMsg"),
                IsUpload = false
            };
            Hijri_Month.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Hijri_Month, "Hijri_Table", false, "Hijri_Month", new List<string> {"Hijri_mon_ar", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "[Hijri_Month] ASC", "", "[Hijri_mon_ar]"),
                "en-US" => new Lookup<DbField>(Hijri_Month, "Hijri_Table", false, "Hijri_Month", new List<string> {"Hijri_mon_ar", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "[Hijri_Month] ASC", "", "[Hijri_mon_ar]"),
                _ => new Lookup<DbField>(Hijri_Month, "Hijri_Table", false, "Hijri_Month", new List<string> {"Hijri_mon_ar", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "[Hijri_Month] ASC", "", "[Hijri_mon_ar]")
            };
            Hijri_Month.GetSelectFilter = () => "[Hijri_Month] != 0";
            Fields.Add("Hijri_Month", Hijri_Month);

            // Hijri_Day
            Hijri_Day = new (this, "x_Hijri_Day", 3, SqlDbType.Int) {
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
                HtmlTag = "SELECT",
                InputTextType = "text",
                Required = true, // Required field
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                OptionCount = 30,
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "Hijri_Day", "CustomMsg"),
                IsUpload = false
            };
            Hijri_Day.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Hijri_Day, "Hijri_Table", false, "Hijri_Day", new List<string> {"Hijri_Day", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CAST([Hijri_Day] AS NVARCHAR)"),
                "en-US" => new Lookup<DbField>(Hijri_Day, "Hijri_Table", false, "Hijri_Day", new List<string> {"Hijri_Day", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CAST([Hijri_Day] AS NVARCHAR)"),
                _ => new Lookup<DbField>(Hijri_Day, "Hijri_Table", false, "Hijri_Day", new List<string> {"Hijri_Day", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CAST([Hijri_Day] AS NVARCHAR)")
            };
            Fields.Add("Hijri_Day", Hijri_Day);

            // date_Started
            date_Started = new (this, "x_date_Started", 200, SqlDbType.VarChar) {
                Name = "date_Started",
                Expression = "[date_Started]",
                BasicSearchExpression = "[date_Started]",
                DateTimeFormat = -1,
                VirtualExpression = "[date_Started]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "date_Started", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Started", date_Started);

            // str_DateHired
            str_DateHired = new (this, "x_str_DateHired", 200, SqlDbType.VarChar) {
                Name = "str_DateHired",
                Expression = "[str_DateHired]",
                BasicSearchExpression = "[str_DateHired]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_DateHired]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_DateHired", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_DateHired", str_DateHired);

            // str_DateLeft
            str_DateLeft = new (this, "x_str_DateLeft", 200, SqlDbType.VarChar) {
                Name = "str_DateLeft",
                Expression = "[str_DateLeft]",
                BasicSearchExpression = "[str_DateLeft]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_DateLeft]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_DateLeft", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_DateLeft", str_DateLeft);

            // str_Emergency_Contact_Name
            str_Emergency_Contact_Name = new (this, "x_str_Emergency_Contact_Name", 202, SqlDbType.NVarChar) {
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Emergency_Contact_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Emergency_Contact_Name", str_Emergency_Contact_Name);

            // str_Emergency_Contact_Phone
            str_Emergency_Contact_Phone = new (this, "x_str_Emergency_Contact_Phone", 200, SqlDbType.VarChar) {
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Emergency_Contact_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Emergency_Contact_Phone", str_Emergency_Contact_Phone);

            // str_Emergency_Contact_Relation
            str_Emergency_Contact_Relation = new (this, "x_str_Emergency_Contact_Relation", 202, SqlDbType.NVarChar) {
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
                HtmlTag = "SELECT",
                InputTextType = "text",
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                OptionCount = 7,
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Emergency_Contact_Relation", "CustomMsg"),
                IsUpload = false
            };
            str_Emergency_Contact_Relation.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(str_Emergency_Contact_Relation, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(str_Emergency_Contact_Relation, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(str_Emergency_Contact_Relation, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("str_Emergency_Contact_Relation", str_Emergency_Contact_Relation);

            // str_Notes
            str_Notes = new (this, "x_str_Notes", 202, SqlDbType.NVarChar) {
                Name = "str_Notes",
                Expression = "[str_Notes]",
                BasicSearchExpression = "[str_Notes]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Notes]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Notes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Notes", str_Notes);

            // int_ClassType
            int_ClassType = new (this, "x_int_ClassType", 3, SqlDbType.Int) {
                Name = "int_ClassType",
                Expression = "[int_ClassType]",
                BasicSearchExpression = "CAST([int_ClassType] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_ClassType]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "int_ClassType", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_ClassType", int_ClassType);

            // str_ZipCodes
            str_ZipCodes = new (this, "x_str_ZipCodes", 203, SqlDbType.NText) {
                Name = "str_ZipCodes",
                Expression = "[str_ZipCodes]",
                BasicSearchExpression = "[str_ZipCodes]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_ZipCodes]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_ZipCodes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_ZipCodes", str_ZipCodes);

            // int_VehicleAssigned
            int_VehicleAssigned = new (this, "x_int_VehicleAssigned", 3, SqlDbType.Int) {
                Name = "int_VehicleAssigned",
                Expression = "[int_VehicleAssigned]",
                BasicSearchExpression = "CAST([int_VehicleAssigned] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_VehicleAssigned]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "int_VehicleAssigned", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_VehicleAssigned", int_VehicleAssigned);

            // int_Status
            int_Status = new (this, "x_int_Status", 3, SqlDbType.Int) {
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "int_Status", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Status", int_Status);

            // int_Type
            int_Type = new (this, "x_int_Type", 3, SqlDbType.Int) {
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "int_Type", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Type", int_Type);

            // int_Location
            int_Location = new (this, "x_int_Location", 3, SqlDbType.Int) {
                Name = "int_Location",
                Expression = "[int_Location]",
                BasicSearchExpression = "CAST([int_Location] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Location]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "int_Location", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Location", int_Location);

            // date_Created
            date_Created = new (this, "x_date_Created", 135, SqlDbType.DateTime) {
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
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "date_Created", "CustomMsg"),
                IsUpload = false
            };
            date_Created.GetAutoUpdateValue = () => CurrentDateTime();
            Fields.Add("date_Created", date_Created);

            // date_Modified
            date_Modified = new (this, "x_date_Modified", 135, SqlDbType.DateTime) {
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
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "date_Modified", "CustomMsg"),
                IsUpload = false
            };
            date_Modified.GetAutoUpdateValue = () => CurrentDateTime();
            Fields.Add("date_Modified", date_Modified);

            // int_Created_By
            int_Created_By = new (this, "x_int_Created_By", 131, SqlDbType.Decimal) {
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
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "int_Created_By", "CustomMsg"),
                IsUpload = false
            };
            int_Created_By.GetAutoUpdateValue = () => CurrentUserLevel();
            Fields.Add("int_Created_By", int_Created_By);

            // int_Modified_By
            int_Modified_By = new (this, "x_int_Modified_By", 131, SqlDbType.Decimal) {
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
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "int_Modified_By", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Modified_By", int_Modified_By);

            // bit_IsDeleted
            bit_IsDeleted = new (this, "x_bit_IsDeleted", 11, SqlDbType.Bit) {
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
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "bit_IsDeleted", "CustomMsg"),
                IsUpload = false
            };
            bit_IsDeleted.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IsDeleted, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsDeleted, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IsDeleted, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_IsDeleted", bit_IsDeleted);

            // str_InstPermitNo
            str_InstPermitNo = new (this, "x_str_InstPermitNo", 202, SqlDbType.NVarChar) {
                Name = "str_InstPermitNo",
                Expression = "[str_InstPermitNo]",
                BasicSearchExpression = "[str_InstPermitNo]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_InstPermitNo]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_InstPermitNo", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_InstPermitNo", str_InstPermitNo);

            // date_PermitExpiration
            date_PermitExpiration = new (this, "x_date_PermitExpiration", 200, SqlDbType.VarChar) {
                Name = "date_PermitExpiration",
                Expression = "[date_PermitExpiration]",
                BasicSearchExpression = "[date_PermitExpiration]",
                DateTimeFormat = -1,
                VirtualExpression = "[date_PermitExpiration]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "date_PermitExpiration", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_PermitExpiration", date_PermitExpiration);

            // date_InCarPermitIssue
            date_InCarPermitIssue = new (this, "x_date_InCarPermitIssue", 200, SqlDbType.VarChar) {
                Name = "date_InCarPermitIssue",
                Expression = "[date_InCarPermitIssue]",
                BasicSearchExpression = "[date_InCarPermitIssue]",
                DateTimeFormat = -1,
                VirtualExpression = "[date_InCarPermitIssue]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "date_InCarPermitIssue", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_InCarPermitIssue", date_InCarPermitIssue);

            // str_InClassPermitNo
            str_InClassPermitNo = new (this, "x_str_InClassPermitNo", 202, SqlDbType.NVarChar) {
                Name = "str_InClassPermitNo",
                Expression = "[str_InClassPermitNo]",
                BasicSearchExpression = "[str_InClassPermitNo]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_InClassPermitNo]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_InClassPermitNo", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_InClassPermitNo", str_InClassPermitNo);

            // date_InClassPermitIssue
            date_InClassPermitIssue = new (this, "x_date_InClassPermitIssue", 200, SqlDbType.VarChar) {
                Name = "date_InClassPermitIssue",
                Expression = "[date_InClassPermitIssue]",
                BasicSearchExpression = "[date_InClassPermitIssue]",
                DateTimeFormat = -1,
                VirtualExpression = "[date_InClassPermitIssue]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "date_InClassPermitIssue", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_InClassPermitIssue", date_InClassPermitIssue);

            // instructor_caption
            instructor_caption = new (this, "x_instructor_caption", 200, SqlDbType.VarChar) {
                Name = "instructor_caption",
                Expression = "[instructor_caption]",
                BasicSearchExpression = "[instructor_caption]",
                DateTimeFormat = -1,
                VirtualExpression = "[instructor_caption]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "instructor_caption", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("instructor_caption", instructor_caption);

            // str_LicType
            str_LicType = new (this, "x_str_LicType", 200, SqlDbType.VarChar) {
                Name = "str_LicType",
                Expression = "[str_LicType]",
                BasicSearchExpression = "[str_LicType]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_LicType]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_LicType", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_LicType", str_LicType);

            // int_Order
            int_Order = new (this, "x_int_Order", 3, SqlDbType.Int) {
                Name = "int_Order",
                Expression = "[int_Order]",
                BasicSearchExpression = "CAST([int_Order] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Order]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "int_Order", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Order", int_Order);

            // str_InstLicenceDate
            str_InstLicenceDate = new (this, "x_str_InstLicenceDate", 200, SqlDbType.VarChar) {
                Name = "str_InstLicenceDate",
                Expression = "[str_InstLicenceDate]",
                BasicSearchExpression = "[str_InstLicenceDate]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_InstLicenceDate]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_InstLicenceDate", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_InstLicenceDate", str_InstLicenceDate);

            // str_DLNum
            str_DLNum = new (this, "x_str_DLNum", 200, SqlDbType.VarChar) {
                Name = "str_DLNum",
                Expression = "[str_DLNum]",
                BasicSearchExpression = "[str_DLNum]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_DLNum]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_DLNum", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_DLNum", str_DLNum);

            // str_DLExp
            str_DLExp = new (this, "x_str_DLExp", 200, SqlDbType.VarChar) {
                Name = "str_DLExp",
                Expression = "[str_DLExp]",
                BasicSearchExpression = "[str_DLExp]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_DLExp]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_DLExp", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_DLExp", str_DLExp);

            // bit_appointmentColor
            bit_appointmentColor = new (this, "x_bit_appointmentColor", 11, SqlDbType.Bit) {
                Name = "bit_appointmentColor",
                Expression = "[bit_appointmentColor]",
                BasicSearchExpression = "[bit_appointmentColor]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_appointmentColor]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "bit_appointmentColor", "CustomMsg"),
                IsUpload = false
            };
            bit_appointmentColor.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_appointmentColor, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_appointmentColor, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_appointmentColor, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_appointmentColor", bit_appointmentColor);

            // str_appointmentColorCode
            str_appointmentColorCode = new (this, "x_str_appointmentColorCode", 202, SqlDbType.NVarChar) {
                Name = "str_appointmentColorCode",
                Expression = "[str_appointmentColorCode]",
                BasicSearchExpression = "[str_appointmentColorCode]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_appointmentColorCode]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_appointmentColorCode", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_appointmentColorCode", str_appointmentColorCode);

            // bit_IsSuperAdmin
            bit_IsSuperAdmin = new (this, "x_bit_IsSuperAdmin", 11, SqlDbType.Bit) {
                Name = "bit_IsSuperAdmin",
                Expression = "[bit_IsSuperAdmin]",
                BasicSearchExpression = "[bit_IsSuperAdmin]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_IsSuperAdmin]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "CHECKBOX",
                InputTextType = "text",
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "bit_IsSuperAdmin", "CustomMsg"),
                IsUpload = false
            };
            bit_IsSuperAdmin.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IsSuperAdmin, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsSuperAdmin, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IsSuperAdmin, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_IsSuperAdmin", bit_IsSuperAdmin);

            // IsDistanceBasedScheduling
            IsDistanceBasedScheduling = new (this, "x_IsDistanceBasedScheduling", 3, SqlDbType.Int) {
                Name = "IsDistanceBasedScheduling",
                Expression = "[IsDistanceBasedScheduling]",
                BasicSearchExpression = "CAST([IsDistanceBasedScheduling] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[IsDistanceBasedScheduling]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "IsDistanceBasedScheduling", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("IsDistanceBasedScheduling", IsDistanceBasedScheduling);

            // str_Package_Code
            str_Package_Code = new (this, "x_str_Package_Code", 202, SqlDbType.NVarChar) {
                Name = "str_Package_Code",
                Expression = "[str_Package_Code]",
                BasicSearchExpression = "[str_Package_Code]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Package_Code]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Package_Code", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Package_Code", str_Package_Code);

            // str_NationalID_Iqama
            str_NationalID_Iqama = new (this, "x_str_NationalID_Iqama", 200, SqlDbType.VarChar) {
                Name = "str_NationalID_Iqama",
                Expression = "[str_NationalID_Iqama]",
                UseBasicSearch = true,
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
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_NationalID_Iqama", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_NationalID_Iqama", str_NationalID_Iqama);

            // NationalID
            NationalID = new (this, "x_NationalID", 20, SqlDbType.BigInt) {
                Name = "NationalID",
                Expression = "[NationalID]",
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
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "NationalID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("NationalID", NationalID);

            // int_RoadDistanceCoverage
            int_RoadDistanceCoverage = new (this, "x_int_RoadDistanceCoverage", 3, SqlDbType.Int) {
                Name = "int_RoadDistanceCoverage",
                Expression = "[int_RoadDistanceCoverage]",
                BasicSearchExpression = "CAST([int_RoadDistanceCoverage] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_RoadDistanceCoverage]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "int_RoadDistanceCoverage", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_RoadDistanceCoverage", int_RoadDistanceCoverage);

            // str_Badge
            str_Badge = new (this, "x_str_Badge", 202, SqlDbType.NVarChar) {
                Name = "str_Badge",
                Expression = "[str_Badge]",
                BasicSearchExpression = "[str_Badge]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Badge]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_Badge", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Badge", str_Badge);

            // strZoomHostUrl
            strZoomHostUrl = new (this, "x_strZoomHostUrl", 203, SqlDbType.NText) {
                Name = "strZoomHostUrl",
                Expression = "[strZoomHostUrl]",
                BasicSearchExpression = "[strZoomHostUrl]",
                DateTimeFormat = -1,
                VirtualExpression = "[strZoomHostUrl]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "strZoomHostUrl", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("strZoomHostUrl", strZoomHostUrl);

            // strZoomUserUrl
            strZoomUserUrl = new (this, "x_strZoomUserUrl", 203, SqlDbType.NText) {
                Name = "strZoomUserUrl",
                Expression = "[strZoomUserUrl]",
                BasicSearchExpression = "[strZoomUserUrl]",
                DateTimeFormat = -1,
                VirtualExpression = "[strZoomUserUrl]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "strZoomUserUrl", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("strZoomUserUrl", strZoomUserUrl);

            // Signature
            Signature = new (this, "x_Signature", 205, SqlDbType.Image) {
                Name = "Signature",
                Expression = "[Signature]",
                BasicSearchExpression = "[Signature]",
                DateTimeFormat = -1,
                VirtualExpression = "[Signature]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "FILE",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "Signature", "CustomMsg"),
                IsUpload = true
            };
            Fields.Add("Signature", Signature);

            // str_VehicleType
            str_VehicleType = new (this, "x_str_VehicleType", 200, SqlDbType.VarChar) {
                Name = "str_VehicleType",
                Expression = "[str_VehicleType]",
                BasicSearchExpression = "[str_VehicleType]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_VehicleType]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "str_VehicleType", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_VehicleType", str_VehicleType);

            // ProfilePicturePath
            ProfilePicturePath = new (this, "x_ProfilePicturePath", 200, SqlDbType.VarChar) {
                Name = "ProfilePicturePath",
                Expression = "[ProfilePicturePath]",
                BasicSearchExpression = "[ProfilePicturePath]",
                DateTimeFormat = -1,
                VirtualExpression = "[ProfilePicturePath]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "ProfilePicturePath", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("ProfilePicturePath", ProfilePicturePath);

            // Institution
            Institution = new (this, "x_Institution", 200, SqlDbType.VarChar) {
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "Institution", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Institution", Institution);

            // IsDrivingexperience
            IsDrivingexperience = new (this, "x_IsDrivingexperience", 11, SqlDbType.Bit) {
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
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "IsDrivingexperience", "CustomMsg"),
                IsUpload = false
            };
            IsDrivingexperience.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(IsDrivingexperience, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(IsDrivingexperience, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(IsDrivingexperience, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("IsDrivingexperience", IsDrivingexperience);

            // intDrivinglicenseType
            intDrivinglicenseType = new (this, "x_intDrivinglicenseType", 3, SqlDbType.Int) {
                Name = "intDrivinglicenseType",
                Expression = "[intDrivinglicenseType]",
                UseBasicSearch = true,
                BasicSearchExpression = "CAST([intDrivinglicenseType] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[intDrivinglicenseType]",
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
                UseFilter = true, // Table header filter
                OptionCount = 4,
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "intDrivinglicenseType", "CustomMsg"),
                IsUpload = false
            };
            intDrivinglicenseType.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(intDrivinglicenseType, "tblStudents", true, "intDrivinglicenseType", new List<string> {"intDrivinglicenseType", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(intDrivinglicenseType, "tblStudents", true, "intDrivinglicenseType", new List<string> {"intDrivinglicenseType", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(intDrivinglicenseType, "tblStudents", true, "intDrivinglicenseType", new List<string> {"intDrivinglicenseType", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("intDrivinglicenseType", intDrivinglicenseType);

            // AbsherApptNbr
            AbsherApptNbr = new (this, "x_AbsherApptNbr", 202, SqlDbType.NVarChar) {
                Name = "AbsherApptNbr",
                Expression = "[AbsherApptNbr]",
                UseBasicSearch = true,
                BasicSearchExpression = "[AbsherApptNbr]",
                DateTimeFormat = -1,
                VirtualExpression = "[AbsherApptNbr]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "AbsherApptNbr", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("AbsherApptNbr", AbsherApptNbr);

            // Absherphoto
            Absherphoto = new (this, "x_Absherphoto", 202, SqlDbType.NVarChar) {
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
                HtmlTag = "FILE",
                InputTextType = "text",
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "Absherphoto", "CustomMsg"),
                IsUpload = true
            };
            Fields.Add("Absherphoto", Absherphoto);

            // Fingerprint
            Fingerprint = new (this, "x_Fingerprint", 202, SqlDbType.NVarChar) {
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
                HtmlTag = "FILE",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "Fingerprint", "CustomMsg"),
                IsUpload = true
            };
            Fields.Add("Fingerprint", Fingerprint);

            // ProfileField
            ProfileField = new (this, "x_ProfileField", 203, SqlDbType.NText) {
                Name = "ProfileField",
                Expression = "[ProfileField]",
                BasicSearchExpression = "[ProfileField]",
                DateTimeFormat = -1,
                VirtualExpression = "[ProfileField]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "ProfileField", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("ProfileField", ProfileField);

            // UserlevelID
            UserlevelID = new (this, "x_UserlevelID", 3, SqlDbType.Int) {
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
                HtmlTag = "SELECT",
                InputTextType = "text",
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "UserlevelID", "CustomMsg"),
                IsUpload = false
            };
            UserlevelID.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(UserlevelID, "UserLevels", false, "UserLevelID", new List<string> {"UserLevelName", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[UserLevelName]"),
                "en-US" => new Lookup<DbField>(UserlevelID, "UserLevels", false, "UserLevelID", new List<string> {"UserLevelName", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[UserLevelName]"),
                _ => new Lookup<DbField>(UserlevelID, "UserLevels", false, "UserLevelID", new List<string> {"UserLevelName", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[UserLevelName]")
            };
            Fields.Add("UserlevelID", UserlevelID);

            // Parent_Username
            Parent_Username = new (this, "x_Parent_Username", 202, SqlDbType.NVarChar) {
                Name = "Parent_Username",
                Expression = "[Parent_Username]",
                BasicSearchExpression = "[Parent_Username]",
                DateTimeFormat = -1,
                VirtualExpression = "[Parent_Username]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "SELECT",
                InputTextType = "text",
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "Parent_Username", "CustomMsg"),
                IsUpload = false
            };
            Parent_Username.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Parent_Username, "tblStaff", false, "str_Username", new List<string> {"str_Username", "str_Full_Name", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT([str_Username],'" + ValueSeparator(1, Parent_Username) + "',[str_Full_Name])"),
                "en-US" => new Lookup<DbField>(Parent_Username, "tblStaff", false, "str_Username", new List<string> {"str_Username", "str_Full_Name", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT([str_Username],'" + ValueSeparator(1, Parent_Username) + "',[str_Full_Name])"),
                _ => new Lookup<DbField>(Parent_Username, "tblStaff", false, "str_Username", new List<string> {"str_Username", "str_Full_Name", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT([str_Username],'" + ValueSeparator(1, Parent_Username) + "',[str_Full_Name])")
            };
            Fields.Add("Parent_Username", Parent_Username);

            // Activated
            Activated = new (this, "x_Activated", 11, SqlDbType.Bit) {
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
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "Activated", "CustomMsg"),
                IsUpload = false
            };
            Activated.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Activated, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Activated, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Activated, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Activated", Activated);

            // int_Nationality
            int_Nationality = new (this, "x_int_Nationality", 3, SqlDbType.Int) {
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "int_Nationality", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Nationality", int_Nationality);

            // User_Role
            User_Role = new (this, "x_User_Role", 202, SqlDbType.NVarChar) {
                Name = "User_Role",
                Expression = "[User_Role]",
                BasicSearchExpression = "[User_Role]",
                DateTimeFormat = -1,
                VirtualExpression = "[User_Role]",
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
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "User_Role", "CustomMsg"),
                IsUpload = false
            };
            User_Role.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(User_Role, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(User_Role, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(User_Role, "tblStudents", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("User_Role", User_Role);

            // int_Staff_Id
            int_Staff_Id = new (this, "x_int_Staff_Id", 3, SqlDbType.Int) {
                Name = "int_Staff_Id",
                Expression = "[int_Staff_Id]",
                BasicSearchExpression = "CAST([int_Staff_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Staff_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudents", "int_Staff_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Staff_Id", int_Staff_Id);

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
            if (mi != null) {
                dynamic? awaitable = mi.Invoke(this, parameters);
                if (awaitable != null) {
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
            if (mi != null) {
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
            if (m.Success) {
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
            if (CurrentOrder == fld.Name) {
                sortField = fld.Expression;
                lastSort = fld.Sort;
                if ((new[] { "ASC", "DESC", "NO" }).Contains(CurrentOrderType)) {
                    curSort = CurrentOrderType;
                } else {
                    curSort = lastSort;
                }
                lastOrderBy = (new[] { "ASC", "DESC" }).Contains(lastSort) ? sortField + " " + lastSort : "";
                curOrderBy = (new[] { "ASC", "DESC" }).Contains(curSort) ? sortField + " " + curSort : "";
                if (ctrl) {
                    orderBy = SessionOrderBy;
                    List<string> listOrderBy = !Empty(orderBy) ? orderBy.Split(new string[] { ", " }, StringSplitOptions.None).ToList() : new ();
                    if (!Empty(lastOrderBy) && listOrderBy.Contains(lastOrderBy)) {
                        if (Empty(curOrderBy)) {
                            listOrderBy.Remove(lastOrderBy);
                        } else {
                            var index = listOrderBy.IndexOf(lastOrderBy);
                            listOrderBy[index] = curOrderBy;
                        }
                    } else if (!Empty(curOrderBy)) {
                        listOrderBy.Add(curOrderBy);
                    }
                    orderBy = String.Join(", ", listOrderBy);
                    SessionOrderBy = orderBy; // Save to Session
                } else {
                    SessionOrderBy = curOrderBy; // Save to Session
                }
            }
        }

        // Update field sort
        public void UpdateFieldSort()
        {
            string orderBy = SessionOrderBy; // Get ORDER BY from Session
            var flds = GetSortFields(orderBy);
            foreach (var (key, field) in Fields) {
                string fldSort = "";
                foreach (var fld in flds) {
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
            get {
                string detailUrl = "";
                if (CurrentDetailTable == "tblAssessment" && tblAssessment != null) {
                    detailUrl = tblAssessment.ListUrl + "?" + Config.TableShowMaster + "=" + TableVar;
                    detailUrl += "&" + ForeignKeyUrl("fk_str_Username", str_Username.CurrentValue);
                }
                if (Empty(detailUrl))
                    detailUrl = "TblStudentsList";
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
            get => _sqlFrom ?? "dbo.tblStudents";
            set => _sqlFrom = value;
        }

        // SELECT
        private string? _sqlSelect = null;

        public string SqlSelect { // Select
            get => _sqlSelect ?? "SELECT * FROM " + SqlFrom;
            set => _sqlSelect = value;
        }

        // WHERE // DN
        private string? _sqlWhere = null;

        public string SqlWhere
        {
            get {
                string where = "";
                return _sqlWhere ?? where;
            }
            set {
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
            if (!Empty(Security.CurrentUserID) && !Security.IsAdmin) { // Non system admin
                filter = AddUserIDFilter(filter, id);
            }
            return filter;
        }

        // Check if User ID security allows view all
        public bool UserIDAllow(string id = "")
        {
            int allow = UserIdAllowSecurity;
            return id switch {
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
        public async Task<int> GetRecordCountAsync(string sql, dynamic? c = null) {
            try {
                var cnt = 0;
                var conn = c ?? Connection;
                using var dr = await conn.OpenDataReaderAsync(sql);
                if (dr != null) {
                    while (await dr.ReadAsync())
                        cnt++;
                }
                return cnt;
            } catch {
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
            try {
                string sqlcnt;
                if ((new[] { "TABLE", "VIEW", "LINKTABLE" }).Contains(Type) && sql.StartsWith(SqlSelect)) { // Handle Custom Field
                    sqlcnt = "SELECT COUNT(*) FROM " + SqlFrom + sql.Substring(SqlSelect.Length);
                } else {
                    sqlcnt = "SELECT COUNT(*) FROM (" + sql + ") EW_COUNT_TABLE";
                }
                return Convert.ToInt32(await conn?.ExecuteScalarAsync(sqlcnt));
            } catch {
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
            get {
                string filter = CurrentFilter;
                filter = ApplyUserIDFilters(filter); // Add User ID filter
                string sort = SessionOrderBy;
                return GetSql(filter, sort);
            }
        }

        // Table SQL with List page filter
        public string ListSql
        {
            get {
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
            get {
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
            row = row.Where(kvp => {
                var fld = FieldByName(kvp.Key);
                return fld != null && !fld.IsCustom;
            }).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            if (row.Count == 0)
                return -1;
            var queryBuilder = GetQueryBuilder();
            try {
                var lastInsertedId = await queryBuilder.InsertGetIdAsync<int>(row);
                int_Student_ID.SetDbValue(lastInsertedId);
                result = 1;
            } catch (Exception e) {
                CurrentPage?.SetFailureMessage(e.Message);
                if (Config.Debug)
                    throw;
            }
            if (result > 0 && AuditTrailOnAdd)
                await WriteAuditTrailOnAdd(row);
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
            Dictionary<string, object> rscascade = new ();
            if (rsold != null) {
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
            if (result > 0 && AuditTrailOnEdit && rsold != null) {
                var rsaudit = new Dictionary<string, object>(row);
                if (!rsaudit.ContainsKey("int_Student_ID"))
                    rsaudit.Add("int_Student_ID", rsold["int_Student_ID"]);
                await WriteAuditTrailOnEdit(rsold, rsaudit);
            }
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
            if (row != null) {
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
            if (result > 0 && AuditTrailOnDelete && row != null)
                await WriteAuditTrailOnDelete(row);
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
            try {
                int_Student_ID.DbValue = row["int_Student_ID"]; // Set DB value only
                str_First_Name.DbValue = row["str_First_Name"]; // Set DB value only
                str_Middle_Name.DbValue = row["str_Middle_Name"]; // Set DB value only
                str_Last_Name.DbValue = row["str_Last_Name"]; // Set DB value only
                str_Full_Name.DbValue = row["str_Full_Name"]; // Set DB value only
                str_Address.DbValue = row["str_Address"]; // Set DB value only
                str_City.DbValue = row["str_City"]; // Set DB value only
                int_State.DbValue = row["int_State"]; // Set DB value only
                str_Zip.DbValue = row["str_Zip"]; // Set DB value only
                date_Hired.DbValue = row["date_Hired"]; // Set DB value only
                date_Left.DbValue = row["date_Left"]; // Set DB value only
                str_CertNumber.DbValue = row["str_CertNumber"]; // Set DB value only
                date_CertExp.DbValue = row["date_CertExp"]; // Set DB value only
                str_Cell_Phone.DbValue = row["str_Cell_Phone"]; // Set DB value only
                str_Home_Phone.DbValue = row["str_Home_Phone"]; // Set DB value only
                str_Other_Phone.DbValue = row["str_Other_Phone"]; // Set DB value only
                str_Email.DbValue = row["str_Email"]; // Set DB value only
                str_Code.DbValue = row["str_Code"]; // Set DB value only
                str_Username.DbValue = row["str_Username"]; // Set DB value only
                str_Password.DbValue = row["str_Password"]; // Set DB value only
                date_Birth_Hijri.DbValue = row["date_Birth_Hijri"]; // Set DB value only
                date_Birth.DbValue = row["date_Birth"]; // Set DB value only
                Hijri_Year.DbValue = row["Hijri_Year"]; // Set DB value only
                Hijri_Month.DbValue = row["Hijri_Month"]; // Set DB value only
                Hijri_Day.DbValue = row["Hijri_Day"]; // Set DB value only
                date_Started.DbValue = row["date_Started"]; // Set DB value only
                str_DateHired.DbValue = row["str_DateHired"]; // Set DB value only
                str_DateLeft.DbValue = row["str_DateLeft"]; // Set DB value only
                str_Emergency_Contact_Name.DbValue = row["str_Emergency_Contact_Name"]; // Set DB value only
                str_Emergency_Contact_Phone.DbValue = row["str_Emergency_Contact_Phone"]; // Set DB value only
                str_Emergency_Contact_Relation.DbValue = row["str_Emergency_Contact_Relation"]; // Set DB value only
                str_Notes.DbValue = row["str_Notes"]; // Set DB value only
                int_ClassType.DbValue = row["int_ClassType"]; // Set DB value only
                str_ZipCodes.DbValue = row["str_ZipCodes"]; // Set DB value only
                int_VehicleAssigned.DbValue = row["int_VehicleAssigned"]; // Set DB value only
                int_Status.DbValue = row["int_Status"]; // Set DB value only
                int_Type.DbValue = row["int_Type"]; // Set DB value only
                int_Location.DbValue = row["int_Location"]; // Set DB value only
                date_Created.DbValue = row["date_Created"]; // Set DB value only
                date_Modified.DbValue = row["date_Modified"]; // Set DB value only
                int_Created_By.DbValue = row["int_Created_By"]; // Set DB value only
                int_Modified_By.DbValue = row["int_Modified_By"]; // Set DB value only
                bit_IsDeleted.DbValue = (ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"); // Set DB value only
                str_InstPermitNo.DbValue = row["str_InstPermitNo"]; // Set DB value only
                date_PermitExpiration.DbValue = row["date_PermitExpiration"]; // Set DB value only
                date_InCarPermitIssue.DbValue = row["date_InCarPermitIssue"]; // Set DB value only
                str_InClassPermitNo.DbValue = row["str_InClassPermitNo"]; // Set DB value only
                date_InClassPermitIssue.DbValue = row["date_InClassPermitIssue"]; // Set DB value only
                instructor_caption.DbValue = row["instructor_caption"]; // Set DB value only
                str_LicType.DbValue = row["str_LicType"]; // Set DB value only
                int_Order.DbValue = row["int_Order"]; // Set DB value only
                str_InstLicenceDate.DbValue = row["str_InstLicenceDate"]; // Set DB value only
                str_DLNum.DbValue = row["str_DLNum"]; // Set DB value only
                str_DLExp.DbValue = row["str_DLExp"]; // Set DB value only
                bit_appointmentColor.DbValue = (ConvertToBool(row["bit_appointmentColor"]) ? "1" : "0"); // Set DB value only
                str_appointmentColorCode.DbValue = row["str_appointmentColorCode"]; // Set DB value only
                bit_IsSuperAdmin.DbValue = (ConvertToBool(row["bit_IsSuperAdmin"]) ? "1" : "0"); // Set DB value only
                IsDistanceBasedScheduling.DbValue = row["IsDistanceBasedScheduling"]; // Set DB value only
                str_Package_Code.DbValue = row["str_Package_Code"]; // Set DB value only
                str_NationalID_Iqama.DbValue = row["str_NationalID_Iqama"]; // Set DB value only
                NationalID.DbValue = row["NationalID"]; // Set DB value only
                int_RoadDistanceCoverage.DbValue = row["int_RoadDistanceCoverage"]; // Set DB value only
                str_Badge.DbValue = row["str_Badge"]; // Set DB value only
                strZoomHostUrl.DbValue = row["strZoomHostUrl"]; // Set DB value only
                strZoomUserUrl.DbValue = row["strZoomUserUrl"]; // Set DB value only
                Signature.Upload.DbValue = row["Signature"];
                str_VehicleType.DbValue = row["str_VehicleType"]; // Set DB value only
                ProfilePicturePath.DbValue = row["ProfilePicturePath"]; // Set DB value only
                Institution.DbValue = row["Institution"]; // Set DB value only
                IsDrivingexperience.DbValue = (ConvertToBool(row["IsDrivingexperience"]) ? "1" : "0"); // Set DB value only
                intDrivinglicenseType.DbValue = row["intDrivinglicenseType"]; // Set DB value only
                AbsherApptNbr.DbValue = row["AbsherApptNbr"]; // Set DB value only
                Absherphoto.Upload.DbValue = row["Absherphoto"];
                Fingerprint.Upload.DbValue = row["Fingerprint"];
                ProfileField.DbValue = row["ProfileField"]; // Set DB value only
                UserlevelID.DbValue = row["UserlevelID"]; // Set DB value only
                Parent_Username.DbValue = row["Parent_Username"]; // Set DB value only
                Activated.DbValue = (ConvertToBool(row["Activated"]) ? "1" : "0"); // Set DB value only
                int_Nationality.DbValue = row["int_Nationality"]; // Set DB value only
                User_Role.DbValue = row["User_Role"]; // Set DB value only
                int_Staff_Id.DbValue = row["int_Staff_Id"]; // Set DB value only
            } catch {}
        }

        public void DeleteUploadedFiles(Dictionary<string, object> row)
        {
            LoadDbValues(row);
            if (!Empty(row["Absherphoto"])) {
                DeleteFile(Absherphoto.OldPhysicalUploadPath + row["Absherphoto"]);
            }
            if (!Empty(row["Fingerprint"])) {
                DeleteFile(Fingerprint.OldPhysicalUploadPath + row["Fingerprint"]);
            }
        }

        // Record filter WHERE clause
        private string _sqlKeyFilter => "[int_Student_ID] = @int_Student_ID@";

        #pragma warning disable 168, 219
        // Get record filter as string
        public string GetRecordFilter(Dictionary<string, object>? row = null, bool current = false)
        {
            string keyFilter = _sqlKeyFilter;
            object? val = null, result = "";
            val = row?.TryGetValue("int_Student_ID", out result) ?? false
                ? result
                : !Empty(int_Student_ID.OldValue) && !current ? int_Student_ID.OldValue : int_Student_ID.CurrentValue;
            if (!IsNumeric(val))
                return "0=1"; // Invalid key
            if (val == null)
                return "0=1"; // Invalid key
            keyFilter = keyFilter.Replace("@int_Student_ID@", AdjustSql(val, DbId)); // Replace key value
            return keyFilter;
        }

        // Get record filter as Dictionary // DN
        public Dictionary<string, object>? GetRowFilterAsDictionary(IDictionary<string, object>? row = null)
        {
            Dictionary<string, object>? keyFilter = new ();
            object? val = null, result;
            val = row?.TryGetValue("int_Student_ID", out result) ?? false
                ? result
                : !Empty(int_Student_ID.OldValue) ? int_Student_ID.OldValue : int_Student_ID.CurrentValue;
            if (!IsNumeric(val))
                return null; // Invalid key
            if (Empty(val))
                return null; // Invalid key
            keyFilter.Add("int_Student_ID", val); // Add key value
            return keyFilter.Count > 0 ? keyFilter : null;
        }
        #pragma warning restore 168, 219

        // Return URL
        public string ReturnUrl
        {
            get {
                string name = Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl;
                // Get referer URL automatically
                if (!Empty(ReferUrl()) && !SameText(ReferPage(), CurrentPageName()) &&
                    !SameText(ReferPage(), "login")) {// Referer not same page or login page
                        Session[name] = ReferUrl(); // Save to Session
                }
                if (!Empty(Session[name])) {
                    return Session.GetString(name);
                } else {
                    return "TblStudentsList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "TblStudentsView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "TblStudentsEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "TblStudentsAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "TblStudentsList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "TblStudentsView",
                Config.ApiAddAction => "TblStudentsAdd",
                Config.ApiEditAction => "TblStudentsEdit",
                Config.ApiDeleteAction => "TblStudentsDelete",
                Config.ApiListAction => "TblStudentsList",
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
        public string ListUrl => "TblStudentsList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblStudentsView", parm);
            else
                url = KeyUrl("TblStudentsView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "TblStudentsAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "TblStudentsAdd?" + parm;
            else
                url = "TblStudentsAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblStudentsEdit", parm);
            else
                url = KeyUrl("TblStudentsEdit", Config.TableShowDetail + "=");
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblStudentsList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblStudentsAdd", parm);
            else
                url = KeyUrl("TblStudentsAdd", Config.TableShowDetail + "=");
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblStudentsList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("TblStudentsDelete")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
            return url;
        }

        // Get primary key as JSON
        public string KeyToJson(bool htmlEncode = false)
        {
            string json = "";
            json += "\"int_Student_ID\":" + ConvertToJson(int_Student_ID.CurrentValue, "number", true);
            json = "{" + json + "}";
            if (htmlEncode)
                json = HtmlEncode(json);
            return json;
        }

        // Add key value to URL
        public string KeyUrl(string url, string parm = "") { // DN
            if (!IsNull(int_Student_ID.CurrentValue)) {
                url += "/" + int_Student_ID.CurrentValue;
            } else {
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
            if (fld.Sortable) {
                sortUrl = SortUrl(fld);
                attrs = " role=\"button\" data-ew-action=\"sort\" data-ajax=\"" + (UseAjaxActions ? "true" : "false") + "\" data-sort-url=\"" + sortUrl + "\" data-sort-type=\"2\"";
                if (!Empty(ContextClass)) // Add context
                    attrs += " data-context=\"" + HtmlEncode(ContextClass) + "\"";
            }
            string html = "<div class=\"ew-table-header-caption\"" + attrs + ">" + fld.Caption + "</div>";
            if (!Empty(sortUrl)) {
                html += "<div class=\"ew-table-header-sort\">" + fld.SortIcon + "</div>";
            }
            if (fld.UseFilter && Security.CanSearch) {
                html += "<div class=\"ew-filter-dropdown-btn\" data-ew-action=\"filter\" data-table=\"" + fld.TableVar + "\" data-field=\"" + fld.FieldVar +
                    "\"><div class=\"ew-table-header-filter\" role=\"button\" aria-haspopup=\"true\">" + Language.Phrase("Filter") + "</div></div>";
            }
            html = "<div class=\"ew-table-header-btn\">" + html + "</div>";
            if (UseCustomTemplate) {
                string scriptId = ("tpc_{id}").Replace("{id}", fld.TableVar + "_" + fld.Param);
                html = "<template id=\"" + scriptId + "\">" + html + "</template>";
            }
            return html;
        }

        // Sort URL (already URL-encoded)
        public string SortUrl(DbField fld)
        {
            if (!Empty(CurrentAction) || !Empty(Export) ||
                (new[] {141, 201, 203, 128, 204, 205}).Contains(fld.Type)) { // Unsortable data type
                return "";
            } else if (fld.Sortable) {
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
            List<string> keys = new ();
            string val;
            val = current ? ConvertToString(int_Student_ID.CurrentValue) ?? "" : ConvertToString(int_Student_ID.OldValue) ?? "";
            if (Empty(val))
                return String.Empty;
            keys.Add(val);
            return String.Join(Config.CompositeKeySeparator, keys);
        }

        // Get record filter as string // DN
        public string GetKey(IDictionary<string, object> row)
        {
            List<string> keys = new ();
            object? val = null, result;
            val = row?.TryGetValue("int_Student_ID", out result) ?? false ? ConvertToString(result) : null;
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
            if (keys.Length == 1) {
                if (current) {
                    int_Student_ID.CurrentValue = keys[0];
                } else {
                    int_Student_ID.OldValue = keys[0];
                }
            }
        }

        #pragma warning disable 168
        // Get record keys
        public List<string> GetRecordKeys()
        {
            List<string> result = new ();
            StringValues sv;
            List<string> keysList = new ();
            if (Post("key_m[]", out sv) || Get("key_m[]", out sv)) { // DN
                keysList = ((StringValues)sv).Select(k => ConvertToString(k)).ToList();
            } else if (RouteValues.Count > 0 || Query.Count > 0 || Form.Count > 0) { // DN
                string key = "";
                string[] keyValues = {};
                if (IsApi() && RouteValues.TryGetValue("key", out object? k)) {
                    string str = ConvertToString(k);
                    keyValues = str.Split('/');
                }
                if (RouteValues.TryGetValue("int_Student_ID", out object? v0)) { // int_Student_ID // DN
                    key = UrlDecode(v0); // DN
                } else if (IsApi() && !Empty(keyValues)) {
                    key = keyValues[0];
                } else {
                    key = Param("int_Student_ID");
                }
                keysList.Add(key);
            }
            // Check keys
            foreach (var keys in keysList) {
                if (!IsNumeric(keys)) // int_Student_ID
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
            foreach (var keys in recordKeys) {
                if (!Empty(keyFilter))
                    keyFilter += " OR ";
                if (setCurrent)
                    int_Student_ID.CurrentValue = keys;
                else
                    int_Student_ID.OldValue = keys;
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
            try {
                var dr = await (conn ?? Connection).OpenDataReaderAsync(sql);
                if (dr?.HasRows ?? false)
                    return dr;
                else
                    dr?.Close(); // Close unused data reader // DN
            } catch {}
            return null;
        }
        #pragma warning restore 618

        // Load row values from recordset
        public void LoadListRowValues(DbDataReader? dr)
        {
            if (dr == null)
                return;
            int_Student_ID.SetDbValue(dr["int_Student_ID"]);
            str_First_Name.SetDbValue(dr["str_First_Name"]);
            str_Middle_Name.SetDbValue(dr["str_Middle_Name"]);
            str_Last_Name.SetDbValue(dr["str_Last_Name"]);
            str_Full_Name.SetDbValue(dr["str_Full_Name"]);
            str_Address.SetDbValue(dr["str_Address"]);
            str_City.SetDbValue(dr["str_City"]);
            int_State.SetDbValue(dr["int_State"]);
            str_Zip.SetDbValue(dr["str_Zip"]);
            date_Hired.SetDbValue(dr["date_Hired"]);
            date_Left.SetDbValue(dr["date_Left"]);
            str_CertNumber.SetDbValue(dr["str_CertNumber"]);
            date_CertExp.SetDbValue(dr["date_CertExp"]);
            str_Cell_Phone.SetDbValue(dr["str_Cell_Phone"]);
            str_Home_Phone.SetDbValue(dr["str_Home_Phone"]);
            str_Other_Phone.SetDbValue(dr["str_Other_Phone"]);
            str_Email.SetDbValue(dr["str_Email"]);
            str_Code.SetDbValue(dr["str_Code"]);
            str_Username.SetDbValue(dr["str_Username"]);
            str_Password.SetDbValue(dr["str_Password"]);
            date_Birth_Hijri.SetDbValue(dr["date_Birth_Hijri"]);
            date_Birth.SetDbValue(dr["date_Birth"]);
            Hijri_Year.SetDbValue(dr["Hijri_Year"]);
            Hijri_Month.SetDbValue(dr["Hijri_Month"]);
            Hijri_Day.SetDbValue(dr["Hijri_Day"]);
            date_Started.SetDbValue(dr["date_Started"]);
            str_DateHired.SetDbValue(dr["str_DateHired"]);
            str_DateLeft.SetDbValue(dr["str_DateLeft"]);
            str_Emergency_Contact_Name.SetDbValue(dr["str_Emergency_Contact_Name"]);
            str_Emergency_Contact_Phone.SetDbValue(dr["str_Emergency_Contact_Phone"]);
            str_Emergency_Contact_Relation.SetDbValue(dr["str_Emergency_Contact_Relation"]);
            str_Notes.SetDbValue(dr["str_Notes"]);
            int_ClassType.SetDbValue(dr["int_ClassType"]);
            str_ZipCodes.SetDbValue(dr["str_ZipCodes"]);
            int_VehicleAssigned.SetDbValue(dr["int_VehicleAssigned"]);
            int_Status.SetDbValue(dr["int_Status"]);
            int_Type.SetDbValue(dr["int_Type"]);
            int_Location.SetDbValue(dr["int_Location"]);
            date_Created.SetDbValue(dr["date_Created"]);
            date_Modified.SetDbValue(dr["date_Modified"]);
            int_Created_By.SetDbValue(dr["int_Created_By"]);
            int_Modified_By.SetDbValue(dr["int_Modified_By"]);
            bit_IsDeleted.SetDbValue(ConvertToBool(dr["bit_IsDeleted"]) ? "1" : "0");
            str_InstPermitNo.SetDbValue(dr["str_InstPermitNo"]);
            date_PermitExpiration.SetDbValue(dr["date_PermitExpiration"]);
            date_InCarPermitIssue.SetDbValue(dr["date_InCarPermitIssue"]);
            str_InClassPermitNo.SetDbValue(dr["str_InClassPermitNo"]);
            date_InClassPermitIssue.SetDbValue(dr["date_InClassPermitIssue"]);
            instructor_caption.SetDbValue(dr["instructor_caption"]);
            str_LicType.SetDbValue(dr["str_LicType"]);
            int_Order.SetDbValue(dr["int_Order"]);
            str_InstLicenceDate.SetDbValue(dr["str_InstLicenceDate"]);
            str_DLNum.SetDbValue(dr["str_DLNum"]);
            str_DLExp.SetDbValue(dr["str_DLExp"]);
            bit_appointmentColor.SetDbValue(ConvertToBool(dr["bit_appointmentColor"]) ? "1" : "0");
            str_appointmentColorCode.SetDbValue(dr["str_appointmentColorCode"]);
            bit_IsSuperAdmin.SetDbValue(ConvertToBool(dr["bit_IsSuperAdmin"]) ? "1" : "0");
            IsDistanceBasedScheduling.SetDbValue(dr["IsDistanceBasedScheduling"]);
            str_Package_Code.SetDbValue(dr["str_Package_Code"]);
            str_NationalID_Iqama.SetDbValue(dr["str_NationalID_Iqama"]);
            NationalID.SetDbValue(dr["NationalID"]);
            int_RoadDistanceCoverage.SetDbValue(dr["int_RoadDistanceCoverage"]);
            str_Badge.SetDbValue(dr["str_Badge"]);
            strZoomHostUrl.SetDbValue(dr["strZoomHostUrl"]);
            strZoomUserUrl.SetDbValue(dr["strZoomUserUrl"]);
            Signature.Upload.DbValue = dr["Signature"];
            str_VehicleType.SetDbValue(dr["str_VehicleType"]);
            ProfilePicturePath.SetDbValue(dr["ProfilePicturePath"]);
            Institution.SetDbValue(dr["Institution"]);
            IsDrivingexperience.SetDbValue(ConvertToBool(dr["IsDrivingexperience"]) ? "1" : "0");
            intDrivinglicenseType.SetDbValue(dr["intDrivinglicenseType"]);
            AbsherApptNbr.SetDbValue(dr["AbsherApptNbr"]);
            Absherphoto.Upload.DbValue = dr["Absherphoto"];
            Absherphoto.SetDbValue(Absherphoto.Upload.DbValue);
            Fingerprint.Upload.DbValue = dr["Fingerprint"];
            Fingerprint.SetDbValue(Fingerprint.Upload.DbValue);
            ProfileField.SetDbValue(dr["ProfileField"]);
            UserlevelID.SetDbValue(dr["UserlevelID"]);
            Parent_Username.SetDbValue(dr["Parent_Username"]);
            Activated.SetDbValue(ConvertToBool(dr["Activated"]) ? "1" : "0");
            int_Nationality.SetDbValue(dr["int_Nationality"]);
            User_Role.SetDbValue(dr["User_Role"]);
            int_Staff_Id.SetDbValue(dr["int_Staff_Id"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "TblStudentsList";
            dynamic? page = CreateInstance(pageName, new object[] { Controller }); // DN
            if (page != null) {
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

            // int_Student_ID

            // str_First_Name

            // str_Middle_Name

            // str_Last_Name

            // str_Full_Name
            str_Full_Name.CellCssStyle = "white-space: nowrap;";

            // str_Address

            // str_City

            // int_State

            // str_Zip

            // date_Hired

            // date_Left

            // str_CertNumber

            // date_CertExp

            // str_Cell_Phone

            // str_Home_Phone

            // str_Other_Phone

            // str_Email

            // str_Code

            // str_Username

            // str_Password

            // date_Birth_Hijri

            // date_Birth

            // Hijri_Year

            // Hijri_Month

            // Hijri_Day

            // date_Started

            // str_DateHired

            // str_DateLeft

            // str_Emergency_Contact_Name

            // str_Emergency_Contact_Phone

            // str_Emergency_Contact_Relation

            // str_Notes

            // int_ClassType

            // str_ZipCodes

            // int_VehicleAssigned

            // int_Status

            // int_Type

            // int_Location

            // date_Created

            // date_Modified

            // int_Created_By

            // int_Modified_By

            // bit_IsDeleted

            // str_InstPermitNo

            // date_PermitExpiration

            // date_InCarPermitIssue

            // str_InClassPermitNo

            // date_InClassPermitIssue

            // instructor_caption

            // str_LicType

            // int_Order

            // str_InstLicenceDate

            // str_DLNum

            // str_DLExp

            // bit_appointmentColor

            // str_appointmentColorCode

            // bit_IsSuperAdmin

            // IsDistanceBasedScheduling

            // str_Package_Code

            // str_NationalID_Iqama

            // NationalID

            // int_RoadDistanceCoverage

            // str_Badge

            // strZoomHostUrl

            // strZoomUserUrl

            // Signature

            // str_VehicleType

            // ProfilePicturePath

            // Institution

            // IsDrivingexperience
            IsDrivingexperience.CellCssStyle = "white-space: nowrap;";

            // intDrivinglicenseType

            // AbsherApptNbr

            // Absherphoto

            // Fingerprint

            // ProfileField

            // UserlevelID

            // Parent_Username

            // Activated

            // int_Nationality

            // User_Role

            // int_Staff_Id

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

            // str_ZipCodes
            str_ZipCodes.ViewValue = str_ZipCodes.CurrentValue;
            str_ZipCodes.ViewCustomAttributes = "";

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

            // strZoomHostUrl
            strZoomHostUrl.ViewValue = strZoomHostUrl.CurrentValue;
            strZoomHostUrl.ViewCustomAttributes = "";

            // strZoomUserUrl
            strZoomUserUrl.ViewValue = strZoomUserUrl.CurrentValue;
            strZoomUserUrl.ViewCustomAttributes = "";

            // Signature
            if (!IsNull(Signature.Upload.DbValue)) {
                Signature.ViewValue = RawUrlEncode(int_Student_ID.CurrentValue);
                Signature.IsBlobImage = IsImageFile(ContentExtension((byte[])Signature.Upload.DbValue));
            } else {
                Signature.ViewValue = "";
            }
            Signature.ViewCustomAttributes = "";

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

            // ProfileField
            ProfileField.ViewValue = ProfileField.CurrentValue;
            ProfileField.ViewCustomAttributes = "";

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

            // int_Student_ID
            int_Student_ID.HrefValue = "";
            int_Student_ID.TooltipValue = "";

            // str_First_Name
            str_First_Name.HrefValue = "";
            str_First_Name.TooltipValue = "";

            // str_Middle_Name
            str_Middle_Name.HrefValue = "";
            str_Middle_Name.TooltipValue = "";

            // str_Last_Name
            str_Last_Name.HrefValue = "";
            str_Last_Name.TooltipValue = "";

            // str_Full_Name
            str_Full_Name.HrefValue = "";
            str_Full_Name.TooltipValue = "";

            // str_Address
            str_Address.HrefValue = "";
            str_Address.TooltipValue = "";

            // str_City
            str_City.HrefValue = "";
            str_City.TooltipValue = "";

            // int_State
            int_State.HrefValue = "";
            int_State.TooltipValue = "";

            // str_Zip
            str_Zip.HrefValue = "";
            str_Zip.TooltipValue = "";

            // date_Hired
            date_Hired.HrefValue = "";
            date_Hired.TooltipValue = "";

            // date_Left
            date_Left.HrefValue = "";
            date_Left.TooltipValue = "";

            // str_CertNumber
            str_CertNumber.HrefValue = "";
            str_CertNumber.TooltipValue = "";

            // date_CertExp
            date_CertExp.HrefValue = "";
            date_CertExp.TooltipValue = "";

            // str_Cell_Phone
            str_Cell_Phone.HrefValue = "";
            str_Cell_Phone.TooltipValue = "";

            // str_Home_Phone
            str_Home_Phone.HrefValue = "";
            str_Home_Phone.TooltipValue = "";

            // str_Other_Phone
            str_Other_Phone.HrefValue = "";
            str_Other_Phone.TooltipValue = "";

            // str_Email
            str_Email.HrefValue = "";
            str_Email.TooltipValue = "";

            // str_Code
            str_Code.HrefValue = "";
            str_Code.TooltipValue = "";

            // str_Username
            str_Username.HrefValue = "";
            str_Username.TooltipValue = "";

            // str_Password
            str_Password.HrefValue = "";
            str_Password.TooltipValue = "";

            // date_Birth_Hijri
            date_Birth_Hijri.HrefValue = "";
            date_Birth_Hijri.TooltipValue = "";

            // date_Birth
            date_Birth.HrefValue = "";
            date_Birth.TooltipValue = "";

            // Hijri_Year
            Hijri_Year.HrefValue = "";
            Hijri_Year.TooltipValue = "";

            // Hijri_Month
            Hijri_Month.HrefValue = "";
            Hijri_Month.TooltipValue = "";

            // Hijri_Day
            Hijri_Day.HrefValue = "";
            Hijri_Day.TooltipValue = "";

            // date_Started
            date_Started.HrefValue = "";
            date_Started.TooltipValue = "";

            // str_DateHired
            str_DateHired.HrefValue = "";
            str_DateHired.TooltipValue = "";

            // str_DateLeft
            str_DateLeft.HrefValue = "";
            str_DateLeft.TooltipValue = "";

            // str_Emergency_Contact_Name
            str_Emergency_Contact_Name.HrefValue = "";
            str_Emergency_Contact_Name.TooltipValue = "";

            // str_Emergency_Contact_Phone
            str_Emergency_Contact_Phone.HrefValue = "";
            str_Emergency_Contact_Phone.TooltipValue = "";

            // str_Emergency_Contact_Relation
            str_Emergency_Contact_Relation.HrefValue = "";
            str_Emergency_Contact_Relation.TooltipValue = "";

            // str_Notes
            str_Notes.HrefValue = "";
            str_Notes.TooltipValue = "";

            // int_ClassType
            int_ClassType.HrefValue = "";
            int_ClassType.TooltipValue = "";

            // str_ZipCodes
            str_ZipCodes.HrefValue = "";
            str_ZipCodes.TooltipValue = "";

            // int_VehicleAssigned
            int_VehicleAssigned.HrefValue = "";
            int_VehicleAssigned.TooltipValue = "";

            // int_Status
            int_Status.HrefValue = "";
            int_Status.TooltipValue = "";

            // int_Type
            int_Type.HrefValue = "";
            int_Type.TooltipValue = "";

            // int_Location
            int_Location.HrefValue = "";
            int_Location.TooltipValue = "";

            // date_Created
            date_Created.HrefValue = "";
            date_Created.TooltipValue = "";

            // date_Modified
            date_Modified.HrefValue = "";
            date_Modified.TooltipValue = "";

            // int_Created_By
            int_Created_By.HrefValue = "";
            int_Created_By.TooltipValue = "";

            // int_Modified_By
            int_Modified_By.HrefValue = "";
            int_Modified_By.TooltipValue = "";

            // bit_IsDeleted
            bit_IsDeleted.HrefValue = "";
            bit_IsDeleted.TooltipValue = "";

            // str_InstPermitNo
            str_InstPermitNo.HrefValue = "";
            str_InstPermitNo.TooltipValue = "";

            // date_PermitExpiration
            date_PermitExpiration.HrefValue = "";
            date_PermitExpiration.TooltipValue = "";

            // date_InCarPermitIssue
            date_InCarPermitIssue.HrefValue = "";
            date_InCarPermitIssue.TooltipValue = "";

            // str_InClassPermitNo
            str_InClassPermitNo.HrefValue = "";
            str_InClassPermitNo.TooltipValue = "";

            // date_InClassPermitIssue
            date_InClassPermitIssue.HrefValue = "";
            date_InClassPermitIssue.TooltipValue = "";

            // instructor_caption
            instructor_caption.HrefValue = "";
            instructor_caption.TooltipValue = "";

            // str_LicType
            str_LicType.HrefValue = "";
            str_LicType.TooltipValue = "";

            // int_Order
            int_Order.HrefValue = "";
            int_Order.TooltipValue = "";

            // str_InstLicenceDate
            str_InstLicenceDate.HrefValue = "";
            str_InstLicenceDate.TooltipValue = "";

            // str_DLNum
            str_DLNum.HrefValue = "";
            str_DLNum.TooltipValue = "";

            // str_DLExp
            str_DLExp.HrefValue = "";
            str_DLExp.TooltipValue = "";

            // bit_appointmentColor
            bit_appointmentColor.HrefValue = "";
            bit_appointmentColor.TooltipValue = "";

            // str_appointmentColorCode
            str_appointmentColorCode.HrefValue = "";
            str_appointmentColorCode.TooltipValue = "";

            // bit_IsSuperAdmin
            bit_IsSuperAdmin.HrefValue = "";
            bit_IsSuperAdmin.TooltipValue = "";

            // IsDistanceBasedScheduling
            IsDistanceBasedScheduling.HrefValue = "";
            IsDistanceBasedScheduling.TooltipValue = "";

            // str_Package_Code
            str_Package_Code.HrefValue = "";
            str_Package_Code.TooltipValue = "";

            // str_NationalID_Iqama
            str_NationalID_Iqama.HrefValue = "";
            str_NationalID_Iqama.TooltipValue = "";

            // NationalID
            NationalID.HrefValue = "";
            NationalID.TooltipValue = "";

            // int_RoadDistanceCoverage
            int_RoadDistanceCoverage.HrefValue = "";
            int_RoadDistanceCoverage.TooltipValue = "";

            // str_Badge
            str_Badge.HrefValue = "";
            str_Badge.TooltipValue = "";

            // strZoomHostUrl
            strZoomHostUrl.HrefValue = "";
            strZoomHostUrl.TooltipValue = "";

            // strZoomUserUrl
            strZoomUserUrl.HrefValue = "";
            strZoomUserUrl.TooltipValue = "";

            // Signature
            if (!IsNull(Signature.Upload.DbValue)) {
                Signature.HrefValue = AppPath(GetFileUploadUrl(Signature, ConvertToString(RawUrlEncode(int_Student_ID.CurrentValue)))); // DN
                Signature.LinkAttrs["target"] = "";
                if (Signature.IsBlobImage && Empty(Signature.LinkAttrs["target"]))
                    Signature.LinkAttrs["target"] = "_blank";
                if (IsExport())
                    Signature.HrefValue = FullUrl(ConvertToString(Signature.HrefValue), "href");
            } else {
                Signature.HrefValue = "";
            }
            Signature.ExportHrefValue = GetFileUploadUrl(Signature, ConvertToString(RawUrlEncode(int_Student_ID.CurrentValue)));
            Signature.TooltipValue = "";

            // str_VehicleType
            str_VehicleType.HrefValue = "";
            str_VehicleType.TooltipValue = "";

            // ProfilePicturePath
            ProfilePicturePath.HrefValue = "";
            ProfilePicturePath.TooltipValue = "";

            // Institution
            Institution.HrefValue = "";
            Institution.TooltipValue = "";

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

            // Fingerprint
            Fingerprint.HrefValue = "";
            Fingerprint.ExportHrefValue = Fingerprint.UploadPath + Fingerprint.Upload.DbValue;
            Fingerprint.TooltipValue = "";

            // ProfileField
            ProfileField.HrefValue = "";
            ProfileField.TooltipValue = "";

            // UserlevelID
            UserlevelID.HrefValue = "";
            UserlevelID.TooltipValue = "";

            // Parent_Username
            Parent_Username.HrefValue = "";
            Parent_Username.TooltipValue = "";

            // Activated
            Activated.HrefValue = "";
            Activated.TooltipValue = "";

            // int_Nationality
            int_Nationality.HrefValue = "";
            int_Nationality.TooltipValue = "";

            // User_Role
            User_Role.HrefValue = "";
            User_Role.TooltipValue = "";

            // int_Staff_Id
            int_Staff_Id.HrefValue = "";
            int_Staff_Id.TooltipValue = "";

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

            // int_Student_ID
            int_Student_ID.SetupEditAttributes();
            int_Student_ID.EditValue = int_Student_ID.CurrentValue;
            int_Student_ID.ViewCustomAttributes = "";

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

            // str_Full_Name
            str_Full_Name.SetupEditAttributes();
            if (!str_Full_Name.Raw)
                str_Full_Name.CurrentValue = HtmlDecode(str_Full_Name.CurrentValue);
            str_Full_Name.EditValue = HtmlEncode(str_Full_Name.CurrentValue);
            str_Full_Name.PlaceHolder = RemoveHtml(str_Full_Name.Caption);

            // str_Address
            str_Address.SetupEditAttributes();
            if (!str_Address.Raw)
                str_Address.CurrentValue = HtmlDecode(str_Address.CurrentValue);
            str_Address.EditValue = HtmlEncode(str_Address.CurrentValue);
            str_Address.PlaceHolder = RemoveHtml(str_Address.Caption);

            // str_City
            str_City.SetupEditAttributes();
            str_City.PlaceHolder = RemoveHtml(str_City.Caption);

            // int_State
            int_State.SetupEditAttributes();
            int_State.PlaceHolder = RemoveHtml(int_State.Caption);
            if (!Empty(int_State.EditValue) && IsNumeric(int_State.EditValue))
                int_State.EditValue = FormatNumber(int_State.EditValue, null);

            // str_Zip
            str_Zip.SetupEditAttributes();
            if (!str_Zip.Raw)
                str_Zip.CurrentValue = HtmlDecode(str_Zip.CurrentValue);
            str_Zip.EditValue = HtmlEncode(str_Zip.CurrentValue);
            str_Zip.PlaceHolder = RemoveHtml(str_Zip.Caption);

            // date_Hired
            date_Hired.SetupEditAttributes();
            date_Hired.EditValue = date_Hired.CurrentValue;
            date_Hired.EditValue = FormatDateTime(date_Hired.EditValue, date_Hired.FormatPattern);
            date_Hired.ViewCustomAttributes = "";

            // date_Left
            date_Left.SetupEditAttributes();
            date_Left.EditValue = FormatDateTime(date_Left.CurrentValue, date_Left.FormatPattern); // DN
            date_Left.PlaceHolder = RemoveHtml(date_Left.Caption);

            // str_CertNumber
            str_CertNumber.SetupEditAttributes();
            if (!str_CertNumber.Raw)
                str_CertNumber.CurrentValue = HtmlDecode(str_CertNumber.CurrentValue);
            str_CertNumber.EditValue = HtmlEncode(str_CertNumber.CurrentValue);
            str_CertNumber.PlaceHolder = RemoveHtml(str_CertNumber.Caption);

            // date_CertExp
            date_CertExp.SetupEditAttributes();
            if (!date_CertExp.Raw)
                date_CertExp.CurrentValue = HtmlDecode(date_CertExp.CurrentValue);
            date_CertExp.EditValue = HtmlEncode(date_CertExp.CurrentValue);
            date_CertExp.PlaceHolder = RemoveHtml(date_CertExp.Caption);

            // str_Cell_Phone
            str_Cell_Phone.SetupEditAttributes();
            if (!str_Cell_Phone.Raw)
                str_Cell_Phone.CurrentValue = HtmlDecode(str_Cell_Phone.CurrentValue);
            str_Cell_Phone.EditValue = HtmlEncode(str_Cell_Phone.CurrentValue);
            str_Cell_Phone.PlaceHolder = RemoveHtml(str_Cell_Phone.Caption);

            // str_Home_Phone
            str_Home_Phone.SetupEditAttributes();
            if (!str_Home_Phone.Raw)
                str_Home_Phone.CurrentValue = HtmlDecode(str_Home_Phone.CurrentValue);
            str_Home_Phone.EditValue = HtmlEncode(str_Home_Phone.CurrentValue);
            str_Home_Phone.PlaceHolder = RemoveHtml(str_Home_Phone.Caption);

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

            // str_Code
            str_Code.SetupEditAttributes();
            if (!str_Code.Raw)
                str_Code.CurrentValue = HtmlDecode(str_Code.CurrentValue);
            str_Code.EditValue = HtmlEncode(str_Code.CurrentValue);
            str_Code.PlaceHolder = RemoveHtml(str_Code.Caption);

            // str_Username
            str_Username.SetupEditAttributes();
            if (!Security.IsAdmin && Security.IsLoggedIn && !UserIDAllow("info")) { // Non system admin
                str_Username.CurrentValue = Empty(str_Username.CurrentValue) ? CurrentUserID() : str_Username.CurrentValue;
            } else {
                if (!str_Username.Raw)
                    str_Username.CurrentValue = HtmlDecode(str_Username.CurrentValue);
                str_Username.EditValue = HtmlEncode(str_Username.CurrentValue);
                str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);
            }

            // str_Password
            str_Password.SetupEditAttributes();
            str_Password.EditValue = Language.Phrase("PasswordMask"); // Show as masked password
            str_Password.PlaceHolder = RemoveHtml(str_Password.Caption);

            // date_Birth_Hijri
            date_Birth_Hijri.SetupEditAttributes();
            if (!date_Birth_Hijri.Raw)
                date_Birth_Hijri.CurrentValue = HtmlDecode(date_Birth_Hijri.CurrentValue);
            date_Birth_Hijri.EditValue = HtmlEncode(date_Birth_Hijri.CurrentValue);
            date_Birth_Hijri.PlaceHolder = RemoveHtml(date_Birth_Hijri.Caption);

            // date_Birth
            date_Birth.SetupEditAttributes();
            date_Birth.EditValue = FormatDateTime(date_Birth.CurrentValue, date_Birth.FormatPattern); // DN
            date_Birth.PlaceHolder = RemoveHtml(date_Birth.Caption);

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

            // date_Started
            date_Started.SetupEditAttributes();
            date_Started.EditValue = ConvertToString(date_Started.CurrentValue); // DN
            date_Started.ViewCustomAttributes = "";

            // str_DateHired
            str_DateHired.SetupEditAttributes();
            str_DateHired.EditValue = ConvertToString(str_DateHired.CurrentValue); // DN
            str_DateHired.ViewCustomAttributes = "";

            // str_DateLeft
            str_DateLeft.SetupEditAttributes();
            str_DateLeft.EditValue = ConvertToString(str_DateLeft.CurrentValue); // DN
            str_DateLeft.ViewCustomAttributes = "";

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

            // str_Notes
            str_Notes.SetupEditAttributes();
            str_Notes.EditValue = str_Notes.CurrentValue; // DN
            str_Notes.PlaceHolder = RemoveHtml(str_Notes.Caption);

            // int_ClassType
            int_ClassType.SetupEditAttributes();
            int_ClassType.EditValue = int_ClassType.CurrentValue; // DN
            int_ClassType.PlaceHolder = RemoveHtml(int_ClassType.Caption);
            if (!Empty(int_ClassType.EditValue) && IsNumeric(int_ClassType.EditValue))
                int_ClassType.EditValue = FormatNumber(int_ClassType.EditValue, null);

            // str_ZipCodes
            str_ZipCodes.SetupEditAttributes();
            str_ZipCodes.EditValue = str_ZipCodes.CurrentValue; // DN
            str_ZipCodes.PlaceHolder = RemoveHtml(str_ZipCodes.Caption);

            // int_VehicleAssigned
            int_VehicleAssigned.SetupEditAttributes();
            int_VehicleAssigned.EditValue = int_VehicleAssigned.CurrentValue; // DN
            int_VehicleAssigned.PlaceHolder = RemoveHtml(int_VehicleAssigned.Caption);
            if (!Empty(int_VehicleAssigned.EditValue) && IsNumeric(int_VehicleAssigned.EditValue))
                int_VehicleAssigned.EditValue = FormatNumber(int_VehicleAssigned.EditValue, null);

            // int_Status
            int_Status.SetupEditAttributes();
            int_Status.EditValue = int_Status.CurrentValue; // DN
            int_Status.PlaceHolder = RemoveHtml(int_Status.Caption);
            if (!Empty(int_Status.EditValue) && IsNumeric(int_Status.EditValue))
                int_Status.EditValue = FormatNumber(int_Status.EditValue, null);

            // int_Type
            int_Type.SetupEditAttributes();
            int_Type.EditValue = int_Type.CurrentValue; // DN
            int_Type.PlaceHolder = RemoveHtml(int_Type.Caption);
            if (!Empty(int_Type.EditValue) && IsNumeric(int_Type.EditValue))
                int_Type.EditValue = FormatNumber(int_Type.EditValue, null);

            // int_Location
            int_Location.SetupEditAttributes();
            int_Location.EditValue = int_Location.CurrentValue; // DN
            int_Location.PlaceHolder = RemoveHtml(int_Location.Caption);
            if (!Empty(int_Location.EditValue) && IsNumeric(int_Location.EditValue))
                int_Location.EditValue = FormatNumber(int_Location.EditValue, null);

            // date_Created

            // date_Modified

            // int_Created_By

            // int_Modified_By
            int_Modified_By.SetupEditAttributes();
            int_Modified_By.EditValue = int_Modified_By.CurrentValue; // DN
            int_Modified_By.PlaceHolder = RemoveHtml(int_Modified_By.Caption);
            if (!Empty(int_Modified_By.EditValue) && IsNumeric(int_Modified_By.EditValue))
                int_Modified_By.EditValue = FormatNumber(int_Modified_By.EditValue, null);

            // bit_IsDeleted
            bit_IsDeleted.EditValue = bit_IsDeleted.Options(false);
            bit_IsDeleted.PlaceHolder = RemoveHtml(bit_IsDeleted.Caption);

            // str_InstPermitNo
            str_InstPermitNo.SetupEditAttributes();
            if (!str_InstPermitNo.Raw)
                str_InstPermitNo.CurrentValue = HtmlDecode(str_InstPermitNo.CurrentValue);
            str_InstPermitNo.EditValue = HtmlEncode(str_InstPermitNo.CurrentValue);
            str_InstPermitNo.PlaceHolder = RemoveHtml(str_InstPermitNo.Caption);

            // date_PermitExpiration
            date_PermitExpiration.SetupEditAttributes();
            if (!date_PermitExpiration.Raw)
                date_PermitExpiration.CurrentValue = HtmlDecode(date_PermitExpiration.CurrentValue);
            date_PermitExpiration.EditValue = HtmlEncode(date_PermitExpiration.CurrentValue);
            date_PermitExpiration.PlaceHolder = RemoveHtml(date_PermitExpiration.Caption);

            // date_InCarPermitIssue
            date_InCarPermitIssue.SetupEditAttributes();
            if (!date_InCarPermitIssue.Raw)
                date_InCarPermitIssue.CurrentValue = HtmlDecode(date_InCarPermitIssue.CurrentValue);
            date_InCarPermitIssue.EditValue = HtmlEncode(date_InCarPermitIssue.CurrentValue);
            date_InCarPermitIssue.PlaceHolder = RemoveHtml(date_InCarPermitIssue.Caption);

            // str_InClassPermitNo
            str_InClassPermitNo.SetupEditAttributes();
            if (!str_InClassPermitNo.Raw)
                str_InClassPermitNo.CurrentValue = HtmlDecode(str_InClassPermitNo.CurrentValue);
            str_InClassPermitNo.EditValue = HtmlEncode(str_InClassPermitNo.CurrentValue);
            str_InClassPermitNo.PlaceHolder = RemoveHtml(str_InClassPermitNo.Caption);

            // date_InClassPermitIssue
            date_InClassPermitIssue.SetupEditAttributes();
            if (!date_InClassPermitIssue.Raw)
                date_InClassPermitIssue.CurrentValue = HtmlDecode(date_InClassPermitIssue.CurrentValue);
            date_InClassPermitIssue.EditValue = HtmlEncode(date_InClassPermitIssue.CurrentValue);
            date_InClassPermitIssue.PlaceHolder = RemoveHtml(date_InClassPermitIssue.Caption);

            // instructor_caption
            instructor_caption.SetupEditAttributes();
            if (!instructor_caption.Raw)
                instructor_caption.CurrentValue = HtmlDecode(instructor_caption.CurrentValue);
            instructor_caption.EditValue = HtmlEncode(instructor_caption.CurrentValue);
            instructor_caption.PlaceHolder = RemoveHtml(instructor_caption.Caption);

            // str_LicType
            str_LicType.SetupEditAttributes();
            if (!str_LicType.Raw)
                str_LicType.CurrentValue = HtmlDecode(str_LicType.CurrentValue);
            str_LicType.EditValue = HtmlEncode(str_LicType.CurrentValue);
            str_LicType.PlaceHolder = RemoveHtml(str_LicType.Caption);

            // int_Order
            int_Order.SetupEditAttributes();
            int_Order.EditValue = int_Order.CurrentValue; // DN
            int_Order.PlaceHolder = RemoveHtml(int_Order.Caption);
            if (!Empty(int_Order.EditValue) && IsNumeric(int_Order.EditValue))
                int_Order.EditValue = FormatNumber(int_Order.EditValue, null);

            // str_InstLicenceDate
            str_InstLicenceDate.SetupEditAttributes();
            if (!str_InstLicenceDate.Raw)
                str_InstLicenceDate.CurrentValue = HtmlDecode(str_InstLicenceDate.CurrentValue);
            str_InstLicenceDate.EditValue = HtmlEncode(str_InstLicenceDate.CurrentValue);
            str_InstLicenceDate.PlaceHolder = RemoveHtml(str_InstLicenceDate.Caption);

            // str_DLNum
            str_DLNum.SetupEditAttributes();
            if (!str_DLNum.Raw)
                str_DLNum.CurrentValue = HtmlDecode(str_DLNum.CurrentValue);
            str_DLNum.EditValue = HtmlEncode(str_DLNum.CurrentValue);
            str_DLNum.PlaceHolder = RemoveHtml(str_DLNum.Caption);

            // str_DLExp
            str_DLExp.SetupEditAttributes();
            if (!str_DLExp.Raw)
                str_DLExp.CurrentValue = HtmlDecode(str_DLExp.CurrentValue);
            str_DLExp.EditValue = HtmlEncode(str_DLExp.CurrentValue);
            str_DLExp.PlaceHolder = RemoveHtml(str_DLExp.Caption);

            // bit_appointmentColor
            bit_appointmentColor.EditValue = bit_appointmentColor.Options(false);
            bit_appointmentColor.PlaceHolder = RemoveHtml(bit_appointmentColor.Caption);

            // str_appointmentColorCode
            str_appointmentColorCode.SetupEditAttributes();
            if (!str_appointmentColorCode.Raw)
                str_appointmentColorCode.CurrentValue = HtmlDecode(str_appointmentColorCode.CurrentValue);
            str_appointmentColorCode.EditValue = HtmlEncode(str_appointmentColorCode.CurrentValue);
            str_appointmentColorCode.PlaceHolder = RemoveHtml(str_appointmentColorCode.Caption);

            // bit_IsSuperAdmin
            bit_IsSuperAdmin.EditValue = bit_IsSuperAdmin.Options(false);
            bit_IsSuperAdmin.PlaceHolder = RemoveHtml(bit_IsSuperAdmin.Caption);

            // IsDistanceBasedScheduling
            IsDistanceBasedScheduling.SetupEditAttributes();
            IsDistanceBasedScheduling.EditValue = IsDistanceBasedScheduling.CurrentValue; // DN
            IsDistanceBasedScheduling.PlaceHolder = RemoveHtml(IsDistanceBasedScheduling.Caption);
            if (!Empty(IsDistanceBasedScheduling.EditValue) && IsNumeric(IsDistanceBasedScheduling.EditValue))
                IsDistanceBasedScheduling.EditValue = FormatNumber(IsDistanceBasedScheduling.EditValue, null);

            // str_Package_Code
            str_Package_Code.SetupEditAttributes();
            if (!str_Package_Code.Raw)
                str_Package_Code.CurrentValue = HtmlDecode(str_Package_Code.CurrentValue);
            str_Package_Code.EditValue = HtmlEncode(str_Package_Code.CurrentValue);
            str_Package_Code.PlaceHolder = RemoveHtml(str_Package_Code.Caption);

            // str_NationalID_Iqama
            str_NationalID_Iqama.SetupEditAttributes();
            if (!str_NationalID_Iqama.Raw)
                str_NationalID_Iqama.CurrentValue = HtmlDecode(str_NationalID_Iqama.CurrentValue);
            str_NationalID_Iqama.EditValue = HtmlEncode(str_NationalID_Iqama.CurrentValue);
            str_NationalID_Iqama.PlaceHolder = RemoveHtml(str_NationalID_Iqama.Caption);

            // NationalID
            NationalID.SetupEditAttributes();
            NationalID.EditValue = NationalID.CurrentValue; // DN
            NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);
            if (!Empty(NationalID.EditValue) && IsNumeric(NationalID.EditValue))
                NationalID.EditValue = FormatNumber(NationalID.EditValue, null);

            // int_RoadDistanceCoverage
            int_RoadDistanceCoverage.SetupEditAttributes();
            int_RoadDistanceCoverage.EditValue = int_RoadDistanceCoverage.CurrentValue; // DN
            int_RoadDistanceCoverage.PlaceHolder = RemoveHtml(int_RoadDistanceCoverage.Caption);
            if (!Empty(int_RoadDistanceCoverage.EditValue) && IsNumeric(int_RoadDistanceCoverage.EditValue))
                int_RoadDistanceCoverage.EditValue = FormatNumber(int_RoadDistanceCoverage.EditValue, null);

            // str_Badge
            str_Badge.SetupEditAttributes();
            if (!str_Badge.Raw)
                str_Badge.CurrentValue = HtmlDecode(str_Badge.CurrentValue);
            str_Badge.EditValue = HtmlEncode(str_Badge.CurrentValue);
            str_Badge.PlaceHolder = RemoveHtml(str_Badge.Caption);

            // strZoomHostUrl
            strZoomHostUrl.SetupEditAttributes();
            strZoomHostUrl.EditValue = strZoomHostUrl.CurrentValue; // DN
            strZoomHostUrl.PlaceHolder = RemoveHtml(strZoomHostUrl.Caption);

            // strZoomUserUrl
            strZoomUserUrl.SetupEditAttributes();
            strZoomUserUrl.EditValue = strZoomUserUrl.CurrentValue; // DN
            strZoomUserUrl.PlaceHolder = RemoveHtml(strZoomUserUrl.Caption);

            // Signature
            Signature.SetupEditAttributes();
            if (!IsNull(Signature.Upload.DbValue)) {
                Signature.EditValue = RawUrlEncode(int_Student_ID.CurrentValue);
                Signature.IsBlobImage = IsImageFile(ContentExtension((byte[])Signature.Upload.DbValue));
            } else {
                Signature.EditValue = "";
            }

            // str_VehicleType
            str_VehicleType.SetupEditAttributes();
            if (!str_VehicleType.Raw)
                str_VehicleType.CurrentValue = HtmlDecode(str_VehicleType.CurrentValue);
            str_VehicleType.EditValue = HtmlEncode(str_VehicleType.CurrentValue);
            str_VehicleType.PlaceHolder = RemoveHtml(str_VehicleType.Caption);

            // ProfilePicturePath
            ProfilePicturePath.SetupEditAttributes();
            if (!ProfilePicturePath.Raw)
                ProfilePicturePath.CurrentValue = HtmlDecode(ProfilePicturePath.CurrentValue);
            ProfilePicturePath.EditValue = HtmlEncode(ProfilePicturePath.CurrentValue);
            ProfilePicturePath.PlaceHolder = RemoveHtml(ProfilePicturePath.Caption);

            // Institution
            Institution.SetupEditAttributes();
            if (!Institution.Raw)
                Institution.CurrentValue = HtmlDecode(Institution.CurrentValue);
            Institution.EditValue = HtmlEncode(Institution.CurrentValue);
            Institution.PlaceHolder = RemoveHtml(Institution.Caption);

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

            // Fingerprint
            Fingerprint.SetupEditAttributes();
            if (!IsNull(Fingerprint.Upload.DbValue)) {
                Fingerprint.EditValue = Fingerprint.Upload.DbValue;
            } else {
                Fingerprint.EditValue = "";
            }
            if (!Empty(Fingerprint.CurrentValue))
                    Fingerprint.Upload.FileName = ConvertToString(Fingerprint.CurrentValue);

            // ProfileField
            ProfileField.SetupEditAttributes();
            ProfileField.EditValue = ProfileField.CurrentValue; // DN
            ProfileField.PlaceHolder = RemoveHtml(ProfileField.Caption);

            // UserlevelID
            UserlevelID.SetupEditAttributes();
            if (Security.CanAdmin) { // System admin
                curVal = ConvertToString(UserlevelID.CurrentValue);
                if (!Empty(curVal)) {
                    if (UserlevelID.Lookup != null && IsDictionary(UserlevelID.Lookup?.Options) && UserlevelID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        UserlevelID.EditValue = UserlevelID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[UserLevelID]", "=", UserlevelID.CurrentValue, DataType.Number, "");
                        sqlWrk = UserlevelID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && UserlevelID.Lookup != null) { // Lookup values found
                            var listwrk = UserlevelID.Lookup?.RenderViewRow(rswrk[0]);
                            UserlevelID.EditValue = UserlevelID.HighlightLookup(ConvertToString(rswrk[0]), UserlevelID.DisplayValue(listwrk));
                        } else {
                            UserlevelID.EditValue = FormatNumber(UserlevelID.CurrentValue, UserlevelID.FormatPattern);
                        }
                    }
                } else {
                    UserlevelID.EditValue = DbNullValue;
                }
            } else {
                UserlevelID.EditValue = Language.Phrase("PasswordMask");
            }
            UserlevelID.ViewCustomAttributes = "";

            // Parent_Username
            Parent_Username.SetupEditAttributes();
            curVal = ConvertToString(Parent_Username.CurrentValue);
            if (!Empty(curVal)) {
                if (Parent_Username.Lookup != null && IsDictionary(Parent_Username.Lookup?.Options) && Parent_Username.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    Parent_Username.EditValue = Parent_Username.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[str_Username]", "=", Parent_Username.CurrentValue, DataType.String, "");
                    sqlWrk = Parent_Username.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && Parent_Username.Lookup != null) { // Lookup values found
                        var listwrk = Parent_Username.Lookup?.RenderViewRow(rswrk[0]);
                        Parent_Username.EditValue = Parent_Username.HighlightLookup(ConvertToString(rswrk[0]), Parent_Username.DisplayValue(listwrk));
                    } else {
                        Parent_Username.EditValue = Parent_Username.CurrentValue;
                    }
                }
            } else {
                Parent_Username.EditValue = DbNullValue;
            }
            Parent_Username.ViewCustomAttributes = "";

            // Activated
            Activated.SetupEditAttributes();
            if (ConvertToBool(Activated.CurrentValue)) {
                Activated.EditValue = Activated.TagCaption(1) != "" ? Activated.TagCaption(1) : "Yes";
            } else {
                Activated.EditValue = Activated.TagCaption(2) != "" ? Activated.TagCaption(2) : "No";
            }
            Activated.ViewCustomAttributes = "";

            // int_Nationality
            int_Nationality.SetupEditAttributes();
            int_Nationality.EditValue = int_Nationality.CurrentValue; // DN
            int_Nationality.PlaceHolder = RemoveHtml(int_Nationality.Caption);
            if (!Empty(int_Nationality.EditValue) && IsNumeric(int_Nationality.EditValue))
                int_Nationality.EditValue = FormatNumber(int_Nationality.EditValue, null);

            // User_Role
            User_Role.SetupEditAttributes();
            User_Role.EditValue = User_Role.Options(true);
            User_Role.PlaceHolder = RemoveHtml(User_Role.Caption);

            // int_Staff_Id
            int_Staff_Id.SetupEditAttributes();
            int_Staff_Id.EditValue = int_Staff_Id.CurrentValue; // DN
            int_Staff_Id.PlaceHolder = RemoveHtml(int_Staff_Id.Caption);
            if (!Empty(int_Staff_Id.EditValue) && IsNumeric(int_Staff_Id.EditValue))
                int_Staff_Id.EditValue = FormatNumber(int_Staff_Id.EditValue, null);

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
            if (!doc.ExportCustom) {
                // Write header
                doc.ExportTableHeader();
                if (doc.Horizontal) { // Horizontal format, write header
                    doc.BeginExportRow();
                    if (exportType == "view") {
                        doc.ExportCaption(str_Full_Name);
                        doc.ExportCaption(str_Cell_Phone);
                        doc.ExportCaption(str_Email);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(date_Birth_Hijri);
                        doc.ExportCaption(date_Birth);
                        doc.ExportCaption(str_NationalID_Iqama);
                        doc.ExportCaption(Institution);
                        doc.ExportCaption(IsDrivingexperience);
                        doc.ExportCaption(intDrivinglicenseType);
                        doc.ExportCaption(AbsherApptNbr);
                        doc.ExportCaption(Absherphoto);
                        doc.ExportCaption(Parent_Username);
                        doc.ExportCaption(int_Nationality);
                        doc.ExportCaption(User_Role);
                        doc.ExportCaption(int_Staff_Id);
                    } else {
                        doc.ExportCaption(int_Student_ID);
                        doc.ExportCaption(str_First_Name);
                        doc.ExportCaption(str_Middle_Name);
                        doc.ExportCaption(str_Last_Name);
                        doc.ExportCaption(str_Full_Name);
                        doc.ExportCaption(str_Address);
                        doc.ExportCaption(str_City);
                        doc.ExportCaption(int_State);
                        doc.ExportCaption(str_Zip);
                        doc.ExportCaption(date_Hired);
                        doc.ExportCaption(date_Left);
                        doc.ExportCaption(str_CertNumber);
                        doc.ExportCaption(date_CertExp);
                        doc.ExportCaption(str_Cell_Phone);
                        doc.ExportCaption(str_Home_Phone);
                        doc.ExportCaption(str_Other_Phone);
                        doc.ExportCaption(str_Email);
                        doc.ExportCaption(str_Code);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(str_Password);
                        doc.ExportCaption(date_Birth_Hijri);
                        doc.ExportCaption(date_Birth);
                        doc.ExportCaption(Hijri_Year);
                        doc.ExportCaption(Hijri_Month);
                        doc.ExportCaption(Hijri_Day);
                        doc.ExportCaption(date_Started);
                        doc.ExportCaption(str_DateHired);
                        doc.ExportCaption(str_DateLeft);
                        doc.ExportCaption(str_Emergency_Contact_Name);
                        doc.ExportCaption(str_Emergency_Contact_Phone);
                        doc.ExportCaption(str_Emergency_Contact_Relation);
                        doc.ExportCaption(str_Notes);
                        doc.ExportCaption(int_ClassType);
                        doc.ExportCaption(int_VehicleAssigned);
                        doc.ExportCaption(int_Status);
                        doc.ExportCaption(int_Type);
                        doc.ExportCaption(int_Location);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(int_Created_By);
                        doc.ExportCaption(int_Modified_By);
                        doc.ExportCaption(bit_IsDeleted);
                        doc.ExportCaption(str_InstPermitNo);
                        doc.ExportCaption(date_PermitExpiration);
                        doc.ExportCaption(date_InCarPermitIssue);
                        doc.ExportCaption(str_InClassPermitNo);
                        doc.ExportCaption(date_InClassPermitIssue);
                        doc.ExportCaption(instructor_caption);
                        doc.ExportCaption(str_LicType);
                        doc.ExportCaption(int_Order);
                        doc.ExportCaption(str_InstLicenceDate);
                        doc.ExportCaption(str_DLNum);
                        doc.ExportCaption(str_DLExp);
                        doc.ExportCaption(bit_appointmentColor);
                        doc.ExportCaption(str_appointmentColorCode);
                        doc.ExportCaption(bit_IsSuperAdmin);
                        doc.ExportCaption(IsDistanceBasedScheduling);
                        doc.ExportCaption(str_Package_Code);
                        doc.ExportCaption(str_NationalID_Iqama);
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(int_RoadDistanceCoverage);
                        doc.ExportCaption(str_Badge);
                        doc.ExportCaption(str_VehicleType);
                        doc.ExportCaption(ProfilePicturePath);
                        doc.ExportCaption(Institution);
                        doc.ExportCaption(IsDrivingexperience);
                        doc.ExportCaption(intDrivinglicenseType);
                        doc.ExportCaption(AbsherApptNbr);
                        doc.ExportCaption(Absherphoto);
                        doc.ExportCaption(Fingerprint);
                        doc.ExportCaption(UserlevelID);
                        doc.ExportCaption(Parent_Username);
                        doc.ExportCaption(Activated);
                        doc.ExportCaption(int_Nationality);
                        doc.ExportCaption(User_Role);
                        doc.ExportCaption(int_Staff_Id);
                    }
                    doc.EndExportRow();
                }
            }
            int recCnt = startRec - 1;
            // Read first record for View Page // DN
            if (exportType == "view") {
                await dataReader.ReadAsync();
            // Move to and read first record for list page // DN
            } else {
                if (Connection.SelectOffset) {
                    await dataReader.ReadAsync();
                } else {
                    for (int i = 0; i < startRec; i++) // Move to the start record and use do-while loop
                        await dataReader.ReadAsync();
                }
            }
            int rowcnt = 0; // DN
            do { // DN
                recCnt++;
                if (recCnt >= startRec) {
                    rowcnt = recCnt - startRec + 1;

                    // Page break
                    if (ExportPageBreakCount > 0) {
                        if (rowcnt > 1 && (rowcnt - 1) % ExportPageBreakCount == 0)
                            doc.ExportPageBreak();
                    }
                    LoadListRowValues(dataReader);

                    // Render row
                    RowType = RowType.View; // Render view
                    ResetAttributes();
                    await RenderListRow();
                    if (!doc.ExportCustom) {
                        doc.BeginExportRow(rowcnt); // Allow CSS styles if enabled
                        if (exportType == "view") {
                            await doc.ExportField(str_Full_Name);
                            await doc.ExportField(str_Cell_Phone);
                            await doc.ExportField(str_Email);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(date_Birth_Hijri);
                            await doc.ExportField(date_Birth);
                            await doc.ExportField(str_NationalID_Iqama);
                            await doc.ExportField(Institution);
                            await doc.ExportField(IsDrivingexperience);
                            await doc.ExportField(intDrivinglicenseType);
                            await doc.ExportField(AbsherApptNbr);
                            await doc.ExportField(Absherphoto);
                            await doc.ExportField(Parent_Username);
                            await doc.ExportField(int_Nationality);
                            await doc.ExportField(User_Role);
                            await doc.ExportField(int_Staff_Id);
                        } else {
                            await doc.ExportField(int_Student_ID);
                            await doc.ExportField(str_First_Name);
                            await doc.ExportField(str_Middle_Name);
                            await doc.ExportField(str_Last_Name);
                            await doc.ExportField(str_Full_Name);
                            await doc.ExportField(str_Address);
                            await doc.ExportField(str_City);
                            await doc.ExportField(int_State);
                            await doc.ExportField(str_Zip);
                            await doc.ExportField(date_Hired);
                            await doc.ExportField(date_Left);
                            await doc.ExportField(str_CertNumber);
                            await doc.ExportField(date_CertExp);
                            await doc.ExportField(str_Cell_Phone);
                            await doc.ExportField(str_Home_Phone);
                            await doc.ExportField(str_Other_Phone);
                            await doc.ExportField(str_Email);
                            await doc.ExportField(str_Code);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(str_Password);
                            await doc.ExportField(date_Birth_Hijri);
                            await doc.ExportField(date_Birth);
                            await doc.ExportField(Hijri_Year);
                            await doc.ExportField(Hijri_Month);
                            await doc.ExportField(Hijri_Day);
                            await doc.ExportField(date_Started);
                            await doc.ExportField(str_DateHired);
                            await doc.ExportField(str_DateLeft);
                            await doc.ExportField(str_Emergency_Contact_Name);
                            await doc.ExportField(str_Emergency_Contact_Phone);
                            await doc.ExportField(str_Emergency_Contact_Relation);
                            await doc.ExportField(str_Notes);
                            await doc.ExportField(int_ClassType);
                            await doc.ExportField(int_VehicleAssigned);
                            await doc.ExportField(int_Status);
                            await doc.ExportField(int_Type);
                            await doc.ExportField(int_Location);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(int_Created_By);
                            await doc.ExportField(int_Modified_By);
                            await doc.ExportField(bit_IsDeleted);
                            await doc.ExportField(str_InstPermitNo);
                            await doc.ExportField(date_PermitExpiration);
                            await doc.ExportField(date_InCarPermitIssue);
                            await doc.ExportField(str_InClassPermitNo);
                            await doc.ExportField(date_InClassPermitIssue);
                            await doc.ExportField(instructor_caption);
                            await doc.ExportField(str_LicType);
                            await doc.ExportField(int_Order);
                            await doc.ExportField(str_InstLicenceDate);
                            await doc.ExportField(str_DLNum);
                            await doc.ExportField(str_DLExp);
                            await doc.ExportField(bit_appointmentColor);
                            await doc.ExportField(str_appointmentColorCode);
                            await doc.ExportField(bit_IsSuperAdmin);
                            await doc.ExportField(IsDistanceBasedScheduling);
                            await doc.ExportField(str_Package_Code);
                            await doc.ExportField(str_NationalID_Iqama);
                            await doc.ExportField(NationalID);
                            await doc.ExportField(int_RoadDistanceCoverage);
                            await doc.ExportField(str_Badge);
                            await doc.ExportField(str_VehicleType);
                            await doc.ExportField(ProfilePicturePath);
                            await doc.ExportField(Institution);
                            await doc.ExportField(IsDrivingexperience);
                            await doc.ExportField(intDrivinglicenseType);
                            await doc.ExportField(AbsherApptNbr);
                            await doc.ExportField(Absherphoto);
                            await doc.ExportField(Fingerprint);
                            await doc.ExportField(UserlevelID);
                            await doc.ExportField(Parent_Username);
                            await doc.ExportField(Activated);
                            await doc.ExportField(int_Nationality);
                            await doc.ExportField(User_Role);
                            await doc.ExportField(int_Staff_Id);
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

        // User ID filter
        public string GetUserIDFilter(object userid)
        {
            string userIdFilter = "[str_Username] = " + QuotedValue(userid, DataType.String, Config.UserTableDbId);
            string parentUserIdFilter = "[str_Username] IN (SELECT [str_Username] FROM dbo.tblStudents WHERE " + MultiValueFilter("[Parent_Username]", userid, Config.UserTableDbId) + ")";
            userIdFilter = "(" + userIdFilter + ") OR (" + parentUserIdFilter + ")";
            return userIdFilter;
        }

        // Add User ID filter
        public string AddUserIDFilter(string filter = "", string id = "")
        {
            string filterWrk = "";
            if (id == "")
                id = (CurrentPageID() == "list") ? CurrentAction : CurrentPageID();
            if (!UserIDAllow(id) && !Security.IsAdmin) {
                filterWrk = Security.UserIDList();
                if (!Empty(filterWrk))
                    filterWrk = "[str_Username] IN (" + filterWrk + ")";
            }

            // Call User ID Filtering event
            UserIdFiltering(ref filterWrk);
            AddFilter(ref filter, filterWrk);
            return filter;
        }

        // Add Parent User ID filter
        public string AddParentUserIDFilter(object? userid)
        {
            if (!Security.IsAdmin) {
                string filterWrk = Security.ParentUserIDList(userid);
                if (!Empty(filterWrk))
                    filterWrk = "[str_Username] IN (" + filterWrk + ")";
                return filterWrk;
            }
            return "";
        }

        // User ID subquery
        public string GetUserIDSubquery(DbField fld, DbField masterfld)
        {
            string wrk = "";
            string sql = "SELECT " + masterfld.Expression + " FROM dbo.tblStudents";
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

        // Send register email
        public async Task<bool> SendRegisterEmail(Dictionary<string, object> row)
        {
            // Get user language
            string userName = ConvertToString(GetUserInfo(Config.LoginUsernameFieldName, row));
            string langId = await Profile.GetLanguageId(userName);
            Email email = await PrepareRegisterEmail(row, langId);
            bool emailSent = false;
            if (EmailSending(email, ConvertToDictionary<dynamic>(new { rs = row }))) // NOTE: Use Email Sending server event of user table
                emailSent = await email.SendAsync();
            return emailSent;
        }

        // Get activate link
        public string ActivateLink(string username, string password, string email)
        {
            return FullUrl("register", "activate") + "?action=confirm&user=" + RawUrlEncode(username) + "&activatetoken=" + Encrypt(email) + "," + Encrypt(username) + "," + Encrypt(password);
        }

        // Prepare register email
        public async Task<Email> PrepareRegisterEmail(Dictionary<string, object>? row = null, string langId = "")
        {
            var email = new Email();
            await email.Load(Config.EmailRegisterTemplate, langId);
            email.ReplaceSender(Config.SenderEmail); // Replace Sender
            string emailAddress = ConvertToString(GetUserInfo(Config.UserEmailFieldName, row) ?? str_Email.CurrentValue);
            emailAddress = Empty(emailAddress) ? Config.RecipientEmail : emailAddress;
            email.ReplaceRecipient(emailAddress); // Replace Recipient
            if (!SameText(emailAddress, Config.RecipientEmail)) // Add Bcc
                email.AddBcc(Config.RecipientEmail);
            email.ReplaceContent("<!--FieldCaption_str_First_Name-->", str_First_Name.Caption);
            email.ReplaceContent("<!--str_First_Name-->", ConvertToString(GetUserInfo("str_First_Name", row) ?? str_First_Name.FormValue));
            email.ReplaceContent("<!--FieldCaption_str_Middle_Name-->", str_Middle_Name.Caption);
            email.ReplaceContent("<!--str_Middle_Name-->", ConvertToString(GetUserInfo("str_Middle_Name", row) ?? str_Middle_Name.FormValue));
            email.ReplaceContent("<!--FieldCaption_str_Last_Name-->", str_Last_Name.Caption);
            email.ReplaceContent("<!--str_Last_Name-->", ConvertToString(GetUserInfo("str_Last_Name", row) ?? str_Last_Name.FormValue));
            email.ReplaceContent("<!--FieldCaption_str_Cell_Phone-->", str_Cell_Phone.Caption);
            email.ReplaceContent("<!--str_Cell_Phone-->", ConvertToString(GetUserInfo("str_Cell_Phone", row) ?? str_Cell_Phone.FormValue));
            email.ReplaceContent("<!--FieldCaption_str_Email-->", str_Email.Caption);
            email.ReplaceContent("<!--str_Email-->", ConvertToString(GetUserInfo("str_Email", row) ?? str_Email.FormValue));
            email.ReplaceContent("<!--FieldCaption_str_Password-->", str_Password.Caption);
            email.ReplaceContent("<!--str_Password-->", ConvertToString(GetUserInfo("str_Password", row) ?? str_Password.FormValue));
            email.ReplaceContent("<!--FieldCaption_Hijri_Year-->", Hijri_Year.Caption);
            email.ReplaceContent("<!--Hijri_Year-->", ConvertToString(GetUserInfo("Hijri_Year", row) ?? Hijri_Year.FormValue));
            email.ReplaceContent("<!--FieldCaption_Hijri_Month-->", Hijri_Month.Caption);
            email.ReplaceContent("<!--Hijri_Month-->", ConvertToString(GetUserInfo("Hijri_Month", row) ?? Hijri_Month.FormValue));
            email.ReplaceContent("<!--FieldCaption_Hijri_Day-->", Hijri_Day.Caption);
            email.ReplaceContent("<!--Hijri_Day-->", ConvertToString(GetUserInfo("Hijri_Day", row) ?? Hijri_Day.FormValue));
            email.ReplaceContent("<!--FieldCaption_str_Emergency_Contact_Name-->", str_Emergency_Contact_Name.Caption);
            email.ReplaceContent("<!--str_Emergency_Contact_Name-->", ConvertToString(GetUserInfo("str_Emergency_Contact_Name", row) ?? str_Emergency_Contact_Name.FormValue));
            email.ReplaceContent("<!--FieldCaption_str_Emergency_Contact_Phone-->", str_Emergency_Contact_Phone.Caption);
            email.ReplaceContent("<!--str_Emergency_Contact_Phone-->", ConvertToString(GetUserInfo("str_Emergency_Contact_Phone", row) ?? str_Emergency_Contact_Phone.FormValue));
            email.ReplaceContent("<!--FieldCaption_str_Emergency_Contact_Relation-->", str_Emergency_Contact_Relation.Caption);
            email.ReplaceContent("<!--str_Emergency_Contact_Relation-->", ConvertToString(GetUserInfo("str_Emergency_Contact_Relation", row) ?? str_Emergency_Contact_Relation.FormValue));
            email.ReplaceContent("<!--FieldCaption_str_NationalID_Iqama-->", str_NationalID_Iqama.Caption);
            email.ReplaceContent("<!--str_NationalID_Iqama-->", ConvertToString(GetUserInfo("str_NationalID_Iqama", row) ?? str_NationalID_Iqama.FormValue));
            email.ReplaceContent("<!--FieldCaption_IsDrivingexperience-->", IsDrivingexperience.Caption);
            email.ReplaceContent("<!--IsDrivingexperience-->", ConvertToString(GetUserInfo("IsDrivingexperience", row) ?? IsDrivingexperience.FormValue));
            email.ReplaceContent("<!--FieldCaption_intDrivinglicenseType-->", intDrivinglicenseType.Caption);
            email.ReplaceContent("<!--intDrivinglicenseType-->", ConvertToString(GetUserInfo("intDrivinglicenseType", row) ?? intDrivinglicenseType.FormValue));
            email.ReplaceContent("<!--FieldCaption_AbsherApptNbr-->", AbsherApptNbr.Caption);
            email.ReplaceContent("<!--AbsherApptNbr-->", ConvertToString(GetUserInfo("AbsherApptNbr", row) ?? AbsherApptNbr.FormValue));
            email.ReplaceContent("<!--FieldCaption_Absherphoto-->", Absherphoto.Caption);
            email.ReplaceContent("<!--Absherphoto-->", ConvertToString(GetUserInfo("Absherphoto", row) ?? Absherphoto.FormValue));
            string username = row == null ? ConvertToString(str_Username.CurrentValue) : ConvertToString(GetUserInfo(Config.LoginUsernameFieldName, row));
            string password = row == null
                ? CurrentForm.HasValue("str_Password") ? CurrentForm.GetValue("str_Password") : CurrentForm.GetValue("x_str_Password") // Use raw password post value
                : ConvertToString(GetUserInfo(Config.LoginPasswordFieldName, row));
            email.ReplaceContent("<!--ActivateLink-->", ActivateLink(username, password, emailAddress));
            return email;
        }

        // Table filter
        private string? _tableFilter = null;

        public string TableFilter
        {
            get => _tableFilter ?? "";
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

            // Set up field names
            string fldName = "", fileNameFld = "", fileTypeFld = "";
            if (SameText(fldparm, "Signature")) {
                fldName = "Signature";
            } else if (SameText(fldparm, "Absherphoto")) {
                fldName = "Absherphoto";
                fileNameFld = "Absherphoto";
            } else if (SameText(fldparm, "Fingerprint")) {
                fldName = "Fingerprint";
                fileNameFld = "Fingerprint";
            } else {
                return JsonBoolResult.FalseResult; // Incorrect field
            }

            // Set up key values
            if (keys.Length == 1) {
                int_Student_ID.CurrentValue = keys[0];
            } else {
                return JsonBoolResult.FalseResult; // Incorrect key
            }

            // Set up filter (WHERE Clause)
            string filter = GetRecordFilter();
            CurrentFilter = filter;
            string sql = CurrentSql;
            using var rs = await Connection.GetDataReaderAsync(sql);
            if (rs != null && await rs.ReadAsync()) {
                var val = rs[fldName];
                if (!Empty(val)) {
                    if (Fields.TryGetValue(fldName, out DbField? fld) && fld != null) {
                        // Binary data
                        if (fld.IsBlob) {
                            byte[] data = (byte[])val;
                            if (resize && data.Length > 0)
                                ResizeBinary(ref data, ref width, ref height);
                            string? contentType = "";

                            // Write file type
                            if (!Empty(fileTypeFld) && !Empty(rs[fileTypeFld]))
                                contentType = ConvertToString(rs[fileTypeFld]);
                            else
                                contentType = ContentType(data);

                            // Write file data
                            if (data.Take(8).SequenceEqual(new byte[] {0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x06, 0x00}) && // Fix Office 2007 documents
                                !data.TakeLast(4).SequenceEqual(new byte[] {0x00, 0x00, 0x00, 0x00}))
                                    data.Concat(new byte[] {0x00, 0x00, 0x00, 0x00});

                            // Clear any debug message
                            // Response?.Clear();

                            // Return file content result // DN
                            string downloadFileName = !Empty(fileNameFld) && !Empty(rs[fileNameFld]) ?
                                ConvertToString(rs[fileNameFld]) :
                                DownloadFileName;
                            string ext = ContentExtension(data).Replace(".", ""); // Get file extension
                            if (ext == "pdf" && Config.EmbedPdf) // Embed Pdf // DN
                                downloadFileName = "";
                            if (!Empty(downloadFileName))
                                return Controller.File(data, contentType, downloadFileName);
                            else
                                return Controller.File(data, contentType);

                        // Upload to folder
                        } else {
                            List<string> files;
                            if (fld.UploadMultiple)
                                files = ConvertToString(val).Split(Config.MultipleUploadSeparator).ToList();
                            else
                                files = new () { ConvertToString(val) };
                            var mi = fld.GetType().GetMethod("GetUploadPath");
                            if (mi != null) // GetUploadPath
                                fld.UploadPath = ConvertToString(mi.Invoke(fld, null));
                            var result = files.ToDictionary(f => f, f => Config.EncryptFilePath
                                ? FullUrl(Config.ApiUrl + Config.ApiFileAction + "/" + TableVar + "/" + Encrypt(fld.PhysicalUploadPath + f))
                                : FullUrl(fld.HrefPath + f));
                            return new JsonBoolResult(new Dictionary<string, object> { { fld.Param, result } }, true);
                        }
                    }
                }
            }
            return JsonBoolResult.FalseResult; // Incorrect key
        }
        #pragma warning restore 1998

        // Write audit trail start/end for grid update
        public async Task WriteAuditTrailLog(string log) => await WriteAuditTrailAsync(CurrentUser(), log, "tblStudents");

        // Write audit trail (add page)
        public async Task WriteAuditTrailOnAdd(IDictionary<string, object> rs)
        {
            if (!AuditTrailOnAdd)
                return;
            string table = "tblStudents";

            // Get key value
            string key = GetKey(rs); // DN
            var usr = CurrentUser();
            foreach (string fldname in rs.Keys) {
                if (Fields.TryGetValue(fldname, out DbField? fld) && !fld.IsBlob) { // Ignore BLOB fields
                    object newvalue;
                    if (fld.HtmlTag == "PASSWORD") {
                        newvalue = Language.Phrase("PasswordMask"); // Password Field
                    } else if (fld.DataType == DataType.Memo) {
                        newvalue = Config.AuditTrailToDatabase ? rs[fldname] : "[MEMO]";
                    } else if (fld.DataType == DataType.Xml) { // XML Field
                        newvalue = "[XML]";
                    } else {
                        newvalue = rs[fldname];
                    }
                    if (fldname == Config.LoginPasswordFieldName)
                        newvalue = Language.Phrase("PasswordMask");
                    await WriteAuditTrailAsync(usr, "A", table, fldname, key, "", newvalue);
                }
            }
        }

        // Write audit trail (edit page)
        public async Task WriteAuditTrailOnEdit(IDictionary<string, object> rsold, IDictionary<string, object> rsnew)
        {
            if (!AuditTrailOnEdit)
                return;
            string table = "tblStudents";

            // Get key value
            string key = GetKey(rsold); // DN

            // Write audit trail
            var dt = DbCurrentDateTime();
            var id = ScriptName();
            var usr = CurrentUser();
            foreach (string fldname in rsnew.Keys) {
                if (Fields.TryGetValue(fldname, out DbField? fld) && !fld.IsBlob) { // Ignore BLOB fields
                    bool modified = false; object? oldvalue = null; object? newvalue = null;
                    if (fld.DataType == DataType.Date) { // DateTime field
                        modified = (FormatDateTime(rsold[fldname], 0) != FormatDateTime(rsnew[fldname], 0));
                    } else if (IsFloatType(fld.Type)) { // Float field
                        modified = ConvertToDouble(rsold[fldname]) != ConvertToDouble(rsnew[fldname]);
                    } else {
                        modified = !CompareValue(rsold[fldname], rsnew[fldname]);
                    }
                    if (modified) {
                        if (fld.HtmlTag == "PASSWORD") { // Password Field
                            oldvalue = Language.Phrase("PasswordMask");
                            newvalue = Language.Phrase("PasswordMask");
                        } else if (fld.DataType == DataType.Memo) { // Memo field
                            if (Config.AuditTrailToDatabase) {
                                oldvalue = rsold[fldname];
                                newvalue = rsnew[fldname];
                            } else {
                                oldvalue = "[MEMO]";
                                newvalue = "[MEMO]";
                            }
                        } else if (fld.DataType == DataType.Xml) { // XML field
                            oldvalue = "[XML]";
                            newvalue = "[XML]";
                        } else {
                            oldvalue = rsold[fldname];
                            newvalue = rsnew[fldname];
                        }
                        if (fldname == Config.LoginPasswordFieldName) {
                            oldvalue = Language.Phrase("PasswordMask");
                            newvalue = Language.Phrase("PasswordMask");
                        }
                        await WriteAuditTrailAsync(usr, "U", table, fldname, key, oldvalue, newvalue);
                    }
                }
            }
        }

        // Write audit trail (delete page)
        public async Task WriteAuditTrailOnDelete(IDictionary<string, object> rs)
        {
            if (!AuditTrailOnDelete)
                return;
            string table = "tblStudents";

            // Get key value
            string key = GetKey(rs); // DN

            // Write audit trail
            var dt = DbCurrentDateTime();
            var id = ScriptName();
            var usr = CurrentUser();
            foreach (string fldname in rs.Keys) {
                if (Fields.TryGetValue(fldname, out DbField? fld) && !fld.IsBlob) { // Ignore BLOB fields
                    object? oldvalue = null;
                    if (fld.HtmlTag == "PASSWORD") { // Password Field
                        oldvalue = Language.Phrase("PasswordMask"); // Password Field
                    } else if (fld.DataType == DataType.Memo) {
                        oldvalue = Config.AuditTrailToDatabase ? rs[fldname] : "[MEMO]";
                    } else if (fld.DataType == DataType.Xml) { // XML field
                        oldvalue = "[XML]";
                    } else {
                        oldvalue = rs[fldname];
                    }
                    if (fldname == Config.LoginPasswordFieldName)
                        oldvalue = Language.Phrase("PasswordMask");
                    await WriteAuditTrailAsync(usr, "D", table, fldname, key, oldvalue);
                }
            }
        }

        // Send email after add success
        public async Task<string> SendEmailOnAdd(Dictionary<string, object> rs)
        {
            string table = "tblStudents";
            string subject = table + " " + Language.Phrase("RecordInserted");
            string action = Language.Phrase("ActionInserted");

            // Get key value
            string key = GetKey(rs); // DN
            var email = new Email();
            await email.Load(Config.EmailNotifyTemplate);
            email.ReplaceSender(Config.SenderEmail); // Replace Sender
            email.ReplaceRecipient(Config.RecipientEmail); // Replace Recipient
            email.ReplaceSubject(subject); // Replace Subject
            email.ReplaceContent("<!--table-->", table);
            email.ReplaceContent("<!--key-->", key);
            email.ReplaceContent("<!--action-->", action);
            bool emailSent = false;
            if (EmailSending(email, ConvertToDictionary<dynamic>(new { rsnew = rs })))
                emailSent = await email.SendAsync();

            // Send email result
            return !emailSent ? email.SendError : "OK"; // DN
        }

        // Send email after update success
        public async Task<string> SendEmailOnEdit(Dictionary<string, object> rsold, Dictionary<string, object> rsnew)
        {
            string table = "tblStudents";
            string subject = table + " " + Language.Phrase("RecordUpdated");
            string action = Language.Phrase("ActionUpdated");

            // Get key value
            string key = GetKey(rsold); // DN
            var email = new Email();
            await email.Load(Config.EmailNotifyTemplate);
            email.ReplaceSender(Config.SenderEmail); // Replace Sender
            email.ReplaceRecipient(Config.RecipientEmail); // Replace Recipient
            email.ReplaceSubject(subject); // Replace Subject
            email.ReplaceContent("<!--table-->", table);
            email.ReplaceContent("<!--key-->", key);
            email.ReplaceContent("<!--action-->", action);
            bool emailSent = false;
            if (EmailSending(email, ConvertToDictionary<dynamic>(new { rsold = rsold, rsnew = rsnew })))
                emailSent = await email.SendAsync();

            // Send email result
            return !emailSent ? email.SendError : "OK"; // DN
        }

        // Table level events
        // Table Load event
        public void TableLoad()
        {
        //Candidates update to full name
        string sUpdateSq23 = "UPD_STUDENTS_FULLNAME";
        Execute (sUpdateSq23); 
        }

        // Recordset Selecting event
        public void RecordsetSelecting(ref string filter) {
            // Enter your code here
        }

        // Recordset Selected event
        public void RecordsetSelected(DbDataReader rs) {
            // Enter your code here
        }

        // Recordset Searching event
        public void RecordsetSearching(ref string filter) {
            // Enter your code here
        }

        // Recordset Search Validated event
        public void RecordsetSearchValidated() {
            // Enter your code here
        }

        // Row_Selecting event
        public void RowSelecting(ref string filter) {
            // Enter your code here
        }

        // Row Selected event
        public void RowSelected(Dictionary<string, object> row) {
            //Log("Row Selected");
        }

        // Row Inserting event
        public bool RowInserting(Dictionary<string, object>? rsold, Dictionary<string, object> rsnew) {
            // Enter your code here
            // To cancel, set return value to False and error message to CancelMessage
            return true;
        }

        // Row Inserted event
        public void RowInserted(Dictionary<string, object>? rsold, Dictionary<string, object> rsnew) {
            //Log("Row Inserted");
        }

        // Row Updating event
        public bool RowUpdating(Dictionary<string, object> rsold, Dictionary<string, object> rsnew) {
            // Enter your code here
            // To cancel, set return value to False and error message to CancelMessage
            return true;
        }

        // Row Updated event
        public void RowUpdated(Dictionary<string, object> rsold, Dictionary<string, object> rsnew) {
         //Update PV_Noexp Scores
        string sUpdateSq22 = "UPD_STUDENTS_PV_NOEXP_SCORES";
        Execute (sUpdateSq22);  
        }

        // Row Update Conflict event
        public bool RowUpdateConflict(Dictionary<string, object> rsold, Dictionary<string, object> rsnew) {
            // Enter your code here
            // To ignore conflict, set return value to false
            return true;
        }

        // Recordset Deleting event
        public bool RowDeleting(Dictionary<string, object> rs) {
            // Enter your code here
            // To cancel, set return value to False and error message to CancelMessage
            return true;
        }

        // Row Deleted event
        public void RowDeleted(Dictionary<string, object> rs) {
            //Log("Row Deleted");
        }

        // Row Export event
        // doc = export document object
        public virtual void RowExport(dynamic doc, DbDataReader rs) {
            //doc.Text.Append("<div>" + MyField.ViewValue +"</div>"); // Build HTML with field value: rs["MyField"] or MyField.ViewValue
        }

        // Email Sending event
        public virtual bool EmailSending(Email email, dynamic? args) {
            //Log(email);
            return true;
        }

        // Lookup Selecting event
        public void LookupSelecting(DbField fld, ref string filter) {
            // Enter your code here
        }

        // Row Rendering event
        public void RowRendering() {
            // Enter your code here
        }

        // Row Rendered event
        public void RowRendered() {
            //VarDump(<FieldName>); // View field properties
        }

        // User ID Filtering event
        public void UserIdFiltering(ref string filter) {
            // Enter your code here
        }
    }
} // End Partial class
