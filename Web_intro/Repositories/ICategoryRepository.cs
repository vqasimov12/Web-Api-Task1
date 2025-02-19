using Web_intro.Entities;

namespace Web_intro.Repositories;

public interface ICategoryRepository
{
    void AddCategory(Category category);
    void RemoveCategory(int id);
    void UpdateCategory(Category category);
    Category GetCategory(int id);
    IEnumerable<Category> GetAll();
}
