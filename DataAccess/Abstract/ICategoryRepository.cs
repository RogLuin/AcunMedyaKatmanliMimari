using Entites;

namespace DataAccess.Abstract;

public interface ICategoryRepository
{
    void Add(Category category);
    void Delete(int id);
    List<Category> GetAll();
}