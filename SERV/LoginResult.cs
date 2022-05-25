using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERV
{
    public enum LoginResult
    {
        
        InvalidUsername,
        InvalidPassword,
        LoginOK,
        AlreadyLogged,
        NotLogged,
        UnknownError
    }
}
