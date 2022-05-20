using DoAnBanSach.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Json;

namespace DoAnBanSach.Client.Services;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;
    private int booksPerPage = 8;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<PaginationResponse<BookExcerpt>> GetBooksAsync(int page)
    {
        var result = await _httpClient.GetFromJsonAsync<PaginationResponse<BookExcerpt>>($"/api/books?page={page}&booksPerPage={booksPerPage}");
        return result;
    }

    public async Task<PaginationResponse<BookExcerpt>> GetBooksAsync(FilterInfo filterInfo, int page)
    {
        var result = await _httpClient.GetFromJsonAsync<PaginationResponse<BookExcerpt>>($"/api/books/filter?filterInfo={JsonConvert.SerializeObject(filterInfo)}&page={page}&booksPerPage={booksPerPage}");
        return result;
    }

    public async Task<List<BookExcerpt>> GetNewBooks()
    {
        var result = await _httpClient.GetFromJsonAsync<List<BookExcerpt>>($"/api/books/new?booksPerPage={booksPerPage}");
        return result;
    }

    public async Task<List<BookExcerpt>> GetBestSellers()
    {
        var result = await _httpClient.GetFromJsonAsync<List<BookExcerpt>>($"/api/books/bestsellers?booksPerPage={booksPerPage}");
        return result;
    }


    public async Task<Book> GetBook(int bookId)
    {
        var result = await _httpClient.GetFromJsonAsync<Book>($"/api/books/{bookId}");
        return result;
    }

    public async Task RemoveBook(int bookId)
    {
        await _httpClient.DeleteAsync($"/api/books/{bookId}");
    }

    public async Task UpdateBook(Book book)
    {
        await _httpClient.PutAsJsonAsync("/api/books", book);
    }

    public async Task CreateBook(Book book)
    {
        await _httpClient.PostAsJsonAsync("/api/books", book);
    }
}
