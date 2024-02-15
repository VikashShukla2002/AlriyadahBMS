namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblAssessment
    /// </summary>
    [MaybeNull]
    public static TblAssessment tblAssessment
    {
        get => HttpData.Resolve<TblAssessment>("tblAssessment");
        set => HttpData["tblAssessment"] = value;
    }

    /// <summary>
    /// Table class for tblAssessment
    /// </summary>
    public class TblAssessment : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> AssessmentID;

        public readonly DbField<SqlDbType> str_Full_Name_Hdr;

        public readonly DbField<SqlDbType> str_First_Name;

        public readonly DbField<SqlDbType> str_Middle_Name;

        public readonly DbField<SqlDbType> str_Last_Name;

        public readonly DbField<SqlDbType> str_Username;

        public readonly DbField<SqlDbType> int_Student_ID;

        public readonly DbField<SqlDbType> NationalID;

        public readonly DbField<SqlDbType> Assessment_Type;

        public readonly DbField<SqlDbType> AssessmentDate;

        public readonly DbField<SqlDbType> AssessmentTime;

        public readonly DbField<SqlDbType> isAssessmentDone;

        public readonly DbField<SqlDbType> AssessmentScore;

        public readonly DbField<SqlDbType> Assessment_Instructor;

        public readonly DbField<SqlDbType> Date_Entered;

        public readonly DbField<SqlDbType> IsDrivingexperience;

        public readonly DbField<SqlDbType> intDrivinglicenseType;

        public readonly DbField<SqlDbType> AbsherApptNbr;

        public readonly DbField<SqlDbType> Absherphoto;

        public readonly DbField<SqlDbType> date_Birth;

        public readonly DbField<SqlDbType> date_Birth_Hijri;

        public readonly DbField<SqlDbType> str_Cell_Phone;

        public readonly DbField<SqlDbType> str_Email;

        public readonly DbField<SqlDbType> UserlevelID;

        public readonly DbField<SqlDbType> BackDateChk;

        public readonly DbField<SqlDbType> DriveTypelink;

        public readonly DbField<SqlDbType> Calendar_ID;

        public readonly DbField<SqlDbType> Assessmnt_Time;

        public readonly DbField<SqlDbType> Institution;

        public readonly DbField<SqlDbType> TheoreticalScore;

        public readonly DbField<SqlDbType> dt_TheoreticalScore;

        public readonly DbField<SqlDbType> RoadTestScore;

        public readonly DbField<SqlDbType> dt_RoadTestScore;

        public readonly DbField<SqlDbType> AccidentOccurrence;

        public readonly DbField<SqlDbType> Dt_AccidentOccurrence;

        public readonly DbField<SqlDbType> AccidentNotes;

        // Constructor
        public TblAssessment()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "tblAssessment";
            Name = "tblAssessment";
            Type = "TABLE";
            UpdateTable = "dbo.tblAssessment"; // Update Table
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

            // AssessmentID
            AssessmentID = new (this, "x_AssessmentID", 3, SqlDbType.Int) {
                Name = "AssessmentID",
                Expression = "[AssessmentID]",
                BasicSearchExpression = "CAST([AssessmentID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[AssessmentID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "NO",
                InputTextType = "text",
                IsAutoIncrement = true, // Autoincrement field
                IsPrimaryKey = true, // Primary key field
                IsForeignKey = true, // Foreign key field
                Nullable = false, // NOT NULL field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "AssessmentID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("AssessmentID", AssessmentID);

            // str_Full_Name_Hdr
            str_Full_Name_Hdr = new (this, "x_str_Full_Name_Hdr", 202, SqlDbType.NVarChar) {
                Name = "str_Full_Name_Hdr",
                Expression = "[str_Full_Name_Hdr]",
                BasicSearchExpression = "[str_Full_Name_Hdr]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Full_Name_Hdr]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "SELECT",
                InputTextType = "text",
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "str_Full_Name_Hdr", "CustomMsg"),
                IsUpload = false
            };
            str_Full_Name_Hdr.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(str_Full_Name_Hdr, "tblStudents", false, "str_Full_Name", new List<string> {"str_Full_Name", "", "", ""}, "", "", new List<string> {}, new List<string> {"x_NationalID"}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[str_Full_Name]"),
                "en-US" => new Lookup<DbField>(str_Full_Name_Hdr, "tblStudents", false, "str_Full_Name", new List<string> {"str_Full_Name", "", "", ""}, "", "", new List<string> {}, new List<string> {"x_NationalID"}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[str_Full_Name]"),
                _ => new Lookup<DbField>(str_Full_Name_Hdr, "tblStudents", false, "str_Full_Name", new List<string> {"str_Full_Name", "", "", ""}, "", "", new List<string> {}, new List<string> {"x_NationalID"}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[str_Full_Name]")
            };
            str_Full_Name_Hdr.GetSelectFilter = () => "[UserlevelID]=30";
            Fields.Add("str_Full_Name_Hdr", str_Full_Name_Hdr);

            // str_First_Name
            str_First_Name = new (this, "x_str_First_Name", 202, SqlDbType.NVarChar) {
                Name = "str_First_Name",
                Expression = "[str_First_Name]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_First_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_First_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "str_First_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_First_Name", str_First_Name);

            // str_Middle_Name
            str_Middle_Name = new (this, "x_str_Middle_Name", 202, SqlDbType.NVarChar) {
                Name = "str_Middle_Name",
                Expression = "[str_Middle_Name]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Middle_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Middle_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "str_Middle_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Middle_Name", str_Middle_Name);

            // str_Last_Name
            str_Last_Name = new (this, "x_str_Last_Name", 202, SqlDbType.NVarChar) {
                Name = "str_Last_Name",
                Expression = "[str_Last_Name]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Last_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Last_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "str_Last_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Last_Name", str_Last_Name);

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
                IsForeignKey = true, // Foreign key field
                UseFilter = true, // Table header filter
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "str_Username", "CustomMsg"),
                IsUpload = false
            };
            str_Username.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(str_Username, "tblAssessment", true, "str_Username", new List<string> {"str_Username", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(str_Username, "tblAssessment", true, "str_Username", new List<string> {"str_Username", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(str_Username, "tblAssessment", true, "str_Username", new List<string> {"str_Username", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("str_Username", str_Username);

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
                ViewTag = "IMAGE",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "int_Student_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Student_ID", int_Student_ID);

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
                Sortable = false, // Allow sort
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "NationalID", "CustomMsg"),
                IsUpload = false
            };
            NationalID.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(NationalID, "tblStudents", false, "NationalID", new List<string> {"NationalID", "", "", ""}, "", "", new List<string> {"x_str_Full_Name_Hdr"}, new List<string> {}, new List<string> {"str_Full_Name"}, new List<string> {"x_str_Full_Name"}, new List<string> {}, new List<string> {}, "", "", "CAST([NationalID] AS NVARCHAR)"),
                "en-US" => new Lookup<DbField>(NationalID, "tblStudents", false, "NationalID", new List<string> {"NationalID", "", "", ""}, "", "", new List<string> {"x_str_Full_Name_Hdr"}, new List<string> {}, new List<string> {"str_Full_Name"}, new List<string> {"x_str_Full_Name"}, new List<string> {}, new List<string> {}, "", "", "CAST([NationalID] AS NVARCHAR)"),
                _ => new Lookup<DbField>(NationalID, "tblStudents", false, "NationalID", new List<string> {"NationalID", "", "", ""}, "", "", new List<string> {"x_str_Full_Name_Hdr"}, new List<string> {}, new List<string> {"str_Full_Name"}, new List<string> {"x_str_Full_Name"}, new List<string> {}, new List<string> {}, "", "", "CAST([NationalID] AS NVARCHAR)")
            };
            Fields.Add("NationalID", NationalID);

            // Assessment_Type
            Assessment_Type = new (this, "x_Assessment_Type", 202, SqlDbType.NVarChar) {
                Name = "Assessment_Type",
                Expression = "[Assessment_Type]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Assessment_Type]",
                DateTimeFormat = -1,
                VirtualExpression = "[Assessment_Type]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "SELECT",
                InputTextType = "text",
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                OptionCount = 2,
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "Assessment_Type", "CustomMsg"),
                IsUpload = false
            };
            Assessment_Type.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Assessment_Type, "tblAssessment", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Assessment_Type, "tblAssessment", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Assessment_Type, "tblAssessment", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Assessment_Type", Assessment_Type);

            // AssessmentDate
            AssessmentDate = new (this, "x_AssessmentDate", 135, SqlDbType.DateTime) {
                Name = "AssessmentDate",
                Expression = "[AssessmentDate]",
                UseBasicSearch = true,
                BasicSearchExpression = CastDateFieldForLike("[AssessmentDate]", 16, "DB"),
                DateTimeFormat = 16,
                VirtualExpression = "[AssessmentDate]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Required = true, // Required field
                UseFilter = true, // Table header filter
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", DateFormat(16)),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "AssessmentDate", "CustomMsg"),
                IsUpload = false
            };
            AssessmentDate.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(AssessmentDate, "tblAssessment", true, "AssessmentDate", new List<string> {"AssessmentDate", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(AssessmentDate, "tblAssessment", true, "AssessmentDate", new List<string> {"AssessmentDate", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(AssessmentDate, "tblAssessment", true, "AssessmentDate", new List<string> {"AssessmentDate", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("AssessmentDate", AssessmentDate);

            // AssessmentTime
            AssessmentTime = new (this, "x_AssessmentTime", 200, SqlDbType.VarChar) {
                Name = "AssessmentTime",
                Expression = "[AssessmentTime]",
                BasicSearchExpression = "[AssessmentTime]",
                DateTimeFormat = -1,
                VirtualExpression = "[AssessmentTime]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "AssessmentTime", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("AssessmentTime", AssessmentTime);

            // isAssessmentDone
            isAssessmentDone = new (this, "x_isAssessmentDone", 200, SqlDbType.VarChar) {
                Name = "isAssessmentDone",
                Expression = "[isAssessmentDone]",
                BasicSearchExpression = "[isAssessmentDone]",
                DateTimeFormat = -1,
                VirtualExpression = "[isAssessmentDone]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "RADIO",
                InputTextType = "text",
                OptionCount = 2,
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "isAssessmentDone", "CustomMsg"),
                IsUpload = false
            };
            isAssessmentDone.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(isAssessmentDone, "tblAssessment", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(isAssessmentDone, "tblAssessment", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(isAssessmentDone, "tblAssessment", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("isAssessmentDone", isAssessmentDone);

            // AssessmentScore
            AssessmentScore = new (this, "x_AssessmentScore", 202, SqlDbType.NVarChar) {
                Name = "AssessmentScore",
                Expression = "[AssessmentScore]",
                BasicSearchExpression = "[AssessmentScore]",
                DateTimeFormat = -1,
                VirtualExpression = "[AssessmentScore]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                UseFilter = true, // Table header filter
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "AssessmentScore", "CustomMsg"),
                IsUpload = false
            };
            AssessmentScore.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(AssessmentScore, "tblAssessment", true, "AssessmentScore", new List<string> {"AssessmentScore", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(AssessmentScore, "tblAssessment", true, "AssessmentScore", new List<string> {"AssessmentScore", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(AssessmentScore, "tblAssessment", true, "AssessmentScore", new List<string> {"AssessmentScore", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("AssessmentScore", AssessmentScore);

            // Assessment_Instructor
            Assessment_Instructor = new (this, "x_Assessment_Instructor", 202, SqlDbType.NVarChar) {
                Name = "Assessment_Instructor",
                Expression = "[Assessment_Instructor]",
                BasicSearchExpression = "[Assessment_Instructor]",
                DateTimeFormat = -1,
                VirtualExpression = "[Assessment_Instructor]",
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
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "Assessment_Instructor", "CustomMsg"),
                IsUpload = false
            };
            Assessment_Instructor.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Assessment_Instructor, "tblStaff", false, "str_Full_Name", new List<string> {"str_Full_Name", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "[str_First_Name] ASC", "", "[str_Full_Name]"),
                "en-US" => new Lookup<DbField>(Assessment_Instructor, "tblStaff", false, "str_Full_Name", new List<string> {"str_Full_Name", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "[str_First_Name] ASC", "", "[str_Full_Name]"),
                _ => new Lookup<DbField>(Assessment_Instructor, "tblStaff", false, "str_Full_Name", new List<string> {"str_Full_Name", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "[str_First_Name] ASC", "", "[str_Full_Name]")
            };
            Fields.Add("Assessment_Instructor", Assessment_Instructor);

            // Date_Entered
            Date_Entered = new (this, "x_Date_Entered", 135, SqlDbType.DateTime) {
                Name = "Date_Entered",
                Expression = "[Date_Entered]",
                BasicSearchExpression = CastDateFieldForLike("[Date_Entered]", 116, "DB"),
                DateTimeFormat = 116,
                VirtualExpression = "[Date_Entered]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", DateFormat(116)),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "Date_Entered", "CustomMsg"),
                IsUpload = false
            };
            Date_Entered.GetAutoUpdateValue = () => CurrentDateTime();
            Fields.Add("Date_Entered", Date_Entered);

            // IsDrivingexperience
            IsDrivingexperience = new (this, "x_IsDrivingexperience", 11, SqlDbType.Bit) {
                Name = "IsDrivingexperience",
                Expression = "[IsDrivingexperience]",
                BasicSearchExpression = "[IsDrivingexperience]",
                DateTimeFormat = -1,
                VirtualExpression = "[IsDrivingexperience]",
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
                CustomMessage = Language.FieldPhrase("tblAssessment", "IsDrivingexperience", "CustomMsg"),
                IsUpload = false
            };
            IsDrivingexperience.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(IsDrivingexperience, "tblAssessment", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(IsDrivingexperience, "tblAssessment", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(IsDrivingexperience, "tblAssessment", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("IsDrivingexperience", IsDrivingexperience);

            // intDrivinglicenseType
            intDrivinglicenseType = new (this, "x_intDrivinglicenseType", 3, SqlDbType.Int) {
                Name = "intDrivinglicenseType",
                Expression = "[intDrivinglicenseType]",
                BasicSearchExpression = "CAST([intDrivinglicenseType] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[intDrivinglicenseType]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "intDrivinglicenseType", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("intDrivinglicenseType", intDrivinglicenseType);

            // AbsherApptNbr
            AbsherApptNbr = new (this, "x_AbsherApptNbr", 202, SqlDbType.NVarChar) {
                Name = "AbsherApptNbr",
                Expression = "[AbsherApptNbr]",
                BasicSearchExpression = "[AbsherApptNbr]",
                DateTimeFormat = -1,
                VirtualExpression = "[AbsherApptNbr]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                ImageResize = true,
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "AbsherApptNbr", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("AbsherApptNbr", AbsherApptNbr);

            // Absherphoto
            Absherphoto = new (this, "x_Absherphoto", 202, SqlDbType.NVarChar) {
                Name = "Absherphoto",
                Expression = "[Absherphoto]",
                BasicSearchExpression = "[Absherphoto]",
                DateTimeFormat = -1,
                VirtualExpression = "[Absherphoto]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "IMAGE",
                HtmlTag = "FILE",
                InputTextType = "text",
                ImageResize = true,
                UploadAllowedFileExtensions = "gif,jpg,jpeg,bmp,png,pdf",
                SearchOperators = new () { "=", "<>", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "Absherphoto", "CustomMsg"),
                IsUpload = true
            };
            Fields.Add("Absherphoto", Absherphoto);

            // date_Birth
            date_Birth = new (this, "x_date_Birth", 135, SqlDbType.DateTime) {
                Name = "date_Birth",
                Expression = "[date_Birth]",
                BasicSearchExpression = CastDateFieldForLike("[date_Birth]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[date_Birth]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "date_Birth", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Birth", date_Birth);

            // date_Birth_Hijri
            date_Birth_Hijri = new (this, "x_date_Birth_Hijri", 202, SqlDbType.NVarChar) {
                Name = "date_Birth_Hijri",
                Expression = "[date_Birth_Hijri]",
                BasicSearchExpression = "[date_Birth_Hijri]",
                DateTimeFormat = -1,
                VirtualExpression = "[date_Birth_Hijri]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "date_Birth_Hijri", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Birth_Hijri", date_Birth_Hijri);

            // str_Cell_Phone
            str_Cell_Phone = new (this, "x_str_Cell_Phone", 202, SqlDbType.NVarChar) {
                Name = "str_Cell_Phone",
                Expression = "[str_Cell_Phone]",
                BasicSearchExpression = "[str_Cell_Phone]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Cell_Phone]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "str_Cell_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Cell_Phone", str_Cell_Phone);

            // str_Email
            str_Email = new (this, "x_str_Email", 202, SqlDbType.NVarChar) {
                Name = "str_Email",
                Expression = "[str_Email]",
                BasicSearchExpression = "[str_Email]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Email]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "str_Email", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Email", str_Email);

            // UserlevelID
            UserlevelID = new (this, "x_UserlevelID", 3, SqlDbType.Int) {
                Name = "UserlevelID",
                Expression = "[UserlevelID]",
                BasicSearchExpression = "CAST([UserlevelID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[UserlevelID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "UserlevelID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("UserlevelID", UserlevelID);

            // BackDateChk
            BackDateChk = new (this, "x_BackDateChk", 20, SqlDbType.BigInt) {
                Name = "BackDateChk",
                Expression = "[BackDateChk]",
                BasicSearchExpression = "CAST([BackDateChk] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[BackDateChk]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Sortable = false, // Allow sort
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "BackDateChk", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("BackDateChk", BackDateChk);

            // DriveTypelink
            DriveTypelink = new (this, "x_DriveTypelink", 203, SqlDbType.NText) {
                Name = "DriveTypelink",
                Expression = "[DriveTypelink]",
                BasicSearchExpression = "[DriveTypelink]",
                DateTimeFormat = -1,
                VirtualExpression = "[DriveTypelink]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "DriveTypelink", "CustomMsg"),
                IsUpload = false
            };
            DriveTypelink.GetDefault = () => "[1] - Private Vehicles, [2] - Motorbike, [3] - Taxi  &  [4] - CDL (Trucks and Buses)";
            Fields.Add("DriveTypelink", DriveTypelink);

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
                Sortable = false, // Allow sort
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "Calendar_ID", "CustomMsg"),
                IsUpload = false
            };
            Calendar_ID.GetDefault = () => 1;
            Fields.Add("Calendar_ID", Calendar_ID);

            // Assessmnt_Time
            Assessmnt_Time = new (this, "x_Assessmnt_Time", 145, SqlDbType.Time) {
                Name = "Assessmnt_Time",
                Expression = "[Assessmnt_Time]",
                BasicSearchExpression = CastDateFieldForLike("[Assessmnt_Time]", 4, "DB"),
                DateTimeFormat = 4,
                VirtualExpression = "[Assessmnt_Time]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Sortable = false, // Allow sort
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectTime")).Replace("%s", DateFormat(4)),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "Assessmnt_Time", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Assessmnt_Time", Assessmnt_Time);

            // Institution
            Institution = new (this, "x_Institution", 200, SqlDbType.VarChar) {
                Name = "Institution",
                Expression = "[Institution]",
                BasicSearchExpression = "[Institution]",
                DateTimeFormat = -1,
                VirtualExpression = "[Institution]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "Institution", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Institution", Institution);

            // TheoreticalScore
            TheoreticalScore = new (this, "x_TheoreticalScore", 131, SqlDbType.Decimal) {
                Name = "TheoreticalScore",
                Expression = "[TheoreticalScore]",
                BasicSearchExpression = "CAST([TheoreticalScore] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[TheoreticalScore]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "TheoreticalScore", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("TheoreticalScore", TheoreticalScore);

            // dt_TheoreticalScore
            dt_TheoreticalScore = new (this, "x_dt_TheoreticalScore", 135, SqlDbType.DateTime) {
                Name = "dt_TheoreticalScore",
                Expression = "[dt_TheoreticalScore]",
                BasicSearchExpression = CastDateFieldForLike("[dt_TheoreticalScore]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_TheoreticalScore]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "dt_TheoreticalScore", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_TheoreticalScore", dt_TheoreticalScore);

            // RoadTestScore
            RoadTestScore = new (this, "x_RoadTestScore", 131, SqlDbType.Decimal) {
                Name = "RoadTestScore",
                Expression = "[RoadTestScore]",
                BasicSearchExpression = "CAST([RoadTestScore] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[RoadTestScore]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "RoadTestScore", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("RoadTestScore", RoadTestScore);

            // dt_RoadTestScore
            dt_RoadTestScore = new (this, "x_dt_RoadTestScore", 135, SqlDbType.DateTime) {
                Name = "dt_RoadTestScore",
                Expression = "[dt_RoadTestScore]",
                BasicSearchExpression = CastDateFieldForLike("[dt_RoadTestScore]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[dt_RoadTestScore]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "dt_RoadTestScore", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dt_RoadTestScore", dt_RoadTestScore);

            // AccidentOccurrence
            AccidentOccurrence = new (this, "x_AccidentOccurrence", 11, SqlDbType.Bit) {
                Name = "AccidentOccurrence",
                Expression = "[AccidentOccurrence]",
                BasicSearchExpression = "[AccidentOccurrence]",
                DateTimeFormat = -1,
                VirtualExpression = "[AccidentOccurrence]",
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
                CustomMessage = Language.FieldPhrase("tblAssessment", "AccidentOccurrence", "CustomMsg"),
                IsUpload = false
            };
            AccidentOccurrence.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(AccidentOccurrence, "tblAssessment", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(AccidentOccurrence, "tblAssessment", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(AccidentOccurrence, "tblAssessment", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("AccidentOccurrence", AccidentOccurrence);

            // Dt_AccidentOccurrence
            Dt_AccidentOccurrence = new (this, "x_Dt_AccidentOccurrence", 135, SqlDbType.DateTime) {
                Name = "Dt_AccidentOccurrence",
                Expression = "[Dt_AccidentOccurrence]",
                BasicSearchExpression = CastDateFieldForLike("[Dt_AccidentOccurrence]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[Dt_AccidentOccurrence]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "Dt_AccidentOccurrence", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Dt_AccidentOccurrence", Dt_AccidentOccurrence);

            // AccidentNotes
            AccidentNotes = new (this, "x_AccidentNotes", 203, SqlDbType.NText) {
                Name = "AccidentNotes",
                Expression = "[AccidentNotes]",
                BasicSearchExpression = "[AccidentNotes]",
                DateTimeFormat = -1,
                VirtualExpression = "[AccidentNotes]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblAssessment", "AccidentNotes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("AccidentNotes", AccidentNotes);

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
            if (CurrentMasterTable == "tblStudents") {
                dynamic masterTable = Resolve("tblStudents")!;
                if (!Empty(str_Username.SessionValue))
                    masterFilter += "" + KeyFilter(masterTable.str_Username, str_Username.SessionValue, masterTable.str_Username.DataType, masterTable.DbId);
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
                if (CurrentMasterTable == "tblStudents") {
                    dynamic masterTable = Resolve("tblStudents")!;
                    if (!Empty(str_Username.SessionValue))
                        detailFilter += "" + KeyFilter(str_Username, str_Username.SessionValue, masterTable.str_Username.DataType, DbId);
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
            case "tblStudents":
                key = keys["str_Username"] ?? "";
                if (Empty(key)) {
                    if (masterTable.str_Username.Required) // Required field and empty value
                        return ""; // Return empty filter
                    validKeys = false;
                } else if (!validKeys) { // Already has empty key
                    return ""; // Return empty filter
                }
                if (validKeys) {
                    return KeyFilter(masterTable.str_Username, keys["str_Username"], str_Username.DataType, DbId);
                }
                break;
            }
            return null; // All null values and no required fields
        }

        // Detail filter // DN
        public string DetailFilter(dynamic masterTable) // DN
        {
            return masterTable.TableVar switch {
                "tblStudents" => KeyFilter(str_Username, masterTable.str_Username.DbValue, masterTable.str_Username.DataType, masterTable.DbId),
                _ => ""
            };
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
                if (CurrentDetailTable == "tblEvaluation" && tblEvaluation != null) {
                    detailUrl = tblEvaluation.ListUrl + "?" + Config.TableShowMaster + "=" + TableVar;
                    detailUrl += "&" + ForeignKeyUrl("fk_AssessmentID", AssessmentID.CurrentValue);
                }
                if (CurrentDetailTable == "tblEvaluationMB" && tblEvaluationMb != null) {
                    detailUrl = tblEvaluationMb.ListUrl + "?" + Config.TableShowMaster + "=" + TableVar;
                    detailUrl += "&" + ForeignKeyUrl("fk_AssessmentID", AssessmentID.CurrentValue);
                }
                if (Empty(detailUrl))
                    detailUrl = "TblAssessmentList";
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
            get => _sqlFrom ?? "dbo.tblAssessment";
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
                AssessmentID.SetDbValue(lastInsertedId);
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
                // Cascade Update detail table 'tblEvaluation'
                cascadeUpdate = false;
                rscascade.Clear();
                if (row.ContainsKey("AssessmentID") && !Empty(row["AssessmentID"]) && !SameString(rsold["AssessmentID"], row["AssessmentID"])) {
                    cascadeUpdate = true;
                    rscascade.Add("AssessmentID", row["AssessmentID"]);
                }
                if (cascadeUpdate) {
                    Dictionary<string, object>? rskey = new ();
                    tblEvaluation = Resolve("tblEvaluation")!;
                    if (tblEvaluation != null) {
                        var rows = await tblEvaluation.Connection.GetRowsAsync(tblEvaluation.GetSql("[AssessmentID] = " + QuotedValue(rsold["AssessmentID"], DataType.Number, "DB")));
                        foreach (var rsdtlold in rows) {
                            rskey = tblEvaluation.GetRowFilterAsDictionary(rsdtlold);
                            var rsdtlnew = new Dictionary<string, object>(rsdtlold);
                            foreach (var (key, value) in rscascade)
                                rsdtlnew[key] = value;
                            bool update = tblEvaluation.Invoke("RowUpdating", new object[] { rsdtlold, rsdtlnew }) is bool b && b; // Call Row Updating event
                            if (update)
                                update = await tblEvaluation.UpdateAsync(rscascade, rskey, rsdtlold) >= 0; // Update
                            if (!update)
                                return -1;
                            tblEvaluation.Invoke("RowUpdated", new object[] { rsdtlold, rsdtlnew }); // Call Row Updated event
                        }
                    }
                }

                // Cascade Update detail table 'tblEvaluationMB'
                cascadeUpdate = false;
                rscascade.Clear();
                if (row.ContainsKey("AssessmentID") && !Empty(row["AssessmentID"]) && !SameString(rsold["AssessmentID"], row["AssessmentID"])) {
                    cascadeUpdate = true;
                    rscascade.Add("AssessmentID", row["AssessmentID"]);
                }
                if (cascadeUpdate) {
                    Dictionary<string, object>? rskey = new ();
                    tblEvaluationMb = Resolve("tblEvaluationMB")!;
                    if (tblEvaluationMb != null) {
                        var rows = await tblEvaluationMb.Connection.GetRowsAsync(tblEvaluationMb.GetSql("[AssessmentID] = " + QuotedValue(rsold["AssessmentID"], DataType.Number, "DB")));
                        foreach (var rsdtlold in rows) {
                            rskey = tblEvaluationMb.GetRowFilterAsDictionary(rsdtlold);
                            var rsdtlnew = new Dictionary<string, object>(rsdtlold);
                            foreach (var (key, value) in rscascade)
                                rsdtlnew[key] = value;
                            bool update = tblEvaluationMb.Invoke("RowUpdating", new object[] { rsdtlold, rsdtlnew }) is bool b && b; // Call Row Updating event
                            if (update)
                                update = await tblEvaluationMb.UpdateAsync(rscascade, rskey, rsdtlold) >= 0; // Update
                            if (!update)
                                return -1;
                            tblEvaluationMb.Invoke("RowUpdated", new object[] { rsdtlold, rsdtlnew }); // Call Row Updated event
                        }
                    }
                }
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
                if (!rsaudit.ContainsKey("AssessmentID"))
                    rsaudit.Add("AssessmentID", rsold["AssessmentID"]);
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
                // Cascade delete detail table 'tblEvaluation'
                tblEvaluation = Resolve("tblEvaluation")!;
                if (tblEvaluation != null) {
                    dtlrows = await Connection.GetRowsAsync(tblEvaluation.GetSql("[AssessmentID] = " + QuotedValue(row["AssessmentID"], DataType.Number, "DB")));
                    delete = dtlrows.All(dtlrow => tblEvaluation.Invoke("RowDeleting", new object[] { dtlrow }) is bool b && b); // Call Row Deleting event
                    if (delete) {
                        foreach (var dtlrow in dtlrows) {
                            delete = ConvertToBool(await tblEvaluation.DeleteAsync(dtlrow)); // Delete
                            if (!delete)
                                break;
                        }
                    }
                    if (delete)
                        dtlrows.ForEach(dtlrow => tblEvaluation.Invoke("RowDeleted", new object[] { dtlrow })); // Call Row Deleted event
                }

                // Cascade delete detail table 'tblEvaluationMB'
                tblEvaluationMb = Resolve("tblEvaluationMB")!;
                if (tblEvaluationMb != null) {
                    dtlrows = await Connection.GetRowsAsync(tblEvaluationMb.GetSql("[AssessmentID] = " + QuotedValue(row["AssessmentID"], DataType.Number, "DB")));
                    delete = dtlrows.All(dtlrow => tblEvaluationMb.Invoke("RowDeleting", new object[] { dtlrow }) is bool b && b); // Call Row Deleting event
                    if (delete) {
                        foreach (var dtlrow in dtlrows) {
                            delete = ConvertToBool(await tblEvaluationMb.DeleteAsync(dtlrow)); // Delete
                            if (!delete)
                                break;
                        }
                    }
                    if (delete)
                        dtlrows.ForEach(dtlrow => tblEvaluationMb.Invoke("RowDeleted", new object[] { dtlrow })); // Call Row Deleted event
                }
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
                AssessmentID.DbValue = row["AssessmentID"]; // Set DB value only
                str_Full_Name_Hdr.DbValue = row["str_Full_Name_Hdr"]; // Set DB value only
                str_First_Name.DbValue = row["str_First_Name"]; // Set DB value only
                str_Middle_Name.DbValue = row["str_Middle_Name"]; // Set DB value only
                str_Last_Name.DbValue = row["str_Last_Name"]; // Set DB value only
                str_Username.DbValue = row["str_Username"]; // Set DB value only
                int_Student_ID.DbValue = row["int_Student_ID"]; // Set DB value only
                NationalID.DbValue = row["NationalID"]; // Set DB value only
                Assessment_Type.DbValue = row["Assessment_Type"]; // Set DB value only
                AssessmentDate.DbValue = row["AssessmentDate"]; // Set DB value only
                AssessmentTime.DbValue = row["AssessmentTime"]; // Set DB value only
                isAssessmentDone.DbValue = row["isAssessmentDone"]; // Set DB value only
                AssessmentScore.DbValue = row["AssessmentScore"]; // Set DB value only
                Assessment_Instructor.DbValue = row["Assessment_Instructor"]; // Set DB value only
                Date_Entered.DbValue = row["Date_Entered"]; // Set DB value only
                IsDrivingexperience.DbValue = (ConvertToBool(row["IsDrivingexperience"]) ? "1" : "0"); // Set DB value only
                intDrivinglicenseType.DbValue = row["intDrivinglicenseType"]; // Set DB value only
                AbsherApptNbr.DbValue = row["AbsherApptNbr"]; // Set DB value only
                Absherphoto.Upload.DbValue = row["Absherphoto"];
                date_Birth.DbValue = row["date_Birth"]; // Set DB value only
                date_Birth_Hijri.DbValue = row["date_Birth_Hijri"]; // Set DB value only
                str_Cell_Phone.DbValue = row["str_Cell_Phone"]; // Set DB value only
                str_Email.DbValue = row["str_Email"]; // Set DB value only
                UserlevelID.DbValue = row["UserlevelID"]; // Set DB value only
                BackDateChk.DbValue = row["BackDateChk"]; // Set DB value only
                DriveTypelink.DbValue = row["DriveTypelink"]; // Set DB value only
                Calendar_ID.DbValue = row["Calendar_ID"]; // Set DB value only
                Assessmnt_Time.DbValue = row["Assessmnt_Time"]; // Set DB value only
                Institution.DbValue = row["Institution"]; // Set DB value only
                TheoreticalScore.DbValue = row["TheoreticalScore"]; // Set DB value only
                dt_TheoreticalScore.DbValue = row["dt_TheoreticalScore"]; // Set DB value only
                RoadTestScore.DbValue = row["RoadTestScore"]; // Set DB value only
                dt_RoadTestScore.DbValue = row["dt_RoadTestScore"]; // Set DB value only
                AccidentOccurrence.DbValue = (ConvertToBool(row["AccidentOccurrence"]) ? "1" : "0"); // Set DB value only
                Dt_AccidentOccurrence.DbValue = row["Dt_AccidentOccurrence"]; // Set DB value only
                AccidentNotes.DbValue = row["AccidentNotes"]; // Set DB value only
            } catch {}
        }

        public void DeleteUploadedFiles(Dictionary<string, object> row)
        {
            LoadDbValues(row);
            if (!Empty(row["Absherphoto"])) {
                DeleteFile(Absherphoto.OldPhysicalUploadPath + row["Absherphoto"]);
            }
        }

        // Record filter WHERE clause
        private string _sqlKeyFilter => "[AssessmentID] = @AssessmentID@";

        #pragma warning disable 168, 219
        // Get record filter as string
        public string GetRecordFilter(Dictionary<string, object>? row = null, bool current = false)
        {
            string keyFilter = _sqlKeyFilter;
            object? val = null, result = "";
            val = row?.TryGetValue("AssessmentID", out result) ?? false
                ? result
                : !Empty(AssessmentID.OldValue) && !current ? AssessmentID.OldValue : AssessmentID.CurrentValue;
            if (!IsNumeric(val))
                return "0=1"; // Invalid key
            if (val == null)
                return "0=1"; // Invalid key
            keyFilter = keyFilter.Replace("@AssessmentID@", AdjustSql(val, DbId)); // Replace key value
            return keyFilter;
        }

        // Get record filter as Dictionary // DN
        public Dictionary<string, object>? GetRowFilterAsDictionary(IDictionary<string, object>? row = null)
        {
            Dictionary<string, object>? keyFilter = new ();
            object? val = null, result;
            val = row?.TryGetValue("AssessmentID", out result) ?? false
                ? result
                : !Empty(AssessmentID.OldValue) ? AssessmentID.OldValue : AssessmentID.CurrentValue;
            if (!IsNumeric(val))
                return null; // Invalid key
            if (Empty(val))
                return null; // Invalid key
            keyFilter.Add("AssessmentID", val); // Add key value
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
                    return "TblAssessmentList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "TblAssessmentView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "TblAssessmentEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "TblAssessmentAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "TblAssessmentList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "TblAssessmentView",
                Config.ApiAddAction => "TblAssessmentAdd",
                Config.ApiEditAction => "TblAssessmentEdit",
                Config.ApiDeleteAction => "TblAssessmentDelete",
                Config.ApiListAction => "TblAssessmentList",
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
        public string ListUrl => "TblAssessmentList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblAssessmentView", parm);
            else
                url = KeyUrl("TblAssessmentView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "TblAssessmentAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "TblAssessmentAdd?" + parm;
            else
                url = "TblAssessmentAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblAssessmentEdit", parm);
            else
                url = KeyUrl("TblAssessmentEdit", Config.TableShowDetail + "=");
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblAssessmentList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblAssessmentAdd", parm);
            else
                url = KeyUrl("TblAssessmentAdd", Config.TableShowDetail + "=");
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblAssessmentList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("TblAssessmentDelete")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
            if (CurrentMasterTable == "tblStudents" && !url.Contains(Config.TableShowMaster + "=")) {
                url += (url.Contains("?") ? "&" : "?") + Config.TableShowMaster + "=" + CurrentMasterTable;
                url += "&" + ForeignKeyUrl("fk_str_Username", str_Username.SessionValue); // Use Session Value
            }
            return url;
        }

        // Get primary key as JSON
        public string KeyToJson(bool htmlEncode = false)
        {
            string json = "";
            json += "\"AssessmentID\":" + ConvertToJson(AssessmentID.CurrentValue, "number", true);
            json = "{" + json + "}";
            if (htmlEncode)
                json = HtmlEncode(json);
            return json;
        }

        // Add key value to URL
        public string KeyUrl(string url, string parm = "") { // DN
            if (!IsNull(AssessmentID.CurrentValue)) {
                url += "/" + AssessmentID.CurrentValue;
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
            val = current ? ConvertToString(AssessmentID.CurrentValue) ?? "" : ConvertToString(AssessmentID.OldValue) ?? "";
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
            val = row?.TryGetValue("AssessmentID", out result) ?? false ? ConvertToString(result) : null;
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
                    AssessmentID.CurrentValue = keys[0];
                } else {
                    AssessmentID.OldValue = keys[0];
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
                if (RouteValues.TryGetValue("AssessmentID", out object? v0)) { // AssessmentID // DN
                    key = UrlDecode(v0); // DN
                } else if (IsApi() && !Empty(keyValues)) {
                    key = keyValues[0];
                } else {
                    key = Param("AssessmentID");
                }
                keysList.Add(key);
            }
            // Check keys
            foreach (var keys in keysList) {
                if (!IsNumeric(keys)) // AssessmentID
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
                    AssessmentID.CurrentValue = keys;
                else
                    AssessmentID.OldValue = keys;
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
            AssessmentID.SetDbValue(dr["AssessmentID"]);
            str_Full_Name_Hdr.SetDbValue(dr["str_Full_Name_Hdr"]);
            str_First_Name.SetDbValue(dr["str_First_Name"]);
            str_Middle_Name.SetDbValue(dr["str_Middle_Name"]);
            str_Last_Name.SetDbValue(dr["str_Last_Name"]);
            str_Username.SetDbValue(dr["str_Username"]);
            int_Student_ID.SetDbValue(dr["int_Student_ID"]);
            NationalID.SetDbValue(dr["NationalID"]);
            Assessment_Type.SetDbValue(dr["Assessment_Type"]);
            AssessmentDate.SetDbValue(dr["AssessmentDate"]);
            AssessmentTime.SetDbValue(dr["AssessmentTime"]);
            isAssessmentDone.SetDbValue(dr["isAssessmentDone"]);
            AssessmentScore.SetDbValue(dr["AssessmentScore"]);
            Assessment_Instructor.SetDbValue(dr["Assessment_Instructor"]);
            Date_Entered.SetDbValue(dr["Date_Entered"]);
            IsDrivingexperience.SetDbValue(ConvertToBool(dr["IsDrivingexperience"]) ? "1" : "0");
            intDrivinglicenseType.SetDbValue(dr["intDrivinglicenseType"]);
            AbsherApptNbr.SetDbValue(dr["AbsherApptNbr"]);
            Absherphoto.Upload.DbValue = dr["Absherphoto"];
            Absherphoto.SetDbValue(Absherphoto.Upload.DbValue);
            date_Birth.SetDbValue(dr["date_Birth"]);
            date_Birth_Hijri.SetDbValue(dr["date_Birth_Hijri"]);
            str_Cell_Phone.SetDbValue(dr["str_Cell_Phone"]);
            str_Email.SetDbValue(dr["str_Email"]);
            UserlevelID.SetDbValue(dr["UserlevelID"]);
            BackDateChk.SetDbValue(dr["BackDateChk"]);
            DriveTypelink.SetDbValue(dr["DriveTypelink"]);
            Calendar_ID.SetDbValue(dr["Calendar_ID"]);
            Assessmnt_Time.SetDbValue(dr["Assessmnt_Time"]);
            Institution.SetDbValue(dr["Institution"]);
            TheoreticalScore.SetDbValue(dr["TheoreticalScore"]);
            dt_TheoreticalScore.SetDbValue(dr["dt_TheoreticalScore"]);
            RoadTestScore.SetDbValue(dr["RoadTestScore"]);
            dt_RoadTestScore.SetDbValue(dr["dt_RoadTestScore"]);
            AccidentOccurrence.SetDbValue(ConvertToBool(dr["AccidentOccurrence"]) ? "1" : "0");
            Dt_AccidentOccurrence.SetDbValue(dr["Dt_AccidentOccurrence"]);
            AccidentNotes.SetDbValue(dr["AccidentNotes"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "TblAssessmentList";
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

            // AssessmentID

            // str_Full_Name_Hdr

            // str_First_Name

            // str_Middle_Name

            // str_Last_Name

            // str_Username

            // int_Student_ID

            // NationalID
            NationalID.CellCssStyle = "white-space: nowrap;";

            // Assessment_Type

            // AssessmentDate

            // AssessmentTime

            // isAssessmentDone

            // AssessmentScore

            // Assessment_Instructor
            Assessment_Instructor.CellCssStyle = "white-space: nowrap;";

            // Date_Entered

            // IsDrivingexperience

            // intDrivinglicenseType

            // AbsherApptNbr

            // Absherphoto

            // date_Birth

            // date_Birth_Hijri
            date_Birth_Hijri.CellCssStyle = "white-space: nowrap;";

            // str_Cell_Phone

            // str_Email

            // UserlevelID

            // BackDateChk
            BackDateChk.CellCssStyle = "white-space: nowrap;";

            // DriveTypelink
            DriveTypelink.CellCssStyle = "white-space: nowrap;";

            // Calendar_ID
            Calendar_ID.CellCssStyle = "white-space: nowrap;";

            // Assessmnt_Time
            Assessmnt_Time.CellCssStyle = "white-space: nowrap;";

            // Institution

            // TheoreticalScore

            // dt_TheoreticalScore

            // RoadTestScore

            // dt_RoadTestScore

            // AccidentOccurrence

            // Dt_AccidentOccurrence

            // AccidentNotes

            // AssessmentID
            AssessmentID.ViewValue = AssessmentID.CurrentValue;
            AssessmentID.ViewCustomAttributes = "";

            // str_Full_Name_Hdr
            curVal = ConvertToString(str_Full_Name_Hdr.CurrentValue);
            if (!Empty(curVal)) {
                if (str_Full_Name_Hdr.Lookup != null && IsDictionary(str_Full_Name_Hdr.Lookup?.Options) && str_Full_Name_Hdr.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    str_Full_Name_Hdr.ViewValue = str_Full_Name_Hdr.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[str_Full_Name]", "=", str_Full_Name_Hdr.CurrentValue, DataType.String, "");
                    lookupFilter = () => str_Full_Name_Hdr.GetSelectFilter();
                    sqlWrk = str_Full_Name_Hdr.Lookup?.GetSql(false, filterWrk, lookupFilter, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && str_Full_Name_Hdr.Lookup != null) { // Lookup values found
                        var listwrk = str_Full_Name_Hdr.Lookup?.RenderViewRow(rswrk[0]);
                        str_Full_Name_Hdr.ViewValue = str_Full_Name_Hdr.HighlightLookup(ConvertToString(rswrk[0]), str_Full_Name_Hdr.DisplayValue(listwrk));
                    } else {
                        str_Full_Name_Hdr.ViewValue = str_Full_Name_Hdr.CurrentValue;
                    }
                }
            } else {
                str_Full_Name_Hdr.ViewValue = DbNullValue;
            }
            str_Full_Name_Hdr.ViewCustomAttributes = "";

            // str_First_Name
            str_First_Name.ViewValue = ConvertToString(str_First_Name.CurrentValue); // DN
            str_First_Name.ViewCustomAttributes = "";

            // str_Middle_Name
            str_Middle_Name.ViewValue = ConvertToString(str_Middle_Name.CurrentValue); // DN
            str_Middle_Name.ViewCustomAttributes = "";

            // str_Last_Name
            str_Last_Name.ViewValue = ConvertToString(str_Last_Name.CurrentValue); // DN
            str_Last_Name.ViewCustomAttributes = "";

            // str_Username
            str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
            str_Username.ViewCustomAttributes = "";

            // int_Student_ID
            int_Student_ID.ViewValue = int_Student_ID.CurrentValue;
            int_Student_ID.ImageAlt = int_Student_ID.Alt;
                int_Student_ID.ImageCssClass = "ew-image";
            int_Student_ID.ViewValue = FormatNumber(int_Student_ID.ViewValue, int_Student_ID.FormatPattern);
            int_Student_ID.ViewCustomAttributes = "";

            // NationalID
            NationalID.ViewValue = NationalID.CurrentValue;
            curVal = ConvertToString(NationalID.CurrentValue);
            if (!Empty(curVal)) {
                if (NationalID.Lookup != null && IsDictionary(NationalID.Lookup?.Options) && NationalID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    NationalID.ViewValue = NationalID.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[NationalID]", "=", NationalID.CurrentValue, DataType.Number, "");
                    sqlWrk = NationalID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && NationalID.Lookup != null) { // Lookup values found
                        var listwrk = NationalID.Lookup?.RenderViewRow(rswrk[0]);
                        NationalID.ViewValue = NationalID.HighlightLookup(ConvertToString(rswrk[0]), NationalID.DisplayValue(listwrk));
                    } else {
                        NationalID.ViewValue = NationalID.CurrentValue;
                    }
                }
            } else {
                NationalID.ViewValue = DbNullValue;
            }
            NationalID.ViewCustomAttributes = "";

            // Assessment_Type
            if (!Empty(Assessment_Type.CurrentValue)) {
                Assessment_Type.ViewValue = Assessment_Type.HighlightLookup(ConvertToString(Assessment_Type.CurrentValue), Assessment_Type.OptionCaption(ConvertToString(Assessment_Type.CurrentValue)));
            } else {
                Assessment_Type.ViewValue = DbNullValue;
            }
            Assessment_Type.ViewCustomAttributes = "";

            // AssessmentDate
            AssessmentDate.ViewValue = AssessmentDate.CurrentValue;
            AssessmentDate.ViewValue = FormatDateTime(AssessmentDate.ViewValue, AssessmentDate.FormatPattern);
            AssessmentDate.ViewCustomAttributes = "";

            // AssessmentTime
            AssessmentTime.ViewValue = ConvertToString(AssessmentTime.CurrentValue); // DN
            AssessmentTime.ViewCustomAttributes = "";

            // isAssessmentDone
            if (!Empty(isAssessmentDone.CurrentValue)) {
                isAssessmentDone.ViewValue = isAssessmentDone.HighlightLookup(ConvertToString(isAssessmentDone.CurrentValue), isAssessmentDone.OptionCaption(ConvertToString(isAssessmentDone.CurrentValue)));
            } else {
                isAssessmentDone.ViewValue = DbNullValue;
            }
            isAssessmentDone.ViewCustomAttributes = "";

            // AssessmentScore
            AssessmentScore.ViewValue = ConvertToString(AssessmentScore.CurrentValue); // DN
            AssessmentScore.ViewCustomAttributes = "";

            // Assessment_Instructor
            curVal = ConvertToString(Assessment_Instructor.CurrentValue);
            if (!Empty(curVal)) {
                if (Assessment_Instructor.Lookup != null && IsDictionary(Assessment_Instructor.Lookup?.Options) && Assessment_Instructor.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    Assessment_Instructor.ViewValue = Assessment_Instructor.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[str_Full_Name]", "=", Assessment_Instructor.CurrentValue, DataType.String, "");
                    sqlWrk = Assessment_Instructor.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && Assessment_Instructor.Lookup != null) { // Lookup values found
                        var listwrk = Assessment_Instructor.Lookup?.RenderViewRow(rswrk[0]);
                        Assessment_Instructor.ViewValue = Assessment_Instructor.HighlightLookup(ConvertToString(rswrk[0]), Assessment_Instructor.DisplayValue(listwrk));
                    } else {
                        Assessment_Instructor.ViewValue = Assessment_Instructor.CurrentValue;
                    }
                }
            } else {
                Assessment_Instructor.ViewValue = DbNullValue;
            }
            Assessment_Instructor.ViewCustomAttributes = "";

            // Date_Entered
            Date_Entered.ViewValue = Date_Entered.CurrentValue;
            Date_Entered.ViewValue = FormatDateTime(Date_Entered.ViewValue, Date_Entered.FormatPattern);
            Date_Entered.ViewCustomAttributes = "";

            // IsDrivingexperience
            if (ConvertToBool(IsDrivingexperience.CurrentValue)) {
                IsDrivingexperience.ViewValue = IsDrivingexperience.TagCaption(1) != "" ? IsDrivingexperience.TagCaption(1) : "Yes";
            } else {
                IsDrivingexperience.ViewValue = IsDrivingexperience.TagCaption(2) != "" ? IsDrivingexperience.TagCaption(2) : "No";
            }
            IsDrivingexperience.ViewCustomAttributes = "";

            // intDrivinglicenseType
            intDrivinglicenseType.ViewValue = intDrivinglicenseType.CurrentValue;
            intDrivinglicenseType.ViewValue = FormatNumber(intDrivinglicenseType.ViewValue, intDrivinglicenseType.FormatPattern);
            intDrivinglicenseType.ViewCustomAttributes = "";

            // AbsherApptNbr
            AbsherApptNbr.ViewValue = ConvertToString(AbsherApptNbr.CurrentValue); // DN
            AbsherApptNbr.ViewCustomAttributes = "";

            // Absherphoto
            if (!IsNull(Absherphoto.Upload.DbValue)) {
                Absherphoto.ImageWidth = 200;
                Absherphoto.ImageHeight = 200;
                Absherphoto.ImageAlt = Absherphoto.Alt;
                Absherphoto.ImageCssClass = "ew-image";
                Absherphoto.ViewValue = Absherphoto.Upload.DbValue;
            } else {
                Absherphoto.ViewValue = "";
            }
            Absherphoto.ViewCustomAttributes = "";

            // date_Birth
            date_Birth.ViewValue = date_Birth.CurrentValue;
            date_Birth.ViewValue = FormatDateTime(date_Birth.ViewValue, date_Birth.FormatPattern);
            date_Birth.ViewCustomAttributes = "";

            // date_Birth_Hijri
            date_Birth_Hijri.ViewValue = ConvertToString(date_Birth_Hijri.CurrentValue); // DN
            date_Birth_Hijri.ViewCustomAttributes = "";

            // str_Cell_Phone
            str_Cell_Phone.ViewValue = ConvertToString(str_Cell_Phone.CurrentValue); // DN
            str_Cell_Phone.ViewCustomAttributes = "";

            // str_Email
            str_Email.ViewValue = ConvertToString(str_Email.CurrentValue); // DN
            str_Email.ViewCustomAttributes = "";

            // UserlevelID
            UserlevelID.ViewValue = UserlevelID.CurrentValue;
            UserlevelID.ViewValue = FormatNumber(UserlevelID.ViewValue, UserlevelID.FormatPattern);
            UserlevelID.ViewCustomAttributes = "";

            // BackDateChk
            BackDateChk.ViewValue = BackDateChk.CurrentValue;
            BackDateChk.ViewValue = FormatNumber(BackDateChk.ViewValue, BackDateChk.FormatPattern);
            BackDateChk.ViewCustomAttributes = "";

            // DriveTypelink
            DriveTypelink.ViewValue = DriveTypelink.CurrentValue;
            DriveTypelink.ViewCustomAttributes = "";

            // Calendar_ID
            Calendar_ID.ViewValue = Calendar_ID.CurrentValue;
            Calendar_ID.ViewValue = FormatNumber(Calendar_ID.ViewValue, Calendar_ID.FormatPattern);
            Calendar_ID.ViewCustomAttributes = "";

            // Assessmnt_Time
            Assessmnt_Time.ViewValue = Assessmnt_Time.CurrentValue;
            Assessmnt_Time.ViewValue = FormatDateTime(Assessmnt_Time.ViewValue, Assessmnt_Time.FormatPattern);
            Assessmnt_Time.ViewCustomAttributes = "";

            // Institution
            Institution.ViewValue = ConvertToString(Institution.CurrentValue); // DN
            Institution.ViewCustomAttributes = "";

            // TheoreticalScore
            TheoreticalScore.ViewValue = TheoreticalScore.CurrentValue;
            TheoreticalScore.ViewValue = FormatNumber(TheoreticalScore.ViewValue, TheoreticalScore.FormatPattern);
            TheoreticalScore.ViewCustomAttributes = "";

            // dt_TheoreticalScore
            dt_TheoreticalScore.ViewValue = dt_TheoreticalScore.CurrentValue;
            dt_TheoreticalScore.ViewValue = FormatDateTime(dt_TheoreticalScore.ViewValue, dt_TheoreticalScore.FormatPattern);
            dt_TheoreticalScore.ViewCustomAttributes = "";

            // RoadTestScore
            RoadTestScore.ViewValue = RoadTestScore.CurrentValue;
            RoadTestScore.ViewValue = FormatNumber(RoadTestScore.ViewValue, RoadTestScore.FormatPattern);
            RoadTestScore.ViewCustomAttributes = "";

            // dt_RoadTestScore
            dt_RoadTestScore.ViewValue = dt_RoadTestScore.CurrentValue;
            dt_RoadTestScore.ViewValue = FormatDateTime(dt_RoadTestScore.ViewValue, dt_RoadTestScore.FormatPattern);
            dt_RoadTestScore.ViewCustomAttributes = "";

            // AccidentOccurrence
            if (ConvertToBool(AccidentOccurrence.CurrentValue)) {
                AccidentOccurrence.ViewValue = AccidentOccurrence.TagCaption(1) != "" ? AccidentOccurrence.TagCaption(1) : "Yes";
            } else {
                AccidentOccurrence.ViewValue = AccidentOccurrence.TagCaption(2) != "" ? AccidentOccurrence.TagCaption(2) : "No";
            }
            AccidentOccurrence.ViewCustomAttributes = "";

            // Dt_AccidentOccurrence
            Dt_AccidentOccurrence.ViewValue = Dt_AccidentOccurrence.CurrentValue;
            Dt_AccidentOccurrence.ViewValue = FormatDateTime(Dt_AccidentOccurrence.ViewValue, Dt_AccidentOccurrence.FormatPattern);
            Dt_AccidentOccurrence.ViewCustomAttributes = "";

            // AccidentNotes
            AccidentNotes.ViewValue = AccidentNotes.CurrentValue;
            AccidentNotes.ViewCustomAttributes = "";

            // AssessmentID
            AssessmentID.HrefValue = "";
            AssessmentID.TooltipValue = "";

            // str_Full_Name_Hdr
            str_Full_Name_Hdr.HrefValue = "";
            str_Full_Name_Hdr.TooltipValue = "";

            // str_First_Name
            str_First_Name.HrefValue = "";
            str_First_Name.TooltipValue = "";

            // str_Middle_Name
            str_Middle_Name.HrefValue = "";
            str_Middle_Name.TooltipValue = "";

            // str_Last_Name
            str_Last_Name.HrefValue = "";
            str_Last_Name.TooltipValue = "";

            // str_Username
            str_Username.HrefValue = "";
            str_Username.TooltipValue = "";

            // int_Student_ID
            int_Student_ID.HrefValue = "";
            int_Student_ID.TooltipValue = "";

            // NationalID
            NationalID.HrefValue = "";
            NationalID.TooltipValue = "";

            // Assessment_Type
            Assessment_Type.HrefValue = "";
            Assessment_Type.TooltipValue = "";

            // AssessmentDate
            AssessmentDate.HrefValue = "";
            AssessmentDate.TooltipValue = "";

            // AssessmentTime
            AssessmentTime.HrefValue = "";
            AssessmentTime.TooltipValue = "";

            // isAssessmentDone
            isAssessmentDone.HrefValue = "";
            isAssessmentDone.TooltipValue = "";

            // AssessmentScore
            AssessmentScore.HrefValue = "";
            AssessmentScore.TooltipValue = "";

            // Assessment_Instructor
            Assessment_Instructor.HrefValue = "";
            Assessment_Instructor.TooltipValue = "";

            // Date_Entered
            Date_Entered.HrefValue = "";
            Date_Entered.TooltipValue = "";

            // IsDrivingexperience
            IsDrivingexperience.HrefValue = "";
            IsDrivingexperience.TooltipValue = "";

            // intDrivinglicenseType
            if (!IsNull(intDrivinglicenseType.CurrentValue)) {
                intDrivinglicenseType.HrefValue = ConvertToString(!Empty(intDrivinglicenseType.ViewValue) && !IsList(intDrivinglicenseType.ViewValue) ? RemoveHtml(ConvertToString(intDrivinglicenseType.ViewValue)) : ConvertToString(intDrivinglicenseType.CurrentValue)); // Add prefix/suffix
                intDrivinglicenseType.LinkAttrs["target"] = ""; // Add target
                if (IsExport())
                    intDrivinglicenseType.HrefValue = FullUrl(ConvertToString(intDrivinglicenseType.HrefValue), "href");
            } else {
                intDrivinglicenseType.HrefValue = "";
            }
            if (!IsExport()) {
                intDrivinglicenseType.TooltipValue = ConvertToString(DriveTypelink.CurrentValue);
                if (Empty(intDrivinglicenseType.HrefValue))
                    intDrivinglicenseType.HrefValue = "javascript:void(0);";
                intDrivinglicenseType.LinkAttrs["class"] = "ew-tooltip-link";
                intDrivinglicenseType.LinkAttrs["data-tooltip-id"] = "tt_tblAssessment_x" + ((RowType != RowType.Master && RowCount > 0) ? ConvertToString(RowCount) : "") + "_intDrivinglicenseType";
                intDrivinglicenseType.LinkAttrs["data-tooltip-width"] = ConvertToString(intDrivinglicenseType.TooltipWidth);
                intDrivinglicenseType.LinkAttrs["data-bs-placement"] = IsRTL ? "left" : "right";
            }

            // AbsherApptNbr
            AbsherApptNbr.HrefValue = "";
            AbsherApptNbr.TooltipValue = "";

            // Absherphoto
            if (!IsNull(Absherphoto.Upload.DbValue)) {
                Absherphoto.HrefValue = ConvertToString(GetFileUploadUrl(Absherphoto, Absherphoto.HtmlDecode(ConvertToString(Absherphoto.Upload.DbValue)))); // Add prefix/suffix
                Absherphoto.LinkAttrs["target"] = "_blank"; // Add target
                if (IsExport())
                    Absherphoto.HrefValue = FullUrl(ConvertToString(Absherphoto.HrefValue), "href");
            } else {
                Absherphoto.HrefValue = "";
            }
            Absherphoto.ExportHrefValue = Absherphoto.UploadPath + Absherphoto.Upload.DbValue;
            Absherphoto.TooltipValue = "";
            if (Absherphoto.UseColorbox) {
                if (Empty(Absherphoto.TooltipValue))
                    Absherphoto.LinkAttrs["title"] = Language.Phrase("ViewImageGallery");
                Absherphoto.LinkAttrs["data-rel"] = "tblAssessment_x_Absherphoto";
                if (Absherphoto.LinkAttrs.ContainsKey("class")) {
                    Absherphoto.LinkAttrs.AppendClass("ew-lightbox");
                } else {
                    Absherphoto.LinkAttrs["class"] = "ew-lightbox";
                }
            }

            // date_Birth
            date_Birth.HrefValue = "";
            date_Birth.TooltipValue = "";

            // date_Birth_Hijri
            date_Birth_Hijri.HrefValue = "";
            date_Birth_Hijri.TooltipValue = "";

            // str_Cell_Phone
            str_Cell_Phone.HrefValue = "";
            str_Cell_Phone.TooltipValue = "";

            // str_Email
            str_Email.HrefValue = "";
            str_Email.TooltipValue = "";

            // UserlevelID
            UserlevelID.HrefValue = "";
            UserlevelID.TooltipValue = "";

            // BackDateChk
            BackDateChk.HrefValue = "";
            BackDateChk.TooltipValue = "";

            // DriveTypelink
            DriveTypelink.HrefValue = "";
            DriveTypelink.TooltipValue = "";

            // Calendar_ID
            Calendar_ID.HrefValue = "";
            Calendar_ID.TooltipValue = "";

            // Assessmnt_Time
            Assessmnt_Time.HrefValue = "";
            Assessmnt_Time.TooltipValue = "";

            // Institution
            Institution.HrefValue = "";
            Institution.TooltipValue = "";

            // TheoreticalScore
            TheoreticalScore.HrefValue = "";
            TheoreticalScore.TooltipValue = "";

            // dt_TheoreticalScore
            dt_TheoreticalScore.HrefValue = "";
            dt_TheoreticalScore.TooltipValue = "";

            // RoadTestScore
            RoadTestScore.HrefValue = "";
            RoadTestScore.TooltipValue = "";

            // dt_RoadTestScore
            dt_RoadTestScore.HrefValue = "";
            dt_RoadTestScore.TooltipValue = "";

            // AccidentOccurrence
            AccidentOccurrence.HrefValue = "";
            AccidentOccurrence.TooltipValue = "";

            // Dt_AccidentOccurrence
            Dt_AccidentOccurrence.HrefValue = "";
            Dt_AccidentOccurrence.TooltipValue = "";

            // AccidentNotes
            AccidentNotes.HrefValue = "";
            AccidentNotes.TooltipValue = "";

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

            // AssessmentID
            AssessmentID.SetupEditAttributes();
            AssessmentID.EditValue = AssessmentID.CurrentValue;
            AssessmentID.ViewCustomAttributes = "";

            // str_Full_Name_Hdr
            str_Full_Name_Hdr.SetupEditAttributes();
            str_Full_Name_Hdr.PlaceHolder = RemoveHtml(str_Full_Name_Hdr.Caption);

            // str_First_Name
            str_First_Name.SetupEditAttributes();
            if (!str_First_Name.Raw)
                str_First_Name.CurrentValue = HtmlDecode(str_First_Name.CurrentValue);
            str_First_Name.EditValue = HtmlEncode(str_First_Name.CurrentValue);
            str_First_Name.PlaceHolder = RemoveHtml(str_First_Name.Caption);

            // str_Middle_Name
            str_Middle_Name.SetupEditAttributes();
            if (!str_Middle_Name.Raw)
                str_Middle_Name.CurrentValue = HtmlDecode(str_Middle_Name.CurrentValue);
            str_Middle_Name.EditValue = HtmlEncode(str_Middle_Name.CurrentValue);
            str_Middle_Name.PlaceHolder = RemoveHtml(str_Middle_Name.Caption);

            // str_Last_Name
            str_Last_Name.SetupEditAttributes();
            if (!str_Last_Name.Raw)
                str_Last_Name.CurrentValue = HtmlDecode(str_Last_Name.CurrentValue);
            str_Last_Name.EditValue = HtmlEncode(str_Last_Name.CurrentValue);
            str_Last_Name.PlaceHolder = RemoveHtml(str_Last_Name.Caption);

            // str_Username
            str_Username.SetupEditAttributes();
            if (!Empty(str_Username.SessionValue)) {
                str_Username.CurrentValue = ForeignKeyValue(str_Username.SessionValue);
                str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
                str_Username.ViewCustomAttributes = "";
            } else if (!Security.IsAdmin && Security.IsLoggedIn && !UserIDAllow("info")) { // Non system admin
                str_Username.CurrentValue = Empty(str_Username.CurrentValue) ? CurrentUserID() : str_Username.CurrentValue;
            } else {
                if (!str_Username.Raw)
                    str_Username.CurrentValue = HtmlDecode(str_Username.CurrentValue);
                str_Username.EditValue = HtmlEncode(str_Username.CurrentValue);
                str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);
            }

            // int_Student_ID
            int_Student_ID.SetupEditAttributes();
            int_Student_ID.EditValue = int_Student_ID.CurrentValue; // DN
            int_Student_ID.PlaceHolder = RemoveHtml(int_Student_ID.Caption);
            if (!Empty(int_Student_ID.EditValue) && IsNumeric(int_Student_ID.EditValue))
                int_Student_ID.EditValue = FormatNumber(int_Student_ID.EditValue, null);

            // NationalID
            NationalID.SetupEditAttributes();
            NationalID.EditValue = NationalID.CurrentValue; // DN
            NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);

            // Assessment_Type
            Assessment_Type.SetupEditAttributes();
            Assessment_Type.EditValue = Assessment_Type.Options(true);
            Assessment_Type.PlaceHolder = RemoveHtml(Assessment_Type.Caption);

            // AssessmentDate
            AssessmentDate.SetupEditAttributes();
            AssessmentDate.EditValue = FormatDateTime(AssessmentDate.CurrentValue, AssessmentDate.FormatPattern); // DN
            AssessmentDate.PlaceHolder = RemoveHtml(AssessmentDate.Caption);

            // AssessmentTime
            AssessmentTime.SetupEditAttributes();
            if (!AssessmentTime.Raw)
                AssessmentTime.CurrentValue = HtmlDecode(AssessmentTime.CurrentValue);
            AssessmentTime.EditValue = HtmlEncode(AssessmentTime.CurrentValue);
            AssessmentTime.PlaceHolder = RemoveHtml(AssessmentTime.Caption);

            // isAssessmentDone
            isAssessmentDone.EditValue = isAssessmentDone.Options(false);
            isAssessmentDone.PlaceHolder = RemoveHtml(isAssessmentDone.Caption);

            // AssessmentScore
            AssessmentScore.SetupEditAttributes();
            AssessmentScore.EditValue = ConvertToString(AssessmentScore.CurrentValue); // DN
            AssessmentScore.ViewCustomAttributes = "";

            // Assessment_Instructor
            Assessment_Instructor.SetupEditAttributes();
            Assessment_Instructor.PlaceHolder = RemoveHtml(Assessment_Instructor.Caption);

            // Date_Entered

            // IsDrivingexperience
            IsDrivingexperience.SetupEditAttributes();
            if (ConvertToBool(IsDrivingexperience.CurrentValue)) {
                IsDrivingexperience.EditValue = IsDrivingexperience.TagCaption(1) != "" ? IsDrivingexperience.TagCaption(1) : "Yes";
            } else {
                IsDrivingexperience.EditValue = IsDrivingexperience.TagCaption(2) != "" ? IsDrivingexperience.TagCaption(2) : "No";
            }
            IsDrivingexperience.ViewCustomAttributes = "";

            // intDrivinglicenseType
            intDrivinglicenseType.SetupEditAttributes();
            intDrivinglicenseType.EditValue = intDrivinglicenseType.CurrentValue;
            intDrivinglicenseType.EditValue = FormatNumber(intDrivinglicenseType.EditValue, intDrivinglicenseType.FormatPattern);
            intDrivinglicenseType.ViewCustomAttributes = "";

            // AbsherApptNbr
            AbsherApptNbr.SetupEditAttributes();
            AbsherApptNbr.EditValue = ConvertToString(AbsherApptNbr.CurrentValue); // DN
            AbsherApptNbr.ViewCustomAttributes = "";

            // Absherphoto
            Absherphoto.SetupEditAttributes();
            if (!IsNull(Absherphoto.Upload.DbValue)) {
                Absherphoto.ImageWidth = 200;
                Absherphoto.ImageHeight = 200;
                Absherphoto.ImageAlt = Absherphoto.Alt;
                Absherphoto.ImageCssClass = "ew-image";
                Absherphoto.EditValue = Absherphoto.Upload.DbValue;
            } else {
                Absherphoto.EditValue = "";
            }
            Absherphoto.ViewCustomAttributes = "";

            // date_Birth
            date_Birth.SetupEditAttributes();
            date_Birth.EditValue = date_Birth.CurrentValue;
            date_Birth.EditValue = FormatDateTime(date_Birth.EditValue, date_Birth.FormatPattern);
            date_Birth.ViewCustomAttributes = "";

            // date_Birth_Hijri
            date_Birth_Hijri.SetupEditAttributes();
            date_Birth_Hijri.EditValue = ConvertToString(date_Birth_Hijri.CurrentValue); // DN
            date_Birth_Hijri.ViewCustomAttributes = "";

            // str_Cell_Phone
            str_Cell_Phone.SetupEditAttributes();
            str_Cell_Phone.EditValue = ConvertToString(str_Cell_Phone.CurrentValue); // DN
            str_Cell_Phone.ViewCustomAttributes = "";

            // str_Email
            str_Email.SetupEditAttributes();
            str_Email.EditValue = ConvertToString(str_Email.CurrentValue); // DN
            str_Email.ViewCustomAttributes = "";

            // UserlevelID
            UserlevelID.SetupEditAttributes();
            UserlevelID.EditValue = UserlevelID.CurrentValue; // DN
            UserlevelID.PlaceHolder = RemoveHtml(UserlevelID.Caption);
            if (!Empty(UserlevelID.EditValue) && IsNumeric(UserlevelID.EditValue))
                UserlevelID.EditValue = FormatNumber(UserlevelID.EditValue, null);

            // BackDateChk
            BackDateChk.SetupEditAttributes();
            BackDateChk.EditValue = BackDateChk.CurrentValue;
            BackDateChk.EditValue = FormatNumber(BackDateChk.EditValue, BackDateChk.FormatPattern);
            BackDateChk.ViewCustomAttributes = "";

            // DriveTypelink
            DriveTypelink.SetupEditAttributes();
            DriveTypelink.EditValue = DriveTypelink.CurrentValue; // DN
            DriveTypelink.PlaceHolder = RemoveHtml(DriveTypelink.Caption);

            // Calendar_ID
            Calendar_ID.SetupEditAttributes();
            Calendar_ID.EditValue = Calendar_ID.CurrentValue; // DN
            Calendar_ID.PlaceHolder = RemoveHtml(Calendar_ID.Caption);
            if (!Empty(Calendar_ID.EditValue) && IsNumeric(Calendar_ID.EditValue))
                Calendar_ID.EditValue = FormatNumber(Calendar_ID.EditValue, null);

            // Assessmnt_Time
            Assessmnt_Time.SetupEditAttributes();
            Assessmnt_Time.EditValue = FormatDateTime(Assessmnt_Time.CurrentValue, Assessmnt_Time.FormatPattern); // DN
            Assessmnt_Time.PlaceHolder = RemoveHtml(Assessmnt_Time.Caption);

            // Institution
            Institution.SetupEditAttributes();
            if (!Institution.Raw)
                Institution.CurrentValue = HtmlDecode(Institution.CurrentValue);
            Institution.EditValue = HtmlEncode(Institution.CurrentValue);
            Institution.PlaceHolder = RemoveHtml(Institution.Caption);

            // TheoreticalScore
            TheoreticalScore.SetupEditAttributes();
            TheoreticalScore.EditValue = TheoreticalScore.CurrentValue; // DN
            TheoreticalScore.PlaceHolder = RemoveHtml(TheoreticalScore.Caption);
            if (!Empty(TheoreticalScore.EditValue) && IsNumeric(TheoreticalScore.EditValue))
                TheoreticalScore.EditValue = FormatNumber(TheoreticalScore.EditValue, null);

            // dt_TheoreticalScore
            dt_TheoreticalScore.SetupEditAttributes();
            dt_TheoreticalScore.EditValue = FormatDateTime(dt_TheoreticalScore.CurrentValue, dt_TheoreticalScore.FormatPattern); // DN
            dt_TheoreticalScore.PlaceHolder = RemoveHtml(dt_TheoreticalScore.Caption);

            // RoadTestScore
            RoadTestScore.SetupEditAttributes();
            RoadTestScore.EditValue = RoadTestScore.CurrentValue; // DN
            RoadTestScore.PlaceHolder = RemoveHtml(RoadTestScore.Caption);
            if (!Empty(RoadTestScore.EditValue) && IsNumeric(RoadTestScore.EditValue))
                RoadTestScore.EditValue = FormatNumber(RoadTestScore.EditValue, null);

            // dt_RoadTestScore
            dt_RoadTestScore.SetupEditAttributes();
            dt_RoadTestScore.EditValue = FormatDateTime(dt_RoadTestScore.CurrentValue, dt_RoadTestScore.FormatPattern); // DN
            dt_RoadTestScore.PlaceHolder = RemoveHtml(dt_RoadTestScore.Caption);

            // AccidentOccurrence
            AccidentOccurrence.EditValue = AccidentOccurrence.Options(false);
            AccidentOccurrence.PlaceHolder = RemoveHtml(AccidentOccurrence.Caption);

            // Dt_AccidentOccurrence
            Dt_AccidentOccurrence.SetupEditAttributes();
            Dt_AccidentOccurrence.EditValue = Dt_AccidentOccurrence.CurrentValue;
            Dt_AccidentOccurrence.EditValue = FormatDateTime(Dt_AccidentOccurrence.EditValue, Dt_AccidentOccurrence.FormatPattern);
            Dt_AccidentOccurrence.ViewCustomAttributes = "";

            // AccidentNotes
            AccidentNotes.SetupEditAttributes();
            AccidentNotes.EditValue = AccidentNotes.CurrentValue; // DN
            AccidentNotes.PlaceHolder = RemoveHtml(AccidentNotes.Caption);

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
                        doc.ExportCaption(str_Full_Name_Hdr);
                        doc.ExportCaption(Assessment_Type);
                        doc.ExportCaption(AssessmentDate);
                        doc.ExportCaption(AssessmentTime);
                        doc.ExportCaption(isAssessmentDone);
                        doc.ExportCaption(AssessmentScore);
                        doc.ExportCaption(Assessment_Instructor);
                        doc.ExportCaption(IsDrivingexperience);
                        doc.ExportCaption(intDrivinglicenseType);
                        doc.ExportCaption(AbsherApptNbr);
                        doc.ExportCaption(Absherphoto);
                        doc.ExportCaption(date_Birth);
                        doc.ExportCaption(date_Birth_Hijri);
                        doc.ExportCaption(str_Cell_Phone);
                        doc.ExportCaption(str_Email);
                        doc.ExportCaption(Institution);
                        doc.ExportCaption(TheoreticalScore);
                        doc.ExportCaption(dt_TheoreticalScore);
                        doc.ExportCaption(RoadTestScore);
                        doc.ExportCaption(dt_RoadTestScore);
                        doc.ExportCaption(AccidentOccurrence);
                        doc.ExportCaption(Dt_AccidentOccurrence);
                        doc.ExportCaption(AccidentNotes);
                    } else {
                        doc.ExportCaption(AssessmentID);
                        doc.ExportCaption(str_Full_Name_Hdr);
                        doc.ExportCaption(str_First_Name);
                        doc.ExportCaption(str_Middle_Name);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(int_Student_ID);
                        doc.ExportCaption(Assessment_Type);
                        doc.ExportCaption(AssessmentDate);
                        doc.ExportCaption(AssessmentTime);
                        doc.ExportCaption(isAssessmentDone);
                        doc.ExportCaption(AssessmentScore);
                        doc.ExportCaption(Assessment_Instructor);
                        doc.ExportCaption(Date_Entered);
                        doc.ExportCaption(IsDrivingexperience);
                        doc.ExportCaption(intDrivinglicenseType);
                        doc.ExportCaption(AbsherApptNbr);
                        doc.ExportCaption(Absherphoto);
                        doc.ExportCaption(date_Birth);
                        doc.ExportCaption(date_Birth_Hijri);
                        doc.ExportCaption(str_Cell_Phone);
                        doc.ExportCaption(str_Email);
                        doc.ExportCaption(UserlevelID);
                        doc.ExportCaption(Calendar_ID);
                        doc.ExportCaption(Assessmnt_Time);
                        doc.ExportCaption(Institution);
                        doc.ExportCaption(TheoreticalScore);
                        doc.ExportCaption(dt_TheoreticalScore);
                        doc.ExportCaption(RoadTestScore);
                        doc.ExportCaption(dt_RoadTestScore);
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
                            await doc.ExportField(str_Full_Name_Hdr);
                            await doc.ExportField(Assessment_Type);
                            await doc.ExportField(AssessmentDate);
                            await doc.ExportField(AssessmentTime);
                            await doc.ExportField(isAssessmentDone);
                            await doc.ExportField(AssessmentScore);
                            await doc.ExportField(Assessment_Instructor);
                            await doc.ExportField(IsDrivingexperience);
                            await doc.ExportField(intDrivinglicenseType);
                            await doc.ExportField(AbsherApptNbr);
                            await doc.ExportField(Absherphoto);
                            await doc.ExportField(date_Birth);
                            await doc.ExportField(date_Birth_Hijri);
                            await doc.ExportField(str_Cell_Phone);
                            await doc.ExportField(str_Email);
                            await doc.ExportField(Institution);
                            await doc.ExportField(TheoreticalScore);
                            await doc.ExportField(dt_TheoreticalScore);
                            await doc.ExportField(RoadTestScore);
                            await doc.ExportField(dt_RoadTestScore);
                            await doc.ExportField(AccidentOccurrence);
                            await doc.ExportField(Dt_AccidentOccurrence);
                            await doc.ExportField(AccidentNotes);
                        } else {
                            await doc.ExportField(AssessmentID);
                            await doc.ExportField(str_Full_Name_Hdr);
                            await doc.ExportField(str_First_Name);
                            await doc.ExportField(str_Middle_Name);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(int_Student_ID);
                            await doc.ExportField(Assessment_Type);
                            await doc.ExportField(AssessmentDate);
                            await doc.ExportField(AssessmentTime);
                            await doc.ExportField(isAssessmentDone);
                            await doc.ExportField(AssessmentScore);
                            await doc.ExportField(Assessment_Instructor);
                            await doc.ExportField(Date_Entered);
                            await doc.ExportField(IsDrivingexperience);
                            await doc.ExportField(intDrivinglicenseType);
                            await doc.ExportField(AbsherApptNbr);
                            await doc.ExportField(Absherphoto);
                            await doc.ExportField(date_Birth);
                            await doc.ExportField(date_Birth_Hijri);
                            await doc.ExportField(str_Cell_Phone);
                            await doc.ExportField(str_Email);
                            await doc.ExportField(UserlevelID);
                            await doc.ExportField(Calendar_ID);
                            await doc.ExportField(Assessmnt_Time);
                            await doc.ExportField(Institution);
                            await doc.ExportField(TheoreticalScore);
                            await doc.ExportField(dt_TheoreticalScore);
                            await doc.ExportField(RoadTestScore);
                            await doc.ExportField(dt_RoadTestScore);
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
            string sql = "SELECT " + masterfld.Expression + " FROM dbo.tblAssessment";
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

        // Add master User ID filter
        public string AddMasterUserIDFilter(string filter, string currentMasterTable)
        {
            string? filterWrk = filter;
            if (currentMasterTable == "tblStudents") {
                filterWrk = tblStudents?.AddUserIDFilter(filterWrk);
            }
            return filterWrk ?? "";
        }

        // Add detail User ID filter
        public string AddDetailUserIDFilter(string filter, string currentMasterTable)
        {
            string filterWrk = filter;
            if (currentMasterTable == "tblStudents") {
                if (tblStudents != null && !tblStudents.UserIDAllow())
                    AddFilter(ref filterWrk, tblStudents.GetUserIDSubquery(str_Username, tblStudents.str_Username));
            }
            return filterWrk;
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
            if (SameText(fldparm, "Absherphoto")) {
                fldName = "Absherphoto";
                fileNameFld = "Absherphoto";
            } else {
                return JsonBoolResult.FalseResult; // Incorrect field
            }

            // Set up key values
            if (keys.Length == 1) {
                AssessmentID.CurrentValue = keys[0];
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
        public async Task WriteAuditTrailLog(string log) => await WriteAuditTrailAsync(CurrentUser(), log, "tblAssessment");

        // Write audit trail (add page)
        public async Task WriteAuditTrailOnAdd(IDictionary<string, object> rs)
        {
            if (!AuditTrailOnAdd)
                return;
            string table = "tblAssessment";

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
            string table = "tblAssessment";

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
            string table = "tblAssessment";

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
            string table = "tblAssessment";
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
        //Insert Assessment Calendar Content #1
        string sInsertSq20 = "INS_ASSESSMENT_CLDR_CONTENT";
        Execute (sInsertSq20);  

        //Update Assessment Table w Calendar ID #2
        string sUpdateSq20 = "UPD_ASSESSMNT_CLDR_ID";
        Execute (sUpdateSq20);  

        //Update Assessment Calendar w Assessment #1, #2
        string sUpdateSq21 = "UPD_CLDR_ASSESSMENT";
        Execute (sUpdateSq21);  

        //Update AssessmentDate w 00:00 to 23:59
        string sUpdateSq22 = "UPD_ASSESSMENTDT_MIDNIGHT";
        Execute (sUpdateSq22); 
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
