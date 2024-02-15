namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// lmsEnrolments
    /// </summary>
    [MaybeNull]
    public static LmsEnrolments lmsEnrolments
    {
        get => HttpData.Resolve<LmsEnrolments>("LMS_Enrolments");
        set => HttpData["LMS_Enrolments"] = value;
    }

    /// <summary>
    /// Table class for LMS_Enrolments
    /// </summary>
    public class LmsEnrolments : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> id;

        public readonly DbField<SqlDbType> enrol;

        public readonly DbField<SqlDbType> status;

        public readonly DbField<SqlDbType> courseid;

        public readonly DbField<SqlDbType> sortorder;

        public readonly DbField<SqlDbType> _name;

        public readonly DbField<SqlDbType> enrolperiod;

        public readonly DbField<SqlDbType> enrolstartdate;

        public readonly DbField<SqlDbType> enrolenddate;

        public readonly DbField<SqlDbType> expirynotify;

        public readonly DbField<SqlDbType> expirythreshold;

        public readonly DbField<SqlDbType> notifyall;

        public readonly DbField<SqlDbType> password;

        public readonly DbField<SqlDbType> cost;

        public readonly DbField<SqlDbType> currency;

        public readonly DbField<SqlDbType> roleid;

        public readonly DbField<SqlDbType> customint1;

        public readonly DbField<SqlDbType> customint2;

        public readonly DbField<SqlDbType> customint3;

        public readonly DbField<SqlDbType> customint4;

        public readonly DbField<SqlDbType> customint5;

        public readonly DbField<SqlDbType> customint6;

        public readonly DbField<SqlDbType> customint7;

        public readonly DbField<SqlDbType> customint8;

        public readonly DbField<SqlDbType> customchar1;

        public readonly DbField<SqlDbType> customchar2;

        public readonly DbField<SqlDbType> customchar3;

        public readonly DbField<SqlDbType> customdec1;

        public readonly DbField<SqlDbType> customdec2;

        public readonly DbField<SqlDbType> customtext1;

        public readonly DbField<SqlDbType> customtext2;

        public readonly DbField<SqlDbType> customtext3;

        public readonly DbField<SqlDbType> customtext4;

        public readonly DbField<SqlDbType> timecreated;

        public readonly DbField<SqlDbType> timemodified;

        // Constructor
        public LmsEnrolments()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "LMS_Enrolments";
            Name = "LMS_Enrolments";
            Type = "VIEW";
            UpdateTable = "dbo.LMS_Enrolments"; // Update Table
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

            // id
            id = new (this, "x_id", 20, SqlDbType.BigInt) {
                Name = "id",
                Expression = "[id]",
                BasicSearchExpression = "CAST([id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("id", id);

            // enrol
            enrol = new (this, "x_enrol", 200, SqlDbType.VarChar) {
                Name = "enrol",
                Expression = "[enrol]",
                UseBasicSearch = true,
                BasicSearchExpression = "[enrol]",
                DateTimeFormat = -1,
                VirtualExpression = "[enrol]",
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
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "enrol", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("enrol", enrol);

            // status
            status = new (this, "x_status", 20, SqlDbType.BigInt) {
                Name = "status",
                Expression = "[status]",
                BasicSearchExpression = "CAST([status] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[status]",
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
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "status", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("status", status);

            // courseid
            courseid = new (this, "x_courseid", 20, SqlDbType.BigInt) {
                Name = "courseid",
                Expression = "[courseid]",
                BasicSearchExpression = "CAST([courseid] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[courseid]",
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
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "courseid", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("courseid", courseid);

            // sortorder
            sortorder = new (this, "x_sortorder", 20, SqlDbType.BigInt) {
                Name = "sortorder",
                Expression = "[sortorder]",
                BasicSearchExpression = "CAST([sortorder] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[sortorder]",
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
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "sortorder", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("sortorder", sortorder);

            // name
            _name = new (this, "x__name", 200, SqlDbType.VarChar) {
                Name = "name",
                Expression = "[name]",
                UseBasicSearch = true,
                BasicSearchExpression = "[name]",
                DateTimeFormat = -1,
                VirtualExpression = "[name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "_name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("name", _name);

            // enrolperiod
            enrolperiod = new (this, "x_enrolperiod", 20, SqlDbType.BigInt) {
                Name = "enrolperiod",
                Expression = "[enrolperiod]",
                BasicSearchExpression = "CAST([enrolperiod] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[enrolperiod]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "enrolperiod", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("enrolperiod", enrolperiod);

            // enrolstartdate
            enrolstartdate = new (this, "x_enrolstartdate", 20, SqlDbType.BigInt) {
                Name = "enrolstartdate",
                Expression = "[enrolstartdate]",
                BasicSearchExpression = "CAST([enrolstartdate] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[enrolstartdate]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "enrolstartdate", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("enrolstartdate", enrolstartdate);

            // enrolenddate
            enrolenddate = new (this, "x_enrolenddate", 20, SqlDbType.BigInt) {
                Name = "enrolenddate",
                Expression = "[enrolenddate]",
                BasicSearchExpression = "CAST([enrolenddate] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[enrolenddate]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "enrolenddate", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("enrolenddate", enrolenddate);

            // expirynotify
            expirynotify = new (this, "x_expirynotify", 131, SqlDbType.Decimal) {
                Name = "expirynotify",
                Expression = "[expirynotify]",
                BasicSearchExpression = "CAST([expirynotify] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[expirynotify]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "expirynotify", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("expirynotify", expirynotify);

            // expirythreshold
            expirythreshold = new (this, "x_expirythreshold", 20, SqlDbType.BigInt) {
                Name = "expirythreshold",
                Expression = "[expirythreshold]",
                BasicSearchExpression = "CAST([expirythreshold] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[expirythreshold]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "expirythreshold", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("expirythreshold", expirythreshold);

            // notifyall
            notifyall = new (this, "x_notifyall", 131, SqlDbType.Decimal) {
                Name = "notifyall",
                Expression = "[notifyall]",
                BasicSearchExpression = "CAST([notifyall] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[notifyall]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "notifyall", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("notifyall", notifyall);

            // password
            password = new (this, "x_password", 200, SqlDbType.VarChar) {
                Name = "password",
                Expression = "[password]",
                UseBasicSearch = true,
                BasicSearchExpression = "[password]",
                DateTimeFormat = -1,
                VirtualExpression = "[password]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "password", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("password", password);

            // cost
            cost = new (this, "x_cost", 200, SqlDbType.VarChar) {
                Name = "cost",
                Expression = "[cost]",
                UseBasicSearch = true,
                BasicSearchExpression = "[cost]",
                DateTimeFormat = -1,
                VirtualExpression = "[cost]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "cost", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("cost", cost);

            // currency
            currency = new (this, "x_currency", 200, SqlDbType.VarChar) {
                Name = "currency",
                Expression = "[currency]",
                UseBasicSearch = true,
                BasicSearchExpression = "[currency]",
                DateTimeFormat = -1,
                VirtualExpression = "[currency]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "currency", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("currency", currency);

            // roleid
            roleid = new (this, "x_roleid", 20, SqlDbType.BigInt) {
                Name = "roleid",
                Expression = "[roleid]",
                BasicSearchExpression = "CAST([roleid] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[roleid]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "roleid", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("roleid", roleid);

            // customint1
            customint1 = new (this, "x_customint1", 20, SqlDbType.BigInt) {
                Name = "customint1",
                Expression = "[customint1]",
                BasicSearchExpression = "CAST([customint1] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[customint1]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "customint1", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("customint1", customint1);

            // customint2
            customint2 = new (this, "x_customint2", 20, SqlDbType.BigInt) {
                Name = "customint2",
                Expression = "[customint2]",
                BasicSearchExpression = "CAST([customint2] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[customint2]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "customint2", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("customint2", customint2);

            // customint3
            customint3 = new (this, "x_customint3", 20, SqlDbType.BigInt) {
                Name = "customint3",
                Expression = "[customint3]",
                BasicSearchExpression = "CAST([customint3] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[customint3]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "customint3", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("customint3", customint3);

            // customint4
            customint4 = new (this, "x_customint4", 20, SqlDbType.BigInt) {
                Name = "customint4",
                Expression = "[customint4]",
                BasicSearchExpression = "CAST([customint4] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[customint4]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "customint4", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("customint4", customint4);

            // customint5
            customint5 = new (this, "x_customint5", 20, SqlDbType.BigInt) {
                Name = "customint5",
                Expression = "[customint5]",
                BasicSearchExpression = "CAST([customint5] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[customint5]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "customint5", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("customint5", customint5);

            // customint6
            customint6 = new (this, "x_customint6", 20, SqlDbType.BigInt) {
                Name = "customint6",
                Expression = "[customint6]",
                BasicSearchExpression = "CAST([customint6] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[customint6]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "customint6", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("customint6", customint6);

            // customint7
            customint7 = new (this, "x_customint7", 20, SqlDbType.BigInt) {
                Name = "customint7",
                Expression = "[customint7]",
                BasicSearchExpression = "CAST([customint7] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[customint7]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "customint7", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("customint7", customint7);

            // customint8
            customint8 = new (this, "x_customint8", 20, SqlDbType.BigInt) {
                Name = "customint8",
                Expression = "[customint8]",
                BasicSearchExpression = "CAST([customint8] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[customint8]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "customint8", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("customint8", customint8);

            // customchar1
            customchar1 = new (this, "x_customchar1", 200, SqlDbType.VarChar) {
                Name = "customchar1",
                Expression = "[customchar1]",
                UseBasicSearch = true,
                BasicSearchExpression = "[customchar1]",
                DateTimeFormat = -1,
                VirtualExpression = "[customchar1]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "customchar1", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("customchar1", customchar1);

            // customchar2
            customchar2 = new (this, "x_customchar2", 200, SqlDbType.VarChar) {
                Name = "customchar2",
                Expression = "[customchar2]",
                UseBasicSearch = true,
                BasicSearchExpression = "[customchar2]",
                DateTimeFormat = -1,
                VirtualExpression = "[customchar2]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "customchar2", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("customchar2", customchar2);

            // customchar3
            customchar3 = new (this, "x_customchar3", 200, SqlDbType.VarChar) {
                Name = "customchar3",
                Expression = "[customchar3]",
                UseBasicSearch = true,
                BasicSearchExpression = "[customchar3]",
                DateTimeFormat = -1,
                VirtualExpression = "[customchar3]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "customchar3", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("customchar3", customchar3);

            // customdec1
            customdec1 = new (this, "x_customdec1", 131, SqlDbType.Decimal) {
                Name = "customdec1",
                Expression = "[customdec1]",
                BasicSearchExpression = "CAST([customdec1] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[customdec1]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "customdec1", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("customdec1", customdec1);

            // customdec2
            customdec2 = new (this, "x_customdec2", 131, SqlDbType.Decimal) {
                Name = "customdec2",
                Expression = "[customdec2]",
                BasicSearchExpression = "CAST([customdec2] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[customdec2]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "customdec2", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("customdec2", customdec2);

            // customtext1
            customtext1 = new (this, "x_customtext1", 200, SqlDbType.VarChar) {
                Name = "customtext1",
                Expression = "[customtext1]",
                UseBasicSearch = true,
                BasicSearchExpression = "[customtext1]",
                DateTimeFormat = -1,
                VirtualExpression = "[customtext1]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "customtext1", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("customtext1", customtext1);

            // customtext2
            customtext2 = new (this, "x_customtext2", 200, SqlDbType.VarChar) {
                Name = "customtext2",
                Expression = "[customtext2]",
                UseBasicSearch = true,
                BasicSearchExpression = "[customtext2]",
                DateTimeFormat = -1,
                VirtualExpression = "[customtext2]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "customtext2", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("customtext2", customtext2);

            // customtext3
            customtext3 = new (this, "x_customtext3", 200, SqlDbType.VarChar) {
                Name = "customtext3",
                Expression = "[customtext3]",
                UseBasicSearch = true,
                BasicSearchExpression = "[customtext3]",
                DateTimeFormat = -1,
                VirtualExpression = "[customtext3]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "customtext3", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("customtext3", customtext3);

            // customtext4
            customtext4 = new (this, "x_customtext4", 200, SqlDbType.VarChar) {
                Name = "customtext4",
                Expression = "[customtext4]",
                UseBasicSearch = true,
                BasicSearchExpression = "[customtext4]",
                DateTimeFormat = -1,
                VirtualExpression = "[customtext4]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "customtext4", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("customtext4", customtext4);

            // timecreated
            timecreated = new (this, "x_timecreated", 20, SqlDbType.BigInt) {
                Name = "timecreated",
                Expression = "[timecreated]",
                BasicSearchExpression = "CAST([timecreated] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[timecreated]",
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
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "timecreated", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("timecreated", timecreated);

            // timemodified
            timemodified = new (this, "x_timemodified", 20, SqlDbType.BigInt) {
                Name = "timemodified",
                Expression = "[timemodified]",
                BasicSearchExpression = "CAST([timemodified] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[timemodified]",
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
                CustomMessage = Language.FieldPhrase("LMS_Enrolments", "timemodified", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("timemodified", timemodified);

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
            get => _sqlFrom ?? "dbo.LMS_Enrolments";
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
                id.DbValue = row["id"]; // Set DB value only
                enrol.DbValue = row["enrol"]; // Set DB value only
                status.DbValue = row["status"]; // Set DB value only
                courseid.DbValue = row["courseid"]; // Set DB value only
                sortorder.DbValue = row["sortorder"]; // Set DB value only
                _name.DbValue = row["name"]; // Set DB value only
                enrolperiod.DbValue = row["enrolperiod"]; // Set DB value only
                enrolstartdate.DbValue = row["enrolstartdate"]; // Set DB value only
                enrolenddate.DbValue = row["enrolenddate"]; // Set DB value only
                expirynotify.DbValue = row["expirynotify"]; // Set DB value only
                expirythreshold.DbValue = row["expirythreshold"]; // Set DB value only
                notifyall.DbValue = row["notifyall"]; // Set DB value only
                password.DbValue = row["password"]; // Set DB value only
                cost.DbValue = row["cost"]; // Set DB value only
                currency.DbValue = row["currency"]; // Set DB value only
                roleid.DbValue = row["roleid"]; // Set DB value only
                customint1.DbValue = row["customint1"]; // Set DB value only
                customint2.DbValue = row["customint2"]; // Set DB value only
                customint3.DbValue = row["customint3"]; // Set DB value only
                customint4.DbValue = row["customint4"]; // Set DB value only
                customint5.DbValue = row["customint5"]; // Set DB value only
                customint6.DbValue = row["customint6"]; // Set DB value only
                customint7.DbValue = row["customint7"]; // Set DB value only
                customint8.DbValue = row["customint8"]; // Set DB value only
                customchar1.DbValue = row["customchar1"]; // Set DB value only
                customchar2.DbValue = row["customchar2"]; // Set DB value only
                customchar3.DbValue = row["customchar3"]; // Set DB value only
                customdec1.DbValue = row["customdec1"]; // Set DB value only
                customdec2.DbValue = row["customdec2"]; // Set DB value only
                customtext1.DbValue = row["customtext1"]; // Set DB value only
                customtext2.DbValue = row["customtext2"]; // Set DB value only
                customtext3.DbValue = row["customtext3"]; // Set DB value only
                customtext4.DbValue = row["customtext4"]; // Set DB value only
                timecreated.DbValue = row["timecreated"]; // Set DB value only
                timemodified.DbValue = row["timemodified"]; // Set DB value only
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
                    return "LmsEnrolmentsList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "LmsEnrolmentsView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "LmsEnrolmentsEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "LmsEnrolmentsAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "LmsEnrolmentsList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "LmsEnrolmentsView",
                Config.ApiAddAction => "LmsEnrolmentsAdd",
                Config.ApiEditAction => "LmsEnrolmentsEdit",
                Config.ApiDeleteAction => "LmsEnrolmentsDelete",
                Config.ApiListAction => "LmsEnrolmentsList",
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
        public string ListUrl => "LmsEnrolmentsList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("LmsEnrolmentsView", parm);
            else
                url = KeyUrl("LmsEnrolmentsView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "LmsEnrolmentsAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "LmsEnrolmentsAdd?" + parm;
            else
                url = "LmsEnrolmentsAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("LmsEnrolmentsEdit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("LmsEnrolmentsList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("LmsEnrolmentsAdd", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("LmsEnrolmentsList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("LmsEnrolmentsDelete")); // DN

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
            id.SetDbValue(dr["id"]);
            enrol.SetDbValue(dr["enrol"]);
            status.SetDbValue(dr["status"]);
            courseid.SetDbValue(dr["courseid"]);
            sortorder.SetDbValue(dr["sortorder"]);
            _name.SetDbValue(dr["name"]);
            enrolperiod.SetDbValue(dr["enrolperiod"]);
            enrolstartdate.SetDbValue(dr["enrolstartdate"]);
            enrolenddate.SetDbValue(dr["enrolenddate"]);
            expirynotify.SetDbValue(dr["expirynotify"]);
            expirythreshold.SetDbValue(dr["expirythreshold"]);
            notifyall.SetDbValue(dr["notifyall"]);
            password.SetDbValue(dr["password"]);
            cost.SetDbValue(dr["cost"]);
            currency.SetDbValue(dr["currency"]);
            roleid.SetDbValue(dr["roleid"]);
            customint1.SetDbValue(dr["customint1"]);
            customint2.SetDbValue(dr["customint2"]);
            customint3.SetDbValue(dr["customint3"]);
            customint4.SetDbValue(dr["customint4"]);
            customint5.SetDbValue(dr["customint5"]);
            customint6.SetDbValue(dr["customint6"]);
            customint7.SetDbValue(dr["customint7"]);
            customint8.SetDbValue(dr["customint8"]);
            customchar1.SetDbValue(dr["customchar1"]);
            customchar2.SetDbValue(dr["customchar2"]);
            customchar3.SetDbValue(dr["customchar3"]);
            customdec1.SetDbValue(dr["customdec1"]);
            customdec2.SetDbValue(dr["customdec2"]);
            customtext1.SetDbValue(dr["customtext1"]);
            customtext2.SetDbValue(dr["customtext2"]);
            customtext3.SetDbValue(dr["customtext3"]);
            customtext4.SetDbValue(dr["customtext4"]);
            timecreated.SetDbValue(dr["timecreated"]);
            timemodified.SetDbValue(dr["timemodified"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "LmsEnrolmentsList";
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

            // id

            // enrol

            // status

            // courseid

            // sortorder

            // name

            // enrolperiod

            // enrolstartdate

            // enrolenddate

            // expirynotify

            // expirythreshold

            // notifyall

            // password

            // cost

            // currency

            // roleid

            // customint1

            // customint2

            // customint3

            // customint4

            // customint5

            // customint6

            // customint7

            // customint8

            // customchar1

            // customchar2

            // customchar3

            // customdec1

            // customdec2

            // customtext1

            // customtext2

            // customtext3

            // customtext4

            // timecreated

            // timemodified

            // id
            id.ViewValue = id.CurrentValue;
            id.ViewValue = FormatNumber(id.ViewValue, id.FormatPattern);
            id.ViewCustomAttributes = "";

            // enrol
            enrol.ViewValue = ConvertToString(enrol.CurrentValue); // DN
            enrol.ViewCustomAttributes = "";

            // status
            status.ViewValue = status.CurrentValue;
            status.ViewValue = FormatNumber(status.ViewValue, status.FormatPattern);
            status.ViewCustomAttributes = "";

            // courseid
            courseid.ViewValue = courseid.CurrentValue;
            courseid.ViewValue = FormatNumber(courseid.ViewValue, courseid.FormatPattern);
            courseid.ViewCustomAttributes = "";

            // sortorder
            sortorder.ViewValue = sortorder.CurrentValue;
            sortorder.ViewValue = FormatNumber(sortorder.ViewValue, sortorder.FormatPattern);
            sortorder.ViewCustomAttributes = "";

            // name
            _name.ViewValue = ConvertToString(_name.CurrentValue); // DN
            _name.ViewCustomAttributes = "";

            // enrolperiod
            enrolperiod.ViewValue = enrolperiod.CurrentValue;
            enrolperiod.ViewValue = FormatNumber(enrolperiod.ViewValue, enrolperiod.FormatPattern);
            enrolperiod.ViewCustomAttributes = "";

            // enrolstartdate
            enrolstartdate.ViewValue = enrolstartdate.CurrentValue;
            enrolstartdate.ViewValue = FormatNumber(enrolstartdate.ViewValue, enrolstartdate.FormatPattern);
            enrolstartdate.ViewCustomAttributes = "";

            // enrolenddate
            enrolenddate.ViewValue = enrolenddate.CurrentValue;
            enrolenddate.ViewValue = FormatNumber(enrolenddate.ViewValue, enrolenddate.FormatPattern);
            enrolenddate.ViewCustomAttributes = "";

            // expirynotify
            expirynotify.ViewValue = expirynotify.CurrentValue;
            expirynotify.ViewValue = FormatNumber(expirynotify.ViewValue, expirynotify.FormatPattern);
            expirynotify.ViewCustomAttributes = "";

            // expirythreshold
            expirythreshold.ViewValue = expirythreshold.CurrentValue;
            expirythreshold.ViewValue = FormatNumber(expirythreshold.ViewValue, expirythreshold.FormatPattern);
            expirythreshold.ViewCustomAttributes = "";

            // notifyall
            notifyall.ViewValue = notifyall.CurrentValue;
            notifyall.ViewValue = FormatNumber(notifyall.ViewValue, notifyall.FormatPattern);
            notifyall.ViewCustomAttributes = "";

            // password
            password.ViewValue = ConvertToString(password.CurrentValue); // DN
            password.ViewCustomAttributes = "";

            // cost
            cost.ViewValue = ConvertToString(cost.CurrentValue); // DN
            cost.ViewCustomAttributes = "";

            // currency
            currency.ViewValue = ConvertToString(currency.CurrentValue); // DN
            currency.ViewCustomAttributes = "";

            // roleid
            roleid.ViewValue = roleid.CurrentValue;
            roleid.ViewValue = FormatNumber(roleid.ViewValue, roleid.FormatPattern);
            roleid.ViewCustomAttributes = "";

            // customint1
            customint1.ViewValue = customint1.CurrentValue;
            customint1.ViewValue = FormatNumber(customint1.ViewValue, customint1.FormatPattern);
            customint1.ViewCustomAttributes = "";

            // customint2
            customint2.ViewValue = customint2.CurrentValue;
            customint2.ViewValue = FormatNumber(customint2.ViewValue, customint2.FormatPattern);
            customint2.ViewCustomAttributes = "";

            // customint3
            customint3.ViewValue = customint3.CurrentValue;
            customint3.ViewValue = FormatNumber(customint3.ViewValue, customint3.FormatPattern);
            customint3.ViewCustomAttributes = "";

            // customint4
            customint4.ViewValue = customint4.CurrentValue;
            customint4.ViewValue = FormatNumber(customint4.ViewValue, customint4.FormatPattern);
            customint4.ViewCustomAttributes = "";

            // customint5
            customint5.ViewValue = customint5.CurrentValue;
            customint5.ViewValue = FormatNumber(customint5.ViewValue, customint5.FormatPattern);
            customint5.ViewCustomAttributes = "";

            // customint6
            customint6.ViewValue = customint6.CurrentValue;
            customint6.ViewValue = FormatNumber(customint6.ViewValue, customint6.FormatPattern);
            customint6.ViewCustomAttributes = "";

            // customint7
            customint7.ViewValue = customint7.CurrentValue;
            customint7.ViewValue = FormatNumber(customint7.ViewValue, customint7.FormatPattern);
            customint7.ViewCustomAttributes = "";

            // customint8
            customint8.ViewValue = customint8.CurrentValue;
            customint8.ViewValue = FormatNumber(customint8.ViewValue, customint8.FormatPattern);
            customint8.ViewCustomAttributes = "";

            // customchar1
            customchar1.ViewValue = ConvertToString(customchar1.CurrentValue); // DN
            customchar1.ViewCustomAttributes = "";

            // customchar2
            customchar2.ViewValue = ConvertToString(customchar2.CurrentValue); // DN
            customchar2.ViewCustomAttributes = "";

            // customchar3
            customchar3.ViewValue = ConvertToString(customchar3.CurrentValue); // DN
            customchar3.ViewCustomAttributes = "";

            // customdec1
            customdec1.ViewValue = customdec1.CurrentValue;
            customdec1.ViewValue = FormatNumber(customdec1.ViewValue, customdec1.FormatPattern);
            customdec1.ViewCustomAttributes = "";

            // customdec2
            customdec2.ViewValue = customdec2.CurrentValue;
            customdec2.ViewValue = FormatNumber(customdec2.ViewValue, customdec2.FormatPattern);
            customdec2.ViewCustomAttributes = "";

            // customtext1
            customtext1.ViewValue = ConvertToString(customtext1.CurrentValue); // DN
            customtext1.ViewCustomAttributes = "";

            // customtext2
            customtext2.ViewValue = ConvertToString(customtext2.CurrentValue); // DN
            customtext2.ViewCustomAttributes = "";

            // customtext3
            customtext3.ViewValue = ConvertToString(customtext3.CurrentValue); // DN
            customtext3.ViewCustomAttributes = "";

            // customtext4
            customtext4.ViewValue = ConvertToString(customtext4.CurrentValue); // DN
            customtext4.ViewCustomAttributes = "";

            // timecreated
            timecreated.ViewValue = timecreated.CurrentValue;
            timecreated.ViewValue = FormatNumber(timecreated.ViewValue, timecreated.FormatPattern);
            timecreated.ViewCustomAttributes = "";

            // timemodified
            timemodified.ViewValue = timemodified.CurrentValue;
            timemodified.ViewValue = FormatNumber(timemodified.ViewValue, timemodified.FormatPattern);
            timemodified.ViewCustomAttributes = "";

            // id
            id.HrefValue = "";
            id.TooltipValue = "";

            // enrol
            enrol.HrefValue = "";
            enrol.TooltipValue = "";

            // status
            status.HrefValue = "";
            status.TooltipValue = "";

            // courseid
            courseid.HrefValue = "";
            courseid.TooltipValue = "";

            // sortorder
            sortorder.HrefValue = "";
            sortorder.TooltipValue = "";

            // name
            _name.HrefValue = "";
            _name.TooltipValue = "";

            // enrolperiod
            enrolperiod.HrefValue = "";
            enrolperiod.TooltipValue = "";

            // enrolstartdate
            enrolstartdate.HrefValue = "";
            enrolstartdate.TooltipValue = "";

            // enrolenddate
            enrolenddate.HrefValue = "";
            enrolenddate.TooltipValue = "";

            // expirynotify
            expirynotify.HrefValue = "";
            expirynotify.TooltipValue = "";

            // expirythreshold
            expirythreshold.HrefValue = "";
            expirythreshold.TooltipValue = "";

            // notifyall
            notifyall.HrefValue = "";
            notifyall.TooltipValue = "";

            // password
            password.HrefValue = "";
            password.TooltipValue = "";

            // cost
            cost.HrefValue = "";
            cost.TooltipValue = "";

            // currency
            currency.HrefValue = "";
            currency.TooltipValue = "";

            // roleid
            roleid.HrefValue = "";
            roleid.TooltipValue = "";

            // customint1
            customint1.HrefValue = "";
            customint1.TooltipValue = "";

            // customint2
            customint2.HrefValue = "";
            customint2.TooltipValue = "";

            // customint3
            customint3.HrefValue = "";
            customint3.TooltipValue = "";

            // customint4
            customint4.HrefValue = "";
            customint4.TooltipValue = "";

            // customint5
            customint5.HrefValue = "";
            customint5.TooltipValue = "";

            // customint6
            customint6.HrefValue = "";
            customint6.TooltipValue = "";

            // customint7
            customint7.HrefValue = "";
            customint7.TooltipValue = "";

            // customint8
            customint8.HrefValue = "";
            customint8.TooltipValue = "";

            // customchar1
            customchar1.HrefValue = "";
            customchar1.TooltipValue = "";

            // customchar2
            customchar2.HrefValue = "";
            customchar2.TooltipValue = "";

            // customchar3
            customchar3.HrefValue = "";
            customchar3.TooltipValue = "";

            // customdec1
            customdec1.HrefValue = "";
            customdec1.TooltipValue = "";

            // customdec2
            customdec2.HrefValue = "";
            customdec2.TooltipValue = "";

            // customtext1
            customtext1.HrefValue = "";
            customtext1.TooltipValue = "";

            // customtext2
            customtext2.HrefValue = "";
            customtext2.TooltipValue = "";

            // customtext3
            customtext3.HrefValue = "";
            customtext3.TooltipValue = "";

            // customtext4
            customtext4.HrefValue = "";
            customtext4.TooltipValue = "";

            // timecreated
            timecreated.HrefValue = "";
            timecreated.TooltipValue = "";

            // timemodified
            timemodified.HrefValue = "";
            timemodified.TooltipValue = "";

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

            // id
            id.SetupEditAttributes();
            id.EditValue = id.CurrentValue; // DN
            id.PlaceHolder = RemoveHtml(id.Caption);
            if (!Empty(id.EditValue) && IsNumeric(id.EditValue))
                id.EditValue = FormatNumber(id.EditValue, null);

            // enrol
            enrol.SetupEditAttributes();
            if (!enrol.Raw)
                enrol.CurrentValue = HtmlDecode(enrol.CurrentValue);
            enrol.EditValue = HtmlEncode(enrol.CurrentValue);
            enrol.PlaceHolder = RemoveHtml(enrol.Caption);

            // status
            status.SetupEditAttributes();
            status.EditValue = status.CurrentValue; // DN
            status.PlaceHolder = RemoveHtml(status.Caption);
            if (!Empty(status.EditValue) && IsNumeric(status.EditValue))
                status.EditValue = FormatNumber(status.EditValue, null);

            // courseid
            courseid.SetupEditAttributes();
            courseid.EditValue = courseid.CurrentValue; // DN
            courseid.PlaceHolder = RemoveHtml(courseid.Caption);
            if (!Empty(courseid.EditValue) && IsNumeric(courseid.EditValue))
                courseid.EditValue = FormatNumber(courseid.EditValue, null);

            // sortorder
            sortorder.SetupEditAttributes();
            sortorder.EditValue = sortorder.CurrentValue; // DN
            sortorder.PlaceHolder = RemoveHtml(sortorder.Caption);
            if (!Empty(sortorder.EditValue) && IsNumeric(sortorder.EditValue))
                sortorder.EditValue = FormatNumber(sortorder.EditValue, null);

            // name
            _name.SetupEditAttributes();
            if (!_name.Raw)
                _name.CurrentValue = HtmlDecode(_name.CurrentValue);
            _name.EditValue = HtmlEncode(_name.CurrentValue);
            _name.PlaceHolder = RemoveHtml(_name.Caption);

            // enrolperiod
            enrolperiod.SetupEditAttributes();
            enrolperiod.EditValue = enrolperiod.CurrentValue; // DN
            enrolperiod.PlaceHolder = RemoveHtml(enrolperiod.Caption);
            if (!Empty(enrolperiod.EditValue) && IsNumeric(enrolperiod.EditValue))
                enrolperiod.EditValue = FormatNumber(enrolperiod.EditValue, null);

            // enrolstartdate
            enrolstartdate.SetupEditAttributes();
            enrolstartdate.EditValue = enrolstartdate.CurrentValue; // DN
            enrolstartdate.PlaceHolder = RemoveHtml(enrolstartdate.Caption);
            if (!Empty(enrolstartdate.EditValue) && IsNumeric(enrolstartdate.EditValue))
                enrolstartdate.EditValue = FormatNumber(enrolstartdate.EditValue, null);

            // enrolenddate
            enrolenddate.SetupEditAttributes();
            enrolenddate.EditValue = enrolenddate.CurrentValue; // DN
            enrolenddate.PlaceHolder = RemoveHtml(enrolenddate.Caption);
            if (!Empty(enrolenddate.EditValue) && IsNumeric(enrolenddate.EditValue))
                enrolenddate.EditValue = FormatNumber(enrolenddate.EditValue, null);

            // expirynotify
            expirynotify.SetupEditAttributes();
            expirynotify.EditValue = expirynotify.CurrentValue; // DN
            expirynotify.PlaceHolder = RemoveHtml(expirynotify.Caption);
            if (!Empty(expirynotify.EditValue) && IsNumeric(expirynotify.EditValue))
                expirynotify.EditValue = FormatNumber(expirynotify.EditValue, null);

            // expirythreshold
            expirythreshold.SetupEditAttributes();
            expirythreshold.EditValue = expirythreshold.CurrentValue; // DN
            expirythreshold.PlaceHolder = RemoveHtml(expirythreshold.Caption);
            if (!Empty(expirythreshold.EditValue) && IsNumeric(expirythreshold.EditValue))
                expirythreshold.EditValue = FormatNumber(expirythreshold.EditValue, null);

            // notifyall
            notifyall.SetupEditAttributes();
            notifyall.EditValue = notifyall.CurrentValue; // DN
            notifyall.PlaceHolder = RemoveHtml(notifyall.Caption);
            if (!Empty(notifyall.EditValue) && IsNumeric(notifyall.EditValue))
                notifyall.EditValue = FormatNumber(notifyall.EditValue, null);

            // password
            password.SetupEditAttributes();
            if (!password.Raw)
                password.CurrentValue = HtmlDecode(password.CurrentValue);
            password.EditValue = HtmlEncode(password.CurrentValue);
            password.PlaceHolder = RemoveHtml(password.Caption);

            // cost
            cost.SetupEditAttributes();
            if (!cost.Raw)
                cost.CurrentValue = HtmlDecode(cost.CurrentValue);
            cost.EditValue = HtmlEncode(cost.CurrentValue);
            cost.PlaceHolder = RemoveHtml(cost.Caption);

            // currency
            currency.SetupEditAttributes();
            if (!currency.Raw)
                currency.CurrentValue = HtmlDecode(currency.CurrentValue);
            currency.EditValue = HtmlEncode(currency.CurrentValue);
            currency.PlaceHolder = RemoveHtml(currency.Caption);

            // roleid
            roleid.SetupEditAttributes();
            roleid.EditValue = roleid.CurrentValue; // DN
            roleid.PlaceHolder = RemoveHtml(roleid.Caption);
            if (!Empty(roleid.EditValue) && IsNumeric(roleid.EditValue))
                roleid.EditValue = FormatNumber(roleid.EditValue, null);

            // customint1
            customint1.SetupEditAttributes();
            customint1.EditValue = customint1.CurrentValue; // DN
            customint1.PlaceHolder = RemoveHtml(customint1.Caption);
            if (!Empty(customint1.EditValue) && IsNumeric(customint1.EditValue))
                customint1.EditValue = FormatNumber(customint1.EditValue, null);

            // customint2
            customint2.SetupEditAttributes();
            customint2.EditValue = customint2.CurrentValue; // DN
            customint2.PlaceHolder = RemoveHtml(customint2.Caption);
            if (!Empty(customint2.EditValue) && IsNumeric(customint2.EditValue))
                customint2.EditValue = FormatNumber(customint2.EditValue, null);

            // customint3
            customint3.SetupEditAttributes();
            customint3.EditValue = customint3.CurrentValue; // DN
            customint3.PlaceHolder = RemoveHtml(customint3.Caption);
            if (!Empty(customint3.EditValue) && IsNumeric(customint3.EditValue))
                customint3.EditValue = FormatNumber(customint3.EditValue, null);

            // customint4
            customint4.SetupEditAttributes();
            customint4.EditValue = customint4.CurrentValue; // DN
            customint4.PlaceHolder = RemoveHtml(customint4.Caption);
            if (!Empty(customint4.EditValue) && IsNumeric(customint4.EditValue))
                customint4.EditValue = FormatNumber(customint4.EditValue, null);

            // customint5
            customint5.SetupEditAttributes();
            customint5.EditValue = customint5.CurrentValue; // DN
            customint5.PlaceHolder = RemoveHtml(customint5.Caption);
            if (!Empty(customint5.EditValue) && IsNumeric(customint5.EditValue))
                customint5.EditValue = FormatNumber(customint5.EditValue, null);

            // customint6
            customint6.SetupEditAttributes();
            customint6.EditValue = customint6.CurrentValue; // DN
            customint6.PlaceHolder = RemoveHtml(customint6.Caption);
            if (!Empty(customint6.EditValue) && IsNumeric(customint6.EditValue))
                customint6.EditValue = FormatNumber(customint6.EditValue, null);

            // customint7
            customint7.SetupEditAttributes();
            customint7.EditValue = customint7.CurrentValue; // DN
            customint7.PlaceHolder = RemoveHtml(customint7.Caption);
            if (!Empty(customint7.EditValue) && IsNumeric(customint7.EditValue))
                customint7.EditValue = FormatNumber(customint7.EditValue, null);

            // customint8
            customint8.SetupEditAttributes();
            customint8.EditValue = customint8.CurrentValue; // DN
            customint8.PlaceHolder = RemoveHtml(customint8.Caption);
            if (!Empty(customint8.EditValue) && IsNumeric(customint8.EditValue))
                customint8.EditValue = FormatNumber(customint8.EditValue, null);

            // customchar1
            customchar1.SetupEditAttributes();
            if (!customchar1.Raw)
                customchar1.CurrentValue = HtmlDecode(customchar1.CurrentValue);
            customchar1.EditValue = HtmlEncode(customchar1.CurrentValue);
            customchar1.PlaceHolder = RemoveHtml(customchar1.Caption);

            // customchar2
            customchar2.SetupEditAttributes();
            if (!customchar2.Raw)
                customchar2.CurrentValue = HtmlDecode(customchar2.CurrentValue);
            customchar2.EditValue = HtmlEncode(customchar2.CurrentValue);
            customchar2.PlaceHolder = RemoveHtml(customchar2.Caption);

            // customchar3
            customchar3.SetupEditAttributes();
            if (!customchar3.Raw)
                customchar3.CurrentValue = HtmlDecode(customchar3.CurrentValue);
            customchar3.EditValue = HtmlEncode(customchar3.CurrentValue);
            customchar3.PlaceHolder = RemoveHtml(customchar3.Caption);

            // customdec1
            customdec1.SetupEditAttributes();
            customdec1.EditValue = customdec1.CurrentValue; // DN
            customdec1.PlaceHolder = RemoveHtml(customdec1.Caption);
            if (!Empty(customdec1.EditValue) && IsNumeric(customdec1.EditValue))
                customdec1.EditValue = FormatNumber(customdec1.EditValue, null);

            // customdec2
            customdec2.SetupEditAttributes();
            customdec2.EditValue = customdec2.CurrentValue; // DN
            customdec2.PlaceHolder = RemoveHtml(customdec2.Caption);
            if (!Empty(customdec2.EditValue) && IsNumeric(customdec2.EditValue))
                customdec2.EditValue = FormatNumber(customdec2.EditValue, null);

            // customtext1
            customtext1.SetupEditAttributes();
            if (!customtext1.Raw)
                customtext1.CurrentValue = HtmlDecode(customtext1.CurrentValue);
            customtext1.EditValue = HtmlEncode(customtext1.CurrentValue);
            customtext1.PlaceHolder = RemoveHtml(customtext1.Caption);

            // customtext2
            customtext2.SetupEditAttributes();
            if (!customtext2.Raw)
                customtext2.CurrentValue = HtmlDecode(customtext2.CurrentValue);
            customtext2.EditValue = HtmlEncode(customtext2.CurrentValue);
            customtext2.PlaceHolder = RemoveHtml(customtext2.Caption);

            // customtext3
            customtext3.SetupEditAttributes();
            if (!customtext3.Raw)
                customtext3.CurrentValue = HtmlDecode(customtext3.CurrentValue);
            customtext3.EditValue = HtmlEncode(customtext3.CurrentValue);
            customtext3.PlaceHolder = RemoveHtml(customtext3.Caption);

            // customtext4
            customtext4.SetupEditAttributes();
            if (!customtext4.Raw)
                customtext4.CurrentValue = HtmlDecode(customtext4.CurrentValue);
            customtext4.EditValue = HtmlEncode(customtext4.CurrentValue);
            customtext4.PlaceHolder = RemoveHtml(customtext4.Caption);

            // timecreated
            timecreated.SetupEditAttributes();
            timecreated.EditValue = timecreated.CurrentValue; // DN
            timecreated.PlaceHolder = RemoveHtml(timecreated.Caption);
            if (!Empty(timecreated.EditValue) && IsNumeric(timecreated.EditValue))
                timecreated.EditValue = FormatNumber(timecreated.EditValue, null);

            // timemodified
            timemodified.SetupEditAttributes();
            timemodified.EditValue = timemodified.CurrentValue; // DN
            timemodified.PlaceHolder = RemoveHtml(timemodified.Caption);
            if (!Empty(timemodified.EditValue) && IsNumeric(timemodified.EditValue))
                timemodified.EditValue = FormatNumber(timemodified.EditValue, null);

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
                        doc.ExportCaption(id);
                        doc.ExportCaption(enrol);
                        doc.ExportCaption(status);
                        doc.ExportCaption(courseid);
                        doc.ExportCaption(sortorder);
                        doc.ExportCaption(_name);
                        doc.ExportCaption(enrolperiod);
                        doc.ExportCaption(enrolstartdate);
                        doc.ExportCaption(enrolenddate);
                        doc.ExportCaption(expirynotify);
                        doc.ExportCaption(expirythreshold);
                        doc.ExportCaption(notifyall);
                        doc.ExportCaption(password);
                        doc.ExportCaption(cost);
                        doc.ExportCaption(currency);
                        doc.ExportCaption(roleid);
                        doc.ExportCaption(customint1);
                        doc.ExportCaption(customint2);
                        doc.ExportCaption(customint3);
                        doc.ExportCaption(customint4);
                        doc.ExportCaption(customint5);
                        doc.ExportCaption(customint6);
                        doc.ExportCaption(customint7);
                        doc.ExportCaption(customint8);
                        doc.ExportCaption(customchar1);
                        doc.ExportCaption(customchar2);
                        doc.ExportCaption(customchar3);
                        doc.ExportCaption(customdec1);
                        doc.ExportCaption(customdec2);
                        doc.ExportCaption(customtext1);
                        doc.ExportCaption(customtext2);
                        doc.ExportCaption(customtext3);
                        doc.ExportCaption(customtext4);
                        doc.ExportCaption(timecreated);
                        doc.ExportCaption(timemodified);
                    } else {
                        doc.ExportCaption(id);
                        doc.ExportCaption(enrol);
                        doc.ExportCaption(status);
                        doc.ExportCaption(courseid);
                        doc.ExportCaption(sortorder);
                        doc.ExportCaption(_name);
                        doc.ExportCaption(enrolperiod);
                        doc.ExportCaption(enrolstartdate);
                        doc.ExportCaption(enrolenddate);
                        doc.ExportCaption(expirynotify);
                        doc.ExportCaption(expirythreshold);
                        doc.ExportCaption(notifyall);
                        doc.ExportCaption(password);
                        doc.ExportCaption(cost);
                        doc.ExportCaption(currency);
                        doc.ExportCaption(roleid);
                        doc.ExportCaption(customint1);
                        doc.ExportCaption(customint2);
                        doc.ExportCaption(customint3);
                        doc.ExportCaption(customint4);
                        doc.ExportCaption(customint5);
                        doc.ExportCaption(customint6);
                        doc.ExportCaption(customint7);
                        doc.ExportCaption(customint8);
                        doc.ExportCaption(customchar1);
                        doc.ExportCaption(customchar2);
                        doc.ExportCaption(customchar3);
                        doc.ExportCaption(customdec1);
                        doc.ExportCaption(customdec2);
                        doc.ExportCaption(customtext1);
                        doc.ExportCaption(customtext2);
                        doc.ExportCaption(customtext3);
                        doc.ExportCaption(customtext4);
                        doc.ExportCaption(timecreated);
                        doc.ExportCaption(timemodified);
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
                            await doc.ExportField(id);
                            await doc.ExportField(enrol);
                            await doc.ExportField(status);
                            await doc.ExportField(courseid);
                            await doc.ExportField(sortorder);
                            await doc.ExportField(_name);
                            await doc.ExportField(enrolperiod);
                            await doc.ExportField(enrolstartdate);
                            await doc.ExportField(enrolenddate);
                            await doc.ExportField(expirynotify);
                            await doc.ExportField(expirythreshold);
                            await doc.ExportField(notifyall);
                            await doc.ExportField(password);
                            await doc.ExportField(cost);
                            await doc.ExportField(currency);
                            await doc.ExportField(roleid);
                            await doc.ExportField(customint1);
                            await doc.ExportField(customint2);
                            await doc.ExportField(customint3);
                            await doc.ExportField(customint4);
                            await doc.ExportField(customint5);
                            await doc.ExportField(customint6);
                            await doc.ExportField(customint7);
                            await doc.ExportField(customint8);
                            await doc.ExportField(customchar1);
                            await doc.ExportField(customchar2);
                            await doc.ExportField(customchar3);
                            await doc.ExportField(customdec1);
                            await doc.ExportField(customdec2);
                            await doc.ExportField(customtext1);
                            await doc.ExportField(customtext2);
                            await doc.ExportField(customtext3);
                            await doc.ExportField(customtext4);
                            await doc.ExportField(timecreated);
                            await doc.ExportField(timemodified);
                        } else {
                            await doc.ExportField(id);
                            await doc.ExportField(enrol);
                            await doc.ExportField(status);
                            await doc.ExportField(courseid);
                            await doc.ExportField(sortorder);
                            await doc.ExportField(_name);
                            await doc.ExportField(enrolperiod);
                            await doc.ExportField(enrolstartdate);
                            await doc.ExportField(enrolenddate);
                            await doc.ExportField(expirynotify);
                            await doc.ExportField(expirythreshold);
                            await doc.ExportField(notifyall);
                            await doc.ExportField(password);
                            await doc.ExportField(cost);
                            await doc.ExportField(currency);
                            await doc.ExportField(roleid);
                            await doc.ExportField(customint1);
                            await doc.ExportField(customint2);
                            await doc.ExportField(customint3);
                            await doc.ExportField(customint4);
                            await doc.ExportField(customint5);
                            await doc.ExportField(customint6);
                            await doc.ExportField(customint7);
                            await doc.ExportField(customint8);
                            await doc.ExportField(customchar1);
                            await doc.ExportField(customchar2);
                            await doc.ExportField(customchar3);
                            await doc.ExportField(customdec1);
                            await doc.ExportField(customdec2);
                            await doc.ExportField(customtext1);
                            await doc.ExportField(customtext2);
                            await doc.ExportField(customtext3);
                            await doc.ExportField(customtext4);
                            await doc.ExportField(timecreated);
                            await doc.ExportField(timemodified);
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
