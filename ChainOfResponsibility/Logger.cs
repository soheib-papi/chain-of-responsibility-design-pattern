
namespace chain_of_responsibility_design_pattern.ChainOfResponsibility
{
    public class Logger: Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest httpRequest)
        {
            Console.WriteLine("Log");
            return false;
        }
    }
}