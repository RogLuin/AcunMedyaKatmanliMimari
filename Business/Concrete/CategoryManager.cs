using Business.Abstract;
using DataAccess.Abstract;
using Entites;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    private ICategoryRepository _repository;

    public CategoryManager(ICategoryRepository categoryRepository)
    {
        _repository = categoryRepository;
    }
    public void Add(Category category)
    {   
        _repository.Add(category);
    }

    public List<Category> GetCategoryList()
    {
        return _repository.GetAll();
    }
}