namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblBillingInfo
    /// </summary>
    [MaybeNull]
    public static TblBillingInfo tblBillingInfo
    {
        get => HttpData.Resolve<TblBillingInfo>("tblBillingInfo");
        set => HttpData["tblBillingInfo"] = value;
    }

    /// <summary>
    /// Table class for tblBillingInfo
    /// </summary>
    public class TblBillingInfo : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> int_Bill_ID;

        public readonly DbField<SqlDbType> NationalID;

        public readonly DbField<SqlDbType> str_First_Name;

        public readonly DbField<SqlDbType> str_Last_Name;

        public readonly DbField<SqlDbType> str_Username;

        public readonly DbField<SqlDbType> int_Student_ID;

        public readonly DbField<SqlDbType> int_Payment_Method;

        public readonly DbField<SqlDbType> date_Paid;

        public readonly DbField<SqlDbType> str_ApprovalCode;

        public readonly DbField<SqlDbType> Payment_Number;

        public readonly DbField<SqlDbType> Pricelist;

        public readonly DbField<SqlDbType> date_Created;

        public readonly DbField<SqlDbType> str_Amount;

        public readonly DbField<SqlDbType> str_CC_Holder_Name;

        public readonly DbField<SqlDbType> str_CC_Number;

        public readonly DbField<SqlDbType> int_CC_ExpMonth;

        public readonly DbField<SqlDbType> int_CC_ExpYear;

        public readonly DbField<SqlDbType> int_CC_Type;

        public readonly DbField<SqlDbType> str_Card_Id;

        public readonly DbField<SqlDbType> str_CC_ValidationNum;

        public readonly DbField<SqlDbType> str_reference;

        public readonly DbField<SqlDbType> str_Amount_Pay;

        public readonly DbField<SqlDbType> mny_Running_Payments;

        public readonly DbField<SqlDbType> mny_Running_Balance;

        public readonly DbField<SqlDbType> str_Payment_Reference;

        public readonly DbField<SqlDbType> int_Accepted_By;

        public readonly DbField<SqlDbType> str_Check_Number;

        public readonly DbField<SqlDbType> bit_Is_Check_Deposited;

        public readonly DbField<SqlDbType> str_Adjustment_Type;

        public readonly DbField<SqlDbType> str_Adjust_Sub_Type;

        public readonly DbField<SqlDbType> bit_Archive;

        public readonly DbField<SqlDbType> int_Created_By;

        public readonly DbField<SqlDbType> int_Modified_By;

        public readonly DbField<SqlDbType> date_Modified;

        public readonly DbField<SqlDbType> bit_IsDeleted;

        public readonly DbField<SqlDbType> str_CardHolder_Address;

        public readonly DbField<SqlDbType> str_CH_City;

        public readonly DbField<SqlDbType> str_CH_Zip;

        public readonly DbField<SqlDbType> int_State;

        public readonly DbField<SqlDbType> bit_IsAuthDotNet;

        public readonly DbField<SqlDbType> bit_IsRefund;

        public readonly DbField<SqlDbType> str_Receipt;

        public readonly DbField<SqlDbType> str_TransactionNumber;

        public readonly DbField<SqlDbType> str_OrderId;

        public readonly DbField<SqlDbType> str_TransactionTime;

        public readonly DbField<SqlDbType> int_Location_Id;

        public readonly DbField<SqlDbType> str_Enrollment_Id;

        public readonly DbField<SqlDbType> str_Notes;

        public readonly DbField<SqlDbType> str_Payment_Note;

        public readonly DbField<SqlDbType> int_Package_ID;

        public readonly DbField<SqlDbType> Package_Name;

        public readonly DbField<SqlDbType> Price;

        public readonly DbField<SqlDbType> AssessmentID;

        public readonly DbField<SqlDbType> course;

        public readonly DbField<SqlDbType> institution;

        public readonly DbField<SqlDbType> UniqueIdx;

        // Constructor
        public TblBillingInfo()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "tblBillingInfo";
            Name = "tblBillingInfo";
            Type = "TABLE";
            UpdateTable = "dbo.tblBillingInfo"; // Update Table
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
                HtmlTag = "NO",
                InputTextType = "text",
                IsAutoIncrement = true, // Autoincrement field
                IsPrimaryKey = true, // Primary key field
                Nullable = false, // NOT NULL field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "int_Bill_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Bill_ID", int_Bill_ID);

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
                HtmlTag = "SELECT",
                InputTextType = "text",
                IsForeignKey = true, // Foreign key field
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "NationalID", "CustomMsg"),
                IsUpload = false
            };
            NationalID.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(NationalID, "qryBillingNames", false, "NationalID", new List<string> {"str_Full_Name", "NationalID", "", ""}, "", "", new List<string> {}, new List<string> {"x_str_Username", "x_int_Student_ID"}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT([str_Full_Name],'" + ValueSeparator(1, NationalID) + "',CAST([NationalID] AS NVARCHAR))"),
                "en-US" => new Lookup<DbField>(NationalID, "qryBillingNames", false, "NationalID", new List<string> {"str_Full_Name", "NationalID", "", ""}, "", "", new List<string> {}, new List<string> {"x_str_Username", "x_int_Student_ID"}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT([str_Full_Name],'" + ValueSeparator(1, NationalID) + "',CAST([NationalID] AS NVARCHAR))"),
                _ => new Lookup<DbField>(NationalID, "qryBillingNames", false, "NationalID", new List<string> {"str_Full_Name", "NationalID", "", ""}, "", "", new List<string> {}, new List<string> {"x_str_Username", "x_int_Student_ID"}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT([str_Full_Name],'" + ValueSeparator(1, NationalID) + "',CAST([NationalID] AS NVARCHAR))")
            };
            Fields.Add("NationalID", NationalID);

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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_First_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_First_Name", str_First_Name);

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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_Last_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Last_Name", str_Last_Name);

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
                HtmlTag = "SELECT",
                InputTextType = "text",
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_Username", "CustomMsg"),
                IsUpload = false
            };
            str_Username.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(str_Username, "qryBillingNames", false, "str_Username", new List<string> {"str_Username", "", "", ""}, "", "", new List<string> {"x_NationalID"}, new List<string> {"x_int_Student_ID"}, new List<string> {"NationalID"}, new List<string> {"x_NationalID"}, new List<string> {}, new List<string> {}, "", "", "[str_Username]"),
                "en-US" => new Lookup<DbField>(str_Username, "qryBillingNames", false, "str_Username", new List<string> {"str_Username", "", "", ""}, "", "", new List<string> {"x_NationalID"}, new List<string> {"x_int_Student_ID"}, new List<string> {"NationalID"}, new List<string> {"x_NationalID"}, new List<string> {}, new List<string> {}, "", "", "[str_Username]"),
                _ => new Lookup<DbField>(str_Username, "qryBillingNames", false, "str_Username", new List<string> {"str_Username", "", "", ""}, "", "", new List<string> {"x_NationalID"}, new List<string> {"x_int_Student_ID"}, new List<string> {"NationalID"}, new List<string> {"x_NationalID"}, new List<string> {}, new List<string> {}, "", "", "[str_Username]")
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
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "SELECT",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "int_Student_ID", "CustomMsg"),
                IsUpload = false
            };
            int_Student_ID.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(int_Student_ID, "qryBillingNames", false, "int_Student_ID", new List<string> {"str_Full_Name", "int_Student_ID", "", ""}, "", "", new List<string> {"x_NationalID", "x_str_Username"}, new List<string> {}, new List<string> {"NationalID", "str_Username"}, new List<string> {"x_NationalID", "x_str_Username"}, new List<string> {}, new List<string> {}, "", "", "CONCAT([str_Full_Name],'" + ValueSeparator(1, int_Student_ID) + "',CAST([int_Student_ID] AS NVARCHAR))"),
                "en-US" => new Lookup<DbField>(int_Student_ID, "qryBillingNames", false, "int_Student_ID", new List<string> {"str_Full_Name", "int_Student_ID", "", ""}, "", "", new List<string> {"x_NationalID", "x_str_Username"}, new List<string> {}, new List<string> {"NationalID", "str_Username"}, new List<string> {"x_NationalID", "x_str_Username"}, new List<string> {}, new List<string> {}, "", "", "CONCAT([str_Full_Name],'" + ValueSeparator(1, int_Student_ID) + "',CAST([int_Student_ID] AS NVARCHAR))"),
                _ => new Lookup<DbField>(int_Student_ID, "qryBillingNames", false, "int_Student_ID", new List<string> {"str_Full_Name", "int_Student_ID", "", ""}, "", "", new List<string> {"x_NationalID", "x_str_Username"}, new List<string> {}, new List<string> {"NationalID", "str_Username"}, new List<string> {"x_NationalID", "x_str_Username"}, new List<string> {}, new List<string> {}, "", "", "CONCAT([str_Full_Name],'" + ValueSeparator(1, int_Student_ID) + "',CAST([int_Student_ID] AS NVARCHAR))")
            };
            Fields.Add("int_Student_ID", int_Student_ID);

            // int_Payment_Method
            int_Payment_Method = new (this, "x_int_Payment_Method", 3, SqlDbType.Int) {
                Name = "int_Payment_Method",
                Expression = "[int_Payment_Method]",
                BasicSearchExpression = "CAST([int_Payment_Method] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Payment_Method]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "SELECT",
                InputTextType = "text",
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                OptionCount = 4,
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "int_Payment_Method", "CustomMsg"),
                IsUpload = false
            };
            int_Payment_Method.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(int_Payment_Method, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(int_Payment_Method, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(int_Payment_Method, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("int_Payment_Method", int_Payment_Method);

            // date_Paid
            date_Paid = new (this, "x_date_Paid", 135, SqlDbType.DateTime) {
                Name = "date_Paid",
                Expression = "[date_Paid]",
                BasicSearchExpression = CastDateFieldForLike("[date_Paid]", 116, "DB"),
                DateTimeFormat = 116,
                VirtualExpression = "[date_Paid]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Required = true, // Required field
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", DateFormat(116)),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "date_Paid", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Paid", date_Paid);

            // str_ApprovalCode
            str_ApprovalCode = new (this, "x_str_ApprovalCode", 202, SqlDbType.NVarChar) {
                Name = "str_ApprovalCode",
                Expression = "[str_ApprovalCode]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_ApprovalCode]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_ApprovalCode]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_ApprovalCode", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_ApprovalCode", str_ApprovalCode);

            // Payment_Number
            Payment_Number = new (this, "x_Payment_Number", 3, SqlDbType.Int) {
                Name = "Payment_Number",
                Expression = "[Payment_Number]",
                BasicSearchExpression = "CAST([Payment_Number] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Payment_Number]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "Payment_Number", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Payment_Number", Payment_Number);

            // Pricelist
            Pricelist = new (this, "x_Pricelist", 6, SqlDbType.Money) {
                Name = "Pricelist",
                Expression = "[Pricelist]",
                BasicSearchExpression = "CAST([Pricelist] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Pricelist]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "Pricelist", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Pricelist", Pricelist);

            // date_Created
            date_Created = new (this, "x_date_Created", 135, SqlDbType.DateTime) {
                Name = "date_Created",
                Expression = "[date_Created]",
                BasicSearchExpression = CastDateFieldForLike("[date_Created]", 13, "DB"),
                DateTimeFormat = 13,
                VirtualExpression = "[date_Created]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", DateFormat(13)),
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "date_Created", "CustomMsg"),
                IsUpload = false
            };
            date_Created.GetAutoUpdateValue = () => CurrentDate();
            Fields.Add("date_Created", date_Created);

            // str_Amount
            str_Amount = new (this, "x_str_Amount", 202, SqlDbType.NVarChar) {
                Name = "str_Amount",
                Expression = "[str_Amount]",
                BasicSearchExpression = "[str_Amount]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Amount]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_Amount", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Amount", str_Amount);

            // str_CC_Holder_Name
            str_CC_Holder_Name = new (this, "x_str_CC_Holder_Name", 202, SqlDbType.NVarChar) {
                Name = "str_CC_Holder_Name",
                Expression = "[str_CC_Holder_Name]",
                BasicSearchExpression = "[str_CC_Holder_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CC_Holder_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_CC_Holder_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CC_Holder_Name", str_CC_Holder_Name);

            // str_CC_Number
            str_CC_Number = new (this, "x_str_CC_Number", 202, SqlDbType.NVarChar) {
                Name = "str_CC_Number",
                Expression = "[str_CC_Number]",
                BasicSearchExpression = "[str_CC_Number]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CC_Number]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectCreditCard"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_CC_Number", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CC_Number", str_CC_Number);

            // int_CC_ExpMonth
            int_CC_ExpMonth = new (this, "x_int_CC_ExpMonth", 3, SqlDbType.Int) {
                Name = "int_CC_ExpMonth",
                Expression = "[int_CC_ExpMonth]",
                BasicSearchExpression = "CAST([int_CC_ExpMonth] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_CC_ExpMonth]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "int_CC_ExpMonth", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CC_ExpMonth", int_CC_ExpMonth);

            // int_CC_ExpYear
            int_CC_ExpYear = new (this, "x_int_CC_ExpYear", 3, SqlDbType.Int) {
                Name = "int_CC_ExpYear",
                Expression = "[int_CC_ExpYear]",
                BasicSearchExpression = "CAST([int_CC_ExpYear] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_CC_ExpYear]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "int_CC_ExpYear", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CC_ExpYear", int_CC_ExpYear);

            // int_CC_Type
            int_CC_Type = new (this, "x_int_CC_Type", 3, SqlDbType.Int) {
                Name = "int_CC_Type",
                Expression = "[int_CC_Type]",
                BasicSearchExpression = "CAST([int_CC_Type] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_CC_Type]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "int_CC_Type", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CC_Type", int_CC_Type);

            // str_Card_Id
            str_Card_Id = new (this, "x_str_Card_Id", 202, SqlDbType.NVarChar) {
                Name = "str_Card_Id",
                Expression = "[str_Card_Id]",
                BasicSearchExpression = "[str_Card_Id]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Card_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_Card_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Card_Id", str_Card_Id);

            // str_CC_ValidationNum
            str_CC_ValidationNum = new (this, "x_str_CC_ValidationNum", 202, SqlDbType.NVarChar) {
                Name = "str_CC_ValidationNum",
                Expression = "[str_CC_ValidationNum]",
                BasicSearchExpression = "[str_CC_ValidationNum]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CC_ValidationNum]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_CC_ValidationNum", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CC_ValidationNum", str_CC_ValidationNum);

            // str_reference
            str_reference = new (this, "x_str_reference", 202, SqlDbType.NVarChar) {
                Name = "str_reference",
                Expression = "[str_reference]",
                BasicSearchExpression = "[str_reference]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_reference]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_reference", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_reference", str_reference);

            // str_Amount_Pay
            str_Amount_Pay = new (this, "x_str_Amount_Pay", 202, SqlDbType.NVarChar) {
                Name = "str_Amount_Pay",
                Expression = "[str_Amount_Pay]",
                UseBasicSearch = true,
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
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_Amount_Pay", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Amount_Pay", str_Amount_Pay);

            // mny_Running_Payments
            mny_Running_Payments = new (this, "x_mny_Running_Payments", 6, SqlDbType.Money) {
                Name = "mny_Running_Payments",
                Expression = "[mny_Running_Payments]",
                BasicSearchExpression = "CAST([mny_Running_Payments] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[mny_Running_Payments]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "mny_Running_Payments", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("mny_Running_Payments", mny_Running_Payments);

            // mny_Running_Balance
            mny_Running_Balance = new (this, "x_mny_Running_Balance", 6, SqlDbType.Money) {
                Name = "mny_Running_Balance",
                Expression = "[mny_Running_Balance]",
                UseBasicSearch = true,
                BasicSearchExpression = "CAST([mny_Running_Balance] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[mny_Running_Balance]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "mny_Running_Balance", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("mny_Running_Balance", mny_Running_Balance);

            // str_Payment_Reference
            str_Payment_Reference = new (this, "x_str_Payment_Reference", 129, SqlDbType.Char) {
                Name = "str_Payment_Reference",
                Expression = "[str_Payment_Reference]",
                BasicSearchExpression = "[str_Payment_Reference]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Payment_Reference]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_Payment_Reference", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Payment_Reference", str_Payment_Reference);

            // int_Accepted_By
            int_Accepted_By = new (this, "x_int_Accepted_By", 3, SqlDbType.Int) {
                Name = "int_Accepted_By",
                Expression = "[int_Accepted_By]",
                BasicSearchExpression = "CAST([int_Accepted_By] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Accepted_By]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "int_Accepted_By", "CustomMsg"),
                IsUpload = false
            };
            int_Accepted_By.GetAutoUpdateValue = () => CurrentUserLevel();
            Fields.Add("int_Accepted_By", int_Accepted_By);

            // str_Check_Number
            str_Check_Number = new (this, "x_str_Check_Number", 202, SqlDbType.NVarChar) {
                Name = "str_Check_Number",
                Expression = "[str_Check_Number]",
                BasicSearchExpression = "[str_Check_Number]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Check_Number]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_Check_Number", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Check_Number", str_Check_Number);

            // bit_Is_Check_Deposited
            bit_Is_Check_Deposited = new (this, "x_bit_Is_Check_Deposited", 11, SqlDbType.Bit) {
                Name = "bit_Is_Check_Deposited",
                Expression = "[bit_Is_Check_Deposited]",
                BasicSearchExpression = "[bit_Is_Check_Deposited]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_Is_Check_Deposited]",
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
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "bit_Is_Check_Deposited", "CustomMsg"),
                IsUpload = false
            };
            bit_Is_Check_Deposited.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_Is_Check_Deposited, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_Is_Check_Deposited, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_Is_Check_Deposited, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_Is_Check_Deposited", bit_Is_Check_Deposited);

            // str_Adjustment_Type
            str_Adjustment_Type = new (this, "x_str_Adjustment_Type", 200, SqlDbType.VarChar) {
                Name = "str_Adjustment_Type",
                Expression = "[str_Adjustment_Type]",
                BasicSearchExpression = "[str_Adjustment_Type]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Adjustment_Type]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_Adjustment_Type", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Adjustment_Type", str_Adjustment_Type);

            // str_Adjust_Sub_Type
            str_Adjust_Sub_Type = new (this, "x_str_Adjust_Sub_Type", 200, SqlDbType.VarChar) {
                Name = "str_Adjust_Sub_Type",
                Expression = "[str_Adjust_Sub_Type]",
                BasicSearchExpression = "[str_Adjust_Sub_Type]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Adjust_Sub_Type]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_Adjust_Sub_Type", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Adjust_Sub_Type", str_Adjust_Sub_Type);

            // bit_Archive
            bit_Archive = new (this, "x_bit_Archive", 11, SqlDbType.Bit) {
                Name = "bit_Archive",
                Expression = "[bit_Archive]",
                BasicSearchExpression = "[bit_Archive]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_Archive]",
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
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "bit_Archive", "CustomMsg"),
                IsUpload = false
            };
            bit_Archive.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_Archive, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_Archive, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_Archive, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_Archive", bit_Archive);

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
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "int_Created_By", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "int_Modified_By", "CustomMsg"),
                IsUpload = false
            };
            int_Modified_By.GetAutoUpdateValue = () => CurrentUserID();
            Fields.Add("int_Modified_By", int_Modified_By);

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
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "date_Modified", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "bit_IsDeleted", "CustomMsg"),
                IsUpload = false
            };
            bit_IsDeleted.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IsDeleted, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsDeleted, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IsDeleted, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            bit_IsDeleted.GetDefault = () => 0;
            Fields.Add("bit_IsDeleted", bit_IsDeleted);

            // str_CardHolder_Address
            str_CardHolder_Address = new (this, "x_str_CardHolder_Address", 202, SqlDbType.NVarChar) {
                Name = "str_CardHolder_Address",
                Expression = "[str_CardHolder_Address]",
                BasicSearchExpression = "[str_CardHolder_Address]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CardHolder_Address]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_CardHolder_Address", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CardHolder_Address", str_CardHolder_Address);

            // str_CH_City
            str_CH_City = new (this, "x_str_CH_City", 202, SqlDbType.NVarChar) {
                Name = "str_CH_City",
                Expression = "[str_CH_City]",
                BasicSearchExpression = "[str_CH_City]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CH_City]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_CH_City", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CH_City", str_CH_City);

            // str_CH_Zip
            str_CH_Zip = new (this, "x_str_CH_Zip", 202, SqlDbType.NVarChar) {
                Name = "str_CH_Zip",
                Expression = "[str_CH_Zip]",
                BasicSearchExpression = "[str_CH_Zip]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CH_Zip]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_CH_Zip", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CH_Zip", str_CH_Zip);

            // int_State
            int_State = new (this, "x_int_State", 3, SqlDbType.Int) {
                Name = "int_State",
                Expression = "[int_State]",
                BasicSearchExpression = "CAST([int_State] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_State]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "int_State", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_State", int_State);

            // bit_IsAuthDotNet
            bit_IsAuthDotNet = new (this, "x_bit_IsAuthDotNet", 11, SqlDbType.Bit) {
                Name = "bit_IsAuthDotNet",
                Expression = "[bit_IsAuthDotNet]",
                BasicSearchExpression = "[bit_IsAuthDotNet]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_IsAuthDotNet]",
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
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "bit_IsAuthDotNet", "CustomMsg"),
                IsUpload = false
            };
            bit_IsAuthDotNet.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IsAuthDotNet, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsAuthDotNet, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IsAuthDotNet, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            bit_IsAuthDotNet.GetDefault = () => 0;
            Fields.Add("bit_IsAuthDotNet", bit_IsAuthDotNet);

            // bit_IsRefund
            bit_IsRefund = new (this, "x_bit_IsRefund", 11, SqlDbType.Bit) {
                Name = "bit_IsRefund",
                Expression = "[bit_IsRefund]",
                BasicSearchExpression = "[bit_IsRefund]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_IsRefund]",
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
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "bit_IsRefund", "CustomMsg"),
                IsUpload = false
            };
            bit_IsRefund.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IsRefund, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsRefund, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IsRefund, "tblBillingInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            bit_IsRefund.GetDefault = () => 0;
            Fields.Add("bit_IsRefund", bit_IsRefund);

            // str_Receipt
            str_Receipt = new (this, "x_str_Receipt", 202, SqlDbType.NVarChar) {
                Name = "str_Receipt",
                Expression = "[str_Receipt]",
                BasicSearchExpression = "[str_Receipt]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Receipt]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_Receipt", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Receipt", str_Receipt);

            // str_TransactionNumber
            str_TransactionNumber = new (this, "x_str_TransactionNumber", 202, SqlDbType.NVarChar) {
                Name = "str_TransactionNumber",
                Expression = "[str_TransactionNumber]",
                BasicSearchExpression = "[str_TransactionNumber]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_TransactionNumber]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_TransactionNumber", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_TransactionNumber", str_TransactionNumber);

            // str_OrderId
            str_OrderId = new (this, "x_str_OrderId", 202, SqlDbType.NVarChar) {
                Name = "str_OrderId",
                Expression = "[str_OrderId]",
                BasicSearchExpression = "[str_OrderId]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_OrderId]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_OrderId", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_OrderId", str_OrderId);

            // str_TransactionTime
            str_TransactionTime = new (this, "x_str_TransactionTime", 200, SqlDbType.VarChar) {
                Name = "str_TransactionTime",
                Expression = "[str_TransactionTime]",
                BasicSearchExpression = "[str_TransactionTime]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_TransactionTime]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_TransactionTime", "CustomMsg"),
                IsUpload = false
            };
            str_TransactionTime.GetAutoUpdateValue = () => CurrentDateTime();
            Fields.Add("str_TransactionTime", str_TransactionTime);

            // int_Location_Id
            int_Location_Id = new (this, "x_int_Location_Id", 3, SqlDbType.Int) {
                Name = "int_Location_Id",
                Expression = "[int_Location_Id]",
                BasicSearchExpression = "CAST([int_Location_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Location_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "int_Location_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Location_Id", int_Location_Id);

            // str_Enrollment_Id
            str_Enrollment_Id = new (this, "x_str_Enrollment_Id", 202, SqlDbType.NVarChar) {
                Name = "str_Enrollment_Id",
                Expression = "[str_Enrollment_Id]",
                BasicSearchExpression = "[str_Enrollment_Id]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Enrollment_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_Enrollment_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Enrollment_Id", str_Enrollment_Id);

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
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_Notes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Notes", str_Notes);

            // str_Payment_Note
            str_Payment_Note = new (this, "x_str_Payment_Note", 202, SqlDbType.NVarChar) {
                Name = "str_Payment_Note",
                Expression = "[str_Payment_Note]",
                BasicSearchExpression = "[str_Payment_Note]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Payment_Note]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "str_Payment_Note", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Payment_Note", str_Payment_Note);

            // int_Package_ID
            int_Package_ID = new (this, "x_int_Package_ID", 3, SqlDbType.Int) {
                Name = "int_Package_ID",
                Expression = "[int_Package_ID]",
                BasicSearchExpression = "CAST([int_Package_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Package_ID]",
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
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "int_Package_ID", "CustomMsg"),
                IsUpload = false
            };
            int_Package_ID.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(int_Package_ID, "tblPackageInfo", false, "int_Package_Id", new List<string> {"int_Package_Id", "str_Package_Name", "", ""}, "", "", new List<string> {}, new List<string> {"x_Package_Name", "x_Price"}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT(CAST([int_Package_Id] AS NVARCHAR),'" + ValueSeparator(1, int_Package_ID) + "',[str_Package_Name])"),
                "en-US" => new Lookup<DbField>(int_Package_ID, "tblPackageInfo", false, "int_Package_Id", new List<string> {"int_Package_Id", "str_Package_Name", "", ""}, "", "", new List<string> {}, new List<string> {"x_Package_Name", "x_Price"}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT(CAST([int_Package_Id] AS NVARCHAR),'" + ValueSeparator(1, int_Package_ID) + "',[str_Package_Name])"),
                _ => new Lookup<DbField>(int_Package_ID, "tblPackageInfo", false, "int_Package_Id", new List<string> {"int_Package_Id", "str_Package_Name", "", ""}, "", "", new List<string> {}, new List<string> {"x_Package_Name", "x_Price"}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT(CAST([int_Package_Id] AS NVARCHAR),'" + ValueSeparator(1, int_Package_ID) + "',[str_Package_Name])")
            };
            Fields.Add("int_Package_ID", int_Package_ID);

            // Package_Name
            Package_Name = new (this, "x_Package_Name", 200, SqlDbType.VarChar) {
                Name = "Package_Name",
                Expression = "[Package_Name]",
                BasicSearchExpression = "[Package_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[Package_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "Package_Name", "CustomMsg"),
                IsUpload = false
            };
            Package_Name.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Package_Name, "tblPackageInfo", false, "str_Package_Name", new List<string> {"str_Package_Name", "", "", ""}, "", "", new List<string> {"x_int_Package_ID"}, new List<string> {}, new List<string> {"int_Package_Id"}, new List<string> {"x_int_Package_Id"}, new List<string> {}, new List<string> {}, "", "", "[str_Package_Name]"),
                "en-US" => new Lookup<DbField>(Package_Name, "tblPackageInfo", false, "str_Package_Name", new List<string> {"str_Package_Name", "", "", ""}, "", "", new List<string> {"x_int_Package_ID"}, new List<string> {}, new List<string> {"int_Package_Id"}, new List<string> {"x_int_Package_Id"}, new List<string> {}, new List<string> {}, "", "", "[str_Package_Name]"),
                _ => new Lookup<DbField>(Package_Name, "tblPackageInfo", false, "str_Package_Name", new List<string> {"str_Package_Name", "", "", ""}, "", "", new List<string> {"x_int_Package_ID"}, new List<string> {}, new List<string> {"int_Package_Id"}, new List<string> {"x_int_Package_Id"}, new List<string> {}, new List<string> {}, "", "", "[str_Package_Name]")
            };
            Fields.Add("Package_Name", Package_Name);

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
                HtmlTag = "SELECT",
                InputTextType = "text",
                Required = true, // Required field
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "Price", "CustomMsg"),
                IsUpload = false
            };
            Price.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Price, "tblPackageInfo", false, "mny_Price", new List<string> {"mny_Price", "", "", ""}, "", "", new List<string> {"x_int_Package_ID"}, new List<string> {}, new List<string> {"int_Package_Id"}, new List<string> {"x_int_Package_Id"}, new List<string> {}, new List<string> {}, "", "", "CAST([mny_Price] AS NVARCHAR)"),
                "en-US" => new Lookup<DbField>(Price, "tblPackageInfo", false, "mny_Price", new List<string> {"mny_Price", "", "", ""}, "", "", new List<string> {"x_int_Package_ID"}, new List<string> {}, new List<string> {"int_Package_Id"}, new List<string> {"x_int_Package_Id"}, new List<string> {}, new List<string> {}, "", "", "CAST([mny_Price] AS NVARCHAR)"),
                _ => new Lookup<DbField>(Price, "tblPackageInfo", false, "mny_Price", new List<string> {"mny_Price", "", "", ""}, "", "", new List<string> {"x_int_Package_ID"}, new List<string> {}, new List<string> {"int_Package_Id"}, new List<string> {"x_int_Package_Id"}, new List<string> {}, new List<string> {}, "", "", "CAST([mny_Price] AS NVARCHAR)")
            };
            Fields.Add("Price", Price);

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
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "AssessmentID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("AssessmentID", AssessmentID);

            // course
            course = new (this, "x_course", 200, SqlDbType.VarChar) {
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "course", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("course", course);

            // institution
            institution = new (this, "x_institution", 200, SqlDbType.VarChar) {
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "institution", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("institution", institution);

            // UniqueIdx
            UniqueIdx = new (this, "x_UniqueIdx", 202, SqlDbType.NVarChar) {
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblBillingInfo", "UniqueIdx", "CustomMsg"),
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
            if (CurrentMasterTable == "tblPotentialStudentInfo") {
                dynamic masterTable = Resolve("tblPotentialStudentInfo")!;
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
            get { // Detail filter
                string detailFilter = "";
                if (CurrentMasterTable == "tblPotentialStudentInfo") {
                    dynamic masterTable = Resolve("tblPotentialStudentInfo")!;
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
            switch (masterTable?.TableVar) {
            case "tblPotentialStudentInfo":
                key = keys["NationalID"] ?? "";
                if (Empty(key)) {
                    if (masterTable.NationalID.Required) // Required field and empty value
                        return ""; // Return empty filter
                    validKeys = false;
                } else if (!validKeys) { // Already has empty key
                    return ""; // Return empty filter
                }
                if (validKeys) {
                    return KeyFilter(masterTable.NationalID, keys["NationalID"], NationalID.DataType, DbId);
                }
                break;
            }
            return null; // All null values and no required fields
        }

        // Detail filter // DN
        public string DetailFilter(dynamic masterTable) // DN
        {
            return masterTable.TableVar switch {
                "tblPotentialStudentInfo" => KeyFilter(NationalID, masterTable.NationalID.DbValue, masterTable.NationalID.DataType, masterTable.DbId),
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
                if (CurrentDetailTable == "tblStudentEnrollment" && tblStudentEnrollment != null) {
                    detailUrl = tblStudentEnrollment.ListUrl + "?" + Config.TableShowMaster + "=" + TableVar;
                    detailUrl += "&" + ForeignKeyUrl("fk_NationalID", NationalID.CurrentValue);
                }
                if (CurrentDetailTable == "qryBillingDetails_v2" && qryBillingDetailsV2 != null) {
                    detailUrl = qryBillingDetailsV2.ListUrl + "?" + Config.TableShowMaster + "=" + TableVar;
                    detailUrl += "&" + ForeignKeyUrl("fk_NationalID", NationalID.CurrentValue);
                }
                if (Empty(detailUrl))
                    detailUrl = "TblBillingInfoList";
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
            get => _sqlFrom ?? "dbo.tblBillingInfo";
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
                int_Bill_ID.SetDbValue(lastInsertedId);
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
                if (!rsaudit.ContainsKey("int_Bill_ID"))
                    rsaudit.Add("int_Bill_ID", rsold["int_Bill_ID"]);
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
                int_Bill_ID.DbValue = row["int_Bill_ID"]; // Set DB value only
                NationalID.DbValue = row["NationalID"]; // Set DB value only
                str_First_Name.DbValue = row["str_First_Name"]; // Set DB value only
                str_Last_Name.DbValue = row["str_Last_Name"]; // Set DB value only
                str_Username.DbValue = row["str_Username"]; // Set DB value only
                int_Student_ID.DbValue = row["int_Student_ID"]; // Set DB value only
                int_Payment_Method.DbValue = row["int_Payment_Method"]; // Set DB value only
                date_Paid.DbValue = row["date_Paid"]; // Set DB value only
                str_ApprovalCode.DbValue = row["str_ApprovalCode"]; // Set DB value only
                Payment_Number.DbValue = row["Payment_Number"]; // Set DB value only
                Pricelist.DbValue = row["Pricelist"]; // Set DB value only
                date_Created.DbValue = row["date_Created"]; // Set DB value only
                str_Amount.DbValue = row["str_Amount"]; // Set DB value only
                str_CC_Holder_Name.DbValue = row["str_CC_Holder_Name"]; // Set DB value only
                str_CC_Number.DbValue = row["str_CC_Number"]; // Set DB value only
                int_CC_ExpMonth.DbValue = row["int_CC_ExpMonth"]; // Set DB value only
                int_CC_ExpYear.DbValue = row["int_CC_ExpYear"]; // Set DB value only
                int_CC_Type.DbValue = row["int_CC_Type"]; // Set DB value only
                str_Card_Id.DbValue = row["str_Card_Id"]; // Set DB value only
                str_CC_ValidationNum.DbValue = row["str_CC_ValidationNum"]; // Set DB value only
                str_reference.DbValue = row["str_reference"]; // Set DB value only
                str_Amount_Pay.DbValue = row["str_Amount_Pay"]; // Set DB value only
                mny_Running_Payments.DbValue = row["mny_Running_Payments"]; // Set DB value only
                mny_Running_Balance.DbValue = row["mny_Running_Balance"]; // Set DB value only
                str_Payment_Reference.DbValue = row["str_Payment_Reference"]; // Set DB value only
                int_Accepted_By.DbValue = row["int_Accepted_By"]; // Set DB value only
                str_Check_Number.DbValue = row["str_Check_Number"]; // Set DB value only
                bit_Is_Check_Deposited.DbValue = (ConvertToBool(row["bit_Is_Check_Deposited"]) ? "1" : "0"); // Set DB value only
                str_Adjustment_Type.DbValue = row["str_Adjustment_Type"]; // Set DB value only
                str_Adjust_Sub_Type.DbValue = row["str_Adjust_Sub_Type"]; // Set DB value only
                bit_Archive.DbValue = (ConvertToBool(row["bit_Archive"]) ? "1" : "0"); // Set DB value only
                int_Created_By.DbValue = row["int_Created_By"]; // Set DB value only
                int_Modified_By.DbValue = row["int_Modified_By"]; // Set DB value only
                date_Modified.DbValue = row["date_Modified"]; // Set DB value only
                bit_IsDeleted.DbValue = (ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"); // Set DB value only
                str_CardHolder_Address.DbValue = row["str_CardHolder_Address"]; // Set DB value only
                str_CH_City.DbValue = row["str_CH_City"]; // Set DB value only
                str_CH_Zip.DbValue = row["str_CH_Zip"]; // Set DB value only
                int_State.DbValue = row["int_State"]; // Set DB value only
                bit_IsAuthDotNet.DbValue = (ConvertToBool(row["bit_IsAuthDotNet"]) ? "1" : "0"); // Set DB value only
                bit_IsRefund.DbValue = (ConvertToBool(row["bit_IsRefund"]) ? "1" : "0"); // Set DB value only
                str_Receipt.DbValue = row["str_Receipt"]; // Set DB value only
                str_TransactionNumber.DbValue = row["str_TransactionNumber"]; // Set DB value only
                str_OrderId.DbValue = row["str_OrderId"]; // Set DB value only
                str_TransactionTime.DbValue = row["str_TransactionTime"]; // Set DB value only
                int_Location_Id.DbValue = row["int_Location_Id"]; // Set DB value only
                str_Enrollment_Id.DbValue = row["str_Enrollment_Id"]; // Set DB value only
                str_Notes.DbValue = row["str_Notes"]; // Set DB value only
                str_Payment_Note.DbValue = row["str_Payment_Note"]; // Set DB value only
                int_Package_ID.DbValue = row["int_Package_ID"]; // Set DB value only
                Package_Name.DbValue = row["Package_Name"]; // Set DB value only
                Price.DbValue = row["Price"]; // Set DB value only
                AssessmentID.DbValue = row["AssessmentID"]; // Set DB value only
                course.DbValue = row["course"]; // Set DB value only
                institution.DbValue = row["institution"]; // Set DB value only
                UniqueIdx.DbValue = row["UniqueIdx"]; // Set DB value only
            } catch {}
        }

        public void DeleteUploadedFiles(Dictionary<string, object> row)
        {
            LoadDbValues(row);
        }

        // Record filter WHERE clause
        private string _sqlKeyFilter => "[int_Bill_ID] = @int_Bill_ID@";

        #pragma warning disable 168, 219
        // Get record filter as string
        public string GetRecordFilter(Dictionary<string, object>? row = null, bool current = false)
        {
            string keyFilter = _sqlKeyFilter;
            object? val = null, result = "";
            val = row?.TryGetValue("int_Bill_ID", out result) ?? false
                ? result
                : !Empty(int_Bill_ID.OldValue) && !current ? int_Bill_ID.OldValue : int_Bill_ID.CurrentValue;
            if (!IsNumeric(val))
                return "0=1"; // Invalid key
            if (val == null)
                return "0=1"; // Invalid key
            keyFilter = keyFilter.Replace("@int_Bill_ID@", AdjustSql(val, DbId)); // Replace key value
            return keyFilter;
        }

        // Get record filter as Dictionary // DN
        public Dictionary<string, object>? GetRowFilterAsDictionary(IDictionary<string, object>? row = null)
        {
            Dictionary<string, object>? keyFilter = new ();
            object? val = null, result;
            val = row?.TryGetValue("int_Bill_ID", out result) ?? false
                ? result
                : !Empty(int_Bill_ID.OldValue) ? int_Bill_ID.OldValue : int_Bill_ID.CurrentValue;
            if (!IsNumeric(val))
                return null; // Invalid key
            if (Empty(val))
                return null; // Invalid key
            keyFilter.Add("int_Bill_ID", val); // Add key value
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
                    return "TblBillingInfoList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "TblBillingInfoView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "TblBillingInfoEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "TblBillingInfoAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "TblBillingInfoList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "TblBillingInfoView",
                Config.ApiAddAction => "TblBillingInfoAdd",
                Config.ApiEditAction => "TblBillingInfoEdit",
                Config.ApiDeleteAction => "TblBillingInfoDelete",
                Config.ApiListAction => "TblBillingInfoList",
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
        public string ListUrl => "TblBillingInfoList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblBillingInfoView", parm);
            else
                url = KeyUrl("TblBillingInfoView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "TblBillingInfoAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "TblBillingInfoAdd?" + parm;
            else
                url = "TblBillingInfoAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblBillingInfoEdit", parm);
            else
                url = KeyUrl("TblBillingInfoEdit", Config.TableShowDetail + "=");
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblBillingInfoList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblBillingInfoAdd", parm);
            else
                url = KeyUrl("TblBillingInfoAdd", Config.TableShowDetail + "=");
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblBillingInfoList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("TblBillingInfoDelete")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
            if (CurrentMasterTable == "tblPotentialStudentInfo" && !url.Contains(Config.TableShowMaster + "=")) {
                url += (url.Contains("?") ? "&" : "?") + Config.TableShowMaster + "=" + CurrentMasterTable;
                url += "&" + ForeignKeyUrl("fk_NationalID", NationalID.SessionValue); // Use Session Value
            }
            return url;
        }

        // Get primary key as JSON
        public string KeyToJson(bool htmlEncode = false)
        {
            string json = "";
            json += "\"int_Bill_ID\":" + ConvertToJson(int_Bill_ID.CurrentValue, "number", true);
            json = "{" + json + "}";
            if (htmlEncode)
                json = HtmlEncode(json);
            return json;
        }

        // Add key value to URL
        public string KeyUrl(string url, string parm = "") { // DN
            if (!IsNull(int_Bill_ID.CurrentValue)) {
                url += "/" + int_Bill_ID.CurrentValue;
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
            val = current ? ConvertToString(int_Bill_ID.CurrentValue) ?? "" : ConvertToString(int_Bill_ID.OldValue) ?? "";
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
            val = row?.TryGetValue("int_Bill_ID", out result) ?? false ? ConvertToString(result) : null;
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
                    int_Bill_ID.CurrentValue = keys[0];
                } else {
                    int_Bill_ID.OldValue = keys[0];
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
                if (RouteValues.TryGetValue("int_Bill_ID", out object? v0)) { // int_Bill_ID // DN
                    key = UrlDecode(v0); // DN
                } else if (IsApi() && !Empty(keyValues)) {
                    key = keyValues[0];
                } else {
                    key = Param("int_Bill_ID");
                }
                keysList.Add(key);
            }
            // Check keys
            foreach (var keys in keysList) {
                if (!IsNumeric(keys)) // int_Bill_ID
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
                    int_Bill_ID.CurrentValue = keys;
                else
                    int_Bill_ID.OldValue = keys;
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
            int_Bill_ID.SetDbValue(dr["int_Bill_ID"]);
            NationalID.SetDbValue(dr["NationalID"]);
            str_First_Name.SetDbValue(dr["str_First_Name"]);
            str_Last_Name.SetDbValue(dr["str_Last_Name"]);
            str_Username.SetDbValue(dr["str_Username"]);
            int_Student_ID.SetDbValue(dr["int_Student_ID"]);
            int_Payment_Method.SetDbValue(dr["int_Payment_Method"]);
            date_Paid.SetDbValue(dr["date_Paid"]);
            str_ApprovalCode.SetDbValue(dr["str_ApprovalCode"]);
            Payment_Number.SetDbValue(dr["Payment_Number"]);
            Pricelist.SetDbValue(dr["Pricelist"]);
            date_Created.SetDbValue(dr["date_Created"]);
            str_Amount.SetDbValue(dr["str_Amount"]);
            str_CC_Holder_Name.SetDbValue(dr["str_CC_Holder_Name"]);
            str_CC_Number.SetDbValue(dr["str_CC_Number"]);
            int_CC_ExpMonth.SetDbValue(dr["int_CC_ExpMonth"]);
            int_CC_ExpYear.SetDbValue(dr["int_CC_ExpYear"]);
            int_CC_Type.SetDbValue(dr["int_CC_Type"]);
            str_Card_Id.SetDbValue(dr["str_Card_Id"]);
            str_CC_ValidationNum.SetDbValue(dr["str_CC_ValidationNum"]);
            str_reference.SetDbValue(dr["str_reference"]);
            str_Amount_Pay.SetDbValue(dr["str_Amount_Pay"]);
            mny_Running_Payments.SetDbValue(dr["mny_Running_Payments"]);
            mny_Running_Balance.SetDbValue(dr["mny_Running_Balance"]);
            str_Payment_Reference.SetDbValue(dr["str_Payment_Reference"]);
            int_Accepted_By.SetDbValue(dr["int_Accepted_By"]);
            str_Check_Number.SetDbValue(dr["str_Check_Number"]);
            bit_Is_Check_Deposited.SetDbValue(ConvertToBool(dr["bit_Is_Check_Deposited"]) ? "1" : "0");
            str_Adjustment_Type.SetDbValue(dr["str_Adjustment_Type"]);
            str_Adjust_Sub_Type.SetDbValue(dr["str_Adjust_Sub_Type"]);
            bit_Archive.SetDbValue(ConvertToBool(dr["bit_Archive"]) ? "1" : "0");
            int_Created_By.SetDbValue(dr["int_Created_By"]);
            int_Modified_By.SetDbValue(dr["int_Modified_By"]);
            date_Modified.SetDbValue(dr["date_Modified"]);
            bit_IsDeleted.SetDbValue(ConvertToBool(dr["bit_IsDeleted"]) ? "1" : "0");
            str_CardHolder_Address.SetDbValue(dr["str_CardHolder_Address"]);
            str_CH_City.SetDbValue(dr["str_CH_City"]);
            str_CH_Zip.SetDbValue(dr["str_CH_Zip"]);
            int_State.SetDbValue(dr["int_State"]);
            bit_IsAuthDotNet.SetDbValue(ConvertToBool(dr["bit_IsAuthDotNet"]) ? "1" : "0");
            bit_IsRefund.SetDbValue(ConvertToBool(dr["bit_IsRefund"]) ? "1" : "0");
            str_Receipt.SetDbValue(dr["str_Receipt"]);
            str_TransactionNumber.SetDbValue(dr["str_TransactionNumber"]);
            str_OrderId.SetDbValue(dr["str_OrderId"]);
            str_TransactionTime.SetDbValue(dr["str_TransactionTime"]);
            int_Location_Id.SetDbValue(dr["int_Location_Id"]);
            str_Enrollment_Id.SetDbValue(dr["str_Enrollment_Id"]);
            str_Notes.SetDbValue(dr["str_Notes"]);
            str_Payment_Note.SetDbValue(dr["str_Payment_Note"]);
            int_Package_ID.SetDbValue(dr["int_Package_ID"]);
            Package_Name.SetDbValue(dr["Package_Name"]);
            Price.SetDbValue(dr["Price"]);
            AssessmentID.SetDbValue(dr["AssessmentID"]);
            course.SetDbValue(dr["course"]);
            institution.SetDbValue(dr["institution"]);
            UniqueIdx.SetDbValue(dr["UniqueIdx"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "TblBillingInfoList";
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

            // int_Bill_ID

            // NationalID

            // str_First_Name

            // str_Last_Name

            // str_Username

            // int_Student_ID

            // int_Payment_Method

            // date_Paid
            date_Paid.CellCssStyle = "white-space: nowrap;";

            // str_ApprovalCode

            // Payment_Number

            // Pricelist

            // date_Created

            // str_Amount

            // str_CC_Holder_Name

            // str_CC_Number

            // int_CC_ExpMonth

            // int_CC_ExpYear

            // int_CC_Type

            // str_Card_Id

            // str_CC_ValidationNum

            // str_reference

            // str_Amount_Pay

            // mny_Running_Payments

            // mny_Running_Balance

            // str_Payment_Reference

            // int_Accepted_By

            // str_Check_Number

            // bit_Is_Check_Deposited

            // str_Adjustment_Type

            // str_Adjust_Sub_Type

            // bit_Archive

            // int_Created_By

            // int_Modified_By

            // date_Modified

            // bit_IsDeleted

            // str_CardHolder_Address

            // str_CH_City

            // str_CH_Zip

            // int_State

            // bit_IsAuthDotNet

            // bit_IsRefund

            // str_Receipt

            // str_TransactionNumber

            // str_OrderId

            // str_TransactionTime

            // int_Location_Id

            // str_Enrollment_Id

            // str_Notes

            // str_Payment_Note

            // int_Package_ID

            // Package_Name

            // Price

            // AssessmentID

            // course

            // institution

            // UniqueIdx

            // int_Bill_ID
            int_Bill_ID.ViewValue = int_Bill_ID.CurrentValue;
            int_Bill_ID.ViewCustomAttributes = "";

            // NationalID
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

            // str_First_Name
            str_First_Name.ViewValue = ConvertToString(str_First_Name.CurrentValue); // DN
            str_First_Name.ViewCustomAttributes = "";

            // str_Last_Name
            str_Last_Name.ViewValue = ConvertToString(str_Last_Name.CurrentValue); // DN
            str_Last_Name.ViewCustomAttributes = "";

            // str_Username
            curVal = ConvertToString(str_Username.CurrentValue);
            if (!Empty(curVal)) {
                if (str_Username.Lookup != null && IsDictionary(str_Username.Lookup?.Options) && str_Username.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    str_Username.ViewValue = str_Username.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[str_Username]", "=", str_Username.CurrentValue, DataType.String, "");
                    sqlWrk = str_Username.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && str_Username.Lookup != null) { // Lookup values found
                        var listwrk = str_Username.Lookup?.RenderViewRow(rswrk[0]);
                        str_Username.ViewValue = str_Username.HighlightLookup(ConvertToString(rswrk[0]), str_Username.DisplayValue(listwrk));
                    } else {
                        str_Username.ViewValue = str_Username.CurrentValue;
                    }
                }
            } else {
                str_Username.ViewValue = DbNullValue;
            }
            str_Username.ViewCustomAttributes = "";

            // int_Student_ID
            curVal = ConvertToString(int_Student_ID.CurrentValue);
            if (!Empty(curVal)) {
                if (int_Student_ID.Lookup != null && IsDictionary(int_Student_ID.Lookup?.Options) && int_Student_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_Student_ID.ViewValue = int_Student_ID.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[int_Student_ID]", "=", int_Student_ID.CurrentValue, DataType.Number, "");
                    sqlWrk = int_Student_ID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && int_Student_ID.Lookup != null) { // Lookup values found
                        var listwrk = int_Student_ID.Lookup?.RenderViewRow(rswrk[0]);
                        int_Student_ID.ViewValue = int_Student_ID.HighlightLookup(ConvertToString(rswrk[0]), int_Student_ID.DisplayValue(listwrk));
                    } else {
                        int_Student_ID.ViewValue = FormatNumber(int_Student_ID.CurrentValue, int_Student_ID.FormatPattern);
                    }
                }
            } else {
                int_Student_ID.ViewValue = DbNullValue;
            }
            int_Student_ID.ViewCustomAttributes = "";

            // int_Payment_Method
            if (!Empty(int_Payment_Method.CurrentValue)) {
                int_Payment_Method.ViewValue = int_Payment_Method.HighlightLookup(ConvertToString(int_Payment_Method.CurrentValue), int_Payment_Method.OptionCaption(ConvertToString(int_Payment_Method.CurrentValue)));
            } else {
                int_Payment_Method.ViewValue = DbNullValue;
            }
            int_Payment_Method.ViewCustomAttributes = "";

            // date_Paid
            date_Paid.ViewValue = date_Paid.CurrentValue;
            date_Paid.ViewValue = FormatDateTime(date_Paid.ViewValue, date_Paid.FormatPattern);
            date_Paid.ViewCustomAttributes = "";

            // str_ApprovalCode
            str_ApprovalCode.ViewValue = ConvertToString(str_ApprovalCode.CurrentValue); // DN
            str_ApprovalCode.ViewCustomAttributes = "";

            // Payment_Number
            Payment_Number.ViewValue = Payment_Number.CurrentValue;
            Payment_Number.ViewValue = FormatNumber(Payment_Number.ViewValue, Payment_Number.FormatPattern);
            Payment_Number.CellCssStyle += "text-align: center;";
            Payment_Number.ViewCustomAttributes = "";

            // Pricelist
            Pricelist.ViewValue = Pricelist.CurrentValue;
            Pricelist.ViewValue = FormatNumber(Pricelist.ViewValue, Pricelist.FormatPattern);
            Pricelist.CellCssStyle += "text-align: right;";
            Pricelist.ViewCustomAttributes = "";

            // date_Created
            date_Created.ViewValue = date_Created.CurrentValue;
            date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
            date_Created.ViewCustomAttributes = "";

            // str_Amount
            str_Amount.ViewValue = ConvertToString(str_Amount.CurrentValue); // DN
            str_Amount.ViewCustomAttributes = "";

            // str_CC_Holder_Name
            str_CC_Holder_Name.ViewValue = ConvertToString(str_CC_Holder_Name.CurrentValue); // DN
            str_CC_Holder_Name.ViewCustomAttributes = "";

            // str_CC_Number
            str_CC_Number.ViewValue = ConvertToString(str_CC_Number.CurrentValue); // DN
            str_CC_Number.ViewCustomAttributes = "";

            // int_CC_ExpMonth
            int_CC_ExpMonth.ViewValue = int_CC_ExpMonth.CurrentValue;
            int_CC_ExpMonth.ViewValue = FormatNumber(int_CC_ExpMonth.ViewValue, int_CC_ExpMonth.FormatPattern);
            int_CC_ExpMonth.ViewCustomAttributes = "";

            // int_CC_ExpYear
            int_CC_ExpYear.ViewValue = int_CC_ExpYear.CurrentValue;
            int_CC_ExpYear.ViewValue = FormatNumber(int_CC_ExpYear.ViewValue, int_CC_ExpYear.FormatPattern);
            int_CC_ExpYear.ViewCustomAttributes = "";

            // int_CC_Type
            int_CC_Type.ViewValue = int_CC_Type.CurrentValue;
            int_CC_Type.ViewValue = FormatNumber(int_CC_Type.ViewValue, int_CC_Type.FormatPattern);
            int_CC_Type.ViewCustomAttributes = "";

            // str_Card_Id
            str_Card_Id.ViewValue = ConvertToString(str_Card_Id.CurrentValue); // DN
            str_Card_Id.ViewCustomAttributes = "";

            // str_CC_ValidationNum
            str_CC_ValidationNum.ViewValue = ConvertToString(str_CC_ValidationNum.CurrentValue); // DN
            str_CC_ValidationNum.ViewCustomAttributes = "";

            // str_reference
            str_reference.ViewValue = ConvertToString(str_reference.CurrentValue); // DN
            str_reference.ViewCustomAttributes = "";

            // str_Amount_Pay
            str_Amount_Pay.ViewValue = ConvertToString(str_Amount_Pay.CurrentValue); // DN
            str_Amount_Pay.CellCssStyle += "text-align: right;";
            str_Amount_Pay.ViewCustomAttributes = "";

            // mny_Running_Payments
            mny_Running_Payments.ViewValue = mny_Running_Payments.CurrentValue;
            mny_Running_Payments.ViewValue = FormatNumber(mny_Running_Payments.ViewValue, mny_Running_Payments.FormatPattern);
            mny_Running_Payments.CellCssStyle += "text-align: right;";
            mny_Running_Payments.ViewCustomAttributes = "";

            // mny_Running_Balance
            mny_Running_Balance.ViewValue = mny_Running_Balance.CurrentValue;
            mny_Running_Balance.ViewValue = FormatNumber(mny_Running_Balance.ViewValue, mny_Running_Balance.FormatPattern);
            mny_Running_Balance.CellCssStyle += "text-align: right;";
            mny_Running_Balance.ViewCustomAttributes = "";

            // str_Payment_Reference
            str_Payment_Reference.ViewValue = ConvertToString(str_Payment_Reference.CurrentValue); // DN
            str_Payment_Reference.ViewCustomAttributes = "";

            // int_Accepted_By
            int_Accepted_By.ViewValue = int_Accepted_By.CurrentValue;
            int_Accepted_By.ViewValue = FormatNumber(int_Accepted_By.ViewValue, int_Accepted_By.FormatPattern);
            int_Accepted_By.ViewCustomAttributes = "";

            // str_Check_Number
            str_Check_Number.ViewValue = ConvertToString(str_Check_Number.CurrentValue); // DN
            str_Check_Number.ViewCustomAttributes = "";

            // bit_Is_Check_Deposited
            if (ConvertToBool(bit_Is_Check_Deposited.CurrentValue)) {
                bit_Is_Check_Deposited.ViewValue = bit_Is_Check_Deposited.TagCaption(1) != "" ? bit_Is_Check_Deposited.TagCaption(1) : "Yes";
            } else {
                bit_Is_Check_Deposited.ViewValue = bit_Is_Check_Deposited.TagCaption(2) != "" ? bit_Is_Check_Deposited.TagCaption(2) : "No";
            }
            bit_Is_Check_Deposited.ViewCustomAttributes = "";

            // str_Adjustment_Type
            str_Adjustment_Type.ViewValue = ConvertToString(str_Adjustment_Type.CurrentValue); // DN
            str_Adjustment_Type.ViewCustomAttributes = "";

            // str_Adjust_Sub_Type
            str_Adjust_Sub_Type.ViewValue = ConvertToString(str_Adjust_Sub_Type.CurrentValue); // DN
            str_Adjust_Sub_Type.ViewCustomAttributes = "";

            // bit_Archive
            if (ConvertToBool(bit_Archive.CurrentValue)) {
                bit_Archive.ViewValue = bit_Archive.TagCaption(1) != "" ? bit_Archive.TagCaption(1) : "Yes";
            } else {
                bit_Archive.ViewValue = bit_Archive.TagCaption(2) != "" ? bit_Archive.TagCaption(2) : "No";
            }
            bit_Archive.ViewCustomAttributes = "";

            // int_Created_By
            int_Created_By.ViewValue = int_Created_By.CurrentValue;
            int_Created_By.ViewValue = FormatNumber(int_Created_By.ViewValue, int_Created_By.FormatPattern);
            int_Created_By.ViewCustomAttributes = "";

            // int_Modified_By
            int_Modified_By.ViewValue = int_Modified_By.CurrentValue;
            int_Modified_By.ViewValue = FormatNumber(int_Modified_By.ViewValue, int_Modified_By.FormatPattern);
            int_Modified_By.ViewCustomAttributes = "";

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

            // str_CardHolder_Address
            str_CardHolder_Address.ViewValue = ConvertToString(str_CardHolder_Address.CurrentValue); // DN
            str_CardHolder_Address.ViewCustomAttributes = "";

            // str_CH_City
            str_CH_City.ViewValue = ConvertToString(str_CH_City.CurrentValue); // DN
            str_CH_City.ViewCustomAttributes = "";

            // str_CH_Zip
            str_CH_Zip.ViewValue = ConvertToString(str_CH_Zip.CurrentValue); // DN
            str_CH_Zip.ViewCustomAttributes = "";

            // int_State
            int_State.ViewValue = int_State.CurrentValue;
            int_State.ViewValue = FormatNumber(int_State.ViewValue, int_State.FormatPattern);
            int_State.ViewCustomAttributes = "";

            // bit_IsAuthDotNet
            if (ConvertToBool(bit_IsAuthDotNet.CurrentValue)) {
                bit_IsAuthDotNet.ViewValue = bit_IsAuthDotNet.TagCaption(1) != "" ? bit_IsAuthDotNet.TagCaption(1) : "Yes";
            } else {
                bit_IsAuthDotNet.ViewValue = bit_IsAuthDotNet.TagCaption(2) != "" ? bit_IsAuthDotNet.TagCaption(2) : "No";
            }
            bit_IsAuthDotNet.ViewCustomAttributes = "";

            // bit_IsRefund
            if (ConvertToBool(bit_IsRefund.CurrentValue)) {
                bit_IsRefund.ViewValue = bit_IsRefund.TagCaption(1) != "" ? bit_IsRefund.TagCaption(1) : "Yes";
            } else {
                bit_IsRefund.ViewValue = bit_IsRefund.TagCaption(2) != "" ? bit_IsRefund.TagCaption(2) : "No";
            }
            bit_IsRefund.ViewCustomAttributes = "";

            // str_Receipt
            str_Receipt.ViewValue = ConvertToString(str_Receipt.CurrentValue); // DN
            str_Receipt.ViewCustomAttributes = "";

            // str_TransactionNumber
            str_TransactionNumber.ViewValue = ConvertToString(str_TransactionNumber.CurrentValue); // DN
            str_TransactionNumber.ViewCustomAttributes = "";

            // str_OrderId
            str_OrderId.ViewValue = ConvertToString(str_OrderId.CurrentValue); // DN
            str_OrderId.ViewCustomAttributes = "";

            // str_TransactionTime
            str_TransactionTime.ViewValue = str_TransactionTime.CurrentValue;
            str_TransactionTime.ViewCustomAttributes = "";

            // int_Location_Id
            int_Location_Id.ViewValue = int_Location_Id.CurrentValue;
            int_Location_Id.ViewValue = FormatNumber(int_Location_Id.ViewValue, int_Location_Id.FormatPattern);
            int_Location_Id.ViewCustomAttributes = "";

            // str_Enrollment_Id
            str_Enrollment_Id.ViewValue = ConvertToString(str_Enrollment_Id.CurrentValue); // DN
            str_Enrollment_Id.ViewCustomAttributes = "";

            // str_Notes
            str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
            str_Notes.ViewCustomAttributes = "";

            // str_Payment_Note
            str_Payment_Note.ViewValue = str_Payment_Note.CurrentValue;
            str_Payment_Note.ViewCustomAttributes = "";

            // int_Package_ID
            curVal = ConvertToString(int_Package_ID.CurrentValue);
            if (!Empty(curVal)) {
                if (int_Package_ID.Lookup != null && IsDictionary(int_Package_ID.Lookup?.Options) && int_Package_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_Package_ID.ViewValue = int_Package_ID.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[int_Package_Id]", "=", int_Package_ID.CurrentValue, DataType.Number, "");
                    sqlWrk = int_Package_ID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && int_Package_ID.Lookup != null) { // Lookup values found
                        var listwrk = int_Package_ID.Lookup?.RenderViewRow(rswrk[0]);
                        int_Package_ID.ViewValue = int_Package_ID.HighlightLookup(ConvertToString(rswrk[0]), int_Package_ID.DisplayValue(listwrk));
                    } else {
                        int_Package_ID.ViewValue = FormatNumber(int_Package_ID.CurrentValue, int_Package_ID.FormatPattern);
                    }
                }
            } else {
                int_Package_ID.ViewValue = DbNullValue;
            }
            int_Package_ID.ViewCustomAttributes = "";

            // Package_Name
            Package_Name.ViewValue = ConvertToString(Package_Name.CurrentValue); // DN
            curVal = ConvertToString(Package_Name.CurrentValue);
            if (!Empty(curVal)) {
                if (Package_Name.Lookup != null && IsDictionary(Package_Name.Lookup?.Options) && Package_Name.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    Package_Name.ViewValue = Package_Name.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[str_Package_Name]", "=", Package_Name.CurrentValue, DataType.String, "");
                    sqlWrk = Package_Name.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && Package_Name.Lookup != null) { // Lookup values found
                        var listwrk = Package_Name.Lookup?.RenderViewRow(rswrk[0]);
                        Package_Name.ViewValue = Package_Name.HighlightLookup(ConvertToString(rswrk[0]), Package_Name.DisplayValue(listwrk));
                    } else {
                        Package_Name.ViewValue = Package_Name.CurrentValue;
                    }
                }
            } else {
                Package_Name.ViewValue = DbNullValue;
            }
            Package_Name.ViewCustomAttributes = "";

            // Price
            curVal = ConvertToString(Price.CurrentValue);
            if (!Empty(curVal)) {
                if (Price.Lookup != null && IsDictionary(Price.Lookup?.Options) && Price.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    Price.ViewValue = Price.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[mny_Price]", "=", Price.CurrentValue, DataType.Number, "");
                    sqlWrk = Price.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && Price.Lookup != null) { // Lookup values found
                        var listwrk = Price.Lookup?.RenderViewRow(rswrk[0]);
                        Price.ViewValue = Price.HighlightLookup(ConvertToString(rswrk[0]), Price.DisplayValue(listwrk));
                    } else {
                        Price.ViewValue = FormatCurrency(Price.CurrentValue, Price.FormatPattern);
                    }
                }
            } else {
                Price.ViewValue = DbNullValue;
            }
            Price.ViewCustomAttributes = "";

            // AssessmentID
            AssessmentID.ViewValue = AssessmentID.CurrentValue;
            AssessmentID.ViewValue = FormatNumber(AssessmentID.ViewValue, AssessmentID.FormatPattern);
            AssessmentID.ViewCustomAttributes = "";

            // course
            course.ViewValue = ConvertToString(course.CurrentValue); // DN
            course.ViewCustomAttributes = "";

            // institution
            institution.ViewValue = ConvertToString(institution.CurrentValue); // DN
            institution.ViewCustomAttributes = "";

            // UniqueIdx
            UniqueIdx.ViewValue = ConvertToString(UniqueIdx.CurrentValue); // DN
            UniqueIdx.ViewCustomAttributes = "";

            // int_Bill_ID
            int_Bill_ID.HrefValue = "";
            int_Bill_ID.TooltipValue = "";

            // NationalID
            NationalID.HrefValue = "";
            NationalID.TooltipValue = "";

            // str_First_Name
            str_First_Name.HrefValue = "";
            str_First_Name.TooltipValue = "";

            // str_Last_Name
            str_Last_Name.HrefValue = "";
            str_Last_Name.TooltipValue = "";

            // str_Username
            str_Username.HrefValue = "";
            str_Username.TooltipValue = "";

            // int_Student_ID
            int_Student_ID.HrefValue = "";
            int_Student_ID.TooltipValue = "";

            // int_Payment_Method
            int_Payment_Method.HrefValue = "";
            int_Payment_Method.TooltipValue = "";

            // date_Paid
            date_Paid.HrefValue = "";
            date_Paid.TooltipValue = "";

            // str_ApprovalCode
            str_ApprovalCode.HrefValue = "";
            str_ApprovalCode.TooltipValue = "";

            // Payment_Number
            Payment_Number.HrefValue = "";
            Payment_Number.TooltipValue = "";

            // Pricelist
            Pricelist.HrefValue = "";
            Pricelist.TooltipValue = "";

            // date_Created
            date_Created.HrefValue = "";
            date_Created.TooltipValue = "";

            // str_Amount
            str_Amount.HrefValue = "";
            str_Amount.TooltipValue = "";

            // str_CC_Holder_Name
            str_CC_Holder_Name.HrefValue = "";
            str_CC_Holder_Name.TooltipValue = "";

            // str_CC_Number
            str_CC_Number.HrefValue = "";
            str_CC_Number.TooltipValue = "";

            // int_CC_ExpMonth
            int_CC_ExpMonth.HrefValue = "";
            int_CC_ExpMonth.TooltipValue = "";

            // int_CC_ExpYear
            int_CC_ExpYear.HrefValue = "";
            int_CC_ExpYear.TooltipValue = "";

            // int_CC_Type
            int_CC_Type.HrefValue = "";
            int_CC_Type.TooltipValue = "";

            // str_Card_Id
            str_Card_Id.HrefValue = "";
            str_Card_Id.TooltipValue = "";

            // str_CC_ValidationNum
            str_CC_ValidationNum.HrefValue = "";
            str_CC_ValidationNum.TooltipValue = "";

            // str_reference
            str_reference.HrefValue = "";
            str_reference.TooltipValue = "";

            // str_Amount_Pay
            str_Amount_Pay.HrefValue = "";
            str_Amount_Pay.TooltipValue = "";

            // mny_Running_Payments
            mny_Running_Payments.HrefValue = "";
            mny_Running_Payments.TooltipValue = "";

            // mny_Running_Balance
            mny_Running_Balance.HrefValue = "";
            mny_Running_Balance.TooltipValue = "";

            // str_Payment_Reference
            str_Payment_Reference.HrefValue = "";
            str_Payment_Reference.TooltipValue = "";

            // int_Accepted_By
            int_Accepted_By.HrefValue = "";
            int_Accepted_By.TooltipValue = "";

            // str_Check_Number
            str_Check_Number.HrefValue = "";
            str_Check_Number.TooltipValue = "";

            // bit_Is_Check_Deposited
            bit_Is_Check_Deposited.HrefValue = "";
            bit_Is_Check_Deposited.TooltipValue = "";

            // str_Adjustment_Type
            str_Adjustment_Type.HrefValue = "";
            str_Adjustment_Type.TooltipValue = "";

            // str_Adjust_Sub_Type
            str_Adjust_Sub_Type.HrefValue = "";
            str_Adjust_Sub_Type.TooltipValue = "";

            // bit_Archive
            bit_Archive.HrefValue = "";
            bit_Archive.TooltipValue = "";

            // int_Created_By
            int_Created_By.HrefValue = "";
            int_Created_By.TooltipValue = "";

            // int_Modified_By
            int_Modified_By.HrefValue = "";
            int_Modified_By.TooltipValue = "";

            // date_Modified
            date_Modified.HrefValue = "";
            date_Modified.TooltipValue = "";

            // bit_IsDeleted
            bit_IsDeleted.HrefValue = "";
            bit_IsDeleted.TooltipValue = "";

            // str_CardHolder_Address
            str_CardHolder_Address.HrefValue = "";
            str_CardHolder_Address.TooltipValue = "";

            // str_CH_City
            str_CH_City.HrefValue = "";
            str_CH_City.TooltipValue = "";

            // str_CH_Zip
            str_CH_Zip.HrefValue = "";
            str_CH_Zip.TooltipValue = "";

            // int_State
            int_State.HrefValue = "";
            int_State.TooltipValue = "";

            // bit_IsAuthDotNet
            bit_IsAuthDotNet.HrefValue = "";
            bit_IsAuthDotNet.TooltipValue = "";

            // bit_IsRefund
            bit_IsRefund.HrefValue = "";
            bit_IsRefund.TooltipValue = "";

            // str_Receipt
            str_Receipt.HrefValue = "";
            str_Receipt.TooltipValue = "";

            // str_TransactionNumber
            str_TransactionNumber.HrefValue = "";
            str_TransactionNumber.TooltipValue = "";

            // str_OrderId
            str_OrderId.HrefValue = "";
            str_OrderId.TooltipValue = "";

            // str_TransactionTime
            str_TransactionTime.HrefValue = "";
            str_TransactionTime.TooltipValue = "";

            // int_Location_Id
            int_Location_Id.HrefValue = "";
            int_Location_Id.TooltipValue = "";

            // str_Enrollment_Id
            str_Enrollment_Id.HrefValue = "";
            str_Enrollment_Id.TooltipValue = "";

            // str_Notes
            str_Notes.HrefValue = "";
            str_Notes.TooltipValue = "";

            // str_Payment_Note
            str_Payment_Note.HrefValue = "";
            str_Payment_Note.TooltipValue = "";

            // int_Package_ID
            int_Package_ID.HrefValue = "";
            int_Package_ID.TooltipValue = "";

            // Package_Name
            Package_Name.HrefValue = "";
            Package_Name.TooltipValue = "";

            // Price
            Price.HrefValue = "";
            Price.TooltipValue = "";

            // AssessmentID
            AssessmentID.HrefValue = "";
            AssessmentID.TooltipValue = "";

            // course
            course.HrefValue = "";
            course.TooltipValue = "";

            // institution
            institution.HrefValue = "";
            institution.TooltipValue = "";

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

            // int_Bill_ID
            int_Bill_ID.SetupEditAttributes();
            int_Bill_ID.EditValue = int_Bill_ID.CurrentValue;
            int_Bill_ID.ViewCustomAttributes = "";

            // NationalID
            NationalID.SetupEditAttributes();
            curVal = ConvertToString(NationalID.CurrentValue);
            if (!Empty(curVal)) {
                if (NationalID.Lookup != null && IsDictionary(NationalID.Lookup?.Options) && NationalID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    NationalID.EditValue = NationalID.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[NationalID]", "=", NationalID.CurrentValue, DataType.Number, "");
                    sqlWrk = NationalID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && NationalID.Lookup != null) { // Lookup values found
                        var listwrk = NationalID.Lookup?.RenderViewRow(rswrk[0]);
                        NationalID.EditValue = NationalID.HighlightLookup(ConvertToString(rswrk[0]), NationalID.DisplayValue(listwrk));
                    } else {
                        NationalID.EditValue = NationalID.CurrentValue;
                    }
                }
            } else {
                NationalID.EditValue = DbNullValue;
            }
            NationalID.ViewCustomAttributes = "";

            // str_First_Name
            str_First_Name.SetupEditAttributes();
            str_First_Name.EditValue = ConvertToString(str_First_Name.CurrentValue); // DN
            str_First_Name.ViewCustomAttributes = "";

            // str_Last_Name
            str_Last_Name.SetupEditAttributes();
            str_Last_Name.EditValue = ConvertToString(str_Last_Name.CurrentValue); // DN
            str_Last_Name.ViewCustomAttributes = "";

            // str_Username
            str_Username.SetupEditAttributes();
            if (!Security.IsAdmin && Security.IsLoggedIn && !UserIDAllow("info")) { // Non system admin
                str_Username.CurrentValue = Empty(str_Username.CurrentValue) ? CurrentUserID() : str_Username.CurrentValue;
            } else {
                str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);
            }

            // int_Student_ID
            int_Student_ID.SetupEditAttributes();
            int_Student_ID.PlaceHolder = RemoveHtml(int_Student_ID.Caption);
            if (!Empty(int_Student_ID.EditValue) && IsNumeric(int_Student_ID.EditValue))
                int_Student_ID.EditValue = FormatNumber(int_Student_ID.EditValue, null);

            // int_Payment_Method
            int_Payment_Method.SetupEditAttributes();
            int_Payment_Method.EditValue = int_Payment_Method.Options(true);
            int_Payment_Method.PlaceHolder = RemoveHtml(int_Payment_Method.Caption);
            if (!Empty(int_Payment_Method.EditValue) && IsNumeric(int_Payment_Method.EditValue))
                int_Payment_Method.EditValue = FormatNumber(int_Payment_Method.EditValue, null);

            // date_Paid
            date_Paid.SetupEditAttributes();
            date_Paid.EditValue = FormatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern); // DN
            date_Paid.PlaceHolder = RemoveHtml(date_Paid.Caption);

            // str_ApprovalCode
            str_ApprovalCode.SetupEditAttributes();
            if (!str_ApprovalCode.Raw)
                str_ApprovalCode.CurrentValue = HtmlDecode(str_ApprovalCode.CurrentValue);
            str_ApprovalCode.EditValue = HtmlEncode(str_ApprovalCode.CurrentValue);
            str_ApprovalCode.PlaceHolder = RemoveHtml(str_ApprovalCode.Caption);

            // Payment_Number
            Payment_Number.SetupEditAttributes();
            Payment_Number.EditValue = Payment_Number.CurrentValue; // DN
            Payment_Number.PlaceHolder = RemoveHtml(Payment_Number.Caption);
            if (!Empty(Payment_Number.EditValue) && IsNumeric(Payment_Number.EditValue))
                Payment_Number.EditValue = FormatNumber(Payment_Number.EditValue, null);

            // Pricelist
            Pricelist.SetupEditAttributes();
            Pricelist.EditValue = Pricelist.CurrentValue; // DN
            Pricelist.PlaceHolder = RemoveHtml(Pricelist.Caption);
            if (!Empty(Pricelist.EditValue) && IsNumeric(Pricelist.EditValue))
                Pricelist.EditValue = FormatNumber(Pricelist.EditValue, null);

            // date_Created

            // str_Amount
            str_Amount.SetupEditAttributes();
            if (!str_Amount.Raw)
                str_Amount.CurrentValue = HtmlDecode(str_Amount.CurrentValue);
            str_Amount.EditValue = HtmlEncode(str_Amount.CurrentValue);
            str_Amount.PlaceHolder = RemoveHtml(str_Amount.Caption);

            // str_CC_Holder_Name
            str_CC_Holder_Name.SetupEditAttributes();
            if (!str_CC_Holder_Name.Raw)
                str_CC_Holder_Name.CurrentValue = HtmlDecode(str_CC_Holder_Name.CurrentValue);
            str_CC_Holder_Name.EditValue = HtmlEncode(str_CC_Holder_Name.CurrentValue);
            str_CC_Holder_Name.PlaceHolder = RemoveHtml(str_CC_Holder_Name.Caption);

            // str_CC_Number
            str_CC_Number.SetupEditAttributes();
            if (!str_CC_Number.Raw)
                str_CC_Number.CurrentValue = HtmlDecode(str_CC_Number.CurrentValue);
            str_CC_Number.EditValue = HtmlEncode(str_CC_Number.CurrentValue);
            str_CC_Number.PlaceHolder = RemoveHtml(str_CC_Number.Caption);

            // int_CC_ExpMonth
            int_CC_ExpMonth.SetupEditAttributes();
            int_CC_ExpMonth.EditValue = int_CC_ExpMonth.CurrentValue; // DN
            int_CC_ExpMonth.PlaceHolder = RemoveHtml(int_CC_ExpMonth.Caption);
            if (!Empty(int_CC_ExpMonth.EditValue) && IsNumeric(int_CC_ExpMonth.EditValue))
                int_CC_ExpMonth.EditValue = FormatNumber(int_CC_ExpMonth.EditValue, null);

            // int_CC_ExpYear
            int_CC_ExpYear.SetupEditAttributes();
            int_CC_ExpYear.EditValue = int_CC_ExpYear.CurrentValue; // DN
            int_CC_ExpYear.PlaceHolder = RemoveHtml(int_CC_ExpYear.Caption);
            if (!Empty(int_CC_ExpYear.EditValue) && IsNumeric(int_CC_ExpYear.EditValue))
                int_CC_ExpYear.EditValue = FormatNumber(int_CC_ExpYear.EditValue, null);

            // int_CC_Type
            int_CC_Type.SetupEditAttributes();
            int_CC_Type.EditValue = int_CC_Type.CurrentValue; // DN
            int_CC_Type.PlaceHolder = RemoveHtml(int_CC_Type.Caption);
            if (!Empty(int_CC_Type.EditValue) && IsNumeric(int_CC_Type.EditValue))
                int_CC_Type.EditValue = FormatNumber(int_CC_Type.EditValue, null);

            // str_Card_Id
            str_Card_Id.SetupEditAttributes();
            if (!str_Card_Id.Raw)
                str_Card_Id.CurrentValue = HtmlDecode(str_Card_Id.CurrentValue);
            str_Card_Id.EditValue = HtmlEncode(str_Card_Id.CurrentValue);
            str_Card_Id.PlaceHolder = RemoveHtml(str_Card_Id.Caption);

            // str_CC_ValidationNum
            str_CC_ValidationNum.SetupEditAttributes();
            if (!str_CC_ValidationNum.Raw)
                str_CC_ValidationNum.CurrentValue = HtmlDecode(str_CC_ValidationNum.CurrentValue);
            str_CC_ValidationNum.EditValue = HtmlEncode(str_CC_ValidationNum.CurrentValue);
            str_CC_ValidationNum.PlaceHolder = RemoveHtml(str_CC_ValidationNum.Caption);

            // str_reference
            str_reference.SetupEditAttributes();
            if (!str_reference.Raw)
                str_reference.CurrentValue = HtmlDecode(str_reference.CurrentValue);
            str_reference.EditValue = HtmlEncode(str_reference.CurrentValue);
            str_reference.PlaceHolder = RemoveHtml(str_reference.Caption);

            // str_Amount_Pay
            str_Amount_Pay.SetupEditAttributes();
            if (!str_Amount_Pay.Raw)
                str_Amount_Pay.CurrentValue = HtmlDecode(str_Amount_Pay.CurrentValue);
            str_Amount_Pay.EditValue = HtmlEncode(str_Amount_Pay.CurrentValue);
            str_Amount_Pay.PlaceHolder = RemoveHtml(str_Amount_Pay.Caption);

            // mny_Running_Payments
            mny_Running_Payments.SetupEditAttributes();
            mny_Running_Payments.EditValue = mny_Running_Payments.CurrentValue; // DN
            mny_Running_Payments.PlaceHolder = RemoveHtml(mny_Running_Payments.Caption);
            if (!Empty(mny_Running_Payments.EditValue) && IsNumeric(mny_Running_Payments.EditValue))
                mny_Running_Payments.EditValue = FormatNumber(mny_Running_Payments.EditValue, null);

            // mny_Running_Balance
            mny_Running_Balance.SetupEditAttributes();
            mny_Running_Balance.EditValue = mny_Running_Balance.CurrentValue;
            mny_Running_Balance.EditValue = FormatNumber(mny_Running_Balance.EditValue, mny_Running_Balance.FormatPattern);
            mny_Running_Balance.CellCssStyle += "text-align: right;";
            mny_Running_Balance.ViewCustomAttributes = "";

            // str_Payment_Reference
            str_Payment_Reference.SetupEditAttributes();
            if (!str_Payment_Reference.Raw)
                str_Payment_Reference.CurrentValue = HtmlDecode(str_Payment_Reference.CurrentValue);
            str_Payment_Reference.EditValue = HtmlEncode(str_Payment_Reference.CurrentValue);
            str_Payment_Reference.PlaceHolder = RemoveHtml(str_Payment_Reference.Caption);

            // int_Accepted_By

            // str_Check_Number
            str_Check_Number.SetupEditAttributes();
            if (!str_Check_Number.Raw)
                str_Check_Number.CurrentValue = HtmlDecode(str_Check_Number.CurrentValue);
            str_Check_Number.EditValue = HtmlEncode(str_Check_Number.CurrentValue);
            str_Check_Number.PlaceHolder = RemoveHtml(str_Check_Number.Caption);

            // bit_Is_Check_Deposited
            bit_Is_Check_Deposited.EditValue = bit_Is_Check_Deposited.Options(false);
            bit_Is_Check_Deposited.PlaceHolder = RemoveHtml(bit_Is_Check_Deposited.Caption);

            // str_Adjustment_Type
            str_Adjustment_Type.SetupEditAttributes();
            if (!str_Adjustment_Type.Raw)
                str_Adjustment_Type.CurrentValue = HtmlDecode(str_Adjustment_Type.CurrentValue);
            str_Adjustment_Type.EditValue = HtmlEncode(str_Adjustment_Type.CurrentValue);
            str_Adjustment_Type.PlaceHolder = RemoveHtml(str_Adjustment_Type.Caption);

            // str_Adjust_Sub_Type
            str_Adjust_Sub_Type.SetupEditAttributes();
            if (!str_Adjust_Sub_Type.Raw)
                str_Adjust_Sub_Type.CurrentValue = HtmlDecode(str_Adjust_Sub_Type.CurrentValue);
            str_Adjust_Sub_Type.EditValue = HtmlEncode(str_Adjust_Sub_Type.CurrentValue);
            str_Adjust_Sub_Type.PlaceHolder = RemoveHtml(str_Adjust_Sub_Type.Caption);

            // bit_Archive
            bit_Archive.EditValue = bit_Archive.Options(false);
            bit_Archive.PlaceHolder = RemoveHtml(bit_Archive.Caption);

            // int_Created_By
            int_Created_By.SetupEditAttributes();
            int_Created_By.EditValue = int_Created_By.CurrentValue; // DN
            int_Created_By.PlaceHolder = RemoveHtml(int_Created_By.Caption);
            if (!Empty(int_Created_By.EditValue) && IsNumeric(int_Created_By.EditValue))
                int_Created_By.EditValue = FormatNumber(int_Created_By.EditValue, null);

            // int_Modified_By

            // date_Modified

            // bit_IsDeleted
            bit_IsDeleted.EditValue = bit_IsDeleted.Options(false);
            bit_IsDeleted.PlaceHolder = RemoveHtml(bit_IsDeleted.Caption);

            // str_CardHolder_Address
            str_CardHolder_Address.SetupEditAttributes();
            if (!str_CardHolder_Address.Raw)
                str_CardHolder_Address.CurrentValue = HtmlDecode(str_CardHolder_Address.CurrentValue);
            str_CardHolder_Address.EditValue = HtmlEncode(str_CardHolder_Address.CurrentValue);
            str_CardHolder_Address.PlaceHolder = RemoveHtml(str_CardHolder_Address.Caption);

            // str_CH_City
            str_CH_City.SetupEditAttributes();
            if (!str_CH_City.Raw)
                str_CH_City.CurrentValue = HtmlDecode(str_CH_City.CurrentValue);
            str_CH_City.EditValue = HtmlEncode(str_CH_City.CurrentValue);
            str_CH_City.PlaceHolder = RemoveHtml(str_CH_City.Caption);

            // str_CH_Zip
            str_CH_Zip.SetupEditAttributes();
            if (!str_CH_Zip.Raw)
                str_CH_Zip.CurrentValue = HtmlDecode(str_CH_Zip.CurrentValue);
            str_CH_Zip.EditValue = HtmlEncode(str_CH_Zip.CurrentValue);
            str_CH_Zip.PlaceHolder = RemoveHtml(str_CH_Zip.Caption);

            // int_State
            int_State.SetupEditAttributes();
            int_State.EditValue = int_State.CurrentValue; // DN
            int_State.PlaceHolder = RemoveHtml(int_State.Caption);
            if (!Empty(int_State.EditValue) && IsNumeric(int_State.EditValue))
                int_State.EditValue = FormatNumber(int_State.EditValue, null);

            // bit_IsAuthDotNet
            bit_IsAuthDotNet.EditValue = bit_IsAuthDotNet.Options(false);
            bit_IsAuthDotNet.PlaceHolder = RemoveHtml(bit_IsAuthDotNet.Caption);

            // bit_IsRefund
            bit_IsRefund.EditValue = bit_IsRefund.Options(false);
            bit_IsRefund.PlaceHolder = RemoveHtml(bit_IsRefund.Caption);

            // str_Receipt
            str_Receipt.SetupEditAttributes();
            if (!str_Receipt.Raw)
                str_Receipt.CurrentValue = HtmlDecode(str_Receipt.CurrentValue);
            str_Receipt.EditValue = HtmlEncode(str_Receipt.CurrentValue);
            str_Receipt.PlaceHolder = RemoveHtml(str_Receipt.Caption);

            // str_TransactionNumber
            str_TransactionNumber.SetupEditAttributes();
            if (!str_TransactionNumber.Raw)
                str_TransactionNumber.CurrentValue = HtmlDecode(str_TransactionNumber.CurrentValue);
            str_TransactionNumber.EditValue = HtmlEncode(str_TransactionNumber.CurrentValue);
            str_TransactionNumber.PlaceHolder = RemoveHtml(str_TransactionNumber.Caption);

            // str_OrderId
            str_OrderId.SetupEditAttributes();
            if (!str_OrderId.Raw)
                str_OrderId.CurrentValue = HtmlDecode(str_OrderId.CurrentValue);
            str_OrderId.EditValue = HtmlEncode(str_OrderId.CurrentValue);
            str_OrderId.PlaceHolder = RemoveHtml(str_OrderId.Caption);

            // str_TransactionTime

            // int_Location_Id
            int_Location_Id.SetupEditAttributes();
            int_Location_Id.EditValue = int_Location_Id.CurrentValue; // DN
            int_Location_Id.PlaceHolder = RemoveHtml(int_Location_Id.Caption);
            if (!Empty(int_Location_Id.EditValue) && IsNumeric(int_Location_Id.EditValue))
                int_Location_Id.EditValue = FormatNumber(int_Location_Id.EditValue, null);

            // str_Enrollment_Id
            str_Enrollment_Id.SetupEditAttributes();
            if (!str_Enrollment_Id.Raw)
                str_Enrollment_Id.CurrentValue = HtmlDecode(str_Enrollment_Id.CurrentValue);
            str_Enrollment_Id.EditValue = HtmlEncode(str_Enrollment_Id.CurrentValue);
            str_Enrollment_Id.PlaceHolder = RemoveHtml(str_Enrollment_Id.Caption);

            // str_Notes
            str_Notes.SetupEditAttributes();
            if (!str_Notes.Raw)
                str_Notes.CurrentValue = HtmlDecode(str_Notes.CurrentValue);
            str_Notes.EditValue = HtmlEncode(str_Notes.CurrentValue);
            str_Notes.PlaceHolder = RemoveHtml(str_Notes.Caption);

            // str_Payment_Note
            str_Payment_Note.SetupEditAttributes();
            str_Payment_Note.EditValue = str_Payment_Note.CurrentValue; // DN
            str_Payment_Note.PlaceHolder = RemoveHtml(str_Payment_Note.Caption);

            // int_Package_ID
            int_Package_ID.SetupEditAttributes();
            int_Package_ID.PlaceHolder = RemoveHtml(int_Package_ID.Caption);
            if (!Empty(int_Package_ID.EditValue) && IsNumeric(int_Package_ID.EditValue))
                int_Package_ID.EditValue = FormatNumber(int_Package_ID.EditValue, null);

            // Package_Name
            Package_Name.SetupEditAttributes();
            Package_Name.EditValue = ConvertToString(Package_Name.CurrentValue); // DN
            curVal = ConvertToString(Package_Name.CurrentValue);
            if (!Empty(curVal)) {
                if (Package_Name.Lookup != null && IsDictionary(Package_Name.Lookup?.Options) && Package_Name.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    Package_Name.EditValue = Package_Name.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[str_Package_Name]", "=", Package_Name.CurrentValue, DataType.String, "");
                    sqlWrk = Package_Name.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && Package_Name.Lookup != null) { // Lookup values found
                        var listwrk = Package_Name.Lookup?.RenderViewRow(rswrk[0]);
                        Package_Name.EditValue = Package_Name.HighlightLookup(ConvertToString(rswrk[0]), Package_Name.DisplayValue(listwrk));
                    } else {
                        Package_Name.EditValue = Package_Name.CurrentValue;
                    }
                }
            } else {
                Package_Name.EditValue = DbNullValue;
            }
            Package_Name.ViewCustomAttributes = "";

            // Price
            Price.SetupEditAttributes();
            curVal = ConvertToString(Price.CurrentValue);
            if (!Empty(curVal)) {
                if (Price.Lookup != null && IsDictionary(Price.Lookup?.Options) && Price.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    Price.EditValue = Price.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[mny_Price]", "=", Price.CurrentValue, DataType.Number, "");
                    sqlWrk = Price.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && Price.Lookup != null) { // Lookup values found
                        var listwrk = Price.Lookup?.RenderViewRow(rswrk[0]);
                        Price.EditValue = Price.HighlightLookup(ConvertToString(rswrk[0]), Price.DisplayValue(listwrk));
                    } else {
                        Price.EditValue = FormatCurrency(Price.CurrentValue, Price.FormatPattern);
                    }
                }
            } else {
                Price.EditValue = DbNullValue;
            }
            Price.ViewCustomAttributes = "";

            // AssessmentID
            AssessmentID.SetupEditAttributes();
            AssessmentID.EditValue = AssessmentID.CurrentValue; // DN
            AssessmentID.PlaceHolder = RemoveHtml(AssessmentID.Caption);
            if (!Empty(AssessmentID.EditValue) && IsNumeric(AssessmentID.EditValue))
                AssessmentID.EditValue = FormatNumber(AssessmentID.EditValue, null);

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
            if (!doc.ExportCustom) {
                // Write header
                doc.ExportTableHeader();
                if (doc.Horizontal) { // Horizontal format, write header
                    doc.BeginExportRow();
                    if (exportType == "view") {
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(str_First_Name);
                        doc.ExportCaption(str_Last_Name);
                        doc.ExportCaption(int_Payment_Method);
                        doc.ExportCaption(date_Paid);
                        doc.ExportCaption(str_ApprovalCode);
                        doc.ExportCaption(str_Amount_Pay);
                        doc.ExportCaption(mny_Running_Payments);
                        doc.ExportCaption(mny_Running_Balance);
                        doc.ExportCaption(str_TransactionTime);
                        doc.ExportCaption(str_Payment_Note);
                        doc.ExportCaption(Package_Name);
                        doc.ExportCaption(Price);
                        doc.ExportCaption(course);
                        doc.ExportCaption(institution);
                    } else {
                        doc.ExportCaption(int_Bill_ID);
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(str_First_Name);
                        doc.ExportCaption(str_Last_Name);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(int_Student_ID);
                        doc.ExportCaption(int_Payment_Method);
                        doc.ExportCaption(date_Paid);
                        doc.ExportCaption(str_ApprovalCode);
                        doc.ExportCaption(Payment_Number);
                        doc.ExportCaption(Pricelist);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(str_Amount);
                        doc.ExportCaption(str_CC_Holder_Name);
                        doc.ExportCaption(str_CC_Number);
                        doc.ExportCaption(int_CC_ExpMonth);
                        doc.ExportCaption(int_CC_ExpYear);
                        doc.ExportCaption(int_CC_Type);
                        doc.ExportCaption(str_Card_Id);
                        doc.ExportCaption(str_CC_ValidationNum);
                        doc.ExportCaption(str_reference);
                        doc.ExportCaption(str_Amount_Pay);
                        doc.ExportCaption(mny_Running_Payments);
                        doc.ExportCaption(mny_Running_Balance);
                        doc.ExportCaption(str_Payment_Reference);
                        doc.ExportCaption(int_Accepted_By);
                        doc.ExportCaption(str_Check_Number);
                        doc.ExportCaption(bit_Is_Check_Deposited);
                        doc.ExportCaption(str_Adjustment_Type);
                        doc.ExportCaption(str_Adjust_Sub_Type);
                        doc.ExportCaption(bit_Archive);
                        doc.ExportCaption(int_Created_By);
                        doc.ExportCaption(int_Modified_By);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(bit_IsDeleted);
                        doc.ExportCaption(str_CardHolder_Address);
                        doc.ExportCaption(str_CH_City);
                        doc.ExportCaption(str_CH_Zip);
                        doc.ExportCaption(int_State);
                        doc.ExportCaption(bit_IsAuthDotNet);
                        doc.ExportCaption(bit_IsRefund);
                        doc.ExportCaption(str_Receipt);
                        doc.ExportCaption(str_TransactionNumber);
                        doc.ExportCaption(str_OrderId);
                        doc.ExportCaption(str_TransactionTime);
                        doc.ExportCaption(int_Location_Id);
                        doc.ExportCaption(str_Enrollment_Id);
                        doc.ExportCaption(str_Notes);
                        doc.ExportCaption(str_Payment_Note);
                        doc.ExportCaption(int_Package_ID);
                        doc.ExportCaption(Package_Name);
                        doc.ExportCaption(Price);
                        doc.ExportCaption(AssessmentID);
                        doc.ExportCaption(course);
                        doc.ExportCaption(institution);
                        doc.ExportCaption(UniqueIdx);
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
                            await doc.ExportField(NationalID);
                            await doc.ExportField(str_First_Name);
                            await doc.ExportField(str_Last_Name);
                            await doc.ExportField(int_Payment_Method);
                            await doc.ExportField(date_Paid);
                            await doc.ExportField(str_ApprovalCode);
                            await doc.ExportField(str_Amount_Pay);
                            await doc.ExportField(mny_Running_Payments);
                            await doc.ExportField(mny_Running_Balance);
                            await doc.ExportField(str_TransactionTime);
                            await doc.ExportField(str_Payment_Note);
                            await doc.ExportField(Package_Name);
                            await doc.ExportField(Price);
                            await doc.ExportField(course);
                            await doc.ExportField(institution);
                        } else {
                            await doc.ExportField(int_Bill_ID);
                            await doc.ExportField(NationalID);
                            await doc.ExportField(str_First_Name);
                            await doc.ExportField(str_Last_Name);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(int_Student_ID);
                            await doc.ExportField(int_Payment_Method);
                            await doc.ExportField(date_Paid);
                            await doc.ExportField(str_ApprovalCode);
                            await doc.ExportField(Payment_Number);
                            await doc.ExportField(Pricelist);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(str_Amount);
                            await doc.ExportField(str_CC_Holder_Name);
                            await doc.ExportField(str_CC_Number);
                            await doc.ExportField(int_CC_ExpMonth);
                            await doc.ExportField(int_CC_ExpYear);
                            await doc.ExportField(int_CC_Type);
                            await doc.ExportField(str_Card_Id);
                            await doc.ExportField(str_CC_ValidationNum);
                            await doc.ExportField(str_reference);
                            await doc.ExportField(str_Amount_Pay);
                            await doc.ExportField(mny_Running_Payments);
                            await doc.ExportField(mny_Running_Balance);
                            await doc.ExportField(str_Payment_Reference);
                            await doc.ExportField(int_Accepted_By);
                            await doc.ExportField(str_Check_Number);
                            await doc.ExportField(bit_Is_Check_Deposited);
                            await doc.ExportField(str_Adjustment_Type);
                            await doc.ExportField(str_Adjust_Sub_Type);
                            await doc.ExportField(bit_Archive);
                            await doc.ExportField(int_Created_By);
                            await doc.ExportField(int_Modified_By);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(bit_IsDeleted);
                            await doc.ExportField(str_CardHolder_Address);
                            await doc.ExportField(str_CH_City);
                            await doc.ExportField(str_CH_Zip);
                            await doc.ExportField(int_State);
                            await doc.ExportField(bit_IsAuthDotNet);
                            await doc.ExportField(bit_IsRefund);
                            await doc.ExportField(str_Receipt);
                            await doc.ExportField(str_TransactionNumber);
                            await doc.ExportField(str_OrderId);
                            await doc.ExportField(str_TransactionTime);
                            await doc.ExportField(int_Location_Id);
                            await doc.ExportField(str_Enrollment_Id);
                            await doc.ExportField(str_Notes);
                            await doc.ExportField(str_Payment_Note);
                            await doc.ExportField(int_Package_ID);
                            await doc.ExportField(Package_Name);
                            await doc.ExportField(Price);
                            await doc.ExportField(AssessmentID);
                            await doc.ExportField(course);
                            await doc.ExportField(institution);
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
            string sql = "SELECT " + masterfld.Expression + " FROM dbo.tblBillingInfo";
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
            if (currentMasterTable == "tblPotentialStudentInfo") {
                filterWrk = tblPotentialStudentInfo?.AddUserIDFilter(filterWrk);
            }
            return filterWrk ?? "";
        }

        // Add detail User ID filter
        public string AddDetailUserIDFilter(string filter, string currentMasterTable)
        {
            string filterWrk = filter;
            if (currentMasterTable == "tblPotentialStudentInfo") {
                if (tblPotentialStudentInfo != null && !tblPotentialStudentInfo.UserIDAllow())
                    AddFilter(ref filterWrk, tblPotentialStudentInfo.GetUserIDSubquery(NationalID, tblPotentialStudentInfo.NationalID));
            }
            return filterWrk;
        }

        // Table filter
        private string? _tableFilter = null;

        public string TableFilter
        {
            get => _tableFilter ?? "[NationalID] is not Null";
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
        public async Task WriteAuditTrailLog(string log) => await WriteAuditTrailAsync(CurrentUser(), log, "tblBillingInfo");

        // Write audit trail (add page)
        public async Task WriteAuditTrailOnAdd(IDictionary<string, object> rs)
        {
            if (!AuditTrailOnAdd)
                return;
            string table = "tblBillingInfo";

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
            string table = "tblBillingInfo";

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
            string table = "tblBillingInfo";

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

        // Send email after add success
        public async Task<string> SendEmailOnAdd(Dictionary<string, object> rs)
        {
            string table = "tblBillingInfo";
            string subject = table + " " + Language.Phrase("RecordInserted");
            string action = Language.Phrase("ActionInserted");

            // Get key value
            string key = GetKey(rs); // DN
            var email = new Email();
            await email.Load(Config.EmailNotifyTemplate);
            email.ReplaceSender(Config.SenderEmail); // Replace Sender
            email.ReplaceRecipient(Config.RecipientEmail); // Replace Recipient
            email.ReplaceSubject(subject); // Replace Subject
            email.ReplaceContent("<!--table-->", table);
            email.ReplaceContent("<!--key-->", key);
            email.ReplaceContent("<!--action-->", action);
            bool emailSent = false;
            if (EmailSending(email, ConvertToDictionary<dynamic>(new { rsnew = rs })))
                emailSent = await email.SendAsync();

            // Send email result
            return !emailSent ? email.SendError : "OK"; // DN
        }

        // Send email after update success
        public async Task<string> SendEmailOnEdit(Dictionary<string, object> rsold, Dictionary<string, object> rsnew)
        {
            string table = "tblBillingInfo";
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
