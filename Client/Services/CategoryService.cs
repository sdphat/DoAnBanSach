using DoAnBanSach.Shared;
using System.Net.Http.Json;

namespace DoAnBanSach.Client.Services;

public class CategoryService : ICategoryService
{
    private readonly HttpClient _httpClient;

    public CategoryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Category>> GetCategoriesAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Category>>("/api/categories");
    }

    public async Task<PaginationResponse<Category>> GetCategoriesAsync(int page)
    {
        return await _httpClient.GetFromJsonAsync<PaginationResponse<Category>>($"/api/categories/{page}");
    }

    public async Task RemoveCategory(int categoryId)
    {
        await _httpClient.DeleteAsync($"/api/categories/{categoryId}");
    }

    public async Task UpdateCategory(Category category)
    {
        await _httpClient.PutAsJsonAsync("/api/categories", category);
    }

    public async Task CreateCategory(Category category)
    {
        await _httpClient.PostAsJsonAsync("/api/categories", category);
    }
}
