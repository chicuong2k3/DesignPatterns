using DesignPatterns.ChainOfResponsibility.Models;

namespace DesignPatterns.ChainOfResponsibility.RequestHandlers
{
    internal abstract class RootHandler : IHandler
    {
        private IHandler? next;
        public IHandler SetNext(IHandler next)
        {
            this.next = next;
            return next;
        }
       
        public virtual void Handle(Request request)
        {
            next?.Handle(request);
        }
    }
}
