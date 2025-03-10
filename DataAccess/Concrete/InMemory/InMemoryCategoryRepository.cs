using DataAccess.Abstract;
using Entites;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCategoryRepository : ICategoryRepository
{
    private List<Category> _categories;

    public InMemoryCategoryRepository()
    {
        _categories = new List<Category>
        {
            new Category
            {
               Id = 1,
               Name = "Elektronics",
            },
            new Category
            {
                Id = 2,
                Name = "Fantasy",
            },
            new Category{
            Id = 3,
            Name = "Horror",
        }
        };
    }
    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Delete(int id)
    {
        Category? category = _categories.Find(c => c.Id == id);
        if (category != null)
        {
            _categories.Remove(category);
            
        }
        else
        {
            Console.WriteLine("Category not found");
        }
    }

    public List<Category> GetAll()
    {
        return _categories;
    }
}