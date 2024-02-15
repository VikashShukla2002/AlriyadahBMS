namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26
{
    /// <summary>
    /// appointmentCldr
    /// </summary>
    [MaybeNull]
    public static AppointmentCldr appointmentCldr
    {
        get => HttpData.Resolve<AppointmentCldr>("Appointment_Cldr");
        set => HttpData["Appointment_Cldr"] = value;
    }

    /// <summary>
    /// Table class for Appointment_Cldr
    /// </summary>
    public class AppointmentCldr : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> Id;

        public readonly DbField<SqlDbType> int_Enrollement_Id;

        public readonly DbField<SqlDbType> int_PackageID;

        public readonly DbField<SqlDbType> _Title;

        public readonly DbField<SqlDbType> Start;

        public readonly DbField<SqlDbType> End;

        public readonly DbField<SqlDbType> AllDay;

        public readonly DbField<SqlDbType> Description;

        public readonly DbField<SqlDbType> _Url;

        public readonly DbField<SqlDbType> Display;

        public readonly DbField<SqlDbType> BackgroundColor;

        public readonly DbField<SqlDbType> CRSS_ID;

        public readonly DbField<SqlDbType> str_AppointmentType;

        public readonly DbField<SqlDbType> str_AppointmentStatus;

        public readonly DbField<SqlDbType> str_Username;

        public readonly DbField<SqlDbType> str_CRSS_IDUSER;

        // Constructor
        public AppointmentCldr()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "Appointment_Cldr";
            Name = "Appointment_Cldr";
            Type = "TABLE";
            UpdateTable = "dbo.Appointment_Cldr"; // Update Table
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
                CustomMessage = Language.FieldPhrase("Appointment_Cldr", "Id", "CustomMsg"),
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
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Appointment_Cldr", "int_Enrollement_Id", "CustomMsg"),
                IsUpload = false
            };
            int_Enrollement_Id.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(int_Enrollement_Id, "tblStudentEnrollment", false, "int_Enrollement_Id", new List<string> { "str_Full_Name", "str_Username", "str_Package_Name", "" }, "", "", new List<string> { }, new List<string> { "x_int_PackageID" }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "CONCAT([str_Full_Name],'" + ValueSeparator(1, int_Enrollement_Id) + "',[str_Username],'" + ValueSeparator(2, int_Enrollement_Id) + "',[str_Package_Name])"),
                "en-US" => new Lookup<DbField>(int_Enrollement_Id, "tblStudentEnrollment", false, "int_Enrollement_Id", new List<string> { "str_Full_Name", "str_Username", "str_Package_Name", "" }, "", "", new List<string> { }, new List<string> { "x_int_PackageID" }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "CONCAT([str_Full_Name],'" + ValueSeparator(1, int_Enrollement_Id) + "',[str_Username],'" + ValueSeparator(2, int_Enrollement_Id) + "',[str_Package_Name])"),
                _ => new Lookup<DbField>(int_Enrollement_Id, "tblStudentEnrollment", false, "int_Enrollement_Id", new List<string> { "str_Full_Name", "str_Username", "str_Package_Name", "" }, "", "", new List<string> { }, new List<string> { "x_int_PackageID" }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "CONCAT([str_Full_Name],'" + ValueSeparator(1, int_Enrollement_Id) + "',[str_Username],'" + ValueSeparator(2, int_Enrollement_Id) + "',[str_Package_Name])")
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
                Required = true, // Required field
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Appointment_Cldr", "int_PackageID", "CustomMsg"),
                IsUpload = false
            };
            int_PackageID.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(int_PackageID, "tblStudentEnrollment", false, "int_Package_Id", new List<string> { "int_Package_Id", "str_Package_Name", "", "" }, "", "", new List<string> { "x_int_Enrollement_Id" }, new List<string> { "x_str_AppointmentType" }, new List<string> { "int_Enrollement_Id" }, new List<string> { "x_int_Enrollement_Id" }, new List<string> { }, new List<string> { }, "", "", "CONCAT(CAST([int_Package_Id] AS NVARCHAR),'" + ValueSeparator(1, int_PackageID) + "',[str_Package_Name])"),
                "en-US" => new Lookup<DbField>(int_PackageID, "tblStudentEnrollment", false, "int_Package_Id", new List<string> { "int_Package_Id", "str_Package_Name", "", "" }, "", "", new List<string> { "x_int_Enrollement_Id" }, new List<string> { "x_str_AppointmentType" }, new List<string> { "int_Enrollement_Id" }, new List<string> { "x_int_Enrollement_Id" }, new List<string> { }, new List<string> { }, "", "", "CONCAT(CAST([int_Package_Id] AS NVARCHAR),'" + ValueSeparator(1, int_PackageID) + "',[str_Package_Name])"),
                _ => new Lookup<DbField>(int_PackageID, "tblStudentEnrollment", false, "int_Package_Id", new List<string> { "int_Package_Id", "str_Package_Name", "", "" }, "", "", new List<string> { "x_int_Enrollement_Id" }, new List<string> { "x_str_AppointmentType" }, new List<string> { "int_Enrollement_Id" }, new List<string> { "x_int_Enrollement_Id" }, new List<string> { }, new List<string> { }, "", "", "CONCAT(CAST([int_Package_Id] AS NVARCHAR),'" + ValueSeparator(1, int_PackageID) + "',[str_Package_Name])")
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
                HtmlTag = "TEXT",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY" },
                CustomMessage = Language.FieldPhrase("Appointment_Cldr", "_Title", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Title", _Title);

            // Start
            Start = new(this, "x_Start", 135, SqlDbType.DateTime)
            {
                Name = "Start",
                Expression = "[Start]",
                BasicSearchExpression = CastDateFieldForLike("[Start]", 0, "DB"),
                DateTimeFormat = 0,
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
                CustomMessage = Language.FieldPhrase("Appointment_Cldr", "Start", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Start", Start);

            // End
            End = new(this, "x_End", 135, SqlDbType.DateTime)
            {
                Name = "End",
                Expression = "[End]",
                BasicSearchExpression = CastDateFieldForLike("[End]", 0, "DB"),
                DateTimeFormat = 0,
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
                CustomMessage = Language.FieldPhrase("Appointment_Cldr", "End", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("Appointment_Cldr", "AllDay", "CustomMsg"),
                IsUpload = false
            };
            AllDay.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(AllDay, "Appointment_Cldr", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(AllDay, "Appointment_Cldr", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(AllDay, "Appointment_Cldr", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
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
                CustomMessage = Language.FieldPhrase("Appointment_Cldr", "Description", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("Appointment_Cldr", "_Url", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("Appointment_Cldr", "Display", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("Appointment_Cldr", "BackgroundColor", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("BackgroundColor", BackgroundColor);

            // CRSS_ID
            CRSS_ID = new(this, "x_CRSS_ID", 202, SqlDbType.NVarChar)
            {
                Name = "CRSS_ID",
                Expression = "[CRSS_ID]",
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
                CustomMessage = Language.FieldPhrase("Appointment_Cldr", "CRSS_ID", "CustomMsg"),
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
                Required = true, // Required field
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Appointment_Cldr", "str_AppointmentType", "CustomMsg"),
                IsUpload = false
            };
            str_AppointmentType.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(str_AppointmentType, "qryAppointmentType", false, "Service_Description", new List<string> { "int_AppType", "Service_Description", "", "" }, "", "", new List<string> { "x_int_PackageID" }, new List<string> { }, new List<string> { "int_PackageID" }, new List<string> { "x_int_PackageID" }, new List<string> { }, new List<string> { }, "", "", "CONCAT(CAST([int_AppType] AS NVARCHAR),'" + ValueSeparator(1, str_AppointmentType) + "',[Service_Description])"),
                "en-US" => new Lookup<DbField>(str_AppointmentType, "qryAppointmentType", false, "Service_Description", new List<string> { "int_AppType", "Service_Description", "", "" }, "", "", new List<string> { "x_int_PackageID" }, new List<string> { }, new List<string> { "int_PackageID" }, new List<string> { "x_int_PackageID" }, new List<string> { }, new List<string> { }, "", "", "CONCAT(CAST([int_AppType] AS NVARCHAR),'" + ValueSeparator(1, str_AppointmentType) + "',[Service_Description])"),
                _ => new Lookup<DbField>(str_AppointmentType, "qryAppointmentType", false, "Service_Description", new List<string> { "int_AppType", "Service_Description", "", "" }, "", "", new List<string> { "x_int_PackageID" }, new List<string> { }, new List<string> { "int_PackageID" }, new List<string> { "x_int_PackageID" }, new List<string> { }, new List<string> { }, "", "", "CONCAT(CAST([int_AppType] AS NVARCHAR),'" + ValueSeparator(1, str_AppointmentType) + "',[Service_Description])")
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
                CustomMessage = Language.FieldPhrase("Appointment_Cldr", "str_AppointmentStatus", "CustomMsg"),
                IsUpload = false
            };
            str_AppointmentStatus.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(str_AppointmentStatus, "Appointment_Cldr", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(str_AppointmentStatus, "Appointment_Cldr", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(str_AppointmentStatus, "Appointment_Cldr", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("str_AppointmentStatus", str_AppointmentStatus);

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
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                SearchOperators = new() { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Appointment_Cldr", "str_Username", "CustomMsg"),
                IsUpload = false
            };
            str_Username.GetAutoUpdateValue = () => CurrentUserName();
            Fields.Add("str_Username", str_Username);

            // str_CRSS_IDUSER
            str_CRSS_IDUSER = new(this, "x_str_CRSS_IDUSER", 202, SqlDbType.NVarChar)
            {
                Name = "str_CRSS_IDUSER",
                Expression = "[str_CRSS_IDUSER]",
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
                CustomMessage = Language.FieldPhrase("Appointment_Cldr", "str_CRSS_IDUSER", "CustomMsg"),
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
            if (result > 0 && AuditTrailOnEdit && rsold != null)
            {
                var rsaudit = new Dictionary<string, object>(row);
                if (!rsaudit.ContainsKey("Id"))
                    rsaudit.Add("Id", rsold["Id"]);
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
                    return "AppointmentCldrList";
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
            if (SameString(pageName, "AppointmentCldrView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "AppointmentCldrEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "AppointmentCldrAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get
            {
                return "AppointmentCldrList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch
            {
                Config.ApiViewAction => "AppointmentCldrView",
                Config.ApiAddAction => "AppointmentCldrAdd",
                Config.ApiEditAction => "AppointmentCldrEdit",
                Config.ApiDeleteAction => "AppointmentCldrDelete",
                Config.ApiListAction => "AppointmentCldrList",
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
        public string ListUrl => "AppointmentCldrList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("AppointmentCldrView", parm);
            else
                url = KeyUrl("AppointmentCldrView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "AppointmentCldrAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "AppointmentCldrAdd?" + parm;
            else
                url = "AppointmentCldrAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("AppointmentCldrEdit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("AppointmentCldrList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("AppointmentCldrAdd", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("AppointmentCldrList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("AppointmentCldrDelete")); // DN

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
            Id.SetDbValue(dr["Id"]);
            int_Enrollement_Id.SetDbValue(dr["int_Enrollement_Id"]);
            int_PackageID.SetDbValue(dr["int_PackageID"]);
            _Title.SetDbValue(dr["Title"]);
            Start.SetDbValue(dr["Start"]);
            End.SetDbValue(dr["End"]);
            AllDay.SetDbValue(ConvertToBool(dr["AllDay"]) ? "1" : "0");
            Description.SetDbValue(dr["Description"]);
            _Url.SetDbValue(dr["Url"]);
            Display.SetDbValue(dr["Display"]);
            BackgroundColor.SetDbValue(dr["BackgroundColor"]);
            CRSS_ID.SetDbValue(dr["CRSS_ID"]);
            str_AppointmentType.SetDbValue(dr["str_AppointmentType"]);
            str_AppointmentStatus.SetDbValue(dr["str_AppointmentStatus"]);
            str_Username.SetDbValue(dr["str_Username"]);
            str_CRSS_IDUSER.SetDbValue(dr["str_CRSS_IDUSER"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "AppointmentCldrList";
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

            // Id

            // int_Enrollement_Id

            // int_PackageID

            // Title

            // Start

            // End

            // AllDay

            // Description

            // Url

            // Display

            // BackgroundColor

            // CRSS_ID

            // str_AppointmentType

            // str_AppointmentStatus

            // str_Username

            // str_CRSS_IDUSER
            str_CRSS_IDUSER.CellCssStyle = "white-space: nowrap;";

            // Id
            Id.ViewValue = Id.CurrentValue;
            Id.ViewCustomAttributes = "";

            // int_Enrollement_Id
            curVal = ConvertToString(int_Enrollement_Id.CurrentValue);
            if (!Empty(curVal))
            {
                if (int_Enrollement_Id.Lookup != null && IsDictionary(int_Enrollement_Id.Lookup?.Options) && int_Enrollement_Id.Lookup?.Options.Values.Count > 0)
                { // Load from cache // DN
                    int_Enrollement_Id.ViewValue = int_Enrollement_Id.LookupCacheOption(curVal);
                }
                else
                { // Lookup from database // DN
                    filterWrk = SearchFilter("[int_Enrollement_Id]", "=", int_Enrollement_Id.CurrentValue, DataType.Number, "");
                    sqlWrk = int_Enrollement_Id.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && int_Enrollement_Id.Lookup != null)
                    { // Lookup values found
                        var listwrk = int_Enrollement_Id.Lookup?.RenderViewRow(rswrk[0]);
                        int_Enrollement_Id.ViewValue = int_Enrollement_Id.HighlightLookup(ConvertToString(rswrk[0]), int_Enrollement_Id.DisplayValue(listwrk));
                    }
                    else
                    {
                        int_Enrollement_Id.ViewValue = FormatNumber(int_Enrollement_Id.CurrentValue, int_Enrollement_Id.FormatPattern);
                    }
                }
            }
            else
            {
                int_Enrollement_Id.ViewValue = DbNullValue;
            }
            int_Enrollement_Id.ViewCustomAttributes = "";

            // int_PackageID
            curVal = ConvertToString(int_PackageID.CurrentValue);
            if (!Empty(curVal))
            {
                if (int_PackageID.Lookup != null && IsDictionary(int_PackageID.Lookup?.Options) && int_PackageID.Lookup?.Options.Values.Count > 0)
                { // Load from cache // DN
                    int_PackageID.ViewValue = int_PackageID.LookupCacheOption(curVal);
                }
                else
                { // Lookup from database // DN
                    filterWrk = SearchFilter("[int_Package_Id]", "=", int_PackageID.CurrentValue, DataType.Number, "");
                    sqlWrk = int_PackageID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && int_PackageID.Lookup != null)
                    { // Lookup values found
                        var listwrk = int_PackageID.Lookup?.RenderViewRow(rswrk[0]);
                        int_PackageID.ViewValue = int_PackageID.HighlightLookup(ConvertToString(rswrk[0]), int_PackageID.DisplayValue(listwrk));
                    }
                    else
                    {
                        int_PackageID.ViewValue = FormatNumber(int_PackageID.CurrentValue, int_PackageID.FormatPattern);
                    }
                }
            }
            else
            {
                int_PackageID.ViewValue = DbNullValue;
            }
            int_PackageID.ViewCustomAttributes = "";

            // Title
            _Title.ViewValue = ConvertToString(_Title.CurrentValue); // DN
            _Title.ViewCustomAttributes = "";

            // Start
            Start.ViewValue = Start.CurrentValue;
            Start.ViewValue = FormatDateTime(Start.ViewValue, Start.FormatPattern);
            Start.ViewCustomAttributes = "";

            // End
            End.ViewValue = End.CurrentValue;
            End.ViewValue = FormatDateTime(End.ViewValue, End.FormatPattern);
            End.ViewCustomAttributes = "";

            // AllDay
            if (ConvertToBool(AllDay.CurrentValue))
            {
                AllDay.ViewValue = AllDay.TagCaption(1) != "" ? AllDay.TagCaption(1) : "Yes";
            }
            else
            {
                AllDay.ViewValue = AllDay.TagCaption(2) != "" ? AllDay.TagCaption(2) : "No";
            }
            AllDay.ViewCustomAttributes = "";

            // Description
            Description.ViewValue = Description.CurrentValue;
            Description.ViewCustomAttributes = "";

            // Url
            _Url.ViewValue = ConvertToString(_Url.CurrentValue); // DN
            _Url.ViewCustomAttributes = "";

            // Display
            Display.ViewValue = ConvertToString(Display.CurrentValue); // DN
            Display.ViewCustomAttributes = "";

            // BackgroundColor
            BackgroundColor.ViewValue = ConvertToString(BackgroundColor.CurrentValue); // DN
            BackgroundColor.ViewCustomAttributes = "";

            // CRSS_ID
            CRSS_ID.ViewValue = ConvertToString(CRSS_ID.CurrentValue); // DN
            CRSS_ID.ViewCustomAttributes = "";

            // str_AppointmentType
            curVal = ConvertToString(str_AppointmentType.CurrentValue);
            if (!Empty(curVal))
            {
                if (str_AppointmentType.Lookup != null && IsDictionary(str_AppointmentType.Lookup?.Options) && str_AppointmentType.Lookup?.Options.Values.Count > 0)
                { // Load from cache // DN
                    str_AppointmentType.ViewValue = str_AppointmentType.LookupCacheOption(curVal);
                }
                else
                { // Lookup from database // DN
                    filterWrk = SearchFilter("[Service_Description]", "=", str_AppointmentType.CurrentValue, DataType.String, "");
                    sqlWrk = str_AppointmentType.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && str_AppointmentType.Lookup != null)
                    { // Lookup values found
                        var listwrk = str_AppointmentType.Lookup?.RenderViewRow(rswrk[0]);
                        str_AppointmentType.ViewValue = str_AppointmentType.HighlightLookup(ConvertToString(rswrk[0]), str_AppointmentType.DisplayValue(listwrk));
                    }
                    else
                    {
                        str_AppointmentType.ViewValue = str_AppointmentType.CurrentValue;
                    }
                }
            }
            else
            {
                str_AppointmentType.ViewValue = DbNullValue;
            }
            str_AppointmentType.ViewCustomAttributes = "";

            // str_AppointmentStatus
            if (!Empty(str_AppointmentStatus.CurrentValue))
            {
                str_AppointmentStatus.ViewValue = str_AppointmentStatus.HighlightLookup(ConvertToString(str_AppointmentStatus.CurrentValue), str_AppointmentStatus.OptionCaption(ConvertToString(str_AppointmentStatus.CurrentValue)));
            }
            else
            {
                str_AppointmentStatus.ViewValue = DbNullValue;
            }
            str_AppointmentStatus.ViewCustomAttributes = "";

            // str_Username
            str_Username.ViewValue = str_Username.CurrentValue;
            str_Username.ViewCustomAttributes = "";

            // str_CRSS_IDUSER
            str_CRSS_IDUSER.ViewValue = ConvertToString(str_CRSS_IDUSER.CurrentValue); // DN
            str_CRSS_IDUSER.ViewCustomAttributes = "";

            // Id
            Id.HrefValue = "";
            Id.TooltipValue = "";

            // int_Enrollement_Id
            int_Enrollement_Id.HrefValue = "";
            int_Enrollement_Id.TooltipValue = "";

            // int_PackageID
            int_PackageID.HrefValue = "";
            int_PackageID.TooltipValue = "";

            // Title
            _Title.HrefValue = "";
            _Title.TooltipValue = "";

            // Start
            Start.HrefValue = "";
            Start.TooltipValue = "";

            // End
            End.HrefValue = "";
            End.TooltipValue = "";

            // AllDay
            AllDay.HrefValue = "";
            AllDay.TooltipValue = "";

            // Description
            Description.HrefValue = "";
            Description.TooltipValue = "";

            // Url
            _Url.HrefValue = "";
            _Url.TooltipValue = "";

            // Display
            Display.HrefValue = "";
            Display.TooltipValue = "";

            // BackgroundColor
            BackgroundColor.HrefValue = "";
            BackgroundColor.TooltipValue = "";

            // CRSS_ID
            CRSS_ID.HrefValue = "";
            CRSS_ID.TooltipValue = "";

            // str_AppointmentType
            str_AppointmentType.HrefValue = "";
            str_AppointmentType.TooltipValue = "";

            // str_AppointmentStatus
            str_AppointmentStatus.HrefValue = "";
            str_AppointmentStatus.TooltipValue = "";

            // str_Username
            str_Username.HrefValue = "";
            str_Username.TooltipValue = "";

            // str_CRSS_IDUSER
            str_CRSS_IDUSER.HrefValue = "";
            str_CRSS_IDUSER.TooltipValue = "";

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

            // Id
            Id.SetupEditAttributes();
            Id.EditValue = Id.CurrentValue;
            Id.ViewCustomAttributes = "";

            // int_Enrollement_Id
            int_Enrollement_Id.SetupEditAttributes();
            int_Enrollement_Id.PlaceHolder = RemoveHtml(int_Enrollement_Id.Caption);
            if (!Empty(int_Enrollement_Id.EditValue) && IsNumeric(int_Enrollement_Id.EditValue))
                int_Enrollement_Id.EditValue = FormatNumber(int_Enrollement_Id.EditValue, null);

            // int_PackageID
            int_PackageID.SetupEditAttributes();
            int_PackageID.PlaceHolder = RemoveHtml(int_PackageID.Caption);
            if (!Empty(int_PackageID.EditValue) && IsNumeric(int_PackageID.EditValue))
                int_PackageID.EditValue = FormatNumber(int_PackageID.EditValue, null);

            // Title
            _Title.SetupEditAttributes();
            if (!_Title.Raw)
                _Title.CurrentValue = HtmlDecode(_Title.CurrentValue);
            _Title.EditValue = HtmlEncode(_Title.CurrentValue);
            _Title.PlaceHolder = RemoveHtml(_Title.Caption);

            // Start
            Start.SetupEditAttributes();
            Start.EditValue = FormatDateTime(Start.CurrentValue, Start.FormatPattern); // DN
            Start.PlaceHolder = RemoveHtml(Start.Caption);

            // End
            End.SetupEditAttributes();
            End.EditValue = FormatDateTime(End.CurrentValue, End.FormatPattern); // DN
            End.PlaceHolder = RemoveHtml(End.Caption);

            // AllDay
            AllDay.EditValue = AllDay.Options(false);
            AllDay.PlaceHolder = RemoveHtml(AllDay.Caption);

            // Description
            Description.SetupEditAttributes();
            Description.EditValue = Description.CurrentValue; // DN
            Description.PlaceHolder = RemoveHtml(Description.Caption);

            // Url
            _Url.SetupEditAttributes();
            if (!_Url.Raw)
                _Url.CurrentValue = HtmlDecode(_Url.CurrentValue);
            _Url.EditValue = HtmlEncode(_Url.CurrentValue);
            _Url.PlaceHolder = RemoveHtml(_Url.Caption);

            // Display
            Display.SetupEditAttributes();
            if (!Display.Raw)
                Display.CurrentValue = HtmlDecode(Display.CurrentValue);
            Display.EditValue = HtmlEncode(Display.CurrentValue);
            Display.PlaceHolder = RemoveHtml(Display.Caption);

            // BackgroundColor
            BackgroundColor.SetupEditAttributes();
            if (!BackgroundColor.Raw)
                BackgroundColor.CurrentValue = HtmlDecode(BackgroundColor.CurrentValue);
            BackgroundColor.EditValue = HtmlEncode(BackgroundColor.CurrentValue);
            BackgroundColor.PlaceHolder = RemoveHtml(BackgroundColor.Caption);

            // CRSS_ID
            CRSS_ID.SetupEditAttributes();
            if (!CRSS_ID.Raw)
                CRSS_ID.CurrentValue = HtmlDecode(CRSS_ID.CurrentValue);
            CRSS_ID.EditValue = HtmlEncode(CRSS_ID.CurrentValue);
            CRSS_ID.PlaceHolder = RemoveHtml(CRSS_ID.Caption);

            // str_AppointmentType
            str_AppointmentType.SetupEditAttributes();
            str_AppointmentType.PlaceHolder = RemoveHtml(str_AppointmentType.Caption);

            // str_AppointmentStatus
            str_AppointmentStatus.SetupEditAttributes();
            str_AppointmentStatus.EditValue = str_AppointmentStatus.Options(true);
            str_AppointmentStatus.PlaceHolder = RemoveHtml(str_AppointmentStatus.Caption);

            // str_Username

            // str_CRSS_IDUSER
            str_CRSS_IDUSER.SetupEditAttributes();
            if (!str_CRSS_IDUSER.Raw)
                str_CRSS_IDUSER.CurrentValue = HtmlDecode(str_CRSS_IDUSER.CurrentValue);
            str_CRSS_IDUSER.EditValue = HtmlEncode(str_CRSS_IDUSER.CurrentValue);
            str_CRSS_IDUSER.PlaceHolder = RemoveHtml(str_CRSS_IDUSER.Caption);

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
                        doc.ExportCaption(Id);
                        doc.ExportCaption(int_PackageID);
                        doc.ExportCaption(_Title);
                        doc.ExportCaption(Start);
                        doc.ExportCaption(End);
                        doc.ExportCaption(Description);
                        doc.ExportCaption(str_AppointmentType);
                        doc.ExportCaption(str_AppointmentStatus);
                        doc.ExportCaption(str_Username);
                    }
                    else
                    {
                        doc.ExportCaption(Id);
                        doc.ExportCaption(int_Enrollement_Id);
                        doc.ExportCaption(int_PackageID);
                        doc.ExportCaption(_Title);
                        doc.ExportCaption(Start);
                        doc.ExportCaption(End);
                        doc.ExportCaption(AllDay);
                        doc.ExportCaption(_Url);
                        doc.ExportCaption(Display);
                        doc.ExportCaption(BackgroundColor);
                        doc.ExportCaption(CRSS_ID);
                        doc.ExportCaption(str_AppointmentType);
                        doc.ExportCaption(str_AppointmentStatus);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(str_CRSS_IDUSER);
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
                            await doc.ExportField(Id);
                            await doc.ExportField(int_PackageID);
                            await doc.ExportField(_Title);
                            await doc.ExportField(Start);
                            await doc.ExportField(End);
                            await doc.ExportField(Description);
                            await doc.ExportField(str_AppointmentType);
                            await doc.ExportField(str_AppointmentStatus);
                            await doc.ExportField(str_Username);
                        }
                        else
                        {
                            await doc.ExportField(Id);
                            await doc.ExportField(int_Enrollement_Id);
                            await doc.ExportField(int_PackageID);
                            await doc.ExportField(_Title);
                            await doc.ExportField(Start);
                            await doc.ExportField(End);
                            await doc.ExportField(AllDay);
                            await doc.ExportField(_Url);
                            await doc.ExportField(Display);
                            await doc.ExportField(BackgroundColor);
                            await doc.ExportField(CRSS_ID);
                            await doc.ExportField(str_AppointmentType);
                            await doc.ExportField(str_AppointmentStatus);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(str_CRSS_IDUSER);
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

        // Write audit trail start/end for grid update
        public async Task WriteAuditTrailLog(string log) => await WriteAuditTrailAsync(CurrentUser(), log, "Appointment_Cldr");

        // Write audit trail (add page)
        public async Task WriteAuditTrailOnAdd(IDictionary<string, object> rs)
        {
            if (!AuditTrailOnAdd)
                return;
            string table = "Appointment_Cldr";

            // Get key value
            string key = GetKey(rs); // DN
            var usr = CurrentUser();
            foreach (string fldname in rs.Keys)
            {
                if (Fields.TryGetValue(fldname, out DbField? fld) && !fld.IsBlob)
                { // Ignore BLOB fields
                    object newvalue;
                    if (fld.HtmlTag == "PASSWORD")
                    {
                        newvalue = Language.Phrase("PasswordMask"); // Password Field
                    }
                    else if (fld.DataType == DataType.Memo)
                    {
                        newvalue = Config.AuditTrailToDatabase ? rs[fldname] : "[MEMO]";
                    }
                    else if (fld.DataType == DataType.Xml)
                    { // XML Field
                        newvalue = "[XML]";
                    }
                    else
                    {
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
            string table = "Appointment_Cldr";

            // Get key value
            string key = GetKey(rsold); // DN

            // Write audit trail
            var dt = DbCurrentDateTime();
            var id = ScriptName();
            var usr = CurrentUser();
            foreach (string fldname in rsnew.Keys)
            {
                if (Fields.TryGetValue(fldname, out DbField? fld) && !fld.IsBlob)
                { // Ignore BLOB fields
                    bool modified = false; object? oldvalue = null; object? newvalue = null;
                    if (fld.DataType == DataType.Date)
                    { // DateTime field
                        modified = (FormatDateTime(rsold[fldname], 0) != FormatDateTime(rsnew[fldname], 0));
                    }
                    else if (IsFloatType(fld.Type))
                    { // Float field
                        modified = ConvertToDouble(rsold[fldname]) != ConvertToDouble(rsnew[fldname]);
                    }
                    else
                    {
                        modified = !CompareValue(rsold[fldname], rsnew[fldname]);
                    }
                    if (modified)
                    {
                        if (fld.HtmlTag == "PASSWORD")
                        { // Password Field
                            oldvalue = Language.Phrase("PasswordMask");
                            newvalue = Language.Phrase("PasswordMask");
                        }
                        else if (fld.DataType == DataType.Memo)
                        { // Memo field
                            if (Config.AuditTrailToDatabase)
                            {
                                oldvalue = rsold[fldname];
                                newvalue = rsnew[fldname];
                            }
                            else
                            {
                                oldvalue = "[MEMO]";
                                newvalue = "[MEMO]";
                            }
                        }
                        else if (fld.DataType == DataType.Xml)
                        { // XML field
                            oldvalue = "[XML]";
                            newvalue = "[XML]";
                        }
                        else
                        {
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
            string table = "Appointment_Cldr";

            // Get key value
            string key = GetKey(rs); // DN

            // Write audit trail
            var dt = DbCurrentDateTime();
            var id = ScriptName();
            var usr = CurrentUser();
            foreach (string fldname in rs.Keys)
            {
                if (Fields.TryGetValue(fldname, out DbField? fld) && !fld.IsBlob)
                { // Ignore BLOB fields
                    object? oldvalue = null;
                    if (fld.HtmlTag == "PASSWORD")
                    { // Password Field
                        oldvalue = Language.Phrase("PasswordMask"); // Password Field
                    }
                    else if (fld.DataType == DataType.Memo)
                    {
                        oldvalue = Config.AuditTrailToDatabase ? rs[fldname] : "[MEMO]";
                    }
                    else if (fld.DataType == DataType.Xml)
                    { // XML field
                        oldvalue = "[XML]";
                    }
                    else
                    {
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

            var str_AppointmentType = rsnew.GetValueOrDefault("str_AppointmentType")?.ToString();
            var str_AppointmentStatus = Convert.ToInt32(rsnew.GetValueOrDefault("str_AppointmentStatus"));

            var int_Enrollement_Id = Convert.ToInt32(rsnew.GetValueOrDefault("int_Enrollement_Id"));
            var int_PackageID = Convert.ToInt32(rsnew.GetValueOrDefault("int_PackageID"));

            var rowEnrollment = ExecuteRow($"SELECT * FROM tblStudentEnrollment WHERE int_Enrollement_Id = '{int_Enrollement_Id}'");
            //var rowPackageInfo = ExecuteRow($"SELECT * FROM tblPackageInfo WHERE int_Package_Id = '{int_PackageID}'");
            var int_Student_Id = Convert.ToInt32(rowEnrollment.GetValueOrDefault("int_Student_Id"));
            var rowStudent = ExecuteRow($"SELECT * FROM tblStudents WHERE int_Student_ID = '{int_Student_Id}'");

            string? name = rowStudent.GetValueOrDefault("str_Full_Name")?.ToString();
            string? date = rowEnrollment.GetValueOrDefault("Start")?.ToString();
            string? phoneNo = rowStudent.GetValueOrDefault("str_Cell_Phone")?.ToString();

            if (AppointmentStatus.Confirmed == (AppointmentStatus)str_AppointmentStatus)
            {
                if (str_AppointmentType?.Contains("Road Test", StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    var smsMessage = SmsMessageFor.StudentRoadTestConfirm(name, date);
                    await JawalbSms.SendSmsAsync(smsMessage, phoneNo!);
                }
                else if (str_AppointmentType?.Contains("Behind The Wheel", StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    var smsMessage = SmsMessageFor.StudentAppointmentForBTWMessage(name, date);
                    await JawalbSms.SendSmsAsync(smsMessage, phoneNo!);
                }
                else if (str_AppointmentType?.Contains("Knowledge Test", StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    var smsMessage = SmsMessageFor.StudentAppointmentForKTMessage(name, date);
                    await JawalbSms.SendSmsAsync(smsMessage, phoneNo!);
                }
            }
            else if (AppointmentStatus.Complete == (AppointmentStatus)str_AppointmentStatus)
            {
                if (str_AppointmentType?.Contains("Behind The Wheel", StringComparison.CurrentCultureIgnoreCase) == true)
                {
                    var smsMessage = SmsMessageFor.StudentAppointmentForRoadTest(name);
                    await JawalbSms.SendSmsAsync(smsMessage, phoneNo!);
                }
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
