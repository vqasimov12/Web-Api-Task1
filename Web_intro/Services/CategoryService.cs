using Web_intro.DTOs.CategoryDTOs;
using Web_intro.Entities;
using Web_intro.Repositories;

namespace Web_intro.Services;

public class CategoryService(ICategoryRepository repository) : ICategoryService
{
    private readonly ICategoryRepository _repository = repository;

    public void AddCategory(CategoryDto category)
    {
        var newCategory = new Category { CategoryName = category.CategoryName, Description = category?.Description };
        _repository.AddCategory(newCategory);
    }

    public bool DeleteCategory(int id)
    {
        _repository.RemoveCategory(id);
        return true;
    }

    public List<Category> GetAll() => [.. _repository.GetAll()];

    public Category GetCategoryById(int id) => _repository.GetCategory(id);

    public bool UpdateCategory(int id, CategoryDto category)
    {
        var categoryToUpdate = _repository.GetCategory(id);
        if (categoryToUpdate == null) return false;
        categoryToUpdate.Description = category.Description;
        categoryToUpdate.CategoryName = category.CategoryName;
        _repository.UpdateCategory(categoryToUpdate);
        return true;
    }
}
