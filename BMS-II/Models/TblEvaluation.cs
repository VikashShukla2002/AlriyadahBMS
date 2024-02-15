namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblEvaluation
    /// </summary>
    [MaybeNull]
    public static TblEvaluation tblEvaluation
    {
        get => HttpData.Resolve<TblEvaluation>("tblEvaluation");
        set => HttpData["tblEvaluation"] = value;
    }

    /// <summary>
    /// Table class for tblEvaluation
    /// </summary>
    public class TblEvaluation : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> Eval_ID;

        public readonly DbField<SqlDbType> AssessmentID;

        public readonly DbField<SqlDbType> str_Full_Name_Hdr;

        public readonly DbField<SqlDbType> NationalID;

        public readonly DbField<SqlDbType> str_Cell_Phone;

        public readonly DbField<SqlDbType> int_Student_ID;

        public readonly DbField<SqlDbType> intDrivinglicenseType;

        public readonly DbField<SqlDbType> Date_Entered;

        public readonly DbField<SqlDbType> Examination_Number;

        public readonly DbField<SqlDbType> Section_1;

        public readonly DbField<SqlDbType> Q1;

        public readonly DbField<SqlDbType> Q2;

        public readonly DbField<SqlDbType> Q3;

        public readonly DbField<SqlDbType> Q4;

        public readonly DbField<SqlDbType> Q5;

        public readonly DbField<SqlDbType> Section_2;

        public readonly DbField<SqlDbType> Q6;

        public readonly DbField<SqlDbType> Q7;

        public readonly DbField<SqlDbType> Q8;

        public readonly DbField<SqlDbType> Q9;

        public readonly DbField<SqlDbType> Q10;

        public readonly DbField<SqlDbType> Q11;

        public readonly DbField<SqlDbType> Q12;

        public readonly DbField<SqlDbType> Q13;

        public readonly DbField<SqlDbType> Q14;

        public readonly DbField<SqlDbType> Q15;

        public readonly DbField<SqlDbType> Section_3;

        public readonly DbField<SqlDbType> Q16;

        public readonly DbField<SqlDbType> Q17;

        public readonly DbField<SqlDbType> Q18;

        public readonly DbField<SqlDbType> Q19;

        public readonly DbField<SqlDbType> Q20;

        public readonly DbField<SqlDbType> Q21;

        public readonly DbField<SqlDbType> Section_4;

        public readonly DbField<SqlDbType> Q22;

        public readonly DbField<SqlDbType> Q23;

        public readonly DbField<SqlDbType> Q24;

        public readonly DbField<SqlDbType> Q25;

        public readonly DbField<SqlDbType> Q26;

        public readonly DbField<SqlDbType> Section_5;

        public readonly DbField<SqlDbType> Q27;

        public readonly DbField<SqlDbType> Q28;

        public readonly DbField<SqlDbType> Q29;

        public readonly DbField<SqlDbType> Q30;

        public readonly DbField<SqlDbType> Q31;

        public readonly DbField<SqlDbType> Q32;

        public readonly DbField<SqlDbType> Q33;

        public readonly DbField<SqlDbType> Q34;

        public readonly DbField<SqlDbType> Q35;

        public readonly DbField<SqlDbType> Section_6;

        public readonly DbField<SqlDbType> Q36;

        public readonly DbField<SqlDbType> Q37;

        public readonly DbField<SqlDbType> Q38;

        public readonly DbField<SqlDbType> Q39;

        public readonly DbField<SqlDbType> Q40;

        public readonly DbField<SqlDbType> Q41;

        public readonly DbField<SqlDbType> Q42;

        public readonly DbField<SqlDbType> Q43;

        public readonly DbField<SqlDbType> Section_7;

        public readonly DbField<SqlDbType> Q44;

        public readonly DbField<SqlDbType> Q45;

        public readonly DbField<SqlDbType> Q46;

        public readonly DbField<SqlDbType> Q47;

        public readonly DbField<SqlDbType> Q48;

        public readonly DbField<SqlDbType> Q49;

        public readonly DbField<SqlDbType> Q50;

        public readonly DbField<SqlDbType> Section_8;

        public readonly DbField<SqlDbType> Q51;

        public readonly DbField<SqlDbType> Q52;

        public readonly DbField<SqlDbType> Q53;

        public readonly DbField<SqlDbType> Q54;

        public readonly DbField<SqlDbType> Q55;

        public readonly DbField<SqlDbType> Section_9;

        public readonly DbField<SqlDbType> Q56;

        public readonly DbField<SqlDbType> Q57;

        public readonly DbField<SqlDbType> Q58;

        public readonly DbField<SqlDbType> Q59;

        public readonly DbField<SqlDbType> Q60;

        public readonly DbField<SqlDbType> Section_10;

        public readonly DbField<SqlDbType> Q61;

        public readonly DbField<SqlDbType> Q62;

        public readonly DbField<SqlDbType> Q63;

        public readonly DbField<SqlDbType> Q64;

        public readonly DbField<SqlDbType> Q65;

        public readonly DbField<SqlDbType> Q66;

        public readonly DbField<SqlDbType> Section_11;

        public readonly DbField<SqlDbType> Q67;

        public readonly DbField<SqlDbType> Q68;

        public readonly DbField<SqlDbType> Q69;

        public readonly DbField<SqlDbType> Q70;

        public readonly DbField<SqlDbType> Notes_3;

        public readonly DbField<SqlDbType> Student_Signature;

        public readonly DbField<SqlDbType> Examiner_Signature;

        public readonly DbField<SqlDbType> str_Username;

        public readonly DbField<SqlDbType> Retake;

        public readonly DbField<SqlDbType> AbsherApptNbr;

        public readonly DbField<SqlDbType> IsDrivingexperience;

        public readonly DbField<SqlDbType> date_Birth_Hijri;

        public readonly DbField<SqlDbType> date_Birth;

        public readonly DbField<SqlDbType> str_Email;

        public readonly DbField<SqlDbType> UserlevelID;

        public readonly DbField<SqlDbType> Assigned_int_Package_Id;

        public readonly DbField<SqlDbType> Scores_S1;

        public readonly DbField<SqlDbType> S1;

        public readonly DbField<SqlDbType> S2;

        public readonly DbField<SqlDbType> S3;

        public readonly DbField<SqlDbType> S4;

        public readonly DbField<SqlDbType> S5;

        public readonly DbField<SqlDbType> Scores_S2;

        public readonly DbField<SqlDbType> S6;

        public readonly DbField<SqlDbType> S7;

        public readonly DbField<SqlDbType> S8;

        public readonly DbField<SqlDbType> S9;

        public readonly DbField<SqlDbType> S10;

        public readonly DbField<SqlDbType> S11;

        public readonly DbField<SqlDbType> S12;

        public readonly DbField<SqlDbType> S13;

        public readonly DbField<SqlDbType> S14;

        public readonly DbField<SqlDbType> S15;

        public readonly DbField<SqlDbType> Scores_S3;

        public readonly DbField<SqlDbType> S16;

        public readonly DbField<SqlDbType> S17;

        public readonly DbField<SqlDbType> S18;

        public readonly DbField<SqlDbType> S19;

        public readonly DbField<SqlDbType> S20;

        public readonly DbField<SqlDbType> S21;

        public readonly DbField<SqlDbType> Scores_S4;

        public readonly DbField<SqlDbType> S22;

        public readonly DbField<SqlDbType> S23;

        public readonly DbField<SqlDbType> S24;

        public readonly DbField<SqlDbType> S25;

        public readonly DbField<SqlDbType> S26;

        public readonly DbField<SqlDbType> Scores_S5;

        public readonly DbField<SqlDbType> S27;

        public readonly DbField<SqlDbType> S28;

        public readonly DbField<SqlDbType> S29;

        public readonly DbField<SqlDbType> S30;

        public readonly DbField<SqlDbType> S31;

        public readonly DbField<SqlDbType> S32;

        public readonly DbField<SqlDbType> S33;

        public readonly DbField<SqlDbType> S34;

        public readonly DbField<SqlDbType> S35;

        public readonly DbField<SqlDbType> Scores_S6;

        public readonly DbField<SqlDbType> S36;

        public readonly DbField<SqlDbType> S37;

        public readonly DbField<SqlDbType> S38;

        public readonly DbField<SqlDbType> S39;

        public readonly DbField<SqlDbType> S40;

        public readonly DbField<SqlDbType> S41;

        public readonly DbField<SqlDbType> S42;

        public readonly DbField<SqlDbType> S43;

        public readonly DbField<SqlDbType> Scores_S7;

        public readonly DbField<SqlDbType> S44;

        public readonly DbField<SqlDbType> S45;

        public readonly DbField<SqlDbType> S46;

        public readonly DbField<SqlDbType> S47;

        public readonly DbField<SqlDbType> S48;

        public readonly DbField<SqlDbType> S49;

        public readonly DbField<SqlDbType> S50;

        public readonly DbField<SqlDbType> Scores_S8;

        public readonly DbField<SqlDbType> S51;

        public readonly DbField<SqlDbType> S52;

        public readonly DbField<SqlDbType> S53;

        public readonly DbField<SqlDbType> S54;

        public readonly DbField<SqlDbType> S55;

        public readonly DbField<SqlDbType> Scores_S9;

        public readonly DbField<SqlDbType> S56;

        public readonly DbField<SqlDbType> S57;

        public readonly DbField<SqlDbType> S58;

        public readonly DbField<SqlDbType> S59;

        public readonly DbField<SqlDbType> Scores_S10;

        public readonly DbField<SqlDbType> S60;

        public readonly DbField<SqlDbType> S61;

        public readonly DbField<SqlDbType> S62;

        public readonly DbField<SqlDbType> S63;

        public readonly DbField<SqlDbType> S64;

        public readonly DbField<SqlDbType> S65;

        public readonly DbField<SqlDbType> Scores_S11;

        public readonly DbField<SqlDbType> S66;

        public readonly DbField<SqlDbType> S67;

        public readonly DbField<SqlDbType> S68;

        public readonly DbField<SqlDbType> S69;

        public readonly DbField<SqlDbType> S70;

        public readonly DbField<SqlDbType> DriveTypelink;

        public readonly DbField<SqlDbType> Evaluation_Score;

        public readonly DbField<SqlDbType> Immediate_Failure_Score;

        public readonly DbField<SqlDbType> Required_Program;

        public readonly DbField<SqlDbType> Price;

        public readonly DbField<SqlDbType> intEvaluationType;

        public readonly DbField<SqlDbType> Institution;

        // Constructor
        public TblEvaluation()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "tblEvaluation";
            Name = "tblEvaluation";
            Type = "TABLE";
            UpdateTable = "dbo.tblEvaluation"; // Update Table
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

            // Eval_ID
            Eval_ID = new (this, "x_Eval_ID", 3, SqlDbType.Int) {
                Name = "Eval_ID",
                Expression = "[Eval_ID]",
                BasicSearchExpression = "CAST([Eval_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Eval_ID]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Eval_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Eval_ID", Eval_ID);

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
                HtmlTag = "TEXT",
                InputTextType = "text",
                IsForeignKey = true, // Foreign key field
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "AssessmentID", "CustomMsg"),
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
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "str_Full_Name_Hdr", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Full_Name_Hdr", str_Full_Name_Hdr);

            // NationalID
            NationalID = new (this, "x_NationalID", 20, SqlDbType.BigInt) {
                Name = "NationalID",
                Expression = "[NationalID]",
                UseBasicSearch = true,
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "NationalID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("NationalID", NationalID);

            // str_Cell_Phone
            str_Cell_Phone = new (this, "x_str_Cell_Phone", 200, SqlDbType.VarChar) {
                Name = "str_Cell_Phone",
                Expression = "[str_Cell_Phone]",
                UseBasicSearch = true,
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
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "str_Cell_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Cell_Phone", str_Cell_Phone);

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
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "int_Student_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Student_ID", int_Student_ID);

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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "intDrivinglicenseType", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("intDrivinglicenseType", intDrivinglicenseType);

            // Date_Entered
            Date_Entered = new (this, "x_Date_Entered", 135, SqlDbType.DateTime) {
                Name = "Date_Entered",
                Expression = "[Date_Entered]",
                BasicSearchExpression = CastDateFieldForLike("[Date_Entered]", 16, "DB"),
                DateTimeFormat = 16,
                VirtualExpression = "[Date_Entered]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", DateFormat(16)),
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Date_Entered", "CustomMsg"),
                IsUpload = false
            };
            Date_Entered.GetAutoUpdateValue = () => CurrentDate();
            Fields.Add("Date_Entered", Date_Entered);

            // Examination_Number
            Examination_Number = new (this, "x_Examination_Number", 3, SqlDbType.Int) {
                Name = "Examination_Number",
                Expression = "[Examination_Number]",
                BasicSearchExpression = "CAST([Examination_Number] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Examination_Number]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Examination_Number", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Examination_Number", Examination_Number);

            // Section_1
            Section_1 = new (this, "x_Section_1", 200, SqlDbType.VarChar) {
                Name = "Section_1",
                Expression = "[Section_1]",
                BasicSearchExpression = "[Section_1]",
                DateTimeFormat = -1,
                VirtualExpression = "[Section_1]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Section_1", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Section_1", Section_1);

            // Q1
            Q1 = new (this, "x_Q1", 11, SqlDbType.Bit) {
                Name = "Q1",
                Expression = "[Q1]",
                BasicSearchExpression = "[Q1]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q1]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q1", "CustomMsg"),
                IsUpload = false
            };
            Q1.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q1, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q1, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q1, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q1", Q1);

            // Q2
            Q2 = new (this, "x_Q2", 11, SqlDbType.Bit) {
                Name = "Q2",
                Expression = "[Q2]",
                BasicSearchExpression = "[Q2]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q2]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q2", "CustomMsg"),
                IsUpload = false
            };
            Q2.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q2, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q2, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q2, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q2", Q2);

            // Q3
            Q3 = new (this, "x_Q3", 11, SqlDbType.Bit) {
                Name = "Q3",
                Expression = "[Q3]",
                BasicSearchExpression = "[Q3]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q3]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q3", "CustomMsg"),
                IsUpload = false
            };
            Q3.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q3, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q3, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q3, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q3", Q3);

            // Q4
            Q4 = new (this, "x_Q4", 11, SqlDbType.Bit) {
                Name = "Q4",
                Expression = "[Q4]",
                BasicSearchExpression = "[Q4]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q4]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q4", "CustomMsg"),
                IsUpload = false
            };
            Q4.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q4, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q4, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q4, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q4", Q4);

            // Q5
            Q5 = new (this, "x_Q5", 11, SqlDbType.Bit) {
                Name = "Q5",
                Expression = "[Q5]",
                BasicSearchExpression = "[Q5]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q5]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q5", "CustomMsg"),
                IsUpload = false
            };
            Q5.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q5, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q5, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q5, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q5", Q5);

            // Section_2
            Section_2 = new (this, "x_Section_2", 200, SqlDbType.VarChar) {
                Name = "Section_2",
                Expression = "[Section_2]",
                BasicSearchExpression = "[Section_2]",
                DateTimeFormat = -1,
                VirtualExpression = "[Section_2]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Section_2", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Section_2", Section_2);

            // Q6
            Q6 = new (this, "x_Q6", 11, SqlDbType.Bit) {
                Name = "Q6",
                Expression = "[Q6]",
                BasicSearchExpression = "[Q6]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q6]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q6", "CustomMsg"),
                IsUpload = false
            };
            Q6.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q6, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q6, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q6, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q6", Q6);

            // Q7
            Q7 = new (this, "x_Q7", 11, SqlDbType.Bit) {
                Name = "Q7",
                Expression = "[Q7]",
                BasicSearchExpression = "[Q7]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q7]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q7", "CustomMsg"),
                IsUpload = false
            };
            Q7.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q7, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q7, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q7, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q7", Q7);

            // Q8
            Q8 = new (this, "x_Q8", 11, SqlDbType.Bit) {
                Name = "Q8",
                Expression = "[Q8]",
                BasicSearchExpression = "[Q8]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q8]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q8", "CustomMsg"),
                IsUpload = false
            };
            Q8.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q8, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q8, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q8, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q8", Q8);

            // Q9
            Q9 = new (this, "x_Q9", 11, SqlDbType.Bit) {
                Name = "Q9",
                Expression = "[Q9]",
                BasicSearchExpression = "[Q9]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q9]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q9", "CustomMsg"),
                IsUpload = false
            };
            Q9.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q9, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q9, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q9, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q9", Q9);

            // Q10
            Q10 = new (this, "x_Q10", 11, SqlDbType.Bit) {
                Name = "Q10",
                Expression = "[Q10]",
                BasicSearchExpression = "[Q10]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q10]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q10", "CustomMsg"),
                IsUpload = false
            };
            Q10.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q10, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q10, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q10, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q10", Q10);

            // Q11
            Q11 = new (this, "x_Q11", 11, SqlDbType.Bit) {
                Name = "Q11",
                Expression = "[Q11]",
                BasicSearchExpression = "[Q11]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q11]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q11", "CustomMsg"),
                IsUpload = false
            };
            Q11.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q11, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q11, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q11, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q11", Q11);

            // Q12
            Q12 = new (this, "x_Q12", 11, SqlDbType.Bit) {
                Name = "Q12",
                Expression = "[Q12]",
                BasicSearchExpression = "[Q12]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q12]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q12", "CustomMsg"),
                IsUpload = false
            };
            Q12.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q12, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q12, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q12, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q12", Q12);

            // Q13
            Q13 = new (this, "x_Q13", 11, SqlDbType.Bit) {
                Name = "Q13",
                Expression = "[Q13]",
                BasicSearchExpression = "[Q13]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q13]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q13", "CustomMsg"),
                IsUpload = false
            };
            Q13.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q13, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q13, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q13, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q13", Q13);

            // Q14
            Q14 = new (this, "x_Q14", 11, SqlDbType.Bit) {
                Name = "Q14",
                Expression = "[Q14]",
                BasicSearchExpression = "[Q14]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q14]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q14", "CustomMsg"),
                IsUpload = false
            };
            Q14.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q14, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q14, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q14, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q14", Q14);

            // Q15
            Q15 = new (this, "x_Q15", 11, SqlDbType.Bit) {
                Name = "Q15",
                Expression = "[Q15]",
                BasicSearchExpression = "[Q15]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q15]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q15", "CustomMsg"),
                IsUpload = false
            };
            Q15.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q15, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q15, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q15, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q15", Q15);

            // Section_3
            Section_3 = new (this, "x_Section_3", 200, SqlDbType.VarChar) {
                Name = "Section_3",
                Expression = "[Section_3]",
                BasicSearchExpression = "[Section_3]",
                DateTimeFormat = -1,
                VirtualExpression = "[Section_3]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Section_3", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Section_3", Section_3);

            // Q16
            Q16 = new (this, "x_Q16", 11, SqlDbType.Bit) {
                Name = "Q16",
                Expression = "[Q16]",
                BasicSearchExpression = "[Q16]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q16]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q16", "CustomMsg"),
                IsUpload = false
            };
            Q16.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q16, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q16, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q16, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q16", Q16);

            // Q17
            Q17 = new (this, "x_Q17", 11, SqlDbType.Bit) {
                Name = "Q17",
                Expression = "[Q17]",
                BasicSearchExpression = "[Q17]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q17]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q17", "CustomMsg"),
                IsUpload = false
            };
            Q17.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q17, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q17, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q17, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q17", Q17);

            // Q18
            Q18 = new (this, "x_Q18", 11, SqlDbType.Bit) {
                Name = "Q18",
                Expression = "[Q18]",
                BasicSearchExpression = "[Q18]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q18]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q18", "CustomMsg"),
                IsUpload = false
            };
            Q18.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q18, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q18, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q18, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q18", Q18);

            // Q19
            Q19 = new (this, "x_Q19", 11, SqlDbType.Bit) {
                Name = "Q19",
                Expression = "[Q19]",
                BasicSearchExpression = "[Q19]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q19]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q19", "CustomMsg"),
                IsUpload = false
            };
            Q19.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q19, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q19, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q19, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q19", Q19);

            // Q20
            Q20 = new (this, "x_Q20", 11, SqlDbType.Bit) {
                Name = "Q20",
                Expression = "[Q20]",
                BasicSearchExpression = "[Q20]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q20]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q20", "CustomMsg"),
                IsUpload = false
            };
            Q20.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q20, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q20, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q20, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q20", Q20);

            // Q21
            Q21 = new (this, "x_Q21", 11, SqlDbType.Bit) {
                Name = "Q21",
                Expression = "[Q21]",
                BasicSearchExpression = "[Q21]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q21]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q21", "CustomMsg"),
                IsUpload = false
            };
            Q21.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q21, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q21, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q21, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q21", Q21);

            // Section_4
            Section_4 = new (this, "x_Section_4", 200, SqlDbType.VarChar) {
                Name = "Section_4",
                Expression = "[Section_4]",
                BasicSearchExpression = "[Section_4]",
                DateTimeFormat = -1,
                VirtualExpression = "[Section_4]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Section_4", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Section_4", Section_4);

            // Q22
            Q22 = new (this, "x_Q22", 11, SqlDbType.Bit) {
                Name = "Q22",
                Expression = "[Q22]",
                BasicSearchExpression = "[Q22]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q22]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q22", "CustomMsg"),
                IsUpload = false
            };
            Q22.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q22, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q22, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q22, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q22", Q22);

            // Q23
            Q23 = new (this, "x_Q23", 11, SqlDbType.Bit) {
                Name = "Q23",
                Expression = "[Q23]",
                BasicSearchExpression = "[Q23]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q23]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q23", "CustomMsg"),
                IsUpload = false
            };
            Q23.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q23, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q23, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q23, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q23", Q23);

            // Q24
            Q24 = new (this, "x_Q24", 11, SqlDbType.Bit) {
                Name = "Q24",
                Expression = "[Q24]",
                BasicSearchExpression = "[Q24]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q24]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q24", "CustomMsg"),
                IsUpload = false
            };
            Q24.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q24, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q24, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q24, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q24", Q24);

            // Q25
            Q25 = new (this, "x_Q25", 11, SqlDbType.Bit) {
                Name = "Q25",
                Expression = "[Q25]",
                BasicSearchExpression = "[Q25]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q25]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q25", "CustomMsg"),
                IsUpload = false
            };
            Q25.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q25, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q25, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q25, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q25", Q25);

            // Q26
            Q26 = new (this, "x_Q26", 11, SqlDbType.Bit) {
                Name = "Q26",
                Expression = "[Q26]",
                BasicSearchExpression = "[Q26]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q26]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q26", "CustomMsg"),
                IsUpload = false
            };
            Q26.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q26, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q26, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q26, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q26", Q26);

            // Section_5
            Section_5 = new (this, "x_Section_5", 200, SqlDbType.VarChar) {
                Name = "Section_5",
                Expression = "[Section_5]",
                BasicSearchExpression = "[Section_5]",
                DateTimeFormat = -1,
                VirtualExpression = "[Section_5]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Section_5", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Section_5", Section_5);

            // Q27
            Q27 = new (this, "x_Q27", 11, SqlDbType.Bit) {
                Name = "Q27",
                Expression = "[Q27]",
                BasicSearchExpression = "[Q27]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q27]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q27", "CustomMsg"),
                IsUpload = false
            };
            Q27.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q27, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q27, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q27, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q27", Q27);

            // Q28
            Q28 = new (this, "x_Q28", 11, SqlDbType.Bit) {
                Name = "Q28",
                Expression = "[Q28]",
                BasicSearchExpression = "[Q28]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q28]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q28", "CustomMsg"),
                IsUpload = false
            };
            Q28.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q28, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q28, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q28, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q28", Q28);

            // Q29
            Q29 = new (this, "x_Q29", 11, SqlDbType.Bit) {
                Name = "Q29",
                Expression = "[Q29]",
                BasicSearchExpression = "[Q29]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q29]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q29", "CustomMsg"),
                IsUpload = false
            };
            Q29.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q29, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q29, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q29, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q29", Q29);

            // Q30
            Q30 = new (this, "x_Q30", 11, SqlDbType.Bit) {
                Name = "Q30",
                Expression = "[Q30]",
                BasicSearchExpression = "[Q30]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q30]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q30", "CustomMsg"),
                IsUpload = false
            };
            Q30.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q30, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q30, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q30, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q30", Q30);

            // Q31
            Q31 = new (this, "x_Q31", 11, SqlDbType.Bit) {
                Name = "Q31",
                Expression = "[Q31]",
                BasicSearchExpression = "[Q31]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q31]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q31", "CustomMsg"),
                IsUpload = false
            };
            Q31.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q31, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q31, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q31, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q31", Q31);

            // Q32
            Q32 = new (this, "x_Q32", 11, SqlDbType.Bit) {
                Name = "Q32",
                Expression = "[Q32]",
                BasicSearchExpression = "[Q32]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q32]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q32", "CustomMsg"),
                IsUpload = false
            };
            Q32.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q32, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q32, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q32, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q32", Q32);

            // Q33
            Q33 = new (this, "x_Q33", 11, SqlDbType.Bit) {
                Name = "Q33",
                Expression = "[Q33]",
                BasicSearchExpression = "[Q33]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q33]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q33", "CustomMsg"),
                IsUpload = false
            };
            Q33.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q33, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q33, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q33, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q33", Q33);

            // Q34
            Q34 = new (this, "x_Q34", 11, SqlDbType.Bit) {
                Name = "Q34",
                Expression = "[Q34]",
                BasicSearchExpression = "[Q34]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q34]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q34", "CustomMsg"),
                IsUpload = false
            };
            Q34.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q34, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q34, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q34, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q34", Q34);

            // Q35
            Q35 = new (this, "x_Q35", 11, SqlDbType.Bit) {
                Name = "Q35",
                Expression = "[Q35]",
                BasicSearchExpression = "[Q35]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q35]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q35", "CustomMsg"),
                IsUpload = false
            };
            Q35.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q35, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q35, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q35, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q35", Q35);

            // Section_6
            Section_6 = new (this, "x_Section_6", 200, SqlDbType.VarChar) {
                Name = "Section_6",
                Expression = "[Section_6]",
                BasicSearchExpression = "[Section_6]",
                DateTimeFormat = -1,
                VirtualExpression = "[Section_6]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Section_6", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Section_6", Section_6);

            // Q36
            Q36 = new (this, "x_Q36", 11, SqlDbType.Bit) {
                Name = "Q36",
                Expression = "[Q36]",
                BasicSearchExpression = "[Q36]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q36]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q36", "CustomMsg"),
                IsUpload = false
            };
            Q36.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q36, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q36, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q36, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q36", Q36);

            // Q37
            Q37 = new (this, "x_Q37", 11, SqlDbType.Bit) {
                Name = "Q37",
                Expression = "[Q37]",
                BasicSearchExpression = "[Q37]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q37]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q37", "CustomMsg"),
                IsUpload = false
            };
            Q37.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q37, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q37, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q37, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q37", Q37);

            // Q38
            Q38 = new (this, "x_Q38", 11, SqlDbType.Bit) {
                Name = "Q38",
                Expression = "[Q38]",
                BasicSearchExpression = "[Q38]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q38]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q38", "CustomMsg"),
                IsUpload = false
            };
            Q38.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q38, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q38, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q38, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q38", Q38);

            // Q39
            Q39 = new (this, "x_Q39", 11, SqlDbType.Bit) {
                Name = "Q39",
                Expression = "[Q39]",
                BasicSearchExpression = "[Q39]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q39]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q39", "CustomMsg"),
                IsUpload = false
            };
            Q39.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q39, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q39, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q39, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q39", Q39);

            // Q40
            Q40 = new (this, "x_Q40", 11, SqlDbType.Bit) {
                Name = "Q40",
                Expression = "[Q40]",
                BasicSearchExpression = "[Q40]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q40]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q40", "CustomMsg"),
                IsUpload = false
            };
            Q40.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q40, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q40, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q40, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q40", Q40);

            // Q41
            Q41 = new (this, "x_Q41", 11, SqlDbType.Bit) {
                Name = "Q41",
                Expression = "[Q41]",
                BasicSearchExpression = "[Q41]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q41]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q41", "CustomMsg"),
                IsUpload = false
            };
            Q41.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q41, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q41, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q41, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q41", Q41);

            // Q42
            Q42 = new (this, "x_Q42", 11, SqlDbType.Bit) {
                Name = "Q42",
                Expression = "[Q42]",
                BasicSearchExpression = "[Q42]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q42]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q42", "CustomMsg"),
                IsUpload = false
            };
            Q42.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q42, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q42, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q42, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q42", Q42);

            // Q43
            Q43 = new (this, "x_Q43", 11, SqlDbType.Bit) {
                Name = "Q43",
                Expression = "[Q43]",
                BasicSearchExpression = "[Q43]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q43]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q43", "CustomMsg"),
                IsUpload = false
            };
            Q43.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q43, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q43, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q43, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q43", Q43);

            // Section_7
            Section_7 = new (this, "x_Section_7", 200, SqlDbType.VarChar) {
                Name = "Section_7",
                Expression = "[Section_7]",
                BasicSearchExpression = "[Section_7]",
                DateTimeFormat = -1,
                VirtualExpression = "[Section_7]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Section_7", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Section_7", Section_7);

            // Q44
            Q44 = new (this, "x_Q44", 11, SqlDbType.Bit) {
                Name = "Q44",
                Expression = "[Q44]",
                BasicSearchExpression = "[Q44]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q44]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q44", "CustomMsg"),
                IsUpload = false
            };
            Q44.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q44, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q44, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q44, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q44", Q44);

            // Q45
            Q45 = new (this, "x_Q45", 11, SqlDbType.Bit) {
                Name = "Q45",
                Expression = "[Q45]",
                BasicSearchExpression = "[Q45]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q45]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q45", "CustomMsg"),
                IsUpload = false
            };
            Q45.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q45, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q45, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q45, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q45", Q45);

            // Q46
            Q46 = new (this, "x_Q46", 11, SqlDbType.Bit) {
                Name = "Q46",
                Expression = "[Q46]",
                BasicSearchExpression = "[Q46]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q46]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q46", "CustomMsg"),
                IsUpload = false
            };
            Q46.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q46, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q46, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q46, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q46", Q46);

            // Q47
            Q47 = new (this, "x_Q47", 11, SqlDbType.Bit) {
                Name = "Q47",
                Expression = "[Q47]",
                BasicSearchExpression = "[Q47]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q47]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q47", "CustomMsg"),
                IsUpload = false
            };
            Q47.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q47, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q47, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q47, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q47", Q47);

            // Q48
            Q48 = new (this, "x_Q48", 11, SqlDbType.Bit) {
                Name = "Q48",
                Expression = "[Q48]",
                BasicSearchExpression = "[Q48]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q48]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q48", "CustomMsg"),
                IsUpload = false
            };
            Q48.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q48, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q48, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q48, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q48", Q48);

            // Q49
            Q49 = new (this, "x_Q49", 11, SqlDbType.Bit) {
                Name = "Q49",
                Expression = "[Q49]",
                BasicSearchExpression = "[Q49]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q49]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q49", "CustomMsg"),
                IsUpload = false
            };
            Q49.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q49, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q49, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q49, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q49", Q49);

            // Q50
            Q50 = new (this, "x_Q50", 11, SqlDbType.Bit) {
                Name = "Q50",
                Expression = "[Q50]",
                BasicSearchExpression = "[Q50]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q50]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q50", "CustomMsg"),
                IsUpload = false
            };
            Q50.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q50, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q50, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q50, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q50", Q50);

            // Section_8
            Section_8 = new (this, "x_Section_8", 200, SqlDbType.VarChar) {
                Name = "Section_8",
                Expression = "[Section_8]",
                BasicSearchExpression = "[Section_8]",
                DateTimeFormat = -1,
                VirtualExpression = "[Section_8]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Section_8", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Section_8", Section_8);

            // Q51
            Q51 = new (this, "x_Q51", 11, SqlDbType.Bit) {
                Name = "Q51",
                Expression = "[Q51]",
                BasicSearchExpression = "[Q51]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q51]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q51", "CustomMsg"),
                IsUpload = false
            };
            Q51.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q51, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q51, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q51, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q51", Q51);

            // Q52
            Q52 = new (this, "x_Q52", 11, SqlDbType.Bit) {
                Name = "Q52",
                Expression = "[Q52]",
                BasicSearchExpression = "[Q52]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q52]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q52", "CustomMsg"),
                IsUpload = false
            };
            Q52.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q52, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q52, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q52, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q52", Q52);

            // Q53
            Q53 = new (this, "x_Q53", 11, SqlDbType.Bit) {
                Name = "Q53",
                Expression = "[Q53]",
                BasicSearchExpression = "[Q53]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q53]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q53", "CustomMsg"),
                IsUpload = false
            };
            Q53.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q53, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q53, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q53, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q53", Q53);

            // Q54
            Q54 = new (this, "x_Q54", 11, SqlDbType.Bit) {
                Name = "Q54",
                Expression = "[Q54]",
                BasicSearchExpression = "[Q54]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q54]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q54", "CustomMsg"),
                IsUpload = false
            };
            Q54.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q54, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q54, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q54, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q54", Q54);

            // Q55
            Q55 = new (this, "x_Q55", 11, SqlDbType.Bit) {
                Name = "Q55",
                Expression = "[Q55]",
                BasicSearchExpression = "[Q55]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q55]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q55", "CustomMsg"),
                IsUpload = false
            };
            Q55.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q55, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q55, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q55, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q55", Q55);

            // Section_9
            Section_9 = new (this, "x_Section_9", 200, SqlDbType.VarChar) {
                Name = "Section_9",
                Expression = "[Section_9]",
                BasicSearchExpression = "[Section_9]",
                DateTimeFormat = -1,
                VirtualExpression = "[Section_9]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Section_9", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Section_9", Section_9);

            // Q56
            Q56 = new (this, "x_Q56", 11, SqlDbType.Bit) {
                Name = "Q56",
                Expression = "[Q56]",
                BasicSearchExpression = "[Q56]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q56]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q56", "CustomMsg"),
                IsUpload = false
            };
            Q56.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q56, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q56, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q56, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q56", Q56);

            // Q57
            Q57 = new (this, "x_Q57", 11, SqlDbType.Bit) {
                Name = "Q57",
                Expression = "[Q57]",
                BasicSearchExpression = "[Q57]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q57]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q57", "CustomMsg"),
                IsUpload = false
            };
            Q57.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q57, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q57, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q57, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q57", Q57);

            // Q58
            Q58 = new (this, "x_Q58", 11, SqlDbType.Bit) {
                Name = "Q58",
                Expression = "[Q58]",
                BasicSearchExpression = "[Q58]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q58]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q58", "CustomMsg"),
                IsUpload = false
            };
            Q58.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q58, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q58, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q58, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q58", Q58);

            // Q59
            Q59 = new (this, "x_Q59", 11, SqlDbType.Bit) {
                Name = "Q59",
                Expression = "[Q59]",
                BasicSearchExpression = "[Q59]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q59]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q59", "CustomMsg"),
                IsUpload = false
            };
            Q59.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q59, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q59, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q59, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q59", Q59);

            // Q60
            Q60 = new (this, "x_Q60", 11, SqlDbType.Bit) {
                Name = "Q60",
                Expression = "[Q60]",
                BasicSearchExpression = "[Q60]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q60]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q60", "CustomMsg"),
                IsUpload = false
            };
            Q60.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q60, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q60, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q60, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q60", Q60);

            // Section_10
            Section_10 = new (this, "x_Section_10", 200, SqlDbType.VarChar) {
                Name = "Section_10",
                Expression = "[Section_10]",
                BasicSearchExpression = "[Section_10]",
                DateTimeFormat = -1,
                VirtualExpression = "[Section_10]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Section_10", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Section_10", Section_10);

            // Q61
            Q61 = new (this, "x_Q61", 11, SqlDbType.Bit) {
                Name = "Q61",
                Expression = "[Q61]",
                BasicSearchExpression = "[Q61]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q61]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q61", "CustomMsg"),
                IsUpload = false
            };
            Q61.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q61, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q61, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q61, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q61", Q61);

            // Q62
            Q62 = new (this, "x_Q62", 11, SqlDbType.Bit) {
                Name = "Q62",
                Expression = "[Q62]",
                BasicSearchExpression = "[Q62]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q62]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q62", "CustomMsg"),
                IsUpload = false
            };
            Q62.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q62, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q62, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q62, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q62", Q62);

            // Q63
            Q63 = new (this, "x_Q63", 11, SqlDbType.Bit) {
                Name = "Q63",
                Expression = "[Q63]",
                BasicSearchExpression = "[Q63]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q63]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q63", "CustomMsg"),
                IsUpload = false
            };
            Q63.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q63, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q63, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q63, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q63", Q63);

            // Q64
            Q64 = new (this, "x_Q64", 11, SqlDbType.Bit) {
                Name = "Q64",
                Expression = "[Q64]",
                BasicSearchExpression = "[Q64]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q64]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q64", "CustomMsg"),
                IsUpload = false
            };
            Q64.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q64, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q64, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q64, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q64", Q64);

            // Q65
            Q65 = new (this, "x_Q65", 11, SqlDbType.Bit) {
                Name = "Q65",
                Expression = "[Q65]",
                BasicSearchExpression = "[Q65]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q65]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q65", "CustomMsg"),
                IsUpload = false
            };
            Q65.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q65, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q65, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q65, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q65", Q65);

            // Q66
            Q66 = new (this, "x_Q66", 11, SqlDbType.Bit) {
                Name = "Q66",
                Expression = "[Q66]",
                BasicSearchExpression = "[Q66]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q66]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q66", "CustomMsg"),
                IsUpload = false
            };
            Q66.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q66, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q66, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q66, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q66", Q66);

            // Section_11
            Section_11 = new (this, "x_Section_11", 200, SqlDbType.VarChar) {
                Name = "Section_11",
                Expression = "[Section_11]",
                BasicSearchExpression = "[Section_11]",
                DateTimeFormat = -1,
                VirtualExpression = "[Section_11]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Section_11", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Section_11", Section_11);

            // Q67
            Q67 = new (this, "x_Q67", 11, SqlDbType.Bit) {
                Name = "Q67",
                Expression = "[Q67]",
                BasicSearchExpression = "[Q67]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q67]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q67", "CustomMsg"),
                IsUpload = false
            };
            Q67.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q67, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q67, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q67, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q67", Q67);

            // Q68
            Q68 = new (this, "x_Q68", 11, SqlDbType.Bit) {
                Name = "Q68",
                Expression = "[Q68]",
                BasicSearchExpression = "[Q68]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q68]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q68", "CustomMsg"),
                IsUpload = false
            };
            Q68.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q68, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q68, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q68, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q68", Q68);

            // Q69
            Q69 = new (this, "x_Q69", 11, SqlDbType.Bit) {
                Name = "Q69",
                Expression = "[Q69]",
                BasicSearchExpression = "[Q69]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q69]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q69", "CustomMsg"),
                IsUpload = false
            };
            Q69.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q69, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q69, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q69, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q69", Q69);

            // Q70
            Q70 = new (this, "x_Q70", 11, SqlDbType.Bit) {
                Name = "Q70",
                Expression = "[Q70]",
                BasicSearchExpression = "[Q70]",
                DateTimeFormat = -1,
                VirtualExpression = "[Q70]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Q70", "CustomMsg"),
                IsUpload = false
            };
            Q70.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Q70, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Q70, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Q70, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Q70", Q70);

            // Notes_3
            Notes_3 = new (this, "x_Notes_3", 203, SqlDbType.NText) {
                Name = "Notes_3",
                Expression = "[Notes_3]",
                BasicSearchExpression = "[Notes_3]",
                DateTimeFormat = -1,
                VirtualExpression = "[Notes_3]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Notes_3", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Notes_3", Notes_3);

            // Student_Signature
            Student_Signature = new (this, "x_Student_Signature", 203, SqlDbType.NText) {
                Name = "Student_Signature",
                Expression = "[Student_Signature]",
                BasicSearchExpression = "[Student_Signature]",
                DateTimeFormat = -1,
                VirtualExpression = "[Student_Signature]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                Sortable = false, // Allow sort
                TruncateMemoRemoveHtml = true,
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Student_Signature", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Student_Signature", Student_Signature);

            // Examiner_Signature
            Examiner_Signature = new (this, "x_Examiner_Signature", 203, SqlDbType.NText) {
                Name = "Examiner_Signature",
                Expression = "[Examiner_Signature]",
                BasicSearchExpression = "[Examiner_Signature]",
                DateTimeFormat = -1,
                VirtualExpression = "[Examiner_Signature]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                Sortable = false, // Allow sort
                TruncateMemoRemoveHtml = true,
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Examiner_Signature", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Examiner_Signature", Examiner_Signature);

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
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "str_Username", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Username", str_Username);

            // Retake
            Retake = new (this, "x_Retake", 11, SqlDbType.Bit) {
                Name = "Retake",
                Expression = "[Retake]",
                BasicSearchExpression = "[Retake]",
                DateTimeFormat = -1,
                VirtualExpression = "[Retake]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Retake", "CustomMsg"),
                IsUpload = false
            };
            Retake.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Retake, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Retake, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Retake, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Retake", Retake);

            // AbsherApptNbr
            AbsherApptNbr = new (this, "x_AbsherApptNbr", 202, SqlDbType.NVarChar) {
                Name = "AbsherApptNbr",
                Expression = "[AbsherApptNbr]",
                UseBasicSearch = true,
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "AbsherApptNbr", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("AbsherApptNbr", AbsherApptNbr);

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
                Sortable = false, // Allow sort
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "IsDrivingexperience", "CustomMsg"),
                IsUpload = false
            };
            IsDrivingexperience.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(IsDrivingexperience, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(IsDrivingexperience, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(IsDrivingexperience, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("IsDrivingexperience", IsDrivingexperience);

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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "date_Birth_Hijri", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Birth_Hijri", date_Birth_Hijri);

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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "date_Birth", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Birth", date_Birth);

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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "str_Email", "CustomMsg"),
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
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                Sortable = false, // Allow sort
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "UserlevelID", "CustomMsg"),
                IsUpload = false
            };
            UserlevelID.GetAutoUpdateValue = () => CurrentUserLevel();
            Fields.Add("UserlevelID", UserlevelID);

            // Assigned_int_Package_Id
            Assigned_int_Package_Id = new (this, "x_Assigned_int_Package_Id", 3, SqlDbType.Int) {
                Name = "Assigned_int_Package_Id",
                Expression = "[Assigned_int_Package_Id]",
                BasicSearchExpression = "CAST([Assigned_int_Package_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Assigned_int_Package_Id]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Assigned_int_Package_Id", "CustomMsg"),
                IsUpload = false
            };
            Assigned_int_Package_Id.GetDefault = () => 16;
            Fields.Add("Assigned_int_Package_Id", Assigned_int_Package_Id);

            // Scores_S1
            Scores_S1 = new (this, "x_Scores_S1", 200, SqlDbType.VarChar) {
                Name = "Scores_S1",
                Expression = "[Scores_S1]",
                BasicSearchExpression = "[Scores_S1]",
                DateTimeFormat = -1,
                VirtualExpression = "[Scores_S1]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Scores_S1", "CustomMsg"),
                IsUpload = false
            };
            Scores_S1.GetDefault = () => "(Performance Standards) Safety Check";
            Fields.Add("Scores_S1", Scores_S1);

            // S1
            S1 = new (this, "x_S1", 11, SqlDbType.Bit) {
                Name = "S1",
                Expression = "[S1]",
                BasicSearchExpression = "[S1]",
                DateTimeFormat = -1,
                VirtualExpression = "[S1]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S1", "CustomMsg"),
                IsUpload = false
            };
            S1.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S1, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S1, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S1, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S1", S1);

            // S2
            S2 = new (this, "x_S2", 11, SqlDbType.Bit) {
                Name = "S2",
                Expression = "[S2]",
                BasicSearchExpression = "[S2]",
                DateTimeFormat = -1,
                VirtualExpression = "[S2]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S2", "CustomMsg"),
                IsUpload = false
            };
            S2.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S2, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S2, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S2, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S2", S2);

            // S3
            S3 = new (this, "x_S3", 11, SqlDbType.Bit) {
                Name = "S3",
                Expression = "[S3]",
                BasicSearchExpression = "[S3]",
                DateTimeFormat = -1,
                VirtualExpression = "[S3]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S3", "CustomMsg"),
                IsUpload = false
            };
            S3.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S3, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S3, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S3, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S3", S3);

            // S4
            S4 = new (this, "x_S4", 11, SqlDbType.Bit) {
                Name = "S4",
                Expression = "[S4]",
                BasicSearchExpression = "[S4]",
                DateTimeFormat = -1,
                VirtualExpression = "[S4]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S4", "CustomMsg"),
                IsUpload = false
            };
            S4.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S4, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S4, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S4, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S4", S4);

            // S5
            S5 = new (this, "x_S5", 11, SqlDbType.Bit) {
                Name = "S5",
                Expression = "[S5]",
                BasicSearchExpression = "[S5]",
                DateTimeFormat = -1,
                VirtualExpression = "[S5]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S5", "CustomMsg"),
                IsUpload = false
            };
            S5.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S5, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S5, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S5, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S5", S5);

            // Scores_S2
            Scores_S2 = new (this, "x_Scores_S2", 200, SqlDbType.VarChar) {
                Name = "Scores_S2",
                Expression = "[Scores_S2]",
                BasicSearchExpression = "[Scores_S2]",
                DateTimeFormat = -1,
                VirtualExpression = "[Scores_S2]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Scores_S2", "CustomMsg"),
                IsUpload = false
            };
            Scores_S2.GetDefault = () => "(Performance Criteria) Position (Parallel - Reverse 90)";
            Fields.Add("Scores_S2", Scores_S2);

            // S6
            S6 = new (this, "x_S6", 11, SqlDbType.Bit) {
                Name = "S6",
                Expression = "[S6]",
                BasicSearchExpression = "[S6]",
                DateTimeFormat = -1,
                VirtualExpression = "[S6]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S6", "CustomMsg"),
                IsUpload = false
            };
            S6.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S6, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S6, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S6, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S6", S6);

            // S7
            S7 = new (this, "x_S7", 11, SqlDbType.Bit) {
                Name = "S7",
                Expression = "[S7]",
                BasicSearchExpression = "[S7]",
                DateTimeFormat = -1,
                VirtualExpression = "[S7]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S7", "CustomMsg"),
                IsUpload = false
            };
            S7.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S7, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S7, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S7, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S7", S7);

            // S8
            S8 = new (this, "x_S8", 11, SqlDbType.Bit) {
                Name = "S8",
                Expression = "[S8]",
                BasicSearchExpression = "[S8]",
                DateTimeFormat = -1,
                VirtualExpression = "[S8]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S8", "CustomMsg"),
                IsUpload = false
            };
            S8.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S8, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S8, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S8, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S8", S8);

            // S9
            S9 = new (this, "x_S9", 11, SqlDbType.Bit) {
                Name = "S9",
                Expression = "[S9]",
                BasicSearchExpression = "[S9]",
                DateTimeFormat = -1,
                VirtualExpression = "[S9]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S9", "CustomMsg"),
                IsUpload = false
            };
            S9.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S9, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S9, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S9, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S9", S9);

            // S10
            S10 = new (this, "x_S10", 11, SqlDbType.Bit) {
                Name = "S10",
                Expression = "[S10]",
                BasicSearchExpression = "[S10]",
                DateTimeFormat = -1,
                VirtualExpression = "[S10]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S10", "CustomMsg"),
                IsUpload = false
            };
            S10.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S10, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S10, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S10, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S10", S10);

            // S11
            S11 = new (this, "x_S11", 11, SqlDbType.Bit) {
                Name = "S11",
                Expression = "[S11]",
                BasicSearchExpression = "[S11]",
                DateTimeFormat = -1,
                VirtualExpression = "[S11]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S11", "CustomMsg"),
                IsUpload = false
            };
            S11.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S11, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S11, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S11, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S11", S11);

            // S12
            S12 = new (this, "x_S12", 11, SqlDbType.Bit) {
                Name = "S12",
                Expression = "[S12]",
                BasicSearchExpression = "[S12]",
                DateTimeFormat = -1,
                VirtualExpression = "[S12]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S12", "CustomMsg"),
                IsUpload = false
            };
            S12.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S12, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S12, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S12, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S12", S12);

            // S13
            S13 = new (this, "x_S13", 11, SqlDbType.Bit) {
                Name = "S13",
                Expression = "[S13]",
                BasicSearchExpression = "[S13]",
                DateTimeFormat = -1,
                VirtualExpression = "[S13]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S13", "CustomMsg"),
                IsUpload = false
            };
            S13.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S13, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S13, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S13, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S13", S13);

            // S14
            S14 = new (this, "x_S14", 11, SqlDbType.Bit) {
                Name = "S14",
                Expression = "[S14]",
                BasicSearchExpression = "[S14]",
                DateTimeFormat = -1,
                VirtualExpression = "[S14]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S14", "CustomMsg"),
                IsUpload = false
            };
            S14.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S14, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S14, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S14, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S14", S14);

            // S15
            S15 = new (this, "x_S15", 11, SqlDbType.Bit) {
                Name = "S15",
                Expression = "[S15]",
                BasicSearchExpression = "[S15]",
                DateTimeFormat = -1,
                VirtualExpression = "[S15]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S15", "CustomMsg"),
                IsUpload = false
            };
            S15.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S15, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S15, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S15, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S15", S15);

            // Scores_S3
            Scores_S3 = new (this, "x_Scores_S3", 200, SqlDbType.VarChar) {
                Name = "Scores_S3",
                Expression = "[Scores_S3]",
                BasicSearchExpression = "[Scores_S3]",
                DateTimeFormat = -1,
                VirtualExpression = "[Scores_S3]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Scores_S3", "CustomMsg"),
                IsUpload = false
            };
            Scores_S3.GetDefault = () => "(Performance criteria) Motion and stop";
            Fields.Add("Scores_S3", Scores_S3);

            // S16
            S16 = new (this, "x_S16", 11, SqlDbType.Bit) {
                Name = "S16",
                Expression = "[S16]",
                BasicSearchExpression = "[S16]",
                DateTimeFormat = -1,
                VirtualExpression = "[S16]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S16", "CustomMsg"),
                IsUpload = false
            };
            S16.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S16, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S16, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S16, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S16", S16);

            // S17
            S17 = new (this, "x_S17", 11, SqlDbType.Bit) {
                Name = "S17",
                Expression = "[S17]",
                BasicSearchExpression = "[S17]",
                DateTimeFormat = -1,
                VirtualExpression = "[S17]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S17", "CustomMsg"),
                IsUpload = false
            };
            S17.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S17, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S17, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S17, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S17", S17);

            // S18
            S18 = new (this, "x_S18", 11, SqlDbType.Bit) {
                Name = "S18",
                Expression = "[S18]",
                BasicSearchExpression = "[S18]",
                DateTimeFormat = -1,
                VirtualExpression = "[S18]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S18", "CustomMsg"),
                IsUpload = false
            };
            S18.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S18, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S18, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S18, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S18", S18);

            // S19
            S19 = new (this, "x_S19", 11, SqlDbType.Bit) {
                Name = "S19",
                Expression = "[S19]",
                BasicSearchExpression = "[S19]",
                DateTimeFormat = -1,
                VirtualExpression = "[S19]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S19", "CustomMsg"),
                IsUpload = false
            };
            S19.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S19, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S19, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S19, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S19", S19);

            // S20
            S20 = new (this, "x_S20", 11, SqlDbType.Bit) {
                Name = "S20",
                Expression = "[S20]",
                BasicSearchExpression = "[S20]",
                DateTimeFormat = -1,
                VirtualExpression = "[S20]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S20", "CustomMsg"),
                IsUpload = false
            };
            S20.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S20, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S20, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S20, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S20", S20);

            // S21
            S21 = new (this, "x_S21", 11, SqlDbType.Bit) {
                Name = "S21",
                Expression = "[S21]",
                BasicSearchExpression = "[S21]",
                DateTimeFormat = -1,
                VirtualExpression = "[S21]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S21", "CustomMsg"),
                IsUpload = false
            };
            S21.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S21, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S21, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S21, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S21", S21);

            // Scores_S4
            Scores_S4 = new (this, "x_Scores_S4", 200, SqlDbType.VarChar) {
                Name = "Scores_S4",
                Expression = "[Scores_S4]",
                BasicSearchExpression = "[Scores_S4]",
                DateTimeFormat = -1,
                VirtualExpression = "[Scores_S4]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Scores_S4", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Scores_S4", Scores_S4);

            // S22
            S22 = new (this, "x_S22", 11, SqlDbType.Bit) {
                Name = "S22",
                Expression = "[S22]",
                BasicSearchExpression = "[S22]",
                DateTimeFormat = -1,
                VirtualExpression = "[S22]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S22", "CustomMsg"),
                IsUpload = false
            };
            S22.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S22, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S22, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S22, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S22", S22);

            // S23
            S23 = new (this, "x_S23", 11, SqlDbType.Bit) {
                Name = "S23",
                Expression = "[S23]",
                BasicSearchExpression = "[S23]",
                DateTimeFormat = -1,
                VirtualExpression = "[S23]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S23", "CustomMsg"),
                IsUpload = false
            };
            S23.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S23, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S23, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S23, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S23", S23);

            // S24
            S24 = new (this, "x_S24", 11, SqlDbType.Bit) {
                Name = "S24",
                Expression = "[S24]",
                BasicSearchExpression = "[S24]",
                DateTimeFormat = -1,
                VirtualExpression = "[S24]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S24", "CustomMsg"),
                IsUpload = false
            };
            S24.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S24, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S24, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S24, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S24", S24);

            // S25
            S25 = new (this, "x_S25", 11, SqlDbType.Bit) {
                Name = "S25",
                Expression = "[S25]",
                BasicSearchExpression = "[S25]",
                DateTimeFormat = -1,
                VirtualExpression = "[S25]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S25", "CustomMsg"),
                IsUpload = false
            };
            S25.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S25, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S25, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S25, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S25", S25);

            // S26
            S26 = new (this, "x_S26", 11, SqlDbType.Bit) {
                Name = "S26",
                Expression = "[S26]",
                BasicSearchExpression = "[S26]",
                DateTimeFormat = -1,
                VirtualExpression = "[S26]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S26", "CustomMsg"),
                IsUpload = false
            };
            S26.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S26, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S26, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S26, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S26", S26);

            // Scores_S5
            Scores_S5 = new (this, "x_Scores_S5", 200, SqlDbType.VarChar) {
                Name = "Scores_S5",
                Expression = "[Scores_S5]",
                BasicSearchExpression = "[Scores_S5]",
                DateTimeFormat = -1,
                VirtualExpression = "[Scores_S5]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Scores_S5", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Scores_S5", Scores_S5);

            // S27
            S27 = new (this, "x_S27", 11, SqlDbType.Bit) {
                Name = "S27",
                Expression = "[S27]",
                BasicSearchExpression = "[S27]",
                DateTimeFormat = -1,
                VirtualExpression = "[S27]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S27", "CustomMsg"),
                IsUpload = false
            };
            S27.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S27, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S27, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S27, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S27", S27);

            // S28
            S28 = new (this, "x_S28", 11, SqlDbType.Bit) {
                Name = "S28",
                Expression = "[S28]",
                BasicSearchExpression = "[S28]",
                DateTimeFormat = -1,
                VirtualExpression = "[S28]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S28", "CustomMsg"),
                IsUpload = false
            };
            S28.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S28, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S28, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S28, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S28", S28);

            // S29
            S29 = new (this, "x_S29", 11, SqlDbType.Bit) {
                Name = "S29",
                Expression = "[S29]",
                BasicSearchExpression = "[S29]",
                DateTimeFormat = -1,
                VirtualExpression = "[S29]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S29", "CustomMsg"),
                IsUpload = false
            };
            S29.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S29, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S29, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S29, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S29", S29);

            // S30
            S30 = new (this, "x_S30", 11, SqlDbType.Bit) {
                Name = "S30",
                Expression = "[S30]",
                BasicSearchExpression = "[S30]",
                DateTimeFormat = -1,
                VirtualExpression = "[S30]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S30", "CustomMsg"),
                IsUpload = false
            };
            S30.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S30, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S30, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S30, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S30", S30);

            // S31
            S31 = new (this, "x_S31", 11, SqlDbType.Bit) {
                Name = "S31",
                Expression = "[S31]",
                BasicSearchExpression = "[S31]",
                DateTimeFormat = -1,
                VirtualExpression = "[S31]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S31", "CustomMsg"),
                IsUpload = false
            };
            S31.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S31, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S31, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S31, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S31", S31);

            // S32
            S32 = new (this, "x_S32", 11, SqlDbType.Bit) {
                Name = "S32",
                Expression = "[S32]",
                BasicSearchExpression = "[S32]",
                DateTimeFormat = -1,
                VirtualExpression = "[S32]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S32", "CustomMsg"),
                IsUpload = false
            };
            S32.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S32, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S32, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S32, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S32", S32);

            // S33
            S33 = new (this, "x_S33", 11, SqlDbType.Bit) {
                Name = "S33",
                Expression = "[S33]",
                BasicSearchExpression = "[S33]",
                DateTimeFormat = -1,
                VirtualExpression = "[S33]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S33", "CustomMsg"),
                IsUpload = false
            };
            S33.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S33, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S33, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S33, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S33", S33);

            // S34
            S34 = new (this, "x_S34", 11, SqlDbType.Bit) {
                Name = "S34",
                Expression = "[S34]",
                BasicSearchExpression = "[S34]",
                DateTimeFormat = -1,
                VirtualExpression = "[S34]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S34", "CustomMsg"),
                IsUpload = false
            };
            S34.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S34, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S34, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S34, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S34", S34);

            // S35
            S35 = new (this, "x_S35", 11, SqlDbType.Bit) {
                Name = "S35",
                Expression = "[S35]",
                BasicSearchExpression = "[S35]",
                DateTimeFormat = -1,
                VirtualExpression = "[S35]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S35", "CustomMsg"),
                IsUpload = false
            };
            S35.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S35, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S35, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S35, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S35", S35);

            // Scores_S6
            Scores_S6 = new (this, "x_Scores_S6", 200, SqlDbType.VarChar) {
                Name = "Scores_S6",
                Expression = "[Scores_S6]",
                BasicSearchExpression = "[Scores_S6]",
                DateTimeFormat = -1,
                VirtualExpression = "[Scores_S6]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Scores_S6", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Scores_S6", Scores_S6);

            // S36
            S36 = new (this, "x_S36", 11, SqlDbType.Bit) {
                Name = "S36",
                Expression = "[S36]",
                BasicSearchExpression = "[S36]",
                DateTimeFormat = -1,
                VirtualExpression = "[S36]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S36", "CustomMsg"),
                IsUpload = false
            };
            S36.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S36, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S36, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S36, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S36", S36);

            // S37
            S37 = new (this, "x_S37", 11, SqlDbType.Bit) {
                Name = "S37",
                Expression = "[S37]",
                BasicSearchExpression = "[S37]",
                DateTimeFormat = -1,
                VirtualExpression = "[S37]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S37", "CustomMsg"),
                IsUpload = false
            };
            S37.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S37, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S37, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S37, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S37", S37);

            // S38
            S38 = new (this, "x_S38", 11, SqlDbType.Bit) {
                Name = "S38",
                Expression = "[S38]",
                BasicSearchExpression = "[S38]",
                DateTimeFormat = -1,
                VirtualExpression = "[S38]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S38", "CustomMsg"),
                IsUpload = false
            };
            S38.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S38, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S38, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S38, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S38", S38);

            // S39
            S39 = new (this, "x_S39", 11, SqlDbType.Bit) {
                Name = "S39",
                Expression = "[S39]",
                BasicSearchExpression = "[S39]",
                DateTimeFormat = -1,
                VirtualExpression = "[S39]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S39", "CustomMsg"),
                IsUpload = false
            };
            S39.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S39, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S39, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S39, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S39", S39);

            // S40
            S40 = new (this, "x_S40", 11, SqlDbType.Bit) {
                Name = "S40",
                Expression = "[S40]",
                BasicSearchExpression = "[S40]",
                DateTimeFormat = -1,
                VirtualExpression = "[S40]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S40", "CustomMsg"),
                IsUpload = false
            };
            S40.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S40, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S40, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S40, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S40", S40);

            // S41
            S41 = new (this, "x_S41", 11, SqlDbType.Bit) {
                Name = "S41",
                Expression = "[S41]",
                BasicSearchExpression = "[S41]",
                DateTimeFormat = -1,
                VirtualExpression = "[S41]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S41", "CustomMsg"),
                IsUpload = false
            };
            S41.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S41, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S41, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S41, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S41", S41);

            // S42
            S42 = new (this, "x_S42", 11, SqlDbType.Bit) {
                Name = "S42",
                Expression = "[S42]",
                BasicSearchExpression = "[S42]",
                DateTimeFormat = -1,
                VirtualExpression = "[S42]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S42", "CustomMsg"),
                IsUpload = false
            };
            S42.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S42, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S42, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S42, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S42", S42);

            // S43
            S43 = new (this, "x_S43", 11, SqlDbType.Bit) {
                Name = "S43",
                Expression = "[S43]",
                BasicSearchExpression = "[S43]",
                DateTimeFormat = -1,
                VirtualExpression = "[S43]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S43", "CustomMsg"),
                IsUpload = false
            };
            S43.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S43, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S43, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S43, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S43", S43);

            // Scores_S7
            Scores_S7 = new (this, "x_Scores_S7", 200, SqlDbType.VarChar) {
                Name = "Scores_S7",
                Expression = "[Scores_S7]",
                BasicSearchExpression = "[Scores_S7]",
                DateTimeFormat = -1,
                VirtualExpression = "[Scores_S7]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Scores_S7", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Scores_S7", Scores_S7);

            // S44
            S44 = new (this, "x_S44", 11, SqlDbType.Bit) {
                Name = "S44",
                Expression = "[S44]",
                BasicSearchExpression = "[S44]",
                DateTimeFormat = -1,
                VirtualExpression = "[S44]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S44", "CustomMsg"),
                IsUpload = false
            };
            S44.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S44, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S44, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S44, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S44", S44);

            // S45
            S45 = new (this, "x_S45", 11, SqlDbType.Bit) {
                Name = "S45",
                Expression = "[S45]",
                BasicSearchExpression = "[S45]",
                DateTimeFormat = -1,
                VirtualExpression = "[S45]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S45", "CustomMsg"),
                IsUpload = false
            };
            S45.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S45, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S45, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S45, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S45", S45);

            // S46
            S46 = new (this, "x_S46", 11, SqlDbType.Bit) {
                Name = "S46",
                Expression = "[S46]",
                BasicSearchExpression = "[S46]",
                DateTimeFormat = -1,
                VirtualExpression = "[S46]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S46", "CustomMsg"),
                IsUpload = false
            };
            S46.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S46, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S46, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S46, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S46", S46);

            // S47
            S47 = new (this, "x_S47", 11, SqlDbType.Bit) {
                Name = "S47",
                Expression = "[S47]",
                BasicSearchExpression = "[S47]",
                DateTimeFormat = -1,
                VirtualExpression = "[S47]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S47", "CustomMsg"),
                IsUpload = false
            };
            S47.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S47, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S47, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S47, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S47", S47);

            // S48
            S48 = new (this, "x_S48", 11, SqlDbType.Bit) {
                Name = "S48",
                Expression = "[S48]",
                BasicSearchExpression = "[S48]",
                DateTimeFormat = -1,
                VirtualExpression = "[S48]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S48", "CustomMsg"),
                IsUpload = false
            };
            S48.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S48, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S48, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S48, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S48", S48);

            // S49
            S49 = new (this, "x_S49", 11, SqlDbType.Bit) {
                Name = "S49",
                Expression = "[S49]",
                BasicSearchExpression = "[S49]",
                DateTimeFormat = -1,
                VirtualExpression = "[S49]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S49", "CustomMsg"),
                IsUpload = false
            };
            S49.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S49, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S49, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S49, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S49", S49);

            // S50
            S50 = new (this, "x_S50", 11, SqlDbType.Bit) {
                Name = "S50",
                Expression = "[S50]",
                BasicSearchExpression = "[S50]",
                DateTimeFormat = -1,
                VirtualExpression = "[S50]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S50", "CustomMsg"),
                IsUpload = false
            };
            S50.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S50, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S50, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S50, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S50", S50);

            // Scores_S8
            Scores_S8 = new (this, "x_Scores_S8", 200, SqlDbType.VarChar) {
                Name = "Scores_S8",
                Expression = "[Scores_S8]",
                BasicSearchExpression = "[Scores_S8]",
                DateTimeFormat = -1,
                VirtualExpression = "[Scores_S8]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Scores_S8", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Scores_S8", Scores_S8);

            // S51
            S51 = new (this, "x_S51", 11, SqlDbType.Bit) {
                Name = "S51",
                Expression = "[S51]",
                BasicSearchExpression = "[S51]",
                DateTimeFormat = -1,
                VirtualExpression = "[S51]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S51", "CustomMsg"),
                IsUpload = false
            };
            S51.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S51, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S51, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S51, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S51", S51);

            // S52
            S52 = new (this, "x_S52", 11, SqlDbType.Bit) {
                Name = "S52",
                Expression = "[S52]",
                BasicSearchExpression = "[S52]",
                DateTimeFormat = -1,
                VirtualExpression = "[S52]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S52", "CustomMsg"),
                IsUpload = false
            };
            S52.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S52, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S52, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S52, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S52", S52);

            // S53
            S53 = new (this, "x_S53", 11, SqlDbType.Bit) {
                Name = "S53",
                Expression = "[S53]",
                BasicSearchExpression = "[S53]",
                DateTimeFormat = -1,
                VirtualExpression = "[S53]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S53", "CustomMsg"),
                IsUpload = false
            };
            S53.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S53, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S53, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S53, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S53", S53);

            // S54
            S54 = new (this, "x_S54", 11, SqlDbType.Bit) {
                Name = "S54",
                Expression = "[S54]",
                BasicSearchExpression = "[S54]",
                DateTimeFormat = -1,
                VirtualExpression = "[S54]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S54", "CustomMsg"),
                IsUpload = false
            };
            S54.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S54, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S54, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S54, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S54", S54);

            // S55
            S55 = new (this, "x_S55", 11, SqlDbType.Bit) {
                Name = "S55",
                Expression = "[S55]",
                BasicSearchExpression = "[S55]",
                DateTimeFormat = -1,
                VirtualExpression = "[S55]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S55", "CustomMsg"),
                IsUpload = false
            };
            S55.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S55, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S55, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S55, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S55", S55);

            // Scores_S9
            Scores_S9 = new (this, "x_Scores_S9", 200, SqlDbType.VarChar) {
                Name = "Scores_S9",
                Expression = "[Scores_S9]",
                BasicSearchExpression = "[Scores_S9]",
                DateTimeFormat = -1,
                VirtualExpression = "[Scores_S9]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Scores_S9", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Scores_S9", Scores_S9);

            // S56
            S56 = new (this, "x_S56", 11, SqlDbType.Bit) {
                Name = "S56",
                Expression = "[S56]",
                BasicSearchExpression = "[S56]",
                DateTimeFormat = -1,
                VirtualExpression = "[S56]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S56", "CustomMsg"),
                IsUpload = false
            };
            S56.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S56, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S56, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S56, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S56", S56);

            // S57
            S57 = new (this, "x_S57", 11, SqlDbType.Bit) {
                Name = "S57",
                Expression = "[S57]",
                BasicSearchExpression = "[S57]",
                DateTimeFormat = -1,
                VirtualExpression = "[S57]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S57", "CustomMsg"),
                IsUpload = false
            };
            S57.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S57, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S57, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S57, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S57", S57);

            // S58
            S58 = new (this, "x_S58", 11, SqlDbType.Bit) {
                Name = "S58",
                Expression = "[S58]",
                BasicSearchExpression = "[S58]",
                DateTimeFormat = -1,
                VirtualExpression = "[S58]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S58", "CustomMsg"),
                IsUpload = false
            };
            S58.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S58, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S58, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S58, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S58", S58);

            // S59
            S59 = new (this, "x_S59", 11, SqlDbType.Bit) {
                Name = "S59",
                Expression = "[S59]",
                BasicSearchExpression = "[S59]",
                DateTimeFormat = -1,
                VirtualExpression = "[S59]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S59", "CustomMsg"),
                IsUpload = false
            };
            S59.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S59, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S59, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S59, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S59", S59);

            // Scores_S10
            Scores_S10 = new (this, "x_Scores_S10", 200, SqlDbType.VarChar) {
                Name = "Scores_S10",
                Expression = "[Scores_S10]",
                BasicSearchExpression = "[Scores_S10]",
                DateTimeFormat = -1,
                VirtualExpression = "[Scores_S10]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Scores_S10", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Scores_S10", Scores_S10);

            // S60
            S60 = new (this, "x_S60", 11, SqlDbType.Bit) {
                Name = "S60",
                Expression = "[S60]",
                BasicSearchExpression = "[S60]",
                DateTimeFormat = -1,
                VirtualExpression = "[S60]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S60", "CustomMsg"),
                IsUpload = false
            };
            S60.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S60, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S60, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S60, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S60", S60);

            // S61
            S61 = new (this, "x_S61", 11, SqlDbType.Bit) {
                Name = "S61",
                Expression = "[S61]",
                BasicSearchExpression = "[S61]",
                DateTimeFormat = -1,
                VirtualExpression = "[S61]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S61", "CustomMsg"),
                IsUpload = false
            };
            S61.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S61, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S61, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S61, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S61", S61);

            // S62
            S62 = new (this, "x_S62", 11, SqlDbType.Bit) {
                Name = "S62",
                Expression = "[S62]",
                BasicSearchExpression = "[S62]",
                DateTimeFormat = -1,
                VirtualExpression = "[S62]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S62", "CustomMsg"),
                IsUpload = false
            };
            S62.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S62, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S62, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S62, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S62", S62);

            // S63
            S63 = new (this, "x_S63", 11, SqlDbType.Bit) {
                Name = "S63",
                Expression = "[S63]",
                BasicSearchExpression = "[S63]",
                DateTimeFormat = -1,
                VirtualExpression = "[S63]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S63", "CustomMsg"),
                IsUpload = false
            };
            S63.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S63, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S63, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S63, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S63", S63);

            // S64
            S64 = new (this, "x_S64", 11, SqlDbType.Bit) {
                Name = "S64",
                Expression = "[S64]",
                BasicSearchExpression = "[S64]",
                DateTimeFormat = -1,
                VirtualExpression = "[S64]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S64", "CustomMsg"),
                IsUpload = false
            };
            S64.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S64, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S64, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S64, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S64", S64);

            // S65
            S65 = new (this, "x_S65", 11, SqlDbType.Bit) {
                Name = "S65",
                Expression = "[S65]",
                BasicSearchExpression = "[S65]",
                DateTimeFormat = -1,
                VirtualExpression = "[S65]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S65", "CustomMsg"),
                IsUpload = false
            };
            S65.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S65, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S65, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S65, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S65", S65);

            // Scores_S11
            Scores_S11 = new (this, "x_Scores_S11", 200, SqlDbType.VarChar) {
                Name = "Scores_S11",
                Expression = "[Scores_S11]",
                BasicSearchExpression = "[Scores_S11]",
                DateTimeFormat = -1,
                VirtualExpression = "[Scores_S11]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Scores_S11", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Scores_S11", Scores_S11);

            // S66
            S66 = new (this, "x_S66", 11, SqlDbType.Bit) {
                Name = "S66",
                Expression = "[S66]",
                BasicSearchExpression = "[S66]",
                DateTimeFormat = -1,
                VirtualExpression = "[S66]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S66", "CustomMsg"),
                IsUpload = false
            };
            S66.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S66, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S66, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S66, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S66", S66);

            // S67
            S67 = new (this, "x_S67", 11, SqlDbType.Bit) {
                Name = "S67",
                Expression = "[S67]",
                BasicSearchExpression = "[S67]",
                DateTimeFormat = -1,
                VirtualExpression = "[S67]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S67", "CustomMsg"),
                IsUpload = false
            };
            S67.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S67, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S67, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S67, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S67", S67);

            // S68
            S68 = new (this, "x_S68", 11, SqlDbType.Bit) {
                Name = "S68",
                Expression = "[S68]",
                BasicSearchExpression = "[S68]",
                DateTimeFormat = -1,
                VirtualExpression = "[S68]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S68", "CustomMsg"),
                IsUpload = false
            };
            S68.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S68, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S68, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S68, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S68", S68);

            // S69
            S69 = new (this, "x_S69", 11, SqlDbType.Bit) {
                Name = "S69",
                Expression = "[S69]",
                BasicSearchExpression = "[S69]",
                DateTimeFormat = -1,
                VirtualExpression = "[S69]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S69", "CustomMsg"),
                IsUpload = false
            };
            S69.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S69, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S69, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S69, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S69", S69);

            // S70
            S70 = new (this, "x_S70", 11, SqlDbType.Bit) {
                Name = "S70",
                Expression = "[S70]",
                BasicSearchExpression = "[S70]",
                DateTimeFormat = -1,
                VirtualExpression = "[S70]",
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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "S70", "CustomMsg"),
                IsUpload = false
            };
            S70.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(S70, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(S70, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(S70, "tblEvaluation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("S70", S70);

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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "DriveTypelink", "CustomMsg"),
                IsUpload = false
            };
            DriveTypelink.GetDefault = () => "[1] - Private Vehicles, [2] - Motorbike, [3] - Taxi  &  [4] - CDL (Trucks and Buses)";
            Fields.Add("DriveTypelink", DriveTypelink);

            // Evaluation_Score
            Evaluation_Score = new (this, "x_Evaluation_Score", 5, SqlDbType.Float) {
                Name = "Evaluation_Score",
                Expression = "[Evaluation_Score]",
                BasicSearchExpression = "CAST([Evaluation_Score] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Evaluation_Score]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Evaluation_Score", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Evaluation_Score", Evaluation_Score);

            // Immediate_Failure_Score
            Immediate_Failure_Score = new (this, "x_Immediate_Failure_Score", 5, SqlDbType.Float) {
                Name = "Immediate_Failure_Score",
                Expression = "[Immediate_Failure_Score]",
                BasicSearchExpression = "CAST([Immediate_Failure_Score] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Immediate_Failure_Score]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Immediate_Failure_Score", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Immediate_Failure_Score", Immediate_Failure_Score);

            // Required_Program
            Required_Program = new (this, "x_Required_Program", 202, SqlDbType.NVarChar) {
                Name = "Required_Program",
                Expression = "[Required_Program]",
                BasicSearchExpression = "[Required_Program]",
                DateTimeFormat = -1,
                VirtualExpression = "[Required_Program]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Required_Program", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Required_Program", Required_Program);

            // Price
            Price = new (this, "x_Price", 6, SqlDbType.Money) {
                Name = "Price",
                Expression = "[Price]",
                BasicSearchExpression = "CAST([Price] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Price]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Price", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Price", Price);

            // intEvaluationType
            intEvaluationType = new (this, "x_intEvaluationType", 3, SqlDbType.Int) {
                Name = "intEvaluationType",
                Expression = "[intEvaluationType]",
                BasicSearchExpression = "CAST([intEvaluationType] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[intEvaluationType]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblEvaluation", "intEvaluationType", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("intEvaluationType", intEvaluationType);

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
                CustomMessage = Language.FieldPhrase("tblEvaluation", "Institution", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Institution", Institution);

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
            if (CurrentMasterTable == "tblAssessment") {
                dynamic masterTable = Resolve("tblAssessment")!;
                if (!Empty(AssessmentID.SessionValue))
                    masterFilter += "" + KeyFilter(masterTable.AssessmentID, AssessmentID.SessionValue, masterTable.AssessmentID.DataType, masterTable.DbId);
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
                if (CurrentMasterTable == "tblAssessment") {
                    dynamic masterTable = Resolve("tblAssessment")!;
                    if (!Empty(AssessmentID.SessionValue))
                        detailFilter += "" + KeyFilter(AssessmentID, AssessmentID.SessionValue, masterTable.AssessmentID.DataType, DbId);
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
            case "tblAssessment":
                key = keys["AssessmentID"] ?? "";
                if (Empty(key)) {
                    if (masterTable.AssessmentID.Required) // Required field and empty value
                        return ""; // Return empty filter
                    validKeys = false;
                } else if (!validKeys) { // Already has empty key
                    return ""; // Return empty filter
                }
                if (validKeys) {
                    return KeyFilter(masterTable.AssessmentID, keys["AssessmentID"], AssessmentID.DataType, DbId);
                }
                break;
            }
            return null; // All null values and no required fields
        }

        // Detail filter // DN
        public string DetailFilter(dynamic masterTable) // DN
        {
            return masterTable.TableVar switch {
                "tblAssessment" => KeyFilter(AssessmentID, masterTable.AssessmentID.DbValue, masterTable.AssessmentID.DataType, masterTable.DbId),
                _ => ""
            };
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
            get => _sqlFrom ?? "dbo.tblEvaluation";
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
                Eval_ID.SetDbValue(lastInsertedId);
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
                if (!rsaudit.ContainsKey("Eval_ID"))
                    rsaudit.Add("Eval_ID", rsold["Eval_ID"]);
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
                Eval_ID.DbValue = row["Eval_ID"]; // Set DB value only
                AssessmentID.DbValue = row["AssessmentID"]; // Set DB value only
                str_Full_Name_Hdr.DbValue = row["str_Full_Name_Hdr"]; // Set DB value only
                NationalID.DbValue = row["NationalID"]; // Set DB value only
                str_Cell_Phone.DbValue = row["str_Cell_Phone"]; // Set DB value only
                int_Student_ID.DbValue = row["int_Student_ID"]; // Set DB value only
                intDrivinglicenseType.DbValue = row["intDrivinglicenseType"]; // Set DB value only
                Date_Entered.DbValue = row["Date_Entered"]; // Set DB value only
                Examination_Number.DbValue = row["Examination_Number"]; // Set DB value only
                Section_1.DbValue = row["Section_1"]; // Set DB value only
                Q1.DbValue = (ConvertToBool(row["Q1"]) ? "1" : "0"); // Set DB value only
                Q2.DbValue = (ConvertToBool(row["Q2"]) ? "1" : "0"); // Set DB value only
                Q3.DbValue = (ConvertToBool(row["Q3"]) ? "1" : "0"); // Set DB value only
                Q4.DbValue = (ConvertToBool(row["Q4"]) ? "1" : "0"); // Set DB value only
                Q5.DbValue = (ConvertToBool(row["Q5"]) ? "1" : "0"); // Set DB value only
                Section_2.DbValue = row["Section_2"]; // Set DB value only
                Q6.DbValue = (ConvertToBool(row["Q6"]) ? "1" : "0"); // Set DB value only
                Q7.DbValue = (ConvertToBool(row["Q7"]) ? "1" : "0"); // Set DB value only
                Q8.DbValue = (ConvertToBool(row["Q8"]) ? "1" : "0"); // Set DB value only
                Q9.DbValue = (ConvertToBool(row["Q9"]) ? "1" : "0"); // Set DB value only
                Q10.DbValue = (ConvertToBool(row["Q10"]) ? "1" : "0"); // Set DB value only
                Q11.DbValue = (ConvertToBool(row["Q11"]) ? "1" : "0"); // Set DB value only
                Q12.DbValue = (ConvertToBool(row["Q12"]) ? "1" : "0"); // Set DB value only
                Q13.DbValue = (ConvertToBool(row["Q13"]) ? "1" : "0"); // Set DB value only
                Q14.DbValue = (ConvertToBool(row["Q14"]) ? "1" : "0"); // Set DB value only
                Q15.DbValue = (ConvertToBool(row["Q15"]) ? "1" : "0"); // Set DB value only
                Section_3.DbValue = row["Section_3"]; // Set DB value only
                Q16.DbValue = (ConvertToBool(row["Q16"]) ? "1" : "0"); // Set DB value only
                Q17.DbValue = (ConvertToBool(row["Q17"]) ? "1" : "0"); // Set DB value only
                Q18.DbValue = (ConvertToBool(row["Q18"]) ? "1" : "0"); // Set DB value only
                Q19.DbValue = (ConvertToBool(row["Q19"]) ? "1" : "0"); // Set DB value only
                Q20.DbValue = (ConvertToBool(row["Q20"]) ? "1" : "0"); // Set DB value only
                Q21.DbValue = (ConvertToBool(row["Q21"]) ? "1" : "0"); // Set DB value only
                Section_4.DbValue = row["Section_4"]; // Set DB value only
                Q22.DbValue = (ConvertToBool(row["Q22"]) ? "1" : "0"); // Set DB value only
                Q23.DbValue = (ConvertToBool(row["Q23"]) ? "1" : "0"); // Set DB value only
                Q24.DbValue = (ConvertToBool(row["Q24"]) ? "1" : "0"); // Set DB value only
                Q25.DbValue = (ConvertToBool(row["Q25"]) ? "1" : "0"); // Set DB value only
                Q26.DbValue = (ConvertToBool(row["Q26"]) ? "1" : "0"); // Set DB value only
                Section_5.DbValue = row["Section_5"]; // Set DB value only
                Q27.DbValue = (ConvertToBool(row["Q27"]) ? "1" : "0"); // Set DB value only
                Q28.DbValue = (ConvertToBool(row["Q28"]) ? "1" : "0"); // Set DB value only
                Q29.DbValue = (ConvertToBool(row["Q29"]) ? "1" : "0"); // Set DB value only
                Q30.DbValue = (ConvertToBool(row["Q30"]) ? "1" : "0"); // Set DB value only
                Q31.DbValue = (ConvertToBool(row["Q31"]) ? "1" : "0"); // Set DB value only
                Q32.DbValue = (ConvertToBool(row["Q32"]) ? "1" : "0"); // Set DB value only
                Q33.DbValue = (ConvertToBool(row["Q33"]) ? "1" : "0"); // Set DB value only
                Q34.DbValue = (ConvertToBool(row["Q34"]) ? "1" : "0"); // Set DB value only
                Q35.DbValue = (ConvertToBool(row["Q35"]) ? "1" : "0"); // Set DB value only
                Section_6.DbValue = row["Section_6"]; // Set DB value only
                Q36.DbValue = (ConvertToBool(row["Q36"]) ? "1" : "0"); // Set DB value only
                Q37.DbValue = (ConvertToBool(row["Q37"]) ? "1" : "0"); // Set DB value only
                Q38.DbValue = (ConvertToBool(row["Q38"]) ? "1" : "0"); // Set DB value only
                Q39.DbValue = (ConvertToBool(row["Q39"]) ? "1" : "0"); // Set DB value only
                Q40.DbValue = (ConvertToBool(row["Q40"]) ? "1" : "0"); // Set DB value only
                Q41.DbValue = (ConvertToBool(row["Q41"]) ? "1" : "0"); // Set DB value only
                Q42.DbValue = (ConvertToBool(row["Q42"]) ? "1" : "0"); // Set DB value only
                Q43.DbValue = (ConvertToBool(row["Q43"]) ? "1" : "0"); // Set DB value only
                Section_7.DbValue = row["Section_7"]; // Set DB value only
                Q44.DbValue = (ConvertToBool(row["Q44"]) ? "1" : "0"); // Set DB value only
                Q45.DbValue = (ConvertToBool(row["Q45"]) ? "1" : "0"); // Set DB value only
                Q46.DbValue = (ConvertToBool(row["Q46"]) ? "1" : "0"); // Set DB value only
                Q47.DbValue = (ConvertToBool(row["Q47"]) ? "1" : "0"); // Set DB value only
                Q48.DbValue = (ConvertToBool(row["Q48"]) ? "1" : "0"); // Set DB value only
                Q49.DbValue = (ConvertToBool(row["Q49"]) ? "1" : "0"); // Set DB value only
                Q50.DbValue = (ConvertToBool(row["Q50"]) ? "1" : "0"); // Set DB value only
                Section_8.DbValue = row["Section_8"]; // Set DB value only
                Q51.DbValue = (ConvertToBool(row["Q51"]) ? "1" : "0"); // Set DB value only
                Q52.DbValue = (ConvertToBool(row["Q52"]) ? "1" : "0"); // Set DB value only
                Q53.DbValue = (ConvertToBool(row["Q53"]) ? "1" : "0"); // Set DB value only
                Q54.DbValue = (ConvertToBool(row["Q54"]) ? "1" : "0"); // Set DB value only
                Q55.DbValue = (ConvertToBool(row["Q55"]) ? "1" : "0"); // Set DB value only
                Section_9.DbValue = row["Section_9"]; // Set DB value only
                Q56.DbValue = (ConvertToBool(row["Q56"]) ? "1" : "0"); // Set DB value only
                Q57.DbValue = (ConvertToBool(row["Q57"]) ? "1" : "0"); // Set DB value only
                Q58.DbValue = (ConvertToBool(row["Q58"]) ? "1" : "0"); // Set DB value only
                Q59.DbValue = (ConvertToBool(row["Q59"]) ? "1" : "0"); // Set DB value only
                Q60.DbValue = (ConvertToBool(row["Q60"]) ? "1" : "0"); // Set DB value only
                Section_10.DbValue = row["Section_10"]; // Set DB value only
                Q61.DbValue = (ConvertToBool(row["Q61"]) ? "1" : "0"); // Set DB value only
                Q62.DbValue = (ConvertToBool(row["Q62"]) ? "1" : "0"); // Set DB value only
                Q63.DbValue = (ConvertToBool(row["Q63"]) ? "1" : "0"); // Set DB value only
                Q64.DbValue = (ConvertToBool(row["Q64"]) ? "1" : "0"); // Set DB value only
                Q65.DbValue = (ConvertToBool(row["Q65"]) ? "1" : "0"); // Set DB value only
                Q66.DbValue = (ConvertToBool(row["Q66"]) ? "1" : "0"); // Set DB value only
                Section_11.DbValue = row["Section_11"]; // Set DB value only
                Q67.DbValue = (ConvertToBool(row["Q67"]) ? "1" : "0"); // Set DB value only
                Q68.DbValue = (ConvertToBool(row["Q68"]) ? "1" : "0"); // Set DB value only
                Q69.DbValue = (ConvertToBool(row["Q69"]) ? "1" : "0"); // Set DB value only
                Q70.DbValue = (ConvertToBool(row["Q70"]) ? "1" : "0"); // Set DB value only
                Notes_3.DbValue = row["Notes_3"]; // Set DB value only
                Student_Signature.DbValue = row["Student_Signature"]; // Set DB value only
                Examiner_Signature.DbValue = row["Examiner_Signature"]; // Set DB value only
                str_Username.DbValue = row["str_Username"]; // Set DB value only
                Retake.DbValue = (ConvertToBool(row["Retake"]) ? "1" : "0"); // Set DB value only
                AbsherApptNbr.DbValue = row["AbsherApptNbr"]; // Set DB value only
                IsDrivingexperience.DbValue = (ConvertToBool(row["IsDrivingexperience"]) ? "1" : "0"); // Set DB value only
                date_Birth_Hijri.DbValue = row["date_Birth_Hijri"]; // Set DB value only
                date_Birth.DbValue = row["date_Birth"]; // Set DB value only
                str_Email.DbValue = row["str_Email"]; // Set DB value only
                UserlevelID.DbValue = row["UserlevelID"]; // Set DB value only
                Assigned_int_Package_Id.DbValue = row["Assigned_int_Package_Id"]; // Set DB value only
                Scores_S1.DbValue = row["Scores_S1"]; // Set DB value only
                S1.DbValue = (ConvertToBool(row["S1"]) ? "1" : "0"); // Set DB value only
                S2.DbValue = (ConvertToBool(row["S2"]) ? "1" : "0"); // Set DB value only
                S3.DbValue = (ConvertToBool(row["S3"]) ? "1" : "0"); // Set DB value only
                S4.DbValue = (ConvertToBool(row["S4"]) ? "1" : "0"); // Set DB value only
                S5.DbValue = (ConvertToBool(row["S5"]) ? "1" : "0"); // Set DB value only
                Scores_S2.DbValue = row["Scores_S2"]; // Set DB value only
                S6.DbValue = (ConvertToBool(row["S6"]) ? "1" : "0"); // Set DB value only
                S7.DbValue = (ConvertToBool(row["S7"]) ? "1" : "0"); // Set DB value only
                S8.DbValue = (ConvertToBool(row["S8"]) ? "1" : "0"); // Set DB value only
                S9.DbValue = (ConvertToBool(row["S9"]) ? "1" : "0"); // Set DB value only
                S10.DbValue = (ConvertToBool(row["S10"]) ? "1" : "0"); // Set DB value only
                S11.DbValue = (ConvertToBool(row["S11"]) ? "1" : "0"); // Set DB value only
                S12.DbValue = (ConvertToBool(row["S12"]) ? "1" : "0"); // Set DB value only
                S13.DbValue = (ConvertToBool(row["S13"]) ? "1" : "0"); // Set DB value only
                S14.DbValue = (ConvertToBool(row["S14"]) ? "1" : "0"); // Set DB value only
                S15.DbValue = (ConvertToBool(row["S15"]) ? "1" : "0"); // Set DB value only
                Scores_S3.DbValue = row["Scores_S3"]; // Set DB value only
                S16.DbValue = (ConvertToBool(row["S16"]) ? "1" : "0"); // Set DB value only
                S17.DbValue = (ConvertToBool(row["S17"]) ? "1" : "0"); // Set DB value only
                S18.DbValue = (ConvertToBool(row["S18"]) ? "1" : "0"); // Set DB value only
                S19.DbValue = (ConvertToBool(row["S19"]) ? "1" : "0"); // Set DB value only
                S20.DbValue = (ConvertToBool(row["S20"]) ? "1" : "0"); // Set DB value only
                S21.DbValue = (ConvertToBool(row["S21"]) ? "1" : "0"); // Set DB value only
                Scores_S4.DbValue = row["Scores_S4"]; // Set DB value only
                S22.DbValue = (ConvertToBool(row["S22"]) ? "1" : "0"); // Set DB value only
                S23.DbValue = (ConvertToBool(row["S23"]) ? "1" : "0"); // Set DB value only
                S24.DbValue = (ConvertToBool(row["S24"]) ? "1" : "0"); // Set DB value only
                S25.DbValue = (ConvertToBool(row["S25"]) ? "1" : "0"); // Set DB value only
                S26.DbValue = (ConvertToBool(row["S26"]) ? "1" : "0"); // Set DB value only
                Scores_S5.DbValue = row["Scores_S5"]; // Set DB value only
                S27.DbValue = (ConvertToBool(row["S27"]) ? "1" : "0"); // Set DB value only
                S28.DbValue = (ConvertToBool(row["S28"]) ? "1" : "0"); // Set DB value only
                S29.DbValue = (ConvertToBool(row["S29"]) ? "1" : "0"); // Set DB value only
                S30.DbValue = (ConvertToBool(row["S30"]) ? "1" : "0"); // Set DB value only
                S31.DbValue = (ConvertToBool(row["S31"]) ? "1" : "0"); // Set DB value only
                S32.DbValue = (ConvertToBool(row["S32"]) ? "1" : "0"); // Set DB value only
                S33.DbValue = (ConvertToBool(row["S33"]) ? "1" : "0"); // Set DB value only
                S34.DbValue = (ConvertToBool(row["S34"]) ? "1" : "0"); // Set DB value only
                S35.DbValue = (ConvertToBool(row["S35"]) ? "1" : "0"); // Set DB value only
                Scores_S6.DbValue = row["Scores_S6"]; // Set DB value only
                S36.DbValue = (ConvertToBool(row["S36"]) ? "1" : "0"); // Set DB value only
                S37.DbValue = (ConvertToBool(row["S37"]) ? "1" : "0"); // Set DB value only
                S38.DbValue = (ConvertToBool(row["S38"]) ? "1" : "0"); // Set DB value only
                S39.DbValue = (ConvertToBool(row["S39"]) ? "1" : "0"); // Set DB value only
                S40.DbValue = (ConvertToBool(row["S40"]) ? "1" : "0"); // Set DB value only
                S41.DbValue = (ConvertToBool(row["S41"]) ? "1" : "0"); // Set DB value only
                S42.DbValue = (ConvertToBool(row["S42"]) ? "1" : "0"); // Set DB value only
                S43.DbValue = (ConvertToBool(row["S43"]) ? "1" : "0"); // Set DB value only
                Scores_S7.DbValue = row["Scores_S7"]; // Set DB value only
                S44.DbValue = (ConvertToBool(row["S44"]) ? "1" : "0"); // Set DB value only
                S45.DbValue = (ConvertToBool(row["S45"]) ? "1" : "0"); // Set DB value only
                S46.DbValue = (ConvertToBool(row["S46"]) ? "1" : "0"); // Set DB value only
                S47.DbValue = (ConvertToBool(row["S47"]) ? "1" : "0"); // Set DB value only
                S48.DbValue = (ConvertToBool(row["S48"]) ? "1" : "0"); // Set DB value only
                S49.DbValue = (ConvertToBool(row["S49"]) ? "1" : "0"); // Set DB value only
                S50.DbValue = (ConvertToBool(row["S50"]) ? "1" : "0"); // Set DB value only
                Scores_S8.DbValue = row["Scores_S8"]; // Set DB value only
                S51.DbValue = (ConvertToBool(row["S51"]) ? "1" : "0"); // Set DB value only
                S52.DbValue = (ConvertToBool(row["S52"]) ? "1" : "0"); // Set DB value only
                S53.DbValue = (ConvertToBool(row["S53"]) ? "1" : "0"); // Set DB value only
                S54.DbValue = (ConvertToBool(row["S54"]) ? "1" : "0"); // Set DB value only
                S55.DbValue = (ConvertToBool(row["S55"]) ? "1" : "0"); // Set DB value only
                Scores_S9.DbValue = row["Scores_S9"]; // Set DB value only
                S56.DbValue = (ConvertToBool(row["S56"]) ? "1" : "0"); // Set DB value only
                S57.DbValue = (ConvertToBool(row["S57"]) ? "1" : "0"); // Set DB value only
                S58.DbValue = (ConvertToBool(row["S58"]) ? "1" : "0"); // Set DB value only
                S59.DbValue = (ConvertToBool(row["S59"]) ? "1" : "0"); // Set DB value only
                Scores_S10.DbValue = row["Scores_S10"]; // Set DB value only
                S60.DbValue = (ConvertToBool(row["S60"]) ? "1" : "0"); // Set DB value only
                S61.DbValue = (ConvertToBool(row["S61"]) ? "1" : "0"); // Set DB value only
                S62.DbValue = (ConvertToBool(row["S62"]) ? "1" : "0"); // Set DB value only
                S63.DbValue = (ConvertToBool(row["S63"]) ? "1" : "0"); // Set DB value only
                S64.DbValue = (ConvertToBool(row["S64"]) ? "1" : "0"); // Set DB value only
                S65.DbValue = (ConvertToBool(row["S65"]) ? "1" : "0"); // Set DB value only
                Scores_S11.DbValue = row["Scores_S11"]; // Set DB value only
                S66.DbValue = (ConvertToBool(row["S66"]) ? "1" : "0"); // Set DB value only
                S67.DbValue = (ConvertToBool(row["S67"]) ? "1" : "0"); // Set DB value only
                S68.DbValue = (ConvertToBool(row["S68"]) ? "1" : "0"); // Set DB value only
                S69.DbValue = (ConvertToBool(row["S69"]) ? "1" : "0"); // Set DB value only
                S70.DbValue = (ConvertToBool(row["S70"]) ? "1" : "0"); // Set DB value only
                DriveTypelink.DbValue = row["DriveTypelink"]; // Set DB value only
                Evaluation_Score.DbValue = row["Evaluation_Score"]; // Set DB value only
                Immediate_Failure_Score.DbValue = row["Immediate_Failure_Score"]; // Set DB value only
                Required_Program.DbValue = row["Required_Program"]; // Set DB value only
                Price.DbValue = row["Price"]; // Set DB value only
                intEvaluationType.DbValue = row["intEvaluationType"]; // Set DB value only
                Institution.DbValue = row["Institution"]; // Set DB value only
            } catch {}
        }

        public void DeleteUploadedFiles(Dictionary<string, object> row)
        {
            LoadDbValues(row);
        }

        // Record filter WHERE clause
        private string _sqlKeyFilter => "[Eval_ID] = @Eval_ID@";

        #pragma warning disable 168, 219
        // Get record filter as string
        public string GetRecordFilter(Dictionary<string, object>? row = null, bool current = false)
        {
            string keyFilter = _sqlKeyFilter;
            object? val = null, result = "";
            val = row?.TryGetValue("Eval_ID", out result) ?? false
                ? result
                : !Empty(Eval_ID.OldValue) && !current ? Eval_ID.OldValue : Eval_ID.CurrentValue;
            if (!IsNumeric(val))
                return "0=1"; // Invalid key
            if (val == null)
                return "0=1"; // Invalid key
            keyFilter = keyFilter.Replace("@Eval_ID@", AdjustSql(val, DbId)); // Replace key value
            return keyFilter;
        }

        // Get record filter as Dictionary // DN
        public Dictionary<string, object>? GetRowFilterAsDictionary(IDictionary<string, object>? row = null)
        {
            Dictionary<string, object>? keyFilter = new ();
            object? val = null, result;
            val = row?.TryGetValue("Eval_ID", out result) ?? false
                ? result
                : !Empty(Eval_ID.OldValue) ? Eval_ID.OldValue : Eval_ID.CurrentValue;
            if (!IsNumeric(val))
                return null; // Invalid key
            if (Empty(val))
                return null; // Invalid key
            keyFilter.Add("Eval_ID", val); // Add key value
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
                    return "TblEvaluationList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "TblEvaluationView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "TblEvaluationEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "TblEvaluationAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "TblEvaluationList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "TblEvaluationView",
                Config.ApiAddAction => "TblEvaluationAdd",
                Config.ApiEditAction => "TblEvaluationEdit",
                Config.ApiDeleteAction => "TblEvaluationDelete",
                Config.ApiListAction => "TblEvaluationList",
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
        public string ListUrl => "TblEvaluationList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblEvaluationView", parm);
            else
                url = KeyUrl("TblEvaluationView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "TblEvaluationAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "TblEvaluationAdd?" + parm;
            else
                url = "TblEvaluationAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("TblEvaluationEdit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblEvaluationList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("TblEvaluationAdd", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblEvaluationList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("TblEvaluationDelete")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
            if (CurrentMasterTable == "tblAssessment" && !url.Contains(Config.TableShowMaster + "=")) {
                url += (url.Contains("?") ? "&" : "?") + Config.TableShowMaster + "=" + CurrentMasterTable;
                url += "&" + ForeignKeyUrl("fk_AssessmentID", AssessmentID.SessionValue); // Use Session Value
            }
            return url;
        }

        // Get primary key as JSON
        public string KeyToJson(bool htmlEncode = false)
        {
            string json = "";
            json += "\"Eval_ID\":" + ConvertToJson(Eval_ID.CurrentValue, "number", true);
            json = "{" + json + "}";
            if (htmlEncode)
                json = HtmlEncode(json);
            return json;
        }

        // Add key value to URL
        public string KeyUrl(string url, string parm = "") { // DN
            if (!IsNull(Eval_ID.CurrentValue)) {
                url += "/" + Eval_ID.CurrentValue;
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
            val = current ? ConvertToString(Eval_ID.CurrentValue) ?? "" : ConvertToString(Eval_ID.OldValue) ?? "";
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
            val = row?.TryGetValue("Eval_ID", out result) ?? false ? ConvertToString(result) : null;
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
                    Eval_ID.CurrentValue = keys[0];
                } else {
                    Eval_ID.OldValue = keys[0];
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
                if (RouteValues.TryGetValue("Eval_ID", out object? v0)) { // Eval_ID // DN
                    key = UrlDecode(v0); // DN
                } else if (IsApi() && !Empty(keyValues)) {
                    key = keyValues[0];
                } else {
                    key = Param("Eval_ID");
                }
                keysList.Add(key);
            }
            // Check keys
            foreach (var keys in keysList) {
                if (!IsNumeric(keys)) // Eval_ID
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
                    Eval_ID.CurrentValue = keys;
                else
                    Eval_ID.OldValue = keys;
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
            Eval_ID.SetDbValue(dr["Eval_ID"]);
            AssessmentID.SetDbValue(dr["AssessmentID"]);
            str_Full_Name_Hdr.SetDbValue(dr["str_Full_Name_Hdr"]);
            NationalID.SetDbValue(dr["NationalID"]);
            str_Cell_Phone.SetDbValue(dr["str_Cell_Phone"]);
            int_Student_ID.SetDbValue(dr["int_Student_ID"]);
            intDrivinglicenseType.SetDbValue(dr["intDrivinglicenseType"]);
            Date_Entered.SetDbValue(dr["Date_Entered"]);
            Examination_Number.SetDbValue(dr["Examination_Number"]);
            Section_1.SetDbValue(dr["Section_1"]);
            Q1.SetDbValue(ConvertToBool(dr["Q1"]) ? "1" : "0");
            Q2.SetDbValue(ConvertToBool(dr["Q2"]) ? "1" : "0");
            Q3.SetDbValue(ConvertToBool(dr["Q3"]) ? "1" : "0");
            Q4.SetDbValue(ConvertToBool(dr["Q4"]) ? "1" : "0");
            Q5.SetDbValue(ConvertToBool(dr["Q5"]) ? "1" : "0");
            Section_2.SetDbValue(dr["Section_2"]);
            Q6.SetDbValue(ConvertToBool(dr["Q6"]) ? "1" : "0");
            Q7.SetDbValue(ConvertToBool(dr["Q7"]) ? "1" : "0");
            Q8.SetDbValue(ConvertToBool(dr["Q8"]) ? "1" : "0");
            Q9.SetDbValue(ConvertToBool(dr["Q9"]) ? "1" : "0");
            Q10.SetDbValue(ConvertToBool(dr["Q10"]) ? "1" : "0");
            Q11.SetDbValue(ConvertToBool(dr["Q11"]) ? "1" : "0");
            Q12.SetDbValue(ConvertToBool(dr["Q12"]) ? "1" : "0");
            Q13.SetDbValue(ConvertToBool(dr["Q13"]) ? "1" : "0");
            Q14.SetDbValue(ConvertToBool(dr["Q14"]) ? "1" : "0");
            Q15.SetDbValue(ConvertToBool(dr["Q15"]) ? "1" : "0");
            Section_3.SetDbValue(dr["Section_3"]);
            Q16.SetDbValue(ConvertToBool(dr["Q16"]) ? "1" : "0");
            Q17.SetDbValue(ConvertToBool(dr["Q17"]) ? "1" : "0");
            Q18.SetDbValue(ConvertToBool(dr["Q18"]) ? "1" : "0");
            Q19.SetDbValue(ConvertToBool(dr["Q19"]) ? "1" : "0");
            Q20.SetDbValue(ConvertToBool(dr["Q20"]) ? "1" : "0");
            Q21.SetDbValue(ConvertToBool(dr["Q21"]) ? "1" : "0");
            Section_4.SetDbValue(dr["Section_4"]);
            Q22.SetDbValue(ConvertToBool(dr["Q22"]) ? "1" : "0");
            Q23.SetDbValue(ConvertToBool(dr["Q23"]) ? "1" : "0");
            Q24.SetDbValue(ConvertToBool(dr["Q24"]) ? "1" : "0");
            Q25.SetDbValue(ConvertToBool(dr["Q25"]) ? "1" : "0");
            Q26.SetDbValue(ConvertToBool(dr["Q26"]) ? "1" : "0");
            Section_5.SetDbValue(dr["Section_5"]);
            Q27.SetDbValue(ConvertToBool(dr["Q27"]) ? "1" : "0");
            Q28.SetDbValue(ConvertToBool(dr["Q28"]) ? "1" : "0");
            Q29.SetDbValue(ConvertToBool(dr["Q29"]) ? "1" : "0");
            Q30.SetDbValue(ConvertToBool(dr["Q30"]) ? "1" : "0");
            Q31.SetDbValue(ConvertToBool(dr["Q31"]) ? "1" : "0");
            Q32.SetDbValue(ConvertToBool(dr["Q32"]) ? "1" : "0");
            Q33.SetDbValue(ConvertToBool(dr["Q33"]) ? "1" : "0");
            Q34.SetDbValue(ConvertToBool(dr["Q34"]) ? "1" : "0");
            Q35.SetDbValue(ConvertToBool(dr["Q35"]) ? "1" : "0");
            Section_6.SetDbValue(dr["Section_6"]);
            Q36.SetDbValue(ConvertToBool(dr["Q36"]) ? "1" : "0");
            Q37.SetDbValue(ConvertToBool(dr["Q37"]) ? "1" : "0");
            Q38.SetDbValue(ConvertToBool(dr["Q38"]) ? "1" : "0");
            Q39.SetDbValue(ConvertToBool(dr["Q39"]) ? "1" : "0");
            Q40.SetDbValue(ConvertToBool(dr["Q40"]) ? "1" : "0");
            Q41.SetDbValue(ConvertToBool(dr["Q41"]) ? "1" : "0");
            Q42.SetDbValue(ConvertToBool(dr["Q42"]) ? "1" : "0");
            Q43.SetDbValue(ConvertToBool(dr["Q43"]) ? "1" : "0");
            Section_7.SetDbValue(dr["Section_7"]);
            Q44.SetDbValue(ConvertToBool(dr["Q44"]) ? "1" : "0");
            Q45.SetDbValue(ConvertToBool(dr["Q45"]) ? "1" : "0");
            Q46.SetDbValue(ConvertToBool(dr["Q46"]) ? "1" : "0");
            Q47.SetDbValue(ConvertToBool(dr["Q47"]) ? "1" : "0");
            Q48.SetDbValue(ConvertToBool(dr["Q48"]) ? "1" : "0");
            Q49.SetDbValue(ConvertToBool(dr["Q49"]) ? "1" : "0");
            Q50.SetDbValue(ConvertToBool(dr["Q50"]) ? "1" : "0");
            Section_8.SetDbValue(dr["Section_8"]);
            Q51.SetDbValue(ConvertToBool(dr["Q51"]) ? "1" : "0");
            Q52.SetDbValue(ConvertToBool(dr["Q52"]) ? "1" : "0");
            Q53.SetDbValue(ConvertToBool(dr["Q53"]) ? "1" : "0");
            Q54.SetDbValue(ConvertToBool(dr["Q54"]) ? "1" : "0");
            Q55.SetDbValue(ConvertToBool(dr["Q55"]) ? "1" : "0");
            Section_9.SetDbValue(dr["Section_9"]);
            Q56.SetDbValue(ConvertToBool(dr["Q56"]) ? "1" : "0");
            Q57.SetDbValue(ConvertToBool(dr["Q57"]) ? "1" : "0");
            Q58.SetDbValue(ConvertToBool(dr["Q58"]) ? "1" : "0");
            Q59.SetDbValue(ConvertToBool(dr["Q59"]) ? "1" : "0");
            Q60.SetDbValue(ConvertToBool(dr["Q60"]) ? "1" : "0");
            Section_10.SetDbValue(dr["Section_10"]);
            Q61.SetDbValue(ConvertToBool(dr["Q61"]) ? "1" : "0");
            Q62.SetDbValue(ConvertToBool(dr["Q62"]) ? "1" : "0");
            Q63.SetDbValue(ConvertToBool(dr["Q63"]) ? "1" : "0");
            Q64.SetDbValue(ConvertToBool(dr["Q64"]) ? "1" : "0");
            Q65.SetDbValue(ConvertToBool(dr["Q65"]) ? "1" : "0");
            Q66.SetDbValue(ConvertToBool(dr["Q66"]) ? "1" : "0");
            Section_11.SetDbValue(dr["Section_11"]);
            Q67.SetDbValue(ConvertToBool(dr["Q67"]) ? "1" : "0");
            Q68.SetDbValue(ConvertToBool(dr["Q68"]) ? "1" : "0");
            Q69.SetDbValue(ConvertToBool(dr["Q69"]) ? "1" : "0");
            Q70.SetDbValue(ConvertToBool(dr["Q70"]) ? "1" : "0");
            Notes_3.SetDbValue(dr["Notes_3"]);
            Student_Signature.SetDbValue(dr["Student_Signature"]);
            Examiner_Signature.SetDbValue(dr["Examiner_Signature"]);
            str_Username.SetDbValue(dr["str_Username"]);
            Retake.SetDbValue(ConvertToBool(dr["Retake"]) ? "1" : "0");
            AbsherApptNbr.SetDbValue(dr["AbsherApptNbr"]);
            IsDrivingexperience.SetDbValue(ConvertToBool(dr["IsDrivingexperience"]) ? "1" : "0");
            date_Birth_Hijri.SetDbValue(dr["date_Birth_Hijri"]);
            date_Birth.SetDbValue(dr["date_Birth"]);
            str_Email.SetDbValue(dr["str_Email"]);
            UserlevelID.SetDbValue(dr["UserlevelID"]);
            Assigned_int_Package_Id.SetDbValue(dr["Assigned_int_Package_Id"]);
            Scores_S1.SetDbValue(dr["Scores_S1"]);
            S1.SetDbValue(ConvertToBool(dr["S1"]) ? "1" : "0");
            S2.SetDbValue(ConvertToBool(dr["S2"]) ? "1" : "0");
            S3.SetDbValue(ConvertToBool(dr["S3"]) ? "1" : "0");
            S4.SetDbValue(ConvertToBool(dr["S4"]) ? "1" : "0");
            S5.SetDbValue(ConvertToBool(dr["S5"]) ? "1" : "0");
            Scores_S2.SetDbValue(dr["Scores_S2"]);
            S6.SetDbValue(ConvertToBool(dr["S6"]) ? "1" : "0");
            S7.SetDbValue(ConvertToBool(dr["S7"]) ? "1" : "0");
            S8.SetDbValue(ConvertToBool(dr["S8"]) ? "1" : "0");
            S9.SetDbValue(ConvertToBool(dr["S9"]) ? "1" : "0");
            S10.SetDbValue(ConvertToBool(dr["S10"]) ? "1" : "0");
            S11.SetDbValue(ConvertToBool(dr["S11"]) ? "1" : "0");
            S12.SetDbValue(ConvertToBool(dr["S12"]) ? "1" : "0");
            S13.SetDbValue(ConvertToBool(dr["S13"]) ? "1" : "0");
            S14.SetDbValue(ConvertToBool(dr["S14"]) ? "1" : "0");
            S15.SetDbValue(ConvertToBool(dr["S15"]) ? "1" : "0");
            Scores_S3.SetDbValue(dr["Scores_S3"]);
            S16.SetDbValue(ConvertToBool(dr["S16"]) ? "1" : "0");
            S17.SetDbValue(ConvertToBool(dr["S17"]) ? "1" : "0");
            S18.SetDbValue(ConvertToBool(dr["S18"]) ? "1" : "0");
            S19.SetDbValue(ConvertToBool(dr["S19"]) ? "1" : "0");
            S20.SetDbValue(ConvertToBool(dr["S20"]) ? "1" : "0");
            S21.SetDbValue(ConvertToBool(dr["S21"]) ? "1" : "0");
            Scores_S4.SetDbValue(dr["Scores_S4"]);
            S22.SetDbValue(ConvertToBool(dr["S22"]) ? "1" : "0");
            S23.SetDbValue(ConvertToBool(dr["S23"]) ? "1" : "0");
            S24.SetDbValue(ConvertToBool(dr["S24"]) ? "1" : "0");
            S25.SetDbValue(ConvertToBool(dr["S25"]) ? "1" : "0");
            S26.SetDbValue(ConvertToBool(dr["S26"]) ? "1" : "0");
            Scores_S5.SetDbValue(dr["Scores_S5"]);
            S27.SetDbValue(ConvertToBool(dr["S27"]) ? "1" : "0");
            S28.SetDbValue(ConvertToBool(dr["S28"]) ? "1" : "0");
            S29.SetDbValue(ConvertToBool(dr["S29"]) ? "1" : "0");
            S30.SetDbValue(ConvertToBool(dr["S30"]) ? "1" : "0");
            S31.SetDbValue(ConvertToBool(dr["S31"]) ? "1" : "0");
            S32.SetDbValue(ConvertToBool(dr["S32"]) ? "1" : "0");
            S33.SetDbValue(ConvertToBool(dr["S33"]) ? "1" : "0");
            S34.SetDbValue(ConvertToBool(dr["S34"]) ? "1" : "0");
            S35.SetDbValue(ConvertToBool(dr["S35"]) ? "1" : "0");
            Scores_S6.SetDbValue(dr["Scores_S6"]);
            S36.SetDbValue(ConvertToBool(dr["S36"]) ? "1" : "0");
            S37.SetDbValue(ConvertToBool(dr["S37"]) ? "1" : "0");
            S38.SetDbValue(ConvertToBool(dr["S38"]) ? "1" : "0");
            S39.SetDbValue(ConvertToBool(dr["S39"]) ? "1" : "0");
            S40.SetDbValue(ConvertToBool(dr["S40"]) ? "1" : "0");
            S41.SetDbValue(ConvertToBool(dr["S41"]) ? "1" : "0");
            S42.SetDbValue(ConvertToBool(dr["S42"]) ? "1" : "0");
            S43.SetDbValue(ConvertToBool(dr["S43"]) ? "1" : "0");
            Scores_S7.SetDbValue(dr["Scores_S7"]);
            S44.SetDbValue(ConvertToBool(dr["S44"]) ? "1" : "0");
            S45.SetDbValue(ConvertToBool(dr["S45"]) ? "1" : "0");
            S46.SetDbValue(ConvertToBool(dr["S46"]) ? "1" : "0");
            S47.SetDbValue(ConvertToBool(dr["S47"]) ? "1" : "0");
            S48.SetDbValue(ConvertToBool(dr["S48"]) ? "1" : "0");
            S49.SetDbValue(ConvertToBool(dr["S49"]) ? "1" : "0");
            S50.SetDbValue(ConvertToBool(dr["S50"]) ? "1" : "0");
            Scores_S8.SetDbValue(dr["Scores_S8"]);
            S51.SetDbValue(ConvertToBool(dr["S51"]) ? "1" : "0");
            S52.SetDbValue(ConvertToBool(dr["S52"]) ? "1" : "0");
            S53.SetDbValue(ConvertToBool(dr["S53"]) ? "1" : "0");
            S54.SetDbValue(ConvertToBool(dr["S54"]) ? "1" : "0");
            S55.SetDbValue(ConvertToBool(dr["S55"]) ? "1" : "0");
            Scores_S9.SetDbValue(dr["Scores_S9"]);
            S56.SetDbValue(ConvertToBool(dr["S56"]) ? "1" : "0");
            S57.SetDbValue(ConvertToBool(dr["S57"]) ? "1" : "0");
            S58.SetDbValue(ConvertToBool(dr["S58"]) ? "1" : "0");
            S59.SetDbValue(ConvertToBool(dr["S59"]) ? "1" : "0");
            Scores_S10.SetDbValue(dr["Scores_S10"]);
            S60.SetDbValue(ConvertToBool(dr["S60"]) ? "1" : "0");
            S61.SetDbValue(ConvertToBool(dr["S61"]) ? "1" : "0");
            S62.SetDbValue(ConvertToBool(dr["S62"]) ? "1" : "0");
            S63.SetDbValue(ConvertToBool(dr["S63"]) ? "1" : "0");
            S64.SetDbValue(ConvertToBool(dr["S64"]) ? "1" : "0");
            S65.SetDbValue(ConvertToBool(dr["S65"]) ? "1" : "0");
            Scores_S11.SetDbValue(dr["Scores_S11"]);
            S66.SetDbValue(ConvertToBool(dr["S66"]) ? "1" : "0");
            S67.SetDbValue(ConvertToBool(dr["S67"]) ? "1" : "0");
            S68.SetDbValue(ConvertToBool(dr["S68"]) ? "1" : "0");
            S69.SetDbValue(ConvertToBool(dr["S69"]) ? "1" : "0");
            S70.SetDbValue(ConvertToBool(dr["S70"]) ? "1" : "0");
            DriveTypelink.SetDbValue(dr["DriveTypelink"]);
            Evaluation_Score.SetDbValue(dr["Evaluation_Score"]);
            Immediate_Failure_Score.SetDbValue(dr["Immediate_Failure_Score"]);
            Required_Program.SetDbValue(dr["Required_Program"]);
            Price.SetDbValue(dr["Price"]);
            intEvaluationType.SetDbValue(dr["intEvaluationType"]);
            Institution.SetDbValue(dr["Institution"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "TblEvaluationList";
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

            // Eval_ID
            Eval_ID.CellCssStyle = "white-space: nowrap;";

            // AssessmentID
            AssessmentID.CellCssStyle = "white-space: nowrap;";

            // str_Full_Name_Hdr
            str_Full_Name_Hdr.CellCssStyle = "white-space: nowrap;";

            // NationalID
            NationalID.CellCssStyle = "white-space: nowrap;";

            // str_Cell_Phone

            // int_Student_ID

            // intDrivinglicenseType
            intDrivinglicenseType.CellCssStyle = "white-space: nowrap;";

            // Date_Entered
            Date_Entered.CellCssStyle = "white-space: nowrap;";

            // Examination_Number
            Examination_Number.CellCssStyle = "white-space: nowrap;";

            // Section_1
            Section_1.CellCssStyle = "white-space: nowrap;";

            // Q1
            Q1.CellCssStyle = "white-space: nowrap;";

            // Q2
            Q2.CellCssStyle = "white-space: nowrap;";

            // Q3
            Q3.CellCssStyle = "white-space: nowrap;";

            // Q4
            Q4.CellCssStyle = "white-space: nowrap;";

            // Q5
            Q5.CellCssStyle = "min-width: 15px; white-space: nowrap;";

            // Section_2
            Section_2.CellCssStyle = "white-space: nowrap;";

            // Q6
            Q6.CellCssStyle = "white-space: nowrap;";

            // Q7
            Q7.CellCssStyle = "white-space: nowrap;";

            // Q8
            Q8.CellCssStyle = "white-space: nowrap;";

            // Q9
            Q9.CellCssStyle = "white-space: nowrap;";

            // Q10
            Q10.CellCssStyle = "white-space: nowrap;";

            // Q11
            Q11.CellCssStyle = "white-space: nowrap;";

            // Q12
            Q12.CellCssStyle = "white-space: nowrap;";

            // Q13
            Q13.CellCssStyle = "white-space: nowrap;";

            // Q14
            Q14.CellCssStyle = "white-space: nowrap;";

            // Q15
            Q15.CellCssStyle = "white-space: nowrap;";

            // Section_3
            Section_3.CellCssStyle = "white-space: nowrap;";

            // Q16
            Q16.CellCssStyle = "white-space: nowrap;";

            // Q17
            Q17.CellCssStyle = "white-space: nowrap;";

            // Q18
            Q18.CellCssStyle = "white-space: nowrap;";

            // Q19
            Q19.CellCssStyle = "white-space: nowrap;";

            // Q20
            Q20.CellCssStyle = "white-space: nowrap;";

            // Q21
            Q21.CellCssStyle = "white-space: nowrap;";

            // Section_4
            Section_4.CellCssStyle = "white-space: nowrap;";

            // Q22
            Q22.CellCssStyle = "white-space: nowrap;";

            // Q23
            Q23.CellCssStyle = "white-space: nowrap;";

            // Q24
            Q24.CellCssStyle = "white-space: nowrap;";

            // Q25
            Q25.CellCssStyle = "white-space: nowrap;";

            // Q26
            Q26.CellCssStyle = "white-space: nowrap;";

            // Section_5
            Section_5.CellCssStyle = "white-space: nowrap;";

            // Q27
            Q27.CellCssStyle = "white-space: nowrap;";

            // Q28
            Q28.CellCssStyle = "white-space: nowrap;";

            // Q29
            Q29.CellCssStyle = "white-space: nowrap;";

            // Q30
            Q30.CellCssStyle = "white-space: nowrap;";

            // Q31
            Q31.CellCssStyle = "white-space: nowrap;";

            // Q32
            Q32.CellCssStyle = "white-space: nowrap;";

            // Q33
            Q33.CellCssStyle = "white-space: nowrap;";

            // Q34
            Q34.CellCssStyle = "white-space: nowrap;";

            // Q35
            Q35.CellCssStyle = "white-space: nowrap;";

            // Section_6
            Section_6.CellCssStyle = "white-space: nowrap;";

            // Q36
            Q36.CellCssStyle = "white-space: nowrap;";

            // Q37
            Q37.CellCssStyle = "white-space: nowrap;";

            // Q38
            Q38.CellCssStyle = "white-space: nowrap;";

            // Q39
            Q39.CellCssStyle = "white-space: nowrap;";

            // Q40
            Q40.CellCssStyle = "white-space: nowrap;";

            // Q41
            Q41.CellCssStyle = "white-space: nowrap;";

            // Q42
            Q42.CellCssStyle = "white-space: nowrap;";

            // Q43
            Q43.CellCssStyle = "white-space: nowrap;";

            // Section_7
            Section_7.CellCssStyle = "white-space: nowrap;";

            // Q44
            Q44.CellCssStyle = "white-space: nowrap;";

            // Q45
            Q45.CellCssStyle = "white-space: nowrap;";

            // Q46
            Q46.CellCssStyle = "white-space: nowrap;";

            // Q47
            Q47.CellCssStyle = "white-space: nowrap;";

            // Q48
            Q48.CellCssStyle = "white-space: nowrap;";

            // Q49
            Q49.CellCssStyle = "white-space: nowrap;";

            // Q50
            Q50.CellCssStyle = "white-space: nowrap;";

            // Section_8
            Section_8.CellCssStyle = "white-space: nowrap;";

            // Q51
            Q51.CellCssStyle = "white-space: nowrap;";

            // Q52
            Q52.CellCssStyle = "white-space: nowrap;";

            // Q53
            Q53.CellCssStyle = "white-space: nowrap;";

            // Q54
            Q54.CellCssStyle = "white-space: nowrap;";

            // Q55
            Q55.CellCssStyle = "white-space: nowrap;";

            // Section_9
            Section_9.CellCssStyle = "white-space: nowrap;";

            // Q56
            Q56.CellCssStyle = "white-space: nowrap;";

            // Q57
            Q57.CellCssStyle = "white-space: nowrap;";

            // Q58
            Q58.CellCssStyle = "white-space: nowrap;";

            // Q59
            Q59.CellCssStyle = "white-space: nowrap;";

            // Q60
            Q60.CellCssStyle = "white-space: nowrap;";

            // Section_10
            Section_10.CellCssStyle = "white-space: nowrap;";

            // Q61
            Q61.CellCssStyle = "white-space: nowrap;";

            // Q62
            Q62.CellCssStyle = "white-space: nowrap;";

            // Q63
            Q63.CellCssStyle = "white-space: nowrap;";

            // Q64
            Q64.CellCssStyle = "white-space: nowrap;";

            // Q65
            Q65.CellCssStyle = "white-space: nowrap;";

            // Q66
            Q66.CellCssStyle = "white-space: nowrap;";

            // Section_11
            Section_11.CellCssStyle = "white-space: nowrap;";

            // Q67
            Q67.CellCssStyle = "white-space: nowrap;";

            // Q68
            Q68.CellCssStyle = "white-space: nowrap;";

            // Q69
            Q69.CellCssStyle = "white-space: nowrap;";

            // Q70
            Q70.CellCssStyle = "white-space: nowrap;";

            // Notes_3
            Notes_3.CellCssStyle = "white-space: nowrap;";

            // Student_Signature
            Student_Signature.CellCssStyle = "white-space: nowrap;";

            // Examiner_Signature
            Examiner_Signature.CellCssStyle = "white-space: nowrap;";

            // str_Username
            str_Username.CellCssStyle = "white-space: nowrap;";

            // Retake

            // AbsherApptNbr

            // IsDrivingexperience

            // date_Birth_Hijri
            date_Birth_Hijri.CellCssStyle = "white-space: nowrap;";

            // date_Birth

            // str_Email

            // UserlevelID

            // Assigned_int_Package_Id

            // Scores_S1
            Scores_S1.CellCssStyle = "white-space: nowrap;";

            // S1
            S1.CellCssStyle = "white-space: nowrap;";

            // S2
            S2.CellCssStyle = "white-space: nowrap;";

            // S3
            S3.CellCssStyle = "white-space: nowrap;";

            // S4
            S4.CellCssStyle = "white-space: nowrap;";

            // S5
            S5.CellCssStyle = "white-space: nowrap;";

            // Scores_S2
            Scores_S2.CellCssStyle = "white-space: nowrap;";

            // S6
            S6.CellCssStyle = "white-space: nowrap;";

            // S7
            S7.CellCssStyle = "white-space: nowrap;";

            // S8
            S8.CellCssStyle = "white-space: nowrap;";

            // S9
            S9.CellCssStyle = "white-space: nowrap;";

            // S10
            S10.CellCssStyle = "white-space: nowrap;";

            // S11
            S11.CellCssStyle = "white-space: nowrap;";

            // S12
            S12.CellCssStyle = "white-space: nowrap;";

            // S13
            S13.CellCssStyle = "white-space: nowrap;";

            // S14
            S14.CellCssStyle = "white-space: nowrap;";

            // S15
            S15.CellCssStyle = "white-space: nowrap;";

            // Scores_S3
            Scores_S3.CellCssStyle = "white-space: nowrap;";

            // S16
            S16.CellCssStyle = "white-space: nowrap;";

            // S17
            S17.CellCssStyle = "white-space: nowrap;";

            // S18
            S18.CellCssStyle = "white-space: nowrap;";

            // S19
            S19.CellCssStyle = "white-space: nowrap;";

            // S20
            S20.CellCssStyle = "white-space: nowrap;";

            // S21
            S21.CellCssStyle = "white-space: nowrap;";

            // Scores_S4
            Scores_S4.CellCssStyle = "white-space: nowrap;";

            // S22
            S22.CellCssStyle = "white-space: nowrap;";

            // S23
            S23.CellCssStyle = "white-space: nowrap;";

            // S24
            S24.CellCssStyle = "white-space: nowrap;";

            // S25
            S25.CellCssStyle = "white-space: nowrap;";

            // S26
            S26.CellCssStyle = "white-space: nowrap;";

            // Scores_S5
            Scores_S5.CellCssStyle = "white-space: nowrap;";

            // S27
            S27.CellCssStyle = "white-space: nowrap;";

            // S28
            S28.CellCssStyle = "white-space: nowrap;";

            // S29
            S29.CellCssStyle = "white-space: nowrap;";

            // S30
            S30.CellCssStyle = "white-space: nowrap;";

            // S31
            S31.CellCssStyle = "white-space: nowrap;";

            // S32
            S32.CellCssStyle = "white-space: nowrap;";

            // S33
            S33.CellCssStyle = "white-space: nowrap;";

            // S34
            S34.CellCssStyle = "white-space: nowrap;";

            // S35
            S35.CellCssStyle = "white-space: nowrap;";

            // Scores_S6
            Scores_S6.CellCssStyle = "white-space: nowrap;";

            // S36
            S36.CellCssStyle = "white-space: nowrap;";

            // S37
            S37.CellCssStyle = "white-space: nowrap;";

            // S38
            S38.CellCssStyle = "white-space: nowrap;";

            // S39
            S39.CellCssStyle = "white-space: nowrap;";

            // S40
            S40.CellCssStyle = "white-space: nowrap;";

            // S41
            S41.CellCssStyle = "white-space: nowrap;";

            // S42
            S42.CellCssStyle = "white-space: nowrap;";

            // S43
            S43.CellCssStyle = "white-space: nowrap;";

            // Scores_S7
            Scores_S7.CellCssStyle = "white-space: nowrap;";

            // S44
            S44.CellCssStyle = "white-space: nowrap;";

            // S45
            S45.CellCssStyle = "white-space: nowrap;";

            // S46
            S46.CellCssStyle = "white-space: nowrap;";

            // S47
            S47.CellCssStyle = "white-space: nowrap;";

            // S48
            S48.CellCssStyle = "white-space: nowrap;";

            // S49
            S49.CellCssStyle = "white-space: nowrap;";

            // S50
            S50.CellCssStyle = "white-space: nowrap;";

            // Scores_S8
            Scores_S8.CellCssStyle = "white-space: nowrap;";

            // S51
            S51.CellCssStyle = "white-space: nowrap;";

            // S52
            S52.CellCssStyle = "white-space: nowrap;";

            // S53
            S53.CellCssStyle = "white-space: nowrap;";

            // S54
            S54.CellCssStyle = "white-space: nowrap;";

            // S55
            S55.CellCssStyle = "white-space: nowrap;";

            // Scores_S9
            Scores_S9.CellCssStyle = "white-space: nowrap;";

            // S56
            S56.CellCssStyle = "white-space: nowrap;";

            // S57
            S57.CellCssStyle = "white-space: nowrap;";

            // S58
            S58.CellCssStyle = "white-space: nowrap;";

            // S59
            S59.CellCssStyle = "white-space: nowrap;";

            // Scores_S10
            Scores_S10.CellCssStyle = "white-space: nowrap;";

            // S60
            S60.CellCssStyle = "white-space: nowrap;";

            // S61
            S61.CellCssStyle = "white-space: nowrap;";

            // S62
            S62.CellCssStyle = "white-space: nowrap;";

            // S63
            S63.CellCssStyle = "white-space: nowrap;";

            // S64
            S64.CellCssStyle = "white-space: nowrap;";

            // S65
            S65.CellCssStyle = "white-space: nowrap;";

            // Scores_S11
            Scores_S11.CellCssStyle = "white-space: nowrap;";

            // S66
            S66.CellCssStyle = "white-space: nowrap;";

            // S67
            S67.CellCssStyle = "white-space: nowrap;";

            // S68
            S68.CellCssStyle = "white-space: nowrap;";

            // S69
            S69.CellCssStyle = "white-space: nowrap;";

            // S70
            S70.CellCssStyle = "white-space: nowrap;";

            // DriveTypelink
            DriveTypelink.CellCssStyle = "white-space: nowrap;";

            // Evaluation_Score
            Evaluation_Score.CellCssStyle = "white-space: nowrap;";

            // Immediate_Failure_Score
            Immediate_Failure_Score.CellCssStyle = "white-space: nowrap;";

            // Required_Program
            Required_Program.CellCssStyle = "white-space: nowrap;";

            // Price
            Price.CellCssStyle = "white-space: nowrap;";

            // intEvaluationType

            // Institution

            // Eval_ID
            Eval_ID.ViewValue = Eval_ID.CurrentValue;
            Eval_ID.ViewCustomAttributes = "";

            // AssessmentID
            AssessmentID.ViewValue = AssessmentID.CurrentValue;
            AssessmentID.ViewValue = FormatNumber(AssessmentID.ViewValue, AssessmentID.FormatPattern);
            AssessmentID.ViewCustomAttributes = "";

            // str_Full_Name_Hdr
            str_Full_Name_Hdr.ViewValue = ConvertToString(str_Full_Name_Hdr.CurrentValue); // DN
            str_Full_Name_Hdr.ViewCustomAttributes = "";

            // NationalID
            NationalID.ViewValue = NationalID.CurrentValue;
            NationalID.ViewCustomAttributes = "";

            // str_Cell_Phone
            str_Cell_Phone.ViewValue = ConvertToString(str_Cell_Phone.CurrentValue); // DN
            str_Cell_Phone.ViewCustomAttributes = "";

            // int_Student_ID
            int_Student_ID.ViewValue = int_Student_ID.CurrentValue;
            int_Student_ID.ViewValue = FormatNumber(int_Student_ID.ViewValue, int_Student_ID.FormatPattern);
            int_Student_ID.ViewCustomAttributes = "";

            // intDrivinglicenseType
            intDrivinglicenseType.ViewValue = intDrivinglicenseType.CurrentValue;
            intDrivinglicenseType.ViewValue = FormatNumber(intDrivinglicenseType.ViewValue, intDrivinglicenseType.FormatPattern);
            intDrivinglicenseType.CellCssStyle += "text-align: center;";
            intDrivinglicenseType.ViewCustomAttributes = "";

            // Date_Entered
            Date_Entered.ViewValue = Date_Entered.CurrentValue;
            Date_Entered.ViewValue = FormatDateTime(Date_Entered.ViewValue, Date_Entered.FormatPattern);
            Date_Entered.ViewCustomAttributes = "";

            // Examination_Number
            Examination_Number.ViewValue = Examination_Number.CurrentValue;
            Examination_Number.ViewValue = FormatNumber(Examination_Number.ViewValue, Examination_Number.FormatPattern);
            Examination_Number.ViewCustomAttributes = "";

            // Section_1
            Section_1.ViewValue = ConvertToString(Section_1.CurrentValue); // DN
            Section_1.ViewCustomAttributes = "";

            // Q1
            if (ConvertToBool(Q1.CurrentValue)) {
                Q1.ViewValue = Q1.TagCaption(1) != "" ? Q1.TagCaption(1) : "Yes";
            } else {
                Q1.ViewValue = Q1.TagCaption(2) != "" ? Q1.TagCaption(2) : "No";
            }
            Q1.ViewCustomAttributes = "";

            // Q2
            if (ConvertToBool(Q2.CurrentValue)) {
                Q2.ViewValue = Q2.TagCaption(1) != "" ? Q2.TagCaption(1) : "Yes";
            } else {
                Q2.ViewValue = Q2.TagCaption(2) != "" ? Q2.TagCaption(2) : "No";
            }
            Q2.ViewCustomAttributes = "";

            // Q3
            if (ConvertToBool(Q3.CurrentValue)) {
                Q3.ViewValue = Q3.TagCaption(1) != "" ? Q3.TagCaption(1) : "Yes";
            } else {
                Q3.ViewValue = Q3.TagCaption(2) != "" ? Q3.TagCaption(2) : "No";
            }
            Q3.ViewCustomAttributes = "";

            // Q4
            if (ConvertToBool(Q4.CurrentValue)) {
                Q4.ViewValue = Q4.TagCaption(1) != "" ? Q4.TagCaption(1) : "Yes";
            } else {
                Q4.ViewValue = Q4.TagCaption(2) != "" ? Q4.TagCaption(2) : "No";
            }
            Q4.ViewCustomAttributes = "";

            // Q5
            if (ConvertToBool(Q5.CurrentValue)) {
                Q5.ViewValue = Q5.TagCaption(1) != "" ? Q5.TagCaption(1) : "Yes";
            } else {
                Q5.ViewValue = Q5.TagCaption(2) != "" ? Q5.TagCaption(2) : "No";
            }
            Q5.ViewCustomAttributes = "";

            // Section_2
            Section_2.ViewValue = ConvertToString(Section_2.CurrentValue); // DN
            Section_2.ViewCustomAttributes = "";

            // Q6
            if (ConvertToBool(Q6.CurrentValue)) {
                Q6.ViewValue = Q6.TagCaption(1) != "" ? Q6.TagCaption(1) : "Yes";
            } else {
                Q6.ViewValue = Q6.TagCaption(2) != "" ? Q6.TagCaption(2) : "No";
            }
            Q6.ViewCustomAttributes = "";

            // Q7
            if (ConvertToBool(Q7.CurrentValue)) {
                Q7.ViewValue = Q7.TagCaption(1) != "" ? Q7.TagCaption(1) : "Yes";
            } else {
                Q7.ViewValue = Q7.TagCaption(2) != "" ? Q7.TagCaption(2) : "No";
            }
            Q7.ViewCustomAttributes = "";

            // Q8
            if (ConvertToBool(Q8.CurrentValue)) {
                Q8.ViewValue = Q8.TagCaption(1) != "" ? Q8.TagCaption(1) : "Yes";
            } else {
                Q8.ViewValue = Q8.TagCaption(2) != "" ? Q8.TagCaption(2) : "No";
            }
            Q8.ViewCustomAttributes = "";

            // Q9
            if (ConvertToBool(Q9.CurrentValue)) {
                Q9.ViewValue = Q9.TagCaption(1) != "" ? Q9.TagCaption(1) : "Yes";
            } else {
                Q9.ViewValue = Q9.TagCaption(2) != "" ? Q9.TagCaption(2) : "No";
            }
            Q9.ViewCustomAttributes = "";

            // Q10
            if (ConvertToBool(Q10.CurrentValue)) {
                Q10.ViewValue = Q10.TagCaption(1) != "" ? Q10.TagCaption(1) : "Yes";
            } else {
                Q10.ViewValue = Q10.TagCaption(2) != "" ? Q10.TagCaption(2) : "No";
            }
            Q10.ViewCustomAttributes = "";

            // Q11
            if (ConvertToBool(Q11.CurrentValue)) {
                Q11.ViewValue = Q11.TagCaption(1) != "" ? Q11.TagCaption(1) : "Yes";
            } else {
                Q11.ViewValue = Q11.TagCaption(2) != "" ? Q11.TagCaption(2) : "No";
            }
            Q11.ViewCustomAttributes = "";

            // Q12
            if (ConvertToBool(Q12.CurrentValue)) {
                Q12.ViewValue = Q12.TagCaption(1) != "" ? Q12.TagCaption(1) : "Yes";
            } else {
                Q12.ViewValue = Q12.TagCaption(2) != "" ? Q12.TagCaption(2) : "No";
            }
            Q12.ViewCustomAttributes = "";

            // Q13
            if (ConvertToBool(Q13.CurrentValue)) {
                Q13.ViewValue = Q13.TagCaption(1) != "" ? Q13.TagCaption(1) : "Yes";
            } else {
                Q13.ViewValue = Q13.TagCaption(2) != "" ? Q13.TagCaption(2) : "No";
            }
            Q13.ViewCustomAttributes = "";

            // Q14
            if (ConvertToBool(Q14.CurrentValue)) {
                Q14.ViewValue = Q14.TagCaption(1) != "" ? Q14.TagCaption(1) : "Yes";
            } else {
                Q14.ViewValue = Q14.TagCaption(2) != "" ? Q14.TagCaption(2) : "No";
            }
            Q14.ViewCustomAttributes = "";

            // Q15
            if (ConvertToBool(Q15.CurrentValue)) {
                Q15.ViewValue = Q15.TagCaption(1) != "" ? Q15.TagCaption(1) : "Yes";
            } else {
                Q15.ViewValue = Q15.TagCaption(2) != "" ? Q15.TagCaption(2) : "No";
            }
            Q15.ViewCustomAttributes = "";

            // Section_3
            Section_3.ViewValue = ConvertToString(Section_3.CurrentValue); // DN
            Section_3.ViewCustomAttributes = "";

            // Q16
            if (ConvertToBool(Q16.CurrentValue)) {
                Q16.ViewValue = Q16.TagCaption(1) != "" ? Q16.TagCaption(1) : "Yes";
            } else {
                Q16.ViewValue = Q16.TagCaption(2) != "" ? Q16.TagCaption(2) : "No";
            }
            Q16.ViewCustomAttributes = "";

            // Q17
            if (ConvertToBool(Q17.CurrentValue)) {
                Q17.ViewValue = Q17.TagCaption(1) != "" ? Q17.TagCaption(1) : "Yes";
            } else {
                Q17.ViewValue = Q17.TagCaption(2) != "" ? Q17.TagCaption(2) : "No";
            }
            Q17.ViewCustomAttributes = "";

            // Q18
            if (ConvertToBool(Q18.CurrentValue)) {
                Q18.ViewValue = Q18.TagCaption(1) != "" ? Q18.TagCaption(1) : "Yes";
            } else {
                Q18.ViewValue = Q18.TagCaption(2) != "" ? Q18.TagCaption(2) : "No";
            }
            Q18.ViewCustomAttributes = "";

            // Q19
            if (ConvertToBool(Q19.CurrentValue)) {
                Q19.ViewValue = Q19.TagCaption(1) != "" ? Q19.TagCaption(1) : "Yes";
            } else {
                Q19.ViewValue = Q19.TagCaption(2) != "" ? Q19.TagCaption(2) : "No";
            }
            Q19.ViewCustomAttributes = "";

            // Q20
            if (ConvertToBool(Q20.CurrentValue)) {
                Q20.ViewValue = Q20.TagCaption(1) != "" ? Q20.TagCaption(1) : "Yes";
            } else {
                Q20.ViewValue = Q20.TagCaption(2) != "" ? Q20.TagCaption(2) : "No";
            }
            Q20.ViewCustomAttributes = "";

            // Q21
            if (ConvertToBool(Q21.CurrentValue)) {
                Q21.ViewValue = Q21.TagCaption(1) != "" ? Q21.TagCaption(1) : "Yes";
            } else {
                Q21.ViewValue = Q21.TagCaption(2) != "" ? Q21.TagCaption(2) : "No";
            }
            Q21.ViewCustomAttributes = "";

            // Section_4
            Section_4.ViewValue = ConvertToString(Section_4.CurrentValue); // DN
            Section_4.ViewCustomAttributes = "";

            // Q22
            if (ConvertToBool(Q22.CurrentValue)) {
                Q22.ViewValue = Q22.TagCaption(1) != "" ? Q22.TagCaption(1) : "Yes";
            } else {
                Q22.ViewValue = Q22.TagCaption(2) != "" ? Q22.TagCaption(2) : "No";
            }
            Q22.ViewCustomAttributes = "";

            // Q23
            if (ConvertToBool(Q23.CurrentValue)) {
                Q23.ViewValue = Q23.TagCaption(1) != "" ? Q23.TagCaption(1) : "Yes";
            } else {
                Q23.ViewValue = Q23.TagCaption(2) != "" ? Q23.TagCaption(2) : "No";
            }
            Q23.ViewCustomAttributes = "";

            // Q24
            if (ConvertToBool(Q24.CurrentValue)) {
                Q24.ViewValue = Q24.TagCaption(1) != "" ? Q24.TagCaption(1) : "Yes";
            } else {
                Q24.ViewValue = Q24.TagCaption(2) != "" ? Q24.TagCaption(2) : "No";
            }
            Q24.ViewCustomAttributes = "";

            // Q25
            if (ConvertToBool(Q25.CurrentValue)) {
                Q25.ViewValue = Q25.TagCaption(1) != "" ? Q25.TagCaption(1) : "Yes";
            } else {
                Q25.ViewValue = Q25.TagCaption(2) != "" ? Q25.TagCaption(2) : "No";
            }
            Q25.ViewCustomAttributes = "";

            // Q26
            if (ConvertToBool(Q26.CurrentValue)) {
                Q26.ViewValue = Q26.TagCaption(1) != "" ? Q26.TagCaption(1) : "Yes";
            } else {
                Q26.ViewValue = Q26.TagCaption(2) != "" ? Q26.TagCaption(2) : "No";
            }
            Q26.ViewCustomAttributes = "";

            // Section_5
            Section_5.ViewValue = ConvertToString(Section_5.CurrentValue); // DN
            Section_5.ViewCustomAttributes = "";

            // Q27
            if (ConvertToBool(Q27.CurrentValue)) {
                Q27.ViewValue = Q27.TagCaption(1) != "" ? Q27.TagCaption(1) : "Yes";
            } else {
                Q27.ViewValue = Q27.TagCaption(2) != "" ? Q27.TagCaption(2) : "No";
            }
            Q27.ViewCustomAttributes = "";

            // Q28
            if (ConvertToBool(Q28.CurrentValue)) {
                Q28.ViewValue = Q28.TagCaption(1) != "" ? Q28.TagCaption(1) : "Yes";
            } else {
                Q28.ViewValue = Q28.TagCaption(2) != "" ? Q28.TagCaption(2) : "No";
            }
            Q28.ViewCustomAttributes = "";

            // Q29
            if (ConvertToBool(Q29.CurrentValue)) {
                Q29.ViewValue = Q29.TagCaption(1) != "" ? Q29.TagCaption(1) : "Yes";
            } else {
                Q29.ViewValue = Q29.TagCaption(2) != "" ? Q29.TagCaption(2) : "No";
            }
            Q29.ViewCustomAttributes = "";

            // Q30
            if (ConvertToBool(Q30.CurrentValue)) {
                Q30.ViewValue = Q30.TagCaption(1) != "" ? Q30.TagCaption(1) : "Yes";
            } else {
                Q30.ViewValue = Q30.TagCaption(2) != "" ? Q30.TagCaption(2) : "No";
            }
            Q30.ViewCustomAttributes = "";

            // Q31
            if (ConvertToBool(Q31.CurrentValue)) {
                Q31.ViewValue = Q31.TagCaption(1) != "" ? Q31.TagCaption(1) : "Yes";
            } else {
                Q31.ViewValue = Q31.TagCaption(2) != "" ? Q31.TagCaption(2) : "No";
            }
            Q31.ViewCustomAttributes = "";

            // Q32
            if (ConvertToBool(Q32.CurrentValue)) {
                Q32.ViewValue = Q32.TagCaption(1) != "" ? Q32.TagCaption(1) : "Yes";
            } else {
                Q32.ViewValue = Q32.TagCaption(2) != "" ? Q32.TagCaption(2) : "No";
            }
            Q32.ViewCustomAttributes = "";

            // Q33
            if (ConvertToBool(Q33.CurrentValue)) {
                Q33.ViewValue = Q33.TagCaption(1) != "" ? Q33.TagCaption(1) : "Yes";
            } else {
                Q33.ViewValue = Q33.TagCaption(2) != "" ? Q33.TagCaption(2) : "No";
            }
            Q33.ViewCustomAttributes = "";

            // Q34
            if (ConvertToBool(Q34.CurrentValue)) {
                Q34.ViewValue = Q34.TagCaption(1) != "" ? Q34.TagCaption(1) : "Yes";
            } else {
                Q34.ViewValue = Q34.TagCaption(2) != "" ? Q34.TagCaption(2) : "No";
            }
            Q34.ViewCustomAttributes = "";

            // Q35
            if (ConvertToBool(Q35.CurrentValue)) {
                Q35.ViewValue = Q35.TagCaption(1) != "" ? Q35.TagCaption(1) : "Yes";
            } else {
                Q35.ViewValue = Q35.TagCaption(2) != "" ? Q35.TagCaption(2) : "No";
            }
            Q35.ViewCustomAttributes = "";

            // Section_6
            Section_6.ViewValue = ConvertToString(Section_6.CurrentValue); // DN
            Section_6.ViewCustomAttributes = "";

            // Q36
            if (ConvertToBool(Q36.CurrentValue)) {
                Q36.ViewValue = Q36.TagCaption(1) != "" ? Q36.TagCaption(1) : "Yes";
            } else {
                Q36.ViewValue = Q36.TagCaption(2) != "" ? Q36.TagCaption(2) : "No";
            }
            Q36.ViewCustomAttributes = "";

            // Q37
            if (ConvertToBool(Q37.CurrentValue)) {
                Q37.ViewValue = Q37.TagCaption(1) != "" ? Q37.TagCaption(1) : "Yes";
            } else {
                Q37.ViewValue = Q37.TagCaption(2) != "" ? Q37.TagCaption(2) : "No";
            }
            Q37.ViewCustomAttributes = "";

            // Q38
            if (ConvertToBool(Q38.CurrentValue)) {
                Q38.ViewValue = Q38.TagCaption(1) != "" ? Q38.TagCaption(1) : "Yes";
            } else {
                Q38.ViewValue = Q38.TagCaption(2) != "" ? Q38.TagCaption(2) : "No";
            }
            Q38.ViewCustomAttributes = "";

            // Q39
            if (ConvertToBool(Q39.CurrentValue)) {
                Q39.ViewValue = Q39.TagCaption(1) != "" ? Q39.TagCaption(1) : "Yes";
            } else {
                Q39.ViewValue = Q39.TagCaption(2) != "" ? Q39.TagCaption(2) : "No";
            }
            Q39.ViewCustomAttributes = "";

            // Q40
            if (ConvertToBool(Q40.CurrentValue)) {
                Q40.ViewValue = Q40.TagCaption(1) != "" ? Q40.TagCaption(1) : "Yes";
            } else {
                Q40.ViewValue = Q40.TagCaption(2) != "" ? Q40.TagCaption(2) : "No";
            }
            Q40.ViewCustomAttributes = "";

            // Q41
            if (ConvertToBool(Q41.CurrentValue)) {
                Q41.ViewValue = Q41.TagCaption(1) != "" ? Q41.TagCaption(1) : "Yes";
            } else {
                Q41.ViewValue = Q41.TagCaption(2) != "" ? Q41.TagCaption(2) : "No";
            }
            Q41.ViewCustomAttributes = "";

            // Q42
            if (ConvertToBool(Q42.CurrentValue)) {
                Q42.ViewValue = Q42.TagCaption(1) != "" ? Q42.TagCaption(1) : "Yes";
            } else {
                Q42.ViewValue = Q42.TagCaption(2) != "" ? Q42.TagCaption(2) : "No";
            }
            Q42.ViewCustomAttributes = "";

            // Q43
            if (ConvertToBool(Q43.CurrentValue)) {
                Q43.ViewValue = Q43.TagCaption(1) != "" ? Q43.TagCaption(1) : "Yes";
            } else {
                Q43.ViewValue = Q43.TagCaption(2) != "" ? Q43.TagCaption(2) : "No";
            }
            Q43.ViewCustomAttributes = "";

            // Section_7
            Section_7.ViewValue = ConvertToString(Section_7.CurrentValue); // DN
            Section_7.ViewCustomAttributes = "";

            // Q44
            if (ConvertToBool(Q44.CurrentValue)) {
                Q44.ViewValue = Q44.TagCaption(1) != "" ? Q44.TagCaption(1) : "Yes";
            } else {
                Q44.ViewValue = Q44.TagCaption(2) != "" ? Q44.TagCaption(2) : "No";
            }
            Q44.ViewCustomAttributes = "";

            // Q45
            if (ConvertToBool(Q45.CurrentValue)) {
                Q45.ViewValue = Q45.TagCaption(1) != "" ? Q45.TagCaption(1) : "Yes";
            } else {
                Q45.ViewValue = Q45.TagCaption(2) != "" ? Q45.TagCaption(2) : "No";
            }
            Q45.ViewCustomAttributes = "";

            // Q46
            if (ConvertToBool(Q46.CurrentValue)) {
                Q46.ViewValue = Q46.TagCaption(1) != "" ? Q46.TagCaption(1) : "Yes";
            } else {
                Q46.ViewValue = Q46.TagCaption(2) != "" ? Q46.TagCaption(2) : "No";
            }
            Q46.ViewCustomAttributes = "";

            // Q47
            if (ConvertToBool(Q47.CurrentValue)) {
                Q47.ViewValue = Q47.TagCaption(1) != "" ? Q47.TagCaption(1) : "Yes";
            } else {
                Q47.ViewValue = Q47.TagCaption(2) != "" ? Q47.TagCaption(2) : "No";
            }
            Q47.ViewCustomAttributes = "";

            // Q48
            if (ConvertToBool(Q48.CurrentValue)) {
                Q48.ViewValue = Q48.TagCaption(1) != "" ? Q48.TagCaption(1) : "Yes";
            } else {
                Q48.ViewValue = Q48.TagCaption(2) != "" ? Q48.TagCaption(2) : "No";
            }
            Q48.ViewCustomAttributes = "";

            // Q49
            if (ConvertToBool(Q49.CurrentValue)) {
                Q49.ViewValue = Q49.TagCaption(1) != "" ? Q49.TagCaption(1) : "Yes";
            } else {
                Q49.ViewValue = Q49.TagCaption(2) != "" ? Q49.TagCaption(2) : "No";
            }
            Q49.ViewCustomAttributes = "";

            // Q50
            if (ConvertToBool(Q50.CurrentValue)) {
                Q50.ViewValue = Q50.TagCaption(1) != "" ? Q50.TagCaption(1) : "Yes";
            } else {
                Q50.ViewValue = Q50.TagCaption(2) != "" ? Q50.TagCaption(2) : "No";
            }
            Q50.ViewCustomAttributes = "";

            // Section_8
            Section_8.ViewValue = ConvertToString(Section_8.CurrentValue); // DN
            Section_8.ViewCustomAttributes = "";

            // Q51
            if (ConvertToBool(Q51.CurrentValue)) {
                Q51.ViewValue = Q51.TagCaption(1) != "" ? Q51.TagCaption(1) : "Yes";
            } else {
                Q51.ViewValue = Q51.TagCaption(2) != "" ? Q51.TagCaption(2) : "No";
            }
            Q51.ViewCustomAttributes = "";

            // Q52
            if (ConvertToBool(Q52.CurrentValue)) {
                Q52.ViewValue = Q52.TagCaption(1) != "" ? Q52.TagCaption(1) : "Yes";
            } else {
                Q52.ViewValue = Q52.TagCaption(2) != "" ? Q52.TagCaption(2) : "No";
            }
            Q52.ViewCustomAttributes = "";

            // Q53
            if (ConvertToBool(Q53.CurrentValue)) {
                Q53.ViewValue = Q53.TagCaption(1) != "" ? Q53.TagCaption(1) : "Yes";
            } else {
                Q53.ViewValue = Q53.TagCaption(2) != "" ? Q53.TagCaption(2) : "No";
            }
            Q53.ViewCustomAttributes = "";

            // Q54
            if (ConvertToBool(Q54.CurrentValue)) {
                Q54.ViewValue = Q54.TagCaption(1) != "" ? Q54.TagCaption(1) : "Yes";
            } else {
                Q54.ViewValue = Q54.TagCaption(2) != "" ? Q54.TagCaption(2) : "No";
            }
            Q54.ViewCustomAttributes = "";

            // Q55
            if (ConvertToBool(Q55.CurrentValue)) {
                Q55.ViewValue = Q55.TagCaption(1) != "" ? Q55.TagCaption(1) : "Yes";
            } else {
                Q55.ViewValue = Q55.TagCaption(2) != "" ? Q55.TagCaption(2) : "No";
            }
            Q55.ViewCustomAttributes = "";

            // Section_9
            Section_9.ViewValue = ConvertToString(Section_9.CurrentValue); // DN
            Section_9.ViewCustomAttributes = "";

            // Q56
            if (ConvertToBool(Q56.CurrentValue)) {
                Q56.ViewValue = Q56.TagCaption(1) != "" ? Q56.TagCaption(1) : "Yes";
            } else {
                Q56.ViewValue = Q56.TagCaption(2) != "" ? Q56.TagCaption(2) : "No";
            }
            Q56.ViewCustomAttributes = "";

            // Q57
            if (ConvertToBool(Q57.CurrentValue)) {
                Q57.ViewValue = Q57.TagCaption(1) != "" ? Q57.TagCaption(1) : "Yes";
            } else {
                Q57.ViewValue = Q57.TagCaption(2) != "" ? Q57.TagCaption(2) : "No";
            }
            Q57.ViewCustomAttributes = "";

            // Q58
            if (ConvertToBool(Q58.CurrentValue)) {
                Q58.ViewValue = Q58.TagCaption(1) != "" ? Q58.TagCaption(1) : "Yes";
            } else {
                Q58.ViewValue = Q58.TagCaption(2) != "" ? Q58.TagCaption(2) : "No";
            }
            Q58.ViewCustomAttributes = "";

            // Q59
            if (ConvertToBool(Q59.CurrentValue)) {
                Q59.ViewValue = Q59.TagCaption(1) != "" ? Q59.TagCaption(1) : "Yes";
            } else {
                Q59.ViewValue = Q59.TagCaption(2) != "" ? Q59.TagCaption(2) : "No";
            }
            Q59.ViewCustomAttributes = "";

            // Q60
            if (ConvertToBool(Q60.CurrentValue)) {
                Q60.ViewValue = Q60.TagCaption(1) != "" ? Q60.TagCaption(1) : "Yes";
            } else {
                Q60.ViewValue = Q60.TagCaption(2) != "" ? Q60.TagCaption(2) : "No";
            }
            Q60.ViewCustomAttributes = "";

            // Section_10
            Section_10.ViewValue = ConvertToString(Section_10.CurrentValue); // DN
            Section_10.ViewCustomAttributes = "";

            // Q61
            if (ConvertToBool(Q61.CurrentValue)) {
                Q61.ViewValue = Q61.TagCaption(1) != "" ? Q61.TagCaption(1) : "Yes";
            } else {
                Q61.ViewValue = Q61.TagCaption(2) != "" ? Q61.TagCaption(2) : "No";
            }
            Q61.ViewCustomAttributes = "";

            // Q62
            if (ConvertToBool(Q62.CurrentValue)) {
                Q62.ViewValue = Q62.TagCaption(1) != "" ? Q62.TagCaption(1) : "Yes";
            } else {
                Q62.ViewValue = Q62.TagCaption(2) != "" ? Q62.TagCaption(2) : "No";
            }
            Q62.ViewCustomAttributes = "";

            // Q63
            if (ConvertToBool(Q63.CurrentValue)) {
                Q63.ViewValue = Q63.TagCaption(1) != "" ? Q63.TagCaption(1) : "Yes";
            } else {
                Q63.ViewValue = Q63.TagCaption(2) != "" ? Q63.TagCaption(2) : "No";
            }
            Q63.ViewCustomAttributes = "";

            // Q64
            if (ConvertToBool(Q64.CurrentValue)) {
                Q64.ViewValue = Q64.TagCaption(1) != "" ? Q64.TagCaption(1) : "Yes";
            } else {
                Q64.ViewValue = Q64.TagCaption(2) != "" ? Q64.TagCaption(2) : "No";
            }
            Q64.ViewCustomAttributes = "";

            // Q65
            if (ConvertToBool(Q65.CurrentValue)) {
                Q65.ViewValue = Q65.TagCaption(1) != "" ? Q65.TagCaption(1) : "Yes";
            } else {
                Q65.ViewValue = Q65.TagCaption(2) != "" ? Q65.TagCaption(2) : "No";
            }
            Q65.ViewCustomAttributes = "";

            // Q66
            if (ConvertToBool(Q66.CurrentValue)) {
                Q66.ViewValue = Q66.TagCaption(1) != "" ? Q66.TagCaption(1) : "Yes";
            } else {
                Q66.ViewValue = Q66.TagCaption(2) != "" ? Q66.TagCaption(2) : "No";
            }
            Q66.ViewCustomAttributes = "";

            // Section_11
            Section_11.ViewValue = ConvertToString(Section_11.CurrentValue); // DN
            Section_11.ViewCustomAttributes = "";

            // Q67
            if (ConvertToBool(Q67.CurrentValue)) {
                Q67.ViewValue = Q67.TagCaption(1) != "" ? Q67.TagCaption(1) : "Yes";
            } else {
                Q67.ViewValue = Q67.TagCaption(2) != "" ? Q67.TagCaption(2) : "No";
            }
            Q67.ViewCustomAttributes = "";

            // Q68
            if (ConvertToBool(Q68.CurrentValue)) {
                Q68.ViewValue = Q68.TagCaption(1) != "" ? Q68.TagCaption(1) : "Yes";
            } else {
                Q68.ViewValue = Q68.TagCaption(2) != "" ? Q68.TagCaption(2) : "No";
            }
            Q68.ViewCustomAttributes = "";

            // Q69
            if (ConvertToBool(Q69.CurrentValue)) {
                Q69.ViewValue = Q69.TagCaption(1) != "" ? Q69.TagCaption(1) : "Yes";
            } else {
                Q69.ViewValue = Q69.TagCaption(2) != "" ? Q69.TagCaption(2) : "No";
            }
            Q69.ViewCustomAttributes = "";

            // Q70
            if (ConvertToBool(Q70.CurrentValue)) {
                Q70.ViewValue = Q70.TagCaption(1) != "" ? Q70.TagCaption(1) : "Yes";
            } else {
                Q70.ViewValue = Q70.TagCaption(2) != "" ? Q70.TagCaption(2) : "No";
            }
            Q70.ViewCustomAttributes = "";

            // Notes_3
            Notes_3.ViewValue = Notes_3.CurrentValue;
            Notes_3.ViewCustomAttributes = "";

            // Student_Signature
            Student_Signature.ViewValue = Student_Signature.CurrentValue;
            Student_Signature.ViewCustomAttributes = "";

            // Examiner_Signature
            Examiner_Signature.ViewValue = Examiner_Signature.CurrentValue;
            Examiner_Signature.ViewCustomAttributes = "";

            // str_Username
            str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
            str_Username.ViewCustomAttributes = "";

            // Retake
            if (ConvertToBool(Retake.CurrentValue)) {
                Retake.ViewValue = Retake.TagCaption(1) != "" ? Retake.TagCaption(1) : "Yes";
            } else {
                Retake.ViewValue = Retake.TagCaption(2) != "" ? Retake.TagCaption(2) : "No";
            }
            Retake.ViewCustomAttributes = "";

            // AbsherApptNbr
            AbsherApptNbr.ViewValue = ConvertToString(AbsherApptNbr.CurrentValue); // DN
            AbsherApptNbr.ViewCustomAttributes = "";

            // IsDrivingexperience
            if (ConvertToBool(IsDrivingexperience.CurrentValue)) {
                IsDrivingexperience.ViewValue = IsDrivingexperience.TagCaption(1) != "" ? IsDrivingexperience.TagCaption(1) : "Yes";
            } else {
                IsDrivingexperience.ViewValue = IsDrivingexperience.TagCaption(2) != "" ? IsDrivingexperience.TagCaption(2) : "No";
            }
            IsDrivingexperience.CellCssStyle += "text-align: center;";
            IsDrivingexperience.ViewCustomAttributes = "";

            // date_Birth_Hijri
            date_Birth_Hijri.ViewValue = ConvertToString(date_Birth_Hijri.CurrentValue); // DN
            date_Birth_Hijri.ViewCustomAttributes = "";

            // date_Birth
            date_Birth.ViewValue = date_Birth.CurrentValue;
            date_Birth.ViewValue = FormatDateTime(date_Birth.ViewValue, date_Birth.FormatPattern);
            date_Birth.ViewCustomAttributes = "";

            // str_Email
            str_Email.ViewValue = ConvertToString(str_Email.CurrentValue); // DN
            str_Email.ViewCustomAttributes = "";

            // UserlevelID
            UserlevelID.ViewValue = UserlevelID.CurrentValue;
            UserlevelID.ViewValue = FormatNumber(UserlevelID.ViewValue, UserlevelID.FormatPattern);
            UserlevelID.ViewCustomAttributes = "";

            // Assigned_int_Package_Id
            Assigned_int_Package_Id.ViewValue = Assigned_int_Package_Id.CurrentValue;
            Assigned_int_Package_Id.ViewValue = FormatNumber(Assigned_int_Package_Id.ViewValue, Assigned_int_Package_Id.FormatPattern);
            Assigned_int_Package_Id.ViewCustomAttributes = "";

            // Scores_S1
            Scores_S1.ViewValue = ConvertToString(Scores_S1.CurrentValue); // DN
            Scores_S1.ViewCustomAttributes = "";

            // S1
            if (ConvertToBool(S1.CurrentValue)) {
                S1.ViewValue = S1.TagCaption(1) != "" ? S1.TagCaption(1) : "Yes";
            } else {
                S1.ViewValue = S1.TagCaption(2) != "" ? S1.TagCaption(2) : "No";
            }
            S1.ViewCustomAttributes = "";

            // S2
            if (ConvertToBool(S2.CurrentValue)) {
                S2.ViewValue = S2.TagCaption(1) != "" ? S2.TagCaption(1) : "Yes";
            } else {
                S2.ViewValue = S2.TagCaption(2) != "" ? S2.TagCaption(2) : "No";
            }
            S2.ViewCustomAttributes = "";

            // S3
            if (ConvertToBool(S3.CurrentValue)) {
                S3.ViewValue = S3.TagCaption(1) != "" ? S3.TagCaption(1) : "Yes";
            } else {
                S3.ViewValue = S3.TagCaption(2) != "" ? S3.TagCaption(2) : "No";
            }
            S3.ViewCustomAttributes = "";

            // S4
            if (ConvertToBool(S4.CurrentValue)) {
                S4.ViewValue = S4.TagCaption(1) != "" ? S4.TagCaption(1) : "Yes";
            } else {
                S4.ViewValue = S4.TagCaption(2) != "" ? S4.TagCaption(2) : "No";
            }
            S4.ViewCustomAttributes = "";

            // S5
            if (ConvertToBool(S5.CurrentValue)) {
                S5.ViewValue = S5.TagCaption(1) != "" ? S5.TagCaption(1) : "Yes";
            } else {
                S5.ViewValue = S5.TagCaption(2) != "" ? S5.TagCaption(2) : "No";
            }
            S5.ViewCustomAttributes = "";

            // Scores_S2
            Scores_S2.ViewValue = ConvertToString(Scores_S2.CurrentValue); // DN
            Scores_S2.ViewCustomAttributes = "";

            // S6
            if (ConvertToBool(S6.CurrentValue)) {
                S6.ViewValue = S6.TagCaption(1) != "" ? S6.TagCaption(1) : "Yes";
            } else {
                S6.ViewValue = S6.TagCaption(2) != "" ? S6.TagCaption(2) : "No";
            }
            S6.ViewCustomAttributes = "";

            // S7
            if (ConvertToBool(S7.CurrentValue)) {
                S7.ViewValue = S7.TagCaption(1) != "" ? S7.TagCaption(1) : "Yes";
            } else {
                S7.ViewValue = S7.TagCaption(2) != "" ? S7.TagCaption(2) : "No";
            }
            S7.ViewCustomAttributes = "";

            // S8
            if (ConvertToBool(S8.CurrentValue)) {
                S8.ViewValue = S8.TagCaption(1) != "" ? S8.TagCaption(1) : "Yes";
            } else {
                S8.ViewValue = S8.TagCaption(2) != "" ? S8.TagCaption(2) : "No";
            }
            S8.ViewCustomAttributes = "";

            // S9
            if (ConvertToBool(S9.CurrentValue)) {
                S9.ViewValue = S9.TagCaption(1) != "" ? S9.TagCaption(1) : "Yes";
            } else {
                S9.ViewValue = S9.TagCaption(2) != "" ? S9.TagCaption(2) : "No";
            }
            S9.ViewCustomAttributes = "";

            // S10
            if (ConvertToBool(S10.CurrentValue)) {
                S10.ViewValue = S10.TagCaption(1) != "" ? S10.TagCaption(1) : "Yes";
            } else {
                S10.ViewValue = S10.TagCaption(2) != "" ? S10.TagCaption(2) : "No";
            }
            S10.ViewCustomAttributes = "";

            // S11
            if (ConvertToBool(S11.CurrentValue)) {
                S11.ViewValue = S11.TagCaption(1) != "" ? S11.TagCaption(1) : "Yes";
            } else {
                S11.ViewValue = S11.TagCaption(2) != "" ? S11.TagCaption(2) : "No";
            }
            S11.ViewCustomAttributes = "";

            // S12
            if (ConvertToBool(S12.CurrentValue)) {
                S12.ViewValue = S12.TagCaption(1) != "" ? S12.TagCaption(1) : "Yes";
            } else {
                S12.ViewValue = S12.TagCaption(2) != "" ? S12.TagCaption(2) : "No";
            }
            S12.ViewCustomAttributes = "";

            // S13
            if (ConvertToBool(S13.CurrentValue)) {
                S13.ViewValue = S13.TagCaption(1) != "" ? S13.TagCaption(1) : "Yes";
            } else {
                S13.ViewValue = S13.TagCaption(2) != "" ? S13.TagCaption(2) : "No";
            }
            S13.ViewCustomAttributes = "";

            // S14
            if (ConvertToBool(S14.CurrentValue)) {
                S14.ViewValue = S14.TagCaption(1) != "" ? S14.TagCaption(1) : "Yes";
            } else {
                S14.ViewValue = S14.TagCaption(2) != "" ? S14.TagCaption(2) : "No";
            }
            S14.ViewCustomAttributes = "";

            // S15
            if (ConvertToBool(S15.CurrentValue)) {
                S15.ViewValue = S15.TagCaption(1) != "" ? S15.TagCaption(1) : "Yes";
            } else {
                S15.ViewValue = S15.TagCaption(2) != "" ? S15.TagCaption(2) : "No";
            }
            S15.ViewCustomAttributes = "";

            // Scores_S3
            Scores_S3.ViewValue = ConvertToString(Scores_S3.CurrentValue); // DN
            Scores_S3.ViewCustomAttributes = "";

            // S16
            if (ConvertToBool(S16.CurrentValue)) {
                S16.ViewValue = S16.TagCaption(1) != "" ? S16.TagCaption(1) : "Yes";
            } else {
                S16.ViewValue = S16.TagCaption(2) != "" ? S16.TagCaption(2) : "No";
            }
            S16.ViewCustomAttributes = "";

            // S17
            if (ConvertToBool(S17.CurrentValue)) {
                S17.ViewValue = S17.TagCaption(1) != "" ? S17.TagCaption(1) : "Yes";
            } else {
                S17.ViewValue = S17.TagCaption(2) != "" ? S17.TagCaption(2) : "No";
            }
            S17.ViewCustomAttributes = "";

            // S18
            if (ConvertToBool(S18.CurrentValue)) {
                S18.ViewValue = S18.TagCaption(1) != "" ? S18.TagCaption(1) : "Yes";
            } else {
                S18.ViewValue = S18.TagCaption(2) != "" ? S18.TagCaption(2) : "No";
            }
            S18.ViewCustomAttributes = "";

            // S19
            if (ConvertToBool(S19.CurrentValue)) {
                S19.ViewValue = S19.TagCaption(1) != "" ? S19.TagCaption(1) : "Yes";
            } else {
                S19.ViewValue = S19.TagCaption(2) != "" ? S19.TagCaption(2) : "No";
            }
            S19.ViewCustomAttributes = "";

            // S20
            if (ConvertToBool(S20.CurrentValue)) {
                S20.ViewValue = S20.TagCaption(1) != "" ? S20.TagCaption(1) : "Yes";
            } else {
                S20.ViewValue = S20.TagCaption(2) != "" ? S20.TagCaption(2) : "No";
            }
            S20.ViewCustomAttributes = "";

            // S21
            if (ConvertToBool(S21.CurrentValue)) {
                S21.ViewValue = S21.TagCaption(1) != "" ? S21.TagCaption(1) : "Yes";
            } else {
                S21.ViewValue = S21.TagCaption(2) != "" ? S21.TagCaption(2) : "No";
            }
            S21.ViewCustomAttributes = "";

            // Scores_S4
            Scores_S4.ViewValue = ConvertToString(Scores_S4.CurrentValue); // DN
            Scores_S4.ViewCustomAttributes = "";

            // S22
            if (ConvertToBool(S22.CurrentValue)) {
                S22.ViewValue = S22.TagCaption(1) != "" ? S22.TagCaption(1) : "Yes";
            } else {
                S22.ViewValue = S22.TagCaption(2) != "" ? S22.TagCaption(2) : "No";
            }
            S22.ViewCustomAttributes = "";

            // S23
            if (ConvertToBool(S23.CurrentValue)) {
                S23.ViewValue = S23.TagCaption(1) != "" ? S23.TagCaption(1) : "Yes";
            } else {
                S23.ViewValue = S23.TagCaption(2) != "" ? S23.TagCaption(2) : "No";
            }
            S23.ViewCustomAttributes = "";

            // S24
            if (ConvertToBool(S24.CurrentValue)) {
                S24.ViewValue = S24.TagCaption(1) != "" ? S24.TagCaption(1) : "Yes";
            } else {
                S24.ViewValue = S24.TagCaption(2) != "" ? S24.TagCaption(2) : "No";
            }
            S24.ViewCustomAttributes = "";

            // S25
            if (ConvertToBool(S25.CurrentValue)) {
                S25.ViewValue = S25.TagCaption(1) != "" ? S25.TagCaption(1) : "Yes";
            } else {
                S25.ViewValue = S25.TagCaption(2) != "" ? S25.TagCaption(2) : "No";
            }
            S25.ViewCustomAttributes = "";

            // S26
            if (ConvertToBool(S26.CurrentValue)) {
                S26.ViewValue = S26.TagCaption(1) != "" ? S26.TagCaption(1) : "Yes";
            } else {
                S26.ViewValue = S26.TagCaption(2) != "" ? S26.TagCaption(2) : "No";
            }
            S26.ViewCustomAttributes = "";

            // Scores_S5
            Scores_S5.ViewValue = ConvertToString(Scores_S5.CurrentValue); // DN
            Scores_S5.ViewCustomAttributes = "";

            // S27
            if (ConvertToBool(S27.CurrentValue)) {
                S27.ViewValue = S27.TagCaption(1) != "" ? S27.TagCaption(1) : "Yes";
            } else {
                S27.ViewValue = S27.TagCaption(2) != "" ? S27.TagCaption(2) : "No";
            }
            S27.ViewCustomAttributes = "";

            // S28
            if (ConvertToBool(S28.CurrentValue)) {
                S28.ViewValue = S28.TagCaption(1) != "" ? S28.TagCaption(1) : "Yes";
            } else {
                S28.ViewValue = S28.TagCaption(2) != "" ? S28.TagCaption(2) : "No";
            }
            S28.ViewCustomAttributes = "";

            // S29
            if (ConvertToBool(S29.CurrentValue)) {
                S29.ViewValue = S29.TagCaption(1) != "" ? S29.TagCaption(1) : "Yes";
            } else {
                S29.ViewValue = S29.TagCaption(2) != "" ? S29.TagCaption(2) : "No";
            }
            S29.ViewCustomAttributes = "";

            // S30
            if (ConvertToBool(S30.CurrentValue)) {
                S30.ViewValue = S30.TagCaption(1) != "" ? S30.TagCaption(1) : "Yes";
            } else {
                S30.ViewValue = S30.TagCaption(2) != "" ? S30.TagCaption(2) : "No";
            }
            S30.ViewCustomAttributes = "";

            // S31
            if (ConvertToBool(S31.CurrentValue)) {
                S31.ViewValue = S31.TagCaption(1) != "" ? S31.TagCaption(1) : "Yes";
            } else {
                S31.ViewValue = S31.TagCaption(2) != "" ? S31.TagCaption(2) : "No";
            }
            S31.ViewCustomAttributes = "";

            // S32
            if (ConvertToBool(S32.CurrentValue)) {
                S32.ViewValue = S32.TagCaption(1) != "" ? S32.TagCaption(1) : "Yes";
            } else {
                S32.ViewValue = S32.TagCaption(2) != "" ? S32.TagCaption(2) : "No";
            }
            S32.ViewCustomAttributes = "";

            // S33
            if (ConvertToBool(S33.CurrentValue)) {
                S33.ViewValue = S33.TagCaption(1) != "" ? S33.TagCaption(1) : "Yes";
            } else {
                S33.ViewValue = S33.TagCaption(2) != "" ? S33.TagCaption(2) : "No";
            }
            S33.ViewCustomAttributes = "";

            // S34
            if (ConvertToBool(S34.CurrentValue)) {
                S34.ViewValue = S34.TagCaption(1) != "" ? S34.TagCaption(1) : "Yes";
            } else {
                S34.ViewValue = S34.TagCaption(2) != "" ? S34.TagCaption(2) : "No";
            }
            S34.ViewCustomAttributes = "";

            // S35
            if (ConvertToBool(S35.CurrentValue)) {
                S35.ViewValue = S35.TagCaption(1) != "" ? S35.TagCaption(1) : "Yes";
            } else {
                S35.ViewValue = S35.TagCaption(2) != "" ? S35.TagCaption(2) : "No";
            }
            S35.ViewCustomAttributes = "";

            // Scores_S6
            Scores_S6.ViewValue = ConvertToString(Scores_S6.CurrentValue); // DN
            Scores_S6.ViewCustomAttributes = "";

            // S36
            if (ConvertToBool(S36.CurrentValue)) {
                S36.ViewValue = S36.TagCaption(1) != "" ? S36.TagCaption(1) : "Yes";
            } else {
                S36.ViewValue = S36.TagCaption(2) != "" ? S36.TagCaption(2) : "No";
            }
            S36.ViewCustomAttributes = "";

            // S37
            if (ConvertToBool(S37.CurrentValue)) {
                S37.ViewValue = S37.TagCaption(1) != "" ? S37.TagCaption(1) : "Yes";
            } else {
                S37.ViewValue = S37.TagCaption(2) != "" ? S37.TagCaption(2) : "No";
            }
            S37.ViewCustomAttributes = "";

            // S38
            if (ConvertToBool(S38.CurrentValue)) {
                S38.ViewValue = S38.TagCaption(1) != "" ? S38.TagCaption(1) : "Yes";
            } else {
                S38.ViewValue = S38.TagCaption(2) != "" ? S38.TagCaption(2) : "No";
            }
            S38.ViewCustomAttributes = "";

            // S39
            if (ConvertToBool(S39.CurrentValue)) {
                S39.ViewValue = S39.TagCaption(1) != "" ? S39.TagCaption(1) : "Yes";
            } else {
                S39.ViewValue = S39.TagCaption(2) != "" ? S39.TagCaption(2) : "No";
            }
            S39.ViewCustomAttributes = "";

            // S40
            if (ConvertToBool(S40.CurrentValue)) {
                S40.ViewValue = S40.TagCaption(1) != "" ? S40.TagCaption(1) : "Yes";
            } else {
                S40.ViewValue = S40.TagCaption(2) != "" ? S40.TagCaption(2) : "No";
            }
            S40.ViewCustomAttributes = "";

            // S41
            if (ConvertToBool(S41.CurrentValue)) {
                S41.ViewValue = S41.TagCaption(1) != "" ? S41.TagCaption(1) : "Yes";
            } else {
                S41.ViewValue = S41.TagCaption(2) != "" ? S41.TagCaption(2) : "No";
            }
            S41.ViewCustomAttributes = "";

            // S42
            if (ConvertToBool(S42.CurrentValue)) {
                S42.ViewValue = S42.TagCaption(1) != "" ? S42.TagCaption(1) : "Yes";
            } else {
                S42.ViewValue = S42.TagCaption(2) != "" ? S42.TagCaption(2) : "No";
            }
            S42.ViewCustomAttributes = "";

            // S43
            if (ConvertToBool(S43.CurrentValue)) {
                S43.ViewValue = S43.TagCaption(1) != "" ? S43.TagCaption(1) : "Yes";
            } else {
                S43.ViewValue = S43.TagCaption(2) != "" ? S43.TagCaption(2) : "No";
            }
            S43.ViewCustomAttributes = "";

            // Scores_S7
            Scores_S7.ViewValue = ConvertToString(Scores_S7.CurrentValue); // DN
            Scores_S7.ViewCustomAttributes = "";

            // S44
            if (ConvertToBool(S44.CurrentValue)) {
                S44.ViewValue = S44.TagCaption(1) != "" ? S44.TagCaption(1) : "Yes";
            } else {
                S44.ViewValue = S44.TagCaption(2) != "" ? S44.TagCaption(2) : "No";
            }
            S44.ViewCustomAttributes = "";

            // S45
            if (ConvertToBool(S45.CurrentValue)) {
                S45.ViewValue = S45.TagCaption(1) != "" ? S45.TagCaption(1) : "Yes";
            } else {
                S45.ViewValue = S45.TagCaption(2) != "" ? S45.TagCaption(2) : "No";
            }
            S45.ViewCustomAttributes = "";

            // S46
            if (ConvertToBool(S46.CurrentValue)) {
                S46.ViewValue = S46.TagCaption(1) != "" ? S46.TagCaption(1) : "Yes";
            } else {
                S46.ViewValue = S46.TagCaption(2) != "" ? S46.TagCaption(2) : "No";
            }
            S46.ViewCustomAttributes = "";

            // S47
            if (ConvertToBool(S47.CurrentValue)) {
                S47.ViewValue = S47.TagCaption(1) != "" ? S47.TagCaption(1) : "Yes";
            } else {
                S47.ViewValue = S47.TagCaption(2) != "" ? S47.TagCaption(2) : "No";
            }
            S47.ViewCustomAttributes = "";

            // S48
            if (ConvertToBool(S48.CurrentValue)) {
                S48.ViewValue = S48.TagCaption(1) != "" ? S48.TagCaption(1) : "Yes";
            } else {
                S48.ViewValue = S48.TagCaption(2) != "" ? S48.TagCaption(2) : "No";
            }
            S48.ViewCustomAttributes = "";

            // S49
            if (ConvertToBool(S49.CurrentValue)) {
                S49.ViewValue = S49.TagCaption(1) != "" ? S49.TagCaption(1) : "Yes";
            } else {
                S49.ViewValue = S49.TagCaption(2) != "" ? S49.TagCaption(2) : "No";
            }
            S49.ViewCustomAttributes = "";

            // S50
            if (ConvertToBool(S50.CurrentValue)) {
                S50.ViewValue = S50.TagCaption(1) != "" ? S50.TagCaption(1) : "Yes";
            } else {
                S50.ViewValue = S50.TagCaption(2) != "" ? S50.TagCaption(2) : "No";
            }
            S50.ViewCustomAttributes = "";

            // Scores_S8
            Scores_S8.ViewValue = ConvertToString(Scores_S8.CurrentValue); // DN
            Scores_S8.ViewCustomAttributes = "";

            // S51
            if (ConvertToBool(S51.CurrentValue)) {
                S51.ViewValue = S51.TagCaption(1) != "" ? S51.TagCaption(1) : "Yes";
            } else {
                S51.ViewValue = S51.TagCaption(2) != "" ? S51.TagCaption(2) : "No";
            }
            S51.ViewCustomAttributes = "";

            // S52
            if (ConvertToBool(S52.CurrentValue)) {
                S52.ViewValue = S52.TagCaption(1) != "" ? S52.TagCaption(1) : "Yes";
            } else {
                S52.ViewValue = S52.TagCaption(2) != "" ? S52.TagCaption(2) : "No";
            }
            S52.ViewCustomAttributes = "";

            // S53
            if (ConvertToBool(S53.CurrentValue)) {
                S53.ViewValue = S53.TagCaption(1) != "" ? S53.TagCaption(1) : "Yes";
            } else {
                S53.ViewValue = S53.TagCaption(2) != "" ? S53.TagCaption(2) : "No";
            }
            S53.ViewCustomAttributes = "";

            // S54
            if (ConvertToBool(S54.CurrentValue)) {
                S54.ViewValue = S54.TagCaption(1) != "" ? S54.TagCaption(1) : "Yes";
            } else {
                S54.ViewValue = S54.TagCaption(2) != "" ? S54.TagCaption(2) : "No";
            }
            S54.ViewCustomAttributes = "";

            // S55
            if (ConvertToBool(S55.CurrentValue)) {
                S55.ViewValue = S55.TagCaption(1) != "" ? S55.TagCaption(1) : "Yes";
            } else {
                S55.ViewValue = S55.TagCaption(2) != "" ? S55.TagCaption(2) : "No";
            }
            S55.ViewCustomAttributes = "";

            // Scores_S9
            Scores_S9.ViewValue = ConvertToString(Scores_S9.CurrentValue); // DN
            Scores_S9.ViewCustomAttributes = "";

            // S56
            if (ConvertToBool(S56.CurrentValue)) {
                S56.ViewValue = S56.TagCaption(1) != "" ? S56.TagCaption(1) : "Yes";
            } else {
                S56.ViewValue = S56.TagCaption(2) != "" ? S56.TagCaption(2) : "No";
            }
            S56.ViewCustomAttributes = "";

            // S57
            if (ConvertToBool(S57.CurrentValue)) {
                S57.ViewValue = S57.TagCaption(1) != "" ? S57.TagCaption(1) : "Yes";
            } else {
                S57.ViewValue = S57.TagCaption(2) != "" ? S57.TagCaption(2) : "No";
            }
            S57.ViewCustomAttributes = "";

            // S58
            if (ConvertToBool(S58.CurrentValue)) {
                S58.ViewValue = S58.TagCaption(1) != "" ? S58.TagCaption(1) : "Yes";
            } else {
                S58.ViewValue = S58.TagCaption(2) != "" ? S58.TagCaption(2) : "No";
            }
            S58.ViewCustomAttributes = "";

            // S59
            if (ConvertToBool(S59.CurrentValue)) {
                S59.ViewValue = S59.TagCaption(1) != "" ? S59.TagCaption(1) : "Yes";
            } else {
                S59.ViewValue = S59.TagCaption(2) != "" ? S59.TagCaption(2) : "No";
            }
            S59.ViewCustomAttributes = "";

            // Scores_S10
            Scores_S10.ViewValue = ConvertToString(Scores_S10.CurrentValue); // DN
            Scores_S10.ViewCustomAttributes = "";

            // S60
            if (ConvertToBool(S60.CurrentValue)) {
                S60.ViewValue = S60.TagCaption(1) != "" ? S60.TagCaption(1) : "Yes";
            } else {
                S60.ViewValue = S60.TagCaption(2) != "" ? S60.TagCaption(2) : "No";
            }
            S60.ViewCustomAttributes = "";

            // S61
            if (ConvertToBool(S61.CurrentValue)) {
                S61.ViewValue = S61.TagCaption(1) != "" ? S61.TagCaption(1) : "Yes";
            } else {
                S61.ViewValue = S61.TagCaption(2) != "" ? S61.TagCaption(2) : "No";
            }
            S61.ViewCustomAttributes = "";

            // S62
            if (ConvertToBool(S62.CurrentValue)) {
                S62.ViewValue = S62.TagCaption(1) != "" ? S62.TagCaption(1) : "Yes";
            } else {
                S62.ViewValue = S62.TagCaption(2) != "" ? S62.TagCaption(2) : "No";
            }
            S62.ViewCustomAttributes = "";

            // S63
            if (ConvertToBool(S63.CurrentValue)) {
                S63.ViewValue = S63.TagCaption(1) != "" ? S63.TagCaption(1) : "Yes";
            } else {
                S63.ViewValue = S63.TagCaption(2) != "" ? S63.TagCaption(2) : "No";
            }
            S63.ViewCustomAttributes = "";

            // S64
            if (ConvertToBool(S64.CurrentValue)) {
                S64.ViewValue = S64.TagCaption(1) != "" ? S64.TagCaption(1) : "Yes";
            } else {
                S64.ViewValue = S64.TagCaption(2) != "" ? S64.TagCaption(2) : "No";
            }
            S64.ViewCustomAttributes = "";

            // S65
            if (ConvertToBool(S65.CurrentValue)) {
                S65.ViewValue = S65.TagCaption(1) != "" ? S65.TagCaption(1) : "Yes";
            } else {
                S65.ViewValue = S65.TagCaption(2) != "" ? S65.TagCaption(2) : "No";
            }
            S65.ViewCustomAttributes = "";

            // Scores_S11
            Scores_S11.ViewValue = ConvertToString(Scores_S11.CurrentValue); // DN
            Scores_S11.ViewCustomAttributes = "";

            // S66
            if (ConvertToBool(S66.CurrentValue)) {
                S66.ViewValue = S66.TagCaption(1) != "" ? S66.TagCaption(1) : "Yes";
            } else {
                S66.ViewValue = S66.TagCaption(2) != "" ? S66.TagCaption(2) : "No";
            }
            S66.ViewCustomAttributes = "";

            // S67
            if (ConvertToBool(S67.CurrentValue)) {
                S67.ViewValue = S67.TagCaption(1) != "" ? S67.TagCaption(1) : "Yes";
            } else {
                S67.ViewValue = S67.TagCaption(2) != "" ? S67.TagCaption(2) : "No";
            }
            S67.ViewCustomAttributes = "";

            // S68
            if (ConvertToBool(S68.CurrentValue)) {
                S68.ViewValue = S68.TagCaption(1) != "" ? S68.TagCaption(1) : "Yes";
            } else {
                S68.ViewValue = S68.TagCaption(2) != "" ? S68.TagCaption(2) : "No";
            }
            S68.ViewCustomAttributes = "";

            // S69
            if (ConvertToBool(S69.CurrentValue)) {
                S69.ViewValue = S69.TagCaption(1) != "" ? S69.TagCaption(1) : "Yes";
            } else {
                S69.ViewValue = S69.TagCaption(2) != "" ? S69.TagCaption(2) : "No";
            }
            S69.ViewCustomAttributes = "";

            // S70
            if (ConvertToBool(S70.CurrentValue)) {
                S70.ViewValue = S70.TagCaption(1) != "" ? S70.TagCaption(1) : "Yes";
            } else {
                S70.ViewValue = S70.TagCaption(2) != "" ? S70.TagCaption(2) : "No";
            }
            S70.ViewCustomAttributes = "";

            // DriveTypelink
            DriveTypelink.ViewValue = DriveTypelink.CurrentValue;
            DriveTypelink.ViewCustomAttributes = "";

            // Evaluation_Score
            Evaluation_Score.ViewValue = Evaluation_Score.CurrentValue;
            Evaluation_Score.ViewValue = FormatNumber(Evaluation_Score.ViewValue, Evaluation_Score.FormatPattern);
            Evaluation_Score.ViewCustomAttributes = "";

            // Immediate_Failure_Score
            Immediate_Failure_Score.ViewValue = Immediate_Failure_Score.CurrentValue;
            Immediate_Failure_Score.ViewValue = FormatNumber(Immediate_Failure_Score.ViewValue, Immediate_Failure_Score.FormatPattern);
            Immediate_Failure_Score.ViewCustomAttributes = "";

            // Required_Program
            Required_Program.ViewValue = ConvertToString(Required_Program.CurrentValue); // DN
            Required_Program.ViewCustomAttributes = "";

            // Price
            Price.ViewValue = Price.CurrentValue;
            Price.ViewValue = FormatNumber(Price.ViewValue, Price.FormatPattern);
            Price.ViewCustomAttributes = "";

            // intEvaluationType
            intEvaluationType.ViewValue = intEvaluationType.CurrentValue;
            intEvaluationType.ViewValue = FormatNumber(intEvaluationType.ViewValue, intEvaluationType.FormatPattern);
            intEvaluationType.ViewCustomAttributes = "";

            // Institution
            Institution.ViewValue = ConvertToString(Institution.CurrentValue); // DN
            Institution.ViewCustomAttributes = "";

            // Eval_ID
            Eval_ID.HrefValue = "";
            Eval_ID.TooltipValue = "";

            // AssessmentID
            AssessmentID.HrefValue = "";
            AssessmentID.TooltipValue = "";

            // str_Full_Name_Hdr
            str_Full_Name_Hdr.HrefValue = "";
            str_Full_Name_Hdr.TooltipValue = "";

            // NationalID
            NationalID.HrefValue = "";
            NationalID.TooltipValue = "";

            // str_Cell_Phone
            str_Cell_Phone.HrefValue = "";
            str_Cell_Phone.TooltipValue = "";

            // int_Student_ID
            int_Student_ID.HrefValue = "";
            int_Student_ID.TooltipValue = "";

            // intDrivinglicenseType
            if (!IsNull(DriveTypelink.CurrentValue)) {
                intDrivinglicenseType.HrefValue = ConvertToString(!Empty(DriveTypelink.ViewValue) && !IsList(DriveTypelink.ViewValue) ? RemoveHtml(ConvertToString(DriveTypelink.ViewValue)) : ConvertToString(DriveTypelink.CurrentValue)); // Add prefix/suffix
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
                intDrivinglicenseType.LinkAttrs["data-tooltip-id"] = "tt_tblEvaluation_x" + ((RowType != RowType.Master && RowCount > 0) ? ConvertToString(RowCount) : "") + "_intDrivinglicenseType";
                intDrivinglicenseType.LinkAttrs["data-tooltip-width"] = ConvertToString(intDrivinglicenseType.TooltipWidth);
                intDrivinglicenseType.LinkAttrs["data-bs-placement"] = IsRTL ? "left" : "right";
            }

            // Date_Entered
            Date_Entered.HrefValue = "";
            Date_Entered.TooltipValue = "";

            // Examination_Number
            Examination_Number.HrefValue = "";
            Examination_Number.TooltipValue = "";

            // Section_1
            Section_1.HrefValue = "";
            Section_1.TooltipValue = "";

            // Q1
            Q1.HrefValue = "";
            Q1.TooltipValue = "";

            // Q2
            Q2.HrefValue = "";
            Q2.TooltipValue = "";

            // Q3
            Q3.HrefValue = "";
            Q3.TooltipValue = "";

            // Q4
            Q4.HrefValue = "";
            Q4.TooltipValue = "";

            // Q5
            Q5.HrefValue = "";
            Q5.TooltipValue = "";

            // Section_2
            Section_2.HrefValue = "";
            Section_2.TooltipValue = "";

            // Q6
            Q6.HrefValue = "";
            Q6.TooltipValue = "";

            // Q7
            Q7.HrefValue = "";
            Q7.TooltipValue = "";

            // Q8
            Q8.HrefValue = "";
            Q8.TooltipValue = "";

            // Q9
            Q9.HrefValue = "";
            Q9.TooltipValue = "";

            // Q10
            Q10.HrefValue = "";
            Q10.TooltipValue = "";

            // Q11
            Q11.HrefValue = "";
            Q11.TooltipValue = "";

            // Q12
            Q12.HrefValue = "";
            Q12.TooltipValue = "";

            // Q13
            Q13.HrefValue = "";
            Q13.TooltipValue = "";

            // Q14
            Q14.HrefValue = "";
            Q14.TooltipValue = "";

            // Q15
            Q15.HrefValue = "";
            Q15.TooltipValue = "";

            // Section_3
            Section_3.HrefValue = "";
            Section_3.TooltipValue = "";

            // Q16
            Q16.HrefValue = "";
            Q16.TooltipValue = "";

            // Q17
            Q17.HrefValue = "";
            Q17.TooltipValue = "";

            // Q18
            Q18.HrefValue = "";
            Q18.TooltipValue = "";

            // Q19
            Q19.HrefValue = "";
            Q19.TooltipValue = "";

            // Q20
            Q20.HrefValue = "";
            Q20.TooltipValue = "";

            // Q21
            Q21.HrefValue = "";
            Q21.TooltipValue = "";

            // Section_4
            Section_4.HrefValue = "";
            Section_4.TooltipValue = "";

            // Q22
            Q22.HrefValue = "";
            Q22.TooltipValue = "";

            // Q23
            Q23.HrefValue = "";
            Q23.TooltipValue = "";

            // Q24
            Q24.HrefValue = "";
            Q24.TooltipValue = "";

            // Q25
            Q25.HrefValue = "";
            Q25.TooltipValue = "";

            // Q26
            Q26.HrefValue = "";
            Q26.TooltipValue = "";

            // Section_5
            Section_5.HrefValue = "";
            Section_5.TooltipValue = "";

            // Q27
            Q27.HrefValue = "";
            Q27.TooltipValue = "";

            // Q28
            Q28.HrefValue = "";
            Q28.TooltipValue = "";

            // Q29
            Q29.HrefValue = "";
            Q29.TooltipValue = "";

            // Q30
            Q30.HrefValue = "";
            Q30.TooltipValue = "";

            // Q31
            Q31.HrefValue = "";
            Q31.TooltipValue = "";

            // Q32
            Q32.HrefValue = "";
            Q32.TooltipValue = "";

            // Q33
            Q33.HrefValue = "";
            Q33.TooltipValue = "";

            // Q34
            Q34.HrefValue = "";
            Q34.TooltipValue = "";

            // Q35
            Q35.HrefValue = "";
            Q35.TooltipValue = "";

            // Section_6
            Section_6.HrefValue = "";
            Section_6.TooltipValue = "";

            // Q36
            Q36.HrefValue = "";
            Q36.TooltipValue = "";

            // Q37
            Q37.HrefValue = "";
            Q37.TooltipValue = "";

            // Q38
            Q38.HrefValue = "";
            Q38.TooltipValue = "";

            // Q39
            Q39.HrefValue = "";
            Q39.TooltipValue = "";

            // Q40
            Q40.HrefValue = "";
            Q40.TooltipValue = "";

            // Q41
            Q41.HrefValue = "";
            Q41.TooltipValue = "";

            // Q42
            Q42.HrefValue = "";
            Q42.TooltipValue = "";

            // Q43
            Q43.HrefValue = "";
            Q43.TooltipValue = "";

            // Section_7
            Section_7.HrefValue = "";
            Section_7.TooltipValue = "";

            // Q44
            Q44.HrefValue = "";
            Q44.TooltipValue = "";

            // Q45
            Q45.HrefValue = "";
            Q45.TooltipValue = "";

            // Q46
            Q46.HrefValue = "";
            Q46.TooltipValue = "";

            // Q47
            Q47.HrefValue = "";
            Q47.TooltipValue = "";

            // Q48
            Q48.HrefValue = "";
            Q48.TooltipValue = "";

            // Q49
            Q49.HrefValue = "";
            Q49.TooltipValue = "";

            // Q50
            Q50.HrefValue = "";
            Q50.TooltipValue = "";

            // Section_8
            Section_8.HrefValue = "";
            Section_8.TooltipValue = "";

            // Q51
            Q51.HrefValue = "";
            Q51.TooltipValue = "";

            // Q52
            Q52.HrefValue = "";
            Q52.TooltipValue = "";

            // Q53
            Q53.HrefValue = "";
            Q53.TooltipValue = "";

            // Q54
            Q54.HrefValue = "";
            Q54.TooltipValue = "";

            // Q55
            Q55.HrefValue = "";
            Q55.TooltipValue = "";

            // Section_9
            Section_9.HrefValue = "";
            Section_9.TooltipValue = "";

            // Q56
            Q56.HrefValue = "";
            Q56.TooltipValue = "";

            // Q57
            Q57.HrefValue = "";
            Q57.TooltipValue = "";

            // Q58
            Q58.HrefValue = "";
            Q58.TooltipValue = "";

            // Q59
            Q59.HrefValue = "";
            Q59.TooltipValue = "";

            // Q60
            Q60.HrefValue = "";
            Q60.TooltipValue = "";

            // Section_10
            Section_10.HrefValue = "";
            Section_10.TooltipValue = "";

            // Q61
            Q61.HrefValue = "";
            Q61.TooltipValue = "";

            // Q62
            Q62.HrefValue = "";
            Q62.TooltipValue = "";

            // Q63
            Q63.HrefValue = "";
            Q63.TooltipValue = "";

            // Q64
            Q64.HrefValue = "";
            Q64.TooltipValue = "";

            // Q65
            Q65.HrefValue = "";
            Q65.TooltipValue = "";

            // Q66
            Q66.HrefValue = "";
            Q66.TooltipValue = "";

            // Section_11
            Section_11.HrefValue = "";
            Section_11.TooltipValue = "";

            // Q67
            Q67.HrefValue = "";
            Q67.TooltipValue = "";

            // Q68
            Q68.HrefValue = "";
            Q68.TooltipValue = "";

            // Q69
            Q69.HrefValue = "";
            Q69.TooltipValue = "";

            // Q70
            Q70.HrefValue = "";
            Q70.TooltipValue = "";

            // Notes_3
            Notes_3.HrefValue = "";
            Notes_3.TooltipValue = "";

            // Student_Signature
            Student_Signature.HrefValue = "";
            Student_Signature.TooltipValue = "";

            // Examiner_Signature
            Examiner_Signature.HrefValue = "";
            Examiner_Signature.TooltipValue = "";

            // str_Username
            str_Username.HrefValue = "";
            str_Username.TooltipValue = "";

            // Retake
            Retake.HrefValue = "";
            Retake.TooltipValue = "";

            // AbsherApptNbr
            AbsherApptNbr.HrefValue = "";
            AbsherApptNbr.TooltipValue = "";

            // IsDrivingexperience
            IsDrivingexperience.HrefValue = "";
            IsDrivingexperience.TooltipValue = "";

            // date_Birth_Hijri
            date_Birth_Hijri.HrefValue = "";
            date_Birth_Hijri.TooltipValue = "";

            // date_Birth
            date_Birth.HrefValue = "";
            date_Birth.TooltipValue = "";

            // str_Email
            str_Email.HrefValue = "";
            str_Email.TooltipValue = "";

            // UserlevelID
            UserlevelID.HrefValue = "";
            UserlevelID.TooltipValue = "";

            // Assigned_int_Package_Id
            Assigned_int_Package_Id.HrefValue = "";
            Assigned_int_Package_Id.TooltipValue = "";

            // Scores_S1
            Scores_S1.HrefValue = "";
            Scores_S1.TooltipValue = "";

            // S1
            S1.HrefValue = "";
            S1.TooltipValue = "";

            // S2
            S2.HrefValue = "";
            S2.TooltipValue = "";

            // S3
            S3.HrefValue = "";
            S3.TooltipValue = "";

            // S4
            S4.HrefValue = "";
            S4.TooltipValue = "";

            // S5
            S5.HrefValue = "";
            S5.TooltipValue = "";

            // Scores_S2
            Scores_S2.HrefValue = "";
            Scores_S2.TooltipValue = "";

            // S6
            S6.HrefValue = "";
            S6.TooltipValue = "";

            // S7
            S7.HrefValue = "";
            S7.TooltipValue = "";

            // S8
            S8.HrefValue = "";
            S8.TooltipValue = "";

            // S9
            S9.HrefValue = "";
            S9.TooltipValue = "";

            // S10
            S10.HrefValue = "";
            S10.TooltipValue = "";

            // S11
            S11.HrefValue = "";
            S11.TooltipValue = "";

            // S12
            S12.HrefValue = "";
            S12.TooltipValue = "";

            // S13
            S13.HrefValue = "";
            S13.TooltipValue = "";

            // S14
            S14.HrefValue = "";
            S14.TooltipValue = "";

            // S15
            S15.HrefValue = "";
            S15.TooltipValue = "";

            // Scores_S3
            Scores_S3.HrefValue = "";
            Scores_S3.TooltipValue = "";

            // S16
            S16.HrefValue = "";
            S16.TooltipValue = "";

            // S17
            S17.HrefValue = "";
            S17.TooltipValue = "";

            // S18
            S18.HrefValue = "";
            S18.TooltipValue = "";

            // S19
            S19.HrefValue = "";
            S19.TooltipValue = "";

            // S20
            S20.HrefValue = "";
            S20.TooltipValue = "";

            // S21
            S21.HrefValue = "";
            S21.TooltipValue = "";

            // Scores_S4
            Scores_S4.HrefValue = "";
            Scores_S4.TooltipValue = "";

            // S22
            S22.HrefValue = "";
            S22.TooltipValue = "";

            // S23
            S23.HrefValue = "";
            S23.TooltipValue = "";

            // S24
            S24.HrefValue = "";
            S24.TooltipValue = "";

            // S25
            S25.HrefValue = "";
            S25.TooltipValue = "";

            // S26
            S26.HrefValue = "";
            S26.TooltipValue = "";

            // Scores_S5
            Scores_S5.HrefValue = "";
            Scores_S5.TooltipValue = "";

            // S27
            S27.HrefValue = "";
            S27.TooltipValue = "";

            // S28
            S28.HrefValue = "";
            S28.TooltipValue = "";

            // S29
            S29.HrefValue = "";
            S29.TooltipValue = "";

            // S30
            S30.HrefValue = "";
            S30.TooltipValue = "";

            // S31
            S31.HrefValue = "";
            S31.TooltipValue = "";

            // S32
            S32.HrefValue = "";
            S32.TooltipValue = "";

            // S33
            S33.HrefValue = "";
            S33.TooltipValue = "";

            // S34
            S34.HrefValue = "";
            S34.TooltipValue = "";

            // S35
            S35.HrefValue = "";
            S35.TooltipValue = "";

            // Scores_S6
            Scores_S6.HrefValue = "";
            Scores_S6.TooltipValue = "";

            // S36
            S36.HrefValue = "";
            S36.TooltipValue = "";

            // S37
            S37.HrefValue = "";
            S37.TooltipValue = "";

            // S38
            S38.HrefValue = "";
            S38.TooltipValue = "";

            // S39
            S39.HrefValue = "";
            S39.TooltipValue = "";

            // S40
            S40.HrefValue = "";
            S40.TooltipValue = "";

            // S41
            S41.HrefValue = "";
            S41.TooltipValue = "";

            // S42
            S42.HrefValue = "";
            S42.TooltipValue = "";

            // S43
            S43.HrefValue = "";
            S43.TooltipValue = "";

            // Scores_S7
            Scores_S7.HrefValue = "";
            Scores_S7.TooltipValue = "";

            // S44
            S44.HrefValue = "";
            S44.TooltipValue = "";

            // S45
            S45.HrefValue = "";
            S45.TooltipValue = "";

            // S46
            S46.HrefValue = "";
            S46.TooltipValue = "";

            // S47
            S47.HrefValue = "";
            S47.TooltipValue = "";

            // S48
            S48.HrefValue = "";
            S48.TooltipValue = "";

            // S49
            S49.HrefValue = "";
            S49.TooltipValue = "";

            // S50
            S50.HrefValue = "";
            S50.TooltipValue = "";

            // Scores_S8
            Scores_S8.HrefValue = "";
            Scores_S8.TooltipValue = "";

            // S51
            S51.HrefValue = "";
            S51.TooltipValue = "";

            // S52
            S52.HrefValue = "";
            S52.TooltipValue = "";

            // S53
            S53.HrefValue = "";
            S53.TooltipValue = "";

            // S54
            S54.HrefValue = "";
            S54.TooltipValue = "";

            // S55
            S55.HrefValue = "";
            S55.TooltipValue = "";

            // Scores_S9
            Scores_S9.HrefValue = "";
            Scores_S9.TooltipValue = "";

            // S56
            S56.HrefValue = "";
            S56.TooltipValue = "";

            // S57
            S57.HrefValue = "";
            S57.TooltipValue = "";

            // S58
            S58.HrefValue = "";
            S58.TooltipValue = "";

            // S59
            S59.HrefValue = "";
            S59.TooltipValue = "";

            // Scores_S10
            Scores_S10.HrefValue = "";
            Scores_S10.TooltipValue = "";

            // S60
            S60.HrefValue = "";
            S60.TooltipValue = "";

            // S61
            S61.HrefValue = "";
            S61.TooltipValue = "";

            // S62
            S62.HrefValue = "";
            S62.TooltipValue = "";

            // S63
            S63.HrefValue = "";
            S63.TooltipValue = "";

            // S64
            S64.HrefValue = "";
            S64.TooltipValue = "";

            // S65
            S65.HrefValue = "";
            S65.TooltipValue = "";

            // Scores_S11
            Scores_S11.HrefValue = "";
            Scores_S11.TooltipValue = "";

            // S66
            S66.HrefValue = "";
            S66.TooltipValue = "";

            // S67
            S67.HrefValue = "";
            S67.TooltipValue = "";

            // S68
            S68.HrefValue = "";
            S68.TooltipValue = "";

            // S69
            S69.HrefValue = "";
            S69.TooltipValue = "";

            // S70
            S70.HrefValue = "";
            S70.TooltipValue = "";

            // DriveTypelink
            DriveTypelink.HrefValue = "";
            DriveTypelink.TooltipValue = "";

            // Evaluation_Score
            Evaluation_Score.HrefValue = "";
            Evaluation_Score.TooltipValue = "";

            // Immediate_Failure_Score
            Immediate_Failure_Score.HrefValue = "";
            Immediate_Failure_Score.TooltipValue = "";

            // Required_Program
            Required_Program.HrefValue = "";
            Required_Program.TooltipValue = "";

            // Price
            Price.HrefValue = "";
            Price.TooltipValue = "";

            // intEvaluationType
            intEvaluationType.HrefValue = "";
            intEvaluationType.TooltipValue = "";

            // Institution
            Institution.HrefValue = "";
            Institution.TooltipValue = "";

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

            // Eval_ID
            Eval_ID.SetupEditAttributes();
            Eval_ID.EditValue = Eval_ID.CurrentValue;
            Eval_ID.ViewCustomAttributes = "";

            // AssessmentID
            AssessmentID.SetupEditAttributes();
            if (!Empty(AssessmentID.SessionValue)) {
                AssessmentID.CurrentValue = ForeignKeyValue(AssessmentID.SessionValue);
                AssessmentID.ViewValue = AssessmentID.CurrentValue;
                AssessmentID.ViewValue = FormatNumber(AssessmentID.ViewValue, AssessmentID.FormatPattern);
                AssessmentID.ViewCustomAttributes = "";
            } else {
                AssessmentID.EditValue = AssessmentID.CurrentValue; // DN
                AssessmentID.PlaceHolder = RemoveHtml(AssessmentID.Caption);
                if (!Empty(AssessmentID.EditValue) && IsNumeric(AssessmentID.EditValue))
                    AssessmentID.EditValue = FormatNumber(AssessmentID.EditValue, null);
            }

            // str_Full_Name_Hdr
            str_Full_Name_Hdr.SetupEditAttributes();
            str_Full_Name_Hdr.EditValue = ConvertToString(str_Full_Name_Hdr.CurrentValue); // DN
            str_Full_Name_Hdr.ViewCustomAttributes = "";

            // NationalID
            NationalID.SetupEditAttributes();
            NationalID.EditValue = NationalID.CurrentValue;
            NationalID.ViewCustomAttributes = "";

            // str_Cell_Phone
            str_Cell_Phone.SetupEditAttributes();
            str_Cell_Phone.EditValue = ConvertToString(str_Cell_Phone.CurrentValue); // DN
            str_Cell_Phone.ViewCustomAttributes = "";

            // int_Student_ID
            int_Student_ID.SetupEditAttributes();
            int_Student_ID.EditValue = int_Student_ID.CurrentValue; // DN
            int_Student_ID.PlaceHolder = RemoveHtml(int_Student_ID.Caption);
            if (!Empty(int_Student_ID.EditValue) && IsNumeric(int_Student_ID.EditValue))
                int_Student_ID.EditValue = FormatNumber(int_Student_ID.EditValue, null);

            // intDrivinglicenseType
            intDrivinglicenseType.SetupEditAttributes();
            intDrivinglicenseType.EditValue = intDrivinglicenseType.CurrentValue;
            intDrivinglicenseType.EditValue = FormatNumber(intDrivinglicenseType.EditValue, intDrivinglicenseType.FormatPattern);
            intDrivinglicenseType.CellCssStyle += "text-align: center;";
            intDrivinglicenseType.ViewCustomAttributes = "";

            // Date_Entered

            // Examination_Number
            Examination_Number.SetupEditAttributes();
            Examination_Number.EditValue = Examination_Number.CurrentValue; // DN
            Examination_Number.PlaceHolder = RemoveHtml(Examination_Number.Caption);
            if (!Empty(Examination_Number.EditValue) && IsNumeric(Examination_Number.EditValue))
                Examination_Number.EditValue = FormatNumber(Examination_Number.EditValue, null);

            // Section_1
            Section_1.SetupEditAttributes();
            if (!Section_1.Raw)
                Section_1.CurrentValue = HtmlDecode(Section_1.CurrentValue);
            Section_1.EditValue = HtmlEncode(Section_1.CurrentValue);
            Section_1.PlaceHolder = RemoveHtml(Section_1.Caption);

            // Q1
            Q1.EditValue = Q1.Options(false);
            Q1.PlaceHolder = RemoveHtml(Q1.Caption);

            // Q2
            Q2.EditValue = Q2.Options(false);
            Q2.PlaceHolder = RemoveHtml(Q2.Caption);

            // Q3
            Q3.EditValue = Q3.Options(false);
            Q3.PlaceHolder = RemoveHtml(Q3.Caption);

            // Q4
            Q4.EditValue = Q4.Options(false);
            Q4.PlaceHolder = RemoveHtml(Q4.Caption);

            // Q5
            Q5.EditValue = Q5.Options(false);
            Q5.PlaceHolder = RemoveHtml(Q5.Caption);

            // Section_2
            Section_2.SetupEditAttributes();
            Section_2.EditValue = ConvertToString(Section_2.CurrentValue); // DN
            Section_2.ViewCustomAttributes = "";

            // Q6
            Q6.EditValue = Q6.Options(false);
            Q6.PlaceHolder = RemoveHtml(Q6.Caption);

            // Q7
            Q7.EditValue = Q7.Options(false);
            Q7.PlaceHolder = RemoveHtml(Q7.Caption);

            // Q8
            Q8.EditValue = Q8.Options(false);
            Q8.PlaceHolder = RemoveHtml(Q8.Caption);

            // Q9
            Q9.EditValue = Q9.Options(false);
            Q9.PlaceHolder = RemoveHtml(Q9.Caption);

            // Q10
            Q10.EditValue = Q10.Options(false);
            Q10.PlaceHolder = RemoveHtml(Q10.Caption);

            // Q11
            Q11.EditValue = Q11.Options(false);
            Q11.PlaceHolder = RemoveHtml(Q11.Caption);

            // Q12
            Q12.EditValue = Q12.Options(false);
            Q12.PlaceHolder = RemoveHtml(Q12.Caption);

            // Q13
            Q13.EditValue = Q13.Options(false);
            Q13.PlaceHolder = RemoveHtml(Q13.Caption);

            // Q14
            Q14.EditValue = Q14.Options(false);
            Q14.PlaceHolder = RemoveHtml(Q14.Caption);

            // Q15
            Q15.EditValue = Q15.Options(false);
            Q15.PlaceHolder = RemoveHtml(Q15.Caption);

            // Section_3
            Section_3.SetupEditAttributes();
            Section_3.EditValue = ConvertToString(Section_3.CurrentValue); // DN
            Section_3.ViewCustomAttributes = "";

            // Q16
            Q16.EditValue = Q16.Options(false);
            Q16.PlaceHolder = RemoveHtml(Q16.Caption);

            // Q17
            Q17.EditValue = Q17.Options(false);
            Q17.PlaceHolder = RemoveHtml(Q17.Caption);

            // Q18
            Q18.EditValue = Q18.Options(false);
            Q18.PlaceHolder = RemoveHtml(Q18.Caption);

            // Q19
            Q19.EditValue = Q19.Options(false);
            Q19.PlaceHolder = RemoveHtml(Q19.Caption);

            // Q20
            Q20.EditValue = Q20.Options(false);
            Q20.PlaceHolder = RemoveHtml(Q20.Caption);

            // Q21
            Q21.EditValue = Q21.Options(false);
            Q21.PlaceHolder = RemoveHtml(Q21.Caption);

            // Section_4
            Section_4.SetupEditAttributes();
            Section_4.EditValue = ConvertToString(Section_4.CurrentValue); // DN
            Section_4.ViewCustomAttributes = "";

            // Q22
            Q22.EditValue = Q22.Options(false);
            Q22.PlaceHolder = RemoveHtml(Q22.Caption);

            // Q23
            Q23.EditValue = Q23.Options(false);
            Q23.PlaceHolder = RemoveHtml(Q23.Caption);

            // Q24
            Q24.EditValue = Q24.Options(false);
            Q24.PlaceHolder = RemoveHtml(Q24.Caption);

            // Q25
            Q25.EditValue = Q25.Options(false);
            Q25.PlaceHolder = RemoveHtml(Q25.Caption);

            // Q26
            Q26.EditValue = Q26.Options(false);
            Q26.PlaceHolder = RemoveHtml(Q26.Caption);

            // Section_5
            Section_5.SetupEditAttributes();
            Section_5.EditValue = ConvertToString(Section_5.CurrentValue); // DN
            Section_5.ViewCustomAttributes = "";

            // Q27
            Q27.EditValue = Q27.Options(false);
            Q27.PlaceHolder = RemoveHtml(Q27.Caption);

            // Q28
            Q28.EditValue = Q28.Options(false);
            Q28.PlaceHolder = RemoveHtml(Q28.Caption);

            // Q29
            Q29.EditValue = Q29.Options(false);
            Q29.PlaceHolder = RemoveHtml(Q29.Caption);

            // Q30
            Q30.EditValue = Q30.Options(false);
            Q30.PlaceHolder = RemoveHtml(Q30.Caption);

            // Q31
            Q31.EditValue = Q31.Options(false);
            Q31.PlaceHolder = RemoveHtml(Q31.Caption);

            // Q32
            Q32.EditValue = Q32.Options(false);
            Q32.PlaceHolder = RemoveHtml(Q32.Caption);

            // Q33
            Q33.EditValue = Q33.Options(false);
            Q33.PlaceHolder = RemoveHtml(Q33.Caption);

            // Q34
            Q34.EditValue = Q34.Options(false);
            Q34.PlaceHolder = RemoveHtml(Q34.Caption);

            // Q35
            Q35.EditValue = Q35.Options(false);
            Q35.PlaceHolder = RemoveHtml(Q35.Caption);

            // Section_6
            Section_6.SetupEditAttributes();
            Section_6.EditValue = ConvertToString(Section_6.CurrentValue); // DN
            Section_6.ViewCustomAttributes = "";

            // Q36
            Q36.EditValue = Q36.Options(false);
            Q36.PlaceHolder = RemoveHtml(Q36.Caption);

            // Q37
            Q37.EditValue = Q37.Options(false);
            Q37.PlaceHolder = RemoveHtml(Q37.Caption);

            // Q38
            Q38.EditValue = Q38.Options(false);
            Q38.PlaceHolder = RemoveHtml(Q38.Caption);

            // Q39
            Q39.EditValue = Q39.Options(false);
            Q39.PlaceHolder = RemoveHtml(Q39.Caption);

            // Q40
            Q40.EditValue = Q40.Options(false);
            Q40.PlaceHolder = RemoveHtml(Q40.Caption);

            // Q41
            Q41.EditValue = Q41.Options(false);
            Q41.PlaceHolder = RemoveHtml(Q41.Caption);

            // Q42
            Q42.EditValue = Q42.Options(false);
            Q42.PlaceHolder = RemoveHtml(Q42.Caption);

            // Q43
            Q43.EditValue = Q43.Options(false);
            Q43.PlaceHolder = RemoveHtml(Q43.Caption);

            // Section_7
            Section_7.SetupEditAttributes();
            Section_7.EditValue = ConvertToString(Section_7.CurrentValue); // DN
            Section_7.ViewCustomAttributes = "";

            // Q44
            Q44.EditValue = Q44.Options(false);
            Q44.PlaceHolder = RemoveHtml(Q44.Caption);

            // Q45
            Q45.EditValue = Q45.Options(false);
            Q45.PlaceHolder = RemoveHtml(Q45.Caption);

            // Q46
            Q46.EditValue = Q46.Options(false);
            Q46.PlaceHolder = RemoveHtml(Q46.Caption);

            // Q47
            Q47.EditValue = Q47.Options(false);
            Q47.PlaceHolder = RemoveHtml(Q47.Caption);

            // Q48
            Q48.EditValue = Q48.Options(false);
            Q48.PlaceHolder = RemoveHtml(Q48.Caption);

            // Q49
            Q49.EditValue = Q49.Options(false);
            Q49.PlaceHolder = RemoveHtml(Q49.Caption);

            // Q50
            Q50.EditValue = Q50.Options(false);
            Q50.PlaceHolder = RemoveHtml(Q50.Caption);

            // Section_8
            Section_8.SetupEditAttributes();
            Section_8.EditValue = ConvertToString(Section_8.CurrentValue); // DN
            Section_8.ViewCustomAttributes = "";

            // Q51
            Q51.EditValue = Q51.Options(false);
            Q51.PlaceHolder = RemoveHtml(Q51.Caption);

            // Q52
            Q52.EditValue = Q52.Options(false);
            Q52.PlaceHolder = RemoveHtml(Q52.Caption);

            // Q53
            Q53.EditValue = Q53.Options(false);
            Q53.PlaceHolder = RemoveHtml(Q53.Caption);

            // Q54
            Q54.EditValue = Q54.Options(false);
            Q54.PlaceHolder = RemoveHtml(Q54.Caption);

            // Q55
            Q55.EditValue = Q55.Options(false);
            Q55.PlaceHolder = RemoveHtml(Q55.Caption);

            // Section_9
            Section_9.SetupEditAttributes();
            Section_9.EditValue = ConvertToString(Section_9.CurrentValue); // DN
            Section_9.ViewCustomAttributes = "";

            // Q56
            Q56.EditValue = Q56.Options(false);
            Q56.PlaceHolder = RemoveHtml(Q56.Caption);

            // Q57
            Q57.EditValue = Q57.Options(false);
            Q57.PlaceHolder = RemoveHtml(Q57.Caption);

            // Q58
            Q58.EditValue = Q58.Options(false);
            Q58.PlaceHolder = RemoveHtml(Q58.Caption);

            // Q59
            Q59.EditValue = Q59.Options(false);
            Q59.PlaceHolder = RemoveHtml(Q59.Caption);

            // Q60
            Q60.EditValue = Q60.Options(false);
            Q60.PlaceHolder = RemoveHtml(Q60.Caption);

            // Section_10
            Section_10.SetupEditAttributes();
            Section_10.EditValue = ConvertToString(Section_10.CurrentValue); // DN
            Section_10.ViewCustomAttributes = "";

            // Q61
            Q61.EditValue = Q61.Options(false);
            Q61.PlaceHolder = RemoveHtml(Q61.Caption);

            // Q62
            Q62.EditValue = Q62.Options(false);
            Q62.PlaceHolder = RemoveHtml(Q62.Caption);

            // Q63
            Q63.EditValue = Q63.Options(false);
            Q63.PlaceHolder = RemoveHtml(Q63.Caption);

            // Q64
            Q64.EditValue = Q64.Options(false);
            Q64.PlaceHolder = RemoveHtml(Q64.Caption);

            // Q65
            Q65.EditValue = Q65.Options(false);
            Q65.PlaceHolder = RemoveHtml(Q65.Caption);

            // Q66
            Q66.EditValue = Q66.Options(false);
            Q66.PlaceHolder = RemoveHtml(Q66.Caption);

            // Section_11
            Section_11.SetupEditAttributes();
            Section_11.EditValue = ConvertToString(Section_11.CurrentValue); // DN
            Section_11.ViewCustomAttributes = "";

            // Q67
            Q67.EditValue = Q67.Options(false);
            Q67.PlaceHolder = RemoveHtml(Q67.Caption);

            // Q68
            Q68.EditValue = Q68.Options(false);
            Q68.PlaceHolder = RemoveHtml(Q68.Caption);

            // Q69
            Q69.EditValue = Q69.Options(false);
            Q69.PlaceHolder = RemoveHtml(Q69.Caption);

            // Q70
            Q70.EditValue = Q70.Options(false);
            Q70.PlaceHolder = RemoveHtml(Q70.Caption);

            // Notes_3
            Notes_3.SetupEditAttributes();
            Notes_3.EditValue = Notes_3.CurrentValue; // DN
            Notes_3.PlaceHolder = RemoveHtml(Notes_3.Caption);

            // Student_Signature
            Student_Signature.SetupEditAttributes();

            // Examiner_Signature
            Examiner_Signature.SetupEditAttributes();

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

            // Retake
            Retake.EditValue = Retake.Options(false);
            Retake.PlaceHolder = RemoveHtml(Retake.Caption);

            // AbsherApptNbr
            AbsherApptNbr.SetupEditAttributes();
            AbsherApptNbr.EditValue = ConvertToString(AbsherApptNbr.CurrentValue); // DN
            AbsherApptNbr.ViewCustomAttributes = "";

            // IsDrivingexperience
            IsDrivingexperience.SetupEditAttributes();
            if (ConvertToBool(IsDrivingexperience.CurrentValue)) {
                IsDrivingexperience.EditValue = IsDrivingexperience.TagCaption(1) != "" ? IsDrivingexperience.TagCaption(1) : "Yes";
            } else {
                IsDrivingexperience.EditValue = IsDrivingexperience.TagCaption(2) != "" ? IsDrivingexperience.TagCaption(2) : "No";
            }
            IsDrivingexperience.CellCssStyle += "text-align: center;";
            IsDrivingexperience.ViewCustomAttributes = "";

            // date_Birth_Hijri
            date_Birth_Hijri.SetupEditAttributes();
            date_Birth_Hijri.EditValue = ConvertToString(date_Birth_Hijri.CurrentValue); // DN
            date_Birth_Hijri.ViewCustomAttributes = "";

            // date_Birth
            date_Birth.SetupEditAttributes();
            date_Birth.EditValue = date_Birth.CurrentValue;
            date_Birth.EditValue = FormatDateTime(date_Birth.EditValue, date_Birth.FormatPattern);
            date_Birth.ViewCustomAttributes = "";

            // str_Email
            str_Email.SetupEditAttributes();
            str_Email.EditValue = ConvertToString(str_Email.CurrentValue); // DN
            str_Email.ViewCustomAttributes = "";

            // UserlevelID

            // Assigned_int_Package_Id
            Assigned_int_Package_Id.SetupEditAttributes();
            Assigned_int_Package_Id.EditValue = Assigned_int_Package_Id.CurrentValue; // DN
            Assigned_int_Package_Id.PlaceHolder = RemoveHtml(Assigned_int_Package_Id.Caption);
            if (!Empty(Assigned_int_Package_Id.EditValue) && IsNumeric(Assigned_int_Package_Id.EditValue))
                Assigned_int_Package_Id.EditValue = FormatNumber(Assigned_int_Package_Id.EditValue, null);

            // Scores_S1
            Scores_S1.SetupEditAttributes();
            if (!Scores_S1.Raw)
                Scores_S1.CurrentValue = HtmlDecode(Scores_S1.CurrentValue);
            Scores_S1.EditValue = HtmlEncode(Scores_S1.CurrentValue);
            Scores_S1.PlaceHolder = RemoveHtml(Scores_S1.Caption);

            // S1
            S1.EditValue = S1.Options(false);
            S1.PlaceHolder = RemoveHtml(S1.Caption);

            // S2
            S2.EditValue = S2.Options(false);
            S2.PlaceHolder = RemoveHtml(S2.Caption);

            // S3
            S3.EditValue = S3.Options(false);
            S3.PlaceHolder = RemoveHtml(S3.Caption);

            // S4
            S4.EditValue = S4.Options(false);
            S4.PlaceHolder = RemoveHtml(S4.Caption);

            // S5
            S5.EditValue = S5.Options(false);
            S5.PlaceHolder = RemoveHtml(S5.Caption);

            // Scores_S2
            Scores_S2.SetupEditAttributes();
            if (!Scores_S2.Raw)
                Scores_S2.CurrentValue = HtmlDecode(Scores_S2.CurrentValue);
            Scores_S2.EditValue = HtmlEncode(Scores_S2.CurrentValue);
            Scores_S2.PlaceHolder = RemoveHtml(Scores_S2.Caption);

            // S6
            S6.EditValue = S6.Options(false);
            S6.PlaceHolder = RemoveHtml(S6.Caption);

            // S7
            S7.EditValue = S7.Options(false);
            S7.PlaceHolder = RemoveHtml(S7.Caption);

            // S8
            S8.EditValue = S8.Options(false);
            S8.PlaceHolder = RemoveHtml(S8.Caption);

            // S9
            S9.EditValue = S9.Options(false);
            S9.PlaceHolder = RemoveHtml(S9.Caption);

            // S10
            S10.EditValue = S10.Options(false);
            S10.PlaceHolder = RemoveHtml(S10.Caption);

            // S11
            S11.EditValue = S11.Options(false);
            S11.PlaceHolder = RemoveHtml(S11.Caption);

            // S12
            S12.EditValue = S12.Options(false);
            S12.PlaceHolder = RemoveHtml(S12.Caption);

            // S13
            S13.EditValue = S13.Options(false);
            S13.PlaceHolder = RemoveHtml(S13.Caption);

            // S14
            S14.EditValue = S14.Options(false);
            S14.PlaceHolder = RemoveHtml(S14.Caption);

            // S15
            S15.EditValue = S15.Options(false);
            S15.PlaceHolder = RemoveHtml(S15.Caption);

            // Scores_S3
            Scores_S3.SetupEditAttributes();
            if (!Scores_S3.Raw)
                Scores_S3.CurrentValue = HtmlDecode(Scores_S3.CurrentValue);
            Scores_S3.EditValue = HtmlEncode(Scores_S3.CurrentValue);
            Scores_S3.PlaceHolder = RemoveHtml(Scores_S3.Caption);

            // S16
            S16.EditValue = S16.Options(false);
            S16.PlaceHolder = RemoveHtml(S16.Caption);

            // S17
            S17.EditValue = S17.Options(false);
            S17.PlaceHolder = RemoveHtml(S17.Caption);

            // S18
            S18.EditValue = S18.Options(false);
            S18.PlaceHolder = RemoveHtml(S18.Caption);

            // S19
            S19.EditValue = S19.Options(false);
            S19.PlaceHolder = RemoveHtml(S19.Caption);

            // S20
            S20.EditValue = S20.Options(false);
            S20.PlaceHolder = RemoveHtml(S20.Caption);

            // S21
            S21.EditValue = S21.Options(false);
            S21.PlaceHolder = RemoveHtml(S21.Caption);

            // Scores_S4
            Scores_S4.SetupEditAttributes();
            if (!Scores_S4.Raw)
                Scores_S4.CurrentValue = HtmlDecode(Scores_S4.CurrentValue);
            Scores_S4.EditValue = HtmlEncode(Scores_S4.CurrentValue);
            Scores_S4.PlaceHolder = RemoveHtml(Scores_S4.Caption);

            // S22
            S22.EditValue = S22.Options(false);
            S22.PlaceHolder = RemoveHtml(S22.Caption);

            // S23
            S23.EditValue = S23.Options(false);
            S23.PlaceHolder = RemoveHtml(S23.Caption);

            // S24
            S24.EditValue = S24.Options(false);
            S24.PlaceHolder = RemoveHtml(S24.Caption);

            // S25
            S25.EditValue = S25.Options(false);
            S25.PlaceHolder = RemoveHtml(S25.Caption);

            // S26
            S26.EditValue = S26.Options(false);
            S26.PlaceHolder = RemoveHtml(S26.Caption);

            // Scores_S5
            Scores_S5.SetupEditAttributes();
            if (!Scores_S5.Raw)
                Scores_S5.CurrentValue = HtmlDecode(Scores_S5.CurrentValue);
            Scores_S5.EditValue = HtmlEncode(Scores_S5.CurrentValue);
            Scores_S5.PlaceHolder = RemoveHtml(Scores_S5.Caption);

            // S27
            S27.EditValue = S27.Options(false);
            S27.PlaceHolder = RemoveHtml(S27.Caption);

            // S28
            S28.EditValue = S28.Options(false);
            S28.PlaceHolder = RemoveHtml(S28.Caption);

            // S29
            S29.EditValue = S29.Options(false);
            S29.PlaceHolder = RemoveHtml(S29.Caption);

            // S30
            S30.EditValue = S30.Options(false);
            S30.PlaceHolder = RemoveHtml(S30.Caption);

            // S31
            S31.EditValue = S31.Options(false);
            S31.PlaceHolder = RemoveHtml(S31.Caption);

            // S32
            S32.EditValue = S32.Options(false);
            S32.PlaceHolder = RemoveHtml(S32.Caption);

            // S33
            S33.EditValue = S33.Options(false);
            S33.PlaceHolder = RemoveHtml(S33.Caption);

            // S34
            S34.EditValue = S34.Options(false);
            S34.PlaceHolder = RemoveHtml(S34.Caption);

            // S35
            S35.EditValue = S35.Options(false);
            S35.PlaceHolder = RemoveHtml(S35.Caption);

            // Scores_S6
            Scores_S6.SetupEditAttributes();
            if (!Scores_S6.Raw)
                Scores_S6.CurrentValue = HtmlDecode(Scores_S6.CurrentValue);
            Scores_S6.EditValue = HtmlEncode(Scores_S6.CurrentValue);
            Scores_S6.PlaceHolder = RemoveHtml(Scores_S6.Caption);

            // S36
            S36.EditValue = S36.Options(false);
            S36.PlaceHolder = RemoveHtml(S36.Caption);

            // S37
            S37.EditValue = S37.Options(false);
            S37.PlaceHolder = RemoveHtml(S37.Caption);

            // S38
            S38.EditValue = S38.Options(false);
            S38.PlaceHolder = RemoveHtml(S38.Caption);

            // S39
            S39.EditValue = S39.Options(false);
            S39.PlaceHolder = RemoveHtml(S39.Caption);

            // S40
            S40.EditValue = S40.Options(false);
            S40.PlaceHolder = RemoveHtml(S40.Caption);

            // S41
            S41.EditValue = S41.Options(false);
            S41.PlaceHolder = RemoveHtml(S41.Caption);

            // S42
            S42.EditValue = S42.Options(false);
            S42.PlaceHolder = RemoveHtml(S42.Caption);

            // S43
            S43.EditValue = S43.Options(false);
            S43.PlaceHolder = RemoveHtml(S43.Caption);

            // Scores_S7
            Scores_S7.SetupEditAttributes();
            if (!Scores_S7.Raw)
                Scores_S7.CurrentValue = HtmlDecode(Scores_S7.CurrentValue);
            Scores_S7.EditValue = HtmlEncode(Scores_S7.CurrentValue);
            Scores_S7.PlaceHolder = RemoveHtml(Scores_S7.Caption);

            // S44
            S44.EditValue = S44.Options(false);
            S44.PlaceHolder = RemoveHtml(S44.Caption);

            // S45
            S45.EditValue = S45.Options(false);
            S45.PlaceHolder = RemoveHtml(S45.Caption);

            // S46
            S46.EditValue = S46.Options(false);
            S46.PlaceHolder = RemoveHtml(S46.Caption);

            // S47
            S47.EditValue = S47.Options(false);
            S47.PlaceHolder = RemoveHtml(S47.Caption);

            // S48
            S48.EditValue = S48.Options(false);
            S48.PlaceHolder = RemoveHtml(S48.Caption);

            // S49
            S49.EditValue = S49.Options(false);
            S49.PlaceHolder = RemoveHtml(S49.Caption);

            // S50
            S50.EditValue = S50.Options(false);
            S50.PlaceHolder = RemoveHtml(S50.Caption);

            // Scores_S8
            Scores_S8.SetupEditAttributes();
            if (!Scores_S8.Raw)
                Scores_S8.CurrentValue = HtmlDecode(Scores_S8.CurrentValue);
            Scores_S8.EditValue = HtmlEncode(Scores_S8.CurrentValue);
            Scores_S8.PlaceHolder = RemoveHtml(Scores_S8.Caption);

            // S51
            S51.EditValue = S51.Options(false);
            S51.PlaceHolder = RemoveHtml(S51.Caption);

            // S52
            S52.EditValue = S52.Options(false);
            S52.PlaceHolder = RemoveHtml(S52.Caption);

            // S53
            S53.EditValue = S53.Options(false);
            S53.PlaceHolder = RemoveHtml(S53.Caption);

            // S54
            S54.EditValue = S54.Options(false);
            S54.PlaceHolder = RemoveHtml(S54.Caption);

            // S55
            S55.EditValue = S55.Options(false);
            S55.PlaceHolder = RemoveHtml(S55.Caption);

            // Scores_S9
            Scores_S9.SetupEditAttributes();
            if (!Scores_S9.Raw)
                Scores_S9.CurrentValue = HtmlDecode(Scores_S9.CurrentValue);
            Scores_S9.EditValue = HtmlEncode(Scores_S9.CurrentValue);
            Scores_S9.PlaceHolder = RemoveHtml(Scores_S9.Caption);

            // S56
            S56.EditValue = S56.Options(false);
            S56.PlaceHolder = RemoveHtml(S56.Caption);

            // S57
            S57.EditValue = S57.Options(false);
            S57.PlaceHolder = RemoveHtml(S57.Caption);

            // S58
            S58.EditValue = S58.Options(false);
            S58.PlaceHolder = RemoveHtml(S58.Caption);

            // S59
            S59.EditValue = S59.Options(false);
            S59.PlaceHolder = RemoveHtml(S59.Caption);

            // Scores_S10
            Scores_S10.SetupEditAttributes();
            if (!Scores_S10.Raw)
                Scores_S10.CurrentValue = HtmlDecode(Scores_S10.CurrentValue);
            Scores_S10.EditValue = HtmlEncode(Scores_S10.CurrentValue);
            Scores_S10.PlaceHolder = RemoveHtml(Scores_S10.Caption);

            // S60
            S60.EditValue = S60.Options(false);
            S60.PlaceHolder = RemoveHtml(S60.Caption);

            // S61
            S61.EditValue = S61.Options(false);
            S61.PlaceHolder = RemoveHtml(S61.Caption);

            // S62
            S62.EditValue = S62.Options(false);
            S62.PlaceHolder = RemoveHtml(S62.Caption);

            // S63
            S63.EditValue = S63.Options(false);
            S63.PlaceHolder = RemoveHtml(S63.Caption);

            // S64
            S64.EditValue = S64.Options(false);
            S64.PlaceHolder = RemoveHtml(S64.Caption);

            // S65
            S65.EditValue = S65.Options(false);
            S65.PlaceHolder = RemoveHtml(S65.Caption);

            // Scores_S11
            Scores_S11.SetupEditAttributes();
            if (!Scores_S11.Raw)
                Scores_S11.CurrentValue = HtmlDecode(Scores_S11.CurrentValue);
            Scores_S11.EditValue = HtmlEncode(Scores_S11.CurrentValue);
            Scores_S11.PlaceHolder = RemoveHtml(Scores_S11.Caption);

            // S66
            S66.EditValue = S66.Options(false);
            S66.PlaceHolder = RemoveHtml(S66.Caption);

            // S67
            S67.EditValue = S67.Options(false);
            S67.PlaceHolder = RemoveHtml(S67.Caption);

            // S68
            S68.EditValue = S68.Options(false);
            S68.PlaceHolder = RemoveHtml(S68.Caption);

            // S69
            S69.EditValue = S69.Options(false);
            S69.PlaceHolder = RemoveHtml(S69.Caption);

            // S70
            S70.EditValue = S70.Options(false);
            S70.PlaceHolder = RemoveHtml(S70.Caption);

            // DriveTypelink
            DriveTypelink.SetupEditAttributes();
            DriveTypelink.EditValue = DriveTypelink.CurrentValue; // DN
            DriveTypelink.PlaceHolder = RemoveHtml(DriveTypelink.Caption);

            // Evaluation_Score
            Evaluation_Score.SetupEditAttributes();
            Evaluation_Score.EditValue = Evaluation_Score.CurrentValue; // DN
            Evaluation_Score.PlaceHolder = RemoveHtml(Evaluation_Score.Caption);
            if (!Empty(Evaluation_Score.EditValue) && IsNumeric(Evaluation_Score.EditValue))
                Evaluation_Score.EditValue = FormatNumber(Evaluation_Score.EditValue, null);

            // Immediate_Failure_Score
            Immediate_Failure_Score.SetupEditAttributes();
            Immediate_Failure_Score.EditValue = Immediate_Failure_Score.CurrentValue; // DN
            Immediate_Failure_Score.PlaceHolder = RemoveHtml(Immediate_Failure_Score.Caption);
            if (!Empty(Immediate_Failure_Score.EditValue) && IsNumeric(Immediate_Failure_Score.EditValue))
                Immediate_Failure_Score.EditValue = FormatNumber(Immediate_Failure_Score.EditValue, null);

            // Required_Program
            Required_Program.SetupEditAttributes();
            if (!Required_Program.Raw)
                Required_Program.CurrentValue = HtmlDecode(Required_Program.CurrentValue);
            Required_Program.EditValue = HtmlEncode(Required_Program.CurrentValue);
            Required_Program.PlaceHolder = RemoveHtml(Required_Program.Caption);

            // Price
            Price.SetupEditAttributes();
            Price.EditValue = Price.CurrentValue; // DN
            Price.PlaceHolder = RemoveHtml(Price.Caption);
            if (!Empty(Price.EditValue) && IsNumeric(Price.EditValue))
                Price.EditValue = FormatNumber(Price.EditValue, null);

            // intEvaluationType
            intEvaluationType.SetupEditAttributes();
            intEvaluationType.EditValue = intEvaluationType.CurrentValue; // DN
            intEvaluationType.PlaceHolder = RemoveHtml(intEvaluationType.Caption);
            if (!Empty(intEvaluationType.EditValue) && IsNumeric(intEvaluationType.EditValue))
                intEvaluationType.EditValue = FormatNumber(intEvaluationType.EditValue, null);

            // Institution
            Institution.SetupEditAttributes();
            if (!Institution.Raw)
                Institution.CurrentValue = HtmlDecode(Institution.CurrentValue);
            Institution.EditValue = HtmlEncode(Institution.CurrentValue);
            Institution.PlaceHolder = RemoveHtml(Institution.Caption);

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
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(intDrivinglicenseType);
                        doc.ExportCaption(Date_Entered);
                        doc.ExportCaption(Examination_Number);
                        doc.ExportCaption(Student_Signature);
                        doc.ExportCaption(Examiner_Signature);
                        doc.ExportCaption(AbsherApptNbr);
                        doc.ExportCaption(Scores_S1);
                        doc.ExportCaption(S1);
                        doc.ExportCaption(S2);
                        doc.ExportCaption(S3);
                        doc.ExportCaption(S4);
                        doc.ExportCaption(S5);
                        doc.ExportCaption(Scores_S2);
                        doc.ExportCaption(S6);
                        doc.ExportCaption(S7);
                        doc.ExportCaption(S8);
                        doc.ExportCaption(S9);
                        doc.ExportCaption(S10);
                        doc.ExportCaption(S11);
                        doc.ExportCaption(S12);
                        doc.ExportCaption(S13);
                        doc.ExportCaption(S14);
                        doc.ExportCaption(S15);
                        doc.ExportCaption(Scores_S3);
                        doc.ExportCaption(S16);
                        doc.ExportCaption(S17);
                        doc.ExportCaption(S18);
                        doc.ExportCaption(S19);
                        doc.ExportCaption(S20);
                        doc.ExportCaption(S21);
                        doc.ExportCaption(Scores_S4);
                        doc.ExportCaption(S22);
                        doc.ExportCaption(S23);
                        doc.ExportCaption(S24);
                        doc.ExportCaption(S25);
                        doc.ExportCaption(S26);
                        doc.ExportCaption(Scores_S5);
                        doc.ExportCaption(S27);
                        doc.ExportCaption(S28);
                        doc.ExportCaption(S29);
                        doc.ExportCaption(S30);
                        doc.ExportCaption(S31);
                        doc.ExportCaption(S32);
                        doc.ExportCaption(S33);
                        doc.ExportCaption(S34);
                        doc.ExportCaption(S35);
                        doc.ExportCaption(Scores_S6);
                        doc.ExportCaption(S36);
                        doc.ExportCaption(S37);
                        doc.ExportCaption(S38);
                        doc.ExportCaption(S39);
                        doc.ExportCaption(S40);
                        doc.ExportCaption(S41);
                        doc.ExportCaption(S42);
                        doc.ExportCaption(S43);
                        doc.ExportCaption(Scores_S7);
                        doc.ExportCaption(S44);
                        doc.ExportCaption(S45);
                        doc.ExportCaption(S46);
                        doc.ExportCaption(S47);
                        doc.ExportCaption(S48);
                        doc.ExportCaption(S49);
                        doc.ExportCaption(S50);
                        doc.ExportCaption(Scores_S8);
                        doc.ExportCaption(S51);
                        doc.ExportCaption(S52);
                        doc.ExportCaption(S53);
                        doc.ExportCaption(S54);
                        doc.ExportCaption(S55);
                        doc.ExportCaption(Scores_S9);
                        doc.ExportCaption(S56);
                        doc.ExportCaption(S57);
                        doc.ExportCaption(S58);
                        doc.ExportCaption(S59);
                        doc.ExportCaption(Scores_S10);
                        doc.ExportCaption(S60);
                        doc.ExportCaption(S61);
                        doc.ExportCaption(S62);
                        doc.ExportCaption(S63);
                        doc.ExportCaption(S64);
                        doc.ExportCaption(S65);
                        doc.ExportCaption(Scores_S11);
                        doc.ExportCaption(S66);
                        doc.ExportCaption(S67);
                        doc.ExportCaption(S68);
                        doc.ExportCaption(S69);
                        doc.ExportCaption(S70);
                        doc.ExportCaption(Evaluation_Score);
                        doc.ExportCaption(Immediate_Failure_Score);
                        doc.ExportCaption(Required_Program);
                        doc.ExportCaption(Price);
                        doc.ExportCaption(intEvaluationType);
                    } else {
                        doc.ExportCaption(Eval_ID);
                        doc.ExportCaption(AssessmentID);
                        doc.ExportCaption(str_Full_Name_Hdr);
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(str_Cell_Phone);
                        doc.ExportCaption(int_Student_ID);
                        doc.ExportCaption(intDrivinglicenseType);
                        doc.ExportCaption(Date_Entered);
                        doc.ExportCaption(Examination_Number);
                        doc.ExportCaption(Section_1);
                        doc.ExportCaption(Q1);
                        doc.ExportCaption(Q2);
                        doc.ExportCaption(Q3);
                        doc.ExportCaption(Q4);
                        doc.ExportCaption(Q5);
                        doc.ExportCaption(Section_2);
                        doc.ExportCaption(Q6);
                        doc.ExportCaption(Q7);
                        doc.ExportCaption(Q8);
                        doc.ExportCaption(Q9);
                        doc.ExportCaption(Q10);
                        doc.ExportCaption(Q11);
                        doc.ExportCaption(Q12);
                        doc.ExportCaption(Q13);
                        doc.ExportCaption(Q14);
                        doc.ExportCaption(Q15);
                        doc.ExportCaption(Section_3);
                        doc.ExportCaption(Q16);
                        doc.ExportCaption(Q17);
                        doc.ExportCaption(Q18);
                        doc.ExportCaption(Q19);
                        doc.ExportCaption(Q20);
                        doc.ExportCaption(Q21);
                        doc.ExportCaption(Section_4);
                        doc.ExportCaption(Q22);
                        doc.ExportCaption(Q23);
                        doc.ExportCaption(Q24);
                        doc.ExportCaption(Q25);
                        doc.ExportCaption(Q26);
                        doc.ExportCaption(Section_5);
                        doc.ExportCaption(Q27);
                        doc.ExportCaption(Q28);
                        doc.ExportCaption(Q29);
                        doc.ExportCaption(Q30);
                        doc.ExportCaption(Q31);
                        doc.ExportCaption(Q32);
                        doc.ExportCaption(Q33);
                        doc.ExportCaption(Q34);
                        doc.ExportCaption(Q35);
                        doc.ExportCaption(Section_6);
                        doc.ExportCaption(Q36);
                        doc.ExportCaption(Q37);
                        doc.ExportCaption(Q38);
                        doc.ExportCaption(Q39);
                        doc.ExportCaption(Q40);
                        doc.ExportCaption(Q41);
                        doc.ExportCaption(Q42);
                        doc.ExportCaption(Q43);
                        doc.ExportCaption(Section_7);
                        doc.ExportCaption(Q44);
                        doc.ExportCaption(Q45);
                        doc.ExportCaption(Q46);
                        doc.ExportCaption(Q47);
                        doc.ExportCaption(Q48);
                        doc.ExportCaption(Q49);
                        doc.ExportCaption(Q50);
                        doc.ExportCaption(Section_8);
                        doc.ExportCaption(Q51);
                        doc.ExportCaption(Q52);
                        doc.ExportCaption(Q53);
                        doc.ExportCaption(Q54);
                        doc.ExportCaption(Q55);
                        doc.ExportCaption(Section_9);
                        doc.ExportCaption(Q56);
                        doc.ExportCaption(Q57);
                        doc.ExportCaption(Q58);
                        doc.ExportCaption(Q59);
                        doc.ExportCaption(Q60);
                        doc.ExportCaption(Section_10);
                        doc.ExportCaption(Q61);
                        doc.ExportCaption(Q62);
                        doc.ExportCaption(Q63);
                        doc.ExportCaption(Q64);
                        doc.ExportCaption(Q65);
                        doc.ExportCaption(Q66);
                        doc.ExportCaption(Section_11);
                        doc.ExportCaption(Q67);
                        doc.ExportCaption(Q68);
                        doc.ExportCaption(Q69);
                        doc.ExportCaption(Q70);
                        doc.ExportCaption(Retake);
                        doc.ExportCaption(AbsherApptNbr);
                        doc.ExportCaption(IsDrivingexperience);
                        doc.ExportCaption(date_Birth_Hijri);
                        doc.ExportCaption(date_Birth);
                        doc.ExportCaption(str_Email);
                        doc.ExportCaption(UserlevelID);
                        doc.ExportCaption(Scores_S1);
                        doc.ExportCaption(S1);
                        doc.ExportCaption(S2);
                        doc.ExportCaption(S3);
                        doc.ExportCaption(S4);
                        doc.ExportCaption(S5);
                        doc.ExportCaption(Scores_S2);
                        doc.ExportCaption(S6);
                        doc.ExportCaption(S7);
                        doc.ExportCaption(S8);
                        doc.ExportCaption(S9);
                        doc.ExportCaption(S10);
                        doc.ExportCaption(S11);
                        doc.ExportCaption(S12);
                        doc.ExportCaption(S13);
                        doc.ExportCaption(S14);
                        doc.ExportCaption(S15);
                        doc.ExportCaption(Scores_S3);
                        doc.ExportCaption(S16);
                        doc.ExportCaption(S17);
                        doc.ExportCaption(S18);
                        doc.ExportCaption(S19);
                        doc.ExportCaption(S20);
                        doc.ExportCaption(S21);
                        doc.ExportCaption(Scores_S4);
                        doc.ExportCaption(S22);
                        doc.ExportCaption(S23);
                        doc.ExportCaption(S24);
                        doc.ExportCaption(S25);
                        doc.ExportCaption(S26);
                        doc.ExportCaption(Scores_S5);
                        doc.ExportCaption(S27);
                        doc.ExportCaption(S28);
                        doc.ExportCaption(S29);
                        doc.ExportCaption(S30);
                        doc.ExportCaption(S31);
                        doc.ExportCaption(S32);
                        doc.ExportCaption(S33);
                        doc.ExportCaption(S34);
                        doc.ExportCaption(S35);
                        doc.ExportCaption(Scores_S6);
                        doc.ExportCaption(S36);
                        doc.ExportCaption(S37);
                        doc.ExportCaption(S38);
                        doc.ExportCaption(S39);
                        doc.ExportCaption(S40);
                        doc.ExportCaption(S41);
                        doc.ExportCaption(S42);
                        doc.ExportCaption(S43);
                        doc.ExportCaption(Scores_S7);
                        doc.ExportCaption(S44);
                        doc.ExportCaption(S45);
                        doc.ExportCaption(S46);
                        doc.ExportCaption(S47);
                        doc.ExportCaption(S48);
                        doc.ExportCaption(S49);
                        doc.ExportCaption(S50);
                        doc.ExportCaption(Scores_S8);
                        doc.ExportCaption(S51);
                        doc.ExportCaption(S52);
                        doc.ExportCaption(S53);
                        doc.ExportCaption(S54);
                        doc.ExportCaption(S55);
                        doc.ExportCaption(Scores_S9);
                        doc.ExportCaption(S56);
                        doc.ExportCaption(S57);
                        doc.ExportCaption(S58);
                        doc.ExportCaption(S59);
                        doc.ExportCaption(Scores_S10);
                        doc.ExportCaption(S60);
                        doc.ExportCaption(S61);
                        doc.ExportCaption(S62);
                        doc.ExportCaption(S63);
                        doc.ExportCaption(S64);
                        doc.ExportCaption(S65);
                        doc.ExportCaption(Scores_S11);
                        doc.ExportCaption(S66);
                        doc.ExportCaption(S67);
                        doc.ExportCaption(S68);
                        doc.ExportCaption(S69);
                        doc.ExportCaption(S70);
                        doc.ExportCaption(Evaluation_Score);
                        doc.ExportCaption(Immediate_Failure_Score);
                        doc.ExportCaption(Required_Program);
                        doc.ExportCaption(Price);
                        doc.ExportCaption(intEvaluationType);
                        doc.ExportCaption(Institution);
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
                            await doc.ExportField(NationalID);
                            await doc.ExportField(intDrivinglicenseType);
                            await doc.ExportField(Date_Entered);
                            await doc.ExportField(Examination_Number);
                            await doc.ExportField(Student_Signature);
                            await doc.ExportField(Examiner_Signature);
                            await doc.ExportField(AbsherApptNbr);
                            await doc.ExportField(Scores_S1);
                            await doc.ExportField(S1);
                            await doc.ExportField(S2);
                            await doc.ExportField(S3);
                            await doc.ExportField(S4);
                            await doc.ExportField(S5);
                            await doc.ExportField(Scores_S2);
                            await doc.ExportField(S6);
                            await doc.ExportField(S7);
                            await doc.ExportField(S8);
                            await doc.ExportField(S9);
                            await doc.ExportField(S10);
                            await doc.ExportField(S11);
                            await doc.ExportField(S12);
                            await doc.ExportField(S13);
                            await doc.ExportField(S14);
                            await doc.ExportField(S15);
                            await doc.ExportField(Scores_S3);
                            await doc.ExportField(S16);
                            await doc.ExportField(S17);
                            await doc.ExportField(S18);
                            await doc.ExportField(S19);
                            await doc.ExportField(S20);
                            await doc.ExportField(S21);
                            await doc.ExportField(Scores_S4);
                            await doc.ExportField(S22);
                            await doc.ExportField(S23);
                            await doc.ExportField(S24);
                            await doc.ExportField(S25);
                            await doc.ExportField(S26);
                            await doc.ExportField(Scores_S5);
                            await doc.ExportField(S27);
                            await doc.ExportField(S28);
                            await doc.ExportField(S29);
                            await doc.ExportField(S30);
                            await doc.ExportField(S31);
                            await doc.ExportField(S32);
                            await doc.ExportField(S33);
                            await doc.ExportField(S34);
                            await doc.ExportField(S35);
                            await doc.ExportField(Scores_S6);
                            await doc.ExportField(S36);
                            await doc.ExportField(S37);
                            await doc.ExportField(S38);
                            await doc.ExportField(S39);
                            await doc.ExportField(S40);
                            await doc.ExportField(S41);
                            await doc.ExportField(S42);
                            await doc.ExportField(S43);
                            await doc.ExportField(Scores_S7);
                            await doc.ExportField(S44);
                            await doc.ExportField(S45);
                            await doc.ExportField(S46);
                            await doc.ExportField(S47);
                            await doc.ExportField(S48);
                            await doc.ExportField(S49);
                            await doc.ExportField(S50);
                            await doc.ExportField(Scores_S8);
                            await doc.ExportField(S51);
                            await doc.ExportField(S52);
                            await doc.ExportField(S53);
                            await doc.ExportField(S54);
                            await doc.ExportField(S55);
                            await doc.ExportField(Scores_S9);
                            await doc.ExportField(S56);
                            await doc.ExportField(S57);
                            await doc.ExportField(S58);
                            await doc.ExportField(S59);
                            await doc.ExportField(Scores_S10);
                            await doc.ExportField(S60);
                            await doc.ExportField(S61);
                            await doc.ExportField(S62);
                            await doc.ExportField(S63);
                            await doc.ExportField(S64);
                            await doc.ExportField(S65);
                            await doc.ExportField(Scores_S11);
                            await doc.ExportField(S66);
                            await doc.ExportField(S67);
                            await doc.ExportField(S68);
                            await doc.ExportField(S69);
                            await doc.ExportField(S70);
                            await doc.ExportField(Evaluation_Score);
                            await doc.ExportField(Immediate_Failure_Score);
                            await doc.ExportField(Required_Program);
                            await doc.ExportField(Price);
                            await doc.ExportField(intEvaluationType);
                        } else {
                            await doc.ExportField(Eval_ID);
                            await doc.ExportField(AssessmentID);
                            await doc.ExportField(str_Full_Name_Hdr);
                            await doc.ExportField(NationalID);
                            await doc.ExportField(str_Cell_Phone);
                            await doc.ExportField(int_Student_ID);
                            await doc.ExportField(intDrivinglicenseType);
                            await doc.ExportField(Date_Entered);
                            await doc.ExportField(Examination_Number);
                            await doc.ExportField(Section_1);
                            await doc.ExportField(Q1);
                            await doc.ExportField(Q2);
                            await doc.ExportField(Q3);
                            await doc.ExportField(Q4);
                            await doc.ExportField(Q5);
                            await doc.ExportField(Section_2);
                            await doc.ExportField(Q6);
                            await doc.ExportField(Q7);
                            await doc.ExportField(Q8);
                            await doc.ExportField(Q9);
                            await doc.ExportField(Q10);
                            await doc.ExportField(Q11);
                            await doc.ExportField(Q12);
                            await doc.ExportField(Q13);
                            await doc.ExportField(Q14);
                            await doc.ExportField(Q15);
                            await doc.ExportField(Section_3);
                            await doc.ExportField(Q16);
                            await doc.ExportField(Q17);
                            await doc.ExportField(Q18);
                            await doc.ExportField(Q19);
                            await doc.ExportField(Q20);
                            await doc.ExportField(Q21);
                            await doc.ExportField(Section_4);
                            await doc.ExportField(Q22);
                            await doc.ExportField(Q23);
                            await doc.ExportField(Q24);
                            await doc.ExportField(Q25);
                            await doc.ExportField(Q26);
                            await doc.ExportField(Section_5);
                            await doc.ExportField(Q27);
                            await doc.ExportField(Q28);
                            await doc.ExportField(Q29);
                            await doc.ExportField(Q30);
                            await doc.ExportField(Q31);
                            await doc.ExportField(Q32);
                            await doc.ExportField(Q33);
                            await doc.ExportField(Q34);
                            await doc.ExportField(Q35);
                            await doc.ExportField(Section_6);
                            await doc.ExportField(Q36);
                            await doc.ExportField(Q37);
                            await doc.ExportField(Q38);
                            await doc.ExportField(Q39);
                            await doc.ExportField(Q40);
                            await doc.ExportField(Q41);
                            await doc.ExportField(Q42);
                            await doc.ExportField(Q43);
                            await doc.ExportField(Section_7);
                            await doc.ExportField(Q44);
                            await doc.ExportField(Q45);
                            await doc.ExportField(Q46);
                            await doc.ExportField(Q47);
                            await doc.ExportField(Q48);
                            await doc.ExportField(Q49);
                            await doc.ExportField(Q50);
                            await doc.ExportField(Section_8);
                            await doc.ExportField(Q51);
                            await doc.ExportField(Q52);
                            await doc.ExportField(Q53);
                            await doc.ExportField(Q54);
                            await doc.ExportField(Q55);
                            await doc.ExportField(Section_9);
                            await doc.ExportField(Q56);
                            await doc.ExportField(Q57);
                            await doc.ExportField(Q58);
                            await doc.ExportField(Q59);
                            await doc.ExportField(Q60);
                            await doc.ExportField(Section_10);
                            await doc.ExportField(Q61);
                            await doc.ExportField(Q62);
                            await doc.ExportField(Q63);
                            await doc.ExportField(Q64);
                            await doc.ExportField(Q65);
                            await doc.ExportField(Q66);
                            await doc.ExportField(Section_11);
                            await doc.ExportField(Q67);
                            await doc.ExportField(Q68);
                            await doc.ExportField(Q69);
                            await doc.ExportField(Q70);
                            await doc.ExportField(Retake);
                            await doc.ExportField(AbsherApptNbr);
                            await doc.ExportField(IsDrivingexperience);
                            await doc.ExportField(date_Birth_Hijri);
                            await doc.ExportField(date_Birth);
                            await doc.ExportField(str_Email);
                            await doc.ExportField(UserlevelID);
                            await doc.ExportField(Scores_S1);
                            await doc.ExportField(S1);
                            await doc.ExportField(S2);
                            await doc.ExportField(S3);
                            await doc.ExportField(S4);
                            await doc.ExportField(S5);
                            await doc.ExportField(Scores_S2);
                            await doc.ExportField(S6);
                            await doc.ExportField(S7);
                            await doc.ExportField(S8);
                            await doc.ExportField(S9);
                            await doc.ExportField(S10);
                            await doc.ExportField(S11);
                            await doc.ExportField(S12);
                            await doc.ExportField(S13);
                            await doc.ExportField(S14);
                            await doc.ExportField(S15);
                            await doc.ExportField(Scores_S3);
                            await doc.ExportField(S16);
                            await doc.ExportField(S17);
                            await doc.ExportField(S18);
                            await doc.ExportField(S19);
                            await doc.ExportField(S20);
                            await doc.ExportField(S21);
                            await doc.ExportField(Scores_S4);
                            await doc.ExportField(S22);
                            await doc.ExportField(S23);
                            await doc.ExportField(S24);
                            await doc.ExportField(S25);
                            await doc.ExportField(S26);
                            await doc.ExportField(Scores_S5);
                            await doc.ExportField(S27);
                            await doc.ExportField(S28);
                            await doc.ExportField(S29);
                            await doc.ExportField(S30);
                            await doc.ExportField(S31);
                            await doc.ExportField(S32);
                            await doc.ExportField(S33);
                            await doc.ExportField(S34);
                            await doc.ExportField(S35);
                            await doc.ExportField(Scores_S6);
                            await doc.ExportField(S36);
                            await doc.ExportField(S37);
                            await doc.ExportField(S38);
                            await doc.ExportField(S39);
                            await doc.ExportField(S40);
                            await doc.ExportField(S41);
                            await doc.ExportField(S42);
                            await doc.ExportField(S43);
                            await doc.ExportField(Scores_S7);
                            await doc.ExportField(S44);
                            await doc.ExportField(S45);
                            await doc.ExportField(S46);
                            await doc.ExportField(S47);
                            await doc.ExportField(S48);
                            await doc.ExportField(S49);
                            await doc.ExportField(S50);
                            await doc.ExportField(Scores_S8);
                            await doc.ExportField(S51);
                            await doc.ExportField(S52);
                            await doc.ExportField(S53);
                            await doc.ExportField(S54);
                            await doc.ExportField(S55);
                            await doc.ExportField(Scores_S9);
                            await doc.ExportField(S56);
                            await doc.ExportField(S57);
                            await doc.ExportField(S58);
                            await doc.ExportField(S59);
                            await doc.ExportField(Scores_S10);
                            await doc.ExportField(S60);
                            await doc.ExportField(S61);
                            await doc.ExportField(S62);
                            await doc.ExportField(S63);
                            await doc.ExportField(S64);
                            await doc.ExportField(S65);
                            await doc.ExportField(Scores_S11);
                            await doc.ExportField(S66);
                            await doc.ExportField(S67);
                            await doc.ExportField(S68);
                            await doc.ExportField(S69);
                            await doc.ExportField(S70);
                            await doc.ExportField(Evaluation_Score);
                            await doc.ExportField(Immediate_Failure_Score);
                            await doc.ExportField(Required_Program);
                            await doc.ExportField(Price);
                            await doc.ExportField(intEvaluationType);
                            await doc.ExportField(Institution);
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
            string sql = "SELECT " + masterfld.Expression + " FROM dbo.tblEvaluation";
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
            if (currentMasterTable == "tblAssessment") {
                filterWrk = tblAssessment?.AddUserIDFilter(filterWrk);
            }
            return filterWrk ?? "";
        }

        // Add detail User ID filter
        public string AddDetailUserIDFilter(string filter, string currentMasterTable)
        {
            string filterWrk = filter;
            if (currentMasterTable == "tblAssessment") {
                if (tblAssessment != null && !tblAssessment.UserIDAllow())
                    AddFilter(ref filterWrk, tblAssessment.GetUserIDSubquery(AssessmentID, tblAssessment.AssessmentID));
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

            // No binary fields
            return JsonBoolResult.FalseResult; // Incorrect key
        }
        #pragma warning restore 1998

        // Write audit trail start/end for grid update
        public async Task WriteAuditTrailLog(string log) => await WriteAuditTrailAsync(CurrentUser(), log, "tblEvaluation");

        // Write audit trail (add page)
        public async Task WriteAuditTrailOnAdd(IDictionary<string, object> rs)
        {
            if (!AuditTrailOnAdd)
                return;
            string table = "tblEvaluation";

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
            string table = "tblEvaluation";

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
            string table = "tblEvaluation";

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
         //Update Potential Student Evaluation Scores
        string sUpdateSq21 = "UPD_STUDENTS_EVAL_PV_SCORE";
        Execute (sUpdateSq21);  
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
