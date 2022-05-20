using DoAnBanSach.Shared;
using System.Net.Http.Json;

namespace DoAnBanSach.Client.Services;

public class UserService
{
    private readonly HttpClient _httpClient;

    public UserService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<PaginationResponse<PublicUser>> GetUsers(int page)
    {
        return await _httpClient.GetFromJsonAsync<PaginationResponse<PublicUser>>($"/api/users?page={page}");
    }

    public async Task RemoveUser(int userId)
    {
        await _httpClient.DeleteAsync($"/api/users/{userId}");
    }

    public async Task UpdateUser(PublicUser user)
    {
        await _httpClient.PutAsJsonAsync("/api/users", user);
    }
}
