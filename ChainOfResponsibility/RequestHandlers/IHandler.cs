using DesignPatterns.ChainOfResponsibility.Models;

namespace DesignPatterns.ChainOfResponsibility.RequestHandlers
{
    internal interface IHandler
    {
        void Handle(Request request);
        public IHandler SetNext(IHandler next);
    }
}
