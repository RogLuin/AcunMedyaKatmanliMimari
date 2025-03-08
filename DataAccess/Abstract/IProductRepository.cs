using Entites;

namespace DataAccess.Abstract;

public interface IProductRepository
{
    void Add(Product product);
    void Delete(int id);
    List<Product> GetAll();
}