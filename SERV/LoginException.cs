using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERV
{
    public class LoginException : Exception
    {
        public LoginResult Result;

        public LoginException(LoginResult result)
        {
            Result = result;
        }
    }
}
