

using DesignPatterns.ChainOfResponsibility.Models;
using DesignPatterns.ChainOfResponsibility.Repositories;

namespace DesignPatterns.ChainOfResponsibility.RequestHandlers
{
    internal class AuthenticationHandler : RootHandler
    {
        private readonly AuthenticationManager authenticationManager;
        public AuthenticationHandler(AuthenticationManager authenticationManager)
        {
            this.authenticationManager = authenticationManager;
        }
        public override void Handle(Request request)
        {
            Console.WriteLine("Authentication middleware is processing...");
            if (!authenticationManager.IsAuthenticated)
            {
                Console.WriteLine("Please login to perform this operation.");
                return;
            }

            base.Handle(request);
        }
    }
}
