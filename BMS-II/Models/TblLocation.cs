namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblLocation
    /// </summary>
    [MaybeNull]
    public static TblLocation tblLocation
    {
        get => HttpData.Resolve<TblLocation>("tblLocation");
        set => HttpData["tblLocation"] = value;
    }

    /// <summary>
    /// Table class for tblLocation
    /// </summary>
    public class TblLocation : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> int_Location_Id;

        public readonly DbField<SqlDbType> str_Name;

        public readonly DbField<SqlDbType> str_Code;

        public readonly DbField<SqlDbType> str_Location_Type;

        public readonly DbField<SqlDbType> str_Address1;

        public readonly DbField<SqlDbType> str_Address2;

        public readonly DbField<SqlDbType> str_City;

        public readonly DbField<SqlDbType> int_State;

        public readonly DbField<SqlDbType> str_Zip;

        public readonly DbField<SqlDbType> str_County;

        public readonly DbField<SqlDbType> str_Manager;

        public readonly DbField<SqlDbType> str_Phone_Main;

        public readonly DbField<SqlDbType> str_Phone_Fax;

        public readonly DbField<SqlDbType> str_Phone_Other;

        public readonly DbField<SqlDbType> str_Notes;

        public readonly DbField<SqlDbType> str_Coverage_Code;

        public readonly DbField<SqlDbType> int_Status;

        public readonly DbField<SqlDbType> date_Created;

        public readonly DbField<SqlDbType> date_Modified;

        public readonly DbField<SqlDbType> int_Created_By;

        public readonly DbField<SqlDbType> int_Modified_By;

        public readonly DbField<SqlDbType> bit_IsDeleted;

        public readonly DbField<SqlDbType> str_LocCapacity;

        public readonly DbField<SqlDbType> str_ContactEmail;

        public readonly DbField<SqlDbType> str_SchoolHours;

        public readonly DbField<SqlDbType> str_EmerName;

        public readonly DbField<SqlDbType> str_EmerPhone;

        public readonly DbField<SqlDbType> str_Room;

        public readonly DbField<SqlDbType> str_Email_Content;

        public readonly DbField<SqlDbType> bit_appointmentColor;

        public readonly DbField<SqlDbType> str_appointmentColorCode;

        public readonly DbField<SqlDbType> isKnowledgeTest;

        public readonly DbField<SqlDbType> isRoadTest;

        public readonly DbField<SqlDbType> dec_Latitude;

        public readonly DbField<SqlDbType> dec_Longitude;

        public readonly DbField<SqlDbType> str_nameAr;

        public readonly DbField<SqlDbType> IsDistanceBasedScheduling;

        public readonly DbField<SqlDbType> str_ZoomEmail;

        public readonly DbField<SqlDbType> str_ProviderLocationId;

        public readonly DbField<SqlDbType> int_RoadDistanceCoverage;

        public readonly DbField<SqlDbType> IsCashDrawer;

        // Constructor
        public TblLocation()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "tblLocation";
            Name = "tblLocation";
            Type = "TABLE";
            UpdateTable = "dbo.tblLocation"; // Update Table
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
                HtmlTag = "SELECT",
                InputTextType = "text",
                IsPrimaryKey = true, // Primary key field
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblLocation", "int_Location_Id", "CustomMsg"),
                IsUpload = false
            };
            int_Location_Id.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(int_Location_Id, "tblLocation", false, "int_Location_Id", new List<string> {"int_Location_Id", "str_Name", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT(CAST([int_Location_Id] AS NVARCHAR),'" + ValueSeparator(1, int_Location_Id) + "',[str_Name])"),
                "en-US" => new Lookup<DbField>(int_Location_Id, "tblLocation", false, "int_Location_Id", new List<string> {"int_Location_Id", "str_Name", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT(CAST([int_Location_Id] AS NVARCHAR),'" + ValueSeparator(1, int_Location_Id) + "',[str_Name])"),
                _ => new Lookup<DbField>(int_Location_Id, "tblLocation", false, "int_Location_Id", new List<string> {"int_Location_Id", "str_Name", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT(CAST([int_Location_Id] AS NVARCHAR),'" + ValueSeparator(1, int_Location_Id) + "',[str_Name])")
            };
            Fields.Add("int_Location_Id", int_Location_Id);

            // str_Name
            str_Name = new (this, "x_str_Name", 202, SqlDbType.NVarChar) {
                Name = "str_Name",
                Expression = "[str_Name]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Name", str_Name);

            // str_Code
            str_Code = new (this, "x_str_Code", 202, SqlDbType.NVarChar) {
                Name = "str_Code",
                Expression = "[str_Code]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Code]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Code]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_Code", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Code", str_Code);

            // str_Location_Type
            str_Location_Type = new (this, "x_str_Location_Type", 202, SqlDbType.NVarChar) {
                Name = "str_Location_Type",
                Expression = "[str_Location_Type]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Location_Type]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Location_Type]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_Location_Type", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Location_Type", str_Location_Type);

            // str_Address1
            str_Address1 = new (this, "x_str_Address1", 202, SqlDbType.NVarChar) {
                Name = "str_Address1",
                Expression = "[str_Address1]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Address1]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Address1]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_Address1", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Address1", str_Address1);

            // str_Address2
            str_Address2 = new (this, "x_str_Address2", 202, SqlDbType.NVarChar) {
                Name = "str_Address2",
                Expression = "[str_Address2]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Address2]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Address2]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_Address2", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Address2", str_Address2);

            // str_City
            str_City = new (this, "x_str_City", 202, SqlDbType.NVarChar) {
                Name = "str_City",
                Expression = "[str_City]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_City]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_City]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_City", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_City", str_City);

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
                CustomMessage = Language.FieldPhrase("tblLocation", "int_State", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_State", int_State);

            // str_Zip
            str_Zip = new (this, "x_str_Zip", 202, SqlDbType.NVarChar) {
                Name = "str_Zip",
                Expression = "[str_Zip]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Zip]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Zip]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_Zip", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Zip", str_Zip);

            // str_County
            str_County = new (this, "x_str_County", 202, SqlDbType.NVarChar) {
                Name = "str_County",
                Expression = "[str_County]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_County]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_County]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_County", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_County", str_County);

            // str_Manager
            str_Manager = new (this, "x_str_Manager", 202, SqlDbType.NVarChar) {
                Name = "str_Manager",
                Expression = "[str_Manager]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Manager]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Manager]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_Manager", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Manager", str_Manager);

            // str_Phone_Main
            str_Phone_Main = new (this, "x_str_Phone_Main", 202, SqlDbType.NVarChar) {
                Name = "str_Phone_Main",
                Expression = "[str_Phone_Main]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Phone_Main]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Phone_Main]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_Phone_Main", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Phone_Main", str_Phone_Main);

            // str_Phone_Fax
            str_Phone_Fax = new (this, "x_str_Phone_Fax", 202, SqlDbType.NVarChar) {
                Name = "str_Phone_Fax",
                Expression = "[str_Phone_Fax]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Phone_Fax]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Phone_Fax]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_Phone_Fax", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Phone_Fax", str_Phone_Fax);

            // str_Phone_Other
            str_Phone_Other = new (this, "x_str_Phone_Other", 202, SqlDbType.NVarChar) {
                Name = "str_Phone_Other",
                Expression = "[str_Phone_Other]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Phone_Other]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Phone_Other]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_Phone_Other", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Phone_Other", str_Phone_Other);

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
                CustomMessage = Language.FieldPhrase("tblLocation", "str_Notes", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Notes", str_Notes);

            // str_Coverage_Code
            str_Coverage_Code = new (this, "x_str_Coverage_Code", 203, SqlDbType.NText) {
                Name = "str_Coverage_Code",
                Expression = "[str_Coverage_Code]",
                BasicSearchExpression = "[str_Coverage_Code]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Coverage_Code]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_Coverage_Code", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Coverage_Code", str_Coverage_Code);

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
                CustomMessage = Language.FieldPhrase("tblLocation", "int_Status", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Status", int_Status);

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
                CustomMessage = Language.FieldPhrase("tblLocation", "date_Created", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("tblLocation", "date_Modified", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Modified", date_Modified);

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
                CustomMessage = Language.FieldPhrase("tblLocation", "int_Created_By", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("tblLocation", "int_Modified_By", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Modified_By", int_Modified_By);

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
                CustomMessage = Language.FieldPhrase("tblLocation", "bit_IsDeleted", "CustomMsg"),
                IsUpload = false
            };
            bit_IsDeleted.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_IsDeleted, "tblLocation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_IsDeleted, "tblLocation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_IsDeleted, "tblLocation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_IsDeleted", bit_IsDeleted);

            // str_LocCapacity
            str_LocCapacity = new (this, "x_str_LocCapacity", 202, SqlDbType.NVarChar) {
                Name = "str_LocCapacity",
                Expression = "[str_LocCapacity]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_LocCapacity]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_LocCapacity]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_LocCapacity", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_LocCapacity", str_LocCapacity);

            // str_ContactEmail
            str_ContactEmail = new (this, "x_str_ContactEmail", 202, SqlDbType.NVarChar) {
                Name = "str_ContactEmail",
                Expression = "[str_ContactEmail]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_ContactEmail]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_ContactEmail]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_ContactEmail", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_ContactEmail", str_ContactEmail);

            // str_SchoolHours
            str_SchoolHours = new (this, "x_str_SchoolHours", 202, SqlDbType.NVarChar) {
                Name = "str_SchoolHours",
                Expression = "[str_SchoolHours]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_SchoolHours]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_SchoolHours]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_SchoolHours", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_SchoolHours", str_SchoolHours);

            // str_EmerName
            str_EmerName = new (this, "x_str_EmerName", 202, SqlDbType.NVarChar) {
                Name = "str_EmerName",
                Expression = "[str_EmerName]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_EmerName]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_EmerName]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_EmerName", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_EmerName", str_EmerName);

            // str_EmerPhone
            str_EmerPhone = new (this, "x_str_EmerPhone", 202, SqlDbType.NVarChar) {
                Name = "str_EmerPhone",
                Expression = "[str_EmerPhone]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_EmerPhone]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_EmerPhone]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_EmerPhone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_EmerPhone", str_EmerPhone);

            // str_Room
            str_Room = new (this, "x_str_Room", 202, SqlDbType.NVarChar) {
                Name = "str_Room",
                Expression = "[str_Room]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Room]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Room]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_Room", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Room", str_Room);

            // str_Email_Content
            str_Email_Content = new (this, "x_str_Email_Content", 200, SqlDbType.VarChar) {
                Name = "str_Email_Content",
                Expression = "[str_Email_Content]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Email_Content]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Email_Content]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_Email_Content", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Email_Content", str_Email_Content);

            // bit_appointmentColor
            bit_appointmentColor = new (this, "x_bit_appointmentColor", 11, SqlDbType.Bit) {
                Name = "bit_appointmentColor",
                Expression = "[bit_appointmentColor]",
                BasicSearchExpression = "[bit_appointmentColor]",
                DateTimeFormat = -1,
                VirtualExpression = "[bit_appointmentColor]",
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
                CustomMessage = Language.FieldPhrase("tblLocation", "bit_appointmentColor", "CustomMsg"),
                IsUpload = false
            };
            bit_appointmentColor.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(bit_appointmentColor, "tblLocation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(bit_appointmentColor, "tblLocation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(bit_appointmentColor, "tblLocation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("bit_appointmentColor", bit_appointmentColor);

            // str_appointmentColorCode
            str_appointmentColorCode = new (this, "x_str_appointmentColorCode", 202, SqlDbType.NVarChar) {
                Name = "str_appointmentColorCode",
                Expression = "[str_appointmentColorCode]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_appointmentColorCode]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_appointmentColorCode]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_appointmentColorCode", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_appointmentColorCode", str_appointmentColorCode);

            // isKnowledgeTest
            isKnowledgeTest = new (this, "x_isKnowledgeTest", 11, SqlDbType.Bit) {
                Name = "isKnowledgeTest",
                Expression = "[isKnowledgeTest]",
                BasicSearchExpression = "[isKnowledgeTest]",
                DateTimeFormat = -1,
                VirtualExpression = "[isKnowledgeTest]",
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
                CustomMessage = Language.FieldPhrase("tblLocation", "isKnowledgeTest", "CustomMsg"),
                IsUpload = false
            };
            isKnowledgeTest.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(isKnowledgeTest, "tblLocation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(isKnowledgeTest, "tblLocation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(isKnowledgeTest, "tblLocation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("isKnowledgeTest", isKnowledgeTest);

            // isRoadTest
            isRoadTest = new (this, "x_isRoadTest", 11, SqlDbType.Bit) {
                Name = "isRoadTest",
                Expression = "[isRoadTest]",
                BasicSearchExpression = "[isRoadTest]",
                DateTimeFormat = -1,
                VirtualExpression = "[isRoadTest]",
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
                CustomMessage = Language.FieldPhrase("tblLocation", "isRoadTest", "CustomMsg"),
                IsUpload = false
            };
            isRoadTest.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(isRoadTest, "tblLocation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(isRoadTest, "tblLocation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(isRoadTest, "tblLocation", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("isRoadTest", isRoadTest);

            // dec_Latitude
            dec_Latitude = new (this, "x_dec_Latitude", 131, SqlDbType.Decimal) {
                Name = "dec_Latitude",
                Expression = "[dec_Latitude]",
                BasicSearchExpression = "CAST([dec_Latitude] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[dec_Latitude]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "dec_Latitude", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dec_Latitude", dec_Latitude);

            // dec_Longitude
            dec_Longitude = new (this, "x_dec_Longitude", 131, SqlDbType.Decimal) {
                Name = "dec_Longitude",
                Expression = "[dec_Longitude]",
                BasicSearchExpression = "CAST([dec_Longitude] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[dec_Longitude]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "dec_Longitude", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("dec_Longitude", dec_Longitude);

            // str_nameAr
            str_nameAr = new (this, "x_str_nameAr", 202, SqlDbType.NVarChar) {
                Name = "str_nameAr",
                Expression = "[str_nameAr]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_nameAr]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_nameAr]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_nameAr", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_nameAr", str_nameAr);

            // IsDistanceBasedScheduling
            IsDistanceBasedScheduling = new (this, "x_IsDistanceBasedScheduling", 3, SqlDbType.Int) {
                Name = "IsDistanceBasedScheduling",
                Expression = "[IsDistanceBasedScheduling]",
                BasicSearchExpression = "CAST([IsDistanceBasedScheduling] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[IsDistanceBasedScheduling]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "IsDistanceBasedScheduling", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("IsDistanceBasedScheduling", IsDistanceBasedScheduling);

            // str_ZoomEmail
            str_ZoomEmail = new (this, "x_str_ZoomEmail", 200, SqlDbType.VarChar) {
                Name = "str_ZoomEmail",
                Expression = "[str_ZoomEmail]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_ZoomEmail]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_ZoomEmail]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_ZoomEmail", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_ZoomEmail", str_ZoomEmail);

            // str_ProviderLocationId
            str_ProviderLocationId = new (this, "x_str_ProviderLocationId", 202, SqlDbType.NVarChar) {
                Name = "str_ProviderLocationId",
                Expression = "[str_ProviderLocationId]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_ProviderLocationId]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_ProviderLocationId]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "str_ProviderLocationId", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_ProviderLocationId", str_ProviderLocationId);

            // int_RoadDistanceCoverage
            int_RoadDistanceCoverage = new (this, "x_int_RoadDistanceCoverage", 3, SqlDbType.Int) {
                Name = "int_RoadDistanceCoverage",
                Expression = "[int_RoadDistanceCoverage]",
                BasicSearchExpression = "CAST([int_RoadDistanceCoverage] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_RoadDistanceCoverage]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "int_RoadDistanceCoverage", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_RoadDistanceCoverage", int_RoadDistanceCoverage);

            // IsCashDrawer
            IsCashDrawer = new (this, "x_IsCashDrawer", 3, SqlDbType.Int) {
                Name = "IsCashDrawer",
                Expression = "[IsCashDrawer]",
                BasicSearchExpression = "CAST([IsCashDrawer] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[IsCashDrawer]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblLocation", "IsCashDrawer", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("IsCashDrawer", IsCashDrawer);

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
            get => _sqlFrom ?? "dbo.tblLocation";
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
                int_Location_Id.DbValue = row["int_Location_Id"]; // Set DB value only
                str_Name.DbValue = row["str_Name"]; // Set DB value only
                str_Code.DbValue = row["str_Code"]; // Set DB value only
                str_Location_Type.DbValue = row["str_Location_Type"]; // Set DB value only
                str_Address1.DbValue = row["str_Address1"]; // Set DB value only
                str_Address2.DbValue = row["str_Address2"]; // Set DB value only
                str_City.DbValue = row["str_City"]; // Set DB value only
                int_State.DbValue = row["int_State"]; // Set DB value only
                str_Zip.DbValue = row["str_Zip"]; // Set DB value only
                str_County.DbValue = row["str_County"]; // Set DB value only
                str_Manager.DbValue = row["str_Manager"]; // Set DB value only
                str_Phone_Main.DbValue = row["str_Phone_Main"]; // Set DB value only
                str_Phone_Fax.DbValue = row["str_Phone_Fax"]; // Set DB value only
                str_Phone_Other.DbValue = row["str_Phone_Other"]; // Set DB value only
                str_Notes.DbValue = row["str_Notes"]; // Set DB value only
                str_Coverage_Code.DbValue = row["str_Coverage_Code"]; // Set DB value only
                int_Status.DbValue = row["int_Status"]; // Set DB value only
                date_Created.DbValue = row["date_Created"]; // Set DB value only
                date_Modified.DbValue = row["date_Modified"]; // Set DB value only
                int_Created_By.DbValue = row["int_Created_By"]; // Set DB value only
                int_Modified_By.DbValue = row["int_Modified_By"]; // Set DB value only
                bit_IsDeleted.DbValue = (ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"); // Set DB value only
                str_LocCapacity.DbValue = row["str_LocCapacity"]; // Set DB value only
                str_ContactEmail.DbValue = row["str_ContactEmail"]; // Set DB value only
                str_SchoolHours.DbValue = row["str_SchoolHours"]; // Set DB value only
                str_EmerName.DbValue = row["str_EmerName"]; // Set DB value only
                str_EmerPhone.DbValue = row["str_EmerPhone"]; // Set DB value only
                str_Room.DbValue = row["str_Room"]; // Set DB value only
                str_Email_Content.DbValue = row["str_Email_Content"]; // Set DB value only
                bit_appointmentColor.DbValue = (ConvertToBool(row["bit_appointmentColor"]) ? "1" : "0"); // Set DB value only
                str_appointmentColorCode.DbValue = row["str_appointmentColorCode"]; // Set DB value only
                isKnowledgeTest.DbValue = (ConvertToBool(row["isKnowledgeTest"]) ? "1" : "0"); // Set DB value only
                isRoadTest.DbValue = (ConvertToBool(row["isRoadTest"]) ? "1" : "0"); // Set DB value only
                dec_Latitude.DbValue = row["dec_Latitude"]; // Set DB value only
                dec_Longitude.DbValue = row["dec_Longitude"]; // Set DB value only
                str_nameAr.DbValue = row["str_nameAr"]; // Set DB value only
                IsDistanceBasedScheduling.DbValue = row["IsDistanceBasedScheduling"]; // Set DB value only
                str_ZoomEmail.DbValue = row["str_ZoomEmail"]; // Set DB value only
                str_ProviderLocationId.DbValue = row["str_ProviderLocationId"]; // Set DB value only
                int_RoadDistanceCoverage.DbValue = row["int_RoadDistanceCoverage"]; // Set DB value only
                IsCashDrawer.DbValue = row["IsCashDrawer"]; // Set DB value only
            } catch {}
        }

        public void DeleteUploadedFiles(Dictionary<string, object> row)
        {
            LoadDbValues(row);
        }

        // Record filter WHERE clause
        private string _sqlKeyFilter => "[int_Location_Id] = @int_Location_Id@";

        #pragma warning disable 168, 219
        // Get record filter as string
        public string GetRecordFilter(Dictionary<string, object>? row = null, bool current = false)
        {
            string keyFilter = _sqlKeyFilter;
            object? val = null, result = "";
            val = row?.TryGetValue("int_Location_Id", out result) ?? false
                ? result
                : !Empty(int_Location_Id.OldValue) && !current ? int_Location_Id.OldValue : int_Location_Id.CurrentValue;
            if (!IsNumeric(val))
                return "0=1"; // Invalid key
            if (val == null)
                return "0=1"; // Invalid key
            keyFilter = keyFilter.Replace("@int_Location_Id@", AdjustSql(val, DbId)); // Replace key value
            return keyFilter;
        }

        // Get record filter as Dictionary // DN
        public Dictionary<string, object>? GetRowFilterAsDictionary(IDictionary<string, object>? row = null)
        {
            Dictionary<string, object>? keyFilter = new ();
            object? val = null, result;
            val = row?.TryGetValue("int_Location_Id", out result) ?? false
                ? result
                : !Empty(int_Location_Id.OldValue) ? int_Location_Id.OldValue : int_Location_Id.CurrentValue;
            if (!IsNumeric(val))
                return null; // Invalid key
            if (Empty(val))
                return null; // Invalid key
            keyFilter.Add("int_Location_Id", val); // Add key value
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
                    return "TblLocationList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "TblLocationView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "TblLocationEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "TblLocationAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "TblLocationList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "TblLocationView",
                Config.ApiAddAction => "TblLocationAdd",
                Config.ApiEditAction => "TblLocationEdit",
                Config.ApiDeleteAction => "TblLocationDelete",
                Config.ApiListAction => "TblLocationList",
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
        public string ListUrl => "TblLocationList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblLocationView", parm);
            else
                url = KeyUrl("TblLocationView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "TblLocationAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "TblLocationAdd?" + parm;
            else
                url = "TblLocationAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("TblLocationEdit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblLocationList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("TblLocationAdd", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblLocationList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("TblLocationDelete")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
            return url;
        }

        // Get primary key as JSON
        public string KeyToJson(bool htmlEncode = false)
        {
            string json = "";
            json += "\"int_Location_Id\":" + ConvertToJson(int_Location_Id.CurrentValue, "number", true);
            json = "{" + json + "}";
            if (htmlEncode)
                json = HtmlEncode(json);
            return json;
        }

        // Add key value to URL
        public string KeyUrl(string url, string parm = "") { // DN
            if (!IsNull(int_Location_Id.CurrentValue)) {
                url += "/" + int_Location_Id.CurrentValue;
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
            val = current ? ConvertToString(int_Location_Id.CurrentValue) ?? "" : ConvertToString(int_Location_Id.OldValue) ?? "";
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
            val = row?.TryGetValue("int_Location_Id", out result) ?? false ? ConvertToString(result) : null;
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
                    int_Location_Id.CurrentValue = keys[0];
                } else {
                    int_Location_Id.OldValue = keys[0];
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
                if (RouteValues.TryGetValue("int_Location_Id", out object? v0)) { // int_Location_Id // DN
                    key = UrlDecode(v0); // DN
                } else if (IsApi() && !Empty(keyValues)) {
                    key = keyValues[0];
                } else {
                    key = Param("int_Location_Id");
                }
                keysList.Add(key);
            }
            // Check keys
            foreach (var keys in keysList) {
                if (!IsNumeric(keys)) // int_Location_Id
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
                    int_Location_Id.CurrentValue = keys;
                else
                    int_Location_Id.OldValue = keys;
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
            int_Location_Id.SetDbValue(dr["int_Location_Id"]);
            str_Name.SetDbValue(dr["str_Name"]);
            str_Code.SetDbValue(dr["str_Code"]);
            str_Location_Type.SetDbValue(dr["str_Location_Type"]);
            str_Address1.SetDbValue(dr["str_Address1"]);
            str_Address2.SetDbValue(dr["str_Address2"]);
            str_City.SetDbValue(dr["str_City"]);
            int_State.SetDbValue(dr["int_State"]);
            str_Zip.SetDbValue(dr["str_Zip"]);
            str_County.SetDbValue(dr["str_County"]);
            str_Manager.SetDbValue(dr["str_Manager"]);
            str_Phone_Main.SetDbValue(dr["str_Phone_Main"]);
            str_Phone_Fax.SetDbValue(dr["str_Phone_Fax"]);
            str_Phone_Other.SetDbValue(dr["str_Phone_Other"]);
            str_Notes.SetDbValue(dr["str_Notes"]);
            str_Coverage_Code.SetDbValue(dr["str_Coverage_Code"]);
            int_Status.SetDbValue(dr["int_Status"]);
            date_Created.SetDbValue(dr["date_Created"]);
            date_Modified.SetDbValue(dr["date_Modified"]);
            int_Created_By.SetDbValue(dr["int_Created_By"]);
            int_Modified_By.SetDbValue(dr["int_Modified_By"]);
            bit_IsDeleted.SetDbValue(ConvertToBool(dr["bit_IsDeleted"]) ? "1" : "0");
            str_LocCapacity.SetDbValue(dr["str_LocCapacity"]);
            str_ContactEmail.SetDbValue(dr["str_ContactEmail"]);
            str_SchoolHours.SetDbValue(dr["str_SchoolHours"]);
            str_EmerName.SetDbValue(dr["str_EmerName"]);
            str_EmerPhone.SetDbValue(dr["str_EmerPhone"]);
            str_Room.SetDbValue(dr["str_Room"]);
            str_Email_Content.SetDbValue(dr["str_Email_Content"]);
            bit_appointmentColor.SetDbValue(ConvertToBool(dr["bit_appointmentColor"]) ? "1" : "0");
            str_appointmentColorCode.SetDbValue(dr["str_appointmentColorCode"]);
            isKnowledgeTest.SetDbValue(ConvertToBool(dr["isKnowledgeTest"]) ? "1" : "0");
            isRoadTest.SetDbValue(ConvertToBool(dr["isRoadTest"]) ? "1" : "0");
            dec_Latitude.SetDbValue(dr["dec_Latitude"]);
            dec_Longitude.SetDbValue(dr["dec_Longitude"]);
            str_nameAr.SetDbValue(dr["str_nameAr"]);
            IsDistanceBasedScheduling.SetDbValue(dr["IsDistanceBasedScheduling"]);
            str_ZoomEmail.SetDbValue(dr["str_ZoomEmail"]);
            str_ProviderLocationId.SetDbValue(dr["str_ProviderLocationId"]);
            int_RoadDistanceCoverage.SetDbValue(dr["int_RoadDistanceCoverage"]);
            IsCashDrawer.SetDbValue(dr["IsCashDrawer"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "TblLocationList";
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

            // int_Location_Id

            // str_Name

            // str_Code

            // str_Location_Type

            // str_Address1

            // str_Address2

            // str_City

            // int_State

            // str_Zip

            // str_County

            // str_Manager

            // str_Phone_Main

            // str_Phone_Fax

            // str_Phone_Other

            // str_Notes

            // str_Coverage_Code

            // int_Status

            // date_Created

            // date_Modified

            // int_Created_By

            // int_Modified_By

            // bit_IsDeleted

            // str_LocCapacity

            // str_ContactEmail

            // str_SchoolHours

            // str_EmerName

            // str_EmerPhone

            // str_Room

            // str_Email_Content

            // bit_appointmentColor

            // str_appointmentColorCode

            // isKnowledgeTest

            // isRoadTest

            // dec_Latitude

            // dec_Longitude

            // str_nameAr

            // IsDistanceBasedScheduling

            // str_ZoomEmail

            // str_ProviderLocationId

            // int_RoadDistanceCoverage

            // IsCashDrawer

            // int_Location_Id
            listWrk = new List<object?>();
            listWrk.Add(int_Location_Id.CurrentValue); // DN
            listWrk.Add(int_Location_Id.CurrentValue);
            listWrk.Add(str_Name.CurrentValue);
            listWrk = int_Location_Id.Lookup?.RenderViewRow(listWrk, this);
            dispVal = int_Location_Id.DisplayValue(listWrk);
            if (!Empty(dispVal))
                int_Location_Id.ViewValue = dispVal;
            int_Location_Id.ViewCustomAttributes = "";

            // str_Name
            str_Name.ViewValue = ConvertToString(str_Name.CurrentValue); // DN
            str_Name.ViewCustomAttributes = "";

            // str_Code
            str_Code.ViewValue = ConvertToString(str_Code.CurrentValue); // DN
            str_Code.ViewCustomAttributes = "";

            // str_Location_Type
            str_Location_Type.ViewValue = ConvertToString(str_Location_Type.CurrentValue); // DN
            str_Location_Type.ViewCustomAttributes = "";

            // str_Address1
            str_Address1.ViewValue = ConvertToString(str_Address1.CurrentValue); // DN
            str_Address1.ViewCustomAttributes = "";

            // str_Address2
            str_Address2.ViewValue = ConvertToString(str_Address2.CurrentValue); // DN
            str_Address2.ViewCustomAttributes = "";

            // str_City
            str_City.ViewValue = ConvertToString(str_City.CurrentValue); // DN
            str_City.ViewCustomAttributes = "";

            // int_State
            int_State.ViewValue = int_State.CurrentValue;
            int_State.ViewValue = FormatNumber(int_State.ViewValue, int_State.FormatPattern);
            int_State.ViewCustomAttributes = "";

            // str_Zip
            str_Zip.ViewValue = ConvertToString(str_Zip.CurrentValue); // DN
            str_Zip.ViewCustomAttributes = "";

            // str_County
            str_County.ViewValue = ConvertToString(str_County.CurrentValue); // DN
            str_County.ViewCustomAttributes = "";

            // str_Manager
            str_Manager.ViewValue = ConvertToString(str_Manager.CurrentValue); // DN
            str_Manager.ViewCustomAttributes = "";

            // str_Phone_Main
            str_Phone_Main.ViewValue = ConvertToString(str_Phone_Main.CurrentValue); // DN
            str_Phone_Main.ViewCustomAttributes = "";

            // str_Phone_Fax
            str_Phone_Fax.ViewValue = ConvertToString(str_Phone_Fax.CurrentValue); // DN
            str_Phone_Fax.ViewCustomAttributes = "";

            // str_Phone_Other
            str_Phone_Other.ViewValue = ConvertToString(str_Phone_Other.CurrentValue); // DN
            str_Phone_Other.ViewCustomAttributes = "";

            // str_Notes
            str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
            str_Notes.ViewCustomAttributes = "";

            // str_Coverage_Code
            str_Coverage_Code.ViewValue = str_Coverage_Code.CurrentValue;
            str_Coverage_Code.ViewCustomAttributes = "";

            // int_Status
            int_Status.ViewValue = int_Status.CurrentValue;
            int_Status.ViewValue = FormatNumber(int_Status.ViewValue, int_Status.FormatPattern);
            int_Status.ViewCustomAttributes = "";

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

            // bit_IsDeleted
            if (ConvertToBool(bit_IsDeleted.CurrentValue)) {
                bit_IsDeleted.ViewValue = bit_IsDeleted.TagCaption(1) != "" ? bit_IsDeleted.TagCaption(1) : "Yes";
            } else {
                bit_IsDeleted.ViewValue = bit_IsDeleted.TagCaption(2) != "" ? bit_IsDeleted.TagCaption(2) : "No";
            }
            bit_IsDeleted.ViewCustomAttributes = "";

            // str_LocCapacity
            str_LocCapacity.ViewValue = ConvertToString(str_LocCapacity.CurrentValue); // DN
            str_LocCapacity.ViewCustomAttributes = "";

            // str_ContactEmail
            str_ContactEmail.ViewValue = ConvertToString(str_ContactEmail.CurrentValue); // DN
            str_ContactEmail.ViewCustomAttributes = "";

            // str_SchoolHours
            str_SchoolHours.ViewValue = ConvertToString(str_SchoolHours.CurrentValue); // DN
            str_SchoolHours.ViewCustomAttributes = "";

            // str_EmerName
            str_EmerName.ViewValue = ConvertToString(str_EmerName.CurrentValue); // DN
            str_EmerName.ViewCustomAttributes = "";

            // str_EmerPhone
            str_EmerPhone.ViewValue = ConvertToString(str_EmerPhone.CurrentValue); // DN
            str_EmerPhone.ViewCustomAttributes = "";

            // str_Room
            str_Room.ViewValue = ConvertToString(str_Room.CurrentValue); // DN
            str_Room.ViewCustomAttributes = "";

            // str_Email_Content
            str_Email_Content.ViewValue = ConvertToString(str_Email_Content.CurrentValue); // DN
            str_Email_Content.ViewCustomAttributes = "";

            // bit_appointmentColor
            if (ConvertToBool(bit_appointmentColor.CurrentValue)) {
                bit_appointmentColor.ViewValue = bit_appointmentColor.TagCaption(1) != "" ? bit_appointmentColor.TagCaption(1) : "Yes";
            } else {
                bit_appointmentColor.ViewValue = bit_appointmentColor.TagCaption(2) != "" ? bit_appointmentColor.TagCaption(2) : "No";
            }
            bit_appointmentColor.ViewCustomAttributes = "";

            // str_appointmentColorCode
            str_appointmentColorCode.ViewValue = ConvertToString(str_appointmentColorCode.CurrentValue); // DN
            str_appointmentColorCode.ViewCustomAttributes = "";

            // isKnowledgeTest
            if (ConvertToBool(isKnowledgeTest.CurrentValue)) {
                isKnowledgeTest.ViewValue = isKnowledgeTest.TagCaption(1) != "" ? isKnowledgeTest.TagCaption(1) : "Yes";
            } else {
                isKnowledgeTest.ViewValue = isKnowledgeTest.TagCaption(2) != "" ? isKnowledgeTest.TagCaption(2) : "No";
            }
            isKnowledgeTest.ViewCustomAttributes = "";

            // isRoadTest
            if (ConvertToBool(isRoadTest.CurrentValue)) {
                isRoadTest.ViewValue = isRoadTest.TagCaption(1) != "" ? isRoadTest.TagCaption(1) : "Yes";
            } else {
                isRoadTest.ViewValue = isRoadTest.TagCaption(2) != "" ? isRoadTest.TagCaption(2) : "No";
            }
            isRoadTest.ViewCustomAttributes = "";

            // dec_Latitude
            dec_Latitude.ViewValue = dec_Latitude.CurrentValue;
            dec_Latitude.ViewValue = FormatNumber(dec_Latitude.ViewValue, dec_Latitude.FormatPattern);
            dec_Latitude.ViewCustomAttributes = "";

            // dec_Longitude
            dec_Longitude.ViewValue = dec_Longitude.CurrentValue;
            dec_Longitude.ViewValue = FormatNumber(dec_Longitude.ViewValue, dec_Longitude.FormatPattern);
            dec_Longitude.ViewCustomAttributes = "";

            // str_nameAr
            str_nameAr.ViewValue = ConvertToString(str_nameAr.CurrentValue); // DN
            str_nameAr.ViewCustomAttributes = "";

            // IsDistanceBasedScheduling
            IsDistanceBasedScheduling.ViewValue = IsDistanceBasedScheduling.CurrentValue;
            IsDistanceBasedScheduling.ViewValue = FormatNumber(IsDistanceBasedScheduling.ViewValue, IsDistanceBasedScheduling.FormatPattern);
            IsDistanceBasedScheduling.ViewCustomAttributes = "";

            // str_ZoomEmail
            str_ZoomEmail.ViewValue = ConvertToString(str_ZoomEmail.CurrentValue); // DN
            str_ZoomEmail.ViewCustomAttributes = "";

            // str_ProviderLocationId
            str_ProviderLocationId.ViewValue = ConvertToString(str_ProviderLocationId.CurrentValue); // DN
            str_ProviderLocationId.ViewCustomAttributes = "";

            // int_RoadDistanceCoverage
            int_RoadDistanceCoverage.ViewValue = int_RoadDistanceCoverage.CurrentValue;
            int_RoadDistanceCoverage.ViewValue = FormatNumber(int_RoadDistanceCoverage.ViewValue, int_RoadDistanceCoverage.FormatPattern);
            int_RoadDistanceCoverage.ViewCustomAttributes = "";

            // IsCashDrawer
            IsCashDrawer.ViewValue = IsCashDrawer.CurrentValue;
            IsCashDrawer.ViewValue = FormatNumber(IsCashDrawer.ViewValue, IsCashDrawer.FormatPattern);
            IsCashDrawer.ViewCustomAttributes = "";

            // int_Location_Id
            int_Location_Id.HrefValue = "";
            int_Location_Id.TooltipValue = "";

            // str_Name
            str_Name.HrefValue = "";
            str_Name.TooltipValue = "";

            // str_Code
            str_Code.HrefValue = "";
            str_Code.TooltipValue = "";

            // str_Location_Type
            str_Location_Type.HrefValue = "";
            str_Location_Type.TooltipValue = "";

            // str_Address1
            str_Address1.HrefValue = "";
            str_Address1.TooltipValue = "";

            // str_Address2
            str_Address2.HrefValue = "";
            str_Address2.TooltipValue = "";

            // str_City
            str_City.HrefValue = "";
            str_City.TooltipValue = "";

            // int_State
            int_State.HrefValue = "";
            int_State.TooltipValue = "";

            // str_Zip
            str_Zip.HrefValue = "";
            str_Zip.TooltipValue = "";

            // str_County
            str_County.HrefValue = "";
            str_County.TooltipValue = "";

            // str_Manager
            str_Manager.HrefValue = "";
            str_Manager.TooltipValue = "";

            // str_Phone_Main
            str_Phone_Main.HrefValue = "";
            str_Phone_Main.TooltipValue = "";

            // str_Phone_Fax
            str_Phone_Fax.HrefValue = "";
            str_Phone_Fax.TooltipValue = "";

            // str_Phone_Other
            str_Phone_Other.HrefValue = "";
            str_Phone_Other.TooltipValue = "";

            // str_Notes
            str_Notes.HrefValue = "";
            str_Notes.TooltipValue = "";

            // str_Coverage_Code
            str_Coverage_Code.HrefValue = "";
            str_Coverage_Code.TooltipValue = "";

            // int_Status
            int_Status.HrefValue = "";
            int_Status.TooltipValue = "";

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

            // bit_IsDeleted
            bit_IsDeleted.HrefValue = "";
            bit_IsDeleted.TooltipValue = "";

            // str_LocCapacity
            str_LocCapacity.HrefValue = "";
            str_LocCapacity.TooltipValue = "";

            // str_ContactEmail
            str_ContactEmail.HrefValue = "";
            str_ContactEmail.TooltipValue = "";

            // str_SchoolHours
            str_SchoolHours.HrefValue = "";
            str_SchoolHours.TooltipValue = "";

            // str_EmerName
            str_EmerName.HrefValue = "";
            str_EmerName.TooltipValue = "";

            // str_EmerPhone
            str_EmerPhone.HrefValue = "";
            str_EmerPhone.TooltipValue = "";

            // str_Room
            str_Room.HrefValue = "";
            str_Room.TooltipValue = "";

            // str_Email_Content
            str_Email_Content.HrefValue = "";
            str_Email_Content.TooltipValue = "";

            // bit_appointmentColor
            bit_appointmentColor.HrefValue = "";
            bit_appointmentColor.TooltipValue = "";

            // str_appointmentColorCode
            str_appointmentColorCode.HrefValue = "";
            str_appointmentColorCode.TooltipValue = "";

            // isKnowledgeTest
            isKnowledgeTest.HrefValue = "";
            isKnowledgeTest.TooltipValue = "";

            // isRoadTest
            isRoadTest.HrefValue = "";
            isRoadTest.TooltipValue = "";

            // dec_Latitude
            dec_Latitude.HrefValue = "";
            dec_Latitude.TooltipValue = "";

            // dec_Longitude
            dec_Longitude.HrefValue = "";
            dec_Longitude.TooltipValue = "";

            // str_nameAr
            str_nameAr.HrefValue = "";
            str_nameAr.TooltipValue = "";

            // IsDistanceBasedScheduling
            IsDistanceBasedScheduling.HrefValue = "";
            IsDistanceBasedScheduling.TooltipValue = "";

            // str_ZoomEmail
            str_ZoomEmail.HrefValue = "";
            str_ZoomEmail.TooltipValue = "";

            // str_ProviderLocationId
            str_ProviderLocationId.HrefValue = "";
            str_ProviderLocationId.TooltipValue = "";

            // int_RoadDistanceCoverage
            int_RoadDistanceCoverage.HrefValue = "";
            int_RoadDistanceCoverage.TooltipValue = "";

            // IsCashDrawer
            IsCashDrawer.HrefValue = "";
            IsCashDrawer.TooltipValue = "";

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

            // int_Location_Id
            int_Location_Id.SetupEditAttributes();
            int_Location_Id.PlaceHolder = RemoveHtml(int_Location_Id.Caption);

            // str_Name
            str_Name.SetupEditAttributes();
            if (!str_Name.Raw)
                str_Name.CurrentValue = HtmlDecode(str_Name.CurrentValue);
            str_Name.EditValue = HtmlEncode(str_Name.CurrentValue);
            str_Name.PlaceHolder = RemoveHtml(str_Name.Caption);

            // str_Code
            str_Code.SetupEditAttributes();
            if (!str_Code.Raw)
                str_Code.CurrentValue = HtmlDecode(str_Code.CurrentValue);
            str_Code.EditValue = HtmlEncode(str_Code.CurrentValue);
            str_Code.PlaceHolder = RemoveHtml(str_Code.Caption);

            // str_Location_Type
            str_Location_Type.SetupEditAttributes();
            if (!str_Location_Type.Raw)
                str_Location_Type.CurrentValue = HtmlDecode(str_Location_Type.CurrentValue);
            str_Location_Type.EditValue = HtmlEncode(str_Location_Type.CurrentValue);
            str_Location_Type.PlaceHolder = RemoveHtml(str_Location_Type.Caption);

            // str_Address1
            str_Address1.SetupEditAttributes();
            if (!str_Address1.Raw)
                str_Address1.CurrentValue = HtmlDecode(str_Address1.CurrentValue);
            str_Address1.EditValue = HtmlEncode(str_Address1.CurrentValue);
            str_Address1.PlaceHolder = RemoveHtml(str_Address1.Caption);

            // str_Address2
            str_Address2.SetupEditAttributes();
            if (!str_Address2.Raw)
                str_Address2.CurrentValue = HtmlDecode(str_Address2.CurrentValue);
            str_Address2.EditValue = HtmlEncode(str_Address2.CurrentValue);
            str_Address2.PlaceHolder = RemoveHtml(str_Address2.Caption);

            // str_City
            str_City.SetupEditAttributes();
            if (!str_City.Raw)
                str_City.CurrentValue = HtmlDecode(str_City.CurrentValue);
            str_City.EditValue = HtmlEncode(str_City.CurrentValue);
            str_City.PlaceHolder = RemoveHtml(str_City.Caption);

            // int_State
            int_State.SetupEditAttributes();
            int_State.EditValue = int_State.CurrentValue; // DN
            int_State.PlaceHolder = RemoveHtml(int_State.Caption);
            if (!Empty(int_State.EditValue) && IsNumeric(int_State.EditValue))
                int_State.EditValue = FormatNumber(int_State.EditValue, null);

            // str_Zip
            str_Zip.SetupEditAttributes();
            if (!str_Zip.Raw)
                str_Zip.CurrentValue = HtmlDecode(str_Zip.CurrentValue);
            str_Zip.EditValue = HtmlEncode(str_Zip.CurrentValue);
            str_Zip.PlaceHolder = RemoveHtml(str_Zip.Caption);

            // str_County
            str_County.SetupEditAttributes();
            if (!str_County.Raw)
                str_County.CurrentValue = HtmlDecode(str_County.CurrentValue);
            str_County.EditValue = HtmlEncode(str_County.CurrentValue);
            str_County.PlaceHolder = RemoveHtml(str_County.Caption);

            // str_Manager
            str_Manager.SetupEditAttributes();
            if (!str_Manager.Raw)
                str_Manager.CurrentValue = HtmlDecode(str_Manager.CurrentValue);
            str_Manager.EditValue = HtmlEncode(str_Manager.CurrentValue);
            str_Manager.PlaceHolder = RemoveHtml(str_Manager.Caption);

            // str_Phone_Main
            str_Phone_Main.SetupEditAttributes();
            if (!str_Phone_Main.Raw)
                str_Phone_Main.CurrentValue = HtmlDecode(str_Phone_Main.CurrentValue);
            str_Phone_Main.EditValue = HtmlEncode(str_Phone_Main.CurrentValue);
            str_Phone_Main.PlaceHolder = RemoveHtml(str_Phone_Main.Caption);

            // str_Phone_Fax
            str_Phone_Fax.SetupEditAttributes();
            if (!str_Phone_Fax.Raw)
                str_Phone_Fax.CurrentValue = HtmlDecode(str_Phone_Fax.CurrentValue);
            str_Phone_Fax.EditValue = HtmlEncode(str_Phone_Fax.CurrentValue);
            str_Phone_Fax.PlaceHolder = RemoveHtml(str_Phone_Fax.Caption);

            // str_Phone_Other
            str_Phone_Other.SetupEditAttributes();
            if (!str_Phone_Other.Raw)
                str_Phone_Other.CurrentValue = HtmlDecode(str_Phone_Other.CurrentValue);
            str_Phone_Other.EditValue = HtmlEncode(str_Phone_Other.CurrentValue);
            str_Phone_Other.PlaceHolder = RemoveHtml(str_Phone_Other.Caption);

            // str_Notes
            str_Notes.SetupEditAttributes();
            if (!str_Notes.Raw)
                str_Notes.CurrentValue = HtmlDecode(str_Notes.CurrentValue);
            str_Notes.EditValue = HtmlEncode(str_Notes.CurrentValue);
            str_Notes.PlaceHolder = RemoveHtml(str_Notes.Caption);

            // str_Coverage_Code
            str_Coverage_Code.SetupEditAttributes();
            str_Coverage_Code.EditValue = str_Coverage_Code.CurrentValue; // DN
            str_Coverage_Code.PlaceHolder = RemoveHtml(str_Coverage_Code.Caption);

            // int_Status
            int_Status.SetupEditAttributes();
            int_Status.EditValue = int_Status.CurrentValue; // DN
            int_Status.PlaceHolder = RemoveHtml(int_Status.Caption);
            if (!Empty(int_Status.EditValue) && IsNumeric(int_Status.EditValue))
                int_Status.EditValue = FormatNumber(int_Status.EditValue, null);

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

            // bit_IsDeleted
            bit_IsDeleted.EditValue = bit_IsDeleted.Options(false);
            bit_IsDeleted.PlaceHolder = RemoveHtml(bit_IsDeleted.Caption);

            // str_LocCapacity
            str_LocCapacity.SetupEditAttributes();
            if (!str_LocCapacity.Raw)
                str_LocCapacity.CurrentValue = HtmlDecode(str_LocCapacity.CurrentValue);
            str_LocCapacity.EditValue = HtmlEncode(str_LocCapacity.CurrentValue);
            str_LocCapacity.PlaceHolder = RemoveHtml(str_LocCapacity.Caption);

            // str_ContactEmail
            str_ContactEmail.SetupEditAttributes();
            if (!str_ContactEmail.Raw)
                str_ContactEmail.CurrentValue = HtmlDecode(str_ContactEmail.CurrentValue);
            str_ContactEmail.EditValue = HtmlEncode(str_ContactEmail.CurrentValue);
            str_ContactEmail.PlaceHolder = RemoveHtml(str_ContactEmail.Caption);

            // str_SchoolHours
            str_SchoolHours.SetupEditAttributes();
            if (!str_SchoolHours.Raw)
                str_SchoolHours.CurrentValue = HtmlDecode(str_SchoolHours.CurrentValue);
            str_SchoolHours.EditValue = HtmlEncode(str_SchoolHours.CurrentValue);
            str_SchoolHours.PlaceHolder = RemoveHtml(str_SchoolHours.Caption);

            // str_EmerName
            str_EmerName.SetupEditAttributes();
            if (!str_EmerName.Raw)
                str_EmerName.CurrentValue = HtmlDecode(str_EmerName.CurrentValue);
            str_EmerName.EditValue = HtmlEncode(str_EmerName.CurrentValue);
            str_EmerName.PlaceHolder = RemoveHtml(str_EmerName.Caption);

            // str_EmerPhone
            str_EmerPhone.SetupEditAttributes();
            if (!str_EmerPhone.Raw)
                str_EmerPhone.CurrentValue = HtmlDecode(str_EmerPhone.CurrentValue);
            str_EmerPhone.EditValue = HtmlEncode(str_EmerPhone.CurrentValue);
            str_EmerPhone.PlaceHolder = RemoveHtml(str_EmerPhone.Caption);

            // str_Room
            str_Room.SetupEditAttributes();
            if (!str_Room.Raw)
                str_Room.CurrentValue = HtmlDecode(str_Room.CurrentValue);
            str_Room.EditValue = HtmlEncode(str_Room.CurrentValue);
            str_Room.PlaceHolder = RemoveHtml(str_Room.Caption);

            // str_Email_Content
            str_Email_Content.SetupEditAttributes();
            if (!str_Email_Content.Raw)
                str_Email_Content.CurrentValue = HtmlDecode(str_Email_Content.CurrentValue);
            str_Email_Content.EditValue = HtmlEncode(str_Email_Content.CurrentValue);
            str_Email_Content.PlaceHolder = RemoveHtml(str_Email_Content.Caption);

            // bit_appointmentColor
            bit_appointmentColor.EditValue = bit_appointmentColor.Options(false);
            bit_appointmentColor.PlaceHolder = RemoveHtml(bit_appointmentColor.Caption);

            // str_appointmentColorCode
            str_appointmentColorCode.SetupEditAttributes();
            if (!str_appointmentColorCode.Raw)
                str_appointmentColorCode.CurrentValue = HtmlDecode(str_appointmentColorCode.CurrentValue);
            str_appointmentColorCode.EditValue = HtmlEncode(str_appointmentColorCode.CurrentValue);
            str_appointmentColorCode.PlaceHolder = RemoveHtml(str_appointmentColorCode.Caption);

            // isKnowledgeTest
            isKnowledgeTest.EditValue = isKnowledgeTest.Options(false);
            isKnowledgeTest.PlaceHolder = RemoveHtml(isKnowledgeTest.Caption);

            // isRoadTest
            isRoadTest.EditValue = isRoadTest.Options(false);
            isRoadTest.PlaceHolder = RemoveHtml(isRoadTest.Caption);

            // dec_Latitude
            dec_Latitude.SetupEditAttributes();
            dec_Latitude.EditValue = dec_Latitude.CurrentValue; // DN
            dec_Latitude.PlaceHolder = RemoveHtml(dec_Latitude.Caption);
            if (!Empty(dec_Latitude.EditValue) && IsNumeric(dec_Latitude.EditValue))
                dec_Latitude.EditValue = FormatNumber(dec_Latitude.EditValue, null);

            // dec_Longitude
            dec_Longitude.SetupEditAttributes();
            dec_Longitude.EditValue = dec_Longitude.CurrentValue; // DN
            dec_Longitude.PlaceHolder = RemoveHtml(dec_Longitude.Caption);
            if (!Empty(dec_Longitude.EditValue) && IsNumeric(dec_Longitude.EditValue))
                dec_Longitude.EditValue = FormatNumber(dec_Longitude.EditValue, null);

            // str_nameAr
            str_nameAr.SetupEditAttributes();
            if (!str_nameAr.Raw)
                str_nameAr.CurrentValue = HtmlDecode(str_nameAr.CurrentValue);
            str_nameAr.EditValue = HtmlEncode(str_nameAr.CurrentValue);
            str_nameAr.PlaceHolder = RemoveHtml(str_nameAr.Caption);

            // IsDistanceBasedScheduling
            IsDistanceBasedScheduling.SetupEditAttributes();
            IsDistanceBasedScheduling.EditValue = IsDistanceBasedScheduling.CurrentValue; // DN
            IsDistanceBasedScheduling.PlaceHolder = RemoveHtml(IsDistanceBasedScheduling.Caption);
            if (!Empty(IsDistanceBasedScheduling.EditValue) && IsNumeric(IsDistanceBasedScheduling.EditValue))
                IsDistanceBasedScheduling.EditValue = FormatNumber(IsDistanceBasedScheduling.EditValue, null);

            // str_ZoomEmail
            str_ZoomEmail.SetupEditAttributes();
            if (!str_ZoomEmail.Raw)
                str_ZoomEmail.CurrentValue = HtmlDecode(str_ZoomEmail.CurrentValue);
            str_ZoomEmail.EditValue = HtmlEncode(str_ZoomEmail.CurrentValue);
            str_ZoomEmail.PlaceHolder = RemoveHtml(str_ZoomEmail.Caption);

            // str_ProviderLocationId
            str_ProviderLocationId.SetupEditAttributes();
            if (!str_ProviderLocationId.Raw)
                str_ProviderLocationId.CurrentValue = HtmlDecode(str_ProviderLocationId.CurrentValue);
            str_ProviderLocationId.EditValue = HtmlEncode(str_ProviderLocationId.CurrentValue);
            str_ProviderLocationId.PlaceHolder = RemoveHtml(str_ProviderLocationId.Caption);

            // int_RoadDistanceCoverage
            int_RoadDistanceCoverage.SetupEditAttributes();
            int_RoadDistanceCoverage.EditValue = int_RoadDistanceCoverage.CurrentValue; // DN
            int_RoadDistanceCoverage.PlaceHolder = RemoveHtml(int_RoadDistanceCoverage.Caption);
            if (!Empty(int_RoadDistanceCoverage.EditValue) && IsNumeric(int_RoadDistanceCoverage.EditValue))
                int_RoadDistanceCoverage.EditValue = FormatNumber(int_RoadDistanceCoverage.EditValue, null);

            // IsCashDrawer
            IsCashDrawer.SetupEditAttributes();
            IsCashDrawer.EditValue = IsCashDrawer.CurrentValue; // DN
            IsCashDrawer.PlaceHolder = RemoveHtml(IsCashDrawer.Caption);
            if (!Empty(IsCashDrawer.EditValue) && IsNumeric(IsCashDrawer.EditValue))
                IsCashDrawer.EditValue = FormatNumber(IsCashDrawer.EditValue, null);

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
                        doc.ExportCaption(int_Location_Id);
                        doc.ExportCaption(str_Name);
                        doc.ExportCaption(str_Code);
                        doc.ExportCaption(str_Location_Type);
                        doc.ExportCaption(str_Address1);
                        doc.ExportCaption(str_Address2);
                        doc.ExportCaption(str_City);
                        doc.ExportCaption(int_State);
                        doc.ExportCaption(str_Zip);
                        doc.ExportCaption(str_County);
                        doc.ExportCaption(str_Manager);
                        doc.ExportCaption(str_Phone_Main);
                        doc.ExportCaption(str_Phone_Fax);
                        doc.ExportCaption(str_Phone_Other);
                        doc.ExportCaption(str_Notes);
                        doc.ExportCaption(str_Coverage_Code);
                        doc.ExportCaption(int_Status);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(int_Created_By);
                        doc.ExportCaption(int_Modified_By);
                        doc.ExportCaption(bit_IsDeleted);
                        doc.ExportCaption(str_LocCapacity);
                        doc.ExportCaption(str_ContactEmail);
                        doc.ExportCaption(str_SchoolHours);
                        doc.ExportCaption(str_EmerName);
                        doc.ExportCaption(str_EmerPhone);
                        doc.ExportCaption(str_Room);
                        doc.ExportCaption(str_Email_Content);
                        doc.ExportCaption(bit_appointmentColor);
                        doc.ExportCaption(str_appointmentColorCode);
                        doc.ExportCaption(isKnowledgeTest);
                        doc.ExportCaption(isRoadTest);
                        doc.ExportCaption(dec_Latitude);
                        doc.ExportCaption(dec_Longitude);
                        doc.ExportCaption(str_nameAr);
                        doc.ExportCaption(IsDistanceBasedScheduling);
                        doc.ExportCaption(str_ZoomEmail);
                        doc.ExportCaption(str_ProviderLocationId);
                        doc.ExportCaption(int_RoadDistanceCoverage);
                        doc.ExportCaption(IsCashDrawer);
                    } else {
                        doc.ExportCaption(int_Location_Id);
                        doc.ExportCaption(str_Name);
                        doc.ExportCaption(str_Code);
                        doc.ExportCaption(str_Location_Type);
                        doc.ExportCaption(str_Address1);
                        doc.ExportCaption(str_Address2);
                        doc.ExportCaption(str_City);
                        doc.ExportCaption(int_State);
                        doc.ExportCaption(str_Zip);
                        doc.ExportCaption(str_County);
                        doc.ExportCaption(str_Manager);
                        doc.ExportCaption(str_Phone_Main);
                        doc.ExportCaption(str_Phone_Fax);
                        doc.ExportCaption(str_Phone_Other);
                        doc.ExportCaption(str_Notes);
                        doc.ExportCaption(int_Status);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(int_Created_By);
                        doc.ExportCaption(int_Modified_By);
                        doc.ExportCaption(bit_IsDeleted);
                        doc.ExportCaption(str_LocCapacity);
                        doc.ExportCaption(str_ContactEmail);
                        doc.ExportCaption(str_SchoolHours);
                        doc.ExportCaption(str_EmerName);
                        doc.ExportCaption(str_EmerPhone);
                        doc.ExportCaption(str_Room);
                        doc.ExportCaption(str_Email_Content);
                        doc.ExportCaption(bit_appointmentColor);
                        doc.ExportCaption(str_appointmentColorCode);
                        doc.ExportCaption(isKnowledgeTest);
                        doc.ExportCaption(isRoadTest);
                        doc.ExportCaption(dec_Latitude);
                        doc.ExportCaption(dec_Longitude);
                        doc.ExportCaption(str_nameAr);
                        doc.ExportCaption(IsDistanceBasedScheduling);
                        doc.ExportCaption(str_ZoomEmail);
                        doc.ExportCaption(str_ProviderLocationId);
                        doc.ExportCaption(int_RoadDistanceCoverage);
                        doc.ExportCaption(IsCashDrawer);
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
                            await doc.ExportField(int_Location_Id);
                            await doc.ExportField(str_Name);
                            await doc.ExportField(str_Code);
                            await doc.ExportField(str_Location_Type);
                            await doc.ExportField(str_Address1);
                            await doc.ExportField(str_Address2);
                            await doc.ExportField(str_City);
                            await doc.ExportField(int_State);
                            await doc.ExportField(str_Zip);
                            await doc.ExportField(str_County);
                            await doc.ExportField(str_Manager);
                            await doc.ExportField(str_Phone_Main);
                            await doc.ExportField(str_Phone_Fax);
                            await doc.ExportField(str_Phone_Other);
                            await doc.ExportField(str_Notes);
                            await doc.ExportField(str_Coverage_Code);
                            await doc.ExportField(int_Status);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(int_Created_By);
                            await doc.ExportField(int_Modified_By);
                            await doc.ExportField(bit_IsDeleted);
                            await doc.ExportField(str_LocCapacity);
                            await doc.ExportField(str_ContactEmail);
                            await doc.ExportField(str_SchoolHours);
                            await doc.ExportField(str_EmerName);
                            await doc.ExportField(str_EmerPhone);
                            await doc.ExportField(str_Room);
                            await doc.ExportField(str_Email_Content);
                            await doc.ExportField(bit_appointmentColor);
                            await doc.ExportField(str_appointmentColorCode);
                            await doc.ExportField(isKnowledgeTest);
                            await doc.ExportField(isRoadTest);
                            await doc.ExportField(dec_Latitude);
                            await doc.ExportField(dec_Longitude);
                            await doc.ExportField(str_nameAr);
                            await doc.ExportField(IsDistanceBasedScheduling);
                            await doc.ExportField(str_ZoomEmail);
                            await doc.ExportField(str_ProviderLocationId);
                            await doc.ExportField(int_RoadDistanceCoverage);
                            await doc.ExportField(IsCashDrawer);
                        } else {
                            await doc.ExportField(int_Location_Id);
                            await doc.ExportField(str_Name);
                            await doc.ExportField(str_Code);
                            await doc.ExportField(str_Location_Type);
                            await doc.ExportField(str_Address1);
                            await doc.ExportField(str_Address2);
                            await doc.ExportField(str_City);
                            await doc.ExportField(int_State);
                            await doc.ExportField(str_Zip);
                            await doc.ExportField(str_County);
                            await doc.ExportField(str_Manager);
                            await doc.ExportField(str_Phone_Main);
                            await doc.ExportField(str_Phone_Fax);
                            await doc.ExportField(str_Phone_Other);
                            await doc.ExportField(str_Notes);
                            await doc.ExportField(int_Status);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(int_Created_By);
                            await doc.ExportField(int_Modified_By);
                            await doc.ExportField(bit_IsDeleted);
                            await doc.ExportField(str_LocCapacity);
                            await doc.ExportField(str_ContactEmail);
                            await doc.ExportField(str_SchoolHours);
                            await doc.ExportField(str_EmerName);
                            await doc.ExportField(str_EmerPhone);
                            await doc.ExportField(str_Room);
                            await doc.ExportField(str_Email_Content);
                            await doc.ExportField(bit_appointmentColor);
                            await doc.ExportField(str_appointmentColorCode);
                            await doc.ExportField(isKnowledgeTest);
                            await doc.ExportField(isRoadTest);
                            await doc.ExportField(dec_Latitude);
                            await doc.ExportField(dec_Longitude);
                            await doc.ExportField(str_nameAr);
                            await doc.ExportField(IsDistanceBasedScheduling);
                            await doc.ExportField(str_ZoomEmail);
                            await doc.ExportField(str_ProviderLocationId);
                            await doc.ExportField(int_RoadDistanceCoverage);
                            await doc.ExportField(IsCashDrawer);
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
