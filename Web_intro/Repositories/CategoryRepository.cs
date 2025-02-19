using Web_intro.Context;
using Web_intro.Entities;

namespace Web_intro.Repositories;

public class CategoryRepository(AppDbContext appDbContext) : ICategoryRepository
{
    private readonly AppDbContext _appDbContext = appDbContext;

    public void AddCategory(Category category)
    {
        _appDbContext.Categories.Add(category);
        _appDbContext.SaveChanges();
    }

    public IEnumerable<Category> GetAll() => _appDbContext.Categories;

    public Category GetCategory(int id) => _appDbContext.Categories.FirstOrDefault(x => x.CategoryID == id)!;

    public void RemoveCategory(int id)
    {
        var category = _appDbContext.Categories.FirstOrDefault(x => x.CategoryID == id);
        if (category is null) return;
        _appDbContext.Categories.Remove(category);
        _appDbContext.SaveChanges();
    }

    public void UpdateCategory(Category category)
    {
        _appDbContext.Categories.Update(category);
        _appDbContext.SaveChanges();
    }
}
