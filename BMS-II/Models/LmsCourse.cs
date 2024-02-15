namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// lmsCourse
    /// </summary>
    [MaybeNull]
    public static LmsCourse lmsCourse
    {
        get => HttpData.Resolve<LmsCourse>("LMS_Course");
        set => HttpData["LMS_Course"] = value;
    }

    /// <summary>
    /// Table class for LMS_Course
    /// </summary>
    public class LmsCourse : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> category;

        public readonly DbField<SqlDbType> sortorder;

        public readonly DbField<SqlDbType> fullname;

        public readonly DbField<SqlDbType> shortname;

        public readonly DbField<SqlDbType> idnumber;

        public readonly DbField<SqlDbType> summary;

        public readonly DbField<SqlDbType> summaryformat;

        public readonly DbField<SqlDbType> format;

        public readonly DbField<SqlDbType> showgrades;

        public readonly DbField<SqlDbType> newsitems;

        public readonly DbField<SqlDbType> startdate;

        public readonly DbField<SqlDbType> enddate;

        public readonly DbField<SqlDbType> relativedatesmode;

        public readonly DbField<SqlDbType> marker;

        public readonly DbField<SqlDbType> maxbytes;

        public readonly DbField<SqlDbType> legacyfiles;

        public readonly DbField<SqlDbType> showreports;

        public readonly DbField<SqlDbType> _visible;

        public readonly DbField<SqlDbType> visibleold;

        public readonly DbField<SqlDbType> downloadcontent;

        public readonly DbField<SqlDbType> groupmode;

        public readonly DbField<SqlDbType> groupmodeforce;

        public readonly DbField<SqlDbType> defaultgroupingid;

        public readonly DbField<SqlDbType> _lang;

        public readonly DbField<SqlDbType> calendartype;

        public readonly DbField<SqlDbType> theme;

        public readonly DbField<SqlDbType> timecreated;

        public readonly DbField<SqlDbType> timemodified;

        public readonly DbField<SqlDbType> requested;

        public readonly DbField<SqlDbType> enablecompletion;

        public readonly DbField<SqlDbType> completionnotify;

        public readonly DbField<SqlDbType> cacherev;

        public readonly DbField<SqlDbType> originalcourseid;

        public readonly DbField<SqlDbType> showactivitydates;

        public readonly DbField<SqlDbType> showcompletionconditions;

        public readonly DbField<SqlDbType> pdfexportfont;

        // Constructor
        public LmsCourse()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "LMS_Course";
            Name = "LMS_Course";
            Type = "VIEW";
            UpdateTable = "dbo.LMS_Course"; // Update Table
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("id", id);

            // category
            category = new (this, "x_category", 20, SqlDbType.BigInt) {
                Name = "category",
                Expression = "[category]",
                BasicSearchExpression = "CAST([category] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[category]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "category", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("category", category);

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
                CustomMessage = Language.FieldPhrase("LMS_Course", "sortorder", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("sortorder", sortorder);

            // fullname
            fullname = new (this, "x_fullname", 200, SqlDbType.VarChar) {
                Name = "fullname",
                Expression = "[fullname]",
                UseBasicSearch = true,
                BasicSearchExpression = "[fullname]",
                DateTimeFormat = -1,
                VirtualExpression = "[fullname]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "fullname", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("fullname", fullname);

            // shortname
            shortname = new (this, "x_shortname", 200, SqlDbType.VarChar) {
                Name = "shortname",
                Expression = "[shortname]",
                UseBasicSearch = true,
                BasicSearchExpression = "[shortname]",
                DateTimeFormat = -1,
                VirtualExpression = "[shortname]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "shortname", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("shortname", shortname);

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
                CustomMessage = Language.FieldPhrase("LMS_Course", "idnumber", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("idnumber", idnumber);

            // summary
            summary = new (this, "x_summary", 200, SqlDbType.VarChar) {
                Name = "summary",
                Expression = "[summary]",
                UseBasicSearch = true,
                BasicSearchExpression = "[summary]",
                DateTimeFormat = -1,
                VirtualExpression = "[summary]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Course", "summary", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("summary", summary);

            // summaryformat
            summaryformat = new (this, "x_summaryformat", 131, SqlDbType.Decimal) {
                Name = "summaryformat",
                Expression = "[summaryformat]",
                BasicSearchExpression = "CAST([summaryformat] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[summaryformat]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "summaryformat", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("summaryformat", summaryformat);

            // format
            format = new (this, "x_format", 200, SqlDbType.VarChar) {
                Name = "format",
                Expression = "[format]",
                UseBasicSearch = true,
                BasicSearchExpression = "[format]",
                DateTimeFormat = -1,
                VirtualExpression = "[format]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "format", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("format", format);

            // showgrades
            showgrades = new (this, "x_showgrades", 131, SqlDbType.Decimal) {
                Name = "showgrades",
                Expression = "[showgrades]",
                BasicSearchExpression = "CAST([showgrades] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[showgrades]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "showgrades", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("showgrades", showgrades);

            // newsitems
            newsitems = new (this, "x_newsitems", 3, SqlDbType.Int) {
                Name = "newsitems",
                Expression = "[newsitems]",
                BasicSearchExpression = "CAST([newsitems] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[newsitems]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "newsitems", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("newsitems", newsitems);

            // startdate
            startdate = new (this, "x_startdate", 20, SqlDbType.BigInt) {
                Name = "startdate",
                Expression = "[startdate]",
                BasicSearchExpression = "CAST([startdate] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[startdate]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "startdate", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("startdate", startdate);

            // enddate
            enddate = new (this, "x_enddate", 20, SqlDbType.BigInt) {
                Name = "enddate",
                Expression = "[enddate]",
                BasicSearchExpression = "CAST([enddate] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[enddate]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "enddate", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("enddate", enddate);

            // relativedatesmode
            relativedatesmode = new (this, "x_relativedatesmode", 131, SqlDbType.Decimal) {
                Name = "relativedatesmode",
                Expression = "[relativedatesmode]",
                BasicSearchExpression = "CAST([relativedatesmode] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[relativedatesmode]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "relativedatesmode", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("relativedatesmode", relativedatesmode);

            // marker
            marker = new (this, "x_marker", 20, SqlDbType.BigInt) {
                Name = "marker",
                Expression = "[marker]",
                BasicSearchExpression = "CAST([marker] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[marker]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "marker", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("marker", marker);

            // maxbytes
            maxbytes = new (this, "x_maxbytes", 20, SqlDbType.BigInt) {
                Name = "maxbytes",
                Expression = "[maxbytes]",
                BasicSearchExpression = "CAST([maxbytes] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[maxbytes]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "maxbytes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("maxbytes", maxbytes);

            // legacyfiles
            legacyfiles = new (this, "x_legacyfiles", 2, SqlDbType.SmallInt) {
                Name = "legacyfiles",
                Expression = "[legacyfiles]",
                BasicSearchExpression = "CAST([legacyfiles] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[legacyfiles]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "legacyfiles", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("legacyfiles", legacyfiles);

            // showreports
            showreports = new (this, "x_showreports", 2, SqlDbType.SmallInt) {
                Name = "showreports",
                Expression = "[showreports]",
                BasicSearchExpression = "CAST([showreports] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[showreports]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "showreports", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("showreports", showreports);

            // visible
            _visible = new (this, "x__visible", 131, SqlDbType.Decimal) {
                Name = "visible",
                Expression = "[visible]",
                BasicSearchExpression = "CAST([visible] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[visible]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "_visible", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("visible", _visible);

            // visibleold
            visibleold = new (this, "x_visibleold", 131, SqlDbType.Decimal) {
                Name = "visibleold",
                Expression = "[visibleold]",
                BasicSearchExpression = "CAST([visibleold] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[visibleold]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "visibleold", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("visibleold", visibleold);

            // downloadcontent
            downloadcontent = new (this, "x_downloadcontent", 131, SqlDbType.Decimal) {
                Name = "downloadcontent",
                Expression = "[downloadcontent]",
                BasicSearchExpression = "CAST([downloadcontent] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[downloadcontent]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Course", "downloadcontent", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("downloadcontent", downloadcontent);

            // groupmode
            groupmode = new (this, "x_groupmode", 2, SqlDbType.SmallInt) {
                Name = "groupmode",
                Expression = "[groupmode]",
                BasicSearchExpression = "CAST([groupmode] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[groupmode]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "groupmode", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("groupmode", groupmode);

            // groupmodeforce
            groupmodeforce = new (this, "x_groupmodeforce", 2, SqlDbType.SmallInt) {
                Name = "groupmodeforce",
                Expression = "[groupmodeforce]",
                BasicSearchExpression = "CAST([groupmodeforce] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[groupmodeforce]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "groupmodeforce", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("groupmodeforce", groupmodeforce);

            // defaultgroupingid
            defaultgroupingid = new (this, "x_defaultgroupingid", 20, SqlDbType.BigInt) {
                Name = "defaultgroupingid",
                Expression = "[defaultgroupingid]",
                BasicSearchExpression = "CAST([defaultgroupingid] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[defaultgroupingid]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "defaultgroupingid", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("defaultgroupingid", defaultgroupingid);

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
                CustomMessage = Language.FieldPhrase("LMS_Course", "_lang", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "calendartype", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "theme", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("theme", theme);

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
                CustomMessage = Language.FieldPhrase("LMS_Course", "timecreated", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "timemodified", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("timemodified", timemodified);

            // requested
            requested = new (this, "x_requested", 131, SqlDbType.Decimal) {
                Name = "requested",
                Expression = "[requested]",
                BasicSearchExpression = "CAST([requested] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[requested]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "requested", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("requested", requested);

            // enablecompletion
            enablecompletion = new (this, "x_enablecompletion", 131, SqlDbType.Decimal) {
                Name = "enablecompletion",
                Expression = "[enablecompletion]",
                BasicSearchExpression = "CAST([enablecompletion] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[enablecompletion]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "enablecompletion", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("enablecompletion", enablecompletion);

            // completionnotify
            completionnotify = new (this, "x_completionnotify", 131, SqlDbType.Decimal) {
                Name = "completionnotify",
                Expression = "[completionnotify]",
                BasicSearchExpression = "CAST([completionnotify] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[completionnotify]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "completionnotify", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("completionnotify", completionnotify);

            // cacherev
            cacherev = new (this, "x_cacherev", 20, SqlDbType.BigInt) {
                Name = "cacherev",
                Expression = "[cacherev]",
                BasicSearchExpression = "CAST([cacherev] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[cacherev]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "cacherev", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("cacherev", cacherev);

            // originalcourseid
            originalcourseid = new (this, "x_originalcourseid", 20, SqlDbType.BigInt) {
                Name = "originalcourseid",
                Expression = "[originalcourseid]",
                BasicSearchExpression = "CAST([originalcourseid] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[originalcourseid]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Course", "originalcourseid", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("originalcourseid", originalcourseid);

            // showactivitydates
            showactivitydates = new (this, "x_showactivitydates", 131, SqlDbType.Decimal) {
                Name = "showactivitydates",
                Expression = "[showactivitydates]",
                BasicSearchExpression = "CAST([showactivitydates] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[showactivitydates]",
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
                CustomMessage = Language.FieldPhrase("LMS_Course", "showactivitydates", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("showactivitydates", showactivitydates);

            // showcompletionconditions
            showcompletionconditions = new (this, "x_showcompletionconditions", 131, SqlDbType.Decimal) {
                Name = "showcompletionconditions",
                Expression = "[showcompletionconditions]",
                BasicSearchExpression = "CAST([showcompletionconditions] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[showcompletionconditions]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Course", "showcompletionconditions", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("showcompletionconditions", showcompletionconditions);

            // pdfexportfont
            pdfexportfont = new (this, "x_pdfexportfont", 200, SqlDbType.VarChar) {
                Name = "pdfexportfont",
                Expression = "[pdfexportfont]",
                UseBasicSearch = true,
                BasicSearchExpression = "[pdfexportfont]",
                DateTimeFormat = -1,
                VirtualExpression = "[pdfexportfont]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("LMS_Course", "pdfexportfont", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("pdfexportfont", pdfexportfont);

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
            get => _sqlFrom ?? "dbo.LMS_Course";
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
                category.DbValue = row["category"]; // Set DB value only
                sortorder.DbValue = row["sortorder"]; // Set DB value only
                fullname.DbValue = row["fullname"]; // Set DB value only
                shortname.DbValue = row["shortname"]; // Set DB value only
                idnumber.DbValue = row["idnumber"]; // Set DB value only
                summary.DbValue = row["summary"]; // Set DB value only
                summaryformat.DbValue = row["summaryformat"]; // Set DB value only
                format.DbValue = row["format"]; // Set DB value only
                showgrades.DbValue = row["showgrades"]; // Set DB value only
                newsitems.DbValue = row["newsitems"]; // Set DB value only
                startdate.DbValue = row["startdate"]; // Set DB value only
                enddate.DbValue = row["enddate"]; // Set DB value only
                relativedatesmode.DbValue = row["relativedatesmode"]; // Set DB value only
                marker.DbValue = row["marker"]; // Set DB value only
                maxbytes.DbValue = row["maxbytes"]; // Set DB value only
                legacyfiles.DbValue = row["legacyfiles"]; // Set DB value only
                showreports.DbValue = row["showreports"]; // Set DB value only
                _visible.DbValue = row["visible"]; // Set DB value only
                visibleold.DbValue = row["visibleold"]; // Set DB value only
                downloadcontent.DbValue = row["downloadcontent"]; // Set DB value only
                groupmode.DbValue = row["groupmode"]; // Set DB value only
                groupmodeforce.DbValue = row["groupmodeforce"]; // Set DB value only
                defaultgroupingid.DbValue = row["defaultgroupingid"]; // Set DB value only
                _lang.DbValue = row["lang"]; // Set DB value only
                calendartype.DbValue = row["calendartype"]; // Set DB value only
                theme.DbValue = row["theme"]; // Set DB value only
                timecreated.DbValue = row["timecreated"]; // Set DB value only
                timemodified.DbValue = row["timemodified"]; // Set DB value only
                requested.DbValue = row["requested"]; // Set DB value only
                enablecompletion.DbValue = row["enablecompletion"]; // Set DB value only
                completionnotify.DbValue = row["completionnotify"]; // Set DB value only
                cacherev.DbValue = row["cacherev"]; // Set DB value only
                originalcourseid.DbValue = row["originalcourseid"]; // Set DB value only
                showactivitydates.DbValue = row["showactivitydates"]; // Set DB value only
                showcompletionconditions.DbValue = row["showcompletionconditions"]; // Set DB value only
                pdfexportfont.DbValue = row["pdfexportfont"]; // Set DB value only
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
                    return "LmsCourseList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "LmsCourseView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "LmsCourseEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "LmsCourseAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "LmsCourseList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "LmsCourseView",
                Config.ApiAddAction => "LmsCourseAdd",
                Config.ApiEditAction => "LmsCourseEdit",
                Config.ApiDeleteAction => "LmsCourseDelete",
                Config.ApiListAction => "LmsCourseList",
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
        public string ListUrl => "LmsCourseList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("LmsCourseView", parm);
            else
                url = KeyUrl("LmsCourseView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "LmsCourseAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "LmsCourseAdd?" + parm;
            else
                url = "LmsCourseAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("LmsCourseEdit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("LmsCourseList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("LmsCourseAdd", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("LmsCourseList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("LmsCourseDelete")); // DN

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
            category.SetDbValue(dr["category"]);
            sortorder.SetDbValue(dr["sortorder"]);
            fullname.SetDbValue(dr["fullname"]);
            shortname.SetDbValue(dr["shortname"]);
            idnumber.SetDbValue(dr["idnumber"]);
            summary.SetDbValue(dr["summary"]);
            summaryformat.SetDbValue(dr["summaryformat"]);
            format.SetDbValue(dr["format"]);
            showgrades.SetDbValue(dr["showgrades"]);
            newsitems.SetDbValue(dr["newsitems"]);
            startdate.SetDbValue(dr["startdate"]);
            enddate.SetDbValue(dr["enddate"]);
            relativedatesmode.SetDbValue(dr["relativedatesmode"]);
            marker.SetDbValue(dr["marker"]);
            maxbytes.SetDbValue(dr["maxbytes"]);
            legacyfiles.SetDbValue(dr["legacyfiles"]);
            showreports.SetDbValue(dr["showreports"]);
            _visible.SetDbValue(dr["visible"]);
            visibleold.SetDbValue(dr["visibleold"]);
            downloadcontent.SetDbValue(dr["downloadcontent"]);
            groupmode.SetDbValue(dr["groupmode"]);
            groupmodeforce.SetDbValue(dr["groupmodeforce"]);
            defaultgroupingid.SetDbValue(dr["defaultgroupingid"]);
            _lang.SetDbValue(dr["lang"]);
            calendartype.SetDbValue(dr["calendartype"]);
            theme.SetDbValue(dr["theme"]);
            timecreated.SetDbValue(dr["timecreated"]);
            timemodified.SetDbValue(dr["timemodified"]);
            requested.SetDbValue(dr["requested"]);
            enablecompletion.SetDbValue(dr["enablecompletion"]);
            completionnotify.SetDbValue(dr["completionnotify"]);
            cacherev.SetDbValue(dr["cacherev"]);
            originalcourseid.SetDbValue(dr["originalcourseid"]);
            showactivitydates.SetDbValue(dr["showactivitydates"]);
            showcompletionconditions.SetDbValue(dr["showcompletionconditions"]);
            pdfexportfont.SetDbValue(dr["pdfexportfont"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "LmsCourseList";
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

            // category

            // sortorder

            // fullname

            // shortname

            // idnumber

            // summary

            // summaryformat

            // format

            // showgrades

            // newsitems

            // startdate

            // enddate

            // relativedatesmode

            // marker

            // maxbytes

            // legacyfiles

            // showreports

            // visible

            // visibleold

            // downloadcontent

            // groupmode

            // groupmodeforce

            // defaultgroupingid

            // lang

            // calendartype

            // theme

            // timecreated

            // timemodified

            // requested

            // enablecompletion

            // completionnotify

            // cacherev

            // originalcourseid

            // showactivitydates

            // showcompletionconditions

            // pdfexportfont

            // id
            id.ViewValue = id.CurrentValue;
            id.ViewValue = FormatNumber(id.ViewValue, id.FormatPattern);
            id.ViewCustomAttributes = "";

            // category
            category.ViewValue = category.CurrentValue;
            category.ViewValue = FormatNumber(category.ViewValue, category.FormatPattern);
            category.ViewCustomAttributes = "";

            // sortorder
            sortorder.ViewValue = sortorder.CurrentValue;
            sortorder.ViewValue = FormatNumber(sortorder.ViewValue, sortorder.FormatPattern);
            sortorder.ViewCustomAttributes = "";

            // fullname
            fullname.ViewValue = ConvertToString(fullname.CurrentValue); // DN
            fullname.ViewCustomAttributes = "";

            // shortname
            shortname.ViewValue = ConvertToString(shortname.CurrentValue); // DN
            shortname.ViewCustomAttributes = "";

            // idnumber
            idnumber.ViewValue = ConvertToString(idnumber.CurrentValue); // DN
            idnumber.ViewCustomAttributes = "";

            // summary
            summary.ViewValue = ConvertToString(summary.CurrentValue); // DN
            summary.ViewCustomAttributes = "";

            // summaryformat
            summaryformat.ViewValue = summaryformat.CurrentValue;
            summaryformat.ViewValue = FormatNumber(summaryformat.ViewValue, summaryformat.FormatPattern);
            summaryformat.ViewCustomAttributes = "";

            // format
            format.ViewValue = ConvertToString(format.CurrentValue); // DN
            format.ViewCustomAttributes = "";

            // showgrades
            showgrades.ViewValue = showgrades.CurrentValue;
            showgrades.ViewValue = FormatNumber(showgrades.ViewValue, showgrades.FormatPattern);
            showgrades.ViewCustomAttributes = "";

            // newsitems
            newsitems.ViewValue = newsitems.CurrentValue;
            newsitems.ViewValue = FormatNumber(newsitems.ViewValue, newsitems.FormatPattern);
            newsitems.ViewCustomAttributes = "";

            // startdate
            startdate.ViewValue = startdate.CurrentValue;
            startdate.ViewValue = FormatNumber(startdate.ViewValue, startdate.FormatPattern);
            startdate.ViewCustomAttributes = "";

            // enddate
            enddate.ViewValue = enddate.CurrentValue;
            enddate.ViewValue = FormatNumber(enddate.ViewValue, enddate.FormatPattern);
            enddate.ViewCustomAttributes = "";

            // relativedatesmode
            relativedatesmode.ViewValue = relativedatesmode.CurrentValue;
            relativedatesmode.ViewValue = FormatNumber(relativedatesmode.ViewValue, relativedatesmode.FormatPattern);
            relativedatesmode.ViewCustomAttributes = "";

            // marker
            marker.ViewValue = marker.CurrentValue;
            marker.ViewValue = FormatNumber(marker.ViewValue, marker.FormatPattern);
            marker.ViewCustomAttributes = "";

            // maxbytes
            maxbytes.ViewValue = maxbytes.CurrentValue;
            maxbytes.ViewValue = FormatNumber(maxbytes.ViewValue, maxbytes.FormatPattern);
            maxbytes.ViewCustomAttributes = "";

            // legacyfiles
            legacyfiles.ViewValue = legacyfiles.CurrentValue;
            legacyfiles.ViewValue = FormatNumber(legacyfiles.ViewValue, legacyfiles.FormatPattern);
            legacyfiles.ViewCustomAttributes = "";

            // showreports
            showreports.ViewValue = showreports.CurrentValue;
            showreports.ViewValue = FormatNumber(showreports.ViewValue, showreports.FormatPattern);
            showreports.ViewCustomAttributes = "";

            // visible
            _visible.ViewValue = _visible.CurrentValue;
            _visible.ViewValue = FormatNumber(_visible.ViewValue, _visible.FormatPattern);
            _visible.ViewCustomAttributes = "";

            // visibleold
            visibleold.ViewValue = visibleold.CurrentValue;
            visibleold.ViewValue = FormatNumber(visibleold.ViewValue, visibleold.FormatPattern);
            visibleold.ViewCustomAttributes = "";

            // downloadcontent
            downloadcontent.ViewValue = downloadcontent.CurrentValue;
            downloadcontent.ViewValue = FormatNumber(downloadcontent.ViewValue, downloadcontent.FormatPattern);
            downloadcontent.ViewCustomAttributes = "";

            // groupmode
            groupmode.ViewValue = groupmode.CurrentValue;
            groupmode.ViewValue = FormatNumber(groupmode.ViewValue, groupmode.FormatPattern);
            groupmode.ViewCustomAttributes = "";

            // groupmodeforce
            groupmodeforce.ViewValue = groupmodeforce.CurrentValue;
            groupmodeforce.ViewValue = FormatNumber(groupmodeforce.ViewValue, groupmodeforce.FormatPattern);
            groupmodeforce.ViewCustomAttributes = "";

            // defaultgroupingid
            defaultgroupingid.ViewValue = defaultgroupingid.CurrentValue;
            defaultgroupingid.ViewValue = FormatNumber(defaultgroupingid.ViewValue, defaultgroupingid.FormatPattern);
            defaultgroupingid.ViewCustomAttributes = "";

            // lang
            _lang.ViewValue = ConvertToString(_lang.CurrentValue); // DN
            _lang.ViewCustomAttributes = "";

            // calendartype
            calendartype.ViewValue = ConvertToString(calendartype.CurrentValue); // DN
            calendartype.ViewCustomAttributes = "";

            // theme
            theme.ViewValue = ConvertToString(theme.CurrentValue); // DN
            theme.ViewCustomAttributes = "";

            // timecreated
            timecreated.ViewValue = timecreated.CurrentValue;
            timecreated.ViewValue = FormatNumber(timecreated.ViewValue, timecreated.FormatPattern);
            timecreated.ViewCustomAttributes = "";

            // timemodified
            timemodified.ViewValue = timemodified.CurrentValue;
            timemodified.ViewValue = FormatNumber(timemodified.ViewValue, timemodified.FormatPattern);
            timemodified.ViewCustomAttributes = "";

            // requested
            requested.ViewValue = requested.CurrentValue;
            requested.ViewValue = FormatNumber(requested.ViewValue, requested.FormatPattern);
            requested.ViewCustomAttributes = "";

            // enablecompletion
            enablecompletion.ViewValue = enablecompletion.CurrentValue;
            enablecompletion.ViewValue = FormatNumber(enablecompletion.ViewValue, enablecompletion.FormatPattern);
            enablecompletion.ViewCustomAttributes = "";

            // completionnotify
            completionnotify.ViewValue = completionnotify.CurrentValue;
            completionnotify.ViewValue = FormatNumber(completionnotify.ViewValue, completionnotify.FormatPattern);
            completionnotify.ViewCustomAttributes = "";

            // cacherev
            cacherev.ViewValue = cacherev.CurrentValue;
            cacherev.ViewValue = FormatNumber(cacherev.ViewValue, cacherev.FormatPattern);
            cacherev.ViewCustomAttributes = "";

            // originalcourseid
            originalcourseid.ViewValue = originalcourseid.CurrentValue;
            originalcourseid.ViewValue = FormatNumber(originalcourseid.ViewValue, originalcourseid.FormatPattern);
            originalcourseid.ViewCustomAttributes = "";

            // showactivitydates
            showactivitydates.ViewValue = showactivitydates.CurrentValue;
            showactivitydates.ViewValue = FormatNumber(showactivitydates.ViewValue, showactivitydates.FormatPattern);
            showactivitydates.ViewCustomAttributes = "";

            // showcompletionconditions
            showcompletionconditions.ViewValue = showcompletionconditions.CurrentValue;
            showcompletionconditions.ViewValue = FormatNumber(showcompletionconditions.ViewValue, showcompletionconditions.FormatPattern);
            showcompletionconditions.ViewCustomAttributes = "";

            // pdfexportfont
            pdfexportfont.ViewValue = ConvertToString(pdfexportfont.CurrentValue); // DN
            pdfexportfont.ViewCustomAttributes = "";

            // id
            id.HrefValue = "";
            id.TooltipValue = "";

            // category
            category.HrefValue = "";
            category.TooltipValue = "";

            // sortorder
            sortorder.HrefValue = "";
            sortorder.TooltipValue = "";

            // fullname
            fullname.HrefValue = "";
            fullname.TooltipValue = "";

            // shortname
            shortname.HrefValue = "";
            shortname.TooltipValue = "";

            // idnumber
            idnumber.HrefValue = "";
            idnumber.TooltipValue = "";

            // summary
            summary.HrefValue = "";
            summary.TooltipValue = "";

            // summaryformat
            summaryformat.HrefValue = "";
            summaryformat.TooltipValue = "";

            // format
            format.HrefValue = "";
            format.TooltipValue = "";

            // showgrades
            showgrades.HrefValue = "";
            showgrades.TooltipValue = "";

            // newsitems
            newsitems.HrefValue = "";
            newsitems.TooltipValue = "";

            // startdate
            startdate.HrefValue = "";
            startdate.TooltipValue = "";

            // enddate
            enddate.HrefValue = "";
            enddate.TooltipValue = "";

            // relativedatesmode
            relativedatesmode.HrefValue = "";
            relativedatesmode.TooltipValue = "";

            // marker
            marker.HrefValue = "";
            marker.TooltipValue = "";

            // maxbytes
            maxbytes.HrefValue = "";
            maxbytes.TooltipValue = "";

            // legacyfiles
            legacyfiles.HrefValue = "";
            legacyfiles.TooltipValue = "";

            // showreports
            showreports.HrefValue = "";
            showreports.TooltipValue = "";

            // visible
            _visible.HrefValue = "";
            _visible.TooltipValue = "";

            // visibleold
            visibleold.HrefValue = "";
            visibleold.TooltipValue = "";

            // downloadcontent
            downloadcontent.HrefValue = "";
            downloadcontent.TooltipValue = "";

            // groupmode
            groupmode.HrefValue = "";
            groupmode.TooltipValue = "";

            // groupmodeforce
            groupmodeforce.HrefValue = "";
            groupmodeforce.TooltipValue = "";

            // defaultgroupingid
            defaultgroupingid.HrefValue = "";
            defaultgroupingid.TooltipValue = "";

            // lang
            _lang.HrefValue = "";
            _lang.TooltipValue = "";

            // calendartype
            calendartype.HrefValue = "";
            calendartype.TooltipValue = "";

            // theme
            theme.HrefValue = "";
            theme.TooltipValue = "";

            // timecreated
            timecreated.HrefValue = "";
            timecreated.TooltipValue = "";

            // timemodified
            timemodified.HrefValue = "";
            timemodified.TooltipValue = "";

            // requested
            requested.HrefValue = "";
            requested.TooltipValue = "";

            // enablecompletion
            enablecompletion.HrefValue = "";
            enablecompletion.TooltipValue = "";

            // completionnotify
            completionnotify.HrefValue = "";
            completionnotify.TooltipValue = "";

            // cacherev
            cacherev.HrefValue = "";
            cacherev.TooltipValue = "";

            // originalcourseid
            originalcourseid.HrefValue = "";
            originalcourseid.TooltipValue = "";

            // showactivitydates
            showactivitydates.HrefValue = "";
            showactivitydates.TooltipValue = "";

            // showcompletionconditions
            showcompletionconditions.HrefValue = "";
            showcompletionconditions.TooltipValue = "";

            // pdfexportfont
            pdfexportfont.HrefValue = "";
            pdfexportfont.TooltipValue = "";

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

            // category
            category.SetupEditAttributes();
            category.EditValue = category.CurrentValue; // DN
            category.PlaceHolder = RemoveHtml(category.Caption);
            if (!Empty(category.EditValue) && IsNumeric(category.EditValue))
                category.EditValue = FormatNumber(category.EditValue, null);

            // sortorder
            sortorder.SetupEditAttributes();
            sortorder.EditValue = sortorder.CurrentValue; // DN
            sortorder.PlaceHolder = RemoveHtml(sortorder.Caption);
            if (!Empty(sortorder.EditValue) && IsNumeric(sortorder.EditValue))
                sortorder.EditValue = FormatNumber(sortorder.EditValue, null);

            // fullname
            fullname.SetupEditAttributes();
            if (!fullname.Raw)
                fullname.CurrentValue = HtmlDecode(fullname.CurrentValue);
            fullname.EditValue = HtmlEncode(fullname.CurrentValue);
            fullname.PlaceHolder = RemoveHtml(fullname.Caption);

            // shortname
            shortname.SetupEditAttributes();
            if (!shortname.Raw)
                shortname.CurrentValue = HtmlDecode(shortname.CurrentValue);
            shortname.EditValue = HtmlEncode(shortname.CurrentValue);
            shortname.PlaceHolder = RemoveHtml(shortname.Caption);

            // idnumber
            idnumber.SetupEditAttributes();
            if (!idnumber.Raw)
                idnumber.CurrentValue = HtmlDecode(idnumber.CurrentValue);
            idnumber.EditValue = HtmlEncode(idnumber.CurrentValue);
            idnumber.PlaceHolder = RemoveHtml(idnumber.Caption);

            // summary
            summary.SetupEditAttributes();
            if (!summary.Raw)
                summary.CurrentValue = HtmlDecode(summary.CurrentValue);
            summary.EditValue = HtmlEncode(summary.CurrentValue);
            summary.PlaceHolder = RemoveHtml(summary.Caption);

            // summaryformat
            summaryformat.SetupEditAttributes();
            summaryformat.EditValue = summaryformat.CurrentValue; // DN
            summaryformat.PlaceHolder = RemoveHtml(summaryformat.Caption);
            if (!Empty(summaryformat.EditValue) && IsNumeric(summaryformat.EditValue))
                summaryformat.EditValue = FormatNumber(summaryformat.EditValue, null);

            // format
            format.SetupEditAttributes();
            if (!format.Raw)
                format.CurrentValue = HtmlDecode(format.CurrentValue);
            format.EditValue = HtmlEncode(format.CurrentValue);
            format.PlaceHolder = RemoveHtml(format.Caption);

            // showgrades
            showgrades.SetupEditAttributes();
            showgrades.EditValue = showgrades.CurrentValue; // DN
            showgrades.PlaceHolder = RemoveHtml(showgrades.Caption);
            if (!Empty(showgrades.EditValue) && IsNumeric(showgrades.EditValue))
                showgrades.EditValue = FormatNumber(showgrades.EditValue, null);

            // newsitems
            newsitems.SetupEditAttributes();
            newsitems.EditValue = newsitems.CurrentValue; // DN
            newsitems.PlaceHolder = RemoveHtml(newsitems.Caption);
            if (!Empty(newsitems.EditValue) && IsNumeric(newsitems.EditValue))
                newsitems.EditValue = FormatNumber(newsitems.EditValue, null);

            // startdate
            startdate.SetupEditAttributes();
            startdate.EditValue = startdate.CurrentValue; // DN
            startdate.PlaceHolder = RemoveHtml(startdate.Caption);
            if (!Empty(startdate.EditValue) && IsNumeric(startdate.EditValue))
                startdate.EditValue = FormatNumber(startdate.EditValue, null);

            // enddate
            enddate.SetupEditAttributes();
            enddate.EditValue = enddate.CurrentValue; // DN
            enddate.PlaceHolder = RemoveHtml(enddate.Caption);
            if (!Empty(enddate.EditValue) && IsNumeric(enddate.EditValue))
                enddate.EditValue = FormatNumber(enddate.EditValue, null);

            // relativedatesmode
            relativedatesmode.SetupEditAttributes();
            relativedatesmode.EditValue = relativedatesmode.CurrentValue; // DN
            relativedatesmode.PlaceHolder = RemoveHtml(relativedatesmode.Caption);
            if (!Empty(relativedatesmode.EditValue) && IsNumeric(relativedatesmode.EditValue))
                relativedatesmode.EditValue = FormatNumber(relativedatesmode.EditValue, null);

            // marker
            marker.SetupEditAttributes();
            marker.EditValue = marker.CurrentValue; // DN
            marker.PlaceHolder = RemoveHtml(marker.Caption);
            if (!Empty(marker.EditValue) && IsNumeric(marker.EditValue))
                marker.EditValue = FormatNumber(marker.EditValue, null);

            // maxbytes
            maxbytes.SetupEditAttributes();
            maxbytes.EditValue = maxbytes.CurrentValue; // DN
            maxbytes.PlaceHolder = RemoveHtml(maxbytes.Caption);
            if (!Empty(maxbytes.EditValue) && IsNumeric(maxbytes.EditValue))
                maxbytes.EditValue = FormatNumber(maxbytes.EditValue, null);

            // legacyfiles
            legacyfiles.SetupEditAttributes();
            legacyfiles.EditValue = legacyfiles.CurrentValue; // DN
            legacyfiles.PlaceHolder = RemoveHtml(legacyfiles.Caption);
            if (!Empty(legacyfiles.EditValue) && IsNumeric(legacyfiles.EditValue))
                legacyfiles.EditValue = FormatNumber(legacyfiles.EditValue, null);

            // showreports
            showreports.SetupEditAttributes();
            showreports.EditValue = showreports.CurrentValue; // DN
            showreports.PlaceHolder = RemoveHtml(showreports.Caption);
            if (!Empty(showreports.EditValue) && IsNumeric(showreports.EditValue))
                showreports.EditValue = FormatNumber(showreports.EditValue, null);

            // visible
            _visible.SetupEditAttributes();
            _visible.EditValue = _visible.CurrentValue; // DN
            _visible.PlaceHolder = RemoveHtml(_visible.Caption);
            if (!Empty(_visible.EditValue) && IsNumeric(_visible.EditValue))
                _visible.EditValue = FormatNumber(_visible.EditValue, null);

            // visibleold
            visibleold.SetupEditAttributes();
            visibleold.EditValue = visibleold.CurrentValue; // DN
            visibleold.PlaceHolder = RemoveHtml(visibleold.Caption);
            if (!Empty(visibleold.EditValue) && IsNumeric(visibleold.EditValue))
                visibleold.EditValue = FormatNumber(visibleold.EditValue, null);

            // downloadcontent
            downloadcontent.SetupEditAttributes();
            downloadcontent.EditValue = downloadcontent.CurrentValue; // DN
            downloadcontent.PlaceHolder = RemoveHtml(downloadcontent.Caption);
            if (!Empty(downloadcontent.EditValue) && IsNumeric(downloadcontent.EditValue))
                downloadcontent.EditValue = FormatNumber(downloadcontent.EditValue, null);

            // groupmode
            groupmode.SetupEditAttributes();
            groupmode.EditValue = groupmode.CurrentValue; // DN
            groupmode.PlaceHolder = RemoveHtml(groupmode.Caption);
            if (!Empty(groupmode.EditValue) && IsNumeric(groupmode.EditValue))
                groupmode.EditValue = FormatNumber(groupmode.EditValue, null);

            // groupmodeforce
            groupmodeforce.SetupEditAttributes();
            groupmodeforce.EditValue = groupmodeforce.CurrentValue; // DN
            groupmodeforce.PlaceHolder = RemoveHtml(groupmodeforce.Caption);
            if (!Empty(groupmodeforce.EditValue) && IsNumeric(groupmodeforce.EditValue))
                groupmodeforce.EditValue = FormatNumber(groupmodeforce.EditValue, null);

            // defaultgroupingid
            defaultgroupingid.SetupEditAttributes();
            defaultgroupingid.EditValue = defaultgroupingid.CurrentValue; // DN
            defaultgroupingid.PlaceHolder = RemoveHtml(defaultgroupingid.Caption);
            if (!Empty(defaultgroupingid.EditValue) && IsNumeric(defaultgroupingid.EditValue))
                defaultgroupingid.EditValue = FormatNumber(defaultgroupingid.EditValue, null);

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

            // requested
            requested.SetupEditAttributes();
            requested.EditValue = requested.CurrentValue; // DN
            requested.PlaceHolder = RemoveHtml(requested.Caption);
            if (!Empty(requested.EditValue) && IsNumeric(requested.EditValue))
                requested.EditValue = FormatNumber(requested.EditValue, null);

            // enablecompletion
            enablecompletion.SetupEditAttributes();
            enablecompletion.EditValue = enablecompletion.CurrentValue; // DN
            enablecompletion.PlaceHolder = RemoveHtml(enablecompletion.Caption);
            if (!Empty(enablecompletion.EditValue) && IsNumeric(enablecompletion.EditValue))
                enablecompletion.EditValue = FormatNumber(enablecompletion.EditValue, null);

            // completionnotify
            completionnotify.SetupEditAttributes();
            completionnotify.EditValue = completionnotify.CurrentValue; // DN
            completionnotify.PlaceHolder = RemoveHtml(completionnotify.Caption);
            if (!Empty(completionnotify.EditValue) && IsNumeric(completionnotify.EditValue))
                completionnotify.EditValue = FormatNumber(completionnotify.EditValue, null);

            // cacherev
            cacherev.SetupEditAttributes();
            cacherev.EditValue = cacherev.CurrentValue; // DN
            cacherev.PlaceHolder = RemoveHtml(cacherev.Caption);
            if (!Empty(cacherev.EditValue) && IsNumeric(cacherev.EditValue))
                cacherev.EditValue = FormatNumber(cacherev.EditValue, null);

            // originalcourseid
            originalcourseid.SetupEditAttributes();
            originalcourseid.EditValue = originalcourseid.CurrentValue; // DN
            originalcourseid.PlaceHolder = RemoveHtml(originalcourseid.Caption);
            if (!Empty(originalcourseid.EditValue) && IsNumeric(originalcourseid.EditValue))
                originalcourseid.EditValue = FormatNumber(originalcourseid.EditValue, null);

            // showactivitydates
            showactivitydates.SetupEditAttributes();
            showactivitydates.EditValue = showactivitydates.CurrentValue; // DN
            showactivitydates.PlaceHolder = RemoveHtml(showactivitydates.Caption);
            if (!Empty(showactivitydates.EditValue) && IsNumeric(showactivitydates.EditValue))
                showactivitydates.EditValue = FormatNumber(showactivitydates.EditValue, null);

            // showcompletionconditions
            showcompletionconditions.SetupEditAttributes();
            showcompletionconditions.EditValue = showcompletionconditions.CurrentValue; // DN
            showcompletionconditions.PlaceHolder = RemoveHtml(showcompletionconditions.Caption);
            if (!Empty(showcompletionconditions.EditValue) && IsNumeric(showcompletionconditions.EditValue))
                showcompletionconditions.EditValue = FormatNumber(showcompletionconditions.EditValue, null);

            // pdfexportfont
            pdfexportfont.SetupEditAttributes();
            if (!pdfexportfont.Raw)
                pdfexportfont.CurrentValue = HtmlDecode(pdfexportfont.CurrentValue);
            pdfexportfont.EditValue = HtmlEncode(pdfexportfont.CurrentValue);
            pdfexportfont.PlaceHolder = RemoveHtml(pdfexportfont.Caption);

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
                        doc.ExportCaption(category);
                        doc.ExportCaption(sortorder);
                        doc.ExportCaption(fullname);
                        doc.ExportCaption(shortname);
                        doc.ExportCaption(idnumber);
                        doc.ExportCaption(summary);
                        doc.ExportCaption(summaryformat);
                        doc.ExportCaption(format);
                        doc.ExportCaption(showgrades);
                        doc.ExportCaption(newsitems);
                        doc.ExportCaption(startdate);
                        doc.ExportCaption(enddate);
                        doc.ExportCaption(relativedatesmode);
                        doc.ExportCaption(marker);
                        doc.ExportCaption(maxbytes);
                        doc.ExportCaption(legacyfiles);
                        doc.ExportCaption(showreports);
                        doc.ExportCaption(_visible);
                        doc.ExportCaption(visibleold);
                        doc.ExportCaption(downloadcontent);
                        doc.ExportCaption(groupmode);
                        doc.ExportCaption(groupmodeforce);
                        doc.ExportCaption(defaultgroupingid);
                        doc.ExportCaption(_lang);
                        doc.ExportCaption(calendartype);
                        doc.ExportCaption(theme);
                        doc.ExportCaption(timecreated);
                        doc.ExportCaption(timemodified);
                        doc.ExportCaption(requested);
                        doc.ExportCaption(enablecompletion);
                        doc.ExportCaption(completionnotify);
                        doc.ExportCaption(cacherev);
                        doc.ExportCaption(originalcourseid);
                        doc.ExportCaption(showactivitydates);
                        doc.ExportCaption(showcompletionconditions);
                        doc.ExportCaption(pdfexportfont);
                    } else {
                        doc.ExportCaption(id);
                        doc.ExportCaption(category);
                        doc.ExportCaption(sortorder);
                        doc.ExportCaption(fullname);
                        doc.ExportCaption(shortname);
                        doc.ExportCaption(idnumber);
                        doc.ExportCaption(summary);
                        doc.ExportCaption(summaryformat);
                        doc.ExportCaption(format);
                        doc.ExportCaption(showgrades);
                        doc.ExportCaption(newsitems);
                        doc.ExportCaption(startdate);
                        doc.ExportCaption(enddate);
                        doc.ExportCaption(relativedatesmode);
                        doc.ExportCaption(marker);
                        doc.ExportCaption(maxbytes);
                        doc.ExportCaption(legacyfiles);
                        doc.ExportCaption(showreports);
                        doc.ExportCaption(_visible);
                        doc.ExportCaption(visibleold);
                        doc.ExportCaption(downloadcontent);
                        doc.ExportCaption(groupmode);
                        doc.ExportCaption(groupmodeforce);
                        doc.ExportCaption(defaultgroupingid);
                        doc.ExportCaption(_lang);
                        doc.ExportCaption(calendartype);
                        doc.ExportCaption(theme);
                        doc.ExportCaption(timecreated);
                        doc.ExportCaption(timemodified);
                        doc.ExportCaption(requested);
                        doc.ExportCaption(enablecompletion);
                        doc.ExportCaption(completionnotify);
                        doc.ExportCaption(cacherev);
                        doc.ExportCaption(originalcourseid);
                        doc.ExportCaption(showactivitydates);
                        doc.ExportCaption(showcompletionconditions);
                        doc.ExportCaption(pdfexportfont);
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
                            await doc.ExportField(category);
                            await doc.ExportField(sortorder);
                            await doc.ExportField(fullname);
                            await doc.ExportField(shortname);
                            await doc.ExportField(idnumber);
                            await doc.ExportField(summary);
                            await doc.ExportField(summaryformat);
                            await doc.ExportField(format);
                            await doc.ExportField(showgrades);
                            await doc.ExportField(newsitems);
                            await doc.ExportField(startdate);
                            await doc.ExportField(enddate);
                            await doc.ExportField(relativedatesmode);
                            await doc.ExportField(marker);
                            await doc.ExportField(maxbytes);
                            await doc.ExportField(legacyfiles);
                            await doc.ExportField(showreports);
                            await doc.ExportField(_visible);
                            await doc.ExportField(visibleold);
                            await doc.ExportField(downloadcontent);
                            await doc.ExportField(groupmode);
                            await doc.ExportField(groupmodeforce);
                            await doc.ExportField(defaultgroupingid);
                            await doc.ExportField(_lang);
                            await doc.ExportField(calendartype);
                            await doc.ExportField(theme);
                            await doc.ExportField(timecreated);
                            await doc.ExportField(timemodified);
                            await doc.ExportField(requested);
                            await doc.ExportField(enablecompletion);
                            await doc.ExportField(completionnotify);
                            await doc.ExportField(cacherev);
                            await doc.ExportField(originalcourseid);
                            await doc.ExportField(showactivitydates);
                            await doc.ExportField(showcompletionconditions);
                            await doc.ExportField(pdfexportfont);
                        } else {
                            await doc.ExportField(id);
                            await doc.ExportField(category);
                            await doc.ExportField(sortorder);
                            await doc.ExportField(fullname);
                            await doc.ExportField(shortname);
                            await doc.ExportField(idnumber);
                            await doc.ExportField(summary);
                            await doc.ExportField(summaryformat);
                            await doc.ExportField(format);
                            await doc.ExportField(showgrades);
                            await doc.ExportField(newsitems);
                            await doc.ExportField(startdate);
                            await doc.ExportField(enddate);
                            await doc.ExportField(relativedatesmode);
                            await doc.ExportField(marker);
                            await doc.ExportField(maxbytes);
                            await doc.ExportField(legacyfiles);
                            await doc.ExportField(showreports);
                            await doc.ExportField(_visible);
                            await doc.ExportField(visibleold);
                            await doc.ExportField(downloadcontent);
                            await doc.ExportField(groupmode);
                            await doc.ExportField(groupmodeforce);
                            await doc.ExportField(defaultgroupingid);
                            await doc.ExportField(_lang);
                            await doc.ExportField(calendartype);
                            await doc.ExportField(theme);
                            await doc.ExportField(timecreated);
                            await doc.ExportField(timemodified);
                            await doc.ExportField(requested);
                            await doc.ExportField(enablecompletion);
                            await doc.ExportField(completionnotify);
                            await doc.ExportField(cacherev);
                            await doc.ExportField(originalcourseid);
                            await doc.ExportField(showactivitydates);
                            await doc.ExportField(showcompletionconditions);
                            await doc.ExportField(pdfexportfont);
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
