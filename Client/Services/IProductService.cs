using DoAnBanSach.Shared;

namespace DoAnBanSach.Client.Services;

public interface IProductService
{
    Task CreateBook(Book book);
    Task<List<BookExcerpt>> GetBestSellers();
    Task<Book> GetBook(int bookId);
    public Task<PaginationResponse<BookExcerpt>> GetBooksAsync(int page);
    public Task<PaginationResponse<BookExcerpt>> GetBooksAsync(FilterInfo filterInfo, int page);
    Task<List<BookExcerpt>> GetNewBooks();
    Task RemoveBook(int bookId);
    Task UpdateBook(Book book);
}
