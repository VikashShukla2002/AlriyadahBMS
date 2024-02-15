namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// qryClassSchedule
    /// </summary>
    [MaybeNull]
    public static QryClassSchedule qryClassSchedule
    {
        get => HttpData.Resolve<QryClassSchedule>("qryClassSchedule");
        set => HttpData["qryClassSchedule"] = value;
    }

    /// <summary>
    /// Table class for qryClassSchedule
    /// </summary>
    public class QryClassSchedule : DbTable, IQueryFactory
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

        public readonly DbField<SqlDbType> int_CR_ID;

        public readonly DbField<SqlDbType> int_CR_Product_ID;

        public readonly DbField<SqlDbType> int_TotSession;

        public readonly DbField<SqlDbType> str_Username;

        public readonly DbField<SqlDbType> int_Session_ID;

        public readonly DbField<SqlDbType> date_Start;

        public readonly DbField<SqlDbType> int_Status;

        public readonly DbField<SqlDbType> str_Session_Date;

        public readonly DbField<SqlDbType> Instructor;

        public readonly DbField<SqlDbType> Location;

        public readonly DbField<SqlDbType> str_Package_Name;

        public readonly DbField<SqlDbType> str_Day_Name;

        public readonly DbField<SqlDbType> str_CR_Number;

        public readonly DbField<SqlDbType> str_CRSS_ID;

        // Constructor
        public QryClassSchedule()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "qryClassSchedule";
            Name = "qryClassSchedule";
            Type = "VIEW";
            UpdateTable = "dbo.qryClassSchedule"; // Update Table
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

            // int_CR_ID
            int_CR_ID = new (this, "x_int_CR_ID", 3, SqlDbType.Int) {
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
                HtmlTag = "TEXT",
                InputTextType = "text",
                IsPrimaryKey = true, // Primary key field
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("qryClassSchedule", "int_CR_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CR_ID", int_CR_ID);

            // int_CR_Product_ID
            int_CR_Product_ID = new (this, "x_int_CR_Product_ID", 3, SqlDbType.Int) {
                Name = "int_CR_Product_ID",
                Expression = "[int_CR_Product_ID]",
                BasicSearchExpression = "CAST([int_CR_Product_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_CR_Product_ID]",
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
                CustomMessage = Language.FieldPhrase("qryClassSchedule", "int_CR_Product_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_CR_Product_ID", int_CR_Product_ID);

            // int_TotSession
            int_TotSession = new (this, "x_int_TotSession", 3, SqlDbType.Int) {
                Name = "int_TotSession",
                Expression = "[int_TotSession]",
                BasicSearchExpression = "CAST([int_TotSession] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_TotSession]",
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
                CustomMessage = Language.FieldPhrase("qryClassSchedule", "int_TotSession", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_TotSession", int_TotSession);

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
                CustomMessage = Language.FieldPhrase("qryClassSchedule", "str_Username", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Username", str_Username);

            // int_Session_ID
            int_Session_ID = new (this, "x_int_Session_ID", 20, SqlDbType.BigInt) {
                Name = "int_Session_ID",
                Expression = "[int_Session_ID]",
                BasicSearchExpression = "CAST([int_Session_ID] AS NVARCHAR)",
                DateTimeFormat = -1,
                VirtualExpression = "[int_Session_ID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryClassSchedule", "int_Session_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Session_ID", int_Session_ID);

            // date_Start
            date_Start = new (this, "x_date_Start", 135, SqlDbType.DateTime) {
                Name = "date_Start",
                Expression = "[date_Start]",
                BasicSearchExpression = CastDateFieldForLike("[date_Start]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[date_Start]",
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
                CustomMessage = Language.FieldPhrase("qryClassSchedule", "date_Start", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("date_Start", date_Start);

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
                CustomMessage = Language.FieldPhrase("qryClassSchedule", "int_Status", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("int_Status", int_Status);

            // str_Session_Date
            str_Session_Date = new (this, "x_str_Session_Date", 135, SqlDbType.DateTime) {
                Name = "str_Session_Date",
                Expression = "[str_Session_Date]",
                BasicSearchExpression = CastDateFieldForLike("[str_Session_Date]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[str_Session_Date]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryClassSchedule", "str_Session_Date", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Session_Date", str_Session_Date);

            // Instructor
            Instructor = new (this, "x_Instructor", 202, SqlDbType.NVarChar) {
                Name = "Instructor",
                Expression = "[Instructor]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Instructor]",
                DateTimeFormat = -1,
                VirtualExpression = "[Instructor]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryClassSchedule", "Instructor", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Instructor", Instructor);

            // Location
            Location = new (this, "x_Location", 202, SqlDbType.NVarChar) {
                Name = "Location",
                Expression = "[Location]",
                UseBasicSearch = true,
                BasicSearchExpression = "[Location]",
                DateTimeFormat = -1,
                VirtualExpression = "[Location]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryClassSchedule", "Location", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("Location", Location);

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
                CustomMessage = Language.FieldPhrase("qryClassSchedule", "str_Package_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Package_Name", str_Package_Name);

            // str_Day_Name
            str_Day_Name = new (this, "x_str_Day_Name", 202, SqlDbType.NVarChar) {
                Name = "str_Day_Name",
                Expression = "[str_Day_Name]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_Day_Name]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_Day_Name]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryClassSchedule", "str_Day_Name", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_Day_Name", str_Day_Name);

            // str_CR_Number
            str_CR_Number = new (this, "x_str_CR_Number", 202, SqlDbType.NVarChar) {
                Name = "str_CR_Number",
                Expression = "[str_CR_Number]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_CR_Number]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CR_Number]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryClassSchedule", "str_CR_Number", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CR_Number", str_CR_Number);

            // str_CRSS_ID
            str_CRSS_ID = new (this, "x_str_CRSS_ID", 202, SqlDbType.NVarChar) {
                Name = "str_CRSS_ID",
                Expression = "[str_CRSS_ID]",
                UseBasicSearch = true,
                BasicSearchExpression = "[str_CRSS_ID]",
                DateTimeFormat = -1,
                VirtualExpression = "[str_CRSS_ID]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("qryClassSchedule", "str_CRSS_ID", "CustomMsg"),
                IsUpload = false
            };
            Fields.Add("str_CRSS_ID", str_CRSS_ID);

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
            get => _sqlFrom ?? "dbo.qryClassSchedule";
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
                int_CR_ID.DbValue = row["int_CR_ID"]; // Set DB value only
                int_CR_Product_ID.DbValue = row["int_CR_Product_ID"]; // Set DB value only
                int_TotSession.DbValue = row["int_TotSession"]; // Set DB value only
                str_Username.DbValue = row["str_Username"]; // Set DB value only
                int_Session_ID.DbValue = row["int_Session_ID"]; // Set DB value only
                date_Start.DbValue = row["date_Start"]; // Set DB value only
                int_Status.DbValue = row["int_Status"]; // Set DB value only
                str_Session_Date.DbValue = row["str_Session_Date"]; // Set DB value only
                Instructor.DbValue = row["Instructor"]; // Set DB value only
                Location.DbValue = row["Location"]; // Set DB value only
                str_Package_Name.DbValue = row["str_Package_Name"]; // Set DB value only
                str_Day_Name.DbValue = row["str_Day_Name"]; // Set DB value only
                str_CR_Number.DbValue = row["str_CR_Number"]; // Set DB value only
                str_CRSS_ID.DbValue = row["str_CRSS_ID"]; // Set DB value only
            } catch {}
        }

        public void DeleteUploadedFiles(Dictionary<string, object> row)
        {
            LoadDbValues(row);
        }

        // Record filter WHERE clause
        private string _sqlKeyFilter => "[int_CR_ID] = @int_CR_ID@";

        #pragma warning disable 168, 219
        // Get record filter as string
        public string GetRecordFilter(Dictionary<string, object>? row = null, bool current = false)
        {
            string keyFilter = _sqlKeyFilter;
            object? val = null, result = "";
            val = row?.TryGetValue("int_CR_ID", out result) ?? false
                ? result
                : !Empty(int_CR_ID.OldValue) && !current ? int_CR_ID.OldValue : int_CR_ID.CurrentValue;
            if (!IsNumeric(val))
                return "0=1"; // Invalid key
            if (val == null)
                return "0=1"; // Invalid key
            keyFilter = keyFilter.Replace("@int_CR_ID@", AdjustSql(val, DbId)); // Replace key value
            return keyFilter;
        }

        // Get record filter as Dictionary // DN
        public Dictionary<string, object>? GetRowFilterAsDictionary(IDictionary<string, object>? row = null)
        {
            Dictionary<string, object>? keyFilter = new ();
            object? val = null, result;
            val = row?.TryGetValue("int_CR_ID", out result) ?? false
                ? result
                : !Empty(int_CR_ID.OldValue) ? int_CR_ID.OldValue : int_CR_ID.CurrentValue;
            if (!IsNumeric(val))
                return null; // Invalid key
            if (Empty(val))
                return null; // Invalid key
            keyFilter.Add("int_CR_ID", val); // Add key value
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
                    return "QryClassScheduleList";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, "QryClassScheduleView"))
                return Language.Phrase("View");
            else if (SameString(pageName, "QryClassScheduleEdit"))
                return Language.Phrase("Edit");
            else if (SameString(pageName, "QryClassScheduleAdd"))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "QryClassScheduleList";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return action.ToLowerInvariant() switch {
                Config.ApiViewAction => "QryClassScheduleView",
                Config.ApiAddAction => "QryClassScheduleAdd",
                Config.ApiEditAction => "QryClassScheduleEdit",
                Config.ApiDeleteAction => "QryClassScheduleDelete",
                Config.ApiListAction => "QryClassScheduleList",
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
        public string ListUrl => "QryClassScheduleList";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("QryClassScheduleView", parm);
            else
                url = KeyUrl("QryClassScheduleView", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "QryClassScheduleAdd";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "QryClassScheduleAdd?" + parm;
            else
                url = "QryClassScheduleAdd";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("QryClassScheduleEdit", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("QryClassScheduleList", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("QryClassScheduleAdd", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("QryClassScheduleList", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("QryClassScheduleDelete")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
            return url;
        }

        // Get primary key as JSON
        public string KeyToJson(bool htmlEncode = false)
        {
            string json = "";
            json += "\"int_CR_ID\":" + ConvertToJson(int_CR_ID.CurrentValue, "number", true);
            json = "{" + json + "}";
            if (htmlEncode)
                json = HtmlEncode(json);
            return json;
        }

        // Add key value to URL
        public string KeyUrl(string url, string parm = "") { // DN
            if (!IsNull(int_CR_ID.CurrentValue)) {
                url += "/" + int_CR_ID.CurrentValue;
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
            val = current ? ConvertToString(int_CR_ID.CurrentValue) ?? "" : ConvertToString(int_CR_ID.OldValue) ?? "";
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
            val = row?.TryGetValue("int_CR_ID", out result) ?? false ? ConvertToString(result) : null;
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
                    int_CR_ID.CurrentValue = keys[0];
                } else {
                    int_CR_ID.OldValue = keys[0];
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
                if (RouteValues.TryGetValue("int_CR_ID", out object? v0)) { // int_CR_ID // DN
                    key = UrlDecode(v0); // DN
                } else if (IsApi() && !Empty(keyValues)) {
                    key = keyValues[0];
                } else {
                    key = Param("int_CR_ID");
                }
                keysList.Add(key);
            }
            // Check keys
            foreach (var keys in keysList) {
                if (!IsNumeric(keys)) // int_CR_ID
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
                    int_CR_ID.CurrentValue = keys;
                else
                    int_CR_ID.OldValue = keys;
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
            int_CR_ID.SetDbValue(dr["int_CR_ID"]);
            int_CR_Product_ID.SetDbValue(dr["int_CR_Product_ID"]);
            int_TotSession.SetDbValue(dr["int_TotSession"]);
            str_Username.SetDbValue(dr["str_Username"]);
            int_Session_ID.SetDbValue(dr["int_Session_ID"]);
            date_Start.SetDbValue(dr["date_Start"]);
            int_Status.SetDbValue(dr["int_Status"]);
            str_Session_Date.SetDbValue(dr["str_Session_Date"]);
            Instructor.SetDbValue(dr["Instructor"]);
            Location.SetDbValue(dr["Location"]);
            str_Package_Name.SetDbValue(dr["str_Package_Name"]);
            str_Day_Name.SetDbValue(dr["str_Day_Name"]);
            str_CR_Number.SetDbValue(dr["str_CR_Number"]);
            str_CRSS_ID.SetDbValue(dr["str_CRSS_ID"]);
        }

        // Render list content
        public async Task<string> RenderListContent(string filter)
        {
            string pageName = "QryClassScheduleList";
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

            // int_CR_ID

            // int_CR_Product_ID

            // int_TotSession

            // str_Username

            // int_Session_ID

            // date_Start

            // int_Status

            // str_Session_Date

            // Instructor

            // Location

            // str_Package_Name

            // str_Day_Name

            // str_CR_Number

            // str_CRSS_ID

            // int_CR_ID
            int_CR_ID.ViewValue = int_CR_ID.CurrentValue;
            int_CR_ID.ViewValue = FormatNumber(int_CR_ID.ViewValue, int_CR_ID.FormatPattern);
            int_CR_ID.ViewCustomAttributes = "";

            // int_CR_Product_ID
            int_CR_Product_ID.ViewValue = int_CR_Product_ID.CurrentValue;
            int_CR_Product_ID.ViewValue = FormatNumber(int_CR_Product_ID.ViewValue, int_CR_Product_ID.FormatPattern);
            int_CR_Product_ID.ViewCustomAttributes = "";

            // int_TotSession
            int_TotSession.ViewValue = int_TotSession.CurrentValue;
            int_TotSession.ViewValue = FormatNumber(int_TotSession.ViewValue, int_TotSession.FormatPattern);
            int_TotSession.ViewCustomAttributes = "";

            // str_Username
            str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
            str_Username.ViewCustomAttributes = "";

            // int_Session_ID
            int_Session_ID.ViewValue = int_Session_ID.CurrentValue;
            int_Session_ID.ViewValue = FormatNumber(int_Session_ID.ViewValue, int_Session_ID.FormatPattern);
            int_Session_ID.ViewCustomAttributes = "";

            // date_Start
            date_Start.ViewValue = date_Start.CurrentValue;
            date_Start.ViewValue = FormatDateTime(date_Start.ViewValue, date_Start.FormatPattern);
            date_Start.ViewCustomAttributes = "";

            // int_Status
            int_Status.ViewValue = int_Status.CurrentValue;
            int_Status.ViewValue = FormatNumber(int_Status.ViewValue, int_Status.FormatPattern);
            int_Status.ViewCustomAttributes = "";

            // str_Session_Date
            str_Session_Date.ViewValue = str_Session_Date.CurrentValue;
            str_Session_Date.ViewValue = FormatDateTime(str_Session_Date.ViewValue, str_Session_Date.FormatPattern);
            str_Session_Date.ViewCustomAttributes = "";

            // Instructor
            Instructor.ViewValue = ConvertToString(Instructor.CurrentValue); // DN
            Instructor.ViewCustomAttributes = "";

            // Location
            Location.ViewValue = ConvertToString(Location.CurrentValue); // DN
            Location.ViewCustomAttributes = "";

            // str_Package_Name
            str_Package_Name.ViewValue = ConvertToString(str_Package_Name.CurrentValue); // DN
            str_Package_Name.ViewCustomAttributes = "";

            // str_Day_Name
            str_Day_Name.ViewValue = ConvertToString(str_Day_Name.CurrentValue); // DN
            str_Day_Name.ViewCustomAttributes = "";

            // str_CR_Number
            str_CR_Number.ViewValue = ConvertToString(str_CR_Number.CurrentValue); // DN
            str_CR_Number.ViewCustomAttributes = "";

            // str_CRSS_ID
            str_CRSS_ID.ViewValue = ConvertToString(str_CRSS_ID.CurrentValue); // DN
            str_CRSS_ID.ViewCustomAttributes = "";

            // int_CR_ID
            int_CR_ID.HrefValue = "";
            int_CR_ID.TooltipValue = "";

            // int_CR_Product_ID
            int_CR_Product_ID.HrefValue = "";
            int_CR_Product_ID.TooltipValue = "";

            // int_TotSession
            int_TotSession.HrefValue = "";
            int_TotSession.TooltipValue = "";

            // str_Username
            str_Username.HrefValue = "";
            str_Username.TooltipValue = "";

            // int_Session_ID
            int_Session_ID.HrefValue = "";
            int_Session_ID.TooltipValue = "";

            // date_Start
            date_Start.HrefValue = "";
            date_Start.TooltipValue = "";

            // int_Status
            int_Status.HrefValue = "";
            int_Status.TooltipValue = "";

            // str_Session_Date
            str_Session_Date.HrefValue = "";
            str_Session_Date.TooltipValue = "";

            // Instructor
            Instructor.HrefValue = "";
            Instructor.TooltipValue = "";

            // Location
            Location.HrefValue = "";
            Location.TooltipValue = "";

            // str_Package_Name
            str_Package_Name.HrefValue = "";
            str_Package_Name.TooltipValue = "";

            // str_Day_Name
            str_Day_Name.HrefValue = "";
            str_Day_Name.TooltipValue = "";

            // str_CR_Number
            str_CR_Number.HrefValue = "";
            str_CR_Number.TooltipValue = "";

            // str_CRSS_ID
            str_CRSS_ID.HrefValue = "";
            str_CRSS_ID.TooltipValue = "";

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

            // int_CR_ID
            int_CR_ID.SetupEditAttributes();
            int_CR_ID.EditValue = int_CR_ID.CurrentValue; // DN
            int_CR_ID.PlaceHolder = RemoveHtml(int_CR_ID.Caption);

            // int_CR_Product_ID
            int_CR_Product_ID.SetupEditAttributes();
            int_CR_Product_ID.EditValue = int_CR_Product_ID.CurrentValue; // DN
            int_CR_Product_ID.PlaceHolder = RemoveHtml(int_CR_Product_ID.Caption);
            if (!Empty(int_CR_Product_ID.EditValue) && IsNumeric(int_CR_Product_ID.EditValue))
                int_CR_Product_ID.EditValue = FormatNumber(int_CR_Product_ID.EditValue, null);

            // int_TotSession
            int_TotSession.SetupEditAttributes();
            int_TotSession.EditValue = int_TotSession.CurrentValue; // DN
            int_TotSession.PlaceHolder = RemoveHtml(int_TotSession.Caption);
            if (!Empty(int_TotSession.EditValue) && IsNumeric(int_TotSession.EditValue))
                int_TotSession.EditValue = FormatNumber(int_TotSession.EditValue, null);

            // str_Username
            str_Username.SetupEditAttributes();
            if (!str_Username.Raw)
                str_Username.CurrentValue = HtmlDecode(str_Username.CurrentValue);
            str_Username.EditValue = HtmlEncode(str_Username.CurrentValue);
            str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);

            // int_Session_ID
            int_Session_ID.SetupEditAttributes();
            int_Session_ID.EditValue = int_Session_ID.CurrentValue; // DN
            int_Session_ID.PlaceHolder = RemoveHtml(int_Session_ID.Caption);
            if (!Empty(int_Session_ID.EditValue) && IsNumeric(int_Session_ID.EditValue))
                int_Session_ID.EditValue = FormatNumber(int_Session_ID.EditValue, null);

            // date_Start
            date_Start.SetupEditAttributes();
            date_Start.EditValue = FormatDateTime(date_Start.CurrentValue, date_Start.FormatPattern); // DN
            date_Start.PlaceHolder = RemoveHtml(date_Start.Caption);

            // int_Status
            int_Status.SetupEditAttributes();
            int_Status.EditValue = int_Status.CurrentValue; // DN
            int_Status.PlaceHolder = RemoveHtml(int_Status.Caption);
            if (!Empty(int_Status.EditValue) && IsNumeric(int_Status.EditValue))
                int_Status.EditValue = FormatNumber(int_Status.EditValue, null);

            // str_Session_Date
            str_Session_Date.SetupEditAttributes();
            str_Session_Date.EditValue = FormatDateTime(str_Session_Date.CurrentValue, str_Session_Date.FormatPattern); // DN
            str_Session_Date.PlaceHolder = RemoveHtml(str_Session_Date.Caption);

            // Instructor
            Instructor.SetupEditAttributes();
            if (!Instructor.Raw)
                Instructor.CurrentValue = HtmlDecode(Instructor.CurrentValue);
            Instructor.EditValue = HtmlEncode(Instructor.CurrentValue);
            Instructor.PlaceHolder = RemoveHtml(Instructor.Caption);

            // Location
            Location.SetupEditAttributes();
            if (!Location.Raw)
                Location.CurrentValue = HtmlDecode(Location.CurrentValue);
            Location.EditValue = HtmlEncode(Location.CurrentValue);
            Location.PlaceHolder = RemoveHtml(Location.Caption);

            // str_Package_Name
            str_Package_Name.SetupEditAttributes();
            if (!str_Package_Name.Raw)
                str_Package_Name.CurrentValue = HtmlDecode(str_Package_Name.CurrentValue);
            str_Package_Name.EditValue = HtmlEncode(str_Package_Name.CurrentValue);
            str_Package_Name.PlaceHolder = RemoveHtml(str_Package_Name.Caption);

            // str_Day_Name
            str_Day_Name.SetupEditAttributes();
            if (!str_Day_Name.Raw)
                str_Day_Name.CurrentValue = HtmlDecode(str_Day_Name.CurrentValue);
            str_Day_Name.EditValue = HtmlEncode(str_Day_Name.CurrentValue);
            str_Day_Name.PlaceHolder = RemoveHtml(str_Day_Name.Caption);

            // str_CR_Number
            str_CR_Number.SetupEditAttributes();
            if (!str_CR_Number.Raw)
                str_CR_Number.CurrentValue = HtmlDecode(str_CR_Number.CurrentValue);
            str_CR_Number.EditValue = HtmlEncode(str_CR_Number.CurrentValue);
            str_CR_Number.PlaceHolder = RemoveHtml(str_CR_Number.Caption);

            // str_CRSS_ID
            str_CRSS_ID.SetupEditAttributes();
            if (!str_CRSS_ID.Raw)
                str_CRSS_ID.CurrentValue = HtmlDecode(str_CRSS_ID.CurrentValue);
            str_CRSS_ID.EditValue = HtmlEncode(str_CRSS_ID.CurrentValue);
            str_CRSS_ID.PlaceHolder = RemoveHtml(str_CRSS_ID.Caption);

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
                        doc.ExportCaption(int_CR_ID);
                        doc.ExportCaption(int_CR_Product_ID);
                        doc.ExportCaption(int_TotSession);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(int_Session_ID);
                        doc.ExportCaption(date_Start);
                        doc.ExportCaption(int_Status);
                        doc.ExportCaption(str_Session_Date);
                        doc.ExportCaption(Instructor);
                        doc.ExportCaption(Location);
                        doc.ExportCaption(str_Package_Name);
                        doc.ExportCaption(str_Day_Name);
                        doc.ExportCaption(str_CR_Number);
                        doc.ExportCaption(str_CRSS_ID);
                    } else {
                        doc.ExportCaption(int_CR_ID);
                        doc.ExportCaption(int_CR_Product_ID);
                        doc.ExportCaption(int_TotSession);
                        doc.ExportCaption(str_Username);
                        doc.ExportCaption(int_Session_ID);
                        doc.ExportCaption(date_Start);
                        doc.ExportCaption(int_Status);
                        doc.ExportCaption(str_Session_Date);
                        doc.ExportCaption(Instructor);
                        doc.ExportCaption(Location);
                        doc.ExportCaption(str_Package_Name);
                        doc.ExportCaption(str_Day_Name);
                        doc.ExportCaption(str_CR_Number);
                        doc.ExportCaption(str_CRSS_ID);
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
                            await doc.ExportField(int_CR_ID);
                            await doc.ExportField(int_CR_Product_ID);
                            await doc.ExportField(int_TotSession);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(int_Session_ID);
                            await doc.ExportField(date_Start);
                            await doc.ExportField(int_Status);
                            await doc.ExportField(str_Session_Date);
                            await doc.ExportField(Instructor);
                            await doc.ExportField(Location);
                            await doc.ExportField(str_Package_Name);
                            await doc.ExportField(str_Day_Name);
                            await doc.ExportField(str_CR_Number);
                            await doc.ExportField(str_CRSS_ID);
                        } else {
                            await doc.ExportField(int_CR_ID);
                            await doc.ExportField(int_CR_Product_ID);
                            await doc.ExportField(int_TotSession);
                            await doc.ExportField(str_Username);
                            await doc.ExportField(int_Session_ID);
                            await doc.ExportField(date_Start);
                            await doc.ExportField(int_Status);
                            await doc.ExportField(str_Session_Date);
                            await doc.ExportField(Instructor);
                            await doc.ExportField(Location);
                            await doc.ExportField(str_Package_Name);
                            await doc.ExportField(str_Day_Name);
                            await doc.ExportField(str_CR_Number);
                            await doc.ExportField(str_CRSS_ID);
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
            get => _tableFilter ?? "[int_Status]=1 and [str_Session_Date]= Getdate() or [str_Session_Date]>Getdate()";
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
