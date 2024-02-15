namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// qryEvalCalcWshtResultsMb
    /// </summary>
    [MaybeNull]
    public static QryEvalCalcWshtResultsMb qryEvalCalcWshtResultsMb
    {
        get => HttpData.Resolve<QryEvalCalcWshtResultsMb>("qryEvalCalcWsht_ResultsMB");
        set => HttpData["qryEvalCalcWsht_ResultsMB"] = value;
    }

    /// <summary>
    /// Table class for qryEvalCalcWsht_ResultsMB
    /// </summary>
    public class QryEvalCalcWshtResultsMb : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> Eval_ID;

        public readonly DbField<SqlDbType> int_Student_ID;

        public readonly DbField<SqlDbType> AssessmentID;

        public readonly DbField<SqlDbType> str_Full_Name_Hdr;

        public readonly DbField<SqlDbType> NationalID;

        public readonly DbField<SqlDbType> str_Username;

        public readonly DbField<SqlDbType> intDrivinglicenseType;

        public readonly DbField<SqlDbType> Date_Entered;

        public readonly DbField<SqlDbType> Examination_Number;

        public readonly DbField<SqlDbType> Sect11Sum;

        public readonly DbField<SqlDbType> Subtotal;

        public readonly DbField<SqlDbType> Assign_int_Package_Id;

        public readonly DbField<SqlDbType> Package_Name;

        public readonly DbField<SqlDbType> Discount;

        public readonly DbField<SqlDbType> Price;

        public readonly DbField<SqlDbType> Package_Items;

        public readonly DbField<SqlDbType> Examiner_Signature;

        public readonly DbField<SqlDbType> Student_Signature;

        public readonly DbField<SqlDbType> str_Email;

        public readonly DbField<SqlDbType> UserlevelID;

        // Constructor
        public QryEvalCalcWshtResultsMb()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "qryEvalCalcWsht_ResultsMB";
            Name = "qryEvalCalcWsht_ResultsMB";
            Type = "VIEW";
            UpdateTable = "dbo.qryEvalCalcWsht_ResultsMB"; // Update Table
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
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "Eval_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Eval_ID", Eval_ID);

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
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "int_Student_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Student_ID", int_Student_ID);

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
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "AssessmentID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("AssessmentID", AssessmentID);

            // str_Full_Name_Hdr
            str_Full_Name_Hdr = new (this, "x_str_Full_Name_Hdr", 202, SqlDbType.NVarChar) {
                Name = "str_Full_Name_Hdr",
                Expression = "[str_Full_Name_Hdr]",
                UseBasicSearch = true,
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
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "str_Full_Name_Hdr", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Full_Name_Hdr", str_Full_Name_Hdr);

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
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "NationalID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("NationalID", NationalID);

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
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "str_Username", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Username", str_Username);

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
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "intDrivinglicenseType", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("intDrivinglicenseType", intDrivinglicenseType);

            // Date_Entered
            Date_Entered = new (this, "x_Date_Entered", 135, SqlDbType.DateTime) {
                Name = "Date_Entered",
                Expression = "[Date_Entered]",
                BasicSearchExpression = CastDateFieldForLike("[Date_Entered]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[Date_Entered]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "Date_Entered", "CustomMsg"),
                IsUpload = false
            };
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
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "Examination_Number", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Examination_Number", Examination_Number);

            // Sect11Sum
            Sect11Sum = new (this, "x_Sect11Sum", 5, SqlDbType.Float) {
                Name = "Sect11Sum",
                Expression = "[Sect11Sum]",
                BasicSearchExpression = "CAST([Sect11Sum] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Sect11Sum]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "Sect11Sum", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Sect11Sum", Sect11Sum);

            // Subtotal
            Subtotal = new (this, "x_Subtotal", 5, SqlDbType.Float) {
                Name = "Subtotal",
                Expression = "[Subtotal]",
                BasicSearchExpression = "CAST([Subtotal] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Subtotal]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "Subtotal", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Subtotal", Subtotal);

            // Assign_int_Package_Id
            Assign_int_Package_Id = new (this, "x_Assign_int_Package_Id", 3, SqlDbType.Int) {
                Name = "Assign_int_Package_Id",
                Expression = "[Assign_int_Package_Id]",
                BasicSearchExpression = "CAST([Assign_int_Package_Id] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Assign_int_Package_Id]",
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
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "Assign_int_Package_Id", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Assign_int_Package_Id", Assign_int_Package_Id);

            // Package_Name
            Package_Name = new (this, "x_Package_Name", 202, SqlDbType.NVarChar) {
                Name = "Package_Name",
                Expression = "[Package_Name]",
                UseBasicSearch = true,
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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "Package_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Package_Name", Package_Name);

            // Discount
            Discount = new (this, "x_Discount", 200, SqlDbType.VarChar) {
                Name = "Discount",
                Expression = "[Discount]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Discount]",
                DateTimeFormat = -1,
                VirtualExpression = "[Discount]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "Discount", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Discount", Discount);

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
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "Price", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Price", Price);

            // Package_Items
            Package_Items = new (this, "x_Package_Items", 200, SqlDbType.VarChar) {
                Name = "Package_Items",
                Expression = "[Package_Items]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Package_Items]",
                DateTimeFormat = -1,
                VirtualExpression = "[Package_Items]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "Package_Items", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Package_Items", Package_Items);

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
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "Examiner_Signature", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Examiner_Signature", Examiner_Signature);

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
                HtmlTag = "TEXTAREA",
                InputTextType = "text",
                Sortable = false, // Allow sort
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "Student_Signature", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Student_Signature", Student_Signature);

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
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "str_Email", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("qryEvalCalcWsht_ResultsMB", "UserlevelID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("UserlevelID", UserlevelID);

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
            get => _sqlFrom ?? "dbo.qryEvalCalcWsht_ResultsMB";
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
                Eval_ID.SetDbValue(lastInsertedId);
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
                Eval_ID.DbValue = row["Eval_ID"]; // Set DB value only
                int_Student_ID.DbValue = row["int_Student_ID"]; // Set DB value only
                AssessmentID.DbValue = row["AssessmentID"]; // Set DB value only
                str_Full_Name_Hdr.DbValue = row["str_Full_Name_Hdr"]; // Set DB value only
                NationalID.DbValue = row["NationalID"]; // Set DB value only
                str_Username.DbValue = row["str_Username"]; // Set DB value only
                intDrivinglicenseType.DbValue = row["intDrivinglicenseType"]; // Set DB value only
                Date_Entered.DbValue = row["Date_Entered"]; // Set DB value only
                Examination_Number.DbValue = row["Examination_Number"]; // Set DB value only
                Sect11Sum.DbValue = row["Sect11Sum"]; // Set DB value only
                Subtotal.DbValue = row["Subtotal"]; // Set DB value only
                Assign_int_Package_Id.DbValue = row["Assign_int_Package_Id"]; // Set DB value only
                Package_Name.DbValue = row["Package_Name"]; // Set DB value only
                Discount.DbValue = row["Discount"]; // Set DB value only
                Price.DbValue = row["Price"]; // Set DB value only
                Package_Items.DbValue = row["Package_Items"]; // Set DB value only
                Examiner_Signature.DbValue = row["Examiner_Signature"]; // Set DB value only
                Student_Signature.DbValue = row["Student_Signature"]; // Set DB value only
                str_Email.DbValue = row["str_Email"]; // Set DB value only
                UserlevelID.DbValue = row["UserlevelID"]; // Set DB value only
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
                    return "QryEvalCalcWshtResultsMbList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "QryEvalCalcWshtResultsMbView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "QryEvalCalcWshtResultsMbEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "QryEvalCalcWshtResultsMbAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "QryEvalCalcWshtResultsMbList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "QryEvalCalcWshtResultsMbView",
                Config.ApiAddAction => "QryEvalCalcWshtResultsMbAdd",
                Config.ApiEditAction => "QryEvalCalcWshtResultsMbEdit",
                Config.ApiDeleteAction => "QryEvalCalcWshtResultsMbDelete",
                Config.ApiListAction => "QryEvalCalcWshtResultsMbList",
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
        public string ListUrl => "QryEvalCalcWshtResultsMbList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("QryEvalCalcWshtResultsMbView", parm);
            else
                url = KeyUrl("QryEvalCalcWshtResultsMbView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "QryEvalCalcWshtResultsMbAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "QryEvalCalcWshtResultsMbAdd?" + parm;
            else
                url = "QryEvalCalcWshtResultsMbAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("QryEvalCalcWshtResultsMbEdit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("QryEvalCalcWshtResultsMbList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("QryEvalCalcWshtResultsMbAdd", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("QryEvalCalcWshtResultsMbList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("QryEvalCalcWshtResultsMbDelete")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
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
            int_Student_ID.SetDbValue(dr["int_Student_ID"]);
            AssessmentID.SetDbValue(dr["AssessmentID"]);
            str_Full_Name_Hdr.SetDbValue(dr["str_Full_Name_Hdr"]);
            NationalID.SetDbValue(dr["NationalID"]);
            str_Username.SetDbValue(dr["str_Username"]);
            intDrivinglicenseType.SetDbValue(dr["intDrivinglicenseType"]);
            Date_Entered.SetDbValue(dr["Date_Entered"]);
            Examination_Number.SetDbValue(dr["Examination_Number"]);
            Sect11Sum.SetDbValue(dr["Sect11Sum"]);
            Subtotal.SetDbValue(dr["Subtotal"]);
            Assign_int_Package_Id.SetDbValue(dr["Assign_int_Package_Id"]);
            Package_Name.SetDbValue(dr["Package_Name"]);
            Discount.SetDbValue(dr["Discount"]);
            Price.SetDbValue(dr["Price"]);
            Package_Items.SetDbValue(dr["Package_Items"]);
            Examiner_Signature.SetDbValue(dr["Examiner_Signature"]);
            Student_Signature.SetDbValue(dr["Student_Signature"]);
            str_Email.SetDbValue(dr["str_Email"]);
            UserlevelID.SetDbValue(dr["UserlevelID"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "QryEvalCalcWshtResultsMbList";
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

            // int_Student_ID

            // AssessmentID

            // str_Full_Name_Hdr

            // NationalID

            // str_Username

            // intDrivinglicenseType

            // Date_Entered

            // Examination_Number

            // Sect11Sum

            // Subtotal

            // Assign_int_Package_Id

            // Package_Name

            // Discount

            // Price

            // Package_Items

            // Examiner_Signature

            // Student_Signature

            // str_Email

            // UserlevelID

            // Eval_ID
            Eval_ID.ViewValue = Eval_ID.CurrentValue;
            Eval_ID.ViewCustomAttributes = "";

            // int_Student_ID
            int_Student_ID.ViewValue = int_Student_ID.CurrentValue;
            int_Student_ID.ViewValue = FormatNumber(int_Student_ID.ViewValue, int_Student_ID.FormatPattern);
            int_Student_ID.ViewCustomAttributes = "";

            // AssessmentID
            AssessmentID.ViewValue = AssessmentID.CurrentValue;
            AssessmentID.ViewValue = FormatNumber(AssessmentID.ViewValue, AssessmentID.FormatPattern);
            AssessmentID.ViewCustomAttributes = "";

            // str_Full_Name_Hdr
            str_Full_Name_Hdr.ViewValue = ConvertToString(str_Full_Name_Hdr.CurrentValue); // DN
            str_Full_Name_Hdr.ViewCustomAttributes = "";

            // NationalID
            NationalID.ViewValue = NationalID.CurrentValue;
            NationalID.ViewValue = FormatNumber(NationalID.ViewValue, NationalID.FormatPattern);
            NationalID.ViewCustomAttributes = "";

            // str_Username
            str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
            str_Username.ViewCustomAttributes = "";

            // intDrivinglicenseType
            intDrivinglicenseType.ViewValue = intDrivinglicenseType.CurrentValue;
            intDrivinglicenseType.ViewValue = FormatNumber(intDrivinglicenseType.ViewValue, intDrivinglicenseType.FormatPattern);
            intDrivinglicenseType.ViewCustomAttributes = "";

            // Date_Entered
            Date_Entered.ViewValue = Date_Entered.CurrentValue;
            Date_Entered.ViewValue = FormatDateTime(Date_Entered.ViewValue, Date_Entered.FormatPattern);
            Date_Entered.ViewCustomAttributes = "";

            // Examination_Number
            Examination_Number.ViewValue = Examination_Number.CurrentValue;
            Examination_Number.ViewValue = FormatNumber(Examination_Number.ViewValue, Examination_Number.FormatPattern);
            Examination_Number.ViewCustomAttributes = "";

            // Sect11Sum
            Sect11Sum.ViewValue = Sect11Sum.CurrentValue;
            Sect11Sum.ViewValue = FormatNumber(Sect11Sum.ViewValue, Sect11Sum.FormatPattern);
            Sect11Sum.ViewCustomAttributes = "";

            // Subtotal
            Subtotal.ViewValue = Subtotal.CurrentValue;
            Subtotal.ViewValue = FormatNumber(Subtotal.ViewValue, Subtotal.FormatPattern);
            Subtotal.ViewCustomAttributes = "";

            // Assign_int_Package_Id
            Assign_int_Package_Id.ViewValue = Assign_int_Package_Id.CurrentValue;
            Assign_int_Package_Id.ViewValue = FormatNumber(Assign_int_Package_Id.ViewValue, Assign_int_Package_Id.FormatPattern);
            Assign_int_Package_Id.ViewCustomAttributes = "";

            // Package_Name
            Package_Name.ViewValue = ConvertToString(Package_Name.CurrentValue); // DN
            Package_Name.ViewCustomAttributes = "";

            // Discount
            Discount.ViewValue = ConvertToString(Discount.CurrentValue); // DN
            Discount.ViewCustomAttributes = "";

            // Price
            Price.ViewValue = Price.CurrentValue;
            Price.ViewValue = FormatNumber(Price.ViewValue, Price.FormatPattern);
            Price.ViewCustomAttributes = "";

            // Package_Items
            Package_Items.ViewValue = ConvertToString(Package_Items.CurrentValue); // DN
            Package_Items.ViewCustomAttributes = "";

            // Examiner_Signature
            Examiner_Signature.ViewValue = Examiner_Signature.CurrentValue;
            Examiner_Signature.ViewCustomAttributes = "";

            // Student_Signature
            Student_Signature.ViewValue = Student_Signature.CurrentValue;
            Student_Signature.ViewCustomAttributes = "";

            // str_Email
            str_Email.ViewValue = ConvertToString(str_Email.CurrentValue); // DN
            str_Email.ViewCustomAttributes = "";

            // UserlevelID
            UserlevelID.ViewValue = UserlevelID.CurrentValue;
            UserlevelID.ViewValue = FormatNumber(UserlevelID.ViewValue, UserlevelID.FormatPattern);
            UserlevelID.ViewCustomAttributes = "";

            // Eval_ID
            Eval_ID.HrefValue = "";
            Eval_ID.TooltipValue = "";

            // int_Student_ID
            int_Student_ID.HrefValue = "";
            int_Student_ID.TooltipValue = "";

            // AssessmentID
            AssessmentID.HrefValue = "";
            AssessmentID.TooltipValue = "";

            // str_Full_Name_Hdr
            str_Full_Name_Hdr.HrefValue = "";
            str_Full_Name_Hdr.TooltipValue = "";

            // NationalID
            NationalID.HrefValue = "";
            NationalID.TooltipValue = "";

            // str_Username
            str_Username.HrefValue = "";
            str_Username.TooltipValue = "";

            // intDrivinglicenseType
            intDrivinglicenseType.HrefValue = "";
            intDrivinglicenseType.TooltipValue = "";

            // Date_Entered
            Date_Entered.HrefValue = "";
            Date_Entered.TooltipValue = "";

            // Examination_Number
            Examination_Number.HrefValue = "";
            Examination_Number.TooltipValue = "";

            // Sect11Sum
            Sect11Sum.HrefValue = "";
            Sect11Sum.TooltipValue = "";

            // Subtotal
            Subtotal.HrefValue = "";
            Subtotal.TooltipValue = "";

            // Assign_int_Package_Id
            Assign_int_Package_Id.HrefValue = "";
            Assign_int_Package_Id.TooltipValue = "";

            // Package_Name
            Package_Name.HrefValue = "";
            Package_Name.TooltipValue = "";

            // Discount
            Discount.HrefValue = "";
            Discount.TooltipValue = "";

            // Price
            Price.HrefValue = "";
            Price.TooltipValue = "";

            // Package_Items
            Package_Items.HrefValue = "";
            Package_Items.TooltipValue = "";

            // Examiner_Signature
            Examiner_Signature.HrefValue = "";
            Examiner_Signature.TooltipValue = "";

            // Student_Signature
            Student_Signature.HrefValue = "";
            Student_Signature.TooltipValue = "";

            // str_Email
            str_Email.HrefValue = "";
            str_Email.TooltipValue = "";

            // UserlevelID
            UserlevelID.HrefValue = "";
            UserlevelID.TooltipValue = "";

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

            // int_Student_ID
            int_Student_ID.SetupEditAttributes();
            int_Student_ID.EditValue = int_Student_ID.CurrentValue; // DN
            int_Student_ID.PlaceHolder = RemoveHtml(int_Student_ID.Caption);
            if (!Empty(int_Student_ID.EditValue) && IsNumeric(int_Student_ID.EditValue))
                int_Student_ID.EditValue = FormatNumber(int_Student_ID.EditValue, null);

            // AssessmentID
            AssessmentID.SetupEditAttributes();
            AssessmentID.EditValue = AssessmentID.CurrentValue; // DN
            AssessmentID.PlaceHolder = RemoveHtml(AssessmentID.Caption);
            if (!Empty(AssessmentID.EditValue) && IsNumeric(AssessmentID.EditValue))
                AssessmentID.EditValue = FormatNumber(AssessmentID.EditValue, null);

            // str_Full_Name_Hdr
            str_Full_Name_Hdr.SetupEditAttributes();
            if (!str_Full_Name_Hdr.Raw)
                str_Full_Name_Hdr.CurrentValue = HtmlDecode(str_Full_Name_Hdr.CurrentValue);
            str_Full_Name_Hdr.EditValue = HtmlEncode(str_Full_Name_Hdr.CurrentValue);
            str_Full_Name_Hdr.PlaceHolder = RemoveHtml(str_Full_Name_Hdr.Caption);

            // NationalID
            NationalID.SetupEditAttributes();
            NationalID.EditValue = NationalID.CurrentValue; // DN
            NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);
            if (!Empty(NationalID.EditValue) && IsNumeric(NationalID.EditValue))
                NationalID.EditValue = FormatNumber(NationalID.EditValue, null);

            // str_Username
            str_Username.SetupEditAttributes();
            if (!str_Username.Raw)
                str_Username.CurrentValue = HtmlDecode(str_Username.CurrentValue);
            str_Username.EditValue = HtmlEncode(str_Username.CurrentValue);
            str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);

            // intDrivinglicenseType
            intDrivinglicenseType.SetupEditAttributes();
            intDrivinglicenseType.EditValue = intDrivinglicenseType.CurrentValue; // DN
            intDrivinglicenseType.PlaceHolder = RemoveHtml(intDrivinglicenseType.Caption);
            if (!Empty(intDrivinglicenseType.EditValue) && IsNumeric(intDrivinglicenseType.EditValue))
                intDrivinglicenseType.EditValue = FormatNumber(intDrivinglicenseType.EditValue, null);

            // Date_Entered
            Date_Entered.SetupEditAttributes();
            Date_Entered.EditValue = FormatDateTime(Date_Entered.CurrentValue, Date_Entered.FormatPattern); // DN
            Date_Entered.PlaceHolder = RemoveHtml(Date_Entered.Caption);

            // Examination_Number
            Examination_Number.SetupEditAttributes();
            Examination_Number.EditValue = Examination_Number.CurrentValue; // DN
            Examination_Number.PlaceHolder = RemoveHtml(Examination_Number.Caption);
            if (!Empty(Examination_Number.EditValue) && IsNumeric(Examination_Number.EditValue))
                Examination_Number.EditValue = FormatNumber(Examination_Number.EditValue, null);

            // Sect11Sum
            Sect11Sum.SetupEditAttributes();
            Sect11Sum.EditValue = Sect11Sum.CurrentValue; // DN
            Sect11Sum.PlaceHolder = RemoveHtml(Sect11Sum.Caption);
            if (!Empty(Sect11Sum.EditValue) && IsNumeric(Sect11Sum.EditValue))
                Sect11Sum.EditValue = FormatNumber(Sect11Sum.EditValue, null);

            // Subtotal
            Subtotal.SetupEditAttributes();
            Subtotal.EditValue = Subtotal.CurrentValue; // DN
            Subtotal.PlaceHolder = RemoveHtml(Subtotal.Caption);
            if (!Empty(Subtotal.EditValue) && IsNumeric(Subtotal.EditValue))
                Subtotal.EditValue = FormatNumber(Subtotal.EditValue, null);

            // Assign_int_Package_Id
            Assign_int_Package_Id.SetupEditAttributes();
            Assign_int_Package_Id.EditValue = Assign_int_Package_Id.CurrentValue; // DN
            Assign_int_Package_Id.PlaceHolder = RemoveHtml(Assign_int_Package_Id.Caption);
            if (!Empty(Assign_int_Package_Id.EditValue) && IsNumeric(Assign_int_Package_Id.EditValue))
                Assign_int_Package_Id.EditValue = FormatNumber(Assign_int_Package_Id.EditValue, null);

            // Package_Name
            Package_Name.SetupEditAttributes();
            if (!Package_Name.Raw)
                Package_Name.CurrentValue = HtmlDecode(Package_Name.CurrentValue);
            Package_Name.EditValue = HtmlEncode(Package_Name.CurrentValue);
            Package_Name.PlaceHolder = RemoveHtml(Package_Name.Caption);

            // Discount
            Discount.SetupEditAttributes();
            if (!Discount.Raw)
                Discount.CurrentValue = HtmlDecode(Discount.CurrentValue);
            Discount.EditValue = HtmlEncode(Discount.CurrentValue);
            Discount.PlaceHolder = RemoveHtml(Discount.Caption);

            // Price
            Price.SetupEditAttributes();
            Price.EditValue = Price.CurrentValue; // DN
            Price.PlaceHolder = RemoveHtml(Price.Caption);
            if (!Empty(Price.EditValue) && IsNumeric(Price.EditValue))
                Price.EditValue = FormatNumber(Price.EditValue, null);

            // Package_Items
            Package_Items.SetupEditAttributes();
            if (!Package_Items.Raw)
                Package_Items.CurrentValue = HtmlDecode(Package_Items.CurrentValue);
            Package_Items.EditValue = HtmlEncode(Package_Items.CurrentValue);
            Package_Items.PlaceHolder = RemoveHtml(Package_Items.Caption);

            // Examiner_Signature
            Examiner_Signature.SetupEditAttributes();
            Examiner_Signature.EditValue = Examiner_Signature.CurrentValue; // DN
            Examiner_Signature.PlaceHolder = RemoveHtml(Examiner_Signature.Caption);

            // Student_Signature
            Student_Signature.SetupEditAttributes();
            Student_Signature.EditValue = Student_Signature.CurrentValue; // DN
            Student_Signature.PlaceHolder = RemoveHtml(Student_Signature.Caption);

            // str_Email
            str_Email.SetupEditAttributes();
            if (!str_Email.Raw)
                str_Email.CurrentValue = HtmlDecode(str_Email.CurrentValue);
            str_Email.EditValue = HtmlEncode(str_Email.CurrentValue);
            str_Email.PlaceHolder = RemoveHtml(str_Email.Caption);

            // UserlevelID
            UserlevelID.SetupEditAttributes();
            UserlevelID.EditValue = UserlevelID.CurrentValue; // DN
            UserlevelID.PlaceHolder = RemoveHtml(UserlevelID.Caption);
            if (!Empty(UserlevelID.EditValue) && IsNumeric(UserlevelID.EditValue))
                UserlevelID.EditValue = FormatNumber(UserlevelID.EditValue, null);

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
                        doc.ExportCaption(Eval_ID);
                        doc.ExportCaption(int_Student_ID);
                        doc.ExportCaption(AssessmentID);
                        doc.ExportCaption(str_Full_Name_Hdr);
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(intDrivinglicenseType);
                        doc.ExportCaption(Date_Entered);
                        doc.ExportCaption(Examination_Number);
                        doc.ExportCaption(Sect11Sum);
                        doc.ExportCaption(Subtotal);
                        doc.ExportCaption(Assign_int_Package_Id);
                        doc.ExportCaption(Package_Name);
                        doc.ExportCaption(Discount);
                        doc.ExportCaption(Price);
                        doc.ExportCaption(Package_Items);
                        doc.ExportCaption(Examiner_Signature);
                        doc.ExportCaption(Student_Signature);
                        doc.ExportCaption(str_Email);
                        doc.ExportCaption(UserlevelID);
                    } else {
                        doc.ExportCaption(Eval_ID);
                        doc.ExportCaption(int_Student_ID);
                        doc.ExportCaption(AssessmentID);
                        doc.ExportCaption(str_Full_Name_Hdr);
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(intDrivinglicenseType);
                        doc.ExportCaption(Date_Entered);
                        doc.ExportCaption(Examination_Number);
                        doc.ExportCaption(Sect11Sum);
                        doc.ExportCaption(Subtotal);
                        doc.ExportCaption(Assign_int_Package_Id);
                        doc.ExportCaption(Package_Name);
                        doc.ExportCaption(Discount);
                        doc.ExportCaption(Price);
                        doc.ExportCaption(Package_Items);
                        doc.ExportCaption(str_Email);
                        doc.ExportCaption(UserlevelID);
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
                            await doc.ExportField(Eval_ID);
                            await doc.ExportField(int_Student_ID);
                            await doc.ExportField(AssessmentID);
                            await doc.ExportField(str_Full_Name_Hdr);
                            await doc.ExportField(NationalID);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(intDrivinglicenseType);
                            await doc.ExportField(Date_Entered);
                            await doc.ExportField(Examination_Number);
                            await doc.ExportField(Sect11Sum);
                            await doc.ExportField(Subtotal);
                            await doc.ExportField(Assign_int_Package_Id);
                            await doc.ExportField(Package_Name);
                            await doc.ExportField(Discount);
                            await doc.ExportField(Price);
                            await doc.ExportField(Package_Items);
                            await doc.ExportField(Examiner_Signature);
                            await doc.ExportField(Student_Signature);
                            await doc.ExportField(str_Email);
                            await doc.ExportField(UserlevelID);
                        } else {
                            await doc.ExportField(Eval_ID);
                            await doc.ExportField(int_Student_ID);
                            await doc.ExportField(AssessmentID);
                            await doc.ExportField(str_Full_Name_Hdr);
                            await doc.ExportField(NationalID);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(intDrivinglicenseType);
                            await doc.ExportField(Date_Entered);
                            await doc.ExportField(Examination_Number);
                            await doc.ExportField(Sect11Sum);
                            await doc.ExportField(Subtotal);
                            await doc.ExportField(Assign_int_Package_Id);
                            await doc.ExportField(Package_Name);
                            await doc.ExportField(Discount);
                            await doc.ExportField(Price);
                            await doc.ExportField(Package_Items);
                            await doc.ExportField(str_Email);
                            await doc.ExportField(UserlevelID);
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
