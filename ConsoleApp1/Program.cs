using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entites;

IProductService productService = new ProductManager(new InMemoryProductRepository());
List<Product> products = productService.GetProductList();

ICategoryService categoryService = new CategoryManager(new InMemoryCategoryRepository());
List<Category> categories = categoryService.GetCategoryList();

foreach (var product in products)
{
    Console.WriteLine(product.Name +  " " + " " + product.Description);
    
}