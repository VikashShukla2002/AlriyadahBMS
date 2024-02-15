namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// calendar1Calendar
    /// </summary>
    public static Calendar1Calendar calendar1Calendar
    {
        get => HttpData.Get<Calendar1Calendar>("calendar1Calendar")!;
        set => HttpData["calendar1Calendar"] = value;
    }

    /// <summary>
    /// Page class for Calendar1
    /// </summary>
    public class Calendar1Calendar : Calendar1CalendarBase
    {
        // Constructor
        public Calendar1Calendar(Controller controller) : base(controller)
        {
        }

        // Constructor
        public Calendar1Calendar() : base()
        {
        }

        // Page Data Rendering event
        public override void PageDataRendering(ref string header) {
        header = ("<p class=MsoNormal align=right style='text-align:right'><b><span style='font-size:12.0pt;line-height:106%;font-family:Segoe UI,sans-serif;color:#243F92'>Current User: "  + CurrentUserName() + "</span></b></p>");
        }
        // Page Data Rendered event
        public override void PageDataRendered(ref string footer) {
        if (Convert.ToInt32(CurrentUserLevel()) == 1)
                {footer = ("<p class=MsoNormal align=left style='text-align:left'><b><span style='font-size:12.0pt;line-height:106%;font-family:Segoe UI,sans-serif;color:#243F92'>Current User Role: Owner" +  "</span></b></p>");}
        if (Convert.ToInt32(CurrentUserLevel()) == 2)
                {footer = ("<p class=MsoNormal align=left style='text-align:left'><b><span style='font-size:12.0pt;line-height:106%;font-family:Segoe UI,sans-serif;color:#243F92'>Current User Role: School Manager" +  "</span></b></p>");}
        if (Convert.ToInt32(CurrentUserLevel()) == 3)
                {footer = ("<p class=MsoNormal align=left style='text-align:left'><b><span style='font-size:12.0pt;line-height:106%;font-family:Segoe UI,sans-serif;color:#243F92'>Current User Role: Traffic Department" +  "</span></b></p>");}
        if (Convert.ToInt32(CurrentUserLevel()) == 4)
               {footer = ("<p class=MsoNormal align=left style='text-align:left'><b><span style='font-size:12.0pt;line-height:106%;font-family:Segoe UI,sans-serif;color:#243F92'>Current User Role: Accountant" +  "</span></b></p>");}
        if (Convert.ToInt32(CurrentUserLevel()) == 5)
               {footer = ("<p class=MsoNormal align=left style='text-align:left'><b><span style='font-size:12.0pt;line-height:106%;font-family:Segoe UI,sans-serif;color:#243F92'>Current User Role: Supervisor" +  "</span></b></p>");}
        if (Convert.ToInt32(CurrentUserLevel()) == 6)
               {footer = ("<p class=MsoNormal align=left style='text-align:left'><b><span style='font-size:12.0pt;line-height:106%;font-family:Segoe UI,sans-serif;color:#243F92'>Current User Role: Scheduler" +  "</span></b></p>");}
        if (Convert.ToInt32(CurrentUserLevel()) == 7)
               {footer = ("<p class=MsoNormal align=left style='text-align:left'><b><span style='font-size:12.0pt;line-height:106%;font-family:Segoe UI,sans-serif;color:#243F92'>Current User Role: Evaluator / Examiner" +  "</span></b></p>");}  
        if (Convert.ToInt32(CurrentUserLevel()) == 8)
               {footer = ("<p class=MsoNormal align=left style='text-align:left'><b><span style='font-size:12.0pt;line-height:106%;font-family:Segoe UI,sans-serif;color:#243F92'>Current User Role: Trainer / Instructor" +  "</span></b></p>");}
        if (Convert.ToInt32(CurrentUserLevel()) == 9)
               {footer = ("<p class=MsoNormal align=left style='text-align:left'><b><span style='font-size:12.0pt;line-height:106%;font-family:Segoe UI,sans-serif;color:#243F92'>Current User Role: Receptionist" +  "</span></b></p>");}
        if (Convert.ToInt32(CurrentUserLevel()) == 30)
               {footer = ("<p class=MsoNormal align=left style='text-align:left'><b><span style='font-size:12.0pt;line-height:106%;font-family:Segoe UI,sans-serif;color:#243F92'>Current User Role: Candidate" +  "</span></b></p>");}
        if (Convert.ToInt32(CurrentUserLevel()) == -1)
               {footer = ("<p class=MsoNormal align=left style='text-align:left'><b><span style='font-size:12.0pt;line-height:106%;font-family:Segoe UI,sans-serif;color:#243F92'>Current User Role: Administrator" +  "</span></b></p>");}   
         }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class Calendar1CalendarBase : Calendar1
    {
        // Page ID
        public string PageID = "calendar";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "Calendar1";

        // Page object name
        public string PageObjName = "calendar1Calendar";

        // Title
        public string? Title = null; // Title for <title> tag

        // Page headings
        public string Heading = "";

        public string Subheading = "";

        public string PageHeader = "";

        public string PageFooter = "";

        // CSS
        public string ReportContainerClass = "ew-grid";

        // Token
        public string? Token = null; // DN

        public bool CheckToken = Config.CheckToken;

        // Action result // DN
        public IActionResult? ActionResult;

        // Cache // DN
        public IMemoryCache? Cache;

        // Page layout
        public bool UseLayout = true;

        // Page terminated // DN
        private bool _terminated = false;

        // Is terminated
        public bool IsTerminated => _terminated;

        // Is lookup
        public bool IsLookup => IsApi() && RouteValues.TryGetValue("controller", out object? name) && SameText(name, Config.ApiLookupAction);

        // Is AutoFill
        public bool IsAutoFill => IsLookup && SameText(Post("ajax"), "autofill");

        // Is AutoSuggest
        public bool IsAutoSuggest => IsLookup && SameText(Post("ajax"), "autosuggest");

        // Is modal lookup
        public bool IsModalLookup => IsLookup && SameText(Post("ajax"), "modal");

        // Page URL
        private string _pageUrl = "";

        // Constructor
        public Calendar1CalendarBase()
        {
            // Initialize
            TableVar = "Calendar1"; // DN
            if (!DashboardReport)
                CurrentPage = this;

            // Language object
            Language = ResolveLanguage();

            // Table object (calendar1)
            if (calendar1 == null || calendar1 is Calendar1)
                calendar1 = this;

            // Start time
            StartTime = Environment.TickCount;

            // Debug message
            LoadDebugMessage();

            // Open connection
            Conn = Connection; // DN

            // User table object (tblStudents)
            UserTable = Resolve("usertable")!;
            UserTableConn = GetConnection(UserTable.DbId);
        }

        // Page action result
        public IActionResult PageResult()
        {
            if (ActionResult != null)
                return ActionResult;
            SetupMenus();
            return Controller.View();
        }

        // Page heading
        public string PageHeading
        {
            get {
                if (!Empty(Heading))
                    return Heading;
                else if (!Empty(Caption))
                    return Caption;
                else
                    return "";
            }
        }

        // Page subheading
        public string PageSubheading
        {
            get {
                if (!Empty(Subheading))
                    return Subheading;
                return "";
            }
        }

        // Page name
        public string PageName => "Calendar1";

        // Page URL
        public string PageUrl
        {
            get {
                if (_pageUrl == "") {
                    _pageUrl = PageName + "?";
                }
                return _pageUrl;
            }
        }

        // Show Page Header
        public IHtmlContent ShowPageHeader()
        {
            string header = PageHeader;
            PageDataRendering(ref header);
            if (!Empty(header)) // Header exists, display
                return new HtmlString("<p id=\"ew-page-header\">" + header + "</p>");
            return HtmlString.Empty;
        }

        // Show Page Footer
        public IHtmlContent ShowPageFooter()
        {
            string footer = PageFooter;
            PageDataRendered(ref footer);
            if (!Empty(footer)) // Footer exists, display
                return new HtmlString("<p id=\"ew-page-footer\">" + footer + "</p>");
            return HtmlString.Empty;
        }

        // Valid post
        protected async Task<bool> ValidPost() => !CheckToken || !IsPost() || IsApi() || Antiforgery != null && HttpContext != null && await Antiforgery.IsRequestValidAsync(HttpContext);

        // Create token
        public void CreateToken()
        {
            Token ??= HttpContext != null ? Antiforgery?.GetAndStoreTokens(HttpContext).RequestToken : null;
            CurrentToken = Token ?? ""; // Save to global variable
        }

        // Constructor
        public Calendar1CalendarBase(Controller? controller = null): this() { // DN
            if (controller != null)
                Controller = controller;
        }

        /// <summary>
        /// Terminate page
        /// </summary>
        /// <param name="url">URL to rediect to</param>
        /// <returns>Page result</returns>
        public override IActionResult Terminate(string url = "") { // DN
            if (_terminated) // DN
                return new EmptyResult();

            // Page Unload event
            PageUnload();

            // Global Page Unloaded event
            PageUnloaded();
            if (!IsApi())
                PageRedirecting(ref url);

            // Gargage collection
            Collect(); // DN

            // Terminate
            _terminated = true; // DN

            // Return for API
            if (IsApi()) {
                var result = new Dictionary<string, string> { { "version", Config.ProductVersion } };
                if (!Empty(url)) // Add url
                    result.Add("url", GetUrl(url));
                foreach (var (key, value) in GetMessages()) // Add messages
                    result.Add(key, value);
                return Controller.Json(result);
            } else if (ActionResult != null) { // Check action result
                return ActionResult;
            }

            // Go to URL if specified
            if (!Empty(url)) {
                if (!Config.Debug)
                    ResponseClear();
                if (Response != null && !Response.HasStarted) {
                    SaveDebugMessage();
                    return Controller.LocalRedirect(AppPath(url));
                }
            }
            return new EmptyResult();
        }

        /// <summary>
        /// Full calendar event object fields
        /// See: https://fullcalendar.io/docs/event-object
        /// </summary>
        public Dictionary<string, string?> EventFields = new() {
            { "id", "Id" },
            { "groupId", "str_Username" },
            { "allDay", "AllDay" },
            { "start", "Start" },
            { "end", "End" },
            { "startStr", null },
            { "endStr", null },
            { "title", "Title" },
            { "url", "Url" },
            { "classNames", "ClassNames" },
            { "editable", null },
            { "startEditable", null },
            { "durationEditable", null },
            { "resourceEditable", null },
            { "display", "Display" },
            { "overlap", null },
            { "constraint", null },
            { "backgroundColor", "BackgroundColor" },
            { "borderColor", null },
            { "textColor", null },
            { "extendedProps", null },
            { "source", null },
            { "description", "Description" },
        };

        // Calendar URLs // DN
        public string EventViewUrl = "";

        public string EventAddUrl = "";

        public string EventEditUrl = "";

        public string EventCopyUrl = "";

        public string EventDeleteUrl = "";

        /// <summary>
        /// Page run
        /// </summary>
        /// <returns>Page result</returns>
        public override async Task<IActionResult> Run()
        {
            // Use layout
            if (!Empty(Param("layout")) && !Param<bool>("layout"))
                UseLayout = false;

            // User profile
            Profile = ResolveProfile();

            // Security
            Security = ResolveSecurity();
            if (TableVar != "")
                Security.LoadTablePermissions(TableVar);
            CurrentAction = Param("action"); // Set up current action

            // Global Page Loading event
            PageLoading();

            // Page Load event
            PageLoad();

            // Check token
            if (!await ValidPost())
                End(Language.Phrase("InvalidPostRequest"));

            // Check action result
            if (ActionResult != null) // Action result set by server event // DN
                return ActionResult;

            // Create token
            CreateToken();

            // Set up Breadcrumb
            SetupBreadcrumb();

            // Set up View/Add/Edit/Delete URL
            EventViewUrl = Security.CanView ? "Calendar1View" : "";
            EventAddUrl = Security.CanAdd ? "Calendar1Add" : "";
            EventEditUrl = Security.CanEdit ? "Calendar1Edit" : "";
            EventCopyUrl = Security.CanAdd ? "Calendar1Add" : "";
            EventDeleteUrl = Security.CanDelete ? "Calendar1Delete" : "";

            // Set LoginStatus, Page Rendering and Page Render
            if (!IsApi() && !IsTerminated) {
                SetupLoginStatus(); // Setup login status

                // Pass login status to client side
                SetClientVar("login", LoginStatus);

                // Global Page Rendering event
                PageRendering();

                // Page Render event
                calendar1Calendar?.PageRender();
            }
            return PageResult();
        }

        /// <summary>
        /// Get event field name
        /// </summary>
        /// <param name="id">Event id</param>
        /// <returns>Event field name</returns>
        public string GetEventFieldName(string id)
        {
            return EventFields.TryGetValue(id, out string? name) && name != null ? name : "";
        }

        /// <summary>
        /// Get events
        /// - Note: Use ISO8601 string for date fields so FullCalendar can parse (see https://fullcalendar.io/docs/date-parsing)
        /// - No UTC offset specified, parsing will depend on the default time zone 'local' (see https://fullcalendar.io/docs/timeZone)
        /// </summary>
        /// <returns>Events</returns>
        public async Task<List<Dictionary<string, object>>> GetEvents()
        {
            // Call Page Selecting event
            PageSelecting(ref Filter);

            // Set up User ID
            Filter = ApplyUserIDFilters(Filter);
            string sql = BuildSelectSql(SqlSelect, SqlWhere, "", "", "", Filter, "");
            List<Dictionary<string, object>> events = await Connection.GetRowsAsync(sql);
            Fields["Start"].FormatPattern = "yyyy-MM-dd'T'HH:mm:ss";
            Fields["End"].FormatPattern = "yyyy-MM-dd'T'HH:mm:ss";

            // Render event
            for (int i = 0; i < events.Count(); i++) {
                Dictionary<string, object>? evt = events[i];
                await LoadRowValues(evt);
                ResetAttributes();
                RowType = RowType.View;
                await RenderRow();
                events[i] = GetEvent();
            }
            return events;
        }

        #pragma warning disable 1998
        /// <summary>
        /// Load row values from record
        /// </summary>
        /// <param name="row">Record</param>
        protected async Task LoadRowValues(Dictionary<string, object>? row)
        {
            if (row == null)
                return;
            Id.SetDbValue(row["Id"]);
            _Title.SetDbValue(row["Title"]);
            Start.SetDbValue(row["Start"]);
            End.SetDbValue(row["End"]);
            AllDay.SetDbValue((ConvertToBool(row["AllDay"]) ? "1" : "0"));
            Description.SetDbValue(row["Description"]);
            _Url.SetDbValue(row["Url"]);
            ClassNames.SetDbValue(row["ClassNames"]);
            Display.SetDbValue(row["Display"]);
            BackgroundColor.SetDbValue(row["BackgroundColor"]);
            str_Username.SetDbValue(row["str_Username"]);
        }

        /// <summary>
        /// Render row
        /// </summary>
        public async Task RenderRow()
        {
            // Call Row_Rendering event
            RowRendering();

            // Id

            // Title

            // Start

            // End

            // AllDay

            // Description

            // Url

            // ClassNames

            // Display

            // BackgroundColor

            // str_Username
            if (RowType == RowType.View) {
                // Id
                Id.ViewValue = Id.CurrentValue;
                Id.ViewCustomAttributes = "";

                // Title
                _Title.ViewValue = ConvertToString(_Title.CurrentValue); // DN
                _Title.ViewCustomAttributes = "";

                // Start
                Start.ViewValue = Start.CurrentValue;
                Start.ViewValue = FormatDateTime(Start.ViewValue, Start.FormatPattern);
                Start.ViewCustomAttributes = "";

                // End
                End.ViewValue = End.CurrentValue;
                End.ViewValue = FormatDateTime(End.ViewValue, End.FormatPattern);
                End.ViewCustomAttributes = "";

                // AllDay
                if (ConvertToBool(AllDay.CurrentValue)) {
                    AllDay.ViewValue = AllDay.TagCaption(1) != "" ? AllDay.TagCaption(1) : "Yes";
                } else {
                    AllDay.ViewValue = AllDay.TagCaption(2) != "" ? AllDay.TagCaption(2) : "No";
                }
                AllDay.ViewCustomAttributes = "";

                // Description
                Description.ViewValue = Description.CurrentValue;
                Description.ViewCustomAttributes = "";

                // Url
                _Url.ViewValue = ConvertToString(_Url.CurrentValue); // DN
                _Url.ViewCustomAttributes = "";

                // ClassNames
                ClassNames.ViewValue = ConvertToString(ClassNames.CurrentValue); // DN
                ClassNames.ViewCustomAttributes = "";

                // Display
                Display.ViewValue = ConvertToString(Display.CurrentValue); // DN
                Display.ViewCustomAttributes = "";

                // BackgroundColor
                BackgroundColor.ViewValue = ConvertToString(BackgroundColor.CurrentValue); // DN
                BackgroundColor.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
                str_Username.ViewCustomAttributes = "";

                // Id
                Id.HrefValue = "";
                Id.TooltipValue = "";

                // Title
                _Title.HrefValue = "";
                _Title.TooltipValue = "";

                // Start
                Start.HrefValue = "";
                Start.TooltipValue = "";

                // End
                End.HrefValue = "";
                End.TooltipValue = "";

                // AllDay
                AllDay.HrefValue = "";
                AllDay.TooltipValue = "";

                // Description
                Description.HrefValue = "";
                Description.TooltipValue = "";

                // Url
                _Url.HrefValue = "";
                _Url.TooltipValue = "";

                // ClassNames
                ClassNames.HrefValue = "";
                ClassNames.TooltipValue = "";

                // Display
                Display.HrefValue = "";
                Display.TooltipValue = "";

                // BackgroundColor
                BackgroundColor.HrefValue = "";
                BackgroundColor.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";
                str_Username.TooltipValue = "";
            }

            // Call Row_Rendered event
            RowRendered();
        }
        #pragma warning restore 1998

        /// <summary>
        /// Get event
        /// </summary>
        /// <returns>Event data</returns>
        protected Dictionary<string, object> GetEvent()
        {
            List<string> eventListFields = new () { "Id", "Title", "Start", "End", "AllDay", "Description", "Url", "ClassNames", "Display", "BackgroundColor", "str_Username" };
            Dictionary<string, object> evt = new ();
            foreach (var (key, fld) in Fields) {
                if (fld.DataType == DataType.Blob || !eventListFields.Contains(fld.Name)) { // Skip blob fields / non list fields
                    continue;
                }
                string name = EventFields.FirstOrDefault(x => x.Value == fld.Name).Key;
                if (Empty(name))
                    name = fld.Name;
                object value = fld.IsBoolean
                    ? ConvertToBool(fld.CurrentValue)
                    : (IsNull(fld.CurrentValue) ? "" : fld.GetViewValue());
                evt.Add(name, value);
            }
            return evt;
        }

        /// <summary>
        /// Get calendar options As JSON
        /// </summary>
        /// <returns>Calendar options</returns>
        public async Task<string> GetCalendarOptions() {
            return ConvertToJson(new  {
                fullCalendarOptions = new  {
                    selectable = true,
                    direction = IsRTL ? "rtl" : "ltr",
                    locale = CurrentLanguageID,
                    eventTimeFormat = CurrentDateTimeFormat.ShortTimePattern,
                    events = await GetEvents()
                },
                updateTable = UpdateTable,
                viewUrl = EventViewUrl,
                editUrl = EventEditUrl,
                deleteUrl = EventDeleteUrl,
                addUrl = EventAddUrl,
                copyUrl = EventCopyUrl,
                eventFields = EventFields
            });
        }

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            url = Regex.Replace(url, @"\?cmd=reset(all)?$", ""); // Remove cmd=reset / cmd=resetall
            breadcrumb.Add("calendar", TableVar, url, "", TableVar, true);
            CurrentBreadcrumb = breadcrumb;
        }

        // Setup lookup options
        public async Task SetupLookupOptions(DbField fld)
        {
            if (fld.Lookup == null)
                return;
            Func<string>? lookupFilter = null;
            dynamic conn = Connection;
            if (fld.Lookup.Options.Count is int c && c == 0) {
                // Always call to Lookup.GetSql so that user can setup Lookup.Options in Lookup Selecting server event
                var sql = fld.Lookup.GetSql(false, "", lookupFilter, this);

                // Set up lookup cache
                if (!fld.HasLookupOptions && fld.UseLookupCache && !Empty(sql) && fld.Lookup.ParentFields.Count == 0 && fld.Lookup.Options.Count == 0) {
                    int totalCnt = await TryGetRecordCountAsync(sql, conn);
                    if (totalCnt > fld.LookupCacheCount) // Total count > cache count, do not cache
                        return;
                    var dict = new Dictionary<string, Dictionary<string, object>>();
                    var values = new List<object>();
                    List<Dictionary<string, object>> rs = await conn.GetRowsAsync(sql);
                    if (rs != null) {
                        for (int i = 0; i < rs.Count; i++) {
                            var row = rs[i];
                            row = fld.Lookup?.RenderViewRow(row, Resolve(fld.Lookup.LinkTable));
                            string key = row?.Values.First()?.ToString() ?? String.Empty;
                            if (!dict.ContainsKey(key) && row != null)
                                dict.Add(key, row);
                        }
                    }
                    fld.Lookup?.SetOptions(dict);
                }
            }
        }

        // Set up other options
        public void SetupOtherOptions()
        {
            // Filter button
            var item = FilterOptions.Add("savecurrentfilter");
            item.Body = "<a class=\"ew-save-filter\" data-form=\"fCalendar1srch\" data-ew-action=\"none\">" + Language.Phrase("SaveCurrentFilter") + "</a>";
            item.Visible = true;
            item = FilterOptions.Add("deletefilter");
            item.Body = "<a class=\"ew-delete-filter\" data-form=\"fCalendar1srch\" data-ew-action=\"none\">" + Language.Phrase("DeleteFilter") + "</a>";
            item.Visible = false;
            FilterOptions.UseDropDownButton = true;
            FilterOptions.UseButtonGroup = !FilterOptions.UseDropDownButton;
            FilterOptions.DropDownButtonPhrase = "Filters";

            // Add group option item
            item = FilterOptions.AddGroupOption();
            item.Body = "";
            item.Visible = false;
        }

        // Page Load event
        public virtual void PageLoad() {
            //Log("Page Load");
        }

        // Page Unload event
        public virtual void PageUnload() {
            //Log("Page Unload");
        }

        // Page Redirecting event
        public virtual void PageRedirecting(ref string url) {
            //url = newurl;
        }

        // Message Showing event
        // type = ""|"success"|"failure"|"warning"
        public virtual void MessageShowing(ref string msg, string type) {
            // Note: Do not change msg outside the following 4 cases.
            if (type == "success") {
                //msg = "your success message";
            } else if (type == "failure") {
                //msg = "your failure message";
            } else if (type == "warning") {
                //msg = "your warning message";
            } else {
                //msg = "your message";
            }
        }

        // Page Load event
        public virtual void PageRender() {
            //Log("Page Render");
        }

        // Page Data Rendering event
        public virtual void PageDataRendering(ref string header) {
            // Example:
            //header = "your header";
        }

        // Page Data Rendered event
        public virtual void PageDataRendered(ref string footer) {
            // Example:
            //footer = "your footer";
        }

        // Page Breaking event
        public void PageBreaking(ref bool brk, ref string content) {
            // Example:
            //	brk = false; // Skip page break, or
            //	content = "<div style=\"page-break-after:always;\">&nbsp;</div>"; // Modify page break content
        }

        // Page Selecting event
        public void PageSelecting(ref string filter) {
            // Enter your code here
        }
    } // End page class
} // End Partial class
