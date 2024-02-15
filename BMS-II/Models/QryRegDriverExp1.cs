namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// qryRegDriverExp1
    /// </summary>
    [MaybeNull]
    public static QryRegDriverExp1 qryRegDriverExp1
    {
        get => HttpData.Resolve<QryRegDriverExp1>("qryRegDriverExp1");
        set => HttpData["qryRegDriverExp1"] = value;
    }

    /// <summary>
    /// Table class for qryRegDriverExp1
    /// </summary>
    public class QryRegDriverExp1 : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> int_Student_ID;

        public readonly DbField<SqlDbType> str_First_Name;

        public readonly DbField<SqlDbType> str_Middle_Name;

        public readonly DbField<SqlDbType> str_Last_Name;

        public readonly DbField<SqlDbType> str_Home_Phone;

        public readonly DbField<SqlDbType> str_Cell_Phone;

        public readonly DbField<SqlDbType> str_Other_Phone;

        public readonly DbField<SqlDbType> str_Email;

        public readonly DbField<SqlDbType> str_Username;

        public readonly DbField<SqlDbType> str_Password;

        public readonly DbField<SqlDbType> date_Birth;

        public readonly DbField<SqlDbType> date_Birth_Hijri;

        public readonly DbField<SqlDbType> str_Emergency_Contact_Name;

        public readonly DbField<SqlDbType> str_Emergency_Contact_Phone;

        public readonly DbField<SqlDbType> str_Emergency_Contact_Relation;

        public readonly DbField<SqlDbType> int_Type;

        public readonly DbField<SqlDbType> int_Location;

        public readonly DbField<SqlDbType> date_Created;

        public readonly DbField<SqlDbType> date_Modified;

        public readonly DbField<SqlDbType> str_DLNum;

        public readonly DbField<SqlDbType> str_DLExp;

        public readonly DbField<SqlDbType> int_Nationality;

        public readonly DbField<SqlDbType> str_NationalID_Iqama;

        public readonly DbField<SqlDbType> NationalID;

        public readonly DbField<SqlDbType> UserlevelID;

        public readonly DbField<SqlDbType> Activated;

        public readonly DbField<SqlDbType> IsDrivingexperience;

        public readonly DbField<SqlDbType> intDrivinglicenseType;

        public readonly DbField<SqlDbType> Absherphoto;

        public readonly DbField<SqlDbType> AbsherApptNbr;

        public readonly DbField<SqlDbType> Fingerprint;

        // Constructor
        public QryRegDriverExp1()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "qryRegDriverExp1";
            Name = "qryRegDriverExp1";
            Type = "VIEW";
            UpdateTable = "dbo.qryRegDriverExp1"; // Update Table
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
                HtmlTag = "NO",
                InputTextType = "text",
                IsAutoIncrement = true, // Autoincrement field
                IsPrimaryKey = true, // Primary key field
                Nullable = false, // NOT NULL field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "int_Student_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Student_ID", int_Student_ID);

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
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "str_First_Name", "CustomMsg"),
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "str_Middle_Name", "CustomMsg"),
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "str_Last_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Last_Name", str_Last_Name);

            // str_Home_Phone
            str_Home_Phone = new (this, "x_str_Home_Phone", 200, SqlDbType.VarChar) {
                Name = "str_Home_Phone",
                Expression = "[str_Home_Phone]",
                UseBasicSearch = true,
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
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "str_Home_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Home_Phone", str_Home_Phone);

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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "str_Cell_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Cell_Phone", str_Cell_Phone);

            // str_Other_Phone
            str_Other_Phone = new (this, "x_str_Other_Phone", 200, SqlDbType.VarChar) {
                Name = "str_Other_Phone",
                Expression = "[str_Other_Phone]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Other_Phone]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Other_Phone]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "str_Other_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Other_Phone", str_Other_Phone);

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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "str_Email", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Email", str_Email);

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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "str_Username", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Username", str_Username);

            // str_Password
            str_Password = new (this, "x_str_Password", 202, SqlDbType.NVarChar) {
                Name = "str_Password",
                Expression = "[str_Password]",
                UseBasicSearch = true,
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "str_Password", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Password", str_Password);

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
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "date_Birth", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Birth", date_Birth);

            // date_Birth_Hijri
            date_Birth_Hijri = new (this, "x_date_Birth_Hijri", 202, SqlDbType.NVarChar) {
                Name = "date_Birth_Hijri",
                Expression = "[date_Birth_Hijri]",
                UseBasicSearch = true,
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
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "date_Birth_Hijri", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Birth_Hijri", date_Birth_Hijri);

            // str_Emergency_Contact_Name
            str_Emergency_Contact_Name = new (this, "x_str_Emergency_Contact_Name", 202, SqlDbType.NVarChar) {
                Name = "str_Emergency_Contact_Name",
                Expression = "[str_Emergency_Contact_Name]",
                UseBasicSearch = true,
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
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "str_Emergency_Contact_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Emergency_Contact_Name", str_Emergency_Contact_Name);

            // str_Emergency_Contact_Phone
            str_Emergency_Contact_Phone = new (this, "x_str_Emergency_Contact_Phone", 200, SqlDbType.VarChar) {
                Name = "str_Emergency_Contact_Phone",
                Expression = "[str_Emergency_Contact_Phone]",
                UseBasicSearch = true,
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
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "str_Emergency_Contact_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Emergency_Contact_Phone", str_Emergency_Contact_Phone);

            // str_Emergency_Contact_Relation
            str_Emergency_Contact_Relation = new (this, "x_str_Emergency_Contact_Relation", 202, SqlDbType.NVarChar) {
                Name = "str_Emergency_Contact_Relation",
                Expression = "[str_Emergency_Contact_Relation]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Emergency_Contact_Relation]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Emergency_Contact_Relation]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "str_Emergency_Contact_Relation", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Emergency_Contact_Relation", str_Emergency_Contact_Relation);

            // int_Type
            int_Type = new (this, "x_int_Type", 3, SqlDbType.Int) {
                Name = "int_Type",
                Expression = "[int_Type]",
                BasicSearchExpression = "CAST([int_Type] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Type]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "int_Type", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Type", int_Type);

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
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "int_Location", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Location", int_Location);

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
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "date_Created", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "date_Modified", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Modified", date_Modified);

            // str_DLNum
            str_DLNum = new (this, "x_str_DLNum", 200, SqlDbType.VarChar) {
                Name = "str_DLNum",
                Expression = "[str_DLNum]",
                UseBasicSearch = true,
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
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "str_DLNum", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_DLNum", str_DLNum);

            // str_DLExp
            str_DLExp = new (this, "x_str_DLExp", 200, SqlDbType.VarChar) {
                Name = "str_DLExp",
                Expression = "[str_DLExp]",
                UseBasicSearch = true,
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
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "str_DLExp", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_DLExp", str_DLExp);

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
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "int_Nationality", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Nationality", int_Nationality);

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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "str_NationalID_Iqama", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_NationalID_Iqama", str_NationalID_Iqama);

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
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "NationalID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("NationalID", NationalID);

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
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "UserlevelID", "CustomMsg"),
                IsUpload = false
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
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "Activated", "CustomMsg"),
                IsUpload = false
            };
            Activated.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Activated, "qryRegDriverExp1", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Activated, "qryRegDriverExp1", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Activated, "qryRegDriverExp1", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Activated", Activated);

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
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "IsDrivingexperience", "CustomMsg"),
                IsUpload = false
            };
            IsDrivingexperience.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(IsDrivingexperience, "qryRegDriverExp1", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(IsDrivingexperience, "qryRegDriverExp1", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(IsDrivingexperience, "qryRegDriverExp1", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
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
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "intDrivinglicenseType", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("intDrivinglicenseType", intDrivinglicenseType);

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
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "Absherphoto", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Absherphoto", Absherphoto);

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
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "AbsherApptNbr", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("AbsherApptNbr", AbsherApptNbr);

            // Fingerprint
            Fingerprint = new (this, "x_Fingerprint", 202, SqlDbType.NVarChar) {
                Name = "Fingerprint",
                Expression = "[Fingerprint]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Fingerprint]",
                DateTimeFormat = -1,
                VirtualExpression = "[Fingerprint]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryRegDriverExp1", "Fingerprint", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Fingerprint", Fingerprint);

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
            get => _sqlFrom ?? "dbo.qryRegDriverExp1";
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
                var lastInsertedId = await queryBuilder.InsertGetIdAsync<int>(row);
                int_Student_ID.SetDbValue(lastInsertedId);
                result = 1;
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
                int_Student_ID.DbValue = row["int_Student_ID"]; // Set DB value only
                str_First_Name.DbValue = row["str_First_Name"]; // Set DB value only
                str_Middle_Name.DbValue = row["str_Middle_Name"]; // Set DB value only
                str_Last_Name.DbValue = row["str_Last_Name"]; // Set DB value only
                str_Home_Phone.DbValue = row["str_Home_Phone"]; // Set DB value only
                str_Cell_Phone.DbValue = row["str_Cell_Phone"]; // Set DB value only
                str_Other_Phone.DbValue = row["str_Other_Phone"]; // Set DB value only
                str_Email.DbValue = row["str_Email"]; // Set DB value only
                str_Username.DbValue = row["str_Username"]; // Set DB value only
                str_Password.DbValue = row["str_Password"]; // Set DB value only
                date_Birth.DbValue = row["date_Birth"]; // Set DB value only
                date_Birth_Hijri.DbValue = row["date_Birth_Hijri"]; // Set DB value only
                str_Emergency_Contact_Name.DbValue = row["str_Emergency_Contact_Name"]; // Set DB value only
                str_Emergency_Contact_Phone.DbValue = row["str_Emergency_Contact_Phone"]; // Set DB value only
                str_Emergency_Contact_Relation.DbValue = row["str_Emergency_Contact_Relation"]; // Set DB value only
                int_Type.DbValue = row["int_Type"]; // Set DB value only
                int_Location.DbValue = row["int_Location"]; // Set DB value only
                date_Created.DbValue = row["date_Created"]; // Set DB value only
                date_Modified.DbValue = row["date_Modified"]; // Set DB value only
                str_DLNum.DbValue = row["str_DLNum"]; // Set DB value only
                str_DLExp.DbValue = row["str_DLExp"]; // Set DB value only
                int_Nationality.DbValue = row["int_Nationality"]; // Set DB value only
                str_NationalID_Iqama.DbValue = row["str_NationalID_Iqama"]; // Set DB value only
                NationalID.DbValue = row["NationalID"]; // Set DB value only
                UserlevelID.DbValue = row["UserlevelID"]; // Set DB value only
                Activated.DbValue = (ConvertToBool(row["Activated"]) ? "1" : "0"); // Set DB value only
                IsDrivingexperience.DbValue = (ConvertToBool(row["IsDrivingexperience"]) ? "1" : "0"); // Set DB value only
                intDrivinglicenseType.DbValue = row["intDrivinglicenseType"]; // Set DB value only
                Absherphoto.DbValue = row["Absherphoto"]; // Set DB value only
                AbsherApptNbr.DbValue = row["AbsherApptNbr"]; // Set DB value only
                Fingerprint.DbValue = row["Fingerprint"]; // Set DB value only
            } catch {}
        }

        public void DeleteUploadedFiles(Dictionary<string, object> row)
        {
            LoadDbValues(row);
        }

        // Record filter WHERE clause
        private string _sqlKeyFilter => "[int_Student_ID] = @int_Student_ID@";

        #pragma warning disable 168, 219
        // Get record filter as string
        public string GetRecordFilter(Dictionary<string, object>? row = null, bool current = false)
        {
            string keyFilter = _sqlKeyFilter;
            object? val = null, result = "";
            val = row?.TryGetValue("int_Student_ID", out result) ?? false
                ? result
                : !Empty(int_Student_ID.OldValue) && !current ? int_Student_ID.OldValue : int_Student_ID.CurrentValue;
            if (!IsNumeric(val))
                return "0=1"; // Invalid key
            if (val == null)
                return "0=1"; // Invalid key
            keyFilter = keyFilter.Replace("@int_Student_ID@", AdjustSql(val, DbId)); // Replace key value
            return keyFilter;
        }

        // Get record filter as Dictionary // DN
        public Dictionary<string, object>? GetRowFilterAsDictionary(IDictionary<string, object>? row = null)
        {
            Dictionary<string, object>? keyFilter = new ();
            object? val = null, result;
            val = row?.TryGetValue("int_Student_ID", out result) ?? false
                ? result
                : !Empty(int_Student_ID.OldValue) ? int_Student_ID.OldValue : int_Student_ID.CurrentValue;
            if (!IsNumeric(val))
                return null; // Invalid key
            if (Empty(val))
                return null; // Invalid key
            keyFilter.Add("int_Student_ID", val); // Add key value
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
                    return "QryRegDriverExp1List";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "QryRegDriverExp1View"))
                return Language.Phrase("View");
            else if (SameString(pageName, "QryRegDriverExp1Edit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "QryRegDriverExp1Add"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "QryRegDriverExp1List";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "QryRegDriverExp1View",
                Config.ApiAddAction => "QryRegDriverExp1Add",
                Config.ApiEditAction => "QryRegDriverExp1Edit",
                Config.ApiDeleteAction => "QryRegDriverExp1Delete",
                Config.ApiListAction => "QryRegDriverExp1List",
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
        public string ListUrl => "QryRegDriverExp1List";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("QryRegDriverExp1View", parm);
            else
                url = KeyUrl("QryRegDriverExp1View", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "QryRegDriverExp1Add";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "QryRegDriverExp1Add?" + parm;
            else
                url = "QryRegDriverExp1Add";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("QryRegDriverExp1Edit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("QryRegDriverExp1List", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("QryRegDriverExp1Add", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("QryRegDriverExp1List", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("QryRegDriverExp1Delete")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
            return url;
        }

        // Get primary key as JSON
        public string KeyToJson(bool htmlEncode = false)
        {
            string json = "";
            json += "\"int_Student_ID\":" + ConvertToJson(int_Student_ID.CurrentValue, "number", true);
            json = "{" + json + "}";
            if (htmlEncode)
                json = HtmlEncode(json);
            return json;
        }

        // Add key value to URL
        public string KeyUrl(string url, string parm = "") { // DN
            if (!IsNull(int_Student_ID.CurrentValue)) {
                url += "/" + int_Student_ID.CurrentValue;
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
            val = current ? ConvertToString(int_Student_ID.CurrentValue) ?? "" : ConvertToString(int_Student_ID.OldValue) ?? "";
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
            val = row?.TryGetValue("int_Student_ID", out result) ?? false ? ConvertToString(result) : null;
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
                    int_Student_ID.CurrentValue = keys[0];
                } else {
                    int_Student_ID.OldValue = keys[0];
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
                if (RouteValues.TryGetValue("int_Student_ID", out object? v0)) { // int_Student_ID // DN
                    key = UrlDecode(v0); // DN
                } else if (IsApi() && !Empty(keyValues)) {
                    key = keyValues[0];
                } else {
                    key = Param("int_Student_ID");
                }
                keysList.Add(key);
            }
            // Check keys
            foreach (var keys in keysList) {
                if (!IsNumeric(keys)) // int_Student_ID
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
                    int_Student_ID.CurrentValue = keys;
                else
                    int_Student_ID.OldValue = keys;
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
            int_Student_ID.SetDbValue(dr["int_Student_ID"]);
            str_First_Name.SetDbValue(dr["str_First_Name"]);
            str_Middle_Name.SetDbValue(dr["str_Middle_Name"]);
            str_Last_Name.SetDbValue(dr["str_Last_Name"]);
            str_Home_Phone.SetDbValue(dr["str_Home_Phone"]);
            str_Cell_Phone.SetDbValue(dr["str_Cell_Phone"]);
            str_Other_Phone.SetDbValue(dr["str_Other_Phone"]);
            str_Email.SetDbValue(dr["str_Email"]);
            str_Username.SetDbValue(dr["str_Username"]);
            str_Password.SetDbValue(dr["str_Password"]);
            date_Birth.SetDbValue(dr["date_Birth"]);
            date_Birth_Hijri.SetDbValue(dr["date_Birth_Hijri"]);
            str_Emergency_Contact_Name.SetDbValue(dr["str_Emergency_Contact_Name"]);
            str_Emergency_Contact_Phone.SetDbValue(dr["str_Emergency_Contact_Phone"]);
            str_Emergency_Contact_Relation.SetDbValue(dr["str_Emergency_Contact_Relation"]);
            int_Type.SetDbValue(dr["int_Type"]);
            int_Location.SetDbValue(dr["int_Location"]);
            date_Created.SetDbValue(dr["date_Created"]);
            date_Modified.SetDbValue(dr["date_Modified"]);
            str_DLNum.SetDbValue(dr["str_DLNum"]);
            str_DLExp.SetDbValue(dr["str_DLExp"]);
            int_Nationality.SetDbValue(dr["int_Nationality"]);
            str_NationalID_Iqama.SetDbValue(dr["str_NationalID_Iqama"]);
            NationalID.SetDbValue(dr["NationalID"]);
            UserlevelID.SetDbValue(dr["UserlevelID"]);
            Activated.SetDbValue(ConvertToBool(dr["Activated"]) ? "1" : "0");
            IsDrivingexperience.SetDbValue(ConvertToBool(dr["IsDrivingexperience"]) ? "1" : "0");
            intDrivinglicenseType.SetDbValue(dr["intDrivinglicenseType"]);
            Absherphoto.SetDbValue(dr["Absherphoto"]);
            AbsherApptNbr.SetDbValue(dr["AbsherApptNbr"]);
            Fingerprint.SetDbValue(dr["Fingerprint"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "QryRegDriverExp1List";
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

            // int_Student_ID

            // str_First_Name

            // str_Middle_Name

            // str_Last_Name

            // str_Home_Phone

            // str_Cell_Phone

            // str_Other_Phone

            // str_Email

            // str_Username

            // str_Password

            // date_Birth

            // date_Birth_Hijri

            // str_Emergency_Contact_Name

            // str_Emergency_Contact_Phone

            // str_Emergency_Contact_Relation

            // int_Type

            // int_Location

            // date_Created

            // date_Modified

            // str_DLNum

            // str_DLExp

            // int_Nationality

            // str_NationalID_Iqama

            // NationalID

            // UserlevelID

            // Activated

            // IsDrivingexperience

            // intDrivinglicenseType

            // Absherphoto

            // AbsherApptNbr

            // Fingerprint

            // int_Student_ID
            int_Student_ID.ViewValue = int_Student_ID.CurrentValue;
            int_Student_ID.ViewCustomAttributes = "";

            // str_First_Name
            str_First_Name.ViewValue = ConvertToString(str_First_Name.CurrentValue); // DN
            str_First_Name.ViewCustomAttributes = "";

            // str_Middle_Name
            str_Middle_Name.ViewValue = ConvertToString(str_Middle_Name.CurrentValue); // DN
            str_Middle_Name.ViewCustomAttributes = "";

            // str_Last_Name
            str_Last_Name.ViewValue = ConvertToString(str_Last_Name.CurrentValue); // DN
            str_Last_Name.ViewCustomAttributes = "";

            // str_Home_Phone
            str_Home_Phone.ViewValue = ConvertToString(str_Home_Phone.CurrentValue); // DN
            str_Home_Phone.ViewCustomAttributes = "";

            // str_Cell_Phone
            str_Cell_Phone.ViewValue = ConvertToString(str_Cell_Phone.CurrentValue); // DN
            str_Cell_Phone.ViewCustomAttributes = "";

            // str_Other_Phone
            str_Other_Phone.ViewValue = ConvertToString(str_Other_Phone.CurrentValue); // DN
            str_Other_Phone.ViewCustomAttributes = "";

            // str_Email
            str_Email.ViewValue = ConvertToString(str_Email.CurrentValue); // DN
            str_Email.ViewCustomAttributes = "";

            // str_Username
            str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
            str_Username.ViewCustomAttributes = "";

            // str_Password
            str_Password.ViewValue = ConvertToString(str_Password.CurrentValue); // DN
            str_Password.ViewCustomAttributes = "";

            // date_Birth
            date_Birth.ViewValue = date_Birth.CurrentValue;
            date_Birth.ViewValue = FormatDateTime(date_Birth.ViewValue, date_Birth.FormatPattern);
            date_Birth.ViewCustomAttributes = "";

            // date_Birth_Hijri
            date_Birth_Hijri.ViewValue = ConvertToString(date_Birth_Hijri.CurrentValue); // DN
            date_Birth_Hijri.ViewCustomAttributes = "";

            // str_Emergency_Contact_Name
            str_Emergency_Contact_Name.ViewValue = ConvertToString(str_Emergency_Contact_Name.CurrentValue); // DN
            str_Emergency_Contact_Name.ViewCustomAttributes = "";

            // str_Emergency_Contact_Phone
            str_Emergency_Contact_Phone.ViewValue = ConvertToString(str_Emergency_Contact_Phone.CurrentValue); // DN
            str_Emergency_Contact_Phone.ViewCustomAttributes = "";

            // str_Emergency_Contact_Relation
            str_Emergency_Contact_Relation.ViewValue = ConvertToString(str_Emergency_Contact_Relation.CurrentValue); // DN
            str_Emergency_Contact_Relation.ViewCustomAttributes = "";

            // int_Type
            int_Type.ViewValue = int_Type.CurrentValue;
            int_Type.ViewValue = FormatNumber(int_Type.ViewValue, int_Type.FormatPattern);
            int_Type.ViewCustomAttributes = "";

            // int_Location
            int_Location.ViewValue = int_Location.CurrentValue;
            int_Location.ViewValue = FormatNumber(int_Location.ViewValue, int_Location.FormatPattern);
            int_Location.ViewCustomAttributes = "";

            // date_Created
            date_Created.ViewValue = date_Created.CurrentValue;
            date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
            date_Created.ViewCustomAttributes = "";

            // date_Modified
            date_Modified.ViewValue = date_Modified.CurrentValue;
            date_Modified.ViewValue = FormatDateTime(date_Modified.ViewValue, date_Modified.FormatPattern);
            date_Modified.ViewCustomAttributes = "";

            // str_DLNum
            str_DLNum.ViewValue = ConvertToString(str_DLNum.CurrentValue); // DN
            str_DLNum.ViewCustomAttributes = "";

            // str_DLExp
            str_DLExp.ViewValue = ConvertToString(str_DLExp.CurrentValue); // DN
            str_DLExp.ViewCustomAttributes = "";

            // int_Nationality
            int_Nationality.ViewValue = int_Nationality.CurrentValue;
            int_Nationality.ViewValue = FormatNumber(int_Nationality.ViewValue, int_Nationality.FormatPattern);
            int_Nationality.ViewCustomAttributes = "";

            // str_NationalID_Iqama
            str_NationalID_Iqama.ViewValue = ConvertToString(str_NationalID_Iqama.CurrentValue); // DN
            str_NationalID_Iqama.ViewCustomAttributes = "";

            // NationalID
            NationalID.ViewValue = NationalID.CurrentValue;
            NationalID.ViewValue = FormatNumber(NationalID.ViewValue, NationalID.FormatPattern);
            NationalID.ViewCustomAttributes = "";

            // UserlevelID
            UserlevelID.ViewValue = UserlevelID.CurrentValue;
            UserlevelID.ViewValue = FormatNumber(UserlevelID.ViewValue, UserlevelID.FormatPattern);
            UserlevelID.ViewCustomAttributes = "";

            // Activated
            if (ConvertToBool(Activated.CurrentValue)) {
                Activated.ViewValue = Activated.TagCaption(1) != "" ? Activated.TagCaption(1) : "Yes";
            } else {
                Activated.ViewValue = Activated.TagCaption(2) != "" ? Activated.TagCaption(2) : "No";
            }
            Activated.ViewCustomAttributes = "";

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

            // Absherphoto
            Absherphoto.ViewValue = ConvertToString(Absherphoto.CurrentValue); // DN
            Absherphoto.ViewCustomAttributes = "";

            // AbsherApptNbr
            AbsherApptNbr.ViewValue = ConvertToString(AbsherApptNbr.CurrentValue); // DN
            AbsherApptNbr.ViewCustomAttributes = "";

            // Fingerprint
            Fingerprint.ViewValue = ConvertToString(Fingerprint.CurrentValue); // DN
            Fingerprint.ViewCustomAttributes = "";

            // int_Student_ID
            int_Student_ID.HrefValue = "";
            int_Student_ID.TooltipValue = "";

            // str_First_Name
            str_First_Name.HrefValue = "";
            str_First_Name.TooltipValue = "";

            // str_Middle_Name
            str_Middle_Name.HrefValue = "";
            str_Middle_Name.TooltipValue = "";

            // str_Last_Name
            str_Last_Name.HrefValue = "";
            str_Last_Name.TooltipValue = "";

            // str_Home_Phone
            str_Home_Phone.HrefValue = "";
            str_Home_Phone.TooltipValue = "";

            // str_Cell_Phone
            str_Cell_Phone.HrefValue = "";
            str_Cell_Phone.TooltipValue = "";

            // str_Other_Phone
            str_Other_Phone.HrefValue = "";
            str_Other_Phone.TooltipValue = "";

            // str_Email
            str_Email.HrefValue = "";
            str_Email.TooltipValue = "";

            // str_Username
            str_Username.HrefValue = "";
            str_Username.TooltipValue = "";

            // str_Password
            str_Password.HrefValue = "";
            str_Password.TooltipValue = "";

            // date_Birth
            date_Birth.HrefValue = "";
            date_Birth.TooltipValue = "";

            // date_Birth_Hijri
            date_Birth_Hijri.HrefValue = "";
            date_Birth_Hijri.TooltipValue = "";

            // str_Emergency_Contact_Name
            str_Emergency_Contact_Name.HrefValue = "";
            str_Emergency_Contact_Name.TooltipValue = "";

            // str_Emergency_Contact_Phone
            str_Emergency_Contact_Phone.HrefValue = "";
            str_Emergency_Contact_Phone.TooltipValue = "";

            // str_Emergency_Contact_Relation
            str_Emergency_Contact_Relation.HrefValue = "";
            str_Emergency_Contact_Relation.TooltipValue = "";

            // int_Type
            int_Type.HrefValue = "";
            int_Type.TooltipValue = "";

            // int_Location
            int_Location.HrefValue = "";
            int_Location.TooltipValue = "";

            // date_Created
            date_Created.HrefValue = "";
            date_Created.TooltipValue = "";

            // date_Modified
            date_Modified.HrefValue = "";
            date_Modified.TooltipValue = "";

            // str_DLNum
            str_DLNum.HrefValue = "";
            str_DLNum.TooltipValue = "";

            // str_DLExp
            str_DLExp.HrefValue = "";
            str_DLExp.TooltipValue = "";

            // int_Nationality
            int_Nationality.HrefValue = "";
            int_Nationality.TooltipValue = "";

            // str_NationalID_Iqama
            str_NationalID_Iqama.HrefValue = "";
            str_NationalID_Iqama.TooltipValue = "";

            // NationalID
            NationalID.HrefValue = "";
            NationalID.TooltipValue = "";

            // UserlevelID
            UserlevelID.HrefValue = "";
            UserlevelID.TooltipValue = "";

            // Activated
            Activated.HrefValue = "";
            Activated.TooltipValue = "";

            // IsDrivingexperience
            IsDrivingexperience.HrefValue = "";
            IsDrivingexperience.TooltipValue = "";

            // intDrivinglicenseType
            intDrivinglicenseType.HrefValue = "";
            intDrivinglicenseType.TooltipValue = "";

            // Absherphoto
            Absherphoto.HrefValue = "";
            Absherphoto.TooltipValue = "";

            // AbsherApptNbr
            AbsherApptNbr.HrefValue = "";
            AbsherApptNbr.TooltipValue = "";

            // Fingerprint
            Fingerprint.HrefValue = "";
            Fingerprint.TooltipValue = "";

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

            // int_Student_ID
            int_Student_ID.SetupEditAttributes();
            int_Student_ID.EditValue = int_Student_ID.CurrentValue;
            int_Student_ID.ViewCustomAttributes = "";

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

            // str_Other_Phone
            str_Other_Phone.SetupEditAttributes();
            if (!str_Other_Phone.Raw)
                str_Other_Phone.CurrentValue = HtmlDecode(str_Other_Phone.CurrentValue);
            str_Other_Phone.EditValue = HtmlEncode(str_Other_Phone.CurrentValue);
            str_Other_Phone.PlaceHolder = RemoveHtml(str_Other_Phone.Caption);

            // str_Email
            str_Email.SetupEditAttributes();
            if (!str_Email.Raw)
                str_Email.CurrentValue = HtmlDecode(str_Email.CurrentValue);
            str_Email.EditValue = HtmlEncode(str_Email.CurrentValue);
            str_Email.PlaceHolder = RemoveHtml(str_Email.Caption);

            // str_Username
            str_Username.SetupEditAttributes();
            if (!str_Username.Raw)
                str_Username.CurrentValue = HtmlDecode(str_Username.CurrentValue);
            str_Username.EditValue = HtmlEncode(str_Username.CurrentValue);
            str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);

            // str_Password
            str_Password.SetupEditAttributes();
            if (!str_Password.Raw)
                str_Password.CurrentValue = HtmlDecode(str_Password.CurrentValue);
            str_Password.EditValue = HtmlEncode(str_Password.CurrentValue);
            str_Password.PlaceHolder = RemoveHtml(str_Password.Caption);

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
            if (!str_Emergency_Contact_Relation.Raw)
                str_Emergency_Contact_Relation.CurrentValue = HtmlDecode(str_Emergency_Contact_Relation.CurrentValue);
            str_Emergency_Contact_Relation.EditValue = HtmlEncode(str_Emergency_Contact_Relation.CurrentValue);
            str_Emergency_Contact_Relation.PlaceHolder = RemoveHtml(str_Emergency_Contact_Relation.Caption);

            // int_Type
            int_Type.SetupEditAttributes();
            int_Type.EditValue = int_Type.CurrentValue; // DN
            int_Type.PlaceHolder = RemoveHtml(int_Type.Caption);
            if (!Empty(int_Type.EditValue) && IsNumeric(int_Type.EditValue))
                int_Type.EditValue = FormatNumber(int_Type.EditValue, null);

            // int_Location
            int_Location.SetupEditAttributes();
            int_Location.EditValue = int_Location.CurrentValue; // DN
            int_Location.PlaceHolder = RemoveHtml(int_Location.Caption);
            if (!Empty(int_Location.EditValue) && IsNumeric(int_Location.EditValue))
                int_Location.EditValue = FormatNumber(int_Location.EditValue, null);

            // date_Created
            date_Created.SetupEditAttributes();
            date_Created.EditValue = FormatDateTime(date_Created.CurrentValue, date_Created.FormatPattern); // DN
            date_Created.PlaceHolder = RemoveHtml(date_Created.Caption);

            // date_Modified
            date_Modified.SetupEditAttributes();
            date_Modified.EditValue = FormatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern); // DN
            date_Modified.PlaceHolder = RemoveHtml(date_Modified.Caption);

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

            // int_Nationality
            int_Nationality.SetupEditAttributes();
            int_Nationality.EditValue = int_Nationality.CurrentValue; // DN
            int_Nationality.PlaceHolder = RemoveHtml(int_Nationality.Caption);
            if (!Empty(int_Nationality.EditValue) && IsNumeric(int_Nationality.EditValue))
                int_Nationality.EditValue = FormatNumber(int_Nationality.EditValue, null);

            // str_NationalID_Iqama
            str_NationalID_Iqama.SetupEditAttributes();
            if (!str_NationalID_Iqama.Raw)
                str_NationalID_Iqama.CurrentValue = HtmlDecode(str_NationalID_Iqama.CurrentValue);
            str_NationalID_Iqama.EditValue = HtmlEncode(str_NationalID_Iqama.CurrentValue);
            str_NationalID_Iqama.PlaceHolder = RemoveHtml(str_NationalID_Iqama.Caption);

            // NationalID
            NationalID.SetupEditAttributes();
            NationalID.EditValue = NationalID.CurrentValue; // DN
            NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);
            if (!Empty(NationalID.EditValue) && IsNumeric(NationalID.EditValue))
                NationalID.EditValue = FormatNumber(NationalID.EditValue, null);

            // UserlevelID
            UserlevelID.SetupEditAttributes();
            UserlevelID.EditValue = UserlevelID.CurrentValue; // DN
            UserlevelID.PlaceHolder = RemoveHtml(UserlevelID.Caption);
            if (!Empty(UserlevelID.EditValue) && IsNumeric(UserlevelID.EditValue))
                UserlevelID.EditValue = FormatNumber(UserlevelID.EditValue, null);

            // Activated
            Activated.EditValue = Activated.Options(false);
            Activated.PlaceHolder = RemoveHtml(Activated.Caption);

            // IsDrivingexperience
            IsDrivingexperience.EditValue = IsDrivingexperience.Options(false);
            IsDrivingexperience.PlaceHolder = RemoveHtml(IsDrivingexperience.Caption);

            // intDrivinglicenseType
            intDrivinglicenseType.SetupEditAttributes();
            intDrivinglicenseType.EditValue = intDrivinglicenseType.CurrentValue; // DN
            intDrivinglicenseType.PlaceHolder = RemoveHtml(intDrivinglicenseType.Caption);
            if (!Empty(intDrivinglicenseType.EditValue) && IsNumeric(intDrivinglicenseType.EditValue))
                intDrivinglicenseType.EditValue = FormatNumber(intDrivinglicenseType.EditValue, null);

            // Absherphoto
            Absherphoto.SetupEditAttributes();
            if (!Absherphoto.Raw)
                Absherphoto.CurrentValue = HtmlDecode(Absherphoto.CurrentValue);
            Absherphoto.EditValue = HtmlEncode(Absherphoto.CurrentValue);
            Absherphoto.PlaceHolder = RemoveHtml(Absherphoto.Caption);

            // AbsherApptNbr
            AbsherApptNbr.SetupEditAttributes();
            if (!AbsherApptNbr.Raw)
                AbsherApptNbr.CurrentValue = HtmlDecode(AbsherApptNbr.CurrentValue);
            AbsherApptNbr.EditValue = HtmlEncode(AbsherApptNbr.CurrentValue);
            AbsherApptNbr.PlaceHolder = RemoveHtml(AbsherApptNbr.Caption);

            // Fingerprint
            Fingerprint.SetupEditAttributes();
            if (!Fingerprint.Raw)
                Fingerprint.CurrentValue = HtmlDecode(Fingerprint.CurrentValue);
            Fingerprint.EditValue = HtmlEncode(Fingerprint.CurrentValue);
            Fingerprint.PlaceHolder = RemoveHtml(Fingerprint.Caption);

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
                        doc.ExportCaption(int_Student_ID);
                        doc.ExportCaption(str_First_Name);
                        doc.ExportCaption(str_Middle_Name);
                        doc.ExportCaption(str_Last_Name);
                        doc.ExportCaption(str_Home_Phone);
                        doc.ExportCaption(str_Cell_Phone);
                        doc.ExportCaption(str_Other_Phone);
                        doc.ExportCaption(str_Email);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(str_Password);
                        doc.ExportCaption(date_Birth);
                        doc.ExportCaption(date_Birth_Hijri);
                        doc.ExportCaption(str_Emergency_Contact_Name);
                        doc.ExportCaption(str_Emergency_Contact_Phone);
                        doc.ExportCaption(str_Emergency_Contact_Relation);
                        doc.ExportCaption(int_Type);
                        doc.ExportCaption(int_Location);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(str_DLNum);
                        doc.ExportCaption(str_DLExp);
                        doc.ExportCaption(int_Nationality);
                        doc.ExportCaption(str_NationalID_Iqama);
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(UserlevelID);
                        doc.ExportCaption(Activated);
                        doc.ExportCaption(IsDrivingexperience);
                        doc.ExportCaption(intDrivinglicenseType);
                        doc.ExportCaption(Absherphoto);
                        doc.ExportCaption(AbsherApptNbr);
                        doc.ExportCaption(Fingerprint);
                    } else {
                        doc.ExportCaption(int_Student_ID);
                        doc.ExportCaption(str_First_Name);
                        doc.ExportCaption(str_Middle_Name);
                        doc.ExportCaption(str_Last_Name);
                        doc.ExportCaption(str_Home_Phone);
                        doc.ExportCaption(str_Cell_Phone);
                        doc.ExportCaption(str_Other_Phone);
                        doc.ExportCaption(str_Email);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(str_Password);
                        doc.ExportCaption(date_Birth);
                        doc.ExportCaption(date_Birth_Hijri);
                        doc.ExportCaption(str_Emergency_Contact_Name);
                        doc.ExportCaption(str_Emergency_Contact_Phone);
                        doc.ExportCaption(str_Emergency_Contact_Relation);
                        doc.ExportCaption(int_Type);
                        doc.ExportCaption(int_Location);
                        doc.ExportCaption(date_Created);
                        doc.ExportCaption(date_Modified);
                        doc.ExportCaption(str_DLNum);
                        doc.ExportCaption(str_DLExp);
                        doc.ExportCaption(int_Nationality);
                        doc.ExportCaption(str_NationalID_Iqama);
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(UserlevelID);
                        doc.ExportCaption(Activated);
                        doc.ExportCaption(IsDrivingexperience);
                        doc.ExportCaption(intDrivinglicenseType);
                        doc.ExportCaption(Absherphoto);
                        doc.ExportCaption(AbsherApptNbr);
                        doc.ExportCaption(Fingerprint);
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
                            await doc.ExportField(int_Student_ID);
                            await doc.ExportField(str_First_Name);
                            await doc.ExportField(str_Middle_Name);
                            await doc.ExportField(str_Last_Name);
                            await doc.ExportField(str_Home_Phone);
                            await doc.ExportField(str_Cell_Phone);
                            await doc.ExportField(str_Other_Phone);
                            await doc.ExportField(str_Email);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(str_Password);
                            await doc.ExportField(date_Birth);
                            await doc.ExportField(date_Birth_Hijri);
                            await doc.ExportField(str_Emergency_Contact_Name);
                            await doc.ExportField(str_Emergency_Contact_Phone);
                            await doc.ExportField(str_Emergency_Contact_Relation);
                            await doc.ExportField(int_Type);
                            await doc.ExportField(int_Location);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(str_DLNum);
                            await doc.ExportField(str_DLExp);
                            await doc.ExportField(int_Nationality);
                            await doc.ExportField(str_NationalID_Iqama);
                            await doc.ExportField(NationalID);
                            await doc.ExportField(UserlevelID);
                            await doc.ExportField(Activated);
                            await doc.ExportField(IsDrivingexperience);
                            await doc.ExportField(intDrivinglicenseType);
                            await doc.ExportField(Absherphoto);
                            await doc.ExportField(AbsherApptNbr);
                            await doc.ExportField(Fingerprint);
                        } else {
                            await doc.ExportField(int_Student_ID);
                            await doc.ExportField(str_First_Name);
                            await doc.ExportField(str_Middle_Name);
                            await doc.ExportField(str_Last_Name);
                            await doc.ExportField(str_Home_Phone);
                            await doc.ExportField(str_Cell_Phone);
                            await doc.ExportField(str_Other_Phone);
                            await doc.ExportField(str_Email);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(str_Password);
                            await doc.ExportField(date_Birth);
                            await doc.ExportField(date_Birth_Hijri);
                            await doc.ExportField(str_Emergency_Contact_Name);
                            await doc.ExportField(str_Emergency_Contact_Phone);
                            await doc.ExportField(str_Emergency_Contact_Relation);
                            await doc.ExportField(int_Type);
                            await doc.ExportField(int_Location);
                            await doc.ExportField(date_Created);
                            await doc.ExportField(date_Modified);
                            await doc.ExportField(str_DLNum);
                            await doc.ExportField(str_DLExp);
                            await doc.ExportField(int_Nationality);
                            await doc.ExportField(str_NationalID_Iqama);
                            await doc.ExportField(NationalID);
                            await doc.ExportField(UserlevelID);
                            await doc.ExportField(Activated);
                            await doc.ExportField(IsDrivingexperience);
                            await doc.ExportField(intDrivinglicenseType);
                            await doc.ExportField(Absherphoto);
                            await doc.ExportField(AbsherApptNbr);
                            await doc.ExportField(Fingerprint);
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
