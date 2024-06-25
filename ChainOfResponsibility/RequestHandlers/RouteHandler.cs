using DesignPatterns.ChainOfResponsibility.Models;

namespace DesignPatterns.ChainOfResponsibility.RequestHandlers
{
    internal class RouteHandler : RootHandler
    {
        public override void Handle(Request request)
        {
            Console.WriteLine("Route middleware is processing...");

            base.Handle(request);
        }
    }
}
