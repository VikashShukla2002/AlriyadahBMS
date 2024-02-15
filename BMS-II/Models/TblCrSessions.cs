namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblCrSessions
    /// </summary>
    [MaybeNull]
    public static TblCrSessions tblCrSessions
    {
        get => HttpData.Resolve<TblCrSessions>("tblCRSessions");
        set => HttpData["tblCRSessions"] = value;
    }

    /// <summary>
    /// Table class for tblCRSessions
    /// </summary>
    public class TblCrSessions : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> int_CRSession_ID;

        public readonly DbField<SqlDbType> str_CR_Number;

        public readonly DbField<SqlDbType> int_Status;

        public readonly DbField<SqlDbType> int_Staff_Id;

        public readonly DbField<SqlDbType> Instructor;

        public readonly DbField<SqlDbType> int_Location_Id;

        public readonly DbField<SqlDbType> Location;

        public readonly DbField<SqlDbType> int_Session_ID;

        public readonly DbField<SqlDbType> str_Session_Date;

        public readonly DbField<SqlDbType> int_Day_ID;

        public readonly DbField<SqlDbType> str_Day_Name;

        public readonly DbField<SqlDbType> str_Time_Start;

        public readonly DbField<SqlDbType> str_Time_End;

        public readonly DbField<SqlDbType> date_Created;

        public readonly DbField<SqlDbType> int_CR_Id;

        public readonly DbField<SqlDbType> str_Notes;

        public readonly DbField<SqlDbType> int_Created_By;

        public readonly DbField<SqlDbType> int_Modified_By;

        public readonly DbField<SqlDbType> date_Modified;

        public readonly DbField<SqlDbType> bit_IsDeleted;

        public readonly DbField<SqlDbType> str_Session_Notes;

        public readonly DbField<SqlDbType> is_Rescheduled;

        public readonly DbField<SqlDbType> instructorSignature;

        public readonly DbField<SqlDbType> IsZoomMeet;

        public readonly DbField<SqlDbType> str_ZoomHostUrl;

        public readonly DbField<SqlDbType> str_ZoomUserUrl;

        public readonly DbField<SqlDbType> CR_Row_Index;

        public readonly DbField<SqlDbType> CRSS_ID;

        public readonly DbField<SqlDbType> int_Student_Id;

        public readonly DbField<SqlDbType> str_Username;

        public readonly DbField<SqlDbType> str_Status;

        // Constructor
        public TblCrSessions()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "tblCRSessions";
            Name = "tblCRSessions";
            Type = "TABLE";
            UpdateTable = "dbo.tblCRSessions"; // Update Table
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
                HtmlTag = "NO",
                InputTextType = "text",
                IsAutoIncrement = true, // Autoincrement field
                IsPrimaryKey = true, // Primary key field
                Nullable = false, // NOT NULL field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "int_CRSession_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CRSession_ID", int_CRSession_ID);

            // str_CR_Number
            str_CR_Number = new (this, "x_str_CR_Number", 202, SqlDbType.NVarChar) {
                Name = "str_CR_Number",
                Expression = "[str_CR_Number]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_CR_Number]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CR_Number]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "str_CR_Number", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CR_Number", str_CR_Number);

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
                CustomMessage = Language.FieldPhrase("tblCRSessions", "int_Status", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Status", int_Status);

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
                CustomMessage = Language.FieldPhrase("tblCRSessions", "int_Staff_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Staff_Id", int_Staff_Id);

            // Instructor
            Instructor = new (this, "x_Instructor", 202, SqlDbType.NVarChar) {
                Name = "Instructor",
                Expression = "[Instructor]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Instructor]",
                DateTimeFormat = -1,
                VirtualExpression = "[Instructor]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "Instructor", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Instructor", Instructor);

            // int_Location_Id
            int_Location_Id = new (this, "x_int_Location_Id", 3, SqlDbType.Int) {
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
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "int_Location_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Location_Id", int_Location_Id);

            // Location
            Location = new (this, "x_Location", 202, SqlDbType.NVarChar) {
                Name = "Location",
                Expression = "[Location]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Location]",
                DateTimeFormat = -1,
                VirtualExpression = "[Location]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "Location", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Location", Location);

            // int_Session_ID
            int_Session_ID = new (this, "x_int_Session_ID", 3, SqlDbType.Int) {
                Name = "int_Session_ID",
                Expression = "[int_Session_ID]",
                BasicSearchExpression = "CAST([int_Session_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Session_ID]",
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
                CustomMessage = Language.FieldPhrase("tblCRSessions", "int_Session_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Session_ID", int_Session_ID);

            // str_Session_Date
            str_Session_Date = new (this, "x_str_Session_Date", 200, SqlDbType.VarChar) {
                Name = "str_Session_Date",
                Expression = "[str_Session_Date]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Session_Date]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Session_Date]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "str_Session_Date", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Session_Date", str_Session_Date);

            // int_Day_ID
            int_Day_ID = new (this, "x_int_Day_ID", 3, SqlDbType.Int) {
                Name = "int_Day_ID",
                Expression = "[int_Day_ID]",
                BasicSearchExpression = "CAST([int_Day_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Day_ID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "int_Day_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Day_ID", int_Day_ID);

            // str_Day_Name
            str_Day_Name = new (this, "x_str_Day_Name", 200, SqlDbType.VarChar) {
                Name = "str_Day_Name",
                Expression = "[str_Day_Name]",
                BasicSearchExpression = "[str_Day_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Day_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "str_Day_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Day_Name", str_Day_Name);

            // str_Time_Start
            str_Time_Start = new (this, "x_str_Time_Start", 200, SqlDbType.VarChar) {
                Name = "str_Time_Start",
                Expression = "[str_Time_Start]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Time_Start]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Time_Start]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "str_Time_Start", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Time_Start", str_Time_Start);

            // str_Time_End
            str_Time_End = new (this, "x_str_Time_End", 200, SqlDbType.VarChar) {
                Name = "str_Time_End",
                Expression = "[str_Time_End]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Time_End]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Time_End]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "str_Time_End", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Time_End", str_Time_End);

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
                CustomMessage = Language.FieldPhrase("tblCRSessions", "date_Created", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Created", date_Created);

            // int_CR_Id
            int_CR_Id = new (this, "x_int_CR_Id", 3, SqlDbType.Int) {
                Name = "int_CR_Id",
                Expression = "[int_CR_Id]",
                BasicSearchExpression = "CAST([int_CR_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_CR_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "int_CR_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CR_Id", int_CR_Id);

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
                CustomMessage = Language.FieldPhrase("tblCRSessions", "str_Notes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Notes", str_Notes);

            // int_Created_By
            int_Created_By = new (this, "x_int_Created_By", 3, SqlDbType.Int) {
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
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "int_Created_By", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Created_By", int_Created_By);

            // int_Modified_By
            int_Modified_By = new (this, "x_int_Modified_By", 3, SqlDbType.Int) {
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "int_Modified_By", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Modified_By", int_Modified_By);

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
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "date_Modified", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Modified", date_Modified);

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
                CustomMessage = Language.FieldPhrase("tblCRSessions", "bit_IsDeleted", "CustomMsg"),
                IsUpload = false
            };
            bit_IsDeleted.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IsDeleted, "tblCRSessions", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsDeleted, "tblCRSessions", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IsDeleted, "tblCRSessions", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_IsDeleted", bit_IsDeleted);

            // str_Session_Notes
            str_Session_Notes = new (this, "x_str_Session_Notes", 202, SqlDbType.NVarChar) {
                Name = "str_Session_Notes",
                Expression = "[str_Session_Notes]",
                BasicSearchExpression = "[str_Session_Notes]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Session_Notes]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "str_Session_Notes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Session_Notes", str_Session_Notes);

            // is_Rescheduled
            is_Rescheduled = new (this, "x_is_Rescheduled", 3, SqlDbType.Int) {
                Name = "is_Rescheduled",
                Expression = "[is_Rescheduled]",
                BasicSearchExpression = "CAST([is_Rescheduled] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[is_Rescheduled]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "is_Rescheduled", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("is_Rescheduled", is_Rescheduled);

            // instructorSignature
            instructorSignature = new (this, "x_instructorSignature", 205, SqlDbType.Image) {
                Name = "instructorSignature",
                Expression = "[instructorSignature]",
                BasicSearchExpression = "[instructorSignature]",
                DateTimeFormat = -1,
                VirtualExpression = "[instructorSignature]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "FILE",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "instructorSignature", "CustomMsg"),
                IsUpload = true
            };
            Fields.Add("instructorSignature", instructorSignature);

            // IsZoomMeet
            IsZoomMeet = new (this, "x_IsZoomMeet", 11, SqlDbType.Bit) {
                Name = "IsZoomMeet",
                Expression = "[IsZoomMeet]",
                BasicSearchExpression = "[IsZoomMeet]",
                DateTimeFormat = -1,
                VirtualExpression = "[IsZoomMeet]",
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
                CustomMessage = Language.FieldPhrase("tblCRSessions", "IsZoomMeet", "CustomMsg"),
                IsUpload = false
            };
            IsZoomMeet.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(IsZoomMeet, "tblCRSessions", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(IsZoomMeet, "tblCRSessions", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(IsZoomMeet, "tblCRSessions", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            IsZoomMeet.GetDefault = () => 0;
            Fields.Add("IsZoomMeet", IsZoomMeet);

            // str_ZoomHostUrl
            str_ZoomHostUrl = new (this, "x_str_ZoomHostUrl", 200, SqlDbType.VarChar) {
                Name = "str_ZoomHostUrl",
                Expression = "[str_ZoomHostUrl]",
                BasicSearchExpression = "[str_ZoomHostUrl]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_ZoomHostUrl]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "str_ZoomHostUrl", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_ZoomHostUrl", str_ZoomHostUrl);

            // str_ZoomUserUrl
            str_ZoomUserUrl = new (this, "x_str_ZoomUserUrl", 200, SqlDbType.VarChar) {
                Name = "str_ZoomUserUrl",
                Expression = "[str_ZoomUserUrl]",
                BasicSearchExpression = "[str_ZoomUserUrl]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_ZoomUserUrl]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "str_ZoomUserUrl", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_ZoomUserUrl", str_ZoomUserUrl);

            // CR_Row_Index
            CR_Row_Index = new (this, "x_CR_Row_Index", 20, SqlDbType.BigInt) {
                Name = "CR_Row_Index",
                Expression = "[CR_Row_Index]",
                BasicSearchExpression = "CAST([CR_Row_Index] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[CR_Row_Index]",
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
                CustomMessage = Language.FieldPhrase("tblCRSessions", "CR_Row_Index", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("CR_Row_Index", CR_Row_Index);

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
                CustomMessage = Language.FieldPhrase("tblCRSessions", "CRSS_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("CRSS_ID", CRSS_ID);

            // int_Student_Id
            int_Student_Id = new (this, "x_int_Student_Id", 3, SqlDbType.Int) {
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
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "int_Student_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Student_Id", int_Student_Id);

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
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "str_Username", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Username", str_Username);

            // str_Status
            str_Status = new (this, "x_str_Status", 202, SqlDbType.NVarChar) {
                Name = "str_Status",
                Expression = "[str_Status]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Status]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Status]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblCRSessions", "str_Status", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Status", str_Status);

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
            get => _sqlFrom ?? "dbo.tblCRSessions";
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
                int_CRSession_ID.SetDbValue(lastInsertedId);
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
            Dictionary<string, object> rscascade = new ();
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
                if (!rsaudit.ContainsKey("int_CRSession_ID"))
                    rsaudit.Add("int_CRSession_ID", rsold["int_CRSession_ID"]);
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
                int_CRSession_ID.DbValue = row["int_CRSession_ID"]; // Set DB value only
                str_CR_Number.DbValue = row["str_CR_Number"]; // Set DB value only
                int_Status.DbValue = row["int_Status"]; // Set DB value only
                int_Staff_Id.DbValue = row["int_Staff_Id"]; // Set DB value only
                Instructor.DbValue = row["Instructor"]; // Set DB value only
                int_Location_Id.DbValue = row["int_Location_Id"]; // Set DB value only
                Location.DbValue = row["Location"]; // Set DB value only
                int_Session_ID.DbValue = row["int_Session_ID"]; // Set DB value only
                str_Session_Date.DbValue = row["str_Session_Date"]; // Set DB value only
                int_Day_ID.DbValue = row["int_Day_ID"]; // Set DB value only
                str_Day_Name.DbValue = row["str_Day_Name"]; // Set DB value only
                str_Time_Start.DbValue = row["str_Time_Start"]; // Set DB value only
                str_Time_End.DbValue = row["str_Time_End"]; // Set DB value only
                date_Created.DbValue = row["date_Created"]; // Set DB value only
                int_CR_Id.DbValue = row["int_CR_Id"]; // Set DB value only
                str_Notes.DbValue = row["str_Notes"]; // Set DB value only
                int_Created_By.DbValue = row["int_Created_By"]; // Set DB value only
                int_Modified_By.DbValue = row["int_Modified_By"]; // Set DB value only
                date_Modified.DbValue = row["date_Modified"]; // Set DB value only
                bit_IsDeleted.DbValue = (ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"); // Set DB value only
                str_Session_Notes.DbValue = row["str_Session_Notes"]; // Set DB value only
                is_Rescheduled.DbValue = row["is_Rescheduled"]; // Set DB value only
                instructorSignature.Upload.DbValue = row["instructorSignature"];
                IsZoomMeet.DbValue = (ConvertToBool(row["IsZoomMeet"]) ? "1" : "0"); // Set DB value only
                str_ZoomHostUrl.DbValue = row["str_ZoomHostUrl"]; // Set DB value only
                str_ZoomUserUrl.DbValue = row["str_ZoomUserUrl"]; // Set DB value only
                CR_Row_Index.DbValue = row["CR_Row_Index"]; // Set DB value only
                CRSS_ID.DbValue = row["CRSS_ID"]; // Set DB value only
                int_Student_Id.DbValue = row["int_Student_Id"]; // Set DB value only
                str_Username.DbValue = row["str_Username"]; // Set DB value only
                str_Status.DbValue = row["str_Status"]; // Set DB value only
            } catch {}
        }

        public void DeleteUploadedFiles(Dictionary<string, object> row)
        {
            LoadDbValues(row);
        }

        // Record filter WHERE clause
        private string _sqlKeyFilter => "[int_CRSession_ID] = @int_CRSession_ID@";

        #pragma warning disable 168, 219
        // Get record filter as string
        public string GetRecordFilter(Dictionary<string, object>? row = null, bool current = false)
        {
            string keyFilter = _sqlKeyFilter;
            object? val = null, result = "";
            val = row?.TryGetValue("int_CRSession_ID", out result) ?? false
                ? result
                : !Empty(int_CRSession_ID.OldValue) && !current ? int_CRSession_ID.OldValue : int_CRSession_ID.CurrentValue;
            if (!IsNumeric(val))
                return "0=1"; // Invalid key
            if (val == null)
                return "0=1"; // Invalid key
            keyFilter = keyFilter.Replace("@int_CRSession_ID@", AdjustSql(val, DbId)); // Replace key value
            return keyFilter;
        }

        // Get record filter as Dictionary // DN
        public Dictionary<string, object>? GetRowFilterAsDictionary(IDictionary<string, object>? row = null)
        {
            Dictionary<string, object>? keyFilter = new ();
            object? val = null, result;
            val = row?.TryGetValue("int_CRSession_ID", out result) ?? false
                ? result
                : !Empty(int_CRSession_ID.OldValue) ? int_CRSession_ID.OldValue : int_CRSession_ID.CurrentValue;
            if (!IsNumeric(val))
                return null; // Invalid key
            if (Empty(val))
                return null; // Invalid key
            keyFilter.Add("int_CRSession_ID", val); // Add key value
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
                    return "TblCrSessionsList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "TblCrSessionsView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "TblCrSessionsEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "TblCrSessionsAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "TblCrSessionsList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "TblCrSessionsView",
                Config.ApiAddAction => "TblCrSessionsAdd",
                Config.ApiEditAction => "TblCrSessionsEdit",
                Config.ApiDeleteAction => "TblCrSessionsDelete",
                Config.ApiListAction => "TblCrSessionsList",
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
        public string ListUrl => "TblCrSessionsList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblCrSessionsView", parm);
            else
                url = KeyUrl("TblCrSessionsView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "TblCrSessionsAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "TblCrSessionsAdd?" + parm;
            else
                url = "TblCrSessionsAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("TblCrSessionsEdit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblCrSessionsList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("TblCrSessionsAdd", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblCrSessionsList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("TblCrSessionsDelete")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
            return url;
        }

        // Get primary key as JSON
        public string KeyToJson(bool htmlEncode = false)
        {
            string json = "";
            json += "\"int_CRSession_ID\":" + ConvertToJson(int_CRSession_ID.CurrentValue, "number", true);
            json = "{" + json + "}";
            if (htmlEncode)
                json = HtmlEncode(json);
            return json;
        }

        // Add key value to URL
        public string KeyUrl(string url, string parm = "") { // DN
            if (!IsNull(int_CRSession_ID.CurrentValue)) {
                url += "/" + int_CRSession_ID.CurrentValue;
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
            val = current ? ConvertToString(int_CRSession_ID.CurrentValue) ?? "" : ConvertToString(int_CRSession_ID.OldValue) ?? "";
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
            val = row?.TryGetValue("int_CRSession_ID", out result) ?? false ? ConvertToString(result) : null;
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
                    int_CRSession_ID.CurrentValue = keys[0];
                } else {
                    int_CRSession_ID.OldValue = keys[0];
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
                if (RouteValues.TryGetValue("int_CRSession_ID", out object? v0)) { // int_CRSession_ID // DN
                    key = UrlDecode(v0); // DN
                } else if (IsApi() && !Empty(keyValues)) {
                    key = keyValues[0];
                } else {
                    key = Param("int_CRSession_ID");
                }
                keysList.Add(key);
            }
            // Check keys
            foreach (var keys in keysList) {
                if (!IsNumeric(keys)) // int_CRSession_ID
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
                    int_CRSession_ID.CurrentValue = keys;
                else
                    int_CRSession_ID.OldValue = keys;
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
            int_CRSession_ID.SetDbValue(dr["int_CRSession_ID"]);
            str_CR_Number.SetDbValue(dr["str_CR_Number"]);
            int_Status.SetDbValue(dr["int_Status"]);
            int_Staff_Id.SetDbValue(dr["int_Staff_Id"]);
            Instructor.SetDbValue(dr["Instructor"]);
            int_Location_Id.SetDbValue(dr["int_Location_Id"]);
            Location.SetDbValue(dr["Location"]);
            int_Session_ID.SetDbValue(dr["int_Session_ID"]);
            str_Session_Date.SetDbValue(dr["str_Session_Date"]);
            int_Day_ID.SetDbValue(dr["int_Day_ID"]);
            str_Day_Name.SetDbValue(dr["str_Day_Name"]);
            str_Time_Start.SetDbValue(dr["str_Time_Start"]);
            str_Time_End.SetDbValue(dr["str_Time_End"]);
            date_Created.SetDbValue(dr["date_Created"]);
            int_CR_Id.SetDbValue(dr["int_CR_Id"]);
            str_Notes.SetDbValue(dr["str_Notes"]);
            int_Created_By.SetDbValue(dr["int_Created_By"]);
            int_Modified_By.SetDbValue(dr["int_Modified_By"]);
            date_Modified.SetDbValue(dr["date_Modified"]);
            bit_IsDeleted.SetDbValue(ConvertToBool(dr["bit_IsDeleted"]) ? "1" : "0");
            str_Session_Notes.SetDbValue(dr["str_Session_Notes"]);
            is_Rescheduled.SetDbValue(dr["is_Rescheduled"]);
            instructorSignature.Upload.DbValue = dr["instructorSignature"];
            IsZoomMeet.SetDbValue(ConvertToBool(dr["IsZoomMeet"]) ? "1" : "0");
            str_ZoomHostUrl.SetDbValue(dr["str_ZoomHostUrl"]);
            str_ZoomUserUrl.SetDbValue(dr["str_ZoomUserUrl"]);
            CR_Row_Index.SetDbValue(dr["CR_Row_Index"]);
            CRSS_ID.SetDbValue(dr["CRSS_ID"]);
            int_Student_Id.SetDbValue(dr["int_Student_Id"]);
            str_Username.SetDbValue(dr["str_Username"]);
            str_Status.SetDbValue(dr["str_Status"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "TblCrSessionsList";
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

            // int_CRSession_ID

            // str_CR_Number

            // int_Status

            // int_Staff_Id

            // Instructor

            // int_Location_Id

            // Location

            // int_Session_ID

            // str_Session_Date

            // int_Day_ID

            // str_Day_Name

            // str_Time_Start

            // str_Time_End

            // date_Created

            // int_CR_Id

            // str_Notes

            // int_Created_By

            // int_Modified_By

            // date_Modified

            // bit_IsDeleted

            // str_Session_Notes

            // is_Rescheduled

            // instructorSignature

            // IsZoomMeet

            // str_ZoomHostUrl

            // str_ZoomUserUrl

            // CR_Row_Index

            // CRSS_ID

            // int_Student_Id

            // str_Username

            // str_Status

            // int_CRSession_ID
            int_CRSession_ID.ViewValue = int_CRSession_ID.CurrentValue;
            int_CRSession_ID.ViewCustomAttributes = "";

            // str_CR_Number
            str_CR_Number.ViewValue = ConvertToString(str_CR_Number.CurrentValue); // DN
            str_CR_Number.ViewCustomAttributes = "";

            // int_Status
            int_Status.ViewValue = int_Status.CurrentValue;
            int_Status.ViewValue = FormatNumber(int_Status.ViewValue, int_Status.FormatPattern);
            int_Status.ViewCustomAttributes = "";

            // int_Staff_Id
            int_Staff_Id.ViewValue = int_Staff_Id.CurrentValue;
            int_Staff_Id.ViewValue = FormatNumber(int_Staff_Id.ViewValue, int_Staff_Id.FormatPattern);
            int_Staff_Id.ViewCustomAttributes = "";

            // Instructor
            Instructor.ViewValue = ConvertToString(Instructor.CurrentValue); // DN
            Instructor.ViewCustomAttributes = "";

            // int_Location_Id
            int_Location_Id.ViewValue = int_Location_Id.CurrentValue;
            int_Location_Id.ViewValue = FormatNumber(int_Location_Id.ViewValue, int_Location_Id.FormatPattern);
            int_Location_Id.ViewCustomAttributes = "";

            // Location
            Location.ViewValue = ConvertToString(Location.CurrentValue); // DN
            Location.ViewCustomAttributes = "";

            // int_Session_ID
            int_Session_ID.ViewValue = int_Session_ID.CurrentValue;
            int_Session_ID.ViewValue = FormatNumber(int_Session_ID.ViewValue, int_Session_ID.FormatPattern);
            int_Session_ID.ViewCustomAttributes = "";

            // str_Session_Date
            str_Session_Date.ViewValue = ConvertToString(str_Session_Date.CurrentValue); // DN
            str_Session_Date.ViewCustomAttributes = "";

            // int_Day_ID
            int_Day_ID.ViewValue = int_Day_ID.CurrentValue;
            int_Day_ID.ViewValue = FormatNumber(int_Day_ID.ViewValue, int_Day_ID.FormatPattern);
            int_Day_ID.ViewCustomAttributes = "";

            // str_Day_Name
            str_Day_Name.ViewValue = ConvertToString(str_Day_Name.CurrentValue); // DN
            str_Day_Name.ViewCustomAttributes = "";

            // str_Time_Start
            str_Time_Start.ViewValue = ConvertToString(str_Time_Start.CurrentValue); // DN
            str_Time_Start.ViewCustomAttributes = "";

            // str_Time_End
            str_Time_End.ViewValue = ConvertToString(str_Time_End.CurrentValue); // DN
            str_Time_End.ViewCustomAttributes = "";

            // date_Created
            date_Created.ViewValue = date_Created.CurrentValue;
            date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
            date_Created.ViewCustomAttributes = "";

            // int_CR_Id
            int_CR_Id.ViewValue = int_CR_Id.CurrentValue;
            int_CR_Id.ViewValue = FormatNumber(int_CR_Id.ViewValue, int_CR_Id.FormatPattern);
            int_CR_Id.ViewCustomAttributes = "";

            // str_Notes
            str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
            str_Notes.ViewCustomAttributes = "";

            // int_Created_By
            int_Created_By.ViewValue = int_Created_By.CurrentValue;
            int_Created_By.ViewValue = FormatNumber(int_Created_By.ViewValue, int_Created_By.FormatPattern);
            int_Created_By.ViewCustomAttributes = "";

            // int_Modified_By
            int_Modified_By.ViewValue = int_Modified_By.CurrentValue;
            int_Modified_By.ViewValue = FormatNumber(int_Modified_By.ViewValue, int_Modified_By.FormatPattern);
            int_Modified_By.ViewCustomAttributes = "";

            // date_Modified
            date_Modified.ViewValue = date_Modified.CurrentValue;
            date_Modified.ViewValue = FormatDateTime(date_Modified.ViewValue, date_Modified.FormatPattern);
            date_Modified.ViewCustomAttributes = "";

            // bit_IsDeleted
            if (ConvertToBool(bit_IsDeleted.CurrentValue)) {
                bit_IsDeleted.ViewValue = bit_IsDeleted.TagCaption(1) != "" ? bit_IsDeleted.TagCaption(1) : "Yes";
            } else {
                bit_IsDeleted.ViewValue = bit_IsDeleted.TagCaption(2) != "" ? bit_IsDeleted.TagCaption(2) : "No";
            }
            bit_IsDeleted.ViewCustomAttributes = "";

            // str_Session_Notes
            str_Session_Notes.ViewValue = ConvertToString(str_Session_Notes.CurrentValue); // DN
            str_Session_Notes.ViewCustomAttributes = "";

            // is_Rescheduled
            is_Rescheduled.ViewValue = is_Rescheduled.CurrentValue;
            is_Rescheduled.ViewValue = FormatNumber(is_Rescheduled.ViewValue, is_Rescheduled.FormatPattern);
            is_Rescheduled.ViewCustomAttributes = "";

            // instructorSignature
            if (!IsNull(instructorSignature.Upload.DbValue)) {
                instructorSignature.ViewValue = RawUrlEncode(int_CRSession_ID.CurrentValue);
                instructorSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])instructorSignature.Upload.DbValue));
            } else {
                instructorSignature.ViewValue = "";
            }
            instructorSignature.ViewCustomAttributes = "";

            // IsZoomMeet
            if (ConvertToBool(IsZoomMeet.CurrentValue)) {
                IsZoomMeet.ViewValue = IsZoomMeet.TagCaption(1) != "" ? IsZoomMeet.TagCaption(1) : "Yes";
            } else {
                IsZoomMeet.ViewValue = IsZoomMeet.TagCaption(2) != "" ? IsZoomMeet.TagCaption(2) : "No";
            }
            IsZoomMeet.ViewCustomAttributes = "";

            // str_ZoomHostUrl
            str_ZoomHostUrl.ViewValue = ConvertToString(str_ZoomHostUrl.CurrentValue); // DN
            str_ZoomHostUrl.ViewCustomAttributes = "";

            // str_ZoomUserUrl
            str_ZoomUserUrl.ViewValue = ConvertToString(str_ZoomUserUrl.CurrentValue); // DN
            str_ZoomUserUrl.ViewCustomAttributes = "";

            // CR_Row_Index
            CR_Row_Index.ViewValue = CR_Row_Index.CurrentValue;
            CR_Row_Index.ViewValue = FormatNumber(CR_Row_Index.ViewValue, CR_Row_Index.FormatPattern);
            CR_Row_Index.ViewCustomAttributes = "";

            // CRSS_ID
            CRSS_ID.ViewValue = CRSS_ID.CurrentValue;
            CRSS_ID.ViewValue = FormatNumber(CRSS_ID.ViewValue, CRSS_ID.FormatPattern);
            CRSS_ID.ViewCustomAttributes = "";

            // int_Student_Id
            int_Student_Id.ViewValue = int_Student_Id.CurrentValue;
            int_Student_Id.ViewValue = FormatNumber(int_Student_Id.ViewValue, int_Student_Id.FormatPattern);
            int_Student_Id.ViewCustomAttributes = "";

            // str_Username
            str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
            str_Username.ViewCustomAttributes = "";

            // str_Status
            str_Status.ViewValue = ConvertToString(str_Status.CurrentValue); // DN
            str_Status.ViewCustomAttributes = "";

            // int_CRSession_ID
            int_CRSession_ID.HrefValue = "";
            int_CRSession_ID.TooltipValue = "";

            // str_CR_Number
            str_CR_Number.HrefValue = "";
            str_CR_Number.TooltipValue = "";

            // int_Status
            int_Status.HrefValue = "";
            int_Status.TooltipValue = "";

            // int_Staff_Id
            int_Staff_Id.HrefValue = "";
            int_Staff_Id.TooltipValue = "";

            // Instructor
            Instructor.HrefValue = "";
            Instructor.TooltipValue = "";

            // int_Location_Id
            int_Location_Id.HrefValue = "";
            int_Location_Id.TooltipValue = "";

            // Location
            Location.HrefValue = "";
            Location.TooltipValue = "";

            // int_Session_ID
            int_Session_ID.HrefValue = "";
            int_Session_ID.TooltipValue = "";

            // str_Session_Date
            str_Session_Date.HrefValue = "";
            str_Session_Date.TooltipValue = "";

            // int_Day_ID
            int_Day_ID.HrefValue = "";
            int_Day_ID.TooltipValue = "";

            // str_Day_Name
            str_Day_Name.HrefValue = "";
            str_Day_Name.TooltipValue = "";

            // str_Time_Start
            str_Time_Start.HrefValue = "";
            str_Time_Start.TooltipValue = "";

            // str_Time_End
            str_Time_End.HrefValue = "";
            str_Time_End.TooltipValue = "";

            // date_Created
            date_Created.HrefValue = "";
            date_Created.TooltipValue = "";

            // int_CR_Id
            int_CR_Id.HrefValue = "";
            int_CR_Id.TooltipValue = "";

            // str_Notes
            str_Notes.HrefValue = "";
            str_Notes.TooltipValue = "";

            // int_Created_By
            int_Created_By.HrefValue = "";
            int_Created_By.TooltipValue = "";

            // int_Modified_By
            int_Modified_By.HrefValue = "";
            int_Modified_By.TooltipValue = "";

            // date_Modified
            date_Modified.HrefValue = "";
            date_Modified.TooltipValue = "";

            // bit_IsDeleted
            bit_IsDeleted.HrefValue = "";
            bit_IsDeleted.TooltipValue = "";

            // str_Session_Notes
            str_Session_Notes.HrefValue = "";
            str_Session_Notes.TooltipValue = "";

            // is_Rescheduled
            is_Rescheduled.HrefValue = "";
            is_Rescheduled.TooltipValue = "";

            // instructorSignature
            if (!IsNull(instructorSignature.Upload.DbValue)) {
                instructorSignature.HrefValue = AppPath(GetFileUploadUrl(instructorSignature, ConvertToString(RawUrlEncode(int_CRSession_ID.CurrentValue)))); // DN
                instructorSignature.LinkAttrs["target"] = "";
                if (instructorSignature.IsBlobImage && Empty(instructorSignature.LinkAttrs["target"]))
                    instructorSignature.LinkAttrs["target"] = "_blank";
                if (IsExport())
                    instructorSignature.HrefValue = FullUrl(ConvertToString(instructorSignature.HrefValue), "href");
            } else {
                instructorSignature.HrefValue = "";
            }
            instructorSignature.ExportHrefValue = GetFileUploadUrl(instructorSignature, ConvertToString(RawUrlEncode(int_CRSession_ID.CurrentValue)));
            instructorSignature.TooltipValue = "";

            // IsZoomMeet
            IsZoomMeet.HrefValue = "";
            IsZoomMeet.TooltipValue = "";

            // str_ZoomHostUrl
            str_ZoomHostUrl.HrefValue = "";
            str_ZoomHostUrl.TooltipValue = "";

            // str_ZoomUserUrl
            str_ZoomUserUrl.HrefValue = "";
            str_ZoomUserUrl.TooltipValue = "";

            // CR_Row_Index
            CR_Row_Index.HrefValue = "";
            CR_Row_Index.TooltipValue = "";

            // CRSS_ID
            CRSS_ID.HrefValue = "";
            CRSS_ID.TooltipValue = "";

            // int_Student_Id
            int_Student_Id.HrefValue = "";
            int_Student_Id.TooltipValue = "";

            // str_Username
            str_Username.HrefValue = "";
            str_Username.TooltipValue = "";

            // str_Status
            str_Status.HrefValue = "";
            str_Status.TooltipValue = "";

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

            // int_CRSession_ID
            int_CRSession_ID.SetupEditAttributes();
            int_CRSession_ID.EditValue = int_CRSession_ID.CurrentValue;
            int_CRSession_ID.ViewCustomAttributes = "";

            // str_CR_Number
            str_CR_Number.SetupEditAttributes();
            if (!str_CR_Number.Raw)
                str_CR_Number.CurrentValue = HtmlDecode(str_CR_Number.CurrentValue);
            str_CR_Number.EditValue = HtmlEncode(str_CR_Number.CurrentValue);
            str_CR_Number.PlaceHolder = RemoveHtml(str_CR_Number.Caption);

            // int_Status
            int_Status.SetupEditAttributes();
            int_Status.EditValue = int_Status.CurrentValue; // DN
            int_Status.PlaceHolder = RemoveHtml(int_Status.Caption);
            if (!Empty(int_Status.EditValue) && IsNumeric(int_Status.EditValue))
                int_Status.EditValue = FormatNumber(int_Status.EditValue, null);

            // int_Staff_Id
            int_Staff_Id.SetupEditAttributes();
            int_Staff_Id.EditValue = int_Staff_Id.CurrentValue; // DN
            int_Staff_Id.PlaceHolder = RemoveHtml(int_Staff_Id.Caption);
            if (!Empty(int_Staff_Id.EditValue) && IsNumeric(int_Staff_Id.EditValue))
                int_Staff_Id.EditValue = FormatNumber(int_Staff_Id.EditValue, null);

            // Instructor
            Instructor.SetupEditAttributes();
            if (!Instructor.Raw)
                Instructor.CurrentValue = HtmlDecode(Instructor.CurrentValue);
            Instructor.EditValue = HtmlEncode(Instructor.CurrentValue);
            Instructor.PlaceHolder = RemoveHtml(Instructor.Caption);

            // int_Location_Id
            int_Location_Id.SetupEditAttributes();
            int_Location_Id.EditValue = int_Location_Id.CurrentValue; // DN
            int_Location_Id.PlaceHolder = RemoveHtml(int_Location_Id.Caption);
            if (!Empty(int_Location_Id.EditValue) && IsNumeric(int_Location_Id.EditValue))
                int_Location_Id.EditValue = FormatNumber(int_Location_Id.EditValue, null);

            // Location
            Location.SetupEditAttributes();
            if (!Location.Raw)
                Location.CurrentValue = HtmlDecode(Location.CurrentValue);
            Location.EditValue = HtmlEncode(Location.CurrentValue);
            Location.PlaceHolder = RemoveHtml(Location.Caption);

            // int_Session_ID
            int_Session_ID.SetupEditAttributes();
            int_Session_ID.EditValue = int_Session_ID.CurrentValue; // DN
            int_Session_ID.PlaceHolder = RemoveHtml(int_Session_ID.Caption);
            if (!Empty(int_Session_ID.EditValue) && IsNumeric(int_Session_ID.EditValue))
                int_Session_ID.EditValue = FormatNumber(int_Session_ID.EditValue, null);

            // str_Session_Date
            str_Session_Date.SetupEditAttributes();
            if (!str_Session_Date.Raw)
                str_Session_Date.CurrentValue = HtmlDecode(str_Session_Date.CurrentValue);
            str_Session_Date.EditValue = HtmlEncode(str_Session_Date.CurrentValue);
            str_Session_Date.PlaceHolder = RemoveHtml(str_Session_Date.Caption);

            // int_Day_ID
            int_Day_ID.SetupEditAttributes();
            int_Day_ID.EditValue = int_Day_ID.CurrentValue; // DN
            int_Day_ID.PlaceHolder = RemoveHtml(int_Day_ID.Caption);
            if (!Empty(int_Day_ID.EditValue) && IsNumeric(int_Day_ID.EditValue))
                int_Day_ID.EditValue = FormatNumber(int_Day_ID.EditValue, null);

            // str_Day_Name
            str_Day_Name.SetupEditAttributes();
            if (!str_Day_Name.Raw)
                str_Day_Name.CurrentValue = HtmlDecode(str_Day_Name.CurrentValue);
            str_Day_Name.EditValue = HtmlEncode(str_Day_Name.CurrentValue);
            str_Day_Name.PlaceHolder = RemoveHtml(str_Day_Name.Caption);

            // str_Time_Start
            str_Time_Start.SetupEditAttributes();
            if (!str_Time_Start.Raw)
                str_Time_Start.CurrentValue = HtmlDecode(str_Time_Start.CurrentValue);
            str_Time_Start.EditValue = HtmlEncode(str_Time_Start.CurrentValue);
            str_Time_Start.PlaceHolder = RemoveHtml(str_Time_Start.Caption);

            // str_Time_End
            str_Time_End.SetupEditAttributes();
            if (!str_Time_End.Raw)
                str_Time_End.CurrentValue = HtmlDecode(str_Time_End.CurrentValue);
            str_Time_End.EditValue = HtmlEncode(str_Time_End.CurrentValue);
            str_Time_End.PlaceHolder = RemoveHtml(str_Time_End.Caption);

            // date_Created
            date_Created.SetupEditAttributes();
            date_Created.EditValue = FormatDateTime(date_Created.CurrentValue, date_Created.FormatPattern); // DN
            date_Created.PlaceHolder = RemoveHtml(date_Created.Caption);

            // int_CR_Id
            int_CR_Id.SetupEditAttributes();
            int_CR_Id.EditValue = int_CR_Id.CurrentValue; // DN
            int_CR_Id.PlaceHolder = RemoveHtml(int_CR_Id.Caption);
            if (!Empty(int_CR_Id.EditValue) && IsNumeric(int_CR_Id.EditValue))
                int_CR_Id.EditValue = FormatNumber(int_CR_Id.EditValue, null);

            // str_Notes
            str_Notes.SetupEditAttributes();
            if (!str_Notes.Raw)
                str_Notes.CurrentValue = HtmlDecode(str_Notes.CurrentValue);
            str_Notes.EditValue = HtmlEncode(str_Notes.CurrentValue);
            str_Notes.PlaceHolder = RemoveHtml(str_Notes.Caption);

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

            // date_Modified
            date_Modified.SetupEditAttributes();
            date_Modified.EditValue = FormatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern); // DN
            date_Modified.PlaceHolder = RemoveHtml(date_Modified.Caption);

            // bit_IsDeleted
            bit_IsDeleted.EditValue = bit_IsDeleted.Options(false);
            bit_IsDeleted.PlaceHolder = RemoveHtml(bit_IsDeleted.Caption);

            // str_Session_Notes
            str_Session_Notes.SetupEditAttributes();
            if (!str_Session_Notes.Raw)
                str_Session_Notes.CurrentValue = HtmlDecode(str_Session_Notes.CurrentValue);
            str_Session_Notes.EditValue = HtmlEncode(str_Session_Notes.CurrentValue);
            str_Session_Notes.PlaceHolder = RemoveHtml(str_Session_Notes.Caption);

            // is_Rescheduled
            is_Rescheduled.SetupEditAttributes();
            is_Rescheduled.EditValue = is_Rescheduled.CurrentValue; // DN
            is_Rescheduled.PlaceHolder = RemoveHtml(is_Rescheduled.Caption);
            if (!Empty(is_Rescheduled.EditValue) && IsNumeric(is_Rescheduled.EditValue))
                is_Rescheduled.EditValue = FormatNumber(is_Rescheduled.EditValue, null);

            // instructorSignature
            instructorSignature.SetupEditAttributes();
            if (!IsNull(instructorSignature.Upload.DbValue)) {
                instructorSignature.EditValue = RawUrlEncode(int_CRSession_ID.CurrentValue);
                instructorSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])instructorSignature.Upload.DbValue));
            } else {
                instructorSignature.EditValue = "";
            }

            // IsZoomMeet
            IsZoomMeet.EditValue = IsZoomMeet.Options(false);
            IsZoomMeet.PlaceHolder = RemoveHtml(IsZoomMeet.Caption);

            // str_ZoomHostUrl
            str_ZoomHostUrl.SetupEditAttributes();
            if (!str_ZoomHostUrl.Raw)
                str_ZoomHostUrl.CurrentValue = HtmlDecode(str_ZoomHostUrl.CurrentValue);
            str_ZoomHostUrl.EditValue = HtmlEncode(str_ZoomHostUrl.CurrentValue);
            str_ZoomHostUrl.PlaceHolder = RemoveHtml(str_ZoomHostUrl.Caption);

            // str_ZoomUserUrl
            str_ZoomUserUrl.SetupEditAttributes();
            if (!str_ZoomUserUrl.Raw)
                str_ZoomUserUrl.CurrentValue = HtmlDecode(str_ZoomUserUrl.CurrentValue);
            str_ZoomUserUrl.EditValue = HtmlEncode(str_ZoomUserUrl.CurrentValue);
            str_ZoomUserUrl.PlaceHolder = RemoveHtml(str_ZoomUserUrl.Caption);

            // CR_Row_Index
            CR_Row_Index.SetupEditAttributes();
            CR_Row_Index.EditValue = CR_Row_Index.CurrentValue; // DN
            CR_Row_Index.PlaceHolder = RemoveHtml(CR_Row_Index.Caption);
            if (!Empty(CR_Row_Index.EditValue) && IsNumeric(CR_Row_Index.EditValue))
                CR_Row_Index.EditValue = FormatNumber(CR_Row_Index.EditValue, null);

            // CRSS_ID
            CRSS_ID.SetupEditAttributes();
            CRSS_ID.EditValue = CRSS_ID.CurrentValue; // DN
            CRSS_ID.PlaceHolder = RemoveHtml(CRSS_ID.Caption);
            if (!Empty(CRSS_ID.EditValue) && IsNumeric(CRSS_ID.EditValue))
                CRSS_ID.EditValue = FormatNumber(CRSS_ID.EditValue, null);

            // int_Student_Id
            int_Student_Id.SetupEditAttributes();
            int_Student_Id.EditValue = int_Student_Id.CurrentValue; // DN
            int_Student_Id.PlaceHolder = RemoveHtml(int_Student_Id.Caption);
            if (!Empty(int_Student_Id.EditValue) && IsNumeric(int_Student_Id.EditValue))
                int_Student_Id.EditValue = FormatNumber(int_Student_Id.EditValue, null);

            // str_Username
            str_Username.SetupEditAttributes();
            if (!str_Username.Raw)
                str_Username.CurrentValue = HtmlDecode(str_Username.CurrentValue);
            str_Username.EditValue = HtmlEncode(str_Username.CurrentValue);
            str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);

            // str_Status
            str_Status.SetupEditAttributes();
            if (!str_Status.Raw)
                str_Status.CurrentValue = HtmlDecode(str_Status.CurrentValue);
            str_Status.EditValue = HtmlEncode(str_Status.CurrentValue);
            str_Status.PlaceHolder = RemoveHtml(str_Status.Caption);

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
                        doc.ExportCaption(str_CR_Number);
                        doc.ExportCaption(int_Status);
                        doc.ExportCaption(Instructor);
                        doc.ExportCaption(Location);
                        doc.ExportCaption(int_Session_ID);
                        doc.ExportCaption(str_Session_Date);
                        doc.ExportCaption(int_Day_ID);
                        doc.ExportCaption(str_Time_Start);
                        doc.ExportCaption(str_Time_End);
                        doc.ExportCaption(str_Session_Notes);
                        doc.ExportCaption(is_Rescheduled);
                        doc.ExportCaption(instructorSignature);
                        doc.ExportCaption(IsZoomMeet);
                        doc.ExportCaption(str_ZoomHostUrl);
                        doc.ExportCaption(str_ZoomUserUrl);
                        doc.ExportCaption(int_Student_Id);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(str_Status);
                    } else {
                        doc.ExportCaption(int_CRSession_ID);
                        doc.ExportCaption(str_CR_Number);
                        doc.ExportCaption(int_Status);
                        doc.ExportCaption(int_Staff_Id);
                        doc.ExportCaption(Instructor);
                        doc.ExportCaption(int_Location_Id);
                        doc.ExportCaption(Location);
                        doc.ExportCaption(int_Session_ID);
                        doc.ExportCaption(str_Session_Date);
                        doc.ExportCaption(int_Day_ID);
                        doc.ExportCaption(str_Day_Name);
                        doc.ExportCaption(str_Time_Start);
                        doc.ExportCaption(str_Time_End);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(int_CR_Id);
                        doc.ExportCaption(str_Notes);
                        doc.ExportCaption(int_Created_By);
                        doc.ExportCaption(int_Modified_By);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(bit_IsDeleted);
                        doc.ExportCaption(str_Session_Notes);
                        doc.ExportCaption(is_Rescheduled);
                        doc.ExportCaption(IsZoomMeet);
                        doc.ExportCaption(str_ZoomHostUrl);
                        doc.ExportCaption(str_ZoomUserUrl);
                        doc.ExportCaption(CR_Row_Index);
                        doc.ExportCaption(CRSS_ID);
                        doc.ExportCaption(int_Student_Id);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(str_Status);
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
                            await doc.ExportField(str_CR_Number);
                            await doc.ExportField(int_Status);
                            await doc.ExportField(Instructor);
                            await doc.ExportField(Location);
                            await doc.ExportField(int_Session_ID);
                            await doc.ExportField(str_Session_Date);
                            await doc.ExportField(int_Day_ID);
                            await doc.ExportField(str_Time_Start);
                            await doc.ExportField(str_Time_End);
                            await doc.ExportField(str_Session_Notes);
                            await doc.ExportField(is_Rescheduled);
                            await doc.ExportField(instructorSignature);
                            await doc.ExportField(IsZoomMeet);
                            await doc.ExportField(str_ZoomHostUrl);
                            await doc.ExportField(str_ZoomUserUrl);
                            await doc.ExportField(int_Student_Id);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(str_Status);
                        } else {
                            await doc.ExportField(int_CRSession_ID);
                            await doc.ExportField(str_CR_Number);
                            await doc.ExportField(int_Status);
                            await doc.ExportField(int_Staff_Id);
                            await doc.ExportField(Instructor);
                            await doc.ExportField(int_Location_Id);
                            await doc.ExportField(Location);
                            await doc.ExportField(int_Session_ID);
                            await doc.ExportField(str_Session_Date);
                            await doc.ExportField(int_Day_ID);
                            await doc.ExportField(str_Day_Name);
                            await doc.ExportField(str_Time_Start);
                            await doc.ExportField(str_Time_End);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(int_CR_Id);
                            await doc.ExportField(str_Notes);
                            await doc.ExportField(int_Created_By);
                            await doc.ExportField(int_Modified_By);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(bit_IsDeleted);
                            await doc.ExportField(str_Session_Notes);
                            await doc.ExportField(is_Rescheduled);
                            await doc.ExportField(IsZoomMeet);
                            await doc.ExportField(str_ZoomHostUrl);
                            await doc.ExportField(str_ZoomUserUrl);
                            await doc.ExportField(CR_Row_Index);
                            await doc.ExportField(CRSS_ID);
                            await doc.ExportField(int_Student_Id);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(str_Status);
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
            if (SameText(fldparm, "instructorSignature")) {
                fldName = "instructorSignature";
            } else {
                return JsonBoolResult.FalseResult; // Incorrect field
            }

            // Set up key values
            if (keys.Length == 1) {
                int_CRSession_ID.CurrentValue = keys[0];
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
        public async Task WriteAuditTrailLog(string log) => await WriteAuditTrailAsync(CurrentUser(), log, "tblCRSessions");

        // Write audit trail (add page)
        public async Task WriteAuditTrailOnAdd(IDictionary<string, object> rs)
        {
            if (!AuditTrailOnAdd)
                return;
            string table = "tblCRSessions";

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
            string table = "tblCRSessions";

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
            string table = "tblCRSessions";

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

        // Send email after update success
        public async Task<string> SendEmailOnEdit(Dictionary<string, object> rsold, Dictionary<string, object> rsnew)
        {
            string table = "tblCRSessions";
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
