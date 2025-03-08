using DataAccess.Abstract;
using Entites;

namespace DataAccess.Concrete.InMemory;

public class InMemoryProductRepository : IProductRepository
{
    private List<Product> _products;

    public InMemoryProductRepository()
    {
        _products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Samsung s3",
                UnitPrice = 4000,
                Description = "Cheap Phone",
                Category = new Category
                {
                    Id = 1,
                    Name = "Electronics"
                }
            },
            new Product
            {
                Id = 2,
                Name = "Samsung s5",
                UnitPrice = 6000,
                Description = "Mid Range Phone",
                Category = new Category
                {
                    Id = 1,
                    Name = "Electronics"

                }
            },
            new Product
            {
                Id = 3,
                Name = "Samsung s7",
                UnitPrice = 7000,
                Description = "High Range Phone",
                Category = new Category
                {
                    Id = 1,
                    Name = "Electronics"
                }

            }
        };
    }


    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Delete(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            _products.Remove(product);
        }
    }

    public List<Product> GetAll()
    {
        return _products;
    }
}
   
