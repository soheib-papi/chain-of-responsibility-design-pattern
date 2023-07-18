using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chain_of_responsibility_design_pattern.ChainOfResponsibility
{
    public class HttpRequest
    {
        private string _username;
        private string _password;

        public HttpRequest(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string UserName 
        { 
            get { return _username; }
        }

        public string Password 
        { 
            get { return _password; }
        }
    }
}