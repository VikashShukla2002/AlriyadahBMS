namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26
{
    /// <summary>
    /// appointmentCalendar
    /// </summary>
    [MaybeNull]
    public static AppointmentCalendar appointmentCalendar
    {
        get => HttpData.Resolve<AppointmentCalendar>("Appointment_Calendar");
        set => HttpData["Appointment_Calendar"] = value;
    }

    /// <summary>
    /// Table class for Appointment_Calendar
    /// </summary>
    public class AppointmentCalendar : DbTable, IQueryFactory
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

        public readonly ReportField<SqlDbType> Id;

        public readonly ReportField<SqlDbType> int_Enrollement_Id;

        public readonly ReportField<SqlDbType> int_PackageID;

        public readonly ReportField<SqlDbType> _Title;

        public readonly ReportField<SqlDbType> Start;

        public readonly ReportField<SqlDbType> End;

        public readonly ReportField<SqlDbType> AllDay;

        public readonly ReportField<SqlDbType> Description;

        public readonly ReportField<SqlDbType> _Url;

        public readonly ReportField<SqlDbType> Display;

        public readonly ReportField<SqlDbType> BackgroundColor;

        public readonly ReportField<SqlDbType> CRSS_ID;

        public readonly ReportField<SqlDbType> str_AppointmentType;

        public readonly ReportField<SqlDbType> str_AppointmentStatus;

        public readonly ReportField<SqlDbType> str_Username;

        public readonly ReportField<SqlDbType> str_CRSS_IDUSER;

        // Constructor
        public AppointmentCalendar()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "Appointment_Calendar";
            Name = "Appointment_Calendar";
            Type = "REPORT";
            UpdateTable = "Appointment_Cldr"; // Calendar update table
            DbId = "DB"; // DN
            ExportAll = true;
            ExportPageBreakCount = 0; // Page break per every n record (report only)
            ExportPageOrientation = "portrait"; // Page orientation (PDF only)
            ExportPageSize = "a4"; // Page size (PDF only)
            ExportColumnWidths = new float[] { }; // Column widths (PDF only) // DN
            ExportExcelPageOrientation = "Portrait"; // Page orientation (EPPlus only)
            ExportExcelPageSize = "A4"; // Page size (EPPlus only)
            ExportWordPageOrientation = "Portrait"; // Page orientation (Word only)
            UserIdAllowSecurity = Config.DefaultUserIdAllowSecurity; // User ID Allow

            // Id
            Id = new(this, "x_Id", 3, SqlDbType.Int)
            {
                Name = "Id",
                Expression = "[Id]",
                BasicSearchExpression = "CAST([Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Id]",
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("Appointment_Calendar", "Id", "CustomMsg"),
                SourceTableVar = "Appointment_Cldr",
                IsUpload = false
            };
            Fields.Add("Id", Id);

            // int_Enrollement_Id
            int_Enrollement_Id = new(this, "x_int_Enrollement_Id", 3, SqlDbType.Int)
            {
                Name = "int_Enrollement_Id",
                Expression = "[int_Enrollement_Id]",
                BasicSearchExpression = "CAST([int_Enrollement_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Enrollement_Id]",
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
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Appointment_Calendar", "int_Enrollement_Id", "CustomMsg"),
                SourceTableVar = "Appointment_Cldr",
                IsUpload = false
            };
            int_Enrollement_Id.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(int_Enrollement_Id, "tblStudentEnrollment", false, "int_Enrollement_Id", new List<string> { "str_Full_Name", "str_Username", "", "" }, "", "", new List<string> { }, new List<string> { "x_int_PackageID", "x__Title", "x_str_AppointmentType" }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "CONCAT([str_Full_Name],'" + ValueSeparator(1, int_Enrollement_Id) + "',[str_Username])"),
                "en-US" => new Lookup<DbField>(int_Enrollement_Id, "tblStudentEnrollment", false, "int_Enrollement_Id", new List<string> { "str_Full_Name", "str_Username", "", "" }, "", "", new List<string> { }, new List<string> { "x_int_PackageID", "x__Title", "x_str_AppointmentType" }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "CONCAT([str_Full_Name],'" + ValueSeparator(1, int_Enrollement_Id) + "',[str_Username])"),
                _ => new Lookup<DbField>(int_Enrollement_Id, "tblStudentEnrollment", false, "int_Enrollement_Id", new List<string> { "str_Full_Name", "str_Username", "", "" }, "", "", new List<string> { }, new List<string> { "x_int_PackageID", "x__Title", "x_str_AppointmentType" }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "CONCAT([str_Full_Name],'" + ValueSeparator(1, int_Enrollement_Id) + "',[str_Username])")
            };
            Fields.Add("int_Enrollement_Id", int_Enrollement_Id);

            // int_PackageID
            int_PackageID = new(this, "x_int_PackageID", 3, SqlDbType.Int)
            {
                Name = "int_PackageID",
                Expression = "[int_PackageID]",
                BasicSearchExpression = "CAST([int_PackageID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_PackageID]",
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
                CustomMessage = Language.FieldPhrase("Appointment_Calendar", "int_PackageID", "CustomMsg"),
                SourceTableVar = "Appointment_Cldr",
                IsUpload = false
            };
            int_PackageID.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(int_PackageID, "tblStudentEnrollment", false, "int_Package_Id", new List<string> { "int_Package_Id", "str_Package_Name", "", "" }, "", "", new List<string> { "x_int_Enrollement_Id" }, new List<string> { "x__Title", "x_str_AppointmentType" }, new List<string> { "int_Enrollement_Id" }, new List<string> { "x_int_Enrollement_Id" }, new List<string> { }, new List<string> { }, "", "", "CONCAT(CAST([int_Package_Id] AS NVARCHAR),'" + ValueSeparator(1, int_PackageID) + "',[str_Package_Name])"),
                "en-US" => new Lookup<DbField>(int_PackageID, "tblStudentEnrollment", false, "int_Package_Id", new List<string> { "int_Package_Id", "str_Package_Name", "", "" }, "", "", new List<string> { "x_int_Enrollement_Id" }, new List<string> { "x__Title", "x_str_AppointmentType" }, new List<string> { "int_Enrollement_Id" }, new List<string> { "x_int_Enrollement_Id" }, new List<string> { }, new List<string> { }, "", "", "CONCAT(CAST([int_Package_Id] AS NVARCHAR),'" + ValueSeparator(1, int_PackageID) + "',[str_Package_Name])"),
                _ => new Lookup<DbField>(int_PackageID, "tblStudentEnrollment", false, "int_Package_Id", new List<string> { "int_Package_Id", "str_Package_Name", "", "" }, "", "", new List<string> { "x_int_Enrollement_Id" }, new List<string> { "x__Title", "x_str_AppointmentType" }, new List<string> { "int_Enrollement_Id" }, new List<string> { "x_int_Enrollement_Id" }, new List<string> { }, new List<string> { }, "", "", "CONCAT(CAST([int_Package_Id] AS NVARCHAR),'" + ValueSeparator(1, int_PackageID) + "',[str_Package_Name])")
            };
            Fields.Add("int_PackageID", int_PackageID);

            // Title
            _Title = new(this, "x__Title", 202, SqlDbType.NVarChar)
            {
                Name = "Title",
                Expression = "[Title]",
                BasicSearchExpression = "[Title]",
                DateTimeFormat = -1,
                VirtualExpression = "[Title]",
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
                SearchOperators = new() { "=", "<>" },
                CustomMessage = Language.FieldPhrase("Appointment_Calendar", "_Title", "CustomMsg"),
                SourceTableVar = "Appointment_Cldr",
                IsUpload = false
            };
            _Title.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(_Title, "qryStudentJourneyTitle", false, "Title", new List<string> { "Title", "", "", "" }, "", "", new List<string> { "x_int_Enrollement_Id", "x_int_PackageID" }, new List<string> { "x_str_AppointmentType" }, new List<string> { "int_Enrollement_Id", "int_Package_Id" }, new List<string> { "x_int_Enrollement_Id", "x_int_Package_Id" }, new List<string> { }, new List<string> { }, "", "", "[Title]"),
                "en-US" => new Lookup<DbField>(_Title, "qryStudentJourneyTitle", false, "Title", new List<string> { "Title", "", "", "" }, "", "", new List<string> { "x_int_Enrollement_Id", "x_int_PackageID" }, new List<string> { "x_str_AppointmentType" }, new List<string> { "int_Enrollement_Id", "int_Package_Id" }, new List<string> { "x_int_Enrollement_Id", "x_int_Package_Id" }, new List<string> { }, new List<string> { }, "", "", "[Title]"),
                _ => new Lookup<DbField>(_Title, "qryStudentJourneyTitle", false, "Title", new List<string> { "Title", "", "", "" }, "", "", new List<string> { "x_int_Enrollement_Id", "x_int_PackageID" }, new List<string> { "x_str_AppointmentType" }, new List<string> { "int_Enrollement_Id", "int_Package_Id" }, new List<string> { "x_int_Enrollement_Id", "x_int_Package_Id" }, new List<string> { }, new List<string> { }, "", "", "[Title]")
            };
            Fields.Add("Title", _Title);

            // Start
            Start = new(this, "x_Start", 135, SqlDbType.DateTime)
            {
                Name = "Start",
                Expression = "[Start]",
                BasicSearchExpression = CastDateFieldForLike("[Start]", 0, "DB"),
                DateTimeFormat = 1,
                VirtualExpression = "[Start]",
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("Appointment_Calendar", "Start", "CustomMsg"),
                SourceTableVar = "Appointment_Cldr",
                IsUpload = false
            };
            Fields.Add("Start", Start);

            // End
            End = new(this, "x_End", 135, SqlDbType.DateTime)
            {
                Name = "End",
                Expression = "[End]",
                BasicSearchExpression = CastDateFieldForLike("[End]", 0, "DB"),
                DateTimeFormat = 1,
                VirtualExpression = "[End]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Appointment_Calendar", "End", "CustomMsg"),
                SourceTableVar = "Appointment_Cldr",
                IsUpload = false
            };
            Fields.Add("End", End);

            // AllDay
            AllDay = new(this, "x_AllDay", 11, SqlDbType.Bit)
            {
                Name = "AllDay",
                Expression = "[AllDay]",
                BasicSearchExpression = "[AllDay]",
                DateTimeFormat = -1,
                VirtualExpression = "[AllDay]",
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
                SearchOperators = new() { "=", "<>" },
                CustomMessage = Language.FieldPhrase("Appointment_Calendar", "AllDay", "CustomMsg"),
                SourceTableVar = "Appointment_Cldr",
                IsUpload = false
            };
            AllDay.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(AllDay, "Appointment_Calendar", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(AllDay, "Appointment_Calendar", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(AllDay, "Appointment_Calendar", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            AllDay.GetDefault = () => 0;
            Fields.Add("AllDay", AllDay);

            // Description
            Description = new(this, "x_Description", 203, SqlDbType.NText)
            {
                Name = "Description",
                Expression = "[Description]",
                BasicSearchExpression = "[Description]",
                DateTimeFormat = -1,
                VirtualExpression = "[Description]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Appointment_Calendar", "Description", "CustomMsg"),
                SourceTableVar = "Appointment_Cldr",
                IsUpload = false
            };
            Fields.Add("Description", Description);

            // Url
            _Url = new(this, "x__Url", 202, SqlDbType.NVarChar)
            {
                Name = "Url",
                Expression = "[Url]",
                BasicSearchExpression = "[Url]",
                DateTimeFormat = -1,
                VirtualExpression = "[Url]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Appointment_Calendar", "_Url", "CustomMsg"),
                SourceTableVar = "Appointment_Cldr",
                IsUpload = false
            };
            Fields.Add("Url", _Url);

            // Display
            Display = new(this, "x_Display", 202, SqlDbType.NVarChar)
            {
                Name = "Display",
                Expression = "[Display]",
                BasicSearchExpression = "[Display]",
                DateTimeFormat = -1,
                VirtualExpression = "[Display]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Appointment_Calendar", "Display", "CustomMsg"),
                SourceTableVar = "Appointment_Cldr",
                IsUpload = false
            };
            Fields.Add("Display", Display);

            // BackgroundColor
            BackgroundColor = new(this, "x_BackgroundColor", 202, SqlDbType.NVarChar)
            {
                Name = "BackgroundColor",
                Expression = "[BackgroundColor]",
                BasicSearchExpression = "[BackgroundColor]",
                DateTimeFormat = -1,
                VirtualExpression = "[BackgroundColor]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Appointment_Calendar", "BackgroundColor", "CustomMsg"),
                SourceTableVar = "Appointment_Cldr",
                IsUpload = false
            };
            Fields.Add("BackgroundColor", BackgroundColor);

            // CRSS_ID
            CRSS_ID = new(this, "x_CRSS_ID", 202, SqlDbType.NVarChar)
            {
                Name = "CRSS_ID",
                Expression = "[CRSS_ID]",
                UseBasicSearch = true,
                BasicSearchExpression = "[CRSS_ID]",
                DateTimeFormat = -1,
                VirtualExpression = "[CRSS_ID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Appointment_Calendar", "CRSS_ID", "CustomMsg"),
                SourceTableVar = "Appointment_Cldr",
                IsUpload = false
            };
            Fields.Add("CRSS_ID", CRSS_ID);

            // str_AppointmentType
            str_AppointmentType = new(this, "x_str_AppointmentType", 202, SqlDbType.NVarChar)
            {
                Name = "str_AppointmentType",
                Expression = "[str_AppointmentType]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_AppointmentType]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_AppointmentType]",
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
                CustomMessage = Language.FieldPhrase("Appointment_Calendar", "str_AppointmentType", "CustomMsg"),
                SourceTableVar = "Appointment_Cldr",
                IsUpload = false
            };
            str_AppointmentType.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(str_AppointmentType, "qryStudentJourneyTitle", false, "Journey", new List<string> { "Journey", "", "", "" }, "", "", new List<string> { "x_int_Enrollement_Id", "x_int_PackageID", "x__Title" }, new List<string> { }, new List<string> { "int_Enrollement_Id", "int_Package_Id", "Title" }, new List<string> { "x_int_Enrollement_Id", "x_int_Package_Id", "x__Title" }, new List<string> { }, new List<string> { }, "", "", "[Journey]"),
                "en-US" => new Lookup<DbField>(str_AppointmentType, "qryStudentJourneyTitle", false, "Journey", new List<string> { "Journey", "", "", "" }, "", "", new List<string> { "x_int_Enrollement_Id", "x_int_PackageID", "x__Title" }, new List<string> { }, new List<string> { "int_Enrollement_Id", "int_Package_Id", "Title" }, new List<string> { "x_int_Enrollement_Id", "x_int_Package_Id", "x__Title" }, new List<string> { }, new List<string> { }, "", "", "[Journey]"),
                _ => new Lookup<DbField>(str_AppointmentType, "qryStudentJourneyTitle", false, "Journey", new List<string> { "Journey", "", "", "" }, "", "", new List<string> { "x_int_Enrollement_Id", "x_int_PackageID", "x__Title" }, new List<string> { }, new List<string> { "int_Enrollement_Id", "int_Package_Id", "Title" }, new List<string> { "x_int_Enrollement_Id", "x_int_Package_Id", "x__Title" }, new List<string> { }, new List<string> { }, "", "", "[Journey]")
            };
            Fields.Add("str_AppointmentType", str_AppointmentType);

            // str_AppointmentStatus
            str_AppointmentStatus = new(this, "x_str_AppointmentStatus", 202, SqlDbType.NVarChar)
            {
                Name = "str_AppointmentStatus",
                Expression = "[str_AppointmentStatus]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_AppointmentStatus]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_AppointmentStatus]",
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
                OptionCount = 8,
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Appointment_Calendar", "str_AppointmentStatus", "CustomMsg"),
                SourceTableVar = "Appointment_Cldr",
                IsUpload = false
            };
            str_AppointmentStatus.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(str_AppointmentStatus, "Appointment_Calendar", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(str_AppointmentStatus, "Appointment_Calendar", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(str_AppointmentStatus, "Appointment_Calendar", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("str_AppointmentStatus", str_AppointmentStatus);

            // str_Username
            str_Username = new(this, "x_str_Username", 202, SqlDbType.NVarChar)
            {
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
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Appointment_Calendar", "str_Username", "CustomMsg"),
                SourceTableVar = "Appointment_Cldr",
                IsUpload = false
            };
            str_Username.GetAutoUpdateValue = () => CurrentUserName();
            Fields.Add("str_Username", str_Username);

            // str_CRSS_IDUSER
            str_CRSS_IDUSER = new(this, "x_str_CRSS_IDUSER", 202, SqlDbType.NVarChar)
            {
                Name = "str_CRSS_IDUSER",
                Expression = "[str_CRSS_IDUSER]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_CRSS_IDUSER]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CRSS_IDUSER]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Appointment_Calendar", "str_CRSS_IDUSER", "CustomMsg"),
                SourceTableVar = "Appointment_Cldr",
                IsUpload = false
            };
            Fields.Add("str_CRSS_IDUSER", str_CRSS_IDUSER);

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
            get => _sqlFrom ?? "dbo.Appointment_Cldr";
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
                Id.SetDbValue(lastInsertedId);
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
            Dictionary<string, object> rscascade = new();
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
            try
            {
                Id.DbValue = row["Id"]; // Set DB value only
                int_Enrollement_Id.DbValue = row["int_Enrollement_Id"]; // Set DB value only
                int_PackageID.DbValue = row["int_PackageID"]; // Set DB value only
                _Title.DbValue = row["Title"]; // Set DB value only
                Start.DbValue = row["Start"]; // Set DB value only
                End.DbValue = row["End"]; // Set DB value only
                AllDay.DbValue = (ConvertToBool(row["AllDay"]) ? "1" : "0"); // Set DB value only
                Description.DbValue = row["Description"]; // Set DB value only
                _Url.DbValue = row["Url"]; // Set DB value only
                Display.DbValue = row["Display"]; // Set DB value only
                BackgroundColor.DbValue = row["BackgroundColor"]; // Set DB value only
                CRSS_ID.DbValue = row["CRSS_ID"]; // Set DB value only
                str_AppointmentType.DbValue = row["str_AppointmentType"]; // Set DB value only
                str_AppointmentStatus.DbValue = row["str_AppointmentStatus"]; // Set DB value only
                str_Username.DbValue = row["str_Username"]; // Set DB value only
                str_CRSS_IDUSER.DbValue = row["str_CRSS_IDUSER"]; // Set DB value only
            }
            catch { }
        }

        public void DeleteUploadedFiles(Dictionary<string, object> row)
        {
            LoadDbValues(row);
        }

        // Record filter WHERE clause
        private string _sqlKeyFilter => "[Id] = @Id@";

#pragma warning disable 168, 219
        // Get record filter as string
        public string GetRecordFilter(Dictionary<string, object>? row = null, bool current = false)
        {
            string keyFilter = _sqlKeyFilter;
            object? val = null, result = "";
            val = row?.TryGetValue("Id", out result) ?? false
                ? result
                : !Empty(Id.OldValue) && !current ? Id.OldValue : Id.CurrentValue;
            if (!IsNumeric(val))
                return "0=1"; // Invalid key
            if (val == null)
                return "0=1"; // Invalid key
            keyFilter = keyFilter.Replace("@Id@", AdjustSql(val, DbId)); // Replace key value
            return keyFilter;
        }

        // Get record filter as Dictionary // DN
        public Dictionary<string, object>? GetRowFilterAsDictionary(IDictionary<string, object>? row = null)
        {
            Dictionary<string, object>? keyFilter = new();
            object? val = null, result;
            val = row?.TryGetValue("Id", out result) ?? false
                ? result
                : !Empty(Id.OldValue) ? Id.OldValue : Id.CurrentValue;
            if (!IsNumeric(val))
                return null; // Invalid key
            if (Empty(val))
                return null; // Invalid key
            keyFilter.Add("Id", val); // Add key value
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
                    return "";
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
            get
            {
                return "AppointmentCalendar";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return "AppointmentCalendar";
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
            return url;
        }

        // Get primary key as JSON
        public string KeyToJson(bool htmlEncode = false)
        {
            string json = "";
            json += "\"Id\":" + ConvertToJson(Id.CurrentValue, "number", true);
            json = "{" + json + "}";
            if (htmlEncode)
                json = HtmlEncode(json);
            return json;
        }

        // Add key value to URL
        public string KeyUrl(string url, string parm = "")
        { // DN
            if (!IsNull(Id.CurrentValue))
            {
                url += "/" + Id.CurrentValue;
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
            val = current ? ConvertToString(Id.CurrentValue) ?? "" : ConvertToString(Id.OldValue) ?? "";
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
            val = row?.TryGetValue("Id", out result) ?? false ? ConvertToString(result) : null;
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
                    Id.CurrentValue = keys[0];
                }
                else
                {
                    Id.OldValue = keys[0];
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
                if (RouteValues.TryGetValue("Id", out object? v0))
                { // Id // DN
                    key = UrlDecode(v0); // DN
                }
                else if (IsApi() && !Empty(keyValues))
                {
                    key = keyValues[0];
                }
                else
                {
                    key = Param("Id");
                }
                keysList.Add(key);
            }
            // Check keys
            foreach (var keys in keysList)
            {
                if (!IsNumeric(keys)) // Id
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
                    Id.CurrentValue = keys;
                else
                    Id.OldValue = keys;
                keyFilter += "(" + GetRecordFilter() + ")";
            }
            return keyFilter;
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
            string sql = "SELECT " + masterfld.Expression + " FROM dbo.Appointment_Cldr";
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
        public async void RowInserted(Dictionary<string, object>? rsold, Dictionary<string, object> rsnew)
        {
            Log("SMSStudentAppointmentForBTWMessage");

            var title = rsnew.GetValueOrDefault("Title")?.ToString();
            //var str_AppointmentType = rsnew.GetValueOrDefault("str_AppointmentType")?.ToString();
            var str_AppointmentStatus = Convert.ToInt32(rsnew.GetValueOrDefault("str_AppointmentStatus"));
            var int_Enrollement_Id = Convert.ToInt32(rsnew.GetValueOrDefault("int_Enrollement_Id"));
            //var int_PackageID = Convert.ToInt32(rsnew.GetValueOrDefault("int_PackageID"));

            var rowEnrollment = ExecuteRow($"SELECT * FROM tblStudentEnrollment WHERE int_Enrollement_Id = '{int_Enrollement_Id}'");
            //var rowPackageInfo = ExecuteRow($"SELECT * FROM tblPackageInfo WHERE int_Package_Id = '{int_PackageID}'");
            var int_Student_Id = Convert.ToInt32(rowEnrollment.GetValueOrDefault("int_Student_Id"));
            var rowStudent = ExecuteRow($"SELECT * FROM tblStudents WHERE int_Student_ID = '{int_Student_Id}'");

            if (AppointmentStatus.Confirmed == (AppointmentStatus)str_AppointmentStatus)
            {
                string? fullName = rowStudent.GetValueOrDefault("str_Full_Name")?.ToString();
                string? date = rowEnrollment.GetValueOrDefault("Start")?.ToString();
                string? phoneNo = rowStudent.GetValueOrDefault("str_Cell_Phone")?.ToString();

                if (title?.Contains("Road Test", StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    var smsMessage = SmsMessageFor.StudentRoadTestConfirm(fullName, date);

                    await JawalbSms.SendSmsAsync(smsMessage, phoneNo!);
                }
                else if (title?.Contains("Behind The Wheel", StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    var smsMessage = SmsMessageFor.StudentAppointmentForBTWMessage(fullName, date);
                    await JawalbSms.SendSmsAsync(smsMessage, phoneNo!);
                }
                else if (title?.Contains("Knowledge Test", StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    var smsMessage = SmsMessageFor.StudentAppointmentForKTMessage(fullName, date);
                    await JawalbSms.SendSmsAsync(smsMessage, phoneNo!);
                }
            }
        }

        // Row Updating event
        public bool RowUpdating(Dictionary<string, object> rsold, Dictionary<string, object> rsnew)
        {
            // Enter your code here
            // To cancel, set return value to False and error message to CancelMessage
            return true;
        }

        // Row Updated event
        public void RowUpdated(Dictionary<string, object> rsold, Dictionary<string, object> rsnew)
        {
            //Log("Row Updated");
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
