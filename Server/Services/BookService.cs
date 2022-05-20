using DoAnBanSach.Shared;
using DoAnBanSach.Server.Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DoAnBanSach.Server.Services;

public class BookService
{
    private readonly ApplicationDbContext _dataContext;
    public BookService(ApplicationDbContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<List<BookExcerpt>> GetBooks()
    {
        return await _dataContext.Books
            .Select(b => new BookExcerpt { BookId = b.BookId, ImageURL = b.ImageURL, Price = b.Price, Title = b.Title, OutOfStock = b.Amount == 0 })
            .ToListAsync();
    }

    public async Task<List<BookExcerpt>> GetBooks(FilterInfo filterInfo)
    {
        return await _dataContext.Books
            .Where(b => string.IsNullOrWhiteSpace(filterInfo.SearchString) || b.Title.Contains(filterInfo.SearchString))
            .Where(b => filterInfo.FromPrice == null || b.Price >= filterInfo.FromPrice)
            .Where(b => filterInfo.ToPrice == null || b.Price <= filterInfo.ToPrice)
            .Where(b => filterInfo.CategoryId == null || b.CategoryId == filterInfo.CategoryId)
            .Select(b => new BookExcerpt { BookId = b.BookId, ImageURL = b.ImageURL, Price = b.Price, Title = b.Title, OutOfStock = b.Amount == 0 })
            .ToListAsync();
    }

    public async Task<bool> DeleteBook(int bookId)
    {
        try
        {
            _dataContext.Books.Remove(_dataContext.Books.First(b => b.BookId == bookId));
            await _dataContext.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }

    }

    public async Task CreateBook(Book book)
    {
        _dataContext.Books.Add(book);
        await _dataContext.SaveChangesAsync();
    }

    public async Task<List<BookExcerpt>> GetBestSellers(int amount)
    {
        return await _dataContext.Books
            .OrderByDescending(b => b.ImportDateTime)
            .Select(b => new BookExcerpt { BookId = b.BookId, ImageURL = b.ImageURL, Price = b.Price, Title = b.Title, OutOfStock = b.Amount == 0 })
            .Take(amount)
            .ToListAsync();
    }

    public async Task UpdateBook(Book book)
    {
        Book dbBook = _dataContext.Books.First(b => b.BookId == book.BookId);
        foreach(PropertyInfo prop in typeof(Book).GetProperties())
        {
            prop.SetValue(dbBook, prop.GetValue(book));
        }
        await _dataContext.SaveChangesAsync();
    }

    public async Task<List<BookExcerpt>> GetNewBooks(int amount)
    {
        List<BookExcerpt> bookExcerpts = await _dataContext.Books
            .OrderByDescending(b => b.ImportDateTime)
            .Select(b => new BookExcerpt { BookId = b.BookId, ImageURL = b.ImageURL, Price = b.Price, Title = b.Title, OutOfStock = b.Amount == 0 })
            .Take(amount)
            .ToListAsync();
        return bookExcerpts;
    }

    public async Task<Book?> GetBook(int id)
    {
        return await _dataContext.Books
            .Include(b => b.Publisher)
            .Include(b => b.Author)
            .Include(b => b.Category)
            .FirstAsync(b => b.BookId == id);
    }

}
