using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.Helper
{
    public static class AccountApiConst
    {
        public static string Base = "api/";

        public static string POST_SignIn = Base + "login";
    }

    public static class TableApiConst
    {
        public static string Base = "api/";
        public static string GET_TblList = Base + "Table/{table}";
        public static string POST_TblUpdate = Base + "edit/{table}/{key}";
    }

    public static class FileUploadApiConst
    {
        public static string Base = "api/";
        public static string POST_FileUpload = Base + "upload";
    }
    public static class RegisterApiConst
    {
        public static string Base = "api/";
        public static string POST_RegisterAccount = Base + "register";
    }

}
