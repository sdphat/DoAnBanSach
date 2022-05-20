using DoAnBanSach.Server.Services;
using DoAnBanSach.Shared;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace DoAnBanSach.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;
        private readonly PaginationService _paginationService;

        public BooksController(BookService bookService, PaginationService paginationService)
        {
            _bookService = bookService;
            _paginationService = paginationService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<PaginationResponse<BookExcerpt>> GetBooksAsync(int page, int booksPerPage)
        {
            return _paginationService.Paginate<BookExcerpt>(await _bookService.GetBooks(), page, booksPerPage);
        }

        [HttpDelete("{bookId:int}")]
        public async Task DeleteBookAsync(int bookId)
        {
            if (await _bookService.DeleteBook(bookId))
            {
                Response.StatusCode = (int)HttpStatusCode.OK;
            }
            else
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
        }

        [HttpPost]
        public async Task CreateBook()
        {
            try
            {
                Book book = await Request.ReadFromJsonAsync<Book>();
                await _bookService.CreateBook(book);
                Response.StatusCode = (int)HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
        }

        [HttpPut]
        public async Task UpdateBook()
        {
            try
            {
                Book book = await Request.ReadFromJsonAsync<Book>();
                await _bookService.UpdateBook(book);
                Response.StatusCode = (int)HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
        }

        [HttpGet("filter")]
        [AllowAnonymous]
        public async Task<PaginationResponse<BookExcerpt>> GetBooksFilterAsync(string filterInfo, int page, int booksPerPage)
        {
            var pagination = new PaginationResponse<BookExcerpt>();
            FilterInfo? filterInfo1;
            try
            {
                filterInfo1 = JsonConvert.DeserializeObject<FilterInfo>(filterInfo);
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int) HttpStatusCode.BadRequest;
                return null;
            }
            if(filterInfo1 == null)
            {
                pagination.Items = new();
                pagination.ItemsPerPage = booksPerPage;
                pagination.Pages = 1;
            } else
            {
                pagination = _paginationService.Paginate<BookExcerpt>(await _bookService.GetBooks(filterInfo1), page, booksPerPage);
            }
            return pagination;
        }

        [HttpGet("new")]
        public async Task<List<BookExcerpt>> GetNewBooksAsync(int booksPerPage)
        {

            return await _bookService.GetNewBooks(booksPerPage);
        }

        [HttpGet("bestsellers")]
        public async Task<List<BookExcerpt>> GetBestSellersAsync(int booksPerPage)
        {
            return await _bookService.GetBestSellers(booksPerPage);
        }

        [HttpGet("{id:int}")]
        public async Task<Book?> GetBookAsync(int id)
        {
            return await _bookService.GetBook(id);
        }
    }
}
