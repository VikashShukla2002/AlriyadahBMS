using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.Helper
{
    public static class Utility
    {
        public static string GetCurrentUserLevelName(int? userLevelID)
        {
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

    }
}
