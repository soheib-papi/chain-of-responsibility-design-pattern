using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chain_of_responsibility_design_pattern.ChainOfResponsibility
{
    public class Authenticator: Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest httpRequest)
        {
            Console.WriteLine("Authentication");
            return !(httpRequest.UserName == "admin" && httpRequest.Password == "1234");
        }
    }
}