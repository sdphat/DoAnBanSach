using DoAnBanSach.Shared;
using System.Net.Http.Json;

namespace DoAnBanSach.Client.Services;

public class OrderService
{
    private readonly HttpClient _httpClient;

    public OrderService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<List<Order>> GetOrdersAsync(string customerId)
    {
        return await _httpClient.GetFromJsonAsync<List<Order>>($"/api/orders/customer/{customerId}");
    }

    public async Task<PaginationResponse<Order>> GetOrdersPagination(int page)
    {
        return await _httpClient.GetFromJsonAsync<PaginationResponse<Order>>($"/api/orders?page={page}");
    }

    public async Task<List<Order>> GetMyOrdersAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Order>>($"/api/orders/customer");
    }

    public async Task<Order> ConfirmOrder(int orderId)
    {
        var response = await _httpClient.PostAsync($"/api/orders/confirm/{orderId}", null);
        return await response.Content.ReadFromJsonAsync<Order>();
    }
}
