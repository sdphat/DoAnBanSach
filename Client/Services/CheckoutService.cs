using Blazored.LocalStorage;
using DoAnBanSach.Shared;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;

namespace DoAnBanSach.Client.Services;

public class CheckoutService
{
    private readonly ILocalStorageService _localStorageService;
    private readonly IProductService _productService;
    private readonly HttpClient _httpClient;
    private readonly AuthenticationStateProvider _authenticationStateProvider;

    public Cart Cart { get; set; } = new();
    public event Action? OnChange;
    public CheckoutService(ILocalStorageService localStorageService, IProductService productService, HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider)
    {
        _localStorageService = localStorageService;
        _productService = productService;
        _httpClient = httpClient;
        _authenticationStateProvider = authenticationStateProvider;
    }

    public async Task RemoveItemAsync(int productId)
    {
        Cart.Items.Remove(Cart.Items.First(i => i.BookId == productId));
        await SaveCart();
    }

    public async Task AddAmount(int productId, int value)
    {
        int initialAmount;
        try
        {
            initialAmount = Cart.Items.First(p => p.BookId == productId).Amount;

        } catch(Exception ex)
        {
            initialAmount = 0;
        }
        await UpdateAmount(productId, initialAmount + value);
    }

    public async Task MinusAmount(int productId, int value)
    {
        int initialAmount;
        try
        {
            initialAmount = Cart.Items.First(p => p.BookId == productId).Amount;

        }
        catch (Exception ex)
        {
            initialAmount = 0;
        }
        await UpdateAmount(productId, initialAmount - value);
    }

    public async Task UpdateAmount(int productId, int newAmount)
    {
        CheckAmountResponse checkAmountResponse = await _httpClient.GetFromJsonAsync<CheckAmountResponse>($"/api/checkout/check-amount/?bookId={productId}&amount={(newAmount > 0? newAmount: 1)}");
        if(!checkAmountResponse.IsValid)
        {
            throw new Exception("Overflow");
        }
        try
        {
            Cart.Items.First(p => p.BookId == productId).Amount = checkAmountResponse.Amount;
        } catch(Exception ex)
        {
            Book book = await _productService.GetBook(productId);
            Cart.Items.Add(new CartItem { BookId = productId, Amount = newAmount, Price = book.Price, Book = checkAmountResponse.Book });
        }
        await SaveCart();
        NotifyStateChanged();
    }

    public async Task<bool> Checkout()
    {
        var auth = await _authenticationStateProvider.GetAuthenticationStateAsync();
        var user = auth.User;
        if (!user.Identity.IsAuthenticated)
        {
            return false;
        }
        await _httpClient.PostAsJsonAsync("/api/checkout", Cart);
        await ClearCart();
        NotifyStateChanged();
        return true;
    }

    public async Task SaveCart()
    {
        await _localStorageService.SetItemAsync("cart", Cart);
        NotifyStateChanged();
    }

    public async Task LoadCart()
    {
        Cart = await _localStorageService.GetItemAsync<Cart>("cart");
        if(Cart == null)
        {
            Cart = new();
            await SaveCart();
        }
    }

    public async Task ClearCart()
    {
        await _localStorageService.RemoveItemAsync("cart");
        Cart = new();
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
