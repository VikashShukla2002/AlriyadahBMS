using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlriyadahBMS.Services.IServices
{
    public interface IAuthenticationStateService
    {
        void NotifyUserLoggedIn(string token);
        void NotifyUserLogout();
    }
}
