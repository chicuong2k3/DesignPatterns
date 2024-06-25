using DesignPatterns.ChainOfResponsibility.Models;

namespace DesignPatterns.ChainOfResponsibility.Repositories
{
    interface IProductRepository
    {
        List<Product> GetAll();
        void Create(Product product);
    }
    internal class ProductRepository : IProductRepository
    {
        private List<Product> products;
        public ProductRepository()
        {
            products = new List<Product>();
            products.AddRange(new List<Product>()
            {
                new Product
                {
                    Name = "Bánh xốp Nabati",
                    Price = 8000m
                },
                new Product
                {
                    Name = "Bánh bim bim Oishi",
                    Price = 10000m
                },
                new Product
                {
                    Name = "Nước tăng lực",
                    Price = 15000m
                }
            });
        }
        public void Create(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetAll()
        {
            return products;
        }
    }
}
