namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblStaff
    /// </summary>
    [MaybeNull]
    public static TblStaff tblStaff
    {
        get => HttpData.Resolve<TblStaff>("tblStaff");
        set => HttpData["tblStaff"] = value;
    }

    /// <summary>
    /// Table class for tblStaff
    /// </summary>
    public class TblStaff : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> int_Staff_Id;

        public readonly DbField<SqlDbType> str_Full_Name;

        public readonly DbField<SqlDbType> str_First_Name;

        public readonly DbField<SqlDbType> str_Middle_Name;

        public readonly DbField<SqlDbType> str_Last_Name;

        public readonly DbField<SqlDbType> str_Username;

        public readonly DbField<SqlDbType> str_Password;

        public readonly DbField<SqlDbType> NationalID;

        public readonly DbField<SqlDbType> str_NationalID_Iqama;

        public readonly DbField<SqlDbType> str_Address;

        public readonly DbField<SqlDbType> str_City;

        public readonly DbField<SqlDbType> int_State;

        public readonly DbField<SqlDbType> str_Zip;

        public readonly DbField<SqlDbType> str_Home_Phone;

        public readonly DbField<SqlDbType> str_Cell_Phone;

        public readonly DbField<SqlDbType> str_Email;

        public readonly DbField<SqlDbType> date_Birth;

        public readonly DbField<SqlDbType> date_Birth_Hijri;

        public readonly DbField<SqlDbType> int_Location;

        public readonly DbField<SqlDbType> str_InstLicenceDate;

        public readonly DbField<SqlDbType> str_DLNum;

        public readonly DbField<SqlDbType> str_DLExp;

        public readonly DbField<SqlDbType> User_Role;

        public readonly DbField<SqlDbType> UserlevelID;

        public readonly DbField<SqlDbType> Activated;

        public readonly DbField<SqlDbType> Supervisor_Username;

        public readonly DbField<SqlDbType> str_Staff_Username;

        public readonly DbField<SqlDbType> Hijri_Year;

        public readonly DbField<SqlDbType> Hijri_Month;

        public readonly DbField<SqlDbType> Hijri_Day;

        public readonly DbField<SqlDbType> int_Nationality;

        public readonly DbField<SqlDbType> date_Created;

        public readonly DbField<SqlDbType> date_Modified;

        public readonly DbField<SqlDbType> int_Created_By;

        public readonly DbField<SqlDbType> int_Modified_By;

        public readonly DbField<SqlDbType> str_Emergency_Contact_Name;

        public readonly DbField<SqlDbType> str_Emergency_Contact_Phone;

        public readonly DbField<SqlDbType> str_Emergency_Contact_Relation;

        public readonly DbField<SqlDbType> ProfileField;

        public readonly DbField<SqlDbType> Absherphoto;

        public readonly DbField<SqlDbType> AbsherApptNbr;

        // Constructor
        public TblStaff()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "tblStaff";
            Name = "tblStaff";
            Type = "TABLE";
            UpdateTable = "dbo.tblStaff"; // Update Table
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

            // int_Staff_Id
            int_Staff_Id = new (this, "x_int_Staff_Id", 3, SqlDbType.Int) {
                Name = "int_Staff_Id",
                Expression = "[int_Staff_Id]",
                BasicSearchExpression = "CAST([int_Staff_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Staff_Id]",
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
                CustomMessage = Language.FieldPhrase("tblStaff", "int_Staff_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Staff_Id", int_Staff_Id);

            // str_Full_Name
            str_Full_Name = new (this, "x_str_Full_Name", 202, SqlDbType.NVarChar) {
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
                HtmlTag = "TEXT",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_Full_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Full_Name", str_Full_Name);

            // str_First_Name
            str_First_Name = new (this, "x_str_First_Name", 202, SqlDbType.NVarChar) {
                Name = "str_First_Name",
                Expression = "[str_First_Name]",
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
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_First_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_First_Name", str_First_Name);

            // str_Middle_Name
            str_Middle_Name = new (this, "x_str_Middle_Name", 202, SqlDbType.NVarChar) {
                Name = "str_Middle_Name",
                Expression = "[str_Middle_Name]",
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
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_Middle_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Middle_Name", str_Middle_Name);

            // str_Last_Name
            str_Last_Name = new (this, "x_str_Last_Name", 202, SqlDbType.NVarChar) {
                Name = "str_Last_Name",
                Expression = "[str_Last_Name]",
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
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_Last_Name", "CustomMsg"),
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
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_Username", "CustomMsg"),
                IsUpload = false
            };
            str_Username.GetAutoUpdateValue = () => CurrentUserName();
            Fields.Add("str_Username", str_Username);

            // str_Password
            str_Password = new (this, "x_str_Password", 202, SqlDbType.NVarChar) {
                Name = "str_Password",
                Expression = "[str_Password]",
                BasicSearchExpression = "[str_Password]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Password]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_Password", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Password", str_Password);

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
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("tblStaff", "NationalID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("NationalID", NationalID);

            // str_NationalID_Iqama
            str_NationalID_Iqama = new (this, "x_str_NationalID_Iqama", 200, SqlDbType.VarChar) {
                Name = "str_NationalID_Iqama",
                Expression = "[str_NationalID_Iqama]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_NationalID_Iqama]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_NationalID_Iqama]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_NationalID_Iqama", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_NationalID_Iqama", str_NationalID_Iqama);

            // str_Address
            str_Address = new (this, "x_str_Address", 202, SqlDbType.NVarChar) {
                Name = "str_Address",
                Expression = "[str_Address]",
                BasicSearchExpression = "[str_Address]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Address]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_Address", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Address", str_Address);

            // str_City
            str_City = new (this, "x_str_City", 202, SqlDbType.NVarChar) {
                Name = "str_City",
                Expression = "[str_City]",
                BasicSearchExpression = "[str_City]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_City]",
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
                CustomMessage = Language.FieldPhrase("tblStaff", "str_City", "CustomMsg"),
                IsUpload = false
            };
            str_City.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(str_City, "Cities", false, "City", new List<string> {"City", "", "", ""}, "", "", new List<string> {}, new List<string> {"x_int_State"}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[City]"),
                "en-US" => new Lookup<DbField>(str_City, "Cities", false, "City", new List<string> {"City", "", "", ""}, "", "", new List<string> {}, new List<string> {"x_int_State"}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[City]"),
                _ => new Lookup<DbField>(str_City, "Cities", false, "City", new List<string> {"City", "", "", ""}, "", "", new List<string> {}, new List<string> {"x_int_State"}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[City]")
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
                HtmlTag = "SELECT",
                InputTextType = "text",
                Required = true, // Required field
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "int_State", "CustomMsg"),
                IsUpload = false
            };
            int_State.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(int_State, "Cities", false, "Province_ID", new List<string> {"Province", "", "", ""}, "", "", new List<string> {"x_str_City"}, new List<string> {}, new List<string> {"City"}, new List<string> {"x_City"}, new List<string> {}, new List<string> {}, "", "", "[Province]"),
                "en-US" => new Lookup<DbField>(int_State, "Cities", false, "Province_ID", new List<string> {"Province", "", "", ""}, "", "", new List<string> {"x_str_City"}, new List<string> {}, new List<string> {"City"}, new List<string> {"x_City"}, new List<string> {}, new List<string> {}, "", "", "[Province]"),
                _ => new Lookup<DbField>(int_State, "Cities", false, "Province_ID", new List<string> {"Province", "", "", ""}, "", "", new List<string> {"x_str_City"}, new List<string> {}, new List<string> {"City"}, new List<string> {"x_City"}, new List<string> {}, new List<string> {}, "", "", "[Province]")
            };
            Fields.Add("int_State", int_State);

            // str_Zip
            str_Zip = new (this, "x_str_Zip", 202, SqlDbType.NVarChar) {
                Name = "str_Zip",
                Expression = "[str_Zip]",
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
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_Zip", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Zip", str_Zip);

            // str_Home_Phone
            str_Home_Phone = new (this, "x_str_Home_Phone", 202, SqlDbType.NVarChar) {
                Name = "str_Home_Phone",
                Expression = "[str_Home_Phone]",
                BasicSearchExpression = "[str_Home_Phone]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Home_Phone]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_Home_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Home_Phone", str_Home_Phone);

            // str_Cell_Phone
            str_Cell_Phone = new (this, "x_str_Cell_Phone", 202, SqlDbType.NVarChar) {
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
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_Cell_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Cell_Phone", str_Cell_Phone);

            // str_Email
            str_Email = new (this, "x_str_Email", 202, SqlDbType.NVarChar) {
                Name = "str_Email",
                Expression = "[str_Email]",
                UseBasicSearch = true,
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
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectEmail"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_Email", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Email", str_Email);

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
                Required = true, // Required field
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "date_Birth", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("tblStaff", "date_Birth_Hijri", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Birth_Hijri", date_Birth_Hijri);

            // int_Location
            int_Location = new (this, "x_int_Location", 3, SqlDbType.Int) {
                Name = "int_Location",
                Expression = "[int_Location]",
                BasicSearchExpression = "CAST([int_Location] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Location]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "int_Location", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Location", int_Location);

            // str_InstLicenceDate
            str_InstLicenceDate = new (this, "x_str_InstLicenceDate", 200, SqlDbType.VarChar) {
                Name = "str_InstLicenceDate",
                Expression = "[str_InstLicenceDate]",
                BasicSearchExpression = "[str_InstLicenceDate]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_InstLicenceDate]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_InstLicenceDate", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_InstLicenceDate", str_InstLicenceDate);

            // str_DLNum
            str_DLNum = new (this, "x_str_DLNum", 200, SqlDbType.VarChar) {
                Name = "str_DLNum",
                Expression = "[str_DLNum]",
                BasicSearchExpression = "[str_DLNum]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_DLNum]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_DLNum", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_DLNum", str_DLNum);

            // str_DLExp
            str_DLExp = new (this, "x_str_DLExp", 130, SqlDbType.NChar) {
                Name = "str_DLExp",
                Expression = "[str_DLExp]",
                BasicSearchExpression = "[str_DLExp]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_DLExp]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_DLExp", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_DLExp", str_DLExp);

            // User_Role
            User_Role = new (this, "x_User_Role", 200, SqlDbType.VarChar) {
                Name = "User_Role",
                Expression = "[User_Role]",
                BasicSearchExpression = "[User_Role]",
                DateTimeFormat = -1,
                VirtualExpression = "[User_Role]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "User_Role", "CustomMsg"),
                IsUpload = false
            };
            User_Role.GetSelectFilter = () => "[UserLevelID] != 30";
            User_Role.GetDefault = () => "Employee";
            Fields.Add("User_Role", User_Role);

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
                HtmlTag = "SELECT",
                InputTextType = "text",
                Required = true, // Required field
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "UserlevelID", "CustomMsg"),
                IsUpload = false
            };
            UserlevelID.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(UserlevelID, "UserLevels", false, "UserLevelID", new List<string> {"UserLevelID", "UserLevelName", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT(CAST([UserLevelID] AS NVARCHAR),'" + ValueSeparator(1, UserlevelID) + "',[UserLevelName])"),
                "en-US" => new Lookup<DbField>(UserlevelID, "UserLevels", false, "UserLevelID", new List<string> {"UserLevelID", "UserLevelName", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT(CAST([UserLevelID] AS NVARCHAR),'" + ValueSeparator(1, UserlevelID) + "',[UserLevelName])"),
                _ => new Lookup<DbField>(UserlevelID, "UserLevels", false, "UserLevelID", new List<string> {"UserLevelID", "UserLevelName", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT(CAST([UserLevelID] AS NVARCHAR),'" + ValueSeparator(1, UserlevelID) + "',[UserLevelName])")
            };
            Fields.Add("UserlevelID", UserlevelID);

            // Activated
            Activated = new (this, "x_Activated", 11, SqlDbType.Bit) {
                Name = "Activated",
                Expression = "[Activated]",
                BasicSearchExpression = "[Activated]",
                DateTimeFormat = -1,
                VirtualExpression = "[Activated]",
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
                CustomMessage = Language.FieldPhrase("tblStaff", "Activated", "CustomMsg"),
                IsUpload = false
            };
            Activated.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Activated, "tblStaff", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Activated, "tblStaff", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Activated, "tblStaff", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Activated", Activated);

            // Supervisor_Username
            Supervisor_Username = new (this, "x_Supervisor_Username", 202, SqlDbType.NVarChar) {
                Name = "Supervisor_Username",
                Expression = "[Supervisor_Username]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Supervisor_Username]",
                DateTimeFormat = -1,
                VirtualExpression = "[Supervisor_Username]",
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
                CustomMessage = Language.FieldPhrase("tblStaff", "Supervisor_Username", "CustomMsg"),
                IsUpload = false
            };
            Supervisor_Username.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Supervisor_Username, "qryStaffList", false, "str_Staff_Username", new List<string> {"str_Full_Name", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[str_Full_Name]"),
                "en-US" => new Lookup<DbField>(Supervisor_Username, "qryStaffList", false, "str_Staff_Username", new List<string> {"str_Full_Name", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[str_Full_Name]"),
                _ => new Lookup<DbField>(Supervisor_Username, "qryStaffList", false, "str_Staff_Username", new List<string> {"str_Full_Name", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[str_Full_Name]")
            };
            Fields.Add("Supervisor_Username", Supervisor_Username);

            // str_Staff_Username
            str_Staff_Username = new (this, "x_str_Staff_Username", 202, SqlDbType.NVarChar) {
                Name = "str_Staff_Username",
                Expression = "[str_Staff_Username]",
                BasicSearchExpression = "[str_Staff_Username]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Staff_Username]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_Staff_Username", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Staff_Username", str_Staff_Username);

            // Hijri_Year
            Hijri_Year = new (this, "x_Hijri_Year", 3, SqlDbType.Int) {
                Name = "Hijri_Year",
                Expression = "[Hijri_Year]",
                BasicSearchExpression = "CAST([Hijri_Year] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Hijri_Year]",
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
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "Hijri_Year", "CustomMsg"),
                IsUpload = false
            };
            Hijri_Year.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Hijri_Year, "Hijri_Table", false, "Hijri_Year", new List<string> {"Hijri_Year", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CAST([Hijri_Year] AS NVARCHAR)"),
                "en-US" => new Lookup<DbField>(Hijri_Year, "Hijri_Table", false, "Hijri_Year", new List<string> {"Hijri_Year", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CAST([Hijri_Year] AS NVARCHAR)"),
                _ => new Lookup<DbField>(Hijri_Year, "Hijri_Table", false, "Hijri_Year", new List<string> {"Hijri_Year", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CAST([Hijri_Year] AS NVARCHAR)")
            };
            Fields.Add("Hijri_Year", Hijri_Year);

            // Hijri_Month
            Hijri_Month = new (this, "x_Hijri_Month", 3, SqlDbType.Int) {
                Name = "Hijri_Month",
                Expression = "[Hijri_Month]",
                BasicSearchExpression = "CAST([Hijri_Month] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Hijri_Month]",
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
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "Hijri_Month", "CustomMsg"),
                IsUpload = false
            };
            Hijri_Month.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Hijri_Month, "Hijri_Table", false, "Hijri_Month", new List<string> {"Hijri_Month", "Hijri_Monthname", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT(CAST([Hijri_Month] AS NVARCHAR),'" + ValueSeparator(1, Hijri_Month) + "',[Hijri_Monthname])"),
                "en-US" => new Lookup<DbField>(Hijri_Month, "Hijri_Table", false, "Hijri_Month", new List<string> {"Hijri_Month", "Hijri_Monthname", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT(CAST([Hijri_Month] AS NVARCHAR),'" + ValueSeparator(1, Hijri_Month) + "',[Hijri_Monthname])"),
                _ => new Lookup<DbField>(Hijri_Month, "Hijri_Table", false, "Hijri_Month", new List<string> {"Hijri_Month", "Hijri_Monthname", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CONCAT(CAST([Hijri_Month] AS NVARCHAR),'" + ValueSeparator(1, Hijri_Month) + "',[Hijri_Monthname])")
            };
            Hijri_Month.GetSelectFilter = () => "[Hijri_Month] != 0";
            Fields.Add("Hijri_Month", Hijri_Month);

            // Hijri_Day
            Hijri_Day = new (this, "x_Hijri_Day", 3, SqlDbType.Int) {
                Name = "Hijri_Day",
                Expression = "[Hijri_Day]",
                BasicSearchExpression = "CAST([Hijri_Day] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Hijri_Day]",
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
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "Hijri_Day", "CustomMsg"),
                IsUpload = false
            };
            Hijri_Day.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Hijri_Day, "Hijri_Table", false, "Hijri_Day", new List<string> {"Hijri_Day", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CAST([Hijri_Day] AS NVARCHAR)"),
                "en-US" => new Lookup<DbField>(Hijri_Day, "Hijri_Table", false, "Hijri_Day", new List<string> {"Hijri_Day", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CAST([Hijri_Day] AS NVARCHAR)"),
                _ => new Lookup<DbField>(Hijri_Day, "Hijri_Table", false, "Hijri_Day", new List<string> {"Hijri_Day", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "CAST([Hijri_Day] AS NVARCHAR)")
            };
            Hijri_Day.GetSelectFilter = () => "[Hijri_Day] is not null";
            Fields.Add("Hijri_Day", Hijri_Day);

            // int_Nationality
            int_Nationality = new (this, "x_int_Nationality", 3, SqlDbType.Int) {
                Name = "int_Nationality",
                Expression = "[int_Nationality]",
                BasicSearchExpression = "CAST([int_Nationality] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Nationality]",
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
                CustomMessage = Language.FieldPhrase("tblStaff", "int_Nationality", "CustomMsg"),
                IsUpload = false
            };
            int_Nationality.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(int_Nationality, "tblNationality", false, "ID", new List<string> {"Nationality_en", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[Nationality_en]"),
                "en-US" => new Lookup<DbField>(int_Nationality, "tblNationality", false, "ID", new List<string> {"Nationality_en", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[Nationality_en]"),
                _ => new Lookup<DbField>(int_Nationality, "tblNationality", false, "ID", new List<string> {"Nationality_en", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[Nationality_en]")
            };
            Fields.Add("int_Nationality", int_Nationality);

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
                CustomMessage = Language.FieldPhrase("tblStaff", "date_Created", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("tblStaff", "date_Modified", "CustomMsg"),
                IsUpload = false
            };
            date_Modified.GetAutoUpdateValue = () => CurrentDateTime();
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
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "int_Created_By", "CustomMsg"),
                IsUpload = false
            };
            int_Created_By.GetAutoUpdateValue = () => CurrentUserID();
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
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "int_Modified_By", "CustomMsg"),
                IsUpload = false
            };
            int_Modified_By.GetAutoUpdateValue = () => CurrentUserID();
            Fields.Add("int_Modified_By", int_Modified_By);

            // str_Emergency_Contact_Name
            str_Emergency_Contact_Name = new (this, "x_str_Emergency_Contact_Name", 202, SqlDbType.NVarChar) {
                Name = "str_Emergency_Contact_Name",
                Expression = "[str_Emergency_Contact_Name]",
                BasicSearchExpression = "[str_Emergency_Contact_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Emergency_Contact_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_Emergency_Contact_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Emergency_Contact_Name", str_Emergency_Contact_Name);

            // str_Emergency_Contact_Phone
            str_Emergency_Contact_Phone = new (this, "x_str_Emergency_Contact_Phone", 200, SqlDbType.VarChar) {
                Name = "str_Emergency_Contact_Phone",
                Expression = "[str_Emergency_Contact_Phone]",
                BasicSearchExpression = "[str_Emergency_Contact_Phone]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Emergency_Contact_Phone]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_Emergency_Contact_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Emergency_Contact_Phone", str_Emergency_Contact_Phone);

            // str_Emergency_Contact_Relation
            str_Emergency_Contact_Relation = new (this, "x_str_Emergency_Contact_Relation", 202, SqlDbType.NVarChar) {
                Name = "str_Emergency_Contact_Relation",
                Expression = "[str_Emergency_Contact_Relation]",
                BasicSearchExpression = "[str_Emergency_Contact_Relation]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Emergency_Contact_Relation]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "SELECT",
                InputTextType = "text",
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                OptionCount = 7,
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "str_Emergency_Contact_Relation", "CustomMsg"),
                IsUpload = false
            };
            str_Emergency_Contact_Relation.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(str_Emergency_Contact_Relation, "tblStaff", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(str_Emergency_Contact_Relation, "tblStaff", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(str_Emergency_Contact_Relation, "tblStaff", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("str_Emergency_Contact_Relation", str_Emergency_Contact_Relation);

            // ProfileField
            ProfileField = new (this, "x_ProfileField", 203, SqlDbType.NText) {
                Name = "ProfileField",
                Expression = "[ProfileField]",
                BasicSearchExpression = "[ProfileField]",
                DateTimeFormat = -1,
                VirtualExpression = "[ProfileField]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "ProfileField", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("ProfileField", ProfileField);

            // Absherphoto
            Absherphoto = new (this, "x_Absherphoto", 202, SqlDbType.NVarChar) {
                Name = "Absherphoto",
                Expression = "[Absherphoto]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Absherphoto]",
                DateTimeFormat = -1,
                VirtualExpression = "[Absherphoto]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "FILE",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "Absherphoto", "CustomMsg"),
                IsUpload = true
            };
            Fields.Add("Absherphoto", Absherphoto);

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
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("tblStaff", "AbsherApptNbr", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("AbsherApptNbr", AbsherApptNbr);

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
            get => _sqlFrom ?? "dbo.tblStaff";
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
                int_Staff_Id.SetDbValue(lastInsertedId);
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
                if (!rsaudit.ContainsKey("int_Staff_Id"))
                    rsaudit.Add("int_Staff_Id", rsold["int_Staff_Id"]);
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
                int_Staff_Id.DbValue = row["int_Staff_Id"]; // Set DB value only
                str_Full_Name.DbValue = row["str_Full_Name"]; // Set DB value only
                str_First_Name.DbValue = row["str_First_Name"]; // Set DB value only
                str_Middle_Name.DbValue = row["str_Middle_Name"]; // Set DB value only
                str_Last_Name.DbValue = row["str_Last_Name"]; // Set DB value only
                str_Username.DbValue = row["str_Username"]; // Set DB value only
                str_Password.DbValue = row["str_Password"]; // Set DB value only
                NationalID.DbValue = row["NationalID"]; // Set DB value only
                str_NationalID_Iqama.DbValue = row["str_NationalID_Iqama"]; // Set DB value only
                str_Address.DbValue = row["str_Address"]; // Set DB value only
                str_City.DbValue = row["str_City"]; // Set DB value only
                int_State.DbValue = row["int_State"]; // Set DB value only
                str_Zip.DbValue = row["str_Zip"]; // Set DB value only
                str_Home_Phone.DbValue = row["str_Home_Phone"]; // Set DB value only
                str_Cell_Phone.DbValue = row["str_Cell_Phone"]; // Set DB value only
                str_Email.DbValue = row["str_Email"]; // Set DB value only
                date_Birth.DbValue = row["date_Birth"]; // Set DB value only
                date_Birth_Hijri.DbValue = row["date_Birth_Hijri"]; // Set DB value only
                int_Location.DbValue = row["int_Location"]; // Set DB value only
                str_InstLicenceDate.DbValue = row["str_InstLicenceDate"]; // Set DB value only
                str_DLNum.DbValue = row["str_DLNum"]; // Set DB value only
                str_DLExp.DbValue = row["str_DLExp"]; // Set DB value only
                User_Role.DbValue = row["User_Role"]; // Set DB value only
                UserlevelID.DbValue = row["UserlevelID"]; // Set DB value only
                Activated.DbValue = (ConvertToBool(row["Activated"]) ? "1" : "0"); // Set DB value only
                Supervisor_Username.DbValue = row["Supervisor_Username"]; // Set DB value only
                str_Staff_Username.DbValue = row["str_Staff_Username"]; // Set DB value only
                Hijri_Year.DbValue = row["Hijri_Year"]; // Set DB value only
                Hijri_Month.DbValue = row["Hijri_Month"]; // Set DB value only
                Hijri_Day.DbValue = row["Hijri_Day"]; // Set DB value only
                int_Nationality.DbValue = row["int_Nationality"]; // Set DB value only
                date_Created.DbValue = row["date_Created"]; // Set DB value only
                date_Modified.DbValue = row["date_Modified"]; // Set DB value only
                int_Created_By.DbValue = row["int_Created_By"]; // Set DB value only
                int_Modified_By.DbValue = row["int_Modified_By"]; // Set DB value only
                str_Emergency_Contact_Name.DbValue = row["str_Emergency_Contact_Name"]; // Set DB value only
                str_Emergency_Contact_Phone.DbValue = row["str_Emergency_Contact_Phone"]; // Set DB value only
                str_Emergency_Contact_Relation.DbValue = row["str_Emergency_Contact_Relation"]; // Set DB value only
                ProfileField.DbValue = row["ProfileField"]; // Set DB value only
                Absherphoto.Upload.DbValue = row["Absherphoto"];
                AbsherApptNbr.DbValue = row["AbsherApptNbr"]; // Set DB value only
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
        private string _sqlKeyFilter => "[int_Staff_Id] = @int_Staff_Id@";

        #pragma warning disable 168, 219
        // Get record filter as string
        public string GetRecordFilter(Dictionary<string, object>? row = null, bool current = false)
        {
            string keyFilter = _sqlKeyFilter;
            object? val = null, result = "";
            val = row?.TryGetValue("int_Staff_Id", out result) ?? false
                ? result
                : !Empty(int_Staff_Id.OldValue) && !current ? int_Staff_Id.OldValue : int_Staff_Id.CurrentValue;
            if (!IsNumeric(val))
                return "0=1"; // Invalid key
            if (val == null)
                return "0=1"; // Invalid key
            keyFilter = keyFilter.Replace("@int_Staff_Id@", AdjustSql(val, DbId)); // Replace key value
            return keyFilter;
        }

        // Get record filter as Dictionary // DN
        public Dictionary<string, object>? GetRowFilterAsDictionary(IDictionary<string, object>? row = null)
        {
            Dictionary<string, object>? keyFilter = new ();
            object? val = null, result;
            val = row?.TryGetValue("int_Staff_Id", out result) ?? false
                ? result
                : !Empty(int_Staff_Id.OldValue) ? int_Staff_Id.OldValue : int_Staff_Id.CurrentValue;
            if (!IsNumeric(val))
                return null; // Invalid key
            if (Empty(val))
                return null; // Invalid key
            keyFilter.Add("int_Staff_Id", val); // Add key value
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
                    return "TblStaffList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "TblStaffView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "TblStaffEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "TblStaffAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "TblStaffList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "TblStaffView",
                Config.ApiAddAction => "TblStaffAdd",
                Config.ApiEditAction => "TblStaffEdit",
                Config.ApiDeleteAction => "TblStaffDelete",
                Config.ApiListAction => "TblStaffList",
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
        public string ListUrl => "TblStaffList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("TblStaffView", parm);
            else
                url = KeyUrl("TblStaffView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "TblStaffAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "TblStaffAdd?" + parm;
            else
                url = "TblStaffAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("TblStaffEdit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblStaffList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("TblStaffAdd", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("TblStaffList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("TblStaffDelete")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
            return url;
        }

        // Get primary key as JSON
        public string KeyToJson(bool htmlEncode = false)
        {
            string json = "";
            json += "\"int_Staff_Id\":" + ConvertToJson(int_Staff_Id.CurrentValue, "number", true);
            json = "{" + json + "}";
            if (htmlEncode)
                json = HtmlEncode(json);
            return json;
        }

        // Add key value to URL
        public string KeyUrl(string url, string parm = "") { // DN
            if (!IsNull(int_Staff_Id.CurrentValue)) {
                url += "/" + int_Staff_Id.CurrentValue;
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
            val = current ? ConvertToString(int_Staff_Id.CurrentValue) ?? "" : ConvertToString(int_Staff_Id.OldValue) ?? "";
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
            val = row?.TryGetValue("int_Staff_Id", out result) ?? false ? ConvertToString(result) : null;
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
                    int_Staff_Id.CurrentValue = keys[0];
                } else {
                    int_Staff_Id.OldValue = keys[0];
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
                if (RouteValues.TryGetValue("int_Staff_Id", out object? v0)) { // int_Staff_Id // DN
                    key = UrlDecode(v0); // DN
                } else if (IsApi() && !Empty(keyValues)) {
                    key = keyValues[0];
                } else {
                    key = Param("int_Staff_Id");
                }
                keysList.Add(key);
            }
            // Check keys
            foreach (var keys in keysList) {
                if (!IsNumeric(keys)) // int_Staff_Id
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
                    int_Staff_Id.CurrentValue = keys;
                else
                    int_Staff_Id.OldValue = keys;
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
            int_Staff_Id.SetDbValue(dr["int_Staff_Id"]);
            str_Full_Name.SetDbValue(dr["str_Full_Name"]);
            str_First_Name.SetDbValue(dr["str_First_Name"]);
            str_Middle_Name.SetDbValue(dr["str_Middle_Name"]);
            str_Last_Name.SetDbValue(dr["str_Last_Name"]);
            str_Username.SetDbValue(dr["str_Username"]);
            str_Password.SetDbValue(dr["str_Password"]);
            NationalID.SetDbValue(dr["NationalID"]);
            str_NationalID_Iqama.SetDbValue(dr["str_NationalID_Iqama"]);
            str_Address.SetDbValue(dr["str_Address"]);
            str_City.SetDbValue(dr["str_City"]);
            int_State.SetDbValue(dr["int_State"]);
            str_Zip.SetDbValue(dr["str_Zip"]);
            str_Home_Phone.SetDbValue(dr["str_Home_Phone"]);
            str_Cell_Phone.SetDbValue(dr["str_Cell_Phone"]);
            str_Email.SetDbValue(dr["str_Email"]);
            date_Birth.SetDbValue(dr["date_Birth"]);
            date_Birth_Hijri.SetDbValue(dr["date_Birth_Hijri"]);
            int_Location.SetDbValue(dr["int_Location"]);
            str_InstLicenceDate.SetDbValue(dr["str_InstLicenceDate"]);
            str_DLNum.SetDbValue(dr["str_DLNum"]);
            str_DLExp.SetDbValue(dr["str_DLExp"]);
            User_Role.SetDbValue(dr["User_Role"]);
            UserlevelID.SetDbValue(dr["UserlevelID"]);
            Activated.SetDbValue(ConvertToBool(dr["Activated"]) ? "1" : "0");
            Supervisor_Username.SetDbValue(dr["Supervisor_Username"]);
            str_Staff_Username.SetDbValue(dr["str_Staff_Username"]);
            Hijri_Year.SetDbValue(dr["Hijri_Year"]);
            Hijri_Month.SetDbValue(dr["Hijri_Month"]);
            Hijri_Day.SetDbValue(dr["Hijri_Day"]);
            int_Nationality.SetDbValue(dr["int_Nationality"]);
            date_Created.SetDbValue(dr["date_Created"]);
            date_Modified.SetDbValue(dr["date_Modified"]);
            int_Created_By.SetDbValue(dr["int_Created_By"]);
            int_Modified_By.SetDbValue(dr["int_Modified_By"]);
            str_Emergency_Contact_Name.SetDbValue(dr["str_Emergency_Contact_Name"]);
            str_Emergency_Contact_Phone.SetDbValue(dr["str_Emergency_Contact_Phone"]);
            str_Emergency_Contact_Relation.SetDbValue(dr["str_Emergency_Contact_Relation"]);
            ProfileField.SetDbValue(dr["ProfileField"]);
            Absherphoto.Upload.DbValue = dr["Absherphoto"];
            Absherphoto.SetDbValue(Absherphoto.Upload.DbValue);
            AbsherApptNbr.SetDbValue(dr["AbsherApptNbr"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "TblStaffList";
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

            // int_Staff_Id

            // str_Full_Name

            // str_First_Name

            // str_Middle_Name

            // str_Last_Name

            // str_Username
            str_Username.CellCssStyle = "white-space: nowrap;";

            // str_Password
            str_Password.CellCssStyle = "white-space: nowrap;";

            // NationalID

            // str_NationalID_Iqama

            // str_Address

            // str_City

            // int_State

            // str_Zip

            // str_Home_Phone

            // str_Cell_Phone

            // str_Email

            // date_Birth

            // date_Birth_Hijri

            // int_Location

            // str_InstLicenceDate

            // str_DLNum

            // str_DLExp

            // User_Role

            // UserlevelID

            // Activated

            // Supervisor_Username

            // str_Staff_Username

            // Hijri_Year

            // Hijri_Month

            // Hijri_Day

            // int_Nationality

            // date_Created

            // date_Modified

            // int_Created_By

            // int_Modified_By

            // str_Emergency_Contact_Name

            // str_Emergency_Contact_Phone

            // str_Emergency_Contact_Relation

            // ProfileField

            // Absherphoto

            // AbsherApptNbr
            AbsherApptNbr.CellCssStyle = "white-space: nowrap;";

            // int_Staff_Id
            int_Staff_Id.ViewValue = int_Staff_Id.CurrentValue;
            int_Staff_Id.ViewValue = FormatNumber(int_Staff_Id.ViewValue, int_Staff_Id.FormatPattern);
            int_Staff_Id.ViewCustomAttributes = "";

            // str_Full_Name
            str_Full_Name.ViewValue = ConvertToString(str_Full_Name.CurrentValue); // DN
            str_Full_Name.ViewCustomAttributes = "";

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
            str_Username.ViewValue = str_Username.CurrentValue;
            str_Username.ViewCustomAttributes = "";

            // str_Password
            str_Password.ViewValue = ConvertToString(str_Password.CurrentValue); // DN
            str_Password.ViewCustomAttributes = "";

            // NationalID
            NationalID.ViewValue = NationalID.CurrentValue;
            NationalID.ViewCustomAttributes = "";

            // str_NationalID_Iqama
            str_NationalID_Iqama.ViewValue = ConvertToString(str_NationalID_Iqama.CurrentValue); // DN
            str_NationalID_Iqama.ViewCustomAttributes = "";

            // str_Address
            str_Address.ViewValue = ConvertToString(str_Address.CurrentValue); // DN
            str_Address.ViewCustomAttributes = "";

            // str_City
            curVal = ConvertToString(str_City.CurrentValue);
            if (!Empty(curVal)) {
                if (str_City.Lookup != null && IsDictionary(str_City.Lookup?.Options) && str_City.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    str_City.ViewValue = str_City.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[City]", "=", str_City.CurrentValue, DataType.String, "");
                    sqlWrk = str_City.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && str_City.Lookup != null) { // Lookup values found
                        var listwrk = str_City.Lookup?.RenderViewRow(rswrk[0]);
                        str_City.ViewValue = str_City.HighlightLookup(ConvertToString(rswrk[0]), str_City.DisplayValue(listwrk));
                    } else {
                        str_City.ViewValue = str_City.CurrentValue;
                    }
                }
            } else {
                str_City.ViewValue = DbNullValue;
            }
            str_City.ViewCustomAttributes = "";

            // int_State
            curVal = ConvertToString(int_State.CurrentValue);
            if (!Empty(curVal)) {
                if (int_State.Lookup != null && IsDictionary(int_State.Lookup?.Options) && int_State.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_State.ViewValue = int_State.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[Province_ID]", "=", int_State.CurrentValue, DataType.Number, "");
                    sqlWrk = int_State.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && int_State.Lookup != null) { // Lookup values found
                        var listwrk = int_State.Lookup?.RenderViewRow(rswrk[0]);
                        int_State.ViewValue = int_State.HighlightLookup(ConvertToString(rswrk[0]), int_State.DisplayValue(listwrk));
                    } else {
                        int_State.ViewValue = FormatNumber(int_State.CurrentValue, int_State.FormatPattern);
                    }
                }
            } else {
                int_State.ViewValue = DbNullValue;
            }
            int_State.ViewCustomAttributes = "";

            // str_Zip
            str_Zip.ViewValue = ConvertToString(str_Zip.CurrentValue); // DN
            str_Zip.ViewCustomAttributes = "";

            // str_Home_Phone
            str_Home_Phone.ViewValue = ConvertToString(str_Home_Phone.CurrentValue); // DN
            str_Home_Phone.ViewCustomAttributes = "";

            // str_Cell_Phone
            str_Cell_Phone.ViewValue = ConvertToString(str_Cell_Phone.CurrentValue); // DN
            str_Cell_Phone.ViewCustomAttributes = "";

            // str_Email
            str_Email.ViewValue = ConvertToString(str_Email.CurrentValue); // DN
            str_Email.ViewCustomAttributes = "";

            // date_Birth
            date_Birth.ViewValue = date_Birth.CurrentValue;
            date_Birth.ViewValue = FormatDateTime(date_Birth.ViewValue, date_Birth.FormatPattern);
            date_Birth.ViewCustomAttributes = "";

            // date_Birth_Hijri
            date_Birth_Hijri.ViewValue = ConvertToString(date_Birth_Hijri.CurrentValue); // DN
            date_Birth_Hijri.ViewCustomAttributes = "";

            // int_Location
            int_Location.ViewValue = int_Location.CurrentValue;
            int_Location.ViewValue = FormatNumber(int_Location.ViewValue, int_Location.FormatPattern);
            int_Location.ViewCustomAttributes = "";

            // str_InstLicenceDate
            str_InstLicenceDate.ViewValue = ConvertToString(str_InstLicenceDate.CurrentValue); // DN
            str_InstLicenceDate.ViewCustomAttributes = "";

            // str_DLNum
            str_DLNum.ViewValue = ConvertToString(str_DLNum.CurrentValue); // DN
            str_DLNum.ViewCustomAttributes = "";

            // str_DLExp
            str_DLExp.ViewValue = ConvertToString(str_DLExp.CurrentValue); // DN
            str_DLExp.ViewCustomAttributes = "";

            // User_Role
            User_Role.ViewValue = User_Role.CurrentValue;
            User_Role.ViewCustomAttributes = "";

            // UserlevelID
            curVal = ConvertToString(UserlevelID.CurrentValue);
            if (!Empty(curVal)) {
                if (UserlevelID.Lookup != null && IsDictionary(UserlevelID.Lookup?.Options) && UserlevelID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    UserlevelID.ViewValue = UserlevelID.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[UserLevelID]", "=", UserlevelID.CurrentValue, DataType.Number, "");
                    sqlWrk = UserlevelID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && UserlevelID.Lookup != null) { // Lookup values found
                        var listwrk = UserlevelID.Lookup?.RenderViewRow(rswrk[0]);
                        UserlevelID.ViewValue = UserlevelID.HighlightLookup(ConvertToString(rswrk[0]), UserlevelID.DisplayValue(listwrk));
                    } else {
                        UserlevelID.ViewValue = FormatNumber(UserlevelID.CurrentValue, UserlevelID.FormatPattern);
                    }
                }
            } else {
                UserlevelID.ViewValue = DbNullValue;
            }
            UserlevelID.ViewCustomAttributes = "";

            // Activated
            if (ConvertToBool(Activated.CurrentValue)) {
                Activated.ViewValue = Activated.TagCaption(1) != "" ? Activated.TagCaption(1) : "Yes";
            } else {
                Activated.ViewValue = Activated.TagCaption(2) != "" ? Activated.TagCaption(2) : "No";
            }
            Activated.ViewCustomAttributes = "";

            // Supervisor_Username
            curVal = ConvertToString(Supervisor_Username.CurrentValue);
            if (!Empty(curVal)) {
                if (Supervisor_Username.Lookup != null && IsDictionary(Supervisor_Username.Lookup?.Options) && Supervisor_Username.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    Supervisor_Username.ViewValue = Supervisor_Username.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[str_Staff_Username]", "=", Supervisor_Username.CurrentValue, DataType.String, "");
                    sqlWrk = Supervisor_Username.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && Supervisor_Username.Lookup != null) { // Lookup values found
                        var listwrk = Supervisor_Username.Lookup?.RenderViewRow(rswrk[0]);
                        Supervisor_Username.ViewValue = Supervisor_Username.HighlightLookup(ConvertToString(rswrk[0]), Supervisor_Username.DisplayValue(listwrk));
                    } else {
                        Supervisor_Username.ViewValue = Supervisor_Username.CurrentValue;
                    }
                }
            } else {
                Supervisor_Username.ViewValue = DbNullValue;
            }
            Supervisor_Username.ViewCustomAttributes = "";

            // str_Staff_Username
            str_Staff_Username.ViewValue = ConvertToString(str_Staff_Username.CurrentValue); // DN
            str_Staff_Username.ViewCustomAttributes = "";

            // Hijri_Year
            curVal = ConvertToString(Hijri_Year.CurrentValue);
            if (!Empty(curVal)) {
                if (Hijri_Year.Lookup != null && IsDictionary(Hijri_Year.Lookup?.Options) && Hijri_Year.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    Hijri_Year.ViewValue = Hijri_Year.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[Hijri_Year]", "=", Hijri_Year.CurrentValue, DataType.Number, "");
                    sqlWrk = Hijri_Year.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && Hijri_Year.Lookup != null) { // Lookup values found
                        var listwrk = Hijri_Year.Lookup?.RenderViewRow(rswrk[0]);
                        Hijri_Year.ViewValue = Hijri_Year.HighlightLookup(ConvertToString(rswrk[0]), Hijri_Year.DisplayValue(listwrk));
                    } else {
                        Hijri_Year.ViewValue = Hijri_Year.CurrentValue;
                    }
                }
            } else {
                Hijri_Year.ViewValue = DbNullValue;
            }
            Hijri_Year.ViewCustomAttributes = "";

            // Hijri_Month
            curVal = ConvertToString(Hijri_Month.CurrentValue);
            if (!Empty(curVal)) {
                if (Hijri_Month.Lookup != null && IsDictionary(Hijri_Month.Lookup?.Options) && Hijri_Month.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    Hijri_Month.ViewValue = Hijri_Month.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[Hijri_Month]", "=", Hijri_Month.CurrentValue, DataType.Number, "");
                    lookupFilter = () => Hijri_Month.GetSelectFilter();
                    sqlWrk = Hijri_Month.Lookup?.GetSql(false, filterWrk, lookupFilter, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && Hijri_Month.Lookup != null) { // Lookup values found
                        var listwrk = Hijri_Month.Lookup?.RenderViewRow(rswrk[0]);
                        Hijri_Month.ViewValue = Hijri_Month.HighlightLookup(ConvertToString(rswrk[0]), Hijri_Month.DisplayValue(listwrk));
                    } else {
                        Hijri_Month.ViewValue = FormatNumber(Hijri_Month.CurrentValue, Hijri_Month.FormatPattern);
                    }
                }
            } else {
                Hijri_Month.ViewValue = DbNullValue;
            }
            Hijri_Month.ViewCustomAttributes = "";

            // Hijri_Day
            curVal = ConvertToString(Hijri_Day.CurrentValue);
            if (!Empty(curVal)) {
                if (Hijri_Day.Lookup != null && IsDictionary(Hijri_Day.Lookup?.Options) && Hijri_Day.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    Hijri_Day.ViewValue = Hijri_Day.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[Hijri_Day]", "=", Hijri_Day.CurrentValue, DataType.Number, "");
                    lookupFilter = () => Hijri_Day.GetSelectFilter();
                    sqlWrk = Hijri_Day.Lookup?.GetSql(false, filterWrk, lookupFilter, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && Hijri_Day.Lookup != null) { // Lookup values found
                        var listwrk = Hijri_Day.Lookup?.RenderViewRow(rswrk[0]);
                        Hijri_Day.ViewValue = Hijri_Day.HighlightLookup(ConvertToString(rswrk[0]), Hijri_Day.DisplayValue(listwrk));
                    } else {
                        Hijri_Day.ViewValue = FormatNumber(Hijri_Day.CurrentValue, Hijri_Day.FormatPattern);
                    }
                }
            } else {
                Hijri_Day.ViewValue = DbNullValue;
            }
            Hijri_Day.ViewCustomAttributes = "";

            // int_Nationality
            curVal = ConvertToString(int_Nationality.CurrentValue);
            if (!Empty(curVal)) {
                if (int_Nationality.Lookup != null && IsDictionary(int_Nationality.Lookup?.Options) && int_Nationality.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_Nationality.ViewValue = int_Nationality.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[ID]", "=", int_Nationality.CurrentValue, DataType.Number, "");
                    sqlWrk = int_Nationality.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && int_Nationality.Lookup != null) { // Lookup values found
                        var listwrk = int_Nationality.Lookup?.RenderViewRow(rswrk[0]);
                        int_Nationality.ViewValue = int_Nationality.HighlightLookup(ConvertToString(rswrk[0]), int_Nationality.DisplayValue(listwrk));
                    } else {
                        int_Nationality.ViewValue = FormatNumber(int_Nationality.CurrentValue, int_Nationality.FormatPattern);
                    }
                }
            } else {
                int_Nationality.ViewValue = DbNullValue;
            }
            int_Nationality.ViewCustomAttributes = "";

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

            // str_Emergency_Contact_Name
            str_Emergency_Contact_Name.ViewValue = ConvertToString(str_Emergency_Contact_Name.CurrentValue); // DN
            str_Emergency_Contact_Name.ViewCustomAttributes = "";

            // str_Emergency_Contact_Phone
            str_Emergency_Contact_Phone.ViewValue = ConvertToString(str_Emergency_Contact_Phone.CurrentValue); // DN
            str_Emergency_Contact_Phone.ViewCustomAttributes = "";

            // str_Emergency_Contact_Relation
            if (!Empty(str_Emergency_Contact_Relation.CurrentValue)) {
                str_Emergency_Contact_Relation.ViewValue = str_Emergency_Contact_Relation.HighlightLookup(ConvertToString(str_Emergency_Contact_Relation.CurrentValue), str_Emergency_Contact_Relation.OptionCaption(ConvertToString(str_Emergency_Contact_Relation.CurrentValue)));
            } else {
                str_Emergency_Contact_Relation.ViewValue = DbNullValue;
            }
            str_Emergency_Contact_Relation.ViewCustomAttributes = "";

            // ProfileField
            ProfileField.ViewValue = ProfileField.CurrentValue;
            ProfileField.ViewCustomAttributes = "";

            // Absherphoto
            if (!IsNull(Absherphoto.Upload.DbValue)) {
                Absherphoto.ViewValue = Absherphoto.Upload.DbValue;
            } else {
                Absherphoto.ViewValue = "";
            }
            Absherphoto.ViewCustomAttributes = "";

            // AbsherApptNbr
            AbsherApptNbr.ViewValue = AbsherApptNbr.CurrentValue;
            AbsherApptNbr.ViewCustomAttributes = "";

            // int_Staff_Id
            int_Staff_Id.HrefValue = "";
            int_Staff_Id.TooltipValue = "";

            // str_Full_Name
            str_Full_Name.HrefValue = "";
            str_Full_Name.TooltipValue = "";

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

            // str_Password
            str_Password.HrefValue = "";
            str_Password.TooltipValue = "";

            // NationalID
            NationalID.HrefValue = "";
            NationalID.TooltipValue = "";

            // str_NationalID_Iqama
            str_NationalID_Iqama.HrefValue = "";
            str_NationalID_Iqama.TooltipValue = "";

            // str_Address
            str_Address.HrefValue = "";
            str_Address.TooltipValue = "";

            // str_City
            str_City.HrefValue = "";
            str_City.TooltipValue = "";

            // int_State
            int_State.HrefValue = "";
            int_State.TooltipValue = "";

            // str_Zip
            str_Zip.HrefValue = "";
            str_Zip.TooltipValue = "";

            // str_Home_Phone
            str_Home_Phone.HrefValue = "";
            str_Home_Phone.TooltipValue = "";

            // str_Cell_Phone
            str_Cell_Phone.HrefValue = "";
            str_Cell_Phone.TooltipValue = "";

            // str_Email
            str_Email.HrefValue = "";
            str_Email.TooltipValue = "";

            // date_Birth
            date_Birth.HrefValue = "";
            date_Birth.TooltipValue = "";

            // date_Birth_Hijri
            date_Birth_Hijri.HrefValue = "";
            date_Birth_Hijri.TooltipValue = "";

            // int_Location
            int_Location.HrefValue = "";
            int_Location.TooltipValue = "";

            // str_InstLicenceDate
            str_InstLicenceDate.HrefValue = "";
            str_InstLicenceDate.TooltipValue = "";

            // str_DLNum
            str_DLNum.HrefValue = "";
            str_DLNum.TooltipValue = "";

            // str_DLExp
            str_DLExp.HrefValue = "";
            str_DLExp.TooltipValue = "";

            // User_Role
            User_Role.HrefValue = "";
            User_Role.TooltipValue = "";

            // UserlevelID
            UserlevelID.HrefValue = "";
            UserlevelID.TooltipValue = "";

            // Activated
            Activated.HrefValue = "";
            Activated.TooltipValue = "";

            // Supervisor_Username
            Supervisor_Username.HrefValue = "";
            Supervisor_Username.TooltipValue = "";

            // str_Staff_Username
            str_Staff_Username.HrefValue = "";
            str_Staff_Username.TooltipValue = "";

            // Hijri_Year
            Hijri_Year.HrefValue = "";
            Hijri_Year.TooltipValue = "";

            // Hijri_Month
            Hijri_Month.HrefValue = "";
            Hijri_Month.TooltipValue = "";

            // Hijri_Day
            Hijri_Day.HrefValue = "";
            Hijri_Day.TooltipValue = "";

            // int_Nationality
            int_Nationality.HrefValue = "";
            int_Nationality.TooltipValue = "";

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

            // str_Emergency_Contact_Name
            str_Emergency_Contact_Name.HrefValue = "";
            str_Emergency_Contact_Name.TooltipValue = "";

            // str_Emergency_Contact_Phone
            str_Emergency_Contact_Phone.HrefValue = "";
            str_Emergency_Contact_Phone.TooltipValue = "";

            // str_Emergency_Contact_Relation
            str_Emergency_Contact_Relation.HrefValue = "";
            str_Emergency_Contact_Relation.TooltipValue = "";

            // ProfileField
            ProfileField.HrefValue = "";
            ProfileField.TooltipValue = "";

            // Absherphoto
            Absherphoto.HrefValue = "";
            Absherphoto.ExportHrefValue = Absherphoto.UploadPath + Absherphoto.Upload.DbValue;
            Absherphoto.TooltipValue = "";

            // AbsherApptNbr
            AbsherApptNbr.HrefValue = "";
            AbsherApptNbr.TooltipValue = "";

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

            // int_Staff_Id
            int_Staff_Id.SetupEditAttributes();
            int_Staff_Id.EditValue = int_Staff_Id.CurrentValue;
            int_Staff_Id.EditValue = FormatNumber(int_Staff_Id.EditValue, int_Staff_Id.FormatPattern);
            int_Staff_Id.ViewCustomAttributes = "";

            // str_Full_Name
            str_Full_Name.SetupEditAttributes();
            if (!str_Full_Name.Raw)
                str_Full_Name.CurrentValue = HtmlDecode(str_Full_Name.CurrentValue);
            str_Full_Name.EditValue = HtmlEncode(str_Full_Name.CurrentValue);
            str_Full_Name.PlaceHolder = RemoveHtml(str_Full_Name.Caption);

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

            // str_Password
            str_Password.SetupEditAttributes();
            if (!str_Password.Raw)
                str_Password.CurrentValue = HtmlDecode(str_Password.CurrentValue);
            str_Password.EditValue = HtmlEncode(str_Password.CurrentValue);
            str_Password.PlaceHolder = RemoveHtml(str_Password.Caption);

            // NationalID
            NationalID.SetupEditAttributes();
            NationalID.EditValue = NationalID.CurrentValue; // DN
            NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);

            // str_NationalID_Iqama
            str_NationalID_Iqama.SetupEditAttributes();
            if (!str_NationalID_Iqama.Raw)
                str_NationalID_Iqama.CurrentValue = HtmlDecode(str_NationalID_Iqama.CurrentValue);
            str_NationalID_Iqama.EditValue = HtmlEncode(str_NationalID_Iqama.CurrentValue);
            str_NationalID_Iqama.PlaceHolder = RemoveHtml(str_NationalID_Iqama.Caption);

            // str_Address
            str_Address.SetupEditAttributes();
            if (!str_Address.Raw)
                str_Address.CurrentValue = HtmlDecode(str_Address.CurrentValue);
            str_Address.EditValue = HtmlEncode(str_Address.CurrentValue);
            str_Address.PlaceHolder = RemoveHtml(str_Address.Caption);

            // str_City
            str_City.SetupEditAttributes();
            str_City.PlaceHolder = RemoveHtml(str_City.Caption);

            // int_State
            int_State.SetupEditAttributes();
            int_State.PlaceHolder = RemoveHtml(int_State.Caption);
            if (!Empty(int_State.EditValue) && IsNumeric(int_State.EditValue))
                int_State.EditValue = FormatNumber(int_State.EditValue, null);

            // str_Zip
            str_Zip.SetupEditAttributes();
            if (!str_Zip.Raw)
                str_Zip.CurrentValue = HtmlDecode(str_Zip.CurrentValue);
            str_Zip.EditValue = HtmlEncode(str_Zip.CurrentValue);
            str_Zip.PlaceHolder = RemoveHtml(str_Zip.Caption);

            // str_Home_Phone
            str_Home_Phone.SetupEditAttributes();
            if (!str_Home_Phone.Raw)
                str_Home_Phone.CurrentValue = HtmlDecode(str_Home_Phone.CurrentValue);
            str_Home_Phone.EditValue = HtmlEncode(str_Home_Phone.CurrentValue);
            str_Home_Phone.PlaceHolder = RemoveHtml(str_Home_Phone.Caption);

            // str_Cell_Phone
            str_Cell_Phone.SetupEditAttributes();
            if (!str_Cell_Phone.Raw)
                str_Cell_Phone.CurrentValue = HtmlDecode(str_Cell_Phone.CurrentValue);
            str_Cell_Phone.EditValue = HtmlEncode(str_Cell_Phone.CurrentValue);
            str_Cell_Phone.PlaceHolder = RemoveHtml(str_Cell_Phone.Caption);

            // str_Email
            str_Email.SetupEditAttributes();
            if (!str_Email.Raw)
                str_Email.CurrentValue = HtmlDecode(str_Email.CurrentValue);
            str_Email.EditValue = HtmlEncode(str_Email.CurrentValue);
            str_Email.PlaceHolder = RemoveHtml(str_Email.Caption);

            // date_Birth
            date_Birth.SetupEditAttributes();
            date_Birth.EditValue = FormatDateTime(date_Birth.CurrentValue, date_Birth.FormatPattern); // DN
            date_Birth.PlaceHolder = RemoveHtml(date_Birth.Caption);

            // date_Birth_Hijri
            date_Birth_Hijri.SetupEditAttributes();
            if (!date_Birth_Hijri.Raw)
                date_Birth_Hijri.CurrentValue = HtmlDecode(date_Birth_Hijri.CurrentValue);
            date_Birth_Hijri.EditValue = HtmlEncode(date_Birth_Hijri.CurrentValue);
            date_Birth_Hijri.PlaceHolder = RemoveHtml(date_Birth_Hijri.Caption);

            // int_Location
            int_Location.SetupEditAttributes();
            int_Location.EditValue = int_Location.CurrentValue; // DN
            int_Location.PlaceHolder = RemoveHtml(int_Location.Caption);
            if (!Empty(int_Location.EditValue) && IsNumeric(int_Location.EditValue))
                int_Location.EditValue = FormatNumber(int_Location.EditValue, null);

            // str_InstLicenceDate
            str_InstLicenceDate.SetupEditAttributes();
            if (!str_InstLicenceDate.Raw)
                str_InstLicenceDate.CurrentValue = HtmlDecode(str_InstLicenceDate.CurrentValue);
            str_InstLicenceDate.EditValue = HtmlEncode(str_InstLicenceDate.CurrentValue);
            str_InstLicenceDate.PlaceHolder = RemoveHtml(str_InstLicenceDate.Caption);

            // str_DLNum
            str_DLNum.SetupEditAttributes();
            if (!str_DLNum.Raw)
                str_DLNum.CurrentValue = HtmlDecode(str_DLNum.CurrentValue);
            str_DLNum.EditValue = HtmlEncode(str_DLNum.CurrentValue);
            str_DLNum.PlaceHolder = RemoveHtml(str_DLNum.Caption);

            // str_DLExp
            str_DLExp.SetupEditAttributes();
            if (!str_DLExp.Raw)
                str_DLExp.CurrentValue = HtmlDecode(str_DLExp.CurrentValue);
            str_DLExp.EditValue = HtmlEncode(str_DLExp.CurrentValue);
            str_DLExp.PlaceHolder = RemoveHtml(str_DLExp.Caption);

            // User_Role
            User_Role.SetupEditAttributes();

            // UserlevelID
            UserlevelID.SetupEditAttributes();
            UserlevelID.PlaceHolder = RemoveHtml(UserlevelID.Caption);
            if (!Empty(UserlevelID.EditValue) && IsNumeric(UserlevelID.EditValue))
                UserlevelID.EditValue = FormatNumber(UserlevelID.EditValue, null);

            // Activated
            Activated.EditValue = Activated.Options(false);
            Activated.PlaceHolder = RemoveHtml(Activated.Caption);

            // Supervisor_Username
            Supervisor_Username.SetupEditAttributes();
            Supervisor_Username.PlaceHolder = RemoveHtml(Supervisor_Username.Caption);

            // str_Staff_Username
            str_Staff_Username.SetupEditAttributes();
            if (!str_Staff_Username.Raw)
                str_Staff_Username.CurrentValue = HtmlDecode(str_Staff_Username.CurrentValue);
            str_Staff_Username.EditValue = HtmlEncode(str_Staff_Username.CurrentValue);
            str_Staff_Username.PlaceHolder = RemoveHtml(str_Staff_Username.Caption);

            // Hijri_Year
            Hijri_Year.SetupEditAttributes();
            Hijri_Year.PlaceHolder = RemoveHtml(Hijri_Year.Caption);

            // Hijri_Month
            Hijri_Month.SetupEditAttributes();
            Hijri_Month.PlaceHolder = RemoveHtml(Hijri_Month.Caption);
            if (!Empty(Hijri_Month.EditValue) && IsNumeric(Hijri_Month.EditValue))
                Hijri_Month.EditValue = FormatNumber(Hijri_Month.EditValue, null);

            // Hijri_Day
            Hijri_Day.SetupEditAttributes();
            Hijri_Day.PlaceHolder = RemoveHtml(Hijri_Day.Caption);
            if (!Empty(Hijri_Day.EditValue) && IsNumeric(Hijri_Day.EditValue))
                Hijri_Day.EditValue = FormatNumber(Hijri_Day.EditValue, null);

            // int_Nationality
            int_Nationality.SetupEditAttributes();
            int_Nationality.PlaceHolder = RemoveHtml(int_Nationality.Caption);
            if (!Empty(int_Nationality.EditValue) && IsNumeric(int_Nationality.EditValue))
                int_Nationality.EditValue = FormatNumber(int_Nationality.EditValue, null);

            // date_Created

            // date_Modified

            // int_Created_By

            // int_Modified_By

            // str_Emergency_Contact_Name
            str_Emergency_Contact_Name.SetupEditAttributes();
            if (!str_Emergency_Contact_Name.Raw)
                str_Emergency_Contact_Name.CurrentValue = HtmlDecode(str_Emergency_Contact_Name.CurrentValue);
            str_Emergency_Contact_Name.EditValue = HtmlEncode(str_Emergency_Contact_Name.CurrentValue);
            str_Emergency_Contact_Name.PlaceHolder = RemoveHtml(str_Emergency_Contact_Name.Caption);

            // str_Emergency_Contact_Phone
            str_Emergency_Contact_Phone.SetupEditAttributes();
            if (!str_Emergency_Contact_Phone.Raw)
                str_Emergency_Contact_Phone.CurrentValue = HtmlDecode(str_Emergency_Contact_Phone.CurrentValue);
            str_Emergency_Contact_Phone.EditValue = HtmlEncode(str_Emergency_Contact_Phone.CurrentValue);
            str_Emergency_Contact_Phone.PlaceHolder = RemoveHtml(str_Emergency_Contact_Phone.Caption);

            // str_Emergency_Contact_Relation
            str_Emergency_Contact_Relation.SetupEditAttributes();
            str_Emergency_Contact_Relation.EditValue = str_Emergency_Contact_Relation.Options(true);
            str_Emergency_Contact_Relation.PlaceHolder = RemoveHtml(str_Emergency_Contact_Relation.Caption);

            // ProfileField
            ProfileField.SetupEditAttributes();
            ProfileField.EditValue = ProfileField.CurrentValue; // DN
            ProfileField.PlaceHolder = RemoveHtml(ProfileField.Caption);

            // Absherphoto
            Absherphoto.SetupEditAttributes();
            if (!IsNull(Absherphoto.Upload.DbValue)) {
                Absherphoto.EditValue = Absherphoto.Upload.DbValue;
            } else {
                Absherphoto.EditValue = "";
            }
            if (!Empty(Absherphoto.CurrentValue))
                    Absherphoto.Upload.FileName = ConvertToString(Absherphoto.CurrentValue);

            // AbsherApptNbr
            AbsherApptNbr.SetupEditAttributes();

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
                        doc.ExportCaption(str_Full_Name);
                        doc.ExportCaption(str_NationalID_Iqama);
                        doc.ExportCaption(str_Address);
                        doc.ExportCaption(str_City);
                        doc.ExportCaption(int_State);
                        doc.ExportCaption(str_Zip);
                        doc.ExportCaption(str_Home_Phone);
                        doc.ExportCaption(str_Cell_Phone);
                        doc.ExportCaption(str_Email);
                        doc.ExportCaption(date_Birth);
                        doc.ExportCaption(date_Birth_Hijri);
                        doc.ExportCaption(User_Role);
                        doc.ExportCaption(UserlevelID);
                        doc.ExportCaption(Activated);
                        doc.ExportCaption(Supervisor_Username);
                        doc.ExportCaption(str_Staff_Username);
                        doc.ExportCaption(Hijri_Year);
                        doc.ExportCaption(Hijri_Month);
                        doc.ExportCaption(Hijri_Day);
                        doc.ExportCaption(int_Nationality);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(int_Created_By);
                        doc.ExportCaption(int_Modified_By);
                        doc.ExportCaption(str_Emergency_Contact_Name);
                        doc.ExportCaption(str_Emergency_Contact_Phone);
                        doc.ExportCaption(str_Emergency_Contact_Relation);
                        doc.ExportCaption(ProfileField);
                        doc.ExportCaption(Absherphoto);
                    } else {
                        doc.ExportCaption(int_Staff_Id);
                        doc.ExportCaption(str_Full_Name);
                        doc.ExportCaption(str_First_Name);
                        doc.ExportCaption(str_Middle_Name);
                        doc.ExportCaption(str_Last_Name);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(str_NationalID_Iqama);
                        doc.ExportCaption(str_Address);
                        doc.ExportCaption(str_City);
                        doc.ExportCaption(int_State);
                        doc.ExportCaption(str_Zip);
                        doc.ExportCaption(str_Home_Phone);
                        doc.ExportCaption(str_Cell_Phone);
                        doc.ExportCaption(str_Email);
                        doc.ExportCaption(date_Birth);
                        doc.ExportCaption(date_Birth_Hijri);
                        doc.ExportCaption(int_Location);
                        doc.ExportCaption(str_InstLicenceDate);
                        doc.ExportCaption(str_DLNum);
                        doc.ExportCaption(str_DLExp);
                        doc.ExportCaption(User_Role);
                        doc.ExportCaption(UserlevelID);
                        doc.ExportCaption(Activated);
                        doc.ExportCaption(Supervisor_Username);
                        doc.ExportCaption(str_Staff_Username);
                        doc.ExportCaption(Hijri_Year);
                        doc.ExportCaption(Hijri_Month);
                        doc.ExportCaption(Hijri_Day);
                        doc.ExportCaption(int_Nationality);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(int_Created_By);
                        doc.ExportCaption(int_Modified_By);
                        doc.ExportCaption(str_Emergency_Contact_Name);
                        doc.ExportCaption(str_Emergency_Contact_Phone);
                        doc.ExportCaption(str_Emergency_Contact_Relation);
                        doc.ExportCaption(Absherphoto);
                        doc.ExportCaption(AbsherApptNbr);
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
                            await doc.ExportField(str_Full_Name);
                            await doc.ExportField(str_NationalID_Iqama);
                            await doc.ExportField(str_Address);
                            await doc.ExportField(str_City);
                            await doc.ExportField(int_State);
                            await doc.ExportField(str_Zip);
                            await doc.ExportField(str_Home_Phone);
                            await doc.ExportField(str_Cell_Phone);
                            await doc.ExportField(str_Email);
                            await doc.ExportField(date_Birth);
                            await doc.ExportField(date_Birth_Hijri);
                            await doc.ExportField(User_Role);
                            await doc.ExportField(UserlevelID);
                            await doc.ExportField(Activated);
                            await doc.ExportField(Supervisor_Username);
                            await doc.ExportField(str_Staff_Username);
                            await doc.ExportField(Hijri_Year);
                            await doc.ExportField(Hijri_Month);
                            await doc.ExportField(Hijri_Day);
                            await doc.ExportField(int_Nationality);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(int_Created_By);
                            await doc.ExportField(int_Modified_By);
                            await doc.ExportField(str_Emergency_Contact_Name);
                            await doc.ExportField(str_Emergency_Contact_Phone);
                            await doc.ExportField(str_Emergency_Contact_Relation);
                            await doc.ExportField(ProfileField);
                            await doc.ExportField(Absherphoto);
                        } else {
                            await doc.ExportField(int_Staff_Id);
                            await doc.ExportField(str_Full_Name);
                            await doc.ExportField(str_First_Name);
                            await doc.ExportField(str_Middle_Name);
                            await doc.ExportField(str_Last_Name);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(NationalID);
                            await doc.ExportField(str_NationalID_Iqama);
                            await doc.ExportField(str_Address);
                            await doc.ExportField(str_City);
                            await doc.ExportField(int_State);
                            await doc.ExportField(str_Zip);
                            await doc.ExportField(str_Home_Phone);
                            await doc.ExportField(str_Cell_Phone);
                            await doc.ExportField(str_Email);
                            await doc.ExportField(date_Birth);
                            await doc.ExportField(date_Birth_Hijri);
                            await doc.ExportField(int_Location);
                            await doc.ExportField(str_InstLicenceDate);
                            await doc.ExportField(str_DLNum);
                            await doc.ExportField(str_DLExp);
                            await doc.ExportField(User_Role);
                            await doc.ExportField(UserlevelID);
                            await doc.ExportField(Activated);
                            await doc.ExportField(Supervisor_Username);
                            await doc.ExportField(str_Staff_Username);
                            await doc.ExportField(Hijri_Year);
                            await doc.ExportField(Hijri_Month);
                            await doc.ExportField(Hijri_Day);
                            await doc.ExportField(int_Nationality);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(int_Created_By);
                            await doc.ExportField(int_Modified_By);
                            await doc.ExportField(str_Emergency_Contact_Name);
                            await doc.ExportField(str_Emergency_Contact_Phone);
                            await doc.ExportField(str_Emergency_Contact_Relation);
                            await doc.ExportField(Absherphoto);
                            await doc.ExportField(AbsherApptNbr);
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
            string sql = "SELECT " + masterfld.Expression + " FROM dbo.tblStaff";
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
            if (SameText(fldparm, "Absherphoto")) {
                fldName = "Absherphoto";
                fileNameFld = "Absherphoto";
            } else {
                return JsonBoolResult.FalseResult; // Incorrect field
            }

            // Set up key values
            if (keys.Length == 1) {
                int_Staff_Id.CurrentValue = keys[0];
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
        public async Task WriteAuditTrailLog(string log) => await WriteAuditTrailAsync(CurrentUser(), log, "tblStaff");

        // Write audit trail (add page)
        public async Task WriteAuditTrailOnAdd(IDictionary<string, object> rs)
        {
            if (!AuditTrailOnAdd)
                return;
            string table = "tblStaff";

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
            string table = "tblStaff";

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
            string table = "tblStaff";

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
