using Entites;

namespace Business.Abstract;

public interface ICategoryService
{
    void Add(Category category);
    List<Category> GetCategoryList();
}