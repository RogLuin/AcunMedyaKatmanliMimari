using Business.Abstract;
using DataAccess.Abstract;
using Entites;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    private IProductRepository _repository;

    public ProductManager(IProductRepository productRepository)
    {
        _repository = productRepository;
    }
    

    public void Add(Product product)
    {
        if (product.UnitPrice <= 0)
        {
            throw new Exception("Unit Price must be greater than 0");
        }
        else
        {
            _repository.Add(product);
        }
    }

    public List<Product> GetProductList()
    {
        return _repository.GetAll();
    }
}