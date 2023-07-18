namespace chain_of_responsibility_design_pattern.ChainOfResponsibility
{
    public class Compressor: Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest httpRequest)
        {
            Console.WriteLine("Compress");
            return false;
        }
    }
}