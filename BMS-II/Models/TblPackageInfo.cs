namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblPackageInfo
    /// </summary>
    [MaybeNull]
    public static TblPackageInfo tblPackageInfo
    {
        get => HttpData.Resolve<TblPackageInfo>("tblPackageInfo");
        set => HttpData["tblPackageInfo"] = value;
    }

    /// <summary>
    /// Table class for tblPackageInfo
    /// </summary>
    public class TblPackageInfo : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> int_Package_Id;

        public readonly DbField<SqlDbType> str_Package_Name;

        public readonly DbField<SqlDbType> str_Package_Code;

        public readonly DbField<SqlDbType> int_Status;

        public readonly DbField<SqlDbType> str_Discount;

        public readonly DbField<SqlDbType> mny_Price;

        public readonly DbField<SqlDbType> str_Notes;

        public readonly DbField<SqlDbType> bit_IswebSignUp;

        public readonly DbField<SqlDbType> str_Items;

        public readonly DbField<SqlDbType> int_Created_By;

        public readonly DbField<SqlDbType> int_Modified_By;

        public readonly DbField<SqlDbType> date_Created;

        public readonly DbField<SqlDbType> date_Modified;

        public readonly DbField<SqlDbType> bit_IsDeleted;

        public readonly DbField<SqlDbType> str_WebDescription;

        public readonly DbField<SqlDbType> bit_PortalPurchase;

        public readonly DbField<SqlDbType> str_WebName;

        public readonly DbField<SqlDbType> bit_ExtraChk1;

        public readonly DbField<SqlDbType> bit_ExtraChk2;

        public readonly DbField<SqlDbType> str_ExtraDrpDown1;

        public readonly DbField<SqlDbType> str_ExtraDrpDown2;

        public readonly DbField<SqlDbType> str_Extratxt1;

        public readonly DbField<SqlDbType> str_Extratxt2;

        public readonly DbField<SqlDbType> is_Show;

        public readonly DbField<SqlDbType> is_ShowGridColumn;

        public readonly DbField<SqlDbType> rowIndex;

        public readonly DbField<SqlDbType> bit_referral;

        public readonly DbField<SqlDbType> str_Locations;

        public readonly DbField<SqlDbType> str_PackageType;

        public readonly DbField<SqlDbType> int_ParentClass_Id;

        public readonly DbField<SqlDbType> str_CRcostHour;

        public readonly DbField<SqlDbType> str_BTWcostHour;

        public readonly DbField<SqlDbType> bit_OfferSpanishServices;

        public readonly DbField<SqlDbType> ByPassCRSelectionCentralizedOE;

        public readonly DbField<SqlDbType> str_WebNameArabic;

        public readonly DbField<SqlDbType> str_WebDescriptionArabic;

        public readonly DbField<SqlDbType> PackageContractType;

        public readonly DbField<SqlDbType> blob_path;

        public readonly DbField<SqlDbType> StudentSignXCordinate;

        public readonly DbField<SqlDbType> StudentSignYCordinate;

        public readonly DbField<SqlDbType> ParentSignXCordinate;

        public readonly DbField<SqlDbType> ParentSignYCordinate;

        public readonly DbField<SqlDbType> ParentSignPageNo;

        public readonly DbField<SqlDbType> StudentSignPageNo;

        public readonly DbField<SqlDbType> int_CDLProgramType;

        public readonly DbField<SqlDbType> int_CDLEndorsementCode;

        public readonly DbField<SqlDbType> int_CDLClassroom;

        public readonly DbField<SqlDbType> int_CDLRange;

        public readonly DbField<SqlDbType> int_CDLRoad;

        public readonly DbField<SqlDbType> bit_TPR_Package;

        public readonly DbField<SqlDbType> licenseTypeId;

        public readonly DbField<SqlDbType> bit_IsServiceForCertification;

        public readonly DbField<SqlDbType> intMinAgeYearToEnroll;

        public readonly DbField<SqlDbType> intMinAgeMonthToEnroll;

        public readonly DbField<SqlDbType> intMaxAgeYearToEnroll;

        public readonly DbField<SqlDbType> intMaxAgeMonthToEnroll;

        public readonly DbField<SqlDbType> intCompletionDeadlineYear;

        public readonly DbField<SqlDbType> intCompletionDeadlineMonth;

        public readonly DbField<SqlDbType> intCompletionDeadlineDay;

        public readonly DbField<SqlDbType> intCompletionDeadlineFrom;

        public readonly DbField<SqlDbType> bit_IsTexable;

        public readonly DbField<SqlDbType> str_Base_price;

        public readonly DbField<SqlDbType> str_Tax;

        // Constructor
        public TblPackageInfo()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "tblPackageInfo";
            Name = "tblPackageInfo";
            Type = "TABLE";
            UpdateTable = "dbo.tblPackageInfo"; // Update Table
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
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "int_Package_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Package_Id", int_Package_Id);

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
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_Package_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Package_Name", str_Package_Name);

            // str_Package_Code
            str_Package_Code = new (this, "x_str_Package_Code", 202, SqlDbType.NVarChar) {
                Name = "str_Package_Code",
                Expression = "[str_Package_Code]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Package_Code]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Package_Code]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_Package_Code", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Package_Code", str_Package_Code);

            // int_Status
            int_Status = new (this, "x_int_Status", 3, SqlDbType.Int) {
                Name = "int_Status",
                Expression = "[int_Status]",
                BasicSearchExpression = "CAST([int_Status] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Status]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "int_Status", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Status", int_Status);

            // str_Discount
            str_Discount = new (this, "x_str_Discount", 200, SqlDbType.VarChar) {
                Name = "str_Discount",
                Expression = "[str_Discount]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Discount]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Discount]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_Discount", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Discount", str_Discount);

            // mny_Price
            mny_Price = new (this, "x_mny_Price", 6, SqlDbType.Money) {
                Name = "mny_Price",
                Expression = "[mny_Price]",
                BasicSearchExpression = "CAST([mny_Price] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[mny_Price]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "mny_Price", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("mny_Price", mny_Price);

            // str_Notes
            str_Notes = new (this, "x_str_Notes", 202, SqlDbType.NVarChar) {
                Name = "str_Notes",
                Expression = "[str_Notes]",
                UseBasicSearch = true,
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
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_Notes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Notes", str_Notes);

            // bit_IswebSignUp
            bit_IswebSignUp = new (this, "x_bit_IswebSignUp", 11, SqlDbType.Bit) {
                Name = "bit_IswebSignUp",
                Expression = "[bit_IswebSignUp]",
                BasicSearchExpression = "[bit_IswebSignUp]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_IswebSignUp]",
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
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "bit_IswebSignUp", "CustomMsg"),
                IsUpload = false
            };
            bit_IswebSignUp.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IswebSignUp, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IswebSignUp, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IswebSignUp, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_IswebSignUp", bit_IswebSignUp);

            // str_Items
            str_Items = new (this, "x_str_Items", 200, SqlDbType.VarChar) {
                Name = "str_Items",
                Expression = "[str_Items]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Items]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Items]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_Items", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Items", str_Items);

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
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "int_Created_By", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "int_Modified_By", "CustomMsg"),
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
                HtmlTag = "TEXT",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "date_Created", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "date_Modified", "CustomMsg"),
                IsUpload = false
            };
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
                Nullable = false, // NOT NULL field
                DataType = DataType.Boolean,
                OptionCount = 2,
                SearchOperators = new () { "=", "<>" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "bit_IsDeleted", "CustomMsg"),
                IsUpload = false
            };
            bit_IsDeleted.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IsDeleted, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsDeleted, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IsDeleted, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_IsDeleted", bit_IsDeleted);

            // str_WebDescription
            str_WebDescription = new (this, "x_str_WebDescription", 203, SqlDbType.NText) {
                Name = "str_WebDescription",
                Expression = "[str_WebDescription]",
                BasicSearchExpression = "[str_WebDescription]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_WebDescription]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_WebDescription", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_WebDescription", str_WebDescription);

            // bit_PortalPurchase
            bit_PortalPurchase = new (this, "x_bit_PortalPurchase", 11, SqlDbType.Bit) {
                Name = "bit_PortalPurchase",
                Expression = "[bit_PortalPurchase]",
                BasicSearchExpression = "[bit_PortalPurchase]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_PortalPurchase]",
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
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "bit_PortalPurchase", "CustomMsg"),
                IsUpload = false
            };
            bit_PortalPurchase.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_PortalPurchase, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_PortalPurchase, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_PortalPurchase, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_PortalPurchase", bit_PortalPurchase);

            // str_WebName
            str_WebName = new (this, "x_str_WebName", 200, SqlDbType.VarChar) {
                Name = "str_WebName",
                Expression = "[str_WebName]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_WebName]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_WebName]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_WebName", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_WebName", str_WebName);

            // bit_ExtraChk1
            bit_ExtraChk1 = new (this, "x_bit_ExtraChk1", 11, SqlDbType.Bit) {
                Name = "bit_ExtraChk1",
                Expression = "[bit_ExtraChk1]",
                BasicSearchExpression = "[bit_ExtraChk1]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_ExtraChk1]",
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
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "bit_ExtraChk1", "CustomMsg"),
                IsUpload = false
            };
            bit_ExtraChk1.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_ExtraChk1, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_ExtraChk1, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_ExtraChk1, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_ExtraChk1", bit_ExtraChk1);

            // bit_ExtraChk2
            bit_ExtraChk2 = new (this, "x_bit_ExtraChk2", 11, SqlDbType.Bit) {
                Name = "bit_ExtraChk2",
                Expression = "[bit_ExtraChk2]",
                BasicSearchExpression = "[bit_ExtraChk2]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_ExtraChk2]",
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
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "bit_ExtraChk2", "CustomMsg"),
                IsUpload = false
            };
            bit_ExtraChk2.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_ExtraChk2, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_ExtraChk2, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_ExtraChk2, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_ExtraChk2", bit_ExtraChk2);

            // str_ExtraDrpDown1
            str_ExtraDrpDown1 = new (this, "x_str_ExtraDrpDown1", 202, SqlDbType.NVarChar) {
                Name = "str_ExtraDrpDown1",
                Expression = "[str_ExtraDrpDown1]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_ExtraDrpDown1]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_ExtraDrpDown1]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_ExtraDrpDown1", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_ExtraDrpDown1", str_ExtraDrpDown1);

            // str_ExtraDrpDown2
            str_ExtraDrpDown2 = new (this, "x_str_ExtraDrpDown2", 202, SqlDbType.NVarChar) {
                Name = "str_ExtraDrpDown2",
                Expression = "[str_ExtraDrpDown2]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_ExtraDrpDown2]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_ExtraDrpDown2]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_ExtraDrpDown2", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_ExtraDrpDown2", str_ExtraDrpDown2);

            // str_Extratxt1
            str_Extratxt1 = new (this, "x_str_Extratxt1", 202, SqlDbType.NVarChar) {
                Name = "str_Extratxt1",
                Expression = "[str_Extratxt1]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Extratxt1]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Extratxt1]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_Extratxt1", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Extratxt1", str_Extratxt1);

            // str_Extratxt2
            str_Extratxt2 = new (this, "x_str_Extratxt2", 202, SqlDbType.NVarChar) {
                Name = "str_Extratxt2",
                Expression = "[str_Extratxt2]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Extratxt2]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Extratxt2]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_Extratxt2", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Extratxt2", str_Extratxt2);

            // is_Show
            is_Show = new (this, "x_is_Show", 11, SqlDbType.Bit) {
                Name = "is_Show",
                Expression = "[is_Show]",
                BasicSearchExpression = "[is_Show]",
                DateTimeFormat = -1,
                VirtualExpression = "[is_Show]",
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
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "is_Show", "CustomMsg"),
                IsUpload = false
            };
            is_Show.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(is_Show, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(is_Show, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(is_Show, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("is_Show", is_Show);

            // is_ShowGridColumn
            is_ShowGridColumn = new (this, "x_is_ShowGridColumn", 11, SqlDbType.Bit) {
                Name = "is_ShowGridColumn",
                Expression = "[is_ShowGridColumn]",
                BasicSearchExpression = "[is_ShowGridColumn]",
                DateTimeFormat = -1,
                VirtualExpression = "[is_ShowGridColumn]",
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
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "is_ShowGridColumn", "CustomMsg"),
                IsUpload = false
            };
            is_ShowGridColumn.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(is_ShowGridColumn, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(is_ShowGridColumn, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(is_ShowGridColumn, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("is_ShowGridColumn", is_ShowGridColumn);

            // rowIndex
            rowIndex = new (this, "x_rowIndex", 200, SqlDbType.VarChar) {
                Name = "rowIndex",
                Expression = "[rowIndex]",
                UseBasicSearch = true,
                BasicSearchExpression = "[rowIndex]",
                DateTimeFormat = -1,
                VirtualExpression = "[rowIndex]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "rowIndex", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("rowIndex", rowIndex);

            // bit_referral
            bit_referral = new (this, "x_bit_referral", 11, SqlDbType.Bit) {
                Name = "bit_referral",
                Expression = "[bit_referral]",
                BasicSearchExpression = "[bit_referral]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_referral]",
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
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "bit_referral", "CustomMsg"),
                IsUpload = false
            };
            bit_referral.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_referral, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_referral, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_referral, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_referral", bit_referral);

            // str_Locations
            str_Locations = new (this, "x_str_Locations", 201, SqlDbType.Text) {
                Name = "str_Locations",
                Expression = "[str_Locations]",
                BasicSearchExpression = "[str_Locations]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Locations]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_Locations", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Locations", str_Locations);

            // str_PackageType
            str_PackageType = new (this, "x_str_PackageType", 200, SqlDbType.VarChar) {
                Name = "str_PackageType",
                Expression = "[str_PackageType]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_PackageType]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_PackageType]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_PackageType", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_PackageType", str_PackageType);

            // int_ParentClass_Id
            int_ParentClass_Id = new (this, "x_int_ParentClass_Id", 3, SqlDbType.Int) {
                Name = "int_ParentClass_Id",
                Expression = "[int_ParentClass_Id]",
                BasicSearchExpression = "CAST([int_ParentClass_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_ParentClass_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "int_ParentClass_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_ParentClass_Id", int_ParentClass_Id);

            // str_CRcostHour
            str_CRcostHour = new (this, "x_str_CRcostHour", 131, SqlDbType.Decimal) {
                Name = "str_CRcostHour",
                Expression = "[str_CRcostHour]",
                BasicSearchExpression = "CAST([str_CRcostHour] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CRcostHour]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_CRcostHour", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CRcostHour", str_CRcostHour);

            // str_BTWcostHour
            str_BTWcostHour = new (this, "x_str_BTWcostHour", 131, SqlDbType.Decimal) {
                Name = "str_BTWcostHour",
                Expression = "[str_BTWcostHour]",
                BasicSearchExpression = "CAST([str_BTWcostHour] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[str_BTWcostHour]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_BTWcostHour", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_BTWcostHour", str_BTWcostHour);

            // bit_OfferSpanishServices
            bit_OfferSpanishServices = new (this, "x_bit_OfferSpanishServices", 11, SqlDbType.Bit) {
                Name = "bit_OfferSpanishServices",
                Expression = "[bit_OfferSpanishServices]",
                BasicSearchExpression = "[bit_OfferSpanishServices]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_OfferSpanishServices]",
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
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "bit_OfferSpanishServices", "CustomMsg"),
                IsUpload = false
            };
            bit_OfferSpanishServices.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_OfferSpanishServices, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_OfferSpanishServices, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_OfferSpanishServices, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_OfferSpanishServices", bit_OfferSpanishServices);

            // ByPassCRSelectionCentralizedOE
            ByPassCRSelectionCentralizedOE = new (this, "x_ByPassCRSelectionCentralizedOE", 11, SqlDbType.Bit) {
                Name = "ByPassCRSelectionCentralizedOE",
                Expression = "[ByPassCRSelectionCentralizedOE]",
                BasicSearchExpression = "[ByPassCRSelectionCentralizedOE]",
                DateTimeFormat = -1,
                VirtualExpression = "[ByPassCRSelectionCentralizedOE]",
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
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "ByPassCRSelectionCentralizedOE", "CustomMsg"),
                IsUpload = false
            };
            ByPassCRSelectionCentralizedOE.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(ByPassCRSelectionCentralizedOE, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(ByPassCRSelectionCentralizedOE, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(ByPassCRSelectionCentralizedOE, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("ByPassCRSelectionCentralizedOE", ByPassCRSelectionCentralizedOE);

            // str_WebNameArabic
            str_WebNameArabic = new (this, "x_str_WebNameArabic", 202, SqlDbType.NVarChar) {
                Name = "str_WebNameArabic",
                Expression = "[str_WebNameArabic]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_WebNameArabic]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_WebNameArabic]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_WebNameArabic", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_WebNameArabic", str_WebNameArabic);

            // str_WebDescriptionArabic
            str_WebDescriptionArabic = new (this, "x_str_WebDescriptionArabic", 203, SqlDbType.NText) {
                Name = "str_WebDescriptionArabic",
                Expression = "[str_WebDescriptionArabic]",
                BasicSearchExpression = "[str_WebDescriptionArabic]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_WebDescriptionArabic]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_WebDescriptionArabic", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_WebDescriptionArabic", str_WebDescriptionArabic);

            // PackageContractType
            PackageContractType = new (this, "x_PackageContractType", 3, SqlDbType.Int) {
                Name = "PackageContractType",
                Expression = "[PackageContractType]",
                BasicSearchExpression = "CAST([PackageContractType] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[PackageContractType]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "PackageContractType", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("PackageContractType", PackageContractType);

            // blob_path
            blob_path = new (this, "x_blob_path", 203, SqlDbType.NText) {
                Name = "blob_path",
                Expression = "[blob_path]",
                BasicSearchExpression = "[blob_path]",
                DateTimeFormat = -1,
                VirtualExpression = "[blob_path]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "blob_path", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("blob_path", blob_path);

            // StudentSignXCordinate
            StudentSignXCordinate = new (this, "x_StudentSignXCordinate", 3, SqlDbType.Int) {
                Name = "StudentSignXCordinate",
                Expression = "[StudentSignXCordinate]",
                BasicSearchExpression = "CAST([StudentSignXCordinate] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[StudentSignXCordinate]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "StudentSignXCordinate", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("StudentSignXCordinate", StudentSignXCordinate);

            // StudentSignYCordinate
            StudentSignYCordinate = new (this, "x_StudentSignYCordinate", 3, SqlDbType.Int) {
                Name = "StudentSignYCordinate",
                Expression = "[StudentSignYCordinate]",
                BasicSearchExpression = "CAST([StudentSignYCordinate] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[StudentSignYCordinate]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "StudentSignYCordinate", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("StudentSignYCordinate", StudentSignYCordinate);

            // ParentSignXCordinate
            ParentSignXCordinate = new (this, "x_ParentSignXCordinate", 3, SqlDbType.Int) {
                Name = "ParentSignXCordinate",
                Expression = "[ParentSignXCordinate]",
                BasicSearchExpression = "CAST([ParentSignXCordinate] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[ParentSignXCordinate]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "ParentSignXCordinate", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("ParentSignXCordinate", ParentSignXCordinate);

            // ParentSignYCordinate
            ParentSignYCordinate = new (this, "x_ParentSignYCordinate", 3, SqlDbType.Int) {
                Name = "ParentSignYCordinate",
                Expression = "[ParentSignYCordinate]",
                BasicSearchExpression = "CAST([ParentSignYCordinate] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[ParentSignYCordinate]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "ParentSignYCordinate", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("ParentSignYCordinate", ParentSignYCordinate);

            // ParentSignPageNo
            ParentSignPageNo = new (this, "x_ParentSignPageNo", 3, SqlDbType.Int) {
                Name = "ParentSignPageNo",
                Expression = "[ParentSignPageNo]",
                BasicSearchExpression = "CAST([ParentSignPageNo] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[ParentSignPageNo]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "ParentSignPageNo", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("ParentSignPageNo", ParentSignPageNo);

            // StudentSignPageNo
            StudentSignPageNo = new (this, "x_StudentSignPageNo", 3, SqlDbType.Int) {
                Name = "StudentSignPageNo",
                Expression = "[StudentSignPageNo]",
                BasicSearchExpression = "CAST([StudentSignPageNo] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[StudentSignPageNo]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "StudentSignPageNo", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("StudentSignPageNo", StudentSignPageNo);

            // int_CDLProgramType
            int_CDLProgramType = new (this, "x_int_CDLProgramType", 3, SqlDbType.Int) {
                Name = "int_CDLProgramType",
                Expression = "[int_CDLProgramType]",
                BasicSearchExpression = "CAST([int_CDLProgramType] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_CDLProgramType]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "int_CDLProgramType", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CDLProgramType", int_CDLProgramType);

            // int_CDLEndorsementCode
            int_CDLEndorsementCode = new (this, "x_int_CDLEndorsementCode", 3, SqlDbType.Int) {
                Name = "int_CDLEndorsementCode",
                Expression = "[int_CDLEndorsementCode]",
                BasicSearchExpression = "CAST([int_CDLEndorsementCode] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_CDLEndorsementCode]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "int_CDLEndorsementCode", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CDLEndorsementCode", int_CDLEndorsementCode);

            // int_CDLClassroom
            int_CDLClassroom = new (this, "x_int_CDLClassroom", 3, SqlDbType.Int) {
                Name = "int_CDLClassroom",
                Expression = "[int_CDLClassroom]",
                BasicSearchExpression = "CAST([int_CDLClassroom] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_CDLClassroom]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "int_CDLClassroom", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CDLClassroom", int_CDLClassroom);

            // int_CDLRange
            int_CDLRange = new (this, "x_int_CDLRange", 3, SqlDbType.Int) {
                Name = "int_CDLRange",
                Expression = "[int_CDLRange]",
                BasicSearchExpression = "CAST([int_CDLRange] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_CDLRange]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "int_CDLRange", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CDLRange", int_CDLRange);

            // int_CDLRoad
            int_CDLRoad = new (this, "x_int_CDLRoad", 3, SqlDbType.Int) {
                Name = "int_CDLRoad",
                Expression = "[int_CDLRoad]",
                BasicSearchExpression = "CAST([int_CDLRoad] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_CDLRoad]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "int_CDLRoad", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CDLRoad", int_CDLRoad);

            // bit_TPR_Package
            bit_TPR_Package = new (this, "x_bit_TPR_Package", 11, SqlDbType.Bit) {
                Name = "bit_TPR_Package",
                Expression = "[bit_TPR_Package]",
                BasicSearchExpression = "[bit_TPR_Package]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_TPR_Package]",
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
                SearchOperators = new () { "=", "<>" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "bit_TPR_Package", "CustomMsg"),
                IsUpload = false
            };
            bit_TPR_Package.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_TPR_Package, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_TPR_Package, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_TPR_Package, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_TPR_Package", bit_TPR_Package);

            // licenseTypeId
            licenseTypeId = new (this, "x_licenseTypeId", 3, SqlDbType.Int) {
                Name = "licenseTypeId",
                Expression = "[licenseTypeId]",
                BasicSearchExpression = "CAST([licenseTypeId] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[licenseTypeId]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "licenseTypeId", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("licenseTypeId", licenseTypeId);

            // bit_IsServiceForCertification
            bit_IsServiceForCertification = new (this, "x_bit_IsServiceForCertification", 11, SqlDbType.Bit) {
                Name = "bit_IsServiceForCertification",
                Expression = "[bit_IsServiceForCertification]",
                BasicSearchExpression = "[bit_IsServiceForCertification]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_IsServiceForCertification]",
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
                SearchOperators = new () { "=", "<>" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "bit_IsServiceForCertification", "CustomMsg"),
                IsUpload = false
            };
            bit_IsServiceForCertification.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IsServiceForCertification, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsServiceForCertification, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IsServiceForCertification, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_IsServiceForCertification", bit_IsServiceForCertification);

            // intMinAgeYearToEnroll
            intMinAgeYearToEnroll = new (this, "x_intMinAgeYearToEnroll", 200, SqlDbType.VarChar) {
                Name = "intMinAgeYearToEnroll",
                Expression = "[intMinAgeYearToEnroll]",
                UseBasicSearch = true,
                BasicSearchExpression = "[intMinAgeYearToEnroll]",
                DateTimeFormat = -1,
                VirtualExpression = "[intMinAgeYearToEnroll]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "intMinAgeYearToEnroll", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("intMinAgeYearToEnroll", intMinAgeYearToEnroll);

            // intMinAgeMonthToEnroll
            intMinAgeMonthToEnroll = new (this, "x_intMinAgeMonthToEnroll", 200, SqlDbType.VarChar) {
                Name = "intMinAgeMonthToEnroll",
                Expression = "[intMinAgeMonthToEnroll]",
                UseBasicSearch = true,
                BasicSearchExpression = "[intMinAgeMonthToEnroll]",
                DateTimeFormat = -1,
                VirtualExpression = "[intMinAgeMonthToEnroll]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "intMinAgeMonthToEnroll", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("intMinAgeMonthToEnroll", intMinAgeMonthToEnroll);

            // intMaxAgeYearToEnroll
            intMaxAgeYearToEnroll = new (this, "x_intMaxAgeYearToEnroll", 200, SqlDbType.VarChar) {
                Name = "intMaxAgeYearToEnroll",
                Expression = "[intMaxAgeYearToEnroll]",
                UseBasicSearch = true,
                BasicSearchExpression = "[intMaxAgeYearToEnroll]",
                DateTimeFormat = -1,
                VirtualExpression = "[intMaxAgeYearToEnroll]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "intMaxAgeYearToEnroll", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("intMaxAgeYearToEnroll", intMaxAgeYearToEnroll);

            // intMaxAgeMonthToEnroll
            intMaxAgeMonthToEnroll = new (this, "x_intMaxAgeMonthToEnroll", 200, SqlDbType.VarChar) {
                Name = "intMaxAgeMonthToEnroll",
                Expression = "[intMaxAgeMonthToEnroll]",
                UseBasicSearch = true,
                BasicSearchExpression = "[intMaxAgeMonthToEnroll]",
                DateTimeFormat = -1,
                VirtualExpression = "[intMaxAgeMonthToEnroll]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "intMaxAgeMonthToEnroll", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("intMaxAgeMonthToEnroll", intMaxAgeMonthToEnroll);

            // intCompletionDeadlineYear
            intCompletionDeadlineYear = new (this, "x_intCompletionDeadlineYear", 200, SqlDbType.VarChar) {
                Name = "intCompletionDeadlineYear",
                Expression = "[intCompletionDeadlineYear]",
                UseBasicSearch = true,
                BasicSearchExpression = "[intCompletionDeadlineYear]",
                DateTimeFormat = -1,
                VirtualExpression = "[intCompletionDeadlineYear]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "intCompletionDeadlineYear", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("intCompletionDeadlineYear", intCompletionDeadlineYear);

            // intCompletionDeadlineMonth
            intCompletionDeadlineMonth = new (this, "x_intCompletionDeadlineMonth", 200, SqlDbType.VarChar) {
                Name = "intCompletionDeadlineMonth",
                Expression = "[intCompletionDeadlineMonth]",
                UseBasicSearch = true,
                BasicSearchExpression = "[intCompletionDeadlineMonth]",
                DateTimeFormat = -1,
                VirtualExpression = "[intCompletionDeadlineMonth]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "intCompletionDeadlineMonth", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("intCompletionDeadlineMonth", intCompletionDeadlineMonth);

            // intCompletionDeadlineDay
            intCompletionDeadlineDay = new (this, "x_intCompletionDeadlineDay", 200, SqlDbType.VarChar) {
                Name = "intCompletionDeadlineDay",
                Expression = "[intCompletionDeadlineDay]",
                UseBasicSearch = true,
                BasicSearchExpression = "[intCompletionDeadlineDay]",
                DateTimeFormat = -1,
                VirtualExpression = "[intCompletionDeadlineDay]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "intCompletionDeadlineDay", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("intCompletionDeadlineDay", intCompletionDeadlineDay);

            // intCompletionDeadlineFrom
            intCompletionDeadlineFrom = new (this, "x_intCompletionDeadlineFrom", 200, SqlDbType.VarChar) {
                Name = "intCompletionDeadlineFrom",
                Expression = "[intCompletionDeadlineFrom]",
                UseBasicSearch = true,
                BasicSearchExpression = "[intCompletionDeadlineFrom]",
                DateTimeFormat = -1,
                VirtualExpression = "[intCompletionDeadlineFrom]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "intCompletionDeadlineFrom", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("intCompletionDeadlineFrom", intCompletionDeadlineFrom);

            // bit_IsTexable
            bit_IsTexable = new (this, "x_bit_IsTexable", 11, SqlDbType.Bit) {
                Name = "bit_IsTexable",
                Expression = "[bit_IsTexable]",
                BasicSearchExpression = "[bit_IsTexable]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_IsTexable]",
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
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "bit_IsTexable", "CustomMsg"),
                IsUpload = false
            };
            bit_IsTexable.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IsTexable, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsTexable, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IsTexable, "tblPackageInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_IsTexable", bit_IsTexable);

            // str_Base_price
            str_Base_price = new (this, "x_str_Base_price", 200, SqlDbType.VarChar) {
                Name = "str_Base_price",
                Expression = "[str_Base_price]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Base_price]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Base_price]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_Base_price", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Base_price", str_Base_price);

            // str_Tax
            str_Tax = new (this, "x_str_Tax", 200, SqlDbType.VarChar) {
                Name = "str_Tax",
                Expression = "[str_Tax]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Tax]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Tax]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblPackageInfo", "str_Tax", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Tax", str_Tax);

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
            get => _sqlFrom ?? "dbo.tblPackageInfo";
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
                int_Package_Id.DbValue = row["int_Package_Id"]; // Set DB value only
                str_Package_Name.DbValue = row["str_Package_Name"]; // Set DB value only
                str_Package_Code.DbValue = row["str_Package_Code"]; // Set DB value only
                int_Status.DbValue = row["int_Status"]; // Set DB value only
                str_Discount.DbValue = row["str_Discount"]; // Set DB value only
                mny_Price.DbValue = row["mny_Price"]; // Set DB value only
                str_Notes.DbValue = row["str_Notes"]; // Set DB value only
                bit_IswebSignUp.DbValue = (ConvertToBool(row["bit_IswebSignUp"]) ? "1" : "0"); // Set DB value only
                str_Items.DbValue = row["str_Items"]; // Set DB value only
                int_Created_By.DbValue = row["int_Created_By"]; // Set DB value only
                int_Modified_By.DbValue = row["int_Modified_By"]; // Set DB value only
                date_Created.DbValue = row["date_Created"]; // Set DB value only
                date_Modified.DbValue = row["date_Modified"]; // Set DB value only
                bit_IsDeleted.DbValue = (ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"); // Set DB value only
                str_WebDescription.DbValue = row["str_WebDescription"]; // Set DB value only
                bit_PortalPurchase.DbValue = (ConvertToBool(row["bit_PortalPurchase"]) ? "1" : "0"); // Set DB value only
                str_WebName.DbValue = row["str_WebName"]; // Set DB value only
                bit_ExtraChk1.DbValue = (ConvertToBool(row["bit_ExtraChk1"]) ? "1" : "0"); // Set DB value only
                bit_ExtraChk2.DbValue = (ConvertToBool(row["bit_ExtraChk2"]) ? "1" : "0"); // Set DB value only
                str_ExtraDrpDown1.DbValue = row["str_ExtraDrpDown1"]; // Set DB value only
                str_ExtraDrpDown2.DbValue = row["str_ExtraDrpDown2"]; // Set DB value only
                str_Extratxt1.DbValue = row["str_Extratxt1"]; // Set DB value only
                str_Extratxt2.DbValue = row["str_Extratxt2"]; // Set DB value only
                is_Show.DbValue = (ConvertToBool(row["is_Show"]) ? "1" : "0"); // Set DB value only
                is_ShowGridColumn.DbValue = (ConvertToBool(row["is_ShowGridColumn"]) ? "1" : "0"); // Set DB value only
                rowIndex.DbValue = row["rowIndex"]; // Set DB value only
                bit_referral.DbValue = (ConvertToBool(row["bit_referral"]) ? "1" : "0"); // Set DB value only
                str_Locations.DbValue = row["str_Locations"]; // Set DB value only
                str_PackageType.DbValue = row["str_PackageType"]; // Set DB value only
                int_ParentClass_Id.DbValue = row["int_ParentClass_Id"]; // Set DB value only
                str_CRcostHour.DbValue = row["str_CRcostHour"]; // Set DB value only
                str_BTWcostHour.DbValue = row["str_BTWcostHour"]; // Set DB value only
                bit_OfferSpanishServices.DbValue = (ConvertToBool(row["bit_OfferSpanishServices"]) ? "1" : "0"); // Set DB value only
                ByPassCRSelectionCentralizedOE.DbValue = (ConvertToBool(row["ByPassCRSelectionCentralizedOE"]) ? "1" : "0"); // Set DB value only
                str_WebNameArabic.DbValue = row["str_WebNameArabic"]; // Set DB value only
                str_WebDescriptionArabic.DbValue = row["str_WebDescriptionArabic"]; // Set DB value only
                PackageContractType.DbValue = row["PackageContractType"]; // Set DB value only
                blob_path.DbValue = row["blob_path"]; // Set DB value only
                StudentSignXCordinate.DbValue = row["StudentSignXCordinate"]; // Set DB value only
                StudentSignYCordinate.DbValue = row["StudentSignYCordinate"]; // Set DB value only
                ParentSignXCordinate.DbValue = row["ParentSignXCordinate"]; // Set DB value only
                ParentSignYCordinate.DbValue = row["ParentSignYCordinate"]; // Set DB value only
                ParentSignPageNo.DbValue = row["ParentSignPageNo"]; // Set DB value only
                StudentSignPageNo.DbValue = row["StudentSignPageNo"]; // Set DB value only
                int_CDLProgramType.DbValue = row["int_CDLProgramType"]; // Set DB value only
                int_CDLEndorsementCode.DbValue = row["int_CDLEndorsementCode"]; // Set DB value only
                int_CDLClassroom.DbValue = row["int_CDLClassroom"]; // Set DB value only
                int_CDLRange.DbValue = row["int_CDLRange"]; // Set DB value only
                int_CDLRoad.DbValue = row["int_CDLRoad"]; // Set DB value only
                bit_TPR_Package.DbValue = (ConvertToBool(row["bit_TPR_Package"]) ? "1" : "0"); // Set DB value only
                licenseTypeId.DbValue = row["licenseTypeId"]; // Set DB value only
                bit_IsServiceForCertification.DbValue = (ConvertToBool(row["bit_IsServiceForCertification"]) ? "1" : "0"); // Set DB value only
                intMinAgeYearToEnroll.DbValue = row["intMinAgeYearToEnroll"]; // Set DB value only
                intMinAgeMonthToEnroll.DbValue = row["intMinAgeMonthToEnroll"]; // Set DB value only
                intMaxAgeYearToEnroll.DbValue = row["intMaxAgeYearToEnroll"]; // Set DB value only
                intMaxAgeMonthToEnroll.DbValue = row["intMaxAgeMonthToEnroll"]; // Set DB value only
                intCompletionDeadlineYear.DbValue = row["intCompletionDeadlineYear"]; // Set DB value only
                intCompletionDeadlineMonth.DbValue = row["intCompletionDeadlineMonth"]; // Set DB value only
                intCompletionDeadlineDay.DbValue = row["intCompletionDeadlineDay"]; // Set DB value only
                intCompletionDeadlineFrom.DbValue = row["intCompletionDeadlineFrom"]; // Set DB value only
                bit_IsTexable.DbValue = (ConvertToBool(row["bit_IsTexable"]) ? "1" : "0"); // Set DB value only
                str_Base_price.DbValue = row["str_Base_price"]; // Set DB value only
                str_Tax.DbValue = row["str_Tax"]; // Set DB value only
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
                    return "TblPackageInfoList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "TblPackageInfoView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "TblPackageInfoEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "TblPackageInfoAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "TblPackageInfoList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "TblPackageInfoView",
                Config.ApiAddAction => "TblPackageInfoAdd",
                Config.ApiEditAction => "TblPackageInfoEdit",
                Config.ApiDeleteAction => "TblPackageInfoDelete",
                Config.ApiListAction => "TblPackageInfoList",
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
        public string ListUrl => "TblPackageInfoList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblPackageInfoView", parm);
            else
                url = KeyUrl("TblPackageInfoView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "TblPackageInfoAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "TblPackageInfoAdd?" + parm;
            else
                url = "TblPackageInfoAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("TblPackageInfoEdit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblPackageInfoList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("TblPackageInfoAdd", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblPackageInfoList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("TblPackageInfoDelete")); // DN

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
            int_Package_Id.SetDbValue(dr["int_Package_Id"]);
            str_Package_Name.SetDbValue(dr["str_Package_Name"]);
            str_Package_Code.SetDbValue(dr["str_Package_Code"]);
            int_Status.SetDbValue(dr["int_Status"]);
            str_Discount.SetDbValue(dr["str_Discount"]);
            mny_Price.SetDbValue(dr["mny_Price"]);
            str_Notes.SetDbValue(dr["str_Notes"]);
            bit_IswebSignUp.SetDbValue(ConvertToBool(dr["bit_IswebSignUp"]) ? "1" : "0");
            str_Items.SetDbValue(dr["str_Items"]);
            int_Created_By.SetDbValue(dr["int_Created_By"]);
            int_Modified_By.SetDbValue(dr["int_Modified_By"]);
            date_Created.SetDbValue(dr["date_Created"]);
            date_Modified.SetDbValue(dr["date_Modified"]);
            bit_IsDeleted.SetDbValue(ConvertToBool(dr["bit_IsDeleted"]) ? "1" : "0");
            str_WebDescription.SetDbValue(dr["str_WebDescription"]);
            bit_PortalPurchase.SetDbValue(ConvertToBool(dr["bit_PortalPurchase"]) ? "1" : "0");
            str_WebName.SetDbValue(dr["str_WebName"]);
            bit_ExtraChk1.SetDbValue(ConvertToBool(dr["bit_ExtraChk1"]) ? "1" : "0");
            bit_ExtraChk2.SetDbValue(ConvertToBool(dr["bit_ExtraChk2"]) ? "1" : "0");
            str_ExtraDrpDown1.SetDbValue(dr["str_ExtraDrpDown1"]);
            str_ExtraDrpDown2.SetDbValue(dr["str_ExtraDrpDown2"]);
            str_Extratxt1.SetDbValue(dr["str_Extratxt1"]);
            str_Extratxt2.SetDbValue(dr["str_Extratxt2"]);
            is_Show.SetDbValue(ConvertToBool(dr["is_Show"]) ? "1" : "0");
            is_ShowGridColumn.SetDbValue(ConvertToBool(dr["is_ShowGridColumn"]) ? "1" : "0");
            rowIndex.SetDbValue(dr["rowIndex"]);
            bit_referral.SetDbValue(ConvertToBool(dr["bit_referral"]) ? "1" : "0");
            str_Locations.SetDbValue(dr["str_Locations"]);
            str_PackageType.SetDbValue(dr["str_PackageType"]);
            int_ParentClass_Id.SetDbValue(dr["int_ParentClass_Id"]);
            str_CRcostHour.SetDbValue(dr["str_CRcostHour"]);
            str_BTWcostHour.SetDbValue(dr["str_BTWcostHour"]);
            bit_OfferSpanishServices.SetDbValue(ConvertToBool(dr["bit_OfferSpanishServices"]) ? "1" : "0");
            ByPassCRSelectionCentralizedOE.SetDbValue(ConvertToBool(dr["ByPassCRSelectionCentralizedOE"]) ? "1" : "0");
            str_WebNameArabic.SetDbValue(dr["str_WebNameArabic"]);
            str_WebDescriptionArabic.SetDbValue(dr["str_WebDescriptionArabic"]);
            PackageContractType.SetDbValue(dr["PackageContractType"]);
            blob_path.SetDbValue(dr["blob_path"]);
            StudentSignXCordinate.SetDbValue(dr["StudentSignXCordinate"]);
            StudentSignYCordinate.SetDbValue(dr["StudentSignYCordinate"]);
            ParentSignXCordinate.SetDbValue(dr["ParentSignXCordinate"]);
            ParentSignYCordinate.SetDbValue(dr["ParentSignYCordinate"]);
            ParentSignPageNo.SetDbValue(dr["ParentSignPageNo"]);
            StudentSignPageNo.SetDbValue(dr["StudentSignPageNo"]);
            int_CDLProgramType.SetDbValue(dr["int_CDLProgramType"]);
            int_CDLEndorsementCode.SetDbValue(dr["int_CDLEndorsementCode"]);
            int_CDLClassroom.SetDbValue(dr["int_CDLClassroom"]);
            int_CDLRange.SetDbValue(dr["int_CDLRange"]);
            int_CDLRoad.SetDbValue(dr["int_CDLRoad"]);
            bit_TPR_Package.SetDbValue(ConvertToBool(dr["bit_TPR_Package"]) ? "1" : "0");
            licenseTypeId.SetDbValue(dr["licenseTypeId"]);
            bit_IsServiceForCertification.SetDbValue(ConvertToBool(dr["bit_IsServiceForCertification"]) ? "1" : "0");
            intMinAgeYearToEnroll.SetDbValue(dr["intMinAgeYearToEnroll"]);
            intMinAgeMonthToEnroll.SetDbValue(dr["intMinAgeMonthToEnroll"]);
            intMaxAgeYearToEnroll.SetDbValue(dr["intMaxAgeYearToEnroll"]);
            intMaxAgeMonthToEnroll.SetDbValue(dr["intMaxAgeMonthToEnroll"]);
            intCompletionDeadlineYear.SetDbValue(dr["intCompletionDeadlineYear"]);
            intCompletionDeadlineMonth.SetDbValue(dr["intCompletionDeadlineMonth"]);
            intCompletionDeadlineDay.SetDbValue(dr["intCompletionDeadlineDay"]);
            intCompletionDeadlineFrom.SetDbValue(dr["intCompletionDeadlineFrom"]);
            bit_IsTexable.SetDbValue(ConvertToBool(dr["bit_IsTexable"]) ? "1" : "0");
            str_Base_price.SetDbValue(dr["str_Base_price"]);
            str_Tax.SetDbValue(dr["str_Tax"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "TblPackageInfoList";
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

            // int_Package_Id

            // str_Package_Name

            // str_Package_Code

            // int_Status

            // str_Discount

            // mny_Price

            // str_Notes

            // bit_IswebSignUp

            // str_Items

            // int_Created_By

            // int_Modified_By

            // date_Created

            // date_Modified

            // bit_IsDeleted

            // str_WebDescription

            // bit_PortalPurchase

            // str_WebName

            // bit_ExtraChk1

            // bit_ExtraChk2

            // str_ExtraDrpDown1

            // str_ExtraDrpDown2

            // str_Extratxt1

            // str_Extratxt2

            // is_Show

            // is_ShowGridColumn

            // rowIndex

            // bit_referral

            // str_Locations

            // str_PackageType

            // int_ParentClass_Id

            // str_CRcostHour

            // str_BTWcostHour

            // bit_OfferSpanishServices

            // ByPassCRSelectionCentralizedOE

            // str_WebNameArabic

            // str_WebDescriptionArabic

            // PackageContractType

            // blob_path

            // StudentSignXCordinate

            // StudentSignYCordinate

            // ParentSignXCordinate

            // ParentSignYCordinate

            // ParentSignPageNo

            // StudentSignPageNo

            // int_CDLProgramType

            // int_CDLEndorsementCode

            // int_CDLClassroom

            // int_CDLRange

            // int_CDLRoad

            // bit_TPR_Package

            // licenseTypeId

            // bit_IsServiceForCertification

            // intMinAgeYearToEnroll

            // intMinAgeMonthToEnroll

            // intMaxAgeYearToEnroll

            // intMaxAgeMonthToEnroll

            // intCompletionDeadlineYear

            // intCompletionDeadlineMonth

            // intCompletionDeadlineDay

            // intCompletionDeadlineFrom

            // bit_IsTexable

            // str_Base_price

            // str_Tax

            // int_Package_Id
            int_Package_Id.ViewValue = int_Package_Id.CurrentValue;
            int_Package_Id.ViewValue = FormatNumber(int_Package_Id.ViewValue, int_Package_Id.FormatPattern);
            int_Package_Id.ViewCustomAttributes = "";

            // str_Package_Name
            str_Package_Name.ViewValue = ConvertToString(str_Package_Name.CurrentValue); // DN
            str_Package_Name.ViewCustomAttributes = "";

            // str_Package_Code
            str_Package_Code.ViewValue = ConvertToString(str_Package_Code.CurrentValue); // DN
            str_Package_Code.ViewCustomAttributes = "";

            // int_Status
            int_Status.ViewValue = int_Status.CurrentValue;
            int_Status.ViewValue = FormatNumber(int_Status.ViewValue, int_Status.FormatPattern);
            int_Status.ViewCustomAttributes = "";

            // str_Discount
            str_Discount.ViewValue = ConvertToString(str_Discount.CurrentValue); // DN
            str_Discount.ViewCustomAttributes = "";

            // mny_Price
            mny_Price.ViewValue = mny_Price.CurrentValue;
            mny_Price.ViewValue = FormatNumber(mny_Price.ViewValue, mny_Price.FormatPattern);
            mny_Price.ViewCustomAttributes = "";

            // str_Notes
            str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
            str_Notes.ViewCustomAttributes = "";

            // bit_IswebSignUp
            if (ConvertToBool(bit_IswebSignUp.CurrentValue)) {
                bit_IswebSignUp.ViewValue = bit_IswebSignUp.TagCaption(1) != "" ? bit_IswebSignUp.TagCaption(1) : "Yes";
            } else {
                bit_IswebSignUp.ViewValue = bit_IswebSignUp.TagCaption(2) != "" ? bit_IswebSignUp.TagCaption(2) : "No";
            }
            bit_IswebSignUp.ViewCustomAttributes = "";

            // str_Items
            str_Items.ViewValue = ConvertToString(str_Items.CurrentValue); // DN
            str_Items.ViewCustomAttributes = "";

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

            // str_WebDescription
            str_WebDescription.ViewValue = str_WebDescription.CurrentValue;
            str_WebDescription.ViewCustomAttributes = "";

            // bit_PortalPurchase
            if (ConvertToBool(bit_PortalPurchase.CurrentValue)) {
                bit_PortalPurchase.ViewValue = bit_PortalPurchase.TagCaption(1) != "" ? bit_PortalPurchase.TagCaption(1) : "Yes";
            } else {
                bit_PortalPurchase.ViewValue = bit_PortalPurchase.TagCaption(2) != "" ? bit_PortalPurchase.TagCaption(2) : "No";
            }
            bit_PortalPurchase.ViewCustomAttributes = "";

            // str_WebName
            str_WebName.ViewValue = ConvertToString(str_WebName.CurrentValue); // DN
            str_WebName.ViewCustomAttributes = "";

            // bit_ExtraChk1
            if (ConvertToBool(bit_ExtraChk1.CurrentValue)) {
                bit_ExtraChk1.ViewValue = bit_ExtraChk1.TagCaption(1) != "" ? bit_ExtraChk1.TagCaption(1) : "Yes";
            } else {
                bit_ExtraChk1.ViewValue = bit_ExtraChk1.TagCaption(2) != "" ? bit_ExtraChk1.TagCaption(2) : "No";
            }
            bit_ExtraChk1.ViewCustomAttributes = "";

            // bit_ExtraChk2
            if (ConvertToBool(bit_ExtraChk2.CurrentValue)) {
                bit_ExtraChk2.ViewValue = bit_ExtraChk2.TagCaption(1) != "" ? bit_ExtraChk2.TagCaption(1) : "Yes";
            } else {
                bit_ExtraChk2.ViewValue = bit_ExtraChk2.TagCaption(2) != "" ? bit_ExtraChk2.TagCaption(2) : "No";
            }
            bit_ExtraChk2.ViewCustomAttributes = "";

            // str_ExtraDrpDown1
            str_ExtraDrpDown1.ViewValue = ConvertToString(str_ExtraDrpDown1.CurrentValue); // DN
            str_ExtraDrpDown1.ViewCustomAttributes = "";

            // str_ExtraDrpDown2
            str_ExtraDrpDown2.ViewValue = ConvertToString(str_ExtraDrpDown2.CurrentValue); // DN
            str_ExtraDrpDown2.ViewCustomAttributes = "";

            // str_Extratxt1
            str_Extratxt1.ViewValue = ConvertToString(str_Extratxt1.CurrentValue); // DN
            str_Extratxt1.ViewCustomAttributes = "";

            // str_Extratxt2
            str_Extratxt2.ViewValue = ConvertToString(str_Extratxt2.CurrentValue); // DN
            str_Extratxt2.ViewCustomAttributes = "";

            // is_Show
            if (ConvertToBool(is_Show.CurrentValue)) {
                is_Show.ViewValue = is_Show.TagCaption(1) != "" ? is_Show.TagCaption(1) : "Yes";
            } else {
                is_Show.ViewValue = is_Show.TagCaption(2) != "" ? is_Show.TagCaption(2) : "No";
            }
            is_Show.ViewCustomAttributes = "";

            // is_ShowGridColumn
            if (ConvertToBool(is_ShowGridColumn.CurrentValue)) {
                is_ShowGridColumn.ViewValue = is_ShowGridColumn.TagCaption(1) != "" ? is_ShowGridColumn.TagCaption(1) : "Yes";
            } else {
                is_ShowGridColumn.ViewValue = is_ShowGridColumn.TagCaption(2) != "" ? is_ShowGridColumn.TagCaption(2) : "No";
            }
            is_ShowGridColumn.ViewCustomAttributes = "";

            // rowIndex
            rowIndex.ViewValue = ConvertToString(rowIndex.CurrentValue); // DN
            rowIndex.ViewCustomAttributes = "";

            // bit_referral
            if (ConvertToBool(bit_referral.CurrentValue)) {
                bit_referral.ViewValue = bit_referral.TagCaption(1) != "" ? bit_referral.TagCaption(1) : "Yes";
            } else {
                bit_referral.ViewValue = bit_referral.TagCaption(2) != "" ? bit_referral.TagCaption(2) : "No";
            }
            bit_referral.ViewCustomAttributes = "";

            // str_Locations
            str_Locations.ViewValue = str_Locations.CurrentValue;
            str_Locations.ViewCustomAttributes = "";

            // str_PackageType
            str_PackageType.ViewValue = ConvertToString(str_PackageType.CurrentValue); // DN
            str_PackageType.ViewCustomAttributes = "";

            // int_ParentClass_Id
            int_ParentClass_Id.ViewValue = int_ParentClass_Id.CurrentValue;
            int_ParentClass_Id.ViewValue = FormatNumber(int_ParentClass_Id.ViewValue, int_ParentClass_Id.FormatPattern);
            int_ParentClass_Id.ViewCustomAttributes = "";

            // str_CRcostHour
            str_CRcostHour.ViewValue = str_CRcostHour.CurrentValue;
            str_CRcostHour.ViewValue = FormatNumber(str_CRcostHour.ViewValue, str_CRcostHour.FormatPattern);
            str_CRcostHour.ViewCustomAttributes = "";

            // str_BTWcostHour
            str_BTWcostHour.ViewValue = str_BTWcostHour.CurrentValue;
            str_BTWcostHour.ViewValue = FormatNumber(str_BTWcostHour.ViewValue, str_BTWcostHour.FormatPattern);
            str_BTWcostHour.ViewCustomAttributes = "";

            // bit_OfferSpanishServices
            if (ConvertToBool(bit_OfferSpanishServices.CurrentValue)) {
                bit_OfferSpanishServices.ViewValue = bit_OfferSpanishServices.TagCaption(1) != "" ? bit_OfferSpanishServices.TagCaption(1) : "Yes";
            } else {
                bit_OfferSpanishServices.ViewValue = bit_OfferSpanishServices.TagCaption(2) != "" ? bit_OfferSpanishServices.TagCaption(2) : "No";
            }
            bit_OfferSpanishServices.ViewCustomAttributes = "";

            // ByPassCRSelectionCentralizedOE
            if (ConvertToBool(ByPassCRSelectionCentralizedOE.CurrentValue)) {
                ByPassCRSelectionCentralizedOE.ViewValue = ByPassCRSelectionCentralizedOE.TagCaption(1) != "" ? ByPassCRSelectionCentralizedOE.TagCaption(1) : "Yes";
            } else {
                ByPassCRSelectionCentralizedOE.ViewValue = ByPassCRSelectionCentralizedOE.TagCaption(2) != "" ? ByPassCRSelectionCentralizedOE.TagCaption(2) : "No";
            }
            ByPassCRSelectionCentralizedOE.ViewCustomAttributes = "";

            // str_WebNameArabic
            str_WebNameArabic.ViewValue = ConvertToString(str_WebNameArabic.CurrentValue); // DN
            str_WebNameArabic.ViewCustomAttributes = "";

            // str_WebDescriptionArabic
            str_WebDescriptionArabic.ViewValue = str_WebDescriptionArabic.CurrentValue;
            str_WebDescriptionArabic.ViewCustomAttributes = "";

            // PackageContractType
            PackageContractType.ViewValue = PackageContractType.CurrentValue;
            PackageContractType.ViewValue = FormatNumber(PackageContractType.ViewValue, PackageContractType.FormatPattern);
            PackageContractType.ViewCustomAttributes = "";

            // blob_path
            blob_path.ViewValue = blob_path.CurrentValue;
            blob_path.ViewCustomAttributes = "";

            // StudentSignXCordinate
            StudentSignXCordinate.ViewValue = StudentSignXCordinate.CurrentValue;
            StudentSignXCordinate.ViewValue = FormatNumber(StudentSignXCordinate.ViewValue, StudentSignXCordinate.FormatPattern);
            StudentSignXCordinate.ViewCustomAttributes = "";

            // StudentSignYCordinate
            StudentSignYCordinate.ViewValue = StudentSignYCordinate.CurrentValue;
            StudentSignYCordinate.ViewValue = FormatNumber(StudentSignYCordinate.ViewValue, StudentSignYCordinate.FormatPattern);
            StudentSignYCordinate.ViewCustomAttributes = "";

            // ParentSignXCordinate
            ParentSignXCordinate.ViewValue = ParentSignXCordinate.CurrentValue;
            ParentSignXCordinate.ViewValue = FormatNumber(ParentSignXCordinate.ViewValue, ParentSignXCordinate.FormatPattern);
            ParentSignXCordinate.ViewCustomAttributes = "";

            // ParentSignYCordinate
            ParentSignYCordinate.ViewValue = ParentSignYCordinate.CurrentValue;
            ParentSignYCordinate.ViewValue = FormatNumber(ParentSignYCordinate.ViewValue, ParentSignYCordinate.FormatPattern);
            ParentSignYCordinate.ViewCustomAttributes = "";

            // ParentSignPageNo
            ParentSignPageNo.ViewValue = ParentSignPageNo.CurrentValue;
            ParentSignPageNo.ViewValue = FormatNumber(ParentSignPageNo.ViewValue, ParentSignPageNo.FormatPattern);
            ParentSignPageNo.ViewCustomAttributes = "";

            // StudentSignPageNo
            StudentSignPageNo.ViewValue = StudentSignPageNo.CurrentValue;
            StudentSignPageNo.ViewValue = FormatNumber(StudentSignPageNo.ViewValue, StudentSignPageNo.FormatPattern);
            StudentSignPageNo.ViewCustomAttributes = "";

            // int_CDLProgramType
            int_CDLProgramType.ViewValue = int_CDLProgramType.CurrentValue;
            int_CDLProgramType.ViewValue = FormatNumber(int_CDLProgramType.ViewValue, int_CDLProgramType.FormatPattern);
            int_CDLProgramType.ViewCustomAttributes = "";

            // int_CDLEndorsementCode
            int_CDLEndorsementCode.ViewValue = int_CDLEndorsementCode.CurrentValue;
            int_CDLEndorsementCode.ViewValue = FormatNumber(int_CDLEndorsementCode.ViewValue, int_CDLEndorsementCode.FormatPattern);
            int_CDLEndorsementCode.ViewCustomAttributes = "";

            // int_CDLClassroom
            int_CDLClassroom.ViewValue = int_CDLClassroom.CurrentValue;
            int_CDLClassroom.ViewValue = FormatNumber(int_CDLClassroom.ViewValue, int_CDLClassroom.FormatPattern);
            int_CDLClassroom.ViewCustomAttributes = "";

            // int_CDLRange
            int_CDLRange.ViewValue = int_CDLRange.CurrentValue;
            int_CDLRange.ViewValue = FormatNumber(int_CDLRange.ViewValue, int_CDLRange.FormatPattern);
            int_CDLRange.ViewCustomAttributes = "";

            // int_CDLRoad
            int_CDLRoad.ViewValue = int_CDLRoad.CurrentValue;
            int_CDLRoad.ViewValue = FormatNumber(int_CDLRoad.ViewValue, int_CDLRoad.FormatPattern);
            int_CDLRoad.ViewCustomAttributes = "";

            // bit_TPR_Package
            if (ConvertToBool(bit_TPR_Package.CurrentValue)) {
                bit_TPR_Package.ViewValue = bit_TPR_Package.TagCaption(1) != "" ? bit_TPR_Package.TagCaption(1) : "Yes";
            } else {
                bit_TPR_Package.ViewValue = bit_TPR_Package.TagCaption(2) != "" ? bit_TPR_Package.TagCaption(2) : "No";
            }
            bit_TPR_Package.ViewCustomAttributes = "";

            // licenseTypeId
            licenseTypeId.ViewValue = licenseTypeId.CurrentValue;
            licenseTypeId.ViewValue = FormatNumber(licenseTypeId.ViewValue, licenseTypeId.FormatPattern);
            licenseTypeId.ViewCustomAttributes = "";

            // bit_IsServiceForCertification
            if (ConvertToBool(bit_IsServiceForCertification.CurrentValue)) {
                bit_IsServiceForCertification.ViewValue = bit_IsServiceForCertification.TagCaption(1) != "" ? bit_IsServiceForCertification.TagCaption(1) : "Yes";
            } else {
                bit_IsServiceForCertification.ViewValue = bit_IsServiceForCertification.TagCaption(2) != "" ? bit_IsServiceForCertification.TagCaption(2) : "No";
            }
            bit_IsServiceForCertification.ViewCustomAttributes = "";

            // intMinAgeYearToEnroll
            intMinAgeYearToEnroll.ViewValue = ConvertToString(intMinAgeYearToEnroll.CurrentValue); // DN
            intMinAgeYearToEnroll.ViewCustomAttributes = "";

            // intMinAgeMonthToEnroll
            intMinAgeMonthToEnroll.ViewValue = ConvertToString(intMinAgeMonthToEnroll.CurrentValue); // DN
            intMinAgeMonthToEnroll.ViewCustomAttributes = "";

            // intMaxAgeYearToEnroll
            intMaxAgeYearToEnroll.ViewValue = ConvertToString(intMaxAgeYearToEnroll.CurrentValue); // DN
            intMaxAgeYearToEnroll.ViewCustomAttributes = "";

            // intMaxAgeMonthToEnroll
            intMaxAgeMonthToEnroll.ViewValue = ConvertToString(intMaxAgeMonthToEnroll.CurrentValue); // DN
            intMaxAgeMonthToEnroll.ViewCustomAttributes = "";

            // intCompletionDeadlineYear
            intCompletionDeadlineYear.ViewValue = ConvertToString(intCompletionDeadlineYear.CurrentValue); // DN
            intCompletionDeadlineYear.ViewCustomAttributes = "";

            // intCompletionDeadlineMonth
            intCompletionDeadlineMonth.ViewValue = ConvertToString(intCompletionDeadlineMonth.CurrentValue); // DN
            intCompletionDeadlineMonth.ViewCustomAttributes = "";

            // intCompletionDeadlineDay
            intCompletionDeadlineDay.ViewValue = ConvertToString(intCompletionDeadlineDay.CurrentValue); // DN
            intCompletionDeadlineDay.ViewCustomAttributes = "";

            // intCompletionDeadlineFrom
            intCompletionDeadlineFrom.ViewValue = ConvertToString(intCompletionDeadlineFrom.CurrentValue); // DN
            intCompletionDeadlineFrom.ViewCustomAttributes = "";

            // bit_IsTexable
            if (ConvertToBool(bit_IsTexable.CurrentValue)) {
                bit_IsTexable.ViewValue = bit_IsTexable.TagCaption(1) != "" ? bit_IsTexable.TagCaption(1) : "Yes";
            } else {
                bit_IsTexable.ViewValue = bit_IsTexable.TagCaption(2) != "" ? bit_IsTexable.TagCaption(2) : "No";
            }
            bit_IsTexable.ViewCustomAttributes = "";

            // str_Base_price
            str_Base_price.ViewValue = ConvertToString(str_Base_price.CurrentValue); // DN
            str_Base_price.ViewCustomAttributes = "";

            // str_Tax
            str_Tax.ViewValue = ConvertToString(str_Tax.CurrentValue); // DN
            str_Tax.ViewCustomAttributes = "";

            // int_Package_Id
            int_Package_Id.HrefValue = "";
            int_Package_Id.TooltipValue = "";

            // str_Package_Name
            str_Package_Name.HrefValue = "";
            str_Package_Name.TooltipValue = "";

            // str_Package_Code
            str_Package_Code.HrefValue = "";
            str_Package_Code.TooltipValue = "";

            // int_Status
            int_Status.HrefValue = "";
            int_Status.TooltipValue = "";

            // str_Discount
            str_Discount.HrefValue = "";
            str_Discount.TooltipValue = "";

            // mny_Price
            mny_Price.HrefValue = "";
            mny_Price.TooltipValue = "";

            // str_Notes
            str_Notes.HrefValue = "";
            str_Notes.TooltipValue = "";

            // bit_IswebSignUp
            bit_IswebSignUp.HrefValue = "";
            bit_IswebSignUp.TooltipValue = "";

            // str_Items
            str_Items.HrefValue = "";
            str_Items.TooltipValue = "";

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

            // str_WebDescription
            str_WebDescription.HrefValue = "";
            str_WebDescription.TooltipValue = "";

            // bit_PortalPurchase
            bit_PortalPurchase.HrefValue = "";
            bit_PortalPurchase.TooltipValue = "";

            // str_WebName
            str_WebName.HrefValue = "";
            str_WebName.TooltipValue = "";

            // bit_ExtraChk1
            bit_ExtraChk1.HrefValue = "";
            bit_ExtraChk1.TooltipValue = "";

            // bit_ExtraChk2
            bit_ExtraChk2.HrefValue = "";
            bit_ExtraChk2.TooltipValue = "";

            // str_ExtraDrpDown1
            str_ExtraDrpDown1.HrefValue = "";
            str_ExtraDrpDown1.TooltipValue = "";

            // str_ExtraDrpDown2
            str_ExtraDrpDown2.HrefValue = "";
            str_ExtraDrpDown2.TooltipValue = "";

            // str_Extratxt1
            str_Extratxt1.HrefValue = "";
            str_Extratxt1.TooltipValue = "";

            // str_Extratxt2
            str_Extratxt2.HrefValue = "";
            str_Extratxt2.TooltipValue = "";

            // is_Show
            is_Show.HrefValue = "";
            is_Show.TooltipValue = "";

            // is_ShowGridColumn
            is_ShowGridColumn.HrefValue = "";
            is_ShowGridColumn.TooltipValue = "";

            // rowIndex
            rowIndex.HrefValue = "";
            rowIndex.TooltipValue = "";

            // bit_referral
            bit_referral.HrefValue = "";
            bit_referral.TooltipValue = "";

            // str_Locations
            str_Locations.HrefValue = "";
            str_Locations.TooltipValue = "";

            // str_PackageType
            str_PackageType.HrefValue = "";
            str_PackageType.TooltipValue = "";

            // int_ParentClass_Id
            int_ParentClass_Id.HrefValue = "";
            int_ParentClass_Id.TooltipValue = "";

            // str_CRcostHour
            str_CRcostHour.HrefValue = "";
            str_CRcostHour.TooltipValue = "";

            // str_BTWcostHour
            str_BTWcostHour.HrefValue = "";
            str_BTWcostHour.TooltipValue = "";

            // bit_OfferSpanishServices
            bit_OfferSpanishServices.HrefValue = "";
            bit_OfferSpanishServices.TooltipValue = "";

            // ByPassCRSelectionCentralizedOE
            ByPassCRSelectionCentralizedOE.HrefValue = "";
            ByPassCRSelectionCentralizedOE.TooltipValue = "";

            // str_WebNameArabic
            str_WebNameArabic.HrefValue = "";
            str_WebNameArabic.TooltipValue = "";

            // str_WebDescriptionArabic
            str_WebDescriptionArabic.HrefValue = "";
            str_WebDescriptionArabic.TooltipValue = "";

            // PackageContractType
            PackageContractType.HrefValue = "";
            PackageContractType.TooltipValue = "";

            // blob_path
            blob_path.HrefValue = "";
            blob_path.TooltipValue = "";

            // StudentSignXCordinate
            StudentSignXCordinate.HrefValue = "";
            StudentSignXCordinate.TooltipValue = "";

            // StudentSignYCordinate
            StudentSignYCordinate.HrefValue = "";
            StudentSignYCordinate.TooltipValue = "";

            // ParentSignXCordinate
            ParentSignXCordinate.HrefValue = "";
            ParentSignXCordinate.TooltipValue = "";

            // ParentSignYCordinate
            ParentSignYCordinate.HrefValue = "";
            ParentSignYCordinate.TooltipValue = "";

            // ParentSignPageNo
            ParentSignPageNo.HrefValue = "";
            ParentSignPageNo.TooltipValue = "";

            // StudentSignPageNo
            StudentSignPageNo.HrefValue = "";
            StudentSignPageNo.TooltipValue = "";

            // int_CDLProgramType
            int_CDLProgramType.HrefValue = "";
            int_CDLProgramType.TooltipValue = "";

            // int_CDLEndorsementCode
            int_CDLEndorsementCode.HrefValue = "";
            int_CDLEndorsementCode.TooltipValue = "";

            // int_CDLClassroom
            int_CDLClassroom.HrefValue = "";
            int_CDLClassroom.TooltipValue = "";

            // int_CDLRange
            int_CDLRange.HrefValue = "";
            int_CDLRange.TooltipValue = "";

            // int_CDLRoad
            int_CDLRoad.HrefValue = "";
            int_CDLRoad.TooltipValue = "";

            // bit_TPR_Package
            bit_TPR_Package.HrefValue = "";
            bit_TPR_Package.TooltipValue = "";

            // licenseTypeId
            licenseTypeId.HrefValue = "";
            licenseTypeId.TooltipValue = "";

            // bit_IsServiceForCertification
            bit_IsServiceForCertification.HrefValue = "";
            bit_IsServiceForCertification.TooltipValue = "";

            // intMinAgeYearToEnroll
            intMinAgeYearToEnroll.HrefValue = "";
            intMinAgeYearToEnroll.TooltipValue = "";

            // intMinAgeMonthToEnroll
            intMinAgeMonthToEnroll.HrefValue = "";
            intMinAgeMonthToEnroll.TooltipValue = "";

            // intMaxAgeYearToEnroll
            intMaxAgeYearToEnroll.HrefValue = "";
            intMaxAgeYearToEnroll.TooltipValue = "";

            // intMaxAgeMonthToEnroll
            intMaxAgeMonthToEnroll.HrefValue = "";
            intMaxAgeMonthToEnroll.TooltipValue = "";

            // intCompletionDeadlineYear
            intCompletionDeadlineYear.HrefValue = "";
            intCompletionDeadlineYear.TooltipValue = "";

            // intCompletionDeadlineMonth
            intCompletionDeadlineMonth.HrefValue = "";
            intCompletionDeadlineMonth.TooltipValue = "";

            // intCompletionDeadlineDay
            intCompletionDeadlineDay.HrefValue = "";
            intCompletionDeadlineDay.TooltipValue = "";

            // intCompletionDeadlineFrom
            intCompletionDeadlineFrom.HrefValue = "";
            intCompletionDeadlineFrom.TooltipValue = "";

            // bit_IsTexable
            bit_IsTexable.HrefValue = "";
            bit_IsTexable.TooltipValue = "";

            // str_Base_price
            str_Base_price.HrefValue = "";
            str_Base_price.TooltipValue = "";

            // str_Tax
            str_Tax.HrefValue = "";
            str_Tax.TooltipValue = "";

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

            // int_Package_Id
            int_Package_Id.SetupEditAttributes();
            int_Package_Id.EditValue = int_Package_Id.CurrentValue; // DN
            int_Package_Id.PlaceHolder = RemoveHtml(int_Package_Id.Caption);
            if (!Empty(int_Package_Id.EditValue) && IsNumeric(int_Package_Id.EditValue))
                int_Package_Id.EditValue = FormatNumber(int_Package_Id.EditValue, null);

            // str_Package_Name
            str_Package_Name.SetupEditAttributes();
            if (!str_Package_Name.Raw)
                str_Package_Name.CurrentValue = HtmlDecode(str_Package_Name.CurrentValue);
            str_Package_Name.EditValue = HtmlEncode(str_Package_Name.CurrentValue);
            str_Package_Name.PlaceHolder = RemoveHtml(str_Package_Name.Caption);

            // str_Package_Code
            str_Package_Code.SetupEditAttributes();
            if (!str_Package_Code.Raw)
                str_Package_Code.CurrentValue = HtmlDecode(str_Package_Code.CurrentValue);
            str_Package_Code.EditValue = HtmlEncode(str_Package_Code.CurrentValue);
            str_Package_Code.PlaceHolder = RemoveHtml(str_Package_Code.Caption);

            // int_Status
            int_Status.SetupEditAttributes();
            int_Status.EditValue = int_Status.CurrentValue; // DN
            int_Status.PlaceHolder = RemoveHtml(int_Status.Caption);
            if (!Empty(int_Status.EditValue) && IsNumeric(int_Status.EditValue))
                int_Status.EditValue = FormatNumber(int_Status.EditValue, null);

            // str_Discount
            str_Discount.SetupEditAttributes();
            if (!str_Discount.Raw)
                str_Discount.CurrentValue = HtmlDecode(str_Discount.CurrentValue);
            str_Discount.EditValue = HtmlEncode(str_Discount.CurrentValue);
            str_Discount.PlaceHolder = RemoveHtml(str_Discount.Caption);

            // mny_Price
            mny_Price.SetupEditAttributes();
            mny_Price.EditValue = mny_Price.CurrentValue; // DN
            mny_Price.PlaceHolder = RemoveHtml(mny_Price.Caption);
            if (!Empty(mny_Price.EditValue) && IsNumeric(mny_Price.EditValue))
                mny_Price.EditValue = FormatNumber(mny_Price.EditValue, null);

            // str_Notes
            str_Notes.SetupEditAttributes();
            if (!str_Notes.Raw)
                str_Notes.CurrentValue = HtmlDecode(str_Notes.CurrentValue);
            str_Notes.EditValue = HtmlEncode(str_Notes.CurrentValue);
            str_Notes.PlaceHolder = RemoveHtml(str_Notes.Caption);

            // bit_IswebSignUp
            bit_IswebSignUp.EditValue = bit_IswebSignUp.Options(false);
            bit_IswebSignUp.PlaceHolder = RemoveHtml(bit_IswebSignUp.Caption);

            // str_Items
            str_Items.SetupEditAttributes();
            if (!str_Items.Raw)
                str_Items.CurrentValue = HtmlDecode(str_Items.CurrentValue);
            str_Items.EditValue = HtmlEncode(str_Items.CurrentValue);
            str_Items.PlaceHolder = RemoveHtml(str_Items.Caption);

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
            date_Created.SetupEditAttributes();
            date_Created.EditValue = FormatDateTime(date_Created.CurrentValue, date_Created.FormatPattern); // DN
            date_Created.PlaceHolder = RemoveHtml(date_Created.Caption);

            // date_Modified
            date_Modified.SetupEditAttributes();
            date_Modified.EditValue = FormatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern); // DN
            date_Modified.PlaceHolder = RemoveHtml(date_Modified.Caption);

            // bit_IsDeleted
            bit_IsDeleted.EditValue = bit_IsDeleted.Options(false);
            bit_IsDeleted.PlaceHolder = RemoveHtml(bit_IsDeleted.Caption);

            // str_WebDescription
            str_WebDescription.SetupEditAttributes();
            str_WebDescription.EditValue = str_WebDescription.CurrentValue; // DN
            str_WebDescription.PlaceHolder = RemoveHtml(str_WebDescription.Caption);

            // bit_PortalPurchase
            bit_PortalPurchase.EditValue = bit_PortalPurchase.Options(false);
            bit_PortalPurchase.PlaceHolder = RemoveHtml(bit_PortalPurchase.Caption);

            // str_WebName
            str_WebName.SetupEditAttributes();
            if (!str_WebName.Raw)
                str_WebName.CurrentValue = HtmlDecode(str_WebName.CurrentValue);
            str_WebName.EditValue = HtmlEncode(str_WebName.CurrentValue);
            str_WebName.PlaceHolder = RemoveHtml(str_WebName.Caption);

            // bit_ExtraChk1
            bit_ExtraChk1.EditValue = bit_ExtraChk1.Options(false);
            bit_ExtraChk1.PlaceHolder = RemoveHtml(bit_ExtraChk1.Caption);

            // bit_ExtraChk2
            bit_ExtraChk2.EditValue = bit_ExtraChk2.Options(false);
            bit_ExtraChk2.PlaceHolder = RemoveHtml(bit_ExtraChk2.Caption);

            // str_ExtraDrpDown1
            str_ExtraDrpDown1.SetupEditAttributes();
            if (!str_ExtraDrpDown1.Raw)
                str_ExtraDrpDown1.CurrentValue = HtmlDecode(str_ExtraDrpDown1.CurrentValue);
            str_ExtraDrpDown1.EditValue = HtmlEncode(str_ExtraDrpDown1.CurrentValue);
            str_ExtraDrpDown1.PlaceHolder = RemoveHtml(str_ExtraDrpDown1.Caption);

            // str_ExtraDrpDown2
            str_ExtraDrpDown2.SetupEditAttributes();
            if (!str_ExtraDrpDown2.Raw)
                str_ExtraDrpDown2.CurrentValue = HtmlDecode(str_ExtraDrpDown2.CurrentValue);
            str_ExtraDrpDown2.EditValue = HtmlEncode(str_ExtraDrpDown2.CurrentValue);
            str_ExtraDrpDown2.PlaceHolder = RemoveHtml(str_ExtraDrpDown2.Caption);

            // str_Extratxt1
            str_Extratxt1.SetupEditAttributes();
            if (!str_Extratxt1.Raw)
                str_Extratxt1.CurrentValue = HtmlDecode(str_Extratxt1.CurrentValue);
            str_Extratxt1.EditValue = HtmlEncode(str_Extratxt1.CurrentValue);
            str_Extratxt1.PlaceHolder = RemoveHtml(str_Extratxt1.Caption);

            // str_Extratxt2
            str_Extratxt2.SetupEditAttributes();
            if (!str_Extratxt2.Raw)
                str_Extratxt2.CurrentValue = HtmlDecode(str_Extratxt2.CurrentValue);
            str_Extratxt2.EditValue = HtmlEncode(str_Extratxt2.CurrentValue);
            str_Extratxt2.PlaceHolder = RemoveHtml(str_Extratxt2.Caption);

            // is_Show
            is_Show.EditValue = is_Show.Options(false);
            is_Show.PlaceHolder = RemoveHtml(is_Show.Caption);

            // is_ShowGridColumn
            is_ShowGridColumn.EditValue = is_ShowGridColumn.Options(false);
            is_ShowGridColumn.PlaceHolder = RemoveHtml(is_ShowGridColumn.Caption);

            // rowIndex
            rowIndex.SetupEditAttributes();
            if (!rowIndex.Raw)
                rowIndex.CurrentValue = HtmlDecode(rowIndex.CurrentValue);
            rowIndex.EditValue = HtmlEncode(rowIndex.CurrentValue);
            rowIndex.PlaceHolder = RemoveHtml(rowIndex.Caption);

            // bit_referral
            bit_referral.EditValue = bit_referral.Options(false);
            bit_referral.PlaceHolder = RemoveHtml(bit_referral.Caption);

            // str_Locations
            str_Locations.SetupEditAttributes();
            str_Locations.EditValue = str_Locations.CurrentValue; // DN
            str_Locations.PlaceHolder = RemoveHtml(str_Locations.Caption);

            // str_PackageType
            str_PackageType.SetupEditAttributes();
            if (!str_PackageType.Raw)
                str_PackageType.CurrentValue = HtmlDecode(str_PackageType.CurrentValue);
            str_PackageType.EditValue = HtmlEncode(str_PackageType.CurrentValue);
            str_PackageType.PlaceHolder = RemoveHtml(str_PackageType.Caption);

            // int_ParentClass_Id
            int_ParentClass_Id.SetupEditAttributes();
            int_ParentClass_Id.EditValue = int_ParentClass_Id.CurrentValue; // DN
            int_ParentClass_Id.PlaceHolder = RemoveHtml(int_ParentClass_Id.Caption);
            if (!Empty(int_ParentClass_Id.EditValue) && IsNumeric(int_ParentClass_Id.EditValue))
                int_ParentClass_Id.EditValue = FormatNumber(int_ParentClass_Id.EditValue, null);

            // str_CRcostHour
            str_CRcostHour.SetupEditAttributes();
            str_CRcostHour.EditValue = str_CRcostHour.CurrentValue; // DN
            str_CRcostHour.PlaceHolder = RemoveHtml(str_CRcostHour.Caption);
            if (!Empty(str_CRcostHour.EditValue) && IsNumeric(str_CRcostHour.EditValue))
                str_CRcostHour.EditValue = FormatNumber(str_CRcostHour.EditValue, null);

            // str_BTWcostHour
            str_BTWcostHour.SetupEditAttributes();
            str_BTWcostHour.EditValue = str_BTWcostHour.CurrentValue; // DN
            str_BTWcostHour.PlaceHolder = RemoveHtml(str_BTWcostHour.Caption);
            if (!Empty(str_BTWcostHour.EditValue) && IsNumeric(str_BTWcostHour.EditValue))
                str_BTWcostHour.EditValue = FormatNumber(str_BTWcostHour.EditValue, null);

            // bit_OfferSpanishServices
            bit_OfferSpanishServices.EditValue = bit_OfferSpanishServices.Options(false);
            bit_OfferSpanishServices.PlaceHolder = RemoveHtml(bit_OfferSpanishServices.Caption);

            // ByPassCRSelectionCentralizedOE
            ByPassCRSelectionCentralizedOE.EditValue = ByPassCRSelectionCentralizedOE.Options(false);
            ByPassCRSelectionCentralizedOE.PlaceHolder = RemoveHtml(ByPassCRSelectionCentralizedOE.Caption);

            // str_WebNameArabic
            str_WebNameArabic.SetupEditAttributes();
            if (!str_WebNameArabic.Raw)
                str_WebNameArabic.CurrentValue = HtmlDecode(str_WebNameArabic.CurrentValue);
            str_WebNameArabic.EditValue = HtmlEncode(str_WebNameArabic.CurrentValue);
            str_WebNameArabic.PlaceHolder = RemoveHtml(str_WebNameArabic.Caption);

            // str_WebDescriptionArabic
            str_WebDescriptionArabic.SetupEditAttributes();
            str_WebDescriptionArabic.EditValue = str_WebDescriptionArabic.CurrentValue; // DN
            str_WebDescriptionArabic.PlaceHolder = RemoveHtml(str_WebDescriptionArabic.Caption);

            // PackageContractType
            PackageContractType.SetupEditAttributes();
            PackageContractType.EditValue = PackageContractType.CurrentValue; // DN
            PackageContractType.PlaceHolder = RemoveHtml(PackageContractType.Caption);
            if (!Empty(PackageContractType.EditValue) && IsNumeric(PackageContractType.EditValue))
                PackageContractType.EditValue = FormatNumber(PackageContractType.EditValue, null);

            // blob_path
            blob_path.SetupEditAttributes();
            blob_path.EditValue = blob_path.CurrentValue; // DN
            blob_path.PlaceHolder = RemoveHtml(blob_path.Caption);

            // StudentSignXCordinate
            StudentSignXCordinate.SetupEditAttributes();
            StudentSignXCordinate.EditValue = StudentSignXCordinate.CurrentValue; // DN
            StudentSignXCordinate.PlaceHolder = RemoveHtml(StudentSignXCordinate.Caption);
            if (!Empty(StudentSignXCordinate.EditValue) && IsNumeric(StudentSignXCordinate.EditValue))
                StudentSignXCordinate.EditValue = FormatNumber(StudentSignXCordinate.EditValue, null);

            // StudentSignYCordinate
            StudentSignYCordinate.SetupEditAttributes();
            StudentSignYCordinate.EditValue = StudentSignYCordinate.CurrentValue; // DN
            StudentSignYCordinate.PlaceHolder = RemoveHtml(StudentSignYCordinate.Caption);
            if (!Empty(StudentSignYCordinate.EditValue) && IsNumeric(StudentSignYCordinate.EditValue))
                StudentSignYCordinate.EditValue = FormatNumber(StudentSignYCordinate.EditValue, null);

            // ParentSignXCordinate
            ParentSignXCordinate.SetupEditAttributes();
            ParentSignXCordinate.EditValue = ParentSignXCordinate.CurrentValue; // DN
            ParentSignXCordinate.PlaceHolder = RemoveHtml(ParentSignXCordinate.Caption);
            if (!Empty(ParentSignXCordinate.EditValue) && IsNumeric(ParentSignXCordinate.EditValue))
                ParentSignXCordinate.EditValue = FormatNumber(ParentSignXCordinate.EditValue, null);

            // ParentSignYCordinate
            ParentSignYCordinate.SetupEditAttributes();
            ParentSignYCordinate.EditValue = ParentSignYCordinate.CurrentValue; // DN
            ParentSignYCordinate.PlaceHolder = RemoveHtml(ParentSignYCordinate.Caption);
            if (!Empty(ParentSignYCordinate.EditValue) && IsNumeric(ParentSignYCordinate.EditValue))
                ParentSignYCordinate.EditValue = FormatNumber(ParentSignYCordinate.EditValue, null);

            // ParentSignPageNo
            ParentSignPageNo.SetupEditAttributes();
            ParentSignPageNo.EditValue = ParentSignPageNo.CurrentValue; // DN
            ParentSignPageNo.PlaceHolder = RemoveHtml(ParentSignPageNo.Caption);
            if (!Empty(ParentSignPageNo.EditValue) && IsNumeric(ParentSignPageNo.EditValue))
                ParentSignPageNo.EditValue = FormatNumber(ParentSignPageNo.EditValue, null);

            // StudentSignPageNo
            StudentSignPageNo.SetupEditAttributes();
            StudentSignPageNo.EditValue = StudentSignPageNo.CurrentValue; // DN
            StudentSignPageNo.PlaceHolder = RemoveHtml(StudentSignPageNo.Caption);
            if (!Empty(StudentSignPageNo.EditValue) && IsNumeric(StudentSignPageNo.EditValue))
                StudentSignPageNo.EditValue = FormatNumber(StudentSignPageNo.EditValue, null);

            // int_CDLProgramType
            int_CDLProgramType.SetupEditAttributes();
            int_CDLProgramType.EditValue = int_CDLProgramType.CurrentValue; // DN
            int_CDLProgramType.PlaceHolder = RemoveHtml(int_CDLProgramType.Caption);
            if (!Empty(int_CDLProgramType.EditValue) && IsNumeric(int_CDLProgramType.EditValue))
                int_CDLProgramType.EditValue = FormatNumber(int_CDLProgramType.EditValue, null);

            // int_CDLEndorsementCode
            int_CDLEndorsementCode.SetupEditAttributes();
            int_CDLEndorsementCode.EditValue = int_CDLEndorsementCode.CurrentValue; // DN
            int_CDLEndorsementCode.PlaceHolder = RemoveHtml(int_CDLEndorsementCode.Caption);
            if (!Empty(int_CDLEndorsementCode.EditValue) && IsNumeric(int_CDLEndorsementCode.EditValue))
                int_CDLEndorsementCode.EditValue = FormatNumber(int_CDLEndorsementCode.EditValue, null);

            // int_CDLClassroom
            int_CDLClassroom.SetupEditAttributes();
            int_CDLClassroom.EditValue = int_CDLClassroom.CurrentValue; // DN
            int_CDLClassroom.PlaceHolder = RemoveHtml(int_CDLClassroom.Caption);
            if (!Empty(int_CDLClassroom.EditValue) && IsNumeric(int_CDLClassroom.EditValue))
                int_CDLClassroom.EditValue = FormatNumber(int_CDLClassroom.EditValue, null);

            // int_CDLRange
            int_CDLRange.SetupEditAttributes();
            int_CDLRange.EditValue = int_CDLRange.CurrentValue; // DN
            int_CDLRange.PlaceHolder = RemoveHtml(int_CDLRange.Caption);
            if (!Empty(int_CDLRange.EditValue) && IsNumeric(int_CDLRange.EditValue))
                int_CDLRange.EditValue = FormatNumber(int_CDLRange.EditValue, null);

            // int_CDLRoad
            int_CDLRoad.SetupEditAttributes();
            int_CDLRoad.EditValue = int_CDLRoad.CurrentValue; // DN
            int_CDLRoad.PlaceHolder = RemoveHtml(int_CDLRoad.Caption);
            if (!Empty(int_CDLRoad.EditValue) && IsNumeric(int_CDLRoad.EditValue))
                int_CDLRoad.EditValue = FormatNumber(int_CDLRoad.EditValue, null);

            // bit_TPR_Package
            bit_TPR_Package.EditValue = bit_TPR_Package.Options(false);
            bit_TPR_Package.PlaceHolder = RemoveHtml(bit_TPR_Package.Caption);

            // licenseTypeId
            licenseTypeId.SetupEditAttributes();
            licenseTypeId.EditValue = licenseTypeId.CurrentValue; // DN
            licenseTypeId.PlaceHolder = RemoveHtml(licenseTypeId.Caption);
            if (!Empty(licenseTypeId.EditValue) && IsNumeric(licenseTypeId.EditValue))
                licenseTypeId.EditValue = FormatNumber(licenseTypeId.EditValue, null);

            // bit_IsServiceForCertification
            bit_IsServiceForCertification.EditValue = bit_IsServiceForCertification.Options(false);
            bit_IsServiceForCertification.PlaceHolder = RemoveHtml(bit_IsServiceForCertification.Caption);

            // intMinAgeYearToEnroll
            intMinAgeYearToEnroll.SetupEditAttributes();
            if (!intMinAgeYearToEnroll.Raw)
                intMinAgeYearToEnroll.CurrentValue = HtmlDecode(intMinAgeYearToEnroll.CurrentValue);
            intMinAgeYearToEnroll.EditValue = HtmlEncode(intMinAgeYearToEnroll.CurrentValue);
            intMinAgeYearToEnroll.PlaceHolder = RemoveHtml(intMinAgeYearToEnroll.Caption);

            // intMinAgeMonthToEnroll
            intMinAgeMonthToEnroll.SetupEditAttributes();
            if (!intMinAgeMonthToEnroll.Raw)
                intMinAgeMonthToEnroll.CurrentValue = HtmlDecode(intMinAgeMonthToEnroll.CurrentValue);
            intMinAgeMonthToEnroll.EditValue = HtmlEncode(intMinAgeMonthToEnroll.CurrentValue);
            intMinAgeMonthToEnroll.PlaceHolder = RemoveHtml(intMinAgeMonthToEnroll.Caption);

            // intMaxAgeYearToEnroll
            intMaxAgeYearToEnroll.SetupEditAttributes();
            if (!intMaxAgeYearToEnroll.Raw)
                intMaxAgeYearToEnroll.CurrentValue = HtmlDecode(intMaxAgeYearToEnroll.CurrentValue);
            intMaxAgeYearToEnroll.EditValue = HtmlEncode(intMaxAgeYearToEnroll.CurrentValue);
            intMaxAgeYearToEnroll.PlaceHolder = RemoveHtml(intMaxAgeYearToEnroll.Caption);

            // intMaxAgeMonthToEnroll
            intMaxAgeMonthToEnroll.SetupEditAttributes();
            if (!intMaxAgeMonthToEnroll.Raw)
                intMaxAgeMonthToEnroll.CurrentValue = HtmlDecode(intMaxAgeMonthToEnroll.CurrentValue);
            intMaxAgeMonthToEnroll.EditValue = HtmlEncode(intMaxAgeMonthToEnroll.CurrentValue);
            intMaxAgeMonthToEnroll.PlaceHolder = RemoveHtml(intMaxAgeMonthToEnroll.Caption);

            // intCompletionDeadlineYear
            intCompletionDeadlineYear.SetupEditAttributes();
            if (!intCompletionDeadlineYear.Raw)
                intCompletionDeadlineYear.CurrentValue = HtmlDecode(intCompletionDeadlineYear.CurrentValue);
            intCompletionDeadlineYear.EditValue = HtmlEncode(intCompletionDeadlineYear.CurrentValue);
            intCompletionDeadlineYear.PlaceHolder = RemoveHtml(intCompletionDeadlineYear.Caption);

            // intCompletionDeadlineMonth
            intCompletionDeadlineMonth.SetupEditAttributes();
            if (!intCompletionDeadlineMonth.Raw)
                intCompletionDeadlineMonth.CurrentValue = HtmlDecode(intCompletionDeadlineMonth.CurrentValue);
            intCompletionDeadlineMonth.EditValue = HtmlEncode(intCompletionDeadlineMonth.CurrentValue);
            intCompletionDeadlineMonth.PlaceHolder = RemoveHtml(intCompletionDeadlineMonth.Caption);

            // intCompletionDeadlineDay
            intCompletionDeadlineDay.SetupEditAttributes();
            if (!intCompletionDeadlineDay.Raw)
                intCompletionDeadlineDay.CurrentValue = HtmlDecode(intCompletionDeadlineDay.CurrentValue);
            intCompletionDeadlineDay.EditValue = HtmlEncode(intCompletionDeadlineDay.CurrentValue);
            intCompletionDeadlineDay.PlaceHolder = RemoveHtml(intCompletionDeadlineDay.Caption);

            // intCompletionDeadlineFrom
            intCompletionDeadlineFrom.SetupEditAttributes();
            if (!intCompletionDeadlineFrom.Raw)
                intCompletionDeadlineFrom.CurrentValue = HtmlDecode(intCompletionDeadlineFrom.CurrentValue);
            intCompletionDeadlineFrom.EditValue = HtmlEncode(intCompletionDeadlineFrom.CurrentValue);
            intCompletionDeadlineFrom.PlaceHolder = RemoveHtml(intCompletionDeadlineFrom.Caption);

            // bit_IsTexable
            bit_IsTexable.EditValue = bit_IsTexable.Options(false);
            bit_IsTexable.PlaceHolder = RemoveHtml(bit_IsTexable.Caption);

            // str_Base_price
            str_Base_price.SetupEditAttributes();
            if (!str_Base_price.Raw)
                str_Base_price.CurrentValue = HtmlDecode(str_Base_price.CurrentValue);
            str_Base_price.EditValue = HtmlEncode(str_Base_price.CurrentValue);
            str_Base_price.PlaceHolder = RemoveHtml(str_Base_price.Caption);

            // str_Tax
            str_Tax.SetupEditAttributes();
            if (!str_Tax.Raw)
                str_Tax.CurrentValue = HtmlDecode(str_Tax.CurrentValue);
            str_Tax.EditValue = HtmlEncode(str_Tax.CurrentValue);
            str_Tax.PlaceHolder = RemoveHtml(str_Tax.Caption);

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
                        doc.ExportCaption(int_Package_Id);
                        doc.ExportCaption(str_Package_Name);
                        doc.ExportCaption(str_Package_Code);
                        doc.ExportCaption(int_Status);
                        doc.ExportCaption(str_Discount);
                        doc.ExportCaption(mny_Price);
                        doc.ExportCaption(str_Notes);
                        doc.ExportCaption(bit_IswebSignUp);
                        doc.ExportCaption(str_Items);
                        doc.ExportCaption(int_Created_By);
                        doc.ExportCaption(int_Modified_By);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(bit_IsDeleted);
                        doc.ExportCaption(str_WebDescription);
                        doc.ExportCaption(bit_PortalPurchase);
                        doc.ExportCaption(str_WebName);
                        doc.ExportCaption(bit_ExtraChk1);
                        doc.ExportCaption(bit_ExtraChk2);
                        doc.ExportCaption(str_ExtraDrpDown1);
                        doc.ExportCaption(str_ExtraDrpDown2);
                        doc.ExportCaption(str_Extratxt1);
                        doc.ExportCaption(str_Extratxt2);
                        doc.ExportCaption(is_Show);
                        doc.ExportCaption(is_ShowGridColumn);
                        doc.ExportCaption(rowIndex);
                        doc.ExportCaption(bit_referral);
                        doc.ExportCaption(str_Locations);
                        doc.ExportCaption(str_PackageType);
                        doc.ExportCaption(int_ParentClass_Id);
                        doc.ExportCaption(str_CRcostHour);
                        doc.ExportCaption(str_BTWcostHour);
                        doc.ExportCaption(bit_OfferSpanishServices);
                        doc.ExportCaption(ByPassCRSelectionCentralizedOE);
                        doc.ExportCaption(str_WebNameArabic);
                        doc.ExportCaption(str_WebDescriptionArabic);
                        doc.ExportCaption(PackageContractType);
                        doc.ExportCaption(blob_path);
                        doc.ExportCaption(StudentSignXCordinate);
                        doc.ExportCaption(StudentSignYCordinate);
                        doc.ExportCaption(ParentSignXCordinate);
                        doc.ExportCaption(ParentSignYCordinate);
                        doc.ExportCaption(ParentSignPageNo);
                        doc.ExportCaption(StudentSignPageNo);
                        doc.ExportCaption(int_CDLProgramType);
                        doc.ExportCaption(int_CDLEndorsementCode);
                        doc.ExportCaption(int_CDLClassroom);
                        doc.ExportCaption(int_CDLRange);
                        doc.ExportCaption(int_CDLRoad);
                        doc.ExportCaption(bit_TPR_Package);
                        doc.ExportCaption(licenseTypeId);
                        doc.ExportCaption(bit_IsServiceForCertification);
                        doc.ExportCaption(intMinAgeYearToEnroll);
                        doc.ExportCaption(intMinAgeMonthToEnroll);
                        doc.ExportCaption(intMaxAgeYearToEnroll);
                        doc.ExportCaption(intMaxAgeMonthToEnroll);
                        doc.ExportCaption(intCompletionDeadlineYear);
                        doc.ExportCaption(intCompletionDeadlineMonth);
                        doc.ExportCaption(intCompletionDeadlineDay);
                        doc.ExportCaption(intCompletionDeadlineFrom);
                        doc.ExportCaption(bit_IsTexable);
                        doc.ExportCaption(str_Base_price);
                        doc.ExportCaption(str_Tax);
                    } else {
                        doc.ExportCaption(int_Package_Id);
                        doc.ExportCaption(str_Package_Name);
                        doc.ExportCaption(str_Package_Code);
                        doc.ExportCaption(int_Status);
                        doc.ExportCaption(str_Discount);
                        doc.ExportCaption(mny_Price);
                        doc.ExportCaption(str_Notes);
                        doc.ExportCaption(bit_IswebSignUp);
                        doc.ExportCaption(str_Items);
                        doc.ExportCaption(int_Created_By);
                        doc.ExportCaption(int_Modified_By);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(bit_IsDeleted);
                        doc.ExportCaption(bit_PortalPurchase);
                        doc.ExportCaption(str_WebName);
                        doc.ExportCaption(bit_ExtraChk1);
                        doc.ExportCaption(bit_ExtraChk2);
                        doc.ExportCaption(str_ExtraDrpDown1);
                        doc.ExportCaption(str_ExtraDrpDown2);
                        doc.ExportCaption(str_Extratxt1);
                        doc.ExportCaption(str_Extratxt2);
                        doc.ExportCaption(is_Show);
                        doc.ExportCaption(is_ShowGridColumn);
                        doc.ExportCaption(rowIndex);
                        doc.ExportCaption(bit_referral);
                        doc.ExportCaption(str_PackageType);
                        doc.ExportCaption(int_ParentClass_Id);
                        doc.ExportCaption(str_CRcostHour);
                        doc.ExportCaption(str_BTWcostHour);
                        doc.ExportCaption(bit_OfferSpanishServices);
                        doc.ExportCaption(ByPassCRSelectionCentralizedOE);
                        doc.ExportCaption(str_WebNameArabic);
                        doc.ExportCaption(PackageContractType);
                        doc.ExportCaption(StudentSignXCordinate);
                        doc.ExportCaption(StudentSignYCordinate);
                        doc.ExportCaption(ParentSignXCordinate);
                        doc.ExportCaption(ParentSignYCordinate);
                        doc.ExportCaption(ParentSignPageNo);
                        doc.ExportCaption(StudentSignPageNo);
                        doc.ExportCaption(int_CDLProgramType);
                        doc.ExportCaption(int_CDLEndorsementCode);
                        doc.ExportCaption(int_CDLClassroom);
                        doc.ExportCaption(int_CDLRange);
                        doc.ExportCaption(int_CDLRoad);
                        doc.ExportCaption(bit_TPR_Package);
                        doc.ExportCaption(licenseTypeId);
                        doc.ExportCaption(bit_IsServiceForCertification);
                        doc.ExportCaption(intMinAgeYearToEnroll);
                        doc.ExportCaption(intMinAgeMonthToEnroll);
                        doc.ExportCaption(intMaxAgeYearToEnroll);
                        doc.ExportCaption(intMaxAgeMonthToEnroll);
                        doc.ExportCaption(intCompletionDeadlineYear);
                        doc.ExportCaption(intCompletionDeadlineMonth);
                        doc.ExportCaption(intCompletionDeadlineDay);
                        doc.ExportCaption(intCompletionDeadlineFrom);
                        doc.ExportCaption(bit_IsTexable);
                        doc.ExportCaption(str_Base_price);
                        doc.ExportCaption(str_Tax);
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
                            await doc.ExportField(int_Package_Id);
                            await doc.ExportField(str_Package_Name);
                            await doc.ExportField(str_Package_Code);
                            await doc.ExportField(int_Status);
                            await doc.ExportField(str_Discount);
                            await doc.ExportField(mny_Price);
                            await doc.ExportField(str_Notes);
                            await doc.ExportField(bit_IswebSignUp);
                            await doc.ExportField(str_Items);
                            await doc.ExportField(int_Created_By);
                            await doc.ExportField(int_Modified_By);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(bit_IsDeleted);
                            await doc.ExportField(str_WebDescription);
                            await doc.ExportField(bit_PortalPurchase);
                            await doc.ExportField(str_WebName);
                            await doc.ExportField(bit_ExtraChk1);
                            await doc.ExportField(bit_ExtraChk2);
                            await doc.ExportField(str_ExtraDrpDown1);
                            await doc.ExportField(str_ExtraDrpDown2);
                            await doc.ExportField(str_Extratxt1);
                            await doc.ExportField(str_Extratxt2);
                            await doc.ExportField(is_Show);
                            await doc.ExportField(is_ShowGridColumn);
                            await doc.ExportField(rowIndex);
                            await doc.ExportField(bit_referral);
                            await doc.ExportField(str_Locations);
                            await doc.ExportField(str_PackageType);
                            await doc.ExportField(int_ParentClass_Id);
                            await doc.ExportField(str_CRcostHour);
                            await doc.ExportField(str_BTWcostHour);
                            await doc.ExportField(bit_OfferSpanishServices);
                            await doc.ExportField(ByPassCRSelectionCentralizedOE);
                            await doc.ExportField(str_WebNameArabic);
                            await doc.ExportField(str_WebDescriptionArabic);
                            await doc.ExportField(PackageContractType);
                            await doc.ExportField(blob_path);
                            await doc.ExportField(StudentSignXCordinate);
                            await doc.ExportField(StudentSignYCordinate);
                            await doc.ExportField(ParentSignXCordinate);
                            await doc.ExportField(ParentSignYCordinate);
                            await doc.ExportField(ParentSignPageNo);
                            await doc.ExportField(StudentSignPageNo);
                            await doc.ExportField(int_CDLProgramType);
                            await doc.ExportField(int_CDLEndorsementCode);
                            await doc.ExportField(int_CDLClassroom);
                            await doc.ExportField(int_CDLRange);
                            await doc.ExportField(int_CDLRoad);
                            await doc.ExportField(bit_TPR_Package);
                            await doc.ExportField(licenseTypeId);
                            await doc.ExportField(bit_IsServiceForCertification);
                            await doc.ExportField(intMinAgeYearToEnroll);
                            await doc.ExportField(intMinAgeMonthToEnroll);
                            await doc.ExportField(intMaxAgeYearToEnroll);
                            await doc.ExportField(intMaxAgeMonthToEnroll);
                            await doc.ExportField(intCompletionDeadlineYear);
                            await doc.ExportField(intCompletionDeadlineMonth);
                            await doc.ExportField(intCompletionDeadlineDay);
                            await doc.ExportField(intCompletionDeadlineFrom);
                            await doc.ExportField(bit_IsTexable);
                            await doc.ExportField(str_Base_price);
                            await doc.ExportField(str_Tax);
                        } else {
                            await doc.ExportField(int_Package_Id);
                            await doc.ExportField(str_Package_Name);
                            await doc.ExportField(str_Package_Code);
                            await doc.ExportField(int_Status);
                            await doc.ExportField(str_Discount);
                            await doc.ExportField(mny_Price);
                            await doc.ExportField(str_Notes);
                            await doc.ExportField(bit_IswebSignUp);
                            await doc.ExportField(str_Items);
                            await doc.ExportField(int_Created_By);
                            await doc.ExportField(int_Modified_By);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(bit_IsDeleted);
                            await doc.ExportField(bit_PortalPurchase);
                            await doc.ExportField(str_WebName);
                            await doc.ExportField(bit_ExtraChk1);
                            await doc.ExportField(bit_ExtraChk2);
                            await doc.ExportField(str_ExtraDrpDown1);
                            await doc.ExportField(str_ExtraDrpDown2);
                            await doc.ExportField(str_Extratxt1);
                            await doc.ExportField(str_Extratxt2);
                            await doc.ExportField(is_Show);
                            await doc.ExportField(is_ShowGridColumn);
                            await doc.ExportField(rowIndex);
                            await doc.ExportField(bit_referral);
                            await doc.ExportField(str_PackageType);
                            await doc.ExportField(int_ParentClass_Id);
                            await doc.ExportField(str_CRcostHour);
                            await doc.ExportField(str_BTWcostHour);
                            await doc.ExportField(bit_OfferSpanishServices);
                            await doc.ExportField(ByPassCRSelectionCentralizedOE);
                            await doc.ExportField(str_WebNameArabic);
                            await doc.ExportField(PackageContractType);
                            await doc.ExportField(StudentSignXCordinate);
                            await doc.ExportField(StudentSignYCordinate);
                            await doc.ExportField(ParentSignXCordinate);
                            await doc.ExportField(ParentSignYCordinate);
                            await doc.ExportField(ParentSignPageNo);
                            await doc.ExportField(StudentSignPageNo);
                            await doc.ExportField(int_CDLProgramType);
                            await doc.ExportField(int_CDLEndorsementCode);
                            await doc.ExportField(int_CDLClassroom);
                            await doc.ExportField(int_CDLRange);
                            await doc.ExportField(int_CDLRoad);
                            await doc.ExportField(bit_TPR_Package);
                            await doc.ExportField(licenseTypeId);
                            await doc.ExportField(bit_IsServiceForCertification);
                            await doc.ExportField(intMinAgeYearToEnroll);
                            await doc.ExportField(intMinAgeMonthToEnroll);
                            await doc.ExportField(intMaxAgeYearToEnroll);
                            await doc.ExportField(intMaxAgeMonthToEnroll);
                            await doc.ExportField(intCompletionDeadlineYear);
                            await doc.ExportField(intCompletionDeadlineMonth);
                            await doc.ExportField(intCompletionDeadlineDay);
                            await doc.ExportField(intCompletionDeadlineFrom);
                            await doc.ExportField(bit_IsTexable);
                            await doc.ExportField(str_Base_price);
                            await doc.ExportField(str_Tax);
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
