namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// assessmentStatus
    /// </summary>
    [MaybeNull]
    public static AssessmentStatus assessmentStatus
    {
        get => HttpData.Resolve<AssessmentStatus>("Assessment_Status");
        set => HttpData["Assessment_Status"] = value;
    }

    /// <summary>
    /// Table class for Assessment Status
    /// </summary>
    public class AssessmentStatus : ReportTable, IQueryFactory
    {
        #pragma warning disable 414

        public bool ShowGroupHeaderAsRow = false;

        public bool ShowCompactSummaryFooter = true;
        #pragma warning restore 414

        public int RowCount = 0; // DN

        public bool UseSessionForListSql = true;

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

        public readonly ReportField<SqlDbType> str_Full_Name_Hdr;

        public readonly ReportField<SqlDbType> AssessmentID;

        public readonly ReportField<SqlDbType> str_Username;

        public readonly ReportField<SqlDbType> NationalID;

        public readonly ReportField<SqlDbType> DLType;

        public readonly ReportField<SqlDbType> AssessmentDate;

        public readonly ReportField<SqlDbType> AssessmentDone;

        public readonly ReportField<SqlDbType> AbsherApptNbr;

        public readonly ReportField<SqlDbType> AssessmentScore;

        public readonly ReportField<SqlDbType> Price;

        public readonly ReportField<SqlDbType> int_Student_ID;

        // Constructor
        public AssessmentStatus()
        {
            // Language object // DN
            Language = ResolveLanguage();
            TableVar = "Assessment_Status";
            Name = "Assessment Status";
            Type = "REPORT";
            ReportSourceTable = "dshbdAssessmentv1"; // Report source table
            ReportSourceTableName = "dshbdAssessmentv1"; // Report source table name
            TableReportType = "summary";
            DbId = "DB"; // DN
            ExportAll = true;
            ExportPageBreakCount = 0; // Page break per every n record (report only)
            ExportPageOrientation = "portrait"; // Page orientation (PDF only)
            ExportPageSize = "a4"; // Page size (PDF only)
            ExportColumnWidths = new float[] {  }; // Column widths (PDF only) // DN
            ExportExcelPageOrientation = "Portrait"; // Page orientation (EPPlus only)
            ExportExcelPageSize = "A4"; // Page size (EPPlus only)
            ExportWordPageOrientation = "Portrait"; // Page orientation (Word only)
            UserIdAllowSecurity = Config.DefaultUserIdAllowSecurity; // User ID Allow

            // str_Full_Name_Hdr
            str_Full_Name_Hdr = new (this, "x_str_Full_Name_Hdr", 202, SqlDbType.NVarChar) {
                Name = "str_Full_Name_Hdr",
                Expression = "[str_Full_Name_Hdr]",
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
                CustomMessage = Language.FieldPhrase("Assessment_Status", "str_Full_Name_Hdr", "CustomMsg"),
                SourceTableVar = "dshbdAssessmentv1",
                IsUpload = false
            };
            Fields.Add("str_Full_Name_Hdr", str_Full_Name_Hdr);

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
                IsPrimaryKey = true, // Primary key field
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("Assessment_Status", "AssessmentID", "CustomMsg"),
                SourceTableVar = "dshbdAssessmentv1",
                IsUpload = false
            };
            Fields.Add("AssessmentID", AssessmentID);

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
                HtmlTag = "TEXT",
                InputTextType = "text",
                GroupingFieldId = 1,
                ShowGroupHeaderAsRow = false,
                ShowCompactSummaryFooter = true,
                GroupByType = "",
                GroupInterval = "0",
                GroupSql = "",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Assessment_Status", "str_Username", "CustomMsg"),
                SourceTableVar = "dshbdAssessmentv1",
                IsUpload = false
            };
            Fields.Add("str_Username", str_Username);

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
                CustomMessage = Language.FieldPhrase("Assessment_Status", "NationalID", "CustomMsg"),
                SourceTableVar = "dshbdAssessmentv1",
                IsUpload = false
            };
            Fields.Add("NationalID", NationalID);

            // DL Type
            DLType = new (this, "x_DLType", 200, SqlDbType.VarChar) {
                Name = "DL Type",
                Expression = "[DL Type]",
                BasicSearchExpression = "[DL Type]",
                DateTimeFormat = -1,
                VirtualExpression = "[DL Type]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                GroupingFieldId = 2,
                ShowGroupHeaderAsRow = false,
                ShowCompactSummaryFooter = true,
                GroupByType = "",
                GroupInterval = "0",
                GroupSql = "",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY" },
                CustomMessage = Language.FieldPhrase("Assessment_Status", "DLType", "CustomMsg"),
                SourceTableVar = "dshbdAssessmentv1",
                IsUpload = false
            };
            Fields.Add("DL Type", DLType);

            // AssessmentDate
            AssessmentDate = new (this, "x_AssessmentDate", 135, SqlDbType.DateTime) {
                Name = "AssessmentDate",
                Expression = "[AssessmentDate]",
                BasicSearchExpression = CastDateFieldForLike("[AssessmentDate]", 0, "DB"),
                DateTimeFormat = 0,
                VirtualExpression = "[AssessmentDate]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                DefaultErrorMessage = ConvertToString(Language.Phrase("IncorrectDate")).Replace("%s", CurrentDateTimeFormat.ShortDatePattern),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Assessment_Status", "AssessmentDate", "CustomMsg"),
                SourceTableVar = "dshbdAssessmentv1",
                IsUpload = false
            };
            Fields.Add("AssessmentDate", AssessmentDate);

            // Assessment Done
            AssessmentDone = new (this, "x_AssessmentDone", 200, SqlDbType.VarChar) {
                Name = "Assessment Done",
                Expression = "[Assessment Done]",
                BasicSearchExpression = "[Assessment Done]",
                DateTimeFormat = -1,
                VirtualExpression = "[Assessment Done]",
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
                CustomMessage = Language.FieldPhrase("Assessment_Status", "AssessmentDone", "CustomMsg"),
                SourceTableVar = "dshbdAssessmentv1",
                IsUpload = false
            };
            Fields.Add("Assessment Done", AssessmentDone);

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
                HtmlTag = "TEXT",
                InputTextType = "text",
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY", "IS NULL", "IS NOT NULL" },
                CustomMessage = Language.FieldPhrase("Assessment_Status", "AbsherApptNbr", "CustomMsg"),
                SourceTableVar = "dshbdAssessmentv1",
                IsUpload = false
            };
            Fields.Add("AbsherApptNbr", AbsherApptNbr);

            // Assessment Score
            AssessmentScore = new (this, "x_AssessmentScore", 200, SqlDbType.VarChar) {
                Name = "Assessment Score",
                Expression = "[Assessment Score]",
                BasicSearchExpression = "[Assessment Score]",
                DateTimeFormat = -1,
                VirtualExpression = "[Assessment Score]",
                IsVirtual = false,
                ForceSelection = false,
                SelectMultiple = false,
                VirtualSearch = false,
                ViewTag = "FORMATTED TEXT",
                HtmlTag = "TEXT",
                InputTextType = "text",
                GroupingFieldId = 3,
                ShowGroupHeaderAsRow = false,
                ShowCompactSummaryFooter = true,
                GroupByType = "",
                GroupInterval = "0",
                GroupSql = "",
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "STARTS WITH", "NOT STARTS WITH", "LIKE", "NOT LIKE", "ENDS WITH", "NOT ENDS WITH", "IS EMPTY", "IS NOT EMPTY" },
                CustomMessage = Language.FieldPhrase("Assessment_Status", "AssessmentScore", "CustomMsg"),
                SourceTableVar = "dshbdAssessmentv1",
                IsUpload = false
            };
            Fields.Add("Assessment Score", AssessmentScore);

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
                CustomMessage = Language.FieldPhrase("Assessment_Status", "Price", "CustomMsg"),
                SourceTableVar = "dshbdAssessmentv1",
                IsUpload = false
            };
            Fields.Add("Price", Price);

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
                Nullable = false, // NOT NULL field
                Required = true, // Required field
                DefaultErrorMessage = Language.Phrase("IncorrectInteger"),
                SearchOperators = new () { "=", "<>", "IN", "NOT IN", "<", "<=", ">", ">=", "BETWEEN", "NOT BETWEEN" },
                CustomMessage = Language.FieldPhrase("Assessment_Status", "int_Student_ID", "CustomMsg"),
                SourceTableVar = "dshbdAssessmentv1",
                IsUpload = false
            };
            Fields.Add("int_Student_ID", int_Student_ID);

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

        // Single column sort // DN
        public void UpdateSort(ReportField fld)
        {
            if (CurrentOrder == fld.Name) {
                string sortField = fld.Expression, lastSort = fld.Sort, currentSort = "";
                if ((new[] { "ASC", "DESC", "NO" }).Contains(CurrentOrderType)) {
                    currentSort = CurrentOrderType;
                } else {
                    currentSort = lastSort;
                }
                fld.Sort = currentSort;
                string currentOrderBy = (new[] { "ASC", "DESC" }).Contains(currentSort) ? sortField + " " + currentSort : "";
                if (fld.GroupingFieldId == 0)
                    DetailOrderBy = currentOrderBy; // Save to Session
            } else {
                if (fld.GroupingFieldId == 0)
                    fld.Sort = "";
            }
        }

        // Multiple column sort // DN
        public void UpdateSort(ReportField fld, bool ctrl)
        {
            if (CurrentOrder == fld.Name) {
                string sortField = fld.Expression, lastSort = fld.Sort, currentSort = "";
                if ((new[] { "ASC", "DESC", "NO" }).Contains(CurrentOrderType)) {
                    currentSort = CurrentOrderType;
                } else {
                    currentSort = lastSort;
                }
                fld.Sort = currentSort;
                string lastOrderBy = (new[] { "ASC", "DESC" }).Contains(lastSort) ? sortField + " " + lastSort : "";
                string currentOrderBy = (new[] { "ASC", "DESC" }).Contains(currentSort) ? sortField + " " + currentSort : "";
                if (fld.GroupingFieldId == 0) {
                    if (ctrl) {
                        List<string> orderBy = !Empty(DetailOrderBy) ? DetailOrderBy.Split(new string[] { ", " }, StringSplitOptions.None).ToList() : new ();
                        if (!Empty(lastOrderBy) && orderBy.Contains(lastOrderBy)) {
                            if (Empty(currentOrderBy)) {
                                orderBy.Remove(lastOrderBy);
                            } else {
                                var index = orderBy.IndexOf(lastOrderBy);
                                orderBy[index] = currentOrderBy;
                            }
                        } else if (!Empty(currentOrderBy)) {
                            orderBy.Add(currentOrderBy);
                        }
                        DetailOrderBy = String.Join(", ", orderBy); // Save to Session
                    } else {
                        DetailOrderBy = currentOrderBy; // Save to Session
                    }
                }
            } else {
                if (fld.GroupingFieldId == 0 && !ctrl)
                    fld.Sort = "";
            }
        }

        // Get Sort SQL
        public string SortSql
        {
            get {
                string detailSortSql = DetailOrderBy; // Get ORDER BY for detail fields from session
                var groups = new List<string>();
                foreach (ReportField fld in Fields.Values) {
                    if ((new[] { "ASC", "DESC" }).Contains(fld.Sort)) {
                        string fldsql = fld.Expression;
                        if (fld.GroupingFieldId > 0) {
                            if (!Empty(fld.GroupSql))
                                groups.Add(fld.GroupSql.Replace("%s", fldsql) + " " + fld.Sort);
                            else
                                groups.Add(fldsql + " " + fld.Sort);
                        }
                    }
                }
                if (!Empty(detailSortSql))
                    groups.Add(detailSortSql);
                return String.Join(", ", groups);
            }
        }

        // Crosstab/Summary report private properties
        private string _sqlFirstGroupField = "";

        private string _sqlSelectGroup = "";

        private string _sqlOrderByGroup = "";

        public ReportField? FirstGroupField; // DN

        // First Group Field
        public string SqlFirstGroupField
        {
            get => GetSqlFirstGroupField();
            set => _sqlFirstGroupField = value;
        }

        // Get First Group Field // DN
        public string GetSqlFirstGroupField(bool alias = false)
        {
            if (!Empty(_sqlFirstGroupField))
                return _sqlFirstGroupField;
            string expr = FirstGroupField?.Expression ?? "";
            if (FirstGroupField != null && !Empty(FirstGroupField.GroupSql)) {
                expr = FirstGroupField.GroupSql.Replace("%s", FirstGroupField.Expression);
                if (alias)
                    expr += " AS " + QuotedName(FirstGroupField.GroupName, DbId);
            }
            return expr;
        }

        // Select Group
        public string SqlSelectGroup
        {
            get => !Empty(_sqlSelectGroup) ? _sqlSelectGroup : "SELECT DISTINCT " + GetSqlFirstGroupField(true) + " FROM " + SqlFrom;
            set => _sqlSelectGroup = value;
        }

        // Order By Group
        public string SqlOrderByGroup
        {
            get => !Empty(_sqlOrderByGroup) ? _sqlOrderByGroup : SqlFirstGroupField + " ASC";
            set => _sqlOrderByGroup = value;
        }

        // Summary/Simple report private properties
        private string _sqlSelectAggregate = "";

        private string _sqlAggregatePrefix = "";

        private string _sqlAggregateSuffix = "";

        private string _sqlSelectCount = "";

        // Select Aggregate
        public string SqlSelectAggregate
        {
            get => !Empty(_sqlSelectAggregate) ? _sqlSelectAggregate : "SELECT SUM([Price]) AS sum_price FROM " + SqlFrom;
            set => _sqlSelectAggregate = value;
        }

        // Aggregate Prefix
        public string SqlAggregatePrefix
        {
            get => !Empty(_sqlAggregatePrefix) ? _sqlAggregatePrefix : "";
            set => _sqlAggregatePrefix = value;
        }

        // Aggregate Suffix
        public string SqlAggregateSuffix
        {
            get => !Empty(_sqlAggregateSuffix) ? _sqlAggregateSuffix : "";
            set => _sqlAggregateSuffix = value;
        }

        // Select Count
        public string SqlSelectCount
        {
            get => !Empty(_sqlSelectCount) ? _sqlSelectCount : "SELECT COUNT(*) FROM " + SqlFrom;
            set => _sqlSelectCount = value;
        }

        #pragma warning disable 1998
        // Render for lookup
        public async Task RenderLookup()
        {
        }
        #pragma warning restore 1998

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
            get => _sqlFrom ?? "dbo.dshbdAssessmentv1";
            set => _sqlFrom = value;
        }

        // SELECT
        private string? _sqlSelect = null;

        public string SqlSelect { // Select
            get {
                if (!Empty(_sqlSelect))
                    return _sqlSelect;
                string select = "*";
                if (!Empty(str_Username.GroupSql)) {
                    string expr = str_Username.GroupSql.Replace("%s", str_Username.Expression) + " AS " + QuotedName(str_Username.GroupName, DbId);
                    select += ", " + expr;
                }
                if (!Empty(DLType.GroupSql)) {
                    string expr = DLType.GroupSql.Replace("%s", DLType.Expression) + " AS " + QuotedName(DLType.GroupName, DbId);
                    select += ", " + expr;
                }
                if (!Empty(AssessmentScore.GroupSql)) {
                    string expr = AssessmentScore.GroupSql.Replace("%s", AssessmentScore.Expression) + " AS " + QuotedName(AssessmentScore.GroupName, DbId);
                    select += ", " + expr;
                }
                return "SELECT " + select + " FROM " + SqlFrom;
            }
            set {
                _sqlSelect = value;
            }
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

        // Record filter WHERE clause
        private string _sqlKeyFilter => "[AssessmentID] = @AssessmentID@";

        #pragma warning disable 168, 219
        // Get record filter as string
        public string GetRecordFilter(Dictionary<string, object>? row = null, bool current = false)
        {
            string keyFilter = _sqlKeyFilter;
            object? val = null, result = "";
            val = row?.TryGetValue("AssessmentID", out result) ?? false
                ? result
                : !Empty(AssessmentID.OldValue) && !current ? AssessmentID.OldValue : AssessmentID.CurrentValue;
            if (!IsNumeric(val))
                return "0=1"; // Invalid key
            if (val == null)
                return "0=1"; // Invalid key
            keyFilter = keyFilter.Replace("@AssessmentID@", AdjustSql(val, DbId)); // Replace key value
            return keyFilter;
        }

        // Get record filter as Dictionary // DN
        public Dictionary<string, object>? GetRowFilterAsDictionary(IDictionary<string, object>? row = null)
        {
            Dictionary<string, object>? keyFilter = new ();
            object? val = null, result;
            val = row?.TryGetValue("AssessmentID", out result) ?? false
                ? result
                : !Empty(AssessmentID.OldValue) ? AssessmentID.OldValue : AssessmentID.CurrentValue;
            if (!IsNumeric(val))
                return null; // Invalid key
            if (Empty(val))
                return null; // Invalid key
            keyFilter.Add("AssessmentID", val); // Add key value
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
                    return "";
                }
            }
            set {
                Session[Config.ProjectName + "_" + TableVar + "_" + Config.TableReturnUrl] = value;
            }
        }

        // Get modal caption
        public string GetModalCaption(string pageName)
        {
            if (SameString(pageName, ""))
                return Language.Phrase("View");
            else if (SameString(pageName, ""))
                return Language.Phrase("Edit");
            else if (SameString(pageName, ""))
                return Language.Phrase("Add");
            else
                return "";
        }

        // Default route URL
        public string DefaultRouteUrl
        {
            get {
                return "AssessmentStatus";
            }
        }

        // API page name
        public string GetApiPageName(string action)
        {
            return "AssessmentStatus";
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
        public string ListUrl => "";

        // View URL
        public string ViewUrl => GetViewUrl();

        // View URL
        public string GetViewUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = KeyUrl("", parm);
            else
                url = KeyUrl("", Config.TableShowDetail + "=");
            return AddMasterUrl(url);
        }

        // Add URL
        public string AddUrl { get; set; } = "";

        // Add URL
        public string GetAddUrl(string parm = "")
        {
            string url = "";
            if (!Empty(parm))
                url = "?" + parm;
            else
                url = "";
            return AppPath(AddMasterUrl(url));
        }

        // Edit URL
        public string EditUrl => GetEditUrl();

        // Edit URL (with parameter)
        public string GetEditUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline edit URL
        public string InlineEditUrl =>
            AppPath(AddMasterUrl(KeyUrl("", "action=edit"))); // DN

        // Copy URL
        public string CopyUrl => GetCopyUrl();

        // Copy URL
        public string GetCopyUrl(string parm = "")
        {
            string url = "";
            url = KeyUrl("", parm);
            return AppPath(AddMasterUrl(url)); // DN
        }

        // Inline copy URL
        public string InlineCopyUrl =>
            AppPath(AddMasterUrl(KeyUrl("", "action=copy"))); // DN

        // Delete URL
        public string DeleteUrl => UseAjaxActions && Param<bool>("infinitescroll") && CurrentPageID() == "list"
            ? AppPath(KeyUrl(Config.ApiUrl + Config.ApiDeleteAction + "/" + TableVar))
            : AppPath(KeyUrl("")); // DN

        // Add master URL
        public string AddMasterUrl(string url)
        {
            return url;
        }

        // Get primary key as JSON
        public string KeyToJson(bool htmlEncode = false)
        {
            string json = "";
            json += "\"AssessmentID\":" + ConvertToJson(AssessmentID.CurrentValue, "number", true);
            json = "{" + json + "}";
            if (htmlEncode)
                json = HtmlEncode(json);
            return json;
        }

        // Add key value to URL
        public string KeyUrl(string url, string parm = "") { // DN
            if (!IsNull(AssessmentID.CurrentValue)) {
                url += "/" + AssessmentID.CurrentValue;
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
                DrillDown ||
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
            val = current ? ConvertToString(AssessmentID.CurrentValue) ?? "" : ConvertToString(AssessmentID.OldValue) ?? "";
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
            val = row?.TryGetValue("AssessmentID", out result) ?? false ? ConvertToString(result) : null;
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
                    AssessmentID.CurrentValue = keys[0];
                } else {
                    AssessmentID.OldValue = keys[0];
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
                if (RouteValues.TryGetValue("AssessmentID", out object? v0)) { // AssessmentID // DN
                    key = UrlDecode(v0); // DN
                } else if (IsApi() && !Empty(keyValues)) {
                    key = keyValues[0];
                } else {
                    key = Param("AssessmentID");
                }
                keysList.Add(key);
            }
            // Check keys
            foreach (var keys in keysList) {
                if (!IsNumeric(keys)) // AssessmentID
                    continue;
                result.Add(keys);
            }
            return result;
        }
        #pragma warning restore 168

        // Table filter
        private string? _tableFilter = null;

        public string TableFilter
        {
            get => _tableFilter ?? "";
            set => _tableFilter = value;
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
