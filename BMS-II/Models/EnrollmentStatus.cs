namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// enrollmentStatus
    /// </summary>
    [MaybeNull]
    public static EnrollmentStatus enrollmentStatus
    {
        get => HttpData.Resolve<EnrollmentStatus>("Enrollment_Status");
        set => HttpData["Enrollment_Status"] = value;
    }

    /// <summary>
    /// Table class for Enrollment Status
    /// </summary>
    public class EnrollmentStatus : ReportTable, IQueryFactory
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

        public readonly ReportField<SqlDbType> int_Enrollement_Id;

        public readonly ReportField<SqlDbType> str_Username;

        public readonly ReportField<SqlDbType> NationalID;

        public readonly ReportField<SqlDbType> str_Full_Name;

        public readonly ReportField<SqlDbType> int_CR_ID;

        public readonly ReportField<SqlDbType> int_Student_Id;

        public readonly ReportField<SqlDbType> int_BTW_Id;

        public readonly ReportField<SqlDbType> int_Item_Id;

        public readonly ReportField<SqlDbType> int_Package_Id;

        public readonly ReportField<SqlDbType> int_PackageCR_Id;

        public readonly ReportField<SqlDbType> date_Created;

        public readonly ReportField<SqlDbType> date_Modified;

        public readonly ReportField<SqlDbType> int_Created_By;

        public readonly ReportField<SqlDbType> int_Modified_By;

        public readonly ReportField<SqlDbType> str_PurchaseAmount;

        public readonly ReportField<SqlDbType> int_ApptId;

        public readonly ReportField<SqlDbType> str_Notes;

        public readonly ReportField<SqlDbType> int_SoldBy;

        public readonly ReportField<SqlDbType> int_Bill_ID;

        public readonly ReportField<SqlDbType> str_Amount_Pay;

        public readonly ReportField<SqlDbType> int_ApptCldr_ID;

        public readonly ReportField<SqlDbType> str_Package_Name;

        public readonly ReportField<SqlDbType> course;

        public readonly ReportField<SqlDbType> institution;

        public readonly ReportField<SqlDbType> UniqueIdx;

        // Constructor
        public EnrollmentStatus()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "Enrollment_Status";
            Name = "Enrollment Status";
            Type = "REPORT";
            ReportSourceTable = "tblStudentEnrollment"; // Report source table
            ReportSourceTableName = "tblStudentEnrollment"; // Report source table name
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

            // int_Enrollement_Id
            int_Enrollement_Id = new (this, "x_int_Enrollement_Id", 3, SqlDbType.Int) {
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
                HtmlTag = "NO",
                InputTextType = "text",
                IsAutoIncrement = true, // Autoincrement field
                IsPrimaryKey = true, // Primary key field
                Nullable = false, // NOT NULL field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "int_Enrollement_Id", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("int_Enrollement_Id", int_Enrollement_Id);

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
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                GroupingFieldId = 1,
                ShowGroupHeaderAsRow = false,
                ShowCompactSummaryFooter = true,
                GroupByType = "",
                GroupInterval = "0",
                GroupSql = "",
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "str_Username", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            str_Username.GetAutoUpdateValue = () => CurrentUserName();
            Fields.Add("str_Username", str_Username);

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
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "NationalID", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("NationalID", NationalID);

            // str_Full_Name
            str_Full_Name = new (this, "x_str_Full_Name", 202, SqlDbType.NVarChar) {
                Name = "str_Full_Name",
                Expression = "[str_Full_Name]",
                BasicSearchExpression = "[str_Full_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Full_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "str_Full_Name", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("str_Full_Name", str_Full_Name);

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
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "int_CR_ID", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("int_CR_ID", int_CR_ID);

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
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "int_Student_Id", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("int_Student_Id", int_Student_Id);

            // int_BTW_Id
            int_BTW_Id = new (this, "x_int_BTW_Id", 3, SqlDbType.Int) {
                Name = "int_BTW_Id",
                Expression = "[int_BTW_Id]",
                BasicSearchExpression = "CAST([int_BTW_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_BTW_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "int_BTW_Id", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("int_BTW_Id", int_BTW_Id);

            // int_Item_Id
            int_Item_Id = new (this, "x_int_Item_Id", 3, SqlDbType.Int) {
                Name = "int_Item_Id",
                Expression = "[int_Item_Id]",
                BasicSearchExpression = "CAST([int_Item_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Item_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "int_Item_Id", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("int_Item_Id", int_Item_Id);

            // int_Package_Id
            int_Package_Id = new (this, "x_int_Package_Id", 3, SqlDbType.Int) {
                Name = "int_Package_Id",
                Expression = "[int_Package_Id]",
                BasicSearchExpression = "CAST([int_Package_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Package_Id]",
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
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "int_Package_Id", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("int_Package_Id", int_Package_Id);

            // int_PackageCR_Id
            int_PackageCR_Id = new (this, "x_int_PackageCR_Id", 3, SqlDbType.Int) {
                Name = "int_PackageCR_Id",
                Expression = "[int_PackageCR_Id]",
                BasicSearchExpression = "CAST([int_PackageCR_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_PackageCR_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "int_PackageCR_Id", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("int_PackageCR_Id", int_PackageCR_Id);

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
                GroupingFieldId = 3,
                ShowGroupHeaderAsRow = false,
                ShowCompactSummaryFooter = true,
                GroupByType = "",
                GroupInterval = "0",
                GroupSql = "",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "date_Created", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
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
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "date_Modified", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("date_Modified", date_Modified);

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
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "int_Created_By", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
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
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "int_Modified_By", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("int_Modified_By", int_Modified_By);

            // str_PurchaseAmount
            str_PurchaseAmount = new (this, "x_str_PurchaseAmount", 131, SqlDbType.Decimal) {
                Name = "str_PurchaseAmount",
                Expression = "[str_PurchaseAmount]",
                BasicSearchExpression = "CAST([str_PurchaseAmount] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[str_PurchaseAmount]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "str_PurchaseAmount", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("str_PurchaseAmount", str_PurchaseAmount);

            // int_ApptId
            int_ApptId = new (this, "x_int_ApptId", 3, SqlDbType.Int) {
                Name = "int_ApptId",
                Expression = "[int_ApptId]",
                BasicSearchExpression = "CAST([int_ApptId] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_ApptId]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "int_ApptId", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("int_ApptId", int_ApptId);

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
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "str_Notes", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("str_Notes", str_Notes);

            // int_SoldBy
            int_SoldBy = new (this, "x_int_SoldBy", 3, SqlDbType.Int) {
                Name = "int_SoldBy",
                Expression = "[int_SoldBy]",
                BasicSearchExpression = "CAST([int_SoldBy] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_SoldBy]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "int_SoldBy", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("int_SoldBy", int_SoldBy);

            // int_Bill_ID
            int_Bill_ID = new (this, "x_int_Bill_ID", 3, SqlDbType.Int) {
                Name = "int_Bill_ID",
                Expression = "[int_Bill_ID]",
                BasicSearchExpression = "CAST([int_Bill_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Bill_ID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "int_Bill_ID", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("int_Bill_ID", int_Bill_ID);

            // str_Amount_Pay
            str_Amount_Pay = new (this, "x_str_Amount_Pay", 200, SqlDbType.VarChar) {
                Name = "str_Amount_Pay",
                Expression = "[str_Amount_Pay]",
                BasicSearchExpression = "[str_Amount_Pay]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Amount_Pay]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "str_Amount_Pay", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("str_Amount_Pay", str_Amount_Pay);

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
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "int_ApptCldr_ID", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("int_ApptCldr_ID", int_ApptCldr_ID);

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
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "str_Package_Name", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("str_Package_Name", str_Package_Name);

            // course
            course = new (this, "x_course", 200, SqlDbType.VarChar) {
                Name = "course",
                Expression = "[course]",
                UseBasicSearch = true,
                BasicSearchExpression = "[course]",
                DateTimeFormat = -1,
                VirtualExpression = "[course]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "course", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("course", course);

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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "institution", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("institution", institution);

            // UniqueIdx
            UniqueIdx = new (this, "x_UniqueIdx", 202, SqlDbType.NVarChar) {
                Name = "UniqueIdx",
                Expression = "[UniqueIdx]",
                UseBasicSearch = true,
                BasicSearchExpression = "[UniqueIdx]",
                DateTimeFormat = -1,
                VirtualExpression = "[UniqueIdx]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Enrollment_Status", "UniqueIdx", "CustomMsg"),
                SourceTableVar = "tblStudentEnrollment",
                IsUpload = false
            };
            Fields.Add("UniqueIdx", UniqueIdx);

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
            get => !Empty(_sqlSelectAggregate) ? _sqlSelectAggregate : "SELECT SUM([str_PurchaseAmount]) AS sum_str_purchaseamount FROM " + SqlFrom;
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
            get => _sqlFrom ?? "dbo.tblStudentEnrollment";
            set => _sqlFrom = value;
        }

        // SELECT
        private string? _sqlSelect = null;

        public string SqlSelect { // Select
            get {
                if (!Empty(_sqlSelect))
                    return _sqlSelect;
                string select = "*";
                if (!Empty(str_Username.GroupSql)) {
                    string expr = str_Username.GroupSql.Replace("%s", str_Username.Expression) + " AS " + QuotedName(str_Username.GroupName, DbId);
                    select += ", " + expr;
                }
                if (!Empty(int_Package_Id.GroupSql)) {
                    string expr = int_Package_Id.GroupSql.Replace("%s", int_Package_Id.Expression) + " AS " + QuotedName(int_Package_Id.GroupName, DbId);
                    select += ", " + expr;
                }
                if (!Empty(date_Created.GroupSql)) {
                    string expr = date_Created.GroupSql.Replace("%s", date_Created.Expression) + " AS " + QuotedName(date_Created.GroupName, DbId);
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
                AddFilter(ref where, ConvertToString(TableFilter));
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
        private string _sqlKeyFilter => "[int_Enrollement_Id] = @int_Enrollement_Id@";

        #pragma warning disable 168, 219
        // Get record filter as string
        public string GetRecordFilter(Dictionary<string, object>? row = null, bool current = false)
        {
            string keyFilter = _sqlKeyFilter;
            object? val = null, result = "";
            val = row?.TryGetValue("int_Enrollement_Id", out result) ?? false
                ? result
                : !Empty(int_Enrollement_Id.OldValue) && !current ? int_Enrollement_Id.OldValue : int_Enrollement_Id.CurrentValue;
            if (!IsNumeric(val))
                return "0=1"; // Invalid key
            if (val == null)
                return "0=1"; // Invalid key
            keyFilter = keyFilter.Replace("@int_Enrollement_Id@", AdjustSql(val, DbId)); // Replace key value
            return keyFilter;
        }

        // Get record filter as Dictionary // DN
        public Dictionary<string, object>? GetRowFilterAsDictionary(IDictionary<string, object>? row = null)
        {
            Dictionary<string, object>? keyFilter = new ();
            object? val = null, result;
            val = row?.TryGetValue("int_Enrollement_Id", out result) ?? false
                ? result
                : !Empty(int_Enrollement_Id.OldValue) ? int_Enrollement_Id.OldValue : int_Enrollement_Id.CurrentValue;
            if (!IsNumeric(val))
                return null; // Invalid key
            if (Empty(val))
                return null; // Invalid key
            keyFilter.Add("int_Enrollement_Id", val); // Add key value
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
                return "EnrollmentStatus";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return "EnrollmentStatus";
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
            json += "\"int_Enrollement_Id\":" + ConvertToJson(int_Enrollement_Id.CurrentValue, "number", true);
            json = "{" + json + "}";
            if (htmlEncode)
                json = HtmlEncode(json);
            return json;
        }

        // Add key value to URL
        public string KeyUrl(string url, string parm = "") { // DN
            if (!IsNull(int_Enrollement_Id.CurrentValue)) {
                url += "/" + int_Enrollement_Id.CurrentValue;
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
            val = current ? ConvertToString(int_Enrollement_Id.CurrentValue) ?? "" : ConvertToString(int_Enrollement_Id.OldValue) ?? "";
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
            val = row?.TryGetValue("int_Enrollement_Id", out result) ?? false ? ConvertToString(result) : null;
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
                    int_Enrollement_Id.CurrentValue = keys[0];
                } else {
                    int_Enrollement_Id.OldValue = keys[0];
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
                if (RouteValues.TryGetValue("int_Enrollement_Id", out object? v0)) { // int_Enrollement_Id // DN
                    key = UrlDecode(v0); // DN
                } else if (IsApi() && !Empty(keyValues)) {
                    key = keyValues[0];
                } else {
                    key = Param("int_Enrollement_Id");
                }
                keysList.Add(key);
            }
            // Check keys
            foreach (var keys in keysList) {
                if (!IsNumeric(keys)) // int_Enrollement_Id
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
            get => _tableFilter ?? "[course] not like 'en%'";
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
