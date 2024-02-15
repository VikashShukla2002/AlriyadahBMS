namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblAppointmentsInfo
    /// </summary>
    [MaybeNull]
    public static TblAppointmentsInfo tblAppointmentsInfo
    {
        get => HttpData.Resolve<TblAppointmentsInfo>("tblAppointmentsInfo");
        set => HttpData["tblAppointmentsInfo"] = value;
    }

    /// <summary>
    /// Table class for tblAppointmentsInfo
    /// </summary>
    public class TblAppointmentsInfo : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> int_Appt_id;

        public readonly DbField<SqlDbType> str_AppName;

        public readonly DbField<SqlDbType> str_App_Date;

        public readonly DbField<SqlDbType> str_StartTime;

        public readonly DbField<SqlDbType> str_EndTime;

        public readonly DbField<SqlDbType> str_PickupTime;

        public readonly DbField<SqlDbType> str_DropOffTime;

        public readonly DbField<SqlDbType> int_VehicleID;

        public readonly DbField<SqlDbType> dec_InstID;

        public readonly DbField<SqlDbType> dec_StudentID;

        public readonly DbField<SqlDbType> dec_Observed_StudentID;

        public readonly DbField<SqlDbType> int_Apptype;

        public readonly DbField<SqlDbType> int_AppStatus;

        public readonly DbField<SqlDbType> mny_AppCost;

        public readonly DbField<SqlDbType> mny_AmountPaid;

        public readonly DbField<SqlDbType> bit_CheckAppPaid;

        public readonly DbField<SqlDbType> bit_Confirmation;

        public readonly DbField<SqlDbType> str_Instructions;

        public readonly DbField<SqlDbType> str_Instructions1;

        public readonly DbField<SqlDbType> str_AppNotes;

        public readonly DbField<SqlDbType> str_PickupLocation;

        public readonly DbField<SqlDbType> int_Created_By;

        public readonly DbField<SqlDbType> int_Modified_By;

        public readonly DbField<SqlDbType> date_Created;

        public readonly DbField<SqlDbType> date_Modified;

        public readonly DbField<SqlDbType> bit_IsDeleted;

        public readonly DbField<SqlDbType> str_Interval;

        public readonly DbField<SqlDbType> RemM1;

        public readonly DbField<SqlDbType> RemM2;

        public readonly DbField<SqlDbType> RemM3;

        public readonly DbField<SqlDbType> int_Location_ID;

        public readonly DbField<SqlDbType> SPID;

        public readonly DbField<SqlDbType> Chk_Trace;

        public readonly DbField<SqlDbType> str_DropOffLocation;

        public readonly DbField<SqlDbType> imgInstructorSignature;

        public readonly DbField<SqlDbType> imgStudentSignature;

        public readonly DbField<SqlDbType> imgObserverSignature;

        public readonly DbField<SqlDbType> dt_apptstart;

        public readonly DbField<SqlDbType> dt_apptComplete;

        public readonly DbField<SqlDbType> int_apptstartedBy;

        public readonly DbField<SqlDbType> int_apptCompletedBy;

        public readonly DbField<SqlDbType> SMSReminder1;

        public readonly DbField<SqlDbType> SMSReminder2;

        public readonly DbField<SqlDbType> SMSReminder3;

        public readonly DbField<SqlDbType> VoiceReminder1;

        public readonly DbField<SqlDbType> VoiceReminder2;

        public readonly DbField<SqlDbType> VoiceReminder3;

        public readonly DbField<SqlDbType> bit_isroadtest;

        public readonly DbField<SqlDbType> int_slotType;

        public readonly DbField<SqlDbType> bit_VisibleOnPortal;

        public readonly DbField<SqlDbType> IsDataRetrieved;

        public readonly DbField<SqlDbType> bit_chargesApplied;

        public readonly DbField<SqlDbType> dec_DistanceTravelled;

        public readonly DbField<SqlDbType> btwProductIdsforSSRules;

        public readonly DbField<SqlDbType> int_evaluateApptWithEmail;

        public readonly DbField<SqlDbType> PublicNotesId;

        public readonly DbField<SqlDbType> NationalID;

        public readonly DbField<SqlDbType> str_Username;

        public readonly DbField<SqlDbType> int_PackageID;

        public readonly DbField<SqlDbType> int_ApptCldr_ID;

        public readonly DbField<SqlDbType> str_CRSS_ID;

        // Constructor
        public TblAppointmentsInfo()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "tblAppointmentsInfo";
            Name = "tblAppointmentsInfo";
            Type = "TABLE";
            UpdateTable = "dbo.tblAppointmentsInfo"; // Update Table
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

            // int_Appt_id
            int_Appt_id = new (this, "x_int_Appt_id", 3, SqlDbType.Int) {
                Name = "int_Appt_id",
                Expression = "[int_Appt_id]",
                BasicSearchExpression = "CAST([int_Appt_id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Appt_id]",
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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "int_Appt_id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Appt_id", int_Appt_id);

            // str_AppName
            str_AppName = new (this, "x_str_AppName", 202, SqlDbType.NVarChar) {
                Name = "str_AppName",
                Expression = "[str_AppName]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_AppName]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_AppName]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "str_AppName", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_AppName", str_AppName);

            // str_App_Date
            str_App_Date = new (this, "x_str_App_Date", 200, SqlDbType.VarChar) {
                Name = "str_App_Date",
                Expression = "[str_App_Date]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_App_Date]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_App_Date]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "str_App_Date", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_App_Date", str_App_Date);

            // str_StartTime
            str_StartTime = new (this, "x_str_StartTime", 200, SqlDbType.VarChar) {
                Name = "str_StartTime",
                Expression = "[str_StartTime]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_StartTime]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_StartTime]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "str_StartTime", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_StartTime", str_StartTime);

            // str_EndTime
            str_EndTime = new (this, "x_str_EndTime", 200, SqlDbType.VarChar) {
                Name = "str_EndTime",
                Expression = "[str_EndTime]",
                BasicSearchExpression = "[str_EndTime]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_EndTime]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "str_EndTime", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_EndTime", str_EndTime);

            // str_PickupTime
            str_PickupTime = new (this, "x_str_PickupTime", 200, SqlDbType.VarChar) {
                Name = "str_PickupTime",
                Expression = "[str_PickupTime]",
                BasicSearchExpression = "[str_PickupTime]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_PickupTime]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "str_PickupTime", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_PickupTime", str_PickupTime);

            // str_DropOffTime
            str_DropOffTime = new (this, "x_str_DropOffTime", 200, SqlDbType.VarChar) {
                Name = "str_DropOffTime",
                Expression = "[str_DropOffTime]",
                BasicSearchExpression = "[str_DropOffTime]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_DropOffTime]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "str_DropOffTime", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_DropOffTime", str_DropOffTime);

            // int_VehicleID
            int_VehicleID = new (this, "x_int_VehicleID", 3, SqlDbType.Int) {
                Name = "int_VehicleID",
                Expression = "[int_VehicleID]",
                BasicSearchExpression = "CAST([int_VehicleID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_VehicleID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "int_VehicleID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_VehicleID", int_VehicleID);

            // dec_InstID
            dec_InstID = new (this, "x_dec_InstID", 131, SqlDbType.Decimal) {
                Name = "dec_InstID",
                Expression = "[dec_InstID]",
                BasicSearchExpression = "CAST([dec_InstID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[dec_InstID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "dec_InstID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dec_InstID", dec_InstID);

            // dec_StudentID
            dec_StudentID = new (this, "x_dec_StudentID", 3, SqlDbType.Int) {
                Name = "dec_StudentID",
                Expression = "[dec_StudentID]",
                BasicSearchExpression = "CAST([dec_StudentID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[dec_StudentID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "dec_StudentID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dec_StudentID", dec_StudentID);

            // dec_Observed_StudentID
            dec_Observed_StudentID = new (this, "x_dec_Observed_StudentID", 3, SqlDbType.Int) {
                Name = "dec_Observed_StudentID",
                Expression = "[dec_Observed_StudentID]",
                BasicSearchExpression = "CAST([dec_Observed_StudentID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[dec_Observed_StudentID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "dec_Observed_StudentID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dec_Observed_StudentID", dec_Observed_StudentID);

            // int_Apptype
            int_Apptype = new (this, "x_int_Apptype", 3, SqlDbType.Int) {
                Name = "int_Apptype",
                Expression = "[int_Apptype]",
                BasicSearchExpression = "CAST([int_Apptype] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Apptype]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "int_Apptype", "CustomMsg"),
                IsUpload = false
            };
            int_Apptype.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(int_Apptype, "qryAppointmentType", false, "int_AppType", new List<string> {"int_AppType", "Service_Description", "", ""}, "", "", new List<string> {"x_int_PackageID"}, new List<string> {}, new List<string> {"int_PackageID"}, new List<string> {"x_int_PackageID"}, new List<string> {}, new List<string> {}, "", "", "CONCAT(CAST([int_AppType] AS NVARCHAR),'" + ValueSeparator(1, int_Apptype) + "',[Service_Description])"),
                "en-US" => new Lookup<DbField>(int_Apptype, "qryAppointmentType", false, "int_AppType", new List<string> {"int_AppType", "Service_Description", "", ""}, "", "", new List<string> {"x_int_PackageID"}, new List<string> {}, new List<string> {"int_PackageID"}, new List<string> {"x_int_PackageID"}, new List<string> {}, new List<string> {}, "", "", "CONCAT(CAST([int_AppType] AS NVARCHAR),'" + ValueSeparator(1, int_Apptype) + "',[Service_Description])"),
                _ => new Lookup<DbField>(int_Apptype, "qryAppointmentType", false, "int_AppType", new List<string> {"int_AppType", "Service_Description", "", ""}, "", "", new List<string> {"x_int_PackageID"}, new List<string> {}, new List<string> {"int_PackageID"}, new List<string> {"x_int_PackageID"}, new List<string> {}, new List<string> {}, "", "", "CONCAT(CAST([int_AppType] AS NVARCHAR),'" + ValueSeparator(1, int_Apptype) + "',[Service_Description])")
            };
            Fields.Add("int_Apptype", int_Apptype);

            // int_AppStatus
            int_AppStatus = new (this, "x_int_AppStatus", 3, SqlDbType.Int) {
                Name = "int_AppStatus",
                Expression = "[int_AppStatus]",
                BasicSearchExpression = "CAST([int_AppStatus] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_AppStatus]",
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
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "int_AppStatus", "CustomMsg"),
                IsUpload = false
            };
            int_AppStatus.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(int_AppStatus, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(int_AppStatus, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(int_AppStatus, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("int_AppStatus", int_AppStatus);

            // mny_AppCost
            mny_AppCost = new (this, "x_mny_AppCost", 6, SqlDbType.Money) {
                Name = "mny_AppCost",
                Expression = "[mny_AppCost]",
                BasicSearchExpression = "CAST([mny_AppCost] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[mny_AppCost]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "mny_AppCost", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("mny_AppCost", mny_AppCost);

            // mny_AmountPaid
            mny_AmountPaid = new (this, "x_mny_AmountPaid", 6, SqlDbType.Money) {
                Name = "mny_AmountPaid",
                Expression = "[mny_AmountPaid]",
                BasicSearchExpression = "CAST([mny_AmountPaid] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[mny_AmountPaid]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "mny_AmountPaid", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("mny_AmountPaid", mny_AmountPaid);

            // bit_CheckAppPaid
            bit_CheckAppPaid = new (this, "x_bit_CheckAppPaid", 11, SqlDbType.Bit) {
                Name = "bit_CheckAppPaid",
                Expression = "[bit_CheckAppPaid]",
                BasicSearchExpression = "[bit_CheckAppPaid]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_CheckAppPaid]",
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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "bit_CheckAppPaid", "CustomMsg"),
                IsUpload = false
            };
            bit_CheckAppPaid.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_CheckAppPaid, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_CheckAppPaid, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_CheckAppPaid, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_CheckAppPaid", bit_CheckAppPaid);

            // bit_Confirmation
            bit_Confirmation = new (this, "x_bit_Confirmation", 11, SqlDbType.Bit) {
                Name = "bit_Confirmation",
                Expression = "[bit_Confirmation]",
                BasicSearchExpression = "[bit_Confirmation]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_Confirmation]",
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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "bit_Confirmation", "CustomMsg"),
                IsUpload = false
            };
            bit_Confirmation.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_Confirmation, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_Confirmation, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_Confirmation, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_Confirmation", bit_Confirmation);

            // str_Instructions
            str_Instructions = new (this, "x_str_Instructions", 202, SqlDbType.NVarChar) {
                Name = "str_Instructions",
                Expression = "[str_Instructions]",
                BasicSearchExpression = "[str_Instructions]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Instructions]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "str_Instructions", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Instructions", str_Instructions);

            // str_Instructions1
            str_Instructions1 = new (this, "x_str_Instructions1", 202, SqlDbType.NVarChar) {
                Name = "str_Instructions1",
                Expression = "[str_Instructions1]",
                BasicSearchExpression = "[str_Instructions1]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Instructions1]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "str_Instructions1", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Instructions1", str_Instructions1);

            // str_AppNotes
            str_AppNotes = new (this, "x_str_AppNotes", 202, SqlDbType.NVarChar) {
                Name = "str_AppNotes",
                Expression = "[str_AppNotes]",
                BasicSearchExpression = "[str_AppNotes]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_AppNotes]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "str_AppNotes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_AppNotes", str_AppNotes);

            // str_PickupLocation
            str_PickupLocation = new (this, "x_str_PickupLocation", 202, SqlDbType.NVarChar) {
                Name = "str_PickupLocation",
                Expression = "[str_PickupLocation]",
                BasicSearchExpression = "[str_PickupLocation]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_PickupLocation]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "str_PickupLocation", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_PickupLocation", str_PickupLocation);

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
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "int_Created_By", "CustomMsg"),
                IsUpload = false
            };
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
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "int_Modified_By", "CustomMsg"),
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
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "date_Created", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "date_Modified", "CustomMsg"),
                IsUpload = false
            };
            date_Modified.GetAutoUpdateValue = () => CurrentDateTime();
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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "bit_IsDeleted", "CustomMsg"),
                IsUpload = false
            };
            bit_IsDeleted.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IsDeleted, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsDeleted, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IsDeleted, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            bit_IsDeleted.GetDefault = () => 0;
            Fields.Add("bit_IsDeleted", bit_IsDeleted);

            // str_Interval
            str_Interval = new (this, "x_str_Interval", 200, SqlDbType.VarChar) {
                Name = "str_Interval",
                Expression = "[str_Interval]",
                BasicSearchExpression = "[str_Interval]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Interval]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "str_Interval", "CustomMsg"),
                IsUpload = false
            };
            str_Interval.GetDefault = () => "0";
            Fields.Add("str_Interval", str_Interval);

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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "RemM1", "CustomMsg"),
                IsUpload = false
            };
            RemM1.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(RemM1, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(RemM1, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(RemM1, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "RemM2", "CustomMsg"),
                IsUpload = false
            };
            RemM2.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(RemM2, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(RemM2, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(RemM2, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "RemM3", "CustomMsg"),
                IsUpload = false
            };
            RemM3.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(RemM3, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(RemM3, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(RemM3, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            RemM3.GetDefault = () => 0;
            Fields.Add("RemM3", RemM3);

            // int_Location_ID
            int_Location_ID = new (this, "x_int_Location_ID", 131, SqlDbType.Decimal) {
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
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "int_Location_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Location_ID", int_Location_ID);

            // SPID
            SPID = new (this, "x_SPID", 131, SqlDbType.Decimal) {
                Name = "SPID",
                Expression = "[SPID]",
                BasicSearchExpression = "CAST([SPID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[SPID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "SPID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("SPID", SPID);

            // Chk_Trace
            Chk_Trace = new (this, "x_Chk_Trace", 200, SqlDbType.VarChar) {
                Name = "Chk_Trace",
                Expression = "[Chk_Trace]",
                BasicSearchExpression = "[Chk_Trace]",
                DateTimeFormat = -1,
                VirtualExpression = "[Chk_Trace]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "Chk_Trace", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Chk_Trace", Chk_Trace);

            // str_DropOffLocation
            str_DropOffLocation = new (this, "x_str_DropOffLocation", 202, SqlDbType.NVarChar) {
                Name = "str_DropOffLocation",
                Expression = "[str_DropOffLocation]",
                BasicSearchExpression = "[str_DropOffLocation]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_DropOffLocation]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "str_DropOffLocation", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_DropOffLocation", str_DropOffLocation);

            // imgInstructorSignature
            imgInstructorSignature = new (this, "x_imgInstructorSignature", 205, SqlDbType.Image) {
                Name = "imgInstructorSignature",
                Expression = "[imgInstructorSignature]",
                BasicSearchExpression = "[imgInstructorSignature]",
                DateTimeFormat = -1,
                VirtualExpression = "[imgInstructorSignature]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "FILE",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "imgInstructorSignature", "CustomMsg"),
                IsUpload = true
            };
            Fields.Add("imgInstructorSignature", imgInstructorSignature);

            // imgStudentSignature
            imgStudentSignature = new (this, "x_imgStudentSignature", 205, SqlDbType.Image) {
                Name = "imgStudentSignature",
                Expression = "[imgStudentSignature]",
                BasicSearchExpression = "[imgStudentSignature]",
                DateTimeFormat = -1,
                VirtualExpression = "[imgStudentSignature]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "FILE",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "imgStudentSignature", "CustomMsg"),
                IsUpload = true
            };
            Fields.Add("imgStudentSignature", imgStudentSignature);

            // imgObserverSignature
            imgObserverSignature = new (this, "x_imgObserverSignature", 205, SqlDbType.Image) {
                Name = "imgObserverSignature",
                Expression = "[imgObserverSignature]",
                BasicSearchExpression = "[imgObserverSignature]",
                DateTimeFormat = -1,
                VirtualExpression = "[imgObserverSignature]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "FILE",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "imgObserverSignature", "CustomMsg"),
                IsUpload = true
            };
            Fields.Add("imgObserverSignature", imgObserverSignature);

            // dt_apptstart
            dt_apptstart = new (this, "x_dt_apptstart", 135, SqlDbType.DateTime) {
                Name = "dt_apptstart",
                Expression = "[dt_apptstart]",
                BasicSearchExpression = CastDateFieldForLike("[dt_apptstart]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_apptstart]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "dt_apptstart", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_apptstart", dt_apptstart);

            // dt_apptComplete
            dt_apptComplete = new (this, "x_dt_apptComplete", 135, SqlDbType.DateTime) {
                Name = "dt_apptComplete",
                Expression = "[dt_apptComplete]",
                BasicSearchExpression = CastDateFieldForLike("[dt_apptComplete]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_apptComplete]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "dt_apptComplete", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_apptComplete", dt_apptComplete);

            // int_apptstartedBy
            int_apptstartedBy = new (this, "x_int_apptstartedBy", 3, SqlDbType.Int) {
                Name = "int_apptstartedBy",
                Expression = "[int_apptstartedBy]",
                BasicSearchExpression = "CAST([int_apptstartedBy] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_apptstartedBy]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "int_apptstartedBy", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_apptstartedBy", int_apptstartedBy);

            // int_apptCompletedBy
            int_apptCompletedBy = new (this, "x_int_apptCompletedBy", 3, SqlDbType.Int) {
                Name = "int_apptCompletedBy",
                Expression = "[int_apptCompletedBy]",
                BasicSearchExpression = "CAST([int_apptCompletedBy] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_apptCompletedBy]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "int_apptCompletedBy", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_apptCompletedBy", int_apptCompletedBy);

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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "SMSReminder1", "CustomMsg"),
                IsUpload = false
            };
            SMSReminder1.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(SMSReminder1, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(SMSReminder1, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(SMSReminder1, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "SMSReminder2", "CustomMsg"),
                IsUpload = false
            };
            SMSReminder2.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(SMSReminder2, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(SMSReminder2, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(SMSReminder2, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "SMSReminder3", "CustomMsg"),
                IsUpload = false
            };
            SMSReminder3.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(SMSReminder3, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(SMSReminder3, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(SMSReminder3, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "VoiceReminder1", "CustomMsg"),
                IsUpload = false
            };
            VoiceReminder1.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(VoiceReminder1, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(VoiceReminder1, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(VoiceReminder1, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "VoiceReminder2", "CustomMsg"),
                IsUpload = false
            };
            VoiceReminder2.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(VoiceReminder2, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(VoiceReminder2, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(VoiceReminder2, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "VoiceReminder3", "CustomMsg"),
                IsUpload = false
            };
            VoiceReminder3.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(VoiceReminder3, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(VoiceReminder3, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(VoiceReminder3, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("VoiceReminder3", VoiceReminder3);

            // bit_isroadtest
            bit_isroadtest = new (this, "x_bit_isroadtest", 11, SqlDbType.Bit) {
                Name = "bit_isroadtest",
                Expression = "[bit_isroadtest]",
                BasicSearchExpression = "[bit_isroadtest]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_isroadtest]",
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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "bit_isroadtest", "CustomMsg"),
                IsUpload = false
            };
            bit_isroadtest.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_isroadtest, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_isroadtest, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_isroadtest, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_isroadtest", bit_isroadtest);

            // int_slotType
            int_slotType = new (this, "x_int_slotType", 3, SqlDbType.Int) {
                Name = "int_slotType",
                Expression = "[int_slotType]",
                BasicSearchExpression = "CAST([int_slotType] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_slotType]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "int_slotType", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_slotType", int_slotType);

            // bit_VisibleOnPortal
            bit_VisibleOnPortal = new (this, "x_bit_VisibleOnPortal", 11, SqlDbType.Bit) {
                Name = "bit_VisibleOnPortal",
                Expression = "[bit_VisibleOnPortal]",
                BasicSearchExpression = "[bit_VisibleOnPortal]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_VisibleOnPortal]",
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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "bit_VisibleOnPortal", "CustomMsg"),
                IsUpload = false
            };
            bit_VisibleOnPortal.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_VisibleOnPortal, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_VisibleOnPortal, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_VisibleOnPortal, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_VisibleOnPortal", bit_VisibleOnPortal);

            // IsDataRetrieved
            IsDataRetrieved = new (this, "x_IsDataRetrieved", 11, SqlDbType.Bit) {
                Name = "IsDataRetrieved",
                Expression = "[IsDataRetrieved]",
                BasicSearchExpression = "[IsDataRetrieved]",
                DateTimeFormat = -1,
                VirtualExpression = "[IsDataRetrieved]",
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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "IsDataRetrieved", "CustomMsg"),
                IsUpload = false
            };
            IsDataRetrieved.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(IsDataRetrieved, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(IsDataRetrieved, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(IsDataRetrieved, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("IsDataRetrieved", IsDataRetrieved);

            // bit_chargesApplied
            bit_chargesApplied = new (this, "x_bit_chargesApplied", 11, SqlDbType.Bit) {
                Name = "bit_chargesApplied",
                Expression = "[bit_chargesApplied]",
                BasicSearchExpression = "[bit_chargesApplied]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_chargesApplied]",
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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "bit_chargesApplied", "CustomMsg"),
                IsUpload = false
            };
            bit_chargesApplied.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_chargesApplied, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_chargesApplied, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_chargesApplied, "tblAppointmentsInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_chargesApplied", bit_chargesApplied);

            // dec_DistanceTravelled
            dec_DistanceTravelled = new (this, "x_dec_DistanceTravelled", 131, SqlDbType.Decimal) {
                Name = "dec_DistanceTravelled",
                Expression = "[dec_DistanceTravelled]",
                BasicSearchExpression = "CAST([dec_DistanceTravelled] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[dec_DistanceTravelled]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "dec_DistanceTravelled", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dec_DistanceTravelled", dec_DistanceTravelled);

            // btwProductIdsforSSRules
            btwProductIdsforSSRules = new (this, "x_btwProductIdsforSSRules", 201, SqlDbType.Text) {
                Name = "btwProductIdsforSSRules",
                Expression = "[btwProductIdsforSSRules]",
                BasicSearchExpression = "[btwProductIdsforSSRules]",
                DateTimeFormat = -1,
                VirtualExpression = "[btwProductIdsforSSRules]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "btwProductIdsforSSRules", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("btwProductIdsforSSRules", btwProductIdsforSSRules);

            // int_evaluateApptWithEmail
            int_evaluateApptWithEmail = new (this, "x_int_evaluateApptWithEmail", 3, SqlDbType.Int) {
                Name = "int_evaluateApptWithEmail",
                Expression = "[int_evaluateApptWithEmail]",
                BasicSearchExpression = "CAST([int_evaluateApptWithEmail] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_evaluateApptWithEmail]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "int_evaluateApptWithEmail", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_evaluateApptWithEmail", int_evaluateApptWithEmail);

            // PublicNotesId
            PublicNotesId = new (this, "x_PublicNotesId", 201, SqlDbType.Text) {
                Name = "PublicNotesId",
                Expression = "[PublicNotesId]",
                BasicSearchExpression = "[PublicNotesId]",
                DateTimeFormat = -1,
                VirtualExpression = "[PublicNotesId]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "PublicNotesId", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("PublicNotesId", PublicNotesId);

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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "NationalID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("NationalID", NationalID);

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
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "str_Username", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Username", str_Username);

            // int_PackageID
            int_PackageID = new (this, "x_int_PackageID", 3, SqlDbType.Int) {
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
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "int_PackageID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_PackageID", int_PackageID);

            // int_ApptCldr_ID
            int_ApptCldr_ID = new (this, "x_int_ApptCldr_ID", 3, SqlDbType.Int) {
                Name = "int_ApptCldr_ID",
                Expression = "[int_ApptCldr_ID]",
                BasicSearchExpression = "CAST([int_ApptCldr_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_ApptCldr_ID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "int_ApptCldr_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_ApptCldr_ID", int_ApptCldr_ID);

            // str_CRSS_ID
            str_CRSS_ID = new (this, "x_str_CRSS_ID", 202, SqlDbType.NVarChar) {
                Name = "str_CRSS_ID",
                Expression = "[str_CRSS_ID]",
                BasicSearchExpression = "[str_CRSS_ID]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CRSS_ID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAppointmentsInfo", "str_CRSS_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CRSS_ID", str_CRSS_ID);

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
            get => _sqlFrom ?? "dbo.tblAppointmentsInfo";
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
                int_Appt_id.SetDbValue(lastInsertedId);
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
                if (!rsaudit.ContainsKey("int_Appt_id"))
                    rsaudit.Add("int_Appt_id", rsold["int_Appt_id"]);
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
                int_Appt_id.DbValue = row["int_Appt_id"]; // Set DB value only
                str_AppName.DbValue = row["str_AppName"]; // Set DB value only
                str_App_Date.DbValue = row["str_App_Date"]; // Set DB value only
                str_StartTime.DbValue = row["str_StartTime"]; // Set DB value only
                str_EndTime.DbValue = row["str_EndTime"]; // Set DB value only
                str_PickupTime.DbValue = row["str_PickupTime"]; // Set DB value only
                str_DropOffTime.DbValue = row["str_DropOffTime"]; // Set DB value only
                int_VehicleID.DbValue = row["int_VehicleID"]; // Set DB value only
                dec_InstID.DbValue = row["dec_InstID"]; // Set DB value only
                dec_StudentID.DbValue = row["dec_StudentID"]; // Set DB value only
                dec_Observed_StudentID.DbValue = row["dec_Observed_StudentID"]; // Set DB value only
                int_Apptype.DbValue = row["int_Apptype"]; // Set DB value only
                int_AppStatus.DbValue = row["int_AppStatus"]; // Set DB value only
                mny_AppCost.DbValue = row["mny_AppCost"]; // Set DB value only
                mny_AmountPaid.DbValue = row["mny_AmountPaid"]; // Set DB value only
                bit_CheckAppPaid.DbValue = (ConvertToBool(row["bit_CheckAppPaid"]) ? "1" : "0"); // Set DB value only
                bit_Confirmation.DbValue = (ConvertToBool(row["bit_Confirmation"]) ? "1" : "0"); // Set DB value only
                str_Instructions.DbValue = row["str_Instructions"]; // Set DB value only
                str_Instructions1.DbValue = row["str_Instructions1"]; // Set DB value only
                str_AppNotes.DbValue = row["str_AppNotes"]; // Set DB value only
                str_PickupLocation.DbValue = row["str_PickupLocation"]; // Set DB value only
                int_Created_By.DbValue = row["int_Created_By"]; // Set DB value only
                int_Modified_By.DbValue = row["int_Modified_By"]; // Set DB value only
                date_Created.DbValue = row["date_Created"]; // Set DB value only
                date_Modified.DbValue = row["date_Modified"]; // Set DB value only
                bit_IsDeleted.DbValue = (ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"); // Set DB value only
                str_Interval.DbValue = row["str_Interval"]; // Set DB value only
                RemM1.DbValue = (ConvertToBool(row["RemM1"]) ? "1" : "0"); // Set DB value only
                RemM2.DbValue = (ConvertToBool(row["RemM2"]) ? "1" : "0"); // Set DB value only
                RemM3.DbValue = (ConvertToBool(row["RemM3"]) ? "1" : "0"); // Set DB value only
                int_Location_ID.DbValue = row["int_Location_ID"]; // Set DB value only
                SPID.DbValue = row["SPID"]; // Set DB value only
                Chk_Trace.DbValue = row["Chk_Trace"]; // Set DB value only
                str_DropOffLocation.DbValue = row["str_DropOffLocation"]; // Set DB value only
                imgInstructorSignature.Upload.DbValue = row["imgInstructorSignature"];
                imgStudentSignature.Upload.DbValue = row["imgStudentSignature"];
                imgObserverSignature.Upload.DbValue = row["imgObserverSignature"];
                dt_apptstart.DbValue = row["dt_apptstart"]; // Set DB value only
                dt_apptComplete.DbValue = row["dt_apptComplete"]; // Set DB value only
                int_apptstartedBy.DbValue = row["int_apptstartedBy"]; // Set DB value only
                int_apptCompletedBy.DbValue = row["int_apptCompletedBy"]; // Set DB value only
                SMSReminder1.DbValue = (ConvertToBool(row["SMSReminder1"]) ? "1" : "0"); // Set DB value only
                SMSReminder2.DbValue = (ConvertToBool(row["SMSReminder2"]) ? "1" : "0"); // Set DB value only
                SMSReminder3.DbValue = (ConvertToBool(row["SMSReminder3"]) ? "1" : "0"); // Set DB value only
                VoiceReminder1.DbValue = (ConvertToBool(row["VoiceReminder1"]) ? "1" : "0"); // Set DB value only
                VoiceReminder2.DbValue = (ConvertToBool(row["VoiceReminder2"]) ? "1" : "0"); // Set DB value only
                VoiceReminder3.DbValue = (ConvertToBool(row["VoiceReminder3"]) ? "1" : "0"); // Set DB value only
                bit_isroadtest.DbValue = (ConvertToBool(row["bit_isroadtest"]) ? "1" : "0"); // Set DB value only
                int_slotType.DbValue = row["int_slotType"]; // Set DB value only
                bit_VisibleOnPortal.DbValue = (ConvertToBool(row["bit_VisibleOnPortal"]) ? "1" : "0"); // Set DB value only
                IsDataRetrieved.DbValue = (ConvertToBool(row["IsDataRetrieved"]) ? "1" : "0"); // Set DB value only
                bit_chargesApplied.DbValue = (ConvertToBool(row["bit_chargesApplied"]) ? "1" : "0"); // Set DB value only
                dec_DistanceTravelled.DbValue = row["dec_DistanceTravelled"]; // Set DB value only
                btwProductIdsforSSRules.DbValue = row["btwProductIdsforSSRules"]; // Set DB value only
                int_evaluateApptWithEmail.DbValue = row["int_evaluateApptWithEmail"]; // Set DB value only
                PublicNotesId.DbValue = row["PublicNotesId"]; // Set DB value only
                NationalID.DbValue = row["NationalID"]; // Set DB value only
                str_Username.DbValue = row["str_Username"]; // Set DB value only
                int_PackageID.DbValue = row["int_PackageID"]; // Set DB value only
                int_ApptCldr_ID.DbValue = row["int_ApptCldr_ID"]; // Set DB value only
                str_CRSS_ID.DbValue = row["str_CRSS_ID"]; // Set DB value only
            } catch {}
        }

        public void DeleteUploadedFiles(Dictionary<string, object> row)
        {
            LoadDbValues(row);
        }

        // Record filter WHERE clause
        private string _sqlKeyFilter => "[int_Appt_id] = @int_Appt_id@";

        #pragma warning disable 168, 219
        // Get record filter as string
        public string GetRecordFilter(Dictionary<string, object>? row = null, bool current = false)
        {
            string keyFilter = _sqlKeyFilter;
            object? val = null, result = "";
            val = row?.TryGetValue("int_Appt_id", out result) ?? false
                ? result
                : !Empty(int_Appt_id.OldValue) && !current ? int_Appt_id.OldValue : int_Appt_id.CurrentValue;
            if (!IsNumeric(val))
                return "0=1"; // Invalid key
            if (val == null)
                return "0=1"; // Invalid key
            keyFilter = keyFilter.Replace("@int_Appt_id@", AdjustSql(val, DbId)); // Replace key value
            return keyFilter;
        }

        // Get record filter as Dictionary // DN
        public Dictionary<string, object>? GetRowFilterAsDictionary(IDictionary<string, object>? row = null)
        {
            Dictionary<string, object>? keyFilter = new ();
            object? val = null, result;
            val = row?.TryGetValue("int_Appt_id", out result) ?? false
                ? result
                : !Empty(int_Appt_id.OldValue) ? int_Appt_id.OldValue : int_Appt_id.CurrentValue;
            if (!IsNumeric(val))
                return null; // Invalid key
            if (Empty(val))
                return null; // Invalid key
            keyFilter.Add("int_Appt_id", val); // Add key value
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
                    return "TblAppointmentsInfoList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "TblAppointmentsInfoView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "TblAppointmentsInfoEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "TblAppointmentsInfoAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "TblAppointmentsInfoList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "TblAppointmentsInfoView",
                Config.ApiAddAction => "TblAppointmentsInfoAdd",
                Config.ApiEditAction => "TblAppointmentsInfoEdit",
                Config.ApiDeleteAction => "TblAppointmentsInfoDelete",
                Config.ApiListAction => "TblAppointmentsInfoList",
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
        public string ListUrl => "TblAppointmentsInfoList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblAppointmentsInfoView", parm);
            else
                url = KeyUrl("TblAppointmentsInfoView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "TblAppointmentsInfoAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "TblAppointmentsInfoAdd?" + parm;
            else
                url = "TblAppointmentsInfoAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("TblAppointmentsInfoEdit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblAppointmentsInfoList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("TblAppointmentsInfoAdd", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblAppointmentsInfoList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("TblAppointmentsInfoDelete")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
            return url;
        }

        // Get primary key as JSON
        public string KeyToJson(bool htmlEncode = false)
        {
            string json = "";
            json += "\"int_Appt_id\":" + ConvertToJson(int_Appt_id.CurrentValue, "number", true);
            json = "{" + json + "}";
            if (htmlEncode)
                json = HtmlEncode(json);
            return json;
        }

        // Add key value to URL
        public string KeyUrl(string url, string parm = "") { // DN
            if (!IsNull(int_Appt_id.CurrentValue)) {
                url += "/" + int_Appt_id.CurrentValue;
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
            val = current ? ConvertToString(int_Appt_id.CurrentValue) ?? "" : ConvertToString(int_Appt_id.OldValue) ?? "";
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
            val = row?.TryGetValue("int_Appt_id", out result) ?? false ? ConvertToString(result) : null;
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
                    int_Appt_id.CurrentValue = keys[0];
                } else {
                    int_Appt_id.OldValue = keys[0];
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
                if (RouteValues.TryGetValue("int_Appt_id", out object? v0)) { // int_Appt_id // DN
                    key = UrlDecode(v0); // DN
                } else if (IsApi() && !Empty(keyValues)) {
                    key = keyValues[0];
                } else {
                    key = Param("int_Appt_id");
                }
                keysList.Add(key);
            }
            // Check keys
            foreach (var keys in keysList) {
                if (!IsNumeric(keys)) // int_Appt_id
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
                    int_Appt_id.CurrentValue = keys;
                else
                    int_Appt_id.OldValue = keys;
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
            int_Appt_id.SetDbValue(dr["int_Appt_id"]);
            str_AppName.SetDbValue(dr["str_AppName"]);
            str_App_Date.SetDbValue(dr["str_App_Date"]);
            str_StartTime.SetDbValue(dr["str_StartTime"]);
            str_EndTime.SetDbValue(dr["str_EndTime"]);
            str_PickupTime.SetDbValue(dr["str_PickupTime"]);
            str_DropOffTime.SetDbValue(dr["str_DropOffTime"]);
            int_VehicleID.SetDbValue(dr["int_VehicleID"]);
            dec_InstID.SetDbValue(dr["dec_InstID"]);
            dec_StudentID.SetDbValue(dr["dec_StudentID"]);
            dec_Observed_StudentID.SetDbValue(dr["dec_Observed_StudentID"]);
            int_Apptype.SetDbValue(dr["int_Apptype"]);
            int_AppStatus.SetDbValue(dr["int_AppStatus"]);
            mny_AppCost.SetDbValue(dr["mny_AppCost"]);
            mny_AmountPaid.SetDbValue(dr["mny_AmountPaid"]);
            bit_CheckAppPaid.SetDbValue(ConvertToBool(dr["bit_CheckAppPaid"]) ? "1" : "0");
            bit_Confirmation.SetDbValue(ConvertToBool(dr["bit_Confirmation"]) ? "1" : "0");
            str_Instructions.SetDbValue(dr["str_Instructions"]);
            str_Instructions1.SetDbValue(dr["str_Instructions1"]);
            str_AppNotes.SetDbValue(dr["str_AppNotes"]);
            str_PickupLocation.SetDbValue(dr["str_PickupLocation"]);
            int_Created_By.SetDbValue(dr["int_Created_By"]);
            int_Modified_By.SetDbValue(dr["int_Modified_By"]);
            date_Created.SetDbValue(dr["date_Created"]);
            date_Modified.SetDbValue(dr["date_Modified"]);
            bit_IsDeleted.SetDbValue(ConvertToBool(dr["bit_IsDeleted"]) ? "1" : "0");
            str_Interval.SetDbValue(dr["str_Interval"]);
            RemM1.SetDbValue(ConvertToBool(dr["RemM1"]) ? "1" : "0");
            RemM2.SetDbValue(ConvertToBool(dr["RemM2"]) ? "1" : "0");
            RemM3.SetDbValue(ConvertToBool(dr["RemM3"]) ? "1" : "0");
            int_Location_ID.SetDbValue(dr["int_Location_ID"]);
            SPID.SetDbValue(dr["SPID"]);
            Chk_Trace.SetDbValue(dr["Chk_Trace"]);
            str_DropOffLocation.SetDbValue(dr["str_DropOffLocation"]);
            imgInstructorSignature.Upload.DbValue = dr["imgInstructorSignature"];
            imgStudentSignature.Upload.DbValue = dr["imgStudentSignature"];
            imgObserverSignature.Upload.DbValue = dr["imgObserverSignature"];
            dt_apptstart.SetDbValue(dr["dt_apptstart"]);
            dt_apptComplete.SetDbValue(dr["dt_apptComplete"]);
            int_apptstartedBy.SetDbValue(dr["int_apptstartedBy"]);
            int_apptCompletedBy.SetDbValue(dr["int_apptCompletedBy"]);
            SMSReminder1.SetDbValue(ConvertToBool(dr["SMSReminder1"]) ? "1" : "0");
            SMSReminder2.SetDbValue(ConvertToBool(dr["SMSReminder2"]) ? "1" : "0");
            SMSReminder3.SetDbValue(ConvertToBool(dr["SMSReminder3"]) ? "1" : "0");
            VoiceReminder1.SetDbValue(ConvertToBool(dr["VoiceReminder1"]) ? "1" : "0");
            VoiceReminder2.SetDbValue(ConvertToBool(dr["VoiceReminder2"]) ? "1" : "0");
            VoiceReminder3.SetDbValue(ConvertToBool(dr["VoiceReminder3"]) ? "1" : "0");
            bit_isroadtest.SetDbValue(ConvertToBool(dr["bit_isroadtest"]) ? "1" : "0");
            int_slotType.SetDbValue(dr["int_slotType"]);
            bit_VisibleOnPortal.SetDbValue(ConvertToBool(dr["bit_VisibleOnPortal"]) ? "1" : "0");
            IsDataRetrieved.SetDbValue(ConvertToBool(dr["IsDataRetrieved"]) ? "1" : "0");
            bit_chargesApplied.SetDbValue(ConvertToBool(dr["bit_chargesApplied"]) ? "1" : "0");
            dec_DistanceTravelled.SetDbValue(dr["dec_DistanceTravelled"]);
            btwProductIdsforSSRules.SetDbValue(dr["btwProductIdsforSSRules"]);
            int_evaluateApptWithEmail.SetDbValue(dr["int_evaluateApptWithEmail"]);
            PublicNotesId.SetDbValue(dr["PublicNotesId"]);
            NationalID.SetDbValue(dr["NationalID"]);
            str_Username.SetDbValue(dr["str_Username"]);
            int_PackageID.SetDbValue(dr["int_PackageID"]);
            int_ApptCldr_ID.SetDbValue(dr["int_ApptCldr_ID"]);
            str_CRSS_ID.SetDbValue(dr["str_CRSS_ID"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "TblAppointmentsInfoList";
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

            // int_Appt_id

            // str_AppName

            // str_App_Date

            // str_StartTime

            // str_EndTime

            // str_PickupTime

            // str_DropOffTime

            // int_VehicleID

            // dec_InstID

            // dec_StudentID

            // dec_Observed_StudentID

            // int_Apptype

            // int_AppStatus

            // mny_AppCost

            // mny_AmountPaid

            // bit_CheckAppPaid

            // bit_Confirmation

            // str_Instructions

            // str_Instructions1

            // str_AppNotes

            // str_PickupLocation

            // int_Created_By

            // int_Modified_By

            // date_Created

            // date_Modified

            // bit_IsDeleted

            // str_Interval

            // RemM1

            // RemM2

            // RemM3

            // int_Location_ID

            // SPID

            // Chk_Trace

            // str_DropOffLocation

            // imgInstructorSignature

            // imgStudentSignature

            // imgObserverSignature

            // dt_apptstart

            // dt_apptComplete

            // int_apptstartedBy

            // int_apptCompletedBy

            // SMSReminder1

            // SMSReminder2

            // SMSReminder3

            // VoiceReminder1

            // VoiceReminder2

            // VoiceReminder3

            // bit_isroadtest

            // int_slotType

            // bit_VisibleOnPortal

            // IsDataRetrieved

            // bit_chargesApplied

            // dec_DistanceTravelled

            // btwProductIdsforSSRules

            // int_evaluateApptWithEmail

            // PublicNotesId

            // NationalID

            // str_Username

            // int_PackageID

            // int_ApptCldr_ID

            // str_CRSS_ID

            // int_Appt_id
            int_Appt_id.ViewValue = int_Appt_id.CurrentValue;
            int_Appt_id.ViewCustomAttributes = "";

            // str_AppName
            str_AppName.ViewValue = ConvertToString(str_AppName.CurrentValue); // DN
            str_AppName.ViewCustomAttributes = "";

            // str_App_Date
            str_App_Date.ViewValue = ConvertToString(str_App_Date.CurrentValue); // DN
            str_App_Date.ViewCustomAttributes = "";

            // str_StartTime
            str_StartTime.ViewValue = ConvertToString(str_StartTime.CurrentValue); // DN
            str_StartTime.ViewCustomAttributes = "";

            // str_EndTime
            str_EndTime.ViewValue = ConvertToString(str_EndTime.CurrentValue); // DN
            str_EndTime.ViewCustomAttributes = "";

            // str_PickupTime
            str_PickupTime.ViewValue = ConvertToString(str_PickupTime.CurrentValue); // DN
            str_PickupTime.ViewCustomAttributes = "";

            // str_DropOffTime
            str_DropOffTime.ViewValue = ConvertToString(str_DropOffTime.CurrentValue); // DN
            str_DropOffTime.ViewCustomAttributes = "";

            // int_VehicleID
            int_VehicleID.ViewValue = int_VehicleID.CurrentValue;
            int_VehicleID.ViewValue = FormatNumber(int_VehicleID.ViewValue, int_VehicleID.FormatPattern);
            int_VehicleID.ViewCustomAttributes = "";

            // dec_InstID
            dec_InstID.ViewValue = dec_InstID.CurrentValue;
            dec_InstID.ViewValue = FormatNumber(dec_InstID.ViewValue, dec_InstID.FormatPattern);
            dec_InstID.ViewCustomAttributes = "";

            // dec_StudentID
            dec_StudentID.ViewValue = dec_StudentID.CurrentValue;
            dec_StudentID.ViewValue = FormatNumber(dec_StudentID.ViewValue, dec_StudentID.FormatPattern);
            dec_StudentID.ViewCustomAttributes = "";

            // dec_Observed_StudentID
            dec_Observed_StudentID.ViewValue = dec_Observed_StudentID.CurrentValue;
            dec_Observed_StudentID.ViewValue = FormatNumber(dec_Observed_StudentID.ViewValue, dec_Observed_StudentID.FormatPattern);
            dec_Observed_StudentID.ViewCustomAttributes = "";

            // int_Apptype
            int_Apptype.ViewValue = int_Apptype.CurrentValue;
            curVal = ConvertToString(int_Apptype.CurrentValue);
            if (!Empty(curVal)) {
                if (int_Apptype.Lookup != null && IsDictionary(int_Apptype.Lookup?.Options) && int_Apptype.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_Apptype.ViewValue = int_Apptype.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[int_AppType]", "=", int_Apptype.CurrentValue, DataType.Number, "");
                    sqlWrk = int_Apptype.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && int_Apptype.Lookup != null) { // Lookup values found
                        var listwrk = int_Apptype.Lookup?.RenderViewRow(rswrk[0]);
                        int_Apptype.ViewValue = int_Apptype.HighlightLookup(ConvertToString(rswrk[0]), int_Apptype.DisplayValue(listwrk));
                    } else {
                        int_Apptype.ViewValue = FormatNumber(int_Apptype.CurrentValue, int_Apptype.FormatPattern);
                    }
                }
            } else {
                int_Apptype.ViewValue = DbNullValue;
            }
            int_Apptype.ViewCustomAttributes = "";

            // int_AppStatus
            if (!Empty(int_AppStatus.CurrentValue)) {
                int_AppStatus.ViewValue = int_AppStatus.HighlightLookup(ConvertToString(int_AppStatus.CurrentValue), int_AppStatus.OptionCaption(ConvertToString(int_AppStatus.CurrentValue)));
            } else {
                int_AppStatus.ViewValue = DbNullValue;
            }
            int_AppStatus.ViewCustomAttributes = "";

            // mny_AppCost
            mny_AppCost.ViewValue = mny_AppCost.CurrentValue;
            mny_AppCost.ViewValue = FormatNumber(mny_AppCost.ViewValue, mny_AppCost.FormatPattern);
            mny_AppCost.ViewCustomAttributes = "";

            // mny_AmountPaid
            mny_AmountPaid.ViewValue = mny_AmountPaid.CurrentValue;
            mny_AmountPaid.ViewValue = FormatNumber(mny_AmountPaid.ViewValue, mny_AmountPaid.FormatPattern);
            mny_AmountPaid.ViewCustomAttributes = "";

            // bit_CheckAppPaid
            if (ConvertToBool(bit_CheckAppPaid.CurrentValue)) {
                bit_CheckAppPaid.ViewValue = bit_CheckAppPaid.TagCaption(1) != "" ? bit_CheckAppPaid.TagCaption(1) : "Yes";
            } else {
                bit_CheckAppPaid.ViewValue = bit_CheckAppPaid.TagCaption(2) != "" ? bit_CheckAppPaid.TagCaption(2) : "No";
            }
            bit_CheckAppPaid.ViewCustomAttributes = "";

            // bit_Confirmation
            if (ConvertToBool(bit_Confirmation.CurrentValue)) {
                bit_Confirmation.ViewValue = bit_Confirmation.TagCaption(1) != "" ? bit_Confirmation.TagCaption(1) : "Yes";
            } else {
                bit_Confirmation.ViewValue = bit_Confirmation.TagCaption(2) != "" ? bit_Confirmation.TagCaption(2) : "No";
            }
            bit_Confirmation.ViewCustomAttributes = "";

            // str_Instructions
            str_Instructions.ViewValue = ConvertToString(str_Instructions.CurrentValue); // DN
            str_Instructions.ViewCustomAttributes = "";

            // str_Instructions1
            str_Instructions1.ViewValue = ConvertToString(str_Instructions1.CurrentValue); // DN
            str_Instructions1.ViewCustomAttributes = "";

            // str_AppNotes
            str_AppNotes.ViewValue = ConvertToString(str_AppNotes.CurrentValue); // DN
            str_AppNotes.ViewCustomAttributes = "";

            // str_PickupLocation
            str_PickupLocation.ViewValue = ConvertToString(str_PickupLocation.CurrentValue); // DN
            str_PickupLocation.ViewCustomAttributes = "";

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

            // str_Interval
            str_Interval.ViewValue = ConvertToString(str_Interval.CurrentValue); // DN
            str_Interval.ViewCustomAttributes = "";

            // RemM1
            if (ConvertToBool(RemM1.CurrentValue)) {
                RemM1.ViewValue = RemM1.TagCaption(1) != "" ? RemM1.TagCaption(1) : "Yes";
            } else {
                RemM1.ViewValue = RemM1.TagCaption(2) != "" ? RemM1.TagCaption(2) : "No";
            }
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

            // int_Location_ID
            int_Location_ID.ViewValue = int_Location_ID.CurrentValue;
            int_Location_ID.ViewValue = FormatNumber(int_Location_ID.ViewValue, int_Location_ID.FormatPattern);
            int_Location_ID.ViewCustomAttributes = "";

            // SPID
            SPID.ViewValue = SPID.CurrentValue;
            SPID.ViewValue = FormatNumber(SPID.ViewValue, SPID.FormatPattern);
            SPID.ViewCustomAttributes = "";

            // Chk_Trace
            Chk_Trace.ViewValue = ConvertToString(Chk_Trace.CurrentValue); // DN
            Chk_Trace.ViewCustomAttributes = "";

            // str_DropOffLocation
            str_DropOffLocation.ViewValue = ConvertToString(str_DropOffLocation.CurrentValue); // DN
            str_DropOffLocation.ViewCustomAttributes = "";

            // imgInstructorSignature
            if (!IsNull(imgInstructorSignature.Upload.DbValue)) {
                imgInstructorSignature.ViewValue = RawUrlEncode(int_Appt_id.CurrentValue);
                imgInstructorSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])imgInstructorSignature.Upload.DbValue));
            } else {
                imgInstructorSignature.ViewValue = "";
            }
            imgInstructorSignature.ViewCustomAttributes = "";

            // imgStudentSignature
            if (!IsNull(imgStudentSignature.Upload.DbValue)) {
                imgStudentSignature.ViewValue = RawUrlEncode(int_Appt_id.CurrentValue);
                imgStudentSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])imgStudentSignature.Upload.DbValue));
            } else {
                imgStudentSignature.ViewValue = "";
            }
            imgStudentSignature.ViewCustomAttributes = "";

            // imgObserverSignature
            if (!IsNull(imgObserverSignature.Upload.DbValue)) {
                imgObserverSignature.ViewValue = RawUrlEncode(int_Appt_id.CurrentValue);
                imgObserverSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])imgObserverSignature.Upload.DbValue));
            } else {
                imgObserverSignature.ViewValue = "";
            }
            imgObserverSignature.ViewCustomAttributes = "";

            // dt_apptstart
            dt_apptstart.ViewValue = dt_apptstart.CurrentValue;
            dt_apptstart.ViewValue = FormatDateTime(dt_apptstart.ViewValue, dt_apptstart.FormatPattern);
            dt_apptstart.ViewCustomAttributes = "";

            // dt_apptComplete
            dt_apptComplete.ViewValue = dt_apptComplete.CurrentValue;
            dt_apptComplete.ViewValue = FormatDateTime(dt_apptComplete.ViewValue, dt_apptComplete.FormatPattern);
            dt_apptComplete.ViewCustomAttributes = "";

            // int_apptstartedBy
            int_apptstartedBy.ViewValue = int_apptstartedBy.CurrentValue;
            int_apptstartedBy.ViewValue = FormatNumber(int_apptstartedBy.ViewValue, int_apptstartedBy.FormatPattern);
            int_apptstartedBy.ViewCustomAttributes = "";

            // int_apptCompletedBy
            int_apptCompletedBy.ViewValue = int_apptCompletedBy.CurrentValue;
            int_apptCompletedBy.ViewValue = FormatNumber(int_apptCompletedBy.ViewValue, int_apptCompletedBy.FormatPattern);
            int_apptCompletedBy.ViewCustomAttributes = "";

            // SMSReminder1
            if (ConvertToBool(SMSReminder1.CurrentValue)) {
                SMSReminder1.ViewValue = SMSReminder1.TagCaption(1) != "" ? SMSReminder1.TagCaption(1) : "Yes";
            } else {
                SMSReminder1.ViewValue = SMSReminder1.TagCaption(2) != "" ? SMSReminder1.TagCaption(2) : "No";
            }
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

            // bit_isroadtest
            if (ConvertToBool(bit_isroadtest.CurrentValue)) {
                bit_isroadtest.ViewValue = bit_isroadtest.TagCaption(1) != "" ? bit_isroadtest.TagCaption(1) : "Yes";
            } else {
                bit_isroadtest.ViewValue = bit_isroadtest.TagCaption(2) != "" ? bit_isroadtest.TagCaption(2) : "No";
            }
            bit_isroadtest.ViewCustomAttributes = "";

            // int_slotType
            int_slotType.ViewValue = int_slotType.CurrentValue;
            int_slotType.ViewValue = FormatNumber(int_slotType.ViewValue, int_slotType.FormatPattern);
            int_slotType.ViewCustomAttributes = "";

            // bit_VisibleOnPortal
            if (ConvertToBool(bit_VisibleOnPortal.CurrentValue)) {
                bit_VisibleOnPortal.ViewValue = bit_VisibleOnPortal.TagCaption(1) != "" ? bit_VisibleOnPortal.TagCaption(1) : "Yes";
            } else {
                bit_VisibleOnPortal.ViewValue = bit_VisibleOnPortal.TagCaption(2) != "" ? bit_VisibleOnPortal.TagCaption(2) : "No";
            }
            bit_VisibleOnPortal.ViewCustomAttributes = "";

            // IsDataRetrieved
            if (ConvertToBool(IsDataRetrieved.CurrentValue)) {
                IsDataRetrieved.ViewValue = IsDataRetrieved.TagCaption(1) != "" ? IsDataRetrieved.TagCaption(1) : "Yes";
            } else {
                IsDataRetrieved.ViewValue = IsDataRetrieved.TagCaption(2) != "" ? IsDataRetrieved.TagCaption(2) : "No";
            }
            IsDataRetrieved.ViewCustomAttributes = "";

            // bit_chargesApplied
            if (ConvertToBool(bit_chargesApplied.CurrentValue)) {
                bit_chargesApplied.ViewValue = bit_chargesApplied.TagCaption(1) != "" ? bit_chargesApplied.TagCaption(1) : "Yes";
            } else {
                bit_chargesApplied.ViewValue = bit_chargesApplied.TagCaption(2) != "" ? bit_chargesApplied.TagCaption(2) : "No";
            }
            bit_chargesApplied.ViewCustomAttributes = "";

            // dec_DistanceTravelled
            dec_DistanceTravelled.ViewValue = dec_DistanceTravelled.CurrentValue;
            dec_DistanceTravelled.ViewValue = FormatNumber(dec_DistanceTravelled.ViewValue, dec_DistanceTravelled.FormatPattern);
            dec_DistanceTravelled.ViewCustomAttributes = "";

            // btwProductIdsforSSRules
            btwProductIdsforSSRules.ViewValue = btwProductIdsforSSRules.CurrentValue;
            btwProductIdsforSSRules.ViewCustomAttributes = "";

            // int_evaluateApptWithEmail
            int_evaluateApptWithEmail.ViewValue = int_evaluateApptWithEmail.CurrentValue;
            int_evaluateApptWithEmail.ViewValue = FormatNumber(int_evaluateApptWithEmail.ViewValue, int_evaluateApptWithEmail.FormatPattern);
            int_evaluateApptWithEmail.ViewCustomAttributes = "";

            // PublicNotesId
            PublicNotesId.ViewValue = PublicNotesId.CurrentValue;
            PublicNotesId.ViewCustomAttributes = "";

            // NationalID
            NationalID.ViewValue = NationalID.CurrentValue;
            NationalID.ViewValue = FormatNumber(NationalID.ViewValue, NationalID.FormatPattern);
            NationalID.ViewCustomAttributes = "";

            // str_Username
            str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
            str_Username.ViewCustomAttributes = "";

            // int_PackageID
            int_PackageID.ViewValue = int_PackageID.CurrentValue;
            int_PackageID.ViewValue = FormatNumber(int_PackageID.ViewValue, int_PackageID.FormatPattern);
            int_PackageID.ViewCustomAttributes = "";

            // int_ApptCldr_ID
            int_ApptCldr_ID.ViewValue = int_ApptCldr_ID.CurrentValue;
            int_ApptCldr_ID.ViewValue = FormatNumber(int_ApptCldr_ID.ViewValue, int_ApptCldr_ID.FormatPattern);
            int_ApptCldr_ID.ViewCustomAttributes = "";

            // str_CRSS_ID
            str_CRSS_ID.ViewValue = ConvertToString(str_CRSS_ID.CurrentValue); // DN
            str_CRSS_ID.ViewCustomAttributes = "";

            // int_Appt_id
            int_Appt_id.HrefValue = "";
            int_Appt_id.TooltipValue = "";

            // str_AppName
            str_AppName.HrefValue = "";
            str_AppName.TooltipValue = "";

            // str_App_Date
            str_App_Date.HrefValue = "";
            str_App_Date.TooltipValue = "";

            // str_StartTime
            str_StartTime.HrefValue = "";
            str_StartTime.TooltipValue = "";

            // str_EndTime
            str_EndTime.HrefValue = "";
            str_EndTime.TooltipValue = "";

            // str_PickupTime
            str_PickupTime.HrefValue = "";
            str_PickupTime.TooltipValue = "";

            // str_DropOffTime
            str_DropOffTime.HrefValue = "";
            str_DropOffTime.TooltipValue = "";

            // int_VehicleID
            int_VehicleID.HrefValue = "";
            int_VehicleID.TooltipValue = "";

            // dec_InstID
            dec_InstID.HrefValue = "";
            dec_InstID.TooltipValue = "";

            // dec_StudentID
            dec_StudentID.HrefValue = "";
            dec_StudentID.TooltipValue = "";

            // dec_Observed_StudentID
            dec_Observed_StudentID.HrefValue = "";
            dec_Observed_StudentID.TooltipValue = "";

            // int_Apptype
            int_Apptype.HrefValue = "";
            int_Apptype.TooltipValue = "";

            // int_AppStatus
            int_AppStatus.HrefValue = "";
            int_AppStatus.TooltipValue = "";

            // mny_AppCost
            mny_AppCost.HrefValue = "";
            mny_AppCost.TooltipValue = "";

            // mny_AmountPaid
            mny_AmountPaid.HrefValue = "";
            mny_AmountPaid.TooltipValue = "";

            // bit_CheckAppPaid
            bit_CheckAppPaid.HrefValue = "";
            bit_CheckAppPaid.TooltipValue = "";

            // bit_Confirmation
            bit_Confirmation.HrefValue = "";
            bit_Confirmation.TooltipValue = "";

            // str_Instructions
            str_Instructions.HrefValue = "";
            str_Instructions.TooltipValue = "";

            // str_Instructions1
            str_Instructions1.HrefValue = "";
            str_Instructions1.TooltipValue = "";

            // str_AppNotes
            str_AppNotes.HrefValue = "";
            str_AppNotes.TooltipValue = "";

            // str_PickupLocation
            str_PickupLocation.HrefValue = "";
            str_PickupLocation.TooltipValue = "";

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

            // str_Interval
            str_Interval.HrefValue = "";
            str_Interval.TooltipValue = "";

            // RemM1
            RemM1.HrefValue = "";
            RemM1.TooltipValue = "";

            // RemM2
            RemM2.HrefValue = "";
            RemM2.TooltipValue = "";

            // RemM3
            RemM3.HrefValue = "";
            RemM3.TooltipValue = "";

            // int_Location_ID
            int_Location_ID.HrefValue = "";
            int_Location_ID.TooltipValue = "";

            // SPID
            SPID.HrefValue = "";
            SPID.TooltipValue = "";

            // Chk_Trace
            Chk_Trace.HrefValue = "";
            Chk_Trace.TooltipValue = "";

            // str_DropOffLocation
            str_DropOffLocation.HrefValue = "";
            str_DropOffLocation.TooltipValue = "";

            // imgInstructorSignature
            if (!IsNull(imgInstructorSignature.Upload.DbValue)) {
                imgInstructorSignature.HrefValue = AppPath(GetFileUploadUrl(imgInstructorSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)))); // DN
                imgInstructorSignature.LinkAttrs["target"] = "";
                if (imgInstructorSignature.IsBlobImage && Empty(imgInstructorSignature.LinkAttrs["target"]))
                    imgInstructorSignature.LinkAttrs["target"] = "_blank";
                if (IsExport())
                    imgInstructorSignature.HrefValue = FullUrl(ConvertToString(imgInstructorSignature.HrefValue), "href");
            } else {
                imgInstructorSignature.HrefValue = "";
            }
            imgInstructorSignature.ExportHrefValue = GetFileUploadUrl(imgInstructorSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)));
            imgInstructorSignature.TooltipValue = "";

            // imgStudentSignature
            if (!IsNull(imgStudentSignature.Upload.DbValue)) {
                imgStudentSignature.HrefValue = AppPath(GetFileUploadUrl(imgStudentSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)))); // DN
                imgStudentSignature.LinkAttrs["target"] = "";
                if (imgStudentSignature.IsBlobImage && Empty(imgStudentSignature.LinkAttrs["target"]))
                    imgStudentSignature.LinkAttrs["target"] = "_blank";
                if (IsExport())
                    imgStudentSignature.HrefValue = FullUrl(ConvertToString(imgStudentSignature.HrefValue), "href");
            } else {
                imgStudentSignature.HrefValue = "";
            }
            imgStudentSignature.ExportHrefValue = GetFileUploadUrl(imgStudentSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)));
            imgStudentSignature.TooltipValue = "";

            // imgObserverSignature
            if (!IsNull(imgObserverSignature.Upload.DbValue)) {
                imgObserverSignature.HrefValue = AppPath(GetFileUploadUrl(imgObserverSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)))); // DN
                imgObserverSignature.LinkAttrs["target"] = "";
                if (imgObserverSignature.IsBlobImage && Empty(imgObserverSignature.LinkAttrs["target"]))
                    imgObserverSignature.LinkAttrs["target"] = "_blank";
                if (IsExport())
                    imgObserverSignature.HrefValue = FullUrl(ConvertToString(imgObserverSignature.HrefValue), "href");
            } else {
                imgObserverSignature.HrefValue = "";
            }
            imgObserverSignature.ExportHrefValue = GetFileUploadUrl(imgObserverSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)));
            imgObserverSignature.TooltipValue = "";

            // dt_apptstart
            dt_apptstart.HrefValue = "";
            dt_apptstart.TooltipValue = "";

            // dt_apptComplete
            dt_apptComplete.HrefValue = "";
            dt_apptComplete.TooltipValue = "";

            // int_apptstartedBy
            int_apptstartedBy.HrefValue = "";
            int_apptstartedBy.TooltipValue = "";

            // int_apptCompletedBy
            int_apptCompletedBy.HrefValue = "";
            int_apptCompletedBy.TooltipValue = "";

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

            // bit_isroadtest
            bit_isroadtest.HrefValue = "";
            bit_isroadtest.TooltipValue = "";

            // int_slotType
            int_slotType.HrefValue = "";
            int_slotType.TooltipValue = "";

            // bit_VisibleOnPortal
            bit_VisibleOnPortal.HrefValue = "";
            bit_VisibleOnPortal.TooltipValue = "";

            // IsDataRetrieved
            IsDataRetrieved.HrefValue = "";
            IsDataRetrieved.TooltipValue = "";

            // bit_chargesApplied
            bit_chargesApplied.HrefValue = "";
            bit_chargesApplied.TooltipValue = "";

            // dec_DistanceTravelled
            dec_DistanceTravelled.HrefValue = "";
            dec_DistanceTravelled.TooltipValue = "";

            // btwProductIdsforSSRules
            btwProductIdsforSSRules.HrefValue = "";
            btwProductIdsforSSRules.TooltipValue = "";

            // int_evaluateApptWithEmail
            int_evaluateApptWithEmail.HrefValue = "";
            int_evaluateApptWithEmail.TooltipValue = "";

            // PublicNotesId
            PublicNotesId.HrefValue = "";
            PublicNotesId.TooltipValue = "";

            // NationalID
            NationalID.HrefValue = "";
            NationalID.TooltipValue = "";

            // str_Username
            str_Username.HrefValue = "";
            str_Username.TooltipValue = "";

            // int_PackageID
            int_PackageID.HrefValue = "";
            int_PackageID.TooltipValue = "";

            // int_ApptCldr_ID
            int_ApptCldr_ID.HrefValue = "";
            int_ApptCldr_ID.TooltipValue = "";

            // str_CRSS_ID
            str_CRSS_ID.HrefValue = "";
            str_CRSS_ID.TooltipValue = "";

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

            // int_Appt_id
            int_Appt_id.SetupEditAttributes();
            int_Appt_id.EditValue = int_Appt_id.CurrentValue;
            int_Appt_id.ViewCustomAttributes = "";

            // str_AppName
            str_AppName.SetupEditAttributes();
            if (!str_AppName.Raw)
                str_AppName.CurrentValue = HtmlDecode(str_AppName.CurrentValue);
            str_AppName.EditValue = HtmlEncode(str_AppName.CurrentValue);
            str_AppName.PlaceHolder = RemoveHtml(str_AppName.Caption);

            // str_App_Date
            str_App_Date.SetupEditAttributes();
            if (!str_App_Date.Raw)
                str_App_Date.CurrentValue = HtmlDecode(str_App_Date.CurrentValue);
            str_App_Date.EditValue = HtmlEncode(str_App_Date.CurrentValue);
            str_App_Date.PlaceHolder = RemoveHtml(str_App_Date.Caption);

            // str_StartTime
            str_StartTime.SetupEditAttributes();
            if (!str_StartTime.Raw)
                str_StartTime.CurrentValue = HtmlDecode(str_StartTime.CurrentValue);
            str_StartTime.EditValue = HtmlEncode(str_StartTime.CurrentValue);
            str_StartTime.PlaceHolder = RemoveHtml(str_StartTime.Caption);

            // str_EndTime
            str_EndTime.SetupEditAttributes();
            if (!str_EndTime.Raw)
                str_EndTime.CurrentValue = HtmlDecode(str_EndTime.CurrentValue);
            str_EndTime.EditValue = HtmlEncode(str_EndTime.CurrentValue);
            str_EndTime.PlaceHolder = RemoveHtml(str_EndTime.Caption);

            // str_PickupTime
            str_PickupTime.SetupEditAttributes();
            if (!str_PickupTime.Raw)
                str_PickupTime.CurrentValue = HtmlDecode(str_PickupTime.CurrentValue);
            str_PickupTime.EditValue = HtmlEncode(str_PickupTime.CurrentValue);
            str_PickupTime.PlaceHolder = RemoveHtml(str_PickupTime.Caption);

            // str_DropOffTime
            str_DropOffTime.SetupEditAttributes();
            if (!str_DropOffTime.Raw)
                str_DropOffTime.CurrentValue = HtmlDecode(str_DropOffTime.CurrentValue);
            str_DropOffTime.EditValue = HtmlEncode(str_DropOffTime.CurrentValue);
            str_DropOffTime.PlaceHolder = RemoveHtml(str_DropOffTime.Caption);

            // int_VehicleID
            int_VehicleID.SetupEditAttributes();
            int_VehicleID.EditValue = int_VehicleID.CurrentValue; // DN
            int_VehicleID.PlaceHolder = RemoveHtml(int_VehicleID.Caption);
            if (!Empty(int_VehicleID.EditValue) && IsNumeric(int_VehicleID.EditValue))
                int_VehicleID.EditValue = FormatNumber(int_VehicleID.EditValue, null);

            // dec_InstID
            dec_InstID.SetupEditAttributes();
            dec_InstID.EditValue = dec_InstID.CurrentValue; // DN
            dec_InstID.PlaceHolder = RemoveHtml(dec_InstID.Caption);
            if (!Empty(dec_InstID.EditValue) && IsNumeric(dec_InstID.EditValue))
                dec_InstID.EditValue = FormatNumber(dec_InstID.EditValue, null);

            // dec_StudentID
            dec_StudentID.SetupEditAttributes();
            dec_StudentID.EditValue = dec_StudentID.CurrentValue; // DN
            dec_StudentID.PlaceHolder = RemoveHtml(dec_StudentID.Caption);
            if (!Empty(dec_StudentID.EditValue) && IsNumeric(dec_StudentID.EditValue))
                dec_StudentID.EditValue = FormatNumber(dec_StudentID.EditValue, null);

            // dec_Observed_StudentID
            dec_Observed_StudentID.SetupEditAttributes();
            dec_Observed_StudentID.EditValue = dec_Observed_StudentID.CurrentValue; // DN
            dec_Observed_StudentID.PlaceHolder = RemoveHtml(dec_Observed_StudentID.Caption);
            if (!Empty(dec_Observed_StudentID.EditValue) && IsNumeric(dec_Observed_StudentID.EditValue))
                dec_Observed_StudentID.EditValue = FormatNumber(dec_Observed_StudentID.EditValue, null);

            // int_Apptype
            int_Apptype.SetupEditAttributes();
            int_Apptype.EditValue = int_Apptype.CurrentValue;
            curVal = ConvertToString(int_Apptype.CurrentValue);
            if (!Empty(curVal)) {
                if (int_Apptype.Lookup != null && IsDictionary(int_Apptype.Lookup?.Options) && int_Apptype.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_Apptype.EditValue = int_Apptype.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[int_AppType]", "=", int_Apptype.CurrentValue, DataType.Number, "");
                    sqlWrk = int_Apptype.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && int_Apptype.Lookup != null) { // Lookup values found
                        var listwrk = int_Apptype.Lookup?.RenderViewRow(rswrk[0]);
                        int_Apptype.EditValue = int_Apptype.HighlightLookup(ConvertToString(rswrk[0]), int_Apptype.DisplayValue(listwrk));
                    } else {
                        int_Apptype.EditValue = FormatNumber(int_Apptype.CurrentValue, int_Apptype.FormatPattern);
                    }
                }
            } else {
                int_Apptype.EditValue = DbNullValue;
            }
            int_Apptype.ViewCustomAttributes = "";

            // int_AppStatus
            int_AppStatus.SetupEditAttributes();
            int_AppStatus.EditValue = int_AppStatus.Options(true);
            int_AppStatus.PlaceHolder = RemoveHtml(int_AppStatus.Caption);
            if (!Empty(int_AppStatus.EditValue) && IsNumeric(int_AppStatus.EditValue))
                int_AppStatus.EditValue = FormatNumber(int_AppStatus.EditValue, null);

            // mny_AppCost
            mny_AppCost.SetupEditAttributes();
            mny_AppCost.EditValue = mny_AppCost.CurrentValue;
            mny_AppCost.EditValue = FormatNumber(mny_AppCost.EditValue, mny_AppCost.FormatPattern);
            mny_AppCost.ViewCustomAttributes = "";

            // mny_AmountPaid
            mny_AmountPaid.SetupEditAttributes();
            mny_AmountPaid.EditValue = mny_AmountPaid.CurrentValue;
            mny_AmountPaid.EditValue = FormatNumber(mny_AmountPaid.EditValue, mny_AmountPaid.FormatPattern);
            mny_AmountPaid.ViewCustomAttributes = "";

            // bit_CheckAppPaid
            bit_CheckAppPaid.EditValue = bit_CheckAppPaid.Options(false);
            bit_CheckAppPaid.PlaceHolder = RemoveHtml(bit_CheckAppPaid.Caption);

            // bit_Confirmation
            bit_Confirmation.EditValue = bit_Confirmation.Options(false);
            bit_Confirmation.PlaceHolder = RemoveHtml(bit_Confirmation.Caption);

            // str_Instructions
            str_Instructions.SetupEditAttributes();
            if (!str_Instructions.Raw)
                str_Instructions.CurrentValue = HtmlDecode(str_Instructions.CurrentValue);
            str_Instructions.EditValue = HtmlEncode(str_Instructions.CurrentValue);
            str_Instructions.PlaceHolder = RemoveHtml(str_Instructions.Caption);

            // str_Instructions1
            str_Instructions1.SetupEditAttributes();
            if (!str_Instructions1.Raw)
                str_Instructions1.CurrentValue = HtmlDecode(str_Instructions1.CurrentValue);
            str_Instructions1.EditValue = HtmlEncode(str_Instructions1.CurrentValue);
            str_Instructions1.PlaceHolder = RemoveHtml(str_Instructions1.Caption);

            // str_AppNotes
            str_AppNotes.SetupEditAttributes();
            if (!str_AppNotes.Raw)
                str_AppNotes.CurrentValue = HtmlDecode(str_AppNotes.CurrentValue);
            str_AppNotes.EditValue = HtmlEncode(str_AppNotes.CurrentValue);
            str_AppNotes.PlaceHolder = RemoveHtml(str_AppNotes.Caption);

            // str_PickupLocation
            str_PickupLocation.SetupEditAttributes();
            if (!str_PickupLocation.Raw)
                str_PickupLocation.CurrentValue = HtmlDecode(str_PickupLocation.CurrentValue);
            str_PickupLocation.EditValue = HtmlEncode(str_PickupLocation.CurrentValue);
            str_PickupLocation.PlaceHolder = RemoveHtml(str_PickupLocation.Caption);

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

            // date_Modified

            // bit_IsDeleted
            bit_IsDeleted.EditValue = bit_IsDeleted.Options(false);
            bit_IsDeleted.PlaceHolder = RemoveHtml(bit_IsDeleted.Caption);

            // str_Interval
            str_Interval.SetupEditAttributes();
            if (!str_Interval.Raw)
                str_Interval.CurrentValue = HtmlDecode(str_Interval.CurrentValue);
            str_Interval.EditValue = HtmlEncode(str_Interval.CurrentValue);
            str_Interval.PlaceHolder = RemoveHtml(str_Interval.Caption);

            // RemM1
            RemM1.EditValue = RemM1.Options(false);
            RemM1.PlaceHolder = RemoveHtml(RemM1.Caption);

            // RemM2
            RemM2.EditValue = RemM2.Options(false);
            RemM2.PlaceHolder = RemoveHtml(RemM2.Caption);

            // RemM3
            RemM3.EditValue = RemM3.Options(false);
            RemM3.PlaceHolder = RemoveHtml(RemM3.Caption);

            // int_Location_ID
            int_Location_ID.SetupEditAttributes();
            int_Location_ID.EditValue = int_Location_ID.CurrentValue; // DN
            int_Location_ID.PlaceHolder = RemoveHtml(int_Location_ID.Caption);
            if (!Empty(int_Location_ID.EditValue) && IsNumeric(int_Location_ID.EditValue))
                int_Location_ID.EditValue = FormatNumber(int_Location_ID.EditValue, null);

            // SPID
            SPID.SetupEditAttributes();
            SPID.EditValue = SPID.CurrentValue; // DN
            SPID.PlaceHolder = RemoveHtml(SPID.Caption);
            if (!Empty(SPID.EditValue) && IsNumeric(SPID.EditValue))
                SPID.EditValue = FormatNumber(SPID.EditValue, null);

            // Chk_Trace
            Chk_Trace.SetupEditAttributes();
            if (!Chk_Trace.Raw)
                Chk_Trace.CurrentValue = HtmlDecode(Chk_Trace.CurrentValue);
            Chk_Trace.EditValue = HtmlEncode(Chk_Trace.CurrentValue);
            Chk_Trace.PlaceHolder = RemoveHtml(Chk_Trace.Caption);

            // str_DropOffLocation
            str_DropOffLocation.SetupEditAttributes();
            if (!str_DropOffLocation.Raw)
                str_DropOffLocation.CurrentValue = HtmlDecode(str_DropOffLocation.CurrentValue);
            str_DropOffLocation.EditValue = HtmlEncode(str_DropOffLocation.CurrentValue);
            str_DropOffLocation.PlaceHolder = RemoveHtml(str_DropOffLocation.Caption);

            // imgInstructorSignature
            imgInstructorSignature.SetupEditAttributes();
            if (!IsNull(imgInstructorSignature.Upload.DbValue)) {
                imgInstructorSignature.EditValue = RawUrlEncode(int_Appt_id.CurrentValue);
                imgInstructorSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])imgInstructorSignature.Upload.DbValue));
            } else {
                imgInstructorSignature.EditValue = "";
            }

            // imgStudentSignature
            imgStudentSignature.SetupEditAttributes();
            if (!IsNull(imgStudentSignature.Upload.DbValue)) {
                imgStudentSignature.EditValue = RawUrlEncode(int_Appt_id.CurrentValue);
                imgStudentSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])imgStudentSignature.Upload.DbValue));
            } else {
                imgStudentSignature.EditValue = "";
            }

            // imgObserverSignature
            imgObserverSignature.SetupEditAttributes();
            if (!IsNull(imgObserverSignature.Upload.DbValue)) {
                imgObserverSignature.EditValue = RawUrlEncode(int_Appt_id.CurrentValue);
                imgObserverSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])imgObserverSignature.Upload.DbValue));
            } else {
                imgObserverSignature.EditValue = "";
            }

            // dt_apptstart
            dt_apptstart.SetupEditAttributes();
            dt_apptstart.EditValue = FormatDateTime(dt_apptstart.CurrentValue, dt_apptstart.FormatPattern); // DN
            dt_apptstart.PlaceHolder = RemoveHtml(dt_apptstart.Caption);

            // dt_apptComplete
            dt_apptComplete.SetupEditAttributes();
            dt_apptComplete.EditValue = FormatDateTime(dt_apptComplete.CurrentValue, dt_apptComplete.FormatPattern); // DN
            dt_apptComplete.PlaceHolder = RemoveHtml(dt_apptComplete.Caption);

            // int_apptstartedBy
            int_apptstartedBy.SetupEditAttributes();
            int_apptstartedBy.EditValue = int_apptstartedBy.CurrentValue; // DN
            int_apptstartedBy.PlaceHolder = RemoveHtml(int_apptstartedBy.Caption);
            if (!Empty(int_apptstartedBy.EditValue) && IsNumeric(int_apptstartedBy.EditValue))
                int_apptstartedBy.EditValue = FormatNumber(int_apptstartedBy.EditValue, null);

            // int_apptCompletedBy
            int_apptCompletedBy.SetupEditAttributes();
            int_apptCompletedBy.EditValue = int_apptCompletedBy.CurrentValue; // DN
            int_apptCompletedBy.PlaceHolder = RemoveHtml(int_apptCompletedBy.Caption);
            if (!Empty(int_apptCompletedBy.EditValue) && IsNumeric(int_apptCompletedBy.EditValue))
                int_apptCompletedBy.EditValue = FormatNumber(int_apptCompletedBy.EditValue, null);

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

            // bit_isroadtest
            bit_isroadtest.EditValue = bit_isroadtest.Options(false);
            bit_isroadtest.PlaceHolder = RemoveHtml(bit_isroadtest.Caption);

            // int_slotType
            int_slotType.SetupEditAttributes();
            int_slotType.EditValue = int_slotType.CurrentValue; // DN
            int_slotType.PlaceHolder = RemoveHtml(int_slotType.Caption);
            if (!Empty(int_slotType.EditValue) && IsNumeric(int_slotType.EditValue))
                int_slotType.EditValue = FormatNumber(int_slotType.EditValue, null);

            // bit_VisibleOnPortal
            bit_VisibleOnPortal.EditValue = bit_VisibleOnPortal.Options(false);
            bit_VisibleOnPortal.PlaceHolder = RemoveHtml(bit_VisibleOnPortal.Caption);

            // IsDataRetrieved
            IsDataRetrieved.EditValue = IsDataRetrieved.Options(false);
            IsDataRetrieved.PlaceHolder = RemoveHtml(IsDataRetrieved.Caption);

            // bit_chargesApplied
            bit_chargesApplied.EditValue = bit_chargesApplied.Options(false);
            bit_chargesApplied.PlaceHolder = RemoveHtml(bit_chargesApplied.Caption);

            // dec_DistanceTravelled
            dec_DistanceTravelled.SetupEditAttributes();
            dec_DistanceTravelled.EditValue = dec_DistanceTravelled.CurrentValue; // DN
            dec_DistanceTravelled.PlaceHolder = RemoveHtml(dec_DistanceTravelled.Caption);
            if (!Empty(dec_DistanceTravelled.EditValue) && IsNumeric(dec_DistanceTravelled.EditValue))
                dec_DistanceTravelled.EditValue = FormatNumber(dec_DistanceTravelled.EditValue, null);

            // btwProductIdsforSSRules
            btwProductIdsforSSRules.SetupEditAttributes();
            btwProductIdsforSSRules.EditValue = btwProductIdsforSSRules.CurrentValue; // DN
            btwProductIdsforSSRules.PlaceHolder = RemoveHtml(btwProductIdsforSSRules.Caption);

            // int_evaluateApptWithEmail
            int_evaluateApptWithEmail.SetupEditAttributes();
            int_evaluateApptWithEmail.EditValue = int_evaluateApptWithEmail.CurrentValue; // DN
            int_evaluateApptWithEmail.PlaceHolder = RemoveHtml(int_evaluateApptWithEmail.Caption);
            if (!Empty(int_evaluateApptWithEmail.EditValue) && IsNumeric(int_evaluateApptWithEmail.EditValue))
                int_evaluateApptWithEmail.EditValue = FormatNumber(int_evaluateApptWithEmail.EditValue, null);

            // PublicNotesId
            PublicNotesId.SetupEditAttributes();
            PublicNotesId.EditValue = PublicNotesId.CurrentValue; // DN
            PublicNotesId.PlaceHolder = RemoveHtml(PublicNotesId.Caption);

            // NationalID
            NationalID.SetupEditAttributes();
            NationalID.EditValue = NationalID.CurrentValue;
            NationalID.EditValue = FormatNumber(NationalID.EditValue, NationalID.FormatPattern);
            NationalID.ViewCustomAttributes = "";

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

            // int_PackageID
            int_PackageID.SetupEditAttributes();
            int_PackageID.EditValue = int_PackageID.CurrentValue; // DN
            int_PackageID.PlaceHolder = RemoveHtml(int_PackageID.Caption);
            if (!Empty(int_PackageID.EditValue) && IsNumeric(int_PackageID.EditValue))
                int_PackageID.EditValue = FormatNumber(int_PackageID.EditValue, null);

            // int_ApptCldr_ID
            int_ApptCldr_ID.SetupEditAttributes();
            int_ApptCldr_ID.EditValue = int_ApptCldr_ID.CurrentValue; // DN
            int_ApptCldr_ID.PlaceHolder = RemoveHtml(int_ApptCldr_ID.Caption);
            if (!Empty(int_ApptCldr_ID.EditValue) && IsNumeric(int_ApptCldr_ID.EditValue))
                int_ApptCldr_ID.EditValue = FormatNumber(int_ApptCldr_ID.EditValue, null);

            // str_CRSS_ID
            str_CRSS_ID.SetupEditAttributes();
            if (!str_CRSS_ID.Raw)
                str_CRSS_ID.CurrentValue = HtmlDecode(str_CRSS_ID.CurrentValue);
            str_CRSS_ID.EditValue = HtmlEncode(str_CRSS_ID.CurrentValue);
            str_CRSS_ID.PlaceHolder = RemoveHtml(str_CRSS_ID.Caption);

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
                        doc.ExportCaption(int_Appt_id);
                        doc.ExportCaption(str_AppName);
                        doc.ExportCaption(str_App_Date);
                        doc.ExportCaption(str_StartTime);
                        doc.ExportCaption(str_EndTime);
                        doc.ExportCaption(str_PickupTime);
                        doc.ExportCaption(str_DropOffTime);
                        doc.ExportCaption(int_VehicleID);
                        doc.ExportCaption(dec_InstID);
                        doc.ExportCaption(dec_StudentID);
                        doc.ExportCaption(dec_Observed_StudentID);
                        doc.ExportCaption(int_Apptype);
                        doc.ExportCaption(int_AppStatus);
                        doc.ExportCaption(mny_AppCost);
                        doc.ExportCaption(mny_AmountPaid);
                        doc.ExportCaption(bit_CheckAppPaid);
                        doc.ExportCaption(bit_Confirmation);
                        doc.ExportCaption(str_Instructions);
                        doc.ExportCaption(str_Instructions1);
                        doc.ExportCaption(str_AppNotes);
                        doc.ExportCaption(str_PickupLocation);
                        doc.ExportCaption(int_Created_By);
                        doc.ExportCaption(int_Modified_By);
                        doc.ExportCaption(bit_IsDeleted);
                        doc.ExportCaption(str_Interval);
                        doc.ExportCaption(RemM1);
                        doc.ExportCaption(RemM2);
                        doc.ExportCaption(RemM3);
                        doc.ExportCaption(int_Location_ID);
                        doc.ExportCaption(SPID);
                        doc.ExportCaption(Chk_Trace);
                        doc.ExportCaption(str_DropOffLocation);
                        doc.ExportCaption(imgInstructorSignature);
                        doc.ExportCaption(imgStudentSignature);
                        doc.ExportCaption(imgObserverSignature);
                        doc.ExportCaption(dt_apptstart);
                        doc.ExportCaption(dt_apptComplete);
                        doc.ExportCaption(int_apptstartedBy);
                        doc.ExportCaption(int_apptCompletedBy);
                        doc.ExportCaption(SMSReminder1);
                        doc.ExportCaption(SMSReminder2);
                        doc.ExportCaption(SMSReminder3);
                        doc.ExportCaption(VoiceReminder1);
                        doc.ExportCaption(VoiceReminder2);
                        doc.ExportCaption(VoiceReminder3);
                        doc.ExportCaption(bit_isroadtest);
                        doc.ExportCaption(int_slotType);
                        doc.ExportCaption(bit_VisibleOnPortal);
                        doc.ExportCaption(IsDataRetrieved);
                        doc.ExportCaption(bit_chargesApplied);
                        doc.ExportCaption(dec_DistanceTravelled);
                        doc.ExportCaption(btwProductIdsforSSRules);
                        doc.ExportCaption(int_evaluateApptWithEmail);
                        doc.ExportCaption(PublicNotesId);
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(int_PackageID);
                        doc.ExportCaption(int_ApptCldr_ID);
                        doc.ExportCaption(str_CRSS_ID);
                    } else {
                        doc.ExportCaption(int_Appt_id);
                        doc.ExportCaption(str_AppName);
                        doc.ExportCaption(str_App_Date);
                        doc.ExportCaption(str_StartTime);
                        doc.ExportCaption(str_EndTime);
                        doc.ExportCaption(str_PickupTime);
                        doc.ExportCaption(str_DropOffTime);
                        doc.ExportCaption(int_VehicleID);
                        doc.ExportCaption(dec_InstID);
                        doc.ExportCaption(dec_StudentID);
                        doc.ExportCaption(dec_Observed_StudentID);
                        doc.ExportCaption(int_Apptype);
                        doc.ExportCaption(int_AppStatus);
                        doc.ExportCaption(mny_AppCost);
                        doc.ExportCaption(mny_AmountPaid);
                        doc.ExportCaption(bit_CheckAppPaid);
                        doc.ExportCaption(bit_Confirmation);
                        doc.ExportCaption(str_Instructions);
                        doc.ExportCaption(str_Instructions1);
                        doc.ExportCaption(str_AppNotes);
                        doc.ExportCaption(str_PickupLocation);
                        doc.ExportCaption(int_Created_By);
                        doc.ExportCaption(int_Modified_By);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(bit_IsDeleted);
                        doc.ExportCaption(str_Interval);
                        doc.ExportCaption(RemM1);
                        doc.ExportCaption(RemM2);
                        doc.ExportCaption(RemM3);
                        doc.ExportCaption(int_Location_ID);
                        doc.ExportCaption(SPID);
                        doc.ExportCaption(Chk_Trace);
                        doc.ExportCaption(str_DropOffLocation);
                        doc.ExportCaption(dt_apptstart);
                        doc.ExportCaption(dt_apptComplete);
                        doc.ExportCaption(int_apptstartedBy);
                        doc.ExportCaption(int_apptCompletedBy);
                        doc.ExportCaption(SMSReminder1);
                        doc.ExportCaption(SMSReminder2);
                        doc.ExportCaption(SMSReminder3);
                        doc.ExportCaption(VoiceReminder1);
                        doc.ExportCaption(VoiceReminder2);
                        doc.ExportCaption(VoiceReminder3);
                        doc.ExportCaption(bit_isroadtest);
                        doc.ExportCaption(int_slotType);
                        doc.ExportCaption(bit_VisibleOnPortal);
                        doc.ExportCaption(IsDataRetrieved);
                        doc.ExportCaption(bit_chargesApplied);
                        doc.ExportCaption(dec_DistanceTravelled);
                        doc.ExportCaption(int_evaluateApptWithEmail);
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(int_PackageID);
                        doc.ExportCaption(int_ApptCldr_ID);
                        doc.ExportCaption(str_CRSS_ID);
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
                            await doc.ExportField(int_Appt_id);
                            await doc.ExportField(str_AppName);
                            await doc.ExportField(str_App_Date);
                            await doc.ExportField(str_StartTime);
                            await doc.ExportField(str_EndTime);
                            await doc.ExportField(str_PickupTime);
                            await doc.ExportField(str_DropOffTime);
                            await doc.ExportField(int_VehicleID);
                            await doc.ExportField(dec_InstID);
                            await doc.ExportField(dec_StudentID);
                            await doc.ExportField(dec_Observed_StudentID);
                            await doc.ExportField(int_Apptype);
                            await doc.ExportField(int_AppStatus);
                            await doc.ExportField(mny_AppCost);
                            await doc.ExportField(mny_AmountPaid);
                            await doc.ExportField(bit_CheckAppPaid);
                            await doc.ExportField(bit_Confirmation);
                            await doc.ExportField(str_Instructions);
                            await doc.ExportField(str_Instructions1);
                            await doc.ExportField(str_AppNotes);
                            await doc.ExportField(str_PickupLocation);
                            await doc.ExportField(int_Created_By);
                            await doc.ExportField(int_Modified_By);
                            await doc.ExportField(bit_IsDeleted);
                            await doc.ExportField(str_Interval);
                            await doc.ExportField(RemM1);
                            await doc.ExportField(RemM2);
                            await doc.ExportField(RemM3);
                            await doc.ExportField(int_Location_ID);
                            await doc.ExportField(SPID);
                            await doc.ExportField(Chk_Trace);
                            await doc.ExportField(str_DropOffLocation);
                            await doc.ExportField(imgInstructorSignature);
                            await doc.ExportField(imgStudentSignature);
                            await doc.ExportField(imgObserverSignature);
                            await doc.ExportField(dt_apptstart);
                            await doc.ExportField(dt_apptComplete);
                            await doc.ExportField(int_apptstartedBy);
                            await doc.ExportField(int_apptCompletedBy);
                            await doc.ExportField(SMSReminder1);
                            await doc.ExportField(SMSReminder2);
                            await doc.ExportField(SMSReminder3);
                            await doc.ExportField(VoiceReminder1);
                            await doc.ExportField(VoiceReminder2);
                            await doc.ExportField(VoiceReminder3);
                            await doc.ExportField(bit_isroadtest);
                            await doc.ExportField(int_slotType);
                            await doc.ExportField(bit_VisibleOnPortal);
                            await doc.ExportField(IsDataRetrieved);
                            await doc.ExportField(bit_chargesApplied);
                            await doc.ExportField(dec_DistanceTravelled);
                            await doc.ExportField(btwProductIdsforSSRules);
                            await doc.ExportField(int_evaluateApptWithEmail);
                            await doc.ExportField(PublicNotesId);
                            await doc.ExportField(NationalID);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(int_PackageID);
                            await doc.ExportField(int_ApptCldr_ID);
                            await doc.ExportField(str_CRSS_ID);
                        } else {
                            await doc.ExportField(int_Appt_id);
                            await doc.ExportField(str_AppName);
                            await doc.ExportField(str_App_Date);
                            await doc.ExportField(str_StartTime);
                            await doc.ExportField(str_EndTime);
                            await doc.ExportField(str_PickupTime);
                            await doc.ExportField(str_DropOffTime);
                            await doc.ExportField(int_VehicleID);
                            await doc.ExportField(dec_InstID);
                            await doc.ExportField(dec_StudentID);
                            await doc.ExportField(dec_Observed_StudentID);
                            await doc.ExportField(int_Apptype);
                            await doc.ExportField(int_AppStatus);
                            await doc.ExportField(mny_AppCost);
                            await doc.ExportField(mny_AmountPaid);
                            await doc.ExportField(bit_CheckAppPaid);
                            await doc.ExportField(bit_Confirmation);
                            await doc.ExportField(str_Instructions);
                            await doc.ExportField(str_Instructions1);
                            await doc.ExportField(str_AppNotes);
                            await doc.ExportField(str_PickupLocation);
                            await doc.ExportField(int_Created_By);
                            await doc.ExportField(int_Modified_By);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(bit_IsDeleted);
                            await doc.ExportField(str_Interval);
                            await doc.ExportField(RemM1);
                            await doc.ExportField(RemM2);
                            await doc.ExportField(RemM3);
                            await doc.ExportField(int_Location_ID);
                            await doc.ExportField(SPID);
                            await doc.ExportField(Chk_Trace);
                            await doc.ExportField(str_DropOffLocation);
                            await doc.ExportField(dt_apptstart);
                            await doc.ExportField(dt_apptComplete);
                            await doc.ExportField(int_apptstartedBy);
                            await doc.ExportField(int_apptCompletedBy);
                            await doc.ExportField(SMSReminder1);
                            await doc.ExportField(SMSReminder2);
                            await doc.ExportField(SMSReminder3);
                            await doc.ExportField(VoiceReminder1);
                            await doc.ExportField(VoiceReminder2);
                            await doc.ExportField(VoiceReminder3);
                            await doc.ExportField(bit_isroadtest);
                            await doc.ExportField(int_slotType);
                            await doc.ExportField(bit_VisibleOnPortal);
                            await doc.ExportField(IsDataRetrieved);
                            await doc.ExportField(bit_chargesApplied);
                            await doc.ExportField(dec_DistanceTravelled);
                            await doc.ExportField(int_evaluateApptWithEmail);
                            await doc.ExportField(NationalID);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(int_PackageID);
                            await doc.ExportField(int_ApptCldr_ID);
                            await doc.ExportField(str_CRSS_ID);
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

        // User ID subquery
        public string GetUserIDSubquery(DbField fld, DbField masterfld)
        {
            string wrk = "";
            string sql = "SELECT " + masterfld.Expression + " FROM dbo.tblAppointmentsInfo";
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

            // Set up field names
            string fldName = "", fileNameFld = "", fileTypeFld = "";
            if (SameText(fldparm, "imgInstructorSignature")) {
                fldName = "imgInstructorSignature";
            } else if (SameText(fldparm, "imgStudentSignature")) {
                fldName = "imgStudentSignature";
            } else if (SameText(fldparm, "imgObserverSignature")) {
                fldName = "imgObserverSignature";
            } else {
                return JsonBoolResult.FalseResult; // Incorrect field
            }

            // Set up key values
            if (keys.Length == 1) {
                int_Appt_id.CurrentValue = keys[0];
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
        public async Task WriteAuditTrailLog(string log) => await WriteAuditTrailAsync(CurrentUser(), log, "tblAppointmentsInfo");

        // Write audit trail (add page)
        public async Task WriteAuditTrailOnAdd(IDictionary<string, object> rs)
        {
            if (!AuditTrailOnAdd)
                return;
            string table = "tblAppointmentsInfo";

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
            string table = "tblAppointmentsInfo";

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
            string table = "tblAppointmentsInfo";

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
            string table = "tblAppointmentsInfo";
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
