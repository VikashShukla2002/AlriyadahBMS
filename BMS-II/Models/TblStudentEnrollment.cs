using AngleSharp.Common;

namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26
{
    /// <summary>
    /// tblStudentEnrollment
    /// </summary>
    [MaybeNull]
    public static TblStudentEnrollment tblStudentEnrollment
    {
        get => HttpData.Resolve<TblStudentEnrollment>("tblStudentEnrollment");
        set => HttpData["tblStudentEnrollment"] = value;
    }

    /// <summary>
    /// Table class for tblStudentEnrollment
    /// </summary>
    public class TblStudentEnrollment : DbTable, IQueryFactory
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

        public bool ModalSearch = true;

        public bool ModalView = false;

        public bool ModalAdd = false;

        public bool ModalEdit = false;

        public bool ModalUpdate = false;

        public bool InlineDelete = false;

        public bool ModalGridAdd = false;

        public bool ModalGridEdit = false;

        public bool ModalMultiEdit = false;

        public readonly DbField<SqlDbType> int_Enrollement_Id;

        public readonly DbField<SqlDbType> str_Full_Name;

        public readonly DbField<SqlDbType> str_Username;

        public readonly DbField<SqlDbType> NationalID;

        public readonly DbField<SqlDbType> int_CR_ID;

        public readonly DbField<SqlDbType> int_Student_Id;

        public readonly DbField<SqlDbType> int_BTW_Id;

        public readonly DbField<SqlDbType> int_Item_Id;

        public readonly DbField<SqlDbType> int_Package_Id;

        public readonly DbField<SqlDbType> str_Package_Name;

        public readonly DbField<SqlDbType> int_PackageCR_Id;

        public readonly DbField<SqlDbType> date_Created;

        public readonly DbField<SqlDbType> date_Modified;

        public readonly DbField<SqlDbType> int_Created_By;

        public readonly DbField<SqlDbType> int_Modified_By;

        public readonly DbField<SqlDbType> str_PurchaseAmount;

        public readonly DbField<SqlDbType> int_ApptId;

        public readonly DbField<SqlDbType> course;

        public readonly DbField<SqlDbType> institution;

        public readonly DbField<SqlDbType> str_Notes;

        public readonly DbField<SqlDbType> int_SoldBy;

        public readonly DbField<SqlDbType> int_Bill_ID;

        public readonly DbField<SqlDbType> str_Amount_Pay;

        public readonly DbField<SqlDbType> int_ApptCldr_ID;

        public readonly DbField<SqlDbType> UniqueIdx;

        // Constructor
        public TblStudentEnrollment()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "tblStudentEnrollment";
            Name = "tblStudentEnrollment";
            Type = "TABLE";
            UpdateTable = "dbo.tblStudentEnrollment"; // Update Table
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
                HtmlTag = "NO",
                InputTextType = "text",
                IsAutoIncrement = true, // Autoincrement field
                IsPrimaryKey = true, // Primary key field
                Nullable = false, // NOT NULL field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "int_Enrollement_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Enrollement_Id", int_Enrollement_Id);

            // str_Full_Name
            str_Full_Name = new(this, "x_str_Full_Name", 202, SqlDbType.NVarChar)
            {
                Name = "str_Full_Name",
                Expression = "[str_Full_Name]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Full_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Full_Name]",
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
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "str_Full_Name", "CustomMsg"),
                IsUpload = false
            };
            str_Full_Name.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(str_Full_Name, "tblStudents", false, "str_Full_Name", new List<string> { "str_Full_Name", "", "", "" }, "", "", new List<string> { }, new List<string> { "x_NationalID" }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "[str_Full_Name]"),
                "en-US" => new Lookup<DbField>(str_Full_Name, "tblStudents", false, "str_Full_Name", new List<string> { "str_Full_Name", "", "", "" }, "", "", new List<string> { }, new List<string> { "x_NationalID" }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "[str_Full_Name]"),
                _ => new Lookup<DbField>(str_Full_Name, "tblStudents", false, "str_Full_Name", new List<string> { "str_Full_Name", "", "", "" }, "", "", new List<string> { }, new List<string> { "x_NationalID" }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "[str_Full_Name]")
            };
            Fields.Add("str_Full_Name", str_Full_Name);

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
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "str_Username", "CustomMsg"),
                IsUpload = false
            };
            str_Username.GetAutoUpdateValue = () => CurrentUserName();
            Fields.Add("str_Username", str_Username);

            // NationalID
            NationalID = new(this, "x_NationalID", 20, SqlDbType.BigInt)
            {
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
                HtmlTag = "SELECT",
                InputTextType = "text",
                IsForeignKey = true, // Foreign key field
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "NationalID", "CustomMsg"),
                IsUpload = false
            };
            NationalID.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(NationalID, "tblStudents", false, "NationalID", new List<string> { "NationalID", "", "", "" }, "", "", new List<string> { "x_str_Full_Name" }, new List<string> { }, new List<string> { "str_Full_Name" }, new List<string> { "x_str_Full_Name" }, new List<string> { }, new List<string> { }, "", "", "CAST([NationalID] AS NVARCHAR)"),
                "en-US" => new Lookup<DbField>(NationalID, "tblStudents", false, "NationalID", new List<string> { "NationalID", "", "", "" }, "", "", new List<string> { "x_str_Full_Name" }, new List<string> { }, new List<string> { "str_Full_Name" }, new List<string> { "x_str_Full_Name" }, new List<string> { }, new List<string> { }, "", "", "CAST([NationalID] AS NVARCHAR)"),
                _ => new Lookup<DbField>(NationalID, "tblStudents", false, "NationalID", new List<string> { "NationalID", "", "", "" }, "", "", new List<string> { "x_str_Full_Name" }, new List<string> { }, new List<string> { "str_Full_Name" }, new List<string> { "x_str_Full_Name" }, new List<string> { }, new List<string> { }, "", "", "CAST([NationalID] AS NVARCHAR)")
            };
            Fields.Add("NationalID", NationalID);

            // int_CR_ID
            int_CR_ID = new(this, "x_int_CR_ID", 3, SqlDbType.Int)
            {
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
                HtmlTag = "SELECT",
                InputTextType = "text",
                Required = true, // Required field
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "int_CR_ID", "CustomMsg"),
                IsUpload = false
            };
            int_CR_ID.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(int_CR_ID, "qryClassRoomList", false, "int_CR_ID", new List<string> { "str_CR_Days", "", "str_CR_Days", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "CONCAT([str_CR_Days],'" + ValueSeparator(2, int_CR_ID) + "',[str_CR_Days])"),
                "en-US" => new Lookup<DbField>(int_CR_ID, "qryClassRoomList", false, "int_CR_ID", new List<string> { "str_Package_Name", "", "str_CR_Days", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "CONCAT([str_Package_Name],'" + ValueSeparator(2, int_CR_ID) + "',[str_CR_Days])"),
                _ => new Lookup<DbField>(int_CR_ID, "qryClassRoomList", false, "int_CR_ID", new List<string> { "str_CR_Days", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "[str_CR_Days]")
            };
            Fields.Add("int_CR_ID", int_CR_ID);

            // int_Student_Id
            int_Student_Id = new(this, "x_int_Student_Id", 3, SqlDbType.Int)
            {
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "int_Student_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Student_Id", int_Student_Id);

            // int_BTW_Id
            int_BTW_Id = new(this, "x_int_BTW_Id", 3, SqlDbType.Int)
            {
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "int_BTW_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_BTW_Id", int_BTW_Id);

            // int_Item_Id
            int_Item_Id = new(this, "x_int_Item_Id", 3, SqlDbType.Int)
            {
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "int_Item_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Item_Id", int_Item_Id);

            // int_Package_Id
            int_Package_Id = new(this, "x_int_Package_Id", 3, SqlDbType.Int)
            {
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
                HtmlTag = "SELECT",
                InputTextType = "text",
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "int_Package_Id", "CustomMsg"),
                IsUpload = false
            };
            int_Package_Id.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(int_Package_Id, "qryClassRoomList", false, "int_CR_Product_ID", new List<string> { "int_CR_Product_ID", "str_Package_Name", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "CONCAT(CAST([int_CR_Product_ID] AS NVARCHAR),'" + ValueSeparator(1, int_Package_Id) + "',[str_Package_Name])"),
                "en-US" => new Lookup<DbField>(int_Package_Id, "qryClassRoomList", false, "int_CR_Product_ID", new List<string> { "int_CR_Product_ID", "str_Package_Name", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "CONCAT(CAST([int_CR_Product_ID] AS NVARCHAR),'" + ValueSeparator(1, int_Package_Id) + "',[str_Package_Name])"),
                _ => new Lookup<DbField>(int_Package_Id, "qryClassRoomList", false, "int_CR_Product_ID", new List<string> { "int_CR_Product_ID", "str_Package_Name", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "CONCAT(CAST([int_CR_Product_ID] AS NVARCHAR),'" + ValueSeparator(1, int_Package_Id) + "',[str_Package_Name])")
            };
            Fields.Add("int_Package_Id", int_Package_Id);

            // str_Package_Name
            str_Package_Name = new(this, "x_str_Package_Name", 202, SqlDbType.NVarChar)
            {
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "str_Package_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Package_Name", str_Package_Name);

            // int_PackageCR_Id
            int_PackageCR_Id = new(this, "x_int_PackageCR_Id", 3, SqlDbType.Int)
            {
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
                HtmlTag = "SELECT",
                InputTextType = "text",
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new() { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "int_PackageCR_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_PackageCR_Id", int_PackageCR_Id);

            // date_Created
            date_Created = new(this, "x_date_Created", 135, SqlDbType.DateTime)
            {
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "date_Created", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Created", date_Created);

            // date_Modified
            date_Modified = new(this, "x_date_Modified", 135, SqlDbType.DateTime)
            {
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "date_Modified", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Modified", date_Modified);

            // int_Created_By
            int_Created_By = new(this, "x_int_Created_By", 3, SqlDbType.Int)
            {
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "int_Created_By", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Created_By", int_Created_By);

            // int_Modified_By
            int_Modified_By = new(this, "x_int_Modified_By", 3, SqlDbType.Int)
            {
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "int_Modified_By", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Modified_By", int_Modified_By);

            // str_PurchaseAmount
            str_PurchaseAmount = new(this, "x_str_PurchaseAmount", 131, SqlDbType.Decimal)
            {
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "str_PurchaseAmount", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_PurchaseAmount", str_PurchaseAmount);

            // int_ApptId
            int_ApptId = new(this, "x_int_ApptId", 3, SqlDbType.Int)
            {
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "int_ApptId", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_ApptId", int_ApptId);

            // course
            course = new(this, "x_course", 200, SqlDbType.VarChar)
            {
                Name = "course",
                Expression = "[course]",
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
                OptionCount = 2,
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "course", "CustomMsg"),
                IsUpload = false
            };
            course.Lookup = CurrentLanguage switch
            {
                "ar-SA" => new Lookup<DbField>(course, "tblStudentEnrollment", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                "en-US" => new Lookup<DbField>(course, "tblStudentEnrollment", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", ""),
                _ => new Lookup<DbField>(course, "tblStudentEnrollment", false, "", new List<string> { "", "", "", "" }, "", "", new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, new List<string> { }, "", "", "")
            };
            Fields.Add("course", course);

            // institution
            institution = new(this, "x_institution", 200, SqlDbType.VarChar)
            {
                Name = "institution",
                Expression = "[institution]",
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "institution", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("institution", institution);

            // str_Notes
            str_Notes = new(this, "x_str_Notes", 202, SqlDbType.NVarChar)
            {
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "str_Notes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Notes", str_Notes);

            // int_SoldBy
            int_SoldBy = new(this, "x_int_SoldBy", 3, SqlDbType.Int)
            {
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "int_SoldBy", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_SoldBy", int_SoldBy);

            // int_Bill_ID
            int_Bill_ID = new(this, "x_int_Bill_ID", 3, SqlDbType.Int)
            {
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "int_Bill_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Bill_ID", int_Bill_ID);

            // str_Amount_Pay
            str_Amount_Pay = new(this, "x_str_Amount_Pay", 200, SqlDbType.VarChar)
            {
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "str_Amount_Pay", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Amount_Pay", str_Amount_Pay);

            // int_ApptCldr_ID
            int_ApptCldr_ID = new(this, "x_int_ApptCldr_ID", 3, SqlDbType.Int)
            {
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "int_ApptCldr_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_ApptCldr_ID", int_ApptCldr_ID);

            // UniqueIdx
            UniqueIdx = new(this, "x_UniqueIdx", 202, SqlDbType.NVarChar)
            {
                Name = "UniqueIdx",
                Expression = "[UniqueIdx]",
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
                SearchOperators = new() { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStudentEnrollment", "UniqueIdx", "CustomMsg"),
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

        // Current master table name
        public string CurrentMasterTable
        {
            get => Session.GetString(Config.ProjectName + "_" + TableVar + "_" + Config.TableMasterTable);
            set => Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableMasterTable] = value;
        }

        // Session master where clause
        public string MasterFilterFromSession
        {
            get
            { // Master filter
                string masterFilter = "";
                if (CurrentMasterTable == "tblBillingInfo")
                {
                    dynamic masterTable = Resolve("tblBillingInfo")!;
                    if (!Empty(NationalID.SessionValue))
                        masterFilter += "" + KeyFilter(masterTable.NationalID, NationalID.SessionValue, masterTable.NationalID.DataType, masterTable.DbId);
                    else
                        return "";
                }
                return masterFilter;
            }
        }

        // Session detail WHERE clause
        public string DetailFilterFromSession
        {
            get
            { // Detail filter
                string detailFilter = "";
                if (CurrentMasterTable == "tblBillingInfo")
                {
                    dynamic masterTable = Resolve("tblBillingInfo")!;
                    if (!Empty(NationalID.SessionValue))
                        detailFilter += "" + KeyFilter(NationalID, NationalID.SessionValue, masterTable.NationalID.DataType, DbId);
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
            switch (masterTable?.TableVar)
            {
                case "tblBillingInfo":
                    key = keys["NationalID"] ?? "";
                    if (Empty(key))
                    {
                        if (masterTable.NationalID.Required) // Required field and empty value
                            return ""; // Return empty filter
                        validKeys = false;
                    }
                    else if (!validKeys)
                    { // Already has empty key
                        return ""; // Return empty filter
                    }
                    if (validKeys)
                    {
                        return KeyFilter(masterTable.NationalID, keys["NationalID"], NationalID.DataType, DbId);
                    }
                    break;
            }
            return null; // All null values and no required fields
        }

        // Detail filter // DN
        public string DetailFilter(dynamic masterTable) // DN
        {
            return masterTable.TableVar switch
            {
                "tblBillingInfo" => KeyFilter(NationalID, masterTable.NationalID.DbValue, masterTable.NationalID.DataType, masterTable.DbId),
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
            get => _sqlFrom ?? "dbo.tblStudentEnrollment";
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
                AddFilter(ref where, ConvertToString(TableFilter));
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
                int_Enrollement_Id.SetDbValue(lastInsertedId);
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
                if (!rsaudit.ContainsKey("int_Enrollement_Id"))
                    rsaudit.Add("int_Enrollement_Id", rsold["int_Enrollement_Id"]);
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
                int_Enrollement_Id.DbValue = row["int_Enrollement_Id"]; // Set DB value only
                str_Full_Name.DbValue = row["str_Full_Name"]; // Set DB value only
                str_Username.DbValue = row["str_Username"]; // Set DB value only
                NationalID.DbValue = row["NationalID"]; // Set DB value only
                int_CR_ID.DbValue = row["int_CR_ID"]; // Set DB value only
                int_Student_Id.DbValue = row["int_Student_Id"]; // Set DB value only
                int_BTW_Id.DbValue = row["int_BTW_Id"]; // Set DB value only
                int_Item_Id.DbValue = row["int_Item_Id"]; // Set DB value only
                int_Package_Id.DbValue = row["int_Package_Id"]; // Set DB value only
                str_Package_Name.DbValue = row["str_Package_Name"]; // Set DB value only
                int_PackageCR_Id.DbValue = row["int_PackageCR_Id"]; // Set DB value only
                date_Created.DbValue = row["date_Created"]; // Set DB value only
                date_Modified.DbValue = row["date_Modified"]; // Set DB value only
                int_Created_By.DbValue = row["int_Created_By"]; // Set DB value only
                int_Modified_By.DbValue = row["int_Modified_By"]; // Set DB value only
                str_PurchaseAmount.DbValue = row["str_PurchaseAmount"]; // Set DB value only
                int_ApptId.DbValue = row["int_ApptId"]; // Set DB value only
                course.DbValue = row["course"]; // Set DB value only
                institution.DbValue = row["institution"]; // Set DB value only
                str_Notes.DbValue = row["str_Notes"]; // Set DB value only
                int_SoldBy.DbValue = row["int_SoldBy"]; // Set DB value only
                int_Bill_ID.DbValue = row["int_Bill_ID"]; // Set DB value only
                str_Amount_Pay.DbValue = row["str_Amount_Pay"]; // Set DB value only
                int_ApptCldr_ID.DbValue = row["int_ApptCldr_ID"]; // Set DB value only
                UniqueIdx.DbValue = row["UniqueIdx"]; // Set DB value only
            }
            catch { }
        }

        public void DeleteUploadedFiles(Dictionary<string, object> row)
        {
            LoadDbValues(row);
        }

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
            Dictionary<string, object>? keyFilter = new();
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
                    return "TblStudentEnrollmentList";
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
            if (SameString(pageName, "TblStudentEnrollmentView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "TblStudentEnrollmentEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "TblStudentEnrollmentAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get
            {
                return "TblStudentEnrollmentList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch
            {
                Config.ApiViewAction => "TblStudentEnrollmentView",
                Config.ApiAddAction => "TblStudentEnrollmentAdd",
                Config.ApiEditAction => "TblStudentEnrollmentEdit",
                Config.ApiDeleteAction => "TblStudentEnrollmentDelete",
                Config.ApiListAction => "TblStudentEnrollmentList",
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
        public string ListUrl => "TblStudentEnrollmentList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblStudentEnrollmentView", parm);
            else
                url = KeyUrl("TblStudentEnrollmentView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "TblStudentEnrollmentAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "TblStudentEnrollmentAdd?" + parm;
            else
                url = "TblStudentEnrollmentAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("TblStudentEnrollmentEdit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblStudentEnrollmentList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("TblStudentEnrollmentAdd", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblStudentEnrollmentList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("TblStudentEnrollmentDelete")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
            if (CurrentMasterTable == "tblBillingInfo" && !url.Contains(Config.TableShowMaster + "="))
            {
                url += (url.Contains("?") ? "&" : "?") + Config.TableShowMaster + "=" + CurrentMasterTable;
                url += "&" + ForeignKeyUrl("fk_NationalID", NationalID.SessionValue); // Use Session Value
            }
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
        public string KeyUrl(string url, string parm = "")
        { // DN
            if (!IsNull(int_Enrollement_Id.CurrentValue))
            {
                url += "/" + int_Enrollement_Id.CurrentValue;
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
            val = current ? ConvertToString(int_Enrollement_Id.CurrentValue) ?? "" : ConvertToString(int_Enrollement_Id.OldValue) ?? "";
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
            if (keys.Length == 1)
            {
                if (current)
                {
                    int_Enrollement_Id.CurrentValue = keys[0];
                }
                else
                {
                    int_Enrollement_Id.OldValue = keys[0];
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
                if (RouteValues.TryGetValue("int_Enrollement_Id", out object? v0))
                { // int_Enrollement_Id // DN
                    key = UrlDecode(v0); // DN
                }
                else if (IsApi() && !Empty(keyValues))
                {
                    key = keyValues[0];
                }
                else
                {
                    key = Param("int_Enrollement_Id");
                }
                keysList.Add(key);
            }
            // Check keys
            foreach (var keys in keysList)
            {
                if (!IsNumeric(keys)) // int_Enrollement_Id
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
                    int_Enrollement_Id.CurrentValue = keys;
                else
                    int_Enrollement_Id.OldValue = keys;
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
            int_Enrollement_Id.SetDbValue(dr["int_Enrollement_Id"]);
            str_Full_Name.SetDbValue(dr["str_Full_Name"]);
            str_Username.SetDbValue(dr["str_Username"]);
            NationalID.SetDbValue(dr["NationalID"]);
            int_CR_ID.SetDbValue(dr["int_CR_ID"]);
            int_Student_Id.SetDbValue(dr["int_Student_Id"]);
            int_BTW_Id.SetDbValue(dr["int_BTW_Id"]);
            int_Item_Id.SetDbValue(dr["int_Item_Id"]);
            int_Package_Id.SetDbValue(dr["int_Package_Id"]);
            str_Package_Name.SetDbValue(dr["str_Package_Name"]);
            int_PackageCR_Id.SetDbValue(dr["int_PackageCR_Id"]);
            date_Created.SetDbValue(dr["date_Created"]);
            date_Modified.SetDbValue(dr["date_Modified"]);
            int_Created_By.SetDbValue(dr["int_Created_By"]);
            int_Modified_By.SetDbValue(dr["int_Modified_By"]);
            str_PurchaseAmount.SetDbValue(dr["str_PurchaseAmount"]);
            int_ApptId.SetDbValue(dr["int_ApptId"]);
            course.SetDbValue(dr["course"]);
            institution.SetDbValue(dr["institution"]);
            str_Notes.SetDbValue(dr["str_Notes"]);
            int_SoldBy.SetDbValue(dr["int_SoldBy"]);
            int_Bill_ID.SetDbValue(dr["int_Bill_ID"]);
            str_Amount_Pay.SetDbValue(dr["str_Amount_Pay"]);
            int_ApptCldr_ID.SetDbValue(dr["int_ApptCldr_ID"]);
            UniqueIdx.SetDbValue(dr["UniqueIdx"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "TblStudentEnrollmentList";
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

            // int_Enrollement_Id

            // str_Full_Name

            // str_Username

            // NationalID

            // int_CR_ID

            // int_Student_Id

            // int_BTW_Id

            // int_Item_Id

            // int_Package_Id

            // str_Package_Name

            // int_PackageCR_Id

            // date_Created

            // date_Modified

            // int_Created_By

            // int_Modified_By

            // str_PurchaseAmount

            // int_ApptId

            // course

            // institution

            // str_Notes

            // int_SoldBy

            // int_Bill_ID

            // str_Amount_Pay

            // int_ApptCldr_ID

            // UniqueIdx

            // int_Enrollement_Id
            int_Enrollement_Id.ViewValue = int_Enrollement_Id.CurrentValue;
            int_Enrollement_Id.ViewCustomAttributes = "";

            // str_Full_Name
            curVal = ConvertToString(str_Full_Name.CurrentValue);
            if (!Empty(curVal))
            {
                if (str_Full_Name.Lookup != null && IsDictionary(str_Full_Name.Lookup?.Options) && str_Full_Name.Lookup?.Options.Values.Count > 0)
                { // Load from cache // DN
                    str_Full_Name.ViewValue = str_Full_Name.LookupCacheOption(curVal);
                }
                else
                { // Lookup from database // DN
                    filterWrk = SearchFilter("[str_Full_Name]", "=", str_Full_Name.CurrentValue, DataType.String, "");
                    sqlWrk = str_Full_Name.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && str_Full_Name.Lookup != null)
                    { // Lookup values found
                        var listwrk = str_Full_Name.Lookup?.RenderViewRow(rswrk[0]);
                        str_Full_Name.ViewValue = str_Full_Name.HighlightLookup(ConvertToString(rswrk[0]), str_Full_Name.DisplayValue(listwrk));
                    }
                    else
                    {
                        str_Full_Name.ViewValue = str_Full_Name.CurrentValue;
                    }
                }
            }
            else
            {
                str_Full_Name.ViewValue = DbNullValue;
            }
            str_Full_Name.ViewCustomAttributes = "";

            // str_Username
            str_Username.ViewValue = str_Username.CurrentValue;
            str_Username.ViewCustomAttributes = "";

            // NationalID
            curVal = ConvertToString(NationalID.CurrentValue);
            if (!Empty(curVal))
            {
                if (NationalID.Lookup != null && IsDictionary(NationalID.Lookup?.Options) && NationalID.Lookup?.Options.Values.Count > 0)
                { // Load from cache // DN
                    NationalID.ViewValue = NationalID.LookupCacheOption(curVal);
                }
                else
                { // Lookup from database // DN
                    filterWrk = SearchFilter("[NationalID]", "=", NationalID.CurrentValue, DataType.Number, "");
                    sqlWrk = NationalID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && NationalID.Lookup != null)
                    { // Lookup values found
                        var listwrk = NationalID.Lookup?.RenderViewRow(rswrk[0]);
                        NationalID.ViewValue = NationalID.HighlightLookup(ConvertToString(rswrk[0]), NationalID.DisplayValue(listwrk));
                    }
                    else
                    {
                        NationalID.ViewValue = NationalID.CurrentValue;
                    }
                }
            }
            else
            {
                NationalID.ViewValue = DbNullValue;
            }
            NationalID.ViewCustomAttributes = "";

            // int_CR_ID
            curVal = ConvertToString(int_CR_ID.CurrentValue);
            if (!Empty(curVal))
            {
                if (int_CR_ID.Lookup != null && IsDictionary(int_CR_ID.Lookup?.Options) && int_CR_ID.Lookup?.Options.Values.Count > 0)
                { // Load from cache // DN
                    int_CR_ID.ViewValue = int_CR_ID.LookupCacheOption(curVal);
                }
                else
                { // Lookup from database // DN
                    filterWrk = SearchFilter("[int_CR_ID]", "=", int_CR_ID.CurrentValue, DataType.Number, "");
                    sqlWrk = int_CR_ID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && int_CR_ID.Lookup != null)
                    { // Lookup values found
                        var listwrk = int_CR_ID.Lookup?.RenderViewRow(rswrk[0]);
                        int_CR_ID.ViewValue = int_CR_ID.HighlightLookup(ConvertToString(rswrk[0]), int_CR_ID.DisplayValue(listwrk));
                    }
                    else
                    {
                        int_CR_ID.ViewValue = FormatNumber(int_CR_ID.CurrentValue, int_CR_ID.FormatPattern);
                    }
                }
            }
            else
            {
                int_CR_ID.ViewValue = DbNullValue;
            }
            int_CR_ID.ViewCustomAttributes = "";

            // int_Student_Id
            int_Student_Id.ViewValue = int_Student_Id.CurrentValue;
            int_Student_Id.ViewValue = FormatNumber(int_Student_Id.ViewValue, int_Student_Id.FormatPattern);
            int_Student_Id.ViewCustomAttributes = "";

            // int_BTW_Id
            int_BTW_Id.ViewValue = int_BTW_Id.CurrentValue;
            int_BTW_Id.ViewValue = FormatNumber(int_BTW_Id.ViewValue, int_BTW_Id.FormatPattern);
            int_BTW_Id.ViewCustomAttributes = "";

            // int_Item_Id
            int_Item_Id.ViewValue = int_Item_Id.CurrentValue;
            int_Item_Id.ViewValue = FormatNumber(int_Item_Id.ViewValue, int_Item_Id.FormatPattern);
            int_Item_Id.ViewCustomAttributes = "";

            // int_Package_Id
            curVal = ConvertToString(int_Package_Id.CurrentValue);
            if (!Empty(curVal))
            {
                if (int_Package_Id.Lookup != null && IsDictionary(int_Package_Id.Lookup?.Options) && int_Package_Id.Lookup?.Options.Values.Count > 0)
                { // Load from cache // DN
                    int_Package_Id.ViewValue = int_Package_Id.LookupCacheOption(curVal);
                }
                else
                { // Lookup from database // DN
                    filterWrk = SearchFilter("[int_CR_Product_ID]", "=", int_Package_Id.CurrentValue, DataType.Number, "");
                    sqlWrk = int_Package_Id.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && int_Package_Id.Lookup != null)
                    { // Lookup values found
                        var listwrk = int_Package_Id.Lookup?.RenderViewRow(rswrk[0]);
                        int_Package_Id.ViewValue = int_Package_Id.HighlightLookup(ConvertToString(rswrk[0]), int_Package_Id.DisplayValue(listwrk));
                    }
                    else
                    {
                        int_Package_Id.ViewValue = FormatNumber(int_Package_Id.CurrentValue, int_Package_Id.FormatPattern);
                    }
                }
            }
            else
            {
                int_Package_Id.ViewValue = DbNullValue;
            }
            int_Package_Id.ViewCustomAttributes = "";

            // str_Package_Name
            str_Package_Name.ViewValue = ConvertToString(str_Package_Name.CurrentValue); // DN
            str_Package_Name.ViewCustomAttributes = "";

            // int_PackageCR_Id
            int_PackageCR_Id.ViewValue = FormatNumber(int_PackageCR_Id.ViewValue, int_PackageCR_Id.FormatPattern);
            int_PackageCR_Id.ViewCustomAttributes = "";

            // date_Created
            date_Created.ViewValue = date_Created.CurrentValue;
            date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
            date_Created.ViewCustomAttributes = "";

            // date_Modified
            date_Modified.ViewValue = date_Modified.CurrentValue;
            date_Modified.ViewValue = FormatDateTime(date_Modified.ViewValue, date_Modified.FormatPattern);
            date_Modified.ViewCustomAttributes = "";

            // int_Created_By
            int_Created_By.ViewValue = int_Created_By.CurrentValue;
            int_Created_By.ViewValue = FormatNumber(int_Created_By.ViewValue, int_Created_By.FormatPattern);
            int_Created_By.ViewCustomAttributes = "";

            // int_Modified_By
            int_Modified_By.ViewValue = int_Modified_By.CurrentValue;
            int_Modified_By.ViewValue = FormatNumber(int_Modified_By.ViewValue, int_Modified_By.FormatPattern);
            int_Modified_By.ViewCustomAttributes = "";

            // str_PurchaseAmount
            str_PurchaseAmount.ViewValue = str_PurchaseAmount.CurrentValue;
            str_PurchaseAmount.ViewValue = FormatNumber(str_PurchaseAmount.ViewValue, str_PurchaseAmount.FormatPattern);
            str_PurchaseAmount.ViewCustomAttributes = "";

            // int_ApptId
            int_ApptId.ViewValue = int_ApptId.CurrentValue;
            int_ApptId.ViewValue = FormatNumber(int_ApptId.ViewValue, int_ApptId.FormatPattern);
            int_ApptId.ViewCustomAttributes = "";

            // course
            course.ViewValue = ConvertToString(course.CurrentValue); // DN
            course.ViewCustomAttributes = "";

            // institution
            institution.ViewValue = ConvertToString(institution.CurrentValue); // DN
            institution.ViewCustomAttributes = "";

            // str_Notes
            str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
            str_Notes.ViewCustomAttributes = "";

            // int_SoldBy
            int_SoldBy.ViewValue = int_SoldBy.CurrentValue;
            int_SoldBy.ViewValue = FormatNumber(int_SoldBy.ViewValue, int_SoldBy.FormatPattern);
            int_SoldBy.ViewCustomAttributes = "";

            // int_Bill_ID
            int_Bill_ID.ViewValue = int_Bill_ID.CurrentValue;
            int_Bill_ID.ViewValue = FormatNumber(int_Bill_ID.ViewValue, int_Bill_ID.FormatPattern);
            int_Bill_ID.ViewCustomAttributes = "";

            // str_Amount_Pay
            str_Amount_Pay.ViewValue = ConvertToString(str_Amount_Pay.CurrentValue); // DN
            str_Amount_Pay.ViewCustomAttributes = "";

            // int_ApptCldr_ID
            int_ApptCldr_ID.ViewValue = int_ApptCldr_ID.CurrentValue;
            int_ApptCldr_ID.ViewValue = FormatNumber(int_ApptCldr_ID.ViewValue, int_ApptCldr_ID.FormatPattern);
            int_ApptCldr_ID.ViewCustomAttributes = "";

            // UniqueIdx
            UniqueIdx.ViewValue = ConvertToString(UniqueIdx.CurrentValue); // DN
            UniqueIdx.ViewCustomAttributes = "";

            // int_Enrollement_Id
            int_Enrollement_Id.HrefValue = "";
            int_Enrollement_Id.TooltipValue = "";

            // str_Full_Name
            str_Full_Name.HrefValue = "";
            str_Full_Name.TooltipValue = "";

            // str_Username
            str_Username.HrefValue = "";
            str_Username.TooltipValue = "";

            // NationalID
            NationalID.HrefValue = "";
            NationalID.TooltipValue = "";

            // int_CR_ID
            int_CR_ID.HrefValue = "";
            int_CR_ID.TooltipValue = "";

            // int_Student_Id
            int_Student_Id.HrefValue = "";
            int_Student_Id.TooltipValue = "";

            // int_BTW_Id
            int_BTW_Id.HrefValue = "";
            int_BTW_Id.TooltipValue = "";

            // int_Item_Id
            int_Item_Id.HrefValue = "";
            int_Item_Id.TooltipValue = "";

            // int_Package_Id
            int_Package_Id.HrefValue = "";
            int_Package_Id.TooltipValue = "";

            // str_Package_Name
            str_Package_Name.HrefValue = "";
            str_Package_Name.TooltipValue = "";

            // int_PackageCR_Id
            int_PackageCR_Id.HrefValue = "";
            int_PackageCR_Id.TooltipValue = "";

            // date_Created
            date_Created.HrefValue = "";
            date_Created.TooltipValue = "";

            // date_Modified
            date_Modified.HrefValue = "";
            date_Modified.TooltipValue = "";

            // int_Created_By
            int_Created_By.HrefValue = "";
            int_Created_By.TooltipValue = "";

            // int_Modified_By
            int_Modified_By.HrefValue = "";
            int_Modified_By.TooltipValue = "";

            // str_PurchaseAmount
            str_PurchaseAmount.HrefValue = "";
            str_PurchaseAmount.TooltipValue = "";

            // int_ApptId
            int_ApptId.HrefValue = "";
            int_ApptId.TooltipValue = "";

            // course
            course.HrefValue = "";
            course.TooltipValue = "";

            // institution
            institution.HrefValue = "";
            institution.TooltipValue = "";

            // str_Notes
            str_Notes.HrefValue = "";
            str_Notes.TooltipValue = "";

            // int_SoldBy
            int_SoldBy.HrefValue = "";
            int_SoldBy.TooltipValue = "";

            // int_Bill_ID
            int_Bill_ID.HrefValue = "";
            int_Bill_ID.TooltipValue = "";

            // str_Amount_Pay
            str_Amount_Pay.HrefValue = "";
            str_Amount_Pay.TooltipValue = "";

            // int_ApptCldr_ID
            int_ApptCldr_ID.HrefValue = "";
            int_ApptCldr_ID.TooltipValue = "";

            // UniqueIdx
            UniqueIdx.HrefValue = "";
            UniqueIdx.TooltipValue = "";

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

            // int_Enrollement_Id
            int_Enrollement_Id.SetupEditAttributes();
            int_Enrollement_Id.EditValue = int_Enrollement_Id.CurrentValue;
            int_Enrollement_Id.ViewCustomAttributes = "";

            // str_Full_Name
            str_Full_Name.SetupEditAttributes();
            curVal = ConvertToString(str_Full_Name.CurrentValue);
            if (!Empty(curVal))
            {
                if (str_Full_Name.Lookup != null && IsDictionary(str_Full_Name.Lookup?.Options) && str_Full_Name.Lookup?.Options.Values.Count > 0)
                { // Load from cache // DN
                    str_Full_Name.EditValue = str_Full_Name.LookupCacheOption(curVal);
                }
                else
                { // Lookup from database // DN
                    filterWrk = SearchFilter("[str_Full_Name]", "=", str_Full_Name.CurrentValue, DataType.String, "");
                    sqlWrk = str_Full_Name.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && str_Full_Name.Lookup != null)
                    { // Lookup values found
                        var listwrk = str_Full_Name.Lookup?.RenderViewRow(rswrk[0]);
                        str_Full_Name.EditValue = str_Full_Name.HighlightLookup(ConvertToString(rswrk[0]), str_Full_Name.DisplayValue(listwrk));
                    }
                    else
                    {
                        str_Full_Name.EditValue = str_Full_Name.CurrentValue;
                    }
                }
            }
            else
            {
                str_Full_Name.EditValue = DbNullValue;
            }
            str_Full_Name.ViewCustomAttributes = "";

            // str_Username

            // NationalID
            NationalID.SetupEditAttributes();
            curVal = ConvertToString(NationalID.CurrentValue);
            if (!Empty(curVal))
            {
                if (NationalID.Lookup != null && IsDictionary(NationalID.Lookup?.Options) && NationalID.Lookup?.Options.Values.Count > 0)
                { // Load from cache // DN
                    NationalID.EditValue = NationalID.LookupCacheOption(curVal);
                }
                else
                { // Lookup from database // DN
                    filterWrk = SearchFilter("[NationalID]", "=", NationalID.CurrentValue, DataType.Number, "");
                    sqlWrk = NationalID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && NationalID.Lookup != null)
                    { // Lookup values found
                        var listwrk = NationalID.Lookup?.RenderViewRow(rswrk[0]);
                        NationalID.EditValue = NationalID.HighlightLookup(ConvertToString(rswrk[0]), NationalID.DisplayValue(listwrk));
                    }
                    else
                    {
                        NationalID.EditValue = NationalID.CurrentValue;
                    }
                }
            }
            else
            {
                NationalID.EditValue = DbNullValue;
            }
            NationalID.ViewCustomAttributes = "";

            // int_CR_ID
            int_CR_ID.SetupEditAttributes();
            int_CR_ID.PlaceHolder = RemoveHtml(int_CR_ID.Caption);
            if (!Empty(int_CR_ID.EditValue) && IsNumeric(int_CR_ID.EditValue))
                int_CR_ID.EditValue = FormatNumber(int_CR_ID.EditValue, null);

            // int_Student_Id
            int_Student_Id.SetupEditAttributes();
            int_Student_Id.EditValue = int_Student_Id.CurrentValue; // DN
            int_Student_Id.PlaceHolder = RemoveHtml(int_Student_Id.Caption);
            if (!Empty(int_Student_Id.EditValue) && IsNumeric(int_Student_Id.EditValue))
                int_Student_Id.EditValue = FormatNumber(int_Student_Id.EditValue, null);

            // int_BTW_Id
            int_BTW_Id.SetupEditAttributes();
            int_BTW_Id.EditValue = int_BTW_Id.CurrentValue; // DN
            int_BTW_Id.PlaceHolder = RemoveHtml(int_BTW_Id.Caption);
            if (!Empty(int_BTW_Id.EditValue) && IsNumeric(int_BTW_Id.EditValue))
                int_BTW_Id.EditValue = FormatNumber(int_BTW_Id.EditValue, null);

            // int_Item_Id
            int_Item_Id.SetupEditAttributes();
            int_Item_Id.EditValue = int_Item_Id.CurrentValue; // DN
            int_Item_Id.PlaceHolder = RemoveHtml(int_Item_Id.Caption);
            if (!Empty(int_Item_Id.EditValue) && IsNumeric(int_Item_Id.EditValue))
                int_Item_Id.EditValue = FormatNumber(int_Item_Id.EditValue, null);

            // int_Package_Id
            int_Package_Id.SetupEditAttributes();
            int_Package_Id.PlaceHolder = RemoveHtml(int_Package_Id.Caption);
            if (!Empty(int_Package_Id.EditValue) && IsNumeric(int_Package_Id.EditValue))
                int_Package_Id.EditValue = FormatNumber(int_Package_Id.EditValue, null);

            // str_Package_Name
            str_Package_Name.SetupEditAttributes();
            str_Package_Name.EditValue = ConvertToString(str_Package_Name.CurrentValue); // DN
            str_Package_Name.ViewCustomAttributes = "";

            // int_PackageCR_Id
            int_PackageCR_Id.SetupEditAttributes();
            int_PackageCR_Id.PlaceHolder = RemoveHtml(int_PackageCR_Id.Caption);
            if (!Empty(int_PackageCR_Id.EditValue) && IsNumeric(int_PackageCR_Id.EditValue))
                int_PackageCR_Id.EditValue = FormatNumber(int_PackageCR_Id.EditValue, null);

            // date_Created
            date_Created.SetupEditAttributes();
            date_Created.EditValue = FormatDateTime(date_Created.CurrentValue, date_Created.FormatPattern); // DN
            date_Created.PlaceHolder = RemoveHtml(date_Created.Caption);

            // date_Modified
            date_Modified.SetupEditAttributes();
            date_Modified.EditValue = FormatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern); // DN
            date_Modified.PlaceHolder = RemoveHtml(date_Modified.Caption);

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

            // str_PurchaseAmount
            str_PurchaseAmount.SetupEditAttributes();
            str_PurchaseAmount.EditValue = str_PurchaseAmount.CurrentValue;
            str_PurchaseAmount.EditValue = FormatNumber(str_PurchaseAmount.EditValue, str_PurchaseAmount.FormatPattern);
            str_PurchaseAmount.ViewCustomAttributes = "";

            // int_ApptId
            int_ApptId.SetupEditAttributes();
            int_ApptId.EditValue = int_ApptId.CurrentValue; // DN
            int_ApptId.PlaceHolder = RemoveHtml(int_ApptId.Caption);
            if (!Empty(int_ApptId.EditValue) && IsNumeric(int_ApptId.EditValue))
                int_ApptId.EditValue = FormatNumber(int_ApptId.EditValue, null);

            // course
            course.SetupEditAttributes();
            if (!course.Raw)
                course.CurrentValue = HtmlDecode(course.CurrentValue);
            course.EditValue = HtmlEncode(course.CurrentValue);
            course.PlaceHolder = RemoveHtml(course.Caption);

            // institution
            institution.SetupEditAttributes();
            if (!institution.Raw)
                institution.CurrentValue = HtmlDecode(institution.CurrentValue);
            institution.EditValue = HtmlEncode(institution.CurrentValue);
            institution.PlaceHolder = RemoveHtml(institution.Caption);

            // str_Notes
            str_Notes.SetupEditAttributes();
            if (!str_Notes.Raw)
                str_Notes.CurrentValue = HtmlDecode(str_Notes.CurrentValue);
            str_Notes.EditValue = HtmlEncode(str_Notes.CurrentValue);
            str_Notes.PlaceHolder = RemoveHtml(str_Notes.Caption);

            // int_SoldBy
            int_SoldBy.SetupEditAttributes();
            int_SoldBy.EditValue = int_SoldBy.CurrentValue; // DN
            int_SoldBy.PlaceHolder = RemoveHtml(int_SoldBy.Caption);
            if (!Empty(int_SoldBy.EditValue) && IsNumeric(int_SoldBy.EditValue))
                int_SoldBy.EditValue = FormatNumber(int_SoldBy.EditValue, null);

            // int_Bill_ID
            int_Bill_ID.SetupEditAttributes();
            int_Bill_ID.EditValue = int_Bill_ID.CurrentValue; // DN
            int_Bill_ID.PlaceHolder = RemoveHtml(int_Bill_ID.Caption);
            if (!Empty(int_Bill_ID.EditValue) && IsNumeric(int_Bill_ID.EditValue))
                int_Bill_ID.EditValue = FormatNumber(int_Bill_ID.EditValue, null);

            // str_Amount_Pay
            str_Amount_Pay.SetupEditAttributes();
            str_Amount_Pay.EditValue = ConvertToString(str_Amount_Pay.CurrentValue); // DN
            str_Amount_Pay.ViewCustomAttributes = "";

            // int_ApptCldr_ID
            int_ApptCldr_ID.SetupEditAttributes();
            int_ApptCldr_ID.EditValue = int_ApptCldr_ID.CurrentValue; // DN
            int_ApptCldr_ID.PlaceHolder = RemoveHtml(int_ApptCldr_ID.Caption);
            if (!Empty(int_ApptCldr_ID.EditValue) && IsNumeric(int_ApptCldr_ID.EditValue))
                int_ApptCldr_ID.EditValue = FormatNumber(int_ApptCldr_ID.EditValue, null);

            // UniqueIdx
            UniqueIdx.SetupEditAttributes();
            if (!UniqueIdx.Raw)
                UniqueIdx.CurrentValue = HtmlDecode(UniqueIdx.CurrentValue);
            UniqueIdx.EditValue = HtmlEncode(UniqueIdx.CurrentValue);
            UniqueIdx.PlaceHolder = RemoveHtml(UniqueIdx.Caption);

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
                        doc.ExportCaption(str_Full_Name);
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(int_CR_ID);
                        doc.ExportCaption(str_Package_Name);
                        doc.ExportCaption(str_PurchaseAmount);
                        doc.ExportCaption(course);
                        doc.ExportCaption(institution);
                        doc.ExportCaption(str_Notes);
                        doc.ExportCaption(str_Amount_Pay);
                        doc.ExportCaption(UniqueIdx);
                    }
                    else
                    {
                        doc.ExportCaption(int_Enrollement_Id);
                        doc.ExportCaption(str_Full_Name);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(int_CR_ID);
                        doc.ExportCaption(int_Student_Id);
                        doc.ExportCaption(int_BTW_Id);
                        doc.ExportCaption(int_Item_Id);
                        doc.ExportCaption(int_Package_Id);
                        doc.ExportCaption(str_Package_Name);
                        doc.ExportCaption(int_PackageCR_Id);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(int_Created_By);
                        doc.ExportCaption(int_Modified_By);
                        doc.ExportCaption(str_PurchaseAmount);
                        doc.ExportCaption(int_ApptId);
                        doc.ExportCaption(course);
                        doc.ExportCaption(institution);
                        doc.ExportCaption(str_Notes);
                        doc.ExportCaption(int_SoldBy);
                        doc.ExportCaption(int_Bill_ID);
                        doc.ExportCaption(str_Amount_Pay);
                        doc.ExportCaption(int_ApptCldr_ID);
                        doc.ExportCaption(UniqueIdx);
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
                            await doc.ExportField(str_Full_Name);
                            await doc.ExportField(NationalID);
                            await doc.ExportField(int_CR_ID);
                            await doc.ExportField(str_Package_Name);
                            await doc.ExportField(str_PurchaseAmount);
                            await doc.ExportField(course);
                            await doc.ExportField(institution);
                            await doc.ExportField(str_Notes);
                            await doc.ExportField(str_Amount_Pay);
                            await doc.ExportField(UniqueIdx);
                        }
                        else
                        {
                            await doc.ExportField(int_Enrollement_Id);
                            await doc.ExportField(str_Full_Name);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(NationalID);
                            await doc.ExportField(int_CR_ID);
                            await doc.ExportField(int_Student_Id);
                            await doc.ExportField(int_BTW_Id);
                            await doc.ExportField(int_Item_Id);
                            await doc.ExportField(int_Package_Id);
                            await doc.ExportField(str_Package_Name);
                            await doc.ExportField(int_PackageCR_Id);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(int_Created_By);
                            await doc.ExportField(int_Modified_By);
                            await doc.ExportField(str_PurchaseAmount);
                            await doc.ExportField(int_ApptId);
                            await doc.ExportField(course);
                            await doc.ExportField(institution);
                            await doc.ExportField(str_Notes);
                            await doc.ExportField(int_SoldBy);
                            await doc.ExportField(int_Bill_ID);
                            await doc.ExportField(str_Amount_Pay);
                            await doc.ExportField(int_ApptCldr_ID);
                            await doc.ExportField(UniqueIdx);
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
            string sql = "SELECT " + masterfld.Expression + " FROM dbo.tblStudentEnrollment";
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
            if (currentMasterTable == "tblBillingInfo")
            {
                filterWrk = tblBillingInfo?.AddUserIDFilter(filterWrk);
            }
            return filterWrk ?? "";
        }

        // Add detail User ID filter
        public string AddDetailUserIDFilter(string filter, string currentMasterTable)
        {
            string filterWrk = filter;
            if (currentMasterTable == "tblBillingInfo")
            {
                if (tblBillingInfo != null && !tblBillingInfo.UserIDAllow())
                    AddFilter(ref filterWrk, tblBillingInfo.GetUserIDSubquery(NationalID, tblBillingInfo.NationalID));
            }
            return filterWrk;
        }

        // Table filter
        private string? _tableFilter = null;

        public string TableFilter
        {
            get => _tableFilter ?? "[course] not like 'en%'";
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
        public async Task WriteAuditTrailLog(string log) => await WriteAuditTrailAsync(CurrentUser(), log, "tblStudentEnrollment");

        // Write audit trail (add page)
        public async Task WriteAuditTrailOnAdd(IDictionary<string, object> rs)
        {
            if (!AuditTrailOnAdd)
                return;
            string table = "tblStudentEnrollment";

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
            string table = "tblStudentEnrollment";

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
            string table = "tblStudentEnrollment";

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

        // Send email after update success
        public async Task<string> SendEmailOnEdit(Dictionary<string, object> rsold, Dictionary<string, object> rsnew)
        {
            string table = "tblStudentEnrollment";
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
            //Log("Row Inserted");

            var int_Package_Id = Convert.ToInt32(rsnew.GetValueOrDefault("int_Package_Id"));
            var int_Student_Id = Convert.ToInt32(rsnew.GetValueOrDefault("int_Student_Id"));

            var rowPackageInfo = ExecuteRow($"SELECT * FROM tblPackageInfo WHERE int_Package_Id = '{int_Package_Id}'");
            var rowStudent = ExecuteRow($"SELECT * FROM tblStudents WHERE int_Student_ID = '{int_Student_Id}'");

            var smsMessage = SmsMessageFor.AfterAssessmentTest(rowStudent.GetValueOrDefault("str_Full_Name")?.ToString(), rowPackageInfo.GetValueOrDefault("str_Package_Name")?.ToString());
            var phoneNo = rowStudent.GetValueOrDefault("str_Cell_Phone")?.ToString();

            await JawalbSms.SendSmsAsync(smsMessage, phoneNo!);
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
            //INS_APPNTMNT_CLDR_CONTENT
            string sInsertSq72 = "INS_APPNTMNT_CLDR_CONTENT";
            Execute(sInsertSq72);

            //INS_BMS_NEW_USERS
            string sInsertSq73 = "INS_BMS_NEW_USERS";
            Execute(sInsertSq73);

            //INS_CRSESSIONS_FROM_qryCRSessionWsht_Student
            string sInsertSq74 = "INS_CRSESSIONS_FROM_qryCRSessionWsht_Student";
            Execute(sInsertSq74);

            //INS_ATTENDANCE_FROM_SESSIONS
            string sInsertSq75 = "INS_ATTENDANCE_FROM_SESSIONS";
            Execute(sInsertSq75);

            var int_Student_Id = Convert.ToInt32(rsnew.GetValueOrDefault("int_Student_Id"));
            var int_Package_Id = Convert.ToInt32(rsnew.GetValueOrDefault("int_Package_Id"));
            var int_Enrollement_Id = Convert.ToInt32(rsnew.GetValueOrDefault("int_Enrollement_Id"));

            var rowStudent = ExecuteRow($"SELECT * FROM tblStudents WHERE int_Student_ID = '{int_Student_Id}'");
            var rowPackageInfo = ExecuteRow($"SELECT * FROM tblPackageInfo WHERE int_Package_Id = '{int_Package_Id}'");
            var packageName = rowPackageInfo.GetValueOrDefault("str_Package_Name", "").ToString();

            var rowAppointmentCldr = ExecuteRow($"SELECT * FROM [Appointment_Cldr] where int_Enrollement_Id = '{int_Enrollement_Id}'");

            string? name = rowStudent.GetValueOrDefault("str_Full_Name")?.ToString();
            string? date = rowAppointmentCldr.GetValueOrDefault("Start")?.ToString();
            string? phoneNo = rowStudent.GetValueOrDefault("str_Cell_Phone")?.ToString();

            //if (packageName?.Contains("Behind The Wheel", StringComparison.CurrentCultureIgnoreCase) == true || packageName?.Contains("BTW", StringComparison.CurrentCultureIgnoreCase) == true)
            //{
                var smsMessage = SmsMessageFor.StudentAppointmentForBTWMessage(name, date);
                await JawalbSms.SendSmsAsync(smsMessage, phoneNo!);
            //}
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
