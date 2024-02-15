namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// equipment
    /// </summary>
    [MaybeNull]
    public static Equipment equipment
    {
        get => HttpData.Resolve<Equipment>("Equipment");
        set => HttpData["Equipment"] = value;
    }

    /// <summary>
    /// Table class for Equipment
    /// </summary>
    public class Equipment : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> Equipment_ID;

        public readonly DbField<SqlDbType> int_Location;

        public readonly DbField<SqlDbType> Equipment_Type_ID;

        public readonly DbField<SqlDbType> Equipment_Type_Name;

        public readonly DbField<SqlDbType> Manufacturer_Name;

        public readonly DbField<SqlDbType> Serial_VIN_Number;

        public readonly DbField<SqlDbType> Retailer_Name;

        public readonly DbField<SqlDbType> DatePurchased;

        public readonly DbField<SqlDbType> ServiceInception_Date;

        public readonly DbField<SqlDbType> UsefulLife;

        public readonly DbField<SqlDbType> Price;

        public readonly DbField<SqlDbType> VAT;

        public readonly DbField<SqlDbType> Creation_Date;

        public readonly DbField<SqlDbType> Modified_Date;

        public readonly DbField<SqlDbType> Created_by;

        public readonly DbField<SqlDbType> Modified_by;

        // Constructor
        public Equipment()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "Equipment";
            Name = "Equipment";
            Type = "TABLE";
            UpdateTable = "dbo.Equipment"; // Update Table
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

            // Equipment_ID
            Equipment_ID = new (this, "x_Equipment_ID", 3, SqlDbType.Int) {
                Name = "Equipment_ID",
                Expression = "[Equipment_ID]",
                BasicSearchExpression = "CAST([Equipment_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Equipment_ID]",
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
                CustomMessage = Language.FieldPhrase("Equipment", "Equipment_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Equipment_ID", Equipment_ID);

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
                HtmlTag = "SELECT",
                InputTextType = "text",
                UsePleaseSelect = true, // Use PleaseSelect by default
                PleaseSelectText = Language.Phrase("PleaseSelect"), // PleaseSelect text
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Equipment", "int_Location", "CustomMsg"),
                IsUpload = false
            };
            int_Location.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(int_Location, "tblLocation", false, "int_Location_Id", new List<string> {"str_Name", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[str_Name]"),
                "en-US" => new Lookup<DbField>(int_Location, "tblLocation", false, "int_Location_Id", new List<string> {"str_Name", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[str_Name]"),
                _ => new Lookup<DbField>(int_Location, "tblLocation", false, "int_Location_Id", new List<string> {"str_Name", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "[str_Name]")
            };
            Fields.Add("int_Location", int_Location);

            // Equipment_Type_ID
            Equipment_Type_ID = new (this, "x_Equipment_Type_ID", 3, SqlDbType.Int) {
                Name = "Equipment_Type_ID",
                Expression = "[Equipment_Type_ID]",
                BasicSearchExpression = "CAST([Equipment_Type_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Equipment_Type_ID]",
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
                OptionCount = 6,
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Equipment", "Equipment_Type_ID", "CustomMsg"),
                IsUpload = false
            };
            Equipment_Type_ID.Lookup = CurrentLanguage switch {
                "ar-SA" => new Lookup<DbField>(Equipment_Type_ID, "Equipment", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                "en-US" => new Lookup<DbField>(Equipment_Type_ID, "Equipment", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", ""),
                _ => new Lookup<DbField>(Equipment_Type_ID, "Equipment", false, "", new List<string> {"", "", "", ""}, "", "", new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, new List<string> {}, "", "", "")
            };
            Fields.Add("Equipment_Type_ID", Equipment_Type_ID);

            // Equipment_Type_Name
            Equipment_Type_Name = new (this, "x_Equipment_Type_Name", 202, SqlDbType.NVarChar) {
                Name = "Equipment_Type_Name",
                Expression = "[Equipment_Type_Name]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Equipment_Type_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[Equipment_Type_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Equipment", "Equipment_Type_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Equipment_Type_Name", Equipment_Type_Name);

            // Manufacturer_Name
            Manufacturer_Name = new (this, "x_Manufacturer_Name", 202, SqlDbType.NVarChar) {
                Name = "Manufacturer_Name",
                Expression = "[Manufacturer_Name]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Manufacturer_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[Manufacturer_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Equipment", "Manufacturer_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Manufacturer_Name", Manufacturer_Name);

            // Serial_VIN_Number
            Serial_VIN_Number = new (this, "x_Serial_VIN_Number", 202, SqlDbType.NVarChar) {
                Name = "Serial_VIN_Number",
                Expression = "[Serial_VIN_Number]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Serial_VIN_Number]",
                DateTimeFormat = -1,
                VirtualExpression = "[Serial_VIN_Number]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Equipment", "Serial_VIN_Number", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Serial_VIN_Number", Serial_VIN_Number);

            // Retailer_Name
            Retailer_Name = new (this, "x_Retailer_Name", 202, SqlDbType.NVarChar) {
                Name = "Retailer_Name",
                Expression = "[Retailer_Name]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Retailer_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[Retailer_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Equipment", "Retailer_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Retailer_Name", Retailer_Name);

            // DatePurchased
            DatePurchased = new (this, "x_DatePurchased", 133, SqlDbType.DateTime) {
                Name = "DatePurchased",
                Expression = "[DatePurchased]",
                BasicSearchExpression = CastDateFieldForLike("[DatePurchased]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[DatePurchased]",
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
                CustomMessage = Language.FieldPhrase("Equipment", "DatePurchased", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("DatePurchased", DatePurchased);

            // ServiceInception_Date
            ServiceInception_Date = new (this, "x_ServiceInception_Date", 133, SqlDbType.DateTime) {
                Name = "ServiceInception_Date",
                Expression = "[ServiceInception_Date]",
                BasicSearchExpression = CastDateFieldForLike("[ServiceInception_Date]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[ServiceInception_Date]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Equipment", "ServiceInception_Date", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("ServiceInception_Date", ServiceInception_Date);

            // UsefulLife
            UsefulLife = new (this, "x_UsefulLife", 3, SqlDbType.Int) {
                Name = "UsefulLife",
                Expression = "[UsefulLife]",
                BasicSearchExpression = "CAST([UsefulLife] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[UsefulLife]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Equipment", "UsefulLife", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("UsefulLife", UsefulLife);

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
                CustomMessage = Language.FieldPhrase("Equipment", "Price", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Price", Price);

            // VAT
            VAT = new (this, "x_VAT", 6, SqlDbType.Money) {
                Name = "VAT",
                Expression = "[VAT]",
                BasicSearchExpression = "CAST([VAT] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[VAT]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Equipment", "VAT", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("VAT", VAT);

            // Creation_Date
            Creation_Date = new (this, "x_Creation_Date", 135, SqlDbType.DateTime) {
                Name = "Creation_Date",
                Expression = "[Creation_Date]",
                BasicSearchExpression = CastDateFieldForLike("[Creation_Date]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[Creation_Date]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Equipment", "Creation_Date", "CustomMsg"),
                IsUpload = false
            };
            Creation_Date.GetAutoUpdateValue = () => CurrentDateTime();
            Fields.Add("Creation_Date", Creation_Date);

            // Modified_Date
            Modified_Date = new (this, "x_Modified_Date", 135, SqlDbType.DateTime) {
                Name = "Modified_Date",
                Expression = "[Modified_Date]",
                BasicSearchExpression = CastDateFieldForLike("[Modified_Date]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[Modified_Date]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Equipment", "Modified_Date", "CustomMsg"),
                IsUpload = false
            };
            Modified_Date.GetAutoUpdateValue = () => CurrentDateTime();
            Fields.Add("Modified_Date", Modified_Date);

            // Created_by
            Created_by = new (this, "x_Created_by", 202, SqlDbType.NVarChar) {
                Name = "Created_by",
                Expression = "[Created_by]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Created_by]",
                DateTimeFormat = -1,
                VirtualExpression = "[Created_by]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Equipment", "Created_by", "CustomMsg"),
                IsUpload = false
            };
            Created_by.GetAutoUpdateValue = () => CurrentUserName();
            Fields.Add("Created_by", Created_by);

            // Modified_by
            Modified_by = new (this, "x_Modified_by", 202, SqlDbType.NVarChar) {
                Name = "Modified_by",
                Expression = "[Modified_by]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Modified_by]",
                DateTimeFormat = -1,
                VirtualExpression = "[Modified_by]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "HIDDEN",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Equipment", "Modified_by", "CustomMsg"),
                IsUpload = false
            };
            Modified_by.GetAutoUpdateValue = () => CurrentUserName();
            Fields.Add("Modified_by", Modified_by);

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
            get => _sqlFrom ?? "dbo.Equipment";
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
                Equipment_ID.SetDbValue(lastInsertedId);
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
                Equipment_ID.DbValue = row["Equipment_ID"]; // Set DB value only
                int_Location.DbValue = row["int_Location"]; // Set DB value only
                Equipment_Type_ID.DbValue = row["Equipment_Type_ID"]; // Set DB value only
                Equipment_Type_Name.DbValue = row["Equipment_Type_Name"]; // Set DB value only
                Manufacturer_Name.DbValue = row["Manufacturer_Name"]; // Set DB value only
                Serial_VIN_Number.DbValue = row["Serial_VIN_Number"]; // Set DB value only
                Retailer_Name.DbValue = row["Retailer_Name"]; // Set DB value only
                DatePurchased.DbValue = row["DatePurchased"]; // Set DB value only
                ServiceInception_Date.DbValue = row["ServiceInception_Date"]; // Set DB value only
                UsefulLife.DbValue = row["UsefulLife"]; // Set DB value only
                Price.DbValue = row["Price"]; // Set DB value only
                VAT.DbValue = row["VAT"]; // Set DB value only
                Creation_Date.DbValue = row["Creation_Date"]; // Set DB value only
                Modified_Date.DbValue = row["Modified_Date"]; // Set DB value only
                Created_by.DbValue = row["Created_by"]; // Set DB value only
                Modified_by.DbValue = row["Modified_by"]; // Set DB value only
            } catch {}
        }

        public void DeleteUploadedFiles(Dictionary<string, object> row)
        {
            LoadDbValues(row);
        }

        // Record filter WHERE clause
        private string _sqlKeyFilter => "[Equipment_ID] = @Equipment_ID@";

        #pragma warning disable 168, 219
        // Get record filter as string
        public string GetRecordFilter(Dictionary<string, object>? row = null, bool current = false)
        {
            string keyFilter = _sqlKeyFilter;
            object? val = null, result = "";
            val = row?.TryGetValue("Equipment_ID", out result) ?? false
                ? result
                : !Empty(Equipment_ID.OldValue) && !current ? Equipment_ID.OldValue : Equipment_ID.CurrentValue;
            if (!IsNumeric(val))
                return "0=1"; // Invalid key
            if (val == null)
                return "0=1"; // Invalid key
            keyFilter = keyFilter.Replace("@Equipment_ID@", AdjustSql(val, DbId)); // Replace key value
            return keyFilter;
        }

        // Get record filter as Dictionary // DN
        public Dictionary<string, object>? GetRowFilterAsDictionary(IDictionary<string, object>? row = null)
        {
            Dictionary<string, object>? keyFilter = new ();
            object? val = null, result;
            val = row?.TryGetValue("Equipment_ID", out result) ?? false
                ? result
                : !Empty(Equipment_ID.OldValue) ? Equipment_ID.OldValue : Equipment_ID.CurrentValue;
            if (!IsNumeric(val))
                return null; // Invalid key
            if (Empty(val))
                return null; // Invalid key
            keyFilter.Add("Equipment_ID", val); // Add key value
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
                    return "EquipmentList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "EquipmentView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "EquipmentEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "EquipmentAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "EquipmentList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "EquipmentView",
                Config.ApiAddAction => "EquipmentAdd",
                Config.ApiEditAction => "EquipmentEdit",
                Config.ApiDeleteAction => "EquipmentDelete",
                Config.ApiListAction => "EquipmentList",
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
        public string ListUrl => "EquipmentList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("EquipmentView", parm);
            else
                url = KeyUrl("EquipmentView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "EquipmentAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "EquipmentAdd?" + parm;
            else
                url = "EquipmentAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("EquipmentEdit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("EquipmentList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("EquipmentAdd", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("EquipmentList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("EquipmentDelete")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
            return url;
        }

        // Get primary key as JSON
        public string KeyToJson(bool htmlEncode = false)
        {
            string json = "";
            json += "\"Equipment_ID\":" + ConvertToJson(Equipment_ID.CurrentValue, "number", true);
            json = "{" + json + "}";
            if (htmlEncode)
                json = HtmlEncode(json);
            return json;
        }

        // Add key value to URL
        public string KeyUrl(string url, string parm = "") { // DN
            if (!IsNull(Equipment_ID.CurrentValue)) {
                url += "/" + Equipment_ID.CurrentValue;
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
            val = current ? ConvertToString(Equipment_ID.CurrentValue) ?? "" : ConvertToString(Equipment_ID.OldValue) ?? "";
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
            val = row?.TryGetValue("Equipment_ID", out result) ?? false ? ConvertToString(result) : null;
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
                    Equipment_ID.CurrentValue = keys[0];
                } else {
                    Equipment_ID.OldValue = keys[0];
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
                if (RouteValues.TryGetValue("Equipment_ID", out object? v0)) { // Equipment_ID // DN
                    key = UrlDecode(v0); // DN
                } else if (IsApi() && !Empty(keyValues)) {
                    key = keyValues[0];
                } else {
                    key = Param("Equipment_ID");
                }
                keysList.Add(key);
            }
            // Check keys
            foreach (var keys in keysList) {
                if (!IsNumeric(keys)) // Equipment_ID
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
                    Equipment_ID.CurrentValue = keys;
                else
                    Equipment_ID.OldValue = keys;
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
            Equipment_ID.SetDbValue(dr["Equipment_ID"]);
            int_Location.SetDbValue(dr["int_Location"]);
            Equipment_Type_ID.SetDbValue(dr["Equipment_Type_ID"]);
            Equipment_Type_Name.SetDbValue(dr["Equipment_Type_Name"]);
            Manufacturer_Name.SetDbValue(dr["Manufacturer_Name"]);
            Serial_VIN_Number.SetDbValue(dr["Serial_VIN_Number"]);
            Retailer_Name.SetDbValue(dr["Retailer_Name"]);
            DatePurchased.SetDbValue(dr["DatePurchased"]);
            ServiceInception_Date.SetDbValue(dr["ServiceInception_Date"]);
            UsefulLife.SetDbValue(dr["UsefulLife"]);
            Price.SetDbValue(dr["Price"]);
            VAT.SetDbValue(dr["VAT"]);
            Creation_Date.SetDbValue(dr["Creation_Date"]);
            Modified_Date.SetDbValue(dr["Modified_Date"]);
            Created_by.SetDbValue(dr["Created_by"]);
            Modified_by.SetDbValue(dr["Modified_by"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "EquipmentList";
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

            // Equipment_ID

            // int_Location

            // Equipment_Type_ID

            // Equipment_Type_Name

            // Manufacturer_Name

            // Serial_VIN_Number

            // Retailer_Name

            // DatePurchased

            // ServiceInception_Date

            // UsefulLife

            // Price

            // VAT

            // Creation_Date

            // Modified_Date

            // Created_by

            // Modified_by

            // Equipment_ID
            Equipment_ID.ViewValue = Equipment_ID.CurrentValue;
            Equipment_ID.ViewCustomAttributes = "";

            // int_Location
            curVal = ConvertToString(int_Location.CurrentValue);
            if (!Empty(curVal)) {
                if (int_Location.Lookup != null && IsDictionary(int_Location.Lookup?.Options) && int_Location.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_Location.ViewValue = int_Location.LookupCacheOption(curVal);
                } else { // Lookup from database // DN
                    filterWrk = SearchFilter("[int_Location_Id]", "=", int_Location.CurrentValue, DataType.Number, "");
                    sqlWrk = int_Location.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    if (rswrk?.Count > 0 && int_Location.Lookup != null) { // Lookup values found
                        var listwrk = int_Location.Lookup?.RenderViewRow(rswrk[0]);
                        int_Location.ViewValue = int_Location.HighlightLookup(ConvertToString(rswrk[0]), int_Location.DisplayValue(listwrk));
                    } else {
                        int_Location.ViewValue = FormatNumber(int_Location.CurrentValue, int_Location.FormatPattern);
                    }
                }
            } else {
                int_Location.ViewValue = DbNullValue;
            }
            int_Location.ViewCustomAttributes = "";

            // Equipment_Type_ID
            if (!Empty(Equipment_Type_ID.CurrentValue)) {
                Equipment_Type_ID.ViewValue = Equipment_Type_ID.HighlightLookup(ConvertToString(Equipment_Type_ID.CurrentValue), Equipment_Type_ID.OptionCaption(ConvertToString(Equipment_Type_ID.CurrentValue)));
            } else {
                Equipment_Type_ID.ViewValue = DbNullValue;
            }
            Equipment_Type_ID.ViewCustomAttributes = "";

            // Equipment_Type_Name
            Equipment_Type_Name.ViewValue = ConvertToString(Equipment_Type_Name.CurrentValue); // DN
            Equipment_Type_Name.ViewCustomAttributes = "";

            // Manufacturer_Name
            Manufacturer_Name.ViewValue = ConvertToString(Manufacturer_Name.CurrentValue); // DN
            Manufacturer_Name.ViewCustomAttributes = "";

            // Serial_VIN_Number
            Serial_VIN_Number.ViewValue = ConvertToString(Serial_VIN_Number.CurrentValue); // DN
            Serial_VIN_Number.ViewCustomAttributes = "";

            // Retailer_Name
            Retailer_Name.ViewValue = ConvertToString(Retailer_Name.CurrentValue); // DN
            Retailer_Name.ViewCustomAttributes = "";

            // DatePurchased
            DatePurchased.ViewValue = DatePurchased.CurrentValue;
            DatePurchased.ViewValue = FormatDateTime(DatePurchased.ViewValue, DatePurchased.FormatPattern);
            DatePurchased.ViewCustomAttributes = "";

            // ServiceInception_Date
            ServiceInception_Date.ViewValue = ServiceInception_Date.CurrentValue;
            ServiceInception_Date.ViewValue = FormatDateTime(ServiceInception_Date.ViewValue, ServiceInception_Date.FormatPattern);
            ServiceInception_Date.ViewCustomAttributes = "";

            // UsefulLife
            UsefulLife.ViewValue = UsefulLife.CurrentValue;
            UsefulLife.ViewValue = FormatNumber(UsefulLife.ViewValue, UsefulLife.FormatPattern);
            UsefulLife.ViewCustomAttributes = "";

            // Price
            Price.ViewValue = Price.CurrentValue;
            Price.ViewValue = FormatNumber(Price.ViewValue, Price.FormatPattern);
            Price.ViewCustomAttributes = "";

            // VAT
            VAT.ViewValue = VAT.CurrentValue;
            VAT.ViewValue = FormatNumber(VAT.ViewValue, VAT.FormatPattern);
            VAT.ViewCustomAttributes = "";

            // Creation_Date
            Creation_Date.ViewValue = Creation_Date.CurrentValue;
            Creation_Date.ViewValue = FormatDateTime(Creation_Date.ViewValue, Creation_Date.FormatPattern);
            Creation_Date.ViewCustomAttributes = "";

            // Modified_Date
            Modified_Date.ViewValue = Modified_Date.CurrentValue;
            Modified_Date.ViewValue = FormatDateTime(Modified_Date.ViewValue, Modified_Date.FormatPattern);
            Modified_Date.ViewCustomAttributes = "";

            // Created_by
            Created_by.ViewValue = Created_by.CurrentValue;
            Created_by.ViewCustomAttributes = "";

            // Modified_by
            Modified_by.ViewValue = Modified_by.CurrentValue;
            Modified_by.ViewCustomAttributes = "";

            // Equipment_ID
            Equipment_ID.HrefValue = "";
            Equipment_ID.TooltipValue = "";

            // int_Location
            int_Location.HrefValue = "";
            int_Location.TooltipValue = "";

            // Equipment_Type_ID
            Equipment_Type_ID.HrefValue = "";
            Equipment_Type_ID.TooltipValue = "";

            // Equipment_Type_Name
            Equipment_Type_Name.HrefValue = "";
            Equipment_Type_Name.TooltipValue = "";

            // Manufacturer_Name
            Manufacturer_Name.HrefValue = "";
            Manufacturer_Name.TooltipValue = "";

            // Serial_VIN_Number
            Serial_VIN_Number.HrefValue = "";
            Serial_VIN_Number.TooltipValue = "";

            // Retailer_Name
            Retailer_Name.HrefValue = "";
            Retailer_Name.TooltipValue = "";

            // DatePurchased
            DatePurchased.HrefValue = "";
            DatePurchased.TooltipValue = "";

            // ServiceInception_Date
            ServiceInception_Date.HrefValue = "";
            ServiceInception_Date.TooltipValue = "";

            // UsefulLife
            UsefulLife.HrefValue = "";
            UsefulLife.TooltipValue = "";

            // Price
            Price.HrefValue = "";
            Price.TooltipValue = "";

            // VAT
            VAT.HrefValue = "";
            VAT.TooltipValue = "";

            // Creation_Date
            Creation_Date.HrefValue = "";
            Creation_Date.TooltipValue = "";

            // Modified_Date
            Modified_Date.HrefValue = "";
            Modified_Date.TooltipValue = "";

            // Created_by
            Created_by.HrefValue = "";
            Created_by.TooltipValue = "";

            // Modified_by
            Modified_by.HrefValue = "";
            Modified_by.TooltipValue = "";

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

            // Equipment_ID
            Equipment_ID.SetupEditAttributes();
            Equipment_ID.EditValue = Equipment_ID.CurrentValue;
            Equipment_ID.ViewCustomAttributes = "";

            // int_Location
            int_Location.SetupEditAttributes();
            int_Location.PlaceHolder = RemoveHtml(int_Location.Caption);
            if (!Empty(int_Location.EditValue) && IsNumeric(int_Location.EditValue))
                int_Location.EditValue = FormatNumber(int_Location.EditValue, null);

            // Equipment_Type_ID
            Equipment_Type_ID.SetupEditAttributes();
            Equipment_Type_ID.EditValue = Equipment_Type_ID.Options(true);
            Equipment_Type_ID.PlaceHolder = RemoveHtml(Equipment_Type_ID.Caption);
            if (!Empty(Equipment_Type_ID.EditValue) && IsNumeric(Equipment_Type_ID.EditValue))
                Equipment_Type_ID.EditValue = FormatNumber(Equipment_Type_ID.EditValue, null);

            // Equipment_Type_Name
            Equipment_Type_Name.SetupEditAttributes();
            if (!Equipment_Type_Name.Raw)
                Equipment_Type_Name.CurrentValue = HtmlDecode(Equipment_Type_Name.CurrentValue);
            Equipment_Type_Name.EditValue = HtmlEncode(Equipment_Type_Name.CurrentValue);
            Equipment_Type_Name.PlaceHolder = RemoveHtml(Equipment_Type_Name.Caption);

            // Manufacturer_Name
            Manufacturer_Name.SetupEditAttributes();
            if (!Manufacturer_Name.Raw)
                Manufacturer_Name.CurrentValue = HtmlDecode(Manufacturer_Name.CurrentValue);
            Manufacturer_Name.EditValue = HtmlEncode(Manufacturer_Name.CurrentValue);
            Manufacturer_Name.PlaceHolder = RemoveHtml(Manufacturer_Name.Caption);

            // Serial_VIN_Number
            Serial_VIN_Number.SetupEditAttributes();
            if (!Serial_VIN_Number.Raw)
                Serial_VIN_Number.CurrentValue = HtmlDecode(Serial_VIN_Number.CurrentValue);
            Serial_VIN_Number.EditValue = HtmlEncode(Serial_VIN_Number.CurrentValue);
            Serial_VIN_Number.PlaceHolder = RemoveHtml(Serial_VIN_Number.Caption);

            // Retailer_Name
            Retailer_Name.SetupEditAttributes();
            if (!Retailer_Name.Raw)
                Retailer_Name.CurrentValue = HtmlDecode(Retailer_Name.CurrentValue);
            Retailer_Name.EditValue = HtmlEncode(Retailer_Name.CurrentValue);
            Retailer_Name.PlaceHolder = RemoveHtml(Retailer_Name.Caption);

            // DatePurchased
            DatePurchased.SetupEditAttributes();
            DatePurchased.EditValue = FormatDateTime(DatePurchased.CurrentValue, DatePurchased.FormatPattern); // DN
            DatePurchased.PlaceHolder = RemoveHtml(DatePurchased.Caption);

            // ServiceInception_Date
            ServiceInception_Date.SetupEditAttributes();
            ServiceInception_Date.EditValue = FormatDateTime(ServiceInception_Date.CurrentValue, ServiceInception_Date.FormatPattern); // DN
            ServiceInception_Date.PlaceHolder = RemoveHtml(ServiceInception_Date.Caption);

            // UsefulLife
            UsefulLife.SetupEditAttributes();
            UsefulLife.EditValue = UsefulLife.CurrentValue; // DN
            UsefulLife.PlaceHolder = RemoveHtml(UsefulLife.Caption);
            if (!Empty(UsefulLife.EditValue) && IsNumeric(UsefulLife.EditValue))
                UsefulLife.EditValue = FormatNumber(UsefulLife.EditValue, null);

            // Price
            Price.SetupEditAttributes();
            Price.EditValue = Price.CurrentValue; // DN
            Price.PlaceHolder = RemoveHtml(Price.Caption);
            if (!Empty(Price.EditValue) && IsNumeric(Price.EditValue))
                Price.EditValue = FormatNumber(Price.EditValue, null);

            // VAT
            VAT.SetupEditAttributes();
            VAT.EditValue = VAT.CurrentValue; // DN
            VAT.PlaceHolder = RemoveHtml(VAT.Caption);
            if (!Empty(VAT.EditValue) && IsNumeric(VAT.EditValue))
                VAT.EditValue = FormatNumber(VAT.EditValue, null);

            // Creation_Date

            // Modified_Date

            // Created_by

            // Modified_by

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
                        doc.ExportCaption(int_Location);
                        doc.ExportCaption(Equipment_Type_ID);
                        doc.ExportCaption(Equipment_Type_Name);
                        doc.ExportCaption(Manufacturer_Name);
                        doc.ExportCaption(Serial_VIN_Number);
                        doc.ExportCaption(Retailer_Name);
                        doc.ExportCaption(DatePurchased);
                        doc.ExportCaption(ServiceInception_Date);
                        doc.ExportCaption(UsefulLife);
                        doc.ExportCaption(Price);
                        doc.ExportCaption(VAT);
                        doc.ExportCaption(Creation_Date);
                        doc.ExportCaption(Modified_Date);
                        doc.ExportCaption(Created_by);
                        doc.ExportCaption(Modified_by);
                    } else {
                        doc.ExportCaption(Equipment_ID);
                        doc.ExportCaption(int_Location);
                        doc.ExportCaption(Equipment_Type_ID);
                        doc.ExportCaption(Equipment_Type_Name);
                        doc.ExportCaption(Manufacturer_Name);
                        doc.ExportCaption(Serial_VIN_Number);
                        doc.ExportCaption(Retailer_Name);
                        doc.ExportCaption(DatePurchased);
                        doc.ExportCaption(ServiceInception_Date);
                        doc.ExportCaption(UsefulLife);
                        doc.ExportCaption(Price);
                        doc.ExportCaption(VAT);
                        doc.ExportCaption(Creation_Date);
                        doc.ExportCaption(Modified_Date);
                        doc.ExportCaption(Created_by);
                        doc.ExportCaption(Modified_by);
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
                            await doc.ExportField(int_Location);
                            await doc.ExportField(Equipment_Type_ID);
                            await doc.ExportField(Equipment_Type_Name);
                            await doc.ExportField(Manufacturer_Name);
                            await doc.ExportField(Serial_VIN_Number);
                            await doc.ExportField(Retailer_Name);
                            await doc.ExportField(DatePurchased);
                            await doc.ExportField(ServiceInception_Date);
                            await doc.ExportField(UsefulLife);
                            await doc.ExportField(Price);
                            await doc.ExportField(VAT);
                            await doc.ExportField(Creation_Date);
                            await doc.ExportField(Modified_Date);
                            await doc.ExportField(Created_by);
                            await doc.ExportField(Modified_by);
                        } else {
                            await doc.ExportField(Equipment_ID);
                            await doc.ExportField(int_Location);
                            await doc.ExportField(Equipment_Type_ID);
                            await doc.ExportField(Equipment_Type_Name);
                            await doc.ExportField(Manufacturer_Name);
                            await doc.ExportField(Serial_VIN_Number);
                            await doc.ExportField(Retailer_Name);
                            await doc.ExportField(DatePurchased);
                            await doc.ExportField(ServiceInception_Date);
                            await doc.ExportField(UsefulLife);
                            await doc.ExportField(Price);
                            await doc.ExportField(VAT);
                            await doc.ExportField(Creation_Date);
                            await doc.ExportField(Modified_Date);
                            await doc.ExportField(Created_by);
                            await doc.ExportField(Modified_by);
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
