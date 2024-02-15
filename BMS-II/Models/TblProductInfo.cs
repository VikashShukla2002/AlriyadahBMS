namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblProductInfo
    /// </summary>
    [MaybeNull]
    public static TblProductInfo tblProductInfo
    {
        get => HttpData.Resolve<TblProductInfo>("tblProductInfo");
        set => HttpData["tblProductInfo"] = value;
    }

    /// <summary>
    /// Table class for tblProductInfo
    /// </summary>
    public class TblProductInfo : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> int_Product_Id;

        public readonly DbField<SqlDbType> str_Product_Name;

        public readonly DbField<SqlDbType> str_Item_Code;

        public readonly DbField<SqlDbType> mny_Price;

        public readonly DbField<SqlDbType> bit_IsTaxable;

        public readonly DbField<SqlDbType> str_Web_Description;

        public readonly DbField<SqlDbType> dec_StateTax;

        public readonly DbField<SqlDbType> dec_AddTax;

        public readonly DbField<SqlDbType> mny_TotalPrice;

        public readonly DbField<SqlDbType> int_Product_Type;

        public readonly DbField<SqlDbType> int_Product_Sub_Type;

        public readonly DbField<SqlDbType> int_Status;

        public readonly DbField<SqlDbType> bit_Is_Web_Purchase;

        public readonly DbField<SqlDbType> str_BTW_Hours;

        public readonly DbField<SqlDbType> str_Hour;

        public readonly DbField<SqlDbType> Str_Minutes;

        public readonly DbField<SqlDbType> str_Appointment_Duration;

        public readonly DbField<SqlDbType> str_Notes;

        public readonly DbField<SqlDbType> int_Created_By;

        public readonly DbField<SqlDbType> int_Modified_By;

        public readonly DbField<SqlDbType> date_Created;

        public readonly DbField<SqlDbType> date_Modified;

        public readonly DbField<SqlDbType> bit_IsDeleted;

        public readonly DbField<SqlDbType> int_Dollar;

        public readonly DbField<SqlDbType> bit_PortalPurchase;

        public readonly DbField<SqlDbType> str_WebName;

        public readonly DbField<SqlDbType> bit_ExtraChk1;

        public readonly DbField<SqlDbType> bit_ExtraChk2;

        public readonly DbField<SqlDbType> str_ExtraDrpDown1;

        public readonly DbField<SqlDbType> str_ExtraDrpDown2;

        public readonly DbField<SqlDbType> str_Extratxt1;

        public readonly DbField<SqlDbType> str_Extratxt2;

        public readonly DbField<SqlDbType> str_OBHours;

        public readonly DbField<SqlDbType> str_OBMinutes;

        public readonly DbField<SqlDbType> str_TotalOB_Mins;

        public readonly DbField<SqlDbType> LMSProductID;

        public readonly DbField<SqlDbType> LMSNoOfAttempts;

        public readonly DbField<SqlDbType> int_LMSLinkExpirationDays;

        public readonly DbField<SqlDbType> IGD_product_id;

        public readonly DbField<SqlDbType> IEC_product_id;

        public readonly DbField<SqlDbType> Somastream_Product_ID;

        public readonly DbField<SqlDbType> ProTREAD_Product_ID;

        public readonly DbField<SqlDbType> ASD_product_id;

        public readonly DbField<SqlDbType> D2L_product_Id;

        public readonly DbField<SqlDbType> int_Course_Duration;

        public readonly DbField<SqlDbType> Moodle_product_Id;

        // Constructor
        public TblProductInfo()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "tblProductInfo";
            Name = "tblProductInfo";
            Type = "TABLE";
            UpdateTable = "dbo.tblProductInfo"; // Update Table
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

            // int_Product_Id
            int_Product_Id = new (this, "x_int_Product_Id", 3, SqlDbType.Int) {
                Name = "int_Product_Id",
                Expression = "[int_Product_Id]",
                BasicSearchExpression = "CAST([int_Product_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Product_Id]",
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
                CustomMessage = Language.FieldPhrase("tblProductInfo", "int_Product_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Product_Id", int_Product_Id);

            // str_Product_Name
            str_Product_Name = new (this, "x_str_Product_Name", 202, SqlDbType.NVarChar) {
                Name = "str_Product_Name",
                Expression = "[str_Product_Name]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Product_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Product_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "str_Product_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Product_Name", str_Product_Name);

            // str_Item_Code
            str_Item_Code = new (this, "x_str_Item_Code", 202, SqlDbType.NVarChar) {
                Name = "str_Item_Code",
                Expression = "[str_Item_Code]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Item_Code]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Item_Code]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "str_Item_Code", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Item_Code", str_Item_Code);

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
                CustomMessage = Language.FieldPhrase("tblProductInfo", "mny_Price", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("mny_Price", mny_Price);

            // bit_IsTaxable
            bit_IsTaxable = new (this, "x_bit_IsTaxable", 11, SqlDbType.Bit) {
                Name = "bit_IsTaxable",
                Expression = "[bit_IsTaxable]",
                BasicSearchExpression = "[bit_IsTaxable]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_IsTaxable]",
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
                CustomMessage = Language.FieldPhrase("tblProductInfo", "bit_IsTaxable", "CustomMsg"),
                IsUpload = false
            };
            bit_IsTaxable.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IsTaxable, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsTaxable, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IsTaxable, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_IsTaxable", bit_IsTaxable);

            // str_Web_Description
            str_Web_Description = new (this, "x_str_Web_Description", 202, SqlDbType.NVarChar) {
                Name = "str_Web_Description",
                Expression = "[str_Web_Description]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Web_Description]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Web_Description]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "str_Web_Description", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Web_Description", str_Web_Description);

            // dec_StateTax
            dec_StateTax = new (this, "x_dec_StateTax", 3, SqlDbType.Int) {
                Name = "dec_StateTax",
                Expression = "[dec_StateTax]",
                BasicSearchExpression = "CAST([dec_StateTax] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[dec_StateTax]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "dec_StateTax", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dec_StateTax", dec_StateTax);

            // dec_AddTax
            dec_AddTax = new (this, "x_dec_AddTax", 131, SqlDbType.Decimal) {
                Name = "dec_AddTax",
                Expression = "[dec_AddTax]",
                BasicSearchExpression = "CAST([dec_AddTax] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[dec_AddTax]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "dec_AddTax", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dec_AddTax", dec_AddTax);

            // mny_TotalPrice
            mny_TotalPrice = new (this, "x_mny_TotalPrice", 6, SqlDbType.Money) {
                Name = "mny_TotalPrice",
                Expression = "[mny_TotalPrice]",
                BasicSearchExpression = "CAST([mny_TotalPrice] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[mny_TotalPrice]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "mny_TotalPrice", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("mny_TotalPrice", mny_TotalPrice);

            // int_Product_Type
            int_Product_Type = new (this, "x_int_Product_Type", 3, SqlDbType.Int) {
                Name = "int_Product_Type",
                Expression = "[int_Product_Type]",
                BasicSearchExpression = "CAST([int_Product_Type] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Product_Type]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "int_Product_Type", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Product_Type", int_Product_Type);

            // int_Product_Sub_Type
            int_Product_Sub_Type = new (this, "x_int_Product_Sub_Type", 3, SqlDbType.Int) {
                Name = "int_Product_Sub_Type",
                Expression = "[int_Product_Sub_Type]",
                BasicSearchExpression = "CAST([int_Product_Sub_Type] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Product_Sub_Type]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "int_Product_Sub_Type", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Product_Sub_Type", int_Product_Sub_Type);

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
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "int_Status", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Status", int_Status);

            // bit_Is_Web_Purchase
            bit_Is_Web_Purchase = new (this, "x_bit_Is_Web_Purchase", 11, SqlDbType.Bit) {
                Name = "bit_Is_Web_Purchase",
                Expression = "[bit_Is_Web_Purchase]",
                BasicSearchExpression = "[bit_Is_Web_Purchase]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_Is_Web_Purchase]",
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
                CustomMessage = Language.FieldPhrase("tblProductInfo", "bit_Is_Web_Purchase", "CustomMsg"),
                IsUpload = false
            };
            bit_Is_Web_Purchase.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_Is_Web_Purchase, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_Is_Web_Purchase, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_Is_Web_Purchase, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_Is_Web_Purchase", bit_Is_Web_Purchase);

            // str_BTW_Hours
            str_BTW_Hours = new (this, "x_str_BTW_Hours", 200, SqlDbType.VarChar) {
                Name = "str_BTW_Hours",
                Expression = "[str_BTW_Hours]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_BTW_Hours]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_BTW_Hours]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "str_BTW_Hours", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_BTW_Hours", str_BTW_Hours);

            // str_Hour
            str_Hour = new (this, "x_str_Hour", 200, SqlDbType.VarChar) {
                Name = "str_Hour",
                Expression = "[str_Hour]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Hour]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Hour]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "str_Hour", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Hour", str_Hour);

            // Str_Minutes
            Str_Minutes = new (this, "x_Str_Minutes", 200, SqlDbType.VarChar) {
                Name = "Str_Minutes",
                Expression = "[Str_Minutes]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Str_Minutes]",
                DateTimeFormat = -1,
                VirtualExpression = "[Str_Minutes]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "Str_Minutes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Str_Minutes", Str_Minutes);

            // str_Appointment_Duration
            str_Appointment_Duration = new (this, "x_str_Appointment_Duration", 200, SqlDbType.VarChar) {
                Name = "str_Appointment_Duration",
                Expression = "[str_Appointment_Duration]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Appointment_Duration]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Appointment_Duration]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "str_Appointment_Duration", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Appointment_Duration", str_Appointment_Duration);

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
                CustomMessage = Language.FieldPhrase("tblProductInfo", "str_Notes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Notes", str_Notes);

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
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "int_Created_By", "CustomMsg"),
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
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "int_Modified_By", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("tblProductInfo", "date_Created", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("tblProductInfo", "date_Modified", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("tblProductInfo", "bit_IsDeleted", "CustomMsg"),
                IsUpload = false
            };
            bit_IsDeleted.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IsDeleted, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsDeleted, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IsDeleted, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_IsDeleted", bit_IsDeleted);

            // int_Dollar
            int_Dollar = new (this, "x_int_Dollar", 3, SqlDbType.Int) {
                Name = "int_Dollar",
                Expression = "[int_Dollar]",
                BasicSearchExpression = "CAST([int_Dollar] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Dollar]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "int_Dollar", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Dollar", int_Dollar);

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
                CustomMessage = Language.FieldPhrase("tblProductInfo", "bit_PortalPurchase", "CustomMsg"),
                IsUpload = false
            };
            bit_PortalPurchase.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_PortalPurchase, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_PortalPurchase, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_PortalPurchase, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_PortalPurchase", bit_PortalPurchase);

            // str_WebName
            str_WebName = new (this, "x_str_WebName", 202, SqlDbType.NVarChar) {
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
                CustomMessage = Language.FieldPhrase("tblProductInfo", "str_WebName", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("tblProductInfo", "bit_ExtraChk1", "CustomMsg"),
                IsUpload = false
            };
            bit_ExtraChk1.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_ExtraChk1, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_ExtraChk1, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_ExtraChk1, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
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
                CustomMessage = Language.FieldPhrase("tblProductInfo", "bit_ExtraChk2", "CustomMsg"),
                IsUpload = false
            };
            bit_ExtraChk2.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_ExtraChk2, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_ExtraChk2, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_ExtraChk2, "tblProductInfo", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
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
                CustomMessage = Language.FieldPhrase("tblProductInfo", "str_ExtraDrpDown1", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("tblProductInfo", "str_ExtraDrpDown2", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("tblProductInfo", "str_Extratxt1", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("tblProductInfo", "str_Extratxt2", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Extratxt2", str_Extratxt2);

            // str_OBHours
            str_OBHours = new (this, "x_str_OBHours", 200, SqlDbType.VarChar) {
                Name = "str_OBHours",
                Expression = "[str_OBHours]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_OBHours]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_OBHours]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "str_OBHours", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_OBHours", str_OBHours);

            // str_OBMinutes
            str_OBMinutes = new (this, "x_str_OBMinutes", 200, SqlDbType.VarChar) {
                Name = "str_OBMinutes",
                Expression = "[str_OBMinutes]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_OBMinutes]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_OBMinutes]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "str_OBMinutes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_OBMinutes", str_OBMinutes);

            // str_TotalOB_Mins
            str_TotalOB_Mins = new (this, "x_str_TotalOB_Mins", 200, SqlDbType.VarChar) {
                Name = "str_TotalOB_Mins",
                Expression = "[str_TotalOB_Mins]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_TotalOB_Mins]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_TotalOB_Mins]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "str_TotalOB_Mins", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_TotalOB_Mins", str_TotalOB_Mins);

            // LMSProductID
            LMSProductID = new (this, "x_LMSProductID", 3, SqlDbType.Int) {
                Name = "LMSProductID",
                Expression = "[LMSProductID]",
                BasicSearchExpression = "CAST([LMSProductID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[LMSProductID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "LMSProductID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("LMSProductID", LMSProductID);

            // LMSNoOfAttempts
            LMSNoOfAttempts = new (this, "x_LMSNoOfAttempts", 3, SqlDbType.Int) {
                Name = "LMSNoOfAttempts",
                Expression = "[LMSNoOfAttempts]",
                BasicSearchExpression = "CAST([LMSNoOfAttempts] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[LMSNoOfAttempts]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "LMSNoOfAttempts", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("LMSNoOfAttempts", LMSNoOfAttempts);

            // int_LMSLinkExpirationDays
            int_LMSLinkExpirationDays = new (this, "x_int_LMSLinkExpirationDays", 3, SqlDbType.Int) {
                Name = "int_LMSLinkExpirationDays",
                Expression = "[int_LMSLinkExpirationDays]",
                BasicSearchExpression = "CAST([int_LMSLinkExpirationDays] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_LMSLinkExpirationDays]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "int_LMSLinkExpirationDays", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_LMSLinkExpirationDays", int_LMSLinkExpirationDays);

            // IGD_product_id
            IGD_product_id = new (this, "x_IGD_product_id", 3, SqlDbType.Int) {
                Name = "IGD_product_id",
                Expression = "[IGD_product_id]",
                BasicSearchExpression = "CAST([IGD_product_id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[IGD_product_id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "IGD_product_id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("IGD_product_id", IGD_product_id);

            // IEC_product_id
            IEC_product_id = new (this, "x_IEC_product_id", 3, SqlDbType.Int) {
                Name = "IEC_product_id",
                Expression = "[IEC_product_id]",
                BasicSearchExpression = "CAST([IEC_product_id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[IEC_product_id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "IEC_product_id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("IEC_product_id", IEC_product_id);

            // Somastream_Product_ID
            Somastream_Product_ID = new (this, "x_Somastream_Product_ID", 3, SqlDbType.Int) {
                Name = "Somastream_Product_ID",
                Expression = "[Somastream_Product_ID]",
                BasicSearchExpression = "CAST([Somastream_Product_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Somastream_Product_ID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "Somastream_Product_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Somastream_Product_ID", Somastream_Product_ID);

            // ProTREAD_Product_ID
            ProTREAD_Product_ID = new (this, "x_ProTREAD_Product_ID", 3, SqlDbType.Int) {
                Name = "ProTREAD_Product_ID",
                Expression = "[ProTREAD_Product_ID]",
                BasicSearchExpression = "CAST([ProTREAD_Product_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[ProTREAD_Product_ID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "ProTREAD_Product_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("ProTREAD_Product_ID", ProTREAD_Product_ID);

            // ASD_product_id
            ASD_product_id = new (this, "x_ASD_product_id", 3, SqlDbType.Int) {
                Name = "ASD_product_id",
                Expression = "[ASD_product_id]",
                BasicSearchExpression = "CAST([ASD_product_id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[ASD_product_id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "ASD_product_id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("ASD_product_id", ASD_product_id);

            // D2L_product_Id
            D2L_product_Id = new (this, "x_D2L_product_Id", 3, SqlDbType.Int) {
                Name = "D2L_product_Id",
                Expression = "[D2L_product_Id]",
                BasicSearchExpression = "CAST([D2L_product_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[D2L_product_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "D2L_product_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("D2L_product_Id", D2L_product_Id);

            // int_Course_Duration
            int_Course_Duration = new (this, "x_int_Course_Duration", 3, SqlDbType.Int) {
                Name = "int_Course_Duration",
                Expression = "[int_Course_Duration]",
                BasicSearchExpression = "CAST([int_Course_Duration] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Course_Duration]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "int_Course_Duration", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Course_Duration", int_Course_Duration);

            // Moodle_product_Id
            Moodle_product_Id = new (this, "x_Moodle_product_Id", 3, SqlDbType.Int) {
                Name = "Moodle_product_Id",
                Expression = "[Moodle_product_Id]",
                BasicSearchExpression = "CAST([Moodle_product_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Moodle_product_Id]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblProductInfo", "Moodle_product_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Moodle_product_Id", Moodle_product_Id);

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
            get => _sqlFrom ?? "dbo.tblProductInfo";
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
                int_Product_Id.DbValue = row["int_Product_Id"]; // Set DB value only
                str_Product_Name.DbValue = row["str_Product_Name"]; // Set DB value only
                str_Item_Code.DbValue = row["str_Item_Code"]; // Set DB value only
                mny_Price.DbValue = row["mny_Price"]; // Set DB value only
                bit_IsTaxable.DbValue = (ConvertToBool(row["bit_IsTaxable"]) ? "1" : "0"); // Set DB value only
                str_Web_Description.DbValue = row["str_Web_Description"]; // Set DB value only
                dec_StateTax.DbValue = row["dec_StateTax"]; // Set DB value only
                dec_AddTax.DbValue = row["dec_AddTax"]; // Set DB value only
                mny_TotalPrice.DbValue = row["mny_TotalPrice"]; // Set DB value only
                int_Product_Type.DbValue = row["int_Product_Type"]; // Set DB value only
                int_Product_Sub_Type.DbValue = row["int_Product_Sub_Type"]; // Set DB value only
                int_Status.DbValue = row["int_Status"]; // Set DB value only
                bit_Is_Web_Purchase.DbValue = (ConvertToBool(row["bit_Is_Web_Purchase"]) ? "1" : "0"); // Set DB value only
                str_BTW_Hours.DbValue = row["str_BTW_Hours"]; // Set DB value only
                str_Hour.DbValue = row["str_Hour"]; // Set DB value only
                Str_Minutes.DbValue = row["Str_Minutes"]; // Set DB value only
                str_Appointment_Duration.DbValue = row["str_Appointment_Duration"]; // Set DB value only
                str_Notes.DbValue = row["str_Notes"]; // Set DB value only
                int_Created_By.DbValue = row["int_Created_By"]; // Set DB value only
                int_Modified_By.DbValue = row["int_Modified_By"]; // Set DB value only
                date_Created.DbValue = row["date_Created"]; // Set DB value only
                date_Modified.DbValue = row["date_Modified"]; // Set DB value only
                bit_IsDeleted.DbValue = (ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"); // Set DB value only
                int_Dollar.DbValue = row["int_Dollar"]; // Set DB value only
                bit_PortalPurchase.DbValue = (ConvertToBool(row["bit_PortalPurchase"]) ? "1" : "0"); // Set DB value only
                str_WebName.DbValue = row["str_WebName"]; // Set DB value only
                bit_ExtraChk1.DbValue = (ConvertToBool(row["bit_ExtraChk1"]) ? "1" : "0"); // Set DB value only
                bit_ExtraChk2.DbValue = (ConvertToBool(row["bit_ExtraChk2"]) ? "1" : "0"); // Set DB value only
                str_ExtraDrpDown1.DbValue = row["str_ExtraDrpDown1"]; // Set DB value only
                str_ExtraDrpDown2.DbValue = row["str_ExtraDrpDown2"]; // Set DB value only
                str_Extratxt1.DbValue = row["str_Extratxt1"]; // Set DB value only
                str_Extratxt2.DbValue = row["str_Extratxt2"]; // Set DB value only
                str_OBHours.DbValue = row["str_OBHours"]; // Set DB value only
                str_OBMinutes.DbValue = row["str_OBMinutes"]; // Set DB value only
                str_TotalOB_Mins.DbValue = row["str_TotalOB_Mins"]; // Set DB value only
                LMSProductID.DbValue = row["LMSProductID"]; // Set DB value only
                LMSNoOfAttempts.DbValue = row["LMSNoOfAttempts"]; // Set DB value only
                int_LMSLinkExpirationDays.DbValue = row["int_LMSLinkExpirationDays"]; // Set DB value only
                IGD_product_id.DbValue = row["IGD_product_id"]; // Set DB value only
                IEC_product_id.DbValue = row["IEC_product_id"]; // Set DB value only
                Somastream_Product_ID.DbValue = row["Somastream_Product_ID"]; // Set DB value only
                ProTREAD_Product_ID.DbValue = row["ProTREAD_Product_ID"]; // Set DB value only
                ASD_product_id.DbValue = row["ASD_product_id"]; // Set DB value only
                D2L_product_Id.DbValue = row["D2L_product_Id"]; // Set DB value only
                int_Course_Duration.DbValue = row["int_Course_Duration"]; // Set DB value only
                Moodle_product_Id.DbValue = row["Moodle_product_Id"]; // Set DB value only
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
                    return "TblProductInfoList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "TblProductInfoView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "TblProductInfoEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "TblProductInfoAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "TblProductInfoList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "TblProductInfoView",
                Config.ApiAddAction => "TblProductInfoAdd",
                Config.ApiEditAction => "TblProductInfoEdit",
                Config.ApiDeleteAction => "TblProductInfoDelete",
                Config.ApiListAction => "TblProductInfoList",
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
        public string ListUrl => "TblProductInfoList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblProductInfoView", parm);
            else
                url = KeyUrl("TblProductInfoView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "TblProductInfoAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "TblProductInfoAdd?" + parm;
            else
                url = "TblProductInfoAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("TblProductInfoEdit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblProductInfoList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("TblProductInfoAdd", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblProductInfoList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("TblProductInfoDelete")); // DN

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
            int_Product_Id.SetDbValue(dr["int_Product_Id"]);
            str_Product_Name.SetDbValue(dr["str_Product_Name"]);
            str_Item_Code.SetDbValue(dr["str_Item_Code"]);
            mny_Price.SetDbValue(dr["mny_Price"]);
            bit_IsTaxable.SetDbValue(ConvertToBool(dr["bit_IsTaxable"]) ? "1" : "0");
            str_Web_Description.SetDbValue(dr["str_Web_Description"]);
            dec_StateTax.SetDbValue(dr["dec_StateTax"]);
            dec_AddTax.SetDbValue(dr["dec_AddTax"]);
            mny_TotalPrice.SetDbValue(dr["mny_TotalPrice"]);
            int_Product_Type.SetDbValue(dr["int_Product_Type"]);
            int_Product_Sub_Type.SetDbValue(dr["int_Product_Sub_Type"]);
            int_Status.SetDbValue(dr["int_Status"]);
            bit_Is_Web_Purchase.SetDbValue(ConvertToBool(dr["bit_Is_Web_Purchase"]) ? "1" : "0");
            str_BTW_Hours.SetDbValue(dr["str_BTW_Hours"]);
            str_Hour.SetDbValue(dr["str_Hour"]);
            Str_Minutes.SetDbValue(dr["Str_Minutes"]);
            str_Appointment_Duration.SetDbValue(dr["str_Appointment_Duration"]);
            str_Notes.SetDbValue(dr["str_Notes"]);
            int_Created_By.SetDbValue(dr["int_Created_By"]);
            int_Modified_By.SetDbValue(dr["int_Modified_By"]);
            date_Created.SetDbValue(dr["date_Created"]);
            date_Modified.SetDbValue(dr["date_Modified"]);
            bit_IsDeleted.SetDbValue(ConvertToBool(dr["bit_IsDeleted"]) ? "1" : "0");
            int_Dollar.SetDbValue(dr["int_Dollar"]);
            bit_PortalPurchase.SetDbValue(ConvertToBool(dr["bit_PortalPurchase"]) ? "1" : "0");
            str_WebName.SetDbValue(dr["str_WebName"]);
            bit_ExtraChk1.SetDbValue(ConvertToBool(dr["bit_ExtraChk1"]) ? "1" : "0");
            bit_ExtraChk2.SetDbValue(ConvertToBool(dr["bit_ExtraChk2"]) ? "1" : "0");
            str_ExtraDrpDown1.SetDbValue(dr["str_ExtraDrpDown1"]);
            str_ExtraDrpDown2.SetDbValue(dr["str_ExtraDrpDown2"]);
            str_Extratxt1.SetDbValue(dr["str_Extratxt1"]);
            str_Extratxt2.SetDbValue(dr["str_Extratxt2"]);
            str_OBHours.SetDbValue(dr["str_OBHours"]);
            str_OBMinutes.SetDbValue(dr["str_OBMinutes"]);
            str_TotalOB_Mins.SetDbValue(dr["str_TotalOB_Mins"]);
            LMSProductID.SetDbValue(dr["LMSProductID"]);
            LMSNoOfAttempts.SetDbValue(dr["LMSNoOfAttempts"]);
            int_LMSLinkExpirationDays.SetDbValue(dr["int_LMSLinkExpirationDays"]);
            IGD_product_id.SetDbValue(dr["IGD_product_id"]);
            IEC_product_id.SetDbValue(dr["IEC_product_id"]);
            Somastream_Product_ID.SetDbValue(dr["Somastream_Product_ID"]);
            ProTREAD_Product_ID.SetDbValue(dr["ProTREAD_Product_ID"]);
            ASD_product_id.SetDbValue(dr["ASD_product_id"]);
            D2L_product_Id.SetDbValue(dr["D2L_product_Id"]);
            int_Course_Duration.SetDbValue(dr["int_Course_Duration"]);
            Moodle_product_Id.SetDbValue(dr["Moodle_product_Id"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "TblProductInfoList";
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

            // int_Product_Id

            // str_Product_Name

            // str_Item_Code

            // mny_Price

            // bit_IsTaxable

            // str_Web_Description

            // dec_StateTax

            // dec_AddTax

            // mny_TotalPrice

            // int_Product_Type

            // int_Product_Sub_Type

            // int_Status

            // bit_Is_Web_Purchase

            // str_BTW_Hours

            // str_Hour

            // Str_Minutes

            // str_Appointment_Duration

            // str_Notes

            // int_Created_By

            // int_Modified_By

            // date_Created

            // date_Modified

            // bit_IsDeleted

            // int_Dollar

            // bit_PortalPurchase

            // str_WebName

            // bit_ExtraChk1

            // bit_ExtraChk2

            // str_ExtraDrpDown1

            // str_ExtraDrpDown2

            // str_Extratxt1

            // str_Extratxt2

            // str_OBHours

            // str_OBMinutes

            // str_TotalOB_Mins

            // LMSProductID

            // LMSNoOfAttempts

            // int_LMSLinkExpirationDays

            // IGD_product_id

            // IEC_product_id

            // Somastream_Product_ID

            // ProTREAD_Product_ID

            // ASD_product_id

            // D2L_product_Id

            // int_Course_Duration

            // Moodle_product_Id

            // int_Product_Id
            int_Product_Id.ViewValue = int_Product_Id.CurrentValue;
            int_Product_Id.ViewValue = FormatNumber(int_Product_Id.ViewValue, int_Product_Id.FormatPattern);
            int_Product_Id.ViewCustomAttributes = "";

            // str_Product_Name
            str_Product_Name.ViewValue = ConvertToString(str_Product_Name.CurrentValue); // DN
            str_Product_Name.ViewCustomAttributes = "";

            // str_Item_Code
            str_Item_Code.ViewValue = ConvertToString(str_Item_Code.CurrentValue); // DN
            str_Item_Code.ViewCustomAttributes = "";

            // mny_Price
            mny_Price.ViewValue = mny_Price.CurrentValue;
            mny_Price.ViewValue = FormatNumber(mny_Price.ViewValue, mny_Price.FormatPattern);
            mny_Price.ViewCustomAttributes = "";

            // bit_IsTaxable
            if (ConvertToBool(bit_IsTaxable.CurrentValue)) {
                bit_IsTaxable.ViewValue = bit_IsTaxable.TagCaption(1) != "" ? bit_IsTaxable.TagCaption(1) : "Yes";
            } else {
                bit_IsTaxable.ViewValue = bit_IsTaxable.TagCaption(2) != "" ? bit_IsTaxable.TagCaption(2) : "No";
            }
            bit_IsTaxable.ViewCustomAttributes = "";

            // str_Web_Description
            str_Web_Description.ViewValue = ConvertToString(str_Web_Description.CurrentValue); // DN
            str_Web_Description.ViewCustomAttributes = "";

            // dec_StateTax
            dec_StateTax.ViewValue = dec_StateTax.CurrentValue;
            dec_StateTax.ViewValue = FormatNumber(dec_StateTax.ViewValue, dec_StateTax.FormatPattern);
            dec_StateTax.ViewCustomAttributes = "";

            // dec_AddTax
            dec_AddTax.ViewValue = dec_AddTax.CurrentValue;
            dec_AddTax.ViewValue = FormatNumber(dec_AddTax.ViewValue, dec_AddTax.FormatPattern);
            dec_AddTax.ViewCustomAttributes = "";

            // mny_TotalPrice
            mny_TotalPrice.ViewValue = mny_TotalPrice.CurrentValue;
            mny_TotalPrice.ViewValue = FormatNumber(mny_TotalPrice.ViewValue, mny_TotalPrice.FormatPattern);
            mny_TotalPrice.ViewCustomAttributes = "";

            // int_Product_Type
            int_Product_Type.ViewValue = int_Product_Type.CurrentValue;
            int_Product_Type.ViewValue = FormatNumber(int_Product_Type.ViewValue, int_Product_Type.FormatPattern);
            int_Product_Type.ViewCustomAttributes = "";

            // int_Product_Sub_Type
            int_Product_Sub_Type.ViewValue = int_Product_Sub_Type.CurrentValue;
            int_Product_Sub_Type.ViewValue = FormatNumber(int_Product_Sub_Type.ViewValue, int_Product_Sub_Type.FormatPattern);
            int_Product_Sub_Type.ViewCustomAttributes = "";

            // int_Status
            int_Status.ViewValue = int_Status.CurrentValue;
            int_Status.ViewValue = FormatNumber(int_Status.ViewValue, int_Status.FormatPattern);
            int_Status.ViewCustomAttributes = "";

            // bit_Is_Web_Purchase
            if (ConvertToBool(bit_Is_Web_Purchase.CurrentValue)) {
                bit_Is_Web_Purchase.ViewValue = bit_Is_Web_Purchase.TagCaption(1) != "" ? bit_Is_Web_Purchase.TagCaption(1) : "Yes";
            } else {
                bit_Is_Web_Purchase.ViewValue = bit_Is_Web_Purchase.TagCaption(2) != "" ? bit_Is_Web_Purchase.TagCaption(2) : "No";
            }
            bit_Is_Web_Purchase.ViewCustomAttributes = "";

            // str_BTW_Hours
            str_BTW_Hours.ViewValue = ConvertToString(str_BTW_Hours.CurrentValue); // DN
            str_BTW_Hours.ViewCustomAttributes = "";

            // str_Hour
            str_Hour.ViewValue = ConvertToString(str_Hour.CurrentValue); // DN
            str_Hour.ViewCustomAttributes = "";

            // Str_Minutes
            Str_Minutes.ViewValue = ConvertToString(Str_Minutes.CurrentValue); // DN
            Str_Minutes.ViewCustomAttributes = "";

            // str_Appointment_Duration
            str_Appointment_Duration.ViewValue = ConvertToString(str_Appointment_Duration.CurrentValue); // DN
            str_Appointment_Duration.ViewCustomAttributes = "";

            // str_Notes
            str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
            str_Notes.ViewCustomAttributes = "";

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

            // int_Dollar
            int_Dollar.ViewValue = int_Dollar.CurrentValue;
            int_Dollar.ViewValue = FormatNumber(int_Dollar.ViewValue, int_Dollar.FormatPattern);
            int_Dollar.ViewCustomAttributes = "";

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

            // str_OBHours
            str_OBHours.ViewValue = ConvertToString(str_OBHours.CurrentValue); // DN
            str_OBHours.ViewCustomAttributes = "";

            // str_OBMinutes
            str_OBMinutes.ViewValue = ConvertToString(str_OBMinutes.CurrentValue); // DN
            str_OBMinutes.ViewCustomAttributes = "";

            // str_TotalOB_Mins
            str_TotalOB_Mins.ViewValue = ConvertToString(str_TotalOB_Mins.CurrentValue); // DN
            str_TotalOB_Mins.ViewCustomAttributes = "";

            // LMSProductID
            LMSProductID.ViewValue = LMSProductID.CurrentValue;
            LMSProductID.ViewValue = FormatNumber(LMSProductID.ViewValue, LMSProductID.FormatPattern);
            LMSProductID.ViewCustomAttributes = "";

            // LMSNoOfAttempts
            LMSNoOfAttempts.ViewValue = LMSNoOfAttempts.CurrentValue;
            LMSNoOfAttempts.ViewValue = FormatNumber(LMSNoOfAttempts.ViewValue, LMSNoOfAttempts.FormatPattern);
            LMSNoOfAttempts.ViewCustomAttributes = "";

            // int_LMSLinkExpirationDays
            int_LMSLinkExpirationDays.ViewValue = int_LMSLinkExpirationDays.CurrentValue;
            int_LMSLinkExpirationDays.ViewValue = FormatNumber(int_LMSLinkExpirationDays.ViewValue, int_LMSLinkExpirationDays.FormatPattern);
            int_LMSLinkExpirationDays.ViewCustomAttributes = "";

            // IGD_product_id
            IGD_product_id.ViewValue = IGD_product_id.CurrentValue;
            IGD_product_id.ViewValue = FormatNumber(IGD_product_id.ViewValue, IGD_product_id.FormatPattern);
            IGD_product_id.ViewCustomAttributes = "";

            // IEC_product_id
            IEC_product_id.ViewValue = IEC_product_id.CurrentValue;
            IEC_product_id.ViewValue = FormatNumber(IEC_product_id.ViewValue, IEC_product_id.FormatPattern);
            IEC_product_id.ViewCustomAttributes = "";

            // Somastream_Product_ID
            Somastream_Product_ID.ViewValue = Somastream_Product_ID.CurrentValue;
            Somastream_Product_ID.ViewValue = FormatNumber(Somastream_Product_ID.ViewValue, Somastream_Product_ID.FormatPattern);
            Somastream_Product_ID.ViewCustomAttributes = "";

            // ProTREAD_Product_ID
            ProTREAD_Product_ID.ViewValue = ProTREAD_Product_ID.CurrentValue;
            ProTREAD_Product_ID.ViewValue = FormatNumber(ProTREAD_Product_ID.ViewValue, ProTREAD_Product_ID.FormatPattern);
            ProTREAD_Product_ID.ViewCustomAttributes = "";

            // ASD_product_id
            ASD_product_id.ViewValue = ASD_product_id.CurrentValue;
            ASD_product_id.ViewValue = FormatNumber(ASD_product_id.ViewValue, ASD_product_id.FormatPattern);
            ASD_product_id.ViewCustomAttributes = "";

            // D2L_product_Id
            D2L_product_Id.ViewValue = D2L_product_Id.CurrentValue;
            D2L_product_Id.ViewValue = FormatNumber(D2L_product_Id.ViewValue, D2L_product_Id.FormatPattern);
            D2L_product_Id.ViewCustomAttributes = "";

            // int_Course_Duration
            int_Course_Duration.ViewValue = int_Course_Duration.CurrentValue;
            int_Course_Duration.ViewValue = FormatNumber(int_Course_Duration.ViewValue, int_Course_Duration.FormatPattern);
            int_Course_Duration.ViewCustomAttributes = "";

            // Moodle_product_Id
            Moodle_product_Id.ViewValue = Moodle_product_Id.CurrentValue;
            Moodle_product_Id.ViewValue = FormatNumber(Moodle_product_Id.ViewValue, Moodle_product_Id.FormatPattern);
            Moodle_product_Id.ViewCustomAttributes = "";

            // int_Product_Id
            int_Product_Id.HrefValue = "";
            int_Product_Id.TooltipValue = "";

            // str_Product_Name
            str_Product_Name.HrefValue = "";
            str_Product_Name.TooltipValue = "";

            // str_Item_Code
            str_Item_Code.HrefValue = "";
            str_Item_Code.TooltipValue = "";

            // mny_Price
            mny_Price.HrefValue = "";
            mny_Price.TooltipValue = "";

            // bit_IsTaxable
            bit_IsTaxable.HrefValue = "";
            bit_IsTaxable.TooltipValue = "";

            // str_Web_Description
            str_Web_Description.HrefValue = "";
            str_Web_Description.TooltipValue = "";

            // dec_StateTax
            dec_StateTax.HrefValue = "";
            dec_StateTax.TooltipValue = "";

            // dec_AddTax
            dec_AddTax.HrefValue = "";
            dec_AddTax.TooltipValue = "";

            // mny_TotalPrice
            mny_TotalPrice.HrefValue = "";
            mny_TotalPrice.TooltipValue = "";

            // int_Product_Type
            int_Product_Type.HrefValue = "";
            int_Product_Type.TooltipValue = "";

            // int_Product_Sub_Type
            int_Product_Sub_Type.HrefValue = "";
            int_Product_Sub_Type.TooltipValue = "";

            // int_Status
            int_Status.HrefValue = "";
            int_Status.TooltipValue = "";

            // bit_Is_Web_Purchase
            bit_Is_Web_Purchase.HrefValue = "";
            bit_Is_Web_Purchase.TooltipValue = "";

            // str_BTW_Hours
            str_BTW_Hours.HrefValue = "";
            str_BTW_Hours.TooltipValue = "";

            // str_Hour
            str_Hour.HrefValue = "";
            str_Hour.TooltipValue = "";

            // Str_Minutes
            Str_Minutes.HrefValue = "";
            Str_Minutes.TooltipValue = "";

            // str_Appointment_Duration
            str_Appointment_Duration.HrefValue = "";
            str_Appointment_Duration.TooltipValue = "";

            // str_Notes
            str_Notes.HrefValue = "";
            str_Notes.TooltipValue = "";

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

            // int_Dollar
            int_Dollar.HrefValue = "";
            int_Dollar.TooltipValue = "";

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

            // str_OBHours
            str_OBHours.HrefValue = "";
            str_OBHours.TooltipValue = "";

            // str_OBMinutes
            str_OBMinutes.HrefValue = "";
            str_OBMinutes.TooltipValue = "";

            // str_TotalOB_Mins
            str_TotalOB_Mins.HrefValue = "";
            str_TotalOB_Mins.TooltipValue = "";

            // LMSProductID
            LMSProductID.HrefValue = "";
            LMSProductID.TooltipValue = "";

            // LMSNoOfAttempts
            LMSNoOfAttempts.HrefValue = "";
            LMSNoOfAttempts.TooltipValue = "";

            // int_LMSLinkExpirationDays
            int_LMSLinkExpirationDays.HrefValue = "";
            int_LMSLinkExpirationDays.TooltipValue = "";

            // IGD_product_id
            IGD_product_id.HrefValue = "";
            IGD_product_id.TooltipValue = "";

            // IEC_product_id
            IEC_product_id.HrefValue = "";
            IEC_product_id.TooltipValue = "";

            // Somastream_Product_ID
            Somastream_Product_ID.HrefValue = "";
            Somastream_Product_ID.TooltipValue = "";

            // ProTREAD_Product_ID
            ProTREAD_Product_ID.HrefValue = "";
            ProTREAD_Product_ID.TooltipValue = "";

            // ASD_product_id
            ASD_product_id.HrefValue = "";
            ASD_product_id.TooltipValue = "";

            // D2L_product_Id
            D2L_product_Id.HrefValue = "";
            D2L_product_Id.TooltipValue = "";

            // int_Course_Duration
            int_Course_Duration.HrefValue = "";
            int_Course_Duration.TooltipValue = "";

            // Moodle_product_Id
            Moodle_product_Id.HrefValue = "";
            Moodle_product_Id.TooltipValue = "";

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

            // int_Product_Id
            int_Product_Id.SetupEditAttributes();
            int_Product_Id.EditValue = int_Product_Id.CurrentValue; // DN
            int_Product_Id.PlaceHolder = RemoveHtml(int_Product_Id.Caption);
            if (!Empty(int_Product_Id.EditValue) && IsNumeric(int_Product_Id.EditValue))
                int_Product_Id.EditValue = FormatNumber(int_Product_Id.EditValue, null);

            // str_Product_Name
            str_Product_Name.SetupEditAttributes();
            if (!str_Product_Name.Raw)
                str_Product_Name.CurrentValue = HtmlDecode(str_Product_Name.CurrentValue);
            str_Product_Name.EditValue = HtmlEncode(str_Product_Name.CurrentValue);
            str_Product_Name.PlaceHolder = RemoveHtml(str_Product_Name.Caption);

            // str_Item_Code
            str_Item_Code.SetupEditAttributes();
            if (!str_Item_Code.Raw)
                str_Item_Code.CurrentValue = HtmlDecode(str_Item_Code.CurrentValue);
            str_Item_Code.EditValue = HtmlEncode(str_Item_Code.CurrentValue);
            str_Item_Code.PlaceHolder = RemoveHtml(str_Item_Code.Caption);

            // mny_Price
            mny_Price.SetupEditAttributes();
            mny_Price.EditValue = mny_Price.CurrentValue; // DN
            mny_Price.PlaceHolder = RemoveHtml(mny_Price.Caption);
            if (!Empty(mny_Price.EditValue) && IsNumeric(mny_Price.EditValue))
                mny_Price.EditValue = FormatNumber(mny_Price.EditValue, null);

            // bit_IsTaxable
            bit_IsTaxable.EditValue = bit_IsTaxable.Options(false);
            bit_IsTaxable.PlaceHolder = RemoveHtml(bit_IsTaxable.Caption);

            // str_Web_Description
            str_Web_Description.SetupEditAttributes();
            if (!str_Web_Description.Raw)
                str_Web_Description.CurrentValue = HtmlDecode(str_Web_Description.CurrentValue);
            str_Web_Description.EditValue = HtmlEncode(str_Web_Description.CurrentValue);
            str_Web_Description.PlaceHolder = RemoveHtml(str_Web_Description.Caption);

            // dec_StateTax
            dec_StateTax.SetupEditAttributes();
            dec_StateTax.EditValue = dec_StateTax.CurrentValue; // DN
            dec_StateTax.PlaceHolder = RemoveHtml(dec_StateTax.Caption);
            if (!Empty(dec_StateTax.EditValue) && IsNumeric(dec_StateTax.EditValue))
                dec_StateTax.EditValue = FormatNumber(dec_StateTax.EditValue, null);

            // dec_AddTax
            dec_AddTax.SetupEditAttributes();
            dec_AddTax.EditValue = dec_AddTax.CurrentValue; // DN
            dec_AddTax.PlaceHolder = RemoveHtml(dec_AddTax.Caption);
            if (!Empty(dec_AddTax.EditValue) && IsNumeric(dec_AddTax.EditValue))
                dec_AddTax.EditValue = FormatNumber(dec_AddTax.EditValue, null);

            // mny_TotalPrice
            mny_TotalPrice.SetupEditAttributes();
            mny_TotalPrice.EditValue = mny_TotalPrice.CurrentValue; // DN
            mny_TotalPrice.PlaceHolder = RemoveHtml(mny_TotalPrice.Caption);
            if (!Empty(mny_TotalPrice.EditValue) && IsNumeric(mny_TotalPrice.EditValue))
                mny_TotalPrice.EditValue = FormatNumber(mny_TotalPrice.EditValue, null);

            // int_Product_Type
            int_Product_Type.SetupEditAttributes();
            int_Product_Type.EditValue = int_Product_Type.CurrentValue; // DN
            int_Product_Type.PlaceHolder = RemoveHtml(int_Product_Type.Caption);
            if (!Empty(int_Product_Type.EditValue) && IsNumeric(int_Product_Type.EditValue))
                int_Product_Type.EditValue = FormatNumber(int_Product_Type.EditValue, null);

            // int_Product_Sub_Type
            int_Product_Sub_Type.SetupEditAttributes();
            int_Product_Sub_Type.EditValue = int_Product_Sub_Type.CurrentValue; // DN
            int_Product_Sub_Type.PlaceHolder = RemoveHtml(int_Product_Sub_Type.Caption);
            if (!Empty(int_Product_Sub_Type.EditValue) && IsNumeric(int_Product_Sub_Type.EditValue))
                int_Product_Sub_Type.EditValue = FormatNumber(int_Product_Sub_Type.EditValue, null);

            // int_Status
            int_Status.SetupEditAttributes();
            int_Status.EditValue = int_Status.CurrentValue; // DN
            int_Status.PlaceHolder = RemoveHtml(int_Status.Caption);
            if (!Empty(int_Status.EditValue) && IsNumeric(int_Status.EditValue))
                int_Status.EditValue = FormatNumber(int_Status.EditValue, null);

            // bit_Is_Web_Purchase
            bit_Is_Web_Purchase.EditValue = bit_Is_Web_Purchase.Options(false);
            bit_Is_Web_Purchase.PlaceHolder = RemoveHtml(bit_Is_Web_Purchase.Caption);

            // str_BTW_Hours
            str_BTW_Hours.SetupEditAttributes();
            if (!str_BTW_Hours.Raw)
                str_BTW_Hours.CurrentValue = HtmlDecode(str_BTW_Hours.CurrentValue);
            str_BTW_Hours.EditValue = HtmlEncode(str_BTW_Hours.CurrentValue);
            str_BTW_Hours.PlaceHolder = RemoveHtml(str_BTW_Hours.Caption);

            // str_Hour
            str_Hour.SetupEditAttributes();
            if (!str_Hour.Raw)
                str_Hour.CurrentValue = HtmlDecode(str_Hour.CurrentValue);
            str_Hour.EditValue = HtmlEncode(str_Hour.CurrentValue);
            str_Hour.PlaceHolder = RemoveHtml(str_Hour.Caption);

            // Str_Minutes
            Str_Minutes.SetupEditAttributes();
            if (!Str_Minutes.Raw)
                Str_Minutes.CurrentValue = HtmlDecode(Str_Minutes.CurrentValue);
            Str_Minutes.EditValue = HtmlEncode(Str_Minutes.CurrentValue);
            Str_Minutes.PlaceHolder = RemoveHtml(Str_Minutes.Caption);

            // str_Appointment_Duration
            str_Appointment_Duration.SetupEditAttributes();
            if (!str_Appointment_Duration.Raw)
                str_Appointment_Duration.CurrentValue = HtmlDecode(str_Appointment_Duration.CurrentValue);
            str_Appointment_Duration.EditValue = HtmlEncode(str_Appointment_Duration.CurrentValue);
            str_Appointment_Duration.PlaceHolder = RemoveHtml(str_Appointment_Duration.Caption);

            // str_Notes
            str_Notes.SetupEditAttributes();
            if (!str_Notes.Raw)
                str_Notes.CurrentValue = HtmlDecode(str_Notes.CurrentValue);
            str_Notes.EditValue = HtmlEncode(str_Notes.CurrentValue);
            str_Notes.PlaceHolder = RemoveHtml(str_Notes.Caption);

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

            // int_Dollar
            int_Dollar.SetupEditAttributes();
            int_Dollar.EditValue = int_Dollar.CurrentValue; // DN
            int_Dollar.PlaceHolder = RemoveHtml(int_Dollar.Caption);
            if (!Empty(int_Dollar.EditValue) && IsNumeric(int_Dollar.EditValue))
                int_Dollar.EditValue = FormatNumber(int_Dollar.EditValue, null);

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

            // str_OBHours
            str_OBHours.SetupEditAttributes();
            if (!str_OBHours.Raw)
                str_OBHours.CurrentValue = HtmlDecode(str_OBHours.CurrentValue);
            str_OBHours.EditValue = HtmlEncode(str_OBHours.CurrentValue);
            str_OBHours.PlaceHolder = RemoveHtml(str_OBHours.Caption);

            // str_OBMinutes
            str_OBMinutes.SetupEditAttributes();
            if (!str_OBMinutes.Raw)
                str_OBMinutes.CurrentValue = HtmlDecode(str_OBMinutes.CurrentValue);
            str_OBMinutes.EditValue = HtmlEncode(str_OBMinutes.CurrentValue);
            str_OBMinutes.PlaceHolder = RemoveHtml(str_OBMinutes.Caption);

            // str_TotalOB_Mins
            str_TotalOB_Mins.SetupEditAttributes();
            if (!str_TotalOB_Mins.Raw)
                str_TotalOB_Mins.CurrentValue = HtmlDecode(str_TotalOB_Mins.CurrentValue);
            str_TotalOB_Mins.EditValue = HtmlEncode(str_TotalOB_Mins.CurrentValue);
            str_TotalOB_Mins.PlaceHolder = RemoveHtml(str_TotalOB_Mins.Caption);

            // LMSProductID
            LMSProductID.SetupEditAttributes();
            LMSProductID.EditValue = LMSProductID.CurrentValue; // DN
            LMSProductID.PlaceHolder = RemoveHtml(LMSProductID.Caption);
            if (!Empty(LMSProductID.EditValue) && IsNumeric(LMSProductID.EditValue))
                LMSProductID.EditValue = FormatNumber(LMSProductID.EditValue, null);

            // LMSNoOfAttempts
            LMSNoOfAttempts.SetupEditAttributes();
            LMSNoOfAttempts.EditValue = LMSNoOfAttempts.CurrentValue; // DN
            LMSNoOfAttempts.PlaceHolder = RemoveHtml(LMSNoOfAttempts.Caption);
            if (!Empty(LMSNoOfAttempts.EditValue) && IsNumeric(LMSNoOfAttempts.EditValue))
                LMSNoOfAttempts.EditValue = FormatNumber(LMSNoOfAttempts.EditValue, null);

            // int_LMSLinkExpirationDays
            int_LMSLinkExpirationDays.SetupEditAttributes();
            int_LMSLinkExpirationDays.EditValue = int_LMSLinkExpirationDays.CurrentValue; // DN
            int_LMSLinkExpirationDays.PlaceHolder = RemoveHtml(int_LMSLinkExpirationDays.Caption);
            if (!Empty(int_LMSLinkExpirationDays.EditValue) && IsNumeric(int_LMSLinkExpirationDays.EditValue))
                int_LMSLinkExpirationDays.EditValue = FormatNumber(int_LMSLinkExpirationDays.EditValue, null);

            // IGD_product_id
            IGD_product_id.SetupEditAttributes();
            IGD_product_id.EditValue = IGD_product_id.CurrentValue; // DN
            IGD_product_id.PlaceHolder = RemoveHtml(IGD_product_id.Caption);
            if (!Empty(IGD_product_id.EditValue) && IsNumeric(IGD_product_id.EditValue))
                IGD_product_id.EditValue = FormatNumber(IGD_product_id.EditValue, null);

            // IEC_product_id
            IEC_product_id.SetupEditAttributes();
            IEC_product_id.EditValue = IEC_product_id.CurrentValue; // DN
            IEC_product_id.PlaceHolder = RemoveHtml(IEC_product_id.Caption);
            if (!Empty(IEC_product_id.EditValue) && IsNumeric(IEC_product_id.EditValue))
                IEC_product_id.EditValue = FormatNumber(IEC_product_id.EditValue, null);

            // Somastream_Product_ID
            Somastream_Product_ID.SetupEditAttributes();
            Somastream_Product_ID.EditValue = Somastream_Product_ID.CurrentValue; // DN
            Somastream_Product_ID.PlaceHolder = RemoveHtml(Somastream_Product_ID.Caption);
            if (!Empty(Somastream_Product_ID.EditValue) && IsNumeric(Somastream_Product_ID.EditValue))
                Somastream_Product_ID.EditValue = FormatNumber(Somastream_Product_ID.EditValue, null);

            // ProTREAD_Product_ID
            ProTREAD_Product_ID.SetupEditAttributes();
            ProTREAD_Product_ID.EditValue = ProTREAD_Product_ID.CurrentValue; // DN
            ProTREAD_Product_ID.PlaceHolder = RemoveHtml(ProTREAD_Product_ID.Caption);
            if (!Empty(ProTREAD_Product_ID.EditValue) && IsNumeric(ProTREAD_Product_ID.EditValue))
                ProTREAD_Product_ID.EditValue = FormatNumber(ProTREAD_Product_ID.EditValue, null);

            // ASD_product_id
            ASD_product_id.SetupEditAttributes();
            ASD_product_id.EditValue = ASD_product_id.CurrentValue; // DN
            ASD_product_id.PlaceHolder = RemoveHtml(ASD_product_id.Caption);
            if (!Empty(ASD_product_id.EditValue) && IsNumeric(ASD_product_id.EditValue))
                ASD_product_id.EditValue = FormatNumber(ASD_product_id.EditValue, null);

            // D2L_product_Id
            D2L_product_Id.SetupEditAttributes();
            D2L_product_Id.EditValue = D2L_product_Id.CurrentValue; // DN
            D2L_product_Id.PlaceHolder = RemoveHtml(D2L_product_Id.Caption);
            if (!Empty(D2L_product_Id.EditValue) && IsNumeric(D2L_product_Id.EditValue))
                D2L_product_Id.EditValue = FormatNumber(D2L_product_Id.EditValue, null);

            // int_Course_Duration
            int_Course_Duration.SetupEditAttributes();
            int_Course_Duration.EditValue = int_Course_Duration.CurrentValue; // DN
            int_Course_Duration.PlaceHolder = RemoveHtml(int_Course_Duration.Caption);
            if (!Empty(int_Course_Duration.EditValue) && IsNumeric(int_Course_Duration.EditValue))
                int_Course_Duration.EditValue = FormatNumber(int_Course_Duration.EditValue, null);

            // Moodle_product_Id
            Moodle_product_Id.SetupEditAttributes();
            Moodle_product_Id.EditValue = Moodle_product_Id.CurrentValue; // DN
            Moodle_product_Id.PlaceHolder = RemoveHtml(Moodle_product_Id.Caption);
            if (!Empty(Moodle_product_Id.EditValue) && IsNumeric(Moodle_product_Id.EditValue))
                Moodle_product_Id.EditValue = FormatNumber(Moodle_product_Id.EditValue, null);

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
                        doc.ExportCaption(int_Product_Id);
                        doc.ExportCaption(str_Product_Name);
                        doc.ExportCaption(str_Item_Code);
                        doc.ExportCaption(mny_Price);
                        doc.ExportCaption(bit_IsTaxable);
                        doc.ExportCaption(str_Web_Description);
                        doc.ExportCaption(dec_StateTax);
                        doc.ExportCaption(dec_AddTax);
                        doc.ExportCaption(mny_TotalPrice);
                        doc.ExportCaption(int_Product_Type);
                        doc.ExportCaption(int_Product_Sub_Type);
                        doc.ExportCaption(int_Status);
                        doc.ExportCaption(bit_Is_Web_Purchase);
                        doc.ExportCaption(str_BTW_Hours);
                        doc.ExportCaption(str_Hour);
                        doc.ExportCaption(Str_Minutes);
                        doc.ExportCaption(str_Appointment_Duration);
                        doc.ExportCaption(str_Notes);
                        doc.ExportCaption(int_Created_By);
                        doc.ExportCaption(int_Modified_By);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(bit_IsDeleted);
                        doc.ExportCaption(int_Dollar);
                        doc.ExportCaption(bit_PortalPurchase);
                        doc.ExportCaption(str_WebName);
                        doc.ExportCaption(bit_ExtraChk1);
                        doc.ExportCaption(bit_ExtraChk2);
                        doc.ExportCaption(str_ExtraDrpDown1);
                        doc.ExportCaption(str_ExtraDrpDown2);
                        doc.ExportCaption(str_Extratxt1);
                        doc.ExportCaption(str_Extratxt2);
                        doc.ExportCaption(str_OBHours);
                        doc.ExportCaption(str_OBMinutes);
                        doc.ExportCaption(str_TotalOB_Mins);
                        doc.ExportCaption(LMSProductID);
                        doc.ExportCaption(LMSNoOfAttempts);
                        doc.ExportCaption(int_LMSLinkExpirationDays);
                        doc.ExportCaption(IGD_product_id);
                        doc.ExportCaption(IEC_product_id);
                        doc.ExportCaption(Somastream_Product_ID);
                        doc.ExportCaption(ProTREAD_Product_ID);
                        doc.ExportCaption(ASD_product_id);
                        doc.ExportCaption(D2L_product_Id);
                        doc.ExportCaption(int_Course_Duration);
                        doc.ExportCaption(Moodle_product_Id);
                    } else {
                        doc.ExportCaption(int_Product_Id);
                        doc.ExportCaption(str_Product_Name);
                        doc.ExportCaption(str_Item_Code);
                        doc.ExportCaption(mny_Price);
                        doc.ExportCaption(bit_IsTaxable);
                        doc.ExportCaption(str_Web_Description);
                        doc.ExportCaption(dec_StateTax);
                        doc.ExportCaption(dec_AddTax);
                        doc.ExportCaption(mny_TotalPrice);
                        doc.ExportCaption(int_Product_Type);
                        doc.ExportCaption(int_Product_Sub_Type);
                        doc.ExportCaption(int_Status);
                        doc.ExportCaption(bit_Is_Web_Purchase);
                        doc.ExportCaption(str_BTW_Hours);
                        doc.ExportCaption(str_Hour);
                        doc.ExportCaption(Str_Minutes);
                        doc.ExportCaption(str_Appointment_Duration);
                        doc.ExportCaption(str_Notes);
                        doc.ExportCaption(int_Created_By);
                        doc.ExportCaption(int_Modified_By);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(bit_IsDeleted);
                        doc.ExportCaption(int_Dollar);
                        doc.ExportCaption(bit_PortalPurchase);
                        doc.ExportCaption(str_WebName);
                        doc.ExportCaption(bit_ExtraChk1);
                        doc.ExportCaption(bit_ExtraChk2);
                        doc.ExportCaption(str_ExtraDrpDown1);
                        doc.ExportCaption(str_ExtraDrpDown2);
                        doc.ExportCaption(str_Extratxt1);
                        doc.ExportCaption(str_Extratxt2);
                        doc.ExportCaption(str_OBHours);
                        doc.ExportCaption(str_OBMinutes);
                        doc.ExportCaption(str_TotalOB_Mins);
                        doc.ExportCaption(LMSProductID);
                        doc.ExportCaption(LMSNoOfAttempts);
                        doc.ExportCaption(int_LMSLinkExpirationDays);
                        doc.ExportCaption(IGD_product_id);
                        doc.ExportCaption(IEC_product_id);
                        doc.ExportCaption(Somastream_Product_ID);
                        doc.ExportCaption(ProTREAD_Product_ID);
                        doc.ExportCaption(ASD_product_id);
                        doc.ExportCaption(D2L_product_Id);
                        doc.ExportCaption(int_Course_Duration);
                        doc.ExportCaption(Moodle_product_Id);
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
                            await doc.ExportField(int_Product_Id);
                            await doc.ExportField(str_Product_Name);
                            await doc.ExportField(str_Item_Code);
                            await doc.ExportField(mny_Price);
                            await doc.ExportField(bit_IsTaxable);
                            await doc.ExportField(str_Web_Description);
                            await doc.ExportField(dec_StateTax);
                            await doc.ExportField(dec_AddTax);
                            await doc.ExportField(mny_TotalPrice);
                            await doc.ExportField(int_Product_Type);
                            await doc.ExportField(int_Product_Sub_Type);
                            await doc.ExportField(int_Status);
                            await doc.ExportField(bit_Is_Web_Purchase);
                            await doc.ExportField(str_BTW_Hours);
                            await doc.ExportField(str_Hour);
                            await doc.ExportField(Str_Minutes);
                            await doc.ExportField(str_Appointment_Duration);
                            await doc.ExportField(str_Notes);
                            await doc.ExportField(int_Created_By);
                            await doc.ExportField(int_Modified_By);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(bit_IsDeleted);
                            await doc.ExportField(int_Dollar);
                            await doc.ExportField(bit_PortalPurchase);
                            await doc.ExportField(str_WebName);
                            await doc.ExportField(bit_ExtraChk1);
                            await doc.ExportField(bit_ExtraChk2);
                            await doc.ExportField(str_ExtraDrpDown1);
                            await doc.ExportField(str_ExtraDrpDown2);
                            await doc.ExportField(str_Extratxt1);
                            await doc.ExportField(str_Extratxt2);
                            await doc.ExportField(str_OBHours);
                            await doc.ExportField(str_OBMinutes);
                            await doc.ExportField(str_TotalOB_Mins);
                            await doc.ExportField(LMSProductID);
                            await doc.ExportField(LMSNoOfAttempts);
                            await doc.ExportField(int_LMSLinkExpirationDays);
                            await doc.ExportField(IGD_product_id);
                            await doc.ExportField(IEC_product_id);
                            await doc.ExportField(Somastream_Product_ID);
                            await doc.ExportField(ProTREAD_Product_ID);
                            await doc.ExportField(ASD_product_id);
                            await doc.ExportField(D2L_product_Id);
                            await doc.ExportField(int_Course_Duration);
                            await doc.ExportField(Moodle_product_Id);
                        } else {
                            await doc.ExportField(int_Product_Id);
                            await doc.ExportField(str_Product_Name);
                            await doc.ExportField(str_Item_Code);
                            await doc.ExportField(mny_Price);
                            await doc.ExportField(bit_IsTaxable);
                            await doc.ExportField(str_Web_Description);
                            await doc.ExportField(dec_StateTax);
                            await doc.ExportField(dec_AddTax);
                            await doc.ExportField(mny_TotalPrice);
                            await doc.ExportField(int_Product_Type);
                            await doc.ExportField(int_Product_Sub_Type);
                            await doc.ExportField(int_Status);
                            await doc.ExportField(bit_Is_Web_Purchase);
                            await doc.ExportField(str_BTW_Hours);
                            await doc.ExportField(str_Hour);
                            await doc.ExportField(Str_Minutes);
                            await doc.ExportField(str_Appointment_Duration);
                            await doc.ExportField(str_Notes);
                            await doc.ExportField(int_Created_By);
                            await doc.ExportField(int_Modified_By);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(bit_IsDeleted);
                            await doc.ExportField(int_Dollar);
                            await doc.ExportField(bit_PortalPurchase);
                            await doc.ExportField(str_WebName);
                            await doc.ExportField(bit_ExtraChk1);
                            await doc.ExportField(bit_ExtraChk2);
                            await doc.ExportField(str_ExtraDrpDown1);
                            await doc.ExportField(str_ExtraDrpDown2);
                            await doc.ExportField(str_Extratxt1);
                            await doc.ExportField(str_Extratxt2);
                            await doc.ExportField(str_OBHours);
                            await doc.ExportField(str_OBMinutes);
                            await doc.ExportField(str_TotalOB_Mins);
                            await doc.ExportField(LMSProductID);
                            await doc.ExportField(LMSNoOfAttempts);
                            await doc.ExportField(int_LMSLinkExpirationDays);
                            await doc.ExportField(IGD_product_id);
                            await doc.ExportField(IEC_product_id);
                            await doc.ExportField(Somastream_Product_ID);
                            await doc.ExportField(ProTREAD_Product_ID);
                            await doc.ExportField(ASD_product_id);
                            await doc.ExportField(D2L_product_Id);
                            await doc.ExportField(int_Course_Duration);
                            await doc.ExportField(Moodle_product_Id);
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
