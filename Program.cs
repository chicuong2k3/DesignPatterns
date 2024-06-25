using DesignPatterns.ChainOfResponsibility.Models;
using DesignPatterns.ChainOfResponsibility.Repositories;
using DesignPatterns.ChainOfResponsibility.RequestHandlers;

namespace DesignPatterns
{
    class Program
    {
        public static void Main(string[] args)
        {
            IProductRepository productRepository = new ProductRepository(); 
            AuthenticationManager authenticationManager = new AuthenticationManager();

            IHandler handler = new AuthenticationHandler(authenticationManager);

            handler.SetNext(new RouteHandler())
                .SetNext(new ListProductsHandler(productRepository));

            authenticationManager.Login();
            handler.Handle(new Request());
        }
    }
}