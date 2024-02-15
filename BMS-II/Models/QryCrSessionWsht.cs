namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// qryCrSessionWsht
    /// </summary>
    [MaybeNull]
    public static QryCrSessionWsht qryCrSessionWsht
    {
        get => HttpData.Resolve<QryCrSessionWsht>("qryCRSessionWsht");
        set => HttpData["qryCRSessionWsht"] = value;
    }

    /// <summary>
    /// Table class for qryCRSessionWsht
    /// </summary>
    public class QryCrSessionWsht : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> int_CR_ID;

        public readonly DbField<SqlDbType> int_CR_Product_ID;

        public readonly DbField<SqlDbType> str_CR_Number;

        public readonly DbField<SqlDbType> mon_CR_Price;

        public readonly DbField<SqlDbType> int_CR_Size;

        public readonly DbField<SqlDbType> int_MU_Size;

        public readonly DbField<SqlDbType> int_CR_Status;

        public readonly DbField<SqlDbType> Is_Web_SignUp;

        public readonly DbField<SqlDbType> int_Location_ID;

        public readonly DbField<SqlDbType> int_Teacher_ID;

        public readonly DbField<SqlDbType> Instructor_Name;

        public readonly DbField<SqlDbType> date_Start;

        public readonly DbField<SqlDbType> int_TotSession;

        public readonly DbField<SqlDbType> int_PerDaySession;

        public readonly DbField<SqlDbType> str_CR_Days;

        public readonly DbField<SqlDbType> str_CR_Notes;

        public readonly DbField<SqlDbType> int_Created_By;

        public readonly DbField<SqlDbType> int_Modified_By;

        public readonly DbField<SqlDbType> date_Created;

        public readonly DbField<SqlDbType> date_Modified;

        public readonly DbField<SqlDbType> bit_IsDeleted;

        public readonly DbField<SqlDbType> bit_AllTeacher;

        public readonly DbField<SqlDbType> int_Manual_Change;

        public readonly DbField<SqlDbType> str_WebDesc;

        public readonly DbField<SqlDbType> is_Show;

        public readonly DbField<SqlDbType> is_ShowGridColumn;

        public readonly DbField<SqlDbType> rowIndex;

        public readonly DbField<SqlDbType> is_ZoomMeet;

        public readonly DbField<SqlDbType> Classroom_Internal_Cr_Notes;

        public readonly DbField<SqlDbType> BulkCR_Set;

        public readonly DbField<SqlDbType> int_Day_Incremental;

        public readonly DbField<SqlDbType> int_Reoccurrence;

        public readonly DbField<SqlDbType> str_Username;

        public readonly DbField<SqlDbType> Calendar_ID;

        public readonly DbField<SqlDbType> str_Package_Name;

        public readonly DbField<SqlDbType> int_Session_Id;

        public readonly DbField<SqlDbType> CRSS_ID;

        // Constructor
        public QryCrSessionWsht()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "qryCRSessionWsht";
            Name = "qryCRSessionWsht";
            Type = "VIEW";
            UpdateTable = "dbo.qryCRSessionWsht"; // Update Table
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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "int_CR_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CR_ID", int_CR_ID);

            // int_CR_Product_ID
            int_CR_Product_ID = new (this, "x_int_CR_Product_ID", 3, SqlDbType.Int) {
                Name = "int_CR_Product_ID",
                Expression = "[int_CR_Product_ID]",
                BasicSearchExpression = "CAST([int_CR_Product_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_CR_Product_ID]",
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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "int_CR_Product_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CR_Product_ID", int_CR_Product_ID);

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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "str_CR_Number", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CR_Number", str_CR_Number);

            // mon_CR_Price
            mon_CR_Price = new (this, "x_mon_CR_Price", 6, SqlDbType.Money) {
                Name = "mon_CR_Price",
                Expression = "[mon_CR_Price]",
                BasicSearchExpression = "CAST([mon_CR_Price] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[mon_CR_Price]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "mon_CR_Price", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("mon_CR_Price", mon_CR_Price);

            // int_CR_Size
            int_CR_Size = new (this, "x_int_CR_Size", 3, SqlDbType.Int) {
                Name = "int_CR_Size",
                Expression = "[int_CR_Size]",
                BasicSearchExpression = "CAST([int_CR_Size] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_CR_Size]",
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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "int_CR_Size", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CR_Size", int_CR_Size);

            // int_MU_Size
            int_MU_Size = new (this, "x_int_MU_Size", 3, SqlDbType.Int) {
                Name = "int_MU_Size",
                Expression = "[int_MU_Size]",
                BasicSearchExpression = "CAST([int_MU_Size] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_MU_Size]",
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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "int_MU_Size", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_MU_Size", int_MU_Size);

            // int_CR_Status
            int_CR_Status = new (this, "x_int_CR_Status", 3, SqlDbType.Int) {
                Name = "int_CR_Status",
                Expression = "[int_CR_Status]",
                BasicSearchExpression = "CAST([int_CR_Status] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_CR_Status]",
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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "int_CR_Status", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CR_Status", int_CR_Status);

            // Is_Web_SignUp
            Is_Web_SignUp = new (this, "x_Is_Web_SignUp", 11, SqlDbType.Bit) {
                Name = "Is_Web_SignUp",
                Expression = "[Is_Web_SignUp]",
                BasicSearchExpression = "[Is_Web_SignUp]",
                DateTimeFormat = -1,
                VirtualExpression = "[Is_Web_SignUp]",
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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "Is_Web_SignUp", "CustomMsg"),
                IsUpload = false
            };
            Is_Web_SignUp.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Is_Web_SignUp, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Is_Web_SignUp, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Is_Web_SignUp, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Is_Web_SignUp", Is_Web_SignUp);

            // int_Location_ID
            int_Location_ID = new (this, "x_int_Location_ID", 3, SqlDbType.Int) {
                Name = "int_Location_ID",
                Expression = "[int_Location_ID]",
                BasicSearchExpression = "CAST([int_Location_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Location_ID]",
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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "int_Location_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Location_ID", int_Location_ID);

            // int_Teacher_ID
            int_Teacher_ID = new (this, "x_int_Teacher_ID", 3, SqlDbType.Int) {
                Name = "int_Teacher_ID",
                Expression = "[int_Teacher_ID]",
                BasicSearchExpression = "CAST([int_Teacher_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Teacher_ID]",
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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "int_Teacher_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Teacher_ID", int_Teacher_ID);

            // Instructor_Name
            Instructor_Name = new (this, "x_Instructor_Name", 202, SqlDbType.NVarChar) {
                Name = "Instructor_Name",
                Expression = "[Instructor_Name]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Instructor_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[Instructor_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "Instructor_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Instructor_Name", Instructor_Name);

            // date_Start
            date_Start = new (this, "x_date_Start", 135, SqlDbType.DateTime) {
                Name = "date_Start",
                Expression = "[date_Start]",
                BasicSearchExpression = CastDateFieldForLike("[date_Start]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[date_Start]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "date_Start", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Start", date_Start);

            // int_TotSession
            int_TotSession = new (this, "x_int_TotSession", 3, SqlDbType.Int) {
                Name = "int_TotSession",
                Expression = "[int_TotSession]",
                BasicSearchExpression = "CAST([int_TotSession] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_TotSession]",
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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "int_TotSession", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_TotSession", int_TotSession);

            // int_PerDaySession
            int_PerDaySession = new (this, "x_int_PerDaySession", 3, SqlDbType.Int) {
                Name = "int_PerDaySession",
                Expression = "[int_PerDaySession]",
                BasicSearchExpression = "CAST([int_PerDaySession] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_PerDaySession]",
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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "int_PerDaySession", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_PerDaySession", int_PerDaySession);

            // str_CR_Days
            str_CR_Days = new (this, "x_str_CR_Days", 202, SqlDbType.NVarChar) {
                Name = "str_CR_Days",
                Expression = "[str_CR_Days]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_CR_Days]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CR_Days]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "str_CR_Days", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CR_Days", str_CR_Days);

            // str_CR_Notes
            str_CR_Notes = new (this, "x_str_CR_Notes", 202, SqlDbType.NVarChar) {
                Name = "str_CR_Notes",
                Expression = "[str_CR_Notes]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_CR_Notes]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CR_Notes]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "str_CR_Notes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CR_Notes", str_CR_Notes);

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
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "int_Created_By", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "int_Modified_By", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Modified_By", int_Modified_By);

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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "date_Created", "CustomMsg"),
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
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "date_Modified", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "bit_IsDeleted", "CustomMsg"),
                IsUpload = false
            };
            bit_IsDeleted.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IsDeleted, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsDeleted, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IsDeleted, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_IsDeleted", bit_IsDeleted);

            // bit_AllTeacher
            bit_AllTeacher = new (this, "x_bit_AllTeacher", 11, SqlDbType.Bit) {
                Name = "bit_AllTeacher",
                Expression = "[bit_AllTeacher]",
                BasicSearchExpression = "[bit_AllTeacher]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_AllTeacher]",
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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "bit_AllTeacher", "CustomMsg"),
                IsUpload = false
            };
            bit_AllTeacher.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_AllTeacher, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_AllTeacher, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_AllTeacher, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_AllTeacher", bit_AllTeacher);

            // int_Manual_Change
            int_Manual_Change = new (this, "x_int_Manual_Change", 3, SqlDbType.Int) {
                Name = "int_Manual_Change",
                Expression = "[int_Manual_Change]",
                BasicSearchExpression = "CAST([int_Manual_Change] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Manual_Change]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "int_Manual_Change", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Manual_Change", int_Manual_Change);

            // str_WebDesc
            str_WebDesc = new (this, "x_str_WebDesc", 202, SqlDbType.NVarChar) {
                Name = "str_WebDesc",
                Expression = "[str_WebDesc]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_WebDesc]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_WebDesc]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "str_WebDesc", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_WebDesc", str_WebDesc);

            // is_Show
            is_Show = new (this, "x_is_Show", 11, SqlDbType.Bit) {
                Name = "is_Show",
                Expression = "[is_Show]",
                BasicSearchExpression = "[is_Show]",
                DateTimeFormat = -1,
                VirtualExpression = "[is_Show]",
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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "is_Show", "CustomMsg"),
                IsUpload = false
            };
            is_Show.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(is_Show, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(is_Show, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(is_Show, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("is_Show", is_Show);

            // is_ShowGridColumn
            is_ShowGridColumn = new (this, "x_is_ShowGridColumn", 11, SqlDbType.Bit) {
                Name = "is_ShowGridColumn",
                Expression = "[is_ShowGridColumn]",
                BasicSearchExpression = "[is_ShowGridColumn]",
                DateTimeFormat = -1,
                VirtualExpression = "[is_ShowGridColumn]",
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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "is_ShowGridColumn", "CustomMsg"),
                IsUpload = false
            };
            is_ShowGridColumn.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(is_ShowGridColumn, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(is_ShowGridColumn, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(is_ShowGridColumn, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("is_ShowGridColumn", is_ShowGridColumn);

            // rowIndex
            rowIndex = new (this, "x_rowIndex", 200, SqlDbType.VarChar) {
                Name = "rowIndex",
                Expression = "[rowIndex]",
                UseBasicSearch = true,
                BasicSearchExpression = "[rowIndex]",
                DateTimeFormat = -1,
                VirtualExpression = "[rowIndex]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "rowIndex", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("rowIndex", rowIndex);

            // is_ZoomMeet
            is_ZoomMeet = new (this, "x_is_ZoomMeet", 11, SqlDbType.Bit) {
                Name = "is_ZoomMeet",
                Expression = "[is_ZoomMeet]",
                BasicSearchExpression = "[is_ZoomMeet]",
                DateTimeFormat = -1,
                VirtualExpression = "[is_ZoomMeet]",
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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "is_ZoomMeet", "CustomMsg"),
                IsUpload = false
            };
            is_ZoomMeet.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(is_ZoomMeet, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(is_ZoomMeet, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(is_ZoomMeet, "qryCRSessionWsht", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("is_ZoomMeet", is_ZoomMeet);

            // Classroom_Internal_Cr_Notes
            Classroom_Internal_Cr_Notes = new (this, "x_Classroom_Internal_Cr_Notes", 203, SqlDbType.NText) {
                Name = "Classroom_Internal_Cr_Notes",
                Expression = "[Classroom_Internal_Cr_Notes]",
                BasicSearchExpression = "[Classroom_Internal_Cr_Notes]",
                DateTimeFormat = -1,
                VirtualExpression = "[Classroom_Internal_Cr_Notes]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "Classroom_Internal_Cr_Notes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Classroom_Internal_Cr_Notes", Classroom_Internal_Cr_Notes);

            // BulkCR_Set
            BulkCR_Set = new (this, "x_BulkCR_Set", 202, SqlDbType.NVarChar) {
                Name = "BulkCR_Set",
                Expression = "[BulkCR_Set]",
                UseBasicSearch = true,
                BasicSearchExpression = "[BulkCR_Set]",
                DateTimeFormat = -1,
                VirtualExpression = "[BulkCR_Set]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "BulkCR_Set", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("BulkCR_Set", BulkCR_Set);

            // int_Day_Incremental
            int_Day_Incremental = new (this, "x_int_Day_Incremental", 3, SqlDbType.Int) {
                Name = "int_Day_Incremental",
                Expression = "[int_Day_Incremental]",
                BasicSearchExpression = "CAST([int_Day_Incremental] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Day_Incremental]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "int_Day_Incremental", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Day_Incremental", int_Day_Incremental);

            // int_Reoccurrence
            int_Reoccurrence = new (this, "x_int_Reoccurrence", 3, SqlDbType.Int) {
                Name = "int_Reoccurrence",
                Expression = "[int_Reoccurrence]",
                BasicSearchExpression = "CAST([int_Reoccurrence] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Reoccurrence]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "int_Reoccurrence", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Reoccurrence", int_Reoccurrence);

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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "str_Username", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Username", str_Username);

            // Calendar_ID
            Calendar_ID = new (this, "x_Calendar_ID", 3, SqlDbType.Int) {
                Name = "Calendar_ID",
                Expression = "[Calendar_ID]",
                BasicSearchExpression = "CAST([Calendar_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Calendar_ID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "Calendar_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Calendar_ID", Calendar_ID);

            // str_Package_Name
            str_Package_Name = new (this, "x_str_Package_Name", 202, SqlDbType.NVarChar) {
                Name = "str_Package_Name",
                Expression = "[str_Package_Name]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Package_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Package_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "str_Package_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Package_Name", str_Package_Name);

            // int_Session_Id
            int_Session_Id = new (this, "x_int_Session_Id", 20, SqlDbType.BigInt) {
                Name = "int_Session_Id",
                Expression = "[int_Session_Id]",
                BasicSearchExpression = "CAST([int_Session_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Session_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "int_Session_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Session_Id", int_Session_Id);

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
                CustomMessage = Language.FieldPhrase("qryCRSessionWsht", "CRSS_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("CRSS_ID", CRSS_ID);

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
            get => _sqlFrom ?? "dbo.qryCRSessionWsht";
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
                result = await queryBuilder.InsertAsync(row);
            } catch (Exception e) {
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
                int_CR_ID.DbValue = row["int_CR_ID"]; // Set DB value only
                int_CR_Product_ID.DbValue = row["int_CR_Product_ID"]; // Set DB value only
                str_CR_Number.DbValue = row["str_CR_Number"]; // Set DB value only
                mon_CR_Price.DbValue = row["mon_CR_Price"]; // Set DB value only
                int_CR_Size.DbValue = row["int_CR_Size"]; // Set DB value only
                int_MU_Size.DbValue = row["int_MU_Size"]; // Set DB value only
                int_CR_Status.DbValue = row["int_CR_Status"]; // Set DB value only
                Is_Web_SignUp.DbValue = (ConvertToBool(row["Is_Web_SignUp"]) ? "1" : "0"); // Set DB value only
                int_Location_ID.DbValue = row["int_Location_ID"]; // Set DB value only
                int_Teacher_ID.DbValue = row["int_Teacher_ID"]; // Set DB value only
                Instructor_Name.DbValue = row["Instructor_Name"]; // Set DB value only
                date_Start.DbValue = row["date_Start"]; // Set DB value only
                int_TotSession.DbValue = row["int_TotSession"]; // Set DB value only
                int_PerDaySession.DbValue = row["int_PerDaySession"]; // Set DB value only
                str_CR_Days.DbValue = row["str_CR_Days"]; // Set DB value only
                str_CR_Notes.DbValue = row["str_CR_Notes"]; // Set DB value only
                int_Created_By.DbValue = row["int_Created_By"]; // Set DB value only
                int_Modified_By.DbValue = row["int_Modified_By"]; // Set DB value only
                date_Created.DbValue = row["date_Created"]; // Set DB value only
                date_Modified.DbValue = row["date_Modified"]; // Set DB value only
                bit_IsDeleted.DbValue = (ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"); // Set DB value only
                bit_AllTeacher.DbValue = (ConvertToBool(row["bit_AllTeacher"]) ? "1" : "0"); // Set DB value only
                int_Manual_Change.DbValue = row["int_Manual_Change"]; // Set DB value only
                str_WebDesc.DbValue = row["str_WebDesc"]; // Set DB value only
                is_Show.DbValue = (ConvertToBool(row["is_Show"]) ? "1" : "0"); // Set DB value only
                is_ShowGridColumn.DbValue = (ConvertToBool(row["is_ShowGridColumn"]) ? "1" : "0"); // Set DB value only
                rowIndex.DbValue = row["rowIndex"]; // Set DB value only
                is_ZoomMeet.DbValue = (ConvertToBool(row["is_ZoomMeet"]) ? "1" : "0"); // Set DB value only
                Classroom_Internal_Cr_Notes.DbValue = row["Classroom_Internal_Cr_Notes"]; // Set DB value only
                BulkCR_Set.DbValue = row["BulkCR_Set"]; // Set DB value only
                int_Day_Incremental.DbValue = row["int_Day_Incremental"]; // Set DB value only
                int_Reoccurrence.DbValue = row["int_Reoccurrence"]; // Set DB value only
                str_Username.DbValue = row["str_Username"]; // Set DB value only
                Calendar_ID.DbValue = row["Calendar_ID"]; // Set DB value only
                str_Package_Name.DbValue = row["str_Package_Name"]; // Set DB value only
                int_Session_Id.DbValue = row["int_Session_Id"]; // Set DB value only
                CRSS_ID.DbValue = row["CRSS_ID"]; // Set DB value only
            } catch {}
        }

        public void DeleteUploadedFiles(Dictionary<string, object> row)
        {
            LoadDbValues(row);
        }

        // Record filter WHERE clause
        private string _sqlKeyFilter => "";

        #pragma warning disable 168, 219
        // Get record filter as string
        public string GetRecordFilter(Dictionary<string, object>? row = null, bool current = false)
        {
            string keyFilter = _sqlKeyFilter;
            object? val = null, result = "";
            return keyFilter;
        }

        // Get record filter as Dictionary // DN
        public Dictionary<string, object>? GetRowFilterAsDictionary(IDictionary<string, object>? row = null)
        {
            Dictionary<string, object>? keyFilter = new ();
            object? val = null, result;
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
                    return "QryCrSessionWshtList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "QryCrSessionWshtView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "QryCrSessionWshtEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "QryCrSessionWshtAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "QryCrSessionWshtList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "QryCrSessionWshtView",
                Config.ApiAddAction => "QryCrSessionWshtAdd",
                Config.ApiEditAction => "QryCrSessionWshtEdit",
                Config.ApiDeleteAction => "QryCrSessionWshtDelete",
                Config.ApiListAction => "QryCrSessionWshtList",
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
        public string ListUrl => "QryCrSessionWshtList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("QryCrSessionWshtView", parm);
            else
                url = KeyUrl("QryCrSessionWshtView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "QryCrSessionWshtAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "QryCrSessionWshtAdd?" + parm;
            else
                url = "QryCrSessionWshtAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("QryCrSessionWshtEdit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("QryCrSessionWshtList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("QryCrSessionWshtAdd", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("QryCrSessionWshtList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("QryCrSessionWshtDelete")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
            return url;
        }

        // Get primary key as JSON
        public string KeyToJson(bool htmlEncode = false)
        {
            string json = "";
            json = "{" + json + "}";
            if (htmlEncode)
                json = HtmlEncode(json);
            return json;
        }

        // Add key value to URL
        public string KeyUrl(string url, string parm = "") { // DN
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
            return String.Join(Config.CompositeKeySeparator, keys);
        }

        // Get record filter as string // DN
        public string GetKey(IDictionary<string, object> row)
        {
            List<string> keys = new ();
            object? val = null, result;
            return String.Join(Config.CompositeKeySeparator, keys);
        }
        #pragma warning restore 168, 219

        // Set key
        public void SetKey(string key, bool current = false)
        {
            OldKey = key;
            string[] keys = OldKey.Split(Convert.ToChar(Config.CompositeKeySeparator));
            if (keys.Length == 0) {
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
                string[] keyValues = {};
                if (IsApi() && RouteValues.TryGetValue("key", out object? k)) {
                    string str = ConvertToString(k);
                    keyValues = str.Split('/');
                }
            }
            // Check keys
            foreach (var keys in keysList) {
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
            int_CR_ID.SetDbValue(dr["int_CR_ID"]);
            int_CR_Product_ID.SetDbValue(dr["int_CR_Product_ID"]);
            str_CR_Number.SetDbValue(dr["str_CR_Number"]);
            mon_CR_Price.SetDbValue(dr["mon_CR_Price"]);
            int_CR_Size.SetDbValue(dr["int_CR_Size"]);
            int_MU_Size.SetDbValue(dr["int_MU_Size"]);
            int_CR_Status.SetDbValue(dr["int_CR_Status"]);
            Is_Web_SignUp.SetDbValue(ConvertToBool(dr["Is_Web_SignUp"]) ? "1" : "0");
            int_Location_ID.SetDbValue(dr["int_Location_ID"]);
            int_Teacher_ID.SetDbValue(dr["int_Teacher_ID"]);
            Instructor_Name.SetDbValue(dr["Instructor_Name"]);
            date_Start.SetDbValue(dr["date_Start"]);
            int_TotSession.SetDbValue(dr["int_TotSession"]);
            int_PerDaySession.SetDbValue(dr["int_PerDaySession"]);
            str_CR_Days.SetDbValue(dr["str_CR_Days"]);
            str_CR_Notes.SetDbValue(dr["str_CR_Notes"]);
            int_Created_By.SetDbValue(dr["int_Created_By"]);
            int_Modified_By.SetDbValue(dr["int_Modified_By"]);
            date_Created.SetDbValue(dr["date_Created"]);
            date_Modified.SetDbValue(dr["date_Modified"]);
            bit_IsDeleted.SetDbValue(ConvertToBool(dr["bit_IsDeleted"]) ? "1" : "0");
            bit_AllTeacher.SetDbValue(ConvertToBool(dr["bit_AllTeacher"]) ? "1" : "0");
            int_Manual_Change.SetDbValue(dr["int_Manual_Change"]);
            str_WebDesc.SetDbValue(dr["str_WebDesc"]);
            is_Show.SetDbValue(ConvertToBool(dr["is_Show"]) ? "1" : "0");
            is_ShowGridColumn.SetDbValue(ConvertToBool(dr["is_ShowGridColumn"]) ? "1" : "0");
            rowIndex.SetDbValue(dr["rowIndex"]);
            is_ZoomMeet.SetDbValue(ConvertToBool(dr["is_ZoomMeet"]) ? "1" : "0");
            Classroom_Internal_Cr_Notes.SetDbValue(dr["Classroom_Internal_Cr_Notes"]);
            BulkCR_Set.SetDbValue(dr["BulkCR_Set"]);
            int_Day_Incremental.SetDbValue(dr["int_Day_Incremental"]);
            int_Reoccurrence.SetDbValue(dr["int_Reoccurrence"]);
            str_Username.SetDbValue(dr["str_Username"]);
            Calendar_ID.SetDbValue(dr["Calendar_ID"]);
            str_Package_Name.SetDbValue(dr["str_Package_Name"]);
            int_Session_Id.SetDbValue(dr["int_Session_Id"]);
            CRSS_ID.SetDbValue(dr["CRSS_ID"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "QryCrSessionWshtList";
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

            // int_CR_ID

            // int_CR_Product_ID

            // str_CR_Number

            // mon_CR_Price

            // int_CR_Size

            // int_MU_Size

            // int_CR_Status

            // Is_Web_SignUp

            // int_Location_ID

            // int_Teacher_ID

            // Instructor_Name

            // date_Start

            // int_TotSession

            // int_PerDaySession

            // str_CR_Days

            // str_CR_Notes

            // int_Created_By

            // int_Modified_By

            // date_Created

            // date_Modified

            // bit_IsDeleted

            // bit_AllTeacher

            // int_Manual_Change

            // str_WebDesc

            // is_Show

            // is_ShowGridColumn

            // rowIndex

            // is_ZoomMeet

            // Classroom_Internal_Cr_Notes

            // BulkCR_Set

            // int_Day_Incremental

            // int_Reoccurrence

            // str_Username

            // Calendar_ID

            // str_Package_Name

            // int_Session_Id

            // CRSS_ID

            // int_CR_ID
            int_CR_ID.ViewValue = int_CR_ID.CurrentValue;
            int_CR_ID.ViewValue = FormatNumber(int_CR_ID.ViewValue, int_CR_ID.FormatPattern);
            int_CR_ID.ViewCustomAttributes = "";

            // int_CR_Product_ID
            int_CR_Product_ID.ViewValue = int_CR_Product_ID.CurrentValue;
            int_CR_Product_ID.ViewValue = FormatNumber(int_CR_Product_ID.ViewValue, int_CR_Product_ID.FormatPattern);
            int_CR_Product_ID.ViewCustomAttributes = "";

            // str_CR_Number
            str_CR_Number.ViewValue = ConvertToString(str_CR_Number.CurrentValue); // DN
            str_CR_Number.ViewCustomAttributes = "";

            // mon_CR_Price
            mon_CR_Price.ViewValue = mon_CR_Price.CurrentValue;
            mon_CR_Price.ViewValue = FormatNumber(mon_CR_Price.ViewValue, mon_CR_Price.FormatPattern);
            mon_CR_Price.ViewCustomAttributes = "";

            // int_CR_Size
            int_CR_Size.ViewValue = int_CR_Size.CurrentValue;
            int_CR_Size.ViewValue = FormatNumber(int_CR_Size.ViewValue, int_CR_Size.FormatPattern);
            int_CR_Size.ViewCustomAttributes = "";

            // int_MU_Size
            int_MU_Size.ViewValue = int_MU_Size.CurrentValue;
            int_MU_Size.ViewValue = FormatNumber(int_MU_Size.ViewValue, int_MU_Size.FormatPattern);
            int_MU_Size.ViewCustomAttributes = "";

            // int_CR_Status
            int_CR_Status.ViewValue = int_CR_Status.CurrentValue;
            int_CR_Status.ViewValue = FormatNumber(int_CR_Status.ViewValue, int_CR_Status.FormatPattern);
            int_CR_Status.ViewCustomAttributes = "";

            // Is_Web_SignUp
            if (ConvertToBool(Is_Web_SignUp.CurrentValue)) {
                Is_Web_SignUp.ViewValue = Is_Web_SignUp.TagCaption(1) != "" ? Is_Web_SignUp.TagCaption(1) : "Yes";
            } else {
                Is_Web_SignUp.ViewValue = Is_Web_SignUp.TagCaption(2) != "" ? Is_Web_SignUp.TagCaption(2) : "No";
            }
            Is_Web_SignUp.ViewCustomAttributes = "";

            // int_Location_ID
            int_Location_ID.ViewValue = int_Location_ID.CurrentValue;
            int_Location_ID.ViewValue = FormatNumber(int_Location_ID.ViewValue, int_Location_ID.FormatPattern);
            int_Location_ID.ViewCustomAttributes = "";

            // int_Teacher_ID
            int_Teacher_ID.ViewValue = int_Teacher_ID.CurrentValue;
            int_Teacher_ID.ViewValue = FormatNumber(int_Teacher_ID.ViewValue, int_Teacher_ID.FormatPattern);
            int_Teacher_ID.ViewCustomAttributes = "";

            // Instructor_Name
            Instructor_Name.ViewValue = ConvertToString(Instructor_Name.CurrentValue); // DN
            Instructor_Name.ViewCustomAttributes = "";

            // date_Start
            date_Start.ViewValue = date_Start.CurrentValue;
            date_Start.ViewValue = FormatDateTime(date_Start.ViewValue, date_Start.FormatPattern);
            date_Start.ViewCustomAttributes = "";

            // int_TotSession
            int_TotSession.ViewValue = int_TotSession.CurrentValue;
            int_TotSession.ViewValue = FormatNumber(int_TotSession.ViewValue, int_TotSession.FormatPattern);
            int_TotSession.ViewCustomAttributes = "";

            // int_PerDaySession
            int_PerDaySession.ViewValue = int_PerDaySession.CurrentValue;
            int_PerDaySession.ViewValue = FormatNumber(int_PerDaySession.ViewValue, int_PerDaySession.FormatPattern);
            int_PerDaySession.ViewCustomAttributes = "";

            // str_CR_Days
            str_CR_Days.ViewValue = ConvertToString(str_CR_Days.CurrentValue); // DN
            str_CR_Days.ViewCustomAttributes = "";

            // str_CR_Notes
            str_CR_Notes.ViewValue = ConvertToString(str_CR_Notes.CurrentValue); // DN
            str_CR_Notes.ViewCustomAttributes = "";

            // int_Created_By
            int_Created_By.ViewValue = int_Created_By.CurrentValue;
            int_Created_By.ViewValue = FormatNumber(int_Created_By.ViewValue, int_Created_By.FormatPattern);
            int_Created_By.ViewCustomAttributes = "";

            // int_Modified_By
            int_Modified_By.ViewValue = int_Modified_By.CurrentValue;
            int_Modified_By.ViewValue = FormatNumber(int_Modified_By.ViewValue, int_Modified_By.FormatPattern);
            int_Modified_By.ViewCustomAttributes = "";

            // date_Created
            date_Created.ViewValue = date_Created.CurrentValue;
            date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
            date_Created.ViewCustomAttributes = "";

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

            // bit_AllTeacher
            if (ConvertToBool(bit_AllTeacher.CurrentValue)) {
                bit_AllTeacher.ViewValue = bit_AllTeacher.TagCaption(1) != "" ? bit_AllTeacher.TagCaption(1) : "Yes";
            } else {
                bit_AllTeacher.ViewValue = bit_AllTeacher.TagCaption(2) != "" ? bit_AllTeacher.TagCaption(2) : "No";
            }
            bit_AllTeacher.ViewCustomAttributes = "";

            // int_Manual_Change
            int_Manual_Change.ViewValue = int_Manual_Change.CurrentValue;
            int_Manual_Change.ViewValue = FormatNumber(int_Manual_Change.ViewValue, int_Manual_Change.FormatPattern);
            int_Manual_Change.ViewCustomAttributes = "";

            // str_WebDesc
            str_WebDesc.ViewValue = ConvertToString(str_WebDesc.CurrentValue); // DN
            str_WebDesc.ViewCustomAttributes = "";

            // is_Show
            if (ConvertToBool(is_Show.CurrentValue)) {
                is_Show.ViewValue = is_Show.TagCaption(1) != "" ? is_Show.TagCaption(1) : "Yes";
            } else {
                is_Show.ViewValue = is_Show.TagCaption(2) != "" ? is_Show.TagCaption(2) : "No";
            }
            is_Show.ViewCustomAttributes = "";

            // is_ShowGridColumn
            if (ConvertToBool(is_ShowGridColumn.CurrentValue)) {
                is_ShowGridColumn.ViewValue = is_ShowGridColumn.TagCaption(1) != "" ? is_ShowGridColumn.TagCaption(1) : "Yes";
            } else {
                is_ShowGridColumn.ViewValue = is_ShowGridColumn.TagCaption(2) != "" ? is_ShowGridColumn.TagCaption(2) : "No";
            }
            is_ShowGridColumn.ViewCustomAttributes = "";

            // rowIndex
            rowIndex.ViewValue = ConvertToString(rowIndex.CurrentValue); // DN
            rowIndex.ViewCustomAttributes = "";

            // is_ZoomMeet
            if (ConvertToBool(is_ZoomMeet.CurrentValue)) {
                is_ZoomMeet.ViewValue = is_ZoomMeet.TagCaption(1) != "" ? is_ZoomMeet.TagCaption(1) : "Yes";
            } else {
                is_ZoomMeet.ViewValue = is_ZoomMeet.TagCaption(2) != "" ? is_ZoomMeet.TagCaption(2) : "No";
            }
            is_ZoomMeet.ViewCustomAttributes = "";

            // Classroom_Internal_Cr_Notes
            Classroom_Internal_Cr_Notes.ViewValue = Classroom_Internal_Cr_Notes.CurrentValue;
            Classroom_Internal_Cr_Notes.ViewCustomAttributes = "";

            // BulkCR_Set
            BulkCR_Set.ViewValue = ConvertToString(BulkCR_Set.CurrentValue); // DN
            BulkCR_Set.ViewCustomAttributes = "";

            // int_Day_Incremental
            int_Day_Incremental.ViewValue = int_Day_Incremental.CurrentValue;
            int_Day_Incremental.ViewValue = FormatNumber(int_Day_Incremental.ViewValue, int_Day_Incremental.FormatPattern);
            int_Day_Incremental.ViewCustomAttributes = "";

            // int_Reoccurrence
            int_Reoccurrence.ViewValue = int_Reoccurrence.CurrentValue;
            int_Reoccurrence.ViewValue = FormatNumber(int_Reoccurrence.ViewValue, int_Reoccurrence.FormatPattern);
            int_Reoccurrence.ViewCustomAttributes = "";

            // str_Username
            str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
            str_Username.ViewCustomAttributes = "";

            // Calendar_ID
            Calendar_ID.ViewValue = Calendar_ID.CurrentValue;
            Calendar_ID.ViewValue = FormatNumber(Calendar_ID.ViewValue, Calendar_ID.FormatPattern);
            Calendar_ID.ViewCustomAttributes = "";

            // str_Package_Name
            str_Package_Name.ViewValue = ConvertToString(str_Package_Name.CurrentValue); // DN
            str_Package_Name.ViewCustomAttributes = "";

            // int_Session_Id
            int_Session_Id.ViewValue = int_Session_Id.CurrentValue;
            int_Session_Id.ViewValue = FormatNumber(int_Session_Id.ViewValue, int_Session_Id.FormatPattern);
            int_Session_Id.ViewCustomAttributes = "";

            // CRSS_ID
            CRSS_ID.ViewValue = CRSS_ID.CurrentValue;
            CRSS_ID.ViewValue = FormatNumber(CRSS_ID.ViewValue, CRSS_ID.FormatPattern);
            CRSS_ID.ViewCustomAttributes = "";

            // int_CR_ID
            int_CR_ID.HrefValue = "";
            int_CR_ID.TooltipValue = "";

            // int_CR_Product_ID
            int_CR_Product_ID.HrefValue = "";
            int_CR_Product_ID.TooltipValue = "";

            // str_CR_Number
            str_CR_Number.HrefValue = "";
            str_CR_Number.TooltipValue = "";

            // mon_CR_Price
            mon_CR_Price.HrefValue = "";
            mon_CR_Price.TooltipValue = "";

            // int_CR_Size
            int_CR_Size.HrefValue = "";
            int_CR_Size.TooltipValue = "";

            // int_MU_Size
            int_MU_Size.HrefValue = "";
            int_MU_Size.TooltipValue = "";

            // int_CR_Status
            int_CR_Status.HrefValue = "";
            int_CR_Status.TooltipValue = "";

            // Is_Web_SignUp
            Is_Web_SignUp.HrefValue = "";
            Is_Web_SignUp.TooltipValue = "";

            // int_Location_ID
            int_Location_ID.HrefValue = "";
            int_Location_ID.TooltipValue = "";

            // int_Teacher_ID
            int_Teacher_ID.HrefValue = "";
            int_Teacher_ID.TooltipValue = "";

            // Instructor_Name
            Instructor_Name.HrefValue = "";
            Instructor_Name.TooltipValue = "";

            // date_Start
            date_Start.HrefValue = "";
            date_Start.TooltipValue = "";

            // int_TotSession
            int_TotSession.HrefValue = "";
            int_TotSession.TooltipValue = "";

            // int_PerDaySession
            int_PerDaySession.HrefValue = "";
            int_PerDaySession.TooltipValue = "";

            // str_CR_Days
            str_CR_Days.HrefValue = "";
            str_CR_Days.TooltipValue = "";

            // str_CR_Notes
            str_CR_Notes.HrefValue = "";
            str_CR_Notes.TooltipValue = "";

            // int_Created_By
            int_Created_By.HrefValue = "";
            int_Created_By.TooltipValue = "";

            // int_Modified_By
            int_Modified_By.HrefValue = "";
            int_Modified_By.TooltipValue = "";

            // date_Created
            date_Created.HrefValue = "";
            date_Created.TooltipValue = "";

            // date_Modified
            date_Modified.HrefValue = "";
            date_Modified.TooltipValue = "";

            // bit_IsDeleted
            bit_IsDeleted.HrefValue = "";
            bit_IsDeleted.TooltipValue = "";

            // bit_AllTeacher
            bit_AllTeacher.HrefValue = "";
            bit_AllTeacher.TooltipValue = "";

            // int_Manual_Change
            int_Manual_Change.HrefValue = "";
            int_Manual_Change.TooltipValue = "";

            // str_WebDesc
            str_WebDesc.HrefValue = "";
            str_WebDesc.TooltipValue = "";

            // is_Show
            is_Show.HrefValue = "";
            is_Show.TooltipValue = "";

            // is_ShowGridColumn
            is_ShowGridColumn.HrefValue = "";
            is_ShowGridColumn.TooltipValue = "";

            // rowIndex
            rowIndex.HrefValue = "";
            rowIndex.TooltipValue = "";

            // is_ZoomMeet
            is_ZoomMeet.HrefValue = "";
            is_ZoomMeet.TooltipValue = "";

            // Classroom_Internal_Cr_Notes
            Classroom_Internal_Cr_Notes.HrefValue = "";
            Classroom_Internal_Cr_Notes.TooltipValue = "";

            // BulkCR_Set
            BulkCR_Set.HrefValue = "";
            BulkCR_Set.TooltipValue = "";

            // int_Day_Incremental
            int_Day_Incremental.HrefValue = "";
            int_Day_Incremental.TooltipValue = "";

            // int_Reoccurrence
            int_Reoccurrence.HrefValue = "";
            int_Reoccurrence.TooltipValue = "";

            // str_Username
            str_Username.HrefValue = "";
            str_Username.TooltipValue = "";

            // Calendar_ID
            Calendar_ID.HrefValue = "";
            Calendar_ID.TooltipValue = "";

            // str_Package_Name
            str_Package_Name.HrefValue = "";
            str_Package_Name.TooltipValue = "";

            // int_Session_Id
            int_Session_Id.HrefValue = "";
            int_Session_Id.TooltipValue = "";

            // CRSS_ID
            CRSS_ID.HrefValue = "";
            CRSS_ID.TooltipValue = "";

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

            // int_CR_ID
            int_CR_ID.SetupEditAttributes();
            int_CR_ID.EditValue = int_CR_ID.CurrentValue; // DN
            int_CR_ID.PlaceHolder = RemoveHtml(int_CR_ID.Caption);
            if (!Empty(int_CR_ID.EditValue) && IsNumeric(int_CR_ID.EditValue))
                int_CR_ID.EditValue = FormatNumber(int_CR_ID.EditValue, null);

            // int_CR_Product_ID
            int_CR_Product_ID.SetupEditAttributes();
            int_CR_Product_ID.EditValue = int_CR_Product_ID.CurrentValue; // DN
            int_CR_Product_ID.PlaceHolder = RemoveHtml(int_CR_Product_ID.Caption);
            if (!Empty(int_CR_Product_ID.EditValue) && IsNumeric(int_CR_Product_ID.EditValue))
                int_CR_Product_ID.EditValue = FormatNumber(int_CR_Product_ID.EditValue, null);

            // str_CR_Number
            str_CR_Number.SetupEditAttributes();
            if (!str_CR_Number.Raw)
                str_CR_Number.CurrentValue = HtmlDecode(str_CR_Number.CurrentValue);
            str_CR_Number.EditValue = HtmlEncode(str_CR_Number.CurrentValue);
            str_CR_Number.PlaceHolder = RemoveHtml(str_CR_Number.Caption);

            // mon_CR_Price
            mon_CR_Price.SetupEditAttributes();
            mon_CR_Price.EditValue = mon_CR_Price.CurrentValue; // DN
            mon_CR_Price.PlaceHolder = RemoveHtml(mon_CR_Price.Caption);
            if (!Empty(mon_CR_Price.EditValue) && IsNumeric(mon_CR_Price.EditValue))
                mon_CR_Price.EditValue = FormatNumber(mon_CR_Price.EditValue, null);

            // int_CR_Size
            int_CR_Size.SetupEditAttributes();
            int_CR_Size.EditValue = int_CR_Size.CurrentValue; // DN
            int_CR_Size.PlaceHolder = RemoveHtml(int_CR_Size.Caption);
            if (!Empty(int_CR_Size.EditValue) && IsNumeric(int_CR_Size.EditValue))
                int_CR_Size.EditValue = FormatNumber(int_CR_Size.EditValue, null);

            // int_MU_Size
            int_MU_Size.SetupEditAttributes();
            int_MU_Size.EditValue = int_MU_Size.CurrentValue; // DN
            int_MU_Size.PlaceHolder = RemoveHtml(int_MU_Size.Caption);
            if (!Empty(int_MU_Size.EditValue) && IsNumeric(int_MU_Size.EditValue))
                int_MU_Size.EditValue = FormatNumber(int_MU_Size.EditValue, null);

            // int_CR_Status
            int_CR_Status.SetupEditAttributes();
            int_CR_Status.EditValue = int_CR_Status.CurrentValue; // DN
            int_CR_Status.PlaceHolder = RemoveHtml(int_CR_Status.Caption);
            if (!Empty(int_CR_Status.EditValue) && IsNumeric(int_CR_Status.EditValue))
                int_CR_Status.EditValue = FormatNumber(int_CR_Status.EditValue, null);

            // Is_Web_SignUp
            Is_Web_SignUp.EditValue = Is_Web_SignUp.Options(false);
            Is_Web_SignUp.PlaceHolder = RemoveHtml(Is_Web_SignUp.Caption);

            // int_Location_ID
            int_Location_ID.SetupEditAttributes();
            int_Location_ID.EditValue = int_Location_ID.CurrentValue; // DN
            int_Location_ID.PlaceHolder = RemoveHtml(int_Location_ID.Caption);
            if (!Empty(int_Location_ID.EditValue) && IsNumeric(int_Location_ID.EditValue))
                int_Location_ID.EditValue = FormatNumber(int_Location_ID.EditValue, null);

            // int_Teacher_ID
            int_Teacher_ID.SetupEditAttributes();
            int_Teacher_ID.EditValue = int_Teacher_ID.CurrentValue; // DN
            int_Teacher_ID.PlaceHolder = RemoveHtml(int_Teacher_ID.Caption);
            if (!Empty(int_Teacher_ID.EditValue) && IsNumeric(int_Teacher_ID.EditValue))
                int_Teacher_ID.EditValue = FormatNumber(int_Teacher_ID.EditValue, null);

            // Instructor_Name
            Instructor_Name.SetupEditAttributes();
            if (!Instructor_Name.Raw)
                Instructor_Name.CurrentValue = HtmlDecode(Instructor_Name.CurrentValue);
            Instructor_Name.EditValue = HtmlEncode(Instructor_Name.CurrentValue);
            Instructor_Name.PlaceHolder = RemoveHtml(Instructor_Name.Caption);

            // date_Start
            date_Start.SetupEditAttributes();
            date_Start.EditValue = FormatDateTime(date_Start.CurrentValue, date_Start.FormatPattern); // DN
            date_Start.PlaceHolder = RemoveHtml(date_Start.Caption);

            // int_TotSession
            int_TotSession.SetupEditAttributes();
            int_TotSession.EditValue = int_TotSession.CurrentValue; // DN
            int_TotSession.PlaceHolder = RemoveHtml(int_TotSession.Caption);
            if (!Empty(int_TotSession.EditValue) && IsNumeric(int_TotSession.EditValue))
                int_TotSession.EditValue = FormatNumber(int_TotSession.EditValue, null);

            // int_PerDaySession
            int_PerDaySession.SetupEditAttributes();
            int_PerDaySession.EditValue = int_PerDaySession.CurrentValue; // DN
            int_PerDaySession.PlaceHolder = RemoveHtml(int_PerDaySession.Caption);
            if (!Empty(int_PerDaySession.EditValue) && IsNumeric(int_PerDaySession.EditValue))
                int_PerDaySession.EditValue = FormatNumber(int_PerDaySession.EditValue, null);

            // str_CR_Days
            str_CR_Days.SetupEditAttributes();
            if (!str_CR_Days.Raw)
                str_CR_Days.CurrentValue = HtmlDecode(str_CR_Days.CurrentValue);
            str_CR_Days.EditValue = HtmlEncode(str_CR_Days.CurrentValue);
            str_CR_Days.PlaceHolder = RemoveHtml(str_CR_Days.Caption);

            // str_CR_Notes
            str_CR_Notes.SetupEditAttributes();
            if (!str_CR_Notes.Raw)
                str_CR_Notes.CurrentValue = HtmlDecode(str_CR_Notes.CurrentValue);
            str_CR_Notes.EditValue = HtmlEncode(str_CR_Notes.CurrentValue);
            str_CR_Notes.PlaceHolder = RemoveHtml(str_CR_Notes.Caption);

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

            // date_Created
            date_Created.SetupEditAttributes();
            date_Created.EditValue = FormatDateTime(date_Created.CurrentValue, date_Created.FormatPattern); // DN
            date_Created.PlaceHolder = RemoveHtml(date_Created.Caption);

            // date_Modified
            date_Modified.SetupEditAttributes();
            date_Modified.EditValue = FormatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern); // DN
            date_Modified.PlaceHolder = RemoveHtml(date_Modified.Caption);

            // bit_IsDeleted
            bit_IsDeleted.EditValue = bit_IsDeleted.Options(false);
            bit_IsDeleted.PlaceHolder = RemoveHtml(bit_IsDeleted.Caption);

            // bit_AllTeacher
            bit_AllTeacher.EditValue = bit_AllTeacher.Options(false);
            bit_AllTeacher.PlaceHolder = RemoveHtml(bit_AllTeacher.Caption);

            // int_Manual_Change
            int_Manual_Change.SetupEditAttributes();
            int_Manual_Change.EditValue = int_Manual_Change.CurrentValue; // DN
            int_Manual_Change.PlaceHolder = RemoveHtml(int_Manual_Change.Caption);
            if (!Empty(int_Manual_Change.EditValue) && IsNumeric(int_Manual_Change.EditValue))
                int_Manual_Change.EditValue = FormatNumber(int_Manual_Change.EditValue, null);

            // str_WebDesc
            str_WebDesc.SetupEditAttributes();
            if (!str_WebDesc.Raw)
                str_WebDesc.CurrentValue = HtmlDecode(str_WebDesc.CurrentValue);
            str_WebDesc.EditValue = HtmlEncode(str_WebDesc.CurrentValue);
            str_WebDesc.PlaceHolder = RemoveHtml(str_WebDesc.Caption);

            // is_Show
            is_Show.EditValue = is_Show.Options(false);
            is_Show.PlaceHolder = RemoveHtml(is_Show.Caption);

            // is_ShowGridColumn
            is_ShowGridColumn.EditValue = is_ShowGridColumn.Options(false);
            is_ShowGridColumn.PlaceHolder = RemoveHtml(is_ShowGridColumn.Caption);

            // rowIndex
            rowIndex.SetupEditAttributes();
            if (!rowIndex.Raw)
                rowIndex.CurrentValue = HtmlDecode(rowIndex.CurrentValue);
            rowIndex.EditValue = HtmlEncode(rowIndex.CurrentValue);
            rowIndex.PlaceHolder = RemoveHtml(rowIndex.Caption);

            // is_ZoomMeet
            is_ZoomMeet.EditValue = is_ZoomMeet.Options(false);
            is_ZoomMeet.PlaceHolder = RemoveHtml(is_ZoomMeet.Caption);

            // Classroom_Internal_Cr_Notes
            Classroom_Internal_Cr_Notes.SetupEditAttributes();
            Classroom_Internal_Cr_Notes.EditValue = Classroom_Internal_Cr_Notes.CurrentValue; // DN
            Classroom_Internal_Cr_Notes.PlaceHolder = RemoveHtml(Classroom_Internal_Cr_Notes.Caption);

            // BulkCR_Set
            BulkCR_Set.SetupEditAttributes();
            if (!BulkCR_Set.Raw)
                BulkCR_Set.CurrentValue = HtmlDecode(BulkCR_Set.CurrentValue);
            BulkCR_Set.EditValue = HtmlEncode(BulkCR_Set.CurrentValue);
            BulkCR_Set.PlaceHolder = RemoveHtml(BulkCR_Set.Caption);

            // int_Day_Incremental
            int_Day_Incremental.SetupEditAttributes();
            int_Day_Incremental.EditValue = int_Day_Incremental.CurrentValue; // DN
            int_Day_Incremental.PlaceHolder = RemoveHtml(int_Day_Incremental.Caption);
            if (!Empty(int_Day_Incremental.EditValue) && IsNumeric(int_Day_Incremental.EditValue))
                int_Day_Incremental.EditValue = FormatNumber(int_Day_Incremental.EditValue, null);

            // int_Reoccurrence
            int_Reoccurrence.SetupEditAttributes();
            int_Reoccurrence.EditValue = int_Reoccurrence.CurrentValue; // DN
            int_Reoccurrence.PlaceHolder = RemoveHtml(int_Reoccurrence.Caption);
            if (!Empty(int_Reoccurrence.EditValue) && IsNumeric(int_Reoccurrence.EditValue))
                int_Reoccurrence.EditValue = FormatNumber(int_Reoccurrence.EditValue, null);

            // str_Username
            str_Username.SetupEditAttributes();
            if (!str_Username.Raw)
                str_Username.CurrentValue = HtmlDecode(str_Username.CurrentValue);
            str_Username.EditValue = HtmlEncode(str_Username.CurrentValue);
            str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);

            // Calendar_ID
            Calendar_ID.SetupEditAttributes();
            Calendar_ID.EditValue = Calendar_ID.CurrentValue; // DN
            Calendar_ID.PlaceHolder = RemoveHtml(Calendar_ID.Caption);
            if (!Empty(Calendar_ID.EditValue) && IsNumeric(Calendar_ID.EditValue))
                Calendar_ID.EditValue = FormatNumber(Calendar_ID.EditValue, null);

            // str_Package_Name
            str_Package_Name.SetupEditAttributes();
            if (!str_Package_Name.Raw)
                str_Package_Name.CurrentValue = HtmlDecode(str_Package_Name.CurrentValue);
            str_Package_Name.EditValue = HtmlEncode(str_Package_Name.CurrentValue);
            str_Package_Name.PlaceHolder = RemoveHtml(str_Package_Name.Caption);

            // int_Session_Id
            int_Session_Id.SetupEditAttributes();
            int_Session_Id.EditValue = int_Session_Id.CurrentValue; // DN
            int_Session_Id.PlaceHolder = RemoveHtml(int_Session_Id.Caption);
            if (!Empty(int_Session_Id.EditValue) && IsNumeric(int_Session_Id.EditValue))
                int_Session_Id.EditValue = FormatNumber(int_Session_Id.EditValue, null);

            // CRSS_ID
            CRSS_ID.SetupEditAttributes();
            CRSS_ID.EditValue = CRSS_ID.CurrentValue; // DN
            CRSS_ID.PlaceHolder = RemoveHtml(CRSS_ID.Caption);
            if (!Empty(CRSS_ID.EditValue) && IsNumeric(CRSS_ID.EditValue))
                CRSS_ID.EditValue = FormatNumber(CRSS_ID.EditValue, null);

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
                        doc.ExportCaption(int_CR_ID);
                        doc.ExportCaption(int_CR_Product_ID);
                        doc.ExportCaption(str_CR_Number);
                        doc.ExportCaption(mon_CR_Price);
                        doc.ExportCaption(int_CR_Size);
                        doc.ExportCaption(int_MU_Size);
                        doc.ExportCaption(int_CR_Status);
                        doc.ExportCaption(Is_Web_SignUp);
                        doc.ExportCaption(int_Location_ID);
                        doc.ExportCaption(int_Teacher_ID);
                        doc.ExportCaption(Instructor_Name);
                        doc.ExportCaption(date_Start);
                        doc.ExportCaption(int_TotSession);
                        doc.ExportCaption(int_PerDaySession);
                        doc.ExportCaption(str_CR_Days);
                        doc.ExportCaption(str_CR_Notes);
                        doc.ExportCaption(int_Created_By);
                        doc.ExportCaption(int_Modified_By);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(bit_IsDeleted);
                        doc.ExportCaption(bit_AllTeacher);
                        doc.ExportCaption(int_Manual_Change);
                        doc.ExportCaption(str_WebDesc);
                        doc.ExportCaption(is_Show);
                        doc.ExportCaption(is_ShowGridColumn);
                        doc.ExportCaption(rowIndex);
                        doc.ExportCaption(is_ZoomMeet);
                        doc.ExportCaption(Classroom_Internal_Cr_Notes);
                        doc.ExportCaption(BulkCR_Set);
                        doc.ExportCaption(int_Day_Incremental);
                        doc.ExportCaption(int_Reoccurrence);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(Calendar_ID);
                        doc.ExportCaption(str_Package_Name);
                        doc.ExportCaption(int_Session_Id);
                        doc.ExportCaption(CRSS_ID);
                    } else {
                        doc.ExportCaption(int_CR_ID);
                        doc.ExportCaption(int_CR_Product_ID);
                        doc.ExportCaption(str_CR_Number);
                        doc.ExportCaption(mon_CR_Price);
                        doc.ExportCaption(int_CR_Size);
                        doc.ExportCaption(int_MU_Size);
                        doc.ExportCaption(int_CR_Status);
                        doc.ExportCaption(Is_Web_SignUp);
                        doc.ExportCaption(int_Location_ID);
                        doc.ExportCaption(int_Teacher_ID);
                        doc.ExportCaption(Instructor_Name);
                        doc.ExportCaption(date_Start);
                        doc.ExportCaption(int_TotSession);
                        doc.ExportCaption(int_PerDaySession);
                        doc.ExportCaption(str_CR_Days);
                        doc.ExportCaption(str_CR_Notes);
                        doc.ExportCaption(int_Created_By);
                        doc.ExportCaption(int_Modified_By);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(bit_IsDeleted);
                        doc.ExportCaption(bit_AllTeacher);
                        doc.ExportCaption(int_Manual_Change);
                        doc.ExportCaption(str_WebDesc);
                        doc.ExportCaption(is_Show);
                        doc.ExportCaption(is_ShowGridColumn);
                        doc.ExportCaption(rowIndex);
                        doc.ExportCaption(is_ZoomMeet);
                        doc.ExportCaption(BulkCR_Set);
                        doc.ExportCaption(int_Day_Incremental);
                        doc.ExportCaption(int_Reoccurrence);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(Calendar_ID);
                        doc.ExportCaption(str_Package_Name);
                        doc.ExportCaption(int_Session_Id);
                        doc.ExportCaption(CRSS_ID);
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
                            await doc.ExportField(int_CR_ID);
                            await doc.ExportField(int_CR_Product_ID);
                            await doc.ExportField(str_CR_Number);
                            await doc.ExportField(mon_CR_Price);
                            await doc.ExportField(int_CR_Size);
                            await doc.ExportField(int_MU_Size);
                            await doc.ExportField(int_CR_Status);
                            await doc.ExportField(Is_Web_SignUp);
                            await doc.ExportField(int_Location_ID);
                            await doc.ExportField(int_Teacher_ID);
                            await doc.ExportField(Instructor_Name);
                            await doc.ExportField(date_Start);
                            await doc.ExportField(int_TotSession);
                            await doc.ExportField(int_PerDaySession);
                            await doc.ExportField(str_CR_Days);
                            await doc.ExportField(str_CR_Notes);
                            await doc.ExportField(int_Created_By);
                            await doc.ExportField(int_Modified_By);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(bit_IsDeleted);
                            await doc.ExportField(bit_AllTeacher);
                            await doc.ExportField(int_Manual_Change);
                            await doc.ExportField(str_WebDesc);
                            await doc.ExportField(is_Show);
                            await doc.ExportField(is_ShowGridColumn);
                            await doc.ExportField(rowIndex);
                            await doc.ExportField(is_ZoomMeet);
                            await doc.ExportField(Classroom_Internal_Cr_Notes);
                            await doc.ExportField(BulkCR_Set);
                            await doc.ExportField(int_Day_Incremental);
                            await doc.ExportField(int_Reoccurrence);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(Calendar_ID);
                            await doc.ExportField(str_Package_Name);
                            await doc.ExportField(int_Session_Id);
                            await doc.ExportField(CRSS_ID);
                        } else {
                            await doc.ExportField(int_CR_ID);
                            await doc.ExportField(int_CR_Product_ID);
                            await doc.ExportField(str_CR_Number);
                            await doc.ExportField(mon_CR_Price);
                            await doc.ExportField(int_CR_Size);
                            await doc.ExportField(int_MU_Size);
                            await doc.ExportField(int_CR_Status);
                            await doc.ExportField(Is_Web_SignUp);
                            await doc.ExportField(int_Location_ID);
                            await doc.ExportField(int_Teacher_ID);
                            await doc.ExportField(Instructor_Name);
                            await doc.ExportField(date_Start);
                            await doc.ExportField(int_TotSession);
                            await doc.ExportField(int_PerDaySession);
                            await doc.ExportField(str_CR_Days);
                            await doc.ExportField(str_CR_Notes);
                            await doc.ExportField(int_Created_By);
                            await doc.ExportField(int_Modified_By);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(bit_IsDeleted);
                            await doc.ExportField(bit_AllTeacher);
                            await doc.ExportField(int_Manual_Change);
                            await doc.ExportField(str_WebDesc);
                            await doc.ExportField(is_Show);
                            await doc.ExportField(is_ShowGridColumn);
                            await doc.ExportField(rowIndex);
                            await doc.ExportField(is_ZoomMeet);
                            await doc.ExportField(BulkCR_Set);
                            await doc.ExportField(int_Day_Incremental);
                            await doc.ExportField(int_Reoccurrence);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(Calendar_ID);
                            await doc.ExportField(str_Package_Name);
                            await doc.ExportField(int_Session_Id);
                            await doc.ExportField(CRSS_ID);
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
