using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entites;

IProductService productService = new ProductManager(new InMemoryProductRepository());
List<Product> products = productService.GetProductList();

foreach (var product in products)
{
    Console.WriteLine(product.Name +  " " + " " + product.Description);
}
