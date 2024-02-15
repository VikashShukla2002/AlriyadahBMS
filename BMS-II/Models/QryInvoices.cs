namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// qryInvoices
    /// </summary>
    [MaybeNull]
    public static QryInvoices qryInvoices
    {
        get => HttpData.Resolve<QryInvoices>("qryInvoices");
        set => HttpData["qryInvoices"] = value;
    }

    /// <summary>
    /// Table class for qryInvoices
    /// </summary>
    public class QryInvoices : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> str_First_Name;

        public readonly DbField<SqlDbType> str_Middle_Name;

        public readonly DbField<SqlDbType> str_Last_Name;

        public readonly DbField<SqlDbType> str_Cell_Phone;

        public readonly DbField<SqlDbType> NationalID;

        public readonly DbField<SqlDbType> Required_Program;

        public readonly DbField<SqlDbType> Course_Price;

        public readonly DbField<SqlDbType> Vat_Tax_15;

        public readonly DbField<SqlDbType> Total_Price;

        public readonly DbField<SqlDbType> str_ApprovalCode;

        public readonly DbField<SqlDbType> str_Amount_Pay;

        public readonly DbField<SqlDbType> date_Paid;

        public readonly DbField<SqlDbType> int_Package_ID;

        public readonly DbField<SqlDbType> Invoice_Nbr;

        public readonly DbField<SqlDbType> InvoiceDate;

        public readonly DbField<SqlDbType> Price;

        // Constructor
        public QryInvoices()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "qryInvoices";
            Name = "qryInvoices";
            Type = "VIEW";
            UpdateTable = "dbo.qryInvoices"; // Update Table
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
                CustomMessage = Language.FieldPhrase("qryInvoices", "str_First_Name", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("qryInvoices", "str_Middle_Name", "CustomMsg"),
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
                CustomMessage = Language.FieldPhrase("qryInvoices", "str_Last_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Last_Name", str_Last_Name);

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
                CustomMessage = Language.FieldPhrase("qryInvoices", "str_Cell_Phone", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Cell_Phone", str_Cell_Phone);

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
                CustomMessage = Language.FieldPhrase("qryInvoices", "NationalID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("NationalID", NationalID);

            // Required_Program
            Required_Program = new (this, "x_Required_Program", 202, SqlDbType.NVarChar) {
                Name = "Required_Program",
                Expression = "[Required_Program]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Required_Program]",
                DateTimeFormat = -1,
                VirtualExpression = "[Required_Program]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryInvoices", "Required_Program", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Required_Program", Required_Program);

            // Course_Price
            Course_Price = new (this, "x_Course_Price", 131, SqlDbType.Decimal) {
                Name = "Course_Price",
                Expression = "[Course_Price]",
                BasicSearchExpression = "CAST([Course_Price] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Course_Price]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryInvoices", "Course_Price", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Course_Price", Course_Price);

            // Vat_Tax_15
            Vat_Tax_15 = new (this, "x_Vat_Tax_15", 131, SqlDbType.Decimal) {
                Name = "Vat_Tax_15",
                Expression = "[Vat_Tax_15]",
                BasicSearchExpression = "CAST([Vat_Tax_15] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Vat_Tax_15]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryInvoices", "Vat_Tax_15", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Vat_Tax_15", Vat_Tax_15);

            // Total_Price
            Total_Price = new (this, "x_Total_Price", 131, SqlDbType.Decimal) {
                Name = "Total_Price",
                Expression = "[Total_Price]",
                BasicSearchExpression = "CAST([Total_Price] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[Total_Price]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectFloat"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryInvoices", "Total_Price", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Total_Price", Total_Price);

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
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryInvoices", "str_ApprovalCode", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_ApprovalCode", str_ApprovalCode);

            // str_Amount_Pay
            str_Amount_Pay = new (this, "x_str_Amount_Pay", 200, SqlDbType.VarChar) {
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
                CustomMessage = Language.FieldPhrase("qryInvoices", "str_Amount_Pay", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Amount_Pay", str_Amount_Pay);

            // date_Paid
            date_Paid = new (this, "x_date_Paid", 135, SqlDbType.DateTime) {
                Name = "date_Paid",
                Expression = "[date_Paid]",
                BasicSearchExpression = CastDateFieldForLike("[date_Paid]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[date_Paid]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryInvoices", "date_Paid", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Paid", date_Paid);

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
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryInvoices", "int_Package_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Package_ID", int_Package_ID);

            // Invoice_Nbr
            Invoice_Nbr = new (this, "x_Invoice_Nbr", 202, SqlDbType.NVarChar) {
                Name = "Invoice_Nbr",
                Expression = "[Invoice_Nbr]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Invoice_Nbr]",
                DateTimeFormat = -1,
                VirtualExpression = "[Invoice_Nbr]",
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
                CustomMessage = Language.FieldPhrase("qryInvoices", "Invoice_Nbr", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Invoice_Nbr", Invoice_Nbr);

            // Invoice Date
            InvoiceDate = new (this, "x_InvoiceDate", 202, SqlDbType.NVarChar) {
                Name = "Invoice Date",
                Expression = "[Invoice Date]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Invoice Date]",
                DateTimeFormat = -1,
                VirtualExpression = "[Invoice Date]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryInvoices", "InvoiceDate", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Invoice Date", InvoiceDate);

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
                CustomMessage = Language.FieldPhrase("qryInvoices", "Price", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Price", Price);

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
            get => _sqlFrom ?? "dbo.qryInvoices";
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
                str_First_Name.DbValue = row["str_First_Name"]; // Set DB value only
                str_Middle_Name.DbValue = row["str_Middle_Name"]; // Set DB value only
                str_Last_Name.DbValue = row["str_Last_Name"]; // Set DB value only
                str_Cell_Phone.DbValue = row["str_Cell_Phone"]; // Set DB value only
                NationalID.DbValue = row["NationalID"]; // Set DB value only
                Required_Program.DbValue = row["Required_Program"]; // Set DB value only
                Course_Price.DbValue = row["Course_Price"]; // Set DB value only
                Vat_Tax_15.DbValue = row["Vat_Tax_15"]; // Set DB value only
                Total_Price.DbValue = row["Total_Price"]; // Set DB value only
                str_ApprovalCode.DbValue = row["str_ApprovalCode"]; // Set DB value only
                str_Amount_Pay.DbValue = row["str_Amount_Pay"]; // Set DB value only
                date_Paid.DbValue = row["date_Paid"]; // Set DB value only
                int_Package_ID.DbValue = row["int_Package_ID"]; // Set DB value only
                Invoice_Nbr.DbValue = row["Invoice_Nbr"]; // Set DB value only
                InvoiceDate.DbValue = row["Invoice Date"]; // Set DB value only
                Price.DbValue = row["Price"]; // Set DB value only
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
                    return "QryInvoicesList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "QryInvoicesView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "QryInvoicesEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "QryInvoicesAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "QryInvoicesList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "QryInvoicesView",
                Config.ApiAddAction => "QryInvoicesAdd",
                Config.ApiEditAction => "QryInvoicesEdit",
                Config.ApiDeleteAction => "QryInvoicesDelete",
                Config.ApiListAction => "QryInvoicesList",
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
        public string ListUrl => "QryInvoicesList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("QryInvoicesView", parm);
            else
                url = KeyUrl("QryInvoicesView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "QryInvoicesAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "QryInvoicesAdd?" + parm;
            else
                url = "QryInvoicesAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("QryInvoicesEdit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("QryInvoicesList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("QryInvoicesAdd", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("QryInvoicesList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("QryInvoicesDelete")); // DN

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
            str_First_Name.SetDbValue(dr["str_First_Name"]);
            str_Middle_Name.SetDbValue(dr["str_Middle_Name"]);
            str_Last_Name.SetDbValue(dr["str_Last_Name"]);
            str_Cell_Phone.SetDbValue(dr["str_Cell_Phone"]);
            NationalID.SetDbValue(dr["NationalID"]);
            Required_Program.SetDbValue(dr["Required_Program"]);
            Course_Price.SetDbValue(dr["Course_Price"]);
            Vat_Tax_15.SetDbValue(dr["Vat_Tax_15"]);
            Total_Price.SetDbValue(dr["Total_Price"]);
            str_ApprovalCode.SetDbValue(dr["str_ApprovalCode"]);
            str_Amount_Pay.SetDbValue(dr["str_Amount_Pay"]);
            date_Paid.SetDbValue(dr["date_Paid"]);
            int_Package_ID.SetDbValue(dr["int_Package_ID"]);
            Invoice_Nbr.SetDbValue(dr["Invoice_Nbr"]);
            InvoiceDate.SetDbValue(dr["Invoice Date"]);
            Price.SetDbValue(dr["Price"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "QryInvoicesList";
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

            // str_First_Name

            // str_Middle_Name

            // str_Last_Name

            // str_Cell_Phone

            // NationalID

            // Required_Program

            // Course_Price

            // Vat_Tax_15

            // Total_Price

            // str_ApprovalCode

            // str_Amount_Pay

            // date_Paid

            // int_Package_ID

            // Invoice_Nbr

            // Invoice Date

            // Price

            // str_First_Name
            str_First_Name.ViewValue = ConvertToString(str_First_Name.CurrentValue); // DN
            str_First_Name.ViewCustomAttributes = "";

            // str_Middle_Name
            str_Middle_Name.ViewValue = ConvertToString(str_Middle_Name.CurrentValue); // DN
            str_Middle_Name.ViewCustomAttributes = "";

            // str_Last_Name
            str_Last_Name.ViewValue = ConvertToString(str_Last_Name.CurrentValue); // DN
            str_Last_Name.ViewCustomAttributes = "";

            // str_Cell_Phone
            str_Cell_Phone.ViewValue = ConvertToString(str_Cell_Phone.CurrentValue); // DN
            str_Cell_Phone.ViewCustomAttributes = "";

            // NationalID
            NationalID.ViewValue = NationalID.CurrentValue;
            NationalID.ViewValue = FormatNumber(NationalID.ViewValue, NationalID.FormatPattern);
            NationalID.ViewCustomAttributes = "";

            // Required_Program
            Required_Program.ViewValue = ConvertToString(Required_Program.CurrentValue); // DN
            Required_Program.ViewCustomAttributes = "";

            // Course_Price
            Course_Price.ViewValue = Course_Price.CurrentValue;
            Course_Price.ViewValue = FormatNumber(Course_Price.ViewValue, Course_Price.FormatPattern);
            Course_Price.ViewCustomAttributes = "";

            // Vat_Tax_15
            Vat_Tax_15.ViewValue = Vat_Tax_15.CurrentValue;
            Vat_Tax_15.ViewValue = FormatNumber(Vat_Tax_15.ViewValue, Vat_Tax_15.FormatPattern);
            Vat_Tax_15.ViewCustomAttributes = "";

            // Total_Price
            Total_Price.ViewValue = Total_Price.CurrentValue;
            Total_Price.ViewValue = FormatNumber(Total_Price.ViewValue, Total_Price.FormatPattern);
            Total_Price.ViewCustomAttributes = "";

            // str_ApprovalCode
            str_ApprovalCode.ViewValue = ConvertToString(str_ApprovalCode.CurrentValue); // DN
            str_ApprovalCode.ViewCustomAttributes = "";

            // str_Amount_Pay
            str_Amount_Pay.ViewValue = ConvertToString(str_Amount_Pay.CurrentValue); // DN
            str_Amount_Pay.ViewCustomAttributes = "";

            // date_Paid
            date_Paid.ViewValue = date_Paid.CurrentValue;
            date_Paid.ViewValue = FormatDateTime(date_Paid.ViewValue, date_Paid.FormatPattern);
            date_Paid.ViewCustomAttributes = "";

            // int_Package_ID
            int_Package_ID.ViewValue = int_Package_ID.CurrentValue;
            int_Package_ID.ViewValue = FormatNumber(int_Package_ID.ViewValue, int_Package_ID.FormatPattern);
            int_Package_ID.ViewCustomAttributes = "";

            // Invoice_Nbr
            Invoice_Nbr.ViewValue = ConvertToString(Invoice_Nbr.CurrentValue); // DN
            Invoice_Nbr.ViewCustomAttributes = "";

            // Invoice Date
            InvoiceDate.ViewValue = ConvertToString(InvoiceDate.CurrentValue); // DN
            InvoiceDate.ViewCustomAttributes = "";

            // Price
            Price.ViewValue = Price.CurrentValue;
            Price.ViewValue = FormatNumber(Price.ViewValue, Price.FormatPattern);
            Price.ViewCustomAttributes = "";

            // str_First_Name
            str_First_Name.HrefValue = "";
            str_First_Name.TooltipValue = "";

            // str_Middle_Name
            str_Middle_Name.HrefValue = "";
            str_Middle_Name.TooltipValue = "";

            // str_Last_Name
            str_Last_Name.HrefValue = "";
            str_Last_Name.TooltipValue = "";

            // str_Cell_Phone
            str_Cell_Phone.HrefValue = "";
            str_Cell_Phone.TooltipValue = "";

            // NationalID
            NationalID.HrefValue = "";
            NationalID.TooltipValue = "";

            // Required_Program
            Required_Program.HrefValue = "";
            Required_Program.TooltipValue = "";

            // Course_Price
            Course_Price.HrefValue = "";
            Course_Price.TooltipValue = "";

            // Vat_Tax_15
            Vat_Tax_15.HrefValue = "";
            Vat_Tax_15.TooltipValue = "";

            // Total_Price
            Total_Price.HrefValue = "";
            Total_Price.TooltipValue = "";

            // str_ApprovalCode
            str_ApprovalCode.HrefValue = "";
            str_ApprovalCode.TooltipValue = "";

            // str_Amount_Pay
            str_Amount_Pay.HrefValue = "";
            str_Amount_Pay.TooltipValue = "";

            // date_Paid
            date_Paid.HrefValue = "";
            date_Paid.TooltipValue = "";

            // int_Package_ID
            int_Package_ID.HrefValue = "";
            int_Package_ID.TooltipValue = "";

            // Invoice_Nbr
            Invoice_Nbr.HrefValue = "";
            Invoice_Nbr.TooltipValue = "";

            // Invoice Date
            InvoiceDate.HrefValue = "";
            InvoiceDate.TooltipValue = "";

            // Price
            Price.HrefValue = "";
            Price.TooltipValue = "";

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

            // str_Cell_Phone
            str_Cell_Phone.SetupEditAttributes();
            if (!str_Cell_Phone.Raw)
                str_Cell_Phone.CurrentValue = HtmlDecode(str_Cell_Phone.CurrentValue);
            str_Cell_Phone.EditValue = HtmlEncode(str_Cell_Phone.CurrentValue);
            str_Cell_Phone.PlaceHolder = RemoveHtml(str_Cell_Phone.Caption);

            // NationalID
            NationalID.SetupEditAttributes();
            NationalID.EditValue = NationalID.CurrentValue; // DN
            NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);
            if (!Empty(NationalID.EditValue) && IsNumeric(NationalID.EditValue))
                NationalID.EditValue = FormatNumber(NationalID.EditValue, null);

            // Required_Program
            Required_Program.SetupEditAttributes();
            if (!Required_Program.Raw)
                Required_Program.CurrentValue = HtmlDecode(Required_Program.CurrentValue);
            Required_Program.EditValue = HtmlEncode(Required_Program.CurrentValue);
            Required_Program.PlaceHolder = RemoveHtml(Required_Program.Caption);

            // Course_Price
            Course_Price.SetupEditAttributes();
            Course_Price.EditValue = Course_Price.CurrentValue; // DN
            Course_Price.PlaceHolder = RemoveHtml(Course_Price.Caption);
            if (!Empty(Course_Price.EditValue) && IsNumeric(Course_Price.EditValue))
                Course_Price.EditValue = FormatNumber(Course_Price.EditValue, null);

            // Vat_Tax_15
            Vat_Tax_15.SetupEditAttributes();
            Vat_Tax_15.EditValue = Vat_Tax_15.CurrentValue; // DN
            Vat_Tax_15.PlaceHolder = RemoveHtml(Vat_Tax_15.Caption);
            if (!Empty(Vat_Tax_15.EditValue) && IsNumeric(Vat_Tax_15.EditValue))
                Vat_Tax_15.EditValue = FormatNumber(Vat_Tax_15.EditValue, null);

            // Total_Price
            Total_Price.SetupEditAttributes();
            Total_Price.EditValue = Total_Price.CurrentValue; // DN
            Total_Price.PlaceHolder = RemoveHtml(Total_Price.Caption);
            if (!Empty(Total_Price.EditValue) && IsNumeric(Total_Price.EditValue))
                Total_Price.EditValue = FormatNumber(Total_Price.EditValue, null);

            // str_ApprovalCode
            str_ApprovalCode.SetupEditAttributes();
            if (!str_ApprovalCode.Raw)
                str_ApprovalCode.CurrentValue = HtmlDecode(str_ApprovalCode.CurrentValue);
            str_ApprovalCode.EditValue = HtmlEncode(str_ApprovalCode.CurrentValue);
            str_ApprovalCode.PlaceHolder = RemoveHtml(str_ApprovalCode.Caption);

            // str_Amount_Pay
            str_Amount_Pay.SetupEditAttributes();
            if (!str_Amount_Pay.Raw)
                str_Amount_Pay.CurrentValue = HtmlDecode(str_Amount_Pay.CurrentValue);
            str_Amount_Pay.EditValue = HtmlEncode(str_Amount_Pay.CurrentValue);
            str_Amount_Pay.PlaceHolder = RemoveHtml(str_Amount_Pay.Caption);

            // date_Paid
            date_Paid.SetupEditAttributes();
            date_Paid.EditValue = FormatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern); // DN
            date_Paid.PlaceHolder = RemoveHtml(date_Paid.Caption);

            // int_Package_ID
            int_Package_ID.SetupEditAttributes();
            int_Package_ID.EditValue = int_Package_ID.CurrentValue; // DN
            int_Package_ID.PlaceHolder = RemoveHtml(int_Package_ID.Caption);
            if (!Empty(int_Package_ID.EditValue) && IsNumeric(int_Package_ID.EditValue))
                int_Package_ID.EditValue = FormatNumber(int_Package_ID.EditValue, null);

            // Invoice_Nbr
            Invoice_Nbr.SetupEditAttributes();
            if (!Invoice_Nbr.Raw)
                Invoice_Nbr.CurrentValue = HtmlDecode(Invoice_Nbr.CurrentValue);
            Invoice_Nbr.EditValue = HtmlEncode(Invoice_Nbr.CurrentValue);
            Invoice_Nbr.PlaceHolder = RemoveHtml(Invoice_Nbr.Caption);

            // Invoice Date
            InvoiceDate.SetupEditAttributes();
            if (!InvoiceDate.Raw)
                InvoiceDate.CurrentValue = HtmlDecode(InvoiceDate.CurrentValue);
            InvoiceDate.EditValue = HtmlEncode(InvoiceDate.CurrentValue);
            InvoiceDate.PlaceHolder = RemoveHtml(InvoiceDate.Caption);

            // Price
            Price.SetupEditAttributes();
            Price.EditValue = Price.CurrentValue; // DN
            Price.PlaceHolder = RemoveHtml(Price.Caption);
            if (!Empty(Price.EditValue) && IsNumeric(Price.EditValue))
                Price.EditValue = FormatNumber(Price.EditValue, null);

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
                        doc.ExportCaption(str_First_Name);
                        doc.ExportCaption(str_Middle_Name);
                        doc.ExportCaption(str_Last_Name);
                        doc.ExportCaption(str_Cell_Phone);
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(Required_Program);
                        doc.ExportCaption(Course_Price);
                        doc.ExportCaption(Vat_Tax_15);
                        doc.ExportCaption(Total_Price);
                        doc.ExportCaption(str_ApprovalCode);
                        doc.ExportCaption(str_Amount_Pay);
                        doc.ExportCaption(date_Paid);
                        doc.ExportCaption(int_Package_ID);
                        doc.ExportCaption(Invoice_Nbr);
                        doc.ExportCaption(InvoiceDate);
                        doc.ExportCaption(Price);
                    } else {
                        doc.ExportCaption(str_First_Name);
                        doc.ExportCaption(str_Middle_Name);
                        doc.ExportCaption(str_Last_Name);
                        doc.ExportCaption(str_Cell_Phone);
                        doc.ExportCaption(NationalID);
                        doc.ExportCaption(Required_Program);
                        doc.ExportCaption(Course_Price);
                        doc.ExportCaption(Vat_Tax_15);
                        doc.ExportCaption(Total_Price);
                        doc.ExportCaption(str_ApprovalCode);
                        doc.ExportCaption(str_Amount_Pay);
                        doc.ExportCaption(date_Paid);
                        doc.ExportCaption(int_Package_ID);
                        doc.ExportCaption(Invoice_Nbr);
                        doc.ExportCaption(InvoiceDate);
                        doc.ExportCaption(Price);
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
                            await doc.ExportField(str_First_Name);
                            await doc.ExportField(str_Middle_Name);
                            await doc.ExportField(str_Last_Name);
                            await doc.ExportField(str_Cell_Phone);
                            await doc.ExportField(NationalID);
                            await doc.ExportField(Required_Program);
                            await doc.ExportField(Course_Price);
                            await doc.ExportField(Vat_Tax_15);
                            await doc.ExportField(Total_Price);
                            await doc.ExportField(str_ApprovalCode);
                            await doc.ExportField(str_Amount_Pay);
                            await doc.ExportField(date_Paid);
                            await doc.ExportField(int_Package_ID);
                            await doc.ExportField(Invoice_Nbr);
                            await doc.ExportField(InvoiceDate);
                            await doc.ExportField(Price);
                        } else {
                            await doc.ExportField(str_First_Name);
                            await doc.ExportField(str_Middle_Name);
                            await doc.ExportField(str_Last_Name);
                            await doc.ExportField(str_Cell_Phone);
                            await doc.ExportField(NationalID);
                            await doc.ExportField(Required_Program);
                            await doc.ExportField(Course_Price);
                            await doc.ExportField(Vat_Tax_15);
                            await doc.ExportField(Total_Price);
                            await doc.ExportField(str_ApprovalCode);
                            await doc.ExportField(str_Amount_Pay);
                            await doc.ExportField(date_Paid);
                            await doc.ExportField(int_Package_ID);
                            await doc.ExportField(Invoice_Nbr);
                            await doc.ExportField(InvoiceDate);
                            await doc.ExportField(Price);
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
