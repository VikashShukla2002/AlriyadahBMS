namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// sessions
    /// </summary>
    [MaybeNull]
    public static Sessions sessions
    {
        get => HttpData.Resolve<Sessions>("Sessions");
        set => HttpData["Sessions"] = value;
    }

    /// <summary>
    /// Table class for Sessions
    /// </summary>
    public class Sessions : ReportTable, IQueryFactory
    {
        #pragma warning disable 414

        public bool ShowGroupHeaderAsRow = false;

        public bool ShowCompactSummaryFooter = true;
        #pragma warning restore 414

        public int RowCount = 0; // DN

        public bool UseSessionForListSql = true;

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

        public readonly ReportField<SqlDbType> int_CRSession_ID;

        public readonly ReportField<SqlDbType> str_CR_Number;

        public readonly ReportField<SqlDbType> int_Status;

        public readonly ReportField<SqlDbType> int_Staff_Id;

        public readonly ReportField<SqlDbType> Instructor;

        public readonly ReportField<SqlDbType> int_Location_Id;

        public readonly ReportField<SqlDbType> Location;

        public readonly ReportField<SqlDbType> int_Session_ID;

        public readonly ReportField<SqlDbType> str_Session_Date;

        public readonly ReportField<SqlDbType> int_Day_ID;

        public readonly ReportField<SqlDbType> str_Day_Name;

        public readonly ReportField<SqlDbType> str_Time_Start;

        public readonly ReportField<SqlDbType> str_Time_End;

        public readonly ReportField<SqlDbType> date_Created;

        public readonly ReportField<SqlDbType> int_CR_Id;

        public readonly ReportField<SqlDbType> str_Notes;

        public readonly ReportField<SqlDbType> int_Created_By;

        public readonly ReportField<SqlDbType> int_Modified_By;

        public readonly ReportField<SqlDbType> date_Modified;

        public readonly ReportField<SqlDbType> bit_IsDeleted;

        public readonly ReportField<SqlDbType> str_Session_Notes;

        public readonly ReportField<SqlDbType> is_Rescheduled;

        public readonly ReportField<SqlDbType> instructorSignature;

        public readonly ReportField<SqlDbType> IsZoomMeet;

        public readonly ReportField<SqlDbType> str_ZoomHostUrl;

        public readonly ReportField<SqlDbType> str_ZoomUserUrl;

        public readonly ReportField<SqlDbType> CR_Row_Index;

        public readonly ReportField<SqlDbType> CRSS_ID;

        public readonly ReportField<SqlDbType> int_Student_Id;

        public readonly ReportField<SqlDbType> str_Username;

        public readonly ReportField<SqlDbType> str_Status;

        // Constructor
        public Sessions()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "Sessions";
            Name = "Sessions";
            Type = "REPORT";
            ReportSourceTable = "tblCRSessions"; // Report source table
            ReportSourceTableName = "tblCRSessions"; // Report source table name
            TableReportType = "summary";
            DbId = "DB"; // DN
            ExportAll = true;
            ExportPageBreakCount = 0; // Page break per every n record (report only)
            ExportPageOrientation = "portrait"; // Page orientation (PDF only)
            ExportPageSize = "a4"; // Page size (PDF only)
            ExportColumnWidths = new float[] {  }; // Column widths (PDF only) // DN
            ExportExcelPageOrientation = "Portrait"; // Page orientation (EPPlus only)
            ExportExcelPageSize = "A4"; // Page size (EPPlus only)
            ExportWordPageOrientation = "Portrait"; // Page orientation (Word only)
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
                CustomMessage = Language.FieldPhrase("Sessions", "int_CRSession_ID", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
                IsUpload = false
            };
            Fields.Add("int_CRSession_ID", int_CRSession_ID);

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
                HtmlTag = "TEXT",
                InputTextType = "text",
                GroupingFieldId = 1,
                ShowGroupHeaderAsRow = false,
                ShowCompactSummaryFooter = true,
                GroupByType = "",
                GroupInterval = "0",
                GroupSql = "",
                IsForeignKey = true, // Foreign key field
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY" },
                CustomMessage = Language.FieldPhrase("Sessions", "str_CR_Number", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "int_Status", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "int_Staff_Id", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
                IsUpload = false
            };
            Fields.Add("int_Staff_Id", int_Staff_Id);

            // Instructor
            Instructor = new (this, "x_Instructor", 202, SqlDbType.NVarChar) {
                Name = "Instructor",
                Expression = "[Instructor]",
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
                CustomMessage = Language.FieldPhrase("Sessions", "Instructor", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "int_Location_Id", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
                IsUpload = false
            };
            Fields.Add("int_Location_Id", int_Location_Id);

            // Location
            Location = new (this, "x_Location", 202, SqlDbType.NVarChar) {
                Name = "Location",
                Expression = "[Location]",
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
                CustomMessage = Language.FieldPhrase("Sessions", "Location", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "int_Session_ID", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
                IsUpload = false
            };
            Fields.Add("int_Session_ID", int_Session_ID);

            // str_Session_Date
            str_Session_Date = new (this, "x_str_Session_Date", 200, SqlDbType.VarChar) {
                Name = "str_Session_Date",
                Expression = "[str_Session_Date]",
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
                GroupingFieldId = 2,
                ShowGroupHeaderAsRow = false,
                ShowCompactSummaryFooter = true,
                GroupByType = "",
                GroupInterval = "0",
                GroupSql = "",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Sessions", "str_Session_Date", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "int_Day_ID", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "str_Day_Name", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
                IsUpload = false
            };
            Fields.Add("str_Day_Name", str_Day_Name);

            // str_Time_Start
            str_Time_Start = new (this, "x_str_Time_Start", 200, SqlDbType.VarChar) {
                Name = "str_Time_Start",
                Expression = "[str_Time_Start]",
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
                CustomMessage = Language.FieldPhrase("Sessions", "str_Time_Start", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
                IsUpload = false
            };
            Fields.Add("str_Time_Start", str_Time_Start);

            // str_Time_End
            str_Time_End = new (this, "x_str_Time_End", 200, SqlDbType.VarChar) {
                Name = "str_Time_End",
                Expression = "[str_Time_End]",
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
                CustomMessage = Language.FieldPhrase("Sessions", "str_Time_End", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "date_Created", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "int_CR_Id", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "str_Notes", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "int_Created_By", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "int_Modified_By", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "date_Modified", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "bit_IsDeleted", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
                IsUpload = false
            };
            bit_IsDeleted.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IsDeleted, "Sessions", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsDeleted, "Sessions", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IsDeleted, "Sessions", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
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
                CustomMessage = Language.FieldPhrase("Sessions", "str_Session_Notes", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "is_Rescheduled", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "instructorSignature", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "IsZoomMeet", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
                IsUpload = false
            };
            IsZoomMeet.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(IsZoomMeet, "Sessions", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(IsZoomMeet, "Sessions", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(IsZoomMeet, "Sessions", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
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
                CustomMessage = Language.FieldPhrase("Sessions", "str_ZoomHostUrl", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "str_ZoomUserUrl", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "CR_Row_Index", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "CRSS_ID", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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
                CustomMessage = Language.FieldPhrase("Sessions", "int_Student_Id", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
                IsUpload = false
            };
            Fields.Add("int_Student_Id", int_Student_Id);

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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Sessions", "str_Username", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
                IsUpload = false
            };
            Fields.Add("str_Username", str_Username);

            // str_Status
            str_Status = new (this, "x_str_Status", 202, SqlDbType.NVarChar) {
                Name = "str_Status",
                Expression = "[str_Status]",
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
                CustomMessage = Language.FieldPhrase("Sessions", "str_Status", "CustomMsg"),
                SourceTableVar = "tblCRSessions",
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

        // Single column sort // DN
        public void UpdateSort(ReportField fld)
        {
            if (CurrentOrder == fld.Name) {
                string sortField = fld.Expression, lastSort = fld.Sort, currentSort = "";
                if ((new[] { "ASC", "DESC", "NO" }).Contains(CurrentOrderType)) {
                    currentSort = CurrentOrderType;
                } else {
                    currentSort = lastSort;
                }
                fld.Sort = currentSort;
                string currentOrderBy = (new[] { "ASC", "DESC" }).Contains(currentSort) ? sortField + " " + currentSort : "";
                if (fld.GroupingFieldId == 0)
                    DetailOrderBy = currentOrderBy; // Save to Session
            } else {
                if (fld.GroupingFieldId == 0)
                    fld.Sort = "";
            }
        }

        // Multiple column sort // DN
        public void UpdateSort(ReportField fld, bool ctrl)
        {
            if (CurrentOrder == fld.Name) {
                string sortField = fld.Expression, lastSort = fld.Sort, currentSort = "";
                if ((new[] { "ASC", "DESC", "NO" }).Contains(CurrentOrderType)) {
                    currentSort = CurrentOrderType;
                } else {
                    currentSort = lastSort;
                }
                fld.Sort = currentSort;
                string lastOrderBy = (new[] { "ASC", "DESC" }).Contains(lastSort) ? sortField + " " + lastSort : "";
                string currentOrderBy = (new[] { "ASC", "DESC" }).Contains(currentSort) ? sortField + " " + currentSort : "";
                if (fld.GroupingFieldId == 0) {
                    if (ctrl) {
                        List<string> orderBy = !Empty(DetailOrderBy) ? DetailOrderBy.Split(new string[] { ", " }, StringSplitOptions.None).ToList() : new ();
                        if (!Empty(lastOrderBy) && orderBy.Contains(lastOrderBy)) {
                            if (Empty(currentOrderBy)) {
                                orderBy.Remove(lastOrderBy);
                            } else {
                                var index = orderBy.IndexOf(lastOrderBy);
                                orderBy[index] = currentOrderBy;
                            }
                        } else if (!Empty(currentOrderBy)) {
                            orderBy.Add(currentOrderBy);
                        }
                        DetailOrderBy = String.Join(", ", orderBy); // Save to Session
                    } else {
                        DetailOrderBy = currentOrderBy; // Save to Session
                    }
                }
            } else {
                if (fld.GroupingFieldId == 0 && !ctrl)
                    fld.Sort = "";
            }
        }

        // Get Sort SQL
        public string SortSql
        {
            get {
                string detailSortSql = DetailOrderBy; // Get ORDER BY for detail fields from session
                var groups = new List<string>();
                foreach (ReportField fld in Fields.Values) {
                    if ((new[] { "ASC", "DESC" }).Contains(fld.Sort)) {
                        string fldsql = fld.Expression;
                        if (fld.GroupingFieldId > 0) {
                            if (!Empty(fld.GroupSql))
                                groups.Add(fld.GroupSql.Replace("%s", fldsql) + " " + fld.Sort);
                            else
                                groups.Add(fldsql + " " + fld.Sort);
                        }
                    }
                }
                if (!Empty(detailSortSql))
                    groups.Add(detailSortSql);
                return String.Join(", ", groups);
            }
        }

        // Current master table name
        public string CurrentMasterTable
        {
            get => Session.GetString(Config.ProjectName + "_" + TableVar + "_" + Config.TableMasterTable);
            set => Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableMasterTable] = value;
        }

        // Session master where clause
        public string MasterFilterFromSession
        {
            get { // Master filter
                string masterFilter = "";
            if (CurrentMasterTable == "tblCRAttendance") {
                dynamic masterTable = Resolve("tblCRAttendance")!;
                if (!Empty(str_CR_Number.SessionValue))
                    masterFilter += "" + KeyFilter(masterTable.str_CR_Number, str_CR_Number.SessionValue, masterTable.str_CR_Number.DataType, masterTable.DbId);
                else
                    return "";
            }
                return masterFilter;
            }
        }

        // Session detail WHERE clause
        public string DetailFilterFromSession
        {
            get { // Detail filter
                string detailFilter = "";
                if (CurrentMasterTable == "tblCRAttendance") {
                    dynamic masterTable = Resolve("tblCRAttendance")!;
                    if (!Empty(str_CR_Number.SessionValue))
                        detailFilter += "" + KeyFilter(str_CR_Number, str_CR_Number.SessionValue, masterTable.str_CR_Number.DataType, DbId);
                    else
                        return "";
                }
                return detailFilter;
            }
        }

        // Master filter // DN
        public string? MasterFilter(dynamic? masterTable, Dictionary<string, object?> keys) // DN
        {
            bool validKeys = true;
            object key = "";
            switch (masterTable?.TableVar) {
            case "tblCRAttendance":
                key = keys["str_CR_Number"] ?? "";
                if (Empty(key)) {
                    if (masterTable.str_CR_Number.Required) // Required field and empty value
                        return ""; // Return empty filter
                    validKeys = false;
                } else if (!validKeys) { // Already has empty key
                    return ""; // Return empty filter
                }
                if (validKeys) {
                    return KeyFilter(masterTable.str_CR_Number, keys["str_CR_Number"], str_CR_Number.DataType, DbId);
                }
                break;
            }
            return null; // All null values and no required fields
        }

        // Detail filter // DN
        public string DetailFilter(dynamic masterTable) // DN
        {
            return masterTable.TableVar switch {
                "tblCRAttendance" => KeyFilter(str_CR_Number, masterTable.str_CR_Number.DbValue, masterTable.str_CR_Number.DataType, masterTable.DbId),
                _ => ""
            };
        }

        // Crosstab/Summary report private properties
        private string _sqlFirstGroupField = "";

        private string _sqlSelectGroup = "";

        private string _sqlOrderByGroup = "";

        public ReportField? FirstGroupField; // DN

        // First Group Field
        public string SqlFirstGroupField
        {
            get => GetSqlFirstGroupField();
            set => _sqlFirstGroupField = value;
        }

        // Get First Group Field // DN
        public string GetSqlFirstGroupField(bool alias = false)
        {
            if (!Empty(_sqlFirstGroupField))
                return _sqlFirstGroupField;
            string expr = FirstGroupField?.Expression ?? "";
            if (FirstGroupField != null && !Empty(FirstGroupField.GroupSql)) {
                expr = FirstGroupField.GroupSql.Replace("%s", FirstGroupField.Expression);
                if (alias)
                    expr += " AS " + QuotedName(FirstGroupField.GroupName, DbId);
            }
            return expr;
        }

        // Select Group
        public string SqlSelectGroup
        {
            get => !Empty(_sqlSelectGroup) ? _sqlSelectGroup : "SELECT DISTINCT " + GetSqlFirstGroupField(true) + " FROM " + SqlFrom;
            set => _sqlSelectGroup = value;
        }

        // Order By Group
        public string SqlOrderByGroup
        {
            get => !Empty(_sqlOrderByGroup) ? _sqlOrderByGroup : SqlFirstGroupField + " ASC";
            set => _sqlOrderByGroup = value;
        }

        // Summary/Simple report private properties
        private string _sqlSelectAggregate = "";

        private string _sqlAggregatePrefix = "";

        private string _sqlAggregateSuffix = "";

        private string _sqlSelectCount = "";

        // Select Aggregate
        public string SqlSelectAggregate
        {
            get => !Empty(_sqlSelectAggregate) ? _sqlSelectAggregate : "SELECT COUNT(NULLIF([int_CRSession_ID],0)) AS cnt_int_crsession_id FROM " + SqlFrom;
            set => _sqlSelectAggregate = value;
        }

        // Aggregate Prefix
        public string SqlAggregatePrefix
        {
            get => !Empty(_sqlAggregatePrefix) ? _sqlAggregatePrefix : "";
            set => _sqlAggregatePrefix = value;
        }

        // Aggregate Suffix
        public string SqlAggregateSuffix
        {
            get => !Empty(_sqlAggregateSuffix) ? _sqlAggregateSuffix : "";
            set => _sqlAggregateSuffix = value;
        }

        // Select Count
        public string SqlSelectCount
        {
            get => !Empty(_sqlSelectCount) ? _sqlSelectCount : "SELECT COUNT(*) FROM " + SqlFrom;
            set => _sqlSelectCount = value;
        }

        #pragma warning disable 1998
        // Render for lookup
        public async Task RenderLookup()
        {
        }
        #pragma warning restore 1998

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
            get {
                if (!Empty(_sqlSelect))
                    return _sqlSelect;
                string select = "*";
                if (!Empty(str_CR_Number.GroupSql)) {
                    string expr = str_CR_Number.GroupSql.Replace("%s", str_CR_Number.Expression) + " AS " + QuotedName(str_CR_Number.GroupName, DbId);
                    select += ", " + expr;
                }
                if (!Empty(str_Session_Date.GroupSql)) {
                    string expr = str_Session_Date.GroupSql.Replace("%s", str_Session_Date.Expression) + " AS " + QuotedName(str_Session_Date.GroupName, DbId);
                    select += ", " + expr;
                }
                return "SELECT " + select + " FROM " + SqlFrom;
            }
            set {
                _sqlSelect = value;
            }
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
                    return "";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, ""))
                return Language.Phrase("View");
            else if (SameString(pageName, ""))
                return Language.Phrase("Edit");
            else if (SameString(pageName, ""))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "Sessions";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return "Sessions";
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
        public string ListUrl => "";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("", parm);
            else
                url = KeyUrl("", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "?" + parm;
            else
                url = "";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
            if (CurrentMasterTable == "tblCRAttendance" && !url.Contains(Config.TableShowMaster + "=")) {
                url += (url.Contains("?") ? "&" : "?") + Config.TableShowMaster + "=" + CurrentMasterTable;
                url += "&" + ForeignKeyUrl("fk_str_CR_Number", str_CR_Number.SessionValue); // Use Session Value
            }
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
                DrillDown ||
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

        // Table filter
        private string? _tableFilter = null;

        public string TableFilter
        {
            get => _tableFilter ?? "";
            set => _tableFilter = value;
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
            string sql = BuildReportSql(SqlSelect, SqlWhere, SqlGroupBy, SqlHaving, SqlOrderBy, filter, "");
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

        // Table level events

        // Table Load event
        public void TableLoad()
        {
            // Enter your code here
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
