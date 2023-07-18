using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chain_of_responsibility_design_pattern.ChainOfResponsibility
{
    public class WebServer
    {
        private Handler _handler;

        public WebServer(Handler handler)
        {
            _handler = handler;
        }

        public void Handle(HttpRequest httpRequest)
        {
            _handler.Handle(httpRequest);
        }
    }
}