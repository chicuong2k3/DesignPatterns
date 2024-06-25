using DesignPatterns.ChainOfResponsibility.Models;
using DesignPatterns.ChainOfResponsibility.Repositories;

namespace DesignPatterns.ChainOfResponsibility.RequestHandlers
{
    internal class ListProductsHandler : RootHandler
    {
        private readonly IProductRepository productRepository;
        public ListProductsHandler(IProductRepository productRepository)
        {
            this.productRepository = productRepository;

        }

        public override void Handle(Request request)
        {
            Console.WriteLine("List products processing...");

            //var products = productRepository.GetAll();

            //foreach (var product in products)
            //{
            //    Console.WriteLine($"{product.Name}: {product.Price} vnd");
            //}

            base.Handle(request);
        }
    }
}
