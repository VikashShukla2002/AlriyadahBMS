namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblCrAttendance
    /// </summary>
    [MaybeNull]
    public static TblCrAttendance tblCrAttendance
    {
        get => HttpData.Resolve<TblCrAttendance>("tblCRAttendance");
        set => HttpData["tblCRAttendance"] = value;
    }

    /// <summary>
    /// Table class for tblCRAttendance
    /// </summary>
    public class TblCrAttendance : DbTable, IQueryFactory
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

        public bool ModalView = false;

        public bool ModalAdd = false;

        public bool ModalEdit = false;

        public bool ModalUpdate = false;

        public bool InlineDelete = false;

        public bool ModalGridAdd = false;

        public bool ModalGridEdit = false;

        public bool ModalMultiEdit = false;

        public readonly DbField<SqlDbType> int_Attendance_ID;

        public readonly DbField<SqlDbType> int_Student_ID;

        public readonly DbField<SqlDbType> str_FullName;

        public readonly DbField<SqlDbType> str_Username;

        public readonly DbField<SqlDbType> int_CR_ID;

        public readonly DbField<SqlDbType> int_CRSession_ID;

        public readonly DbField<SqlDbType> Is_All_Attend;

        public readonly DbField<SqlDbType> idnumber;

        public readonly DbField<SqlDbType> course_id;

        public readonly DbField<SqlDbType> str_Test_Score;

        public readonly DbField<SqlDbType> str_Notes;

        public readonly DbField<SqlDbType> bit_IsDeleted;

        public readonly DbField<SqlDbType> int_Created_BY;

        public readonly DbField<SqlDbType> int_Modified_BY;

        public readonly DbField<SqlDbType> date_Created;

        public readonly DbField<SqlDbType> date_Modified;

        public readonly DbField<SqlDbType> bit_IsMakeUP;

        public readonly DbField<SqlDbType> dec_Orginal_SessionID;

        public readonly DbField<SqlDbType> dec_CR_ID_For_Del;

        public readonly DbField<SqlDbType> int_Session_ID_For_Del;

        public readonly DbField<SqlDbType> RemM1;

        public readonly DbField<SqlDbType> RemM2;

        public readonly DbField<SqlDbType> RemM3;

        public readonly DbField<SqlDbType> studentSignature;

        public readonly DbField<SqlDbType> SMSReminder1;

        public readonly DbField<SqlDbType> SMSReminder2;

        public readonly DbField<SqlDbType> SMSReminder3;

        public readonly DbField<SqlDbType> VoiceReminder1;

        public readonly DbField<SqlDbType> VoiceReminder2;

        public readonly DbField<SqlDbType> VoiceReminder3;

        public readonly DbField<SqlDbType> strParentName;

        public readonly DbField<SqlDbType> strParentState;

        public readonly DbField<SqlDbType> strParentLicenseNumber;

        public readonly DbField<SqlDbType> CRSS_ID;

        public readonly DbField<SqlDbType> str_CR_Number;

        // Constructor
        public TblCrAttendance()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "tblCRAttendance";
            Name = "tblCRAttendance";
            Type = "TABLE";
            UpdateTable = "dbo.tblCRAttendance"; // Update Table
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
            UserIdAllowSecurity = Config.DefaultUserIdAllowSecurity; // User ID Allow

            // int_Attendance_ID
            int_Attendance_ID = new (this, "x_int_Attendance_ID", 3, SqlDbType.Int) {
                Name = "int_Attendance_ID",
                Expression = "[int_Attendance_ID]",
                BasicSearchExpression = "CAST([int_Attendance_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Attendance_ID]",
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
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "int_Attendance_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Attendance_ID", int_Attendance_ID);

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
                HtmlTag = "TEXT",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "int_Student_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Student_ID", int_Student_ID);

            // str_FullName
            str_FullName = new (this, "x_str_FullName", 202, SqlDbType.NVarChar) {
                Name = "str_FullName",
                Expression = "[str_FullName]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_FullName]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_FullName]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "str_FullName", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_FullName", str_FullName);

            // str_Username
            str_Username = new (this, "x_str_Username", 202, SqlDbType.NVarChar) {
                Name = "str_Username",
                Expression = "[str_Username]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Username]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Username]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "SELECT",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                SearchOperators = new () { "=", "<>" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "str_Username", "CustomMsg"),
                IsUpload = false
            };
            str_Username.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(str_Username, "qryStudEnrllist", false, "str_Username", new List<string> {"str_Username", "", "", ""}, "", "", new List<string> {"x_idnumber"}, new List<string> {"x_idnumber"}, new List<string> {"course"}, new List<string> {"x_course"}, new List<string> {}, new List<string> {}, "", "", "[str_Username]"),
                "en-US" => new Lookup<DbField>(str_Username, "qryStudEnrllist", false, "str_Username", new List<string> {"str_Username", "", "", ""}, "", "", new List<string> {"x_idnumber"}, new List<string> {"x_idnumber"}, new List<string> {"course"}, new List<string> {"x_course"}, new List<string> {}, new List<string> {}, "", "", "[str_Username]"),
                _ => new Lookup<DbField>(str_Username, "qryStudEnrllist", false, "str_Username", new List<string> {"str_Username", "", "", ""}, "", "", new List<string> {"x_idnumber"}, new List<string> {"x_idnumber"}, new List<string> {"course"}, new List<string> {"x_course"}, new List<string> {}, new List<string> {}, "", "", "[str_Username]")
            };
            Fields.Add("str_Username", str_Username);

            // int_CR_ID
            int_CR_ID = new (this, "x_int_CR_ID", 3, SqlDbType.Int) {
                Name = "int_CR_ID",
                Expression = "[int_CR_ID]",
                BasicSearchExpression = "CAST([int_CR_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_CR_ID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "int_CR_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CR_ID", int_CR_ID);

            // int_CRSession_ID
            int_CRSession_ID = new (this, "x_int_CRSession_ID", 3, SqlDbType.Int) {
                Name = "int_CRSession_ID",
                Expression = "[int_CRSession_ID]",
                BasicSearchExpression = "CAST([int_CRSession_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_CRSession_ID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "int_CRSession_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CRSession_ID", int_CRSession_ID);

            // Is_All_Attend
            Is_All_Attend = new (this, "x_Is_All_Attend", 11, SqlDbType.Bit) {
                Name = "Is_All_Attend",
                Expression = "[Is_All_Attend]",
                BasicSearchExpression = "[Is_All_Attend]",
                DateTimeFormat = -1,
                VirtualExpression = "[Is_All_Attend]",
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
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "Is_All_Attend", "CustomMsg"),
                IsUpload = false
            };
            Is_All_Attend.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Is_All_Attend, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Is_All_Attend, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Is_All_Attend, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Is_All_Attend", Is_All_Attend);

            // idnumber
            idnumber = new (this, "x_idnumber", 200, SqlDbType.VarChar) {
                Name = "idnumber",
                Expression = "[idnumber]",
                UseBasicSearch = true,
                BasicSearchExpression = "[idnumber]",
                DateTimeFormat = -1,
                VirtualExpression = "[idnumber]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "idnumber", "CustomMsg"),
                IsUpload = false
            };
            idnumber.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(idnumber, "qryStudEnrllist", true, "course", new List<string> {"course", "", "", ""}, "", "", new List<string> {"x_str_Username"}, new List<string> {"x_str_Username"}, new List<string> {"str_Username"}, new List<string> {"x_str_Username"}, new List<string> {}, new List<string> {}, "", "", "[course]"),
                "en-US" => new Lookup<DbField>(idnumber, "qryStudEnrllist", true, "course", new List<string> {"course", "", "", ""}, "", "", new List<string> {"x_str_Username"}, new List<string> {"x_str_Username"}, new List<string> {"str_Username"}, new List<string> {"x_str_Username"}, new List<string> {}, new List<string> {}, "", "", "[course]"),
                _ => new Lookup<DbField>(idnumber, "qryStudEnrllist", true, "course", new List<string> {"course", "", "", ""}, "", "", new List<string> {"x_str_Username"}, new List<string> {"x_str_Username"}, new List<string> {"str_Username"}, new List<string> {"x_str_Username"}, new List<string> {}, new List<string> {}, "", "", "[course]")
            };
            Fields.Add("idnumber", idnumber);

            // course_id
            course_id = new (this, "x_course_id", 20, SqlDbType.BigInt) {
                Name = "course_id",
                Expression = "[course_id]",
                BasicSearchExpression = "CAST([course_id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[course_id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "course_id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("course_id", course_id);

            // str_Test_Score
            str_Test_Score = new (this, "x_str_Test_Score", 200, SqlDbType.VarChar) {
                Name = "str_Test_Score",
                Expression = "[str_Test_Score]",
                BasicSearchExpression = "[str_Test_Score]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Test_Score]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "str_Test_Score", "CustomMsg"),
                IsUpload = false
            };
            str_Test_Score.GetDefault = () => "0";
            Fields.Add("str_Test_Score", str_Test_Score);

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
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "str_Notes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Notes", str_Notes);

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
                Nullable = false, // NOT NULL field
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new () { "=", "<>" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "bit_IsDeleted", "CustomMsg"),
                IsUpload = false
            };
            bit_IsDeleted.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IsDeleted, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsDeleted, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IsDeleted, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_IsDeleted", bit_IsDeleted);

            // int_Created_BY
            int_Created_BY = new (this, "x_int_Created_BY", 131, SqlDbType.Decimal) {
                Name = "int_Created_BY",
                Expression = "[int_Created_BY]",
                BasicSearchExpression = "CAST([int_Created_BY] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Created_BY]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "int_Created_BY", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Created_BY", int_Created_BY);

            // int_Modified_BY
            int_Modified_BY = new (this, "x_int_Modified_BY", 131, SqlDbType.Decimal) {
                Name = "int_Modified_BY",
                Expression = "[int_Modified_BY]",
                BasicSearchExpression = "CAST([int_Modified_BY] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Modified_BY]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "int_Modified_BY", "CustomMsg"),
                IsUpload = false
            };
            int_Modified_BY.GetAutoUpdateValue = () => CurrentUserID();
            Fields.Add("int_Modified_BY", int_Modified_BY);

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
                HtmlTag = "TEXT",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "date_Created", "CustomMsg"),
                IsUpload = false
            };
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
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "date_Modified", "CustomMsg"),
                IsUpload = false
            };
            date_Modified.GetAutoUpdateValue = () => CurrentDateTime();
            Fields.Add("date_Modified", date_Modified);

            // bit_IsMakeUP
            bit_IsMakeUP = new (this, "x_bit_IsMakeUP", 11, SqlDbType.Bit) {
                Name = "bit_IsMakeUP",
                Expression = "[bit_IsMakeUP]",
                BasicSearchExpression = "[bit_IsMakeUP]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_IsMakeUP]",
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
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "bit_IsMakeUP", "CustomMsg"),
                IsUpload = false
            };
            bit_IsMakeUP.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IsMakeUP, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsMakeUP, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IsMakeUP, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_IsMakeUP", bit_IsMakeUP);

            // dec_Orginal_SessionID
            dec_Orginal_SessionID = new (this, "x_dec_Orginal_SessionID", 131, SqlDbType.Decimal) {
                Name = "dec_Orginal_SessionID",
                Expression = "[dec_Orginal_SessionID]",
                BasicSearchExpression = "CAST([dec_Orginal_SessionID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[dec_Orginal_SessionID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "dec_Orginal_SessionID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dec_Orginal_SessionID", dec_Orginal_SessionID);

            // dec_CR_ID_For_Del
            dec_CR_ID_For_Del = new (this, "x_dec_CR_ID_For_Del", 131, SqlDbType.Decimal) {
                Name = "dec_CR_ID_For_Del",
                Expression = "[dec_CR_ID_For_Del]",
                BasicSearchExpression = "CAST([dec_CR_ID_For_Del] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[dec_CR_ID_For_Del]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "dec_CR_ID_For_Del", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dec_CR_ID_For_Del", dec_CR_ID_For_Del);

            // int_Session_ID_For_Del
            int_Session_ID_For_Del = new (this, "x_int_Session_ID_For_Del", 3, SqlDbType.Int) {
                Name = "int_Session_ID_For_Del",
                Expression = "[int_Session_ID_For_Del]",
                BasicSearchExpression = "CAST([int_Session_ID_For_Del] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Session_ID_For_Del]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "int_Session_ID_For_Del", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Session_ID_For_Del", int_Session_ID_For_Del);

            // RemM1
            RemM1 = new (this, "x_RemM1", 11, SqlDbType.Bit) {
                Name = "RemM1",
                Expression = "[RemM1]",
                BasicSearchExpression = "[RemM1]",
                DateTimeFormat = -1,
                VirtualExpression = "[RemM1]",
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
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "RemM1", "CustomMsg"),
                IsUpload = false
            };
            RemM1.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(RemM1, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(RemM1, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(RemM1, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            RemM1.GetDefault = () => 0;
            Fields.Add("RemM1", RemM1);

            // RemM2
            RemM2 = new (this, "x_RemM2", 11, SqlDbType.Bit) {
                Name = "RemM2",
                Expression = "[RemM2]",
                BasicSearchExpression = "[RemM2]",
                DateTimeFormat = -1,
                VirtualExpression = "[RemM2]",
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
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "RemM2", "CustomMsg"),
                IsUpload = false
            };
            RemM2.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(RemM2, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(RemM2, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(RemM2, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            RemM2.GetDefault = () => 0;
            Fields.Add("RemM2", RemM2);

            // RemM3
            RemM3 = new (this, "x_RemM3", 11, SqlDbType.Bit) {
                Name = "RemM3",
                Expression = "[RemM3]",
                BasicSearchExpression = "[RemM3]",
                DateTimeFormat = -1,
                VirtualExpression = "[RemM3]",
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
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "RemM3", "CustomMsg"),
                IsUpload = false
            };
            RemM3.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(RemM3, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(RemM3, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(RemM3, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            RemM3.GetDefault = () => 0;
            Fields.Add("RemM3", RemM3);

            // studentSignature
            studentSignature = new (this, "x_studentSignature", 205, SqlDbType.Image) {
                Name = "studentSignature",
                Expression = "[studentSignature]",
                BasicSearchExpression = "[studentSignature]",
                DateTimeFormat = -1,
                VirtualExpression = "[studentSignature]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "FILE",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "studentSignature", "CustomMsg"),
                IsUpload = true
            };
            Fields.Add("studentSignature", studentSignature);

            // SMSReminder1
            SMSReminder1 = new (this, "x_SMSReminder1", 11, SqlDbType.Bit) {
                Name = "SMSReminder1",
                Expression = "[SMSReminder1]",
                BasicSearchExpression = "[SMSReminder1]",
                DateTimeFormat = -1,
                VirtualExpression = "[SMSReminder1]",
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
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "SMSReminder1", "CustomMsg"),
                IsUpload = false
            };
            SMSReminder1.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(SMSReminder1, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(SMSReminder1, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(SMSReminder1, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("SMSReminder1", SMSReminder1);

            // SMSReminder2
            SMSReminder2 = new (this, "x_SMSReminder2", 11, SqlDbType.Bit) {
                Name = "SMSReminder2",
                Expression = "[SMSReminder2]",
                BasicSearchExpression = "[SMSReminder2]",
                DateTimeFormat = -1,
                VirtualExpression = "[SMSReminder2]",
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
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "SMSReminder2", "CustomMsg"),
                IsUpload = false
            };
            SMSReminder2.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(SMSReminder2, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(SMSReminder2, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(SMSReminder2, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("SMSReminder2", SMSReminder2);

            // SMSReminder3
            SMSReminder3 = new (this, "x_SMSReminder3", 11, SqlDbType.Bit) {
                Name = "SMSReminder3",
                Expression = "[SMSReminder3]",
                BasicSearchExpression = "[SMSReminder3]",
                DateTimeFormat = -1,
                VirtualExpression = "[SMSReminder3]",
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
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "SMSReminder3", "CustomMsg"),
                IsUpload = false
            };
            SMSReminder3.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(SMSReminder3, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(SMSReminder3, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(SMSReminder3, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("SMSReminder3", SMSReminder3);

            // VoiceReminder1
            VoiceReminder1 = new (this, "x_VoiceReminder1", 11, SqlDbType.Bit) {
                Name = "VoiceReminder1",
                Expression = "[VoiceReminder1]",
                BasicSearchExpression = "[VoiceReminder1]",
                DateTimeFormat = -1,
                VirtualExpression = "[VoiceReminder1]",
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
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "VoiceReminder1", "CustomMsg"),
                IsUpload = false
            };
            VoiceReminder1.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(VoiceReminder1, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(VoiceReminder1, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(VoiceReminder1, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("VoiceReminder1", VoiceReminder1);

            // VoiceReminder2
            VoiceReminder2 = new (this, "x_VoiceReminder2", 11, SqlDbType.Bit) {
                Name = "VoiceReminder2",
                Expression = "[VoiceReminder2]",
                BasicSearchExpression = "[VoiceReminder2]",
                DateTimeFormat = -1,
                VirtualExpression = "[VoiceReminder2]",
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
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "VoiceReminder2", "CustomMsg"),
                IsUpload = false
            };
            VoiceReminder2.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(VoiceReminder2, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(VoiceReminder2, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(VoiceReminder2, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("VoiceReminder2", VoiceReminder2);

            // VoiceReminder3
            VoiceReminder3 = new (this, "x_VoiceReminder3", 11, SqlDbType.Bit) {
                Name = "VoiceReminder3",
                Expression = "[VoiceReminder3]",
                BasicSearchExpression = "[VoiceReminder3]",
                DateTimeFormat = -1,
                VirtualExpression = "[VoiceReminder3]",
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
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "VoiceReminder3", "CustomMsg"),
                IsUpload = false
            };
            VoiceReminder3.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(VoiceReminder3, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(VoiceReminder3, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(VoiceReminder3, "tblCRAttendance", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("VoiceReminder3", VoiceReminder3);

            // strParentName
            strParentName = new (this, "x_strParentName", 202, SqlDbType.NVarChar) {
                Name = "strParentName",
                Expression = "[strParentName]",
                BasicSearchExpression = "[strParentName]",
                DateTimeFormat = -1,
                VirtualExpression = "[strParentName]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "strParentName", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("strParentName", strParentName);

            // strParentState
            strParentState = new (this, "x_strParentState", 202, SqlDbType.NVarChar) {
                Name = "strParentState",
                Expression = "[strParentState]",
                BasicSearchExpression = "[strParentState]",
                DateTimeFormat = -1,
                VirtualExpression = "[strParentState]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "strParentState", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("strParentState", strParentState);

            // strParentLicenseNumber
            strParentLicenseNumber = new (this, "x_strParentLicenseNumber", 202, SqlDbType.NVarChar) {
                Name = "strParentLicenseNumber",
                Expression = "[strParentLicenseNumber]",
                BasicSearchExpression = "[strParentLicenseNumber]",
                DateTimeFormat = -1,
                VirtualExpression = "[strParentLicenseNumber]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "strParentLicenseNumber", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("strParentLicenseNumber", strParentLicenseNumber);

            // CRSS_ID
            CRSS_ID = new (this, "x_CRSS_ID", 20, SqlDbType.BigInt) {
                Name = "CRSS_ID",
                Expression = "[CRSS_ID]",
                BasicSearchExpression = "CAST([CRSS_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[CRSS_ID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "CRSS_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("CRSS_ID", CRSS_ID);

            // str_CR_Number
            str_CR_Number = new (this, "x_str_CR_Number", 202, SqlDbType.NVarChar) {
                Name = "str_CR_Number",
                Expression = "[str_CR_Number]",
                BasicSearchExpression = "[str_CR_Number]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CR_Number]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "SELECT",
                InputTextType = "text",
                IsForeignKey = true, // Foreign key field
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRAttendance", "str_CR_Number", "CustomMsg"),
                IsUpload = false
            };
            str_CR_Number.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(str_CR_Number, "tblClassRoom", false, "str_CR_Number", new List<string> {"str_CR_Number", "str_CR_Days", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "[str_CR_Number]", "", "CONCAT([str_CR_Number],'" + ValueSeparator(1, str_CR_Number) + "',[str_CR_Days])"),
                "en-US" => new Lookup<DbField>(str_CR_Number, "tblClassRoom", false, "str_CR_Number", new List<string> {"str_CR_Number", "str_CR_Days", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "[str_CR_Number]", "", "CONCAT([str_CR_Number],'" + ValueSeparator(1, str_CR_Number) + "',[str_CR_Days])"),
                _ => new Lookup<DbField>(str_CR_Number, "tblClassRoom", false, "str_CR_Number", new List<string> {"str_CR_Number", "str_CR_Days", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "[str_CR_Number]", "", "CONCAT([str_CR_Number],'" + ValueSeparator(1, str_CR_Number) + "',[str_CR_Days])")
            };
            Fields.Add("str_CR_Number", str_CR_Number);

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
                if (Empty(detailUrl))
                    detailUrl = "TblCrAttendanceList";
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
            get => _sqlFrom ?? "dbo.tblCRAttendance";
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
                int_Attendance_ID.SetDbValue(lastInsertedId);
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
                if (!rsaudit.ContainsKey("int_Attendance_ID"))
                    rsaudit.Add("int_Attendance_ID", rsold["int_Attendance_ID"]);
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
                int_Attendance_ID.DbValue = row["int_Attendance_ID"]; // Set DB value only
                int_Student_ID.DbValue = row["int_Student_ID"]; // Set DB value only
                str_FullName.DbValue = row["str_FullName"]; // Set DB value only
                str_Username.DbValue = row["str_Username"]; // Set DB value only
                int_CR_ID.DbValue = row["int_CR_ID"]; // Set DB value only
                int_CRSession_ID.DbValue = row["int_CRSession_ID"]; // Set DB value only
                Is_All_Attend.DbValue = (ConvertToBool(row["Is_All_Attend"]) ? "1" : "0"); // Set DB value only
                idnumber.DbValue = row["idnumber"]; // Set DB value only
                course_id.DbValue = row["course_id"]; // Set DB value only
                str_Test_Score.DbValue = row["str_Test_Score"]; // Set DB value only
                str_Notes.DbValue = row["str_Notes"]; // Set DB value only
                bit_IsDeleted.DbValue = (ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"); // Set DB value only
                int_Created_BY.DbValue = row["int_Created_BY"]; // Set DB value only
                int_Modified_BY.DbValue = row["int_Modified_BY"]; // Set DB value only
                date_Created.DbValue = row["date_Created"]; // Set DB value only
                date_Modified.DbValue = row["date_Modified"]; // Set DB value only
                bit_IsMakeUP.DbValue = (ConvertToBool(row["bit_IsMakeUP"]) ? "1" : "0"); // Set DB value only
                dec_Orginal_SessionID.DbValue = row["dec_Orginal_SessionID"]; // Set DB value only
                dec_CR_ID_For_Del.DbValue = row["dec_CR_ID_For_Del"]; // Set DB value only
                int_Session_ID_For_Del.DbValue = row["int_Session_ID_For_Del"]; // Set DB value only
                RemM1.DbValue = (ConvertToBool(row["RemM1"]) ? "1" : "0"); // Set DB value only
                RemM2.DbValue = (ConvertToBool(row["RemM2"]) ? "1" : "0"); // Set DB value only
                RemM3.DbValue = (ConvertToBool(row["RemM3"]) ? "1" : "0"); // Set DB value only
                studentSignature.Upload.DbValue = row["studentSignature"];
                SMSReminder1.DbValue = (ConvertToBool(row["SMSReminder1"]) ? "1" : "0"); // Set DB value only
                SMSReminder2.DbValue = (ConvertToBool(row["SMSReminder2"]) ? "1" : "0"); // Set DB value only
                SMSReminder3.DbValue = (ConvertToBool(row["SMSReminder3"]) ? "1" : "0"); // Set DB value only
                VoiceReminder1.DbValue = (ConvertToBool(row["VoiceReminder1"]) ? "1" : "0"); // Set DB value only
                VoiceReminder2.DbValue = (ConvertToBool(row["VoiceReminder2"]) ? "1" : "0"); // Set DB value only
                VoiceReminder3.DbValue = (ConvertToBool(row["VoiceReminder3"]) ? "1" : "0"); // Set DB value only
                strParentName.DbValue = row["strParentName"]; // Set DB value only
                strParentState.DbValue = row["strParentState"]; // Set DB value only
                strParentLicenseNumber.DbValue = row["strParentLicenseNumber"]; // Set DB value only
                CRSS_ID.DbValue = row["CRSS_ID"]; // Set DB value only
                str_CR_Number.DbValue = row["str_CR_Number"]; // Set DB value only
            } catch {}
        }

        public void DeleteUploadedFiles(Dictionary<string, object> row)
        {
            LoadDbValues(row);
        }

        // Record filter WHERE clause
        private string _sqlKeyFilter => "[int_Attendance_ID] = @int_Attendance_ID@";

        #pragma warning disable 168, 219
        // Get record filter as string
        public string GetRecordFilter(Dictionary<string, object>? row = null, bool current = false)
        {
            string keyFilter = _sqlKeyFilter;
            object? val = null, result = "";
            val = row?.TryGetValue("int_Attendance_ID", out result) ?? false
                ? result
                : !Empty(int_Attendance_ID.OldValue) && !current ? int_Attendance_ID.OldValue : int_Attendance_ID.CurrentValue;
            if (!IsNumeric(val))
                return "0=1"; // Invalid key
            if (val == null)
                return "0=1"; // Invalid key
            keyFilter = keyFilter.Replace("@int_Attendance_ID@", AdjustSql(val, DbId)); // Replace key value
            return keyFilter;
        }

        // Get record filter as Dictionary // DN
        public Dictionary<string, object>? GetRowFilterAsDictionary(IDictionary<string, object>? row = null)
        {
            Dictionary<string, object>? keyFilter = new ();
            object? val = null, result;
            val = row?.TryGetValue("int_Attendance_ID", out result) ?? false
                ? result
                : !Empty(int_Attendance_ID.OldValue) ? int_Attendance_ID.OldValue : int_Attendance_ID.CurrentValue;
            if (!IsNumeric(val))
                return null; // Invalid key
            if (Empty(val))
                return null; // Invalid key
            keyFilter.Add("int_Attendance_ID", val); // Add key value
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
                    return "TblCrAttendanceList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "TblCrAttendanceView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "TblCrAttendanceEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "TblCrAttendanceAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "TblCrAttendanceList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "TblCrAttendanceView",
                Config.ApiAddAction => "TblCrAttendanceAdd",
                Config.ApiEditAction => "TblCrAttendanceEdit",
                Config.ApiDeleteAction => "TblCrAttendanceDelete",
                Config.ApiListAction => "TblCrAttendanceList",
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
        public string ListUrl => "TblCrAttendanceList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblCrAttendanceView", parm);
            else
                url = KeyUrl("TblCrAttendanceView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "TblCrAttendanceAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "TblCrAttendanceAdd?" + parm;
            else
                url = "TblCrAttendanceAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblCrAttendanceEdit", parm);
            else
                url = KeyUrl("TblCrAttendanceEdit", Config.TableShowDetail + "=");
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblCrAttendanceList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblCrAttendanceAdd", parm);
            else
                url = KeyUrl("TblCrAttendanceAdd", Config.TableShowDetail + "=");
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblCrAttendanceList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("TblCrAttendanceDelete")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
            return url;
        }

        // Get primary key as JSON
        public string KeyToJson(bool htmlEncode = false)
        {
            string json = "";
            json += "\"int_Attendance_ID\":" + ConvertToJson(int_Attendance_ID.CurrentValue, "number", true);
            json = "{" + json + "}";
            if (htmlEncode)
                json = HtmlEncode(json);
            return json;
        }

        // Add key value to URL
        public string KeyUrl(string url, string parm = "") { // DN
            if (!IsNull(int_Attendance_ID.CurrentValue)) {
                url += "/" + int_Attendance_ID.CurrentValue;
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
            val = current ? ConvertToString(int_Attendance_ID.CurrentValue) ?? "" : ConvertToString(int_Attendance_ID.OldValue) ?? "";
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
            val = row?.TryGetValue("int_Attendance_ID", out result) ?? false ? ConvertToString(result) : null;
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
                    int_Attendance_ID.CurrentValue = keys[0];
                } else {
                    int_Attendance_ID.OldValue = keys[0];
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
                if (RouteValues.TryGetValue("int_Attendance_ID", out object? v0)) { // int_Attendance_ID // DN
                    key = UrlDecode(v0); // DN
                } else if (IsApi() && !Empty(keyValues)) {
                    key = keyValues[0];
                } else {
                    key = Param("int_Attendance_ID");
                }
                keysList.Add(key);
            }
            // Check keys
            foreach (var keys in keysList) {
                if (!IsNumeric(keys)) // int_Attendance_ID
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
                    int_Attendance_ID.CurrentValue = keys;
                else
                    int_Attendance_ID.OldValue = keys;
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
            int_Attendance_ID.SetDbValue(dr["int_Attendance_ID"]);
            int_Student_ID.SetDbValue(dr["int_Student_ID"]);
            str_FullName.SetDbValue(dr["str_FullName"]);
            str_Username.SetDbValue(dr["str_Username"]);
            int_CR_ID.SetDbValue(dr["int_CR_ID"]);
            int_CRSession_ID.SetDbValue(dr["int_CRSession_ID"]);
            Is_All_Attend.SetDbValue(ConvertToBool(dr["Is_All_Attend"]) ? "1" : "0");
            idnumber.SetDbValue(dr["idnumber"]);
            course_id.SetDbValue(dr["course_id"]);
            str_Test_Score.SetDbValue(dr["str_Test_Score"]);
            str_Notes.SetDbValue(dr["str_Notes"]);
            bit_IsDeleted.SetDbValue(ConvertToBool(dr["bit_IsDeleted"]) ? "1" : "0");
            int_Created_BY.SetDbValue(dr["int_Created_BY"]);
            int_Modified_BY.SetDbValue(dr["int_Modified_BY"]);
            date_Created.SetDbValue(dr["date_Created"]);
            date_Modified.SetDbValue(dr["date_Modified"]);
            bit_IsMakeUP.SetDbValue(ConvertToBool(dr["bit_IsMakeUP"]) ? "1" : "0");
            dec_Orginal_SessionID.SetDbValue(dr["dec_Orginal_SessionID"]);
            dec_CR_ID_For_Del.SetDbValue(dr["dec_CR_ID_For_Del"]);
            int_Session_ID_For_Del.SetDbValue(dr["int_Session_ID_For_Del"]);
            RemM1.SetDbValue(ConvertToBool(dr["RemM1"]) ? "1" : "0");
            RemM2.SetDbValue(ConvertToBool(dr["RemM2"]) ? "1" : "0");
            RemM3.SetDbValue(ConvertToBool(dr["RemM3"]) ? "1" : "0");
            studentSignature.Upload.DbValue = dr["studentSignature"];
            SMSReminder1.SetDbValue(ConvertToBool(dr["SMSReminder1"]) ? "1" : "0");
            SMSReminder2.SetDbValue(ConvertToBool(dr["SMSReminder2"]) ? "1" : "0");
            SMSReminder3.SetDbValue(ConvertToBool(dr["SMSReminder3"]) ? "1" : "0");
            VoiceReminder1.SetDbValue(ConvertToBool(dr["VoiceReminder1"]) ? "1" : "0");
            VoiceReminder2.SetDbValue(ConvertToBool(dr["VoiceReminder2"]) ? "1" : "0");
            VoiceReminder3.SetDbValue(ConvertToBool(dr["VoiceReminder3"]) ? "1" : "0");
            strParentName.SetDbValue(dr["strParentName"]);
            strParentState.SetDbValue(dr["strParentState"]);
            strParentLicenseNumber.SetDbValue(dr["strParentLicenseNumber"]);
            CRSS_ID.SetDbValue(dr["CRSS_ID"]);
            str_CR_Number.SetDbValue(dr["str_CR_Number"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "TblCrAttendanceList";
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

            // int_Attendance_ID

            // int_Student_ID

            // str_FullName

            // str_Username

            // int_CR_ID

            // int_CRSession_ID

            // Is_All_Attend

            // idnumber

            // course_id

            // str_Test_Score

            // str_Notes

            // bit_IsDeleted

            // int_Created_BY

            // int_Modified_BY

            // date_Created

            // date_Modified

            // bit_IsMakeUP

            // dec_Orginal_SessionID

            // dec_CR_ID_For_Del

            // int_Session_ID_For_Del

            // RemM1

            // RemM2

            // RemM3

            // studentSignature

            // SMSReminder1

            // SMSReminder2

            // SMSReminder3

            // VoiceReminder1

            // VoiceReminder2

            // VoiceReminder3

            // strParentName

            // strParentState

            // strParentLicenseNumber

            // CRSS_ID

            // str_CR_Number

            // int_Attendance_ID
            int_Attendance_ID.ViewValue = int_Attendance_ID.CurrentValue;
            int_Attendance_ID.ViewCustomAttributes = "";

            // int_Student_ID
            int_Student_ID.ViewValue = int_Student_ID.CurrentValue;
            int_Student_ID.ViewValue = FormatNumber(int_Student_ID.ViewValue, int_Student_ID.FormatPattern);
            int_Student_ID.ViewCustomAttributes = "";

            // str_FullName
            str_FullName.ViewValue = ConvertToString(str_FullName.CurrentValue); // DN
            str_FullName.ViewCustomAttributes = "";

            // str_Username
            curVal = ConvertToString(str_Username.CurrentValue);
            if (!Empty(curVal)) {
                if (str_Username.Lookup != null && IsDictionary(str_Username.Lookup?.Options) && str_Username.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    str_Username.ViewValue = str_Username.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[str_Username]", "=", str_Username.CurrentValue, DataType.String, "");
                    sqlWrk = str_Username.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && str_Username.Lookup != null) { // Lookup values found
                        var listwrk = str_Username.Lookup?.RenderViewRow(rswrk[0]);
                        str_Username.ViewValue = str_Username.HighlightLookup(ConvertToString(rswrk[0]), str_Username.DisplayValue(listwrk));
                    } else {
                        str_Username.ViewValue = str_Username.CurrentValue;
                    }
                }
            } else {
                str_Username.ViewValue = DbNullValue;
            }
            str_Username.ViewCustomAttributes = "";

            // int_CR_ID
            int_CR_ID.ViewValue = int_CR_ID.CurrentValue;
            int_CR_ID.ViewValue = FormatNumber(int_CR_ID.ViewValue, int_CR_ID.FormatPattern);
            int_CR_ID.ViewCustomAttributes = "";

            // int_CRSession_ID
            int_CRSession_ID.ViewValue = int_CRSession_ID.CurrentValue;
            int_CRSession_ID.ViewValue = FormatNumber(int_CRSession_ID.ViewValue, int_CRSession_ID.FormatPattern);
            int_CRSession_ID.ViewCustomAttributes = "";

            // Is_All_Attend
            if (ConvertToBool(Is_All_Attend.CurrentValue)) {
                Is_All_Attend.ViewValue = Is_All_Attend.TagCaption(1) != "" ? Is_All_Attend.TagCaption(1) : "Yes";
            } else {
                Is_All_Attend.ViewValue = Is_All_Attend.TagCaption(2) != "" ? Is_All_Attend.TagCaption(2) : "No";
            }
            Is_All_Attend.CellCssStyle += "text-align: center;";
            Is_All_Attend.ViewCustomAttributes = "";

            // idnumber
            idnumber.ViewValue = ConvertToString(idnumber.CurrentValue); // DN
            curVal = ConvertToString(idnumber.CurrentValue);
            if (!Empty(curVal)) {
                if (idnumber.Lookup != null && IsDictionary(idnumber.Lookup?.Options) && idnumber.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    idnumber.ViewValue = idnumber.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[course]", "=", idnumber.CurrentValue, DataType.String, "");
                    sqlWrk = idnumber.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && idnumber.Lookup != null) { // Lookup values found
                        var listwrk = idnumber.Lookup?.RenderViewRow(rswrk[0]);
                        idnumber.ViewValue = idnumber.HighlightLookup(ConvertToString(rswrk[0]), idnumber.DisplayValue(listwrk));
                    } else {
                        idnumber.ViewValue = idnumber.CurrentValue;
                    }
                }
            } else {
                idnumber.ViewValue = DbNullValue;
            }
            idnumber.ViewCustomAttributes = "";

            // course_id
            course_id.ViewValue = course_id.CurrentValue;
            course_id.ViewValue = FormatNumber(course_id.ViewValue, course_id.FormatPattern);
            course_id.ViewCustomAttributes = "";

            // str_Test_Score
            str_Test_Score.ViewValue = ConvertToString(str_Test_Score.CurrentValue); // DN
            str_Test_Score.ViewCustomAttributes = "";

            // str_Notes
            str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
            str_Notes.ViewCustomAttributes = "";

            // bit_IsDeleted
            if (ConvertToBool(bit_IsDeleted.CurrentValue)) {
                bit_IsDeleted.ViewValue = bit_IsDeleted.TagCaption(1) != "" ? bit_IsDeleted.TagCaption(1) : "Yes";
            } else {
                bit_IsDeleted.ViewValue = bit_IsDeleted.TagCaption(2) != "" ? bit_IsDeleted.TagCaption(2) : "No";
            }
            bit_IsDeleted.CellCssStyle += "text-align: center;";
            bit_IsDeleted.ViewCustomAttributes = "";

            // int_Created_BY
            int_Created_BY.ViewValue = int_Created_BY.CurrentValue;
            int_Created_BY.ViewValue = FormatNumber(int_Created_BY.ViewValue, int_Created_BY.FormatPattern);
            int_Created_BY.ViewCustomAttributes = "";

            // int_Modified_BY
            int_Modified_BY.ViewValue = int_Modified_BY.CurrentValue;
            int_Modified_BY.ViewValue = FormatNumber(int_Modified_BY.ViewValue, int_Modified_BY.FormatPattern);
            int_Modified_BY.ViewCustomAttributes = "";

            // date_Created
            date_Created.ViewValue = date_Created.CurrentValue;
            date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
            date_Created.ViewCustomAttributes = "";

            // date_Modified
            date_Modified.ViewValue = date_Modified.CurrentValue;
            date_Modified.ViewValue = FormatDateTime(date_Modified.ViewValue, date_Modified.FormatPattern);
            date_Modified.ViewCustomAttributes = "";

            // bit_IsMakeUP
            if (ConvertToBool(bit_IsMakeUP.CurrentValue)) {
                bit_IsMakeUP.ViewValue = bit_IsMakeUP.TagCaption(1) != "" ? bit_IsMakeUP.TagCaption(1) : "Yes";
            } else {
                bit_IsMakeUP.ViewValue = bit_IsMakeUP.TagCaption(2) != "" ? bit_IsMakeUP.TagCaption(2) : "No";
            }
            bit_IsMakeUP.CellCssStyle += "text-align: center;";
            bit_IsMakeUP.ViewCustomAttributes = "";

            // dec_Orginal_SessionID
            dec_Orginal_SessionID.ViewValue = dec_Orginal_SessionID.CurrentValue;
            dec_Orginal_SessionID.ViewValue = FormatNumber(dec_Orginal_SessionID.ViewValue, dec_Orginal_SessionID.FormatPattern);
            dec_Orginal_SessionID.ViewCustomAttributes = "";

            // dec_CR_ID_For_Del
            dec_CR_ID_For_Del.ViewValue = dec_CR_ID_For_Del.CurrentValue;
            dec_CR_ID_For_Del.ViewValue = FormatNumber(dec_CR_ID_For_Del.ViewValue, dec_CR_ID_For_Del.FormatPattern);
            dec_CR_ID_For_Del.ViewCustomAttributes = "";

            // int_Session_ID_For_Del
            int_Session_ID_For_Del.ViewValue = int_Session_ID_For_Del.CurrentValue;
            int_Session_ID_For_Del.ViewValue = FormatNumber(int_Session_ID_For_Del.ViewValue, int_Session_ID_For_Del.FormatPattern);
            int_Session_ID_For_Del.ViewCustomAttributes = "";

            // RemM1
            if (ConvertToBool(RemM1.CurrentValue)) {
                RemM1.ViewValue = RemM1.TagCaption(1) != "" ? RemM1.TagCaption(1) : "Yes";
            } else {
                RemM1.ViewValue = RemM1.TagCaption(2) != "" ? RemM1.TagCaption(2) : "No";
            }
            RemM1.CellCssStyle += "text-align: center;";
            RemM1.ViewCustomAttributes = "";

            // RemM2
            if (ConvertToBool(RemM2.CurrentValue)) {
                RemM2.ViewValue = RemM2.TagCaption(1) != "" ? RemM2.TagCaption(1) : "Yes";
            } else {
                RemM2.ViewValue = RemM2.TagCaption(2) != "" ? RemM2.TagCaption(2) : "No";
            }
            RemM2.ViewCustomAttributes = "";

            // RemM3
            if (ConvertToBool(RemM3.CurrentValue)) {
                RemM3.ViewValue = RemM3.TagCaption(1) != "" ? RemM3.TagCaption(1) : "Yes";
            } else {
                RemM3.ViewValue = RemM3.TagCaption(2) != "" ? RemM3.TagCaption(2) : "No";
            }
            RemM3.ViewCustomAttributes = "";

            // studentSignature
            if (!IsNull(studentSignature.Upload.DbValue)) {
                studentSignature.ViewValue = RawUrlEncode(int_Attendance_ID.CurrentValue);
                studentSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])studentSignature.Upload.DbValue));
            } else {
                studentSignature.ViewValue = "";
            }
            studentSignature.ViewCustomAttributes = "";

            // SMSReminder1
            if (ConvertToBool(SMSReminder1.CurrentValue)) {
                SMSReminder1.ViewValue = SMSReminder1.TagCaption(1) != "" ? SMSReminder1.TagCaption(1) : "Yes";
            } else {
                SMSReminder1.ViewValue = SMSReminder1.TagCaption(2) != "" ? SMSReminder1.TagCaption(2) : "No";
            }
            SMSReminder1.CellCssStyle += "text-align: center;";
            SMSReminder1.ViewCustomAttributes = "";

            // SMSReminder2
            if (ConvertToBool(SMSReminder2.CurrentValue)) {
                SMSReminder2.ViewValue = SMSReminder2.TagCaption(1) != "" ? SMSReminder2.TagCaption(1) : "Yes";
            } else {
                SMSReminder2.ViewValue = SMSReminder2.TagCaption(2) != "" ? SMSReminder2.TagCaption(2) : "No";
            }
            SMSReminder2.ViewCustomAttributes = "";

            // SMSReminder3
            if (ConvertToBool(SMSReminder3.CurrentValue)) {
                SMSReminder3.ViewValue = SMSReminder3.TagCaption(1) != "" ? SMSReminder3.TagCaption(1) : "Yes";
            } else {
                SMSReminder3.ViewValue = SMSReminder3.TagCaption(2) != "" ? SMSReminder3.TagCaption(2) : "No";
            }
            SMSReminder3.ViewCustomAttributes = "";

            // VoiceReminder1
            if (ConvertToBool(VoiceReminder1.CurrentValue)) {
                VoiceReminder1.ViewValue = VoiceReminder1.TagCaption(1) != "" ? VoiceReminder1.TagCaption(1) : "Yes";
            } else {
                VoiceReminder1.ViewValue = VoiceReminder1.TagCaption(2) != "" ? VoiceReminder1.TagCaption(2) : "No";
            }
            VoiceReminder1.ViewCustomAttributes = "";

            // VoiceReminder2
            if (ConvertToBool(VoiceReminder2.CurrentValue)) {
                VoiceReminder2.ViewValue = VoiceReminder2.TagCaption(1) != "" ? VoiceReminder2.TagCaption(1) : "Yes";
            } else {
                VoiceReminder2.ViewValue = VoiceReminder2.TagCaption(2) != "" ? VoiceReminder2.TagCaption(2) : "No";
            }
            VoiceReminder2.ViewCustomAttributes = "";

            // VoiceReminder3
            if (ConvertToBool(VoiceReminder3.CurrentValue)) {
                VoiceReminder3.ViewValue = VoiceReminder3.TagCaption(1) != "" ? VoiceReminder3.TagCaption(1) : "Yes";
            } else {
                VoiceReminder3.ViewValue = VoiceReminder3.TagCaption(2) != "" ? VoiceReminder3.TagCaption(2) : "No";
            }
            VoiceReminder3.ViewCustomAttributes = "";

            // strParentName
            strParentName.ViewValue = ConvertToString(strParentName.CurrentValue); // DN
            strParentName.ViewCustomAttributes = "";

            // strParentState
            strParentState.ViewValue = ConvertToString(strParentState.CurrentValue); // DN
            strParentState.ViewCustomAttributes = "";

            // strParentLicenseNumber
            strParentLicenseNumber.ViewValue = ConvertToString(strParentLicenseNumber.CurrentValue); // DN
            strParentLicenseNumber.ViewCustomAttributes = "";

            // CRSS_ID
            CRSS_ID.ViewValue = CRSS_ID.CurrentValue;
            CRSS_ID.ViewValue = FormatNumber(CRSS_ID.ViewValue, CRSS_ID.FormatPattern);
            CRSS_ID.ViewCustomAttributes = "";

            // str_CR_Number
            curVal = ConvertToString(str_CR_Number.CurrentValue);
            if (!Empty(curVal)) {
                if (str_CR_Number.Lookup != null && IsDictionary(str_CR_Number.Lookup?.Options) && str_CR_Number.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    str_CR_Number.ViewValue = str_CR_Number.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[str_CR_Number]", "=", str_CR_Number.CurrentValue, DataType.String, "");
                    sqlWrk = str_CR_Number.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && str_CR_Number.Lookup != null) { // Lookup values found
                        var listwrk = str_CR_Number.Lookup?.RenderViewRow(rswrk[0]);
                        str_CR_Number.ViewValue = str_CR_Number.HighlightLookup(ConvertToString(rswrk[0]), str_CR_Number.DisplayValue(listwrk));
                    } else {
                        str_CR_Number.ViewValue = str_CR_Number.CurrentValue;
                    }
                }
            } else {
                str_CR_Number.ViewValue = DbNullValue;
            }
            str_CR_Number.ViewCustomAttributes = "";

            // int_Attendance_ID
            int_Attendance_ID.HrefValue = "";
            int_Attendance_ID.TooltipValue = "";

            // int_Student_ID
            int_Student_ID.HrefValue = "";
            int_Student_ID.TooltipValue = "";

            // str_FullName
            str_FullName.HrefValue = "";
            str_FullName.TooltipValue = "";

            // str_Username
            str_Username.HrefValue = "";
            str_Username.TooltipValue = "";

            // int_CR_ID
            int_CR_ID.HrefValue = "";
            int_CR_ID.TooltipValue = "";

            // int_CRSession_ID
            int_CRSession_ID.HrefValue = "";
            int_CRSession_ID.TooltipValue = "";

            // Is_All_Attend
            Is_All_Attend.HrefValue = "";
            Is_All_Attend.TooltipValue = "";

            // idnumber
            idnumber.HrefValue = "";
            idnumber.TooltipValue = "";

            // course_id
            course_id.HrefValue = "";
            course_id.TooltipValue = "";

            // str_Test_Score
            str_Test_Score.HrefValue = "";
            str_Test_Score.TooltipValue = "";

            // str_Notes
            str_Notes.HrefValue = "";
            str_Notes.TooltipValue = "";

            // bit_IsDeleted
            bit_IsDeleted.HrefValue = "";
            bit_IsDeleted.TooltipValue = "";

            // int_Created_BY
            int_Created_BY.HrefValue = "";
            int_Created_BY.TooltipValue = "";

            // int_Modified_BY
            int_Modified_BY.HrefValue = "";
            int_Modified_BY.TooltipValue = "";

            // date_Created
            date_Created.HrefValue = "";
            date_Created.TooltipValue = "";

            // date_Modified
            date_Modified.HrefValue = "";
            date_Modified.TooltipValue = "";

            // bit_IsMakeUP
            bit_IsMakeUP.HrefValue = "";
            bit_IsMakeUP.TooltipValue = "";

            // dec_Orginal_SessionID
            dec_Orginal_SessionID.HrefValue = "";
            dec_Orginal_SessionID.TooltipValue = "";

            // dec_CR_ID_For_Del
            dec_CR_ID_For_Del.HrefValue = "";
            dec_CR_ID_For_Del.TooltipValue = "";

            // int_Session_ID_For_Del
            int_Session_ID_For_Del.HrefValue = "";
            int_Session_ID_For_Del.TooltipValue = "";

            // RemM1
            RemM1.HrefValue = "";
            RemM1.TooltipValue = "";

            // RemM2
            RemM2.HrefValue = "";
            RemM2.TooltipValue = "";

            // RemM3
            RemM3.HrefValue = "";
            RemM3.TooltipValue = "";

            // studentSignature
            if (!IsNull(studentSignature.Upload.DbValue)) {
                studentSignature.HrefValue = AppPath(GetFileUploadUrl(studentSignature, ConvertToString(RawUrlEncode(int_Attendance_ID.CurrentValue)))); // DN
                studentSignature.LinkAttrs["target"] = "";
                if (studentSignature.IsBlobImage && Empty(studentSignature.LinkAttrs["target"]))
                    studentSignature.LinkAttrs["target"] = "_blank";
                if (IsExport())
                    studentSignature.HrefValue = FullUrl(ConvertToString(studentSignature.HrefValue), "href");
            } else {
                studentSignature.HrefValue = "";
            }
            studentSignature.ExportHrefValue = GetFileUploadUrl(studentSignature, ConvertToString(RawUrlEncode(int_Attendance_ID.CurrentValue)));
            studentSignature.TooltipValue = "";

            // SMSReminder1
            SMSReminder1.HrefValue = "";
            SMSReminder1.TooltipValue = "";

            // SMSReminder2
            SMSReminder2.HrefValue = "";
            SMSReminder2.TooltipValue = "";

            // SMSReminder3
            SMSReminder3.HrefValue = "";
            SMSReminder3.TooltipValue = "";

            // VoiceReminder1
            VoiceReminder1.HrefValue = "";
            VoiceReminder1.TooltipValue = "";

            // VoiceReminder2
            VoiceReminder2.HrefValue = "";
            VoiceReminder2.TooltipValue = "";

            // VoiceReminder3
            VoiceReminder3.HrefValue = "";
            VoiceReminder3.TooltipValue = "";

            // strParentName
            strParentName.HrefValue = "";
            strParentName.TooltipValue = "";

            // strParentState
            strParentState.HrefValue = "";
            strParentState.TooltipValue = "";

            // strParentLicenseNumber
            strParentLicenseNumber.HrefValue = "";
            strParentLicenseNumber.TooltipValue = "";

            // CRSS_ID
            CRSS_ID.HrefValue = "";
            CRSS_ID.TooltipValue = "";

            // str_CR_Number
            str_CR_Number.HrefValue = "";
            str_CR_Number.TooltipValue = "";

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

            // int_Attendance_ID
            int_Attendance_ID.SetupEditAttributes();
            int_Attendance_ID.EditValue = int_Attendance_ID.CurrentValue;
            int_Attendance_ID.ViewCustomAttributes = "";

            // int_Student_ID
            int_Student_ID.SetupEditAttributes();
            int_Student_ID.EditValue = int_Student_ID.CurrentValue; // DN
            int_Student_ID.PlaceHolder = RemoveHtml(int_Student_ID.Caption);
            if (!Empty(int_Student_ID.EditValue) && IsNumeric(int_Student_ID.EditValue))
                int_Student_ID.EditValue = FormatNumber(int_Student_ID.EditValue, null);

            // str_FullName
            str_FullName.SetupEditAttributes();
            str_FullName.EditValue = ConvertToString(str_FullName.CurrentValue); // DN
            str_FullName.ViewCustomAttributes = "";

            // str_Username
            str_Username.SetupEditAttributes();
            curVal = ConvertToString(str_Username.CurrentValue);
            if (!Empty(curVal)) {
                if (str_Username.Lookup != null && IsDictionary(str_Username.Lookup?.Options) && str_Username.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    str_Username.EditValue = str_Username.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[str_Username]", "=", str_Username.CurrentValue, DataType.String, "");
                    sqlWrk = str_Username.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && str_Username.Lookup != null) { // Lookup values found
                        var listwrk = str_Username.Lookup?.RenderViewRow(rswrk[0]);
                        str_Username.EditValue = str_Username.HighlightLookup(ConvertToString(rswrk[0]), str_Username.DisplayValue(listwrk));
                    } else {
                        str_Username.EditValue = str_Username.CurrentValue;
                    }
                }
            } else {
                str_Username.EditValue = DbNullValue;
            }
            str_Username.ViewCustomAttributes = "";

            // int_CR_ID
            int_CR_ID.SetupEditAttributes();
            int_CR_ID.EditValue = int_CR_ID.CurrentValue;
            int_CR_ID.EditValue = FormatNumber(int_CR_ID.EditValue, int_CR_ID.FormatPattern);
            int_CR_ID.ViewCustomAttributes = "";

            // int_CRSession_ID
            int_CRSession_ID.SetupEditAttributes();
            int_CRSession_ID.EditValue = int_CRSession_ID.CurrentValue;
            int_CRSession_ID.EditValue = FormatNumber(int_CRSession_ID.EditValue, int_CRSession_ID.FormatPattern);
            int_CRSession_ID.ViewCustomAttributes = "";

            // Is_All_Attend
            Is_All_Attend.EditValue = Is_All_Attend.Options(false);
            Is_All_Attend.PlaceHolder = RemoveHtml(Is_All_Attend.Caption);

            // idnumber
            idnumber.SetupEditAttributes();
            idnumber.EditValue = ConvertToString(idnumber.CurrentValue); // DN
            curVal = ConvertToString(idnumber.CurrentValue);
            if (!Empty(curVal)) {
                if (idnumber.Lookup != null && IsDictionary(idnumber.Lookup?.Options) && idnumber.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    idnumber.EditValue = idnumber.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[course]", "=", idnumber.CurrentValue, DataType.String, "");
                    sqlWrk = idnumber.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && idnumber.Lookup != null) { // Lookup values found
                        var listwrk = idnumber.Lookup?.RenderViewRow(rswrk[0]);
                        idnumber.EditValue = idnumber.HighlightLookup(ConvertToString(rswrk[0]), idnumber.DisplayValue(listwrk));
                    } else {
                        idnumber.EditValue = idnumber.CurrentValue;
                    }
                }
            } else {
                idnumber.EditValue = DbNullValue;
            }
            idnumber.ViewCustomAttributes = "";

            // course_id
            course_id.SetupEditAttributes();
            course_id.EditValue = course_id.CurrentValue; // DN
            course_id.PlaceHolder = RemoveHtml(course_id.Caption);
            if (!Empty(course_id.EditValue) && IsNumeric(course_id.EditValue))
                course_id.EditValue = FormatNumber(course_id.EditValue, null);

            // str_Test_Score
            str_Test_Score.SetupEditAttributes();
            if (!str_Test_Score.Raw)
                str_Test_Score.CurrentValue = HtmlDecode(str_Test_Score.CurrentValue);
            str_Test_Score.EditValue = HtmlEncode(str_Test_Score.CurrentValue);
            str_Test_Score.PlaceHolder = RemoveHtml(str_Test_Score.Caption);

            // str_Notes
            str_Notes.SetupEditAttributes();
            if (!str_Notes.Raw)
                str_Notes.CurrentValue = HtmlDecode(str_Notes.CurrentValue);
            str_Notes.EditValue = HtmlEncode(str_Notes.CurrentValue);
            str_Notes.PlaceHolder = RemoveHtml(str_Notes.Caption);

            // bit_IsDeleted
            bit_IsDeleted.EditValue = bit_IsDeleted.Options(false);
            bit_IsDeleted.PlaceHolder = RemoveHtml(bit_IsDeleted.Caption);

            // int_Created_BY
            int_Created_BY.SetupEditAttributes();
            int_Created_BY.EditValue = int_Created_BY.CurrentValue; // DN
            int_Created_BY.PlaceHolder = RemoveHtml(int_Created_BY.Caption);
            if (!Empty(int_Created_BY.EditValue) && IsNumeric(int_Created_BY.EditValue))
                int_Created_BY.EditValue = FormatNumber(int_Created_BY.EditValue, null);

            // int_Modified_BY

            // date_Created
            date_Created.SetupEditAttributes();
            date_Created.EditValue = FormatDateTime(date_Created.CurrentValue, date_Created.FormatPattern); // DN
            date_Created.PlaceHolder = RemoveHtml(date_Created.Caption);

            // date_Modified

            // bit_IsMakeUP
            bit_IsMakeUP.EditValue = bit_IsMakeUP.Options(false);
            bit_IsMakeUP.PlaceHolder = RemoveHtml(bit_IsMakeUP.Caption);

            // dec_Orginal_SessionID
            dec_Orginal_SessionID.SetupEditAttributes();
            dec_Orginal_SessionID.EditValue = dec_Orginal_SessionID.CurrentValue; // DN
            dec_Orginal_SessionID.PlaceHolder = RemoveHtml(dec_Orginal_SessionID.Caption);
            if (!Empty(dec_Orginal_SessionID.EditValue) && IsNumeric(dec_Orginal_SessionID.EditValue))
                dec_Orginal_SessionID.EditValue = FormatNumber(dec_Orginal_SessionID.EditValue, null);

            // dec_CR_ID_For_Del
            dec_CR_ID_For_Del.SetupEditAttributes();
            dec_CR_ID_For_Del.EditValue = dec_CR_ID_For_Del.CurrentValue; // DN
            dec_CR_ID_For_Del.PlaceHolder = RemoveHtml(dec_CR_ID_For_Del.Caption);
            if (!Empty(dec_CR_ID_For_Del.EditValue) && IsNumeric(dec_CR_ID_For_Del.EditValue))
                dec_CR_ID_For_Del.EditValue = FormatNumber(dec_CR_ID_For_Del.EditValue, null);

            // int_Session_ID_For_Del
            int_Session_ID_For_Del.SetupEditAttributes();
            int_Session_ID_For_Del.EditValue = int_Session_ID_For_Del.CurrentValue; // DN
            int_Session_ID_For_Del.PlaceHolder = RemoveHtml(int_Session_ID_For_Del.Caption);
            if (!Empty(int_Session_ID_For_Del.EditValue) && IsNumeric(int_Session_ID_For_Del.EditValue))
                int_Session_ID_For_Del.EditValue = FormatNumber(int_Session_ID_For_Del.EditValue, null);

            // RemM1
            RemM1.EditValue = RemM1.Options(false);
            RemM1.PlaceHolder = RemoveHtml(RemM1.Caption);

            // RemM2
            RemM2.EditValue = RemM2.Options(false);
            RemM2.PlaceHolder = RemoveHtml(RemM2.Caption);

            // RemM3
            RemM3.EditValue = RemM3.Options(false);
            RemM3.PlaceHolder = RemoveHtml(RemM3.Caption);

            // studentSignature
            studentSignature.SetupEditAttributes();
            if (!IsNull(studentSignature.Upload.DbValue)) {
                studentSignature.EditValue = RawUrlEncode(int_Attendance_ID.CurrentValue);
                studentSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])studentSignature.Upload.DbValue));
            } else {
                studentSignature.EditValue = "";
            }

            // SMSReminder1
            SMSReminder1.EditValue = SMSReminder1.Options(false);
            SMSReminder1.PlaceHolder = RemoveHtml(SMSReminder1.Caption);

            // SMSReminder2
            SMSReminder2.EditValue = SMSReminder2.Options(false);
            SMSReminder2.PlaceHolder = RemoveHtml(SMSReminder2.Caption);

            // SMSReminder3
            SMSReminder3.EditValue = SMSReminder3.Options(false);
            SMSReminder3.PlaceHolder = RemoveHtml(SMSReminder3.Caption);

            // VoiceReminder1
            VoiceReminder1.EditValue = VoiceReminder1.Options(false);
            VoiceReminder1.PlaceHolder = RemoveHtml(VoiceReminder1.Caption);

            // VoiceReminder2
            VoiceReminder2.EditValue = VoiceReminder2.Options(false);
            VoiceReminder2.PlaceHolder = RemoveHtml(VoiceReminder2.Caption);

            // VoiceReminder3
            VoiceReminder3.EditValue = VoiceReminder3.Options(false);
            VoiceReminder3.PlaceHolder = RemoveHtml(VoiceReminder3.Caption);

            // strParentName
            strParentName.SetupEditAttributes();
            if (!strParentName.Raw)
                strParentName.CurrentValue = HtmlDecode(strParentName.CurrentValue);
            strParentName.EditValue = HtmlEncode(strParentName.CurrentValue);
            strParentName.PlaceHolder = RemoveHtml(strParentName.Caption);

            // strParentState
            strParentState.SetupEditAttributes();
            if (!strParentState.Raw)
                strParentState.CurrentValue = HtmlDecode(strParentState.CurrentValue);
            strParentState.EditValue = HtmlEncode(strParentState.CurrentValue);
            strParentState.PlaceHolder = RemoveHtml(strParentState.Caption);

            // strParentLicenseNumber
            strParentLicenseNumber.SetupEditAttributes();
            if (!strParentLicenseNumber.Raw)
                strParentLicenseNumber.CurrentValue = HtmlDecode(strParentLicenseNumber.CurrentValue);
            strParentLicenseNumber.EditValue = HtmlEncode(strParentLicenseNumber.CurrentValue);
            strParentLicenseNumber.PlaceHolder = RemoveHtml(strParentLicenseNumber.Caption);

            // CRSS_ID
            CRSS_ID.SetupEditAttributes();
            CRSS_ID.EditValue = CRSS_ID.CurrentValue; // DN
            CRSS_ID.PlaceHolder = RemoveHtml(CRSS_ID.Caption);
            if (!Empty(CRSS_ID.EditValue) && IsNumeric(CRSS_ID.EditValue))
                CRSS_ID.EditValue = FormatNumber(CRSS_ID.EditValue, null);

            // str_CR_Number
            str_CR_Number.SetupEditAttributes();
            curVal = ConvertToString(str_CR_Number.CurrentValue);
            if (!Empty(curVal)) {
                if (str_CR_Number.Lookup != null && IsDictionary(str_CR_Number.Lookup?.Options) && str_CR_Number.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    str_CR_Number.EditValue = str_CR_Number.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[str_CR_Number]", "=", str_CR_Number.CurrentValue, DataType.String, "");
                    sqlWrk = str_CR_Number.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && str_CR_Number.Lookup != null) { // Lookup values found
                        var listwrk = str_CR_Number.Lookup?.RenderViewRow(rswrk[0]);
                        str_CR_Number.EditValue = str_CR_Number.HighlightLookup(ConvertToString(rswrk[0]), str_CR_Number.DisplayValue(listwrk));
                    } else {
                        str_CR_Number.EditValue = str_CR_Number.CurrentValue;
                    }
                }
            } else {
                str_CR_Number.EditValue = DbNullValue;
            }
            str_CR_Number.ViewCustomAttributes = "";

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
                        doc.ExportCaption(int_Attendance_ID);
                        doc.ExportCaption(int_Student_ID);
                        doc.ExportCaption(str_FullName);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(int_CR_ID);
                        doc.ExportCaption(int_CRSession_ID);
                        doc.ExportCaption(Is_All_Attend);
                        doc.ExportCaption(idnumber);
                        doc.ExportCaption(course_id);
                        doc.ExportCaption(str_Test_Score);
                        doc.ExportCaption(str_Notes);
                        doc.ExportCaption(bit_IsDeleted);
                        doc.ExportCaption(int_Created_BY);
                        doc.ExportCaption(int_Modified_BY);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(bit_IsMakeUP);
                        doc.ExportCaption(dec_Orginal_SessionID);
                        doc.ExportCaption(dec_CR_ID_For_Del);
                        doc.ExportCaption(int_Session_ID_For_Del);
                        doc.ExportCaption(RemM1);
                        doc.ExportCaption(RemM2);
                        doc.ExportCaption(RemM3);
                        doc.ExportCaption(studentSignature);
                        doc.ExportCaption(SMSReminder1);
                        doc.ExportCaption(SMSReminder2);
                        doc.ExportCaption(SMSReminder3);
                        doc.ExportCaption(VoiceReminder1);
                        doc.ExportCaption(VoiceReminder2);
                        doc.ExportCaption(VoiceReminder3);
                        doc.ExportCaption(strParentName);
                        doc.ExportCaption(strParentState);
                        doc.ExportCaption(strParentLicenseNumber);
                        doc.ExportCaption(CRSS_ID);
                    } else {
                        doc.ExportCaption(int_Attendance_ID);
                        doc.ExportCaption(int_Student_ID);
                        doc.ExportCaption(str_FullName);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(int_CR_ID);
                        doc.ExportCaption(int_CRSession_ID);
                        doc.ExportCaption(Is_All_Attend);
                        doc.ExportCaption(idnumber);
                        doc.ExportCaption(course_id);
                        doc.ExportCaption(str_Test_Score);
                        doc.ExportCaption(str_Notes);
                        doc.ExportCaption(bit_IsDeleted);
                        doc.ExportCaption(int_Created_BY);
                        doc.ExportCaption(int_Modified_BY);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(bit_IsMakeUP);
                        doc.ExportCaption(dec_Orginal_SessionID);
                        doc.ExportCaption(dec_CR_ID_For_Del);
                        doc.ExportCaption(int_Session_ID_For_Del);
                        doc.ExportCaption(RemM1);
                        doc.ExportCaption(RemM2);
                        doc.ExportCaption(RemM3);
                        doc.ExportCaption(SMSReminder1);
                        doc.ExportCaption(SMSReminder2);
                        doc.ExportCaption(SMSReminder3);
                        doc.ExportCaption(VoiceReminder1);
                        doc.ExportCaption(VoiceReminder2);
                        doc.ExportCaption(VoiceReminder3);
                        doc.ExportCaption(strParentName);
                        doc.ExportCaption(strParentState);
                        doc.ExportCaption(strParentLicenseNumber);
                        doc.ExportCaption(CRSS_ID);
                        doc.ExportCaption(str_CR_Number);
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
                            await doc.ExportField(int_Attendance_ID);
                            await doc.ExportField(int_Student_ID);
                            await doc.ExportField(str_FullName);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(int_CR_ID);
                            await doc.ExportField(int_CRSession_ID);
                            await doc.ExportField(Is_All_Attend);
                            await doc.ExportField(idnumber);
                            await doc.ExportField(course_id);
                            await doc.ExportField(str_Test_Score);
                            await doc.ExportField(str_Notes);
                            await doc.ExportField(bit_IsDeleted);
                            await doc.ExportField(int_Created_BY);
                            await doc.ExportField(int_Modified_BY);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(bit_IsMakeUP);
                            await doc.ExportField(dec_Orginal_SessionID);
                            await doc.ExportField(dec_CR_ID_For_Del);
                            await doc.ExportField(int_Session_ID_For_Del);
                            await doc.ExportField(RemM1);
                            await doc.ExportField(RemM2);
                            await doc.ExportField(RemM3);
                            await doc.ExportField(studentSignature);
                            await doc.ExportField(SMSReminder1);
                            await doc.ExportField(SMSReminder2);
                            await doc.ExportField(SMSReminder3);
                            await doc.ExportField(VoiceReminder1);
                            await doc.ExportField(VoiceReminder2);
                            await doc.ExportField(VoiceReminder3);
                            await doc.ExportField(strParentName);
                            await doc.ExportField(strParentState);
                            await doc.ExportField(strParentLicenseNumber);
                            await doc.ExportField(CRSS_ID);
                        } else {
                            await doc.ExportField(int_Attendance_ID);
                            await doc.ExportField(int_Student_ID);
                            await doc.ExportField(str_FullName);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(int_CR_ID);
                            await doc.ExportField(int_CRSession_ID);
                            await doc.ExportField(Is_All_Attend);
                            await doc.ExportField(idnumber);
                            await doc.ExportField(course_id);
                            await doc.ExportField(str_Test_Score);
                            await doc.ExportField(str_Notes);
                            await doc.ExportField(bit_IsDeleted);
                            await doc.ExportField(int_Created_BY);
                            await doc.ExportField(int_Modified_BY);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(bit_IsMakeUP);
                            await doc.ExportField(dec_Orginal_SessionID);
                            await doc.ExportField(dec_CR_ID_For_Del);
                            await doc.ExportField(int_Session_ID_For_Del);
                            await doc.ExportField(RemM1);
                            await doc.ExportField(RemM2);
                            await doc.ExportField(RemM3);
                            await doc.ExportField(SMSReminder1);
                            await doc.ExportField(SMSReminder2);
                            await doc.ExportField(SMSReminder3);
                            await doc.ExportField(VoiceReminder1);
                            await doc.ExportField(VoiceReminder2);
                            await doc.ExportField(VoiceReminder3);
                            await doc.ExportField(strParentName);
                            await doc.ExportField(strParentState);
                            await doc.ExportField(strParentLicenseNumber);
                            await doc.ExportField(CRSS_ID);
                            await doc.ExportField(str_CR_Number);
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
            if (SameText(fldparm, "studentSignature")) {
                fldName = "studentSignature";
            } else {
                return JsonBoolResult.FalseResult; // Incorrect field
            }

            // Set up key values
            if (keys.Length == 1) {
                int_Attendance_ID.CurrentValue = keys[0];
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
        public async Task WriteAuditTrailLog(string log) => await WriteAuditTrailAsync(CurrentUser(), log, "tblCRAttendance");

        // Write audit trail (add page)
        public async Task WriteAuditTrailOnAdd(IDictionary<string, object> rs)
        {
            if (!AuditTrailOnAdd)
                return;
            string table = "tblCRAttendance";

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
                    await WriteAuditTrailAsync(usr, "A", table, fldname, key, "", newvalue);
                }
            }
        }

        // Write audit trail (edit page)
        public async Task WriteAuditTrailOnEdit(IDictionary<string, object> rsold, IDictionary<string, object> rsnew)
        {
            if (!AuditTrailOnEdit)
                return;
            string table = "tblCRAttendance";

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
            string table = "tblCRAttendance";

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
                    await WriteAuditTrailAsync(usr, "D", table, fldname, key, oldvalue);
                }
            }
        }

        // Table level events

        // Table Load event
        public void TableLoad()
        {
            // Enter your code here
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
            //Log("Row Updated");
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
