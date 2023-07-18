
namespace chain_of_responsibility_design_pattern.ChainOfResponsibility
{
    public abstract class Handler
    {
        private Handler _next;

        public Handler(Handler next)
        {
            _next = next;
        }

        public void Handle(HttpRequest httpRequest)
        {
            if(DoHandle(httpRequest))
                return;
            
            _next?.Handle(httpRequest);
        }

        public abstract bool DoHandle(HttpRequest httpRequest);
    }
}