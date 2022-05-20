using DoAnBanSach.Shared;

namespace DoAnBanSach.Client.Services;

public interface ICategoryService
{
    Task CreateCategory(Category category);
    public Task<List<Category>> GetCategoriesAsync();
    Task<PaginationResponse<Category>> GetCategoriesAsync(int page);
    Task RemoveCategory(int categoryId);
    Task UpdateCategory(Category category);
}
