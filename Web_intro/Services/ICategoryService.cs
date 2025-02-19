using Web_intro.DTOs.CategoryDTOs;
using Web_intro.Entities;

namespace Web_intro.Services;

public interface ICategoryService
{
    Category GetCategoryById(int id);
    List<Category> GetAll();
    void AddCategory(CategoryDto category);
    bool UpdateCategory(int id, CategoryDto category);
    bool DeleteCategory(int id);
}
