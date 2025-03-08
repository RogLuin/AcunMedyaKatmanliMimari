using Entites;

namespace Business.Abstract;

public interface IProductService
{
    void Add(Product product);
    List<Product> GetProductList();

}