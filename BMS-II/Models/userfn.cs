namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// Global events
    /// </summary>

    // ContentType Mapping event
    public static void ContentTypeMapping(IDictionary<string, string> mappings) {
        // Example:
        //mappings[".image"] = "image/png"; // Add new mappings
        //mappings[".rtf"] = "application/x-msdownload"; // Replace an existing mapping
        //mappings.Remove(".mp4"); // Remove MP4 videos
    }

    // Class Init event
    public static void ClassInit() {
        // Enter your code here
    }

    // Page Loading event
    public static void PageLoading() {
        // Enter your code here
    }

    // Page Rendering event
    public static void PageRendering() {
        //Log("Page Rendering");
    }

    // Page Unloaded event
    public static void PageUnloaded() {
        // Enter your code here
    }

    // Personal Data Downloading event
    public static void PersonalDataDownloading(Dictionary<string, object> row) {
        //Log("PersonalData Downloading");
    }

    // Personal Data Deleted event
    public static void PersonalDataDeleted(Dictionary<string, object> row) {
        //Log("PersonalData Deleted");
    }

    // AuditTrail Inserting event
    public static bool AuditTrailInserting(Dictionary<string, object> rsnew) {
        return true;
    }

    // Chart Rendered event
    public static void ChartRendered(ChartJsRenderer renderer) {
        // Example:
        //var data = renderer.Data;
        //var options = renderer.Options;
        //DbChart chart = renderer.Chart;
        //if (chart.ID == "<Report>_<Chart>") { // Check chart ID
        //}
    }

    // One Time Password Sending event
    public static bool OtpSending(string user, dynamic client) {
        // Example:
        // Log(user, client); // View user and client (Email or Sms object)
        // if (SameText(Config.TwoFactorAuthenticationType, "email")) { // Possible values: "email" or "sms"
        //     client.Content = ...; // Change content
        //     client.Recipient = ...; // Change recipient
        //     // return false; // Return false to cancel
        // }
        return true;
    }

    // Routes Add event
    public static void RouteAction(IEndpointRouteBuilder app) {
        // Example:
        // app.MapGet("/", () => "Hello World!");
    }

    // Services Add event
    public static void ServiceAdd(IServiceCollection services) {
        // Example:
        // services.AddSignalR();
    }

    // Container Build event
    public static void ContainerBuild(ContainerBuilder builder) {
        // Enter your code here
    }

    // App Build event
    public static void AppBuild(WebApplicationBuilder builder) {
        // Example:
        // builder.Configuration.AddAzureKeyVault(...);
    }

    // Global user code
    /// <summary>
    /// CurrentUserLevelName
    /// </summary>
    /// <returns>Name of current user level name </returns>
    public static string GetCurrentUserLevelName()
    {
        int userLevelID = Convert.ToInt32(CurrentUserLevel());
        string roleName = "Undefined";
        switch (userLevelID)
        {
            case -2:
                roleName = "Anonymous";
                break;
            case -1:
                roleName = "Administrator";
                break;
            case 0:
                roleName = "Default";
                break;
            case 1:
                roleName = "Owner";
                break;
            case 2:
                roleName = "School Manager";
                break;
            case 3:
                roleName = "Traffic Department";
                break;
            case 4:
                roleName = "Accountant";
                break;
            case 5:
                roleName = "Supervisor";
                break;
            case 6:
                roleName = "Scheduler";
                break;
            case 7:
                roleName = "Evaluator / Examiner";
                break;
            case 8:
                roleName = "Trainer / Instructor";
                break;
            case 9:
                roleName = "Receptionist";
                break;
            case 30:
                roleName = "Candidate";
                break;
        }
        return roleName;
    }

    /// <summary>
    /// ServerLogger
    /// </summary>
    public static class ServerLogger
    {
        private static readonly string LogFilePath = "server-log.txt";

        public static void Log(string message)
        {
            string logEntry = $"{DateTime.Now} - {message}";
            if (!File.Exists(LogFilePath))
            {
                File.Create(LogFilePath).Close();
            }
            File.AppendAllText(LogFilePath, logEntry + Environment.NewLine);
        }
    }

    /// <summary>
    /// https://www.jawalbsms.ws/api.php/sendsms
    /// </summary>
    public class JawalbSms
    {
        const string JAWAL_ACCOUNT = "Riyadah-DS";
        const string JAWAL_PASSWORD = "R1122Tt1122";
        const string JAWAL_SENDER = "Riyadah-DS";
        static readonly HttpClient _httpClient;
        static JawalbSms()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("https://www.jawalbsms.ws/api.php") };
        }

        public static async Task<bool> SendSmsAsync(string phoneNo, string message)
        {
            bool status = false;
            try
            {
                var queryParams = new Dictionary<string, string>{
                    { "user", JAWAL_ACCOUNT },
                    { "pass", JAWAL_PASSWORD },
                    { "to", phoneNo },
                    { "message", message },
                    { "sender", JAWAL_SENDER }
                };
                string query = string.Join("&", queryParams.Select(kvp => $"{Uri.EscapeDataString(kvp.Key)}={Uri.EscapeDataString(kvp.Value)}"));
                var uriBuilder = new UriBuilder(_httpClient.BaseAddress + "/sendsms");
                uriBuilder.Query = query;
                var httpResponse = await _httpClient.GetAsync(uriBuilder.Uri);
                if (httpResponse.IsSuccessStatusCode)
                {
                    var smsContent = await httpResponse.Content.ReadAsStringAsync();
                    if (smsContent.Contains("MSG_ID", StringComparison.CurrentCultureIgnoreCase))
                    {
                        status = true;
                    }
                    else
                    {
                        status = false;
                    }
                }
                else
                {
                    status = false;
                }
            }
            catch (Exception ex)
            {
                _ = ex;
                status = false;
            }
            return status;
        }
    }

    /// <summary>
    /// Get Sms Message For BMSII
    /// </summary>
    public static class SmsMessageFor
    {
        public static string AfterAssessmentTest(string? Name, string? Program)
        {
            if (IsValidParams(Name, Program))
                return Language.Phrase("smsafterassessmenttest").Replace($"{{{{{nameof(Name)}}}}}", Name).Replace($"{{{{{nameof(Program)}}}}}", Program);
            return "";
        }

        public static string ActivateAccountAfterPayment(string? Name, string? Username, string? Password)
        {
            if (IsValidParams(Name, Username, Password))
                return Language.Phrase("smsactivateaccountafterpayment").Replace($"{{{{{nameof(Name)}}}}}", Name).Replace($"{{{{{nameof(Username)}}}}}", Username).Replace($"{{{{{nameof(Password)}}}}}", Password);
            return "";
        }

        public static string StudentAppointmentForKTMessage(string? Name, string? KTDateTime)
        {
            if (IsValidParams(Name, KTDateTime))
                return Language.Phrase("smsstudentappointmentforktmessage").Replace($"{{{{{nameof(Name)}}}}}", Name).Replace($"{{{{{nameof(KTDateTime)}}}}}", KTDateTime);
            return "";
        }

        public static string StudentAppointmentForBTWMessage(string? Name, string? TrainDateTime)
        {
            if (IsValidParams(Name, TrainDateTime))
                return Language.Phrase("smsstudentappointmentforbtwmessage").Replace($"{{{{{nameof(Name)}}}}}", Name).Replace($"{{{{{nameof(TrainDateTime)}}}}}", TrainDateTime);
            return "";
        }

        public static string StudentAppointmentForRoadTest(string? Name)
        {
            if (IsValidParams(Name))
                return Language.Phrase("smsstudentappointmentforroadtestmessage").Replace($"{{{{{nameof(Name)}}}}}", Name);
            return "";
        }

        public static string StudentRoadTestConfirm(string? Name, string? RTDateTime)
        {
            if (IsValidParams(Name))
                return Language.Phrase("smsstudentroadtestconfirmmessage").Replace($"{{{{{nameof(Name)}}}}}", Name).Replace($"{{{{{nameof(RTDateTime)}}}}}", RTDateTime);
            return "";
        }

        public static string StudentFailingForKT(string Name)
        {
            if (IsValidParams(Name))
                return Language.Phrase("smsstudentfailingforktmessage").Replace($"{{{{{nameof(Name)}}}}}", Name);
            return "";
        }

        public static string StudentFailingForRoadTest(string Name)
        {
            if (IsValidParams(Name))
                return Language.Phrase("smsstudentfailingforroadtestmessage").Replace($"{{{{{nameof(Name)}}}}}", Name);
            return "";
        }
        static bool IsValidParams(params string?[] @params)
        {
            foreach (string? param in @params)
            {
                if (string.IsNullOrEmpty(param))
                    throw new Exception("Parameter cannot be null or empty");
            }
            return true;
        }
    }


    /// <summary>
    /// AppointmentStatus 
    /// </summary>
    public enum AppointmentStatus
    {
        Open = 8,
        Canceled = 4,
        Complete = 6,
        Confirmed = 2,
        Deleted = 5,
        NoShow = 3,
        Pending = 1,
        Web = 7
    }

} // End Partial class
