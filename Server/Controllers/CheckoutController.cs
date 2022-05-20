using DoAnBanSach.Server.Data;
using DoAnBanSach.Server.Models;
using DoAnBanSach.Server.Services;
using DoAnBanSach.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DoAnBanSach.Server.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        private readonly BookService _bookService;
        private readonly ApplicationDbContext _dbContext;

        public CheckoutController(ApplicationDbContext dbContext, BookService bookService)
        {
            _bookService = bookService;
            _dbContext = dbContext;
        }
        [HttpPost]
        public async Task<bool> Checkout()
        {
            Cart cart = await Request.ReadFromJsonAsync<Cart>();
            string customerId;
            Request.Cookies.TryGetValue("userid", out customerId);
            cart.CustomerId = customerId;
            List<CartItem> cartItems = cart.Items;
            var order = new Order { CustomerId = cart.CustomerId, EmployeeId = null, TotalPrice = cart.TotalPrice };
            var orderDetails = cartItems.Select(c => new OrderDetail { BookId = c.BookId, Price = c.Price, Amount = c.Amount, TotalPrice = c.TotalPrice }).ToList();
            order.Details = orderDetails;
            foreach(var orderDetail in order.Details)
            {
                var bookId = orderDetail.BookId;
                var book = _dbContext.Books.First(b => b.BookId == bookId);
                book.Amount -= orderDetail.Amount;
            }
            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        [HttpGet("check-amount")]
        public async Task<CheckAmountResponse> CheckAmount(int? bookId, int? amount)
        {
            if(bookId == null || amount == null)
            {
                return new CheckAmountResponse { IsValid = false };
            }
            try
            {
                Book book = await _bookService.GetBook((int) bookId);
                if(amount <= book.Amount)
                {
                    return new CheckAmountResponse { MaxAmount = book.Amount, Amount = (int) amount, IsValid = true, Book = book };
                } else
                {
                    return new CheckAmountResponse { MaxAmount = book.Amount, Amount = (int) amount, IsValid = false, Book = book };
                }
            } catch(Exception ex)
            {
                return new CheckAmountResponse { IsValid = false };
            }
        }
    }
}
