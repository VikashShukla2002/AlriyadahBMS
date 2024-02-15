namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// lmsUsers
    /// </summary>
    [MaybeNull]
    public static LmsUsers lmsUsers
    {
        get => HttpData.Resolve<LmsUsers>("LMS_Users");
        set => HttpData["LMS_Users"] = value;
    }

    /// <summary>
    /// Table class for LMS_Users
    /// </summary>
    public class LmsUsers : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> auth;

        public readonly DbField<SqlDbType> confirmed;

        public readonly DbField<SqlDbType> policyagreed;

        public readonly DbField<SqlDbType> deleted;

        public readonly DbField<SqlDbType> suspended;

        public readonly DbField<SqlDbType> mnethostid;

        public readonly DbField<SqlDbType> _username;

        public readonly DbField<SqlDbType> password;

        public readonly DbField<SqlDbType> idnumber;

        public readonly DbField<SqlDbType> firstname;

        public readonly DbField<SqlDbType> lastname;

        public readonly DbField<SqlDbType> _email;

        public readonly DbField<SqlDbType> emailstop;

        public readonly DbField<SqlDbType> phone1;

        public readonly DbField<SqlDbType> phone2;

        public readonly DbField<SqlDbType> institution;

        public readonly DbField<SqlDbType> department;

        public readonly DbField<SqlDbType> address;

        public readonly DbField<SqlDbType> city;

        public readonly DbField<SqlDbType> country;

        public readonly DbField<SqlDbType> _lang;

        public readonly DbField<SqlDbType> calendartype;

        public readonly DbField<SqlDbType> theme;

        public readonly DbField<SqlDbType> timezone;

        public readonly DbField<SqlDbType> firstaccess;

        public readonly DbField<SqlDbType> lastaccess;

        public readonly DbField<SqlDbType> lastlogin;

        public readonly DbField<SqlDbType> currentlogin;

        public readonly DbField<SqlDbType> lastip;

        public readonly DbField<SqlDbType> secret;

        public readonly DbField<SqlDbType> picture;

        public readonly DbField<SqlDbType> description;

        public readonly DbField<SqlDbType> descriptionformat;

        public readonly DbField<SqlDbType> mailformat;

        public readonly DbField<SqlDbType> maildigest;

        public readonly DbField<SqlDbType> maildisplay;

        public readonly DbField<SqlDbType> autosubscribe;

        public readonly DbField<SqlDbType> trackforums;

        public readonly DbField<SqlDbType> timecreated;

        public readonly DbField<SqlDbType> timemodified;

        public readonly DbField<SqlDbType> trustbitmask;

        public readonly DbField<SqlDbType> imagealt;

        public readonly DbField<SqlDbType> lastnamephonetic;

        public readonly DbField<SqlDbType> firstnamephonetic;

        public readonly DbField<SqlDbType> middlename;

        public readonly DbField<SqlDbType> alternatename;

        public readonly DbField<SqlDbType> moodlenetprofile;

        // Constructor
        public LmsUsers()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "LMS_Users";
            Name = "LMS_Users";
            Type = "VIEW";
            UpdateTable = "dbo.LMS_Users"; // Update Table
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("id", id);

            // auth
            auth = new (this, "x_auth", 200, SqlDbType.VarChar) {
                Name = "auth",
                Expression = "[auth]",
                UseBasicSearch = true,
                BasicSearchExpression = "[auth]",
                DateTimeFormat = -1,
                VirtualExpression = "[auth]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "auth", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("auth", auth);

            // confirmed
            confirmed = new (this, "x_confirmed", 131, SqlDbType.Decimal) {
                Name = "confirmed",
                Expression = "[confirmed]",
                BasicSearchExpression = "CAST([confirmed] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[confirmed]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "confirmed", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("confirmed", confirmed);

            // policyagreed
            policyagreed = new (this, "x_policyagreed", 131, SqlDbType.Decimal) {
                Name = "policyagreed",
                Expression = "[policyagreed]",
                BasicSearchExpression = "CAST([policyagreed] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[policyagreed]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "policyagreed", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("policyagreed", policyagreed);

            // deleted
            deleted = new (this, "x_deleted", 131, SqlDbType.Decimal) {
                Name = "deleted",
                Expression = "[deleted]",
                BasicSearchExpression = "CAST([deleted] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[deleted]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "deleted", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("deleted", deleted);

            // suspended
            suspended = new (this, "x_suspended", 131, SqlDbType.Decimal) {
                Name = "suspended",
                Expression = "[suspended]",
                BasicSearchExpression = "CAST([suspended] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[suspended]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "suspended", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("suspended", suspended);

            // mnethostid
            mnethostid = new (this, "x_mnethostid", 20, SqlDbType.BigInt) {
                Name = "mnethostid",
                Expression = "[mnethostid]",
                BasicSearchExpression = "CAST([mnethostid] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[mnethostid]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "mnethostid", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("mnethostid", mnethostid);

            // username
            _username = new (this, "x__username", 200, SqlDbType.VarChar) {
                Name = "username",
                Expression = "[username]",
                UseBasicSearch = true,
                BasicSearchExpression = "[username]",
                DateTimeFormat = -1,
                VirtualExpression = "[username]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "_username", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("username", _username);

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
                CustomMessage = Language.FieldPhrase("LMS_Users", "password", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("password", password);

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
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY" },
                CustomMessage = Language.FieldPhrase("LMS_Users", "idnumber", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("idnumber", idnumber);

            // firstname
            firstname = new (this, "x_firstname", 200, SqlDbType.VarChar) {
                Name = "firstname",
                Expression = "[firstname]",
                UseBasicSearch = true,
                BasicSearchExpression = "[firstname]",
                DateTimeFormat = -1,
                VirtualExpression = "[firstname]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "firstname", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("firstname", firstname);

            // lastname
            lastname = new (this, "x_lastname", 200, SqlDbType.VarChar) {
                Name = "lastname",
                Expression = "[lastname]",
                UseBasicSearch = true,
                BasicSearchExpression = "[lastname]",
                DateTimeFormat = -1,
                VirtualExpression = "[lastname]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "lastname", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("lastname", lastname);

            // email
            _email = new (this, "x__email", 200, SqlDbType.VarChar) {
                Name = "email",
                Expression = "[email]",
                UseBasicSearch = true,
                BasicSearchExpression = "[email]",
                DateTimeFormat = -1,
                VirtualExpression = "[email]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "_email", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("email", _email);

            // emailstop
            emailstop = new (this, "x_emailstop", 131, SqlDbType.Decimal) {
                Name = "emailstop",
                Expression = "[emailstop]",
                BasicSearchExpression = "CAST([emailstop] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[emailstop]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "emailstop", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("emailstop", emailstop);

            // phone1
            phone1 = new (this, "x_phone1", 200, SqlDbType.VarChar) {
                Name = "phone1",
                Expression = "[phone1]",
                UseBasicSearch = true,
                BasicSearchExpression = "[phone1]",
                DateTimeFormat = -1,
                VirtualExpression = "[phone1]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "phone1", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("phone1", phone1);

            // phone2
            phone2 = new (this, "x_phone2", 200, SqlDbType.VarChar) {
                Name = "phone2",
                Expression = "[phone2]",
                UseBasicSearch = true,
                BasicSearchExpression = "[phone2]",
                DateTimeFormat = -1,
                VirtualExpression = "[phone2]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "phone2", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("phone2", phone2);

            // institution
            institution = new (this, "x_institution", 200, SqlDbType.VarChar) {
                Name = "institution",
                Expression = "[institution]",
                UseBasicSearch = true,
                BasicSearchExpression = "[institution]",
                DateTimeFormat = -1,
                VirtualExpression = "[institution]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "institution", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("institution", institution);

            // department
            department = new (this, "x_department", 200, SqlDbType.VarChar) {
                Name = "department",
                Expression = "[department]",
                UseBasicSearch = true,
                BasicSearchExpression = "[department]",
                DateTimeFormat = -1,
                VirtualExpression = "[department]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "department", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("department", department);

            // address
            address = new (this, "x_address", 200, SqlDbType.VarChar) {
                Name = "address",
                Expression = "[address]",
                UseBasicSearch = true,
                BasicSearchExpression = "[address]",
                DateTimeFormat = -1,
                VirtualExpression = "[address]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "address", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("address", address);

            // city
            city = new (this, "x_city", 200, SqlDbType.VarChar) {
                Name = "city",
                Expression = "[city]",
                UseBasicSearch = true,
                BasicSearchExpression = "[city]",
                DateTimeFormat = -1,
                VirtualExpression = "[city]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "city", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("city", city);

            // country
            country = new (this, "x_country", 200, SqlDbType.VarChar) {
                Name = "country",
                Expression = "[country]",
                UseBasicSearch = true,
                BasicSearchExpression = "[country]",
                DateTimeFormat = -1,
                VirtualExpression = "[country]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "country", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("country", country);

            // lang
            _lang = new (this, "x__lang", 200, SqlDbType.VarChar) {
                Name = "lang",
                Expression = "[lang]",
                UseBasicSearch = true,
                BasicSearchExpression = "[lang]",
                DateTimeFormat = -1,
                VirtualExpression = "[lang]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "_lang", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("lang", _lang);

            // calendartype
            calendartype = new (this, "x_calendartype", 200, SqlDbType.VarChar) {
                Name = "calendartype",
                Expression = "[calendartype]",
                UseBasicSearch = true,
                BasicSearchExpression = "[calendartype]",
                DateTimeFormat = -1,
                VirtualExpression = "[calendartype]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "calendartype", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("calendartype", calendartype);

            // theme
            theme = new (this, "x_theme", 200, SqlDbType.VarChar) {
                Name = "theme",
                Expression = "[theme]",
                UseBasicSearch = true,
                BasicSearchExpression = "[theme]",
                DateTimeFormat = -1,
                VirtualExpression = "[theme]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "theme", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("theme", theme);

            // timezone
            timezone = new (this, "x_timezone", 200, SqlDbType.VarChar) {
                Name = "timezone",
                Expression = "[timezone]",
                UseBasicSearch = true,
                BasicSearchExpression = "[timezone]",
                DateTimeFormat = -1,
                VirtualExpression = "[timezone]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "timezone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("timezone", timezone);

            // firstaccess
            firstaccess = new (this, "x_firstaccess", 20, SqlDbType.BigInt) {
                Name = "firstaccess",
                Expression = "[firstaccess]",
                BasicSearchExpression = "CAST([firstaccess] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[firstaccess]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "firstaccess", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("firstaccess", firstaccess);

            // lastaccess
            lastaccess = new (this, "x_lastaccess", 20, SqlDbType.BigInt) {
                Name = "lastaccess",
                Expression = "[lastaccess]",
                BasicSearchExpression = "CAST([lastaccess] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[lastaccess]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "lastaccess", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("lastaccess", lastaccess);

            // lastlogin
            lastlogin = new (this, "x_lastlogin", 20, SqlDbType.BigInt) {
                Name = "lastlogin",
                Expression = "[lastlogin]",
                BasicSearchExpression = "CAST([lastlogin] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[lastlogin]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "lastlogin", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("lastlogin", lastlogin);

            // currentlogin
            currentlogin = new (this, "x_currentlogin", 20, SqlDbType.BigInt) {
                Name = "currentlogin",
                Expression = "[currentlogin]",
                BasicSearchExpression = "CAST([currentlogin] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[currentlogin]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "currentlogin", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("currentlogin", currentlogin);

            // lastip
            lastip = new (this, "x_lastip", 200, SqlDbType.VarChar) {
                Name = "lastip",
                Expression = "[lastip]",
                UseBasicSearch = true,
                BasicSearchExpression = "[lastip]",
                DateTimeFormat = -1,
                VirtualExpression = "[lastip]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "lastip", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("lastip", lastip);

            // secret
            secret = new (this, "x_secret", 200, SqlDbType.VarChar) {
                Name = "secret",
                Expression = "[secret]",
                UseBasicSearch = true,
                BasicSearchExpression = "[secret]",
                DateTimeFormat = -1,
                VirtualExpression = "[secret]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "secret", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("secret", secret);

            // picture
            picture = new (this, "x_picture", 20, SqlDbType.BigInt) {
                Name = "picture",
                Expression = "[picture]",
                BasicSearchExpression = "CAST([picture] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[picture]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "picture", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("picture", picture);

            // description
            description = new (this, "x_description", 200, SqlDbType.VarChar) {
                Name = "description",
                Expression = "[description]",
                UseBasicSearch = true,
                BasicSearchExpression = "[description]",
                DateTimeFormat = -1,
                VirtualExpression = "[description]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Users", "description", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("description", description);

            // descriptionformat
            descriptionformat = new (this, "x_descriptionformat", 131, SqlDbType.Decimal) {
                Name = "descriptionformat",
                Expression = "[descriptionformat]",
                BasicSearchExpression = "CAST([descriptionformat] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[descriptionformat]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "descriptionformat", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("descriptionformat", descriptionformat);

            // mailformat
            mailformat = new (this, "x_mailformat", 131, SqlDbType.Decimal) {
                Name = "mailformat",
                Expression = "[mailformat]",
                BasicSearchExpression = "CAST([mailformat] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[mailformat]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "mailformat", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("mailformat", mailformat);

            // maildigest
            maildigest = new (this, "x_maildigest", 131, SqlDbType.Decimal) {
                Name = "maildigest",
                Expression = "[maildigest]",
                BasicSearchExpression = "CAST([maildigest] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[maildigest]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "maildigest", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("maildigest", maildigest);

            // maildisplay
            maildisplay = new (this, "x_maildisplay", 131, SqlDbType.Decimal) {
                Name = "maildisplay",
                Expression = "[maildisplay]",
                BasicSearchExpression = "CAST([maildisplay] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[maildisplay]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "maildisplay", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("maildisplay", maildisplay);

            // autosubscribe
            autosubscribe = new (this, "x_autosubscribe", 131, SqlDbType.Decimal) {
                Name = "autosubscribe",
                Expression = "[autosubscribe]",
                BasicSearchExpression = "CAST([autosubscribe] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[autosubscribe]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "autosubscribe", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("autosubscribe", autosubscribe);

            // trackforums
            trackforums = new (this, "x_trackforums", 131, SqlDbType.Decimal) {
                Name = "trackforums",
                Expression = "[trackforums]",
                BasicSearchExpression = "CAST([trackforums] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[trackforums]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "trackforums", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("trackforums", trackforums);

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
                CustomMessage = Language.FieldPhrase("LMS_Users", "timecreated", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "timemodified", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("timemodified", timemodified);

            // trustbitmask
            trustbitmask = new (this, "x_trustbitmask", 20, SqlDbType.BigInt) {
                Name = "trustbitmask",
                Expression = "[trustbitmask]",
                BasicSearchExpression = "CAST([trustbitmask] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[trustbitmask]",
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
                CustomMessage = Language.FieldPhrase("LMS_Users", "trustbitmask", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("trustbitmask", trustbitmask);

            // imagealt
            imagealt = new (this, "x_imagealt", 200, SqlDbType.VarChar) {
                Name = "imagealt",
                Expression = "[imagealt]",
                UseBasicSearch = true,
                BasicSearchExpression = "[imagealt]",
                DateTimeFormat = -1,
                VirtualExpression = "[imagealt]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Users", "imagealt", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("imagealt", imagealt);

            // lastnamephonetic
            lastnamephonetic = new (this, "x_lastnamephonetic", 200, SqlDbType.VarChar) {
                Name = "lastnamephonetic",
                Expression = "[lastnamephonetic]",
                UseBasicSearch = true,
                BasicSearchExpression = "[lastnamephonetic]",
                DateTimeFormat = -1,
                VirtualExpression = "[lastnamephonetic]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Users", "lastnamephonetic", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("lastnamephonetic", lastnamephonetic);

            // firstnamephonetic
            firstnamephonetic = new (this, "x_firstnamephonetic", 200, SqlDbType.VarChar) {
                Name = "firstnamephonetic",
                Expression = "[firstnamephonetic]",
                UseBasicSearch = true,
                BasicSearchExpression = "[firstnamephonetic]",
                DateTimeFormat = -1,
                VirtualExpression = "[firstnamephonetic]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Users", "firstnamephonetic", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("firstnamephonetic", firstnamephonetic);

            // middlename
            middlename = new (this, "x_middlename", 200, SqlDbType.VarChar) {
                Name = "middlename",
                Expression = "[middlename]",
                UseBasicSearch = true,
                BasicSearchExpression = "[middlename]",
                DateTimeFormat = -1,
                VirtualExpression = "[middlename]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Users", "middlename", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("middlename", middlename);

            // alternatename
            alternatename = new (this, "x_alternatename", 200, SqlDbType.VarChar) {
                Name = "alternatename",
                Expression = "[alternatename]",
                UseBasicSearch = true,
                BasicSearchExpression = "[alternatename]",
                DateTimeFormat = -1,
                VirtualExpression = "[alternatename]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Users", "alternatename", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("alternatename", alternatename);

            // moodlenetprofile
            moodlenetprofile = new (this, "x_moodlenetprofile", 200, SqlDbType.VarChar) {
                Name = "moodlenetprofile",
                Expression = "[moodlenetprofile]",
                UseBasicSearch = true,
                BasicSearchExpression = "[moodlenetprofile]",
                DateTimeFormat = -1,
                VirtualExpression = "[moodlenetprofile]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Users", "moodlenetprofile", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("moodlenetprofile", moodlenetprofile);

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
            get => _sqlFrom ?? "dbo.LMS_Users";
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
                auth.DbValue = row["auth"]; // Set DB value only
                confirmed.DbValue = row["confirmed"]; // Set DB value only
                policyagreed.DbValue = row["policyagreed"]; // Set DB value only
                deleted.DbValue = row["deleted"]; // Set DB value only
                suspended.DbValue = row["suspended"]; // Set DB value only
                mnethostid.DbValue = row["mnethostid"]; // Set DB value only
                _username.DbValue = row["username"]; // Set DB value only
                password.DbValue = row["password"]; // Set DB value only
                idnumber.DbValue = row["idnumber"]; // Set DB value only
                firstname.DbValue = row["firstname"]; // Set DB value only
                lastname.DbValue = row["lastname"]; // Set DB value only
                _email.DbValue = row["email"]; // Set DB value only
                emailstop.DbValue = row["emailstop"]; // Set DB value only
                phone1.DbValue = row["phone1"]; // Set DB value only
                phone2.DbValue = row["phone2"]; // Set DB value only
                institution.DbValue = row["institution"]; // Set DB value only
                department.DbValue = row["department"]; // Set DB value only
                address.DbValue = row["address"]; // Set DB value only
                city.DbValue = row["city"]; // Set DB value only
                country.DbValue = row["country"]; // Set DB value only
                _lang.DbValue = row["lang"]; // Set DB value only
                calendartype.DbValue = row["calendartype"]; // Set DB value only
                theme.DbValue = row["theme"]; // Set DB value only
                timezone.DbValue = row["timezone"]; // Set DB value only
                firstaccess.DbValue = row["firstaccess"]; // Set DB value only
                lastaccess.DbValue = row["lastaccess"]; // Set DB value only
                lastlogin.DbValue = row["lastlogin"]; // Set DB value only
                currentlogin.DbValue = row["currentlogin"]; // Set DB value only
                lastip.DbValue = row["lastip"]; // Set DB value only
                secret.DbValue = row["secret"]; // Set DB value only
                picture.DbValue = row["picture"]; // Set DB value only
                description.DbValue = row["description"]; // Set DB value only
                descriptionformat.DbValue = row["descriptionformat"]; // Set DB value only
                mailformat.DbValue = row["mailformat"]; // Set DB value only
                maildigest.DbValue = row["maildigest"]; // Set DB value only
                maildisplay.DbValue = row["maildisplay"]; // Set DB value only
                autosubscribe.DbValue = row["autosubscribe"]; // Set DB value only
                trackforums.DbValue = row["trackforums"]; // Set DB value only
                timecreated.DbValue = row["timecreated"]; // Set DB value only
                timemodified.DbValue = row["timemodified"]; // Set DB value only
                trustbitmask.DbValue = row["trustbitmask"]; // Set DB value only
                imagealt.DbValue = row["imagealt"]; // Set DB value only
                lastnamephonetic.DbValue = row["lastnamephonetic"]; // Set DB value only
                firstnamephonetic.DbValue = row["firstnamephonetic"]; // Set DB value only
                middlename.DbValue = row["middlename"]; // Set DB value only
                alternatename.DbValue = row["alternatename"]; // Set DB value only
                moodlenetprofile.DbValue = row["moodlenetprofile"]; // Set DB value only
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
                    return "LmsUsersList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "LmsUsersView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "LmsUsersEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "LmsUsersAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "LmsUsersList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "LmsUsersView",
                Config.ApiAddAction => "LmsUsersAdd",
                Config.ApiEditAction => "LmsUsersEdit",
                Config.ApiDeleteAction => "LmsUsersDelete",
                Config.ApiListAction => "LmsUsersList",
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
        public string ListUrl => "LmsUsersList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("LmsUsersView", parm);
            else
                url = KeyUrl("LmsUsersView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "LmsUsersAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "LmsUsersAdd?" + parm;
            else
                url = "LmsUsersAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("LmsUsersEdit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("LmsUsersList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("LmsUsersAdd", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("LmsUsersList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("LmsUsersDelete")); // DN

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
            auth.SetDbValue(dr["auth"]);
            confirmed.SetDbValue(dr["confirmed"]);
            policyagreed.SetDbValue(dr["policyagreed"]);
            deleted.SetDbValue(dr["deleted"]);
            suspended.SetDbValue(dr["suspended"]);
            mnethostid.SetDbValue(dr["mnethostid"]);
            _username.SetDbValue(dr["username"]);
            password.SetDbValue(dr["password"]);
            idnumber.SetDbValue(dr["idnumber"]);
            firstname.SetDbValue(dr["firstname"]);
            lastname.SetDbValue(dr["lastname"]);
            _email.SetDbValue(dr["email"]);
            emailstop.SetDbValue(dr["emailstop"]);
            phone1.SetDbValue(dr["phone1"]);
            phone2.SetDbValue(dr["phone2"]);
            institution.SetDbValue(dr["institution"]);
            department.SetDbValue(dr["department"]);
            address.SetDbValue(dr["address"]);
            city.SetDbValue(dr["city"]);
            country.SetDbValue(dr["country"]);
            _lang.SetDbValue(dr["lang"]);
            calendartype.SetDbValue(dr["calendartype"]);
            theme.SetDbValue(dr["theme"]);
            timezone.SetDbValue(dr["timezone"]);
            firstaccess.SetDbValue(dr["firstaccess"]);
            lastaccess.SetDbValue(dr["lastaccess"]);
            lastlogin.SetDbValue(dr["lastlogin"]);
            currentlogin.SetDbValue(dr["currentlogin"]);
            lastip.SetDbValue(dr["lastip"]);
            secret.SetDbValue(dr["secret"]);
            picture.SetDbValue(dr["picture"]);
            description.SetDbValue(dr["description"]);
            descriptionformat.SetDbValue(dr["descriptionformat"]);
            mailformat.SetDbValue(dr["mailformat"]);
            maildigest.SetDbValue(dr["maildigest"]);
            maildisplay.SetDbValue(dr["maildisplay"]);
            autosubscribe.SetDbValue(dr["autosubscribe"]);
            trackforums.SetDbValue(dr["trackforums"]);
            timecreated.SetDbValue(dr["timecreated"]);
            timemodified.SetDbValue(dr["timemodified"]);
            trustbitmask.SetDbValue(dr["trustbitmask"]);
            imagealt.SetDbValue(dr["imagealt"]);
            lastnamephonetic.SetDbValue(dr["lastnamephonetic"]);
            firstnamephonetic.SetDbValue(dr["firstnamephonetic"]);
            middlename.SetDbValue(dr["middlename"]);
            alternatename.SetDbValue(dr["alternatename"]);
            moodlenetprofile.SetDbValue(dr["moodlenetprofile"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "LmsUsersList";
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

            // auth

            // confirmed

            // policyagreed

            // deleted

            // suspended

            // mnethostid

            // username

            // password

            // idnumber

            // firstname

            // lastname

            // email

            // emailstop

            // phone1

            // phone2

            // institution

            // department

            // address

            // city

            // country

            // lang

            // calendartype

            // theme

            // timezone

            // firstaccess

            // lastaccess

            // lastlogin

            // currentlogin

            // lastip

            // secret

            // picture

            // description

            // descriptionformat

            // mailformat

            // maildigest

            // maildisplay

            // autosubscribe

            // trackforums

            // timecreated

            // timemodified

            // trustbitmask

            // imagealt

            // lastnamephonetic

            // firstnamephonetic

            // middlename

            // alternatename

            // moodlenetprofile

            // id
            id.ViewValue = id.CurrentValue;
            id.ViewValue = FormatNumber(id.ViewValue, id.FormatPattern);
            id.ViewCustomAttributes = "";

            // auth
            auth.ViewValue = ConvertToString(auth.CurrentValue); // DN
            auth.ViewCustomAttributes = "";

            // confirmed
            confirmed.ViewValue = confirmed.CurrentValue;
            confirmed.ViewValue = FormatNumber(confirmed.ViewValue, confirmed.FormatPattern);
            confirmed.ViewCustomAttributes = "";

            // policyagreed
            policyagreed.ViewValue = policyagreed.CurrentValue;
            policyagreed.ViewValue = FormatNumber(policyagreed.ViewValue, policyagreed.FormatPattern);
            policyagreed.ViewCustomAttributes = "";

            // deleted
            deleted.ViewValue = deleted.CurrentValue;
            deleted.ViewValue = FormatNumber(deleted.ViewValue, deleted.FormatPattern);
            deleted.ViewCustomAttributes = "";

            // suspended
            suspended.ViewValue = suspended.CurrentValue;
            suspended.ViewValue = FormatNumber(suspended.ViewValue, suspended.FormatPattern);
            suspended.ViewCustomAttributes = "";

            // mnethostid
            mnethostid.ViewValue = mnethostid.CurrentValue;
            mnethostid.ViewValue = FormatNumber(mnethostid.ViewValue, mnethostid.FormatPattern);
            mnethostid.ViewCustomAttributes = "";

            // username
            _username.ViewValue = ConvertToString(_username.CurrentValue); // DN
            _username.ViewCustomAttributes = "";

            // password
            password.ViewValue = ConvertToString(password.CurrentValue); // DN
            password.ViewCustomAttributes = "";

            // idnumber
            idnumber.ViewValue = ConvertToString(idnumber.CurrentValue); // DN
            idnumber.ViewCustomAttributes = "";

            // firstname
            firstname.ViewValue = ConvertToString(firstname.CurrentValue); // DN
            firstname.ViewCustomAttributes = "";

            // lastname
            lastname.ViewValue = ConvertToString(lastname.CurrentValue); // DN
            lastname.ViewCustomAttributes = "";

            // email
            _email.ViewValue = ConvertToString(_email.CurrentValue); // DN
            _email.ViewCustomAttributes = "";

            // emailstop
            emailstop.ViewValue = emailstop.CurrentValue;
            emailstop.ViewValue = FormatNumber(emailstop.ViewValue, emailstop.FormatPattern);
            emailstop.ViewCustomAttributes = "";

            // phone1
            phone1.ViewValue = ConvertToString(phone1.CurrentValue); // DN
            phone1.ViewCustomAttributes = "";

            // phone2
            phone2.ViewValue = ConvertToString(phone2.CurrentValue); // DN
            phone2.ViewCustomAttributes = "";

            // institution
            institution.ViewValue = ConvertToString(institution.CurrentValue); // DN
            institution.ViewCustomAttributes = "";

            // department
            department.ViewValue = ConvertToString(department.CurrentValue); // DN
            department.ViewCustomAttributes = "";

            // address
            address.ViewValue = ConvertToString(address.CurrentValue); // DN
            address.ViewCustomAttributes = "";

            // city
            city.ViewValue = ConvertToString(city.CurrentValue); // DN
            city.ViewCustomAttributes = "";

            // country
            country.ViewValue = ConvertToString(country.CurrentValue); // DN
            country.ViewCustomAttributes = "";

            // lang
            _lang.ViewValue = ConvertToString(_lang.CurrentValue); // DN
            _lang.ViewCustomAttributes = "";

            // calendartype
            calendartype.ViewValue = ConvertToString(calendartype.CurrentValue); // DN
            calendartype.ViewCustomAttributes = "";

            // theme
            theme.ViewValue = ConvertToString(theme.CurrentValue); // DN
            theme.ViewCustomAttributes = "";

            // timezone
            timezone.ViewValue = ConvertToString(timezone.CurrentValue); // DN
            timezone.ViewCustomAttributes = "";

            // firstaccess
            firstaccess.ViewValue = firstaccess.CurrentValue;
            firstaccess.ViewValue = FormatNumber(firstaccess.ViewValue, firstaccess.FormatPattern);
            firstaccess.ViewCustomAttributes = "";

            // lastaccess
            lastaccess.ViewValue = lastaccess.CurrentValue;
            lastaccess.ViewValue = FormatNumber(lastaccess.ViewValue, lastaccess.FormatPattern);
            lastaccess.ViewCustomAttributes = "";

            // lastlogin
            lastlogin.ViewValue = lastlogin.CurrentValue;
            lastlogin.ViewValue = FormatNumber(lastlogin.ViewValue, lastlogin.FormatPattern);
            lastlogin.ViewCustomAttributes = "";

            // currentlogin
            currentlogin.ViewValue = currentlogin.CurrentValue;
            currentlogin.ViewValue = FormatNumber(currentlogin.ViewValue, currentlogin.FormatPattern);
            currentlogin.ViewCustomAttributes = "";

            // lastip
            lastip.ViewValue = ConvertToString(lastip.CurrentValue); // DN
            lastip.ViewCustomAttributes = "";

            // secret
            secret.ViewValue = ConvertToString(secret.CurrentValue); // DN
            secret.ViewCustomAttributes = "";

            // picture
            picture.ViewValue = picture.CurrentValue;
            picture.ViewValue = FormatNumber(picture.ViewValue, picture.FormatPattern);
            picture.ViewCustomAttributes = "";

            // description
            description.ViewValue = ConvertToString(description.CurrentValue); // DN
            description.ViewCustomAttributes = "";

            // descriptionformat
            descriptionformat.ViewValue = descriptionformat.CurrentValue;
            descriptionformat.ViewValue = FormatNumber(descriptionformat.ViewValue, descriptionformat.FormatPattern);
            descriptionformat.ViewCustomAttributes = "";

            // mailformat
            mailformat.ViewValue = mailformat.CurrentValue;
            mailformat.ViewValue = FormatNumber(mailformat.ViewValue, mailformat.FormatPattern);
            mailformat.ViewCustomAttributes = "";

            // maildigest
            maildigest.ViewValue = maildigest.CurrentValue;
            maildigest.ViewValue = FormatNumber(maildigest.ViewValue, maildigest.FormatPattern);
            maildigest.ViewCustomAttributes = "";

            // maildisplay
            maildisplay.ViewValue = maildisplay.CurrentValue;
            maildisplay.ViewValue = FormatNumber(maildisplay.ViewValue, maildisplay.FormatPattern);
            maildisplay.ViewCustomAttributes = "";

            // autosubscribe
            autosubscribe.ViewValue = autosubscribe.CurrentValue;
            autosubscribe.ViewValue = FormatNumber(autosubscribe.ViewValue, autosubscribe.FormatPattern);
            autosubscribe.ViewCustomAttributes = "";

            // trackforums
            trackforums.ViewValue = trackforums.CurrentValue;
            trackforums.ViewValue = FormatNumber(trackforums.ViewValue, trackforums.FormatPattern);
            trackforums.ViewCustomAttributes = "";

            // timecreated
            timecreated.ViewValue = timecreated.CurrentValue;
            timecreated.ViewValue = FormatNumber(timecreated.ViewValue, timecreated.FormatPattern);
            timecreated.ViewCustomAttributes = "";

            // timemodified
            timemodified.ViewValue = timemodified.CurrentValue;
            timemodified.ViewValue = FormatNumber(timemodified.ViewValue, timemodified.FormatPattern);
            timemodified.ViewCustomAttributes = "";

            // trustbitmask
            trustbitmask.ViewValue = trustbitmask.CurrentValue;
            trustbitmask.ViewValue = FormatNumber(trustbitmask.ViewValue, trustbitmask.FormatPattern);
            trustbitmask.ViewCustomAttributes = "";

            // imagealt
            imagealt.ViewValue = ConvertToString(imagealt.CurrentValue); // DN
            imagealt.ViewCustomAttributes = "";

            // lastnamephonetic
            lastnamephonetic.ViewValue = ConvertToString(lastnamephonetic.CurrentValue); // DN
            lastnamephonetic.ViewCustomAttributes = "";

            // firstnamephonetic
            firstnamephonetic.ViewValue = ConvertToString(firstnamephonetic.CurrentValue); // DN
            firstnamephonetic.ViewCustomAttributes = "";

            // middlename
            middlename.ViewValue = ConvertToString(middlename.CurrentValue); // DN
            middlename.ViewCustomAttributes = "";

            // alternatename
            alternatename.ViewValue = ConvertToString(alternatename.CurrentValue); // DN
            alternatename.ViewCustomAttributes = "";

            // moodlenetprofile
            moodlenetprofile.ViewValue = ConvertToString(moodlenetprofile.CurrentValue); // DN
            moodlenetprofile.ViewCustomAttributes = "";

            // id
            id.HrefValue = "";
            id.TooltipValue = "";

            // auth
            auth.HrefValue = "";
            auth.TooltipValue = "";

            // confirmed
            confirmed.HrefValue = "";
            confirmed.TooltipValue = "";

            // policyagreed
            policyagreed.HrefValue = "";
            policyagreed.TooltipValue = "";

            // deleted
            deleted.HrefValue = "";
            deleted.TooltipValue = "";

            // suspended
            suspended.HrefValue = "";
            suspended.TooltipValue = "";

            // mnethostid
            mnethostid.HrefValue = "";
            mnethostid.TooltipValue = "";

            // username
            _username.HrefValue = "";
            _username.TooltipValue = "";

            // password
            password.HrefValue = "";
            password.TooltipValue = "";

            // idnumber
            idnumber.HrefValue = "";
            idnumber.TooltipValue = "";

            // firstname
            firstname.HrefValue = "";
            firstname.TooltipValue = "";

            // lastname
            lastname.HrefValue = "";
            lastname.TooltipValue = "";

            // email
            _email.HrefValue = "";
            _email.TooltipValue = "";

            // emailstop
            emailstop.HrefValue = "";
            emailstop.TooltipValue = "";

            // phone1
            phone1.HrefValue = "";
            phone1.TooltipValue = "";

            // phone2
            phone2.HrefValue = "";
            phone2.TooltipValue = "";

            // institution
            institution.HrefValue = "";
            institution.TooltipValue = "";

            // department
            department.HrefValue = "";
            department.TooltipValue = "";

            // address
            address.HrefValue = "";
            address.TooltipValue = "";

            // city
            city.HrefValue = "";
            city.TooltipValue = "";

            // country
            country.HrefValue = "";
            country.TooltipValue = "";

            // lang
            _lang.HrefValue = "";
            _lang.TooltipValue = "";

            // calendartype
            calendartype.HrefValue = "";
            calendartype.TooltipValue = "";

            // theme
            theme.HrefValue = "";
            theme.TooltipValue = "";

            // timezone
            timezone.HrefValue = "";
            timezone.TooltipValue = "";

            // firstaccess
            firstaccess.HrefValue = "";
            firstaccess.TooltipValue = "";

            // lastaccess
            lastaccess.HrefValue = "";
            lastaccess.TooltipValue = "";

            // lastlogin
            lastlogin.HrefValue = "";
            lastlogin.TooltipValue = "";

            // currentlogin
            currentlogin.HrefValue = "";
            currentlogin.TooltipValue = "";

            // lastip
            lastip.HrefValue = "";
            lastip.TooltipValue = "";

            // secret
            secret.HrefValue = "";
            secret.TooltipValue = "";

            // picture
            picture.HrefValue = "";
            picture.TooltipValue = "";

            // description
            description.HrefValue = "";
            description.TooltipValue = "";

            // descriptionformat
            descriptionformat.HrefValue = "";
            descriptionformat.TooltipValue = "";

            // mailformat
            mailformat.HrefValue = "";
            mailformat.TooltipValue = "";

            // maildigest
            maildigest.HrefValue = "";
            maildigest.TooltipValue = "";

            // maildisplay
            maildisplay.HrefValue = "";
            maildisplay.TooltipValue = "";

            // autosubscribe
            autosubscribe.HrefValue = "";
            autosubscribe.TooltipValue = "";

            // trackforums
            trackforums.HrefValue = "";
            trackforums.TooltipValue = "";

            // timecreated
            timecreated.HrefValue = "";
            timecreated.TooltipValue = "";

            // timemodified
            timemodified.HrefValue = "";
            timemodified.TooltipValue = "";

            // trustbitmask
            trustbitmask.HrefValue = "";
            trustbitmask.TooltipValue = "";

            // imagealt
            imagealt.HrefValue = "";
            imagealt.TooltipValue = "";

            // lastnamephonetic
            lastnamephonetic.HrefValue = "";
            lastnamephonetic.TooltipValue = "";

            // firstnamephonetic
            firstnamephonetic.HrefValue = "";
            firstnamephonetic.TooltipValue = "";

            // middlename
            middlename.HrefValue = "";
            middlename.TooltipValue = "";

            // alternatename
            alternatename.HrefValue = "";
            alternatename.TooltipValue = "";

            // moodlenetprofile
            moodlenetprofile.HrefValue = "";
            moodlenetprofile.TooltipValue = "";

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

            // auth
            auth.SetupEditAttributes();
            if (!auth.Raw)
                auth.CurrentValue = HtmlDecode(auth.CurrentValue);
            auth.EditValue = HtmlEncode(auth.CurrentValue);
            auth.PlaceHolder = RemoveHtml(auth.Caption);

            // confirmed
            confirmed.SetupEditAttributes();
            confirmed.EditValue = confirmed.CurrentValue; // DN
            confirmed.PlaceHolder = RemoveHtml(confirmed.Caption);
            if (!Empty(confirmed.EditValue) && IsNumeric(confirmed.EditValue))
                confirmed.EditValue = FormatNumber(confirmed.EditValue, null);

            // policyagreed
            policyagreed.SetupEditAttributes();
            policyagreed.EditValue = policyagreed.CurrentValue; // DN
            policyagreed.PlaceHolder = RemoveHtml(policyagreed.Caption);
            if (!Empty(policyagreed.EditValue) && IsNumeric(policyagreed.EditValue))
                policyagreed.EditValue = FormatNumber(policyagreed.EditValue, null);

            // deleted
            deleted.SetupEditAttributes();
            deleted.EditValue = deleted.CurrentValue; // DN
            deleted.PlaceHolder = RemoveHtml(deleted.Caption);
            if (!Empty(deleted.EditValue) && IsNumeric(deleted.EditValue))
                deleted.EditValue = FormatNumber(deleted.EditValue, null);

            // suspended
            suspended.SetupEditAttributes();
            suspended.EditValue = suspended.CurrentValue; // DN
            suspended.PlaceHolder = RemoveHtml(suspended.Caption);
            if (!Empty(suspended.EditValue) && IsNumeric(suspended.EditValue))
                suspended.EditValue = FormatNumber(suspended.EditValue, null);

            // mnethostid
            mnethostid.SetupEditAttributes();
            mnethostid.EditValue = mnethostid.CurrentValue; // DN
            mnethostid.PlaceHolder = RemoveHtml(mnethostid.Caption);
            if (!Empty(mnethostid.EditValue) && IsNumeric(mnethostid.EditValue))
                mnethostid.EditValue = FormatNumber(mnethostid.EditValue, null);

            // username
            _username.SetupEditAttributes();
            if (!_username.Raw)
                _username.CurrentValue = HtmlDecode(_username.CurrentValue);
            _username.EditValue = HtmlEncode(_username.CurrentValue);
            _username.PlaceHolder = RemoveHtml(_username.Caption);

            // password
            password.SetupEditAttributes();
            if (!password.Raw)
                password.CurrentValue = HtmlDecode(password.CurrentValue);
            password.EditValue = HtmlEncode(password.CurrentValue);
            password.PlaceHolder = RemoveHtml(password.Caption);

            // idnumber
            idnumber.SetupEditAttributes();
            if (!idnumber.Raw)
                idnumber.CurrentValue = HtmlDecode(idnumber.CurrentValue);
            idnumber.EditValue = HtmlEncode(idnumber.CurrentValue);
            idnumber.PlaceHolder = RemoveHtml(idnumber.Caption);

            // firstname
            firstname.SetupEditAttributes();
            if (!firstname.Raw)
                firstname.CurrentValue = HtmlDecode(firstname.CurrentValue);
            firstname.EditValue = HtmlEncode(firstname.CurrentValue);
            firstname.PlaceHolder = RemoveHtml(firstname.Caption);

            // lastname
            lastname.SetupEditAttributes();
            if (!lastname.Raw)
                lastname.CurrentValue = HtmlDecode(lastname.CurrentValue);
            lastname.EditValue = HtmlEncode(lastname.CurrentValue);
            lastname.PlaceHolder = RemoveHtml(lastname.Caption);

            // email
            _email.SetupEditAttributes();
            if (!_email.Raw)
                _email.CurrentValue = HtmlDecode(_email.CurrentValue);
            _email.EditValue = HtmlEncode(_email.CurrentValue);
            _email.PlaceHolder = RemoveHtml(_email.Caption);

            // emailstop
            emailstop.SetupEditAttributes();
            emailstop.EditValue = emailstop.CurrentValue; // DN
            emailstop.PlaceHolder = RemoveHtml(emailstop.Caption);
            if (!Empty(emailstop.EditValue) && IsNumeric(emailstop.EditValue))
                emailstop.EditValue = FormatNumber(emailstop.EditValue, null);

            // phone1
            phone1.SetupEditAttributes();
            if (!phone1.Raw)
                phone1.CurrentValue = HtmlDecode(phone1.CurrentValue);
            phone1.EditValue = HtmlEncode(phone1.CurrentValue);
            phone1.PlaceHolder = RemoveHtml(phone1.Caption);

            // phone2
            phone2.SetupEditAttributes();
            if (!phone2.Raw)
                phone2.CurrentValue = HtmlDecode(phone2.CurrentValue);
            phone2.EditValue = HtmlEncode(phone2.CurrentValue);
            phone2.PlaceHolder = RemoveHtml(phone2.Caption);

            // institution
            institution.SetupEditAttributes();
            if (!institution.Raw)
                institution.CurrentValue = HtmlDecode(institution.CurrentValue);
            institution.EditValue = HtmlEncode(institution.CurrentValue);
            institution.PlaceHolder = RemoveHtml(institution.Caption);

            // department
            department.SetupEditAttributes();
            if (!department.Raw)
                department.CurrentValue = HtmlDecode(department.CurrentValue);
            department.EditValue = HtmlEncode(department.CurrentValue);
            department.PlaceHolder = RemoveHtml(department.Caption);

            // address
            address.SetupEditAttributes();
            if (!address.Raw)
                address.CurrentValue = HtmlDecode(address.CurrentValue);
            address.EditValue = HtmlEncode(address.CurrentValue);
            address.PlaceHolder = RemoveHtml(address.Caption);

            // city
            city.SetupEditAttributes();
            if (!city.Raw)
                city.CurrentValue = HtmlDecode(city.CurrentValue);
            city.EditValue = HtmlEncode(city.CurrentValue);
            city.PlaceHolder = RemoveHtml(city.Caption);

            // country
            country.SetupEditAttributes();
            if (!country.Raw)
                country.CurrentValue = HtmlDecode(country.CurrentValue);
            country.EditValue = HtmlEncode(country.CurrentValue);
            country.PlaceHolder = RemoveHtml(country.Caption);

            // lang
            _lang.SetupEditAttributes();
            if (!_lang.Raw)
                _lang.CurrentValue = HtmlDecode(_lang.CurrentValue);
            _lang.EditValue = HtmlEncode(_lang.CurrentValue);
            _lang.PlaceHolder = RemoveHtml(_lang.Caption);

            // calendartype
            calendartype.SetupEditAttributes();
            if (!calendartype.Raw)
                calendartype.CurrentValue = HtmlDecode(calendartype.CurrentValue);
            calendartype.EditValue = HtmlEncode(calendartype.CurrentValue);
            calendartype.PlaceHolder = RemoveHtml(calendartype.Caption);

            // theme
            theme.SetupEditAttributes();
            if (!theme.Raw)
                theme.CurrentValue = HtmlDecode(theme.CurrentValue);
            theme.EditValue = HtmlEncode(theme.CurrentValue);
            theme.PlaceHolder = RemoveHtml(theme.Caption);

            // timezone
            timezone.SetupEditAttributes();
            if (!timezone.Raw)
                timezone.CurrentValue = HtmlDecode(timezone.CurrentValue);
            timezone.EditValue = HtmlEncode(timezone.CurrentValue);
            timezone.PlaceHolder = RemoveHtml(timezone.Caption);

            // firstaccess
            firstaccess.SetupEditAttributes();
            firstaccess.EditValue = firstaccess.CurrentValue; // DN
            firstaccess.PlaceHolder = RemoveHtml(firstaccess.Caption);
            if (!Empty(firstaccess.EditValue) && IsNumeric(firstaccess.EditValue))
                firstaccess.EditValue = FormatNumber(firstaccess.EditValue, null);

            // lastaccess
            lastaccess.SetupEditAttributes();
            lastaccess.EditValue = lastaccess.CurrentValue; // DN
            lastaccess.PlaceHolder = RemoveHtml(lastaccess.Caption);
            if (!Empty(lastaccess.EditValue) && IsNumeric(lastaccess.EditValue))
                lastaccess.EditValue = FormatNumber(lastaccess.EditValue, null);

            // lastlogin
            lastlogin.SetupEditAttributes();
            lastlogin.EditValue = lastlogin.CurrentValue; // DN
            lastlogin.PlaceHolder = RemoveHtml(lastlogin.Caption);
            if (!Empty(lastlogin.EditValue) && IsNumeric(lastlogin.EditValue))
                lastlogin.EditValue = FormatNumber(lastlogin.EditValue, null);

            // currentlogin
            currentlogin.SetupEditAttributes();
            currentlogin.EditValue = currentlogin.CurrentValue; // DN
            currentlogin.PlaceHolder = RemoveHtml(currentlogin.Caption);
            if (!Empty(currentlogin.EditValue) && IsNumeric(currentlogin.EditValue))
                currentlogin.EditValue = FormatNumber(currentlogin.EditValue, null);

            // lastip
            lastip.SetupEditAttributes();
            if (!lastip.Raw)
                lastip.CurrentValue = HtmlDecode(lastip.CurrentValue);
            lastip.EditValue = HtmlEncode(lastip.CurrentValue);
            lastip.PlaceHolder = RemoveHtml(lastip.Caption);

            // secret
            secret.SetupEditAttributes();
            if (!secret.Raw)
                secret.CurrentValue = HtmlDecode(secret.CurrentValue);
            secret.EditValue = HtmlEncode(secret.CurrentValue);
            secret.PlaceHolder = RemoveHtml(secret.Caption);

            // picture
            picture.SetupEditAttributes();
            picture.EditValue = picture.CurrentValue; // DN
            picture.PlaceHolder = RemoveHtml(picture.Caption);
            if (!Empty(picture.EditValue) && IsNumeric(picture.EditValue))
                picture.EditValue = FormatNumber(picture.EditValue, null);

            // description
            description.SetupEditAttributes();
            if (!description.Raw)
                description.CurrentValue = HtmlDecode(description.CurrentValue);
            description.EditValue = HtmlEncode(description.CurrentValue);
            description.PlaceHolder = RemoveHtml(description.Caption);

            // descriptionformat
            descriptionformat.SetupEditAttributes();
            descriptionformat.EditValue = descriptionformat.CurrentValue; // DN
            descriptionformat.PlaceHolder = RemoveHtml(descriptionformat.Caption);
            if (!Empty(descriptionformat.EditValue) && IsNumeric(descriptionformat.EditValue))
                descriptionformat.EditValue = FormatNumber(descriptionformat.EditValue, null);

            // mailformat
            mailformat.SetupEditAttributes();
            mailformat.EditValue = mailformat.CurrentValue; // DN
            mailformat.PlaceHolder = RemoveHtml(mailformat.Caption);
            if (!Empty(mailformat.EditValue) && IsNumeric(mailformat.EditValue))
                mailformat.EditValue = FormatNumber(mailformat.EditValue, null);

            // maildigest
            maildigest.SetupEditAttributes();
            maildigest.EditValue = maildigest.CurrentValue; // DN
            maildigest.PlaceHolder = RemoveHtml(maildigest.Caption);
            if (!Empty(maildigest.EditValue) && IsNumeric(maildigest.EditValue))
                maildigest.EditValue = FormatNumber(maildigest.EditValue, null);

            // maildisplay
            maildisplay.SetupEditAttributes();
            maildisplay.EditValue = maildisplay.CurrentValue; // DN
            maildisplay.PlaceHolder = RemoveHtml(maildisplay.Caption);
            if (!Empty(maildisplay.EditValue) && IsNumeric(maildisplay.EditValue))
                maildisplay.EditValue = FormatNumber(maildisplay.EditValue, null);

            // autosubscribe
            autosubscribe.SetupEditAttributes();
            autosubscribe.EditValue = autosubscribe.CurrentValue; // DN
            autosubscribe.PlaceHolder = RemoveHtml(autosubscribe.Caption);
            if (!Empty(autosubscribe.EditValue) && IsNumeric(autosubscribe.EditValue))
                autosubscribe.EditValue = FormatNumber(autosubscribe.EditValue, null);

            // trackforums
            trackforums.SetupEditAttributes();
            trackforums.EditValue = trackforums.CurrentValue; // DN
            trackforums.PlaceHolder = RemoveHtml(trackforums.Caption);
            if (!Empty(trackforums.EditValue) && IsNumeric(trackforums.EditValue))
                trackforums.EditValue = FormatNumber(trackforums.EditValue, null);

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

            // trustbitmask
            trustbitmask.SetupEditAttributes();
            trustbitmask.EditValue = trustbitmask.CurrentValue; // DN
            trustbitmask.PlaceHolder = RemoveHtml(trustbitmask.Caption);
            if (!Empty(trustbitmask.EditValue) && IsNumeric(trustbitmask.EditValue))
                trustbitmask.EditValue = FormatNumber(trustbitmask.EditValue, null);

            // imagealt
            imagealt.SetupEditAttributes();
            if (!imagealt.Raw)
                imagealt.CurrentValue = HtmlDecode(imagealt.CurrentValue);
            imagealt.EditValue = HtmlEncode(imagealt.CurrentValue);
            imagealt.PlaceHolder = RemoveHtml(imagealt.Caption);

            // lastnamephonetic
            lastnamephonetic.SetupEditAttributes();
            if (!lastnamephonetic.Raw)
                lastnamephonetic.CurrentValue = HtmlDecode(lastnamephonetic.CurrentValue);
            lastnamephonetic.EditValue = HtmlEncode(lastnamephonetic.CurrentValue);
            lastnamephonetic.PlaceHolder = RemoveHtml(lastnamephonetic.Caption);

            // firstnamephonetic
            firstnamephonetic.SetupEditAttributes();
            if (!firstnamephonetic.Raw)
                firstnamephonetic.CurrentValue = HtmlDecode(firstnamephonetic.CurrentValue);
            firstnamephonetic.EditValue = HtmlEncode(firstnamephonetic.CurrentValue);
            firstnamephonetic.PlaceHolder = RemoveHtml(firstnamephonetic.Caption);

            // middlename
            middlename.SetupEditAttributes();
            if (!middlename.Raw)
                middlename.CurrentValue = HtmlDecode(middlename.CurrentValue);
            middlename.EditValue = HtmlEncode(middlename.CurrentValue);
            middlename.PlaceHolder = RemoveHtml(middlename.Caption);

            // alternatename
            alternatename.SetupEditAttributes();
            if (!alternatename.Raw)
                alternatename.CurrentValue = HtmlDecode(alternatename.CurrentValue);
            alternatename.EditValue = HtmlEncode(alternatename.CurrentValue);
            alternatename.PlaceHolder = RemoveHtml(alternatename.Caption);

            // moodlenetprofile
            moodlenetprofile.SetupEditAttributes();
            if (!moodlenetprofile.Raw)
                moodlenetprofile.CurrentValue = HtmlDecode(moodlenetprofile.CurrentValue);
            moodlenetprofile.EditValue = HtmlEncode(moodlenetprofile.CurrentValue);
            moodlenetprofile.PlaceHolder = RemoveHtml(moodlenetprofile.Caption);

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
                        doc.ExportCaption(auth);
                        doc.ExportCaption(confirmed);
                        doc.ExportCaption(policyagreed);
                        doc.ExportCaption(deleted);
                        doc.ExportCaption(suspended);
                        doc.ExportCaption(mnethostid);
                        doc.ExportCaption(_username);
                        doc.ExportCaption(password);
                        doc.ExportCaption(idnumber);
                        doc.ExportCaption(firstname);
                        doc.ExportCaption(lastname);
                        doc.ExportCaption(_email);
                        doc.ExportCaption(emailstop);
                        doc.ExportCaption(phone1);
                        doc.ExportCaption(phone2);
                        doc.ExportCaption(institution);
                        doc.ExportCaption(department);
                        doc.ExportCaption(address);
                        doc.ExportCaption(city);
                        doc.ExportCaption(country);
                        doc.ExportCaption(_lang);
                        doc.ExportCaption(calendartype);
                        doc.ExportCaption(theme);
                        doc.ExportCaption(timezone);
                        doc.ExportCaption(firstaccess);
                        doc.ExportCaption(lastaccess);
                        doc.ExportCaption(lastlogin);
                        doc.ExportCaption(currentlogin);
                        doc.ExportCaption(lastip);
                        doc.ExportCaption(secret);
                        doc.ExportCaption(picture);
                        doc.ExportCaption(description);
                        doc.ExportCaption(descriptionformat);
                        doc.ExportCaption(mailformat);
                        doc.ExportCaption(maildigest);
                        doc.ExportCaption(maildisplay);
                        doc.ExportCaption(autosubscribe);
                        doc.ExportCaption(trackforums);
                        doc.ExportCaption(timecreated);
                        doc.ExportCaption(timemodified);
                        doc.ExportCaption(trustbitmask);
                        doc.ExportCaption(imagealt);
                        doc.ExportCaption(lastnamephonetic);
                        doc.ExportCaption(firstnamephonetic);
                        doc.ExportCaption(middlename);
                        doc.ExportCaption(alternatename);
                        doc.ExportCaption(moodlenetprofile);
                    } else {
                        doc.ExportCaption(id);
                        doc.ExportCaption(auth);
                        doc.ExportCaption(confirmed);
                        doc.ExportCaption(policyagreed);
                        doc.ExportCaption(deleted);
                        doc.ExportCaption(suspended);
                        doc.ExportCaption(mnethostid);
                        doc.ExportCaption(_username);
                        doc.ExportCaption(password);
                        doc.ExportCaption(idnumber);
                        doc.ExportCaption(firstname);
                        doc.ExportCaption(lastname);
                        doc.ExportCaption(_email);
                        doc.ExportCaption(emailstop);
                        doc.ExportCaption(phone1);
                        doc.ExportCaption(phone2);
                        doc.ExportCaption(institution);
                        doc.ExportCaption(department);
                        doc.ExportCaption(address);
                        doc.ExportCaption(city);
                        doc.ExportCaption(country);
                        doc.ExportCaption(_lang);
                        doc.ExportCaption(calendartype);
                        doc.ExportCaption(theme);
                        doc.ExportCaption(timezone);
                        doc.ExportCaption(firstaccess);
                        doc.ExportCaption(lastaccess);
                        doc.ExportCaption(lastlogin);
                        doc.ExportCaption(currentlogin);
                        doc.ExportCaption(lastip);
                        doc.ExportCaption(secret);
                        doc.ExportCaption(picture);
                        doc.ExportCaption(description);
                        doc.ExportCaption(descriptionformat);
                        doc.ExportCaption(mailformat);
                        doc.ExportCaption(maildigest);
                        doc.ExportCaption(maildisplay);
                        doc.ExportCaption(autosubscribe);
                        doc.ExportCaption(trackforums);
                        doc.ExportCaption(timecreated);
                        doc.ExportCaption(timemodified);
                        doc.ExportCaption(trustbitmask);
                        doc.ExportCaption(imagealt);
                        doc.ExportCaption(lastnamephonetic);
                        doc.ExportCaption(firstnamephonetic);
                        doc.ExportCaption(middlename);
                        doc.ExportCaption(alternatename);
                        doc.ExportCaption(moodlenetprofile);
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
                            await doc.ExportField(auth);
                            await doc.ExportField(confirmed);
                            await doc.ExportField(policyagreed);
                            await doc.ExportField(deleted);
                            await doc.ExportField(suspended);
                            await doc.ExportField(mnethostid);
                            await doc.ExportField(_username);
                            await doc.ExportField(password);
                            await doc.ExportField(idnumber);
                            await doc.ExportField(firstname);
                            await doc.ExportField(lastname);
                            await doc.ExportField(_email);
                            await doc.ExportField(emailstop);
                            await doc.ExportField(phone1);
                            await doc.ExportField(phone2);
                            await doc.ExportField(institution);
                            await doc.ExportField(department);
                            await doc.ExportField(address);
                            await doc.ExportField(city);
                            await doc.ExportField(country);
                            await doc.ExportField(_lang);
                            await doc.ExportField(calendartype);
                            await doc.ExportField(theme);
                            await doc.ExportField(timezone);
                            await doc.ExportField(firstaccess);
                            await doc.ExportField(lastaccess);
                            await doc.ExportField(lastlogin);
                            await doc.ExportField(currentlogin);
                            await doc.ExportField(lastip);
                            await doc.ExportField(secret);
                            await doc.ExportField(picture);
                            await doc.ExportField(description);
                            await doc.ExportField(descriptionformat);
                            await doc.ExportField(mailformat);
                            await doc.ExportField(maildigest);
                            await doc.ExportField(maildisplay);
                            await doc.ExportField(autosubscribe);
                            await doc.ExportField(trackforums);
                            await doc.ExportField(timecreated);
                            await doc.ExportField(timemodified);
                            await doc.ExportField(trustbitmask);
                            await doc.ExportField(imagealt);
                            await doc.ExportField(lastnamephonetic);
                            await doc.ExportField(firstnamephonetic);
                            await doc.ExportField(middlename);
                            await doc.ExportField(alternatename);
                            await doc.ExportField(moodlenetprofile);
                        } else {
                            await doc.ExportField(id);
                            await doc.ExportField(auth);
                            await doc.ExportField(confirmed);
                            await doc.ExportField(policyagreed);
                            await doc.ExportField(deleted);
                            await doc.ExportField(suspended);
                            await doc.ExportField(mnethostid);
                            await doc.ExportField(_username);
                            await doc.ExportField(password);
                            await doc.ExportField(idnumber);
                            await doc.ExportField(firstname);
                            await doc.ExportField(lastname);
                            await doc.ExportField(_email);
                            await doc.ExportField(emailstop);
                            await doc.ExportField(phone1);
                            await doc.ExportField(phone2);
                            await doc.ExportField(institution);
                            await doc.ExportField(department);
                            await doc.ExportField(address);
                            await doc.ExportField(city);
                            await doc.ExportField(country);
                            await doc.ExportField(_lang);
                            await doc.ExportField(calendartype);
                            await doc.ExportField(theme);
                            await doc.ExportField(timezone);
                            await doc.ExportField(firstaccess);
                            await doc.ExportField(lastaccess);
                            await doc.ExportField(lastlogin);
                            await doc.ExportField(currentlogin);
                            await doc.ExportField(lastip);
                            await doc.ExportField(secret);
                            await doc.ExportField(picture);
                            await doc.ExportField(description);
                            await doc.ExportField(descriptionformat);
                            await doc.ExportField(mailformat);
                            await doc.ExportField(maildigest);
                            await doc.ExportField(maildisplay);
                            await doc.ExportField(autosubscribe);
                            await doc.ExportField(trackforums);
                            await doc.ExportField(timecreated);
                            await doc.ExportField(timemodified);
                            await doc.ExportField(trustbitmask);
                            await doc.ExportField(imagealt);
                            await doc.ExportField(lastnamephonetic);
                            await doc.ExportField(firstnamephonetic);
                            await doc.ExportField(middlename);
                            await doc.ExportField(alternatename);
                            await doc.ExportField(moodlenetprofile);
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
