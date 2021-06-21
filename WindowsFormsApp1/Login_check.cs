using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Login_check
    {
        private static string UserId = "";

        public void setUsersession(String user)
        {
            UserId = user;
        }

        public static string getUsersession()
        {
            return UserId;
        }
    }
}
